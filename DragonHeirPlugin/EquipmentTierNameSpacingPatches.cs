using System;
using HarmonyLib;

namespace EnglishPatch;

// Equipment names like "PeerlessHood"/"PeerlessSneakers". GameController.GenerateArmor/
// GenerateHelmet/GenerateShoes/GenerateWeapon clone the template item and store
// `name = GlobalData.EquipLvName[itemLv] + template.name` natively, with no separator, on the new
// ItemData - which is then persisted in the save. Once GlobalDataListOverrides makes EquipLvName
// English and the base name is English too (ArmorData.csv ships translated), that native join
// bakes "PeerlessHood" into the save; nothing downstream inserts the space, because the
// text-setter pipeline only spaces around CJK it replaces. (Weapon base names and decoration type
// names stay Chinese at that point, so those still come out spaced at display time.)
//
// Display-time fix, like HeroNamePatches.HeroNamePostfix: ItemData.Name's result gets a space
// after a leading EquipLvName tier word when the next character is an uppercase letter. This also
// repairs items already in existing saves; the stored name field is never modified. The
// uppercase check keeps it to the glued case only (every packaged ArmorData base name starts
// uppercase, and none starts with a tier word).
internal static class EquipmentTierNameSpacingPatches
{
    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.EquipmentTierNameSpacingPatches");
            harmony.PatchAll(typeof(EquipmentTierNameSpacingPatches));
            MainPlugin.Logger.LogInfo("[EquipmentTierNameSpacingPatches] Patched ItemData.Name.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[EquipmentTierNameSpacingPatches] PatchAll failed: {ex}");
        }
    }

    // [GameCoupled GameController.GenerateArmor logic] stores EquipLvName[itemLv] + template name with no separator
    // [GameCoupled ItemData.Name logic] returns that stored name (optionally wrapped in a rare-level color tag)
    [HarmonyPatch(typeof(ItemData), nameof(ItemData.Name), new[] { typeof(bool) })]
    [HarmonyPostfix]
    private static void Name_Postfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result)) return;
            __result = InsertTierSpace(__result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[EquipmentTierNameSpacingPatches] ItemData.Name postfix failed: {ex}");
        }
    }

    // Allocation-free unless it actually inserts the space - ItemData.Name is called for every
    // item shown in a list.
    private static string InsertTierSpace(string name)
    {
        // Skip a leading rich-text tag run (Name(colored: true) wraps the name in a color tag).
        var start = 0;
        while (start < name.Length && name[start] == '<')
        {
            var end = name.IndexOf('>', start);
            if (end < 0) return name;
            start = end + 1;
        }

        foreach (var tier in GlobalDataListOverrides.EquipLvNames)
        {
            var next = start + tier.Length;
            if (next >= name.Length || !char.IsUpper(name[next])) continue;
            if (string.CompareOrdinal(name, start, tier, 0, tier.Length) == 0)
                return name.Insert(next, " ");
        }
        return name;
    }
}
