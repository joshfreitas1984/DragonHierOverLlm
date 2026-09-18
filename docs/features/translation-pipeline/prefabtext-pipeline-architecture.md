# PrefabText pipeline architecture (`dumpedPrefabText.txt` → `Files/Mod/dumpedPrefabText.txt.yaml`)

Full reference for how the PrefabText pipeline is wired, extracted out of
`tests-translation-workflow.instructions.md` (which only keeps a short pointer to this file now)
since this is detailed architecture consulted only when working on this specific pipeline, not
needed on every `Tests/**` edit.

Unlike the CSV pipeline, a dumped prefab-text file has **no row/column structure** — each
line is one distinct, already-deduplicated Chinese string with nothing else to decompose, so it's
handled by the generic, game-agnostic `FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow` instead
of `GameFileHandling`'s CSV-specific `CompoundFieldSplitter`/`ParseCsvRow` path (any game with a
similar flat-list dumper can reuse this as-is):

- `GameFileHandling.TextFilesToSplit` has a `dumpedPrefabText.txt` entry with
  `TextFileType = TextFileType.PrefabText` (this enum value already existed in
  `TextFileToSplit.cs` but was previously unused anywhere).
- `GameFileHandling.ExportPrefabTextAssetToCustomFormat` calls
  `PrefabTextWorkflow.ExportPrefabTextToCustomFormat`, which reads
  `Files/Raw/Dumped/PrefabText/dumpedPrefabText.txt` (one string per line) and writes the same
  `TranslationLine` YAML shape as the CSV path — each line gets exactly one whole-line
  `TranslationSplit` (`Split = 0, SubIndex = 0`) and **no `FieldTemplate`** — to
  `Files/Raw/Export/dumpedPrefabText.txt.yaml`, then seeds `Files/Converted/` the same way the CSV
  path does. This means `GameFileHandlingBase.MergeFilesIntoTranslatedAsync` (step 2) and
  `Workflow/TranslationWorkflow.cs`'s translate/retry loop work on it completely unchanged — it's
  just another `TextFileToSplit` entry to those.
- `GameFileHandling.PackageFinalTranslationAsync` filters `TextFileType.PrefabText` entries OUT of
  the CSV `ParseCsvRow`/`FileIteration.IterateTranslatedFilesAsync` reconstruction loop (a
  plain-string `Raw` line would otherwise be misparsed as a CSV row) and instead calls
  `PrefabTextWorkflow.PackagePrefabTextAsync` for each one. That writes
  `Files/Mod/dumpedPrefabText.txt.yaml` as a flat list of `PrefabTextResult { Raw, Result }`
  (`camelCase` YAML keys via `YamlHelper`, so it serializes as `raw`/`result`):
  ```yaml
  - raw: 地图一览
    result: Map Overview
  ```
  A line with no usable translation (`Translated` empty, `FlaggedForRetranslation`, or
  `!SafeToTranslate`) is **omitted from the packaged YAML entirely** (as of 2026-09-16 — see
  [`qc-run-startup-crash-investigation-2026-09-15.md`](qc-run-startup-crash-investigation-2026-09-15.md)),
  not written with `Result = Text` (raw Chinese) as it used to be — so the output no longer has
  guaranteed one entry per dumped string; a missing key just means `PrefabTextPatches.cs` never
  replaces that UI text at all, which is visually the same as a raw-Chinese entry but without ever
  shipping Chinese in a packaged "translation." A QC-rejected correction (low score, uncovered
  DEFECT category) also no longer falls back to raw Chinese — it falls back to the column's ordinary
  pre-QC `Translated` text instead. `DragonHeirPlugin/PrefabTextPatches.cs` loads these files and
  applies exact `raw` string matches at resource, asset-bundle, scene-load, and TMP/UI text-setter
  hooks.
- **Bug fixed (2026-08-27): a failed split was invisible in `PackageFinalTranslationAsync`'s
  printed `Passed`/`Failed` totals for `PrefabText`/`DynamicStringsIL2CPP` files.** The
  reconstruction fallback-to-raw logic itself was always correct (a flagged/unsafe/untranslated
  fragment already correctly forced the whole line back to `Raw` in the packaged YAML), but
  `PrefabTextWorkflow.PackagePrefabTextAsync`/`DynamicStringWorkflow.PackageDynamicStringsAsync`
  never reported which lines fell back vs. genuinely translated — so those failures never
  contributed to the counts, making a raw-fallback line look identical to a real pass in the run's
  reported stats (only the CSV `RegularDb` path via `GameFileHandling.PackageFinalTranslationAsync`
  tracked `passedCount`/`failedCount` at all). Both workflow methods now return a `(int Passed, int
  Failed)` tuple (their private `ReconstructLine` returns `(string? Result, bool Failed)`), and
  `GameFileHandling.PackageFinalTranslationAsync` adds these into its existing totals. If either
  method's signature changes again, re-check this aggregation still compiles/wires up correctly.
  (Historical note: "forced the whole line back to `Raw`" describes 2026-08-27 behavior. As of
  2026-09-16 a failed line is omitted from the packaged YAML instead of packaged with raw Chinese —
  see the bullet above and
  [`qc-run-startup-crash-investigation-2026-09-15.md`](qc-run-startup-crash-investigation-2026-09-15.md).
  The `Passed`/`Failed` count wiring this bullet describes is unaffected by that later change.)
- **Implemented:** `DragonHeirPlugin/PrefabTextPatches.cs` loads `dumpedPrefabText*.txt.yaml` and
  applies exact whole-string matches at resource load, asset-bundle load, scene load, and the
  `UI.Text`/`TMP_Text` setters. See
  [`dynamicstringpatches-agent-reference.md`](../runtime-plugin/prefabtextpatches-agent-reference.md)
  for the runtime hook details.
