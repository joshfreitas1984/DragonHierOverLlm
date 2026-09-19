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
- defect category when applicable; and
- whether a proposed correction is safe, harmful, or unnecessary.

Keep the source fingerprint, sampling seed, label version, and annotator notes with the
assessment artifacts so later model runs compare the same cases.

## Evaluation Protocol

Run every candidate against identical inputs and prompts. Measure two separate abilities:

1. **Detection:** whether the evaluator correctly judges the existing translation.
2. **Correction evaluation:** whether it correctly judges a fixed set of proposed
   corrections, including known-good, genuinely better, and deliberately harmful examples.

The evaluator must not generate or score its own correction in the correction-evaluation
phase. Candidate corrections are supplied as input so the test measures independent
judgment rather than self-consistency.

Use isolated assessment calls and write results to a new assessment directory. Do not call
`QualityReviewWorkflow.RunAsync`, `RunBruteForce`, packaging, or any workflow that mutates
`Files/Converted`.

## Models

Initially compare the currently available QC candidates, including Qwen38, Qwen25-based
QC, GLM4, and any multilingual evaluator that can run locally. Laya should be treated as
an experimental candidate only: its model card describes an English-only typed decision
model, so it must pass the bilingual source-semantic cases before being considered viable.

## Metrics

Record per model:

- parse-success rate;
- Pass/Defect/Abstain accuracy;
- defect precision, recall, and false-positive rate;
- defect-category accuracy;
- harmful-correction rate;
- unnecessary-correction rate;
- score calibration and abstention rate;
- average and p95 latency;
- throughput; and
- estimated full-corpus runtime.

Report results overall and by strata/category. Preserve disagreement cases for manual review
instead of collapsing them into a single average score.

## Acceptance Gates

A model is not promoted solely because it is fast or has a high self-reported score. It must:

- improve or match the current evaluator on genuine-defect recall;
- reduce false positives materially;
- produce no unacceptable increase in harmful corrections;
- meet the required parse-success rate; and
- meet the available runtime budget.

If no model passes all gates, use the safest model as a detector, disable automatic correction
application, and keep uncertain cases in the human-review queue.

## Implementation Shape

Reuse the deterministic sampling and result conventions from the translation assessment, but
create QC-specific input and result types. The comparison should support one result directory
per evaluator and an aggregate comparison file keyed by stable `sampleId` values. The first
implementation should be report-only; production model selection and `Files/Config.yaml`
changes follow only after the gold-set results are reviewed.

## Validation

Add pure tests for sample fingerprinting, stable sample IDs, result aggregation, metric
calculation, and disagreement handling. Use a small mocked response fixture for parser tests.
Do not run numbered or state-mutating translation/QC workflow facts as part of ordinary test
validation.