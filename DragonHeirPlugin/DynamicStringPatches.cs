using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using TMPro;
using UnityEngine.UI;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EnglishPatch;

/// <summary>
/// Case 4 (see the "dynamic/hardcoded in-code string translation plan" repo memory - hard case) -
/// runtime translation of hardcoded string literals compiled directly into IL2CPP game code that
/// the CSV-driven translation pipeline (Tests/GameFileHandling.cs) and PrefabTextPatches.cs cannot
/// reach because they aren't stored in a TextAsset or baked into a prefab field. Two distinct
/// sub-cases, both handled by the same flat translated dictionary:
///  - Runtime-assembled/concatenated strings, e.g.
///    SaveLoadMenuController.GetRecentSaveSlotDescribe's `lVar2.Tasks + "\n\n架势\n" +
///    lVar2.saveDataPath` (compiles to a String.Concat call).
///  - Plain literal assignment with no concatenation at all, e.g. `field = "架势";` later read and
///    displayed - never calls String.Concat/Format, so a source-level patch on those methods alone
///    would miss it entirely.
///
/// **Two-layer patch strategy, both global/reflection-driven (no per-method YAML configuration,
/// no need to ever launch the game just to discover which method/field to target)**:
///  1. **Source-level**: every public static, non-generic, string-returning overload of
///     `System.String.Concat`/`System.String.Format` is Harmony-postfixed (found via reflection,
///     not one bespoke postfix per overload) and has the flat dictionary applied as an exact
///     substring replace on the call's result. Catches concatenation-built strings as early as
///     possible, including ones that end up somewhere other than on-screen UI (logs, tooltips
///     rendered through a non-TMP_Text/Text component, etc).
///  2. **Sink-level**: `TMP_Text.text`'s and `UnityEngine.UI.Text.text`'s setters are also
///     Harmony-postfixed, re-reading the component's own `.text` after the original setter ran and
///     re-applying it (via the same setter) with the dictionary substring-replaced. This is what
///     catches case (b) above - a field holding nothing but a raw literal, assigned straight to a
///     UI component's text with no concatenation call in between - and is also a safety net that
///     independently catches case (a) too (defense in depth) for any text that does end up
///     displayed. A `[ThreadStatic]` re-entrancy guard prevents the setter-patches-calling-the-
///     setter-again pattern from looping (the second, inner call sees already-translated text with
///     no further dictionary matches and is a no-op, but the guard makes that termination
///     unconditional rather than relying on dictionary data never re-introducing raw text).
///
/// Neither layer needs to know in advance which fragments belong to which method/field/component -
/// entries that don't appear in a given string are harmless no-ops, so the same global dictionary
/// is reused everywhere.
///
/// Pipeline (mirrors CSV/PrefabText - see FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow
/// and Tests/GameFileHandling.cs):
///   Converter --dynamic-string-candidates → review → merge into
///   Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt → "1c. ExportDynamicStringsIntoTranslated"
///   → "2. MergeFilesIntoTranslated" → translate → "6. Package to Game Files" produces
///   Files/Mod/dynamicStrings.txt.yaml (flat `raw`/`result` list), deployed to
///   BepInEx\plugins\resources\ alongside the CSV overrides.
///
/// **Why substring replacement instead of `string.Format`-ing the call's arguments**: confirmed via
/// earlier discovery-log testing that these concatenation call sites are frequently built from
/// fields/locals rather than passed-in parameters (e.g. `GetRecentSaveSlotDescribe()` takes no
/// parameters at all), so there is nothing reliable to substitute into a template's `{0}`/`{1}`
/// placeholders. Only the hardcoded literal fragments (e.g. `"架势"`) need translating; everything
/// else concatenated alongside them is either already-translated data from elsewhere (CSV
/// pipeline) or non-text data (e.g. a date) and is left untouched by a plain substring replace.
///
/// IL2CPP interop safety: `System.String` is an ordinary BCL type (no interop concerns at all).
/// `TMP_Text`/`UnityEngine.UI.Text` ARE IL2CPP-wrapped game types, but ordinary Harmony
/// prefix/postfix patching of their methods (including property setters) is a confirmed-safe
/// pattern (see dragonheirplugin.instructions.md's "Confirmed-safe patterns" and
/// PrefabTextPatches.cs, which already patches these same two types' properties directly via
/// `tmpText.text = replacement;`/`uiText.text = replacement;`). No generic
/// Cast&lt;T&gt;/TryCast&lt;T&gt; calls anywhere.
/// </summary>
internal static class DynamicStringPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");
    private const string DictionaryFileName = "dynamicStrings.txt.yaml";

    private static List<DictionaryEntry> _dictionary = new();

    [ThreadStatic]
    private static bool _inTextSetterPostfix;

    public sealed class DictionaryEntry
    {
        public string Raw { get; set; }
        public string Result { get; set; }
    }

    /// <summary>Loads dynamicStrings.txt.yaml (if present) and patches every public static
    /// string-returning overload of System.String.Concat/Format, plus TMP_Text.text and
    /// UnityEngine.UI.Text.text's setters. Safe to call even if the dictionary file is missing
    /// (patches still apply, just as a no-op) or a given overload/setter fails to patch (that one
    /// is skipped and logged, the rest still patch).</summary>
    public static void PatchAll()
    {
        try
        {
            _dictionary = LoadDictionary();
            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Loaded {_dictionary.Count} translated fragment(s) from '{DictionaryFileName}'.");

            var harmony = new Harmony("EnglishPatch.DynamicStringPatches");
            var postfix = new HarmonyMethod(typeof(DynamicStringPatches), nameof(GenericPostfix));

            var targets = typeof(string)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => (m.Name == nameof(string.Concat) || m.Name == nameof(string.Format))
                    && m.ReturnType == typeof(string)
                    && !m.IsGenericMethod);

            var patched = 0;
            foreach (var method in targets)
            {
                try
                {
                    harmony.Patch(method, postfix: postfix);
                    patched++;
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to patch {method}: {ex}");
                }
            }

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Patched {patched} String.Concat/Format overload(s).");

            // Sink-level patches: attribute-driven ([HarmonyPatch] on TmpTextSetText_Postfix /
            // UiTextSetText_Postfix below), applied via PatchAll(Type) rather than manual
            // reflection since the target methods are known/fixed at compile time.
            harmony.PatchAll(typeof(DynamicStringPatches));
            MainPlugin.Logger.LogInfo("[DynamicStringPatches] Patched TMP_Text.text/UI.Text.text setters.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] PatchAll failed: {ex}");
        }
    }

    private static List<DictionaryEntry> LoadDictionary()
    {
        try
        {
            var path = FindResourceFile(DictionaryFileName);
            if (path == null) return new List<DictionaryEntry>();

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();
            var yaml = File.ReadAllText(path);
            var entries = deserializer.Deserialize<List<DictionaryEntry>>(yaml) ?? new List<DictionaryEntry>();

            // Longest-fragment-first: entries are applied via sequential substring replace
            // (ApplyDictionary), so a shorter fragment that happens to be a substring of a longer
            // one (e.g. "势" vs "架势") must not get a chance to match first - it would corrupt the
            // longer fragment's span before that entry's own (more specific/correct) replacement
            // ever runs. Sorting longest-first guarantees the most specific match always wins.
            return entries.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load {DictionaryFileName}: {ex}");
            return new List<DictionaryEntry>();
        }
    }

    private static string FindResourceFile(string fileName)
    {
        return Directory.Exists(ResourcesDir)
            ? Directory.GetFiles(ResourcesDir, fileName, SearchOption.AllDirectories).FirstOrDefault()
            : null;
    }

    // Applied to every patched String.Concat/Format overload's result. _dictionary is expected to
    // stay small (low hundreds of entries at most), so an unconditional per-call scan is cheap
    // relative to the sheer call volume of String.Concat/Format in a running Unity game; skip
    // entirely when the dictionary is empty (e.g. before the pipeline has produced one yet).
    private static void GenericPostfix(ref string __result)
    {
        if (__result == null || _dictionary.Count == 0) return;

        try
        {
            __result = ApplyDictionary(__result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Postfix failed: {ex}");
        }
    }

    // Sink-level patch: catches text that reaches a TMP_Text/UI.Text component regardless of how
    // it was built (concatenation, string.Format, or - the case String.Concat/Format patching
    // alone can't reach - a plain literal field assignment like `field = "架势";` later read
    // straight into .text with no concatenation call at all). Re-reads the component's own .text
    // after the original setter ran, and if the dictionary changes anything, writes it back through
    // the same (patched) setter. The [ThreadStatic] guard makes the resulting re-entrant call
    // unconditionally terminate on its second pass (skips the dictionary scan entirely) rather than
    // relying on the replaced text simply no longer containing any raw fragments.
    [HarmonyPatch(typeof(TMP_Text), nameof(TMP_Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void TmpTextSetText_Postfix(TMP_Text __instance)
    {
        ApplyToComponentText(() => __instance.text, v => __instance.text = v);
    }

    [HarmonyPatch(typeof(Text), nameof(Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiTextSetText_Postfix(Text __instance)
    {
        ApplyToComponentText(() => __instance.text, v => __instance.text = v);
    }

    private static void ApplyToComponentText(Func<string> getText, Action<string> setText)
    {
        if (_inTextSetterPostfix || _dictionary.Count == 0) return;

        try
        {
            var current = getText();
            if (string.IsNullOrEmpty(current)) return;

            var replaced = ApplyDictionary(current);
            if (replaced == current) return;

            _inTextSetterPostfix = true;
            try { setText(replaced); }
            finally { _inTextSetterPostfix = false; }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Text setter postfix failed: {ex}");
        }
    }

    private static string ApplyDictionary(string input)
    {
        var result = input;
        foreach (var entry in _dictionary)
        {
            if (string.IsNullOrEmpty(entry.Raw)) continue;
            if (result.Contains(entry.Raw))
                result = result.Replace(entry.Raw, entry.Result ?? string.Empty);
        }
        return result;
    }
}


