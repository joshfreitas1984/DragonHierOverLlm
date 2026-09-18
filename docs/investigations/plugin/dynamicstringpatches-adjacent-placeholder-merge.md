# DynamicStringPatches — adjacent-placeholder template corruption (CONFIRMED BUG #5)

## Symptom
Force-name/title text rendered corrupted with a bogus inserted character, e.g. `巨 鲸帮...`
(extra space) and `仙霞.派` (extra period), from the `在下#TargetForceDescribe#
#$TargetInteractName#，\n此次特地前来拜访#SourceForceDescribe##$SourceInteractName#` dynamicStrings
template.

## Root cause
In `BuildCompiledTemplate` (`DynamicStringPatches.cs`), when two `{n}`/`#Token#` markers in `Raw`
sit directly adjacent with **zero literal text between them**, the compiled regex has no anchor to
bound the first lazy `+?` capture group against — it degenerates to matching the minimum 1
character, dumping the rest into the second group. Confirmed via a throwaway harness reproducing
the exact runtime string: `#TargetForceDescribe#` captured only `巨`, `#$TargetInteractName#`
captured the remainder (`鲸帮...`). This is fundamental to lazy/greedy quantifiers — there is no
information in the input to know where one adjacent placeholder's value ends and the next begins.

## Fix (in `BuildCompiledTemplate`)
For each **maximal run** of 2+ raw placeholders separated by zero literal text:
- If `Result` contains that exact run's concatenated marker text verbatim (e.g.
  `#SourceForceDescribe##$SourceInteractName#`), the run is **safe**: Result never needed to split
  the pair apart, so the whole run compiles into ONE merged pass-through capture group
  (`run{n}`, CJK-permissive class) that is captured and re-emitted unsplit. A sentinel-swap
  (`\u0001RUNn\u0001`) is used so the ordinary per-placeholder `Replace` pass over `Result` doesn't
  try to re-split the already-merged marker text. The merged span still gets translated by the
  subsequent bare-fragment `ApplyDictionary` pass on its own.
- If `Result` does NOT contain that exact concatenated text (i.e. it inserts something, like a
  space, between the pair — the Target-pair case above), the run is **unsafe and unbounded**: the
  whole template is rejected (`return null`, logged), same as `PatchAll`'s existing handling for a
  template that fails to compile. Only the surrounding literal connector text is lost for such
  templates; the underlying values (force name, rank, etc.) still translate via the ordinary
  bare-fragment `ApplyDictionary` pass.

This was a correction of a **first, overly-conservative fix attempt** that rejected the whole
template for ANY adjacent-placeholder run, which discarded perfectly safe templates (e.g. the
`胜负已分，夺冠者乃是...#SourceForceDescribe##$SourceInteractName#！...` template, whose `Result`
also keeps that pair glued) along with unsafe ones.

## Verification
A throwaway `TempVerify` harness (deleted after use, per repo convention) reproduced both the safe
merge case (`胜负已分...`) and the unsafe reject case (`在下...`Target pair) against the real
`Raw`/`Result` template text, confirming: (1) the safe template now compiles and correctly
translates its connector text while leaving the merged CJK span (`仙霞派掌门姜映泉`) untouched for
the bare-fragment pass, and (2) the unsafe template is still safely skipped rather than corrupting
output.

One implementation pitfall hit during development: the per-run safety-check dictionary
(`runConcatText`) must be keyed by the run's **index into the placeholder-match list** (the loop
variable `idx`/`start`), not by `Match.Index` (the character offset into `Raw`) — mixing the two
throws `KeyNotFoundException` at runtime for any raw string where a run's list-index differs from
its string offset (i.e. almost always).

## CONFIRMED BUG #6 (found while re-investigating the same "仙.霞派" screenshot)

A second, related-but-distinct anchor bug produces the exact same symptom: when a
placeholder/token (or a merged run from bug #5's fix) is the **last thing in `Raw`**, with **zero
trailing literal text after it**, the lazy `+?` quantifier has nothing on its right to bound
itself against either — same degenerate 1-character match as bug #5, just at the end of the
string instead of between two adjacent placeholders. Confirmed against the real
`Files/Mod/dynamicStrings.txt.yaml` entry `"#TargetForceDescribe##$TargetInteractName#，\n此次
特地前来拜访#SourceForceDescribe##$SourceInteractName#"` (no text after the final placeholder
pair) via a throwaway harness: before the fix, only `仙` of `仙霞派掌门姜映泉` was captured; after,
the full name is captured and translated correctly.

**Fix**: `BuildCompiledTemplate` now precomputes whether the *last* placeholder/token match in
`Raw` ends exactly at `raw.Length` (`lastGroupIsUnanchored`). Only that one final group (whether a
single placeholder or a bug-#5-merged run) uses a **greedy** `+` quantifier instead of lazy `+?`;
every other group keeps `+?` unchanged. Greedy is correct here because there's nothing after it in
the pattern to backtrack against, and the CJK-permissive `.` class doesn't cross newlines by
default, so it naturally stops at the next line break rather than over-consuming into unrelated
trailing text.

**Side finding (not fixed, flagged for follow-up)**: this same investigation surfaced
`dumpedPrefabTextFromOtherFields.txt.yaml`'s `"在下#$PlayerName#"` → `"Player #$PlayerName#"`
template as dangerously over-generic — with only a 2-character literal anchor (`在下`) and no
trailing anchor at all, it can mis-fire as a false-positive *prefix* match inside much longer,
unrelated dialogue lines that happen to also start with "在下" (a very common Chinese dialogue
opener meaning "I"/"the undersigned"), incorrectly prepending "Player" to text it has no business
touching. A harness reproduction using the actual `#TargetForceDescribe#`/`#$TargetInteractName#`
template's own text confirmed this exact template fires as a false positive prefix on that
sentence, plausibly explaining the "Player" text seen in the same screenshot alongside the
"仙.霞派" corruption. This is a translation-data specificity problem (not a regex-engine bug) and
was intentionally left unfixed pending a decision on the right scope for that entry (e.g. requiring
it to match the entire input, not just a prefix).

## CONFIRMED BUG #7 (2026-08-30, "still seeing lots of these" - overly-strict safety check)

After bugs #5/#6 shipped, the per-run safety check (`Result` must contain the run's concatenated
marker text **verbatim, with literally nothing between them**) turned out to reject far more
templates than necessary. Many templates have a run that's genuinely safe to merge but where
`Result` inserts a plain **space** between the two values for readability (e.g.
`"#TargetForceDescribe# #$TargetInteractName#"`) - the exact-`Contains` check treated that as
"unsafe" and rejected the WHOLE template, losing translation of all its other (perfectly safe)
literal connector text too. Five real warnings reported in one batch; a throwaway harness
confirmed 3 of the 5 were this exact false-rejection (whitespace-only gap), while the other 2 were
genuinely unsafe (Result inserts real translated words/punctuation between the pair, e.g.
`"#TargetForceDescribe#. It's nice to meet you, #$TargetInteractName#."`, or wraps them in braces).

**Fix**: the safety check now searches `Result` for the run's markers, in order, separated by
`\s*` (whitespace-only) instead of requiring them perfectly adjacent (`Regex.Match` against a
per-run pattern built from `string.Join(@"\s*", ...Regex.Escape(marker))`). A run is only rejected
now if that whitespace-tolerant search fails entirely (real content between the markers, wrong
order, or missing). The matched span (markers + any whitespace) is what gets replaced by the
merged capture's sentinel, so the merge still works exactly as before for the fully-glued case,
and now also succeeds for the whitespace-separated case (dropping the cosmetic space - e.g.
"Giant Whale GangYuLingZhu" instead of "Giant Whale Gang YuLingZhu" - a minor readability tradeoff
strongly preferred over losing the whole template).

Verified via a throwaway harness against the exact 5 reported `Raw`/`Result` pairs: 3 now compile
and merge correctly, 2 remain correctly rejected (their gaps contain real content, not just
whitespace).
