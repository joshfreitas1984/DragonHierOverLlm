# QC evaluator model selection

> **Status (2026-09-20): closed.** Production QC uses **`Qwen38Qc-IQ4XS`** as the single model for
> every QC role (detection, verification, correction generation, and repair) - see "Final decision"
> below. This document is the investigation record; it does not need to be read to operate the
> pipeline day to day (see the sibling repo's
> [quality-review-pass.md](../../../../FanslationStudio.LlmKit/docs/features/translation-pipeline/quality-review-pass.md)
> for that), only to understand why this model and shape were chosen over the alternatives that were
> tried.

## Summary

Twenty-five rounds of testing (2026-09-20, one long session) answered three separable questions
about the post-translation QC pass (`QualityReviewWorkflow`, `FanslationStudio.LlmKit`):

1. **Which model/quant/prompt combination detects genuine translation defects best?**
   `Qwen38Qc-IQ4XS` (`hf.co/unsloth/Qwen3.8-27B-GGUF:UD-IQ4_XS`), after maxing out the shared
   `BaseQualityReviewPrompt.txt`.
2. **Do the five-call design's two "doubled" process variants (doubled detection, doubled
   verification) actually earn their extra LLM-call cost?** Doubled detection: yes, keep it (thin but
   real recall lift). Doubled verification: no measurable benefit - a targeted prompt fix did what
   doubling couldn't.
3. **Could a faster/cheaper model take over correction generation (call 3) while `Qwen38Qc-IQ4XS`
   stays the detector, to save latency on the corpus's flagged subset?** No - rejected on both safety
   grounds (every cheaper candidate produces meaningfully more harmful corrections) and a hardware
   constraint (model-swapping on this box costs 11-15 seconds per switch, which rules out any
   per-row cross-model design regardless of quality).

The gold set used throughout (`Files/Goldset/GoldSet.yaml`) grew from 36 to 108 entries (102
detection items + 6 correction samples) over the course of this work and was user-confirmed
sufficient - see "Gold set growth" below.

## Method

`QualityEvaluatorAssessmentWorkflow` (`FanslationStudio.LlmKit`) runs each candidate model against
the committed gold set and records parse success, Pass/Defect/Abstain accuracy, per-category
recall/precision, correction safety, and latency, without ever mutating `Files/Converted`. A fixed
excluded-methodology (`Scripts/qc_excluded_methodology.py`) drops seam-shaped separator/newline gold
rows from the recall/precision denominator throughout - see "Separator/newline defects are out of
scope" below.

Two extensions were built specifically to answer question 3, both gated behind
`qualityEvaluatorAssessment` config keys that default to off/empty and never affect the production
`RunAsync`/`RunBruteForce` path:

- **`correctorModelNames`/`judgeModelName`**: has each named corrector candidate draft a *fresh*
  correction (`GenerateCorrectionAsync`) for every gold row with known confirmed defects - never
  reusing the gold set's human-authored correction, which exists to test verification, not
  generation - then scores it for safety with a separate, trusted judge model
  (`GetVerificationVerdictAsync`). A model never grades its own draft.
- **`enableRepairLoop`**: when a judge rejects a draft, sends it back through the *same* corrector's
  `GetCorrectionRepairAsync`, then re-verifies, up to `qualityReview.maxScoreRepairIterations` (2)
  times - mirroring production's calls 4/5 loop, to measure whether repair actually rescues a weaker
  corrector's higher failure rate rather than assuming it does.

Both write to their own subdirectories under `Files/TestResults/QcEvaluatorAssessment/` so
single-shot and repair-loop numbers are never conflated, and both are always run as full phases (one
model resident at a time for the *whole* batch) rather than interleaved per row - see "Model-swap
cost" below for why that matters.

## Detection: model, quant, and prompt (rounds 1-21, condensed)

- The shared `BaseQualityReviewPrompt.txt` (`Qwen38`/`HyMT2`/`HyMT2Moe` families) was iteratively
  fixed for real, confirmed false-positive/false-negative patterns: placeholder/null-value leaks,
  name-as-gloss mistranslation, an invented-synonym-pair over-translation pattern, and (last)
  cross-entry mechanical consistency within a translation (number/label order, internal
  capitalization) - each verified fresh (cache deleted, re-run, before/after compared) per
  `QualityEvaluatorAssessmentWorkflow`'s caching trap (see "Gotchas" below).
- **Capability ceiling, not a prompt problem:** `HyMT2-30B-A3B` (and its quantized siblings) and
  `QwenQc-14B` (`qwen2.5:14b-instruct`) were each tested as detector candidates. Two independent,
  targeted prompt-tuning rounds each showed `HyMT2-30B-A3B` picking up nothing on hard
  semantic-reasoning categories (name-as-gloss, invented-synonym-pair) while `Qwen38Qc` improved on
  both - real evidence the gap is capability, not wording. `QwenQc-14B` additionally had a standalone
  precision bug (flagging `GARBLED_NUMBER` on short stat-label strings purely because a number was
  present) and was only 27% faster - not worth chasing. All were dropped from routine detection
  rounds; their `models:` definitions were kept for the correction-generation work in question 3.
- **Final quant sweep (Twenty-first round), full 108-entry gold set:**

  | Model | Quant | Recall | Precision | Avg latency |
  |---|---|---|---|---|
  | `Qwen38Qc` | `UD-Q3_K_XL` (old default) | 0.812 (56/69) | 0.875 (56/64) | 929ms |
  | **`Qwen38Qc-IQ4XS`** | `UD-IQ4_XS` | **0.855 (59/69)** | **0.894 (59/66)** | 1268ms |
  | `Qwen38Qc-UDQ4KM` | `UD-Q4_K_M` | 0.884 (61/69) | 0.871 (61/70) | 1986ms |

  `Qwen38Qc-IQ4XS` strictly beats the old default on both recall and precision at a bounded +36%
  latency cost (~3.6 vs ~2.7 estimated full-corpus days); `UDQ4KM`'s further recall gain costs
  precision and ~2x the latency - the wrong tradeoff direction for this pipeline's stated priority
  (a missed defect ships silently forever; a false positive costs one bounded correction round-trip).
  **User picked `Qwen38Qc-IQ4XS`** as the balanced option - this is the current
  `qualityReview.modelName`.
- Two categories remain weak by design, not by omission: `formatting` (a narrow, diagnosed
  stray-whitespace pattern judged cosmetic) and `terminology` (has a working deterministic
  glossary-resync backstop, `TranslateLinesBruteForce`/`RunBruteForce`, independent of the QC LLM's
  own labeling skill - not yet run, declined by the user).

## Process variants: doubled detection and doubled verification (rounds 10-13)

The five-call design (`GetLlmVerdictAsync`) runs detection twice (calls 1+2, merged permissively -
either call's finding is kept) unconditionally on every corpus column, and can run verification
twice (call 4, merged strictly - either call's objection rejects the correction) on the smaller
confirmed-defect subset. Both costs were previously assumed necessary, never measured in isolation.

- **Doubled detection: kept.** A clean single-vs-double comparison (repairing a latency-contamination
  bug where scoring detection alone had been silently triggering calls 3-5) found a real, if thin,
  recall lift: exactly 1 of 18 in-scope defect rows was caught by the merge but missed by call 1
  alone, 0 rows regressed (`QcDetectionResult.Merge` is a set union, so doubling can only match or
  exceed a single call's catch rate). At ~1.83x the latency (927ms vs 506ms) for a lift that's
  small but never negative, and given a missed defect is the worse failure, **kept as the
  production-matching default** (`doubledDetection: true`).
- **Doubled verification: no benefit, root-caused and fixed differently.** Both harmful-correction
  gold examples known at the time scored `Safe` identically whether verification ran once or
  twice - the second independent call made the *exact same mistake*, not a different one. This
  pointed at a concrete gap (nothing in the verification prompt explicitly checked
  placeholder-token-count preservation or flagged fabricated named entities), not call-to-call noise.
  Adding those two explicit checks to `BaseQualityReviewVerificationPrompt.txt` caught both examples
  correctly with a single verification call. `doubledVerification` remains a harness knob (kept at
  its production-matching `true` default) for re-testing against a larger harmful-correction sample,
  not because doubling itself is currently believed to help.

## Fast-corrector-model-swap: tested and rejected (rounds 22-25)

Full detail: `FanslationStudio.LlmKit/docs/investigations/quality-review-postmortems.md` has the
generalizable model/hardware findings; this section is the DragonHierOverLlm-specific decision.

**Finding 1 - model-swap cost rules out per-row interleaving on its own.** Measured directly against
Ollama's `/api/chat` (`load_duration` field, no LlmKit code needed): a forced model switch on this
single 16.3GB-VRAM card costs **~11.4-13.0s (`Qwen38Qc-IQ4XS`)**, **~14.9-15.2s (`HyMT2-30B-A3B`)**,
or **~6.1-6.7s (`HyMT2-7B`)** - identical whether cold-starting or repeatedly alternating (no partial
residency benefit; the card holds only one of these models at a time). Real inference is 15-300ms -
the swap tax is 40-1000x everything else. At the corpus's ~51.6% historical correction rate (~41,900
of 81,165 splits), one swap-out-and-back per corrected row would cost an estimated ~13 days of pure
reload thrashing alone. **Any pipeline that mixes resident models must batch by phase** (detect the
whole corpus, then correct the flagged subset in one resident pass, then rescore in one resident
pass, repeat per repair iteration) - never implemented in production, since the questions below
never needed it.

**Finding 2 - every cheaper corrector candidate fails on safety before speed matters.** Drafted fresh
corrections for 104 gold rows with confirmed defects, scored by `Qwen38Qc-IQ4XS` as an independent
judge (never grading its own draft):

| Corrector | Safe rate (65 in-scope rows, excludes formatting/separator categories) | Judge |
|---|---|---|
| `Qwen38Qc-IQ4XS` (single-shot) | 0.831 | itself - self-judged, **optimistic upper bound only** |
| `QwenQc-14B` (single-shot) | 0.708 | `Qwen38Qc-IQ4XS` - independent |
| `HyMT2-30B-A3B` (single-shot) | 0.554 | `Qwen38Qc-IQ4XS` - independent |
| `HyMT2-7B` (single-shot) | 0.585 | `Qwen38Qc-IQ4XS` - independent |
| `QwenQc-14B` + its own repair loop (up to 2 rounds) | **0.754 (final)**, 0.631 initial | `Qwen38Qc-IQ4XS` - independent |

Both HyMT2 variants were rejected outright (~42-45% harmful even excluding out-of-scope categories,
including 100% harmful on `dropped-content` for `HyMT2-7B` and 83% on `garbled-number` for
`HyMT2-30B-A3B`). `QwenQc-14B` is the closest real competitor - genuinely independently judged,
unlike Qwen38Qc's own self-graded number - and its repair loop *does* help (+12.3pp), but only
rescues 8 of 22 (36.4%) initially-rejected drafts; the rest ship flagged for human review exactly as
the pipeline intends. Its total measured cost (1 draft + up to 2 repairs, judge verification
cumulative) is ~2385ms/row for a **75.4%** final safe rate, versus `Qwen38Qc-IQ4XS`'s un-repaired
~2751ms/row for an **83.1% (self-judged, likely overstated)** safe rate - genuinely cheaper per row,
but for a real, measurable safety gap. Given this pipeline's established priority (a missed or
harmful correction is worse than bounded extra latency), **not worth taking**.

**Final decision (2026-09-20, user-confirmed): `Qwen38Qc-IQ4XS` is the single model for every QC
role** - detection, verification, correction generation, and repair. No cross-model process variant
is in production. `Files/Config.yaml`'s `qualityReview.modelName: Qwen38Qc-IQ4XS` already reflected
this (production has always used one model for every call in `GetLlmVerdictAsync`) - the
`qualityEvaluatorAssessment.correctorModelNames`/`judgeModelName`/`enableRepairLoop` keys used to
answer this question are assessment-only, never read by the production path, and have been removed
from `Files/Config.yaml` now that the question is closed (this document is the record; re-derive the
config shape from the git history of this file if the question is ever reopened).

## Gotchas found along the way

- **Caching trap:** `QualityEvaluatorAssessmentWorkflow` caches each model's `Results.yaml` keyed
  only on the gold-set fingerprint, not on prompt/config content. Changing a prompt or a new
  `correctorModelNames`/`judgeModelName`/`enableRepairLoop` combination and re-running without
  deleting the relevant output directory silently returns stale results. Always delete
  `Files/TestResults/QcEvaluatorAssessment/<model>/` (or the `CorrectionGeneration*` subdirectories)
  before a round meant to test a change.
- **Repair-loop resumability bug (found and fixed 2026-09-20):** the first implementation tracked
  "which rows still need fixing" in an in-memory dictionary rebuilt fresh on every call. A transient
  Windows file-lock error (see below) interrupted a run mid-repair-loop; on retry, rows already
  marked `Harmful` from before the interruption were silently skipped by the resumed run's repair
  loop (it only re-verifies rows with no verdict yet), so they never got repaired. Fixed by
  persisting `UnresolvedDefectCategories` on the result itself instead of a local dictionary, so
  resume state is always reconstructed from `Results.yaml` alone regardless of where a run stops.
- **Transient Windows file-lock on `WriteYamlAtomically`:** hit a real, repeated
  `UnauthorizedAccessException` on `File.Move` during these long, many-write runs (likely
  antivirus/indexer briefly opening the just-written file). `WriteYamlAtomically` now retries up to 5
  times with linear backoff before giving up - a small, generally-useful hardening, not specific to
  this investigation.
- **Separator/newline defects are out of scope:** `\n`/line-separator omission no longer counts as a
  QC defect since game control now wraps text - `omitted-separator`, `literal-newline`, and
  `misplaced-separator` gold categories (plus `formatting`, which overlaps heavily) are excluded from
  every recall/precision/safety denominator in this document and in
  `Scripts/qc_excluded_methodology.py`.
- **Gold set growth:** grew from 36 to 108 entries (102 detection + 6 correction samples) via several
  targeted mining passes (pronoun-attribution, multi-placeholder, harmful-correction examples mined
  from real production `qcStatus: Corrected` rows, terminology/garbled-number/prompt-leak). User
  confirmed 108 is sufficient - well under the original 300-500 stretch target - and gold-set growth
  is closed out for this cycle.
