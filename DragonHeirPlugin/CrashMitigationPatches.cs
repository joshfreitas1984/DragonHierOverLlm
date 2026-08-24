using System;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Investigation status (see .github/instructions/dragonheirplugin.instructions.md,
/// "Post-resource-load errors" section): a System.ArgumentOutOfRangeException in
/// StartMenuController.ResetFaceSetting was initially suspected to be caused by
/// SpeHeroFaceData.csv being GBK-encoded (fixed in ResourceIoPatches.DecodeAssetBytes). That fix
/// is real and worth keeping, but a subsequent repro proved it's NOT the cause of THIS crash:
/// SpeHeroFaceData was never loaded via Resources.Load before the crash fired (confirmed via
/// BepInEx log — only NameData/SpeAddDataBase/ForceSpeAddDataBase/TechDataBase/AreaData/
/// ResourcePointTypeData were dumped before the exception). Decompiling
/// StartMenuController.ShowStartMenu confirmed ResetFaceSetting runs unconditionally the moment
/// `this.attriRoot != null` — i.e. as soon as the title screen's character panel is shown, not
/// gated behind any of our translated CSVs at all. The real cause is still unidentified (Ghidra's
/// decompiled pseudocode for ResetFaceSetting has un-labeled DAT_ statics pointers for the
/// specific list being indexed, so static analysis alone couldn't pin it down further).
///
/// This Harmony Finalizer patch is a temporary mitigation + diagnostic aid, not a real fix: it
/// prevents the game from crashing on this specific exception so translation testing isn't
/// blocked, and logs full exception details (plus GameDataController list counts, which are the
/// most likely candidates given the loop/index pattern in the decompiled method) so the next
/// investigation pass has real runtime data instead of guessing from static pseudocode. Remove
/// this patch once the actual root cause is found and fixed properly.
/// </summary>
internal static class CrashMitigationPatches
{
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetFaceSetting))]
    [HarmonyFinalizer]
    private static Exception ResetFaceSetting_Finalizer(Exception __exception)
    {
        if (__exception == null)
            return null;

        try
        {
            var gdc = GameDataController.Instance;
            MainPlugin.Logger?.LogError(
                $"CrashMitigationPatches: StartMenuController.ResetFaceSetting threw and was suppressed.\n" +
                $"GameDataController instance null={gdc == null}\n" +
                $"familyNameDataBase.Count={gdc?.familyNameDataBase?.Count.ToString() ?? "null"}\n" +
                $"givenNameDataBase.Count={gdc?.givenNameDataBase?.Count.ToString() ?? "null"}\n" +
                $"maleGivenNameDataBase.Count={gdc?.maleGivenNameDataBase?.Count.ToString() ?? "null"}\n" +
                $"femaleGivenNameDataBase.Count={gdc?.femaleGivenNameDataBase?.Count.ToString() ?? "null"}\n" +
                $"Exception: {__exception}");
        }
        catch (Exception logEx)
        {
            MainPlugin.Logger?.LogError(
                $"CrashMitigationPatches: ResetFaceSetting threw ({__exception.GetType().Name}: {__exception.Message}); " +
                $"failed to gather extra diagnostic context: {logEx}");
        }

        // Swallow the exception so the game doesn't crash — see remarks above for why this is a
        // temporary mitigation, not the real fix.
        return null;
    }

    /// <summary>
    /// Suppressing ResetFaceSetting's exception above leaves StartMenuController in a state its
    /// own developers never intended to reach: ShowStartMenu calls ResetFaceSetting,
    /// ResetPlayerSkeleton, and ResetPlayerTag back-to-back unconditionally, and ResetPlayerTag
    /// reads/writes the SAME unresolved statics pointer (DAT_181d81570-derived) that
    /// ResetFaceSetting was aborted out of mid-initialization. Confirmed via BepInEx log: once
    /// ResetFaceSetting's exception is suppressed, ResetPlayerTag immediately throws a cascading
    /// NullReferenceException. Mitigating this the same way (log + swallow) so testing isn't
    /// blocked by a second crash while the real root cause is still under investigation via
    /// DiagnosticPatches.
    /// </summary>
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetPlayerTag))]
    [HarmonyFinalizer]
    private static Exception ResetPlayerTag_Finalizer(Exception __exception)
    {
        if (__exception == null)
            return null;

        try
        {
            var gdc = GameDataController.Instance;
            MainPlugin.Logger?.LogError(
                $"CrashMitigationPatches: StartMenuController.ResetPlayerTag threw and was suppressed.\n" +
                $"GameDataController instance null={gdc == null}\n" +
                $"heroTagDataBase.Count={gdc?.heroTagDataBase?.Count.ToString() ?? "null"}\n" +
                $"Exception: {__exception}");
        }
        catch (Exception logEx)
        {
            MainPlugin.Logger?.LogError(
                $"CrashMitigationPatches: ResetPlayerTag threw ({__exception.GetType().Name}: {__exception.Message}); " +
                $"failed to gather extra diagnostic context: {logEx}");
        }

        return null;
    }
}
