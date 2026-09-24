using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
///    `targetHorseData` here).
/// 2. Ground-truth raw name, not reverse-translation: rather than reverse-translating the
///    already-English live template name (which would depend on the translation dictionary having
///    no collisions - real risk, see the "枣红马"/"黄骠马" case fixed separately in
///    dynamicStringsFromColumns.txt.yaml), this patch reads `HorseData.csv` (the exact same file
///    `Resources.Load("GameData/HorseData", ...)` serves to the game, deployed at
///    `<plugin>/resources/GameData/HorseData.csv`) directly, once, at plugin load, into a small
///    `id -> rawName` table. Confirmed live that the DEPLOYED csv's name column (column 1) is left
///    as raw Chinese - translation only ever happens via the separate runtime dictionary mechanism,
///    never by pre-translating the packaged CSV - so this table is completely independent of
///    whatever the live in-memory translation state is or how the dictionary evolves later.
/// 3. The recovered raw name and the "大" suffix are joined with `StringBuilder`, NOT
///    `string.Concat`/`+`/interpolation - `StringBuilder.Append`/`ToString` are untouched by
///    DynamicStringPatches' patch list, so this is the one construction path that survives with the
///    literal "大" suffix intact instead of being independently re-translated.
///
/// Looking the live template up by `itemID` instead of trusting `targetHorseData.name` also means
/// this self-heals a save whose `name` field is already baked stale (see the investigation doc) -
/// `itemID` is a plain int, never subject to the translation-freeze bug that can affect
/// `name`/`describe` text fields.
/// </summary>
internal static class HorseMountedIconPatches
{
    private const string MountedSuffix = "大";
    private const string TargetAtlas = "IconAtlas";
    private const string HorseDataFileName = "HorseData.csv";

    private static readonly Dictionary<int, string> _rawNamesByItemId = new();

    /// <summary>Loads HorseData.csv's id -> raw-Chinese-name mapping (if present). Safe to call even
    /// if missing - lookups then just find nothing and this patch's postfix no-ops. Call once from
    /// MainPlugin.Load(), before HorseIconController.Update ever runs.</summary>
    public static void LoadRawHorseNames()
    {
        try
        {
            var pluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
            var resourcesDir = Path.Combine(pluginDir, "resources");

            var path = Directory.Exists(resourcesDir)
                ? Directory.GetFiles(resourcesDir, HorseDataFileName, SearchOption.AllDirectories).FirstOrDefault()
                : null;

            if (path == null)
            {
                MainPlugin.Logger?.LogWarning($"[HorseMountedIconPatches] '{HorseDataFileName}' not found under '{resourcesDir}' - mounted-horse icon fix will no-op.");
                return;
            }

            var lines = File.ReadAllLines(path, Encoding.UTF8);
            // Row 0 is the header ("ID,名称,Description,..."); every id/name pair is a plain
            // Chinese breed name with no embedded commas/quotes (verified against every row in the
            // deployed file), so a plain first-two-columns split is safe without a full CSV parser.
            for (var i = 1; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrWhiteSpace(line)) continue;

                var firstComma = line.IndexOf(',');
                if (firstComma < 0) continue;
                var secondComma = line.IndexOf(',', firstComma + 1);
                if (secondComma < 0) continue;

                var idText = line.Substring(0, firstComma);
                var name = line.Substring(firstComma + 1, secondComma - firstComma - 1);
                if (int.TryParse(idText, out var id) && !string.IsNullOrEmpty(name))
                    _rawNamesByItemId[id] = name;
            }

            MainPlugin.Logger?.LogInfo($"[HorseMountedIconPatches] Loaded {_rawNamesByItemId.Count} raw horse name(s) from '{HorseDataFileName}'.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[HorseMountedIconPatches] Failed to load '{HorseDataFileName}': {ex}");
        }
    }

    [HarmonyPatch(typeof(HorseIconController), nameof(HorseIconController.Update))]
    [HarmonyPostfix]
    private static void Update_Postfix(HorseIconController __instance)
    {
        if (!MainPlugin.ResyncMountedHorseIconEnabledCached) return;

        try
        {
            var horse = __instance?.targetHorseData;
            if (horse == null) return;
            if (__instance.horseIcon == null) return;

            if (!_rawNamesByItemId.TryGetValue(horse.itemID, out var rawName) || string.IsNullOrEmpty(rawName))
                return;

            var textureController = TextureController.Instance;
            if (textureController == null) return;

            // Joined via StringBuilder, NOT string.Concat/interpolation/+ - see class remarks,
            // point 2/3, for why plain concatenation gets the "大" suffix independently retranslated.
            var spriteNameBuilder = new StringBuilder();
            spriteNameBuilder.Append(rawName);
            spriteNameBuilder.Append(MountedSuffix);
            var spriteName = spriteNameBuilder.ToString();

            var sprite = textureController.LoadAtlasSprite(TargetAtlas, spriteName);
            if (sprite == null) return;

            var image = __instance.horseIcon.GetComponent<Image>();
            if (image == null) return;

            image.sprite = sprite;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[HorseMountedIconPatches] Update_Postfix failed: {ex}");
        }
    }
}
