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
>
> **Reverse-engineering rule:** Whenever you investigate/reverse-engineer how existing code works
> (tracing a log line back to its source, figuring out why a heuristic fires, mapping a runtime
> behavior back to the responsible function, etc.), write down what you learned in the relevant
> scoped instructions file (or the target sub-project's own `.github/copilot-instructions.md` if
> the code lives in the sibling `FanslationStudio.LlmKit` repo — see below) before finishing the
> task, even if the user didn't explicitly ask for documentation. Findings that only exist in chat
> history are lost for future sessions; findings written into the instructions files persist. Keep
> entries concise and reference exact file/method names so a future session can jump straight to
> the relevant code.

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
