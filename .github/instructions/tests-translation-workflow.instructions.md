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
part of the numbered pipeline) that scans `<GameFileHandling.GameFolder>\LongYinLiZhiZhuan_Data`
for Chinese text baked directly into prefabs/`MonoBehaviour`/`TextAsset` serialized fields — the
kind of hardcoded UI text that never goes through the CSV pipeline above. It's the offline
counterpart to `FanslationStudio.Plugins.Shared`'s `PrefabTextDumperService`
(`G:\FanslationStudio.Plugins\FanslationStudio.Plugins.Shared\PrefabText\PrefabTextDumperService.cs`),
which walks *loaded* GameObjects at runtime via Harmony + UnityEngine reflection — that approach
can't run here since `Tests` has no Unity runtime. Instead this test uses `AssetsTools.NET` to
statically parse the `.assets`/`.bundle`/`.unity3d` files on disk: **IL2CPP only affects how the
game's compiled code is generated, not the Unity `SerializedFile` container format** these asset
files use, so no game process, Harmony, or IL2CPP-awareness is needed to read them.

- **Unlike `PrefabTextDumperService`** (which only scans standalone external bundles reachable via
  `AssetBundle.LoadFromFile` at runtime, since Unity's monolithic internal files aren't loadable
  that way), this offline scan opens `globalgamemanagers`/`level*`/`sharedassets*` directly too —
  they use the same `SerializedFile` format as a standalone `.assets` file, just without a
  dedicated extension, and `AssetsManager.LoadAssetsFile` reads them fine regardless of extension.
  Only genuinely unparseable companion payloads are filtered out by `IsCandidateAssetFile`:
  `.resS`/`.resource` files are raw data blobs (audio/texture bytes) referenced by a
  `StreamingInfo` elsewhere and have no `SerializedFile` header of their own, and `.manifest` is
  plain-text bundle metadata — all three fail with `AssetsTools`' "signature not supported" if
  scanned directly. `ScanFile` dispatches purely on extension: `.unity3d`/`.assetbundle`/`.bundle`
  go through the `AssetBundleFile`/`LoadBundleFile` path, everything else (`.assets` or no
  extension at all) is opened directly via `LoadAssetsFile`.
- Walks every deserialized field on every asset (not a fixed field-name allowlist like
  `m_text`/`m_Text`) looking for a string value matching the same
  `\p{IsCJKUnifiedIdeographs}`-based pattern as `DragonHeirPlugin/MainPlugin.cs`'s
  `ChineseCharPattern`, and writes unique matches to
  `Files/Raw/Dumped/PrefabText/dumpedPrefabText.txt` (mirroring the runtime dumper's output shape).
- **`classdata.tpk` (optional) covers built-in engine types only** — download one from
  https://github.com/nesrak1/AssetsTools.NET/releases and place it at `Tests/classdata.tpk` (path
  is `AssetDumperWorkflowTests.ClassDataTpkPath`) if a release build stripped type trees for
  engine classes like `Texture2D`/`GameObject`. It does **not** help `MonoBehaviour` assets at
  all — a `MonoBehaviour`'s field layout is defined by the game's own script code, which
  `classdata.tpk` has no knowledge of.
- **`MonoBehaviour` fields (where most hardcoded UI text actually lives) require the
  `Cpp2IlTempGenerator` from the `AssetsTools.NET.Cpp2IL` package instead.** `TextMeshProUGUI`,
  `UI.Text`, and any custom UI script are all `MonoBehaviour`-derived components — without a
  `MonoTempGenerator` wired up, `AssetsManager.GetBaseField` either throws or returns only the
  generic `Object`/`MonoBehaviour` header fields (`m_Script`/`m_Name`), silently missing the actual
  text field. The test wires `manager.MonoTempGenerator = new Cpp2IlTempGenerator(metadataPath,
  gameAssemblyPath)` using the same `GameAssembly.dll` +
  `<data-dir>\il2cpp_data\Metadata\global-metadata.dat` paths `Converter/Program.cs` auto-discovers
  for this same game (see `converter.instructions.md`'s "`--game-dir` auto-discovers" table) — both
  files already exist on disk for this game, no separate download needed, unlike `classdata.tpk`.
  **A near-empty result from this test essentially always means the scan couldn't resolve
  `MonoBehaviour` fields, not that no Chinese prefab text exists** — check the printed
  `monoBehavioursSkipped` count in the test output before concluding "there's nothing there"; if it
  is high (or `GameAssembly.dll`/`global-metadata.dat` weren't found), the scan never actually
  looked at that text at all.
- **`Samboy063.LibCpp2IL` is pinned to `2022.1.0-pre-release.13`** (with `AssetRipper.Primitives
  2.1.0`) in `Tests.csproj` — do not bump without re-verifying, plain restore picks a version that
  breaks MonoBehaviour resolution 100% of the time. A `classdata.tpk` (from `nesrak1/UABEA`'s
  releases, not `AssetsTools.NET`'s own) at `Tests/classdata.tpk` is also required for built-in
  engine types. Full version-pin investigation and classdata.tpk root cause in
  [`Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md`](../../Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md).
- Noise filtering: `m_Name`/`first` fields excluded via `IgnoredFieldNames` in `ExtractChineseText`
  (a path-based heuristic was tried and removed — didn't reliably catch the noise). `TextAsset`
  assets (`m_Script`, whole
  embedded file contents) are skipped entirely before field-walking, and a `MaxStringLength = 2000`
  cap guards against any other unexpectedly huge string field.
- **Output is split into two files (Aug 2026)** by `IsPrimaryTextField` (exact, case-insensitive
  match on `"m_Text"` or `"text"` — the actual field names `UI.Text`/`TMP_Text` use for their
  rendered-text field, confirmed from a real dump): `dumpedPrefabText.txt` gets ONLY those strings,
  one plain string per line with no field-name suffix — this is deliberately just a flat text file,
  matching what `PrefabTextWorkflow.ExportPrefabTextToCustomFormat` (see below) expects to read.
  Everything else found by the generic field walk (`plotText`, `tutorialText`, `choiceText`,
  `eventDescribe`, `startRemindText`, etc. — real dialogue/plot text living on custom
  `MonoBehaviour` fields, not the component's own displayed-text field) goes to the sibling
  `dumpedOtherText.txt` in the original diagnostic `{text}\t[{field}]` format and is **not** fed
  into the translation pipeline.
- **`dumpedPrefabText.txt` now feeds directly into the numbered workflow** via
  `GameFileHandling.ExportPrefabTextAssetToCustomFormat` (`FileInputWorkflowTests`'s
  `"1b. ExportPrefabTextIntoTranslated"`, run right after step 1, before step 2's merge) — this is
  no longer purely a read-only discovery step. See "PrefabText pipeline" below.
- **`IsPrimaryTextField`'s `"m_Text"`/`"text"` allowlist misses real displayed text on several
  other `MonoBehaviour` fields** (`name`, `eventName`/`tutorialName`/`showName`/`bulletName`/
  `fullName`/`jobName`/`spellName`/`pointName`/`sourceName`/`plotName`) — these land in
  `dumpedOtherText.txt` only. Handled via the automated dynamic-string extraction sources
  (`ExtractDynamicStringCandidatesFromOtherText`/`ExtractDynamicStringCandidatesFromIl2CppStringMap`/
  `DynamicStringOtherTextFields`, see DynamicStringsIL2CPP pipeline below) rather than widening
  `IsPrimaryTextField` (risky — `data`/`targetName` mix real content with internal asset/UI names
  on the same field, deliberately excluded).
- **A "primary" `text`/`m_Text` field can still miss `PrefabTextPatches.cs`'s load-time scan if the
  value is set at runtime rather than baked into the prefab.** Fixed generally:
  `PrefabTextPatches.cs` also postfixes `TMP_Text.text`/`UI.Text.text` setters (same sink-level
  pattern `DynamicStringPatches.cs` uses) doing an EXACT whole-string lookup against its own
  `Replacements` dictionary, at `[HarmonyPriority(Priority.First)]` so it always runs before
  `DynamicStringPatches`' bare-fragment postfix. Genuinely runtime-COMPOSED strings still fall
  through unmodified to `DynamicStringPatches`' template/fragment matching. Full investigation
  narrative (both findings) in [`Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md`](../../Tests/docs/assetdumper-libcpp2il-and-noise-filtering.md).

## PrefabText pipeline (`dumpedPrefabText.txt` → `Files/Mod/dumpedPrefabText.txt.yaml`)

A dumped prefab-text file has **no row/column structure** — each line is one distinct,
already-deduplicated Chinese string, handled by the generic, game-agnostic
`FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow` (registered as `TextFileType.PrefabText` in
`GameFileHandling.TextFilesToSplit`) instead of the CSV-specific `CompoundFieldSplitter` path.
Export/package wiring is via `GameFileHandling.ExportPrefabTextAssetToCustomFormat` /
`PackageFinalTranslationAsync` (which special-cases `TextFileType.PrefabText` out of the CSV
reconstruction loop). Output is `Files/Mod/dumpedPrefabText.txt.yaml`, a flat `raw`/`result` list,
looked up at runtime by exact whole-string match (**not yet implemented** in `DragonHeirPlugin/`).
Full wiring details, the packaging-fallback shape, and the 2026-08-27 Passed/Failed-count bug fix:
[`Tests/docs/prefabtext-pipeline-architecture.md`](../../Tests/docs/prefabtext-pipeline-architecture.md).

## DynamicStringsIL2CPP pipeline (`dynamicStrings.txt` → `Files/Mod/dynamicStrings.txt.yaml`)

Hardcoded, runtime-assembled string literal fragments compiled directly into IL2CPP game code
(e.g. `String.Concat`/`String.Format` mixing a Chinese literal with data). Handled by
`FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow` (`TextFileType.DynamicStringsIL2CPP` —
NOT the older unrelated `TextFileType.DynamicStrings`), applied at runtime as an exact
**substring** replace via `DragonHeirPlugin/DynamicStringPatches.cs` Harmony-postfixing
`String.Concat`/`String.Format`. Three candidate-discovery sources feed
`Files/Raw/Dumped/DynamicStrings/dynamicStrings*.txt`: (1) an auto-regenerating IL2CPP-string-map
source (`GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap`) that reruns
`Converter --dynamic-string-candidates` fresh each time and appends new entries straight into the
master `dynamicStrings.txt` — there is no manual review/curation step, despite older doc wording;
`dynamicStrings.txt` IS this candidates output, deduped and accumulated over time, (2)
config-driven CSV-column sources (`GameFileHandling.DynamicStringColumnSources`), (3) config-driven
allowlisted asset-dumper field names (`DynamicStringOtherTextFields`). Sources (2) and (3) both
feed the separate `dynamicStringsFromColumns.txt` file. All three are run inline by
`FileInputWorkflowTests`'s merged `"1c. ExportDynamicStringsIntoTranslated"` fact. Dialogue-option
buttons additionally need a bare-label dictionary entry (see doc). Full wiring details for all
three sources, the `dynamicStringsFromColumns.txt` dedup behavior, and the dialogue-button fix:
[`Tests/docs/dynamicstrings-pipeline-architecture.md`](../../Tests/docs/dynamicstrings-pipeline-architecture.md).

**Known-bad reconstructed template Results are forced via `GameFileHandling.DynamicStringResultOverrides`**,
applied by `ApplyDynamicStringResultOverrides` right after `PackageFinalTranslationAsync` packages
each `DynamicStringsIL2CPP` file — never fix these by hand-editing `Files/Converted`/`Files/Mod`
YAML directly, since a re-export or re-translation silently regenerates the unfixed value and
undoes the edit. E.g. the `"{0}年{1}月{2}日"` save-slot date template reconstructs fragment
translations with no separator (`"{0}Year{1}Month{2}Day"`) — overridden by exact `Raw` match to
`"{0} Year {1} Month {2} Day"`.


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

