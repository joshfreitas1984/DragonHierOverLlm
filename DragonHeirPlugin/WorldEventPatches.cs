using System;
using HarmonyLib;

namespace EnglishPatch;

internal static class WorldEventPatches
{
    [ThreadStatic]
    private static bool _previousGenericTranslationSuppression;

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.WorldEventPatches");
            harmony.PatchAll(typeof(WorldEventPatches));
            MainPlugin.Logger.LogInfo("[WorldEventPatches] Patched EventData.GetDescribe.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[WorldEventPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(EventData), nameof(EventData.GetDescribe), new[] { typeof(bool) })]
    [HarmonyPrefix]
    private static void GetDescribePrefix()
    {
        _previousGenericTranslationSuppression = DynamicStringPatches._suppressGenericTranslation;
        DynamicStringPatches._suppressGenericTranslation = true;
    }

    [HarmonyPatch(typeof(EventData), nameof(EventData.GetDescribe), new[] { typeof(bool) })]
    [HarmonyPostfix]
    private static void GetDescribePostfix(ref string __result)
    {
        try
        {
            if (string.IsNullOrEmpty(__result) || !DynamicStringPatches.ContainsCjk(__result)) return;

            var wasInFormatConcatPatch = DynamicStringPatches._inFormatConcatPatch;
            DynamicStringPatches._inFormatConcatPatch = true;
            try
            {
                __result = DynamicStringPatches.RunGenericPipeline(__result);
            }
            finally
            {
                DynamicStringPatches._inFormatConcatPatch = wasInFormatConcatPatch;
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[WorldEventPatches] GetDescribe postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(EventData), nameof(EventData.GetDescribe), new[] { typeof(bool) })]
    [HarmonyFinalizer]
    private static Exception GetDescribeFinalizer(Exception __exception)
    {
        DynamicStringPatches._suppressGenericTranslation = _previousGenericTranslationSuppression;
        return __exception;
    }
}