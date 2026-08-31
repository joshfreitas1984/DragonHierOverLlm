using System;
using HarmonyLib;
using UnityEngine.UI;

namespace EnglishPatch;

// Source-level pre-translation hook for the BATTLE combat log (BattleController.AddInfoText),
// sibling of InfoListPatches for the HUD log. Also marks the underlying Text component as a
// trusted append-only source so the sink-level setter patch skips full-buffer rescans.
// Full rationale/pattern: docs/battleinfopatches-trusted-append-only-source.md
internal static class BattleInfoPatches
{
    // Tracks which BattleController instances have already had their infoText's Text component
    // marked as a trusted append-only source, so the GetComponent lookup only ever runs once per
    // instance instead of on every single AddInfoText() call.
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<BattleController, object> _markedInstances = new();

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
    private static void AddInfoText_Prefix(BattleController __instance, ref string addInfo)
    {
        if (string.IsNullOrEmpty(addInfo) || DynamicStringPatches._inFormatConcatPatch) return;
        if (!DynamicStringPatches.HasTranslationData) return;

        // Same one-time-per-instance marking as InfoListPatches.TranslateInfoListSourceText - only
        // recorded once the Text component is actually available, so a call before the component's
        // UI is fully initialized retries on the next AddInfoText().
        if (__instance != null && !_markedInstances.TryGetValue(__instance, out _))
        {
            try
            {
                var textLabel = __instance.infoText != null ? __instance.infoText.GetComponent<Text>() : null;
                if (textLabel != null)
                {
                    DynamicStringPatches.MarkTrustedAppendOnlySource(textLabel);
                    _markedInstances.Add(__instance, null);
                }
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogError($"[BattleInfoPatches] MarkTrustedAppendOnlySource failed: {ex}");
            }
        }

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
