# Dynamic-string templates with a runtime color placeholder + literal closing tag

## Symptom

The Enhance-UI raw string `"提升强化等级至+{6}\n{0}需要建筑等级 {1}级</color>\n{2}需要{5}技能 {3}</color>\n{4}"`
shipped with its first line's color span unclosed in-game — the `<color>` opened by `{0}` never got
its matching `</color>` back.

## Root cause

Decompiled `Converter/output/_NoNamespace/EnhanceUIController.cs` (the `Update` method building a
7-arg array, `plVar7`, for `String.Format`) shows `{0}`/`{2}` are **runtime-computed**
`<color=...>` opening tags — game code picks red or green depending on whether the player meets a
building-level/skill-level requirement — while the matching `</color>` closes are **literal text**
baked directly into the raw template. `{5}` is unrelated: just the skill-name noun sitting between
"需要"/"技能" for Chinese word order, not a color placeholder.

QC's correction (`Files/Converted/dynamicStrings.txt.yaml`, this raw string) dropped the literal
`级</color>` off the end of the first line entirely. Confirmed by diffing `qcTranslated` against the
packaged `result` in `Files/Mod/dynamicStrings.txt.yaml` for the same raw string — the fix reached
the shipped mod output unfixed.

Why this slipped through the existing validation gate, and why no purely mechanical rule can fully
close the gap (a runtime-placeholder open + literal close is the mirror image of this repo's
existing `ColorTagHelpers.StartsWithHalfColorTag` case, which handles a literal open with no
close) — see the LlmKit-side postmortem, since that's where the actual validation logic lives:
[`../../FanslationStudio.LlmKit/docs/translation-retry-escalation-and-fixes.md`](../../../FanslationStudio.LlmKit/docs/translation-retry-escalation-and-fixes.md)
("Postmortem: dropped closing tag in a runtime-color-placeholder template...").

## Fix

**First attempt (tried, then reverted):** added `GameHooks.CustomTranslationExclusionRule` to
`FanslationStudio.LlmKit` — checked once per split at the top of `TranslationWorkflow.UpdateSplit`,
before any LLM call, meant to keep these raw strings away from the LLM/QC entirely by supplying a
manual override up front. This was the wrong layer: `UpdateSplit` runs per-`TranslationSplit`, but
`CompoundFieldSplitter` decomposes every one of these raw strings into multiple fragments plus a
`templates:` reconstruction list, so no single split's `Text` ever equals the *whole* raw template
with its `{n}` tokens intact. The hook's raw parameter never matched any dictionary key, so it
silently never fired — confirmed by running `ApplyAllRulesToCurrentTranslation` and seeing "Writing
0 records" for every file. Reverted entirely (`GameHooks.cs`/`TranslationWorkflow.cs` in the sibling
repo) rather than left in as unused infrastructure.

**Actual fix:** these need a **whole-raw → whole-result** override, applied *after*
`CompoundFieldSplitter.Reconstruct` has already glued the fragments back together — exactly the
layer `Tests/TranslationPackaging.cs`'s existing `DynamicStringResultOverrides` dictionary already
operates at (it was built for the adjacent "reconstructed fragments have no connective words"
problem, but the mechanism is identical: force the correct `Result` post-packaging, regardless of
what the LLM/QC produced upstream). All 44 raw strings below were added there instead. Verified for
real, not just by inspection: ran `TranslationPackaging.PackageFinalTranslationAsync` and confirmed
`Files/Mod/dynamicStrings.txt.yaml` now shows the corrected, tag-balanced `result` for the Enhance
string and several others.

## Finding every other affected string

Rather than wait for the next in-game bug report, scanned raw text (not translated/output values —
a corruption only matters if it could ever be introduced, which requires an LLM to have touched the
raw in the first place) in `Files/Converted/dynamicStrings*.yaml` and
`Files/Converted/dumpedPrefabText*.yaml` for the same shape: a `{n}` placeholder present, plus a
literal closing tag (`</color>`, `</b>`, `</i>`) with no matching literal opening tag anywhere in
that raw string — meaning the opening half must be a runtime value the pipeline can never see.

Result: **44 matches, all in `dynamicStrings.txt.yaml`** (all `TextFileType.DynamicStringsIL2CPP`).
Zero matches in the prefab-text family. Most are short UI stat-labels (`{0}同盟</color>` →
"{0} Alliance</color>") where the terseness matches the source — not a translation shortcut, since
the original Chinese is equally terse there. A few are multi-clause sentences (the Enhance-UI string
above; a "recruit favorability/loyalty" notification with two color spans and a reused placeholder)
where a reworded translation has real room to disturb tag/placeholder pairing.

Every override was built by keeping the exact `{n}` placeholder order/position from its raw key
unchanged and only translating the literal text between them — never reordering a placeholder
relative to a literal tag, which is the one thing no mechanical check can verify after the fact.
Verified with three throwaway scripts (not checked in — scratch/one-off, per this repo's
verification-harness convention) before and after writing the dictionary:

- every dictionary key matches an actual raw string in `Files/Converted/dynamicStrings.txt.yaml`
  byte-for-byte (catches key typos, which would silently no-op rather than error);
- every override value has the identical `{n}` placeholder sequence (order and count) as its raw
  key;
- every override value has the identical literal-tag counts (`<b>`, `</b>`, `<i>`, `</i>`,
  `</color>`) as its raw key.

One entry needed a second pass for fluency, not just safety: `"{0}\n通行{2}{1}</color>"` was
initially translated "Passing {2} {1}" (nonsense). Decompiled `QuickDetail.cs`/`MissionData.cs`
confirmed the actual `String.Format` args are `(obstacleDescription, "{skillName}{level}" blob,
passFailColorTag)` — `通行` here means "passage requires [skill]", a terrain-obstacle skill gate, not
the English verb "pass". Corrected to `"{0}\nRequires {2}{1}</color>"`.

## Where the full override list lives

`Tests/TranslationPackaging.cs`'s `DynamicStringResultOverrides` dictionary (the 44 entries added
under the "Runtime-color-placeholder templates" comment) — not duplicated here, since the
dictionary itself is the single source of truth and would drift from this doc otherwise.
