using System;
using System.Collections.Generic;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Optional gameplay tweak (MainPlugin.SplitSeniorTalentGroupsEnabled). The game blocks a talent
/// when the hero owns one in the same 同义组 (sameMeaning) of equal/higher |value| - so once a hero
/// holds a Senior talent (e.g. 阴阳调和, value 10, group 内家) the base 内家/内力精纯/炉火纯青 line
/// can never be learned. For the 内家 (Neigong), 轻功 (Qinggong) and 绝技 (Special technique)
/// groups, the Senior talents (value >= 8) are moved into their own group ("<group>+") so they no
/// longer block the base line; Seniors still block each other, and the base line still blocks
/// itself. Applied lazily as HeroTagDataBase entries are looked up, and restored when toggled off.
/// </summary>
internal static class TagGroupPatches
{
    private static readonly string[] SplitGroups = { "内家", "轻功", "绝技" };
    private const int SeniorMinValue = 8;

    // tagID -> original sameMeaning, for every entry we have rewritten.
    private static readonly Dictionary<int, string> Originals = new();

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.TagGroupPatches");
            harmony.PatchAll(typeof(TagGroupPatches));
            MainPlugin.Logger.LogInfo("[TagGroupPatches] Patched GameDataController.GetTagDataBase.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[TagGroupPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(GameDataController), nameof(GameDataController.GetTagDataBase), new[] { typeof(int) })]
    [HarmonyPostfix]
    private static void GetTagDataBasePostfix(int tagID, HeroTagDataBase __result)
    {
        try
        {
            if (__result == null) return;

            var enabled = MainPlugin.SplitSeniorTalentGroupsEnabledCached;
            if (Originals.TryGetValue(tagID, out var original))
            {
                if (!enabled) { __result.sameMeaning = original; Originals.Remove(tagID); }
                return;
            }

            if (!enabled || __result.value < SeniorMinValue) return;
            var group = __result.sameMeaning;
            if (string.IsNullOrEmpty(group) || Array.IndexOf(SplitGroups, group) < 0) return;

            Originals[tagID] = group;
            __result.sameMeaning = group + "+";
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[TagGroupPatches] GetTagDataBase postfix failed: {ex}");
        }
    }
}
