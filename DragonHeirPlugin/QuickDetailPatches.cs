using System;
using System.Text.RegularExpressions;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// HeroData.GetQuickDetail() (the shift-hover character tooltip, shown from
/// QuickDetail.ShowHeroQuickDetail) lists the hero's attributes as "{name}{grade}" pairs, where
/// only the grade is wrapped in a colour tag (GlobalData.GenerateRareLvColorText). The separator
/// before each pair alternates by index: odd entries get a "|" and even entries a "\n", i.e. two
/// stats per line. In English that renders as a cramped "Strength Divine|Agility Refined" that
/// wraps at arbitrary spaces. Turn the "|" into a newline so each stat sits on its own line.
/// Only a "|" directly after a closing colour tag is touched, so the rest of the tooltip is left alone.
/// The block's hard-coded "<size=15>" wrapper is also removed so it matches the tooltip's own text size.
/// </summary>
internal static class QuickDetailPatches
{
    // The game wraps the whole attribute/skill grade block in a hard-coded "<size=15>...</size>",
    // which is larger than the tooltip's own (resized) default once translated to English. Unwrap
    // it so the block matches the surrounding lines. Only spans containing colour-tagged grades
    // are unwrapped; any other size-15 span in the tooltip is left as the game wrote it.
    private static readonly Regex StatBlockSize = new(@"<size=15>(.*?)</size>", RegexOptions.Compiled | RegexOptions.Singleline);

    private static readonly Regex PairSeparator = new(@"(</color>)[|\uFF5C](?=\S)", RegexOptions.Compiled);

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.QuickDetailPatches");
            harmony.PatchAll(typeof(QuickDetailPatches));
            MainPlugin.Logger.LogInfo("[QuickDetailPatches] Patched HeroData.GetQuickDetail.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[QuickDetailPatches] PatchAll failed: {ex}");
        }
    }

    // [GameCoupled HeroData.GetQuickDetail] result-string postfix
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetQuickDetail))]
    [HarmonyPostfix]
    private static void GetQuickDetailPostfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result)) return;

            __result = PairSeparator.Replace(__result, "$1\n");
            __result = StatBlockSize.Replace(__result, m => m.Groups[1].Value.Contains("</color>") ? m.Groups[1].Value : m.Value);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[QuickDetailPatches] GetQuickDetail postfix failed: {ex}");
        }
    }
}
