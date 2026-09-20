# QC Evaluator Comparison Plan

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

The single-category `QcDefectCategory` contract is removed rather than preserved for
compatibility. Defects become a collection of findings, with category and confirmation state.
Packaging and score gating consume the final verified outcome, not an arbitrarily selected
primary category. A correction is accepted only when all confirmed defects are addressed and
the verifier finds no new defect.

## Implementation Shape

Reuse the deterministic sampling and result conventions from the translation assessment, but
create QC-specific input, multi-defect, stage-result, and aggregate result types. The
comparison should support one result directory per model/stage combination and an aggregate
comparison file keyed by stable `sampleId` and stage IDs. Prompt variants and process variants
must be assessable without changing production configuration. Production model selection and
prompt changes follow only after the assessor shows the relevant quality and latency gates.

## Validation

Add pure tests for multi-defect parsing, sample fingerprinting, stable sample IDs, stage
aggregation, metric calculation, disagreement handling, correction completeness, and newly
introduced defects. Use mocked response fixtures for each stage and for multiple simultaneous
defects. Include assessment cases where the first detector misses an issue that the independent
detector finds.
Do not run numbered or state-mutating translation/QC workflow facts as part of ordinary test
validation.