# Day-tick / rumor / homing-pigeon stutter investigation (2026-10-04)

**Status: MEASURED, NO FIX SHIPPED (deliberately).** The stutter is the game's own `ChangeDay` work,
not this plugin. Only the diagnostic instrumentation was kept (off by default).

## Symptom

The game stutters when a day ticks, when homing-pigeon messages arrive, and when rumors appear. The
suspicion was the translation patches (rumor lines are long `传闻...` strings that go through the
template pipeline).

## Method

`PerfInstrumentation` (`[Debug] PerfInstrumentation`, off by default) was extended so a hitch can be
attributed to plugin or game. Every number below is from `BepInEx/plugins/perfStats.log`.

- **Thread tag.** Background-thread calls record as `<bucket>[bg]`; main-thread calls keep the plain
  bucket name. Before this, `RecordLogPrewarmPatches`' background `Task` and the main thread shared
  buckets.
- **Per-frame main-thread accounting.** The outermost measured scope on the main thread is summed
  per frame (nested scopes are not double-counted).
- **Wall-clock frame time.** The gap between consecutive frame ticks. A frame of 50 ms or more is
  logged as `[HITCH+FRAME]` with the plugin's measured main-thread share next to it. Anything left
  over is game/engine time.
- **GC counters.** .NET collections per frame (`gc(g0/g1/g2)=+N/+N/+N`), to test whether the
  allocation-heavy background prewarm could pause the main thread unseen.
- **Game-side timers (temporary, since removed).** Two throwaway patch classes timed the mail path
  (`GetNewMail`, `PlayPigeonAnim`, `RefreshMailTable`) and the day tick (`GameController.ChangeDay`,
  `ChangeMonth` and the `Manage*`/`Generate*` steps it runs) into `Game.*`/`Mail.*` buckets via
  `PerfInstrumentation.Begin`/`End` prefix+finalizer pairs. They were only installed when
  instrumentation was on at startup, because several targets run per hero per day. Removed once the
  investigation concluded; the findings below came from them.

## Findings

### 1. The ~300 ms translation burst is the HUD build at load, not the day tick

Every run showed one frame of ~290 ms, ~250-265 ms of it main-thread `RunGenericPipeline` (~100
cold calls), about 20 s into the log. The stack of every cache miss went through
`InfoTextList.Add` from native code, and `InfoController.BuildInfoList` (the one-time HUD
initialisation, `inited == false` in `InfoController.Update`) replays the whole stored message
history into `InfoTextList.Add`. It happens once per load. The day-tick windows afterwards peak at
about 33 ms of translation per 2 s, with individual rumor lines at 2-4 ms.

### 2. Rumors are not covered by the existing prewarm

The prewarm hooks `HeroData.AddLog` / `AreaData.AddLog`. Rumors are built with
`String.Format("传闻{0}...")` and queued through `InfoController.AddInfo` (see
`AIController.cs`), so they were never prewarmed (17 of the slow main-thread pipeline calls started
with `传闻`, 0 of the slow background ones). Two attempted fixes did not work and were removed:

- **`InfoController.AddInfo` prewarm.** It fired for only ~9 texts per run, far fewer than the
  queued rumors/logs. IL2CPP most likely inlines that tiny method into its callers, so the Harmony
  detour is rarely reached.
- **Parallel warm of `InfoController.newInfoDatas` in a prefix on `InfoController.Update`.** It
  fired 5 times: the queue is rarely deep enough in one frame, and the large burst is the
  `BuildInfoList` replay, which does not go through the queue.

A full-corpus (non-narrative) warm of `AddLog` text was also tried, since the two modes use separate
memo caches. It showed no measurable benefit and doubled the background work, so it was reverted.

### 3. The day-tick hitch is the game's `ChangeDay`

Day tick (18.11.21 to 18.11.22), consistent across runs:

| Frame | Frame time | .NET GC g0/g1/g2 | Measured plugin work |
|---|---|---|---|
| `ChangeDay` | 153-187 ms | +16 / +1 / +0 | 143-176 ms, all inside `ChangeDay` |
| next | 88-114 ms | +0 / +0 / +0 | 14-28 ms |
| next | 179-200 ms | +0 / +0 / +0 | 1.5-1.8 ms |
| next | 69-96 ms | +0 / +0 / +0 | 0.1-0.3 ms |
| next | 57-82 ms | +0 / +0 / +0 | 0.1-0.3 ms |

- `Game.GameController.ChangeDay`: **143-176 ms in one frame**. Its measured sub-steps account for
  ~35 ms (`GenerateRandomEvent` 17.5 ms, `ManageForceStuff` 13.5 ms,
  `CheckWorldPlotEventDataBase` 3.3 ms); the other ~140 ms is the method body itself (per-hero
  loops such as `TryIdentifyAllItem`/`ManageTagTime`, a `Resources.Load`, `SendMessage`, a
  `Monitor.Enter`/`Exit` pair). The `ChangeDay` frame contained no nested plugin scope (only a
  0.0 ms `HandleTextSetter`), so none of the plugin's measured hooks ran inside it.
- The game already spreads some day work out: `ManageAllAI` ran as 152 calls of ~0.03 ms across
  later frames, and `ManageHeroAutoRecover` ran ~1,500 times on a background thread.
- The hero-name hooks (`HeroNamePostfix`, `GetHeroName` postfixes, `ReplaceSpeStringPrefix`,
  `GetHeroForceLvDescribePostfix`) were suspected because the game calls them for every name. They
  were instrumented and are negligible (18 `GetHeroNamePostfix` calls totalling 4.8 ms main-thread;
  the others ~0 ms). The instrumentation was removed again.
- Mail: `RefreshMailTable` 4.5-5.8 ms, `GetNewMail` 9.2 ms when a letter arrived. Not the cause.
- No gen-2 collection fell in any day-tick frame, so a .NET GC pause from the prewarm is ruled out.
  Unity's own IL2CPP collector is not visible from the plugin and is not ruled out.

## What is NOT done, and why

- `ChangeDay` is one large synchronous game method with no safe seam for splitting its loops across
  frames. Rewriting it through Harmony would risk save compatibility and AI ordering for a game
  stall the plugin does not cause.
- Autosave/quicksave is a separate and much larger (~2.6 s) freeze; see
  [autosave-slow-save-investigation.md](autosave-slow-save-investigation.md). Turning off the
  in-game AutoSave option avoids it.

## Open

- Confirming the stutter is vanilla: run the same save with the plugin DLL removed and compare. Not
  yet done.
- The one-time `BuildInfoList` replay (~250 ms at load) is the only translation-side cost seen. A
  parallel warm of `worldData.infos` in a prefix on `InfoController.BuildInfoList` would shrink it;
  not implemented because it is a once-per-load cost, not the reported stutter.

## Diagnostics kept (all off by default)

`PerfInstrumentation` thread tag, `[FRAME]` / `[HITCH+FRAME]` lines and GC counters. To reuse: enable
`[Debug] PerfInstrumentation`, reproduce, then read `perfStats.log`. Read `[HITCH+FRAME]` first: a
hitch with ~0 ms of plugin work is not the plugin. To time specific game methods again, wrap them in
`PerfInstrumentation.Measure` scopes (patch-pair timing needs the removed `Begin`/`End` helpers,
re-addable from this document's description).

## Related

- [Autosave / quicksave hitch investigation](autosave-slow-save-investigation.md)
- [Performance optimization pass 2](performance-optimization-pass-2026-10-02.md)
- [HeroDetailPanel slow-open investigation](herodetailpanel-slow-load-investigation.md)
