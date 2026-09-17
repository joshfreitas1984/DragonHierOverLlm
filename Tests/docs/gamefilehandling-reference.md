# `GameFileHandling` reference

This game's translation pipeline is split across several focused files under `Tests/` (each kept small on purpose):

- **`GameFileHandling.cs`** — `WorkingDirectory`/`GameFolder` constants, the LLM repair/validation hooks (`RepairKnownLlmQuirks`, `RepairGameSpecificColumn`, `ValidateGameSpecificColumn`, `ExcludeFunctionRoutedDynamicStringFromQc`), `SplitterOptions`, and the shared CSV helpers (`ParseCsvRow`/`RebuildCsvRow`/`StripTrailingCommaBeforeQuote`).
- **`TextFileConfiguration.cs`** — `TextFileConfiguration.TextFilesToSplit`, the authoritative per-file translation/package configuration.
- **`DynamicStringSources.cs`** — the column-source tables (`DynamicStringSources.DynamicStringColumnSources`, `AtlasSpriteNameColumnSources`, `DynamicStringSources.DynamicStringLabelColumnSources`, `DynamicStringNamePartColumnSources`, `DynamicStringSources.DynamicStringTempNpcNameColumnSources`, `DynamicStringInteractionOptionColumnSources`, `DynamicStringSources.DynamicStringOtherTextFields`) and the extraction regexes.
- **`DynamicStringExtraction.cs`** — the `Extract*` passes that populate `Raw/Dumped/DynamicStrings/*.txt`, plus `DedupeDynamicStringFiles`.
- **`TranslationExport.cs`** — `TranslationExport.ExportGameSpecificTextAssetsToCustomFormat`, `ExportPrefabTextAssetToCustomFormat`, `ExportDynamicStringTextAssetToCustomFormat`.
- **`TranslationPackaging.cs`** — `TranslationPackaging.PackageFinalTranslationAsync` and the packaging-time result overrides/filters.

The detailed rationale for their configuration and hooks is recorded here.

## Shared splitter configuration

`CompoundFieldSplitter` remains game-agnostic. This game opts into `#...#` placeholder recognition through `SplitterOptions`, including the `$`-prefixed forms `#$PlayerName#`, `#$SourceInteractName#`, and `#$TargetInteractName#`. Placeholders are absorbed into adjacent translatable fragments so an LLM may move them; `RepairKnownLlmQuirks` restores common wrapper corruption and `ValidateGameSpecificColumn` rejects dropped tokens. The LLM repair is literal insertion rather than regex replacement because valid replacement tokens can contain `$`.

CSV parsing and reconstruction must always use `CompoundFieldSplitter.ParseCsvRow` and `RebuildCsvRow`. `TranslationExport.ExportGameSpecificTextAssetsToCustomFormat` decomposes each non-skipped cell into fragments and a `FieldTemplate`; trivial whole-cell values use a plain split. `TranslationPackaging.PackageFinalTranslationAsync` reconstructs templated cells positionally and leaves skipped columns byte-for-byte from the raw row.

## Column safety policy

`TextFileConfiguration.TextFilesToSplit` is the authoritative translation/package configuration. `SkipColumns` is for non-user-facing values or values used as exact runtime lookup/routing keys. It protects resource paths, categories, effect labels, relationship and skill names, force references, tags, and other structured values whose translation would break `GameDataController` lookups or silently lose data. The current per-file list reflects investigations indexed in [KNOWN_ISSUES.md](../KNOWN_ISSUES.md), especially:

- [skipcolumns-stringtospeadddata-family.md](skipcolumns-stringtospeadddata-family.md)
- [kungfudata-stringtoattriratio-fatal.md](kungfudata-stringtoattriratio-fatal.md)
- [spehero-relationship-and-skillfocus-crashes.md](spehero-relationship-and-skillfocus-crashes.md)

`PlotData.csv` column 9 is intentionally translated. Its `|` and `;` delimiters are structural, so `RepairGameSpecificColumn` strips those characters from translated choice text and `ValidateGameSpecificColumn` checks delimiter counts as a backstop. Separately, `TranslationPackaging.RepairRobHeroItemChooseCallParam` runs at packaging time (after `CsvGameDataWorkflow.PackageAsync` writes `Files/Mod/PlotData.csv`) and forces the `"{0};RobHeroItemChoose;{1}"` template's `{1}` slot back to its own raw text — that callParam is looked up by raw Chinese name at runtime and must never be translated. Deliberately packaging-time, not a translation-time `CustomColumnRepair` rule, and deliberately scoped by the actual template text read back from `Files/Converted/PlotData.csv.yaml` rather than by fragment position alone. See [plotdata-column9-crash-and-repair-pattern.md](plotdata-column9-crash-and-repair-pattern.md) and [robheroitemchoose-getherofix.md](../../DragonHeirPlugin/docs/robheroitemchoose-getherofix.md).

### Quality review hooks

`GameFileHandling.Hooks.CustomQcExclusionRule` (`ExcludeFunctionRoutedDynamicStringFromQc`) keeps this game's `dynamicStrings.txt` dialogue-choice/function-routing entries (`"{label};FunctionName"`, the same structural shape as `PlotData.csv` column 9 above) out of the quality review pass entirely — no LLM call, no reliance on a validator to catch a corrupted correction after the fact, since none is registered for this file. See [dynamicstrings-pipeline-architecture.md](dynamicstrings-pipeline-architecture.md#quality-review-exclusion-for-function-routed-choice-entries) for the full rationale and the shared library's `quality-review-pass-architecture.md` for the general `CustomQcExclusionRule` mechanism.

`ExcludePlotChoiceColumnFromQc` (combined with the rule above via the same `CustomQcExclusionRule` delegate) does the equivalent for `PlotData.csv` column 9 itself. Unlike the initial translation pass, which repairs/validates one `choiceText` fragment at a time via `RepairGameSpecificColumn`/`ValidateGameSpecificColumn` (see [plotdata-column9-crash-and-repair-pattern.md](plotdata-column9-crash-and-repair-pattern.md)), the QC review pass hands the model the whole reconstructed cell to "improve" — and a model asked to smooth a multi-choice `"text;FunctionName;0|text;FunctionName;1"`-shaped blob into fluent prose reliably drops every `|`/`;` it contains. The validator already rejects any such corrupted correction (confirmed via a real triage cluster: 33 proposed corrections for this shape, all rejected for the same `|`-count mismatch), so no data was ever at risk of corruption — the exclusion exists purely to stop generating QC work items that are guaranteed to fail forever. Any raw column-9 cell containing `|` or `;` is excluded, which covers both the multi-choice pipe-joined shape and a single `"choiceText;FunctionName[;param]"` entry with no `|` at all.

### Packaging-time overrides for runtime-color-placeholder templates

`TranslationPackaging.DynamicStringResultOverrides` includes 44 `dynamicStrings.txt` raw strings
where a `<color=...>` opening tag is a runtime-computed game value (substituted through a `{n}`
placeholder) but the matching `</color>` is literal text in the raw string — no mechanical validator
can verify a freely-reworded translation keeps that placeholder positioned correctly relative to the
literal close, since normal grammatical word-order changes are otherwise indistinguishable from a
corruption that silently detaches the color span. These force the correct whole-raw → whole-result
translation post-packaging, same mechanism (and same reason: `CompoundFieldSplitter` decomposes the
raw string into fragments an LLM/QC hook can only ever see individually, never as the whole
template) as every other entry in that dictionary. See
[dynamicstrings-dangling-color-tag-templates.md](dynamicstrings-dangling-color-tag-templates.md) for
the originating bug (a dropped `</color>` in the Enhance-UI string), a reverted first-attempt fix at
the translation-hook layer that never actually fired, and the scan methodology used to find all 44
candidates.

### `TextFileConfiguration.TextFilesToSplit` per-file skip-column detail

Moved here from source comments during the 2026-09 comment refactor (source of truth is still the `SkipColumns` list itself; this is rationale, not configuration):

- **`BuildingData.csv`** cols 8/9/10/12 (每月产出/每月维护/加成/升级消耗) are `Label<sign><number>` cells matched via `String.Contains`/`String.Replace` against a fixed resource-name list (col 10 also against `forceSpeAddDataBase`'s label list) in `GameDataController`'s BuildingData load loop. Col 11 (增加效率) stores its label half as `AreaBuildingRateChange.targetBuildingName`, a building-name lookup key.
- **`ForceData.csv`** col 2 (行事风格) is exact-matched against the hardcoded literal "中庸" in `ForceData.cs` (`String.Equals(this.forceStyle,"中庸",0)`) to drive sect behavior.
- **`HeroTagData.csv`** col 1 (名称) is itself the exact-match lookup key `SpeHeroData.csv`'s raw 标签/Tags column is compared against via `GameDataController.GetTagID`.
- **`KungFuData.csv`** (shared with `SummonKungFuData.csv`): cols 17/18 (攻击架势/防御架势) parsed by `PartPostureData`'s ctor via `String.Contains` against a fixed body-part vocabulary; col 23 (特效) stores `SkillSpeEffectData.speName`, exact-matched and concatenated into a `Resources.Load("SpeEffect/"+speName)` path; col 24 (使用武器) concatenated into `Resources.Load("武器/"+weaponName)` (`HeroData.SetHeroWeapon`/`SetSkillWeapon`); col 21 (动作) is the Spine `animationName` passed to `SkeletonData.FindAnimation`; col 25 (伤害顺序) is `Enum.Parse`'d into `skillDamageOrder`. Col 3 (名字) is additionally cross-referenced by `GetSkillID` against `SpeHeroData.csv` col 13's raw skill names — this cross-reference does **not** apply to `SummonKungFuData.csv`, whose col 3 stays safe to translate because `GetSkillID` only scans `kungfuSkillDataBase`.
- **`SpeAddDataBase.csv`** col 11 (特效价值类别/fightValueType) is exact-matched against "我方"/"敌方"/"伤害" in `HeroSpeAddDataBase.GetDescribe`/`GetTriggerDescribe`/`GetTargetDescribe`. Cols 3/4/10 are concatenated for display only (no lookup found).
- **`TechDataBase.csv`** col 4 (加成对象) is exact-matched via `String.Equals` against `ForceSpeAddDataBase.name`; col 8 (消耗资源) goes through the same `FUN_1817ff280` name-lookup dictionary used for force/weapon name resolution elsewhere.
- **`SpeHeroData.csv`** (disabled entirely): confirmed cause of the `GameController.GenerateHeroData` `ArgumentOutOfRangeException` crash at new-game hero generation is col 2 (性别/Gender), exact-matched against 男/女.
- **`PlotData.csv`** cols 1/2 (角色左/角色右, speaker name) are NOT just a cosmetic display label: confirmed 2026-08-28 both columns can also encode a structured `临时:Name&Gender;Age;RelationLevel[;...]` temporary-NPC-spawn record (e.g. `临时:莺莺&女;24;0;4`) parsed by `PlotController.GetHeroData`/`GetTempPlotHeroData` at runtime (strips the `临时:` prefix, splits on `&` then `;` — see `Converter/output/_NoNamespace/PlotController.cs` ~line 1514/1561); translating name/gender fragments inside that record risks breaking the parse, and the column can't be split further than whole-column. Col 3 (高亮方) is exact-matched against "左"/"右"/"无"/"皆". Col 4 (背景图片) is a background sprite reference. Col 5 (背景音乐) is concatenated/passed to `BGMController.SetPlotBgm`. Col 6 (播放音效) is concatenated into `"Sound/SoundEffect/"+value` (or `"Sound/"+value` for "Environment" cases) and passed to `Resources.Load`. Col 8 (调用函数) is split on `;`/`-` and dispatched via `Component.SendMessage(this, functionName, ...)`.

### `DynamicStringSources.DynamicStringColumnSources` defense-in-depth entries

Added 2026-08-29. `ResourcePointData.csv`/`ResourcePointTypeData.csv`/`AreaData.csv` column 1 (Name) is already fully translated via the normal per-row CSV pipeline (none of them `SkipColumns` it), so this isn't filling a coverage gap — it's a safety net for runtime-composed strings that concatenate these names together outside any single CSV row (e.g. an owner-prefixed resource-point display list like "杭州甘泉" — `AreaData.areaName` + `ResourcePointData.resourcePointName` joined with `\n`), which never flow through the CSV pipeline at all, only through `DynamicStringPatches`' substring dictionary.

`SpeHeroData.csv` columns 5 (等级/position title, e.g. 掌门/副掌门) and 15 (绰号/nickname, e.g. "无为真人") were added the same day for the same reason: since the file is fully disabled in `TextFileConfiguration.TextFilesToSplit`, its display text never reaches the CSV pipeline at all. Nicknames were previously getting corrupted by `DynamicStringPatches`' bare single-character dictionary entries (e.g. "无"->"None", "为"->"For" matching inside "无为真人", producing "None For 真人") because no whole-phrase entry existed to win the longest-match-first ordering; extracting the whole nickname fixes every hero uniformly.

### Temp-NPC name extraction (`DynamicStringSources.DynamicStringTempNpcNameColumnSources`)

Confirmed 2026-09-03 while investigating an untranslated "老农" NPC nameplate: `PlotData.csv` columns 1/2's temp-NPC-spawn record (see above) contains a bare Name fragment that, unlike a plain speaker name already covered via `SpeHeroData`'s own name columns, is genuinely new text that exists nowhere else and is never picked up by any other extraction source. `TempNpcNameRegex` extracts it as its own standalone candidate so it reaches `DynamicStringPatches`' ordinary substring dictionary, the same mechanism as existing bare `临时:X` entries.

Confirmed 2026-09-06 while investigating an untranslated "雷彤" NPC nameplate: the "plain speaker name already covered via `SpeHeroData`'s own name columns" assumption above only holds for recruitable heroes - plot-only characters like 雷彤 have no row in `SpeHeroData.csv` (or any other GameData CSV), so a plain (non-`临时:`) cell in these columns can be genuinely new text too, displayed raw via the exact same nameplate component-text setter as the temp-NPC case. The extractor now emits the whole cell verbatim whenever `TempNpcNameRegex` doesn't match, so both a `临时:X` record and an ordinary permanent-NPC name reach the dictionary from this one source.

### Structured-record fragment extraction (`DynamicStringExtraction.ExtractStructuredRecordFragmentCandidates`)

Confirmed 2026-08-30 via a clinic/hospital interaction-menu screenshot case ("技能 影响:医术"): some structured `Name;TriggerId;Condition...;Description`-shaped records are hardcoded string literals baked directly into game code (not CSV-driven), so the IL2CPP scan has no notion of the field shape and dumps the whole `;`-joined literal as one candidate (e.g. `包扎;HospitalCureExternalInjury;;;技能影响:医术`). Only the individual CJK fields are ever displayed, so the whole-string entry never matches at runtime, and `DynamicStringPatches`' dictionary then falls back to shorter standalone fragments, corrupting text like "技能影响:医术" into "Skills 影响:Medicine".

### Non-Chinese dynamic-string entry filter history

`TranslationPackaging.RemoveNonChineseDynamicStringEntries` was originally a digit-only check (preventing symptoms like `DynamicStringPatches.cs`'s `ApplyDictionary` turning "50%" into "5 0 %" or "100/100" into "1 0 0 / 1 0 0"), extended 2026-08-29 after finding the same class of bug from non-digit junk — e.g. IL2CPP string-map extraction occasionally capturing a Unicode-range glyph-atlas coverage dump (`-.09AZ__az··ÀÖØöøıĴľŁ...一龥`) or a plain ASCII/Latin identifier with no Chinese at all.

### `TranslationPackaging.DynamicStringResultOverrides` background

The `"{0}年{1}月{2}日"` case is a save-slot date built via `DateTime.ToString()` (see `DynamicStringPatches.cs`'s `_compiledTemplates` comments).

## Prefab text and dynamic-string sources

`dumpedPrefabText.txt` and `dumpedPrefabTextFromOtherFields.txt` are flat, exact-match `PrefabText` inputs. The first comes from primary `m_Text`/`text` fields; the second comes from the explicitly sampled allowlist in `DynamicStringSources.DynamicStringOtherTextFields`. They are packaged by `PrefabTextWorkflow` and consumed by the plugin's setter-level exact lookup. The asset-dumper and field-selection rationale is in [assetdumper-libcpp2il-and-noise-filtering.md](assetdumper-libcpp2il-and-noise-filtering.md) and [prefabtext-pipeline-architecture.md](prefabtext-pipeline-architecture.md).

`dynamicStrings.txt` and `dynamicStringsFromColumns.txt` are flat `DynamicStringsIL2CPP` inputs used for substring replacement. `DynamicStringSources.DynamicStringColumnSources` extracts whole phrases from selected CSV columns; `DynamicStringSources.DynamicStringLabelColumnSources` extracts repeated labels from structured `Label<number>`/`Label+number` cells without translating the source columns. The IL2CPP source refreshes `_dynamicStrings_candidates.txt` from the current string map on every workflow run and safely no-ops when the converter output is unavailable. See [dynamicstrings-pipeline-architecture.md](dynamicstrings-pipeline-architecture.md) and [dynamicstrings-extraction-sources.md](dynamicstrings-extraction-sources.md).

`DynamicStringExtraction.ExtractDynamicStringCandidatesFromOtherText`, `DynamicStringExtraction.ExtractDynamicStringCandidatesFromColumns`, and `DynamicStringExtraction.ExtractDynamicStringCandidatesFromIl2CppStringMap` are idempotent: they deduplicate against the master dump and their previous output. The first reads YAML entries as dictionaries because the dumped-entry record has no parameterless constructor.

## Packaging behavior

`TranslationPackaging.PackageFinalTranslationAsync` sends PrefabText and DynamicStringsIL2CPP files through their dedicated workflows, then reconstructs only regular CSV files. A fragment is unsafe when it is flagged, not safe to translate, or has a missing result despite non-empty source text; for regular CSV rows the complete raw line is retained in that case (a CSV row structurally must have something in every column). For PrefabText/DynamicStringsIL2CPP files, as of 2026-09-16 that line is instead omitted from the packaged dictionary entirely rather than packaged with raw Chinese text — see [`qc-run-startup-crash-investigation-2026-09-15.md`](qc-run-startup-crash-investigation-2026-09-15.md) for why (a real game-startup-breaking incident caused by an explicit raw-Chinese packaged entry). A QC-rejected correction similarly falls back to the column's ordinary pre-QC translation rather than raw text for every file type. The reported counts include all dedicated-workflow entries and regular CSV rows.

## Workflow ordering

The numbered facts in `FileInputWorkflowTests` are manual pipeline steps. Run the asset-dumper before the PrefabText extraction when new prefab text is needed; run CSV and IL2CPP candidate extraction before their corresponding exports. Export/merge steps are deliberately left to the operator because they mutate accumulated translation state. Packaging is safe to rerun from `Files/Converted`.
