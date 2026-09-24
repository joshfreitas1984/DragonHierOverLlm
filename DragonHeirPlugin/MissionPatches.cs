using System;
using System.Text.RegularExpressions;
using HarmonyLib;

namespace EnglishPatch;

internal static class MissionPatches
{
    [ThreadStatic]
    private static bool _previousGenericTranslationSuppression;

    private static readonly (Regex Pattern, MatchEvaluator Replacement)[] NaturalObjectivePatterns =
    [
        (new Regex(@"提升(?<area>.+?)的(?<effect>民心|治安|防御)(?<amount>\d+)点", RegexOptions.Compiled),
            match =>
            {
                var effect = match.Groups["effect"].Value switch
                {
                    "民心" => "public sentiment",
                    "治安" => "public safety",
                    "防御" => "defenses",
                    _ => match.Groups["effect"].Value,
                };
                return $"Raise {effect} in {match.Groups["area"].Value} by {match.Groups["amount"].Value} points.";
            }),
        (new Regex(@"在(?<area>.+?)分舵探索(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Explore {match.Groups["area"].Value} {match.Groups["amount"].Value} times."),
        (new Regex(@"为门派获取(?<amount>\d+)(?<resource>.+?)$", RegexOptions.Compiled),
            match => $"Obtain {match.Groups["amount"].Value} {match.Groups["resource"].Value} for the sect."),
        (new Regex(@"增进与(?<hero>.+?)的好感(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Increase {match.Groups["hero"].Value}'s favor by {match.Groups["amount"].Value} points."),
        (new Regex(@"制作价值(?<amount>\d+)的(?<item>.+)", RegexOptions.Compiled),
            match => $"Craft {match.Groups["item"].Value} worth {match.Groups["amount"].Value}."),
        (new Regex(@"招募(?<amount>\d+)名(?<hero>.+)", RegexOptions.Compiled),
            match => $"Recruit {match.Groups["amount"].Value} {match.Groups["hero"].Value}."),
        (new Regex(@"学习(?<amount>\d+)门(?<skill>.+?)武功", RegexOptions.Compiled),
            match => $"Learn {match.Groups["amount"].Value} {match.Groups["skill"].Value} martial arts."),
        (new Regex(@"编纂(?<amount>\d+)本(?<skill>.+?)秘籍", RegexOptions.Compiled),
            match => $"Compile {match.Groups["amount"].Value} {match.Groups["skill"].Value} manuals."),
        (new Regex(@"与(?<hero>.+?)切磋获胜(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Defeat {match.Groups["hero"].Value} in sparring {match.Groups["amount"].Value} times."),
        (new Regex(@"向(?<hero>.+?)传授(?<amount>\d+)门武功", RegexOptions.Compiled),
            match => $"Teach {match.Groups["hero"].Value} {match.Groups["amount"].Value} martial arts."),
        (new Regex(@"搜集(?<amount>\d+)本(?<skill>.+?)秘籍", RegexOptions.Compiled),
            match => $"Collect {match.Groups["amount"].Value} {match.Groups["skill"].Value} manuals."),
        (new Regex(@"提升与(?<target>.+?)的关系(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Improve relations with {match.Groups["target"].Value} by {match.Groups["amount"].Value} points."),
        (new Regex(@"降低与(?<target>.+?)的关系(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Reduce relations with {match.Groups["target"].Value} by {match.Groups["amount"].Value} points."),
        (new Regex(@"袭击(?<hero>.+?)(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Attack {match.Groups["hero"].Value} {match.Groups["amount"].Value} times."),
        (new Regex(@"降低(?<area>.+?)的(?<effect>.+?)(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Reduce {match.Groups["effect"].Value} in {match.Groups["area"].Value} by {match.Groups["amount"].Value} points."),
        (new Regex(@"窃取(?<area>.+?)资源(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Steal resources from {match.Groups["area"].Value} {match.Groups["amount"].Value} times."),
        (new Regex(@"降低(?<hero>.+?)忠诚(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Reduce {match.Groups["hero"].Value}'s loyalty by {match.Groups["amount"].Value} points."),
        (new Regex(@"攻略(?<area>.+)", RegexOptions.Compiled),
            match => $"Conquer {match.Groups["area"].Value}."),
        (new Regex(@"在(?<area>.+?)岗哨巡查(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Patrol the {match.Groups["area"].Value} sentry post {match.Groups["amount"].Value} times."),
        (new Regex(@"搜集(?<amount>\d+)件(?<item>.+?)珍宝", RegexOptions.Compiled),
            match => $"Collect {match.Groups["amount"].Value} {match.Groups["item"].Value} treasures."),
        (new Regex(@"(?<skill>.+?)[(（]\s*(?<level>\d+)\s*级\s*[)）]\s*提升\s*(?<amount>\d+)\s*级", RegexOptions.Compiled),
            match => $"Raise {match.Groups["skill"].Value} from level {match.Groups["level"].Value} by {match.Groups["amount"].Value} levels."),
        (new Regex(@"指点(?<hero>.+?)武功(?<amount>\d+)次", RegexOptions.Compiled),
            match => $"Guide {match.Groups["hero"].Value}'s martial arts training {match.Groups["amount"].Value} times."),
        (new Regex(@"向(?<hero>.+?)下毒(?<amount>\d+)点", RegexOptions.Compiled),
            match => $"Poison {match.Groups["hero"].Value} by {match.Groups["amount"].Value} points."),
    ];

    public static void PatchAll()
    {
        try
        {
            var harmony = new Harmony("EnglishPatch.MissionPatches");
            harmony.PatchAll(typeof(MissionPatches));
            MainPlugin.Logger.LogInfo("[MissionPatches] Patched MissionData.GetMissionTargetDescribe.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[MissionPatches] PatchAll failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetMissionTargetDescribe), new[] { typeof(bool) })]
    [HarmonyPrefix]
    private static void GetMissionTargetDescribePrefix()
    {
        _previousGenericTranslationSuppression = DynamicStringPatches._suppressGenericTranslation;
        DynamicStringPatches._suppressGenericTranslation = true;
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetMissionTargetDescribe), new[] { typeof(bool) })]
    [HarmonyPostfix]
    private static void GetMissionTargetDescribePostfix(bool showFinishRate, ref string __result)
    {
        try
        {
            // Diagnostic (see mission-icon-title-compound-name-corruption.md "round 4"): confirm
            // this method is actually the source of a reported corrupted compound before assuming
            // TranslateObjective ran on it. _suppressGenericTranslation is already true here (set
            // by the prefix), so this is safe from the GenericPostfix BCL-recursion issue.
            if (MainPlugin.ResidualCjkDebugEnabledCached)
                DynamicStringPatches.LogMissionDebug(
                    $"GetMissionTargetDescribe raw result (showFinishRate={showFinishRate})",
                    __result, __result);

            TranslateObjective(ref __result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[MissionPatches] GetMissionTargetDescribe postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetMissionTargetDescribe), new[] { typeof(bool) })]
    [HarmonyFinalizer]
    private static Exception GetMissionTargetDescribeFinalizer(Exception __exception)
    {
        DynamicStringPatches._suppressGenericTranslation = _previousGenericTranslationSuppression;
        return __exception;
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetTriggerTargetDescribe), new[] { typeof(int), typeof(bool) })]
    [HarmonyPrefix]
    private static void GetTriggerTargetDescribePrefix()
    {
        _previousGenericTranslationSuppression = DynamicStringPatches._suppressGenericTranslation;
        DynamicStringPatches._suppressGenericTranslation = true;
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetTriggerTargetDescribe), new[] { typeof(int), typeof(bool) })]
    [HarmonyPostfix]
    private static void GetTriggerTargetDescribePostfix(int targetID, bool unclear, ref string __result)
    {
        try
        {
            // Diagnostic: see GetMissionTargetDescribePostfix's matching comment.
            if (MainPlugin.ResidualCjkDebugEnabledCached)
                DynamicStringPatches.LogMissionDebug(
                    $"GetTriggerTargetDescribe raw result (targetID={targetID}, unclear={unclear})",
                    __result, __result);

            TranslateObjective(ref __result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[MissionPatches] GetTriggerTargetDescribe postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetTriggerTargetDescribe), new[] { typeof(int), typeof(bool) })]
    [HarmonyFinalizer]
    private static Exception GetTriggerTargetDescribeFinalizer(Exception __exception)
    {
        DynamicStringPatches._suppressGenericTranslation = _previousGenericTranslationSuppression;
        return __exception;
    }

    // missionHideTargetPlaceString is a pre-baked "AreaName + BuildingName" compound (e.g.
    // "青城派祠堂") stored directly on the MissionData instance - unlike GetMissionTargetDescribe/
    // GetTriggerTargetDescribe (patched above), it is never recomputed through those methods, so it
    // was reaching MissionIconController's Title and GetMissionBaseDescribe's text completely
    // unpatched, then getting corrupted by the shared generic Concat/Format pipeline the first time
    // it was displayed (see docs/investigations/plugin/mission-icon-title-compound-name-corruption.md,
    // "Actual conclusion"). Translating it here, in place, with the same strict left-to-right
    // TranslateCompoundName used for the bare-compound-name fallback above, resolves both pieces
    // (area name, building name) before they are ever concatenated/Formatted downstream, and the
    // in-place write memoizes the result so this only needs to run once per mission instance.
    [HarmonyPatch(typeof(MissionData), nameof(MissionData.GetMissionBaseDescribe), new[] { typeof(bool) })]
    [HarmonyPrefix]
    private static void GetMissionBaseDescribePrefix(MissionData __instance)
    {
        try
        {
            TranslateHiddenTargetPlaceString(__instance);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[MissionPatches] GetMissionBaseDescribe prefix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(MissionIconController), "Update")]
    [HarmonyPrefix]
    private static void MissionIconControllerUpdatePrefix(MissionIconController __instance)
    {
        try
        {
            TranslateHiddenTargetPlaceString(__instance?.missionData);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[MissionPatches] MissionIconController.Update prefix failed: {ex}");
        }
    }

    private static void TranslateHiddenTargetPlaceString(MissionData missionData)
    {
        if (missionData == null || !missionData.missionHideTargetPlace) return;

        var value = missionData.missionHideTargetPlaceString;
        if (string.IsNullOrEmpty(value) || !DynamicStringPatches.ContainsCjk(value)) return;

        missionData.missionHideTargetPlaceString = DynamicStringPatches.TranslateCompoundName(value);
    }

    private static void TranslateObjective(ref string result)
    {
        if (string.IsNullOrEmpty(result)) return;

        var inputForDiagnostic = result;

        result = result.Replace("任务对象已死亡", "The mission target has died.", StringComparison.Ordinal);

        var beforeNaturalPatterns = result;
        foreach (var (pattern, replacement) in NaturalObjectivePatterns)
            result = pattern.Replace(result, replacement);
        var matchedNaturalPattern = result != beforeNaturalPatterns;

        //MainPlugin.Logger.LogWarning($"[MissionPatches] After natural patterns: {result}");

        if (!DynamicStringPatches.ContainsCjk(result)) return;

        var wasInFormatConcatPatch = DynamicStringPatches._inFormatConcatPatch;
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            // GetTriggerTargetDescribe/GetMissionTargetDescribe don't only return objective
            // sentences - some branches (used by MissionIconController's Title, e.g.
            // "AreaName" + "BuildingName") return a bare compound name with no verb, which none
            // of NaturalObjectivePatterns matches. That shape has no sentence structure for
            // RunGenericPipeline's templates to use, and even its plain dictionary pass
            // (TranslateFragment/ApplyDictionary) matches a raw entry ANYWHERE in the string,
            // independent of position - which let a short fragment (e.g. a single-character
            // dictionary entry) get pulled out of the middle of an unrelated compound and produce
            // corruption such as "Qingcheng Se?t祠?" from "青城派祠堂" (see
            // docs/investigations/plugin/mission-icon-title-compound-name-corruption.md). Once no
            // natural pattern matched, resolve any residual CJK with TranslateCompoundName instead
            // - a strict left-to-right, match-at-current-position-only translator that structurally
            // cannot produce that kind of cross-word corruption, so the result is fully resolved
            // (or safely left as readable raw Chinese) here, before it ever reaches the shared
            // dynamicStrings pipeline (GenericPostfix/ApplyToComponentText) downstream.
            result = matchedNaturalPattern
                ? DynamicStringPatches.RunGenericPipeline(result)
                : DynamicStringPatches.TranslateCompoundName(result);
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = wasInFormatConcatPatch;
        }

        // Diagnostic: confirms TranslateObjective actually ran on a given raw string and shows
        // exactly what it produced (matchedNaturalPattern picks RunGenericPipeline vs
        // TranslateCompoundName) - lets a corrupted report be checked against this method's own
        // output instead of assuming it ran at all. See mission-icon-title-compound-name-corruption.md.
        if (MainPlugin.ResidualCjkDebugEnabledCached)
            DynamicStringPatches.LogMissionDebug(
                $"MissionPatches.TranslateObjective (changed={inputForDiagnostic != result})",
                inputForDiagnostic, result);
    }
}