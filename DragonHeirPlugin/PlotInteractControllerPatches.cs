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
internal static class PlotInteractControllerPatches
{
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
