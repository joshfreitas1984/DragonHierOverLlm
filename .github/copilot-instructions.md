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
> primary source of truth for future sessions. **Batch this**: during a multi-step task, jot only
> short scratch notes into session memory (`/memories/session/...`) as you go — don't rewrite the
> instructions/`KNOWN_ISSUES.md` file after every individual fix. Do ONE consolidated write-back at
> the end of the task (or when the user says they're done), not N incremental ones — each
> incremental rewrite re-reads and re-emits the whole surrounding section, which burns far more
> tokens than a single end-of-task write.
>
> **Reverse-engineering rule:** Whenever you investigate/reverse-engineer how existing code works
> (tracing a log line back to its source, figuring out why a heuristic fires, mapping a runtime
> behavior back to the responsible function, etc.), write down what you learned before finishing
> the task, even if the user didn't explicitly ask for documentation — but same batching rule
> applies: accumulate in session memory first, write the real file once at the end. Findings that
> only exist in chat history are lost for future sessions; findings written into the instructions
> files persist. Keep entries concise and reference exact file/method names so a future session can
> jump straight to the relevant code. Put short-lived narrative/investigation writeups in the
> sub-project's `KNOWN_ISSUES.md` (or a topic file under its `docs/`), not the auto-loaded
> instructions file itself — the instructions file should only ever contain current-state
> rules/pointers, never "how we found this" narrative.

> **Comment and documentation size rule:** Avoid large comments, inline essays, and verbose
> explanations in auto-loaded instruction files or source files. Put detailed rationale,
> investigation notes, and longer guidance in an appropriate `docs/` file, then add a short
> reference or pointer where it is needed. This keeps detailed context lazy-loadable and avoids
> unnecessary token usage.

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

Each sub-project's `KNOWN_ISSUES.md` (`Converter/`, `DragonHeirPlugin/`, `Tests/`) is a short
**index only** — full investigation narratives live one-per-topic under that project's `docs/`
folder (e.g. `Tests/docs/`, `DragonHeirPlugin/docs/`, `Converter/docs/`). Read the specific topic
doc linked from the index, not the whole index or every doc in the folder.

