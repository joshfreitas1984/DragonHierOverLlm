using System;
using HarmonyLib;

namespace EnglishPatch;

// callParam reverse-translate: PlotData.csv column 9's "{0};RobHeroItemChoose;{1}" template (see
// docs/gamefilehandling-reference.md) translates {1} (a hero name, e.g. "高首" -> "High Lord")
// like any other display fragment, but RobHeroItemChoose(string) looks the target hero up by its
// original Chinese name, so the translated param never matches and the button silently does
// nothing (same root cause as ItemIconPatches' icon-name lookup).
// Fixed with an unconditional prefix that reverse-translates choiceData.callParam in place (via
// DynamicStringPatches.ReverseTranslate - a no-op for any callFuc whose param was never in the
// translation dictionary) before EITHER the native body or the no-cost Postfix below reads it.internal static class PlotInteractControllerPatches
internal static class PlotInteractControllerPatches
{
    [HarmonyPatch(typeof(PlotInteractController), nameof(PlotInteractController.OnClick))]
    [HarmonyPrefix]
    private static void OnClick_Prefix(PlotInteractController __instance)
    {
        try
        {
            var choiceData = __instance?.choiceData;
            if (choiceData == null || string.IsNullOrEmpty(choiceData.callParam)) return;

            choiceData.callParam = DynamicStringPatches.ReverseTranslate(choiceData.callParam);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] OnClick_Prefix failed: {ex}");
        }
    }

    // See the callParam translation note at the top of this file. Centralized here (rather than on
    // RobHeroItemChoose/RobHeroItemChoosen themselves) so every call site that looks a hero up by
    // its translated display name gets fixed at once, not just these two.
    //
    // Needs the ORIGINAL name tried first (a hero name can legitimately already be untranslated
    // ASCII in the game files) with the reverse-translated raw name only as a fallback on a genuine
    // miss - so this must call __instance.GetHero(...) again itself. That re-enters this same
    // Harmony-patched method, so _inGetHeroPrefix guards against infinite recursion: the nested
    // call sees the guard set and just lets the original method run untouched.
    [ThreadStatic]
    private static bool _inGetHeroPrefix;

    [HarmonyPatch(typeof(WorldData), nameof(WorldData.GetHero), new[] { typeof(string) })]
    [HarmonyPrefix]
    private static bool GetHero_Prefix(WorldData __instance, string heroName, ref HeroData __result)
    {
        if (_inGetHeroPrefix) return true;

        try
        {
            _inGetHeroPrefix = true;

            __result = __instance.GetHero(heroName);
            if (__result != null) return false;

            // Reverse-translate via HeroNamePatches' dedicated heroFullNames.txt.yaml dictionary
            // (Result -> Raw) - a no-op (returns heroName unchanged) if it was never a known
            // translated full name.
            var rawName = HeroNamePatches.ReverseTranslateFullName(heroName);

            if (rawName != heroName)
                __result = __instance.GetHero(rawName);

            // heroName can also arrive as the raw "Family.Given" CSV value (with the "." still in
            // it, e.g. "姜.映泉") - HeroData.heroName has the "." stripped at load time (see
            // HeroNamePatches.cs), so the native lookup never matches until it's stripped here too.
            if (__result == null && heroName.Contains('.'))
                __result = __instance.GetHero(heroName.Replace(".", string.Empty));

            return false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] GetHero_Prefix failed: {ex}");
            return true;
        }
        finally
        {
            _inGetHeroPrefix = false;
        }
    }
}
