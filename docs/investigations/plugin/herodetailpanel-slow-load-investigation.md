# HeroDetailPanel slow-open investigation (2026-09-13)

**Status: RESOLVED, confirmed fixed in play (2026-09-13).**

## Symptom

HeroDetailPanel (and, to a lesser extent, AreaLog and PlotPanel's RecordScrollView) took a
noticeable while to open. Initial theories (broad text-setter fan-out, `PrefabTextPatches`'
per-instantiation GameObject tree walk) were investigated first via ad hoc reasoning, then
confirmed/refuted with real instrumentation - see `PerfInstrumentation.cs`, gated by
`MainPlugin.PerfInstrumentationEnabled` (off by default; flip on in the BepInEx config to reproduce
this investigation's methodology on a new symptom).

## Root cause

A single catastrophic-regex-backtracking hit, not broad fan-out. `perfStats.log` isolated one call
taking up to **2.68-3.15 seconds**:

```
DynamicStringPatches.RunGenericPipeline: 2682.04ms - [4.1.17]LouZhenZheng在Xianxia Sect Practice 了木…
DynamicStringPatches.HandleTextSetter: 2686.50ms - Canvas/HeroDetailPanel/Log/LogListScrollView/Viewport/Content/Text
```

Per-template instrumentation (`ApplyTemplatesSinglePass.Template` bucket) then named the exact
offending templates - several `"{0}在{1}..."`-shaped narrative templates each independently costing
200-350ms on the SAME input string.

**Why**: these are AI-generated narrative log lines (decompiled source -
`Converter/output/_NoNamespace/AIController.cs` - confirms `String.Format("{0}在{1}欲下毒暗害{2}，
{3}。", ...)`-style calls feeding `HeroData.AddLog`/`AreaData.AddLog`). The same finished text gets
redisplayed verbatim across multiple UI panels (HeroDetailPanel/Log, AreaLog, PlotPanel's
RecordScrollView, all reading from the same persisted `recordLog` field via decompiled-source
confirmation - `HeroData.cs`/`AreaData.cs`). Each redisplay is a brand-new `Text` component, so the
per-component cache never helps, and the text has already been partially substituted by an earlier
pass (mixed English fragments + leftover CJK) - a shape that no longer matches any template's
`Raw` pattern cleanly, forcing the unanchored permissive capture group into worst-case backtracking
across the whole string.

## Rejected approach: translate at the source

First attempt (`RecordLogPatches.cs`, reverted) Harmony-prefixed `HeroData.AddLog`/`AreaData.AddLog`
and translated the string before it was stored - mirroring `InfoListPatches`/`BattleInfoPatches`'
"translate once at the source" pattern. **This was wrong and was reverted**: unlike
`InfoTextList`/`BattleController.AddInfoText` (pure UI/session-transient display buffers, never
serialized), `HeroData.recordLog`/`AreaData.recordLog` are plain `List<string>` fields that ARE
persisted save state. Mutating the string before `AddLog` stores it bakes the English translation
into the save file permanently - irreversible, and any future translation-quality fix (see
`recordlog-translation-naturalness.md`) could never reach an already-saved entry. Never
translate at the source for data that gets serialized - only ever at display time.

## Actual fix (three parts, all non-destructive - save data is never touched)

1. **`MatchTimeout` on compiled template regexes** (`DynamicStringPatches.TemplateRegexTimeout`,
   25ms) - bounds a single catastrophic-backtracking `IsMatch`/`Replace` attempt to a small, fixed
   cost. A timeout is treated exactly like "no match" (skip this template, log a warning naming
   it, continue) rather than propagating the exception. This is what actually caps the worst case -
   confirmed live: the same stale save entry that took 2.68-3.15s dropped to ~589ms after this
   landed (still noticeable once, but bounded and far short of a multi-second stall).
2. **Raised `_genericPipelineMemoCache` bounds** (`maxEntries: 5000, maxInputLength: 20000`, was
   `2000`/`500`) - these finished log-history entries are finite, reused-verbatim text (not an
   ever-growing buffer), so exact-string memoization is a real win here: every REPEAT display within
   a session becomes a cache hit instead of re-running the full pipeline.
3. **`RecordLogPrewarmPatches.cs`** - a read-only Harmony prefix on `HeroData.AddLog`/
   `AreaData.AddLog` (takes `newLog` by value, never `ref` - never mutates what gets stored) that
   fires a background `Task` the moment a NEW entry is created, purely to populate
   `_genericPipelineMemoCache` ahead of time. By the time the player actually opens a log panel, a
   freshly-created entry's translation is usually already cached. Required making `MemoCache`
   lock-protected (it previously assumed single-main-thread-only access).

## Residual limitation (known, accepted)

Entries already sitting in an existing save file never pass through `AddLog` this session (they're
deserialized straight into `recordLog`), so `RecordLogPrewarmPatches` can't reach them - their first
display each session still pays the (now-bounded, ~500-600ms worst case observed) cold-cache cost.
This is considered acceptable: it's a one-time-per-session cost, not a recurring stall, and further
tightening `TemplateRegexTimeout` (currently 25ms) would shrink it further at the cost of a higher
chance of skipping a legitimately-slow-but-valid match.

## Follow-on work

See `docs/recordlog-translation-naturalness.md` for the template isolation/naturalization work
(done 2026-09-13); the runtime routing stretch goal it enabled is documented below, along with two
further bugs found and fixed while confirming it worked in play.

### 2026-09-13 update: the real mechanism was `GetRecordLog`, not the component text setter

The stretch goal's first attempt (route `ApplyToComponentText` to a smaller template list based on
`GetComponentPath`) turned out not to matter, because by the time text reaches the `Text`
component's setter, the damage is already done. The actual mechanism: `HeroData.GetRecordLog`/
`AreaData.GetRecordLog` (confirmed via decompiled source) build the displayed blob with a **loop of
`String.Concat` calls**, one per log entry, joining newest-to-oldest. `DynamicStringPatches.
GenericPostfix` Harmony-postfixes every `String.Concat` overload globally with no component
context, so **every iteration of that loop re-ran the full template/dictionary pipeline against
the ever-growing accumulated blob** - not just the newly-appended entry. By iteration 2+, the
accumulated text is a mix of already-translated English and a fresh raw Chinese entry, which no
longer cleanly matches any template's `Raw` shape, forcing the expensive permissive fallback -
repeated once per entry in the list.

**Fix**: `DragonHeirPlugin/RecordLogDisplayPatches.cs` Harmony-prefixes `HeroData.GetRecordLog`/
`AreaData.GetRecordLog` and skips the original method entirely, translating each entry
individually (a short, clean, single sentence - matches cleanly against the small isolated
log-narrative template list on the first attempt, no permissive fallback needed) and joining with
a `StringBuilder` (deliberately not `string.Concat`, which would immediately re-trigger
`GenericPostfix` on the growing result and reintroduce the exact cost being removed). This should
eliminate nearly all of the per-entry MatchTimeout warnings for stale (pre-existing-save) entries,
not just reduce them - each entry is now processed exactly once, standalone, against ~69 templates
instead of N times against the full corpus as part of a growing blob.

### 2026-09-13 update: `RecordLogDisplayPatches` was written but never wired up

First deploy of the fix above compiled cleanly, was copied to the live game folder, and appeared to
do nothing - the user still saw full-corpus-shaped timeout behavior after a clean build and full
game restart. Root cause: every Harmony patch class in this plugin (`ResourceIoPatches`,
`PrefabTextPatches`, `RecordLogPrewarmPatches`, etc.) only actually takes effect because
`MainPlugin.cs`'s startup sequence explicitly calls `Harmony.CreateAndPatchAll(typeof(ThatClass))`
on it - `[HarmonyPatch]` attributes alone do nothing without that call. `RecordLogDisplayPatches.cs`
was written, built, and deployed successfully, but the corresponding
`Harmony.CreateAndPatchAll(typeof(RecordLogDisplayPatches))` line was never added to `MainPlugin.cs`
- so `HeroData.GetRecordLog`/`AreaData.GetRecordLog` kept running completely unpatched the entire
time. **A silent, easy-to-repeat mistake for any new patch class in this plugin** - it compiles,
deploys, and produces zero errors or warnings; the only symptom is "the fix doesn't seem to do
anything."

Fixed by adding the missing registration call (wrapped in try/catch, matching the defensive pattern
used for every other not-yet-verified-against-live-interop patch in `MainPlugin.cs`, placed after
`DynamicStringPatches.PatchAll()` since `RecordLogDisplayPatches` depends on its dictionary/
templates). Also added `RecordLogDisplayPatches.LogPatchStatus`, called immediately after
registration, which explicitly logs whether Harmony actually bound
`HeroData.GetRecordLog`/`AreaData.GetRecordLog` (`PATCHED` vs `MISSING`) - this failure mode is now
visible in the log at plugin load instead of only discoverable by "the fix doesn't seem to work."
The prefixes themselves also log once on their first real invocation
(`"...prefix is active (first call intercepted)"`), confirming the patch is not just registered but
actually executing.

**Checklist for any future new Harmony patch class in this plugin**: after writing the
`[HarmonyPatch]`-attributed class, verify `MainPlugin.cs` actually calls
`Harmony.CreateAndPatchAll(typeof(YourClass))` (or an equivalent explicit registration) on it, and
add a log line confirming successful binding - do not rely on "it compiled and deployed" as proof
the patch is live.

### 2026-09-13 update: `PerfInstrumentation.PeriodicTick` "Collection was modified" crash

Reported live (`[Error :Il2CppInterop] ... System.InvalidOperationException: Collection was
modified; enumeration operation may not execute. at ... PerfInstrumentation.PeriodicTick()`),
recurring even after confirming both `Record` and `PeriodicTick` only ever touched the shared
`_buckets` dictionary under the same `lock (WriteLock)`. The most likely mechanism: `Time.deltaTime`
's getter - which every read of it anywhere in the game re-enters `PeriodicTick` through, via
`PlotTextSizePatches.OnDeltaTimeRead_Postfix` - got invoked again on the *same thread* while already
inside `PeriodicTick`'s own enumeration (e.g. via some nested engine call triggered by
`HandleTextSetter`'s `GetComponentPath` transform-hierarchy walk, itself invoked as a `Record()`
perf-sample callback). Since `lock`/`Monitor` is reentrant for the same thread, a nested call could
reach `PeriodicTick`'s `lock (WriteLock)` block again without blocking, running its own
foreach-then-`Clear()` concurrently with the outer call's still-active enumerator. **This exact
trigger was not pinned down with certainty** - rather than guess further, the fix was made
structurally crash-proof regardless of the precise mechanism, plus a diagnostic to confirm or
refute the theory from real data on the next report:

1. `PeriodicTick` now **swaps** `_buckets` for a fresh, empty dictionary under the lock, then
   enumerates the detached old reference (`snapshot`) entirely outside the lock - no other code
   path, concurrent or reentrant, can ever reach the object being iterated, since `_buckets` itself
   already points somewhere else by the time enumeration starts.
2. A `[ThreadStatic] _tickReentered` guard makes a same-thread reentrant call into `PeriodicTick`
   return immediately with a warning (`"PeriodicTick re-entered on the same thread..."`) instead of
   proceeding - if that warning ever appears in the log, it confirms the reentrancy theory above
   from live data instead of leaving it a guess.
3. `Record`'s `sampleDescription?.Invoke()` (an arbitrary caller-supplied callback - e.g.
   `GetComponentPath`'s live Unity transform walk) was moved to run *outside* `lock (WriteLock)`
   entirely - invoking arbitrary code while holding a shared lock is the general anti-pattern that
   enabled whatever reentrancy occurred in the first place, independent of the exact trigger.

Confirmed by the user testing in play after this fix (along with the `RecordLogDisplayPatches`
registration fix above) that both the crash and the slow HeroDetailPanel/AreaLog/PlotPanel log
loading are resolved.

## Diagnostics added during this investigation

`PerfInstrumentation.cs` - times `DynamicStringPatches.HandleTextSetter`/`RunGenericPipeline` and
`PrefabTextPatches.ProcessGameObjectRecursive`, dumping aggregate counts/durations to
`perfStats.log` every ~2s plus any individually slow call immediately. Gated by
`MainPlugin.PerfInstrumentationEnabled` (`Debug` config section) - **off by default**; this was the
tool that found the root cause above and is kept in the codebase for the next performance
investigation, not intended to run in normal play.
