# DragonHierOverLlm — Documentation Hub

This is the canonical navigation entry point for the repository. It exists so that a human or an
AI agent (Copilot, Claude Code, or otherwise) can find the right source of truth without relying on
vendor-specific memory.

## Repository overview

DragonHierOverLlm builds an English fan-translation patch for the IL2CPP Unity game *Legend of Dragon Heir* (Long Yin Li Zhi Zhuan), plus the tooling used to reverse-engineer the game and drive
LLM-based translation. The sub-projects are independent and are documented separately:

| Project | Purpose |
| --- | --- |
| [`Converter/`](../Converter/) | Decompiles the game's IL2CPP `Assembly-CSharp.dll` + `GameAssembly.dll` into readable pseudo-C# via Ghidra, for reverse-engineering game data structures. |
| [`DragonHeirPlugin/`](../DragonHeirPlugin/) | BepInEx runtime plugin (Harmony patches) that injects translated text into the running game via IL2CPP interop. |
| [`Tests/`](../Tests/) | Translation pipeline: extracts game CSV/TextAsset data, drives the LLM translation workflow (built on `FanslationStudio.LlmKit`), and repackages translated data for the plugin/mod. |
| [`Verify/`](../Verify/) | Persistent, re-runnable verification harness project for isolating and reproducing logic bugs (regex/string-processing, etc.) outside the running game or main test suite. |
| [`Files/`](../Files/) | Working-directory data: raw extracted game text, glossary, manual translations, converted/translated output, and the mod drop-in folder consumed by `DragonHeirPlugin`. |

## Documentation taxonomy

Each project's documentation is split into three tiers, from "always loaded" to "read on demand":

1. **Scoped instructions** (`.github/instructions/*.instructions.md`) — auto-injected into agent
   context on every matching-path edit. Kept short: current-state rules, safety invariants, build/
   run commands. Never contains investigation narratives.
2. **`KNOWN_ISSUES.md`** (per project root) — an index only, not auto-loaded. One line per known
   issue/investigation, linking to the full writeup.
3. **`docs/*.md`** (per project) — one topic file per investigation, bug, or reference document.
   Read only the specific file relevant to the current task, not the whole folder.

Project-level `README.md` files (e.g. [`Converter/README.md`](../Converter/README.md)) describe
how to run/build that project, separate from the bug-history documentation above.

## Source-of-truth rules

- The auto-loaded instructions file for a project is the current-state source of truth for rules
  and invariants in that project. If a `docs/*.md` topic file disagrees with the instructions file,
  the instructions file wins for current behavior — the topic file may still hold accurate
  historical narrative.
- `KNOWN_ISSUES.md` files are indexes only; never treat them as the full explanation of an issue.
- Repository-scoped Copilot memories (`/memories/repo/`) are short-lived working notes, not
  canonical documentation. Durable technical facts belong in this repository's `docs/` folders, not
  only in memory.
- Do not update instructions files, `KNOWN_ISSUES.md`, or `docs/` topic files as a side effect of a
  fix unless explicitly asked to update documentation.

## Scoped instructions and issue indexes

| Project | Instructions (auto-loaded) | Issue index |
| --- | --- | --- |
| Converter | [`.github/instructions/converter.instructions.md`](../.github/instructions/converter.instructions.md) | [`Converter/KNOWN_ISSUES.md`](../Converter/KNOWN_ISSUES.md) |
| DragonHeirPlugin | [`.github/instructions/dragonheirplugin.instructions.md`](../.github/instructions/dragonheirplugin.instructions.md) | [`DragonHeirPlugin/KNOWN_ISSUES.md`](../DragonHeirPlugin/KNOWN_ISSUES.md) |
| Tests | [`.github/instructions/tests-translation-workflow.instructions.md`](../.github/instructions/tests-translation-workflow.instructions.md) | [`Tests/KNOWN_ISSUES.md`](../Tests/KNOWN_ISSUES.md) |

Verify and Files have no scoped instructions or issue index yet — Verify is a plain reproduction
harness, and Files is a working data directory (see [`Tests/KNOWN_ISSUES.md`](../Tests/KNOWN_ISSUES.md)
for the `Files/` layout conventions used by the translation workflow).

The root [`.github/copilot-instructions.md`](../.github/copilot-instructions.md) is the top-level
entry point that links to all of the above and states the repository-wide workflow rules
(documentation write-back policy, verification harness policy, comment size rule).

[`AGENTS.md`](../AGENTS.md) restates the same repository-wide rules in a vendor-neutral form for
non-Copilot agents (e.g. Claude Code); [`CLAUDE.md`](../CLAUDE.md) is a thin pointer to it. Keep
all three in sync if a repository-wide rule changes.

## Where should I look?

| Task | Start here |
| --- | --- |
| Run the IL2CPP decompiler / regenerate pseudo-C# output | [`.github/instructions/converter.instructions.md`](../.github/instructions/converter.instructions.md), [`Converter/README.md`](../Converter/README.md) |
| Debug a decompiler bug or missing/mislabeled output | [`Converter/KNOWN_ISSUES.md`](../Converter/KNOWN_ISSUES.md) |
| Fix or extend a Harmony patch in the running game plugin | [`.github/instructions/dragonheirplugin.instructions.md`](../.github/instructions/dragonheirplugin.instructions.md) |
| Investigate a game crash caused by translated/patched data | [`DragonHeirPlugin/KNOWN_ISSUES.md`](../DragonHeirPlugin/KNOWN_ISSUES.md) |
| Work on the CSV/TextAsset extraction → LLM translation → repackaging pipeline | [`.github/instructions/tests-translation-workflow.instructions.md`](../.github/instructions/tests-translation-workflow.instructions.md) |
| Debug a data-loss or crash bug in `GameFileHandling`/`LoadAllGameData` | [`Tests/KNOWN_ISSUES.md`](../Tests/KNOWN_ISSUES.md) |
| Reproduce/isolate a logic bug outside the running game | [`Verify/`](../Verify/) (see the workflow rule in [`.github/copilot-instructions.md`](../.github/copilot-instructions.md)) |
| Understand the `Files/` raw/converted/mod data layout | [`Tests/docs/gamefilehandling-reference.md`](../Tests/docs/gamefilehandling-reference.md) |
| Install/play the released patch | [`readme.md`](../readme.md) |
