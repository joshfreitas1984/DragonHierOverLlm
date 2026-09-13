# DragonHeirPlugin — crash investigation index

> This file is an **index only**. It is not auto-loaded into agent context (unlike
> `.github/instructions/dragonheirplugin.instructions.md`, which has `applyTo:
> DragonHeirPlugin/**`). Detailed investigation narratives live in per-topic files under
> `DragonHeirPlugin/docs/` — read only the specific doc relevant to your current task, not this
> whole index. When a new investigation narrative is written, add it as a NEW file under
> `DragonHeirPlugin/docs/` (or extend the closest-matching existing one) and add a one-line
> pointer here — never grow this file into a monolith again.

- [`docs/resourceio-csv-merge-abandoned.md`](docs/resourceio-csv-merge-abandoned.md) — why
  `ResourceIoPatches` uses the packaged drop-in `Files/Mod/*.csv` wholesale instead of a
  row-level `CsvMerger.MergeByFirstColumn` merge (column-0-as-stable-ID assumption is false for
  `NameData.csv`); `CsvMerger.cs` has since been deleted entirely as dead code.
- [`docs/unitylogcapture-no-logmessagereceived.md`](docs/unitylogcapture-no-logmessagereceived.md)
  — why `UnityLogCapture` Harmony-patches `UnityEngine.Debug`'s log methods directly instead of
  subscribing to `Application.logMessageReceived` (doesn't exist in this game's interop build).
- [`docs/resetfacesetting-crash-investigation.md`](docs/resetfacesetting-crash-investigation.md) —
  full case study of the `ResetFaceSetting`/`ResetPlayerTag` crash: an encoding-mismatch red
  herring, diagnostic patches, and the CONFIRMED root cause (`GameDataController.
  StringToSpeAddData` aborting `LoadAllGameData` on a translated effect-string column).
- [`docs/costura-embedded-dependencies.md`](docs/costura-embedded-dependencies.md) — why any new
  external NuGet dependency needs both `CopyLocalLockFileAssemblies=true` AND Costura.Fody to
  actually load at runtime.
- [`docs/dynamicstringpatches-template-regex-bug.md`](docs/dynamicstringpatches-template-regex-bug.md)
  — full multi-misdiagnosis narrative behind the `DynamicStringPatches` composite `String.Format`
  template fix (summarized as current-state in `dragonheirplugin.instructions.md`): the
  `DateTime.ToString()` red herring, a logger re-entrancy crash, the actual `Regex.Escape`
  asymmetry root cause, and two further occurrences of the same `StringToSpeAddData`/
  `StringToAttriRatio` bug class on `KungFuData.csv`/`SummonKungFuData.csv`.
- [`docs/dynamicstrings-column-source-extraction.md`](docs/dynamicstrings-column-source-extraction.md)
  — bare-fragment dictionary corruption of whole-phrase compounds (save-slot force/sect names,
  etc.); the `DynamicStringColumnSources`/`DynamicStringLabelColumnSources` config-driven
  extraction fix and the `dynamicStrings*.txt.yaml` glob-loading change.
- [`docs/prefabtext-multiline-and-token-placeholder-bugs.md`](docs/prefabtext-multiline-and-token-placeholder-bugs.md)
  — `PrefabTextPatches` multi-line newline-escaping mismatch, and
  `DynamicStringWorkflow.IsFormatTemplate` missing the game's `#Token#`/`#$Token#` markers.
- [`docs/forcedata-showforceskill-crash.md`](docs/forcedata-showforceskill-crash.md) —
  `ForceData.csv` columns 9/10/11 causing an `ArgumentOutOfRangeException` in
  `HandBookMenuController.ShowForceSkill`; same `SkipColumns` bug class as `HeroTagData`/
  `KungFuData`/`ResourcePointTypeData`.
- [`docs/prefabtextpatches-full-investigation.md`](docs/prefabtextpatches-full-investigation.md) —
  full narrative behind `PrefabTextPatches`: a wrong-scope correction for `plotText`/`describe`
  fields, why lifecycle-callback patches were rejected, an `is`/`as` interop-safety finding, and
  the scene-embedded-UI coverage gap fix.
- [`docs/prefabtextpatches-agent-reference.md`](docs/prefabtextpatches-agent-reference.md) — concise
  ownership, hook-ordering, exact-match, newline, interop, and change-checklist reference for
  agents editing `PrefabTextPatches.cs`.
- [`docs/resourceio-generic-bytearray-classpointerstore-crash.md`](docs/resourceio-generic-bytearray-classpointerstore-crash.md)
  — `ta.bytes` (`Il2CppStructArray<byte>`, a generic wrapper) started throwing
  `Il2CppClassPointerStore<byte>` cctor `NullReferenceException` for every TextAsset, isolated to
  `ResourceIoPatches` since it was the only patch touching a generic struct-array type; fixed by
  reading bytes via raw native calls instead (`GetTextAssetBytesRaw`), not by regenerating
  interop/cache (which does not fix this).
- [`docs/resourceiopatches-agent-reference.md`](docs/resourceiopatches-agent-reference.md) — concise
  whole-file override, raw-byte decoding, encoding fallback, interop-safety, and change-checklist
  reference for agents editing `ResourceIoPatches.cs`.
- [`docs/unitylogcapture-reference.md`](docs/unitylogcapture-reference.md) — concise hook,
  formatting, interop-safety, and change-checklist reference for agents editing
  `UnityLogCapture.cs`.
- [`docs/dynamicstringpatches-cjk-placeholder-fallback.md`](docs/dynamicstringpatches-cjk-placeholder-fallback.md)
  — why some `isTemplate: true` templates' own translated literal connector text was silently
  skipped when their `{n}` placeholder is legitimately CJK data (sect/title names); the
  CJK-inclusive `PermissivePattern` fallback fix, its verification harness methodology, and a
  confirmed (not just theoretical) residual risk around `BlockingRawEntries` coverage.
- [`docs/dynamicstringpatches-adjacent-placeholder-merge.md`](docs/dynamicstringpatches-adjacent-placeholder-merge.md)
  — CONFIRMED BUG #5: templates with zero-literal-gap adjacent placeholders (e.g. force-name +
  title pairs) had no regex anchor and degenerated to 1-char captures, corrupting output (`巨
  鲸帮...`, `仙霞.派`); the per-run safe-merge-vs-reject fix in `BuildCompiledTemplate` and a
  `Match.Index`-vs-list-index dictionary-keying pitfall hit while implementing it. Also covers
  CONFIRMED BUG #6 (same root cause, applies when a placeholder/token is the LAST thing in `Raw`
  with no trailing literal - greedy-quantifier fix for that one final group), CONFIRMED BUG #7
  (widened the per-run safety check to tolerate whitespace-only gaps in `Result`, not just fully
  glued markers - fixed 3/5 of a batch of over-eagerly-rejected templates), and a flagged-but-
  unfixed side finding: `dumpedPrefabTextFromOtherFields.txt.yaml`'s `"在下#$PlayerName#"` template
  is dangerously over-generic and can false-positive-match as a prefix inside unrelated dialogue.
- [`docs/dynamicstringpatches-agent-reference.md`](docs/dynamicstringpatches-agent-reference.md)
  — concise ownership, ordering, loading, template, re-entrancy, performance, and change-checklist
  reference for agents editing `DynamicStringPatches.cs`.
- [`docs/battleinfopatches-trusted-append-only-source.md`](docs/battleinfopatches-trusted-append-only-source.md)
  — the trusted-append-only-source pattern shared by `BattleInfoPatches`/`InfoListPatches`, and a
  CONFIRMED BUG where `BattleInfoPatches` translated each battle-log line but never called
  `MarkTrustedAppendOnlySource` on the underlying `Text` component, silently defeating the
  sink-patch fast path (fixed).
- [`docs/robheroitemchoose-getherofix.md`](docs/robheroitemchoose-getherofix.md) — the
  `RobHeroItemChoose`/`RobHeroItemChoosen` dead-button fix: `WorldData.GetHero` patched directly
  with an as-is/reverse-translate/dot-stripped fallback chain (the real bug was a leftover
  `"Family.Given"` `.` separator, not a translation issue), a re-entrancy guard for the retry call,
  a "translated-looking debug log text" misdiagnosis worth remembering, and why the earlier
  blanket `OnClick_Prefix` callParam reverse-translate was removed instead of kept/flagged.
- [`docs/plottext-width-overflow-investigation.md`](docs/plottext-width-overflow-investigation.md)
  — full narrative behind the `PlotTextBack/PlotText` "grows past screen size" fix: a wrong-node
  misdiagnosis (a separate static backdrop panel, not `PlotTextBack`, was the visible border), why
  clamping `RectTransform.sizeDelta` directly caused position drift (fixed by clamping
  `Text.preferredWidth` instead), and two wrong safe-width-formula guesses before confirming in-game
  which direction the bubble actually grows.
- [`docs/plottextsizepatches-agent-reference.md`](docs/plottextsizepatches-agent-reference.md) —
  concise root-cause, fix-rationale, formula, interop, and change-checklist reference for agents
  editing `PlotTextSizePatches.cs`.
- [`docs/upgradepriority-and-herosearch-diagnostics-removed.md`](docs/upgradepriority-and-herosearch-diagnostics-removed.md)
  — closes out two previously-undocumented temporary diagnostics confirmed resolved in play:
  `PrefabTextPatches`' UpgradePriorityText/"优先" tracing (`IsDiagTarget`/`DiagLog`) and the whole
  `HeroSearchPatches.cs` file (`AddHeroIcon`/`RegenerateHeroIcon` tracing) — both removed, also
  fixing an unnecessary per-call double-translation-pipeline cost in the latter.
- [`docs/performance-optimization-pass-2026-09-13.md`](docs/performance-optimization-pass-2026-09-13.md)
  — buffered `UnityLogCapture` log writes, merged the duplicate `DynamicStringPatches`/
  `PrefabTextPatches` text-setter patches into one pass, cached several hot-path
  `ConfigEntry<bool>.Value` reads, and a CONFIRMED-BAD attempt (reverted) to replace the global
  `Time.deltaTime` getter patch with a `Canvas.willRenderCanvases` subscription -
  `DelegateSupport.ConvertDelegate` crashes the process with a native `AccessViolationException` at
  plugin load in this game build.
- [`docs/herodetailpanel-slow-load-investigation.md`](docs/herodetailpanel-slow-load-investigation.md)
  — **RESOLVED**, confirmed fixed in play. HeroDetailPanel/AreaLog/PlotPanel-RecordScrollView
  slow-open investigation: a single catastrophic-regex-backtracking template hit (up to 2.68-3.15s)
  against AI-generated log narrative text redisplayed across panels from a shared persisted
  `recordLog` field; a CONFIRMED-BAD, reverted first attempt that translated at the source
  (`HeroData.AddLog`/`AreaData.AddLog`) and would have baked English into save files permanently; a
  first (bounding, not eliminating) fix (compiled-template `MatchTimeout`, raised exact-string
  memoization cache, read-only background cache pre-warm on new log entries); the actual root
  cause found afterward - `HeroData.GetRecordLog`/`AreaData.GetRecordLog` building the displayed
  blob via a loop of `String.Concat` calls, each iteration re-running the FULL template corpus
  against the ever-growing blob - fixed by `RecordLogDisplayPatches.cs` replacing those methods
  entirely; and two further bugs found while confirming that fix in play: a new Harmony patch class
  written but never registered (`Harmony.CreateAndPatchAll` never called on it - silently dead
  code), and a `PerfInstrumentation.PeriodicTick` "Collection was modified" crash (likely same-
  thread `Time.deltaTime` reentrancy) fixed with a swap-based drain plus a reentrancy-detection log.
  Also covers the temporary `PerfInstrumentation.cs` diagnostic (off by default) used throughout.
- [`docs/recordlog-translation-naturalness.md`](docs/recordlog-translation-naturalness.md) —
  **DONE**, confirmed working in play. Naturalized the awkward/mechanically-fragment-translated
  `HeroData.AddLog`/`AreaData.AddLog` narrative lines via `Tests/TranslationPackaging.
  DynamicStringResultOverrides`, and isolated all 69 confirmed log-narrative templates into their
  own `dynamicStringsLogNarratives.txt` pipeline file/category (`Tests/DynamicStringSources.
  LogNarrativeTemplates`, re-derivable via `Converter/Scripts/ExtractAddLogTemplates.ps1`) - which
  in turn enabled the runtime perf stretch goal documented above.
- [`docs/globaldata-tier-scale-overrides.md`](docs/globaldata-tier-scale-overrides.md) —
  **DONE**, confirmed working in play. `BattleEndUI/Rate` and `Attris/*/Lv`'s grade-scale text
  (originally single characters like 冠/绝) was auto-mistranslated ("You"/"Zhen"/"Repeat") via
  `LTLocalization.GetText` at `GlobalData` static-list construction time - unreachable by
  `DynamicStringPatches`'/`PrefabTextPatches`' normal dictionaries. Two failed diagnosis attempts
  (trusting decompiled pseudocode field-offset names; reflecting for `FieldInfo`s instead of
  `PropertyInfo`s - this interop build exposes every field as a property) before a value-search
  diagnostic found the real owners (`GlobalData.BattleScoreText`/`AttriRatioString`/
  `TreasureValueLvName`/`EquipmentWeightLvName`); `GlobalDataListOverrides.cs` now overwrites them
  directly via reflection. Flags GlobalData likely has more of the same undiscovered class of bug
  (a long tail of similarly-named `...LvName`/`...LvText` static lists never checked).

