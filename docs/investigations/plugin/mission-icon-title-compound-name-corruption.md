# Mission icon Title compound name corruption (2026-09-22)

## Symptom

```
ApplyToComponentText
  path:   Canvas/MissionPanel/MissionUI/MissionScrollView/Viewport/Content/MissionIconPrefab(Clone)/Title
  before: 藏宝地图(Qingcheng Se?t祠?)
  after:  Treasure map(Qingcheng Se?t祠?)
```

This looked like a recurrence of the objective-sentence corruption fixed in
[mission-target-describe-natural-translation.md](mission-target-describe-natural-translation.md), but it is a
different code path through the same two patched methods.

## Root cause (hypothesis from decompiled code - later shown NOT to explain the original report; see
"Actual conclusion" below)

`MissionIconController.Update()` builds the mission icon's `Title` as:

```
Title = missionData.name + "(" + MissionData.GetTriggerTargetDescribe(targetID, unclear: false) + ")"
```

(see `Converter/output/_NoNamespace/MissionIconController.cs:80-106`). `GetTriggerTargetDescribe` is already
patched by `DragonHeirPlugin/MissionPatches.cs`, but that method
(`Converter/output/_NoNamespace/MissionData.cs:1030-1254`) has branches that return a **bare compound name**
(area name + building name, e.g. `青城派` + `祠堂`) rather than a verb/amount objective sentence. None of
`MissionPatches.NaturalObjectivePatterns` match a bare noun phrase like this, so `TranslateObjective` fell
through to `DynamicStringPatches.RunGenericPipeline`, which runs sentence-oriented regex templates before the
dictionary pass. Those templates are what corrupted `青城派祠堂` into `Qingcheng Se?t祠?` instead of the clean
whole-compound dictionary translations that already exist (`青城派` → `Qingcheng Sect`,
`Files/Converted/dynamicStringsRoutedMailBodies.txt.yaml:1715`; `祠堂` → `Ancestral hall`,
`Files/Converted/dynamicStringsFromColumns.txt.yaml:625-628`).

This is the same class of problem the prior investigation already flagged as unresolved (generic,
context-free templates being unsafe on structured runtime strings), just triggered by the location-name
branch instead of the numeric-objective branches.

## Fix, round 1 (insufficient)

`MissionPatches.TranslateObjective` was changed to track whether any `NaturalObjectivePatterns` regex
actually matched. If none did (i.e. the string is not a recognized objective sentence, most likely a bare
name), any residual CJK is translated with `DynamicStringPatches.TranslateFragment` (dictionary only, no
templates) instead of `RunGenericPipeline`.

This did not fix the report. Live diagnostics (see below) showed the identical corrupted fragment
(`Qingcheng Se?t祠?`) also appearing in the mission's plain task-description text
(`前往{0}发掘宝藏`), which is built by `MissionData.GetMissionBaseDescribe` and never goes through
`MissionPatches` at all - it flows through the ordinary `String.Format`/`String.Concat` patches straight into
`DynamicStringPatches.RunGenericPipeline`. Both the Title and the description ultimately translate the exact
same location-name substring, so the round-1 fix only ever addressed one of the two call sites, and the real
corruption was happening inside `RunGenericPipeline` itself (shared by both, and memoized - the first
mistranslation gets reused verbatim afterward).

## Diagnosing the actual root cause

`ApplyTemplatesSinglePass` and `ApplyDictionary` (both inside `RunGenericPipeline`) were instrumented to log
to `residualCjkDebug.log` whenever a literal `?` appeared in their output that wasn't present in their input
(`LogUnexpectedQuestionMark`) - a `?` is never a legitimate translation from either stage.

This caught the bug live on a completely unrelated string (a Force job/role description, nothing to do with
missions):

```
before: 主管门派医疗康养事宜
        提升任职者医术/毒术经验<color=#00B400>60%</color>
        同时根据任职者<b>医术/毒术技能</b>提升全门派<b>…
after:  主管 Sect 医疗康养事宜
        Improve 任职者 Medicine/Poison technique experience <color=#00B400>60%</color>
        同 Time 根据任职者<b> Medicine/Poison Technique Skills</b> Improve 全 Sect<b>…
```

`同时` ("at the same time") was torn apart: the dictionary's single-character entry `时` → `Time`
(`Files/Converted/dynamicStrings.txt.yaml:44020-44023`) matched as a free-standing substring, leaving `同`
raw and stitching in `Time`. The same pattern explains `治下` → `治 Bottom` (`下` → `Bottom`,
`Files/Converted/dynamicStrings.txt.yaml:12405-12408`), and almost certainly the original `青城派祠堂` →
`Qingcheng Se?t祠?` report - `派`/`祠` most likely have no safe whole-compound match available at the point
`ApplyDictionary` runs on that string, so a short fragment entry (or template artifact) applies mid-compound
instead.

This is a systemic defect, not a one-off: the loaded dictionary (`dynamicStrings*.txt.yaml`) contains 151
single-character entries, any of which can be mis-applied inside a larger compound word that has no
whole-entry translation of its own.

## Fix, round 2 (still routed through the shared pipeline - fixed the wrong layer)

`DynamicStringPatches.ApplyDictionary`'s replacement routine (`ReplaceWithWordBoundarySpacing`) now guards
short entries (`Raw.Length <= 2`, `ShortEntryBoundaryGuardMaxLength`): an occurrence is only replaced if
neither the character immediately before nor immediately after it is a CJK ideograph. An occurrence still
touching CJK on either side is left as raw Chinese instead of being half-translated - it stays visible (and
gets picked up by residual-CJK logging) as a prompt to add a proper whole-compound dictionary entry, rather
than silently producing broken mixed-language text.

Longer/more specific entries are unaffected and still win when present (candidates are tried longest-first,
so a whole `青城山`/`青城派` entry, when it exists, is applied before the guard would ever need to
consider the shorter `青城` or `派`/`祠` fragments).

The caller (`ApplyDictionary`'s replace loop) was also fixed to treat "this entry's only occurrences were all
boundary-guarded" the same as "no match" (advance to the next candidate) instead of looping on the same
candidate forever, since the entry's raw text is still present in the string after a fully-guarded call.

This fixed the dictionary-level splitting (confirmed live: `同时`/`治下` stopped breaking), but the original
`Qingcheng Se?t祠?` report was still unresolved after deploying it. Diagnosing why (see `residualCjkDebug.log`)
kept surfacing translations of the plugin's own new diagnostic log text (because `GenericPostfix` patches
`System.String.Concat`/`Format` process-wide, not just game code, so the plugin's own string-interpolated log
messages recurse through the same pipeline they're diagnosing) - workable but noisy, and it was still relying
on `DynamicStringPatches`' shared, generic, position-independent substring pipeline for mission text, which
is the wrong layer to be fixing this in: mission text should never need to survive a free-form substring pass
built for arbitrary sentence/paragraph UI text in the first place.

## Fix, round 3 (actual fix - resolve before the shared pipeline ever sees it)

Added `DynamicStringPatches.TranslateCompoundName`: a strict **left-to-right, match-at-current-position-only**
translator, as opposed to `ApplyDictionary`/`TranslateFragment` which match a raw entry *anywhere* in the
string, longest-entry-first, independent of scan position (the actual mechanism behind every corruption seen
in this investigation, round 1 through 3). `TranslateCompoundName` walks the string once; at each position it
either consumes the longest dictionary entry that starts exactly there, or emits one untranslated character
and advances - so a fragment can never be pulled out of the middle of an unrelated compound the way `时` was
pulled out of `同时`. Unmatched compounds surface as plain readable raw Chinese (a prompt to add a proper
entry) instead of half-translated garbage.

`MissionPatches.TranslateObjective` now calls `TranslateCompoundName` (not `RunGenericPipeline`/
`TranslateFragment`) for the "no natural pattern matched" fallback. Critically, this runs **inside**
`GetTriggerTargetDescribe`'s own Harmony postfix - the same method `GetMissionBaseDescribe` calls internally
for the `前往{0}发掘宝藏` task-description text (`MissionData.cs:459/467`) and that `MissionIconController`
calls for the Title (`MissionIconController.cs:98`). So both call sites now receive an already-fully-English
(or safely-raw) string, resolved before it is ever concatenated and handed to the generic
`GenericPostfix`/`ApplyToComponentText` pipeline - mission text no longer depends on the shared substring
pipeline at all for this compound-name case.

Round 3 still did not fix the originally-reported mission's display, even after a clean rebuild/redeploy
confirmed live. That result is the key finding below.

## Actual conclusion: this specific mission's text is baked into save/game state, not recomputed

Two pieces of direct evidence, gathered by instrumenting `GetMissionTargetDescribe`/`GetTriggerTargetDescribe`'s
postfixes to log their raw `__result` *before* any plugin code touches it:

1. For the one live call captured for this mission, `GetTriggerTargetDescribe(targetID=1, unclear=false)`
   returned an **empty string** - unrelated to `青城派祠堂`/`Qingcheng Se?t祠?` entirely. Neither
   `GetMissionTargetDescribe` nor `GetTriggerTargetDescribe` was ever observed producing this compound for
   this mission instance.
2. The reported Title itself is asymmetric: `藏宝地图(Qingcheng Se?t祠?)` - `藏宝地图` (`missionData.name`) is
   still **raw Chinese**, recomputed/re-read fresh on every `MissionIconController.Update()` tick, while
   `(Qingcheng Se?t祠?)` is **already in English** (just corrupted). Two pieces of the same displayed string
   in two different translation states means they come from two different sources/times - the parenthetical
   was translated once, a while ago, not on this tick.
3. Confirmed conclusively by disabling `MissionPatches` entirely and reproducing: the Title still rendered
   `藏宝地图(Qingcheng Se?t祠?)` identically, with the patch that would have produced it turned off. The text
   is not passing through this plugin's translation code at all for this mission instance.

Conclusion: this mission's target-location text was resolved once, at mission-generation time (most likely
during the treasure-map plot flow in `ExploreController`/`PlotController` - see
[mission-target-describe-natural-translation.md](mission-target-describe-natural-translation.md)'s note that
"the map flow clones and generates a mission at runtime"), before any of the fixes in this document existed.
Whatever produced the compound name then is corrupted, and the result is now sitting as stored state on the
mission (and/or persisted in the save file) rather than being re-derived from the Chinese source text on every
redisplay. **No live translation-pipeline fix can repair an already-generated mission instance's stored text.**
The `ClearTranslationCachesHotkey` debug hotkey (clears `DynamicStringPatches`' in-memory memoization) was
built while investigating this and correctly does nothing for this case, since the corrupted text was never in
those caches to begin with.

## What to actually verify

The round 2/round 3 fixes (`ShortEntryBoundaryGuardMaxLength` and `TranslateCompoundName`) are still real,
independent improvements - `ShortEntryBoundaryGuardMaxLength` is already confirmed fixing live corruption
(`同时`/`治下` no longer split). They apply to text computed going forward, including any **freshly-generated**
treasure-map mission's target description. They do not, and cannot, retroactively fix this specific
already-generated mission's stored text - that mission needs to be abandoned/expire and a new one generated to
confirm the fix, not retested against the one from this report.

## Cleanup after this investigation

- Removed the one-off raw-`__result` diagnostic logging added to `GetMissionTargetDescribePostfix`/
  `GetTriggerTargetDescribePostfix` - it did its job (proved these methods aren't the source for this report)
  and has no ongoing value now that the conclusion is documented.
- Kept `DynamicStringPatches.LogUnexpectedQuestionMark` (the `ApplyTemplatesSinglePass`/`ApplyDictionary`
  instrumentation) - unlike the raw-result dumps, this is generically useful ongoing tooling (gated behind
  `ResidualCjkDebugLogging`, off by default) and already found a real, independent bug (`同时`/`治下`
  splitting) during this investigation.
- Kept `MainPlugin.ClearTranslationCachesHotkey` as a generic debug tool for genuinely-memoized corruption
  cases, but corrected its doc comment - it does not help when text is baked into game/save state rather than
  memoized, which is what this specific report turned out to be.
- Kept `TranslateCompoundName`, the `ShortEntryBoundaryGuardMaxLength` dictionary guard, and
  `MissionPatches.TranslateObjective`'s natural-pattern-matched tracking - all still correct, valid fixes for
  their own (different, confirmed-real) bugs, independent of this report's actual root cause.

## Verification

- `dotnet build DragonHeirPlugin\GamePlugin.csproj` compiles cleanly (the only failure seen was the
  post-build `XCOPY` step when the game process is holding the deployed DLL open - not a source error).
- `同时`/`治下` no longer split into `同 Time`/`治 Bottom` - confirmed live via `residualCjkDebug.log`.
- Still open: confirm a **freshly-generated** treasure-map mission (not the one from the original report)
  renders its title/description cleanly. The originally-reported mission instance itself cannot be fixed by
  any code change - see "Actual conclusion" above.

## Fix, round 4 - the actual unpatched carrier: `missionHideTargetPlaceString`

Round 3's "actual conclusion" was right that no live translation-pipeline fix could repair the one
already-generated mission from the original report, but a fresh report of the identical corruption
(`青城派祠堂` → `Qingcheng Se?t祠?`) on a newly-generated mission showed the underlying gap was still
live, not just stale save state.

`MissionData.missionHideTargetPlaceString` (`Converter/output/_NoNamespace/MissionData.cs:67`) is a
second, separate carrier of an "AreaName + BuildingName" compound - distinct from
`GetMissionTargetDescribe`/`GetTriggerTargetDescribe` (which round 3 already patches). It is read
directly, as a plain field with no method call in between, at two call sites:

- `MissionData.GetMissionBaseDescribe(bool)` (`MissionData.cs:462`) - used whenever
  `missionHideTargetPlace` is true, instead of calling `GetTriggerTargetDescribe`.
- `MissionIconController.Update()` (`MissionIconController.cs:101`) - same condition, used to build
  the mission icon's `Title`.

Neither of these reads ever passed through `MissionPatches.TranslateObjective`/
`TranslateCompoundName`, because there was no Harmony patch on either method at all - the field was
completely unpatched. It reached the shared `String.Format`/`String.Concat` → `LTLocalization.SetText`
pipeline as raw, untranslated CJK, where the generic corruption-prone pass (the same one
`TranslateCompoundName` was built to avoid, per round 3) translated it once and the game's own field
then held the corrupted result from then on - the same "translated once, stuck forever" symptom as
round 1-3, just via a carrier those rounds hadn't found yet.

Fix: added `MissionPatches.GetMissionBaseDescribePrefix`/`MissionIconControllerUpdatePrefix`
(Harmony prefixes on both methods above) that translate `missionData.missionHideTargetPlaceString`
in place with `TranslateCompoundName` before the original method body runs, whenever
`missionHideTargetPlace` is true and the field still contains CJK. Writing the translated value back
into the field both fixes the immediate read and memoizes the result (translation only runs once per
mission instance, same as the existing dictionary/pipeline caches).

The `missionHideTargetPlaceString` field is written at mission-generation time via an unnamed
IL2CPP offset write (no named assignment site found in the `_NoNamespace` decompile - see
`GameController.GenerateBountyMission`/`PlotController.GetTreasureMapMission` as the likely
generation-time callers), so patching the two read sites above is the only reachable place to fix
this from the plugin; the write site itself cannot be Harmony-patched.

## Round 5 - reverted: source-getter patches caused an unrelated IL2CPP interop crash

Attempted to translate `AreaName`/`BuildingName` at their source (`AreaData.GetAreaName()`/
`AreaBuildingData.Name(bool)`) via Harmony postfixes, on the theory both getters are display-only.
That theory was about who reads the *return value* - it missed a separate, unrelated risk: patching
an IL2CPP method forces IL2CppInterop to route every call to it (including calls that only ever
happened natively, never crossing into managed code) through a managed trampoline, which has to
marshal the native IL2CPP string into a managed `System.String`. That marshaling itself threw for
some `AreaData` instance (very likely one with no name set - a placeholder/internal area never
meant to be displayed), spamming `ArgumentOutOfRangeException: Length cannot be less than zero`
from `Il2CppInterop.Runtime.IL2CPP.Il2CppStringToManaged`, confirmed live. This has nothing to do
with whether the return value is display vs. lookup - it's a crash in the interop layer itself,
present the moment the method is patched at all. `AreaBuildingData.Name(bool)` carries the identical
risk (same IL2CPP-native-getter shape) even though it hadn't been observed crashing yet, so it was
reverted too rather than waiting to find out. Both patches were removed; `TranslateHiddenTargetPlaceString`
(round 4's fix) was instrumented with `LogMissionDebug` instead, to observe what it actually sees on
each call without touching the source getters.

## Round 6 - WRONG, retracted: "pre-existing save state" theory

Initially, grepping `residualCjkDebug.log` for a fresh report of this corruption (`?huxian Town客?`)
showed every log entry for the string with identical `before`/`after`, including the
`GetTriggerTargetDescribe raw result` diagnostic (the game's own native `__result`, captured *before
any plugin code touches it*) already showing the corrupted string at its very first appearance in the
log (`20:04:43.906`). That was read as "the corruption predates this session - stored save state,
same as the original report's conclusion above."

**Retracted**: confirmed with the user that this exact mission was picked up freshly *during this same
session* (session start `16:54:37`, first read at `20:04:43` - not a reloaded old save). The "raw
result already corrupted" observation is real, but it means the corruption happens natively, live,
during mission generation this session - not that it's stale save state. See round 7.

## Round 7 - confirmed: native, non-managed corruption, not attributable to any C#/Harmony pipeline code

Re-examined with the correct premise (live corruption, not stale save). Identified the compound as
`朱仙镇` (`AreaData.csv` row 61, id 61) + `客栈` (`BuildingData.csv` row 17, id 17):

- `朱仙镇` → `Zhuxian Town` matches `?huxian Town` exactly except for the leading character.
- `客栈` → `Inn` (a clean whole-entry dictionary translation) never applies; instead the corrupted
  string has `客` (raw, untranslated) followed by `?`.

**Byte-level confirmed** (`xxd` on the log file): both `?` characters are literal ASCII `0x3F`, not a
mis-decoded multi-byte character or a full-width `？` (U+FF1F) being correctly Latinized - the
`LogUnexpectedQuestionMark` diagnostic (built to catch exactly this signature from
`ApplyTemplatesSinglePass`/`ApplyDictionary`) exists specifically to flag this, but every one of its
449 hits in this session's log is a false positive (a legitimate `？` → `?` punctuation translation);
grepping for this string, or for the raw `朱仙镇`/`客栈` substrings, anywhere in that diagnostic output
returns nothing.

Ruled out the managed translation pipeline entirely:

1. `TranslateHiddenTargetPlaceString`/`TranslateCompoundName` (round 4's read-site patch) sees this
   string already corrupted and is a no-op on it (`before == after` every time) - not the source.
2. Grepped the *entire* log for the raw Chinese substrings `朱仙镇` and `客栈`/`Zhuxian`+`客栈`
   adjacent together: zero hits. If the compound were built via a `+`/`String.Concat` call in
   managed/AOT'd game code, `GenericPostfix` (which patches every non-generic public static
   `string.Concat`/`Format` overload, confirmed via `PatchAll`'s reflection loop, and logs
   unconditionally via `LogResidualCjkDebug` whenever its input contains CJK - which `"Zhuxian
   Town客栈"` would, since `客栈` is still CJK) would have logged it, corrupted or not. It never did.

Conclusion: `missionHideTargetPlaceString` is built by native, non-managed code with no reachable
Harmony hook (matching round 4's "unnamed IL2CPP offset write" finding) - genuinely below the
interop boundary our patches operate at, not a `System.String.Concat`/`Format` call our `GenericPostfix`
would ever see.

**Leading hypothesis**: a length assumption baked into that native code. `AreaData.csv`'s `Name`
column is packaged fully pre-translated (`TextFileConfiguration.cs`'s `AreaData.csv` entry translates
column 1) - so `AreaData.GetAreaName()` now returns long English text (`"Zhuxian Town"`, 12 chars)
where the native code was presumably only ever exercised against short raw Chinese place names (`"朱仙镇"`,
3 chars) - a roughly 4x length increase. `BuildingData.csv`'s `Name` column, by contrast, is
deliberately *not* translated at packaging time (`SkipColumns` covers it), so `AreaBuildingData.Name(bool)`
still returns short raw Chinese (`"客栈"`, 2 chars) unchanged. Confirmed both source CSVs are clean in
the deployed `resources/GameData/` folder (no corruption at the data-file level) - whatever mangles it
happens purely at runtime, in native code, and losing exactly one character at each edge of the
resulting compound (replaced with a literal `?` sentinel) is consistent with a native buffer/length
calculation that was sized for two short CJK strings and now receives one string ~4x longer than
expected.

**Why this can't be safely re-diagnosed by patching the source getters again**: round 5 already showed
that Harmony-patching `AreaData.GetAreaName()`/`AreaBuildingData.Name(bool)` - even just to observe,
without modifying `__result` - forces every call through an IL2CPP interop marshaling trampoline that
throws for at least one placeholder/no-name `AreaData` instance, and that crash happens in the
marshaling itself before any postfix body runs, so wrapping the postfix in try/catch would not help.
Re-adding either patch (even read-only) reintroduces that crash risk.

**Not fixable by any pipeline code we control** (this is a native/game-internal bug, most likely
newly exposed rather than newly introduced by shipping much-longer pre-translated `AreaData.csv` names
into a native code path never tested against strings that long). Options going forward, none attempted
yet:
- Stop packaging `AreaData.csv`'s `Name` column pre-translated (match `BuildingData.csv`'s
  raw-Chinese approach) and translate area names only through the already-safe runtime paths (dynamic
  string dictionary/templates) instead - but `AreaData.csv`'s Name is very likely relied on
  successfully elsewhere (world map, fast travel, location labels) with no reported issues, so this
  would need to be scoped carefully, not applied blindly.
- A narrow, cosmetic mitigation in `TranslateHiddenTargetPlaceString`: detect this specific corruption
  signature (a leading/trailing stray `?` around recognizable dictionary fragments) and repair it for
  display using the dictionary (e.g. suffix-match `"huxian Town"` back to the one dictionary entry
  ending that way) - a band-aid on the symptom, not the native root cause.

## Round 8 - found the real blind spot: `_suppressGenericTranslation` hides managed code from us, not just from translation

Round 7 argued the corruption must be native/non-managed because no log entry anywhere shows
`GenericPostfix` processing the clean pre-corruption compound. That argument is invalid: **the
absence of that log entry doesn't mean the event didn't happen - it could mean the event happened but
was silenced.**

`MissionPatches.GetTriggerTargetDescribePrefix`/`GetMissionTargetDescribePrefix` set
`DynamicStringPatches._suppressGenericTranslation = true` for the *entire duration* of the original
method body (restored by a matching `HarmonyFinalizer`). `GenericPostfix`'s old guard
(`if (... || _suppressGenericTranslation) return;`) returned **before** ever calling
`LogResidualCjkDebug`, so any `String.Concat`/`String.Format` call made *inside*
`GetTriggerTargetDescribe`/`GetMissionTargetDescribe`'s own method body - e.g. a native/AOT'd
`AreaData.GetAreaName() + AreaBuildingData.Name(bool)` concatenation, if that's really how the
compound is assembled - is not just left untranslated (intentional), it is **completely invisible to
our diagnostics** (unintentional blind spot). This is exactly the code path under suspicion: the
`GetTriggerTargetDescribe raw result`/`GetMissionTargetDescribe raw result` diagnostics already show
the corruption present in `__result` the instant the method returns, i.e. before
`TranslateObjective`/`TranslateCompoundName` ever run on it - so whatever produces it runs earlier,
inside that same suppressed method body, exactly where we had zero visibility.

Fix: split "should translate" from "should log" in `GenericPostfix` (`DynamicStringPatches.cs`). When
`_suppressGenericTranslation` is true, it now logs the untouched `__result` (stage
`"GenericPostfix (suppressed - not translated, diagnostic only)"`) whenever it contains CJK, instead
of returning silently - translation behavior is unchanged (still fully suppressed), this only restores
visibility. Deployed for the next play session; **not yet confirmed** - need a fresh
`missionHideTargetPlace` mission (ideally targeting a building in an area whose name is long once
translated, like `朱仙镇`/Zhuxian Town) to see whether a `GenericPostfix (suppressed...)` entry fires
for this compound and what it actually contains, before or in place of round 7's "native code"
hypothesis.

## Related code and references

- [MissionPatches.cs](../../../DragonHeirPlugin/MissionPatches.cs)
- [DynamicStringPatches.cs](../../../DragonHeirPlugin/DynamicStringPatches.cs)
- [MissionIconController decompilation](../../../Converter/output/_NoNamespace/MissionIconController.cs)
- [MissionData decompilation](../../../Converter/output/_NoNamespace/MissionData.cs)
- [Mission target describe natural translation](mission-target-describe-natural-translation.md)
