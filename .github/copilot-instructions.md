# DragonHierOverLlm — Repo Instructions

This repository contains multiple independent sub-projects. Scoped instructions live under
`.github/instructions/` and apply automatically based on file path:

- `.github/instructions/converter.instructions.md` (`applyTo: Converter/**`) — Il2CppExplorer run
  instructions, flags, output layout, and decompiler post-processing passes for the `Converter`
  project.
- `.github/instructions/dragonheirplugin.instructions.md` (`applyTo: DragonHeirPlugin/**`) —
  IL2CPP interop safety notes for the `DragonHeirPlugin` BepInEx plugin.
- `.github/instructions/tests-translation-workflow.instructions.md` (`applyTo: Tests/**`) — how
  the `Tests/` project's numbered workflow facts drive the game translation pipeline (built on the
  shared `FanslationStudio.LlmKit` library), the `Files/` working-directory layout, and the CSV
  compound-field conventions used by `GameFileHandling.cs`.

> **Workflow rule:** After completing any significant feature or fix in a sub-project, update its
> scoped instructions file (and that sub-project's own `README.md` if present) — these are the
> primary source of truth for future sessions.

## Quick reference

See `.github/instructions/converter.instructions.md` for full Converter run commands, flags,
output layout, and decompiler post-processing passes.

See `.github/instructions/dragonheirplugin.instructions.md` for DragonHeirPlugin IL2CPP interop
safety notes.

See `.github/instructions/tests-translation-workflow.instructions.md` for the translation
workflow pipeline, `Files/` layout, and CSV/compound-field conventions. Note the shared
`FanslationStudio.LlmKit` sibling repo (referenced via project reference, not NuGet) also has its
own `.github/copilot-instructions.md` covering the Line/Split/Template data model and
`CompoundFieldSplitter` rules.
