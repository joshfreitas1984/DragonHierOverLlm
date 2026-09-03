using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Fixes Inn map icons not rendering (confirmed 2026-09-03 - see
/// Converter/output/_NoNamespace/InnIconController.cs's `Init()`, which calls
/// `TextureController.LoadAtlasSprite("AreaIconAtlas", this.innData.innName)` - using the Inn's
/// display name itself as the sprite lookup key, same pattern as
/// `ItemIconPatches.GetItemIconName_Postfix`.
///
/// Root cause: `innName` (InnData.csv column 1, e.g. "有间客栈") is captured by
/// Tests/GameFileHandling.cs's `DynamicStringColumnSources` for translation, so by the time
/// `InnIconController.Init()` runs, `innData.innName` has already been substring-replaced into
/// English by DynamicStringPatches. "AreaIconAtlas" has no sprite keyed by the English text - it
/// was only ever built with the original Chinese inn names - so `LoadAtlasSprite` returns null and
/// the Inn icon fails to render on the map.
///
/// Fix: patch `TextureController.LoadAtlasSprite` directly (rather than `innName` itself, which is
/// also used verbatim for player-facing text, e.g. QuickTravelInnIconController's "Confirm travel
/// to {0}?" label) and reverse-translate the `spriteName` argument back to the original raw
/// Chinese via DynamicStringPatches.ReverseTranslate immediately before the lookup runs. Safe/
/// idempotent for every other atlas sprite lookup that goes through this same method (e.g.
/// AreaIconController's `areaData.spriteName`) since ReverseTranslate only replaces on an exact
/// English-Result dictionary match and is a no-op otherwise.
/// </summary>
internal static class InnIconPatches
{
    [HarmonyPatch(typeof(TextureController), nameof(TextureController.LoadAtlasSprite))]
    [HarmonyPrefix]
    private static void LoadAtlasSprite_Prefix(ref string spriteName)
    {
        spriteName = DynamicStringPatches.ReverseTranslate(spriteName);
    }
}
