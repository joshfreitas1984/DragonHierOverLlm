---
applyTo: "Tests/**"
---

# Tests (translation workflow) — Copilot Instructions

> **Workflow rule:** After any significant feature or fix here, update this file (and
> `FanslationStudio.LlmKit`'s own `.github/copilot-instructions.md` if the change touches shared
> Line/Split/Template types or `CompoundFieldSplitter`) — these are the primary source of truth.
> Keep this file short — it's auto-injected into context on every `Tests/**` edit. Put detailed
> bug-investigation narratives/case studies in [`Tests/KNOWN_ISSUES.md`](../../Tests/KNOWN_ISSUES.md)
> instead (read on-demand, not auto-loaded), and only summarize the current-state rule here.

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
- **Confirmed on a real run (2026-08-24): `otherAssetsSkipped` vastly outnumbered
  `monoBehavioursSkipped`** (40,489 vs 12,458 out of ~52,947 assets, 0 strings found) — meaning the
  dominant failure wasn't `MonoBehaviour`/Cpp2IL resolution at all, it was that this release build
  strips type trees from **every** asset class (`TypeTreeEnabled == false`), and with no
  `classdata.tpk` loaded, built-in engine types (`GameObject`, `Transform`, `Texture2D`, etc.) have
  no `ClassDatabase` to describe their layout either — `GetBaseField` fails on those just as hard
  as on `MonoBehaviour`. A `classdata.tpk` matching Unity `2020.3.48f1` (the version this game uses
  per `converter.instructions.md`) was needed on top of the `Cpp2IlTempGenerator` MonoBehaviour
  fix. **Resolved**: sourced `classdata.tpk` from the `nesrak1/UABEA` release (not
  `nesrak1/AssetsTools.NET`'s own releases — those don't ship one), placed at `Tests/classdata.tpk`
  — this alone dropped `otherAssetsSkipped` from 40,489 to 2.
- **`Samboy063.LibCpp2IL` NuGet version pin is load-bearing — do not bump without re-verifying.**
  `AssetsTools.NET.Cpp2IL` 3.0.4's nuspec only declares a *minimum* dependency on
  `Samboy063.LibCpp2IL >= 2022.0.7.2`, so plain restore picks the wrong version and MonoBehaviour
  resolution fails 100% of the time with one of two different runtime errors depending on which
  auto-resolved version you land on:
  - `2022.0.7.2` (and any older 2021.x/2022.0.x) predates LibCpp2IL's switch to
    `AssetRipper.Primitives.UnityVersion`, so `LibCpp2IlMain` has no
    `Initialize(byte[], byte[], AssetRipper.Primitives.UnityVersion)` overload at all →
    `Method not found: ...LibCpp2IlMain.Initialize(...)`.
  - Any `2022.1.0-pre-release.N` from N=15 onward (nuget.org) — or any unofficial
    `2022.1.0-development.NNNN` build that may already be sitting in the local NuGet cache from an
    unrelated prior restore, which is **not published on nuget.org at all** (verified via both the
    `/v3/registration5-gz-semver2/samboy063.libcpp2il/index.json` and legacy
    `/v2/package-versions` endpoints, with and without `includePrerelease`) — comes from
    LibCpp2IL's later `LibCpp2IlContext` refactor, where `LibCpp2IlMain.MetadataVersion` (and
    `.Initialize`, `.TheMetadata`, etc.) became `[Obsolete]` *properties* delegating to a context
    object instead of plain static fields. `AssetsTools.NET.Cpp2IL.dll` 3.0.4's IL still does a
    direct field access (`ldsfld`) against `LibCpp2IlMain.MetadataVersion`, so these throw
    `Field not found: 'LibCpp2IL.LibCpp2IlMain.MetadataVersion'` for every MonoBehaviour instead.
  - **The correct, officially-published version is `2022.1.0-pre-release.13`** (paired with
    `AssetRipper.Primitives 2.1.0`, per its nuspec) — confirmed by fetching
    `LibCpp2IlMain.cs` at that exact git tag on `SamboyCoding/Cpp2IL` and verifying it has *both*
    the 3-arg `Initialize(byte[], byte[], UnityVersion)` overload *and* still declares
    `MetadataVersion` as `public static float MetadataVersion = 24f;` (a real field, not yet
    refactored to the obsolete-property/context model). This is pinned explicitly in
    `Tests.csproj` alongside `AssetRipper.Primitives 2.1.0` — **if either version is ever bumped,
    re-fetch `LibCpp2IlMain.cs` at the new tag on GitHub and re-check for
    `public static float MetadataVersion =` (field, OK) vs. `=>` (obsolete property, broken)
    before assuming it works.**
  - Confirmed fixed on a real run (2026 session): `monoBehavioursSkipped` dropped from 12,397 (100%
    failure) to 5 out of ~52,947 assets, with 4,180 distinct Chinese strings found.
- Once LibCpp2IL/`classdata.tpk` were both fixed, the dominant remaining noise was `m_Name` (Unity
  GameObject/asset naming, not player-facing text) and a `first` field — both excluded via a
  `IgnoredFieldNames` field-name allowlist-exclusion in `ExtractChineseText`. An earlier
  path-based heuristic (`LooksLikeAssetPath`, matching things like
  `skeleton/battle/obstacle/屏风_1/skeleton.atlas`) was tried and removed — it didn't reliably catch
  the noise; the field-name check is what actually worked. `TextAsset` assets (`m_Script`, whole
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

## PrefabText pipeline (`dumpedPrefabText.txt` → `Files/Mod/dumpedPrefabText.txt.yaml`)

Unlike the CSV pipeline above, a dumped prefab-text file has **no row/column structure** — each
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
- **Still not implemented:** the runtime BepInEx plugin patch in `DragonHeirPlugin/` that actually
  reads `dumpedPrefabText.txt.yaml` and substitutes translated text back into `UI.Text`/`TMP_Text`
  components at runtime.

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

### Game placeholder tokens (`#PlayerName#`)

This game uses `#PlayerName#`-style tokens (`#` + word chars + `#`) as a dynamic placeholder the
game engine substitutes at runtime (player name, etc.). Its position in the sentence can
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
  match elsewhere — see `Tests/KNOWN_ISSUES.md` for confirmed examples:
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
crashes on load" case, see `Tests/KNOWN_ISSUES.md` for the full investigation methodology
(decompiling `GameDataController.LoadAllGameData`, checking `Player.log` when `BepInEx/LogOutput.log`
just stops with no exception, the `StringToSpeAddData` label-lookup heuristic, and verifying a fix
via the packaging-only test fact without a full game relaunch) and to record a new case once solved.

