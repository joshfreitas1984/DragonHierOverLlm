"""Report which game methods tagged [GameCoupled ...] in DragonHeirPlugin changed in the decompile.

Each tag in the plugin source looks like:

    // [GameCoupled HeroData.GetRecordLog replaces] mirrors the original loop; re-sync on change
    // [GameCoupled ExploreController logic] relies on the embedded *DataBase list fields

`Class.Method` compares that method's decompiled body (all overloads); a bare `Class` compares the
class's member signature lines (fields + method signatures). Bodies come from Converter/output,
which is tracked in git, so the comparison is working tree vs a git revision (default HEAD) -
run it after re-decompiling but before committing Converter/output.

Ghidra noise (FUN_/DAT_/LAB_ addresses, Token/RVA comments) is normalized away, but a "changed"
result is still only a prompt to re-read the method, never proof the patch broke. "missing" (the
method/class no longer exists) is the most urgent result.

Usage (from repo root):
    python Scripts/check_game_coupled_patches.py [--rev HEAD] [--diff]
"""

import argparse
import difflib
import re
import subprocess
import sys
from pathlib import Path

REPO = Path(__file__).resolve().parent.parent
PLUGIN_DIR = REPO / "DragonHeirPlugin"
OUTPUT_DIR = REPO / "Converter" / "output"

TAG_RE = re.compile(r"//\s*\[GameCoupled\s+([A-Za-z_][\w]*)(?:\.([A-Za-z_][\w]*))?\s+(replaces|by-name|logic|ui-path)\]\s*(.*)")
NOISE_RE = re.compile(r"\b(FUN|DAT|LAB|PTR|thunk_FUN|switchD|caseD)_[0-9a-fA-F_]+\b")
MEMBER_START_RE = re.compile(r"^    // Token\s*:")


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


def normalize(lines):
    out = []
    for line in lines:
        s = line.strip()
        if not s or s.startswith("// Token") or s.startswith("// RVA"):
            continue
        out.append(NOISE_RE.sub("X", s))
    return out


def method_body(text, method):
    sig_re = re.compile(rf"^    \S.*\b{re.escape(method)}\s*\(")
    body = []
    for chunk in split_members(text):
        if any(sig_re.match(l) for l in chunk[:4]):
            body.extend(normalize(chunk))
    return body or None


def class_signatures(text):
    return [NOISE_RE.sub("X", l.strip()) for l in text.splitlines()
            if re.match(r"^    [a-z]", l) and not l.strip().startswith("//")]


def extract(text, method):
    if text is None:
        return None
    return method_body(text, method) if method else class_signatures(text)


def main():
    ap = argparse.ArgumentParser()
    ap.add_argument("--rev", default="HEAD", help="git revision holding the pre-update decompile")
    ap.add_argument("--diff", action="store_true", help="print a unified diff for each changed target")
    args = ap.parse_args()

    tags = find_tags()
    if not tags:
        print("No [GameCoupled ...] tags found.")
        return 0

    status_order = {"missing": 0, "changed": 1, "new": 2, "unchanged": 3}
    results = []
    cache = {}
    for tag in tags:
        target = f"{tag['cls']}.{tag['method']}" if tag["method"] else tag["cls"]
        if target not in cache:
            class_file = find_class_file(tag["cls"])
            if class_file is None:
                cache[target] = ("missing", None, None)
            else:
                rel = class_file.relative_to(REPO).as_posix()
                new = extract(class_file.read_text(encoding="utf-8", errors="replace"), tag["method"])
                old = extract(read_at_rev(rel, args.rev), tag["method"])
                if new is None:
                    status = "missing"
                elif old is None:
                    status = "new"
                else:
                    status = "unchanged" if old == new else "changed"
                cache[target] = (status, old, new)
        results.append((cache[target][0], target, tag))

    results.sort(key=lambda r: (status_order[r[0]], r[1]))
    counts = {}
    for status, target, tag in results:
        counts[status] = counts.get(status, 0) + 1
        print(f"{status.upper():9} {target:45} {tag['kind']:8} {tag['file']}:{tag['line']}  {tag['reason']}")
        if args.diff and status == "changed":
            _, old, new = cache[target]
            for d in difflib.unified_diff(old, new, f"{target}@{args.rev}", f"{target}@worktree", lineterm="", n=1):
                print("    " + d)

    print()
    print(f"{len(results)} tag(s): " + ", ".join(f"{k}={v}" for k, v in sorted(counts.items(), key=lambda kv: status_order[kv[0]])))
    return 1 if counts.get("missing") or counts.get("changed") else 0


if __name__ == "__main__":
    sys.exit(main())
