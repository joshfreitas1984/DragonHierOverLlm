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

            MainPlugin.Logger?.LogInfo(
                $"[PlotInteractControllerPatches] DIAG OnClick ENTERED callFuc={choiceData?.callFuc ?? "<null>"} " +
                $"callParam={choiceData?.callParam ?? "<null>"} costResource={(choiceData?.costResource != null ? "non-null" : "null")}");

            if (choiceData == null || string.IsNullOrEmpty(choiceData.callParam)) return;

            choiceData.callParam = DynamicStringPatches.ReverseTranslate(choiceData.callParam);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] OnClick_Prefix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(PlotInteractController), nameof(PlotInteractController.OnClick))]
    [HarmonyPostfix]
    private static void OnClick_Postfix(PlotInteractController __instance)
    {
        MainPlugin.Logger?.LogInfo($"[PlotInteractControllerPatches] DIAG OnClick_Postfix ENTERED fixNoCostEnabled={MainPlugin.FixNoCostChoiceClickEnabled?.Value}");
    }

    // See the callParam translation note at the top of this file. Centralized here (rather than on
    // RobHeroItemChoose/RobHeroItemChoosen themselves) so every call site that looks a hero up by
    // its translated display name gets fixed at once, not just these two.
    [HarmonyPatch(typeof(WorldData), nameof(WorldData.GetHero), new[] { typeof(string) })]
    [HarmonyPrefix]
    private static bool GetHero_Prefix(WorldData __instance, string heroName, ref HeroData __result)
    {
        // TEMP DIAGNOSTIC (remove once confirmed fixed): unconditional entry log, outside the try,
        // so we know for certain whether this Prefix is even being invoked at all.
        MainPlugin.Logger?.LogInfo($"[PlotInteractControllerPatches] DIAG GetHero_Prefix ENTERED heroName={heroName ?? "<null>"}");

        try
        {
            // Try normal lookup first
            __result = __instance.GetHero(heroName);

            if (__result != null)
                return false;

            // Reverse-translate via HeroNamePatches' dedicated heroFullNames.txt.yaml dictionary
            // (Result -> Raw) - a no-op (returns heroName unchanged) if it was never a known
            // translated full name.
            var rawName = HeroNamePatches.ReverseTranslateFullName(heroName);

            MainPlugin.Logger?.LogInfo(
                $"[PlotInteractControllerPatches] DIAG GetHero_Prefix comparison heroName='{heroName}' rawName='{rawName}'");

            if (rawName != heroName)
                __result = __instance.GetHero(rawName);

            return false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] GetHero_Prefix failed: {ex}");
            return true;
        }
    }

    // TEMP DIAGNOSTIC (remove once the whole click->crash chain is confirmed fixed): reports
    // whether GetHero actually resolved a HeroData, regardless of whether Prefix rewrote the name
    // or let the native path run unchanged - the crash's own stack trace points at RobHeroItemChoose
    // itself, not GetHero, so this settles whether the lookup now succeeds and the real remaining
    // problem is downstream (e.g. the cityAreaID check - a data/state issue, not translation).
    [HarmonyPatch(typeof(WorldData), nameof(WorldData.GetHero), new[] { typeof(string) })]
    [HarmonyPostfix]
    private static void GetHero_Postfix_Diag(string heroName, HeroData __result)
    {
        MainPlugin.Logger?.LogInfo($"[PlotInteractControllerPatches] DIAG GetHero_Postfix heroName={heroName ?? "<null>"} resolved={(__result != null ? "HIT" : "MISS")}");
    }

    // TEMP DIAGNOSTIC (remove once the whole click->crash chain is confirmed fixed): pure tracing,
    // no mutation - confirms whether native OnClick's SendMessage actually reaches these methods at
    // all, and with what param, independent of the GetHero fix above.
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.RobHeroItemChoose))]
    [HarmonyPrefix]
    private static void RobHeroItemChoose_Diag(string param)
    {
        MainPlugin.Logger?.LogInfo($"[PlotInteractControllerPatches] DIAG RobHeroItemChoose ENTERED param={param ?? "<null>"}");
    }

    [HarmonyPatch(typeof(PlotController), nameof(PlotController.RobHeroItemChoosen))]
    [HarmonyPrefix]
    private static void RobHeroItemChoosen_Diag(string param)
    {
        MainPlugin.Logger?.LogInfo($"[PlotInteractControllerPatches] DIAG RobHeroItemChoosen ENTERED param={param ?? "<null>"}");
    }
}
