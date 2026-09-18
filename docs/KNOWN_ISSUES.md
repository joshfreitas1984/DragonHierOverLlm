# DragonHierOverLlm known issues

This file is an index only. Investigation narratives and current-state references live under the
root `docs/` taxonomy.

## Translation pipeline

- [GameFileHandling reference](features/translation-pipeline/gamefilehandling-reference.md)
- [DynamicStrings pipeline architecture](features/translation-pipeline/dynamicstrings-pipeline-architecture.md)
- [PrefabText pipeline architecture](features/translation-pipeline/prefabtext-pipeline-architecture.md)
- [Asset dumper LibCpp2IL and noise filtering](investigations/tests/assetdumper-libcpp2il-and-noise-filtering.md)
- [DynamicStrings dangling color-tag templates](investigations/tests/dynamicstrings-dangling-color-tag-templates.md)
- [DynamicStrings dialogue-button fix](investigations/tests/dynamicstrings-dialogue-button-fix.md)
- [DynamicStrings extraction sources](investigations/tests/dynamicstrings-extraction-sources.md)
- [GenerateHero unresolved crash](investigations/tests/generatehero-unresolved-crash.md)
- [PlotData column 9 crash and repair pattern](investigations/tests/plotdata-column9-crash-and-repair-pattern.md)
- [QC quality-score noise investigation](investigations/tests/qc-qualityscore-noise-investigation.md)
- [QC startup crash investigation](investigations/tests/qc-run-startup-crash-investigation-2026-09-15.md)
- [SkipColumns StringToSpeAddData family](investigations/tests/skipcolumns-stringtospeadddata-family.md)
- [SpeHero relationship and skill-focus crashes](investigations/tests/spehero-relationship-and-skillfocus-crashes.md)

## Converter

- [NativeMethodExtractor shared-generic mislabeling](investigations/converter/nativemethodextractor-shared-generic-mislabeling.md)
- [Field-resolution hoisted-singleton gap](investigations/converter/field-resolution-hoisted-singleton-gap.md)
- [StringMapExtractor metadata v27 shift bug](investigations/converter/stringmapextractor-metadata-v27-shift-bug.md)
- [StringMapExtractor CSV-unescape corruption](investigations/converter/stringmapextractor-csvunescape-corruption.md)
- [StringMapExtractor dynamic-candidate heuristics](investigations/converter/stringmapextractor-dynamic-candidate-heuristics.md)

## Runtime plugin

- [BattleInfoPatches trusted append-only source](investigations/plugin/battleinfopatches-trusted-append-only-source.md)
- [Costura embedded dependencies](investigations/plugin/costura-embedded-dependencies.md)
- [DynamicStringPatches template regex bug](investigations/plugin/dynamicstringpatches-template-regex-bug.md)
- [DynamicStringPatches CJK placeholder fallback](investigations/plugin/dynamicstringpatches-cjk-placeholder-fallback.md)
- [DynamicStringPatches adjacent-placeholder merge](investigations/plugin/dynamicstringpatches-adjacent-placeholder-merge.md)
- [Forcedata ShowForceSkill crash](investigations/plugin/forcedata-showforceskill-crash.md)
- [GlobalData tier-scale overrides](investigations/plugin/globaldata-tier-scale-overrides.md)
- [HeroDetailPanel slow-load investigation](investigations/plugin/herodetailpanel-slow-load-investigation.md)
- [PrefabText patches full investigation](investigations/plugin/prefabtextpatches-full-investigation.md)
- [ResourceIo generic byte-array ClassPointerStore crash](investigations/plugin/resourceio-generic-bytearray-classpointerstore-crash.md)
- [ResourceIo CSV merge abandoned](investigations/plugin/resourceio-csv-merge-abandoned.md)
- [ResetFaceSetting crash investigation](investigations/plugin/resetfacesetting-crash-investigation.md)
- [RobHeroItemChoose GetHero fix](investigations/plugin/robheroitemchoose-getherofix.md)
- [PlotText width overflow investigation](investigations/plugin/plottext-width-overflow-investigation.md)
- [Performance optimization pass](investigations/plugin/performance-optimization-pass-2026-09-13.md)
- [Record-log translation naturalness](investigations/plugin/recordlog-translation-naturalness.md)
- [UnityLogCapture logMessageReceived investigation](investigations/plugin/unitylogcapture-no-logmessagereceived.md)
- [UpgradePriority and HeroSearch diagnostics removed](investigations/plugin/upgradepriority-and-herosearch-diagnostics-removed.md)

## Current-state feature references

- [DynamicStringPatches agent reference](features/runtime-plugin/dynamicstringpatches-agent-reference.md)
- [PlotTextSizePatches agent reference](features/runtime-plugin/plottextsizepatches-agent-reference.md)
- [PrefabTextPatches agent reference](features/runtime-plugin/prefabtextpatches-agent-reference.md)
- [ResourceIoPatches agent reference](features/runtime-plugin/resourceiopatches-agent-reference.md)
- [UnityLogCapture agent reference](features/runtime-plugin/unitylogcapture-reference.md)
