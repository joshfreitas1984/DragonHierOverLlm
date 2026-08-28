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
  A line falls back to `Result = Text` (untranslated) if it has no usable translation yet
  (`Translated` empty, `FlaggedForRetranslation`, or `!SafeToTranslate`) — so the output always has
  one entry per dumped string, never a missing key. Runtime lookup (a future `DragonHeirPlugin`
  patch) is expected to key off exact `raw` string match.
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
- **Still not implemented:** the runtime BepInEx plugin patch in `DragonHeirPlugin/` that actually
  reads `dumpedPrefabText.txt.yaml` and substitutes translated text back into `UI.Text`/`TMP_Text`
  components at runtime.
