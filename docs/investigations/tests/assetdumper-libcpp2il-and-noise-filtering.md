# Asset dumper: `Samboy063.LibCpp2IL` version pin + field-name noise filtering

> Read this when working on `AssetDumperWorkflowTests.cs` — either the `Cpp2IL`/`classdata.tpk`
> setup, or deciding which `MonoBehaviour` field names should feed the pipeline.

## Overview: what `AssetDumperWorkflowTests.DumpChineseTextFromAssets` does

A standalone, one-off discovery tool (not part of the numbered pipeline) that scans
`<GameFileHandling.GameFolder>\LongYinLiZhiZhuan_Data` for Chinese text baked directly into
prefabs/`MonoBehaviour`/`TextAsset` serialized fields — hardcoded UI text that never goes through
the CSV pipeline. It's the offline counterpart to `FanslationStudio.Plugins.Shared`'s
`PrefabTextDumperService` (walks *loaded* GameObjects at runtime via Harmony + UnityEngine
reflection, which can't run here since `Tests` has no Unity runtime). Instead it uses
`AssetsTools.NET` to statically parse `.assets`/`.bundle`/`.unity3d` files: IL2CPP only affects how
the game's compiled code is generated, not the Unity `SerializedFile` container format, so no game
process/Harmony/IL2CPP-awareness is needed to read them.

- Unlike `PrefabTextDumperService` (external bundles only), this scan also opens
  `globalgamemanagers`/`level*`/`sharedassets*` directly — same `SerializedFile` format, just no
  extension, and `AssetsManager.LoadAssetsFile` reads them regardless. `IsCandidateAssetFile`
  filters out `.resS`/`.resource` (raw data blobs, no `SerializedFile` header) and `.manifest`
  (plain-text bundle metadata). `ScanFile` dispatches on extension:
  `.unity3d`/`.assetbundle`/`.bundle` → `AssetBundleFile`/`LoadBundleFile`; everything else
  (`.assets` or no extension) → `LoadAssetsFile` directly.
- Walks every deserialized field on every asset (not a fixed allowlist) for a string matching the
  same `\p{IsCJKUnifiedIdeographs}` pattern as `DragonHeirPlugin/MainPlugin.cs`'s
  `ChineseCharPattern`, writing unique matches to `Files/Raw/Dumped/PrefabText/dumpedPrefabText.txt`.
- `classdata.tpk` (optional, from `nesrak1/UABEA` releases) covers built-in engine types
  (`Texture2D`/`GameObject`) only when a release build stripped their type trees — it does not
  help `MonoBehaviour` assets, whose field layout is defined by the game's own script code.
  `MonoBehaviour` fields (where most hardcoded UI text lives) instead require
  `Cpp2IlTempGenerator` from `AssetsTools.NET.Cpp2IL`, wired via `manager.MonoTempGenerator = new
  Cpp2IlTempGenerator(metadataPath, gameAssemblyPath)` using the same `GameAssembly.dll` +
  `global-metadata.dat` paths `Converter/Program.cs` auto-discovers for this game. A near-empty
  result almost always means the scan couldn't resolve `MonoBehaviour` fields — check the printed
  `monoBehavioursSkipped` count before concluding no Chinese prefab text exists.
- Noise filtering: `m_Name`/`first` fields excluded via `IgnoredFieldNames` (a path-based
  heuristic was tried and removed — didn't reliably catch the noise). `TextAsset` assets are
  skipped entirely before field-walking, and `MaxStringLength = 2000` guards against unexpectedly
  huge string fields.
- Output is split by `IsPrimaryTextField` (exact, case-insensitive match on `"m_Text"`/`"text"` —
  the field names `UI.Text`/`TMP_Text` use for their rendered-text field): `dumpedPrefabText.txt`
  gets ONLY those strings, one per line, matching what `PrefabTextWorkflow.ExportPrefabTextToCustomFormat`
  expects. Everything else from the generic field walk (`plotText`, `tutorialText`, `choiceText`,
  `eventDescribe`, `startRemindText`, etc.) goes to `dumpedOtherText.txt` in `{text}\t[{field}]`
  format and is diagnostic only — not fed into the translation pipeline.
- `dumpedPrefabText.txt` feeds directly into the numbered workflow via
  `GameFileHandling.ExportPrefabTextAssetToCustomFormat` (`FileInputWorkflowTests`'s
  `"1b. ExportPrefabTextIntoTranslated"`, run right after step 1, before step 2's merge) — see
  `docs/features/translation-pipeline/prefabtext-pipeline-architecture.md`.
- `IsPrimaryTextField`'s allowlist misses real displayed text on several other fields (`name`,
  `eventName`/`tutorialName`/`showName`/`bulletName`/`fullName`/`jobName`/`spellName`/`pointName`/
  `sourceName`/`plotName`) — these land in `dumpedOtherText.txt` only. Handled via the automated
  dynamic-string extraction sources (`ExtractDynamicStringCandidatesFromOtherText`/
  `ExtractDynamicStringCandidatesFromIl2CppStringMap`/`DynamicStringOtherTextFields`, see
  `docs/features/translation-pipeline/dynamicstrings-pipeline-architecture.md`) rather than widening `IsPrimaryTextField`
  (risky — `data`/`targetName` mix real content with internal asset/UI names on the same field).

## `Samboy063.LibCpp2IL` NuGet version pin investigation

`AssetsTools.NET.Cpp2IL` 3.0.4's nuspec only declares a *minimum* dependency on
`Samboy063.LibCpp2IL >= 2022.0.7.2`, so a plain restore picks the wrong version and MonoBehaviour
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
  `/v2/package-versions` endpoints, with and without `includePrerelease`) — comes from LibCpp2IL's
  later `LibCpp2IlContext` refactor, where `LibCpp2IlMain.MetadataVersion` (and `.Initialize`,
  `.TheMetadata`, etc.) became `[Obsolete]` *properties* delegating to a context object instead of
  plain static fields. `AssetsTools.NET.Cpp2IL.dll` 3.0.4's IL still does a direct field access
  (`ldsfld`) against `LibCpp2IlMain.MetadataVersion`, so these throw `Field not found:
  'LibCpp2IL.LibCpp2IlMain.MetadataVersion'` for every MonoBehaviour instead.
- **The correct, officially-published version is `2022.1.0-pre-release.13`** (paired with
  `AssetRipper.Primitives 2.1.0`, per its nuspec) — confirmed by fetching `LibCpp2IlMain.cs` at
  that exact git tag on `SamboyCoding/Cpp2IL` and verifying it has *both* the 3-arg
  `Initialize(byte[], byte[], UnityVersion)` overload *and* still declares `MetadataVersion` as
  `public static float MetadataVersion = 24f;` (a real field, not yet refactored to the
  obsolete-property/context model). This is pinned explicitly in `Tests.csproj` alongside
  `AssetRipper.Primitives 2.1.0` — **if either version is ever bumped, re-fetch `LibCpp2IlMain.cs`
  at the new tag on GitHub and re-check for `public static float MetadataVersion =` (field, OK)
  vs. `=>` (obsolete property, broken) before assuming it works.**
- Confirmed fixed on a real run (2026 session): `monoBehavioursSkipped` dropped from 12,397 (100%
  failure) to 5 out of ~52,947 assets, with 4,180 distinct Chinese strings found.

Also confirmed same session: `otherAssetsSkipped` vastly outnumbered `monoBehavioursSkipped`
(40,489 vs 12,458 out of ~52,947 assets, 0 strings found) before a `classdata.tpk` was added —
meaning the dominant failure wasn't `MonoBehaviour`/Cpp2IL resolution at all, it was that this
release build strips type trees from **every** asset class (`TypeTreeEnabled == false`), and with
no `classdata.tpk` loaded, built-in engine types (`GameObject`, `Transform`, `Texture2D`, etc.)
have no `ClassDatabase` to describe their layout either. A `classdata.tpk` matching Unity
`2020.3.48f1` was needed on top of the `Cpp2IlTempGenerator` MonoBehaviour fix. Sourced from the
`nesrak1/UABEA` release (not `nesrak1/AssetsTools.NET`'s own releases — those don't ship one),
placed at `Tests/classdata.tpk` — this alone dropped `otherAssetsSkipped` from 40,489 to 2.

## Field-name noise-filtering and runtime-vs-load-time text findings

- Once LibCpp2IL/`classdata.tpk` were both fixed, the dominant remaining noise was `m_Name` (Unity
  GameObject/asset naming, not player-facing text) and a `first` field — both excluded via an
  `IgnoredFieldNames` field-name allowlist-exclusion in `ExtractChineseText`. An earlier
  path-based heuristic (`LooksLikeAssetPath`, matching things like
  `skeleton/battle/obstacle/屏风_1/skeleton.atlas`) was tried and removed — it didn't reliably
  catch the noise; the field-name check is what actually worked.
- **`IsPrimaryTextField`'s `"m_Text"`/`"text"` allowlist misses real displayed text on several
  other `MonoBehaviour` fields** — confirmed for character-creation hero-class template badges
  (`异士模板`, `弓手模板`, etc.) living on a plain `name` field, and more broadly for
  `eventName`/`tutorialName`/`showName`/`bulletName`/`fullName`/`jobName`/`spellName`/`pointName`/
  `sourceName`/`plotName`. These land in `dumpedOtherText.txt` only (diagnostic, not fed into the
  pipeline) and never get translated as a result. Rather than widen `IsPrimaryTextField` itself
  (risky — `dumpedOtherText.txt`'s `data` field mixes real content like `丐帮`/`万安客栈` with
  internal asset/UI names like `下拉菜单_按钮`/`三角形`/`中型树0` on the exact same field name, and
  `targetName` similarly mixes a few real NPC names with internal
  `临时:强盗头目&随机;;;事件难度+0.5;-8;;true`-style config strings), this is handled instead by
  the automated dynamic-string extraction sources
  (`ExtractDynamicStringCandidatesFromOtherText`/`ExtractDynamicStringCandidatesFromIl2CppStringMap`/
  `DynamicStringOtherTextFields`, see the DynamicStringsIL2CPP pipeline section of
  `tests-translation-workflow.instructions.md`). `data`/`targetName` were sampled and found too
  noisy even after filtering out ASCII-suspicious entries, so they're deliberately NOT in
  `DynamicStringOtherTextFields` — if a future screenshot confirms a real missing string on one of
  those two fields specifically, add it directly to `dynamicStrings.txt` rather than promoting the
  whole field wholesale.
- **A "primary" `text`/`m_Text` field can STILL miss `PrefabTextPatches.cs`'s load-time scan if the
  value is set at runtime rather than baked into the prefab** (found via a character-creation
  screenshot showing `Initial获得RandomlyWeapon`, i.e. `初始获得随机武器` only partially
  translated) — `dumpedOtherText.txt` correctly tagged this value's field as `text` (so it wasn't
  missed by the noise-filtering above), and `Files/Mod/dumpedPrefabText.txt.yaml` already has the
  correct whole-string translation ("Initial random weapon acquisition"). But the in-game UI
  showed a mangled result built from `DynamicStringPatches`' BARE-FRAGMENT dictionary entries
  (`初始`→`Initial`, `随机`→`Randomly`, `武器`→`Weapon`) instead — proof this particular
  component's `.text` is populated by code at runtime (a character-creation starting-bonus choice
  list: gold/reputation/random armor/weapon/manual/horse), not baked into the asset at
  `Resources.Load`/`AssetBundle.LoadAsset`/scene-load time, so `PrefabTextPatches.cs`'s load-time
  tree-walk never sees the real value at that point. **Fixed generally, not with a per-string
  override**: `PrefabTextPatches.cs` now ALSO postfixes `TMP_Text.text`/`UI.Text.text`'s setters
  (same sink-level pattern `DynamicStringPatches.cs` already used), doing an EXACT whole-string
  lookup against its own `Replacements` dictionary — no separate dictionary/file needed, since
  `dumpedPrefabText.txt.yaml` already has a correct whole-phrase entry for any string
  `AssetDumperWorkflowTests.cs`'s offline scan found (that scan reads each field's serialized
  *default* value, which is exactly what a runtime-populated component is initialized with
  before/when the game sets it). These new postfixes run at `[HarmonyPriority(Priority.First)]`,
  guaranteed to execute before `DynamicStringPatches`' same-named setter postfixes (left at
  default `Priority.Normal`) regardless of which class's Harmony patches were registered first in
  `MainPlugin.Load()` — patch APPLICATION order does not determine POSTFIX EXECUTION order, only
  `HarmonyPriority` does. An earlier stopgap (`GameFileHandling.DynamicStringPrimaryTextOverrides`,
  a narrow per-raw-value allowlist) was removed once this general fix landed. Genuinely
  runtime-COMPOSED strings (concatenated with other data, e.g. a save-slot description) still
  correctly fall through unmodified to `DynamicStringPatches`' template/fragment matching, since
  they never byte-match a whole dumped prefab entry.
