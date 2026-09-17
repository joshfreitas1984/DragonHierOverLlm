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

1. **`FanslationStudio.LlmKit`** (sibling repo, project reference): added
   `GameHooks.CustomTranslationExclusionRule` — checked once per split at the top of
   `TranslationWorkflow.UpdateSplit`, before any LLM call. When a downstream project's hook returns
   a non-null override for a raw string, the split is marked `SafeToTranslate = false` and
   `Translated` is set to the override directly — the raw string never reaches the LLM, and (since
   `QualityReviewWorkflow` already skips any split with `!SafeToTranslate`) never reaches QC either.
   See that repo's `docs/translation-retry-escalation-and-fixes.md` for the full writeup.

2. **This repo**: `Tests/GameFileHandling.cs` registers
   `CustomTranslationExclusionRule = GetDanglingColorTagOverride`, backed by a `DanglingColorTagOverrides`
   dictionary of 44 hand-written overrides.

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

`Tests/GameFileHandling.cs`'s `DanglingColorTagOverrides` dictionary (and the
`GetDanglingColorTagOverride`/`CustomTranslationExclusionRule` wiring right above it) — not
duplicated here, since the dictionary itself is the single source of truth and would drift from
this doc otherwise.
