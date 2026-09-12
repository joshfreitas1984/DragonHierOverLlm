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
/// GameController.GetHeroName(int,int) / GetHeroName(HeroData,HeroData) compute a relationship
/// title natively (family/given name + relation word, e.g. "姜师姐") via direct field-offset
/// branching on hero generation/force/favor data - see
/// Converter/output/_NoNamespace/GameController.cs (methods at ~line 32708 and ~line 33018). The
/// combinatorial surname x relation-word space this produces isn't coverable by
/// DynamicStringPatches' flat substring dictionary (every surname would need its own entry per
/// relation word), so this is a dedicated Harmony Postfix instead of a Prefix: the original
/// (unreimplemented, so no risk of getting the field-offset branching wrong) Chinese result is
/// left to compute normally, then translated here by (a) mapping known standalone Chinese titles
/// to English outright, (b) splitting a known relation-word suffix off the end and translating
/// the remaining prefix (family/given name, or "掌门"/"义"), or (c) falling back to translating a
/// bare family/given name (e.g. the "former lover" case, which returns just the given name,
/// optionally with a "儿" child-affix) the same way.
///
/// (b)/(c) look the name part up in THIS class's own private, exact-match dictionary
/// (_namePartDictionary, loaded from BepInEx\plugins\resources\heroNameParts.txt.yaml by
/// LoadNamePartDictionary) - deliberately NOT DynamicStringPatches.TranslateFragment/its global
/// substring-replace dictionary, since a bare one/two-character surname is far too easy to
/// accidentally match as a substring inside unrelated Chinese text elsewhere in the game (that
/// dictionary is loaded from any "dynamicStrings*.txt.yaml" file; heroNameParts.txt.yaml is
/// deliberately named so it never matches that glob). Depends on
/// Tests/DynamicStringExtraction.cs's ExtractHeroNamePartCandidates and
/// Tests/DynamicStringSources.cs's DynamicStringNamePartColumnSources extracting SpeHeroData's
/// "Family.Given" Name column as two standalone raw fragments (not just the whole dotted string)
/// into that dedicated file, since HeroData strips the "." separator at load time and stores the
/// two halves separately.
///
/// Also covers HeroData.GetHeroForceLvDescribe(bool)'s force-name truncation (see
/// GetHeroForceLvDescribePostfix below) - same class of native-computed, dictionary-bypassing
/// fragment (a first-2-character prefix of the raw force name, e.g. "仙霞" from "仙霞派"), looked
/// up in its own private _forceNamePartDictionary (loaded from
/// BepInEx\plugins\resources\forceNameParts.txt.yaml by LoadForceNamePartDictionary) for the same
/// false-positive-risk reason as _namePartDictionary above.
/// </summary>
internal static class HeroNamePatches
{
    private const string NamePartDictionaryFileName = "heroNameParts.txt.yaml";
    private static Dictionary<string, string> _namePartDictionary = new();

    private const string ForceNamePartDictionaryFileName = "forceNameParts.txt.yaml";
    private static Dictionary<string, string> _forceNamePartDictionary = new();

    private const string FullNameDictionaryFileName = "heroFullNames.txt.yaml";
    private static Dictionary<string, string> _fullNameDictionary = new();
    private static Dictionary<string, string> _reverseFullNameDictionary = new();

    /// <summary>Loads heroNameParts.txt.yaml (if present) into this class's own private, exact-
    /// match dictionary. Safe to call even if the file is missing (lookups then just fall back to
    /// leaving the original Chinese text untranslated). Call once from MainPlugin.Load(), before
    /// GetHeroName is ever invoked.</summary>
    public static void LoadNamePartDictionary() =>
        _namePartDictionary = LoadDictionaryFile(NamePartDictionaryFileName);

    /// <summary>Loads forceNameParts.txt.yaml (if present) into this class's own private, exact-
    /// match force-name-prefix dictionary - same rationale and loading mechanics as
    /// LoadNamePartDictionary above, just for HeroData.GetHeroForceLvDescribe's truncated force-
    /// name prefix instead of GameController.GetHeroName's family/given name. Call once from
    /// MainPlugin.Load(), before GetHeroForceLvDescribe is ever invoked.</summary>
    public static void LoadForceNamePartDictionary() =>
        _forceNamePartDictionary = LoadDictionaryFile(ForceNamePartDictionaryFileName);

    /// <summary>Loads heroFullNames.txt.yaml (if present) into a Result -> Raw reverse lookup -
    /// SpeHeroData's family/given-name compound with the "." removed (e.g. "姜映泉"), matching
    /// HeroData.heroName's own dot-stripped storage. Used by
    /// PlotInteractControllerPatches.GetHero_Prefix to recover the raw Chinese name
    /// WorldData.GetHero looks records up by from an already-translated display name. Call once
    /// from MainPlugin.Load().</summary>
    public static void LoadFullNameDictionary()
    {
        _fullNameDictionary = LoadDictionaryFile(FullNameDictionaryFileName);
        _reverseFullNameDictionary = _fullNameDictionary
            .GroupBy(kv => kv.Value)
            .ToDictionary(g => g.Key, g => g.First().Key);
    }

    /// <summary>Result -> Raw lookup only (exact match) - returns the input unchanged if it isn't
    /// a known translated full name.</summary>
    public static string ReverseTranslateFullName(string translated) =>
        _reverseFullNameDictionary.TryGetValue(translated, out var raw) ? raw : translated;

    private static Dictionary<string, string> LoadDictionaryFile(string fileName)
    {
        try
        {
            var pluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
            var resourcesDir = Path.Combine(pluginDir, "resources");

            // Search recursively (mirrors DynamicStringPatches.FindResourceFiles) - the packaged
            // file actually lands under resources\GameData\<fileName>, not directly under
            // resources\, so a flat Path.Combine+File.Exists check here would silently never find
            // it (CONFIRMED bug: this is why name parts fell back to untranslated Chinese even
            // though HeroNamePatches' Postfix and RelationSuffixes translation were both running
            // correctly - _namePartDictionary just stayed empty).
            var path = Directory.Exists(resourcesDir)
                ? Directory.GetFiles(resourcesDir, fileName, SearchOption.AllDirectories).FirstOrDefault()
                : null;

            if (path == null)
            {
                MainPlugin.Logger?.LogWarning($"[HeroNamePatches] '{fileName}' not found under '{resourcesDir}' - name parts will be left untranslated.");
                return new Dictionary<string, string>();
            }

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

            var entries = deserializer.Deserialize<List<DynamicStringPatches.DictionaryEntry>>(File.ReadAllText(path)) ?? new();
            var dictionary = entries
                .Where(e => !string.IsNullOrEmpty(e.Raw))
                .GroupBy(e => e.Raw)
                .ToDictionary(g => g.Key, g => g.First().Result ?? g.Key);

            MainPlugin.Logger?.LogInfo($"[HeroNamePatches] Loaded {dictionary.Count} name part(s) from '{fileName}'.");
            return dictionary;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"[HeroNamePatches] Failed to load '{fileName}': {ex}");
            return new Dictionary<string, string>();
        }
    }

    // Exact-match only (never a substring replace) - an unknown name part is left as its original
    // Chinese text rather than risk a wrong/partial match.
    private static string TranslateNamePart(string input) =>
        _namePartDictionary.TryGetValue(input, out var translated) ? translated : input;

    // Standalone full-string returns from GetHeroName - never concatenated with a name.
    private static readonly Dictionary<string, string> StandaloneTitles = new()
    {
        ["师傅"] = "Master",
        ["徒儿"] = "Disciple",
        ["娘子"] = "Wife",
        ["夫君"] = "Husband",
        ["掌门"] = "Sect Leader",
    };

    // Relation-word suffixes concatenated onto a family/given name (or "掌门"/"义") prefix.
    // Multi-character suffixes are listed before the single-character ones they contain (e.g.
    // "师兄" before "兄") so the longer, more specific match always wins.
    private static readonly (string Suffix, string English)[] RelationSuffixes = new[]
    {
        ("师兄", "Senior Brother"),
        ("师姐", "Senior Sister"),
        ("师弟", "Junior Brother"),
        ("师妹", "Junior Sister"),
        ("师伯", "Senior Uncle"),
        ("师叔", "Junior Uncle"),
        ("师公", "Grand Master"),
        ("师祖", "Ancestor"),
        ("师侄", "Grand Disciple"),
        ("徒孙", "Grand Student"),
        ("女侠", "Heroine"),
        ("少侠", "Young Hero"),
        ("大侠", "Great Hero"),
        ("兄", "Brother"),
        ("姐", "Sister"),
        ("弟", "Brother"),
        ("妹", "Sister"),
    };

    // Non-name prefixes that can precede a relation suffix instead of a translated family/given
    // name - translated directly rather than going through the fragment dictionary.
    private static readonly (string Prefix, string English)[] KnownPrefixes = new[]
    {
        ("掌门", "Sect Leader's"),
        ("义", "Sworn"),
    };

    [HarmonyPatch(typeof(GameController), nameof(GameController.GetHeroName), new[] { typeof(int), typeof(int) })]
    [HarmonyPostfix]
    public static void GetHeroNameIntPostfix(ref string __result)
    {
        Translate(ref __result);
    }

    [HarmonyPatch(typeof(GameController), nameof(GameController.GetHeroName), new[] { typeof(HeroData), typeof(HeroData) })]
    [HarmonyPostfix]
    public static void GetHeroNameHeroDataPostfix(ref string __result)
    {
        Translate(ref __result);
    }

    private static void Translate(ref string result)
    {
        try
        {
            if (string.IsNullOrEmpty(result)) return;

            if (StandaloneTitles.TryGetValue(result, out var standalone))
            {
                result = standalone;
                return;
            }

            // GetHeroName returns the full, untranslated "family+given" name verbatim in two
            // native branches (invalid/dead hero; the mutual-hater case) - neither is coverable by
            // TranslateNamePart's single-fragment dictionary below, so try an exact whole-name
            // match against heroFullNames.txt first.
            if (_fullNameDictionary.TryGetValue(result, out var fullName))
            {
                result = fullName;
                return;
            }

            foreach (var (suffix, english) in RelationSuffixes)
            {
                if (!result.EndsWith(suffix, StringComparison.Ordinal)) continue;

                var prefix = result.Substring(0, result.Length - suffix.Length);
                result = FormatWithPrefix(prefix, english);
                return;
            }

            // "儿" child-affix (informal address by given name, e.g. "映泉儿" in the former-lover
            // case) - strip it and translate the given name underneath via the same fragment
            // dictionary used for family names.
            const string childSuffix = "儿";
            if (result.Length > childSuffix.Length && result.EndsWith(childSuffix, StringComparison.Ordinal))
            {
                result = TranslateNamePart(result.Substring(0, result.Length - childSuffix.Length));
                return;
            }

            // Bare given-name (former-lover case) or bare family-name (stranger/favor-tier case)
            // fallback - no fixed suffix to strip here, so just run the whole result through the
            // same fragment dictionary. Requires the SpeHeroData Name column's family/given halves
            // to be extracted as their own standalone raw candidates (see
            // Tests/DynamicStringSources.cs's DynamicStringNamePartColumnSources) rather than only the
            // whole "Family.Given" compound, since HeroData strips the "." separator at load time.
            result = TranslateNamePart(result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"Error in GetHeroName translation postfix: {ex}");
        }
    }

    private static string FormatWithPrefix(string prefix, string english)
    {
        if (prefix.Length == 0) return english;

        // KnownPrefixes are possessive modifiers, not names - keep them ahead of the relation
        // word (e.g. "Sect Leader's Brother", "Sworn Brother"), unlike an actual translated
        // family/given name, which reads better after the relation word (e.g. "Senior Sister
        // Jiang" rather than "Jiang Senior Sister").
        foreach (var (known, knownEnglish) in KnownPrefixes)
        {
            if (prefix == known) return $"{knownEnglish} {english}";
        }

        // Family/given name - looked up in this class's own private heroNameParts.txt.yaml
        // dictionary (see LoadNamePartDictionary), not DynamicStringPatches' global substring
        // dictionary.
        return $"{english} {TranslateNamePart(prefix)}";
    }

    // HeroData.GetHeroForceLvDescribe(fullName: false) builds the compact battle-UI force tag
    // (e.g. Canvas/BattleUIPanel/NowActiveHero/NameBack/Force) by taking the first 2 characters
    // of the raw force name (String.Substring(name, 0, 2), e.g. "仙霞派" -> "仙霞") and
    // concatenating the colored rank text onto it - same combinatorial-native-computation shape as
    // GetHeroName above, just truncation instead of relation-word branching. The fullName: true
    // path concatenates the WHOLE untruncated force name instead, which DynamicStringColumnSources'
    // ordinary ForceData.csv column-1 extraction already covers via the generic substring
    // dictionary - so this postfix only needs to handle the fullName: false case, gated directly
    // on the method's own bool parameter (no ambiguity about which case produced __result, unlike
    // GetHeroName's postfix which has to infer shape from the string itself).
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetHeroForceLvDescribe), new[] { typeof(bool) })]
    [HarmonyPostfix]
    public static void GetHeroForceLvDescribePostfix(bool fullName, ref string __result)
    {
        try
        {
            if (fullName || string.IsNullOrEmpty(__result) || __result.Length < 2) return;

            var prefix = __result.Substring(0, 2);
            if (!_forceNamePartDictionary.TryGetValue(prefix, out var translated)) return;

            __result = translated + __result.Substring(2);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"Error in GetHeroForceLvDescribe translation postfix: {ex}");
        }
    }
}
