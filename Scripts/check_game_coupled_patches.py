"""Report which game methods tagged [GameCoupled ...] in DragonHeirPlugin changed between decompiles.

Each tag in the plugin source looks like:

    // [GameCoupled HeroData.GetRecordLog replaces] mirrors the original loop; re-sync on change
    // [GameCoupled ExploreController by-name] "Awake" by string; dumps the *DataBase list fields

`Class.Method` checks that method (all overloads); a bare `Class` checks the class's member
declarations (fields + method signatures). Both sides come from Converter/output, which is tracked
in git: the working tree is compared against a git revision holding the PRE-update decompile
(default HEAD - pass an older --rev if the new decompile is already committed).

Statuses, most urgent first:
  MISSING    the class/method no longer exists in the new decompile.
  CHANGED    IL2CPP metadata changed: a signature, or a method's native code Length (from the
             "// RVA ... Length:" line). This is Ghidra-independent, so it is a real game change.
  TEXT-ONLY  same signatures and native Length, but the decompiled body text differs. Usually
             Ghidra drift between runs (fields resolved as raw offsets, renamed labels), rarely a
             real change - skim with --diff if the patch is a `replaces`.
  NEW        the target did not exist at --rev.
  UNCHANGED  nothing differs.

CHANGED is a prompt to re-read the method and the patch, never proof the patch broke.

Usage (from repo root):
    python Scripts/check_game_coupled_patches.py [--rev HEAD] [--diff]
"""

import argparse
import difflib
import re
import subprocess
import sys
from collections import Counter
from pathlib import Path

REPO = Path(__file__).resolve().parent.parent
PLUGIN_DIR = REPO / "DragonHeirPlugin"
OUTPUT_DIR = REPO / "Converter" / "output"

TAG_RE = re.compile(r"//\s*\[GameCoupled\s+([A-Za-z_]\w*)(?:\.([A-Za-z_]\w*))?\s+(replaces|by-name|logic|ui-path)\]\s*(.*)")
MEMBER_START_RE = re.compile(r"^    // Token\s*:")
LENGTH_RE = re.compile(r"^    // RVA\b.*Length:\s*(0x[0-9A-Fa-f]+)")
DECL_RE = re.compile(r"^    [a-z]")
NOISE_RE = re.compile(r"\b(FUN|DAT|LAB|PTR|thunk_FUN|switchD|caseD|joined_r0x|pStatics)_?[0-9a-fA-F_]*\b")

STRING_RE = re.compile(r'"(?:[^"\\]|\\.)*"')
CALL_RE = re.compile(r"\b([A-Z]\w*\.[A-Za-z_]\w*)\s*\(")

STATUS_ORDER = ["missing", "changed", "text-only", "new", "unchanged"]


def semantic_delta(old_body, new_body):
    """String literals and Class.Method calls added/removed - the Ghidra-stable part of a body.

    An empty delta on a CHANGED method usually means codegen churn (static-field access or field
    offsets moved), not a logic change."""
    # Ghidra shows the same constructor call either way between runs.
    ctor = lambda body: re.sub(r"\bnew (\w+)\(", r"\1.ctor(", "\n".join(body))
    old_text, new_text = ctor(old_body), ctor(new_body)
    lines = []
    for label, rx in (("strings", STRING_RE), ("calls", CALL_RE)):
        before, after = Counter(rx.findall(old_text)), Counter(rx.findall(new_text))
        added, removed = sorted((after - before).elements()), sorted((before - after).elements())
        if added:
            lines.append(f"+{label}: {', '.join(dict.fromkeys(added))}")
        if removed:
            lines.append(f"-{label}: {', '.join(dict.fromkeys(removed))}")
    return lines


def find_tags():
    tags = []
    for path in sorted(PLUGIN_DIR.glob("*.cs")):
        for lineno, line in enumerate(path.read_text(encoding="utf-8").splitlines(), 1):
            m = TAG_RE.search(line)
            if m:
                cls, method, kind, reason = m.groups()
                tags.append({"file": path.name, "line": lineno, "cls": cls, "method": method,
                             "kind": kind, "reason": reason.strip()})
    return tags


def find_class_file(cls):
    matches = list(OUTPUT_DIR.glob(f"*/{cls}.cs"))
    return matches[0] if matches else None


def read_at_rev(rel_path, rev):
    result = subprocess.run(["git", "show", f"{rev}:{rel_path}"], cwd=REPO,
                            capture_output=True, text=True, encoding="utf-8", errors="replace")
    return result.stdout if result.returncode == 0 else None


def split_members(text):
    """Split a decompiled class file into member chunks, each starting at a '// Token :' line."""
    chunks, current = [], []
    for line in text.splitlines():
        if MEMBER_START_RE.match(line) and current:
            chunks.append(current)
            current = []
        current.append(line)
    if current:
        chunks.append(current)
    return chunks


def extract(text, method):
    """Return (metadata, body) for a method (all overloads) or a whole class, or None if absent.

    metadata = signature lines + native code lengths (Ghidra-independent); body = normalized
    decompiled text (Ghidra-dependent)."""
    if text is None:
        return None
    if method is None:
        decls = [l.strip() for l in text.splitlines() if DECL_RE.match(l)]
        return decls, decls
    sig_re = re.compile(rf"^    \S.*\b{re.escape(method)}\s*\(")
    meta, body = [], []
    for chunk in split_members(text):
        sig = next((l for l in chunk[:4] if sig_re.match(l)), None)
        if sig is None:
            continue
        length = next((m.group(1) for l in chunk[:3] if (m := LENGTH_RE.match(l))), "?")
        meta.append(f"{sig.strip()}  [Length {length}]")
        body.extend(NOISE_RE.sub("X", l.strip()) for l in chunk
                    if l.strip() and not l.strip().startswith(("// Token", "// RVA")))
    return (meta, body) if meta else None


def compare(tag, rev):
    class_file = find_class_file(tag["cls"])
    if class_file is None:
        return "missing", None, None
    rel = class_file.relative_to(REPO).as_posix()
    new = extract(class_file.read_text(encoding="utf-8", errors="replace"), tag["method"])
    old = extract(read_at_rev(rel, rev), tag["method"])
    if new is None:
        return "missing", old, new
    if old is None:
        return "new", old, new
    if old[0] != new[0]:
        return "changed", old, new
    if old[1] != new[1]:
        return "text-only", old, new
    return "unchanged", old, new


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--rev", default="HEAD", help="git revision holding the pre-update decompile")
    ap.add_argument("--diff", action="store_true", help="print a diff for each changed/text-only target")
    args = ap.parse_args()

    tags = find_tags()
    if not tags:
        print("No [GameCoupled ...] tags found.")
        return 0

    cache, results = {}, []
    for tag in tags:
        target = f"{tag['cls']}.{tag['method']}" if tag["method"] else tag["cls"]
        if target not in cache:
            cache[target] = compare(tag, args.rev)
        results.append((cache[target][0], target, tag))

    results.sort(key=lambda r: (STATUS_ORDER.index(r[0]), r[1]))
    counts = {}
    for status, target, tag in results:
        counts[status] = counts.get(status, 0) + 1
        print(f"{status.upper():9} {target:52} {tag['kind']:8} {tag['file']}:{tag['line']}  {tag['reason']}")
        if status == "changed" and tag["method"]:
            _, old, new = cache[target]
            delta = semantic_delta(old[1], new[1])
            for d in delta or ["(no string/call changes - likely codegen churn)"]:
                print(f"          {d}")
        if args.diff and status in ("changed", "text-only"):
            _, old, new = cache[target]
            which = 0 if status == "changed" else 1
            for d in difflib.unified_diff(old[which], new[which], f"{target}@{args.rev}", f"{target}@worktree",
                                          lineterm="", n=1):
                print("    " + d)

    print()
    print(f"{len(results)} tag(s): " + ", ".join(f"{s}={counts[s]}" for s in STATUS_ORDER if s in counts))
    return 1 if counts.get("missing") or counts.get("changed") else 0


if __name__ == "__main__":
    sys.exit(main())
