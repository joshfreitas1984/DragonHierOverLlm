using System;
using HarmonyLib;

namespace EnglishPatch;

// PlotInteractController.OnClick's dispatch of choiceData.callFuc (e.g. "RobHeroItemChoose") is
// nested entirely inside "if (choiceData.costResource != null)" in the decompiled source (see
// Converter/output/_NoNamespace/PlotInteractController.cs). Choices with no cost - e.g. PlotData.csv's
// 夺取物件;RobHeroItemChoose entries, which have no cost-resource column at all - leave
// costResource null, so the button is clickable/interactable but the click silently does nothing
// beyond logging the chosen line to the plot transcript (that logging happens unconditionally,
// earlier in the same method, so this patch doesn't need to redo it). Confirmed real member
// signatures via a throwaway reflection probe against the game's actual Assembly-CSharp.dll
// (PlotController.Instance is a public static property backed by a private field; nowChoice has a
// public setter; RemoveEvent(EventData) and RobHeroItemChoose(string) are real instance methods;
// SendMessage(string, Il2CppSystem.Object) accepts a plain string via its implicit operator).
// MainPlugin.FixNoCostChoiceClickEnabled ("Game Bugfixes" config section) lets this be turned off
// if a future game patch fixes the underlying gate.
//
// callParam reverse-translate: PlotData.csv column 9's "{0};RobHeroItemChoose;{1}" template (see
// docs/gamefilehandling-reference.md) translates {1} (a hero name, e.g. "高首" -> "High Lord")
// like any other display fragment, but RobHeroItemChoose(string) looks the target hero up by its
// original Chinese name, so the translated param never matches and the button silently does
// nothing (same root cause as ItemIconPatches' icon-name lookup). CONFIRMED live (2026-09-02
// debug log) that most/all RobHeroItemChoose choices actually have costResource != null, so
// OnClick's NATIVE body (not the no-cost Postfix below) does the real SendMessage dispatch -
// fixing only the Postfix path never even ran for these. Fixed instead with an unconditional
// Prefix that reverse-translates choiceData.callParam in place (via
// DynamicStringPatches.ReverseTranslate - a no-op for any callFuc whose param was never in the
// translation dictionary) before EITHER the native body or the no-cost Postfix below reads it.
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

    [HarmonyPatch(typeof(PlotInteractController), nameof(PlotInteractController.OnClick))]
    [HarmonyPostfix]
    private static void OnClick_Postfix(PlotInteractController __instance)
    {
        if (MainPlugin.FixNoCostChoiceClickEnabled?.Value != true) return;

        try
        {
            var choiceData = __instance.choiceData;
            if (choiceData == null || choiceData.costResource != null) return;

            var pc = PlotController.Instance;
            if (pc == null || pc.plotTextShowing || pc.plotChoiceShowing) return;

            pc.nowChoice = choiceData;

            if (choiceData.destroyEvent && pc.nowEvent != null)
                pc.RemoveEvent(pc.nowEvent);

            // callParam was already reverse-translated by OnClick_Prefix above.
            if (string.IsNullOrEmpty(choiceData.callParam))
                pc.SendMessage(choiceData.callFuc);
            else
                pc.SendMessage(choiceData.callFuc, choiceData.callParam);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[PlotInteractControllerPatches] OnClick_Postfix failed: {ex}");
        }
    }
}
