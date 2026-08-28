using BepInEx;
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

    public override void Load()
    {
        Logger = base.Log;

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
        // Nested patch class - Harmony.CreateAndPatchAll(Type) does not recurse into nested types,
        // so AssetBundleLoadAssetPatch (which needs its own [HarmonyTargetMethod] to resolve the
        // ambiguous AssetBundle.LoadAsset(string) overload - see PrefabTextPatches.cs) must be
        // patched explicitly.
        Harmony.CreateAndPatchAll(typeof(PrefabTextPatches.AssetBundleLoadAssetPatch));
        Harmony.CreateAndPatchAll(typeof(UnityLogCapture));
        //Harmony.CreateAndPatchAll(typeof(DiagnosticPatches));
        Harmony.CreateAndPatchAll(typeof(NameLengthPatches));
        DynamicStringPatches.PatchAll();
        Logger.LogWarning($"Plugin {MyPluginInfo.PLUGIN_GUID} should be patched!");

        //DisableEastAsianTmpSettings();
    }

    public void OnDestroy()
    {
        Logger.LogWarning($"Plugin {MyPluginInfo.PLUGIN_GUID} is destroyed!");
    }

    //private void DisableEastAsianTmpSettings()
    //{
    //    var settings = TMP_Settings.instance;
    //    if (settings != null)
    //    {
    //        SetPrivateField(settings, "m_linebreakingRules", null);
    //        SetPrivateField(settings, "m_leadingCharacters", new TextAsset("("));
    //        SetPrivateField(settings, "m_followingCharacters", new TextAsset(")"));
    //        //SetPrivateField(settings, "m_GetFontFeaturesAtRuntime", false);

    //        TMP_Settings.LoadLinebreakingRules();
    //        Logger.LogMessage("Disabled East Asian TMP settings.");
    //    }
    //}

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