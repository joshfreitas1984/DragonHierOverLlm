using System;
using DG.Tweening;
using HarmonyLib;
using UnityEngine.UI;

namespace EnglishPatch;

// PlotController's dialogue box ("Canvas/PlotPanel/PlotTextBack/PlotText") reveals its text via
// DOTweenModuleUI.DOText(Text target, string endValue, float duration, bool richTextEnabled,
// ScrambleMode scrambleMode, string scrambleChars) - PlotText is a legacy UnityEngine.UI.Text
// component here, not TMP_Text (confirmed via raw metadata dump of Assembly-CSharp.dll's
// DOTweenModuleUI.DOText overload; parameter names above also confirmed via that same dump) -
// which tweens the Text.text setter toward endValue over `duration` seconds. Left unpatched, this
// both re-runs DynamicStringPatches' full translate pipeline on every tween step (perf) and shows
// a visibly garbled partial-CJK/partial-English string mid-reveal, since a growing raw-CJK prefix
// rarely lines up with a dictionary/template match boundary (translation quality). Confirmed via
// Converter/output/_NoNamespace/PlotController.cs's "PlotTextDoText"-tagged DOText call.
//
// MainPlugin.PreTranslatePlotTextEnabled (off by default until verified live) has DOText_Prefix
// translate `endValue` up front via DynamicStringPatches.RunGenericPipeline and seed the target
// Text's cached translated snapshot (DynamicStringPatches.SeedComponentTranslatedSnapshot), so the
// tween reveals already-translated text throughout instead of raw Chinese - fixing both the perf
// and garbling problems above at the source, rather than mitigating them at the sink (see
// MainPlugin.SpeedUpPlotTextTypewriterEnabled for the older, still-available sink-side mitigation
// of just shrinking the tween duration to make the reveal near-instant).
internal static class PlotTextPatches
{
    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    [HarmonyPatch(typeof(DOTweenModuleUI), nameof(DOTweenModuleUI.DOText),
        new[] { typeof(Text), typeof(string), typeof(float), typeof(bool), typeof(ScrambleMode), typeof(string) })]
    [HarmonyPrefix]
    private static void DOText_Prefix(Text target, ref string endValue, ref float duration)
    {
        if (MainPlugin.SpeedUpPlotTextTypewriterEnabled?.Value == true)
        {
            try
            {
                // Shrinking (not zeroing) the duration keeps this a real, still-completing tween,
                // so every chained .SetEase()/.OnComplete()/.SetId()/.SetUpdate() call at the
                // call site still attaches normally and OnComplete still fires - just almost
                // immediately, instead of skipping/replacing the tween outright.
                duration = Math.Min(duration, 0.01f);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogError($"[PlotTextPatches] DOText_Prefix duration shrink failed: {ex}");
            }
        }

        if (MainPlugin.PreTranslatePlotTextEnabled?.Value == true)
        {
            try
            {
                // Translate the WHOLE final string up front, before DOTween ever starts revealing
                // growing substrings of it via the Text.text setter - this both avoids the
                // per-tween-step retranslation cost (DynamicStringPatches' setter postfix would
                // otherwise re-run the full pipeline on every revealed character) and the garbled
                // mid-reveal partial-CJK/partial-English text described in the class comment
                // above, since the tween now reveals already-translated text throughout.
                if (!string.IsNullOrEmpty(endValue) && DynamicStringPatches.ContainsCjk(endValue))
                {
                    var translated = DynamicStringPatches.RunGenericPipeline(endValue);
                    if (translated != endValue)
                    {
                        endValue = translated;
                        DynamicStringPatches.SeedComponentTranslatedSnapshot(target, translated);
                    }
                }
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogError($"[PlotTextPatches] DOText_Prefix pre-translate failed: {ex}");
            }
        }
    }
}
