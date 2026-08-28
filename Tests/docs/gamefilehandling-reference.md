# `GameFileHandling` reference

`Tests/GameFileHandling.cs` is intentionally kept focused on workflow code. The detailed rationale for its configuration and hooks is recorded here.

## Shared splitter configuration

`CompoundFieldSplitter` remains game-agnostic. This game opts into `#...#` placeholder recognition through `SplitterOptions`, including the `$`-prefixed forms `#$PlayerName#`, `#$SourceInteractName#`, and `#$TargetInteractName#`. Placeholders are absorbed into adjacent translatable fragments so an LLM may move them; `RepairKnownLlmQuirks` restores common wrapper corruption and `ValidateGameSpecificColumn` rejects dropped tokens. The LLM repair is literal insertion rather than regex replacement because valid replacement tokens can contain `$`.

CSV parsing and reconstruction must always use `CompoundFieldSplitter.ParseCsvRow` and `RebuildCsvRow`. `ExportGameSpecificTextAssetsToCustomFormat` decomposes each non-skipped cell into fragments and a `FieldTemplate`; trivial whole-cell values use a plain split. `PackageFinalTranslationAsync` reconstructs templated cells positionally and leaves skipped columns byte-for-byte from the raw row.

## Column safety policy

`TextFilesToSplit` is the authoritative translation/package configuration. `SkipColumns` is for non-user-facing values or values used as exact runtime lookup/routing keys. It protects resource paths, categories, effect labels, relationship and skill names, force references, tags, and other structured values whose translation would break `GameDataController` lookups or silently lose data. The current per-file list reflects investigations indexed in [KNOWN_ISSUES.md](../KNOWN_ISSUES.md), especially:

- [skipcolumns-stringtospeadddata-family.md](skipcolumns-stringtospeadddata-family.md)
- [kungfudata-stringtoattriratio-fatal.md](kungfudata-stringtoattriratio-fatal.md)
- [spehero-relationship-and-skillfocus-crashes.md](spehero-relationship-and-skillfocus-crashes.md)

`PlotData.csv` column 9 is intentionally translated. Its `|` and `;` delimiters are structural, so `RepairGameSpecificColumn` strips those characters from translated choice text and `ValidateGameSpecificColumn` checks delimiter counts as a backstop. See [plotdata-column9-crash-and-repair-pattern.md](plotdata-column9-crash-and-repair-pattern.md).

## Prefab text and dynamic-string sources

`dumpedPrefabText.txt` and `dumpedPrefabTextFromOtherFields.txt` are flat, exact-match `PrefabText` inputs. The first comes from primary `m_Text`/`text` fields; the second comes from the explicitly sampled allowlist in `DynamicStringOtherTextFields`. They are packaged by `PrefabTextWorkflow` and consumed by the plugin's setter-level exact lookup. The asset-dumper and field-selection rationale is in [assetdumper-libcpp2il-and-noise-filtering.md](assetdumper-libcpp2il-and-noise-filtering.md) and [prefabtext-pipeline-architecture.md](prefabtext-pipeline-architecture.md).

`dynamicStrings.txt` and `dynamicStringsFromColumns.txt` are flat `DynamicStringsIL2CPP` inputs used for substring replacement. `DynamicStringColumnSources` extracts whole phrases from selected CSV columns; `DynamicStringLabelColumnSources` extracts repeated labels from structured `Label<number>`/`Label+number` cells without translating the source columns. The IL2CPP source refreshes `_dynamicStrings_candidates.txt` from the current string map on every workflow run and safely no-ops when the converter output is unavailable. See [dynamicstrings-pipeline-architecture.md](dynamicstrings-pipeline-architecture.md) and [dynamicstrings-extraction-sources.md](dynamicstrings-extraction-sources.md).

`ExtractDynamicStringCandidatesFromOtherText`, `ExtractDynamicStringCandidatesFromColumns`, and `ExtractDynamicStringCandidatesFromIl2CppStringMap` are idempotent: they deduplicate against the master dump and their previous output. The first reads YAML entries as dictionaries because the dumped-entry record has no parameterless constructor.

## Packaging behavior

`PackageFinalTranslationAsync` sends PrefabText and DynamicStringsIL2CPP files through their dedicated workflows, then reconstructs only regular CSV files. A fragment is unsafe when it is flagged, not safe to translate, or has a missing result despite non-empty source text; the complete raw line is retained in that case. The reported counts include all dedicated-workflow entries and regular CSV rows.

## Workflow ordering

The numbered facts in `FileInputWorkflowTests` are manual pipeline steps. Run the asset-dumper before the PrefabText extraction when new prefab text is needed; run CSV and IL2CPP candidate extraction before their corresponding exports. Export/merge steps are deliberately left to the operator because they mutate accumulated translation state. Packaging is safe to rerun from `Files/Converted`.
