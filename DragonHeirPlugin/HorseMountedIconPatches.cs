using System;
using System.Text;
using HarmonyLib;
using UnityEngine.UI;

namespace EnglishPatch;

/// <summary>
/// Fixes the currently-equipped/ridden horse's bigmap quick-travel icon not rendering (confirmed
/// 2026-09-24, then refined twice more the same day after live repros showed each earlier version
/// was insufficient - see docs/investigations/plugin/save-embedded-plot-text-investigation.md's
/// sprite-lookup notes for the full history).
///
/// Root cause: HorseIconController.Update() builds its "IconAtlas" sprite key directly as
/// `targetHorseData.name + "大"`, bypassing `ItemData.GetItemIconName()`/`ItemIconPatches` entirely.
/// Two compounding problems, both confirmed live:
///
/// 1. `targetHorseData.name` (and even the LIVE `GameDataController.Instance.horseDataBase` template
///    row's own `.name`, not just save-loaded instances) is already translated to English by the
///    time any code reads it - whatever boundary does this runs before even the master template
///    table is visible to managed code, not just at per-instance clone/display time.
/// 2. Rebuilding "&lt;name&gt;大" via ANY `System.String.Concat`/`Format`/`+`/interpolation call -
///    including from our OWN mod code, not just the game's - gets globally intercepted: confirmed
///    live that `liveTemplate.name + "大"` produced `"Swift Heaven Horse Big"`, not
///    `"Swift Heaven Horse大"`. `DynamicStringPatches.PatchAll` Harmony-patches every public static
///    overload of `System.String.Concat`/`Format` (DynamicStringPatches.cs:617-621) - a JIT-level
///    patch that affects every caller in the whole process, not just the game's own code, and the
///    standalone character "大" has its own dictionary entry, so it gets bare-translated to "Big"
///    mid-concatenation regardless of who calls Concat.
///
/// Fix, addressing both:
/// 1. Identity, not text: `ItemData.itemID` reliably identifies horse BREED for every non-saddle
///    horse item (confirmed live: every type-6/subType-0 itemID in a real save maps to exactly one
///    breed across 3749 instances checked - the only itemID collision found was itemID 0 shared by
///    *saddle* items, which use different, non-breed-specific numbering and are never
///    `targetHorseData` here). `GameDataController.Instance.horseDataBase` is keyed by that exact
///    same id (confirmed in `GameDataController.LoadHorseData`, which parses `HorseData.csv` column
///    0 straight into each template's `itemID`). Looking the live template up by `itemID` instead of
///    trusting `targetHorseData.name` also means this self-heals a save whose `name` field is already
///    baked stale (see the investigation doc) - `itemID` is a plain int, never subject to the
///    translation-freeze bug that can affect `name`/`describe` text fields.
/// 2. `DynamicStringPatches.ReverseTranslate` recovers the original raw Chinese name from the live
///    template's already-English `.name` (the same exact-match dictionary lookup `ItemIconPatches`
///    uses, and safe here for the same reason: the "枣红马"/"黄骠马" collision that could have made
///    this ambiguous was fixed at its source in `dynamicStringsFromColumns.txt.yaml`, not worked
///    around here). The recovered raw name and the "大" suffix are then joined with `StringBuilder`,
///    NOT `string.Concat`/`+`/interpolation - `StringBuilder.Append`/`ToString` are untouched by
///    DynamicStringPatches' patch list, so this is the one construction path that survives with the
///    literal "大" suffix intact instead of being independently re-translated.
/// </summary>
internal static class HorseMountedIconPatches
{
    private const string MountedSuffix = "大";
    private const string TargetAtlas = "IconAtlas";

    // TEMPORARY diagnostic state - remove alongside the logging below once the missing-icon report
    // (2026-09-24) is confirmed fixed. Throttles the trace log to once per distinct equipped horse
    // (Update() runs every frame) instead of spamming every frame.
    private static int _lastLoggedItemId = int.MinValue;

    [HarmonyPatch(typeof(HorseIconController), nameof(HorseIconController.Update))]
    [HarmonyPostfix]
    private static void Update_Postfix(HorseIconController __instance)
    {
        if (!MainPlugin.ResyncMountedHorseIconEnabledCached) return;

        try
        {
            var horse = __instance?.targetHorseData;
            if (horse == null) return;

            var trace = horse.itemID != _lastLoggedItemId;
            if (trace) _lastLoggedItemId = horse.itemID;

            if (__instance.horseIcon == null)
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: horseIcon GameObject is null - bailing.");
                return;
            }

            var dataController = GameDataController.Instance;
            if (dataController?.horseDataBase == null)
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: GameDataController.Instance or horseDataBase is null - bailing.");
                return;
            }

            if (!dataController.horseDataBase.TryGetValue(horse.itemID, out var liveTemplate) || liveTemplate == null)
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: no horseDataBase entry for this itemID - bailing.");
                return;
            }

            if (string.IsNullOrEmpty(liveTemplate.name))
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: live template's name is empty - bailing.");
                return;
            }

            var textureController = TextureController.Instance;
            if (textureController == null)
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: TextureController.Instance is null - bailing.");
                return;
            }

            // liveTemplate.name is already English (see class remarks) - recover the raw Chinese
            // name via the same exact-match dictionary ItemIconPatches uses, then join with the
            // "大" suffix via StringBuilder so the suffix itself doesn't get independently
            // retranslated the way plain string concatenation did (see class remarks, point 2).
            var rawName = DynamicStringPatches.ReverseTranslate(liveTemplate.name);
            var spriteNameBuilder = new StringBuilder();
            spriteNameBuilder.Append(rawName);
            spriteNameBuilder.Append(MountedSuffix);
            var spriteName = spriteNameBuilder.ToString();

            var sprite = textureController.LoadAtlasSprite(TargetAtlas, spriteName);
            if (trace)
                MainPlugin.Logger?.LogInfo(
                    $"[HorseMountedIconPatches] itemID={horse.itemID}: liveTemplate.name='{liveTemplate.name}', " +
                    $"rawName='{rawName}', spriteKey='{spriteName}', LoadAtlasSprite -> {(sprite == null ? "NULL" : "found")}");
            if (sprite == null) return;

            var image = __instance.horseIcon.GetComponent<Image>();
            if (image == null)
            {
                if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: horseIcon has no Image component - bailing.");
                return;
            }

            image.sprite = sprite;
            if (trace) MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] itemID={horse.itemID}: sprite set successfully.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[HorseMountedIconPatches] Update_Postfix failed: {ex}");
        }
    }
}
