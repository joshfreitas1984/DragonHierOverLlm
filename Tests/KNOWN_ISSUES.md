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
- [`docs/dynamicstrings-dangling-color-tag-templates.md`](docs/dynamicstrings-dangling-color-tag-templates.md)
  — a color span left unclosed in-game (Enhance-UI string) because `{0}`/`{2}` are runtime-computed
  `<color=...>` opens while the matching `</color>` is literal raw text; QC's correction dropped the
  literal close. Fixed via a new `GameHooks.CustomTranslationExclusionRule` (LlmKit) plus a 44-entry
  manual-override dictionary in `GameFileHandling.cs` covering every raw string in
  `dynamicStrings*.yaml` with this shape (found by scanning raw text for a `{n}` placeholder +
  dangling literal closing tag).
- [`docs/qc-run-startup-crash-investigation-2026-09-15.md`](docs/qc-run-startup-crash-investigation-2026-09-15.md)
  — **RESOLVED (2026-09-16)**: "QC run broke game startup" after commit `551bb94` was
  `PrefabTextWorkflow`/`DynamicStringWorkflow` (FanslationStudio.LlmKit) discarding a low-scoring
  QC-corrected column all the way down to raw, untranslated Chinese text instead of its already-good
  pre-QC translation — including the age-rating splash notice shown at boot. Fixed: a QC-rejected
  column now falls back to `Translated`, never raw text; a genuine unsafe/missing-translation column
  is now omitted from the packaged dictionary entirely rather than packaged with raw Chinese.
  `qualityReview.enabled` also now gates packaging (not just the QC pass), which is what made
  isolating this possible without any LLM calls.

## Quality-review (QC) pipeline

The actual `QualityReviewWorkflow` implementation lives in the **sibling repo**
`../FanslationStudio.LlmKit` (a project reference, not part of this repo) — its
`docs/quality-review-pass-architecture.md` is the current-state technical reference (data model,
DEFECT parsing, packaging gate, triage, reset levels, config). This repo's numbered QC test facts
live in [`Tests/QualityControlWorkflowTests.cs`](QualityControlWorkflowTests.cs) (numbered `0`-`8`
plus a few unnumbered ones — see that file or the auto-loaded
[`tests-translation-workflow.instructions.md`](../.github/instructions/tests-translation-workflow.instructions.md)
for what each one does).

- [`docs/qc-qualityscore-noise-investigation.md`](docs/qc-qualityscore-noise-investigation.md) —
  `QcQualityScore` false-positive/noise investigation in `QualityReviewWorkflow`: confirmed prompt
  fixes applied, options ruled out (score-scale widening, `minAcceptableScore` retuning, trigger
  change), and the DEFECT-category-stratification option (now implemented — see below) including
  the per-category hand-validation findings and precision estimates.

**Current state (2026-09):** DEFECT parsing/persistence, the ~5,000-line backfill, and per-category
triage (`QcTriageByDefectCategory.yaml`) are all done. `Config.yaml`'s
`qualityReview.autoAcceptDefectCategories` now auto-accepts `HardToParseSeam`/`OtherNamedDefect`/
`DroppedContent` (hand-validated near-0% precision); `GarbledNumber`/`DomainTerm`/
`UntranslatedPinyin` stay in the human-review queue (hand-validated high precision); `LostIdiom` is
deliberately left undecided (low precision, but at least one correction made a fine translation
worse — a different risk than wasted review time). `Tests/QualityControlWorkflowTests.cs`'s
`"8. Reset Non-Auto-Accepted Quality Review State"` is the repeatable step for re-running this
policy after a category's verdict changes, and doubles as the backfill for `QcDefectCategory.Unknown`
rows (reviewed before the DEFECT-first prompt existed).
