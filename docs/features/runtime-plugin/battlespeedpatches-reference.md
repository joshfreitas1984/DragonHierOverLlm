# BattleSpeedPatches agent reference

Read this before changing `BattleSpeedPatches.cs`. It makes skill visuals follow the battle speed
selector (the 20x button), behind an on-screen **Anim fix ON/OFF** button.

## Problem

Reported: at 20x some skills (Great Whirlwind Hand / `旋风斩`) play their animation at normal speed,
and area skills pause between each row.

The game stores the speed as `worldData.battleTimeScale` (the speed buttons under
`BattleController.timeScaleTab` are named by their number; `BattleTimeScaleButtonClicked` parses the
name). It does **not** use `Time.timeScale`. Instead each battle step divides its own timing by that
float (`WaitForSeconds(1 / scale)`, `DOLocalMove` durations, move animation `TimeScale`). Anything
that is not divided stays at real-time speed. Three things were not:

| Gap | Where in the game | Fix here |
| --- | --- | --- |
| Skill effect prefabs (`SpeEffect/*`, bullets) play particles/animators at 1x | spawned via `GlobalData.AddChild` from `BattleController.CreateSpeEffect` / `BattleUnitAttackHappen` | `AddChild_Postfix` |
| The character's skill animation (Spine track 1) plays at 1x | `BattleUnitAttackStart` calls `AnimationState.SetAnimation(1, ...)` and never sets `TimeScale` (only `jump_small` moves are scaled) | `SetAnimation_Postfix` |
| Pause between rows / waves | projectile travel uses the dampened `GetHalfBattleTimeScale` (`scale*0.5+0.5`) and an UNSCALED `(distance - base) * 0.2` term in `BattleUnitAttackHappen` | Half/Third postfixes and the tween clamp |

## What the patches do

All patches are no-ops unless the fix is ON, `battleTimeScale > 1`, and a fight is running: the
`BattleController.Update` postfix only stamps "in battle" while `battleState == BattleState.Fighting`,
and every patch requires that stamp to be at most 2 frames old. `BattleController.Update` itself runs
outside battles (it only returns early while `battleState` is `None`) and `battleTimeScale` keeps its
saved value there, so gating on "Update ran" alone sped up unrelated animations across the game.

- **Effects.** `AddChild_Postfix` multiplies every `Animator.speed` in the spawned hierarchy by the
  effect scale. `ParticleSystem.playbackSpeed` / `main.simulationSpeed` throw
  `MissingMethodException` in this game's Unity build, so particle systems are tracked and advanced
  by extra `Simulate(deltaTime * (scale - 1))` each frame from the `BattleController.Update`
  postfix. If that throws once, particle speed-up disables itself for the session.
- **Dedupe.** The `GlobalData.AddChild` overloads call each other, so the postfix fires several times
  per spawned object. Without the `_seenEffects` guard the speed-up was applied once per nested call
  (observed as effects running at roughly the square of the intended speed).
- **Skill animation.** Track-1 `SetAnimation` results get `TrackEntry.TimeScale` = effect scale.
- **Effect scale cap.** Effects and the skill animation use `min(battleTimeScale, 10)` so 20x stays
  watchable; the cap is `EffectSpeedCap`. Game timings (waits, tweens) still use the real scale.
- **Half/Third scale.** Both postfixes return the full `battleTimeScale` when it is larger than the
  game's dampened value. These functions are also used by some unit-movement delays, which therefore
  speed up too.
- **Projectile clamp.** `DOLocalMove` (only on objects spawned via `AddChild` during battle) and the
  `DOTween.To(setter, 0, 1, duration)` progress tween used by path projectiles have their duration
  clamped to `TweenBudgetSeconds (0.6) / battleTimeScale` (floor 0.02 s). Clamping, not rescaling,
  because the duration mixes a scaled and an unscaled term and rescaling would double-scale the
  scaled part. Side effect: a slow projectile in battle also arrives faster.

## The button

`SetTimeScaleTab_Prefix` clones the highest-numbered speed button each battle start, parents it
**outside** `timeScaleTab` (the game `Int32.Parse`s every child's name, so a non-numeric child would
throw), disables its `Toggle`, and relabels its texts. Clicks are detected by polling
`Input.GetMouseButtonDown(0)` against the button's rect in the `BattleController.Update` postfix, so
the clone's copied UI wiring can never fire the speed handler.

The on/off state is saved in `PlayerPrefs` under `EnglishPatch.AnimFixEnabled` (default ON). It is
deliberately not a BepInEx config entry.

## Gotchas

- Needs references to `spine-csharp`, `UnityEngine.ParticleSystemModule`,
  `UnityEngine.AnimationModule` and `UnityEngine.InputLegacyModule` (see `GamePlugin.csproj`).
- `GlobalData.AddChild` and the two DOTween methods are patched manually in `PatchAll` (by reflection
  over overloads). The DOTween `To` overload is found by shape (`DOSetter*`, float, float, float);
  a log warning appears if `DOLocalMove` is not found.
- The row delay was only partly traced from the decompile: the unscaled
  `(distance - base) * 0.2` term (`BattleUnitAttackHappen`, projectile mode 1) and the leading
  `WaitForSeconds` in `BattleUnitAttackHit` (argument not visible in the decompile) are the known
  unscaled pieces. The clamp is a deliberate blunt fix; see the history below.
- If effects still look slow after a game update, run with a temporary log of spawned effect names
  and their `ParticleSystem` / `Animator` / `SkeletonAnimation` counts; that is how `旋风斩` was
  identified (4 particle systems, no animators, no Spine).

## History

An earlier version also added a 40x speed button by cloning the 20x button and intercepting
`BattleTimeScaleButtonClicked`. It was dropped; the fix button replaced it. The cap was tested at 8x,
uncapped and 10x; 10x was kept.
