# QC Evaluator Comparison Plan

## Status

The five-call production shape described below is implemented in `FanslationStudio.LlmKit`
(`QualityReviewWorkflow.GetLlmVerdictAsync` and its `DetectDefectsAsync`/`GenerateCorrectionAsync`/
`GetVerificationVerdictAsync`/`GetCorrectionRepairAsync` helpers), with prompts converted for all
five model families (Qwen25, Qwen38, Glm4, HyMT2, HyMT2Moe). This has been validated with unit
tests and scripted-HTTP end-to-end tests (`Tests/Workflow/QualityReviewFiveCallFlowTests.cs`,
`FanslationStudio.LlmKit` repo) - **no real LLM has been run against the new prompts yet**. The
comparison run described in this document is the next step before trusting the new prompts or
tuning any of the process variants below.

`QualityEvaluatorAssessmentWorkflow` (the existing gold-set comparison harness) has been updated to
compile against the new multi-defect API but does not yet do the full per-stage isolation this plan
calls for (see Implementation Shape) - it currently measures end-to-end detection and correction
safety, not "which stage caused this disagreement."

The gold set (`Files/Goldset/GoldSet.yaml`) has 36 detection items and 1 correction sample as of
this writing (target remains 300-500). Its free-form category vocabulary is fully mapped onto
`QcDefectCategory` in `ParseCategory` (locked in by
`Tests/Workflow/QualityEvaluatorAssessmentWorkflowTests.cs`'s `ParseCategory_MapsEveryGoldSetCategory`
theory) - a category is never silently collapsed into a shared catch-all it doesn't actually belong
to. **The gold set still has zero `harmful`-labeled correction examples** - this can't be filled by
mining translation-assessment output (it only contains independent translations, never a proposed
correction to judge), so it can only be filled by running the real pipeline's correction generation
and reviewing what comes back, which is downstream of running the comparison, not a precondition
for it. Treat harmful-correction rate as unmeasured, not zero, until that happens.

## Objective

Identify a QC evaluator that is accurate enough to detect genuine translation defects,
does not approve harmful corrections, and is fast enough for repeated corpus review.
This comparison is separate from the existing translation-model assessment: every
candidate evaluator judges the same existing translation rather than generating a
translation from source text.

## Dataset

Create a deterministic, versioned sample of 300-500 real `(source, currentTranslation)`
pairs from `Files/Converted`. Stratify the sample across:

- known-good translations;
- genuine translation defects;
- names and domain terms;
- numbers, placeholders, and structural tokens;
- pinyin and dropped content;
- templated/seamed cells; and
- short dialogue and UI strings.

Add a hand-reviewed gold label for each pair:

- `Pass`, `Defect`, or `Abstain`;
- zero or more defect categories when applicable; and
- whether a proposed correction is safe, harmful, or unnecessary.

Keep the source fingerprint, sampling seed, label version, and annotator notes with the
assessment artifacts so later model runs compare the same cases.

## Evaluation Protocol

Run every candidate against identical inputs and prompts. Measure the QC stages separately:

1. **Initial detection:** find every defect in `SOURCE` and `CURRENT TRANSLATION`.
2. **Independent detection:** perform a fresh full review without seeing the initial detector's
   findings, so it can discover any issue rather than only verify one claimed category.
3. **Correction generation:** produce one correction addressing all confirmed defects.
4. **Correction verification:** check every confirmed defect and check that no new defect was
   introduced.
5. **Correction repair:** revise an unsafe or incomplete correction, then return to stage 4.

The evaluator must not generate and score its own correction. Detection and correction
generation are separate calls. Correction verification receives the fixed candidate and the
complete confirmed defect set, rather than a single claimed category.

Use isolated assessment calls and write results to a new assessment directory. Do not call
`QualityReviewWorkflow.RunAsync`, `RunBruteForce`, packaging, or any workflow that mutates
`Files/Converted`.

The assessment must record each stage's parsed result and stable stage result ID. A final
verdict alone is insufficient: disagreements must show whether a defect was missed during
detection, lost during independent verification, mishandled during generation, or introduced
by repair.

## Models

Initially compare the currently available QC candidates, including Qwen38, Qwen25-based
QC, GLM4, and any multilingual evaluator that can run locally. Laya should be treated as
an experimental candidate only: its model card describes an English-only typed decision
model, so it must pass the bilingual source-semantic cases before being considered viable.

Model selection is per role, not necessarily one model for every call. Prefer the fastest
model that passes the relevant gate. A slower model may be used for independent detection or
correction verification only when its measured quality improvement justifies the added
latency. The assessment must support fast-detector/slow-verifier combinations as well as a
single model used for every stage.

## Process Variants

Two structural costs in the five-call shape are assumptions, not yet measured gains, and must be
assessed as on/off variants - exactly like a model or prompt choice - before being treated as
settled production behavior. Neither variant changes production configuration by default; both are
toggled only inside the assessment harness until a variant earns promotion under the Acceptance
Gates below.

1. **Doubled detection (calls 1 + 2), on vs. off.** Calls 1 and 2 currently run unconditionally on
   every column - a flat 2x LLM-call cost across the whole corpus, not just a flagged subset. This
   is the higher-priority variant to resolve, precisely because its cost is unconditional. Compare:
   - single-detection recall/false-positive rate (call 1 alone) against
   - double-detection recall/false-positive rate (call 1 + 2, merged via `QcDetectionResult.Merge`).

   Report the **recall lift specifically attributable to call 2** - cases where call 1 missed a
   defect call 2 caught (see Evaluation Protocol's "first detector misses, independent detector
   finds" case) - separately from any co-occurring-defect recall gain, since only the corpus-wide
   2x cost has to be justified against the miss rate a single pass would have shipped. Also assess
   a same-model-twice variant against a fast-detector/slow-second-opinion variant (cheaper model for
   call 2, mirroring the existing fast-detector/slow-verifier idea already in this plan) as a way to
   capture most of the recall lift for less than 2x the expensive model's cost.

2. **Doubled verification (call 4), on vs. off.** Call 4 only runs for the subset of columns with
   at least one confirmed named defect (already far cheaper than doubling detection). Compare:
   - single verification (current behavior) against
   - two independent call-4 invocations merged (reject/repair on disagreement) - a guard against
     one verifier rubber-stamping a plausible-looking-but-wrong correction, the same self-consistency
     concern doubled detection addresses at the detection stage.

   Report harmful-correction rate and unnecessary-repair-loop rate with and without doubling.

Neither variant is implemented in `QualityReviewWorkflow` yet. Add each as a flag in the assessment
harness only (not `QualityReviewConfig`) until its measured effect justifies a real production
knob - mirroring how `MaxScoreRepairIterations`/`VerificationThinkingEnabled` already exist as
knobs earned by measurement, not assumption.

## Metrics

Record per model:

- parse-success rate;
- Pass/Defect/Abstain accuracy;
- defect precision, recall, and false-positive rate;
- per-category and multi-defect precision/recall;
- missed co-occurring-defect rate;
- harmful-correction rate;
- unnecessary-correction rate;
- correction completeness and newly introduced defect rate;
- score calibration and abstention rate;
- average and p95 latency per stage and end-to-end;
- throughput; and
- estimated full-corpus runtime and LLM call count.

Report results overall and by strata/category. Preserve disagreement cases for manual review
instead of collapsing them into a single average score.

## Acceptance Gates

A model or stage combination is not promoted solely because it is fast or has a high
self-reported score. It must:

- meet a minimum genuine-defect recall, including co-occurring defects;
- reduce false positives materially;
- produce no unacceptable harmful or incomplete corrections;
- meet the required parse-success rate; and
- meet the available runtime budget.

The default promotion order is:

1. Reject combinations that fail safety or minimum recall, regardless of speed.
2. Among passing combinations, choose the fastest end-to-end process.
3. Use a slow model only when it produces a measured improvement that a faster model cannot
   provide, and limit it to the stage where that improvement is demonstrated.

Overall accuracy must not be the primary gate because a detector that says `Pass` for almost
everything can score well on an imbalanced set while missing most real defects.

If no model passes all gates, use the safest model as a detector, disable automatic correction
application, and keep uncertain cases in the human-review queue.

## Production Process Shape

The production QC workflow will use five logical calls:

1. **Call 1 - detector:** detects zero or more defects; never writes a correction.
2. **Call 2 - independent detector:** repeats the full review without call 1 findings.
3. **Call 3 - generator:** writes one correction for the confirmed union of defects.
4. **Call 4 - correction verifier:** verifies every confirmed defect and checks for regressions.
5. **Call 5 - repairer:** improves an incomplete or unsafe correction; its output returns to
   call 4.

Defects are a collection of findings (`TranslationSplit.QcDefectCategories`/`LlmVerdict.Findings`),
each with category and confirmation state - this is the source of truth a future multi-defect
packaging/triage pass should consume. The single-category `QcDefectCategory` scalar was **kept**,
not removed, as a derived "primary" category (first in the confirmed set, or `None`/`Uncertain`)
so `QualityReviewHelpers.PassesQcScoreGate` and every existing packaging workflow
(`CsvGameDataWorkflow`, `DynamicStringWorkflow`, `JsonGameDataWorkflow`, `PrefabTextWorkflow`) keep
working unmodified. Redesigning those consumers to gate on the full collection instead of the
scalar is separate follow-up work, not done as part of this pass. `QcDefectCategory.Unknown` and
`QcDefectCategory.Uncertain` are never collapsed into an empty/clean `QcDefectCategories` list the
way `None` is - both mean "something is unresolved," never "nothing found," and must always
surface as at least one finding so a human review queue can never mistake either for a clean pass.

A correction is accepted only when all confirmed defects are addressed and the verifier finds no
new defect (`QcVerificationResult.Accepted`) - verification always re-checks the FULL confirmed set
on every repair iteration, never a shrinking "still open" list, so a repair that regresses an
already-fixed defect is caught rather than silently missed.

## Implementation Shape

Reuse the deterministic sampling and result conventions from the translation assessment, but
create QC-specific input, multi-defect, stage-result, and aggregate result types. The
comparison should support one result directory per model/stage combination and an aggregate
comparison file keyed by stable `sampleId` and stage IDs. Prompt variants and process variants
must be assessable without changing production configuration. Production model selection and
prompt changes follow only after the assessor shows the relevant quality and latency gates.

## Validation

Done, in `FanslationStudio.LlmKit`'s `Tests` project:

- pure parser tests for multi-defect detection parsing, including `NONE`/`UNCERTAIN` handling and
  invalid/mixed-token responses (`QcDetectionResponseParserTests`);
- pure parser tests for verification parsing, including the unresolved-must-be-a-subset-of-confirmed
  check (`QcVerificationResponseParserTests`);
- end-to-end orchestration tests against a scripted HTTP handler (no real LLM) covering: both
  detectors agreeing `NONE`; call 2 catching a defect call 1 missed; `UNCERTAIN` never collapsing
  into a pass; the verify-repair-reverify loop against a full confirmed set; a newly-introduced
  defect blocking acceptance until repaired; and repair-budget exhaustion accepting the last
  verified candidate (`QualityReviewFiveCallFlowTests`).

Still needed:

- sample fingerprinting, stable sample IDs, stage aggregation, and metric calculation tests once the
  QC-specific assessment types (Implementation Shape) exist;
- disagreement-handling tests once `QualityEvaluatorAssessmentWorkflow` does real per-stage
  isolation instead of end-to-end detection/correction-safety measurement;
- assessment-harness tests for both Process Variants (doubled detection, doubled verification) once
  those flags exist in the harness, each exercising the "first pass misses, second pass catches it"
  and "first pass wrongly accepts, second pass catches it" cases respectively.

Do not run numbered or state-mutating translation/QC workflow facts as part of ordinary test
validation.