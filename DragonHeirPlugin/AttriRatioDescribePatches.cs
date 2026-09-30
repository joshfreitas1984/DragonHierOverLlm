using System;
using System.Text.RegularExpressions;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// AttriNumData.GetDamageRatioDescribe() builds the stat-bonus block of a kungfu skill's
/// description (KungfuSkillLvData.GetSkillDescribe, under the damage/healing bonus heading) as
/// "{name}{grade}{sep}{name}{grade}...". Only the grade is wrapped in a colour tag
/// (GlobalData.GenerateRareLvColorText); the separator is " " or "\n" (every third entry), which
/// in English reads as a cramped run-on. Put each stat on its own line instead.
/// The method returns only this block, so every separator after a closing colour tag is ours to
/// rewrite; matching is structural so it doesn't depend on the separator literal.
/// </summary>
internal static class AttriRatioDescribePatches
{
    private static readonly Regex EntrySeparator = new(@"(</color>)[ \u3000|\uFF5C\r\n]+(?=\S)", RegexOptions.Compiled);

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.AttriRatioDescribePatches");
            harmony.PatchAll(typeof(AttriRatioDescribePatches));
            MainPlugin.Logger.LogInfo("[AttriRatioDescribePatches] Patched AttriNumData.GetDamageRatioDescribe.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[AttriRatioDescribePatches] PatchAll failed: {ex}");
        }
    }

    // [GameCoupled AttriNumData.GetDamageRatioDescribe] result-string postfix
    [HarmonyPatch(typeof(AttriNumData), nameof(AttriNumData.GetDamageRatioDescribe))]
    [HarmonyPostfix]
    private static void GetDamageRatioDescribePostfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result)) return;

            __result = EntrySeparator.Replace(__result, "$1\n");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[AttriRatioDescribePatches] GetDamageRatioDescribe postfix failed: {ex}");
        }
    }
}