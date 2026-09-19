---
name: expand-qc-goldset
description: Mines a completed TranslationAssessmentWorkflow run (Files/TestResults/ModelAssessment) for diverse, real defect/pass examples and adds them as new human-judged items to the committed QC gold set (Files/Goldset/GoldSet.yaml), keeping pinnedSampleSources and the prompt-tuning plan in sync. Use when asked to expand/grow the gold set, add more gold-set examples from an assessment run, or mine an assessment for QC evaluator test cases.
---

# Expand the QC gold set from a translation assessment run

This skill runs from a downstream game-translation repo such as `DragonHierOverLlm`. It never runs
a new `TranslationAssessmentWorkflow`/`QualityReviewWorkflow` pass, never calls an LLM, and never
edits `Files/Converted`. All labels are the agent's own human-style judgment call against real
model output already on disk - never fabricate a translation or a defect.

## 1. Load the current state

1. Read `Files/Config.yaml`'s `translationAssessment` block (`modelNames`, `sampleSize`,
   `sampleSeed`, `outputPath`, `pinnedSampleSources`).
2. Read `Comparison.yaml` under that `outputPath` (normally `Files/TestResults/ModelAssessment/`)
   and confirm `sampleFingerprint`/`sampleSize` match what you expect to mine. Note which model
   folder actually holds which quant right now - a model's `Results.yaml` folder can be manually
   overwritten with a different quant's output after the user changes a default (ask if a
   `Comparison.yaml` model entry has no matching `Results.yaml` folder, or vice versa - don't
   assume).
3. Read `Files/Goldset/GoldSet.yaml` (the committed gold set - NOT anywhere under `TestResults/`,
   which is gitignored). Record every existing `items[].sampleId`/`.source` and
   `correctionSamples[].source` so you never re-add a duplicate, and note the current top-level
   `models:` list and `additionalSourceAssessments` entries (each documents one source run's path/
   fingerprint/seed/selection criteria - add a new entry here, don't overwrite an old one, if this
   run wasn't already recorded).

## 2. Mine candidates for diversity, not just defects

Load every model's `Results.yaml` from step 1's output directory (`{model}/Results.yaml`, list of
`sampleId`/`sampleKind`/`filePath`/`source`/`translation`/`status`). Prefer a short throwaway
Python script for this (PyYAML) over manual reading - many samples - but delete it when done; don't
leave scratch scripts lying around and don't add this kind of ad-hoc analysis to the real test
project (see repo's testing-workflow-preferences memory).

Build a shortlist covering categories under-represented in the current gold set - check what's
already there first. Categories seen useful so far:

- **Structural-failure divergence**: samples where at least one model's `status` is `failed` -
  these usually contain a real separator/placeholder/formatting defect worth a closer look.
- **Known-good baselines**: samples where all models agree or all produce a defensible translation
  with zero factual/structural defect. The gold set skews heavily toward defects if you only mine
  failures - deliberately include a few clean Pass-across-all-models items.
- **Structural token variety**: `\n`-separated multi-sentence `fullCell` cells, `{n}` numbered
  placeholders, `#Token#`/`#$Token#` placeholders, `;`-delimited stat/identifier strings, ultra-short
  (<=6 char) UI/dynamic-string fragments, proper names, poem/song titles.
- **File-type variety**: don't only pull from `PlotData.csv` - `dynamicStrings.txt`,
  `dynamicStringsFromColumns.txt`, `dynamicStringsPoetry.txt`, etc. have different source
  conventions (see the newline gotcha below).

Aim for a batch of 5-10 new items per pass rather than one giant dump - large enough to move the
needle, small enough to hand-judge carefully.

## 3. CRITICAL - check the separator convention before judging "\n"

Before labeling ANY defect about a missing/mis-rendered separator, check whether the SOURCE string
itself contains a **real newline character** or the **literal two-character `\n` token**:

```python
has_real_nl = '\n' in source           # an actual newline character embedded in the source
has_literal_token = '\\n' in source    # a literal backslash followed by 'n'
```

`PlotData.csv` fullCell samples reconstructed via `CompoundFieldSplitter.Reconstruct` normally use
the literal `\n` token (confirmed against that file's templates in `Files/Raw/Export/*.yaml`), but
at least one `dynamicStrings.txt` sample has been found to embed a REAL newline directly in the
source instead. For a real-newline source, reproducing a real newline in the translation is
CORRECT, not a defect - only judge it a defect if the separator is dropped, duplicated, or
relocated. Getting this backwards silently inverts your Pass/Defect calls for that whole item (this
happened once already - see `docs/plans/translation-prompt-tuning-candidates.md`'s note on
`cb459b1c8e845a04`). Always verify per-sample; don't assume one file's convention for another.

## 4. Judge each shortlisted sample

For every candidate model's translation, assign:

- `label`: `Pass`, `Defect`, or `Abstain` (only use `Abstain` when genuinely undecidable even after
  investigation - prefer making a decisive call, same as this gold set's existing entries).
- `defectCategories`: reuse existing vocabulary where it fits before inventing a new one -
  `omitted-separator`, `literal-newline`, `misplaced-separator`, `dropped-content`, `formatting`,
  `terminology`, `fluency`, `garbage-output`, `prompt-leak`, `mistranslation`. Add a new category
  only when none of these actually describe the failure shape.
- `correctionSafety`: `safe`, `unnecessary`, or `harmful` - the set currently has zero `harmful`
  examples; if you find a case where "fixing" the defect would make it worse, that's valuable and
  should be captured as a `correctionSamples` entry (see below), not just a detection item.
- `reviewNote`: one paragraph explaining the actual reasoning - which model(s) got it right/wrong
  and why, referencing the specific words/tokens involved. This is what makes the label reusable
  later; don't skip it.

Two distinct arms, matching `QualityEvaluatorAssessmentWorkflow`'s `GoldSet` schema
(`FanslationStudio.LlmKit/Workflow/QualityEvaluatorAssessmentWorkflow.cs`):

- `items[]` - multi-model **detection** comparison (`source` + `candidates{model: text}` +
  `labels{model: {label, defectCategories, correctionSafety}}`). Use this for ordinary
  translation-assessment mining (this skill's normal case).
- `correctionSamples[]` - single-pipeline **correction-evaluation** case (`source` +
  `currentTranslation` + `proposedCorrection` + one `label`/`defectCategories`/`correctionSafety`).
  Only use this when you have a real, already-adopted correction to compare against (e.g. a QC
  regression documented in `Tests/QualityControlWorkflowTests.cs` or
  `docs/investigations/tests/*.md`), not for ordinary model-assessment candidates.

Tag every new item with `sampleRun: <name>` matching the `additionalSourceAssessments` entry from
step 1 so provenance stays traceable. Extra fields beyond the workflow's deserialized shape
(`sampleRun`, `reviewNote`, `archivedJudgeConfidence`, etc.) are safe - `YamlHelper` deserializes
with `IgnoreUnmatchedProperties()`.

## 5. Write and validate

1. Insert new `items` entries before the `correctionSamples:` key (or before end-of-file if none
   exist yet); insert new `correctionSamples` entries within that list.
2. Any plain (unquoted) YAML scalar containing `": "` (a colon followed by a space) breaks parsing
   - convert long `reviewNote`/`provenance` text to a folded block scalar (`>-`) rather than hunting
     for colons to avoid.
3. Validate the whole file parses after every edit batch (don't wait until the end):
   ```python
   import yaml
   yaml.safe_load(open('Files/Goldset/GoldSet.yaml', encoding='utf-8'))
   ```
4. Cross-check every `Config.yaml` `pinnedSampleSources` entry still has a matching `source` in the
   gold set (`items[].source` or `correctionSamples[].source`) - they should always stay in sync.

## 6. Sync pinned samples and the prompt-tuning plan

For every new item that represents a genuinely reproducible, prompt-fixable defect (not a one-off
model quirk you can't describe a fix for):

1. Add its exact `source` string to `Files/Config.yaml`'s `translationAssessment.pinnedSampleSources`
   so every future assessment run re-tests it regardless of random sampling.
2. Add or extend a numbered candidate entry in `docs/plans/translation-prompt-tuning-candidates.md`
   (create it if this project doesn't have one yet) with the source, current behavior, and a tuning
   idea - only if the user has asked for documentation/plans to be written; otherwise mention the
   candidates in your reply and let the user decide.

## 7. Rebuild and report

Rebuild `Tests\Tests.csproj` (or run the relevant focused test filter) to make sure nothing
downstream broke from the `Config.yaml`/gold-set edits. In your summary: state the new item count
vs. the prior count, name the categories you filled in this batch, and don't claim the gold set is
"done" - the target is 300-500 samples (see `docs/plans/qc-evaluator-comparison.md`); a batch of 5-10
is real progress, not completion.
