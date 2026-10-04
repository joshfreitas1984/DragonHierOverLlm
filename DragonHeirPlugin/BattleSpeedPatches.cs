using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishPatch;

// Makes skill visuals follow the battle speed selector (the "20x" button).
// The game stores the speed as worldData.battleTimeScale and divides its OWN timings by it (no
// Time.timeScale), but skill attack animations, spawned effect prefabs and parts of projectile
// travel time ignore it, so at high speed skills look slow and pause between rows. Everything here
// is gated by one on-screen "Anim fix ON/OFF" button, saved in PlayerPrefs, so it is easy to A/B.
// Full rationale and measurements: docs/features/runtime-plugin/battlespeedpatches-reference.md
internal static class BattleSpeedPatches
{
    private const string FixPrefKey = "EnglishPatch.AnimFixEnabled";

    // Visual playback (effects, skill animation) is capped (config BattleEffectSpeedCap) so very
    // high battle speeds stay watchable; the game's own timings still use the real battleTimeScale.
    private const float DefaultEffectSpeedCap = 10f;

    // Projectile tweens longer than TweenBudgetSeconds / battleTimeScale are shortened to that.
    private const float TweenBudgetSeconds = 0.6f;

    // A patched call only counts as "in battle" if BattleController.Update ran this recently.
    private const int BattleFrameWindow = 2;

    private static bool _fixEnabled = LoadFixEnabled();
    private static GameObject _fixButton;
    private static int _lastBattleFrame = -100;

    // Objects spawned through GlobalData.AddChild during battle (effects, projectiles, text). Doubles
    // as the dedupe guard (AddChild overloads call each other) and the DOLocalMove scope.
    private static readonly HashSet<int> _seenEffects = new();
    private static readonly List<ParticleSystem> _trackedParticles = new();
    private static bool _particlesBroken;

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.BattleSpeedPatches");
            harmony.PatchAll(typeof(BattleSpeedPatches));

            // [GameCoupled GlobalData.AddChild logic] skill effects/projectiles are spawned through it
            var post = new HarmonyMethod(typeof(BattleSpeedPatches), nameof(AddChild_Postfix));
            foreach (var m in AccessTools.GetDeclaredMethods(typeof(GlobalData)))
            {
                if (m.Name == "AddChild" && m.ReturnType == typeof(GameObject))
                    harmony.Patch(m, postfix: post);
            }

            PatchTweenDurations(harmony);
            MainPlugin.Logger.LogInfo("[BattleSpeedPatches] Patched battle speed / animation fix.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] PatchAll failed: {ex}");
        }
    }

    private static bool InBattle => Time.frameCount - _lastBattleFrame <= BattleFrameWindow;

    private static float BattleScale => GameController._instance?.worldData?.battleTimeScale ?? 1f;

    // Effects only get the configured fraction (BattleEffectSpeedFactor) of the speed-up above 1x,
    // so at low speeds (2x-5x) they stay readable; travel/wave timing (UseFullScale, ClampTween)
    // still uses the full battle scale.
    private static float EffectScale()
    {
        var factor = Math.Max(MainPlugin.BattleEffectSpeedFactor?.Value ?? 0.5f, 0f);
        var cap = Math.Max(MainPlugin.BattleEffectSpeedCap?.Value ?? DefaultEffectSpeedCap, 1f);
        return Math.Min(1f + (BattleScale - 1f) * factor, cap);
    }

    // ---- Saved on/off state --------------------------------------------------------------------

    private static bool LoadFixEnabled()
    {
        try { return PlayerPrefs.GetInt(FixPrefKey, 1) != 0; }
        catch { return true; }
    }

    private static void SaveFixEnabled()
    {
        try
        {
            PlayerPrefs.SetInt(FixPrefKey, _fixEnabled ? 1 : 0);
            PlayerPrefs.Save();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] saving fix state failed: {ex}");
        }
    }

    // ---- On-screen toggle button ---------------------------------------------------------------
    //
    // A clone of a speed button, parented OUTSIDE timeScaleTab (SetTimeScaleTab Int32.Parses every
    // child's name). Its Toggle is disabled and clicks are detected by polling the mouse against its
    // rect, so the clone's copied UI wiring can never fire the speed handler.

    // [GameCoupled BattleController.SetTimeScaleTab ui-path] timeScaleTab's children are the speed buttons, named by their number
    [HarmonyPatch(typeof(BattleController), nameof(BattleController.SetTimeScaleTab))]
    [HarmonyPrefix]
    private static void SetTimeScaleTab_Prefix(BattleController __instance)
    {
        try
        {
            var tab = __instance?.timeScaleTab;
            if (tab == null || tab.transform.childCount == 0) return;

            // Template: the highest-numbered speed button.
            Transform source = null;
            int best = int.MinValue;
            for (int i = 0; i < tab.transform.childCount; i++)
            {
                var child = tab.transform.GetChild(i);
                if (int.TryParse(child.name, out var value) && value > best)
                {
                    best = value;
                    source = child;
                }
            }
            if (source != null) AddFixButton(tab, source.gameObject);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] adding fix button failed: {ex}");
        }
    }

    private static void AddFixButton(GameObject tab, GameObject speedButton)
    {
        var parent = tab.transform.parent;
        if (parent == null) return;

        if (_fixButton != null) UnityEngine.Object.Destroy(_fixButton);

        var obj = UnityEngine.Object.Instantiate(speedButton, parent).TryCast<GameObject>();
        if (obj == null) return;
        obj.name = "AnimFixButton";

        var toggle = obj.GetComponent<Toggle>();
        if (toggle != null)
        {
            toggle.group = null;
            toggle.enabled = false;
        }

        // One button-width to the right of the speed button it was cloned from.
        var parentRect = parent.GetComponent<RectTransform>();
        if (parentRect != null) LayoutRebuilder.ForceRebuildLayoutImmediate(parentRect);
        var rect = obj.GetComponent<RectTransform>();
        var srcRect = speedButton.GetComponent<RectTransform>();
        if (rect != null && srcRect != null)
            rect.position = srcRect.position + new Vector3((srcRect.rect.width + 4f) * srcRect.lossyScale.x, 0f, 0f);

        _fixButton = obj;
        RefreshFixLabel();
    }

    private static void RefreshFixLabel()
    {
        if (_fixButton == null) return;
        var label = _fixEnabled ? "Anim fix ON" : "Anim fix OFF";
        foreach (var text in _fixButton.GetComponentsInChildren<Text>(true)) text.text = label;
        foreach (var tmp in _fixButton.GetComponentsInChildren<TMPro.TMP_Text>(true)) tmp.text = label;
    }

    // Per-frame hook: marks "a battle is running", advances tracked particles, polls the button.
    // [GameCoupled BattleController.Update by-name] "Update" bound by string; relies on battleState == Fighting only during real fights
    [HarmonyPatch(typeof(BattleController), "Update")]
    [HarmonyPostfix]
    private static void BattleUpdate_Postfix(BattleController __instance)
    {
        // BattleController.Update runs outside battles too (it only returns early while battleState
        // is None), and worldData.battleTimeScale keeps its saved value, so "Update ran" alone would
        // speed up unrelated animations everywhere.
        if (__instance.battleState != BattleState.Fighting) return;

        _lastBattleFrame = Time.frameCount;
        try
        {
            if (!_particlesBroken) AdvanceTrackedParticles();
        }
        catch (Exception ex)
        {
            _particlesBroken = true;
            _trackedParticles.Clear();
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] particle advance failed, disabled: {ex}");
        }

        try
        {
            PollFixButton();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] fix button poll failed: {ex}");
        }
    }

    private static void PollFixButton()
    {
        if (_fixButton == null || !_fixButton.activeInHierarchy) return;
        if (!Input.GetMouseButtonDown(0)) return;

        var rect = _fixButton.GetComponent<RectTransform>();
        if (rect == null) return;
        var canvas = _fixButton.GetComponentInParent<Canvas>();
        Camera cam = canvas != null && canvas.renderMode != RenderMode.ScreenSpaceOverlay ? canvas.worldCamera : null;
        if (!RectTransformUtility.RectangleContainsScreenPoint(rect, Input.mousePosition, cam)) return;

        _fixEnabled = !_fixEnabled;
        SaveFixEnabled();
        RefreshFixLabel();
        MainPlugin.Logger.LogInfo($"[BattleSpeedPatches] Animation fix {(_fixEnabled ? "ON" : "OFF")}.");
    }

    // ---- Skill effects (particles / animators) -------------------------------------------------
    //
    // ParticleSystem.playbackSpeed / main.simulationSpeed throw MissingMethodException in this
    // game's Unity build, so particle systems are tracked and advanced by extra Simulate() time
    // each frame instead (AdvanceTrackedParticles).

    private static void AddChild_Postfix(GameObject __result)
    {
        if (!_fixEnabled || __result == null || !InBattle) return;
        try
        {
            var scale = EffectScale();
            if (scale <= 1f) return;

            // AddChild overloads call each other, so this fires several times per spawned object.
            if (_seenEffects.Count > 20000) _seenEffects.Clear();
            if (!_seenEffects.Add(__result.GetInstanceID())) return;

            foreach (var anim in __result.GetComponentsInChildren<Animator>(true))
                anim.speed *= scale;

            if (_particlesBroken) return;
            foreach (var ps in __result.GetComponentsInChildren<ParticleSystem>(true))
                _trackedParticles.Add(ps);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] AddChild speedup failed: {ex}");
        }
    }

    private static void AdvanceTrackedParticles()
    {
        if (_trackedParticles.Count == 0) return;
        var scale = EffectScale();
        var extra = Time.deltaTime * (scale - 1f);
        for (int i = _trackedParticles.Count - 1; i >= 0; i--)
        {
            var ps = _trackedParticles[i];
            if (ps == null) { _trackedParticles.RemoveAt(i); continue; }
            if (!_fixEnabled || scale <= 1f || !ps.isPlaying) continue;
            ps.Simulate(extra, false, false, true);
        }
    }

    // ---- Character skill animation -------------------------------------------------------------

    // [GameCoupled BattleController.BattleUnitAttackStart logic] starts the skill animation on Spine track 1 and never scales it
    [HarmonyPatch(typeof(Spine.AnimationState), nameof(Spine.AnimationState.SetAnimation),
        new[] { typeof(int), typeof(string), typeof(bool) })]
    [HarmonyPostfix]
    private static void SetAnimation_Postfix(int trackIndex, Spine.TrackEntry __result)
    {
        if (!_fixEnabled || trackIndex != 1 || __result == null || !InBattle) return;
        var scale = EffectScale();
        if (scale > 1f) __result.TimeScale = scale;
    }

    // ---- Projectile / wave timing --------------------------------------------------------------

    // The game dampens the scale for projectile travel and several waits (Half = scale*0.5+0.5,
    // Third = scale*0.33+0.67), so at 20x they run ~10x/~7x. Use the full scale instead.
    // [GameCoupled BattleController.GetHalfBattleTimeScale logic] dampened-scale formula; callers assume it is <= battleTimeScale
    [HarmonyPatch(typeof(BattleController), nameof(BattleController.GetHalfBattleTimeScale))]
    [HarmonyPostfix]
    private static void GetHalfBattleTimeScale_Postfix(ref float __result) => UseFullScale(ref __result);

    // [GameCoupled BattleController.GetThirdBattleTimeScale logic] dampened-scale formula; callers assume it is <= battleTimeScale
    [HarmonyPatch(typeof(BattleController), nameof(BattleController.GetThirdBattleTimeScale))]
    [HarmonyPostfix]
    private static void GetThirdBattleTimeScale_Postfix(ref float __result) => UseFullScale(ref __result);

    private static void UseFullScale(ref float result)
    {
        if (!_fixEnabled || !InBattle) return;
        var scale = BattleScale;
        if (scale > result) result = scale;
    }

    // Projectile tweens in BattleUnitAttackHappen mix a scaled term (base / scale) with an UNSCALED
    // one (e.g. (distance - base) * 0.2), so at high speed a fixed real-time delay dominates (the
    // pause between rows of an area skill). Rescaling would double-scale the fast part, so clamp
    // instead. Scope: DOLocalMove on objects spawned via AddChild during battle, and the 0 -> 1
    // progress tween (DOTween.To) used by path projectiles.
    // [GameCoupled BattleController.BattleUnitAttackHappen logic] projectile tween durations and the 0->1 progress tween shape
    private static void PatchTweenDurations(Harmony harmony)
    {
        try
        {
            var move = typeof(DG.Tweening.ShortcutExtensions).GetMethod(
                "DOLocalMove", new[] { typeof(Transform), typeof(Vector3), typeof(float), typeof(bool) });
            if (move != null)
                harmony.Patch(move, prefix: new HarmonyMethod(typeof(BattleSpeedPatches), nameof(DOLocalMove_Prefix)));
            else
                MainPlugin.Logger.LogWarning("[BattleSpeedPatches] ShortcutExtensions.DOLocalMove(Transform,Vector3,float,bool) not found.");

            foreach (var m in typeof(DG.Tweening.DOTween).GetMethods())
            {
                if (m.Name != "To" || m.IsGenericMethodDefinition) continue;
                var ps = m.GetParameters();
                if (ps.Length == 4 && ps[0].ParameterType.Name.StartsWith("DOSetter")
                    && ps[1].ParameterType == typeof(float) && ps[2].ParameterType == typeof(float) && ps[3].ParameterType == typeof(float))
                {
                    harmony.Patch(m, prefix: new HarmonyMethod(typeof(BattleSpeedPatches), nameof(DOTweenTo_Prefix)));
                }
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleSpeedPatches] PatchTweenDurations failed: {ex}");
        }
    }

    private static float ClampTween(float duration)
    {
        if (!_fixEnabled || !InBattle) return duration;
        var scale = BattleScale;
        if (scale <= 1f) return duration;
        return Math.Min(duration, Math.Max(TweenBudgetSeconds / scale, 0.02f));
    }

    private static void DOLocalMove_Prefix(Transform target, ref float duration)
    {
        if (target == null || !_seenEffects.Contains(target.gameObject.GetInstanceID())) return;
        duration = ClampTween(duration);
    }

    private static void DOTweenTo_Prefix(float startValue, float endValue, ref float duration)
    {
        if (startValue != 0f || endValue != 1f) return;
        duration = ClampTween(duration);
    }
}
