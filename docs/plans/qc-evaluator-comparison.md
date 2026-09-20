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
- **Third round completed 2026-09-20**, against Qwen38Qc, HyMT2-30B-A3B, and
  HyMT2-30B-A3B-Q3XXS (the first assessment run against the single `BaseQualityReviewPrompt.txt`
  fix above - the two earlier bullets' figures predate it entirely). Note: by this round the gold
  set had already grown from the 36 detection items described above to 121 (via the
  `ModelAssessment-20260919-larger-run` and `ModelAssessment-20260919-pinned-recheck` batches) - so
  the headline 0.77/0.62 recall/precision figures two bullets up are stale on two counts, not just
  one: they predate the prompt fix, and they were measured against the smaller 36-item set, not
  this one.

  The first attempt at this round reused cached `Results.yaml` files that turned out to predate
  the prompt-fix commit (confirmed by file timestamps and `git log` on
  `BaseQualityReviewPrompt.txt`) - `QualityEvaluatorAssessmentWorkflow` treats a `status: completed`
  result file matching the gold-set fingerprint as done regardless of whether the prompt itself
  changed since, so it silently skipped re-running. That produced numbers that looked like a
  verdict on the prompt fix but weren't. The cached files were deleted and the round re-run for
  real (5m41s wall time, confirmed fresh by file timestamps) before drawing any conclusion - do
  not trust `Results.yaml` as reflecting the current prompt without checking it postdates the
  relevant prompt commit.

  On the current 121-item set, excluding the same separator categories plus the one gold item
  already marked excluded from scoring: **Qwen38Qc** 0.565 recall / 0.650 precision; **HyMT2-30B-A3B**
  0.304 recall / 0.500 precision; **HyMT2-30B-A3B-Q3XXS** 0.174 recall / 0.571 precision - all lower
  than the stale pre-fix/36-item figures, because the added pinned-recheck batch specifically
  targeted historically hard cases. On the two landmark hard cases named above: HyMT2-30B-A3B
  catches the placeholder/null-value leak (`a486eb46b7b9f0b6`, `"在"` mistranslated as `"None"`) -
  the one pattern the prompt fix explicitly calls out - but still misses both the name-as-gloss case
  (`b4c303b678cbd79d`, 白云子 → "White Cloud" plus an invented `<b>` tag) and a plain semantic
  mistranslation case (`083e1b05b5abaa3b`, 门派职位) that Qwen38Qc catches. Verdict on the open
  question from the Active Candidate Set section: this one verified prompt-fix round did not close
  HyMT2-30B-A3B's gap on hard reasoning categories - it picked up the one pattern-matchable case and
  nothing else.
- **Fourth round completed 2026-09-20**, a second, more targeted prompt iteration specifically
  aimed at the two remaining hard cases, to test whether the gap is a wording problem (fixable by a
  sharper prompt) or a capability ceiling (not). Added to `BaseQualityReviewPrompt.txt` for all 5
  model families: (a) an explicit new defect rule naming the invented-synonym-pair over-translation
  pattern behind `083e1b05b5abaa3b` (e.g. "Rank/Position" for a single-concept label - previously
  only implicitly covered by the generic "meaning mismatch" rule); and (b) a forced pre-answer
  self-check step ("before finalizing, silently verify every name is kept as a name, and no
  synonym pair was invented") targeting `b4c303b678cbd79d`, since the name-as-gloss rule already
  had that exact example baked in and HyMT2-30B-A3B still missed the live occurrence - suggesting
  an application gap, not a knowledge gap. Verified fresh (5m27s wall time, deleted the whole
  `QcEvaluatorAssessment` output directory first this time rather than relying on the cache to miss
  - see the caching trap above). Result, a clean split:
  - **Qwen38Qc**: mistranslation recall 2/3 -> 3/3 (now catches `083e1b05b5abaa3b`), precision also
    up slightly (0.650 -> 0.667). A genuine, verified prompt-driven win.
  - **HyMT2-30B-A3B**: no change on either landmark case - still misses both
    `083e1b05b5abaa3b` and `b4c303b678cbd79d` despite both interventions targeting them directly.
    Recall/precision moved only in untouched categories (likely ordinary run-to-run LLM sampling
    variance, not a fix effect).
  - **HyMT2-30B-A3B-Q3XXS**: picked up `083e1b05b5abaa3b` (mistranslation recall 1/3 -> 2/3) but
    precision cratered (0.571 -> 0.333, false positives 3 -> 10) and it still missed
    `b4c303b678cbd79d` - a net-negative trade, not a real win.

  This is now two independent, verified prompt interventions where Qwen38Qc improved and
  HyMT2-30B-A3B did not move on the same targeted hard cases at all - real evidence for a
  capability ceiling on this model for semantic-substitution/name-transliteration reasoning, not a
  prompt-wording problem. **Decided 2026-09-20 (final):** `HyMT2-30B-A3B` and
  `HyMT2-30B-A3B-Q3XXS` are dropped from routine `qualityEvaluatorAssessment.modelNames` rounds -
  not just benched. Their `models:` definitions remain in `Files/Config.yaml` for the not-yet-built
  doubled-detection/fast-corrector process variants (see Process Variants below), which need their
  own purpose-built assessment rather than a slot in this standalone-candidate comparison.

- **Fifth round completed 2026-09-20**: for QC specifically (a single detect-once pass per line,
  not an iterative loop - a missed defect ships silently and never gets a second chance, while a
  false positive only costs one bounded correction/verify round-trip), accuracy takes priority over
  speed more strongly than for the translation pass, where corpus-wide throughput is the binding
  constraint. This reframes speed as a tie-breaker between models that already clear the accuracy
  bar, not a co-equal factor - so a wider quant sweep of the accuracy benchmark itself became the
  next question, rather than more prompt tuning.

  It turned out `Qwen38Qc` (`BaseFiles/Qwen38/Config.yaml`) was never full weight - it defaults to
  `hf.co/unsloth/Qwen3.8-27B-GGUF:UD-Q3_K_XL` (14.08 GB). Two more locally-available quants were
  added and run fresh (`Qwen38Qc-IQ4XS` = `UD-IQ4_XS`, 15.18 GB; `Qwen38Qc-Q4KM` = a plain
  (non-Unsloth-Dynamic) `qwen3.8:27b-q4_K_M`, 17.74 GB). Result, on the same excluded-item/
  separator-filtered 121-item set: recall climbed monotonically with quant precision - Q3_K_XL
  0.522, IQ4_XS 0.565, Q4_K_M **0.652** - while precision drifted down slightly (0.667 -> 0.650 ->
  0.600) and latency rose sharply (avg 1362ms -> 2057ms -> 3520ms; p95 3628ms -> 5596ms -> 10558ms).
  The GPU is a 16.3 GB-VRAM card; Q4_K_M's 17.74 GB of weights alone exceeds that, confirmed
  running a 23%/77% CPU/GPU split (`ollama ps`) - part of its latency cost is VRAM overflow, not
  pure compute.

  This prompted two follow-ups, both completed the same day:
  1. **Context-window tuning - smaller effect than expected.** `BaseFiles/Qwen38/Config.yaml`'s
     `num_ctx` was lowered 8192 -> 4096 after measuring real usage via direct `/api/chat` calls
     (worst-case detection: 2773 prompt + 10 completion tokens; correction: 980 + 70) - comfortable
     headroom at 4096, none of the risk of the old 8192. But measured properly (warm, steady-state
     calls, isolating `eval_duration` from one-time model-load time): a model already 100% on GPU
     showed **no measurable latency difference** between ctx 8192 and 4096 (139ms vs 136ms for a
     trivial prompt) - context size affects the KV-cache allocation ceiling, not per-token compute
     cost once loaded. And for the VRAM-overflowing `Q4_K_M`, the CPU/GPU split barely moved
     (23/77 -> 21/79) - its 17GB of *weights alone* already exceeds the 16.3GB VRAM budget before
     any KV cache is added, so no context-window reduction can fix that split. **Conclusion: the
     quant latency differences measured above are compute-cost-per-token scaling with quant
     precision, plus VRAM-overflow penalty for oversized quants - not a context-window sizing
     problem.** The `num_ctx` reduction was kept anyway (no downside, real usage never approached
     8192) but should not be expected to "speed up" any of these models.
  2. **Same-size, better-method quant swap - confirmed a real win.** `qwen3.8:27b-q4_K_M` (tested
     above) is a plain llama.cpp quant, not Unsloth's Dynamic method -
     `hf.co/unsloth/Qwen3.8-27B-GGUF:UD-Q4_K_M` (17.4 GB, same nominal bit-width, Unsloth's improved
     method) was pulled and run as `Qwen38Qc-UDQ4KM`.
  3. **GPU VRAM ceiling confirmed tighter than file size alone suggests.** Even `IQ4_XS` (15.18 GB)
     was found to spill slightly to CPU (8%/92%, via `ollama ps`) on this 16.3 GB-VRAM card, with
     only ~292 MB free at the time - the zero-spill ceiling sits right around `Qwen38Qc`'s 14.08 GB,
     not the naive "under 16.3 GB" assumption. Practical conclusion: Q3-Q4 is the realistic
     operating band for routine QC on this hardware; Q5+ (18.7 GB+) would push several more GB onto
     CPU than Q4_K_M already does, likely moving latency into "occasional slow spot-check tool"
     territory rather than "routine pipeline stage" - not pursued further for now.

  **Fifth round results (all four re-run fresh under the new `num_ctx: 4096`, same excluded-item/
  separator-filtered methodology):**

  | Model | Size | Recall | Precision | Avg latency |
  |---|---|---|---|---|
  | Qwen38Qc (`UD-Q3_K_XL`) | 14.08 GB | 0.609 | 0.667 | 1385ms |
  | Qwen38Qc-IQ4XS (`UD-IQ4_XS`) | 15.18 GB | 0.652 | 0.714 | 1988ms |
  | Qwen38Qc-Q4KM (plain `q4_K_M`) | 17.74 GB | 0.565 | 0.565 | 3183ms |
  | **Qwen38Qc-UDQ4KM** (`UD-Q4_K_M`) | 17.4 GB | **0.652** | **0.789** | 3130ms |

  Note the numbers moved noticeably from the earlier round for the same configs (e.g. Q3_K_XL
  0.522 -> 0.609, plain Q4_K_M 0.652 -> 0.565) - real run-to-run sampling variance at
  `temperature: 0.15`, not a regression; small differences between rounds should not be
  over-interpreted, but a gap the size of UDQ4KM vs plain Q4KM (same size/latency, +0.224 precision,
  false positives 10 -> 4) is far too large and consistent across every metric to be noise.

  **UD-Q4_K_M beats the plain Q4_K_M outright at the same size and latency** - confirms quant
  *method* matters as much as bit-width. Two standouts with different tradeoffs: **UD-Q4_K_M**
  (best precision, tied-best recall, 3.1s avg - the accuracy-first pick) vs **IQ4_XS** (ties on
  recall at 37% lower latency, 1988ms, with a modest precision gap - the balanced pick if latency
  still matters). Both landmark hard cases from the Third/Fourth rounds (`b4c303b678cbd79d`
  name-as-gloss, `083e1b05b5abaa3b` invented-synonym mistranslation) are now caught by **all four**
  quant levels, including the smallest (`Q3_K_XL`) - the Fourth round's prompt fix generalized
  across the whole Qwen38 family regardless of quant, not just the specific quant it was tested on.

  Per-category breakdown is identical across all four quants on the two categories still holding
  recall back: `terminology` (阁主 vs 殿主 honorific confusion) is 0/2 for every quant, and
  `formatting` is 1/6 for every quant. Since quant choice makes zero difference to either, these are
  not precision/capability gaps a bigger quant would fix - `terminology` looks like a **glossary
  coverage gap** (add these honorific-title distinctions to the domain glossary so the existing
  `GLOSSARY:` prompt rule catches a mismatch, rather than writing a new defect-category rule), and
  `formatting` needs its own targeted look. Recommended next step once a model is chosen: pursue
  glossary expansion for the terminology gap rather than another quant or prompt round.

The comparison run described in this document remains the mechanism for evaluating further
prompt or process-variant changes. This round's per-category analysis was scripted ad hoc against
`Results.yaml`/`GoldSet.yaml` rather than through `QualityEvaluatorAssessmentWorkflow`'s own metrics
(which report raw non-excluded aggregate recall/precision only, per the Separator/Newline section
below) - promoting that exclusion + free-form-category breakdown into the workflow itself remains
open work (see the note in that section). The workflow's `Results.yaml` caching (keyed on gold-set
fingerprint, not prompt content) is also a known trap for future rounds - see the paragraph above:
always delete the model's output directory (or check `Results.yaml` timestamps against the
relevant prompt commit) before trusting a round's numbers.

- **Sixth round completed 2026-09-20**: attempted the Fifth round's recommended `terminology` fix
  (add 阁主 -> "Pavilion Master" / 殿主 -> "Hall Master" to
  `Files/Glossary/GameSpecificGlossary.yaml`) and verified it against `Qwen38Qc` only (fastest
  quant, per the Next Steps prompt-max-first ordering). Two real bugs in
  `QualityEvaluatorAssessmentWorkflow` (FanslationStudio.LlmKit) were found and fixed along the way,
  both now committed there:
  - `ReviewDetectionAsync`/`ReviewCorrectionAsync` hardcoded the `glossaryPrompt` parameter to
    `string.Empty` instead of calling `GlossaryLine.AppendPromptsFor` the way the real
    `QualityReviewWorkflow.ReviewColumnAsync` path does - **the gold-set assessment harness never
    injected any glossary content into any QC model's prompt, for any model, in any round to date.**
    Every past `terminology`-category result in this doc (including the "identical 0/2 across every
    quant" finding that drove the Fifth round's glossary hypothesis) was measured with zero glossary
    support. Fixed to compute the real glossary prompt from `source`/`item.Source` (gold-set items
    have no output-file identity, so the file-scoping `only`/`exclude` glossary fields can't apply
    here - passed `string.Empty` for that parameter, same as "no file restriction").
  - `EvaluatorResult.ActualDefectCategory` only recorded `verdict.Defect` (the model's *primary*
    finding), silently dropping any other categories in `verdict.Findings` - undercounting a model
    that found the right category as a secondary finding. Added `ActualDefectCategories` (the full
    list) alongside the existing field.
  - After both fixes, re-ran `Qwen38Qc` fresh (non-cached) against the two `terminology` gold items
    (`f443997a161cdcae` 阁主, `086115857254d774` 殿主). Result: **`terminology`/`DomainTerm` recall
    is still 0/2 by category match** - the model now flags something wrong on both true-positive
    candidates (previously it passed them outright), but categorizes the finding as
    `OtherNamedDefect`/`DroppedContent`, never `DomainTerm`, even with the term correctly injected.
    Worse, the same run introduced **three new false positives** - candidates on these two source
    rows that were correctly gold-labeled `Pass` are now flagged `Defect` once the glossary block is
    present. Net: the glossary fix, now verified to actually reach the model, neither fixes the
    category-recall gap nor improves precision on these rows. The Fifth round's "glossary coverage
    gap" hypothesis for `terminology` is **not supported** by this result - it looks more like a
    prompt-salience/category-mapping issue (the model reacts to the glossary context but doesn't
    reliably use the `GLOSSARY:` rule's own category guidance), which is a different (and likely
    harder) fix than adding more glossary entries.
  - Investigated a claimed corpus-wide safety net (`TranslationWorkflow.TryFlagForNewGlossary`) as a
    reason this might not matter - it has **zero call sites in either repo**, dead code, not wired
    into any workflow. The real, live mechanism is different: `TranslationWorkflow.TranslateLinesBruteForce`
    (`Tests/QualityControlWorkflowTests.cs`'s "0. TranslateAndQualityReviewBruteForce") re-runs
    `ApplyTranslationRules`/`EvaluateRules`/`FindGlossaryMistranslations` against every **existing**
    `split.Translated` value already in `Files/Converted`, flagging anything that no longer matches
    the current glossary for retranslation, and `QualityReviewWorkflow.RunBruteForce` resyncs
    `QcTranslated` the same way. This is a real, deterministic, non-LLM-judgment backstop for the
    real corpus - but it does **not** touch the gold-set assessment harness at all (that harness
    evaluates frozen candidate strings from the translation-model comparison corpus directly via
    `GetLlmVerdictAsync`, never through `TranslateLinesBruteForce`), so it has no bearing on this
    round's measurement, only on what happens once the real corpus is brute-forced.
  - **Decision: do not run the brute-force sync yet.** It's a real fix for the two now-glossaried
    terms in the *production* corpus, but running it now, mid-model-selection/mid-prompt-tuning,
    would retranslate/resync a large chunk of `Files/Converted` on a moving target (still-changing
    prompt and not-yet-chosen model) - wasted work if either changes again before the corpus pass
    that actually matters (the multi-day full run in Next Steps item 3). Revisit after model
    selection and prompt-maxing are both done - see Next Steps below.

- **Seventh round completed 2026-09-20**: investigated `formatting`'s stuck 1/6 recall (the top
  concrete target per Next Steps). Root cause found: the gold-set `formatting` label maps entirely
  onto `QcDefectCategory.OtherNamedDefect` in `ParseCategory` (`FanslationStudio.LlmKit`'s
  `QualityEvaluatorAssessmentWorkflow`) - it never maps to `HardToParseSeam`, unlike
  `omitted-separator`/`literal-newline`/`misplaced-separator`. So the Fifth round's assumption that
  "most `formatting` items" are seam-shaped and covered by the separator exclusion was wrong for the
  taxonomy actually used to score: of the gold set's 6 `formatting`-labeled rows, only 2 co-occur
  with `omitted-separator` (genuinely seam-shaped); the other 4 are real, distinct artifacts with
  **zero explicit prompt coverage** - an invented colon in a terse stat label (`杀机0.1` ->
  `"Deadly intent: 0.1"`), a redundant duplicated real blank line alongside a dropped-content defect,
  and stray trailing whitespace before a real newline (two separate candidates on the same source
  row). `OTHER_NAMED_DEFECT`'s only two worked examples in every `BaseQualityReviewPrompt.txt` are
  placeholder/null leaks and name-as-gloss - nothing about invented punctuation or stray whitespace -
  and the prompt's own "DO NOT flag: minor stylistic choices" line gave the model an easy way to wave
  these off as style, not defects. This is the same shape of gap (missing explicit rule, not a
  capability ceiling) that the Third/Fourth rounds' targeted prompt edits fixed for
  mistranslation/name-as-gloss.

  **Fix applied** to all 5 `BaseQualityReviewPrompt.txt` files (`FanslationStudio.LlmKit`): extended
  `OTHER_NAMED_DEFECT` with explicit examples (invented punctuation in a label/stat string, stray or
  duplicated whitespace around a real newline/separator not present in SOURCE), and narrowed the
  "minor stylistic choices" DO-NOT-flag rule to explicitly exclude punctuation/whitespace/markup
  changes from that carve-out.

  Verified with a fresh (non-cached; `Files/TestResults/QcEvaluatorAssessment/Qwen38Qc/` deleted
  first) `Qwen38Qc` run against the full 121-item gold set. Per-category (non-seam) `formatting`
  recall: **1/6 -> 2/6** - the invented-colon case (`06d3cc1dfc09653f`) is now caught, correctly
  categorized `OtherNamedDefect`. The redundant-blank-line case (`4c531aea002f3953`) was already
  caught pre-fix, but via `UntranslatedPinyin` (a different, also-present defect on that row), not
  attributed to the formatting slip itself - unchanged by this round. **Both stray-trailing-whitespace
  instances (`cb459b1c8e845a04`, two candidates on the same source row) are still missed** despite the
  new rule naming this exact pattern - a genuine, still-open miss, not a wording problem this specific
  edit fixed. No regression found: none of this run's 5 non-seam false positives trace to the new
  rule (they're the pre-existing `terminology`-glossary false positives from the Sixth round plus
  unrelated `DroppedContent` calls).

  Overall excluded-methodology metrics this round (same methodology as Third-Fifth rounds - excludes
  seam-only-labeled defect rows and the one gold item marked "EXCLUDE FROM QC EVALUATOR SCORING"):
  **0.739 recall / 0.773 precision** on `Qwen38Qc` (`UD-Q3_K_XL`, the currently-scoped-in quant) -
  higher than the Fifth round's pre-fix 0.609/0.667 baseline for the same quant, though this run
  also carries the Sixth round's now-working glossary injection, so the combined effect of both
  fixes (not formatting alone) explains the jump; treat it as encouraging but not purely
  attributable to this round's change alone, and larger than the ±0.05-0.1 run-to-run variance band
  noted in earlier rounds, so plausibly a real combined improvement rather than noise.

  Followed up same day with a quick isolated single-call check (direct `/api/chat`, current
  post-fix prompt, no full gold-set round) on both trailing-whitespace candidates: first confirmed
  via raw `repr()` on the gold-set strings that this is a genuine translation-introduced defect, not
  a labeling artifact - SOURCE and the two `Pass`-labeled candidates have no trailing spaces before
  either `\n`; only the two `Defect`-labeled candidates add them. Both isolated calls reproduced
  `DEFECTS: NONE`, matching the batch run. A third call exaggerated the whitespace 3x (6 trailing
  spaces instead of 2) to isolate pure perceptual salience from prompt wording - still
  `DEFECTS: NONE`. **Conclusion: this is a salience/attention gap, not a wording problem** - the
  model does not attend to trailing whitespace as a thing to check at all, at any magnitude tested,
  even with an explicit rule naming it. Not worth further prompt iteration for a low-stakes,
  cosmetic defect shape (trailing whitespace has no player-visible effect once the game's text
  control wraps content, per the Separator/Newline section above). **Decided: deprioritized, not
  pursued further.** The invented-punctuation half of the `formatting` fix is a confirmed, verified
  win (1/6 -> 2/6); the trailing-whitespace half is accepted as a known, low-priority miss rather
  than a target for a third prompt round.

## Next Steps (decided 2026-09-20 - read this before starting further work; Seventh round entry
above supersedes this section's older `formatting`/`terminology` framing)

Priority order, chosen deliberately over "pick a quant now":

1. **Remove ruled-out models from `Files/Config.yaml`.** Done 2026-09-20:
   `Qwen38Qc-Q4KM` (plain quant, beaten outright by `Qwen38Qc-UDQ4KM`) removed from `models:` and
   `qualityEvaluatorAssessment.modelNames`. `HyMT2-30B-A3B`/`HyMT2-30B-A3B-Q3XXS` were already
   dropped from `modelNames` (Fourth round) but their `models:` definitions stay for later
   process-variant work.
2. **Prompt-max detection quality across every remaining weak category, on the fastest quant
   (`Qwen38Qc`/`UD-Q3_K_XL`), before doing any further quant comparison.** Reasoning: prompt fixes
   have now been shown (twice) to generalize across every quant level tested, but a quant
   comparison has to be redone from scratch after every future prompt change (same caching-trap
   risk as always). Iterating on the cheapest/fastest quant minimizes the cost of each prompt-tuning
   cycle; do the final quant sweep once, after the prompt stabilizes, not before. Known concrete
   targets, in order of promise:
   - `formatting` (1/6 on every quant pre-Seventh-round) - **root-caused and partially fixed 2026-09-20
     (Seventh round), now settled.** It wasn't a seam/separator-exclusion issue as previously assumed
     - it was a missing explicit rule for invented punctuation and stray whitespace under
     `OTHER_NAMED_DEFECT`. Fixed prompt across all 5 families, verified fresh: `formatting` recall
     1/6 -> 2/6 (the invented-colon pattern is now caught and correctly categorized). The remaining
     stray-trailing-whitespace pattern (`cb459b1c8e845a04`) was isolated-tested same day (direct
     single-call, exaggerated 3x) and confirmed a salience gap, not a wording problem - **decided:
     deprioritized, not pursued further**, cosmetic/low-stakes given the text-control wrapping
     already in place. Remove from active targets; do not spend another round on it.
   - `terminology` (0/2 on every quant) - **downgraded, not the next thing to chase.** The Sixth
     round confirmed the "glossary coverage gap" hypothesis was wrong: the 阁主/殿主 glossary
     entries are now added (`Files/Glossary/GameSpecificGlossary.yaml`) and confirmed to actually
     reach the model (a real assessment-harness bug - `glossaryPrompt` was hardcoded empty - was
     found and fixed along the way), but category recall is still 0/2 even with the term correctly
     injected; the model flags *something* but never attributes it to `DomainTerm`, and glossary
     presence introduced new false positives on adjacent rows. More importantly: for any term that
     genuinely *is* in the glossary (as these two now are), `TranslationWorkflow.TranslateLinesBruteForce`
     + `QualityReviewWorkflow.RunBruteForce` (the "0. TranslateAndQualityReviewBruteForce" test)
     already deterministically re-syncs the real corpus against the current glossary independent of
     the QC LLM's own categorization skill - so this specific class of defect has a working backstop
     in production regardless of whether the QC model ever learns to label it `terminology`
     correctly. **Do not run that brute-force sync yet** - deliberately deferred until model
     selection (step 3) and prompt-maxing are both done, so it isn't wasted on a corpus pass against
     a still-moving prompt/model target. Once it *is* run, it will fix 阁主/殿主 (and any other
     already-glossaried term) in `Files/Converted` directly, without needing this prompt/category
     fix at all. The QC LLM's own `terminology`/`DomainTerm` detection still matters for the long
     tail of terms *not yet* in the glossary, but that's a lower-priority, ongoing concern rather
     than a blocking gap - don't spend further rounds specifically chasing these two gold items.
   - Any other category below a comfortable recall bar once `formatting` is addressed - rerun the
     ad hoc separator-exclusion analysis script (see the Fourth/Fifth round entries above for the
     methodology: exclude `HardToParseSeam`-mapped categories and the one gold item marked
     "EXCLUDE FROM QC EVALUATOR SCORING") after each change, don't rely on
     `QualityEvaluatorAssessmentWorkflow`'s own raw (non-excluded) aggregate metrics.
   The goal at this stage is a **reliably good detector** - the current bar is "does it reliably
   flag that a translation has a real problem," not final speed or process-shape optimization.
3. **Only after the prompt is maxed out, do one final quant sweep** to pick the production model,
   trading off recall/precision against latency at corpus scale. Full-corpus math (81,165 splits in
   `Files/Converted`, ~51.6% historical correction rate, `maxConcurrency: 2`) puts a full cold-start
   corpus run at **very roughly 4-9 days** depending on quant (~4.1 days at `Q3_K_XL`'s 1385ms/call,
   ~9.2 days at `UD-Q4_K_M`'s 3130ms/call) - so per-call latency compounds into a multi-day
   difference, not a rounding error, and is worth real weight in the final pick. That said,
   **~2 seconds/call is probably the realistic floor** on this hardware (16.3GB VRAM caps
   zero-CPU-spill quants around 14GB, and compute-per-token below that doesn't drop much further
   without a materially smaller/weaker quant) - don't chase sub-1s at the cost of regressing recall
   below whatever the maxed-out prompt achieves. Speed optimization *within* that constraint
   (further `num_ctx`/hardware tuning) is a separate, later concern from model/quant selection.
4. **Defer the Process Variants section below (doubled detection, doubled verification) and any
   other process-shape questions (e.g. whether every correction needs a full verify/repair loop)
   until after step 3.** These are real open questions but they compound with model/prompt choice
   rather than being independent of it - answering "do we need 2 verification scores" before
   knowing which model and prompt you're running is premature. Revisit once a specific model is
   chosen as the production QC evaluator.
4a. **Only after both step 2 (prompt maxed) and step 3 (model/quant chosen) are done, run the
   `TranslateLinesBruteForce`/`RunBruteForce` sync** (see the Sixth round entry above) to
   deterministically re-sync `Files/Converted` against the current glossary, picking up 阁主/殿主
   and any other glossary entries added along the way. Deliberately not run earlier - it would
   retranslate/resync against a still-changing prompt or not-yet-chosen model, which is wasted work
   if either changes again before this runs for real.
5. **Commit outstanding work in both repos** (`DragonHierOverLlm`: this plan doc, `Files/Config.yaml`;
   `FanslationStudio.LlmKit`: the 5 `BaseQualityReviewPrompt.txt` files, `BaseFiles/Qwen38/Config.yaml`'s
   `num_ctx` change, `docs/investigations/quality-review-postmortems.md`) once a natural checkpoint is
   reached - there's a lot of uncommitted work stacked up as of this writing.
6. **Lower priority, not blocking:** grow the gold set past its current 121 items toward the
   300-500 target - today's rounds showed real run-to-run variance at this sample size (some
   metrics moved +/-0.05-0.1 between identical-config runs), which matters more as prompt/quant
   differences get smaller and more marginal.

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

The gold set (`Files/Goldset/GoldSet.yaml`) has 121 detection items and 1 correction sample as of
2026-09-20 (grown from the original 36 via two later mining batches - see **Third round** in
Status above; target remains 300-500). Its free-form category vocabulary is fully mapped onto
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

### Active Candidate Set (narrowed 2026-09-20)

After two comparison runs (pre- and post- the `BaseQualityReviewPrompt.txt` fix above), the same
prompt change was given to all six evaluators as a clean test of whether a cheaper/faster model can
close the gap to Qwen38Qc with better prompting, versus hitting a base-model capability ceiling that
prompting can't fix. Result: it splits cleanly by model, not just by size/quantization -
`HyMT2-30B-A3B` (full weight) picked up both new "easy" detection patterns (a literal
placeholder/null-value leak) immediately from the same prompt edit that improved Qwen38Qc, while its
own quantized siblings (Q3, Q3XXS) caught the identical-shape cases inconsistently, and QwenQc-14B
and HyMT2-7B caught neither. On harder categories (mistranslation, name-as-gloss reasoning), no cheap
model - including full-weight HyMT2-30B-A3B - showed real capability yet.

Going forward, only run:

- **Qwen38Qc** - current accuracy benchmark, the model every other candidate is measured against.
  Note (2026-09-20): this model is itself already a quant
  (`hf.co/unsloth/Qwen3.8-27B-GGUF:UD-Q3_K_XL`), not full weight - `Qwen38Qc-IQ4XS` and
  `Qwen38Qc-Q4KM` were added the same day to test whether a higher-precision quant of the same
  model recovers recall/precision the current default quant might be leaving on the table (see
  Status for results once run).

**Decided 2026-09-20 (final):** `HyMT2-30B-A3B` and `HyMT2-30B-A3B-Q3XXS` are dropped from routine
comparison rounds, not just benched pending a decision. Two independent, verified prompt-tuning
rounds (Status's **Third round** and **Fourth round**) each targeted a specific hard
semantic-reasoning defect (name-as-gloss, and an invented-synonym-pair mistranslation) and each
time HyMT2-30B-A3B picked up nothing on either target while Qwen38Qc improved on both - real
evidence of a capability ceiling, not a prompt-wording problem a third iteration would fix.
Q3XXS additionally showed a heavy precision cost (false positives 3 -> 10) picking up one of the
same patterns, a net-negative trade. Their `models:` definitions remain in `Files/Config.yaml`
- they're still the building blocks for the not-yet-built doubled-detection/fast-corrector
process variants (see Process Variants below), which need their own purpose-built assessment
rather than a slot in this standalone-candidate comparison. Re-add them here only if a
differently-shaped prompt strategy (not just more explicit wording of the same rules) gives a
concrete reason to re-test, or once a process-variant harness actually needs them.

Dropped from active rounds, results archived rather than deleted:

- **HyMT2-7B** - 0.00 recall on real defects in both runs; too small for this task's nuance
  regardless of prompting.
- **HyMT2-30B-A3B-Q3** - missed both easy-pattern catches; quantization has erased what made the
  full model worth testing, and a prompt can't recover precision lost to quantization.
- **QwenQc-14B** - only 27% faster than Qwen38Qc (not a meaningful discount), showed zero pickup
  from the prompt fix, and has a distinct precision bug independent of the prompt change: it flags
  `GARBLED_NUMBER` on short stat-label strings (e.g. `灵巧45` -> "Agile 45", `杀机0.1` -> "Killing
  intent 0.1") purely because a number is present, even though the number is preserved exactly and
  every other model in the comparison (including HyMT2-7B) correctly passes these. Not worth
  chasing given it isn't earning its latency either.

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