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
- **`IsPrimaryTextField`'s `"m_Text"`/`"text"` allowlist misses real displayed text on several
  other `MonoBehaviour` fields (2026-08-27 finding, via in-game screenshots of untranslated text)**
  — confirmed for character-creation hero-class template badges (`异士模板`, `弓手模板`, etc.)
  living on a plain `name` field, and more broadly for `eventName`/`tutorialName`/`showName`/
  `bulletName`/`fullName`/`jobName`/`spellName`/`pointName`/`sourceName`/`plotName`. These land in
  `dumpedOtherText.txt` only (diagnostic, not fed into the pipeline) and never get translated as a
  result. Rather than widen `IsPrimaryTextField` itself (risky — `dumpedOtherText.txt`'s `data`
  field mixes real content like `丐帮`/`万安客栈` with internal asset/UI names like
  `下拉菜单_按钮`/`三角形`/`中型树0` on the exact same field name, and `targetName` similarly mixes
  a few real NPC names with internal `临时:强盗头目&随机;;;事件难度+0.5;-8;;true`-style config
  strings), this is now handled by a **second automated dynamic-string extraction source**: see
  `GameFileHandling.ExtractDynamicStringCandidatesFromOtherText` /
  `GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap` /
  `DynamicStringOtherTextFields` below, registered as `FileInputWorkflowTests`'s
  `"1c. ExportDynamicStringsIntoTranslated"` fact (all three extraction sources now run inline at the
  start of that single fact). `data`/`targetName` were sampled
  and found too noisy even after filtering out ASCII-suspicious entries, so they're deliberately
  NOT in `DynamicStringOtherTextFields` — if a future screenshot confirms a real missing string on
  one of those two fields specifically, add it directly to `dynamicStrings.txt` (the file merged in
  from reviewed `output/_dynamicStrings_candidates.txt` entries - see the DynamicStringsIL2CPP
  pipeline section below) rather than promoting the whole field wholesale.
- **A "primary" `text`/`m_Text` field can STILL miss `PrefabTextPatches.cs`'s load-time scan if the
  value is set at runtime rather than baked into the prefab (2026-08-27 finding, via a
  character-creation screenshot showing `Initial获得RandomlyWeapon`, i.e. `初始获得随机武器` only
  partially translated)** — `dumpedOtherText.txt` correctly tagged this value's field as `text`
  (so it wasn't missed by the noise-filtering above), and `Files/Mod/dumpedPrefabText.txt.yaml`
  already has the correct whole-string translation ("Initial random weapon acquisition"). But the
  in-game UI showed a mangled result built from `DynamicStringPatches`' BARE-FRAGMENT dictionary
  entries (`初始`→`Initial`, `随机`→`Randomly`, `武器`→`Weapon`) instead — proof this particular
  component's `.text` is populated by code at runtime (a character-creation starting-bonus choice
  list: gold/reputation/random armor/weapon/manual/horse), not baked into the asset at
  `Resources.Load`/`AssetBundle.LoadAsset`/scene-load time, so `PrefabTextPatches.cs`'s load-time
  tree-walk never sees the real value at that point. **Fixed generally (2026-08-28), not with a
  per-string override**: `PrefabTextPatches.cs` now ALSO postfixes `TMP_Text.text`/`UI.Text.text`'s
  setters (same sink-level pattern `DynamicStringPatches.cs` already used), doing an EXACT
  whole-string lookup against its own `Replacements` dictionary — no separate dictionary/file
  needed, since `dumpedPrefabText.txt.yaml` already has a correct whole-phrase entry for any string
  `AssetDumperWorkflowTests.cs`'s offline scan found (that scan reads each field's serialized
  *default* value, which is exactly what a runtime-populated component is initialized with
  before/when the game sets it). These new postfixes run at `[HarmonyPriority(Priority.First)]`,
  guaranteed to execute before `DynamicStringPatches`' same-named setter postfixes (left at
  default `Priority.Normal`) regardless of which class's Harmony patches were registered first in
  `MainPlugin.Load()` — patch APPLICATION order does not determine POSTFIX EXECUTION order, only
  `HarmonyPriority` does. This means any whole-string match here gets replaced before
  `DynamicStringPatches`' bare-fragment postfix even runs, so there's nothing left for it to
  corrupt. An earlier stopgap (`GameFileHandling.DynamicStringPrimaryTextOverrides`, a narrow
  per-raw-value allowlist feeding these specific strings into the DynamicStrings substring-replace
  dictionary too) was removed once this general fix landed — no per-string overrides needed going
  forward. Genuinely runtime-COMPOSED strings (concatenated with other data, e.g. a save-slot
  description) still correctly fall through unmodified to `DynamicStringPatches`' template/fragment
  matching, since they never byte-match a whole dumped prefab entry.

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

## DynamicStringsIL2CPP pipeline (`dynamicStrings.txt` → `Files/Mod/dynamicStrings.txt.yaml`)

Hardcoded, runtime-assembled string literal fragments compiled directly into IL2CPP game code
(e.g. a `String.Concat`/`String.Format` call mixing a Chinese literal like `"架势"` with data such
as a save-slot's task text) - see the `dynamic-string-translation-plan` repo memory and
`DragonHeirPlugin/DynamicStringPatches.cs`. Handled by
`FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow`, mechanically almost identical to the
PrefabText pipeline above (flat list of distinct strings -> standard TranslationLine YAML ->
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
  distinct results to `output/_dynamicStrings_candidates.txt`, one per line. Run it with `--dll
  <manifest-or-dummy-dll>` (only needs the DLL path to satisfy `Config.Validate`, no
  `--binary`/`--ghidra` required) plus `--output ./output` and `--exclude-file
  ../Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt` to skip fragments already curated. Review
  the candidates file (it includes plenty of noise - debug/internal strings, data already covered
  by the CSV/PrefabText pipelines, etc.) and merge genuine hardcoded UI/dialogue fragments into
  `Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt` - one distinct literal fragment per line
  (just the bare Chinese text, e.g. `架势` - not surrounding whitespace it happens to be
  concatenated with).
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
  template badges like `异士模板` live on a plain `name` field - see the finding above).
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
  - **The `plotText`/`tutorialText`/`choiceText`/`startRemindText`/`describe`/`eventDescribe`/
    `jobDescribe` fields are long paragraphs/sentences on custom data classes (`SinglePlotData`,
    `InnData`, `EventData`-like structures), not baked directly onto a `TMP_Text`/`UI.Text`
    component - this directly contradicts `DragonHeirPlugin/PrefabTextPatches.cs`'s own doc
    comment, which claims these fields "are already populated from the existing CSV workflow, no
    runtime patch needed". Verified empirically wrong: grepped every raw value sampled from these
    fields against every file in `Files/Raw/Dumped/GameData/*.csv` - zero matches for any of them.
    Do not trust that comment for any other field without similarly verifying against the CSVs.
  - Despite being long-form rather than short labels, these still belong in the
    **DynamicStrings** (substring-replace) mechanism, not `PrefabText` (whole-string load-time
    scan) - `PrefabTextPatches.cs` only inspects a `TMP_Text`/`UI.Text` component's `text` value
    once, at `Resources.Load`/`AssetBundle.LoadAsset`/scene-load time, and never re-checks it
    afterward, so it would never see a value assigned later at arbitrary runtime (e.g. when a plot
    dialog or tutorial popup actually opens) - which is exactly when these fields get copied onto
    a UI component's `.text`. `DynamicStringPatches.cs`, by contrast, patches the
    `TMP_Text.text`/`UI.Text.text` **setters** themselves (sink-level, field-agnostic - see its
    `TmpTextSetText_Postfix`/`UiTextSetText_Postfix`), so it catches the value the moment it's
    actually displayed regardless of which source field it came from - exactly what these need.
    `DynamicStringPatches.LoadDictionary` already sorts entries longest-first specifically so a
    full-paragraph entry can never be corrupted by a shorter, unrelated fragment matching part of
    it first, and the existing `GamePlaceholderTokenRegex`/`CheckTransalationSuccessful`
    placeholder-preservation check already runs unconditionally (not just for CSV columns), so no
    new validation was needed for the longer/paragraph case. Each field was sampled for noise the
    same way as the short name-fields before being added (checked for stray ASCII-letter runs not
    part of a `#Placeholder#` token): `plotText` (415 total, 3 suspicious - all confirmed
    legitimate `<color=red>` markup), `choiceText` (160/160 clean), `describe` (247/247 clean),
    `startRemindText` (240/240 clean), `eventDescribe` (27/27 clean), `jobDescribe` (12/12 clean),
    `tutorialText` (308 total, 7 suspicious - all confirmed legitimate key-name references like
    `Shift`/`WSAD`/`Tab` inside `<b>...</b>` tags).
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
  the other sources. Added specifically because two real missing phrases
  (`随机敌人数量`/`非本门弟子经验`) turned out to be a pure staleness problem - the extraction logic
  itself was already correct, but nothing forced re-extraction after a game patch changed
  `_string_map.csv`, so an old on-disk candidates file silently hid new strings. Regenerating
  unconditionally as part of "1c" makes that failure mode structurally impossible going forward.
  No-ops gracefully (does not fail the test) if `Converter/output/_string_map.csv` doesn't exist yet
  (fresh clone, full decompile pipeline not run) or the subprocess fails for any reason - the other
  three sources still work independently. `Converter/Services/StringMapExtractor.cs`'s
  `IsExoticScriptNoise` filter (see `converter.instructions.md`) keeps BCL/ICU internal Unicode-table
  noise strings out of the regenerated candidates before they ever reach this source.
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
- **No per-method configuration needed at runtime** - the static extraction has no way to
  attribute a literal back to the specific Type+Method that concatenates it, so
  `DragonHeirPlugin/DynamicStringPatches.cs` doesn't try to target specific methods at all. Instead
  it reflects over every public static, non-generic, string-returning overload of
  `System.String.Concat`/`System.String.Format` and Harmony-postfixes all of them with one generic
  postfix that applies every `dynamicStrings.txt.yaml` entry as an exact substring replace
  (`__result.Replace(raw, result)`) - this is a plain BCL type, not an IL2CPP-wrapped game type, so
  patching it is an ordinary, fully-safe Harmony patch. Catches the fragment regardless of which
  game method builds the string.

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

