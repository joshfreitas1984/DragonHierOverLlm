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

## Log-narrative isolation (`dynamicStringsLogNarratives.txt`)

**4g. `ExtractLogNarrativeCandidates`** carves the `HeroData.AddLog`/`AreaData.AddLog` "log
narrative" template family (HeroDetailPanel's Log tab, AreaLog, PlotPanel's RecordScrollView) out
of the master `dynamicStrings.txt` dump into its own dedicated `dynamicStringsLogNarratives.txt`
file, against `DynamicStringSources.LogNarrativeTemplates` - a curated exact-match allowlist, not
a generic column/field source, since these are literals baked directly into IL2CPP method bodies
(confirmed 2026-09-13 via decompiled `Converter/output/_NoNamespace/AIController.cs`,
`GameController.cs`, `HeroData.cs`, `AreaData.cs`, `PlotController.cs`).

A dedicated file (not a tag/category field) was used because `dynamicStrings.txt` is a flat,
unstructured line list with no per-entry metadata - matching the existing precedent set by
`heroNameParts.txt`/`forceNameParts.txt` above. `ExtractLogNarrativeCandidates` only *copies*
matching lines into the new file; it never removes them from the master dump itself. Removal is a
side effect of fact 5's cross-file dedup pass, which is why `dynamicStringsLogNarratives.txt` was
added to `DynamicStringDedupePriorityOrder` **ahead of** `dynamicStrings.txt` - reversing that
order would make the dedup pass keep the master-dump copy and silently strip the new file back to
empty on every re-run.

The curated allowlist is hand-maintained but not meant to be hand-re-derived: if a game content
update regenerates `Converter/output/_NoNamespace/*.cs`, re-run
`Converter/Scripts/ExtractAddLogTemplates.ps1` against the fresh decompile to regenerate a
candidate list for review (it independently reproduces this list almost entirely; see its header
comment for the one known gap - a single call site that inlines several sibling-branch literals
directly into `String.Format` rather than through one variable, needing manual expansion each
time). Six other `AddLog` call sites build their line via `String.Concat`-glued generic fragments
(e.g. `"的"`, `"了"`) rather than one self-contained template and are deliberately excluded - see
`DynamicStringSources.LogNarrativeTemplates`'s doc comment for the full list and rationale.

Naturalness fixes for this family's translated `Result` values go through the same
`GameFileHandling.DynamicStringResultOverrides` mechanism as every other `DynamicStringsIL2CPP`
file (below) - isolating the templates just makes them trivial to enumerate, it doesn't add a
second override mechanism.

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

## Quality review exclusion for function-routed choice entries

`dynamicStrings.txt` has `EnableQualityReview = true` (2026-09), so its ordinary template dialogue
lines get reviewed like any other translated text. But a meaningful slice of this file's entries
(confirmed via decompile: 1,242 of 6,693 raw entries at time of writing) are the same
`"{choiceText};FunctionName[;params...]"` dialogue-choice/routing shape the packaging section above
describes - real runtime records (e.g. `PlotController.cs`'s hardcoded `出手抢夺;RobNPCItemSure`),
not free-text sentences. A QC model has no way to know `FunctionName` is an opaque identifier
rather than text to "fix", and unlike `PlotData.csv` column 9 (see
[plotdata-column9-crash-and-repair-pattern.md](plotdata-column9-crash-and-repair-pattern.md)) there
is no `CustomColumnValidator` registered for this file to catch a corrupted `;`/`&` structure in a
proposed correction - packaging would accept a bad `QcTranslated` as the literal final cell value.

`GameFileHandling.ExcludeFunctionRoutedDynamicStringFromQc` (registered as `GameHooks.
CustomQcExclusionRule`) keeps every such entry out of the QC pass entirely, before any LLM call: any
`DynamicStringsIL2CPP` column whose reconstructed raw text contains a literal ASCII `;` after
position 0 is excluded. This is deliberately broader than "must end in `;Identifier`" - the same
raw dump also contains temp-NPC spawn records (`临时:传令&随机;;-1;3;-1`) and bare trailing-`;`
dialogue-option fragments (`另选它物;`), all part of the same "machine record, not prose"
convention; a real corpus sample confirmed every raw entry containing `;` is one of these shapes,
never ordinary Chinese sentence text (which never contains an ASCII semicolon). See the shared
library's [`quality-review-pass-architecture.md`](../../../FanslationStudio.LlmKit/docs/quality-review-pass-architecture.md)
for the general `CustomQcExclusionRule` mechanism and guidance for writing a similar rule elsewhere.