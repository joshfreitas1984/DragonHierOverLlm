# Translation pipeline — known-issue index

> This file is an **index only**. It is not auto-loaded into agent context (unlike
> `.github/instructions/tests-translation-workflow.instructions.md`, which has `applyTo:
> Tests/**`). Detailed investigation narratives live in per-topic files under `Tests/docs/` — read
> only the specific doc relevant to your current task, not this whole index. Keep the instructions
> file itself short; when a new investigation narrative is written, add it as a NEW file under
> `Tests/docs/` (or extend the closest-matching existing one) and add a one-line pointer here —
> never grow this file into a monolith again.

## Crash/data-loss investigations (`GameDataController.LoadAllGameData` and new-game generation)

Read in this order if bisecting a new "database ends up empty" / uncaught crash — each doc's fix
was a prerequisite for the load sequence progressing far enough to hit the next one:

1. [`docs/skipcolumns-stringtospeadddata-family.md`](docs/skipcolumns-stringtospeadddata-family.md)
   — `HeroTagData.csv`/`ResourcePointTypeData.csv`/`SkinDataBase.csv`: `Label<sign><number>` cells
   cross-referenced by exact string match via `StringToSpeAddData` (non-fatal, logged) — plus the
   `PackageFinalTranslationAsync` `SkipColumns` packaging bug found while fixing this.
2. [`docs/plotdata-column9-crash-and-repair-pattern.md`](docs/plotdata-column9-crash-and-repair-pattern.md)
   — `PlotData.csv` column 9's two-level `|`/`;` choice-option structure, a FATAL uncaught crash
   (not logged to `BepInEx/LogOutput.log`, only `Player.log`). Establishes the preferred
   `CustomColumnRepair`/`CustomColumnValidator` pattern over blanket `SkipColumns` for translatable
   columns with a narrow structural-corruption risk.
3. [`docs/kungfudata-stringtoattriratio-fatal.md`](docs/kungfudata-stringtoattriratio-fatal.md) —
   `KungFuData.csv`/`SummonKungFuData.csv` columns 9/10: same `Label<number>` shape as #1 but fed
   through `StringToAttriRatio` (FATAL, no try/catch) instead of `StringToSpeAddData`.
4. [`docs/spehero-relationship-and-skillfocus-crashes.md`](docs/spehero-relationship-and-skillfocus-crashes.md)
   — `SpeHeroData.csv` column 18 (relationship routing, non-fatal silent data loss) and columns
   11/12 (skill-focus, fatal crash at new-game hero generation — same bug class as `ForceData.csv`
   9/10/11).
5. [`docs/generatehero-unresolved-crash.md`](docs/generatehero-unresolved-crash.md) —
   `GameController.GenerateHero`/`UpgradeSkill`, a separate numeric-data crash NOT caused by
   translation, mitigated (not root-caused) via a narrow Harmony Finalizer.

## Asset dumper / prefab text / dynamic strings

- [`docs/gamefilehandling-reference.md`](docs/gamefilehandling-reference.md) — current
   `GameFileHandling` configuration, hook, extraction, and packaging rationale.

- [`docs/prefabtext-pipeline-architecture.md`](docs/prefabtext-pipeline-architecture.md) — full
  current-state wiring of the PrefabText pipeline (not a narrative — reference doc extracted out
  of the instructions file for length).
- [`docs/dynamicstrings-pipeline-architecture.md`](docs/dynamicstrings-pipeline-architecture.md) —
  full current-state wiring of the DynamicStringsIL2CPP pipeline, all four candidate-discovery
  sources (reference doc, same reason).
- [`docs/assetdumper-libcpp2il-and-noise-filtering.md`](docs/assetdumper-libcpp2il-and-noise-filtering.md)
  — `Samboy063.LibCpp2IL`/`classdata.tpk` version-pin setup for `AssetDumperWorkflowTests.cs`, and
  field-name noise-filtering / runtime-vs-load-time text findings behind the current
  `IsPrimaryTextField`/`DynamicStringOtherTextFields`/`PrefabTextPatches` sink-postfix design.
- [`docs/dynamicstrings-dialogue-button-fix.md`](docs/dynamicstrings-dialogue-button-fix.md) — why
  NPC dialogue-option buttons needed a second, bare-fragment `DynamicStringResult` entry.
- [`docs/dynamicstrings-extraction-sources.md`](docs/dynamicstrings-extraction-sources.md) — the
  `plotText`/`describe`-family field correction (belong in DynamicStrings, not PrefabText) and the
  staleness bug behind the IL2CPP-string-map re-extraction source.
