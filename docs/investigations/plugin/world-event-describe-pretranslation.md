# World-event description pre-translation (2026-09-18)

## Symptom

A randomly generated world-event description was observed in a mixed-language form:

```text
Unknown to you, Young Hero Han may have heard of this.：
Lingzhou城 Middle Currently 举办 One 场<color=...
```

The affected source phrase was the auction event template:

```text
#PosText#城中正在举办一场#DifficultyItemText#拍卖大会，各种名品利器云集一堂，附近富商豪绅纷纷前往欲争相抢购。
```

## Source and runtime path

The phrase is the `eventDescribe` field of a `WorldEventDataBase` entry, extracted from
`RandomEventController.Base.worldEventDataBase.Array.data.eventData.eventDescribe` in
`Files/Raw/Dumped/PrefabText/dumpedOtherText.txt`.

`EventData.GetDescribe(bool)` performs the runtime composition:

- `#PosText#` becomes the city name, such as `Lingzhou`.
- `#DifficultyItemText#` becomes a difficulty/item label containing Unity rich-text markup.
- The completed description is returned to its callers.

The completed value is used by `WorldEventIconController.Update` for the world-map event tooltip
and by `WorldData.GetRandomWorldNews` when a world event is selected as news. World events are
created by the daily `GameController` update through `WorldEventController.ManageWorldEvent`, so
the affected entry is random and difficult to reproduce manually.

## Root cause

The complete template and translation were present and passed QC:

- Source: `Files/Raw/Dumped/PrefabText/dumpedOtherText.txt`
- Converted translation: `Files/Converted/dumpedPrefabTextFromOtherFields.txt.yaml`
- Packaged translation: `Files/Mod/dumpedPrefabTextFromOtherFields.txt.yaml`

Before the fix, `DynamicStringPatches.GenericPostfix` could process intermediate
`String.Concat`/`String.Format` values while `GetDescribe` was still assembling the result. If the
whole template was not matched at that point, the later bare-fragment pass translated isolated
entries such as `中`, `正在`, and `一`, producing output like `Middle Currently One` while leaving
the rest of the Chinese text intact.

The `Unknown to you, #PlayerName#...` prefix is a separate dynamic-string entry. It is not part of
this `eventDescribe` template; it can be composed by another caller around the same runtime UI or
dialogue path.

## Fix

`DragonHeirPlugin/WorldEventPatches.cs` patches `EventData.GetDescribe(bool)` using the same
boundary pattern as `MissionPatches`:

1. The prefix suppresses generic translation while the game method runs.
2. The game expands all event placeholders and rich-text values.
3. The postfix receives the complete description and runs `DynamicStringPatches.RunGenericPipeline` once.
4. A Harmony finalizer restores the previous suppression state even when the game method throws.

The translation runs with the existing `_inFormatConcatPatch` re-entrancy guard enabled, so logging
or nested formatting cannot recursively re-enter the global string patches. The hook changes only
the transient return value; it does not mutate the saved event data.

## Verification

The fix was installed and tested in-game. The affected random event description translated
correctly without the former isolated-fragment corruption.

## References

- [WorldEventPatches.cs](../../../DragonHeirPlugin/WorldEventPatches.cs)
- [MissionPatches.cs](../../../DragonHeirPlugin/MissionPatches.cs)
- [DynamicStringPatches.cs](../../../DragonHeirPlugin/DynamicStringPatches.cs)
- [EventData decompilation](../../../Converter/output/_NoNamespace/EventData.cs)
- [WorldEventIconController decompilation](../../../Converter/output/_NoNamespace/WorldEventIconController.cs)
- [WorldData decompilation](../../../Converter/output/_NoNamespace/WorldData.cs)
- [DynamicStrings extraction sources](../tests/dynamicstrings-extraction-sources.md)
