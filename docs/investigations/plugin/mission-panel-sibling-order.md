# MissionPanel draw order over full-screen panels (2026-10-04)

## Symptom

`Canvas/MissionPanel/MissionUI` (the quest/mail/world-event list opened from the HUD) is useful to
keep open over the map, but vanilla draws it on top of full-screen panels such as
`Canvas/TradePanel` and `Canvas/HeroDetailPanel`, so it could not stay open without covering them.

## Findings

A hierarchy dump (see `HierarchyDump` below) showed:

- The root `Canvas` is `ScreenSpaceCamera`, `sortingOrder=0`, and **no child panel has its own
  `Canvas` override** (`overrideSorting` is false everywhere). Stacking is plain sibling order:
  a higher sibling index draws later, on top.
- Vanilla `MissionPanel` is at sibling index 61, after `TradePanel` (58), `HeroDetailPanel` (57)
  and every other full-screen panel (7-60). `AreaUIPanel` is 2, `BuildingUIPanel` 3, `HudPanel` 6,
  `BigMapUIPanel` (atlas map) 1.
- Panels keep their sibling index whether active or not, so a dump taken with `TradePanel` closed
  still shows where it sits.

## Fix

`MissionPatches.PlaceMissionPanel` moves `Canvas/MissionPanel` to directly after
`Canvas/AreaUIPanel` (`AreaUIPanel` index + 1, resolved at runtime, not hardcoded). Result: it draws
over the map and area panel, and under the HUD, `TradePanel`, and every other panel after them. To
draw over the HUD instead, anchor on `HudPanel` rather than `AreaUIPanel`.

### Hook choice (the first attempt failed)

The first version only postfixed `MissionUIController.ShowMissionUI(bool)` and did nothing in game.
The HUD button calls `ToggleButtonClicked(GameObject)`, which flips `showUI` and plays the tween
directly without going through `ShowMissionUI`. The placement now runs after all of:

- `ShowMissionUI(bool)` (hotkey / other callers),
- `ToggleButtonClicked(GameObject)` (the HUD button),
- `RefreshMissionTable()` (covers the panel already being open without either call; also runs on
  day ticks, so the no-op path is a couple of transform reads and an index compare).

It only calls `SetSiblingIndex` when the index differs, and logs
`[MissionPatches] <caller>: moved MissionPanel sibling index X -> Y.` when it does.

[GameCoupled] relies on the object names `Canvas/AreaUIPanel`, `Canvas/MissionPanel`, and on
`MissionPanel` being the direct parent of `MissionUIController.missionUI`.

## Hierarchy dump tool

`HierarchyDump.cs` (debug only). Set `[Debug] DumpHierarchyHotkey` (e.g. `F10`) in
`BepInEx/config/FanslationStudio.EnglishPatch.cfg` and restart (the frame tick that polls hotkeys is
only patched at startup when a debug hotkey is set; see `PlotTextSizePatches.FrameTickPatch`).
Pressing the key writes `BepInEx/plugins/hierarchy-dump.txt`: every direct child of `Canvas` in
sibling order with active state and any own-`Canvas` sorting override, plus one level of children
under `MissionPanel` and `TradePanel`. Only active `Canvas` is found (`GameObject.Find`), and
inactive panels are listed but their state is the state at the moment of the press.
