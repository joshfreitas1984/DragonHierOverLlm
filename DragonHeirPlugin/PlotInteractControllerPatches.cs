using System;
using HarmonyLib;

namespace EnglishPatch;

internal static class PlotInteractControllerPatches
{
    // Centralized here (rather than on RobHeroItemChoose/RobHeroItemChoosen themselves) so every
    // call site that looks a hero up by its translated display name gets fixed at once, not just
    // these two.
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

            //MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] GetHero_Prefix yo: {heroName}");
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
