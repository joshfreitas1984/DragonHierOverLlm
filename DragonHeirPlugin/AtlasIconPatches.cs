using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EnglishPatch;

/// <summary>
/// Fixes Inn map icons not rendering (confirmed 2026-09-03 - see
/// Converter/output/_NoNamespace/InnIconController.cs's `Init()`, which calls
/// `TextureController.LoadAtlasSprite("AreaIconAtlas", this.innData.innName)` - using the Inn's
/// display name itself as the sprite lookup key, same class of bug as
/// `ItemIconPatches.GetItemIconName_Postfix`.
///
/// Root cause: `innName` (InnData.csv column 1, e.g. "有间客栈") is translated whole-string via the
/// normal per-row CSV pipeline, so by the time `InnIconController.Init()` runs, `innData.innName`
/// is already English. "AreaIconAtlas" has no sprite keyed by the English text - it was only ever
/// built with the original Chinese inn names - so `LoadAtlasSprite` returns null and the icon fails
/// to render.
///
/// Fix: reverse-translate the `spriteName` argument via this class's OWN small, private,
/// exact-match dictionary (loaded from `innIconNames.txt.yaml`, produced by
/// Tests/GameFileHandling.cs's `AtlasSpriteNameColumnSources` as a byproduct of packaging
/// InnData.csv - no extra LLM translation, guaranteed consistent with the name already shown
/// elsewhere) - NOT `DynamicStringPatches.ReverseTranslate`, whose dictionary only has isolated
/// word fragments here (segmented via `ZhSegment`) rather than a whole-name entry, and whose much
/// larger dictionary (100k+ entries) would be needlessly expensive to scan/reverse-apply for a
/// handful of sprite lookups per frame.
/// </summary>
internal static class AtlasIconPatches
{
    private const string SpriteNameDictionaryFileName = "innIconNames.txt.yaml";
    private static Dictionary<string, string> _reverseSpriteNameDictionary = new();

    /// <summary>Loads innIconNames.txt.yaml (if present). Safe to call even if missing - lookups
    /// then just leave the sprite name untouched. Call once from MainPlugin.Load(), before
    /// LoadAtlasSprite is ever invoked.</summary>
    public static void LoadSpriteNameDictionary()
    {
        try
        {
            var pluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
            var resourcesDir = Path.Combine(pluginDir, "resources");

            var path = Directory.Exists(resourcesDir)
                ? Directory.GetFiles(resourcesDir, SpriteNameDictionaryFileName, SearchOption.AllDirectories).FirstOrDefault()
                : null;

            if (path == null)
            {
                MainPlugin.Logger?.LogWarning($"[AtlasIconPatches] '{SpriteNameDictionaryFileName}' not found under '{resourcesDir}' - atlas sprite names will be left untranslated.");
                return;
            }

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

            var entries = deserializer.Deserialize<List<DictionaryEntry>>(File.ReadAllText(path)) ?? new();
            _reverseSpriteNameDictionary = entries
                .Where(e => !string.IsNullOrEmpty(e.Result))
                .GroupBy(e => e.Result)
                .ToDictionary(g => g.Key, g => g.First().Raw);

            MainPlugin.Logger?.LogInfo($"[AtlasIconPatches] Loaded {_reverseSpriteNameDictionary.Count} atlas sprite name(s) from '{SpriteNameDictionaryFileName}'.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[AtlasIconPatches] Failed to load '{SpriteNameDictionaryFileName}': {ex}");
        }
    }

    // Minimal shape matching the flat raw/result YAML - same as DynamicStringPatches.DictionaryEntry.
    private sealed class DictionaryEntry
    {
        public string Raw { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }

    [HarmonyPatch(typeof(TextureController), nameof(TextureController.LoadAtlasSprite))]
    [HarmonyPrefix]
    private static void LoadAtlasSprite_Prefix(string atlasPath, ref string spriteName)
    {
        if (string.IsNullOrEmpty(spriteName)) return;
        if (_reverseSpriteNameDictionary.TryGetValue(spriteName, out var raw))
        {
            spriteName = raw;
            return;
        }

        // Mounted/equipped horse HUD icon (confirmed 2026-09-03 with the Mongolian horse -
        // Converter/output/_NoNamespace/HorseIconController.cs's `Update()` builds its "IconAtlas"
        // key inline as `String.Concat(this.targetHorseData.name, "大")` rather than via
        // `ItemData.GetItemIconName()`, so ItemIconPatches' fix never sees this call site.
        // `targetHorseData.name` is raw Chinese (HorseData.csv name column is SkipColumns'd out of
        // the per-row CSV pipeline - see DynamicStringColumnSources), but that Concat call is
        // itself patched by DynamicStringPatches' global postfix, which translates the whole
        // concatenated result before it ever reaches here.
        if (atlasPath == "IconAtlas")
            spriteName = DynamicStringPatches.ReverseTranslateSuffixed(spriteName, "大");
    }
}

