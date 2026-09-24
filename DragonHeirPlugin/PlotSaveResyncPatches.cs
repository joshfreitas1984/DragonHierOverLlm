using System;
using HarmonyLib;

namespace EnglishPatch;

// Save files embed an already-fully-resolved PlotData/SinglePlotData snapshot (via
// PlotData.Clone/SinglePlotData.Clone, a BinaryFormatter deep-clone) the moment a "special"
// (spePlot) world-event plot is triggered/queued (PlotController.AddPlotDataBase/
// ChangePlotDataBase). That snapshot's plotText is a literal string from then on - it is NOT
// re-read from PlotDataBase/PlotData.csv on later loads. Confirmed live: a save's JSON
// (LongYinLiZhiZhuan_Data/Save/SaveSlotN/Save) contains the dialogue text verbatim under
// plotData.plotDatas[i].plotText, so an already-triggered quest keeps showing whatever text was
// baked in at trigger time even after Files/Converted/PlotData.csv.yaml is corrected, repackaged,
// and deployed, and even with this plugin fully disabled and the game fully relaunched - because
// none of that changes bytes already written into the save file. Full investigation and save JSON
// shape: docs/investigations/plugin/save-embedded-plot-text-investigation.md.
//
// Fix: resync the WHOLE plotDatas list from the live GameDataController.Instance.PlotDataBase in
// one pass, patched on PlotController.ShowPlot(PlotData targetPlot) - BEFORE any line has been
// shown or removed - rather than trying to resync one SinglePlotData at a time on
// ShowSinglePlot. Two earlier approaches were tried and abandoned here, in order:
//
//   1. Patching ShowSinglePlot and finding targetPlot's index via
//      nowPlot.plotDatas.IndexOf(targetPlot). Broken: PlotController.GoNextPlot()
//      (Converter/output/_NoNamespace/PlotController.cs:3619) does
//      `nowPlot.plotDatas.RemoveAt(0)` before showing each subsequent line, so the list shrinks
//      by one every line and the currently-shown line is ALWAYS at position 0 of what remains -
//      IndexOf returned 0 for every line, not just the first.
//   2. Patching ShowSinglePlot and tracking a per-nowPlot-instance "lines shown so far" counter in
//      a ConditionalWeakTable<PlotData, ...>, relying on the SAME managed PlotData object being
//      handed back across multiple separate Harmony invocations. Broken (or at least unreliable):
//      Il2CppInterop does not guarantee a stable managed wrapper identity for the same underlying
//      native object across separate marshalling calls, so a ConditionalWeakTable keyed on that
//      object saw what looked like a "new" key almost every time and the counter never
//      accumulated - live logs showed every single line reported "index 0" again, indistinguishable
//      from approach 1 failing.
//
// This third approach needs no cross-call state at all - everything happens inside one Harmony
// invocation, using only the targetPlot parameter handed to THAT call.
//
// Also resyncs SinglePlotChoiceData.choiceText/describe (the dialogue choice buttons) - see
// ResyncChoices below. Same bug class (frozen into the save by the same PlotData.Clone()), same
// untouched-list moment, different identity anchor since choices have no speaker fields.
internal static class PlotSaveResyncPatches
{
    [HarmonyPatch(typeof(PlotController), nameof(PlotController.ShowPlot))]
    [HarmonyPrefix]
    private static void ShowPlot_Prefix(PlotData targetPlot)
    {
        if (!MainPlugin.ResyncStalePlotTextFromSaveEnabledCached) return;
        if (targetPlot?.plotDatas == null) return;

        try
        {
            var dataController = GameDataController.Instance;
            if (dataController?.PlotDataBase == null) return;
            if (!dataController.PlotDataBase.TryGetValue(targetPlot.plotID, out var livePlot)) return;
            if (livePlot?.plotDatas == null) return;

            // Only trust position-based matching if the two lists are the same shape. A count
            // mismatch means the saved/queued plotDatas has drifted from the live table (lines
            // added/removed upstream since this instance was cloned) - position no longer means
            // anything, so skip the whole conversation rather than guess.
            if (livePlot.plotDatas.Count != targetPlot.plotDatas.Count)
            {
                MainPlugin.Logger?.LogWarning(
                    $"[PlotSaveResyncPatches] Skipped resync for plotID {targetPlot.plotID} - " +
                    $"saved plotDatas has {targetPlot.plotDatas.Count} line(s) but the live table has " +
                    $"{livePlot.plotDatas.Count} - list shape has drifted upstream, position-based " +
                    "matching would be unreliable.");
                return;
            }

            var resyncedCount = 0;
            for (var i = 0; i < targetPlot.plotDatas.Count; i++)
            {
                var saved = targetPlot.plotDatas[i];
                var live = livePlot.plotDatas[i];
                if (saved == null || live == null) continue;

                // Guard against plotID reuse/repurposing: only trust the live row at this
                // position if it still looks like the SAME line (same speaker/target identity).
                // If the game's own upstream data drifted - e.g. plotID 228 later reused for a
                // different quest - skip just this line rather than risk substituting an
                // unrelated line's text under a coincidentally-matching position.
                if (!string.Equals(live.sourceName, saved.sourceName, StringComparison.Ordinal) ||
                    !string.Equals(live.targetName, saved.targetName, StringComparison.Ordinal) ||
                    live.plotSource != saved.plotSource ||
                    live.plotTarget != saved.plotTarget)
                {
                    MainPlugin.Logger?.LogWarning(
                        $"[PlotSaveResyncPatches] Skipped resync for plotID {targetPlot.plotID} index {i} - " +
                        "live PlotDataBase entry's source/target identity no longer matches the saved " +
                        "snapshot at this position. Leaving that line's saved text as-is.");
                    continue;
                }

                if (!string.IsNullOrEmpty(live.plotText) && live.plotText != saved.plotText)
                {
                    saved.plotText = live.plotText;
                    resyncedCount++;
                }

                resyncedCount += ResyncChoices(targetPlot.plotID, i, saved.choices, live.choices);
            }

            if (resyncedCount > 0)
            {
                MainPlugin.Logger?.LogInfo(
                    $"[PlotSaveResyncPatches] Resynced {resyncedCount} stale saved plotText/choice field(s) for plotID {targetPlot.plotID}.");
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[PlotSaveResyncPatches] ShowPlot_Prefix failed: {ex}");
        }
    }

    // SinglePlotChoiceData.choiceText/describe are the same bug class as SinglePlotData.plotText -
    // choices live nested inside each SinglePlotData, so the whole thing gets frozen into the save
    // by the same PlotData.Clone() BinaryFormatter round-trip. Not subject to the GoNextPlot
    // RemoveAt(0) trap that broke the plotDatas index - only plotDatas itself gets popped as lines
    // are consumed, a line's own choices list is never mutated after the fact - so plain positional
    // matching is safe here as long as this runs at the same untouched-list moment as the caller
    // (ShowPlot_Prefix, before any line has been shown).
    //
    // Identity guard uses callFuc/callParam instead of sourceName/targetName (SinglePlotChoiceData
    // has no speaker identity fields) - callFuc/callParam are the raw CSV-sourced function
    // hookup/parameter strings, never translated, so they're a stable anchor for "is this still
    // the same choice" across the saved snapshot and the live table.
    private static int ResyncChoices(int plotID, int lineIndex, Il2CppSystem.Collections.Generic.List<SinglePlotChoiceData> saved, Il2CppSystem.Collections.Generic.List<SinglePlotChoiceData> live)
    {
        if (saved == null || live == null) return 0;

        if (live.Count != saved.Count)
        {
            MainPlugin.Logger?.LogWarning(
                $"[PlotSaveResyncPatches] Skipped choice resync for plotID {plotID} index {lineIndex} - " +
                $"saved choices has {saved.Count} entry(ies) but the live table has {live.Count} - " +
                "list shape has drifted upstream, position-based matching would be unreliable.");
            return 0;
        }

        var resyncedCount = 0;
        for (var i = 0; i < saved.Count; i++)
        {
            var savedChoice = saved[i];
            var liveChoice = live[i];
            if (savedChoice == null || liveChoice == null) continue;

            if (!string.Equals(liveChoice.callFuc, savedChoice.callFuc, StringComparison.Ordinal) ||
                !string.Equals(liveChoice.callParam, savedChoice.callParam, StringComparison.Ordinal))
            {
                MainPlugin.Logger?.LogWarning(
                    $"[PlotSaveResyncPatches] Skipped choice resync for plotID {plotID} index {lineIndex} choice {i} - " +
                    "live PlotDataBase entry's callFuc/callParam no longer matches the saved snapshot at " +
                    "this position. Leaving that choice's saved text as-is.");
                continue;
            }

            if (!string.IsNullOrEmpty(liveChoice.choiceText) && liveChoice.choiceText != savedChoice.choiceText)
            {
                savedChoice.choiceText = liveChoice.choiceText;
                resyncedCount++;
            }

            if (!string.IsNullOrEmpty(liveChoice.describe) && liveChoice.describe != savedChoice.describe)
            {
                savedChoice.describe = liveChoice.describe;
                resyncedCount++;
            }
        }

        return resyncedCount;
    }
}
