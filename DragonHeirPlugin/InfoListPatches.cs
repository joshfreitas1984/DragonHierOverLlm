using System;
using HarmonyLib;

namespace EnglishPatch;

// Source-level pre-translation hook for the HUD InfoList scrolling message log (InfoTextList),
// sibling of BattleInfoPatches for the battle combat log. Also marks the underlying textLabel
// as a trusted append-only source so the sink-level setter patch skips full-buffer rescans.
// Full rationale/pattern: docs/battleinfopatches-trusted-append-only-source.md
internal static class InfoListPatches
{
    // Tracks which InfoTextList instances have already had their textLabel marked as a trusted
    // append-only source, so the (interop) textLabel property getter and cache lookup only ever
    // run once per instance instead of on every single Add() call.
    private static readonly System.Runtime.CompilerServices.ConditionalWeakTable<InfoTextList, object> _markedInstances = new();

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.InfoListPatches");
            harmony.PatchAll(typeof(InfoListPatches));
            MainPlugin.Logger.LogInfo("[InfoListPatches] Patched InfoTextList.Add overloads.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[InfoListPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(InfoTextList), nameof(InfoTextList.Add), new[] { typeof(int), typeof(string) })]
    [HarmonyPrefix]
    private static void InfoTextListAdd_Prefix(InfoTextList __instance, ref string text)
    {
        TranslateInfoListSourceText(__instance, ref text);
    }

    [HarmonyPatch(typeof(InfoTextList), "Add", new[] { typeof(int), typeof(TimeData), typeof(string), typeof(bool) })]
    [HarmonyPrefix]
    private static void InfoTextListAddWithTime_Prefix(InfoTextList __instance, ref string text)
    {
        TranslateInfoListSourceText(__instance, ref text);
    }

    private static void TranslateInfoListSourceText(InfoTextList instance, ref string text)
    {
        if (string.IsNullOrEmpty(text) || DynamicStringPatches._inFormatConcatPatch) return;
        if (!DynamicStringPatches.HasTranslationData) return;

        // Every fragment reaching here is translated before InfoTextList ever appends it to its
        // internal buffer/Text.text - lets ApplyToComponentText skip re-scanning that whole
        // (ever-growing) buffer for CJK on every append. Only done once per instance (see
        // _markedInstances) since it's a one-time, idempotent fact about the component, not about
        // this call's text.
        if (instance != null && !_markedInstances.TryGetValue(instance, out _))
        {
            try
            {
                // Only recorded as "marked" once textLabel is actually available, so a call
                // before the component's UI is fully initialized retries on the next Add().
                if (instance.textLabel != null)
                {
                    DynamicStringPatches.MarkTrustedAppendOnlySource(instance.textLabel);
                    _markedInstances.Add(instance, null);
                }
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogError($"[InfoListPatches] MarkTrustedAppendOnlySource failed: {ex}");
            }
        }

        if (!DynamicStringPatches.ContainsCjk(text)) return;

        // Same re-entrancy guard as DynamicStringPatches.GenericPostfix/FormatPrefix -
        // RunGenericPipeline can log via MainPlugin.Logger, which itself calls String.Format
        // internally.
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            var original = text;
            var result = DynamicStringPatches.RunGenericPipeline(original);
            DynamicStringPatches.LogResidualCjkDebug("InfoTextListAdd", original, result);
            text = result;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[InfoListPatches] InfoTextList.Add prefix failed: {ex}");
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = false;
        }
    }
}
