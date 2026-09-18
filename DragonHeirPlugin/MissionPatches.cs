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
    private static void GetMissionTargetDescribePostfix(ref string __result)
    {
        try
        {
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
    private static void GetTriggerTargetDescribePostfix(ref string __result)
    {
        try
        {
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

    private static void TranslateObjective(ref string result)
    {
        if (string.IsNullOrEmpty(result)) return;

        //MainPlugin.Logger.LogWarning($"[MissionPatches] Translating objective: {result}");

        result = result.Replace("任务对象已死亡", "The mission target has died.", StringComparison.Ordinal);

        foreach (var (pattern, replacement) in NaturalObjectivePatterns)
            result = pattern.Replace(result, replacement);

        //MainPlugin.Logger.LogWarning($"[MissionPatches] After natural patterns: {result}");

        if (!DynamicStringPatches.ContainsCjk(result)) return;

        var wasInFormatConcatPatch = DynamicStringPatches._inFormatConcatPatch;
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            result = DynamicStringPatches.RunGenericPipeline(result);
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = wasInFormatConcatPatch;
        }
    }
}