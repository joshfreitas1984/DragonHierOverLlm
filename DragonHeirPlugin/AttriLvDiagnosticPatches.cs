using System;
using HarmonyLib;
using UnityEngine;
using UnityEngine.UI;

namespace EnglishPatch;

/// <summary>
/// Diagnostic for the Canvas/HeroDetailPanel/Attri/Attris/*/Lv tier labels (e.g. "上"/"中"/"下").
/// The PlotController.Instance-reflection approach (see git history) hit the documented
/// field-resolution gap (Converter's 3d/3e passes can't name every hoisted-singleton instance
/// field offset - Converter/docs/field-resolution-hoisted-singleton-gap.md) and never found the
/// backing list. Better hook point found by tracing HeroDetailController.SetAttriDetail's
/// pseudocode one level further: it always renders through
/// `LTLocalization.SetText(Text targetText, string targetValue)`
/// (Converter/output/_NoNamespace/LTLocalization.cs) - which hands us the ACTUAL UI Text
/// component (so we can key a translation off the widget's hierarchy path, not the raw string
/// value) before the raw CJK value even reaches DynamicStringPatches' generic
/// LTLocalization.GetText dictionary/template pipeline. This patch just logs every SetText call
/// whose value is short + CJK, capturing the full GameObject path, so any prefix/postfix
/// translation patch can target the exact widget instead of relying on ambiguous short-string
/// matching. Remove once all such tier-label widgets are identified and a permanent per-path
/// translation patch is written.
/// </summary>
internal static class AttriLvDiagnosticPatches
{
    [HarmonyPatch(typeof(LTLocalization), nameof(LTLocalization.SetText), new[] { typeof(Text), typeof(string) })]
    [HarmonyPrefix]
    private static void SetText_Prefix(Text targetText, string targetValue)
    {
        try
        {
            if (targetText == null || string.IsNullOrEmpty(targetValue) || targetValue.Length > 2) return;
            if (!System.Text.RegularExpressions.Regex.IsMatch(targetValue, @"\p{IsCJKUnifiedIdeographs}")) return;

            MainPlugin.Logger?.LogInfo($"AttriLvDiagnostic: SetText(\"{targetValue}\") on path {GetPath(targetText.transform)}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"AttriLvDiagnostic: failed: {ex}");
        }
    }

    private static string GetPath(Transform t)
    {
        var parts = new System.Collections.Generic.List<string>();
        while (t != null)
        {
            parts.Insert(0, t.name);
            t = t.parent;
        }
        return string.Join("/", parts);
    }
}

