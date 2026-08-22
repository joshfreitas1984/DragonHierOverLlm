// GhidraDecompile.java
// Ghidra headless post-script — reads the Il2CppExplorer manifest CSV and
// decompiles each listed function to a C source file.
//
// Manifest format (CSV, first line = header):
//   Address,OutputFile,Length,TypeName,MemberName
//   0x210B70,"C:\output\Ns\Class\ctor.c",0x7,SomeNamespace.SomeClass,.ctor
//
// Usage:
//   analyzeHeadless ... -postScript GhidraDecompile "<manifest_path>"
//
//@author Il2CppExplorer
//@category Analysis
//@keybinding
//@menupath
//@toolbar

import java.io.*;
import java.nio.file.*;
import java.util.*;

import ghidra.app.script.GhidraScript;
import ghidra.app.decompiler.DecompInterface;
import ghidra.app.decompiler.DecompileOptions;
import ghidra.app.decompiler.DecompileResults;
import ghidra.program.model.address.Address;
import ghidra.program.model.listing.Function;
import ghidra.util.task.ConsoleTaskMonitor;
import ghidra.program.model.symbol.SourceType;

public class GhidraDecompile extends GhidraScript {

    @Override
    public void run() throws Exception {
        String[] scriptArgs = getScriptArgs();
        if (scriptArgs == null || scriptArgs.length == 0) {
            printerr("GhidraDecompile: manifest path argument is required.");
            printerr("  Usage: -postScript GhidraDecompile \"<manifest_path>\"");
            return;
        }

        String manifestPath = scriptArgs[0].replace("\\\\", "\\");
        File manifestFile = new File(manifestPath);
        if (!manifestFile.exists()) {
            printerr("GhidraDecompile: manifest not found: " + manifestPath);
            return;
        }

        println("GhidraDecompile: reading manifest from " + manifestPath);
        List<String[]> rows = parseManifest(manifestFile);
        println("GhidraDecompile: " + rows.size() + " entries to decompile");

        long imageBase = currentProgram.getImageBase().getOffset();
        println("GhidraDecompile: image base = 0x" + Long.toHexString(imageBase).toUpperCase());

        // ── Optional rename pass: label all known FUN_ addresses with C# names ──
        // This makes cross-calls readable: FUN_1808e20f0 → BattleTeam__ctor
        if (scriptArgs.length > 1) {
            String labelsPath = scriptArgs[1].replace("\\\\", "\\");
            File labelsFile = new File(labelsPath);
            if (labelsFile.exists()) {
                println("GhidraDecompile: renaming functions from labels file...");
                List<String[]> labels = parseLabels(labelsFile);
                int renamed = 0;
                for (String[] row : labels) {
                    long rva = parseHex(row[0]);
                    if (rva == 0) continue;
                    Address addr = resolveAddress(rva, imageBase);
                    if (addr == null) continue;
                    Function func = getFunctionAt(addr);
                    if (func == null) continue; // only rename what Ghidra already found
                    try {
                        func.setName(row[1].trim(), SourceType.USER_DEFINED);
                        renamed++;
                    } catch (Exception ignored) {}
                }
                println("GhidraDecompile: renamed " + renamed + " / " + labels.size() + " functions");
            }
        }

        // ── Optional static data labels pass: name class statics pointers ──────
        // scriptArgs[2] = path to _static_labels.csv  (RVA,Label — same format as _labels.csv)
        // Applies named symbols to DAT_ data addresses so the decompiler emits
        // readable names instead of DAT_XXXXXXXX in the next decompile run.
        if (scriptArgs.length > 2) {
            String staticLabelsPath = scriptArgs[2].replace("\\\\", "\\");
            File staticLabelsFile = new File(staticLabelsPath);
            if (staticLabelsFile.exists()) {
                println("GhidraDecompile: applying static data labels from " + staticLabelsPath);
                List<String[]> staticLabels = parseLabels(staticLabelsFile);
                int labeled = 0;
                for (String[] row : staticLabels) {
                    long rva = parseHex(row[0]);
                    if (rva == 0) continue;
                    Address addr = resolveAddress(rva, imageBase);
                    if (addr == null) continue;
                    try {
                        currentProgram.getSymbolTable().createLabel(
                            addr, row[1].trim(), SourceType.USER_DEFINED);
                        labeled++;
                    } catch (Exception ignored) {}
                }
                println("GhidraDecompile: labeled " + labeled + " / " + staticLabels.size() + " static addresses");
            } else {
                println("GhidraDecompile: static labels file not found (skipping): " + staticLabelsPath);
            }
        }

        // Set up decompiler
        DecompileOptions options = new DecompileOptions();
        DecompInterface decompiler = new DecompInterface();
        decompiler.setOptions(options);
        decompiler.setSimplificationStyle("decompile");
        decompiler.openProgram(currentProgram);

        ConsoleTaskMonitor taskMonitor = new ConsoleTaskMonitor();
        int ok = 0, fail = 0;

        for (int i = 0; i < rows.size(); i++) {
            String[] row = rows.get(i);
            // row: [addrStr, outputFile, lengthStr, typeName, memberName]
            String addrStr   = row[0].trim();
            String outPath   = row[1].trim();
            String typeName  = row.length > 3 ? row[3].trim() : "";
            String memberName = row.length > 4 ? row[4].trim() : "";

            long addrInt = parseHex(addrStr);
            if (addrInt == 0) {
                writeFile(outPath, "// Skipped: address is 0\n// Type: " + typeName + "\n// Member: " + memberName + "\n");
                fail++;
                continue;
            }

            // Try imageBase + rva first, then raw address
            Address ghidraAddr = resolveAddress(addrInt, imageBase);
            if (ghidraAddr == null) {
                String msg = "// ERROR: could not resolve address " + addrStr + "\n// Type: " + typeName + "\n// Member: " + memberName + "\n";
                writeFile(outPath, msg);
                fail++;
                println("  [" + (i+1) + "/" + rows.size() + "] ADDR_ERR " + typeName + " :: " + memberName);
                continue;
            }

            // Get or create function
            Function func = getFunctionAt(ghidraAddr);
            if (func == null) {
                func = createFunction(ghidraAddr, null);
            }
            if (func == null) {
                String msg = "// ERROR: no function at " + addrStr + "\n// Type: " + typeName + "\n// Member: " + memberName + "\n";
                writeFile(outPath, msg);
                fail++;
                println("  [" + (i+1) + "/" + rows.size() + "] NO_FUNC " + typeName + " :: " + memberName);
                continue;
            }

            // Decompile
            DecompileResults result = decompiler.decompileFunction(func, 60, taskMonitor);
            if (result.decompileCompleted()) {
                String cCode = result.getDecompiledFunction().getC();
                String header = "// Type  : " + typeName + "\n" +
                                "// Member: " + memberName + "\n" +
                                "// RVA   : " + addrStr + "\n" +
                                "// ────────────────────────────────────────\n\n";
                writeFile(outPath, header + cCode);
                ok++;
                println("  [" + (i+1) + "/" + rows.size() + "] OK  " + typeName + " :: " + memberName);
            } else {
                String errMsg = result.getErrorMessage();
                if (errMsg == null) errMsg = "unknown error";
                String msg = "// Decompilation failed\n// Type: " + typeName + "\n// Member: " + memberName +
                             "\n// RVA: " + addrStr + "\n// Error: " + errMsg + "\n";
                writeFile(outPath, msg);
                fail++;
                println("  [" + (i+1) + "/" + rows.size() + "] FAIL " + typeName + " :: " + memberName + " - " + errMsg);
            }
        }

        decompiler.dispose();
        println("\nGhidraDecompile: done. OK=" + ok + " FAIL=" + fail);
    }

    // ── Helpers ───────────────────────────────────────────────────────────────

    private Address resolveAddress(long rva, long imageBase) {
        // Try absolute address (imageBase + rva)
        try {
            Address addr = currentProgram.getAddressFactory().getDefaultAddressSpace().getAddress(imageBase + rva);
            if (currentProgram.getMemory().contains(addr)) return addr;
        } catch (Exception ignored) {}

        // Fall back to raw value (file offset or already-absolute address)
        try {
            Address addr = currentProgram.getAddressFactory().getDefaultAddressSpace().getAddress(rva);
            if (currentProgram.getMemory().contains(addr)) return addr;
        } catch (Exception ignored) {}

        return null;
    }

    private static long parseHex(String s) {
        s = s.trim().replace("\"", "");
        if (s.isEmpty() || s.equals("0")) return 0;
        if (s.startsWith("0x") || s.startsWith("0X")) s = s.substring(2);
        try { return Long.parseUnsignedLong(s, 16); } catch (NumberFormatException e) { return 0; }
    }

    /**
     * Parses the manifest CSV, handling quoted OutputFile paths that may contain commas.
     * Returns list of String[] {addrStr, outputFile, lengthStr, typeName, memberName}.
     */
    private static List<String[]> parseManifest(File file) throws IOException {
        List<String[]> rows = new ArrayList<>();
        List<String> lines = Files.readAllLines(file.toPath());
        for (int i = 1; i < lines.size(); i++) {  // skip header
            String line = lines.get(i).trim();
            if (line.isEmpty()) continue;

            // Find quoted output path: Address,"path",Length,TypeName,MemberName
            int firstComma = line.indexOf(',');
            if (firstComma < 0) continue;
            String addrStr = line.substring(0, firstComma);
            String rest    = line.substring(firstComma + 1);

            String outPath, afterPath;
            if (rest.startsWith("\"")) {
                // Quoted path — find closing quote (handle "" escape inside)
                int end = 1;
                while (end < rest.length()) {
                    if (rest.charAt(end) == '"') {
                        if (end + 1 < rest.length() && rest.charAt(end + 1) == '"') {
                            end += 2; // escaped quote
                        } else {
                            break;
                        }
                    } else {
                        end++;
                    }
                }
                outPath   = rest.substring(1, end).replace("\"\"", "\"");
                afterPath = end + 1 < rest.length() ? rest.substring(end + 1) : "";
            } else {
                int nextComma = rest.indexOf(',');
                outPath   = nextComma >= 0 ? rest.substring(0, nextComma) : rest;
                afterPath = nextComma >= 0 ? rest.substring(nextComma) : "";
            }

            // afterPath starts with comma: ,Length,TypeName,MemberName
            String[] tail = afterPath.startsWith(",") ? afterPath.substring(1).split(",", 3) : new String[0];
            String lengthStr  = tail.length > 0 ? tail[0] : "0";
            String typeName   = tail.length > 1 ? tail[1] : "";
            String memberName = tail.length > 2 ? tail[2] : "";

            rows.add(new String[]{addrStr, outPath, lengthStr, typeName, memberName});
        }
        return rows;
    }

    private static void writeFile(String path, String content) throws IOException {
        File f = new File(path);
        File parent = f.getParentFile();
        if (parent != null && !parent.exists()) parent.mkdirs();
        try (FileWriter w = new FileWriter(f)) { w.write(content); }
    }

    /** Parses the labels CSV (header: RVA,Label). Returns list of {rva, label}. */
    private static List<String[]> parseLabels(File file) throws IOException {
        List<String[]> rows = new ArrayList<>();
        List<String> lines = Files.readAllLines(file.toPath());
        for (int i = 1; i < lines.size(); i++) { // skip header
            String line = lines.get(i).trim();
            if (line.isEmpty()) continue;
            int comma = line.indexOf(',');
            if (comma < 0) continue;
            rows.add(new String[]{line.substring(0, comma).trim(), line.substring(comma + 1).trim()});
        }
        return rows;
    }
}
