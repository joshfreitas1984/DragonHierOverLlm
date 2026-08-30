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

> **Workflow rule:** Only update a sub-project's scoped instructions file, `KNOWN_ISSUES.md`, or
> `docs/` topic files when the user explicitly asks for documentation to be updated (e.g. "update
> the instructions", "document this"). Do NOT update these automatically after completing a fix or
> feature, even a significant one — confirm with the user first. When the user does ask for a
> write-back, follow the batching guidance below rather than rewriting incrementally.
>
> **Batching (when a documentation update IS requested):** during a multi-step task, jot only
> short scratch notes into session memory (`/memories/session/...`) as you go — don't rewrite the
> instructions/`KNOWN_ISSUES.md` file after every individual fix. Do ONE consolidated write-back at
> the end of the task (or when the user says they're done), not N incremental ones — each
> incremental rewrite re-reads and re-emits the whole surrounding section, which burns far more
> tokens than a single end-of-task write.
>
> **Reverse-engineering rule:** Whenever you investigate/reverse-engineer how existing code works
> (tracing a log line back to its source, figuring out why a heuristic fires, mapping a runtime
> behavior back to the responsible function, etc.), keep short scratch notes in session memory as
> you go so the findings aren't lost mid-task — but only promote them into the instructions/
> `KNOWN_ISSUES.md`/`docs/` files if the user explicitly asks for documentation to be updated (see
> the Workflow rule above). Keep entries concise and reference exact file/method names so a future
> session can jump straight to the relevant code. Put short-lived narrative/investigation writeups
> in the sub-project's `KNOWN_ISSUES.md` (or a topic file under its `docs/`), not the auto-loaded
> instructions file itself — the instructions file should only ever contain current-state
> rules/pointers, never "how we found this" narrative.
>
> **Verification harnesses:** when you need a throwaway program to verify logic in isolation
> (e.g. reproducing a regex/string-processing bug against real data outside the game), do NOT
> create a new temporary project that gets deleted afterward, and do NOT add this kind of
> ad-hoc reproduction to the main `Tests/` project. Instead, use (or create once, if it doesn't
> exist yet) a persistent, separate verification project — e.g. `Verify/Verify.csproj` at the repo
> root — kept around across sessions so a reproduction is preserved and re-runnable instead of
> being thrown away or mixed into the real test suite. Only fall back to a true one-off throwaway
> project if the logic genuinely cannot be exercised from that verification project (e.g. it
> depends on IL2CPP/Harmony/game-runtime types unavailable outside the running game).

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

