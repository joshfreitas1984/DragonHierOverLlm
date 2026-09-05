# DynamicStringsIL2CPP pipeline architecture (`dynamicStrings*.txt` -> `Files/Mod/dynamicStrings*.txt.yaml`)

This document describes the current numbered workflow for hardcoded, runtime-assembled string
fragments compiled into IL2CPP game code. It is the detailed reference behind the short pointer
in `tests-translation-workflow.instructions.md`.

DynamicStringsIL2CPP uses `FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow` and
`TextFileType.DynamicStringsIL2CPP`, deliberately separate from the older
`TextFileType.DynamicStrings`. Runtime translation is an exact substring replacement: a raw
dictionary entry can replace a hardcoded fragment inside a larger runtime string. This differs
from PrefabText, which uses exact whole-string lookup.

## Numbered workflow

`Tests/FileInputWorkflowTests.cs` runs these facts individually and in order:

- **3. `ExtractIl2CppStringMapCandidates`** regenerates
  `Converter/output/_dynamicStrings_candidates.txt` from the current
  `Converter/output/_string_map.csv` and appends new entries to
  `Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt`. It skips entries already present in the
  master dump and no-ops when the converter input or subprocess is unavailable.
- **4a. `ExtractColumnCandidates`** reads the configured
  `GameFileHandling.DynamicStringColumnSources` CSV columns and writes whole-phrase entries to
  `dynamicStringsFromColumns.txt`.
- **4b. `ExtractHeroNamePartCandidates`** writes the configured hero name halves to
  `heroNameParts.txt`; this remains a separate dictionary source.
- **4c. `ExtractStructuredRecordFragmentCandidates`** extracts standalone fragments from
  semicolon-joined structured records in `dynamicStrings.txt` and writes
  `dynamicStringsFromStructuredFragments.txt`.
- **4d. `ExtractOtherFieldLabelCandidates`** extracts stat-label fragments from the dumped
  other-field data and writes `dynamicStringsFromOtherFieldLabels.txt`.
- **4e. `ExtractPoetryCandidates`** reads poetry candidates from the JSON `PoetryData.txt`
  TextAsset and writes `dynamicStringsPoetry.txt`.
- **4f. `ExtractDrinkQuoteCandidates`** reads the two displayed halves of drink quotes and
  writes `dynamicStringsDrinkQuotes.txt`.
- **5. `DedupeDynamicStringFiles`** performs the authoritative, idempotent cross-file deduplication
  pass over every `Raw/Dumped/DynamicStrings/*.txt` file.
- **6. `ExportDynamicStringFilesIntoTranslated`** serializes every configured
  `DynamicStringsIL2CPP` input into the corresponding `Files/Raw/Export` and
  `Files/Converted` YAML files. This is a serialization step; extraction and deduplication must
  already have run.

The extraction facts are intentionally separate so each source can be rerun without invoking
the other sources. Their output files are listed in `GameFileHandling.TextFilesToSplit` and are
packaged independently, then loaded together by the plugin's `dynamicStrings*.txt.yaml` glob.

`ExtractDynamicStringCandidatesFromOtherText` is not a DynamicStrings source. Fact **2.
`ExportPrefabTextIntoTranslated`** reads the asset dumper's allowlisted non-primary fields and
writes `dumpedPrefabTextFromOtherFields.txt`, which is a `TextFileType.PrefabText` input for
exact whole-string replacement. The field-selection rationale is in
[`dynamicstrings-extraction-sources.md`](dynamicstrings-extraction-sources.md) and
[`assetdumper-libcpp2il-and-noise-filtering.md`](assetdumper-libcpp2il-and-noise-filtering.md).

## Packaging and runtime behavior

`GameFileHandling.PackageFinalTranslationAsync` excludes DynamicStringsIL2CPP files from the CSV
reconstruction loop and calls `DynamicStringWorkflow.PackageDynamicStringsAsync` for each one.
Each output is a flat list of `DynamicStringResult` values with `raw` and `result` YAML keys.
Unsafe, flagged, or untranslated lines fall back to their raw value.

Dialogue-option values such as `Label;ActionName;Param` also emit a deduplicated bare-label
dictionary entry when the template has one translatable split. The game renders the label before
the first semicolon, so a dictionary entry for only the full compound value would not match. The
fix is described in [`dynamicstrings-dialogue-button-fix.md`](dynamicstrings-dialogue-button-fix.md).

At runtime, `DragonHeirPlugin/DynamicStringPatches.cs` loads every packaged
`dynamicStrings*.txt.yaml` file, orders entries longest-first, and applies substring replacements
to the patched `String.Concat`/`String.Format` results and text setters. The static extraction
does not identify the originating game method, so runtime patching is intentionally shared across
the supported string-building overloads.

Known-bad reconstructed results are corrected by
`GameFileHandling.DynamicStringResultOverrides` after packaging. Do not hand-edit generated
`Files/Converted` or `Files/Mod` YAML because later export or packaging regenerates those values.