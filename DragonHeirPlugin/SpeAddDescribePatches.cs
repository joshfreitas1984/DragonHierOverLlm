using System;
using System.Text.RegularExpressions;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// HeroSpeAddDataBase.GetDescribe() concatenates "[我]"/"[敌]"/"[叠]" colour tags directly onto the
/// next piece with no separator (CJK wraps between any characters). Once translated, e.g.
/// "[Stack]Deals damage...", the tag glues to the following word and the line can't word-wrap.
/// Insert a space after any "[tag]</color>" that is immediately followed by non-whitespace.
/// Matches structurally (not on tag text) so it works whether or not the literal was already
/// translated when the method returns.
/// </summary>
internal static class SpeAddDescribePatches
{
    private static readonly Regex TagGlue = new(@"(\[[^\]<]*\]</color>)(?=\S)", RegexOptions.Compiled);

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.SpeAddDescribePatches");
            harmony.PatchAll(typeof(SpeAddDescribePatches));
            MainPlugin.Logger.LogInfo("[SpeAddDescribePatches] Patched HeroSpeAddDataBase.GetDescribe.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[SpeAddDescribePatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(HeroSpeAddDataBase), nameof(HeroSpeAddDataBase.GetDescribe))]
    [HarmonyPostfix]
    private static void GetDescribePostfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result)) return;
            __result = TagGlue.Replace(__result, "$1 ");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[SpeAddDescribePatches] GetDescribe postfix failed: {ex}");
        }
    }
}
