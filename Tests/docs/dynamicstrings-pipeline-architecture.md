# DynamicStringsIL2CPP pipeline architecture (`dynamicStrings.txt` → `Files/Mod/dynamicStrings.txt.yaml`)

Full reference for how the DynamicStringsIL2CPP pipeline is wired, extracted out of
`tests-translation-workflow.instructions.md` (which only keeps a short pointer to this file now)
since this is detailed architecture consulted only when working on this specific pipeline, not
needed on every `Tests/**` edit.

Hardcoded, runtime-assembled string literal fragments compiled directly into IL2CPP game code
(e.g. a `String.Concat`/`String.Format` call mixing a Chinese literal like `"架势"` with data such
as a save-slot's task text) - see the `dynamic-string-translation-plan` repo memory and
`DragonHeirPlugin/DynamicStringPatches.cs`. Handled by
`FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow`, mechanically almost identical to the
PrefabText pipeline (flat list of distinct strings -> standard TranslationLine YAML ->
Export/Converted/translate -> flat raw/result YAML) but kept as its own `TextFileType` (
`DynamicStringsIL2CPP` - deliberately NOT the older, unrelated `TextFileType.DynamicStrings`,
which targeted a Mono/Cecil-transpiler approach that doesn't work against IL2CPP) and its own
`Workflow` class, since the runtime consumption model differs: a PrefabText result is looked up by
an exact *whole-string* match against a UI component's full text, whereas a DynamicStringsIL2CPP
result is applied as an exact *substring* replacement against a small hardcoded fragment of a
larger, otherwise data-driven runtime string.

- **Candidate discovery is fully static/offline** (unlike PrefabText's offline asset scan, but
  equally no game run needed): `Converter`'s `--dynamic-string-candidates` mode filters the
  already-extracted `output/_string_map.csv` (every string literal compiled into the game's IL2CPP
  binary - see `Converter/Services/StringMapExtractor.cs`) for CJK-containing values and writes the
  distinct results to `output/_dynamicStrings_candidates.txt`, one per line.
  `GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap` shells out to run this mode
  (with `--exclude-file ../Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt` to skip already-known
  fragments) and appends any genuinely-new entries **directly into**
  `Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt` - there is no manual review/curation step in
  practice; `dynamicStrings.txt` IS the accumulated, deduped output of this candidates file over
  time, bootstrapped (created) the first time it's missing entirely (e.g. fresh clone or after
  deleting `Raw/Dumped`). It still includes some noise (debug/internal strings, data already
  covered by the CSV/PrefabText pipelines) since there's no filtering beyond dedup - see
  `Services/StringMapExtractor.cs`'s `IsExoticScriptNoise` for the noise filtering that IS applied
  before candidates are even written.
- `GameFileHandling.TextFilesToSplit` has a `dynamicStrings.txt` entry with `TextFileType =
  TextFileType.DynamicStringsIL2CPP`.
- **Second source, config-driven (not manually curated):** `GameFileHandling.DynamicStringColumnSources`
  declares `(CsvFileName, int[] Columns)` pairs for CSV columns known to hold whole-phrase display
  strings some IL2CPP code path reads raw, bypassing the normal per-column CSV translation (e.g.
  `ForceData.csv` column 1 = force/sect name, `SpeHeroData.csv` column 5 = rank/tier tag - see the
  bare-fragment-corruption bug writeup in `dragonheirplugin.instructions.md`).
  `GameFileHandling.ExtractDynamicStringCandidatesFromColumns` (run via `FileInputWorkflowTests`'s
  the merged `"1c. ExportDynamicStringsIntoTranslated"` fact, before the export call in that same
  fact) pulls distinct values from
  those columns into a second dump file, `Files/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt`
  (deduped against the master `dynamicStrings.txt` and idempotent across re-runs), registered as its
  own `TextFileToSplit` entry with the same `TextFileType.DynamicStringsIL2CPP` - flows through the
  same export/merge/package steps as the master `dynamicStrings.txt` file (itself populated by
  reviewing/merging `output/_dynamicStrings_candidates.txt`, not hand-authored), just packaged
  separately as
  `Files/Mod/dynamicStringsFromColumns.txt.yaml`. `DragonHeirPlugin/DynamicStringPatches.cs` loads
  every `dynamicStrings*.txt.yaml` file it finds (not one fixed filename) and merges them into one
  in-memory dictionary, so this needed no runtime-consumption changes beyond that glob.
- **Third source, also config-driven, writing to the SAME `dynamicStringsFromColumns.txt` file:**
  `GameFileHandling.DynamicStringOtherTextFields` declares a hand-vetted allowlist of
  `AssetDumperWorkflowTests`-produced `DumpedTextEntry.Field` names (`name`, `eventName`,
  `tutorialName`, `showName`, `bulletName`, `fullName`, `jobName`, `spellName`, `pointName`,
  `sourceName`, `plotName`, and - added 2026-08-27 - `plotText`, `tutorialText`, `choiceText`,
  `startRemindText`, `describe`, `eventDescribe`, `jobDescribe`) known to hold real player-facing
  text that `IsPrimaryTextField`'s `"m_Text"`/`"text"` check misses (e.g. hero-class creation
  template badges like `异士模板` live on a plain `name` field - see the finding in
  `assetdumper-libcpp2il-and-noise-filtering.md`).
  `GameFileHandling.ExtractDynamicStringCandidatesFromOtherText` (run via
  the same merged `FileInputWorkflowTests`'s `"1c. ExportDynamicStringsIntoTranslated"` fact, run
  inline right alongside the CSV-column source above, both before that fact's own export call) reads
  `Files/Raw/Dumped/PrefabText/dumpedOtherText.txt` (produced by the separate, one-off
  `AssetDumperWorkflowTests.DumpChineseTextFromAssets` asset scan - this extraction only finds
  anything new after that scan has been re-run), keeps every distinct value whose field is in the
  allowlist, and appends any not already seen to `dynamicStringsFromColumns.txt` - deduped and
  idempotent the same way as the CSV-column source above. `data` and `targetName` were sampled and
  found too noisy to promote wholesale (mix real content with internal asset/UI names or
  config-string fragments on the exact same field name) - deliberately left out; add a genuinely
  missing string from one of those two fields directly to `dynamicStrings.txt` instead.
  - The `plotText`/`tutorialText`/`choiceText`/`startRemindText`/`describe`/`eventDescribe`/
    `jobDescribe` fields are long paragraphs on custom data classes, not baked onto a
    `TMP_Text`/`UI.Text` component, and have no CSV source at all (confirmed by grepping every
    dumped CSV — zero matches). They belong in the **DynamicStrings** (substring-replace)
    mechanism, not `PrefabText`, because `DynamicStringPatches.cs` patches the
    `TMP_Text.text`/`UI.Text.text` **setters** themselves (sink-level), catching the value the
    moment it's displayed regardless of source field — `PrefabTextPatches.cs` only inspects text
    once at load time and would never see these. Each field was sampled for ASCII-noise before
    being added (all clean or only false-positive markup hits). Full investigation:
    [`dynamicstrings-extraction-sources.md`](dynamicstrings-extraction-sources.md).
- **Fourth source, writing to the SAME `dynamicStringsFromColumns.txt` file, and the only one that
  actively regenerates its own upstream input rather than just reading a pre-dumped file:**
  `GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap` (run via the same merged
  `FileInputWorkflowTests`'s `"1c. ExportDynamicStringsIntoTranslated"` fact, run inline last,
  after the two sources above, before that fact's own export call) shells out
  (`System.Diagnostics.Process`, `dotnet run --no-build --`) to the sibling `Converter` project to
  regenerate `Converter/output/_dynamicStrings_candidates.txt` FRESH from the current
  `Converter/output/_string_map.csv` every time this fact runs (`--dynamic-string-candidates
  --exclude-file <dynamicStrings.txt>` - see `converter.instructions.md`), then appends any
  genuinely-new entries to `dynamicStringsFromColumns.txt` using the same seen-set dedup pattern as
  the other sources — added to fix a real staleness bug where an old on-disk candidates file
  silently hid new strings after a game patch. No-ops gracefully if
  `Converter/output/_string_map.csv` doesn't exist yet or the subprocess fails. Full investigation:
  [`dynamicstrings-extraction-sources.md`](dynamicstrings-extraction-sources.md).
- `GameFileHandling.ExportDynamicStringTextAssetToCustomFormat` (run via
  `FileInputWorkflowTests`'s `"1c. ExportDynamicStringsIntoTranslated"`, right after step 1b, before
  step 2's merge) calls `DynamicStringWorkflow.ExportDynamicStringsToCustomFormat` - this single
  fact now also runs all three automated candidate-extraction sources inline first (see above), so
  there's only one fact to run for the whole dynamic-strings workflow.
- `GameFileHandling.PackageFinalTranslationAsync` filters `TextFileType.DynamicStringsIL2CPP`
  entries out of the CSV reconstruction loop (same as PrefabText) and calls
  `DynamicStringWorkflow.PackageDynamicStringsAsync` for each, producing
  `Files/Mod/dynamicStrings.txt.yaml` - a flat list of `DynamicStringResult { Raw, Result }`
  (`raw`/`result` YAML keys), the same shape as PrefabText's output.
- **Dialogue-option buttons (e.g. `"打扰了;HideInteractUI"`) need a bare-label dictionary entry
  too, not just the full compound literal** — the game only ever renders the `Label` substring
  before the first `;`, so `DynamicStringPatches.ApplyDictionary`'s `input.Contains(entry.Raw)`
  check can never match if the dictionary key is the full `Label;ActionName;Param` string. Fixed
  in `FanslationStudio.LlmKit/Workflow/DynamicStringWorkflow.cs`: `ReconstructLine`/
  `PackageDynamicStringsAsync` now also emit a second, bare `DynamicStringResult` (deduped)
  whenever a line's template has exactly ONE translatable split — covers this whole "Label;metadata"
  cell class generically. Full narrative in
  [`dynamicstrings-dialogue-button-fix.md`](dynamicstrings-dialogue-button-fix.md).
- **No per-method configuration needed at runtime** - the static extraction has no way to
  attribute a literal back to the specific Type+Method that concatenates it, so
  `DragonHeirPlugin/DynamicStringPatches.cs` doesn't try to target specific methods at all. Instead
  it reflects over every public static, non-generic, string-returning overload of
  `System.String.Concat`/`System.String.Format` and Harmony-postfixes all of them with one generic
  postfix that applies every `dynamicStrings.txt.yaml` entry as an exact substring replace
  (`__result.Replace(raw, result)`) - this is a plain BCL type, not an IL2CPP-wrapped game type, so
  patching it is an ordinary, fully-safe Harmony patch. Catches the fragment regardless of which
  game method builds the string.
