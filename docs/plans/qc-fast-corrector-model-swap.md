# QC Fast-Corrector Model Swap (Parked)

## Status

Parked 2026-09-20. Not implemented, not scheduled - opt in to validate later. Recorded here so the
theory and the reason it's untested aren't lost between now and whenever it's picked up. Parent
plan: [qc-evaluator-comparison.md](qc-evaluator-comparison.md).

## Theory

Use a fast, strong-translator model (HyMT2 family) for correction generation (call 3) and repair
(call 5), while keeping the most accurate detector (currently `Qwen38Qc-IQ4XS`, per the parent
plan's Twenty-first round) for detection (calls 1/2) and correction verification (call 4). Rationale: HyMT2 is
already known to be a strong *translator* in the separate translation-model comparison, and
producing a correction is close in shape to producing a translation, so it may not need the slower,
more accurate model doing the actual rewrite - only judging it.

## Important framing correction

This does **not** address the detector's per-corpus latency cost, and should not be pitched as a
speed fix for detection. Per the five-call design in
[qc-evaluator-comparison.md](qc-evaluator-comparison.md#production-process-shape), detection (calls
1+2) runs on **every column in the corpus unconditionally** - that's the flat, corpus-wide cost.
Correction (calls 3-5) only runs on the smaller subset of columns with a confirmed defect. So if
`Qwen38Qc-IQ4XS` stays the detector, its slowness still applies to the whole corpus regardless of
which model does correction - swapping the corrector model only affects the cost of the
already-smaller confirmed-defect subset.

If full-corpus detection latency is the actual problem to solve, the relevant lever is the
already-documented **doubled detection** Process Variant in the parent plan: whether call 2 (the
independent second detector) needs to be the same slow, accurate model as call 1, or whether a
cheap model can do call 2 while accuracy is spent more surgically. That is a separate question from
this one and should be evaluated on its own terms, not conflated with the corrector-swap idea below.

## Why it's unproven

`QualityEvaluatorAssessmentWorkflow` (`FanslationStudio.LlmKit/Workflow/QualityEvaluatorAssessmentWorkflow.cs`)
has no code path that generates a new correction and scores it - `ReviewCorrectionAsync` only calls
verification (`QualityReviewWorkflow.GetVerificationVerdictAsync`, call 4) against the gold set's one
existing, human-authored correction. `GenerateCorrectionAsync` (call 3) is never invoked anywhere in
the assessment harness. There is currently no way to ask "if HyMT2 drafted a correction for this
confirmed defect, would it actually be correct and safe?" without new code.

## What validating this would take

1. Change `GenerateCorrectionAsync` in `QualityReviewWorkflow.cs` from `private` to `internal` -
   matches the existing pattern for `GetVerificationVerdictAsync`, which the assessment harness
   already calls this way.
2. Add a new evaluation mode to `QualityEvaluatorAssessmentWorkflow`: for each gold-set item labeled
   `Defect` (confirmed categories already known from the gold label), call the candidate corrector
   model's `GenerateCorrectionAsync` and record the `proposedCorrection`.
3. Score each output two ways:
   - **Safety** - feed it back through `GetVerificationVerdictAsync` using a trusted judge model
     (`Qwen38Qc-IQ4XS`, the current production detector) to check no new defect was introduced.
   - **Completeness** - whether it actually resolves the confirmed defect. No automated ground truth
     exists for this yet, so at least an initial sample needs human review.
4. Run it for each HyMT2 variant as corrector against the confirmed real defects from a comparison
   run (~15-20 samples per the 2026-09-20 run), and review the outputs.
5. This same exercise doubles as the harmful/safe correction gold-set expansion already called out
   as an open gap in the parent plan (the gold set has zero `harmful`-labeled correction examples) -
   worth doing together rather than as two separate passes over the same confirmed-defect samples.

## When to pick this up

The parent plan's model/prompt selection is now settled (`Qwen38Qc-IQ4XS`, per its Twenty-first
round - see [qc-evaluator-comparison.md](qc-evaluator-comparison.md)), so this is no longer gated on
an in-flux target. Still parked/opt-in - pick up when correction-generation quality (not just
detection) becomes the priority.
