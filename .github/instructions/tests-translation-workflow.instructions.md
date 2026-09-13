---
applyTo: "Tests/**"
---

# Tests (translation workflow) — Copilot Instructions

> **Workflow rule:** After any significant feature or fix here, update this file (and
> `FanslationStudio.LlmKit`'s own `.github/copilot-instructions.md` if the change touches shared
> Line/Split/Template types or `CompoundFieldSplitter`) — these are the primary source of truth.
> Keep this file short — it's auto-injected into context on every `Tests/**` edit. Put detailed
> bug-investigation narratives/case studies in a topic file under
> [`Tests/docs/`](../../Tests/docs/) instead (read on-demand, not auto-loaded, indexed by
> [`Tests/KNOWN_ISSUES.md`](../../Tests/KNOWN_ISSUES.md)), and only summarize the current-state
> rule here. **Batch write-backs**: during a task, jot scratch notes in session memory as you find
> things — write ONE consolidated update (a new/extended `Tests/docs/*.md` file + this file's
> summary + a one-line index entry) at the end of the task, not after every individual fix.

## What this project actually is

`Tests/` is **not a conventional test suite** — the xUnit `[Fact]` methods in
[FileInputWorkflowTests.cs](../../Tests/FileInputWorkflowTests.cs),
[FileOutputWorkflowTests.cs](../../Tests/FileOutputWorkflowTests.cs),
[TranslationWorkflowTests.cs](../../Tests/TranslationWorkflowTests.cs), and
[GlossaryCreationTests.cs](../../Tests/GlossaryCreationTests.cs) are a **manually-run, numbered
pipeline** for translating the game *Long Yin Li Zhi Zhuan* (龙隐俪之传). Facts are numbered in
their `DisplayName` (e.g. `"0. Copy raws..."`, `"1. ExportAssetsIntoTranslated"`,
`"2. MergeFilesIntoTranslated"`) to indicate run order — they are executed one at a time, by hand,
via the Test Explorer, as workflow steps against real files under `Files/`.

**Do not run these as a batch/regression suite and do not treat a run as a "test pass/fail"
signal for a code change** — they mutate real working-directory state (copy/delete/overwrite
`Files/Raw`, `Files/Converted`, `Files/Mod`) and calling an LLM API costs money and can silently
change on-disk translation state. Only run a specific numbered fact when the user asks to advance
the actual translation workflow.

**Never run the export/merge steps (`"0. Copy raws..."`, `"1. ExportAssetsIntoTranslated"`,
`"2. MergeFilesIntoTranslated"`) on your own initiative, even right after editing
`GameFileHandling.cs`/`TextFilesToSplit`** — the user has explicitly asked for these to always be
left for them to run themselves. This is different from the packaging step below: exporting/merging
touches `Files/Converted`'s accumulated translation state (irreversible-ish, only regenerable by
re-running the whole pipeline), whereas packaging just rebuilds `Files/Mod` from what's already in
`Files/Converted` and is safe to run freely.

For genuine regression testing of logic changes (e.g. CSV parsing, fragment
decomposition/reconstruction), write plain xUnit tests against pure functions — see
`CompoundFieldSplitterTests.cs` — that don't touch `Files/` at all, and run only those.

## Asset dumper (`AssetDumperWorkflowTests.cs`) — finding hardcoded Chinese in prefabs/assets

`AssetDumperWorkflowTests.DumpChineseTextFromAssets` is a standalone, one-off discovery tool (not
part of the numbered pipeline) that statically scans `<GameFileHandling.GameFolder>\LongYinLiZhiZhuan_Data`
assets via `AssetsTools.NET` for Chinese text baked into prefabs/`MonoBehaviour`/`TextAsset`
fields — hardcoded UI text that never goes through the CSV pipeline. Output is split into
`Files/Raw/Dumped/PrefabText/dumpedPrefabText.txt` (feeds the numbered workflow directly, see
"PrefabText pipeline" below) and a diagnostic-only `dumpedOtherText.txt`.

- **Prerequisites**: `Tests/classdata.tpk` (built-in engine types) and a working
  `Cpp2IlTempGenerator` wire-up (`MonoBehaviour` fields) are both required, or the scan silently
  finds little/nothing — check the printed `monoBehavioursSkipped` count before concluding no
  Chinese prefab text exists.
- **`Samboy063.LibCpp2IL` is pinned to `2022.1.0-pre-release.13`** (with `AssetRipper.Primitives
  2.1.0`) in `Tests.csproj` — do not bump without re-verifying; a plain restore picks a version
  that breaks MonoBehaviour resolution 100% of the time.
- A "primary" `text`/`m_Text` field can still miss `PrefabTextPatches.cs`'s load-time scan if the
  value is set at runtime rather than baked into the prefab — handled generally via
  `PrefabTextPatches.cs` postfixing `TMP_Text.text`/`UI.Text.text` setters, not per-string
  overrides.

Full architecture (tool design, `ScanFile`/`classdata.tpk`/`Cpp2IlTempGenerator` details, noise
filtering, `IsPrimaryTextField` output split, and the version-pin investigation) is in
[`Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md`](../../Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md).

## PrefabText pipeline (`dumpedPrefabText.txt` → `Files/Mod/dumpedPrefabText.txt.yaml`)

A dumped prefab-text file has **no row/column structure** — each line is one distinct,
already-deduplicated Chinese string, handled by the generic, game-agnostic
`FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow` (registered as `TextFileType.PrefabText` in
`GameFileHandling.TextFilesToSplit`) instead of the CSV-specific `CompoundFieldSplitter` path.
Export/package wiring is via `GameFileHandling.ExportPrefabTextAssetToCustomFormat` /
`PackageFinalTranslationAsync` (which special-cases `TextFileType.PrefabText` out of the CSV
reconstruction loop). Output is `Files/Mod/dumpedPrefabText.txt.yaml`, a flat `raw`/`result` list,
looked up at runtime by exact whole-string match in `DragonHeirPlugin/PrefabTextPatches.cs`
(resource/asset-bundle/scene-load hooks plus TMP/UI text-setter patches).
Full wiring details, the packaging-fallback shape, and the 2026-08-27 Passed/Failed-count bug fix:
[`Tests/docs/prefabtext-pipeline-architecture.md`](../../Tests/docs/prefabtext-pipeline-architecture.md).

## DynamicStringsIL2CPP pipeline (`dynamicStrings.txt` → `Files/Mod/dynamicStrings.txt.yaml`)

Hardcoded, runtime-assembled string literal fragments compiled directly into IL2CPP game code
(e.g. `String.Concat`/`String.Format` mixing a Chinese literal with data). Handled by
`FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow` (`TextFileType.DynamicStringsIL2CPP` —
NOT the older unrelated `TextFileType.DynamicStrings`), applied at runtime as an exact
**substring** replace via `DragonHeirPlugin/DynamicStringPatches.cs` Harmony-postfixing
`String.Concat`/`String.Format`. Six candidate-discovery facts (`Tests/FileInputWorkflowTests.cs`
facts 3, 4a–4f) feed `Files/Raw/Dumped/DynamicStrings/dynamicStrings*.txt`, followed by fact 5's
cross-file dedup pass and fact 6's export. Dialogue-option buttons additionally need a bare-label
dictionary entry (see doc). Full wiring details for every source, the dedup priority order, and
the dialogue-button fix:
[`Tests/docs/dynamicstrings-pipeline-architecture.md`](../../Tests/docs/dynamicstrings-pipeline-architecture.md).

**The "log narrative" `HeroData.AddLog`/`AreaData.AddLog` template family** (HeroDetailPanel's Log
tab, AreaLog, PlotPanel's RecordScrollView) is carved out of `dynamicStrings.txt` into its own
`dynamicStringsLogNarratives.txt` via fact `"4g. ExtractLogNarrativeCandidates"`, against a curated
allowlist in `DynamicStringSources.LogNarrativeTemplates` (re-derivable after a game update via
`Converter/Scripts/ExtractAddLogTemplates.ps1` - see that field's doc comment). See
[dynamicstrings-pipeline-architecture.md](../../Tests/docs/dynamicstrings-pipeline-architecture.md#log-narrative-isolation-dynamicstringslognarrativestxt)
for why a dedicated file (not a tag field) was used and why its dedup-priority ordering matters.

**Known-bad reconstructed template Results are forced via `GameFileHandling.DynamicStringResultOverrides`**,
applied by `ApplyDynamicStringResultOverrides` right after `PackageFinalTranslationAsync` packages
each `DynamicStringsIL2CPP` file — never fix these by hand-editing `Files/Converted`/`Files/Mod`
YAML directly, since a re-export or re-translation silently regenerates the unfixed value and
undoes the edit. E.g. the `"{0}年{1}月{2}日"` save-slot date template reconstructs fragment
translations with no separator (`"{0}Year{1}Month{2}Day"`) — overridden by exact `Raw` match to
`"{0} Year {1} Month {2} Day"`.


## Quality review (QC) pass — second, independent pass over already-translated text

An LLM (typically a larger/different model than primary translation) reviews each already-
translated column's fully reconstructed cell, optionally proposes a correction, and rates its own
confidence 0-100. Opt-in via `qualityReview.enabled: true` in `Files/Config.yaml`; per-file via
`TextFileToSplit.EnableQualityReview` (defaults true, explicitly `false` on most lookup-key-heavy
CSVs and the whole `PrefabText`/`DynamicStringsIL2CPP` family except `dynamicStrings.txt`). Run via
the numbered facts in `TranslationWorkflowTests.cs`: `"3a. RunQualityReviewPassSample"` (small
random sample - always try this before a full run on a new candidate model),
`"3b. RunQualityReviewPass"` (full, un-sampled - many hours), `"3c. Find Flagged Quality Review
Items"` (pulls every column currently flagged for human review), `"3d. Reset Qc Retry Limits"` (un-
sticks a column parked at `FailedValidation` after fixing whatever caused it - e.g. a false-positive
bad word), `"3e. Reset Leaked Quality Review Corrections"` (repairs any stored correction containing
leaked QC-protocol text), `"3f. RunQualityReviewSampleForOneLine"` (forces a fresh review of one
known corpus row - useful when iterating on the QC prompt/model),
`"3g. QcOmittedSubjectRegression"` (calls the QC model directly against a fixed known-bad
SOURCE/TRANSLATION pair, independent of corpus state - a real regression test, not a manual-
inspection tool; re-validates automatically whichever model `qualityReview.modelName` currently
points at), and `"3h. Reset ALL Quality Review State (full re-review)"` (wipes every column's Qc
state back to `NotReviewed`, not just stuck/corrupted ones like `"3d"`/`"3e"` - NOT routine, run
only after swapping the QC model or a prompt change significant enough that already-recorded
verdicts can no longer be trusted, since it forces the next `"3b"` to re-review the entire corpus). A proposed correction is only ever accepted if it passes the same structural validation
gate a normal translation attempt does, plus a glossary-drift check - a rejected correction never
touches `Translated`; once accepted, a low self-rated confidence score only flags it for human
review, it no longer discards the correction and re-rolls (see the shared library's postmortem
notes below). Full mechanics (data model, staleness/freshness, packaging interaction,
prompt-per-model-family convention, and the 2026-09 omitted-subject/response-truncation/low-score-
discard postmortems) live in the shared library's `docs/quality-review-pass-architecture.md`; the
original design rationale is in `docs/plans/quality-review-pass.md`.

**Per-column exclusion** (`GameHooks.CustomQcExclusionRule`, registered as `GameFileHandling.
ExcludeFunctionRoutedDynamicStringFromQc`) keeps a column out of the QC pass entirely - before any
LLM call - when its raw/effective text looks like prose but is actually a machine-readable record a
QC model has no business "correcting". This game's only current use: `dynamicStrings.txt`'s
`"{choiceText};FunctionName"` dialogue-choice/routing entries. See
[dynamicstrings-pipeline-architecture.md](../../Tests/docs/dynamicstrings-pipeline-architecture.md#quality-review-exclusion-for-function-routed-choice-entries)
for this game's case and the shared library's `quality-review-pass-architecture.md` for the general
mechanism/guidance if a new file+pattern combination needs the same treatment.

## Working directory layout (`Files/`)

- `Files/Raw/Dumped/GameData/` — raw CSVs dumped from the running game (via BepInEx plugin).
- `Files/Raw/Export/*.csv.yaml` — freshly exported `TranslationLine` YAML, regenerated every time
  `ExportGameSpecificTextAssetsToCustomFormat` runs. Treat as **disposable/regenerable**.
- `Files/Converted/*.csv.yaml` — the working copy that actually accumulates translations over
  time (`Translated` fields get filled in here across LLM translation passes). This is the file
  that matters — never something to delete casually.
- `Files/Mod/*.csv` — final packaged output ready to ship, produced by `PackageFinalTranslationAsync`.
- `GameFileHandling.TextFilesToSplit` — the master list of which `.csv` files get processed and
  whether `PackageOutput` is enabled for each. Comment out an entry here to skip a file entirely
  (e.g. not-yet-supported files like `BookTypeIconData.csv`). Set `SkipColumns` on an entry to
  exclude specific zero-based column indices from translation entirely (see below) — e.g.
  `AreaData.csv` sets `SkipColumns = [3]` to leave its 图标 (icon/resource-path) column untouched.

## `GameFileHandling.cs` responsibilities

- `ParseCsvRow` / `RebuildCsvRow` — thin wrappers delegating to
  `FanslationStudio.LlmKit.Utility.CompoundFieldSplitter`. Don't reimplement CSV parsing here;
  the canonical implementation lives in the shared library.
- `ExportGameSpecificTextAssetsToCustomFormat` — for each CSV row: parses columns with
  `ParseCsvRow`, then for each column calls `CompoundFieldSplitter.Decompose`. Trivial
  single-fragment columns become a plain `TranslationSplit` (`SubIndex = 0`, no template).
  Compound columns (multiple fragments, e.g. BuildingData's action column) get one
  `TranslationSplit` per fragment (`Split` = column index, `SubIndex` = fragment order) plus one
  `FieldTemplate` recording how to reassemble the column.
- `PackageFinalTranslationAsync` — reconstructs each row column-by-column: templated columns are
  rebuilt via `CompoundFieldSplitter.Reconstruct` from their ordered fragment translations; plain
  (non-templated) columns get their `Translated` value written straight into the cell. A row is
  marked failed (kept as `Raw`, not packaged) if **any** fragment/split in it is unsafe, flagged
  for retranslation, or missing its translation while having non-empty source text.
- `ExportGameSpecificTextAssetsToCustomFormat` looks up each dumped file's `TextFileToSplit` entry
  by file name and skips calling `CompoundFieldSplitter.Decompose` entirely for any column index in
  `SkipColumns`. A skipped column never gets a `TranslationSplit` or `FieldTemplate` — it isn't
  decomposed at all, so it doesn't matter whether the column's raw content would otherwise have
  produced one fragment or several sub-fragments (e.g. a compound `;`/`-` separated cell); it's
  simply never touched and comes through unchanged from the original raw CSV on both export and
  packaging. Use this for columns that contain CJK-looking text that isn't actually user-facing
  (icon names, resource paths, internal ids) rather than trying to special-case them in
  `CompoundFieldSplitter` itself.
- `GameFileHandling.SplitterOptions` — this game's `CompoundFieldSplitterOptions`, passed to every
  `CompoundFieldSplitter.Decompose` call. Currently configures `PlaceholderPatterns = [#\w+#]` to
  handle this game's `#PlayerName#`-style dynamic placeholder tokens (see "Game placeholder
  tokens" below). **This is where any future game-specific splitting tweaks belong** — the shared
  `CompoundFieldSplitter` is intentionally game-agnostic, so per-game exceptions are opted into
  here, not hardcoded in the shared library.

**Never go back to naive `line.Split(',')` / `string.Join(',', splits)` for row handling** — this
was the original bug: it ignored quoted fields and flattened compound columns into a single
un-parsable blob, breaking both Chinese-detection and safe reassembly. Always route through
`CompoundFieldSplitter`.

## Known game CSV field conventions (informs where compound columns show up)

Beyond commas, several data files pack additional structure **inside individual cells** (this is
what `CompoundFieldSplitter.Decompose` handles automatically — no per-file/per-column special
casing should be needed):

- `;` — list of items within a cell (e.g. multiple building actions in BuildingData).
- `-` — separates role/method metadata from a payload within an item; also used as a plain
  minus/negative sign inside numeric sub-fields (e.g. `1000-12-0-0`) or directly before a digit
  glued to Chinese text (e.g. `-99` in `-99表示自动`) — neither of those is a fragment boundary.
- `&` / `|` — AND / OR role requirements gating an action.
- ASCII `/` between clauses is a real fragment boundary when it's a genuine separator between two
  otherwise-unrelated sentences (e.g. `.../自宅`), and also appears inside plain numeric sub-fields
  (`1/2/3/4/5`).
- **Full-width/CJK punctuation is never a fragment boundary** — `，` `。` `？` `！` `：` `；` `、`
  `（）` `～` etc. always stay glued to whichever fragment they're adjacent to, because an LLM is
  free to reposition/merge/drop punctuation during translation; splitting a sentence apart around
  its own internal punctuation and reassembling with a fixed literal mark risks an ungrammatical
  result. Only genuine ASCII game-syntax characters (`;`, `&`, `|`, `--MethodName`, ASCII `-`/`,`
  used structurally) act as boundaries — never plain-language Chinese punctuation.
- Digits/decimal points glued directly onto Chinese text (e.g. `累计...击败500人`) are **part of
  the same sentence/fragment** and must never be split out on their own — this makes translations
  worse by removing sentence context from the LLM.
- A signed number (`+99`/`-99`) or percentage (`50%`) glued directly onto adjacent Chinese text
  must travel **with** that text as one fragment, not be stranded outside it. When such a
  sign+number immediately follows CJK punctuation that ended up absorbed into a prior run (e.g.
  `占领门派（-99表示自动）`), the two runs are merged back into a **single** fragment identical to
  the whole cell (template `{0}`) rather than left as two separate fragments each holding half of
  an unbalanced bracket — see `CompoundFieldSplitter.MergeAdjacentFragments`. Leaving the
  sign/percent outside a fragment while the bare number bleeds into unrelated adjacent text (the
  original bug) risks the LLM reordering/dropping the number and silently corrupting a sentinel
  value or threshold. A signed number with **nothing** adjacent to glue onto (e.g. `威望+10`, a
  compact stat-modifier label) correctly stays split as fragment `威望` + literal `+10` — the
  sign/percent fusion only kicks in when it's genuinely embedded in surrounding text.

### Game placeholder tokens (`#PlayerName#`, `#$PlayerName#`, `#$SourceInteractName#`, `#$TargetInteractName#`)

This game uses `#PlayerName#`-style tokens (`#` + optional `$` + word chars + `#`) as a dynamic
placeholder the game engine substitutes at runtime (player name, NPC name in an interaction,
etc.) - the `$`-prefixed variants (`#$PlayerName#`, `#$SourceInteractName#`,
`#$TargetInteractName#`) behave identically to the plain ones, just a different naming convention
in the dump, and are covered by the same `PlaceholderPatterns` regex (`#\$?\w+#` in
`GameFileHandling.SplitterOptions` - `\w` alone doesn't include `$`, so the pattern needs the
explicit `\$?` to match these). Its position in the sentence can
legitimately change during translation, so it must **never** be a fixed fragment boundary — e.g.
`欢迎回来，#PlayerName#，今天也要加油哦` must decompose to a **single** fragment (template `{0}`),
not `{0}#PlayerName#{1}` with the placeholder pinned as fixed literal text between two
independently-translated halves. This is configured via `GameFileHandling.SplitterOptions`
(`CompoundFieldSplitterOptions.PlaceholderPatterns`), passed into every `Decompose` call — see
`CompoundFieldSplitter.MergeAdjacentFragments` in the shared library for how a matching
placeholder gap gets absorbed into its surrounding fragment(s). Do **not** hardcode `#` handling
into the shared `CompoundFieldSplitter` itself — another game could use `#` as a genuine
structural separator instead, so this stays an opt-in, game-level setting.

If you're investigating "is this column split correctly", write a targeted assertion on
`CompoundFieldSplitter.Decompose(cell)`'s `Template`/`Fragments` output rather than eyeballing the
exported YAML — the exported YAML in `Files/Raw/Export` is a *symptom*, the bug is always in
`CompoundFieldSplitter` or in how `GameFileHandling.cs` calls it.

## Shared library boundary

Core Line/Split/Template types and CSV/compound-field logic live in `FanslationStudio.LlmKit`
(referenced via the `../../FanslationStudio.LlmKit/...csproj` project reference — a sibling repo,
not a NuGet package). If a fix belongs conceptually to "how do we parse/reconstruct a cell" or
"how does merge matching work", it belongs in that shared repo, not duplicated here — see its own
`.github/copilot-instructions.md` for the rules governing that code.

## Per-column crash-prevention hooks (`SkipColumns` / `CustomColumnRepair` / `CustomColumnValidator`)

Some CSV columns pack extra structure *inside the cell* (e.g. `Label+Number` stat modifiers
looked up by exact string match, or `|`/`;`-delimited compound records) that
`GameDataController.LoadAllGameData` parses with little/no fault tolerance — a single row where an
LLM translation doesn't preserve that structure exactly can silently null out a whole database or
raw-crash the game at startup with no per-row isolation. Two mechanisms exist to guard against
this, both registered in `Tests/GameFileHandling.cs`'s static constructor:

- **`SkipColumns`** (per-file list on a `TextFileToSplit` entry) — the column is **never**
  decomposed/translated; it passes through byte-identical from the raw CSV on both export and
  packaging (`PackageFinalTranslationAsync`'s reconstruction loops `continue`/skip entirely for any
  `SkipColumns` column). Use this only for columns that should never be translated at all (icon
  names, resource paths, internal keys, or a `Label+Number` cell cross-referenced by exact string
  match elsewhere — see [`Tests/docs/skipcolumns-stringtospeadddata-family.md`](../../Tests/docs/skipcolumns-stringtospeadddata-family.md) for confirmed examples:
  `HeroTagData.csv` col 4, `ResourcePointTypeData.csv` cols 2/3/4, `SkinDataBase.csv` col 2,
  `NameData.csv` col 0, `AreaData.csv` col 3).
- **`LineValidation.CustomColumnRepair`** / **`CustomColumnValidator`** (both
  `Func<TextFileToSplit?, int?, string, string, string(?)>`, receiving `(textFile, column, raw,
  result)`) — for columns that DO contain real translatable text but sit inside a structural
  delimiter format (`|`, `;`, etc.) that must never bleed into a translated fragment.
  `CustomColumnRepair` runs in `PrepareResult` and strips/fixes the offending character(s)
  deterministically before validation; `CustomColumnValidator` runs at the end of
  `CheckTransalationSuccessful` as a defense-in-depth backstop (return a non-null reason to force a
  retry). This game's implementations (`RepairGameSpecificColumn` /
  `ValidateGameSpecificColumn`, e.g. the `PlotData.csv` column-9 choice-text case) live in
  `Tests/GameFileHandling.cs` — add new file+column rules there, always scoped to an exact
  `textFile.Path == "..."` + `column == N` check, never a blanket "this character is always bad"
  rule (the same delimiter can be legitimate text in a different column/file).

**Prefer the repair/validator hooks over `SkipColumns` whenever the column has real user-facing
text** — `SkipColumns` throws away translatable content and should be reserved for columns never
meant to be translated. When investigating a new "database ends up empty at startup" or "game
crashes on load" case, see [`Tests/KNOWN_ISSUES.md`](../../Tests/KNOWN_ISSUES.md) for the full investigation methodology
(decompiling `GameDataController.LoadAllGameData`, checking `Player.log` when `BepInEx/LogOutput.log`
just stops with no exception, the `StringToSpeAddData` label-lookup heuristic, and verifying a fix
via the packaging-only test fact without a full game relaunch) and to record a new case once solved.

