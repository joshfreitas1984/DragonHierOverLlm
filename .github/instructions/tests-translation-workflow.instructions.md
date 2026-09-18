---
applyTo: "{Translate,Tests}/**"
---

# Translate and Tests Instructions

`Translate/` contains reusable game-specific extraction, translation, packaging, and configuration
code. `Tests/` contains numbered xUnit workflow facts and pure regression tests. The project uses
the sibling `FanslationStudio.LlmKit` by project reference; shared Line/Split/Template and
compound-field behavior belongs there.

Keep this file short and operational. Use the root [`docs/README.md`](../../docs/README.md) hub and
[`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md) index to find detailed feature references and
investigations.

## Workflow safety

- `Tests/` facts are a manually-run, state-mutating translation workflow, not a normal batch test
  suite. Do not run the workflow facts or call a live LLM unless the user explicitly asks.
- Never run export/merge facts on your own initiative. They can overwrite or regenerate working
  translation state under `Files/Raw`, `Files/Converted`, and `Files/Mod`.
- Keep numbered workflow execution in `Tests/`; do not move test-runner facts into `Translate/`.
- Use pure xUnit tests for regression coverage that does not touch `Files/`. Use the persistent
  `Verify/` project for isolated reproductions; do not create throwaway harnesses.
- Treat `Files/Raw/Export` as regenerable, `Files/Converted` as accumulated translation state,
  and `Files/Mod` as generated packaging output.

See [`docs/features/translation-pipeline/workflow-execution-reference.md`](../../docs/features/translation-pipeline/workflow-execution-reference.md)
for the full workflow policy and working-directory effects.

## Translation invariants

- Route CSV parsing and reconstruction through `CompoundFieldSplitter`; never use naive
  `line.Split(',')` or `string.Join(',', ...)`.
- Preserve `SkipColumns` semantics: skipped columns are never decomposed or translated and pass
  through unchanged. Use narrowly scoped repair/validator hooks for translatable fields that also
  contain structural delimiters.
- Keep game-specific placeholder patterns in `GameFileHandling.SplitterOptions`; do not hardcode
  game rules into the shared splitter.
- Preserve structural tokens, signed numbers, percentages, and compound-field boundaries. When
  changing decomposition, add a targeted assertion for `Template` and `Fragments`, not only a
  round-trip assertion.
- Keep game-specific extraction and packaging behavior in `Translate/`; generic parsing and data
  model changes belong in the sibling `FanslationStudio.LlmKit` repository.

Feature references:

- [`gamefilehandling-reference.md`](../../docs/features/translation-pipeline/gamefilehandling-reference.md)
- [`dynamicstrings-pipeline-architecture.md`](../../docs/features/translation-pipeline/dynamicstrings-pipeline-architecture.md)
- [`prefabtext-pipeline-architecture.md`](../../docs/features/translation-pipeline/prefabtext-pipeline-architecture.md)

## Quality review

Quality review is opt-in and stateful. Keep QC separate from ordinary translation, respect
`qualityReview.enabled` and per-file settings, and use the current numbered QC facts in
`Tests/QualityControlWorkflowTests.cs`. Shared QC mechanics live in the sibling
`FanslationStudio.LlmKit` document:
[`quality-review-pass.md`](../../../../FanslationStudio.LlmKit/docs/features/translation-pipeline/quality-review-pass.md).
The local QC investigation is indexed from [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md).
