using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Fixes broken item icons for Food, Medicine, and unsaddled Horse items (confirmed 2026-08-30 -
/// see chat/log capture: `ItemData.GetItemIconName` returning `name='Coptis Root Pill' ->
/// iconName='Coptis Root Pill'`, followed by
/// `TextureController.LoadAtlasSprite(atlasPath='IconAtlas', spriteName='Coptis Root Pill') ->
/// resolved=False`).
///
/// Root cause: `ItemData.GetItemIconName()` (Converter/output/_NoNamespace/ItemData.cs) builds a
/// purely numeric/id-based sprite key for every item type EXCEPT three: Food (type 1), Medicine
/// (type 2), and Horse without a saddle (type 6, default/subType != 1 branch) - those three fall
/// through to `return this.name;`, using the item's raw Chinese display name itself as the
/// "IconAtlas" lookup key. That's fine as long as `this.name` is still the original raw Chinese -
/// but MedData.csv/FoodData.csv/HorseData.csv's name column (column 1) is ALSO captured via
/// Tests/GameFileHandling.cs's `DynamicStringColumnSources` so the player sees a translated name
/// in the UI, producing a `raw: "补血丹" -> result: "Coptis Root Pill"`-style entry in
/// Files/Mod/dynamicStringsFromColumns.txt.yaml. DynamicStringPatches.cs's global
/// String.Concat/Format postfix applies that dictionary to ANY patched call's result, including
/// whatever internal call the game's own CSV-row loader uses to build/intern `this.name` when
/// populating an ItemData from its data-table row - so by the time `GetItemIconName()` runs,
/// `this.name` has already been substring-replaced into English, and "IconAtlas" has no sprite
/// keyed by the English text (it was only ever built with the original Chinese names).
///
/// Fix: reverse-translate the icon name back to the original raw Chinese immediately after
/// `GetItemIconName()` returns, via DynamicStringPatches.ReverseTranslate (a Result -> Raw lookup
/// built from the same dictionary). Only relevant for the three affected types - every other
/// item type's icon name is already numeric/id-based and was never touched by the translation
/// dictionary in the first place, so this postfix is a no-op for them (ReverseTranslate returns
/// the input unchanged when there's no exact dictionary match).
///
/// IL2CPP interop safety: `ItemData`/`ItemType` are plain interop wrapper/enum types accessed via
/// ordinary field reads (no generic Cast&lt;T&gt;/TryCast&lt;T&gt; calls) - matches the
/// confirmed-safe patterns in dragonheirplugin.instructions.md.
/// </summary>
internal static class ItemIconPatches
{
    [HarmonyPatch(typeof(ItemData), nameof(ItemData.GetItemIconName))]
    [HarmonyPostfix]
    private static void GetItemIconName_Postfix(ItemData __instance, ref string __result)
    {
        if (__instance == null || string.IsNullOrEmpty(__result))
            return;

        // Only Food (1), Medicine (2), and Horse-without-saddle (6, subType != 1) use the raw
        // display name as the icon key - see class remarks. Every other type's key is already
        // numeric/id-based and must be left untouched.
        var type = (int)__instance.type;
        var isNameBasedIconType = type == 1 || type == 2 || (type == 6 && __instance.subType != 1);
        if (!isNameBasedIconType)
            return;

        __result = DynamicStringPatches.ReverseTranslate(__result);
    }
}
