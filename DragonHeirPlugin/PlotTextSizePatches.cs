using System;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishPatch;

// Real fix + manual test harness for "Canvas/PlotPanel/PlotTextBack/PlotText grows past screen
// size". See docs/plottextsizepatches-agent-reference.md for the full investigation and
// rationale. Root cause: PlotText sits under a VerticalLayoutGroup (on PlotTextBack) that does not
// control child width, so every layout rebuild sizes PlotText's RectTransform to
// Text.preferredWidth - wide enough to render the whole string on ONE line, uncapped.
// PlotTextBack's own background never grows to match. English translations run far longer than
// the original Chinese, so preferredWidth routinely blows past the screen.
//
// An earlier version of this fix clamped RectTransform.sizeDelta directly (in the setter itself).
// That clamped the final SIZE correctly, but VerticalLayoutGroup had already used the original,
// uncapped preferredWidth to calculate the child's aligned POSITION before that size was ever
// written - so position and size disagreed, and the box visibly drifted to the wrong spot instead
// of converging. Clamping Text.preferredWidth itself instead means the layout group's position AND
// size math both use the same corrected number from the start, so they stay consistent.
internal static class PlotTextSizePatches
{
    [HarmonyPatch(typeof(Text), nameof(Text.preferredWidth), MethodType.Getter)]
    [HarmonyPostfix]
    private static void ClampPreferredWidth_Postfix(Text __instance, ref float __result)
    {
        if (!MainPlugin.ClampPlotTextWidthEnabledCached) return;
        if (__instance == null || __instance.name != "PlotText") return;
        var plotTextBackTransform = __instance.transform.parent;
        if (plotTextBackTransform == null || plotTextBackTransform.name != "PlotTextBack") return;

        // PlotController.ShowSinglePlot sets pivot on PlotTextBack (the parent), never on PlotText
        // itself - PlotText's own pivot stays a constant (0.5, 0.5) regardless of speaker. The
        // neutral/narrator branch pivots PlotTextBack at (0.5, 0.5) (grows symmetrically from
        // screen-center in both directions), while both real speaker branches pivot it at
        // (0, 0.5) (grows one-directionally from an off-center anchor, hitting the screen edge
        // much sooner). A flat guessed max width kept being wrong in one direction or the other
        // (300 too tight, 600/700 overflowing) - compute the real safe width from the canvas's
        // own size and PlotTextBack's actual anchor offset instead of guessing.
        var plotTextBack = plotTextBackTransform.GetComponent<RectTransform>();
        var parentPivotX = plotTextBack?.pivot.x ?? 0f;
        var isCentered = Mathf.Approximately(parentPivotX, 0.5f);

        var maxWidth = ComputeSafeMaxWidth(plotTextBack, isCentered, out var debugInfo);
        if (__result <= maxWidth) return;

        MainPlugin.Logger?.LogInfo(
            $"PlotTextSizePatches: clamping PlotText.preferredWidth {__result} -> {maxWidth} (isCentered={isCentered}, alignment={__instance.alignment}, PlotTextBack.localScale.x={plotTextBackTransform.localScale.x}, {debugInfo})");

        __result = maxWidth;
    }

    // Derives the true safe max width from the canvas's own reference-resolution width and
    // PlotTextBack's real anchoredPosition, instead of a hand-guessed constant - PlotPanel fills
    // the canvas exactly (confirmed via DiagnosticPatches' hierarchy dump: PlotPanel size ==
    // canvas reference resolution, both centered at the same origin), and PlotTextBack anchors at
    // canvas-center (0.5, 0.5), so its anchoredPosition.x IS its offset from screen-center in the
    // same local units as the canvas's own rect. Falls back to the old flat config values if
    // anything here can't be resolved (e.g. no Canvas ancestor found).
    private static float ComputeSafeMaxWidth(RectTransform plotTextBack, bool isCentered, out string debugInfo)
    {
        try
        {
            if (plotTextBack == null) throw new InvalidOperationException("PlotTextBack RectTransform is null");

            Canvas canvas = null;
            for (var t = plotTextBack.transform; t != null && canvas == null; t = t.parent)
                canvas = t.GetComponent<Canvas>();
            var canvasRect = canvas?.GetComponent<RectTransform>();
            if (canvasRect == null) throw new InvalidOperationException("no Canvas ancestor found");

            var canvasWidth = canvasRect.rect.width;
            var margin = MainPlugin.PlotTextWidthMargin?.Value ?? 150f;
            var anchoredX = plotTextBack.anchoredPosition.x;

            if (isCentered)
            {
                var centeredWidth = Mathf.Max(50f, canvasWidth - margin * 2f);
                debugInfo = $"canvasWidth={canvasWidth}, anchoredX={anchoredX}, margin={margin}";
                return centeredWidth;
            }

            // Confirmed empirically (in-game observation): the box grows TOWARD screen-center and
            // past it, not away from it - a left speaker's bubble grows rightward (toward/past
            // center), a right speaker's grows leftward (toward/past center). So the relevant
            // constraint is the distance from the anchor across to the OPPOSITE edge (halfCanvas
            // + |anchoredX|), not the near edge.
            var halfCanvas = canvasWidth / 2f;
            var roomToEdge = halfCanvas + Mathf.Abs(anchoredX);
            var width = Mathf.Max(50f, roomToEdge - margin);
            debugInfo = $"canvasWidth={canvasWidth}, halfCanvas={halfCanvas}, anchoredX={anchoredX}, roomToEdge={roomToEdge}, margin={margin}";
            return width;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogWarning($"PlotTextSizePatches: ComputeSafeMaxWidth failed, falling back to flat config value: {ex.Message}");
            debugInfo = $"fallback: {ex.Message}";
            return isCentered
                ? MainPlugin.PlotTextMaxWidthCentered?.Value ?? 900f
                : MainPlugin.PlotTextMaxWidth?.Value ?? 300f;
        }
    }

    // Cached so the test hotkey below can reach the live PlotText without a generic
    // FindObjectOfType<T> call from a cold start - ShowSinglePlot/PlotTextShowFinished are already
    // proven-safe Harmony targets, so just remember the instance here.
    private static PlotController _lastPlotController;

    [HarmonyPatch(typeof(PlotController), nameof(PlotController.ShowSinglePlot))]
    [HarmonyPostfix]
    private static void CachePlotController_ShowSinglePlot(PlotController __instance) =>
        _lastPlotController = __instance;

    [HarmonyPatch(typeof(PlotController), nameof(PlotController.PlotTextShowFinished))]
    [HarmonyPostfix]
    private static void CachePlotController_PlotTextShowFinished(PlotController __instance) =>
        _lastPlotController = __instance;

    // Deliberately long, newline-free, no-CJK stress string: forces the same single-line
    // preferredWidth blowup as a long English translation, without needing to find or trigger a
    // specific long dialogue in the game's own data.
    private const string TestString =
        "This is a deliberately long test sentence with no manual line breaks, used only to " +
        "verify that PlotText wraps or clamps correctly instead of growing past the edges of " +
        "the screen when the translated dialogue runs much longer than the original text.";

    // Same once-per-frame tick pattern as FanslationStudio.Plugins.TextResizerPlugin
    // (G:\FanslationStudio.Plugins\...\TextResizerPlugin.cs): BasePlugin never gets a real
    // Update() call, and AddComponent<T>/ClassInjector.RegisterTypeInIl2Cpp<T> crash with an
    // AccessViolationException in this game's IL2CPP build. Time.deltaTime is read every frame by
    // ordinary game code, so patching its getter (a concrete, non-generic method) gives a safe
    // tick without any generic interop call.
    //
    // TRIED AND REVERTED: subscribing to Canvas.willRenderCanvases (a genuine once-per-frame C#
    // event) instead, via Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate, to avoid the
    // Time.deltaTime getter being hit many times per frame by ordinary game systems. That crashed
    // the whole process with a native AccessViolationException inside
    // Il2CppInterop's GenericMethod_GetMethod_Hook during ConvertDelegate itself, at plugin load -
    // a hard native crash, not a catchable managed exception, so the try/catch fallback this class
    // briefly had around it never got a chance to run. Do not retry DelegateSupport.ConvertDelegate
    // for this without confirming it works in this specific game build first.
    private static int _lastTickedFrame = -1;

    [HarmonyPatch(typeof(Time), nameof(Time.deltaTime), MethodType.Getter)]
    [HarmonyPostfix]
    private static void OnDeltaTimeRead_Postfix()
    {
        var frame = Time.frameCount;
        if (frame == _lastTickedFrame) return;
        _lastTickedFrame = frame;

        // Piggybacks on this same safe once-per-frame tick - see PerfInstrumentation for why.
        PerfInstrumentation.PeriodicTick();

        if (MainPlugin.ForceTestPlotTextHotkey != null)
            RunHotkeyCheck();

        if (MainPlugin.ClearTranslationCachesHotkey != null)
            RunClearTranslationCachesHotkeyCheck();
    }

    private static void RunClearTranslationCachesHotkeyCheck()
    {
        if (MainPlugin.ClearTranslationCachesHotkey == null) return;

        try
        {
            if (!MainPlugin.ClearTranslationCachesHotkey.Value.IsDown()) return;
            DynamicStringPatches.ClearTranslationCaches();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PlotTextSizePatches: ClearTranslationCachesHotkey check failed: {ex}");
        }
    }

    private static void RunHotkeyCheck()
    {
        if (MainPlugin.ForceTestPlotTextHotkey == null) return;

        try
        {
            if (!MainPlugin.ForceTestPlotTextHotkey.Value.IsDown()) return;

            var plotPanel = _lastPlotController?.plotPanel;
            if (plotPanel == null)
            {
                MainPlugin.Logger?.LogWarning(
                    "PlotTextSizePatches: no cached PlotController yet - open any plot dialogue once first, then press the hotkey again.");
                return;
            }

            var textTransform = plotPanel.transform.Find("PlotTextBack")?.Find("PlotText");
            var text = textTransform?.GetComponent<Text>();
            if (text == null)
            {
                MainPlugin.Logger?.LogWarning("PlotTextSizePatches: PlotTextBack/PlotText not found under the cached plotPanel.");
                return;
            }

            text.text = TestString;
            MainPlugin.Logger?.LogInfo("PlotTextSizePatches: forced test string into PlotText.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PlotTextSizePatches: RunHotkeyCheck failed: {ex}");
        }
    }
}
