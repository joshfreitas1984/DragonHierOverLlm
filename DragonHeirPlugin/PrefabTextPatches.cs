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

/// <summary>
/// Replaces hardcoded Chinese UI text baked directly into prefabs at load time, using an exact
/// raw-string lookup against the flat raw/result dictionary produced by
/// FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow.PackagePrefabTextAsync
/// (Files/Mod/dumpedPrefabText.txt.yaml, deployed to BepInEx\plugins\resources\ next to this
/// plugin - same "resources" folder ResourceIoPatches.cs already uses for CSV overrides):
/// <code>
/// - raw: 地图一览
///   result: Map Overview
/// </code>
///
/// Only TMPro.TMP_Text and UnityEngine.UI.Text's "text" field is handled - the two "primary" text
/// fields AssetDumperWorkflowTests.cs dumps to dumpedPrefabText.txt (see IsPrimaryTextField
/// there). Other dumped fields (plotText, describe, tutorialText, eventDescribe,
/// startRemindText, choiceText, etc.) all live on plain data classes (SinglePlotData, InnData,
/// EventData, ...) that are already populated from the existing CSV workflow
/// (Tests/GameFileHandling.cs + ResourceIoPatches.cs's whole-file TextAsset override) - translating
/// the CSV is enough for those, no runtime patch needed. This is a deliberate scope decision, not
/// an oversight - broader field coverage can follow up later if untranslated text turns up that
/// isn't covered by a CSV.
///
/// Why this patches Resources.Load/AssetBundle.LoadAsset/SceneManager.Internal_SceneLoaded instead
/// of TMP_Text/UI.Text lifecycle methods (Awake/OnEnable/set_text): a prefab or scene asset's
/// serialized fields are populated directly from native IL2CPP deserialization, which does not
/// invoke C# property setters or Unity lifecycle callbacks for the initial value baked into the
/// asset - by the time Awake/OnEnable/set_text would fire (if they fire at all for a given field),
/// the original Chinese text may already be in place with no observable "set" event to hook.
/// Patching the asset-load call itself and walking the resulting GameObject's component tree
/// directly (mirroring the offline AssetDumperWorkflowTests.cs scan, and the old Mono-only
/// XUnity.ResourceRedirector-based TextReplacerPlugin this replaces - ResourceRedirector doesn't
/// support IL2CPP) sees the data as soon as it exists, regardless of whether anything ever "sets"
/// it in the C# sense. Resources.Load/AssetBundle.LoadAsset alone miss any GameObject that is part
/// of a *scene* file's own serialized contents rather than a standalone loaded prefab (e.g. the
/// Start/title screen's UI) - those are instantiated directly by Unity's scene loader, never
/// routed through either load call - so SceneManager.Internal_SceneLoaded is also patched to catch
/// that category, walking scene.GetRootGameObjects() once the scene has finished loading.
///
/// IL2CPP interop safety (see .github/instructions/dragonheirplugin.instructions.md):
/// - No generic Cast&lt;T&gt;/TryCast&lt;T&gt;/AddComponent&lt;T&gt;/GetComponentsInChildren&lt;T&gt;/
///   FindObjectsOfType&lt;T&gt; anywhere, and no C# `is`/`as` pattern matching against IL2CPP wrapper
///   types either (that syntax compiles down to the same generic TryCast&lt;T&gt; machinery under
///   Il2CppInterop). Il2CppType.From(System.Type) (non-generic) is used instead of the generic
///   Il2CppType.Of&lt;T&gt;() to get the Il2CppSystem.Type values GetComponents(Type) needs.
/// - GameObject.GetComponents(Il2CppSystem.Type) is Unity's own inheritance-aware native lookup
///   (finds TMP_Text/UI.Text or any subclass, e.g. TextMeshProUGUI) - requesting the specific
///   type up front and reconstructing each result via the confirmed-safe (IntPtr) pointer-wrap
///   constructor (same pattern as ResourceIoPatches' `new TextAsset(__result.Pointer)`) avoids
///   ever needing to inspect/guess a concrete runtime subclass name.
/// - AssetBundle.LoadAsset(string) has no Type parameter to check like Resources.Load does, so
///   the returned object's real IL2CPP class is queried directly via
///   IL2CPP.il2cpp_object_get_class/il2cpp_class_get_namespace_/il2cpp_class_get_name_ (the same
///   non-generic technique UnityLogCapture.FormatMessage uses) instead of casting it.
/// - Every patch body and tree-walk step is wrapped in try/catch and fails safe (leaves the
///   original text untouched on any error), per the interop safety rules.
/// </summary>
internal static class PrefabTextPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");
    private const string DictionaryFileName = "dumpedPrefabText.txt.yaml";

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

                // Searched recursively rather than a fixed flat path - the file is deployed
                // alongside the CSV overrides under a subfolder mirroring the game's actual
                // Resources.Load path (e.g. resources\GameData\dumpedPrefabText.txt.yaml), same
                // convention ResourceIoPatches uses for its own override files.
                var dictionaryFile = Directory
                    .EnumerateFiles(ResourcesDir, DictionaryFileName, SearchOption.AllDirectories)
                    .FirstOrDefault();

                if (dictionaryFile == null)
                {
                    MainPlugin.Logger?.LogWarning(
                        $"PrefabTextPatches: no '{DictionaryFileName}' found anywhere under '{ResourcesDir}' - prefab text replacement disabled.");
                    return _replacements;
                }

                var yaml = File.ReadAllText(dictionaryFile);
                var deserializer = new DeserializerBuilder()
                    .WithNamingConvention(CamelCaseNamingConvention.Instance)
                    .IgnoreUnmatchedProperties()
                    .Build();
                var entries = deserializer.Deserialize<List<PrefabTextEntry>>(yaml) ?? [];

                foreach (var entry in entries)
                {
                    if (!string.IsNullOrEmpty(entry.Raw))
                        _replacements[entry.Raw] = entry.Result ?? entry.Raw;
                }

                MainPlugin.Logger?.LogWarning(
                    $"PrefabTextPatches: loaded {_replacements.Count} prefab text replacements from '{dictionaryFile}'.");
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"PrefabTextPatches: failed to load dictionary under '{ResourcesDir}': {ex}");
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

    // Catches text baked directly into a *scene* file (e.g. the Start/title screen) - such
    // GameObjects are never routed through Resources.Load/AssetBundle.LoadAsset at all, since
    // they're part of the scene's own serialized contents and are instantiated by Unity's scene
    // loader directly. SceneManager.Internal_SceneLoaded fires once a scene has fully finished
    // loading (all its root GameObjects already instantiated), so walking
    // scene.GetRootGameObjects() here catches exactly this category, using the same recursive
    // tree-walk as the asset-load patches above.
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

    // AssetBundle.LoadAsset(string) is ambiguous to AccessTools.DeclaredMethod's simple
    // name+parameter-type lookup: this build also has a generic LoadAsset<T>(string) overload with
    // the exact same (string) parameter list, and DeclaredMethod's Type.GetMethod call doesn't
    // disambiguate by generic arity - both candidates match, so a plain
    // [HarmonyPatch(typeof(AssetBundle), nameof(AssetBundle.LoadAsset), new[] { typeof(string) })]
    // attribute throws AmbiguousMatchException at Harmony.CreateAndPatchAll time (plugin fails to
    // load entirely). [HarmonyTargetMethod] lets us resolve the exact non-generic MethodInfo
    // ourselves via LINQ instead of relying on Harmony's ambiguous default resolution. The
    // class-level [HarmonyPatch] attribute must specify ONLY the declaring type here (no method
    // name) - Harmony throws "You cannot combine TargetMethod ... with individual annotations" if
    // a method name/args annotation is combined with a [HarmonyTargetMethod] resolver on the same
    // class.
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
        if (!string.IsNullOrEmpty(currentText) && Replacements.TryGetValue(currentText, out var replacement))
            setText(replacement);
    }

    private class PrefabTextEntry
    {
        public string Raw { get; set; } = string.Empty;
        public string Result { get; set; } = string.Empty;
    }
}
