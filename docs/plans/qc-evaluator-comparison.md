# QC Evaluator Comparison Plan

## Status

The five-call production shape described below is implemented in `FanslationStudio.LlmKit`
(`QualityReviewWorkflow.GetLlmVerdictAsync` and its `DetectDefectsAsync`/`GenerateCorrectionAsync`/
`GetVerificationVerdictAsync`/`GetCorrectionRepairAsync` helpers), with prompts converted for all
five model families (Qwen25, Qwen38, Glm4, HyMT2, HyMT2Moe). This has been validated with unit
tests and scripted-HTTP end-to-end tests (`Tests/Workflow/QualityReviewFiveCallFlowTests.cs`,
`FanslationStudio.LlmKit` repo). The first real-LLM comparison run against the new prompts
completed 2026-09-20 (`Files/TestResults/QcEvaluatorAssessment/Comparison.yaml`, 6 evaluators:
QwenQc-14B, HyMT2-7B, HyMT2-30B-A3B, HyMT2-30B-A3B-Q3, HyMT2-30B-A3B-Q3XXS, Qwen38Qc). Findings:

- Parse-success was solid (95-100%) across all six; the few failures surface as entries missing
  the `parseSuccess`/`score` keys entirely (`actualLabel: Unscored`), not as `parseSuccess: false`.
- Raw aggregate recall (0.04-0.43) looked uniformly weak across every model at first, which read
  like a shared call 1/2 prompt problem. It wasn't: roughly half of every model's false negatives
  came from the `omitted-separator`/`literal-newline`/`misplaced-separator`/`formatting` gold-set
  categories (all mapped to `QcDefectCategory.HardToParseSeam`) - defects the shared
  `BaseQualityReviewPrompt.txt` explicitly instructs every model family not to flag in most cases
  (its "Literal \n sequences" rule). See **Separator/Newline Defects Are Out of Scope** below -
  once those are excluded, the real ranking is Qwen38Qc (0.50 recall / 0.56 precision) clearly
  ahead of QwenQc-14B (0.33 / 0.35), with the whole HyMT2 family still weak (0.05-0.18 recall) on
  genuine (non-separator) defects.
- Of the remaining real defect categories, `mistranslation` looked like the weakest for both
  leading models (Qwen38Qc and QwenQc-14B each caught only 1 of 6) - but 3 of those ~6 misses per
  model were the same single gold-set item (`50ff7ccfb54c694e`, source `殷殷`) counted against
  multiple candidates. That item is a bare 2-character name-syllable fragment sampled with no
  parent-name context, and both candidate translations ("Eagerly"/"Earnestly") are correct readings
  of the classical adverb it happens to also spell - an unfair test, not a genuine miss (see its
  `reviewNote` in `GoldSet.yaml`, marked excluded from scoring 2026-09-20; confirmed the only such
  case among the gold set's 13 `sampleKind: split` items). The remaining, genuine misses were: a
  candidate translation that was literally the placeholder string `"None"`, and a name
  (白云子) rendered as a descriptive English gloss ("White Cloud") plus an invented `<b>` tag
  instead of being transliterated. `BaseQualityReviewPrompt.txt` (all 5 families) was updated
  2026-09-20 to explicitly call out both patterns - placeholder/null-value leaks, and names
  translated as descriptive glosses instead of transliterated - both routed to
  `OTHER_NAMED_DEFECT`, no new category needed. Re-running the comparison after this prompt change
  is the next step, ahead of any correction-side work, per the Acceptance Gates ordering
  (recall/safety before speed or correction quality).

The comparison run described in this document remains the mechanism for evaluating further
prompt or process-variant changes.

## Separator/Newline Defects Are Out of Scope

`\n`/`/`-separator omission in a translation (gold-set categories `omitted-separator`,
`literal-newline`, `misplaced-separator`, and most `formatting` items) is **not counted as a QC
defect** for this game, as of 2026-09-20. The in-game text control now wraps plot text properly,
so where a literal line break lands no longer matters for most text; it only still matters for
status-screen-style UI with fixed layout, which will be handled separately later (regex/flagging
on the raw string, not the LLM QC pass). `BaseQualityReviewPrompt.txt`'s existing "Literal \n
sequences" carve-out (identical across all five model families) was already correct for this -
the gold set's labels were what was out of sync with current product reality, not the prompt or
the models' detection ability.

Do not delete the affected gold-set items; exclude them from scoring (recall/precision/per-category
metrics) instead, since they may become relevant again once the status-screen regex/flagging work
exists. `QualityEvaluatorAssessmentWorkflow`'s metric calculation should eventually do this
exclusion itself rather than requiring a manual pass over `Results.yaml` per run.

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
single model used for every stage. A related, parked idea - using a fast strong-translator
model (HyMT2) for correction generation/repair while a slower, more accurate model (Qwen38Qc)
handles detection/verification - is written up separately in
[qc-fast-corrector-model-swap.md](qc-fast-corrector-model-swap.md), including why it doesn't
by itself address detection's corpus-wide latency cost and what building it out would take.

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