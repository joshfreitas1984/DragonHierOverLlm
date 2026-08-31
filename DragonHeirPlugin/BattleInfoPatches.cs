using System;
using HarmonyLib;

namespace EnglishPatch;

// Source-level hook for the BATTLE combat log (BattleController.AddInfoText). Sibling of
// InfoListPatches (which covers the HUD InfoTextList scrolling log) - the battle log is a
// different component (BattleController's own infoText), so it was never covered by that patch.
//
// The battle log's text component accumulates every combat line for the whole fight. Without a
// source-level patch, the sink-level Text/TMP setter patch (DynamicStringPatches
// .ApplyToComponentText) re-scans the entire ever-growing accumulated buffer through the full
// templates+dictionary pipeline on every single append - O(n) work per attack, so the per-attack
// lag compounds as the battle runs longer (confirmed in-game: delay grows with fight length).
//
// Translating each incoming line HERE, before BattleController appends it, keeps the accumulated
// buffer fully English, so ApplyToComponentText's ContainsCjk(current) short-circuit fires and the
// expensive pipeline never runs against the whole log again. Exactly the pattern InfoListPatches
// uses for the HUD log. Kept in its own file/Harmony instance for the same reason.
internal static class BattleInfoPatches
{
    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.BattleInfoPatches");
            harmony.PatchAll(typeof(BattleInfoPatches));
            MainPlugin.Logger.LogInfo("[BattleInfoPatches] Patched BattleController.AddInfoText.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleInfoPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(BattleController), nameof(BattleController.AddInfoText), new[] { typeof(string), typeof(bool) })]
    [HarmonyPrefix]
    private static void AddInfoText_Prefix(ref string addInfo)
    {
        if (string.IsNullOrEmpty(addInfo) || DynamicStringPatches._inFormatConcatPatch) return;
        if (!DynamicStringPatches.HasTranslationData) return;
        if (!DynamicStringPatches.ContainsCjk(addInfo)) return;

        // Same re-entrancy guard as InfoListPatches/GenericPostfix - RunGenericPipeline can log via
        // MainPlugin.Logger, which itself calls String.Format internally.
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            var original = addInfo;
            var result = DynamicStringPatches.RunGenericPipeline(original);
            DynamicStringPatches.LogResidualCjkDebug("BattleControllerAddInfoText", original, result);
            addInfo = result;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[BattleInfoPatches] AddInfoText prefix failed: {ex}");
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = false;
        }
    }
}
