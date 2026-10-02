using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using UnityEngine;
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
/// Tests/DynamicStringSources.cs's `AtlasSpriteNameColumnSources` as a byproduct of packaging
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

    // Raw (Chinese) sprite key for an inn, resolved by id - see InnIconInitPatch. Cached per id:
    // the live table and innIconNames.txt.yaml are both fixed for the process lifetime.
    private static readonly Dictionary<int, string> _rawInnSpriteNameById = new();

    private static string ResolveRawInnSpriteName(int innId)
    {
        if (_rawInnSpriteNameById.TryGetValue(innId, out var cached)) return cached;

        var innDataBase = GameDataController.Instance?.innDataBase;
        if (innDataBase == null || !innDataBase.TryGetValue(innId, out var liveInn) || liveInn == null)
            return null;

        var liveName = liveInn.innName;
        if (string.IsNullOrEmpty(liveName)) return null;

        // The live row carries the CURRENT packaged translation, which innIconNames.txt.yaml was
        // produced from in the same packaging run; an untranslated (CJK) live name is already the key.
        string raw;
        if (_reverseSpriteNameDictionary.TryGetValue(liveName, out var reversed))
            raw = reversed;
        else if (DynamicStringPatches.ContainsCjk(liveName))
            raw = liveName;
        else
            return null;

        _rawInnSpriteNameById[innId] = raw;
        return raw;
    }

    /// <summary>
    /// Inn icons on a save made under an older translation. `InnData` is cloned into the save
    /// (`InnData.Clone`), so `innData.innName` keeps whatever translation existed when the save was
    /// created. `LoadAtlasSprite_Prefix` below can only reverse a CURRENT translation, so a stale
    /// name either misses (no icon) or, if it happens to equal another inn's current name,
    /// reverses to that other inn's raw key (wrong icon). Same identity-not-text fix as
    /// HorseMountedIconPatches: after the game's own Init has set its (possibly wrong) sprite,
    /// resolve the raw key from `innData.id` via the live `GameDataController.innDataBase` row and
    /// set the sprite again. Display-only - the saved `innName` is never touched.
    /// Registered separately from the outer class so a binding failure here can't take down the
    /// LoadAtlasSprite prefix.
    /// </summary>
    internal static class InnIconInitPatch
    {
        private const string AreaIconAtlas = "AreaIconAtlas";

        // [GameCoupled InnIconController.Init logic] sets the "Sprite" child's SpriteRenderer from LoadAtlasSprite("AreaIconAtlas", innData.innName)
        [HarmonyPatch(typeof(InnIconController), nameof(InnIconController.Init))]
        [HarmonyPostfix]
        private static void Init_Postfix(InnIconController __instance)
        {
            try
            {
                var inn = __instance?.innData;
                if (inn == null) return;

                var rawName = ResolveRawInnSpriteName(inn.id);
                if (rawName == null) return;

                var textureController = TextureController.Instance;
                if (textureController == null) return;

                // rawName is Chinese, so LoadAtlasSprite_Prefix's reverse lookup leaves it as-is.
                var sprite = textureController.LoadAtlasSprite(AreaIconAtlas, rawName);
                if (sprite == null) return;

                var spriteRenderer = __instance.transform.Find("Sprite")?.GetComponent<SpriteRenderer>();
                if (spriteRenderer == null) return;

                var current = spriteRenderer.sprite;
                if (current != null && current.Pointer == sprite.Pointer) return;

                spriteRenderer.sprite = sprite;
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"[AtlasIconPatches] InnIconController.Init postfix failed: {ex}");
            }
        }
    }

    // [GameCoupled InnIconController.Init logic] passes the inn's (already translated) display name as the atlas sprite key
    [HarmonyPatch(typeof(TextureController), nameof(TextureController.LoadAtlasSprite))]
    [HarmonyPrefix]
    private static void LoadAtlasSprite_Prefix(ref string spriteName)
    {
        if (string.IsNullOrEmpty(spriteName)) return;
        if (_reverseSpriteNameDictionary.TryGetValue(spriteName, out var raw))
            spriteName = raw;
    }
}

