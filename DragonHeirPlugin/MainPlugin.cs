using BepInEx;
using BepInEx.Logging;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
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
        Harmony.CreateAndPatchAll(typeof(UnityLogCapture));
        Harmony.CreateAndPatchAll(typeof(CrashMitigationPatches));
        Harmony.CreateAndPatchAll(typeof(DiagnosticPatches));
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

    //[HarmonyPatch(typeof(GameTools), nameof(GameTools.ConvertNumberToChineseDate))]
    //[HarmonyPrefix]
    //public static bool ConvertNumberToChineseDate_Prefix(int number, ref string __result)
    //{
    //    if (number <= 0)
    //        __result = "0";
    //    else
    //        __result = Convert.ToString(number);

    //    return false;
    //}

    //[HarmonyPatch(typeof(GameTools), nameof(GameTools.ConvertNumberToChineseNoUnit))]
    //[HarmonyPrefix]
    //public static bool ConvertNumberToChineseNoUnit_Prefix(int number, ref string __result)
    //{
    //    try
    //    {
    //        if (number >= 1_000_000_000)
    //        {
    //            double billions = number / 1_000_000_000.0;
    //            __result = $"{billions:0.##}B";
    //        }
    //        else if (number >= 1_000_000)
    //        {
    //            double millions = number / 1_000_000.0;
    //            __result = $"{millions:0.##}M";
    //        }
    //        else if (number >= 1_000)
    //        {
    //            double thousands = number / 1_000.0;
    //            __result = $"{thousands:0.##}K";
    //        }
    //        else
    //        {
    //            __result = number.ToString();
    //        }

    //        return false;
    //    }
    //    catch (Exception ex)
    //    {
    //        Logger.LogError($"Error in ConvertNumberToChineseNoUnit patch: {ex}");
    //        return true;
    //    }
    //}

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