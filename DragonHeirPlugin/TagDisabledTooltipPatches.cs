using System;
using System.Collections.Generic;
using HarmonyLib;
using UnityEngine.UI;

namespace EnglishPatch;

/// <summary>
/// The talent-management screen greys out (Selectable.interactable = false) any candidate talent
/// that fails ManageTagController.FreshManageTagUI's checks, with no explanation. Appends the reason
/// to the tooltip text (HeroTagIconController.GetDescribe) by mirroring those checks:
/// already owned, no free slot (unless the talent upgrades an owned one via 替换), a same-group
/// talent of equal/higher tier, an opposite-group talent, and not enough talent points. Unmet
/// stat/talent requirements are already shown in red by the base tooltip, so they are not repeated.
/// Only the in-game manage screen (TagIconType.Get) is covered; the character-creation screen
/// (StartMenuController) uses different rules and has no per-icon hero handy.
/// </summary>
internal static class TagDisabledTooltipPatches
{
    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.TagDisabledTooltipPatches");
            harmony.PatchAll(typeof(TagDisabledTooltipPatches));
            MainPlugin.Logger.LogInfo("[TagDisabledTooltipPatches] Patched HeroTagIconController.GetDescribe.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[TagDisabledTooltipPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(HeroTagIconController), nameof(HeroTagIconController.GetDescribe))]
    [HarmonyPostfix]
    private static void GetDescribePostfix(HeroTagIconController __instance, ref string __result)
    {
        try
        {
            if (__instance == null || __instance.targetTag == null) return;
            if (__instance.tagIconType != TagIconType.Get) return;

            var selectable = __instance.GetComponent<Selectable>();
            if (selectable == null || selectable.interactable) return;

            var manager = ManageTagController.Instance;
            var hero = manager?.targetHero;
            if (hero?.heroTagData == null) return;

            var reasons = GetReasons(hero, __instance.targetTag);
            if (reasons.Count == 0) return;

            __result += "\n\n<color=red>Unavailable:</color>\n" + string.Join("\n", reasons);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[TagDisabledTooltipPatches] GetDescribe postfix failed: {ex}");
        }
    }

    private static List<string> GetReasons(HeroData hero, HeroTagData candidate)
    {
        var reasons = new List<string>();
        var candidateDb = candidate.DataBase();
        if (candidateDb == null) return reasons;

        var slotsFull = hero.GetHeroPermanentTagNum() >= hero.GetMaxTagNum();
        var upgradesOwned = candidateDb.replaceTag != null && candidateDb.replaceTag.Count > 0;
        if (slotsFull && !upgradesOwned)
            reasons.Add("- No free talent slot (only talents that upgrade one you own can be learned).");

        var group = candidateDb.sameMeaning;
        for (var i = 0; i < hero.heroTagData.Count; i++)
        {
            var owned = hero.heroTagData[i];
            if (owned == null) continue;

            if (owned.tagID == candidate.tagID)
            {
                reasons.Add("- Already learned.");
                continue;
            }

            var ownedDb = owned.DataBase();
            if (ownedDb == null || string.IsNullOrEmpty(group)) continue;

            if (ownedDb.oppositeMeaning == group)
                reasons.Add($"- Conflicts with opposite talent you own: {ownedDb.name}");
            else if (ownedDb.sameMeaning == group && Math.Abs(ownedDb.value) >= Math.Abs(candidateDb.value))
                reasons.Add($"- Same talent line as {ownedDb.name} which you own.");
        }

        var cost = candidateDb.GetCostValue(false);
        if (hero.heroTagPoint < cost)
            reasons.Add($"- Not enough talent points (need {cost}).");

        return reasons;
    }
}
