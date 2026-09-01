using BepInEx;
using BepInEx.Configuration;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using System;
using System.Reflection;
using System.Text;

namespace EnglishPatch;

/// <summary>
/// Swaps the Text db asset in
/// </summary>
[BepInPlugin(MyPluginInfo.PLUGIN_GUID, MyPluginInfo.PLUGIN_NAME, MyPluginInfo.PLUGIN_VERSION)]
public class MainPlugin : BasePlugin
{
    public const string ChineseCharPattern = @".*\p{IsCJKUnifiedIdeographs}.*";
    internal static new ManualLogSource Logger;

    // Off by default - flip via BepInEx's generated config file (BepInEx\config\<GUID>.cfg,
    // section "Debug") to have DynamicStringPatches append before/after text for every call that
    // still contains residual CJK characters after both the template and bare-fragment passes to
    // residualCjkDebug.log next to the plugin DLL. See DynamicStringPatches.LogResidualCjkDebug.
    internal static ConfigEntry<bool> ResidualCjkDebugEnabled;

    // Off by default until validated live - DynamicStringPatches.ApplyToComponentText's
    // append-only fast path (translate only the newly appended suffix of a growing Text/TMP_Text,
    // e.g. the InfoList log) assumes appends land on a real line break. A typewriter-style reveal
    // that grows the SAME message a character at a time doesn't have that property, and some
    // templates contain an embedded "\n" of their own, so this toggle lets the fast path be
    // switched off to compare against always running the full pipeline. See DynamicStringPatches.
    internal static ConfigEntry<bool> AppendOnlySuffixTranslationEnabled;

    // Off by default - once enabled, a Text/TMP_Text instance observed with no CJK content is
    // never checked again, so if that same instance is later reused for CJK content (e.g. a
    // recycled label/tooltip), that later content will silently never get translated. Only
    // enable if profiling shows the ContainsCjk scan itself is a bottleneck. See
    // DynamicStringPatches.ApplyToComponentText.
    internal static ConfigEntry<bool> SkipKnownNonCjkComponentsEnabled;

    // Off by default until the DOTweenModuleUI.DOText patch's parameter-name binding is verified
    // live (Harmony matches interop parameters by name, not just type/position - see
    // dragonheirplugin.instructions.md). When true, PlotTextPatches shrinks the dialogue
    // typewriter's tween duration instead of letting it reveal character-by-character. See
    // PlotTextPatches.
    internal static ConfigEntry<bool> SpeedUpPlotTextTypewriterEnabled;

    // Off by default until verified live - same parameter-name-binding caveat as
    // SpeedUpPlotTextTypewriterEnabled above, plus this adds two more by-name-bound parameters
    // ("target", "endValue") to the same patch, so a binding failure here would also break the
    // duration patch (both live in the same HarmonyPatch method). When true, PlotTextPatches
    // translates the dialogue's full final text up front and hands it to DOText's endValue, so
    // the typewriter reveals already-translated text instead of raw Chinese (avoiding the
    // per-tween-step retranslation cost and mid-reveal partial-CJK/partial-English garbling). See
    // PlotTextPatches.
    internal static ConfigEntry<bool> PreTranslatePlotTextEnabled;

    // On by default - toggle off if a future game patch fixes this at the source. See
    // PlotInteractControllerPatches for the full rationale: PlotInteractController.OnClick only
    // dispatches choiceData.callFuc (e.g. RobHeroItemChoose) when choiceData.costResource is
    // non-null, but no-cost choices (e.g. PlotData.csv's 夺取物件/RobHeroItemChoose entries, which
    // have no cost column at all) leave costResource null, so those choice buttons are clickable
    // but silently do nothing.
    internal static ConfigEntry<bool> FixNoCostChoiceClickEnabled;

    // Off by default (dicey/unverified) - a "recollection" dialogue template (e.g.
    // "#TargetInteractName#将此前{0}之遭遇向你娓娓道来......") can embed another already-formatted
    // template's output (a plot-event/world-news sentence, e.g. "{0}在{1}遭逢{5}奇遇...") as its own
    // {0} value. ApplyTemplates normally tries every template exactly once per call in list order,
    // so if one template's own literal-segment/trigger-char precheck only becomes satisfiable
    // after another template further down the list has already run (order-dependent), the earlier
    // one is never retried. When true, ApplyTemplates repeats its full pass over all templates
    // (bounded, stops early once a pass makes no change) instead of running once, to catch that
    // class of gap. See DynamicStringPatches.ApplyTemplates.
    internal static ConfigEntry<bool> MultiPassTemplateApplicationEnabled;

    public override void Load()
    {
        Logger = base.Log;

        DynamicStringPatches.ClearResidualCjkDebugLog();
        UnityLogCapture.DeleteLogFile();

        ResidualCjkDebugEnabled = Config.Bind(
            "Debug",
            "ResidualCjkDebugLogging",
            false,
            "When true, DynamicStringPatches logs before/after text to residualCjkDebug.log for every call that still contains untranslated CJK characters after both the template and bare-fragment passes. Leave off unless actively debugging a translation gap - this is a per-call diagnostic and will grow the log file quickly.");

        MultiPassTemplateApplicationEnabled = Config.Bind(
            "Performance",
            "MultiPassTemplateApplication",
            true,
            "When true, DynamicStringPatches.ApplyTemplates repeats its pass over all compiled templates (bounded, stops once a pass makes no change) instead of trying each template exactly once, to catch order-dependent nested-template gaps (e.g. a recollection dialogue embedding an already-formatted world-event sentence). Off by default - unverified/speculative fix, enable only while investigating a known nested-template translation gap.");

        AppendOnlySuffixTranslationEnabled = Config.Bind(
            "Performance",
            "AppendOnlySuffixTranslation",
            true,
            "When true, a growing Text/TMP_Text component (e.g. the HudPanel InfoList log) only has its newly appended suffix translated instead of the whole accumulated text every time. Off by default - disable if translations near an appended line look wrong (e.g. while a typewriter-style reveal is still in use) and compare against the full-pipeline behavior.");

        SkipKnownNonCjkComponentsEnabled = Config.Bind(
            "Performance",
            "SkipKnownNonCjkComponents",
            false,
            "When true, once a Text/TMP_Text component has been observed with no CJK content, DynamicStringPatches stops checking it again for the rest of the session. Off by default - risky for any component that can be reused/recycled for different content later, since a subsequent switch to CJK content on that same instance would never be detected or translated.");

        SpeedUpPlotTextTypewriterEnabled = Config.Bind(
            "Performance",
            "SpeedUpPlotTextTypewriter",
            true,
            "When true, the PlotPanel dialogue's character-by-character typewriter reveal is sped up to near-instant instead of tweening the text in over its normal duration. Off by default until verified live - fixes both the per-tween-step retranslation cost and the garbled mid-reveal partial-CJK/partial-English text this typewriter effect causes.");

        PreTranslatePlotTextEnabled = Config.Bind(
            "Performance",
            "PreTranslatePlotText",
            true,
            "When true, PlotPanel dialogue text is translated up front before the typewriter tween starts, so the reveal shows already-translated text instead of raw Chinese being retranslated on every tween step. Off by default until verified live - see PlotTextPatches.");

        FixNoCostChoiceClickEnabled = Config.Bind(
            "Game Bugfixes",
            "FixNoCostChoiceClick",
            false,
            "When true, PlotInteractController's dialogue choice buttons that have no cost resource (e.g. the 夺取物件/RobHeroItemChoose choices) actually fire their callFuc instead of silently doing nothing, working around a gap in the base game where the dispatch is only reached when choiceData.costResource is non-null. Turn off if a future game patch fixes this at the source. See PlotInteractControllerPatches.");

        // Register codepage 936 (GBK) support - .NET Core only ships Unicode encodings by
        // default. Some game TextAssets (e.g. SpeHeroFaceData) are GBK-encoded rather than
        // UTF-8, and Unity's TextAsset.text getter always assumes UTF-8, silently mangling
        // GBK content into U+FFFD replacement characters. ResourceIoPatches.DecodeAssetBytes
        // reads the raw TextAsset.bytes and falls back to GBK when UTF-8 strict decoding fails.
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

        // Plugin startup logic
        Logger.LogWarning($"Plugin {MyPluginInfo.PLUGIN_GUID} is loaded!");
        Harmony.CreateAndPatchAll(typeof(MainPlugin));
        Harmony.CreateAndPatchAll(typeof(ResourceIoPatches));
        Harmony.CreateAndPatchAll(typeof(PrefabTextPatches));
        Harmony.CreateAndPatchAll(typeof(PrefabTextPatches.AssetBundleLoadAssetPatch));
        Harmony.CreateAndPatchAll(typeof(PrefabTextPatches.GlobalDataAddChildPatch));
        Harmony.CreateAndPatchAll(typeof(UnityLogCapture));
        Harmony.CreateAndPatchAll(typeof(NameLengthPatches));
        HeroNamePatches.LoadNamePartDictionary();
        Harmony.CreateAndPatchAll(typeof(HeroNamePatches));

        // Wrapped separately - its DOTweenModuleUI.DOText patch's parameter name ("duration") is
        // not yet verified against this build's real interop metadata (see PlotTextPatches), so a
        // binding failure here must not take down every other patch registered below it.
        try
        {
            Harmony.CreateAndPatchAll(typeof(PlotTextPatches));
        }
        catch (Exception ex)
        {
            Logger.LogError($"Failed to patch PlotTextPatches: {ex}");
        }

        Harmony.CreateAndPatchAll(typeof(PlotInteractControllerPatches));

        DynamicStringPatches.PatchAll();

        // Must patch AFTER DynamicStringPatches.PatchAll() - relies on its dictionary/templates
        // and shared re-entrancy guard already being loaded.
        InfoListPatches.PatchAll();

        // Sibling of InfoListPatches for the BATTLE combat log (BattleController.AddInfoText) -
        // same dependency on DynamicStringPatches.PatchAll() having run first.
        BattleInfoPatches.PatchAll();

        // Must patch AFTER DynamicStringPatches.PatchAll() - ItemIconPatches.
        // GetItemIconName_Postfix calls DynamicStringPatches.ReverseTranslate, which reads the
        // reverse dictionary that PatchAll() populates.
        Harmony.CreateAndPatchAll(typeof(ItemIconPatches));

        //Harmony.CreateAndPatchAll(typeof(DiagnosticPatches));
        //Harmony.CreateAndPatchAll(typeof(HardcodedHeroNamePatches));

        Logger.LogWarning($"Plugin {MyPluginInfo.PLUGIN_GUID} should be patched!");
    }

    public void OnDestroy()
    {
        Logger.LogWarning($"Plugin {MyPluginInfo.PLUGIN_GUID} is destroyed!");
    }

    private void SetPrivateField(object obj, string fieldName, object value)
    {
        FieldInfo field = obj.GetType().GetField(fieldName, BindingFlags.NonPublic | BindingFlags.Instance);
        if (field != null)
            field.SetValue(obj, value);
        else
            Logger.LogError($"Field '{fieldName}' not found in {obj.GetType().Name}.");
    }

    // GlobalData.ConvertNumToChinese(int input) spells a number out as Chinese numeral text (e.g.
    // "一万二千三百四十五") for display. Skip the original entirely and return a plain,
    // English-friendly formatted number instead (e.g. "12,345").
    [HarmonyPatch(typeof(GlobalData), nameof(GlobalData.ConvertNumToChinese))]
    [HarmonyPrefix]
    public static bool ConvertNumToChinese_Prefix(int input, ref string __result)
    {
        try
        {
            __result = input.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
            return false;
        }
        catch (Exception ex)
        {
            Logger.LogError($"Error in ConvertNumToChinese patch: {ex}");
            return true;
        }
    }

    // GlobalData.GetNumText(int) is the general-purpose "level/count" numeral-to-Chinese-word
    // helper (e.g. building levels, party counts, chapter numbers) - called from dozens of UI
    // controllers across the codebase (AreaData, BuildingUIController, ChapterController,
    // QuickDetail, etc.), unlike ConvertNumToChinese which is only used for one specific spot.
    // Same treatment: skip the Chinese-word lookup, return the plain Arabic numeral instead.
    [HarmonyPatch(typeof(GlobalData), nameof(GlobalData.GetNumText))]
    [HarmonyPrefix]
    public static bool GetNumText_Prefix(int num, ref string __result)
    {
        try
        {
            __result = num.ToString(System.Globalization.CultureInfo.InvariantCulture);
            return false;
        }
        catch (Exception ex)
        {
            Logger.LogError($"Error in GetNumText patch: {ex}");
            return true;
        }
    }

    // GlobalData.GetChineseNumText(int id) picks a single Chinese numeral character out of a lookup
    // string via "id % length" (no other call sites found in the decompiled codebase - likely
    // rare/decorative, e.g. a looping digit animation). Return the equivalent Arabic digit
    // character instead, mirroring the "id % 10" style of the original.
    [HarmonyPatch(typeof(GlobalData), nameof(GlobalData.GetChineseNumText))]
    [HarmonyPrefix]
    public static bool GetChineseNumText_Prefix(int id, ref char __result)
    {
        try
        {
            __result = (char)('0' + (Math.Abs(id) % 10));
            return false;
        }
        catch (Exception ex)
        {
            Logger.LogError($"Error in GetChineseNumText patch: {ex}");
            return true;
        }
    }

    //[HarmonyPatch(typeof(TypingLogic), "GetTypeSpeed")]
    //[HarmonyPrefix]
    //public static bool GetTypeSpeed_Prefix(ref float __result)
    //{
    //    try
    //    {
    //        // English text requires faster typing speeds since English uses more characters
    //        // than Chinese for the same amount of information. Original speeds were:
    //        // Normal: 0.05f, Fast: 0.02f, Instant: 0.0f
    //        // We divide by 2.5 to make it feel more responsive for English readers

    //        switch (GameManager.Instance.TextSpeed)
    //        {
    //            case TextSpeed.Normal:
    //                __result = 0.02f;  // Original: 0.05f
    //                break;
    //            case TextSpeed.Fast:
    //                __result = 0.008f; // Original: 0.02f
    //                break;
    //            default:
    //                __result = 0.0f;   // Instant stays the same
    //                break;
    //        }

    //        return false;
    //    }
    //    catch (Exception ex)
    //    {
    //        Logger.LogError($"Error in GetTypeSpeed patch: {ex}");
    //        return true;
    //    }
    //}
}