# Translation Prompt Tuning Candidates

## Objective

Track model-assessment defects that look fixable via prompt changes (as opposed to model/quant
choice), so a prompt-tuning pass has a concrete, reproducible checklist instead of vague
impressions from skimming a Comparison.yaml run. Every source line below is pinned in
`Files/Config.yaml`'s `translationAssessment.pinnedSampleSources`, so every future assessment run
re-tests these exact cases regardless of random sampling - re-run the assessment after a prompt
change and diff these specific samples' output against the "Current behavior" notes below.

## Candidates

### 1. Literal "\n" template separator gets replaced with a real newline

Several models (seen so far: `HyMT2-30B-A3B-Q3` consistently, `Qwen25-Standard` occasionally)
substitute the source cell template's literal two-character `\n` token with an actual newline
character (sometimes with stray trailing spaces before it), instead of reproducing the literal
token verbatim. This fails `CompoundFieldSplitter.Reconstruct`'s structural validation even though
the translated prose reads fine.

**IMPORTANT - check the source's actual convention before flagging this**: `PlotData.csv` fullCell
samples use the literal two-character `\n` token (confirmed via `Files/Raw/Export/PlotData.csv.yaml`
templates), but at least one `dynamicStrings.txt` fullCell sample (`cb459b1c8e845a04`, see gold set)
embeds a REAL newline character directly in the source - for that one, reproducing a real newline
is the CORRECT behavior, and it was originally mislabeled a defect in the gold set before being
corrected. Always check whether the source string contains a real newline vs the literal two-char
token per source file before assuming which convention applies.

- Pinned samples: `哈哈哈哈哈，石将军，\n你竟想让老子屈居于你之下，当你的什么狗屁副殿主？`,
  `好你个臭小子！\n小的们，给我接着狠狠地打！`,
  `有人高呼：饿虎扑食？这是饿犬吃屎吧！\n引得台下又是一片嘘声和嘲笑。`
- Current behavior: e.g. Q3 quant outputs `"...General Shi,  \ndo you really think..."` (real
  newline + two stray spaces) instead of `"...General Shi,\\ndo you really think..."` (literal
  backslash-n).
- Tuning idea: add an explicit system-prompt rule/example showing the literal `\n` token must be
  copied through character-for-character, never rendered as an actual line break, with a
  before/after example in the same style as existing placeholder-preservation rules.

### 2. Separator dropped entirely (sentences merged)

Distinct from #1: some models drop the separator instead of mis-rendering it, silently merging two
clauses that the template expects to keep apart. This happens with both the literal token and, in
`cb459b1c8e845a04`, with an actual real-newline-separated source (the Q3 quant drops both real
newlines there, merging all three sentences into one paragraph).

- Pinned samples: `有人高呼：饿虎扑食？这是饿犬吃屎吧！\n引得台下又是一片嘘声和嘲笑。` (HyMT2-7B),
  `等到蛊虫完全苏醒，施术者就能在一定程度上操纵被寄宿之人的行为，\n如同控制牵丝木偶一般，故而得名。\n施术者越精于蛊术，对被寄宿者的控制力就越强。`
  (HyMT2-7B and the Q3 quant each keep only one of the two separators),
  `第{0}名是{1}！\n奖励是银钱{2}两和这{3}，贵派威望也会因此提升{4}点。\n此外，每位参战弟子皆会获得{5}门派功绩以示鼓励。`
  (Q3 quant drops both real newlines here)
- Tuning idea: same rule as #1 can likely cover both - emphasize the separator (whichever form the
  source uses) must appear the same number of times as in the source, not just "somewhere."

### 3. Partial/leftover untranslated CJK glued onto an English word

`Qwen25-Standard` translated `蛊虫` ("gu insects/worms") as `gu虫` - translated the first
character's romanization but left the second character (`虫`) completely untranslated, glued
directly onto the English word with no space or punctuation.

- Pinned sample: `等到蛊虫完全苏醒，施术者就能在一定程度上操纵被寄宿之人的行为，\n如同控制牵丝木偶一般，故而得名。\n施术者越精于蛊术，对被寄宿者的控制力就越强。`
- Tuning idea: add a rule/example against partial-character leftovers specifically (distinct from
  whole-word omission), since this is a different failure shape than a dropped clause.

### 4. Garbage/prompt-leak or outright-wrong output on short, context-free fragments

The current default `HyMT2-30B-A3B` (now Q4 quant) produced `"No valid alternatives existed;
output only the properly translated English text."` for the two-character input `则为` - this
looks like an internal fallback/refusal instruction leaking into the actual output, not a
translation at all. The same model also mistranslated the single character `在` ("at/in/exist") as
simply `"None"` - not a leaked instruction this time, just a flatly wrong word with no plausible
reading back to the source. `Qwen25-Standard` shows a related failure on `轻功10;意志15`, outputting
the literal meta-text `"<translation unchanged as there is no Chinese text to translate>"` even
though the source plainly contains Chinese. This is the most severe class here (a QC evaluator or
player would see this verbatim in-game) and may need investigating on the prompt/inference-settings
side specifically for very short, context-free fragments rather than a copy-editing tweak.

- Pinned samples: `则为`, `在`, `轻功10;意志15`
- Tuning idea: check whether the model's fallback/refusal template text is being emitted as a
  literal completion rather than triggering a retry; consider a short-fragment-specific system
  prompt addition or lowering temperature/max-tokens paths that might encourage this fallback path.

### 5. Non-translatable game identifier dropped entirely

`HyMT2-7B` translated `慷慨赠送;GiveNpcAskItem` as just `"Give away generously"` - it silently
dropped the entire `;GiveNpcAskItem` segment, a non-translatable game function identifier that must
survive verbatim after the semicolon. Every other candidate kept it intact.

- Pinned sample: `慷慨赠送;GiveNpcAskItem`
- Tuning idea: reinforce that any `;`-delimited segment matching an identifier pattern (no CJK
  characters, mixed PascalCase/identifier-style text) must be copied through unchanged, the same
  way placeholder tokens already are.

### 6. Separator token present but relocated to the wrong position

Distinct from #1/#2: `HyMT2-7B` and the current Q4-quant `HyMT2-30B-A3B` both keep the literal `\n`
token intact when translating
`#$PlayerName#，项问天，又是你们两个来坏我好事！\n若不是你们，我爹也不会死！！！`, but move it to the
very end of the string (after `"!!!"`) instead of between the two source sentences - this still
breaks template reconstruction even though the token itself wasn't lost or mis-rendered.

- Pinned sample: `#$PlayerName#，项问天，又是你们两个来坏我好事！\n若不是你们，我爹也不会死！！！`
- Tuning idea: an example showing the separator's *position* relative to sentence boundaries
  matters as much as its presence, not just "don't drop or mis-render it."

### 7. Historically QC-flagged terms/names, re-pinned for the translation pass

Pulled from `docs/investigations/tests/qc-qualityscore-noise-investigation.md`'s per-category
hand-validation findings - these were originally caught as bad QC *corrections* or bad original
*translations* on specific short terms, not full sentences, so they're worth re-testing directly
against the raw translation models too (independent of whatever the QC pass does with them):

- `殷殷` (a name-part fragment from `heroNameParts.txt`, part of `雷殷殷`) was previously
  mistransliterated as "Eern eern" instead of a plausible pinyin romanization like "Yinyin".
- `五毒弟子` (an isolated `dynamicStrings.txt` term) was previously mistranslated as the nonsense
  "Poisson Disciple" instead of "Five Poisons Sect disciple(s)".
- `撤撤撤！你们三个给我记住！` (a `PlotData.csv` stutter/repetition line) is one of three source
  lines using the `撤撤撤` ("retreat!") stutter pattern; the investigation found a QC correction
  elsewhere in this category that inverted an equivalent `撤撤撤` line's meaning to "Charge!" -
  worth checking the raw translation doesn't independently make the same retreat/charge inversion.

A few other examples named in that investigation (an idiomatic, non-literal use of `鬼门关`
downgraded from "narrow escape" to an over-literal "Gate of the Underworld"; a "T-T-Taoist" stutter
replaced with the nonsensical "N-N-Nose"; `大当家` left as unromanized "Da-Da Dangjia"; specific
untranslated-pinyin idiom instances) were described only in shorthand in that doc, without quoting
the exact source line, and `鬼门关`/`想当年`-style phrases recur hundreds of times in the corpus -
pinning the wrong occurrence would test nothing. Worth a follow-up pass through
`Files/Converted/PlotData.csv.yaml`'s QC correction history to find the exact lines if these turn
out to still matter.

## Non-candidates (noted, not pinned)

- Register/profanity softening (e.g. "吃屎" "eating shit" rendered as "eating trash") and stylistic
  wording differences (e.g. "Good heavens, you rascal!" for a plainer insult) are lexical/tone
  choices, not obviously prompt-fixable without risking over-correction elsewhere - left out of the
  pinned set for now.
