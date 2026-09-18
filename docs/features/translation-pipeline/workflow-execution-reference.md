# Translation workflow execution reference

This document describes how to operate the DragonHier translation workflow safely. The detailed
CSV, DynamicStrings, PrefabText, and packaging behavior lives in the neighboring feature references
under this directory.

## Project ownership

- `Translate/` contains reusable game-specific extraction, configuration, translation, and
  packaging code.
- `Tests/` contains numbered xUnit facts that execute workflow steps and pure regression tests.
- `Files/` is the working directory consumed by the workflow and runtime plugin.
- `Verify/` is the persistent harness for isolated reproductions.

The shared `FanslationStudio.LlmKit` project owns the generic translation data model, compound-field
split/rebuild behavior, translation service, and quality-review implementation. This repository
should use its extension points rather than duplicating generic behavior.

## Numbered facts are operational steps

The xUnit facts in `Tests/` are not a conventional batch regression suite. Many facts mutate real
working-directory state, call a live LLM, or regenerate files. Run one numbered fact at a time,
only when advancing the actual translation workflow.

Do not run these steps automatically after code changes, especially:

- raw-copy and export/merge steps that regenerate or overwrite accumulated translation inputs;
- translation or quality-review steps that call a live model;
- cleanup or reset steps that change flags and review state.

Pure regression tests that exercise static utilities without touching `Files/` are appropriate for
normal code validation. Use `Verify/` for a persistent reproduction that does not belong in the main
suite. Do not create a temporary verification project and delete it afterward.

## Working-directory state

- `Files/Raw/Dumped/` contains source dumps from the game and plugin.
- `Files/Raw/Export/` contains freshly generated YAML and is disposable/regenerable.
- `Files/Converted/` contains the accumulated translation state. Do not delete or regenerate it
  casually; this is the state that matters across translation passes.
- `Files/Mod/` contains generated packaged files ready for the plugin or release archive.
- `Files/Config.yaml`, glossary files, and manual translations are project inputs. Changes to them
  can affect later translation and QC passes.

Packaging can be validated independently when it only rebuilds `Files/Mod/` from existing converted
state. Export, merge, translation, and reset operations require deliberate workflow intent because
they can change or discard accumulated state.

## Safe implementation boundaries

- Keep game-specific hooks, file lists, placeholder patterns, extraction sources, and packaging
  overrides in `Translate/`.
- Keep workflow entry points and numbered execution facts in `Tests/`.
- Route CSV rows and compound cells through `CompoundFieldSplitter`; do not parse rows with string
  splitting or reconstruct them with naive joins.
- Use `SkipColumns` only for fields that must never be translated. For translatable fields with
  structural delimiters, use a narrowly scoped repair and validator hook.
- When changing fragment decomposition, assert the resulting template and fragment list directly.
- Keep QC opt-in, respect per-file QC settings, and use the current QC reset/triage facts rather
  than manually editing review state.

See:

- [`gamefilehandling-reference.md`](gamefilehandling-reference.md)
- [`dynamicstrings-pipeline-architecture.md`](dynamicstrings-pipeline-architecture.md)
- [`prefabtext-pipeline-architecture.md`](prefabtext-pipeline-architecture.md)
- [`../../KNOWN_ISSUES.md`](../../KNOWN_ISSUES.md)
- [`../../README.md`](../../README.md)
