# GhidraDecompile.py
# ─────────────────────────────────────────────────────────────────────────────
# Ghidra headless post-script.
# Reads the manifest CSV written by Il2CppExplorer and decompiles each
# function to a C source file.
#
# Manifest format (CSV, first line = header):
#   Address,OutputFile,Length,TypeName,MemberName
#   0x210B70,"C:\output\Ns\Class\ctor.c",0x7,SomeNamespace.SomeClass,.ctor
#
# The Address column contains either the RVA or file offset (controlled by
# the --use-offset flag in Il2CppExplorer).
#
# Ghidra uses this script with:
#   analyzeHeadless ... -postScript GhidraDecompile "<manifest_path>"
# ─────────────────────────────────────────────────────────────────────────────

import os
import sys

# Ghidra API imports (available inside the Ghidra scripting environment)
from ghidra.app.decompiler import DecompInterface, DecompileOptions
from ghidra.util.task import ConsoleTaskMonitor
from ghidra.program.model.address import AddressOutOfBoundsException

# ── Helpers ───────────────────────────────────────────────────────────────────

def parse_hex(s):
    """Convert '0x1A2B' or '1A2B' to an integer; return 0 on failure."""
    s = s.strip().strip('"')
    if not s or s == '0':
        return 0
    try:
        return int(s, 16)
    except ValueError:
        return 0

def parse_manifest(path):
    """
    Parse the CSV manifest.  Returns a list of dicts with keys:
      address_str, output_file, length_str, type_name, member_name
    Skips the header row and blank lines.
    """
    rows = []
    with open(path, 'r') as f:
        lines = f.readlines()
    for line in lines[1:]:          # skip header
        line = line.rstrip('\r\n')
        if not line:
            continue
        # Handle quoted OutputFile which may contain commas
        if ',"' in line:
            first_comma = line.index(',')
            rest = line[first_comma + 1:]   # starts with "
            closing_quote = rest.index('"', 1)
            out_file = rest[1:closing_quote]
            tail = rest[closing_quote + 2:] # skip closing quote + comma
            parts = tail.split(',', 2)
            rows.append({
                'address_str': line[:first_comma],
                'output_file': out_file,
                'length_str':  parts[0] if len(parts) > 0 else '0',
                'type_name':   parts[1] if len(parts) > 1 else '',
                'member_name': parts[2] if len(parts) > 2 else '',
            })
        else:
            parts = line.split(',', 4)
            if len(parts) < 3:
                continue
            rows.append({
                'address_str': parts[0],
                'output_file': parts[1],
                'length_str':  parts[2],
                'type_name':   parts[3] if len(parts) > 3 else '',
                'member_name': parts[4] if len(parts) > 4 else '',
            })
    return rows

def ensure_dir(path):
    d = os.path.dirname(path)
    if d and not os.path.exists(d):
        os.makedirs(d)

def write_file(path, content):
    ensure_dir(path)
    with open(path, 'w') as f:
        f.write(content)

# ── Main script entry point ───────────────────────────────────────────────────

def run():
    args = getScriptArgs()
    if not args:
        print("ERROR: GhidraDecompile.py requires the manifest CSV path as a script argument.")
        print("  Usage: -postScript GhidraDecompile \"<manifest_path>\"")
        return

    manifest_path = args[0].strip('"').strip("'")
    if not os.path.exists(manifest_path):
        print("ERROR: Manifest not found: " + manifest_path)
        return

    print("GhidraDecompile: reading manifest from " + manifest_path)
    rows = parse_manifest(manifest_path)
    print("GhidraDecompile: {} entries to decompile".format(len(rows)))

    # Set up decompiler
    options = DecompileOptions()
    decompiler = DecompInterface()
    decompiler.setOptions(options)
    decompiler.setSimplificationStyle("decompile")
    decompiler.openProgram(currentProgram)

    monitor = ConsoleTaskMonitor()

    image_base = currentProgram.getImageBase().getOffset()
    print("GhidraDecompile: image base = 0x{:X}".format(image_base))

    ok_count   = 0
    fail_count = 0

    for i, row in enumerate(rows):
        addr_int    = parse_hex(row['address_str'])
        out_file    = row['output_file']
        type_name   = row['type_name']
        member_name = row['member_name']

        if addr_int == 0:
            write_file(out_file,
                "// Skipped: address is 0\n"
                "// Type  : {}\n// Member: {}\n".format(type_name, member_name))
            fail_count += 1
            continue

        # Resolve address
        # The address in the manifest may be:
        #   (a) RVA — relative to image base:  absolute = imageBase + rva
        #   (b) File offset — passed as-is to getFunctionAt (works if Ghidra
        #       is configured to load at file-offset addresses; less common).
        # We attempt imageBase+addr first; if not mapped we fall back to addr.

        flat_addr = image_base + addr_int
        try:
            ghidra_addr = toAddr(flat_addr)
        except Exception:
            ghidra_addr = None

        if ghidra_addr is None or not currentProgram.getMemory().contains(ghidra_addr):
            # Try raw addr (file offset or already-absolute address)
            try:
                ghidra_addr = toAddr(addr_int)
            except Exception:
                ghidra_addr = None

        if ghidra_addr is None:
            msg = ("// ERROR: could not resolve address {}\n"
                   "// Type  : {}\n// Member: {}\n").format(row['address_str'], type_name, member_name)
            write_file(out_file, msg)
            fail_count += 1
            print("  [{}/{}] ADDR_ERR {} :: {}".format(i + 1, len(rows), type_name, member_name))
            continue

        # Get or create the function
        func = getFunctionAt(ghidra_addr)
        if func is None:
            func = createFunction(ghidra_addr, None)

        if func is None:
            msg = ("// ERROR: could not find/create function at {}\n"
                   "// Type  : {}\n// Member: {}\n").format(row['address_str'], type_name, member_name)
            write_file(out_file, msg)
            fail_count += 1
            print("  [{}/{}] NO_FUNC {} :: {}".format(i + 1, len(rows), type_name, member_name))
            continue

        # Decompile
        result = decompiler.decompileFunction(func, 60, monitor)

        if result.decompileCompleted():
            c_code = result.getDecompiledFunction().getC()
            header = (
                "// Type  : {}\n"
                "// Member: {}\n"
                "// RVA   : {}\n"
                "// ────────────────────────────────────────\n\n"
            ).format(type_name, member_name, row['address_str'])
            write_file(out_file, header + c_code)
            ok_count += 1
            print("  [{}/{}] OK  {} :: {}".format(i + 1, len(rows), type_name, member_name))
        else:
            err_msg = result.getErrorMessage() or "unknown error"
            msg = (
                "// Decompilation failed\n"
                "// Type  : {}\n"
                "// Member: {}\n"
                "// RVA   : {}\n"
                "// Error : {}\n"
            ).format(type_name, member_name, row['address_str'], err_msg)
            write_file(out_file, msg)
            fail_count += 1
            print("  [{}/{}] FAIL {} :: {} — {}".format(i + 1, len(rows), type_name, member_name, err_msg))

    decompiler.dispose()
    print("\nGhidraDecompile: done. OK={} FAIL={}".format(ok_count, fail_count))

run()
