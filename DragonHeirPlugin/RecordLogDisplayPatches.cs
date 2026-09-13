using System;
using System.Linq;
using System.Text;
using System.Threading;
using HarmonyLib;
using Il2CppSystem.Collections.Generic;

namespace EnglishPatch;

// Replaces HeroData.GetRecordLog/AreaData.GetRecordLog entirely (Harmony prefix, skips the
// original IL2CPP method) - this is the actual mechanism behind the HeroDetailPanel/AreaLog/
// PlotPanel RecordScrollView slow-open cost (see docs/herodetailpanel-slow-load-investigation.md
// and docs/recordlog-translation-naturalness.md), NOT the component text setter.
//
// The base game's own GetRecordLog (confirmed via decompiled HeroData.cs/AreaData.cs) builds the
// whole displayed blob with a LOOP of String.Concat calls, one per log entry, joining
// newest-to-oldest:
//   result = ""
//   for i = Count-1 downto 0: result = String.Concat(result, recordLog[i], i > 0 ? "\n" : "\n......")
// DynamicStringPatches.GenericPostfix Harmony-postfixes EVERY String.Concat overload globally with
// no component/GameObject context, so EVERY iteration of that loop re-ran the FULL template+
// dictionary pipeline against the ever-growing accumulated result (not just the newly-appended
// entry) - and by iteration 2+, that accumulated result is a MIX of already-translated English +
// a fresh raw Chinese entry, which no longer cleanly matches any template's Raw shape, forcing the
// expensive unanchored permissive fallback. DynamicStringPatches.ApplyToComponentText's
// GetComponentPath-based routing (see IsKnownLogPanelPath) only ever sees the FINAL blob this
// method returns - by then the N redundant full-pipeline passes during the Concat loop have
// already happened.
//
// Fix: skip the original method, translate each entry INDIVIDUALLY (a short, clean, single
// sentence - never mixed with other entries, so the strict/non-permissive pattern matches cleanly
// on the first attempt) against ONLY the small isolated log-narrative template list, then join
// with a StringBuilder - deliberately NOT string.Concat/`+`, which would immediately re-trigger
// GenericPostfix on the growing result and reintroduce the exact cost being removed here.
internal static class RecordLogDisplayPatches
{
    // Verification, not assumption: logs which of the two target methods Harmony actually bound at
    // patch time - call this right after Harmony.CreateAndPatchAll(typeof(RecordLogDisplayPatches))
    // in MainPlugin.cs. A missing entry here means the prefix below is NEVER invoked at all (the
    // original game method keeps running untouched), which is exactly what happened the first time
    // this class was added - it compiled fine but was never registered with Harmony anywhere, so
    // every one of its methods was silently dead code. This makes that failure mode visible in the
    // log immediately instead of only being discovered by "the fix doesn't seem to do anything".
    internal static void LogPatchStatus(Harmony harmony)
    {
        try
        {
            var patched = harmony.GetPatchedMethods().ToList();
            var heroPatched = patched.Any(m => m.DeclaringType == typeof(HeroData) && m.Name == nameof(HeroData.GetRecordLog));
            var areaPatched = patched.Any(m => m.DeclaringType == typeof(AreaData) && m.Name == nameof(AreaData.GetRecordLog));
            MainPlugin.Logger?.LogInfo(
                $"[RecordLogDisplayPatches] Harmony bound {patched.Count} method(s) total. " +
                $"HeroData.GetRecordLog: {(heroPatched ? "PATCHED" : "MISSING")}, " +
                $"AreaData.GetRecordLog: {(areaPatched ? "PATCHED" : "MISSING")}.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[RecordLogDisplayPatches] LogPatchStatus failed: {ex}");
        }
    }

    // Incremented on every actual prefix invocation, logged once on the FIRST call - direct,
    // in-log proof the prefix is really executing at runtime (not just successfully registered),
    // and cheap enough (one Interlocked op) to leave in permanently rather than gating it behind a
    // debug flag.
    private static int _heroInvocationCount;
    private static int _areaInvocationCount;

    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetRecordLog))]
    [HarmonyPrefix]
    private static bool HeroDataGetRecordLog_Prefix(HeroData __instance, ref string __result)
    {
        using var _ = PerfInstrumentation.Measure("RecordLogDisplayPatches.HeroData.GetRecordLog",
            () => __instance?.recordLog != null ? $"{__instance.recordLog.Count} entries" : "(no recordLog)");

        // On any failure, run the ORIGINAL method instead (return true) rather than risk leaving
        // __result unset/wrong - a slow-but-correct display beats a broken one.
        try
        {
            __result = BuildTranslatedRecordLog(__instance?.recordLog);
            if (Interlocked.Increment(ref _heroInvocationCount) == 1)
                MainPlugin.Logger?.LogInfo("[RecordLogDisplayPatches] HeroData.GetRecordLog prefix is active (first call intercepted).");
            return false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[RecordLogDisplayPatches] HeroData.GetRecordLog prefix failed, falling back to original: {ex}");
            return true;
        }
    }

    [HarmonyPatch(typeof(AreaData), nameof(AreaData.GetRecordLog))]
    [HarmonyPrefix]
    private static bool AreaDataGetRecordLog_Prefix(AreaData __instance, ref string __result)
    {
        using var _ = PerfInstrumentation.Measure("RecordLogDisplayPatches.AreaData.GetRecordLog",
            () => __instance?.recordLog != null ? $"{__instance.recordLog.Count} entries" : "(no recordLog)");

        try
        {
            __result = BuildTranslatedRecordLog(__instance?.recordLog);
            if (Interlocked.Increment(ref _areaInvocationCount) == 1)
                MainPlugin.Logger?.LogInfo("[RecordLogDisplayPatches] AreaData.GetRecordLog prefix is active (first call intercepted).");
            return false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[RecordLogDisplayPatches] AreaData.GetRecordLog prefix failed, falling back to original: {ex}");
            return true;
        }
    }

    // Mirrors the base game's own GetRecordLog logic exactly: newest entry (highest index) first,
    // each followed by "\n", except the last one processed (index 0, the oldest entry) which gets
    // "\n......" instead - the trailing "more entries exist" marker. A null/empty list returns "",
    // matching the original (recordLog is always constructed as an empty List<string>, never
    // actually null in practice, but this guards defensively either way).
    private static string BuildTranslatedRecordLog(List<string> recordLog)
    {
        if (recordLog == null) return string.Empty;

        var sb = new StringBuilder();
        for (var i = recordLog.Count - 1; i >= 0; i--)
        {
            var entry = recordLog[i] ?? string.Empty;
            // Every entry here is exactly the string HeroData.AddLog/AreaData.AddLog stored -
            // always genuine log-narrative text - so it's always safe to use ONLY the small
            // isolated template list (see DynamicStringPatches.RunGenericPipeline), never the full
            // corpus. Same memoization key RecordLogPrewarmPatches already primes for entries
            // created this session, so this is a cache hit for those; a stale (pre-existing-save)
            // entry computes here for the first time this session, but only against ~69 candidate
            // templates instead of the full corpus, and only ONCE per distinct entry (never
            // re-processed as part of a growing blob).
            var translated = DynamicStringPatches.HasTranslationData
                ? DynamicStringPatches.RunGenericPipeline(entry, preferLogNarrativeTemplates: true)
                : entry;
            sb.Append(translated);
            sb.Append(i > 0 ? "\n" : "\n......");
        }
        return sb.ToString();
    }
}
