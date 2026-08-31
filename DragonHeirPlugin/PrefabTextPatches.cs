using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using HarmonyLib;
using Il2CppInterop.Runtime;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EnglishPatch;

// Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
internal static class PrefabTextPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");
    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    private const string DictionaryFilePattern = "dumpedPrefabText*.txt.yaml";

    private static Dictionary<string, string> _replacements;
    private static Il2CppSystem.Type _tmpTextType;
    private static Il2CppSystem.Type _uiTextType;

    private static Dictionary<string, string> Replacements
    {
        get
        {
            if (_replacements != null)
                return _replacements;

            _replacements = new Dictionary<string, string>();
            try
            {
                if (!Directory.Exists(ResourcesDir))
                {
                    MainPlugin.Logger?.LogWarning(
                        $"PrefabTextPatches: resources directory '{ResourcesDir}' does not exist - prefab text replacement disabled.");
                    return _replacements;
                }

                // Searched recursively rather than a fixed flat path - these files are deployed
                // alongside the CSV overrides under a subfolder mirroring the game's actual
                // Resources.Load path (e.g. resources\GameData\dumpedPrefabText.txt.yaml), same
                // convention ResourceIoPatches uses for its own override files.
                var dictionaryFiles = Directory
                    .EnumerateFiles(ResourcesDir, DictionaryFilePattern, SearchOption.AllDirectories)
                    .ToList();

                if (dictionaryFiles.Count == 0)
                {
                    MainPlugin.Logger?.LogWarning(
                        $"PrefabTextPatches: no '{DictionaryFilePattern}' files found anywhere under '{ResourcesDir}' - prefab text replacement disabled.");
                    return _replacements;
                }

                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .IgnoreUnmatchedProperties()
                    .Build();

                foreach (var dictionaryFile in dictionaryFiles)
                {
                    var yaml = File.ReadAllText(dictionaryFile);
                    var entries = deserializer.Deserialize<List<PrefabTextEntry>>(yaml) ?? [];

                    foreach (var entry in entries)
                    {
                        if (!string.IsNullOrEmpty(entry.Raw))
                            _replacements[entry.Raw] = entry.Result ?? entry.Raw;
                    }

                    MainPlugin.Logger?.LogWarning(
                        $"PrefabTextPatches: loaded entries from '{dictionaryFile}' ({_replacements.Count} total so far).");
                }
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"PrefabTextPatches: failed to load dictionaries under '{ResourcesDir}': {ex}");
            }

            return _replacements;
        }
    }


    // Non-generic Il2CppType.From(System.Type) - not the generic Il2CppType.Of<T>() - per the
    // interop safety notes above.
    private static Il2CppSystem.Type TmpTextType => _tmpTextType ??= Il2CppType.From(typeof(TMP_Text));
    private static Il2CppSystem.Type UiTextType => _uiTextType ??= Il2CppType.From(typeof(Text));

    [HarmonyPatch(typeof(Resources), nameof(Resources.Load), new[] { typeof(string), typeof(Il2CppSystem.Type) })]
    [HarmonyPostfix]
    private static void ResourcesLoad_Postfix(string path, Il2CppSystem.Type systemTypeInstance, ref UnityEngine.Object __result)
    {
        try
        {
            if (__result == null || Replacements.Count == 0 || systemTypeInstance?.FullName != "UnityEngine.GameObject")
                return;

            var go = new GameObject(__result.Pointer);
            ProcessGameObjectRecursive(go);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches.ResourcesLoad_Postfix failed for '{path}': {ex}");
        }
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    [HarmonyPatch(typeof(SceneManager), "Internal_SceneLoaded")]
    [HarmonyPostfix]
    private static void SceneLoaded_Postfix(Scene scene, LoadSceneMode mode)
    {
        try
        {
            if (Replacements.Count == 0)
                return;

            foreach (var go in scene.GetRootGameObjects())
            {
                if (go != null)
                    ProcessGameObjectRecursive(go);
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches.SceneLoaded_Postfix failed: {ex}");
        }
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    [HarmonyPatch(typeof(AssetBundle))]
    internal static class AssetBundleLoadAssetPatch
    {
        [HarmonyTargetMethod]
        private static MethodBase TargetMethod()
        {
            return typeof(AssetBundle)
                .GetMethods(BindingFlags.Public | BindingFlags.Instance)
                .Single(m => m.Name == nameof(AssetBundle.LoadAsset)
                    && !m.IsGenericMethod
                    && m.GetParameters() is [{ ParameterType.Name: "String" }]);
        }

        [HarmonyPostfix]
        private static void Postfix(string name, ref UnityEngine.Object __result)
        {
            try
            {
                if (__result == null || Replacements.Count == 0 || !IsGameObject(__result))
                    return;

                var go = new GameObject(__result.Pointer);
                ProcessGameObjectRecursive(go);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"PrefabTextPatches.AssetBundleLoadAsset_Postfix failed for '{name}': {ex}");
            }
        }
    }

    // AssetBundle.LoadAsset(string) has no requested-Type parameter to check like Resources.Load
    // does, so the object's real IL2CPP class is queried directly instead of casting - same
    // non-generic technique as UnityLogCapture.FormatMessage.
    private static bool IsGameObject(UnityEngine.Object obj)
    {
        var klass = IL2CPP.il2cpp_object_get_class(obj.Pointer);
        var ns = IL2CPP.il2cpp_class_get_namespace_(klass);
        var name = IL2CPP.il2cpp_class_get_name_(klass);
        return ns == "UnityEngine" && name == "GameObject";
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    [ThreadStatic]
    private static bool _inTextSetterPostfix;

    [HarmonyPatch(typeof(TMP_Text), nameof(TMP_Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    [HarmonyPriority(Priority.First)]
    private static void TmpTextSetText_Postfix(TMP_Text __instance)
    {
        ApplyExactMatchToComponentText(() => __instance.text, v => __instance.text = v);
    }

    [HarmonyPatch(typeof(Text), nameof(Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    [HarmonyPriority(Priority.First)]
    private static void UiTextSetText_Postfix(Text __instance)
    {
        ApplyExactMatchToComponentText(() => __instance.text, v => __instance.text = v);
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    private static void ApplyExactMatchToComponentText(Func<string> getText, Action<string> setText)
    {
        if (_inTextSetterPostfix || Replacements.Count == 0)
            return;

        try
        {
            var current = getText();
            if (string.IsNullOrEmpty(current))
                return;

            var lookupKey = NormalizeForLookup(current);
            if (!Replacements.TryGetValue(lookupKey, out var replacement) || replacement == lookupKey)
                return;

            _inTextSetterPostfix = true;
            try { setText(DenormalizeFromLookup(replacement)); }
            finally { _inTextSetterPostfix = false; }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches: text setter postfix failed: {ex}");
        }
    }

    private static void ProcessGameObjectRecursive(GameObject go)
    {
        try
        {
            foreach (var component in go.GetComponents(TmpTextType))
            {
                if (component == null)
                    continue;

                var tmpText = new TMP_Text(component.Pointer);
                ReplaceIfKnown(tmpText.text, replacement => tmpText.text = replacement);
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches: failed reading TMP_Text components: {ex}");
        }

        try
        {
            foreach (var component in go.GetComponents(UiTextType))
            {
                if (component == null)
                    continue;

                var uiText = new Text(component.Pointer);
                ReplaceIfKnown(uiText.text, replacement => uiText.text = replacement);
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches: failed reading UI.Text components: {ex}");
        }

        Transform transform;
        try
        {
            transform = go.transform;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches: failed reading transform: {ex}");
            return;
        }

        var childCount = transform.childCount;
        for (var i = 0; i < childCount; i++)
        {
            try
            {
                var child = transform.GetChild(i);
                if (child != null)
                    ProcessGameObjectRecursive(child.gameObject);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"PrefabTextPatches: failed recursing into child {i}: {ex}");
            }
        }
    }

    private static void ReplaceIfKnown(string currentText, Action<string> setText)
    {
        if (string.IsNullOrEmpty(currentText))
            return;

        if (Replacements.TryGetValue(NormalizeForLookup(currentText), out var replacement))
            setText(DenormalizeFromLookup(replacement));
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    private static string NormalizeForLookup(string text) => text.Replace("\n", "\\n").Replace("\r", "");

    // Reverses NormalizeForLookup for the translated Result value before it is assigned back to a
    // real TMP_Text/UI.Text component, so the rendered text has genuine newlines again rather than
    // a literal "\n" appearing on-screen.
    private static string DenormalizeFromLookup(string text) => text.Replace("\\n", "\n");

    private class PrefabTextEntry
    {
        public string Raw { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }
}
