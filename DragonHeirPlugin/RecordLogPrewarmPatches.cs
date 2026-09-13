using System;
using System.Threading.Tasks;
using HarmonyLib;

namespace EnglishPatch;

// Pre-warms DynamicStringPatches' in-memory translation cache (_genericPipelineMemoCache) the
// moment the game creates a new HeroData/AreaData log entry, on a background thread, so by the
// time the player actually opens HeroDetailPanel's Log tab / AreaLog / PlotPanel's RecordScrollView
// the translation is already sitting in the cache instead of running cold (and potentially hitting
// DynamicStringPatches' template-regex MatchTimeout) on the main/UI thread at display time.
//
// Deliberately READ-ONLY - unlike the earlier (reverted, see KNOWN_ISSUES.md) `RecordLogPatches`,
// this never mutates `newLog` or anything HeroData/AreaData stores. Both Harmony prefixes below
// take `newLog` by value, not `ref` - the save is written exactly as the base game would write it;
// only DynamicStringPatches' own in-process cache is affected, which is empty again on every
// process launch. This fixes the "first display is slow" cost for any entry created DURING this
// session; it cannot help an entry that was already sitting in an existing save before this
// session started (that text never passes through AddLog this session at all) - the MatchTimeout
// is what bounds that remaining cold-start case, to milliseconds instead of seconds.
//
// Safe to run off the main thread: RunGenericPipeline only touches plain managed strings/regex/
// dictionaries that are read-only after DynamicStringPatches.PatchAll() runs at plugin load (no
// Unity/IL2CPP object access at all), and MemoCache is lock-protected specifically to make
// concurrent calls from this background task and the main thread's own display-time translation
// safe (see MemoCache's comment in DynamicStringPatches.cs).
internal static class RecordLogPrewarmPatches
{
    [HarmonyPatch(typeof(HeroData), "AddLog")]
    [HarmonyPrefix]
    private static void HeroDataAddLog_Prefix(string newLog) => Prewarm(newLog);

    [HarmonyPatch(typeof(AreaData), "AddLog")]
    [HarmonyPrefix]
    private static void AreaDataAddLog_Prefix(string newLog) => Prewarm(newLog);

    private static void Prewarm(string newLog)
    {
        if (string.IsNullOrEmpty(newLog) || !DynamicStringPatches.HasTranslationData) return;
        if (!DynamicStringPatches.ContainsCjk(newLog)) return;

        Task.Run(() =>
        {
            try
            {
                // This string is always genuine HeroData/AreaData AddLog narrative text (it's the
                // exact value being passed to AddLog), so it can safely prefer the small isolated
                // log-narrative template list over the full corpus - see RunGenericPipeline.
                DynamicStringPatches.RunGenericPipeline(newLog, preferLogNarrativeTemplates: true);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"[RecordLogPrewarmPatches] background prewarm failed: {ex}");
            }
        });
    }
}
