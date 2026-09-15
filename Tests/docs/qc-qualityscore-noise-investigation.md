# QC `QcQualityScore` noise investigation and current triage state

> **Status (2026-09): option 2 (stratify by DEFECT category) is implemented and its policy is set.**
> DEFECT parsing/persistence, the flagged-subset backfill, and per-category triage
> (`QcTriageByDefectCategory.yaml`) are all done — see "Per-category hand-validation findings and
> policy (implemented)" near the end of this doc for what was found and what `Config.yaml`'s
> `qualityReview.autoAcceptDefectCategories` is currently set to. The mechanism lives in the
> **sibling repo** `FanslationStudio.LlmKit` — see
> `../../FanslationStudio.LlmKit/docs/quality-review-pass-architecture.md`'s "DEFECT categories and
> per-category policy" section for the current-state technical reference; this document remains the
> investigation history and the record of *why* each category landed where it did.

## Summary

`QcQualityScore` (0-100, self-rated by the QC LLM in `QualityReviewWorkflow`, model
`qwen38-27B-2048-unsloth` via Ollama) does not reliably distinguish genuine translation defects
from fine translations. Real sampling shows a 75-91% false-positive rate among lines flagged by
`FlaggedForQcReview` (score below `Config.yaml`'s `qualityReview.minAcceptableScore`, currently 70),
and the same source line scores wildly differently across independent re-runs with unchanged
prompt/input (e.g. one recurring passage scored 0, 5, and 10 in three separate runs; another scored
15, 15, and 35). This points to noise inherent in the model's confidence estimation, not a
prompt-wording problem — three structurally distinct prompt fixes (see below) improved specific
false-positive patterns but did not move the aggregate false-positive rate.

Out of ~50,000 QC'd lines, roughly 5,000 (10%) are currently flagged — too many to hand-validate.

## Prompt fixes already applied (real, confirmed improvements)

All three per-model-family QC prompts (`BaseFiles/Qwen38`, `Qwen25`, `Glm4` /
`Prompts/BaseQualityReviewPrompt.txt`) were updated to fix specific, confirmed false-positive
patterns:

1. **Short-form floor rule** — short interjections/onomatopoeia/battle shouts/single-line dialogue
   fragments (roughly under 15 SOURCE characters) were being scored low with "I can't independently
   verify this" as the only justification. Added an explicit floor: default these to 80+ unless a
   specific named defect applies.
2. **Seam-defect clarification** — terse enumerated/list-style constructions (category tags stacked
   before a shared noun, mixing verb/noun-like items) were flagged as "broken flow at seams" when
   the actual issue was just that a more fluent rewrite was possible. Clarified that this register
   is normal for UI/condition text and a stylistic preference is not a defect.
3. **Honorific-hallucination guard** — a rule added by another session (restore a title/honorific
   dropped next to a name placeholder) was causing the model to *insert* a title (e.g. "Young
   Hero") where SOURCE had no honorific at all next to the placeholder. Added an explicit guard:
   only restore a title literally present in SOURCE; never insert one that isn't there.
4. **DEFECT-first restructuring** — reordered the output format so the model must first name one
   of a fixed set of DEFECT categories (`GARBLED_NUMBER`, `DOMAIN_TERM`, `LOST_IDIOM`,
   `UNTRANSLATED_PINYIN`, `DROPPED_CONTENT`, `HARD_TO_PARSE_SEAM`, `OTHER_NAMED_DEFECT`, or `NONE`)
   before scoring, with a CONSISTENCY rule mechanically binding DEFECT to SCORE (`NONE` requires
   80+, any named defect requires below 40). This makes the score distribution bimodal by
   construction and gives each flagged line a nameable category instead of just a number.

All four were validated against isolated Ollama calls (matching production model params exactly:
temperature 0.15, top_p 0.92, top_k 40, repeat_penalty 1.05, num_ctx 2048, num_predict 512,
`think: false`) before being accepted, and are live in all three prompt files.

## Findings that ruled out further prompt/config tuning

- **`minAcceptableScore` is now a moot lever for values in 1-79.** Because the CONSISTENCY rule
  forces every score into one of two bands (80+ for `NONE`, below 40 for any named defect), nothing
  lands in the 40-79 range. Moving the threshold anywhere in 1-79 flags an identical set of lines.
  The lever that actually matters is DEFECT-categorization accuracy, not the threshold value.
- **Widening the score scale (e.g. 0-1000) would not help.** The problem is not resolution/rounding
  — the model reaches genuinely different verdicts run-to-run on identical input, not the same
  verdict expressed with insufficient precision. A wider scale would just relabel the same noise
  with more digits.
- **Changing the flag trigger to "only flag if a correction was actually proposed" was rejected.**
  This would hide lines where the model detects a defect (low score) but the CONSISTENCY rule
  forces a binary choice and it emits `CORRECTED: NONE` anyway — a worse failure mode than current
  noise, which at least surfaces everything for human review.
- **Corpus-level spot fixes are out of scope for this investigation.** Individual bad lines found
  during sampling (e.g. a PlotData `殷殷……` → "Eern eern......" mistransliteration) are being
  triaged directly by the user via manual glossary entries (`Files/Glossary/HandRolled.yaml`), not
  through this prompt-tuning effort.

## Current triage options under consideration (option 2 now implemented — see below)

For the ~5,000 flagged lines, hand-validating all of them is impractical. Options discussed, in
order of expected effort-to-payoff:

1. **Multi-run consensus filter** — re-run only the flagged lines through the QC model 2-3
   additional times; keep the flag only if the DEFECT category agrees across runs (majority vote).
   Targets the proven noise pattern directly (same input, different score/category across runs).
2. **Stratify by DEFECT category** — hand-validate a random sample per category to get a real
   precision estimate for each, then auto-accept low-precision categories wholesale and only queue
   high-precision categories for human review. See the companion section below for what this
   requires.
3. **Deterministic pre-filter for mechanically-checkable categories** — `GARBLED_NUMBER` (digit
   presence/mismatch between SOURCE and TRANSLATION) and `UNTRANSLATED_PINYIN` (non-dictionary
   Latin-alphabet token detection) don't need an LLM's opinion at all; a script can check these
   directly instead of trusting the model's self-score.
4. **Second-model cross-check** — run the flagged set through a second model family's QC prompt
   (Qwen25 or Glm4, both already implemented) and keep the flag only where both models agree a
   defect exists. Independent-model agreement is a stronger precision signal than one model's
   confidence.
5. **Accept as-is / treat as informational only** — given the measured false-positive rate, it is
   defensible to stop trusting `QcQualityScore` for automated gating entirely and ship the 10% as
   flagged-but-unreviewed.

Option 2 (stratify by DEFECT category) is implemented — see "Per-category hand-validation findings
and policy (implemented)" below. Options 1/3/4/5 remain unimplemented; option 3 (deterministic
pre-filter for `GARBLED_NUMBER`/`UNTRANSLATED_PINYIN`) is worth revisiting given those two
categories' high measured precision below — a mechanical check could plausibly clear even more of
them without an LLM call at all.

## Requirements for option 2 (stratify by DEFECT category)

To turn this from a discussion into an actionable pipeline:

1. **Extract the flagged set with its DEFECT category.** `QualityReviewWorkflow` currently parses
   `SCORE:`/`CORRECTED:` via `ScoreLineRegex`/`CorrectedLineRegex`; the new `DEFECT:` line (added in
   fix #4 above) is emitted by the model but not currently parsed/persisted anywhere — it needs its
   own regex and a field on the QC result record (alongside `QcQualityScore`, `QcStatus`, etc.) so
   it survives into whatever output the flagged-line export reads. Confirm where flagged-line
   records are currently written (converted `.yaml` output, per file grep in this session's
   history) and add the DEFECT value there.
2. **Backfill or re-run to get DEFECT for the existing 5,000.** The DEFECT-first prompt fix (#4)
   was applied after some/most of the current QC pass ran, so most of the 5,000 already-flagged
   lines likely don't have a DEFECT category recorded. Either re-run QC review only for the flagged
   subset (cheap — 5,000 lines, not the full corpus) to backfill DEFECT, or accept that this option
   requires that re-run as a prerequisite step.
3. **Group flagged lines by DEFECT category** and get per-category counts — this alone is useful
   triage signal even before any hand validation (e.g. if `HARD_TO_PARSE_SEAM` and
   `OTHER_NAMED_DEFECT` dominate the 5,000, that already suggests where the noise concentrates).
4. **Draw a random sample per category** (e.g. 30-40 lines each, more for the largest categories) —
   large enough to estimate precision with a usable confidence interval, small enough to hand-check
   in one sitting per category.
5. **Hand-validate each sample** against the same criteria used throughout this investigation
   (compare SOURCE, the full `qcReviewedText`/effective translation — not just one fragment's
   `translated:` — and the proposed `CORRECTED` text) and record genuine-defect vs. false-positive
   per line.
6. **Compute per-category precision** (genuine defects / sample size) and decide a policy per
   category: categories at or near 0% precision get auto-accepted (score/flag ignored entirely),
   categories with meaningfully higher precision get queued for full human review of every flagged
   line in that category (a much smaller set than 5,000 if noise is concentrated in a few
   categories, per findings above).
7. **No code changes are required to attempt step 4's sampling manually** (the DEFECT categories
   are already visible in raw QC output if inspected line-by-line); a lightweight script is only
   needed if the flagged-line export doesn't already surface DEFECT per row, which depends on
   whether step 1/2's parsing gap has been closed.

This option's main up-front cost is steps 1-2 (parsing/persisting DEFECT, and re-running QC on the
flagged subset to backfill it for lines scored before the DEFECT-first prompt was live) — after
that, it's a fixed, small hand-validation cost (a few hundred lines total across categories) rather
than validating all 5,000.

## Per-category hand-validation findings and policy (implemented)

Steps 1-4 above were completed (DEFECT parsing/persistence, flagged-subset backfill, per-category
counts, 40-line-per-category sample — see `TestResults/QcTriageSummary.yaml`/
`QcTriageByDefectCategory.yaml`). Step 5 (hand-validation) was done by reading all ~320 sampled
lines: for each, comparing `text` (SOURCE) against `qcReviewedText` (the *original*, pre-QC
translation — confirmed from `QualityReviewWorkflow.cs`'s `anchor.QcReviewedText = effectiveTranslated`
assignment, set BEFORE the QC call) and `qcTranslated` (QC's *proposed correction*, set AFTER, from
`anchor.QcTranslated = correctedResult`) to judge whether a genuine defect existed and was actually
fixed, not just whether the two texts differ.

Counts below are out of `TotalFlagged: 6620` at the time of this pass (`QcTriageSummary.yaml`).

| Category | Count | Sample verdict | Policy |
| --- | --- | --- | --- |
| `HardToParseSeam` | 1,360 | Near-uniformly fine translations flagged for register/fluency preference. Almost no genuine defects in 40 samples. | **Auto-accept** |
| `DroppedContent` | 1,286 | Mostly false positives (pronoun/style tweaks), but 2-3 genuine content-restoration catches per 40 (e.g. "不愧是老夫" dropped, then correctly restored). Low precision, not zero. | **Auto-accept** |
| `Unknown` | 1,138 | Not a DEFECT category — lines whose response predates the DEFECT-first prompt or otherwise failed to parse a `DEFECT:` line. Scores cluster 60-70 (just under the 70 threshold), unlike every other category's sharply bimodal <40 scores under the CONSISTENCY rule — confirms these are pre-DEFECT-prompt responses, not a precision question. | **Not a policy category** — backfill via `ResetNonAutoAcceptedQcState` (`Unknown` is never auto-accepted) + a re-run |
| `LostIdiom` | 1,069 | Mixed: many flagged items are subjective literal-vs-idiomatic renderings of skill/move names (not really defects), a few genuine idiom-meaning-inversion catches, and **at least one case where the "fix" made a fine translation worse** (鬼门关: good idiomatic "Narrow escape" → over-literal "Gate of the Underworld"). Low precision, but a different risk than wasted review time. | **Deliberately undecided** — left off `autoAcceptDefectCategories` |
| `OtherNamedDefect` | 777 | Catch-all bucket — nearly every sample is a stylistic paraphrase with no factual difference. No consistent defect pattern. | **Auto-accept** |
| `GarbledNumber` | 396 | Moderate-high precision — genuine numeric/placeholder-integration garbles (a fully-untranslated numeral-unit string, wrong tael amounts, date-digit confusion). | **Review queue** |
| `DomainTerm` | 386 | High precision — real proper-noun/terminology fixes (五毒弟子 mistranslated as nonsense "Poisson Disciple" → correctly fixed; consistent character-name garbling across samples, e.g. Zhao Yinzong/Yanxi/Dianjian). | **Review queue** |
| `UntranslatedPinyin` | 206 | Near-100% precision — reviewed text is routinely literal raw pinyin ("xiang dang nian", "daoshan youpo", "wuqu mingge"), correction properly translates it. | **Review queue** |
| `None` | 2 | Negligible, not worth a policy. | N/A |

**Implemented policy** (`Files/Config.yaml`'s `qualityReview.autoAcceptDefectCategories`):
`[HardToParseSeam, OtherNamedDefect, DroppedContent]` — auto-accepted categories total 3,423 lines
(52% of the flagged set) cleared without individual review; `GarbledNumber`/`DomainTerm`/
`UntranslatedPinyin` (988 lines, 15%) stay in the human-review queue where the flags are worth the
time; `LostIdiom` (1,069) is intentionally left undecided; `Unknown` (1,138) needs its own re-run via
`Tests/QualityControlWorkflowTests.cs`'s `"8. Reset Non-Auto-Accepted Quality Review State"` +
`"2. RunQualityReviewPass"` before it can be categorized at all. The mechanism (`QualityReviewConfig
.AutoAcceptDefectCategories`, `QualityReviewHelpers.PassesQcScoreGate`, `QualityReviewWorkflow
.ResetNonAutoAcceptedQcState`) lives in `FanslationStudio.LlmKit` — see its
`docs/quality-review-pass-architecture.md`'s "DEFECT categories and per-category policy" section.

**Re-running this process**: if `LostIdiom` (or any category) gets re-hand-validated later — a
prompt tweak, a larger sample, or just revisiting the judgment call — update
`autoAcceptDefectCategories` in `Config.yaml`, then run `"8. Reset Non-Auto-Accepted Quality Review
State"` to pull the affected rows back out of their current bucket for a fresh look on the next QC
pass.
