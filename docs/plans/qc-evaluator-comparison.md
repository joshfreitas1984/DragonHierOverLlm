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

- **Eighth round completed 2026-09-20**: re-ran the ad hoc separator-exclusion per-category
  breakdown (methodology from the Fourth/Fifth round entries, scripted against the current
  `Qwen38Qc/Results.yaml` and `GoldSet.yaml`) to check for any category still below a comfortable
  recall bar before treating the prompt as maxed out, per Next Steps. Refined the methodology
  slightly beyond earlier rounds' manual pass: a gold-set row is scored under a category only if
  that row does **not** also carry a seam-mapped label (`omitted-separator`/`literal-newline`/
  `misplaced-separator`) - e.g. 2 of the 6 `formatting`-labeled rows also carry `omitted-separator`
  and are genuinely seam-shaped misses, not formatting misses, so they're excluded from
  `formatting`'s denominator the same way seam-only rows are excluded from the overall metric (this
  is what the Seventh round's manual analysis already did by hand; this round scripted it).

  Result, on "does the model flag a defect at all" (the current bar per Next Steps - category
  attribution accuracy is separately tracked but not the gate):

  | Category (pure, non-seam-co-occurring) | Recall |
  |---|---|
  | garbage-output | 5/5 (1.00) |
  | mistranslation | 3/3 (1.00) |
  | prompt-leak | 1/1 (1.00) |
  | terminology | 1/1 (1.00, but still 0/1 by strict category match - unchanged, known, deprioritized) |
  | invented-tag | 1/1 (1.00) |
  | dropped-content | 4/5 (0.80) - one isolated miss (`c765f5d8f19adc53`, HyMT2-7B drops the
    `GiveNpcAskItem` identifier from a semicolon-delimited stat string), not a repeated pattern |
  | formatting | 2/4 (0.50) - both misses are the already-decided-deprioritized
    `cb459b1c8e845a04` stray-trailing-whitespace pair from the Seventh round; no new formatting gap |
  | fluency | 0/1 (0.00) - single item `c61cdad79df4c969`, source `则为` (a bare 2-character
    classical fragment, "Qwen25-Standard" candidate "Is thus" judged unnatural) |

  `fluency`'s 0/1 is the only new low number, but n=1 and the failing case has the same shape as the
  already-excluded `50ff7ccfb54c694e` (殷殷) item: a bare, context-free classical fragment sampled
  with no surrounding sentence, where a literal short rendering reads stilted but isn't clearly
  wrong - a possible unfair-test artifact, not a confirmed systemic weakness, and too small a sample
  to prompt-tune against. **Not treated as a new active target** - flag for attention only if the
  gold set's later growth (Next Steps item 6, 300-500 target) adds more `fluency` items and the
  pattern repeats.

  **Conclusion: no new category below a comfortable recall bar.** `formatting` and `terminology`
  remain the only sub-bar categories and both are already decided/deprioritized (Fifth/Sixth/Seventh
  rounds) - the prompt is confirmed maxed out. Proceeded immediately to Next Steps item 3: restored
  `Qwen38Qc-IQ4XS`/`Qwen38Qc-UDQ4KM` to `qualityEvaluatorAssessment.modelNames` in
  `Files/Config.yaml`, deleted the three quants' stale `Files/TestResults/QcEvaluatorAssessment/`
  output directories, and started a fresh three-way quant sweep (`Tests/AssessmentWorkflowTests.cs`'s
  "2. Assess configured QC models") to pick between `Qwen38Qc-UDQ4KM` (best precision, 0.789,
  3130ms avg) and `Qwen38Qc-IQ4XS` (same recall 0.652, 37% faster, 1988ms) per the plan's model
  choice.

- **Ninth round completed 2026-09-20**: the final quant sweep from the Eighth round, all three
  quants run fresh in one `dotnet test` pass (`Tests/AssessmentWorkflowTests.cs`'s "2. Assess
  configured QC models", 12m26s wall time, all three `Results.yaml` timestamps confirmed to postdate
  both the Config.yaml restore and the Seventh round's prompt-fix commit). Same excluded-methodology
  (seam-category exclusion + the one excluded gold item) as every prior round:

  | Model | Quant | Recall | Precision | Avg latency | p95 latency |
  |---|---|---|---|---|---|
  | **Qwen38Qc** | `UD-Q3_K_XL` (14.08 GB, the long-standing default) | **0.778** (14/18) | 0.778 (14/18) | **1429ms** | 3745ms |
  | Qwen38Qc-IQ4XS | `UD-IQ4_XS` (15.18 GB) | 0.778 (14/18) | 0.778 (14/18) | 1893ms | 5403ms |
  | Qwen38Qc-UDQ4KM | `UD-Q4_K_M` (17.4 GB) | 0.722 (13/18) | **0.812** (13/16) | 2796ms | 9059ms |

  This is a materially different picture from the Fifth round's pre-prompt-maxing sweep (there,
  recall climbed monotonically with quant precision: 0.609 -> 0.652 -> 0.652, and UDQ4KM's precision
  edge, 0.789, was a clear win). After the Sixth/Seventh round prompt fixes, **Qwen38Qc and
  Qwen38Qc-IQ4XS are now tied on both recall and precision** - the recall gap that used to justify
  IQ4XS's extra latency (32% slower on avg, 44% slower on p95) has closed, so IQ4XS no longer earns
  its cost; it is strictly dominated by the faster default quant. **Qwen38Qc-UDQ4KM now trades LOWER
  recall (0.722 vs 0.778) for higher precision (0.812 vs 0.778) at roughly 2x the latency** - the
  wrong direction of tradeoff for this task, per the Fifth round's own framing (accuracy priority
  ordering): a missed defect ships silently and never gets a second chance, while a false positive
  only costs one bounded correction/verify round-trip, so recall matters more than precision as a
  tie-breaker, not less. Sample-size caveat: 18 gold-set defect samples in the excluded-methodology
  denominator is small, and the recall gap here (13 vs 14 hits) is a single sample - within the
  ±0.05-0.1 run-to-run variance band the Fifth round already flagged, so this is not overwhelming
  evidence UDQ4KM is a worse model in general, only that this round found no measured recall benefit
  to justify its cost, which is what the Acceptance Gates require ("use a slow model only when it
  produces a measured improvement a faster model cannot provide").

  **Decision: `Qwen38Qc` (the existing default `UD-Q3_K_XL` quant) is confirmed as the production QC
  model** - `Files/Config.yaml`'s `qualityReview.modelName` already pointed at it, so no production
  config change was needed; `qualityEvaluatorAssessment.modelNames` was narrowed back from all three
  quants to `Qwen38Qc` alone for routine future rounds (Process Variants work, item 4 below, doesn't
  need repeated quant comparisons). **Next Steps item 3 (final quant sweep) is now done.**

- **Tenth round completed 2026-09-20 (Process Variants, Variant 1 - doubled detection): implemented
  and measured, `Qwen38Qc`.** Per the "Handoff: Implementing Process Variants" section's code-audit
  finding, `QualityEvaluatorAssessmentWorkflow.ReviewDetectionAsync` was rewired to call
  `QualityReviewWorkflow.DetectDefectsAsync` directly (now `internal`, was `private`) instead of the
  full five-call `GetLlmVerdictAsync`, gated by a new `qualityEvaluatorAssessment.doubledDetection`
  bool (default `true`, matching production). This both implements the variant and fixes the
  latency-contamination bug the handoff flagged (calls 3-5 no longer run as a side effect of scoring
  detection). A `doubledVerification` flag was also added to the config for the not-yet-implemented
  Variant 2, currently a no-op.

  Three fresh runs against the current gold set (121 items, same excluded-methodology as every prior
  round - seam-category rows and the one excluded gold item dropped from the denominator entirely,
  18 in-scope `Defect` rows remain):

  | Run | Code path | Recall | Precision | Avg latency |
  |---|---|---|---|---|
  | Ninth round's original baseline | OLD `GetLlmVerdictAsync`-based (calls 3-5 contaminate detection-scored rows) | 0.778 (14/18) | 0.778 (14/18) | 1429ms |
  | Clean doubled detection | NEW `DetectDefectsAsync` x2 + `Merge`, no calls 3-5 | 0.722 (13/18) | 0.765 | 927ms |
  | Single detection | NEW `DetectDefectsAsync` x1 | 0.667 (12/18) | 0.750 | 506ms |

  The old baseline's own recall/precision numbers reproduce exactly (14/18, 0.778/0.778, 1429ms) -
  confirms the excluded-methodology script here matches every prior round's. Two findings:

  1. **The latency-contamination bug was real and material, not just theoretical**: even
     doubled-detection-only latency (927ms, two calls, no drafting/verification) is 35% lower than
     the 1429ms the Ninth round attributed to "detection" - that figure was always calls-1+2 blended
     with calls 3-5 on confirmed-defect rows. This does NOT change the Ninth round's quant-selection
     conclusion (production's real per-split cost still includes calls 3-5 when a defect is
     confirmed, same as before - nothing about production's `GetLlmVerdictAsync` changed), but it
     does mean the 1429ms figure should not be read as "how long detection alone takes."
  2. **Doubled detection's recall lift is real but small, and provably non-negative**: aggregate
     recall differs by one sample (13 vs 12 of 18) - on its own, within the ±0.05-0.1 run-to-run
     noise band this doc has flagged since the Fifth round. A row-level paired comparison (same 18
     in-scope `Defect` rows, doubled vs single from these same two runs) resolves the ambiguity:
     exactly **1 row gained, 0 rows lost** - `679e93471a09d7ff:HyMT2-30B-A3B` (`dropped-content`)
     is caught by the call-1+call-2 merge but missed by call 1 alone; no row single-detection caught
     that doubled detection missed. Since `QcDetectionResult.Merge` is a set union, doubled detection
     can only match or exceed call-1-alone's catch rate for any individual pair of real LLM calls
     (never regress it) - the paired result confirms this held here, at the cost of ~1.83x the
     latency (927ms vs 506ms, consistent with running the same call twice).

  **Decision: keep `doubledDetection: true` as the production-matching default.** The measured lift
  is thin at this sample size (1 of 18 defect rows) but never negative, and per the established
  priority (a missed defect ships silently forever; the cost of doubled detection is bounded,
  predictable latency) that asymmetry favors keeping it even though the *size* of the benefit isn't
  well-pinned down yet. Revisit once the gold set grows past 121 (Next Steps item 6) - 18 defect
  rows is too few to size this tradeoff precisely; a larger denominator might show a bigger or
  smaller gap.

  **Variant 2 (doubled verification) remains unimplemented and unmeasurable** - still gated on
  mining harmful-labeled correction examples into the gold set first, per the Handoff section above.
  Not attempted this round.

- **Eleventh round completed 2026-09-20 (Variant 2 gold-set expansion): gold set now has its first 2
  `harmful`-labeled correction examples, and `Qwen38Qc` misses both.** Per the Handoff section's
  guidance, ran `QualityReviewWorkflow.RunAsync`'s 300-item real production sample pass
  ("1. RunQualityReviewPassSample" test) against the live corpus to generate real corrections to
  review. That specific run only touched a handful of rows (most of the 300-item sample had already
  been QC'd in earlier sessions), but `Files/Converted` already holds ~22,000 production-generated
  `qcStatus: Corrected` rows from all prior QC work - a large enough pool to mine directly without
  needing a fresh corpus-wide run. Sampled ~150 of these (structured extraction reconstructing each
  full templated cell's pre/post-correction text, not just a single sub-split - the raw per-split
  fields are misleading in isolation, since one cell's `qcTranslated` covers ALL of that cell's
  sub-splits joined, not just the one carrying the QC metadata) and reviewed for defects the
  correction itself introduced. Found two clean, unambiguous harmful corrections and added them to
  `Files/Goldset/GoldSet.yaml`'s `correctionSamples` (now 3 total, `Files/Goldset/GoldSet.yaml`):

  - `cd12d3474f462380`: source's "都点检" (a historical military title, "Commander-in-Chief") is
    correctly left as an ambiguous-but-acceptable "him" in the pre-correction text, but the
    "corrected" version fabricates a nonexistent character name, "Du Dianjian", found nowhere in
    source or the rest of the game's cast - actively invents a new character rather than fixing
    anything.
  - `bdbe7026ca751cf2`: the correction silently drops one of two `#PlayerName#` placeholders from a
    two-sentence templated cell, replacing it with "them" - a structurally verifiable break (not a
    judgment call) that would ship without ever substituting the player's actual name in that spot.

  Ran a fresh `Qwen38Qc` assessment pass against the expanded gold set (deleted the cached
  `Results.yaml` first, per the usual caching-trap precaution). **Result: `Qwen38Qc`'s verification
  (call 4) scored BOTH new harmful examples `Safe`** (95/100 for the fabricated-name case, 90/100
  for the dropped-placeholder case) - 0/2 recall on harmful corrections. This is not a fluke specific
  to this test harness: the dropped-placeholder example was mined from a REAL production run where
  the actual pipeline's own verify step also accepted it (75/100, above `minAcceptableScore: 60`).
  Two real, independently-generated verify calls (production's real run, and this fresh assessment
  run) both missed the same structurally-detectable defect. **This is a genuine, confirmed
  verification blind spot** - not proof doubled verification (Variant 2) would fix it (an
  independent second verify call could just as easily also miss it, the same open question doubled
  detection answered empirically for detection), but it is now, for the first time, a measurable one:
  Variant 2's implementation (per the Handoff section's plan) can be built and scored against these
  2 examples as soon as it exists. 2 examples is still a thin denominator - treat any recall/precision
  computed from it as directional, not final, until more harmful examples are mined (this pool of
  ~22,000 already-corrected rows makes further mining cheap: no fresh LLM run needed, just more
  sampling and review).

- **Twelfth round completed 2026-09-20 (Variant 2 implemented and measured): doubled verification
  does NOT catch either harmful example - both calls make the identical mistake.** Implemented per
  the Handoff section's plan: added `QcVerificationResult.Merge` (`FanslationStudio.LlmKit/Support/
  QcVerificationResult.cs`) - the mirror-opposite of `QcDetectionResult.Merge`: detection merges
  permissively (either call's finding is kept, since a missed defect is the worse failure),
  verification merges STRICTLY (either call's objection rejects the correction, since accepting a
  harmful correction is the worse failure here). Wired `QualityEvaluatorAssessmentWorkflow.
  ReviewCorrectionAsync` to call `GetVerificationVerdictAsync` once or twice (per
  `doubledVerification`, matching `doubledDetection`'s pattern) and merge via the new method.

  Ran a fresh `Qwen38Qc` pass (cache deleted first) with `doubledVerification: true` (the new
  default, matching `doubledDetection`'s precedent): **both harmful examples still scored `Safe`,
  at the exact same scores as the single-call run** (95/100 fabricated-name, 90/100 dropped-
  placeholder) - only the latency changed (652ms -> 1353ms on the placeholder case, confirming both
  calls actually ran, not a caching artifact). This means the two independent verify calls didn't
  just partially disagree and get merged into a stricter rejection - they made the IDENTICAL
  mistake both times. Unlike Variant 1 (where call 2 sometimes caught what call 1 missed, because
  detection errors are apparently at least partly independent/random across calls), this looks like
  a systematic prompt/model gap rather than call-to-call noise: nothing in
  `BaseQualityReviewVerificationPrompt` explicitly instructs comparing placeholder-token counts
  between `CURRENT TRANSLATION` and `PROPOSED CORRECTION`, or checking that no named entity appears
  in the correction that isn't in `SOURCE` - so there's no reason to expect either call to notice by
  chance. **Doubling a verify call that has no idea what to look for doesn't help**; this is a
  concrete, falsifiable claim about *why* it failed, not just that it failed, and points squarely at
  a verification-prompt fix (explicit placeholder-preservation and no-new-named-entities checks) as
  the next lever to pull, rather than further process-shape changes like doubled verification.
  2-example denominator caveat still applies - this is a strong directional signal (identical
  failure twice, explainable by a concrete prompt gap) but not a final recall/precision number.

- **Thirteenth round completed 2026-09-20 (verification-prompt fix): both harmful examples now
  caught, no detection regression.** Added the two mechanical checks the Twelfth round identified as
  missing - placeholder-token-count preservation and no-fabricated-named-entities - to
  `BaseQualityReviewVerificationPrompt.txt` across all 5 model families (`FanslationStudio.LlmKit/
  BaseFiles/{Qwen38,HyMT2,HyMT2Moe,Qwen25,Glm4}/Prompts/`), as an explicit numbered/lettered
  sub-check under the existing "does the correction introduce a new problem" step, plus a matching
  mention under `OTHER_NAMED_DEFECT` so the category vocabulary stays consistent. Qwen38/HyMT2/
  HyMT2Moe shared one prompt text byte-for-byte; Glm4/Qwen25 shared a second, more heavily-elaborated
  text - edited each of the two source texts once and propagated.

  Deleted the cached `Results.yaml` (prompt change, same caching-trap precaution as every round) and
  ran a fresh `Qwen38Qc` pass: **both harmful examples now correctly score `Harmful`** (0/100, both
  `UNRESOLVED`/`NEW_DEFECTS` correctly populated) - up from 0/2 to 2/2 - and the pre-existing `safe`
  correction sample (`5b03cbee1d695c74`) still scores `Safe` (no false-positive regression from the
  new checks being overzealous). Detection recall/precision on the same 18-defect-row
  excluded-methodology denominator is unchanged (0.722/0.765, ~910ms avg) from the Twelfth round's
  clean-doubled baseline, confirming the verification-only prompt change had no side effect on
  detection (expected, since `BaseQualityReviewPrompt` - detection's own prompt - was untouched).
  Still only a 2-example denominator for the harmful-correction measurement specifically, but going
  2-for-2 immediately after a targeted, mechanistic fix (not a broad prompt rewrite) for the exact
  failure mode identified is a strong signal, not a coincidence. Uncommitted work now includes the 5
  verification prompt files, `QcVerificationResult.Merge`, and `ReviewCorrectionAsync`'s doubling -
  see Next Steps item 5 for the standing "commit when a checkpoint is reached" reminder.

## Next Steps (decided 2026-09-20 - read this before starting further work; Seventh/Eighth/Ninth
round entries above supersede this section's older `formatting`/`terminology`/quant framing.
**Items 1-3 are now done. Item 4a (the brute-force glossary sync) was explicitly declined by the
user 2026-09-20 - do not run it or ask about it again unless the user brings it up. Item 4 (process
variants) is the chosen active work - see the "Handoff: Implementing Process Variants" subsection
under Process Variants below for the concrete implementation plan.**)

Priority order, chosen deliberately over "pick a quant now":

1. **Remove ruled-out models from `Files/Config.yaml`.** Done 2026-09-20:
   `Qwen38Qc-Q4KM` (plain quant, beaten outright by `Qwen38Qc-UDQ4KM`) removed from `models:` and
   `qualityEvaluatorAssessment.modelNames`. `HyMT2-30B-A3B`/`HyMT2-30B-A3B-Q3XXS` were already
   dropped from `modelNames` (Fourth round) but their `models:` definitions stay for later
   process-variant work.
2. **Prompt-max detection quality across every remaining weak category, on the fastest quant
   (`Qwen38Qc`/`UD-Q3_K_XL`), before doing any further quant comparison.** **Done 2026-09-20 (Eighth
   round): re-ran the ad hoc separator-exclusion per-category breakdown and confirmed no category is
   below a comfortable recall bar besides the already-decided `formatting`/`terminology` - prompt
   treated as maxed out.** Reasoning: prompt fixes
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
   trading off recall/precision against latency at corpus scale. **Done 2026-09-20 (Ninth round):
   `Qwen38Qc` (the existing default `UD-Q3_K_XL` quant) is confirmed as the production model - it
   ties `Qwen38Qc-IQ4XS` on recall/precision while being the fastest, and beats `Qwen38Qc-UDQ4KM`'s
   higher precision with better recall (the more important metric for QC) at roughly half the
   latency. No production config change was needed; `qualityEvaluatorAssessment.modelNames` narrowed
   back to `Qwen38Qc` alone.** Full-corpus math (81,165 splits in
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
   chosen as the production QC evaluator. **Variant 1 (doubled detection) done 2026-09-20 (Tenth
   round): implemented as a `qualityEvaluatorAssessment.doubledDetection` flag (default `true`) and
   measured against `Qwen38Qc` - a real but small (1 of 18 gold `Defect` rows, provably
   non-negative via paired comparison) recall lift at ~1.83x the latency; kept as the
   production-matching default. Variant 2 (doubled verification) gold-set-mining prerequisite done
   2026-09-20 (Eleventh round): gold set now has its first 2 `harmful`-labeled correction examples,
   mined from the ~22,000 already-corrected rows in `Files/Converted` rather than a fresh LLM run.
   `Qwen38Qc`'s verification missed both (scored them `Safe`) - a confirmed, measurable verification
   blind spot. `DoubledVerification` implemented and measured 2026-09-20 (Twelfth round): both
   independent verify calls make the IDENTICAL mistake on both harmful examples - doubling doesn't
   help here, unlike doubled detection. Root cause looks like a verification-PROMPT gap (no explicit
   placeholder-preservation or no-new-named-entities check), not call-to-call noise. **Verification
   prompt fixed 2026-09-20 (Thirteenth round): added both checks to all 5 model families'
   `BaseQualityReviewVerificationPrompt.txt` - both harmful examples now correctly score `Harmful`
   (0/100), the pre-existing safe example is unaffected, and detection recall/precision is unchanged.
   Process Variants work (item 4) is done: both variants implemented and measured, and the concrete
   prompt gap Variant 2's measurement surfaced has been fixed and re-verified.**
4a. ~~Only after both step 2 (prompt maxed) and step 3 (model/quant chosen) are done, run the
   `TranslateLinesBruteForce`/`RunBruteForce` sync~~ (see the Sixth round entry above) to
   deterministically re-sync `Files/Converted` against the current glossary, picking up 阁主/殿主
   and any other glossary entries added along the way. **Declined by the user 2026-09-20** - both
   gating conditions (prompt-maxed, model chosen) are now met, but the user does not want this run.
   Do not run it or bring it up again unless the user asks.
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

The gold set (`Files/Goldset/GoldSet.yaml`) has 121 detection items and 3 correction samples as of
2026-09-20 (grown from the original 36 via two later mining batches - see **Third round** in
Status above; target remains 300-500). Its free-form category vocabulary is fully mapped onto
`QcDefectCategory` in `ParseCategory` (locked in by
`Tests/Workflow/QualityEvaluatorAssessmentWorkflowTests.cs`'s `ParseCategory_MapsEveryGoldSetCategory`
theory) - a category is never silently collapsed into a shared catch-all it doesn't actually belong
to. **The gold set now has its first 2 `harmful`-labeled correction examples** (added 2026-09-20,
Eleventh round) - mined directly from the ~22,000 already-`qcStatus: Corrected` rows already sitting
in `Files/Converted` from prior production QC runs, not from translation-assessment output (which
never contains a proposed correction to judge) or a dedicated fresh correction-generation run (not
needed - the corpus already has plenty of real corrections to review). `Qwen38Qc` missed both in a
fresh assessment pass, scoring them `Safe`. 2 examples is still thin for a reliable harmful-correction
rate - treat it as directionally measured, not final, until more are mined from the same pool.

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

### Handoff: Implementing Process Variants (2026-09-20, item 4 chosen as active work)

Code-audit finding that changes the starting point for this work, discovered while confirming the
Ninth round's quant-sweep numbers: `QualityEvaluatorAssessmentWorkflow.ReviewDetectionAsync`
(`FanslationStudio.LlmKit/Workflow/QualityEvaluatorAssessmentWorkflow.cs:141`) does not call the
individual stage methods the Evaluation Protocol section calls for - it delegates the whole gold-set
detection row to `QualityReviewWorkflow.GetLlmVerdictAsync`
(`FanslationStudio.LlmKit/Workflow/QualityReviewWorkflow.cs:1025`), which is the full production
five-call orchestrator. Two consequences, both relevant before writing any variant flag:

1. **Doubled detection is already unconditionally "on" in every round measured so far** (Third
   through Ninth) - `GetLlmVerdictAsync` always runs `DetectDefectsAsync` twice and merges via
   `QcDetectionResult.Merge` (lines 1035-1043) before any scoring happens. There is currently no
   call-1-only baseline anywhere in this doc's numbers to compare against - Variant 1's "recall lift
   attributable to call 2" has never actually been measured, only assumed to exist.
2. **Detection-row latency is contaminated by calls 3-5** whenever a defect is confirmed - if
   `namedDefects.Count > 0`, `GetLlmVerdictAsync` also drafts a correction and runs
   verify/repair (lines 1074-1115) even though `ReviewDetectionAsync` only scores the detection
   outcome and throws the correction away. This is likely why some `Defect`-labeled rows show
   2000-2400ms elapsed against a ~800ms typical `Pass` row in every `Results.yaml` to date - the
   avg/p95 latency figures reported in the Fifth and Ninth round tables are end-to-end five-call
   latency on confirmed-defect rows blended with pure-detection latency on clean rows, not a clean
   per-stage number. Not disqualifying (it reflects real corpus-wide call-mix cost reasonably well
   for the full-corpus runtime math), but a caveat for whoever reads those tables expecting "pure
   detection latency."

**Required changes, `FanslationStudio.LlmKit`:**

1. Change `DetectDefectsAsync` (`QualityReviewWorkflow.cs:870`, currently `private static`) and
   `GenerateCorrectionAsync` (`QualityReviewWorkflow.cs:924`, currently `private static`) to
   `internal static`, matching `GetVerificationVerdictAsync`/`GetCorrectionRepairAsync`
   (already `internal`, already called directly by `QualityEvaluatorAssessmentWorkflow.ReviewCorrectionAsync`
   for the same reason) - the assessment harness needs to call each stage independently instead of
   through the monolithic orchestrator.
2. Add two `bool` flags to the QC evaluator assessment configuration (wherever `ModelNames`/
   `GoldSetPath`/`OutputPath` live today - do NOT add these to `QualityReviewConfig`, per the
   existing instruction above this section), e.g. `DoubledDetection` and `DoubledVerification`,
   both defaulting to `true` to match current behavior.
3. Rewrite `ReviewDetectionAsync` to stop calling `GetLlmVerdictAsync` and instead call
   `DetectDefectsAsync` directly (once if `DoubledDetection` is off, twice + `Merge` if on) - this
   both implements the variant AND fixes the latency-contamination problem above, since it no
   longer triggers calls 3-5 as a side effect of scoring detection. Score/record exactly as today
   (`ActualLabel`/`ActualDefectCategory`/`ActualDefectCategories` from the resulting
   `QcDetectionResult`, mapping `None`/`Uncertain`/named the same way `GetLlmVerdictAsync` currently
   does at lines 1047-1066).
4. Simplest way to compare on vs. off without inventing new result schema: run the flag as two
   separate passes into two separate output directories, the same way quant variants are already
   just separate `qualityEvaluatorAssessment.modelNames` entries pointing at the same underlying
   model - e.g. add a second `ModelExecutionConfig` alias (`Qwen38Qc-SingleDetect`) that points at
   the same Ollama model but is only ever run with `DoubledDetection: false` (config plumbing TBD -
   whichever is less invasive: a per-model override field, or a workflow-level flag applied to every
   model in one run). This reuses 100% of the existing `Comparison.yaml`/`Results.yaml`/ad hoc
   analysis script infra from this session (`category_breakdown.py`'s pattern - excluded-methodology
   recall/precision plus a per-category breakdown) instead of building new reporting.
5. Metric to report specifically (per the Process Variants section above): recall lift attributable
   to call 2 alone - gold `Defect` rows where the single-detection pass misses/miscategorizes but
   the merged pass catches it - separately from the aggregate recall/precision delta, since the
   corpus-wide 2x cost has to be justified against that specific lift, not the aggregate number.

**Doubled verification (call 4) is currently unmeasurable, not just unimplemented:** the gold set
has zero `harmful`-labeled correction examples (noted in the "Separator/Newline Defects Are Out of
Scope" section below) - it can only be filled by running the real pipeline's correction generation
and reviewing what comes back, per that section's existing note, since mining translation-assessment
output never contains a proposed correction to judge. **Recommended order:** do Variant 1 (doubled
detection) first - the gold set already has plenty of `Defect` rows for it, no prerequisite work
needed. Only take on Variant 2 after growing harmful-correction gold examples (via the
`expand-qc-goldset` skill against a real correction-generation run, or a dedicated mining pass) -
writing the harness flag before that data exists would have nothing to measure it against.

**Same caching trap as every prior round applies**: `QualityEvaluatorAssessmentWorkflow` caches
`Results.yaml` on gold-set fingerprint only, not on config/prompt content, so delete
`Files/TestResults/QcEvaluatorAssessment/<model>/` before switching the flag and re-running, or the
harness will silently return the previous flag's cached results. Write findings up as the next
numbered round (Tenth) in Status above, same format as every round to date.

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