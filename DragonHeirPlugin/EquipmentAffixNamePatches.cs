using System;
using System.Collections.Generic;
using HarmonyLib;

namespace EnglishPatch;

// Equipment affix prefixes run together in the item tooltip header ("Great forcePowerlessIron
// Sword"). EquipmentData.GetExtraAddName natively concatenates up to two affix words - each
// HeroSpeAddDataBase.positiveName or negativeName (SpeAddDataBase.csv's 正面词缀/负面词缀 columns,
// translated in the packaged CSV) - with no separator, and QuickDetail.ShowEquipmentQuickDetail
// then concatenates that straight onto ItemData.Name. Both joins happen in native IL2CPP code, and
// every part is already English, so nothing downstream ever inserts the space (the text-setter
// pipeline's word-boundary spacing only applies where it replaces CJK).
//
// Fix: postfix GetExtraAddName and re-split its result into the known affix words (the set of all
// positiveName/negativeName values in the live GameDataController.speAddDataBase, which is what
// the native method reads), join them with a space, and append a trailing space so the tooltip's
// own name concatenation is separated too. Re-splitting instead of re-implementing the native
// selection loop keeps the game's own choice/order of affixes; a split is only applied when it is
// unambiguous (checked against the shipped data: no pair of affixes concatenates ambiguously), and
// anything unrecognized is left untouched apart from the trailing separator.
internal static class EquipmentAffixNamePatches
{
    private static HashSet<string> _affixes;

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.EquipmentAffixNamePatches");
            harmony.PatchAll(typeof(EquipmentAffixNamePatches));
            MainPlugin.Logger.LogInfo("[EquipmentAffixNamePatches] Patched EquipmentData.GetExtraAddName.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[EquipmentAffixNamePatches] PatchAll failed: {ex}");
        }
    }

    // [GameCoupled EquipmentData.GetExtraAddName logic] result is up to two positiveName/negativeName affixes concatenated with no separator
    // [GameCoupled QuickDetail.ShowEquipmentQuickDetail logic] concatenates GetExtraAddName() directly onto ItemData.Name, its only caller
    [HarmonyPatch(typeof(EquipmentData), nameof(EquipmentData.GetExtraAddName))]
    [HarmonyPostfix]
    private static void GetExtraAddName_Postfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result)) return;

            var affixes = GetAffixes();
            var spaced = affixes != null ? SplitAffixes(__result, affixes) : __result;

            // Separates the affixes from the item name QuickDetail appends next. Skipped if the
            // game data ever ends an affix with whitespace itself.
            __result = char.IsWhiteSpace(spaced[^1]) ? spaced : spaced + " ";
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[EquipmentAffixNamePatches] GetExtraAddName postfix failed: {ex}");
        }
    }

    // "AB" -> "A B" when the whole string is exactly two known affixes split at one unique point;
    // a single known affix, or anything not exactly two known affixes, comes back unchanged.
    private static string SplitAffixes(string combined, HashSet<string> affixes)
    {
        if (affixes.Contains(combined)) return combined;

        var splitAt = -1;
        for (var k = 1; k < combined.Length; k++)
        {
            if (!affixes.Contains(combined.Substring(0, k)) || !affixes.Contains(combined.Substring(k))) continue;
            if (splitAt >= 0) return combined; // ambiguous - leave as the game built it
            splitAt = k;
        }

        return splitAt < 0 ? combined : combined.Substring(0, splitAt) + " " + combined.Substring(splitAt);
    }

    // Built once from the live table (the same data GetExtraAddName reads); retried on later calls
    // while the table isn't loaded yet.
    private static HashSet<string> GetAffixes()
    {
        if (_affixes != null) return _affixes;

        var table = GameDataController.Instance?.speAddDataBase;
        if (table == null || table.Count == 0) return null;

        var affixes = new HashSet<string>(StringComparer.Ordinal);
        for (var i = 0; i < table.Count; i++)
        {
            var entry = table[i];
            if (entry == null) continue;
            if (!string.IsNullOrEmpty(entry.positiveName)) affixes.Add(entry.positiveName);
            if (!string.IsNullOrEmpty(entry.negativeName)) affixes.Add(entry.negativeName);
        }

        _affixes = affixes;
        MainPlugin.Logger.LogInfo($"[EquipmentAffixNamePatches] Loaded {affixes.Count} equipment affix name(s).");
        return _affixes;
    }
}
