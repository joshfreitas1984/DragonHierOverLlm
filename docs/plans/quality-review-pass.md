# Plan: Post-translation Quality Review Pass

> **Status: implemented and run for real (2026-09) — results reviewed and accepted.** All six
> phases below have working, built, unit-tested code (see
> [`FanslationStudio.LlmKit/docs/quality-review-pass-architecture.md`](../../../FanslationStudio.LlmKit/docs/quality-review-pass-architecture.md)
> for the current-state technical reference — that's the doc to read to understand how the feature
> actually works today). This file is kept as **design history**: why it's shaped the way it is,
> and the trade-offs that got resolved along the way. The "Remaining work" checklist below is now
> historical (kept for the model-comparison methodology, not as an open TODO) — see its closing
> note for how it was actually resolved, and
> [`Tests/docs/dynamicstrings-pipeline-architecture.md`](../../Tests/docs/dynamicstrings-pipeline-architecture.md#quality-review-exclusion-for-function-routed-choice-entries)
> for a real-run addendum: a per-column exclusion mechanism (`GameHooks.CustomQcExclusionRule`)
> added after discovering `dynamicStrings.txt`'s function-routed dialogue-choice entries needed to
> stay out of QC's reach even though the rest of that file benefits from review. A later real run
> (2026-09) surfaced three further bugs against `qwen3.8` as the QC model - an omitted-subject
> mistranslation surviving review, a regex truncating multi-sentence corrections, and a low
> self-rated score discarding an already-validated correction - see the architecture doc's
> "Postmortems" section for the full diagnosis, and `Tests/TranslationWorkflowTests.cs`'s
> `"3g. QcOmittedSubjectRegression"` for the regression test that now guards the first of the three.

## Goal

Add a second, independent pass over already-translated text that:

1. Cleans up bad sentence construction caused by `CompoundFieldSplitter` fragmenting a cell across
   a template (either side of a split/placeholder translated in isolation, losing sentence flow).
2. Catches genuine mistranslations that already pass today's line validation — wrong names, wrong
   language, dropped nuance — things `LineValidation.CheckTransalationSuccessful` structurally
   cannot detect because it only checks token/tag/format preservation, not translation quality.
3. Never touches game-specific dynamic parameters/placeholders it shouldn't.
4. Tracks which lines have already been reviewed "to a good level" so re-running the pass doesn't
   re-review (and re-pay LLM cost for) everything every time, with no per-line human sign-off.
5. Can run against a different model than the one doing primary translation, as an independently
   run workflow step, so model choice can be A/B tested.
6. Never regresses glossary terms or drops tokens — every proposed correction is re-validated
   before being accepted, exactly like a normal translation attempt is today.
7. Surfaces a confidence/quality score per line so a human can triage by "show me the worst N%"
   instead of reading every line, and can tune (including disabling) how aggressively low scores
   hold a line back from packaging as real QC output accumulates.

## Is this a re-architecture?

**No.** The core `Line → Splits → (Templates)` contract in `FanslationStudio.LlmKit` stays exactly
as-is. The whole feature is additive: new optional fields on `TranslationSplit`, a new workflow
class, a new config section, and a new manually-run pipeline step.

## Key design decisions (why it's shaped this way)

- **Review unit is the reconstructed cell, not individual fragments** — the splitter-seam bad
  sentence construction problem this feature exists to catch is a property of the whole
  reconstructed cell, not any one fragment in isolation.
- **One QC verdict per column, anchored on the `SubIndex == 0` fragment** — a templated (compound)
  column's proposed correction is a single sentence that generally can't be cleanly re-split back
  onto individual fragments (the same ambiguous-reverse-mapping problem the fragment model exists
  to avoid elsewhere), so the whole-cell verdict lives entirely on one fragment rather than being
  spread across all of them.
- **`QcTranslated` lives directly on `TranslationSplit`**, not a separate raw→result override table
  (like `DynamicStringResultOverrides`) — simpler, and for plain columns it's a natural 1:1 mapping
  anyway.
- **`QcReviewedText` is the skip-if-unchanged AND the staleness-detection mechanism** — a column is
  only skipped on a re-run if its current effective text still matches what was last reviewed; if
  `Translated` changes for any reason afterward, it stops matching and the column is automatically
  picked up again. No separate cache file, no manual invalidation.
- **Auto-apply, gated by validation, not report-only** — a proposed correction is only accepted if
  it passes the same structural validation gate a normal translation goes through, plus a
  glossary-drift check (every glossary term matched in the raw must still appear in the correction).
  A rejected correction is recorded on the split itself (`FlaggedForQcReview` + the rejected text +
  reason), mirroring `GameFileHandlingBase.GetFailedTranslations`'s reporting shape, rather than a
  separate transient log file — never a blocking human-approval step.
- **Score is a triage signal, not a gate on its own** — `QcQualityScore` (0-100, self-rated by the
  QC model) only affects packaging (holds a column back from `Files/Mod` below
  `qualityReview.minAcceptableScore`, tunable without re-running QC) and the `FlaggedForQcReview`
  visibility flag; it never blocks the validation-gated auto-apply above.
- **The QC prompt is per-model-family, not a shared/generic file** — different model families can
  need differently-tuned wording to reliably produce the exact `SCORE:`/`CORRECTED:` format without
  leaking instructions back into their own output (the same reason `BaseSystemPrompt.txt` is
  already duplicated per preset, and exactly the failure mode this project's own
  correction-suffix-leak postmortem documents for `qwen2.5:7b`). Lives inside each preset's own
  prompt set (`BaseFiles/Qwen25/Prompts/`, `BaseFiles/Glm4/Prompts/` — a new, minimal `Glm4` preset
  added specifically for this), not a folder sitting outside the preset system.
- **Nothing but the QC engine itself resets `Qc*` fields** — discovered mid-implementation that a
  retranslation (e.g. glossary change → `ApplyAllRulesToCurrentTranslation` flags a column →
  retranslated) or a re-export/merge would otherwise leave stale `QcTranslated`/`QcQualityScore`
  around, which packaging would keep trusting until QC happened to be re-run. Fixed with a shared
  `QualityReviewHelpers.IsQcReviewFresh` check every packaging path (and the QC engine itself) must
  pass before trusting any Qc-derived field, plus carrying `Qc*` state forward across re-export
  merges when the underlying raw text is unchanged (a pure efficiency fix, not required for
  correctness). See the architecture doc's "Staleness / freshness" section for the full mechanics.

## Remaining work (historical — see "How this actually resolved" below)

1. Pull both candidate models: `ollama pull qwen2.5:14b-instruct` and `ollama pull glm4:9b`.
2. Set `qualityReview.enabled: true` in `Files/Config.yaml` (already done) and run
   `"3a. RunQualityReviewPassSample"` yourself via Test Explorer against `QwenQc-14B` — reviews a
   random ~300-column sample, not the full corpus. Never run this via a batch `dotnet test`.
3. Repeat against `Glm4Qc-9B` (change `qualityReview.modelName`, re-run `3a`).
4. Compare the two: real wall-clock time per call, the `QcQualityScore` distribution (informs a
   starting `minAcceptableScore`), how many corrections were proposed and whether they're
   genuinely good fixes, and how many got rejected by the validation gate (a high rejection rate is
   itself a signal the prompt needs tuning). Use `"3c. Find Flagged Quality Review Items"` to pull
   up anything flagged.
5. Pick a model, set `qualityReview.modelName` accordingly, and run the full,
   un-sampled `"3b. RunQualityReviewPass"` (expect a genuinely long job — many hours — regardless
   of which model, since Ollama serves one request at a time per model; see the architecture doc's
   throughput notes).
6. Once validated on a real run: the deferred docs write-back this repo's own workflow rule calls
   for — update `tests-translation-workflow.instructions.md` with a current-state summary of the QC
   pass. **Done** — see the closing note below.

(Model landscape moves fast — worth a quick check in Ollama's library for anything newer/
better-fitting than these two before committing, since the recommendation reflects what was
well-established when this plan was written.)

**How this actually resolved:** the checklist above predates the eventual model choice — by the
time a real run happened, `qwen2.5:14b-instruct`/`glm4:9b` were superseded by a larger local
candidate (`qwen3` in the 8B–27B range) as the primary-translation upgrade under consideration, with
QC evaluated as the cheaper alternative to a full corpus retranslation. The sample run surfaced one
new problem not anticipated in this plan: `dynamicStrings.txt`'s function-routed dialogue-choice
entries (raw `"{label};FunctionName"`, e.g. `出手抢夺;RobNPCItemSure` — confirmed via decompile as a
real runtime record, not extraction noise) looked like ordinary prose to the QC model despite being
partly machine-opaque, with no existing validator to catch a corrupted correction the way `PlotData
.csv` column 9 has. Rather than disabling QC for the whole file (losing review coverage for that
file's genuine template dialogue lines), a new `GameHooks.CustomQcExclusionRule` hook was added to
the shared library so a per-column rule can keep specific columns out of the pass entirely, before
any LLM call — see the shared library's `quality-review-pass-architecture.md` for the mechanism and
`Tests/docs/dynamicstrings-pipeline-architecture.md` for this game's specific rule. After that fix,
the run's corrections were reviewed and accepted; item 6 (`tests-translation-workflow.instructions
.md` write-back) is done.
