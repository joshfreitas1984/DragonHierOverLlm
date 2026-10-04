# QC: System One / "Jev"-style decision models (watchlist)

Status: **watching, no action planned.** Recorded 2026-10-04. Revisit when the Decision Index
space stabilizes (see [Revisit triggers](#revisit-triggers)).

Related: [QC evaluator model selection](qc-evaluator-model-selection.md),
[QC quality-score noise investigation](qc-qualityscore-noise-investigation.md).

## What it is

TypeSafe AI announced **Jev** on 2026-09-15: a closed, API-only "System One" model that does not
generate text. The caller supplies options up front and it returns calibrated probabilities for
each. Weights and the training algorithm ("RLCD") are unpublished, so open "reproductions" are
community guesses.

The community tracker is the Hugging Face Space
[multimodalart/jev-decision-index](https://huggingface.co/spaces/multimodalart/jev-decision-index)
(unofficial, not affiliated with TypeSafe). Its data bundle is
`data/index.json` in that Space. Snapshot below is from `generated_utc` 2026-09-28, Decision Index
0.2.1 (40-benchmark panel, five equal-weight areas, chance-corrected so 0 = random, 100 = perfect).

## Snapshot (2026-09-28)

| Score | Model | Size | Median latency (on-card) |
| --- | --- | --- | --- |
| 57.9 | Jev itself (hosted API) | n/a | ~524 ms round trip |
| 57.4 | Surogate Rune 26B-A4B v3 | 26B | 121 ms |
| 56.4 | pplx-decider-v1-27b (Qwen3.8-27B) | 28B | 101 ms |
| 54.7 | Jebadiah 27B (LoRA, Qwen3.8-27B) | 28B | 110 ms |
| 50.0 | Winnow-12B | 12B | 73 ms |
| 43.5 | Decision 1.0 Lux | 9.7B | 51 ms |
| 40.7 | Decider 4B | 4.7B | 13 ms |

Lowest calibration error among the leaders: Jebadiah 27B (ECE 0.014), pplx-decider (0.018). The
open leaders match Jev only at 26-33B; 4B-class models fall to about 41-43.

## Why it might matter for QC

- Several benchmarks answer many fields per request (yes/no per statement, per aspect, ~18
  questions). Some entrants score "all questions in one forward"; others run one forward per
  question. This is not uniform across entrants.
- If a batch of translation lines could be scored in one pass with calibrated per-line
  probabilities, shared context (glossary, rules) would be paid once per batch instead of once per
  line. The current per-line QC prompt is about 4100 tokens and `num_ctx` is the main latency cost
  (see QC latency memory: 8192 vs 6144).
- Calibrated confidence suits a triage gate: confident passes skip the LLM evaluator, uncertain
  lines go through.

## Why it is not a replacement evaluator (today)

- The index measures tool selection, intent classification, knowledge, and language
  understanding. **None of it is translation-defect detection**, so the score does not predict
  gold-set performance.
- These models emit decisions, not DEFECTS text, so they cannot replace the explanatory evaluator.
- The open leaders are Qwen/Gemma fine-tunes in the same class as the current evaluator, so little
  upside is expected without task-specific training.
- The gold set (129 items) is enough to evaluate, not to train. Training would need many more
  labeled items (see the `expand-qc-goldset` skill).
- Unchecked: Ollama/runtime support, licenses, and which entrants truly batch in one forward pass.

## Cheap experiments, if revisited

1. **No new model:** have the current Qwen38 evaluator score batches of 4/8/16 lines per call
   against the gold set; compare accuracy and per-line latency with the single-line baseline. This
   also shows whether batching hurts via cross-line interference.
2. **Triage gate:** zero-shot a small scorer (for example Decider 4B or Decision 1.0 Lux, or
   `pngwn/system-one-qwen3.5-4b-scorer`) to predict whether the existing evaluator flags a line;
   check calibration against the gold set and compare with the pre-verification gate.

## Revisit triggers

- The Space's methodology/index stabilizes (edition stops changing; 0.2.1 is current).
- An entrant is trained on or evaluated for translation/quality-estimation style tasks.
- A small (<=9B) model reaches roughly Jev-level index with low ECE and a runtime we can host.
- TypeSafe publishes weights or the RLCD method.
