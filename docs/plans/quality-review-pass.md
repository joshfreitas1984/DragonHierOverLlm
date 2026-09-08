# Plan: Post-translation Quality Review Pass

> Status: **design, not implemented**. This is a planning document — no code changes have been
> made yet. Written 2026-09-09. Spans two repos: this one (`DragonHierOverLlm`) and the sibling
> shared library `FanslationStudio.LlmKit` (`../FanslationStudio.LlmKit`, a project reference, not
> a NuGet package).

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

**No.** The core `Line → Splits → (Templates)` contract in `FanslationStudio.LlmKit` (documented
in its `ARCHITECTURE.md`/copilot-instructions as "the contract every downstream project depends
on") stays exactly as-is. This whole feature is additive: new optional fields on
`TranslationSplit` (safe for old serialized YAML, same principle already used for
`FlaggedMistranslation`/`FlaggedHallucination`), a new workflow class, a new config section, and a
new manually-run pipeline step — the same shape as how `PrefabTextWorkflow` and model escalation
were added previously. Existing translation/packaging code paths are only touched at the specific
points listed in Phase 3 below.

## Phase 0 — Docs cleanup (prerequisite, both repos)

`DragonHierOverLlm` already has the target shape: short `AGENTS.md`/`CLAUDE.md` pointing to
`docs/README.md`, which indexes per-project scoped instructions + `KNOWN_ISSUES.md` + `docs/*.md`
topic files. `FanslationStudio.LlmKit` does not — its `.github/copilot-instructions.md` is 422
lines and mixes current-state rules with long investigation narratives (retry mechanics, a
correction-suffix-leak bug writeup, a game-specific-hook ordering bug writeup, etc.) that belong in
topic docs, not an auto-loaded instructions file.

Work:
- Add `FanslationStudio.LlmKit/AGENTS.md` (vendor-neutral rules) and trim
  `.github/copilot-instructions.md` down to current-state operational rules only (data model
  shape, extension points, testing conventions, the "golden rule" about not changing the
  Line/Splits/Templates shape).
- Add `FanslationStudio.LlmKit/docs/README.md` as the navigation hub (mirrors
  `DragonHierOverLlm/docs/README.md`'s taxonomy: scoped instructions → `KNOWN_ISSUES.md` index →
  `docs/*.md` topic files).
- Split the narrative content currently inside `copilot-instructions.md` out into topic files under
  `docs/` (e.g. `docs/translation-service-retry-and-escalation.md`,
  `docs/compoundfieldsplitter-placeholder-design.md`, `docs/known-fixes-2026-08.md`), each indexed
  from a new `FanslationStudio.LlmKit/KNOWN_ISSUES.md`.
- `ARCHITECTURE.md` and `OPTIMIZATION_PLAN.md` already fit the "topic file" tier as-is and don't
  need rewriting, just linking from the new `docs/README.md`.
- Leave `DragonHierOverLlm`'s own docs alone except adding this plan (already done by writing this
  file) and, once Phase 1–5 are implemented, the normal write-back this repo's own instructions
  already require (update `tests-translation-workflow.instructions.md` +
  `FanslationStudio.LlmKit`'s instructions, per the existing workflow rule — not done as part of
  planning).

This phase is pure documentation restructuring, mechanically similar to what was already done for
this repo, so it's low-risk to do first and independently of the rest.

## Phase 1 — Data model additions (`FanslationStudio.LlmKit`, additive only)

On `Support/TranslationSplit.cs`, add:

```csharp
public string QcTranslated { get; set; } = string.Empty;
public QcStatus QcStatus { get; set; } = QcStatus.NotReviewed;
public string QcReviewedText { get; set; } = string.Empty;

// Set when a proposed correction was rejected by the validation gate (Phase 4) - lets a human
// reviewer see exactly what QC tried and why, sitting right next to Translated in the same
// Files/Converted/*.yaml record, instead of a separate transient log file.
public bool FlaggedForQcReview { get; set; } = false;
public string QcRejectedCorrection { get; set; } = string.Empty;
public string QcFailureReason { get; set; } = string.Empty;

// 0-100 self-rated confidence, from the QC model itself, that the CURRENT Translated/QcTranslated
// value is an accurate, well-constructed translation - set on every reviewed split, whether or not
// a correction was proposed. Nullable: null means "not yet reviewed" (distinct from a real 0),
// same reasoning as QcStatus.NotReviewed.
public int? QcQualityScore { get; set; }
```

`FlaggedForQcReview` follows the exact same convention as `FlaggedForRetranslation`/
`FlaggedMistranslation`/`FlaggedHallucination` — a bool the QC engine sets/clears itself on every
review, not an append-only marker a human has to remember to clear. If a subsequent QC run (after
the line's `Translated` changed, e.g. a human hand-fixed it, or the QC algorithm/prompt was
tweaked) no longer rejects the line, the flag is cleared automatically the same way
`TryFlag*`-style checks already reset `FlaggedForRetranslation` each pass in
`Workflow/TranslationWorkflow.cs`.

```csharp
public enum QcStatus
{
    NotReviewed,
    Passed,       // reviewed, no correction needed
    Corrected,    // reviewed, correction proposed AND passed the validation gate
    FailedValidation, // reviewed, a correction was proposed but rejected by the validation gate; original Translated left untouched, logged for visibility
}
```

- `QcReviewedText` stores the exact "effective cell text" (see Phase 2) that was reviewed. On the
  next QC run, a split/column is skipped (no LLM call) if its current effective text still equals
  `QcReviewedText` — this is what satisfies "don't re-review every line every run" without a
  separate cache file. If the underlying translation changes later (re-translation, manual glossary
  fix, a future retranslation pass), `QcReviewedText` no longer matches and the line is
  automatically picked up for review again — no manual invalidation needed.
- `QcTranslated` empty + `QcStatus == Passed` means "reviewed, kept as-is" (packaging falls back to
  `Translated`, identical output). `QcTranslated` non-empty + `QcStatus == Corrected` means
  packaging should prefer it over `Translated`.
- `ResetFlags()` should **not** reset the `Qc*` fields — those track an independent review axis
  from `FlaggedForRetranslation`/`FlaggedMistranslation`/`FlaggedHallucination`, which track the
  primary translation attempt.

### Resolving plain vs. templated (compound) columns

You asked for `QcTranslated` to live directly on `TranslationSplit` rather than a separate
raw→result override table (like `DynamicStringResultOverrides`), and that's the right call for
plain columns — there's exactly one split per column, so it maps 1:1. For a **templated** column
(a `FieldTemplate` reconstructing several fragments via `{0}`/`{1}`/...), the QC pass reviews the
**whole reconstructed cell** (see Phase 2's "review unit" decision), so its proposed correction is
a single corrected sentence that generally can't be cleanly re-split back onto individual
fragments — that's exactly the "ambiguous, error-prone reverse-mapping" problem, and this plan
avoids it entirely rather than attempting it.

Resolution: for a templated column, the whole-cell QC correction is stored on that column's
`SubIndex == 0` fragment (the first fragment always exists and is a stable, unambiguous anchor per
column). Packaging (Phase 3) checks that one fragment's `QcTranslated`/`QcStatus` to decide whether
to bypass `Reconstruct()` entirely for that column. Other fragments in the same column
(`SubIndex >= 1`) don't carry independent QC state — there is one QC verdict per **column**, not
per fragment, consistent with the fact that the splitter-seam problem this feature exists to fix is
a property of the whole reconstructed cell, not of any one fragment in isolation. This asymmetry
(plain columns: 1 split = 1 QC verdict; templated columns: N splits but 1 QC verdict, anchored on
`SubIndex 0`) will be documented explicitly in the shared library's instructions file once built,
since it's not obvious from the field names alone.

## Phase 2 — QC review unit & masking

**Review unit: reconstructed cell only** (your choice) — for each column of each already-translated
line:
- Plain column → effective text = `split.Translated`.
- Templated column → effective text = `CompoundFieldSplitter.Reconstruct(template, fragments)`
  (the exact string that would be written to the CSV today).

The raw Chinese cell is sent alongside as reference/ground truth (same `raw`/`result` shape
`LineValidation` already uses everywhere else).

**Skip conditions** (no LLM call): split not yet translated (`Translated` empty),
`FlaggedForRetranslation` still true (don't QC something about to be retranslated anyway),
`!SafeToTranslate`, or `QcReviewedText == effective text` (already reviewed, unchanged since).

**Masking game-specific dynamic parameters (point 3):** before sending the effective text to the
QC model, run it through the same `StringTokenReplacer`/`CompoundFieldSplitterOptions
.PlaceholderPatterns` masking the translation pipeline already uses for `#PlayerName#`-style
tokens, restoring after. This is already a per-game opt-in (`GameFileHandling.SplitterOptions` in
this repo) — the QC pass reuses it rather than inventing a second mechanism. If a future game needs
QC-specific ignore patterns that don't apply to splitting, add an optional
`LlmConfig.QualityReview.IgnorePatterns` (same shape as `PlaceholderPatterns`) — game-specific,
opt-in, game-agnostic default (empty) in the shared library, exactly like every other
game-specific hook in this codebase.

## Phase 3 — Packaging changes

Everywhere packaging currently reads `split.Translated` for the final written value, prefer
`split.QcTranslated` when non-empty:

- `GameFileHandlingBase`/this repo's `PackageFinalTranslationAsync` (CSV path): for a plain column,
  use `split.QcTranslated` if set else `split.Translated`. For a templated column, if the
  `SubIndex == 0` fragment has non-empty `QcTranslated`, use it directly as the literal cell value
  (bypass `Reconstruct()` for that column entirely); otherwise reconstruct as today from each
  fragment's `Translated`.
- `PrefabTextWorkflow.PackagePrefabTextAsync` / `DynamicStringWorkflow`'s packaging (flat
  raw/result lists): same `QcTranslated`-over-`Translated` fallback, since these are single-split,
  no-template files.

A row/entry already marked failed (kept as `Raw`) by existing rules is unaffected — QC only ever
runs on splits that already have a real `Translated` value.

### Score-gated packaging (point: "committed but not packaged")

`Config.yaml`'s `qualityReview:` section (Phase 5) gets `minAcceptableScore` (int, e.g. default 70).
The existing "is this row ready to package" check in `PackageFinalTranslationAsync` — today a row is
kept as `Raw`/unpackaged if any split in it `!SafeToTranslate`, `FlaggedForRetranslation`, or has an
empty `Translated` with non-empty source text — gets one more condition: **also treat a column as
not-ready-to-package if its (column-level, per the `SubIndex == 0` anchor rule above)
`QcQualityScore` is non-null and below `minAcceptableScore`.**

Important nuance: this only fires when `QcQualityScore` is **non-null** (i.e. the line was actually
reviewed). A split that was never QC-reviewed (`QcQualityScore == null` — QC disabled, or just
hasn't been run yet) is **not** held back by this check — it packages exactly as it does today.
This keeps the whole feature strictly opt-in: a project/run that never enables `qualityReview` sees
zero behavior change in packaging.

This is deliberately a **packaging-time** filter, not something QC itself acts on — the underlying
`Translated`/`QcTranslated`/`QcQualityScore` values always get written to `Files/Converted` in full
regardless of score, so no translation work is ever lost or hidden. `minAcceptableScore` is safe to
raise or lower at any time and re-run packaging only (no LLM calls, no re-review) to immediately see
more or fewer lines held back — this is the intended way to "tweak the score to a level I feel
comfortable" as real output from a run gives a sense of what a given score number actually looks
like in practice. Applies uniformly to the CSV path (`PackageFinalTranslationAsync`) and the flat
`PrefabTextWorkflow`/`DynamicStringWorkflow` packaging (same "fall back to untranslated source
text" bucket a not-yet-translated split already falls into today).

`FlaggedForQcReview` (Phase 4) is also set when `QcQualityScore < minAcceptableScore`, in addition
to the "correction rejected by the gate" case — so the same flag/report tells you both "this didn't
make it into the packaged output" and "here's why," in one place.

## Phase 4 — QC workflow, prompting, and validation gate

New `FanslationStudio.LlmKit/Workflow/QualityReviewWorkflow.cs`:

- Iterates files/lines via the existing `FileIteration` helper, same parallelism pattern as
  `TranslationWorkflow.UpdateCurrentTranslationLines` for the no-LLM rule pass, but this one **does**
  call an LLM per unreviewed column (bounded by its own concurrency setting — see Phase 5).
- Builds a QC prompt per column: raw cell, current translation, relevant glossary lines (reuse
  `GlossaryLine.AppendPromptsFor` — the QC model needs to know canonical name/term mappings to
  judge "did this mistranslate a name" at all) and asks the model, in **one call**, to (a) rate its
  confidence 0-100 that the current translation is accurate and well-constructed, and (b) either
  confirm as-is or return a corrected sentence. One call producing both the score and the verdict —
  no extra round trip just to get a number. Uses a dedicated prompt file
  (`BaseQualityReviewPrompt.txt`-style, following the existing `BaseFiles/Qwen25/Prompts/`
  preset+override pattern) rather than reusing the translation system prompt, since the task
  ("judge and optionally correct this existing English translation against this Chinese source") is
  a different job than "translate this Chinese text." Output must be structured enough to parse
  deterministically (e.g. a fixed `SCORE:`/`CORRECTED:` line format, or JSON if the chosen model
  handles structured output reliably) — treat a response that fails to parse as `QcQualityScore =
  null` (not reviewed) rather than guessing, so a parsing hiccup never silently records a wrong
  score.
- **Score calibration caveat:** a self-rated score from a small/local model is a useful *relative*
  sort key ("show me the worst 5% of reviewed lines"), not a calibrated absolute quality metric —
  don't treat "72" as meaning something precise, just "worse than 85, better than 60" in this run's
  own distribution. This is exactly why `minAcceptableScore` (below) is left as a tunable config
  value you dial in by eye against real output, not a hardcoded constant.
- **Validation gate (point 5):** any proposed correction is run back through the *exact same*
  `LineValidation.CheckTransalationSuccessful` used for a normal translation attempt (placeholder
  preservation, tag balance, banned-phrase list, etc.) — a correction that fails is discarded
  (`Translated` left untouched) rather than applied blindly. On top of the existing checks, add one
  QC-specific check: **every glossary term whose `Raw` matched in the source cell must still have
  its `Result` (or an allowed alternative) present in the corrected text** — this is the concrete
  answer to "make sure it doesn't... mistranslate things in the glossary after running." A
  correction that silently drops or changes a glossary-mapped name/term fails the gate.
- **Rejected corrections are recorded on the split itself, not a log file** (see Phase 1):
  `QcStatus = FailedValidation`, `FlaggedForQcReview = true`, `QcRejectedCorrection` = the text QC
  proposed, `QcFailureReason` = which check rejected it (reuses the same
  `ValidationResult.CorrectionPrompt`-style reason text the retry loop already produces). This is
  visible for optional spot-checking directly in `Files/Converted/*.yaml` (greppable, diffable in
  git, and naturally sits next to the current `Translated` value for an easy before/after
  comparison) — never a blocking human-approval step, consistent with "I don't want a human to
  have to verify each line." Add a `GetFailedQcReviews` helper mirroring the existing
  `GameFileHandlingBase.GetFailedTranslations` (which already scans
  `FlaggedForRetranslation`/`FlaggedMistranslation` to build a `(Text, Translated, Reason)` report)
  so reviewing QC rejections reuses the same reporting shape/tooling a human already knows how to
  read, rather than introducing a second, disconnected mechanism.
- On success (no correction needed, or a correction that passed): set `QcStatus`
  (`Passed`/`Corrected`), `QcReviewedText = effective text`, `FlaggedForQcReview = false`,
  `QcRejectedCorrection`/`QcFailureReason` cleared, and (if corrected) `QcTranslated =` the
  validated correction.

## Phase 5 — Separate model / workflow test (point 4)

- `Config.yaml` gets a `qualityReview:` section: `enabled`, `modelName` (must match a `models:`
  entry, validated at load time the same way `EscalationModelName` already is), `maxConcurrency`
  (falls back to the translation `maxConcurrency`/`batchSize` the same way `EscalationRetryCount`
  falls back today), `minAcceptableScore` (see Phase 3's score-gated packaging — default suggestion
  70, tune freely, 0 disables score-based gating/flagging entirely).
- A new numbered fact in `DragonHierOverLlm/Tests` (e.g. `"X. RunQualityReviewPass"`), run manually
  like every other pipeline step — never automatic, never part of a batch/regression run, per this
  repo's existing rule for the numbered workflow.
- Because `modelName` is independent of the translation models, you can point QC at a different
  local Ollama model than whatever's doing primary translation (or a hosted API model) and compare,
  without touching translation config. See "Sample run before committing to a full-corpus pass"
  below — this comparison happens **before** the first full run, not just as a later follow-up.

### Candidate QC models + a setup step you can do in parallel with implementation

Two candidates worth having ready rather than committing to one upfront, since model choice is
still open:

- **`qwen2.5:14b-instruct`** via Ollama (`ollama pull qwen2.5:14b-instruct`) — a meaningful step up
  in Chinese-language nuance from the `qwen2.5:7b` doing primary translation (same family, so its
  instruction-following quirks/tendencies are already partly understood from this project's
  existing prompt-tuning notes), and comfortably fits the RTX 5070's 16GB VRAM at a
  Q4_K_M-class quantization.
- **`glm4:9b`** (Zhipu's GLM-4, `ollama pull glm4:9b`) — a genuinely different model family
  (reduces correlated blind spots with the Qwen family doing translation), historically strong
  specifically at Chinese, and being smaller (9B vs 14B) should also run noticeably faster per call
  on the same hardware — see the throughput discussion below. More setup work since there's no
  existing tuned prompt convention for it in this codebase.

(Model landscape moves fast; worth a quick check in Ollama's library for anything newer/
better-fitting before committing, since this recommendation reflects what was well-established as
of this plan's writing.)

Both need no code — just a `ModelConfig` entry each (`ModelPreset: None`, since the QC prompt is
new and doesn't need the `Qwen25` preset's translation-specific base prompts) and a prompts folder,
so this is independent, low-risk setup work you can do while Phase 1-4 are implemented:

1. `ollama pull qwen2.5:14b-instruct` and `ollama pull glm4:9b`; confirm both respond via
   `http://localhost:11434/api/chat` (same endpoint the existing translation models already use).
2. Add two `models:` entries to `Files/Config.yaml`:
   ```yaml
   - name: QwenQc-14B
     modelPreset: None
     modelPresetType: Standard
     customPromptsPath: QcPrompts
   - name: Glm4Qc-9B
     modelPreset: None
     modelPresetType: Standard
     customPromptsPath: QcPrompts
   ```
   Both point at the same `QcPrompts` folder — the QC prompt itself is model-agnostic; only the
   underlying model differs.
3. Create the `Files/QcPrompts/` folder (workspace prompt-override convention, same as
   `{ModelName}Prompts/*.txt` elsewhere) and draft `BaseQualityReviewPrompt.txt` /
   `BaseSystemPrompt.txt`-equivalent content for the QC task — exact wording is Phase 4
   implementation work (see "Open items" below), but having the folder + a first draft ready means
   Phase 4 can wire the workflow straight to a real prompt instead of a placeholder.
4. Leave `qualityReview.modelName` unset for now — the sample run below is what actually decides
   which of the two it gets pointed at.

### Sample run before committing to a full-corpus pass

`Files/Converted` currently holds roughly 72,500 translatable splits across 40 files (some smaller
fraction of that is unique text after dedup, mirroring the translation cache's own duplicate-heavy
pattern) — a full QC pass over that is a genuinely long job (likely many hours, possibly overnight,
regardless of which model is used — see the throughput reasoning below), and Ollama serves one
request at a time per model, so `maxConcurrency` doesn't parallelize past what a single GPU already
does. Don't commit an entire model to that full run blind.

Instead, once the QC workflow exists (end of Phase 4), run it once against each candidate model
over a **small, fixed sample** — e.g. 200-500 lines pulled from a couple of already-translated
files with a mix of plain and templated/compound columns, so the sample actually exercises both
code paths from Phase 1's "plain vs. templated" distinction. For each model, record:

- Real wall-clock time per call and total sample time (this directly answers "how slow is this,
  really," grounded in your actual RTX 5070 rather than an estimate).
- The `QcQualityScore` distribution (helps calibrate a starting `minAcceptableScore` — see Phase 3).
- How many corrections were proposed, and a manual skim of whether they're actually good fixes or
  the model second-guessing fine translations.
- How many corrections got rejected by the validation gate (`FailedValidation`) — a high rejection
  rate is itself a signal the model/prompt needs tuning before a full run.

Only after comparing both on the same sample, pick one, point `qualityReview.modelName` at it, and
proceed to a full run. This reuses the exact same "comparison-mode" mechanism already described
above for revisiting model choice later — it's just brought forward to happen before the first full
run instead of only being a nice-to-have follow-up.

### Why a full run is slow either way (context for the sample-run numbers)

Decode speed for this kind of local single-stream inference is memory-bandwidth-bound, roughly
inversely proportional to model size — `qwen2.5:14b-instruct` reads ~1.5x the weight data per token
that `glm4:9b` does, so `glm4:9b` should generate meaningfully faster per call (rough estimate,
1.4-1.6x, not measured on this hardware). Either way, total time for a full pass is essentially
(unique lines to review) × (avg seconds per call) — tens of thousands of calls at even ~1-2 seconds
each adds up to hours. This is why the sample run above exists: it turns "how slow is this" from a
guess into a measured number on your actual hardware before you commit to a multi-hour run, and
`QcReviewedText` (Phase 1) means that cost is paid once per model, not on every subsequent run.

## Sequencing

1. Phase 0 (docs cleanup, both repos) — independent, do first, no code risk.
2. Phase 1 (data model fields) — small, additive, unblocks everything else.
3. Phase 2 + 4 (review unit, masking, prompt, validation gate) — the actual QC engine.
4. Phase 3 (packaging changes) — needed before QC output can ever reach `Files/Mod`.
5. Phase 5 (config + numbered test entry point) — wiring so it's actually runnable end-to-end.
6. Docs write-back (per each repo's own existing rule) once the above is real and tested — not
   part of this planning pass.

## Open items deferred, not blocking

- Exact prompt wording for `BaseQualityReviewPrompt.txt` (including the `SCORE:`/`CORRECTED:`
  output-format instructions) — write during Phase 4 implementation, informed by whatever draft
  comes out of the Phase 5 model-setup step; not part of this design.
- Whether QC should also run over `Files/Mod`-bound `PrefabText`/`DynamicStringsIL2CPP` files in
  the same pass or as a separate opt-in per `TextFileToSplit` entry — default to "same pass,
  respecting `PackageOutput`/`SkipColumns` exactly like translation already does," revisit only if
  a concrete reason not to comes up.
- Whether a `NeedsEscalation`/human-flag `QcStatus` value is ever useful for truly ambiguous cases
  (mirrors the existing `qwen2.5:7b` "some sentences just aren't fixable by this model" reality
  noted in `FanslationStudio.LlmKit`'s docs) — not adding it now; `FailedValidation` +
  `FlaggedForQcReview` already gives visibility without forcing a blocking gate.
