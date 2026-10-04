# Autosave / quicksave hitch investigation (2026-10-04)

**Status: MEASURED, NO FIX SHIPPED (deliberately).** The temporary timing patch was removed afterwards.

## Symptom

Autosave (and quicksave) freezes the game for ~2.6 seconds.

## Where the code lives

`GameDataController.Save(int saveID)` (`Converter/output/_NoNamespace/GameDataController.cs`, ~line
1578). Triggered for autosave from `GameController.Update` when `needAutoSave` is set (`saveID` 0);
quicksave is `saveID` 10. It is fully **synchronous on the main thread**:

1. `GC.Collect()`
2. `GameIntoGameData` (cheap - `gameSaveData.HeroList` just references the live hero list)
3. `SaveFileIO.WriteJson` x3 - `WorldData`, `HeroList`, `TempHeroList` (Newtonsoft, written to
   `<path>.tmp` then moved over the real file)
4. `GenerateSaveInfo`, `SavePlayerprefData`
5. A delete-and-re-copy loop into `Save_backup`
6. UI toast + sound

The translation plugin does not patch any of this (the plot-text resync only edits strings that
the next save then serialises).

## Measurements

A temporary Harmony patch (`SaveTimingPatches.cs`, since removed; it was gated by
`Debug.PerfInstrumentation`) logged a `[SaveTiming]` line per save. Per-file write timestamps relative to save start give the split:

```
Save(saveID=10) total=2621ms, GameIntoGameData=0ms; type0=12239KB@420ms type1=47167KB@2407ms type2=4677KB@2584ms
```

| Step | Time |
|---|---|
| GC + `WorldData` (12 MB) | ~420 ms |
| **`HeroList` (47 MB)** | **~1990 ms (76%)** |
| `TempHeroList` (5 MB) | ~180 ms |
| Backup copies + rest | ~36 ms |

(The backup-file creation timestamps logged alongside were garbage and should be ignored.)

Hero list contents (`SaveSlot0/Hero`, 1,248 heroes, ~48 MB): `kungfuSkills` 42%, `itemListData` 37%,
`recordLog` 9%, everything else under 3% each. Translated text is a minor share (item
`describe`+`name` are under 20% of item data). This is intrinsic game data volume, not something
the translation adds.

About 37-47% of the JSON bytes are default-valued members (0 / false / null): Hero 37%, Save 47%,
TempHero 39%.

## Options considered

| Option | Verdict |
|---|---|
| **Throttle autosaves** (prefix on `Save`, skip `saveID==0` within N minutes of the last one) | Safe - changes *when*, not *what* is written. Not implemented; the user chose to bail out. Best option if this is revisited. |
| Omit default-valued fields (`DefaultValueHandling.Ignore`) | Would save ~0.6-0.9 s at best (property reads still happen). **Unsafe without an audit:** Newtonsoft compares against the *type* default, not the constructor's value, so a field a constructor initialises to non-default and that was saved as 0 would silently load back non-default. Needs a full audit of every save-graph class plus a round-trip diff tool. |
| Snapshot heroes on main thread, serialise on background thread | Rejected. A deep copy of 1,248 heroes costs about as much as the serialisation; a hand-written deep clone is a large maintenance burden; background thread + Unity/IL2CPP and the game's own `CheckAllFinished`/`SetSaveFailed` tracking add risk. |
| Time-sliced save (serialise a few dozen heroes per frame) | Hitch drops to ~30 ms/frame, but heroes serialised in different frames reflect different moments (an item trade straddling the boundary could duplicate/lose an item). Needs a full `Save` replacement. |
| Source-generated / hand-rolled writer instead of reflection | Possibly 2-5x faster (guess, unmeasured), but the plugin only sees Il2CppInterop wrappers (per-field marshalling, string copies, wrapper allocation) and must reproduce Newtonsoft's format exactly for the game's loader. Unproven gain. |
| Parallel serialisation of hero slices while main thread stays blocked | Would likely cut ~2 s to a few hundred ms with byte-identical output, and no mutation during the write. **Rejected on risk:** thread-safety of the game's IL2CPP Newtonsoft on plugin-created threads can be tested but not proven, and any residual risk is to the player's save file. Safeguards if ever revisited: fall back to the game's `Save` on any exception, validate hero count/JSON before replacing, debug byte-compare mode, config flag off by default. |

## Decision

No behaviour change shipped. The user's priority is zero risk to save integrity; only the throttle
meets that bar and it was not taken up. The timing patch was removed; to re-measure after a game
update, hook `GameDataController.Save`/`GameIntoGameData` with a `Stopwatch` and compare the
`Save`/`Hero`/`TempHero` file write timestamps against the save start, as described above.
