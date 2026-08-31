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
    private static Il2CppSystem.Type _uiLabelType;

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
    // NGUI's own label type - has its own get_text()/set_text(string), entirely separate from
    // UnityEngine.UI.Text/TMP_Text, confirmed via live diagnostic: a Dropdown's captionText
    // (UI.Text) renders fine, but a static NGUI UILabel sitting next to it never got touched.
    private static Il2CppSystem.Type UiLabelType => _uiLabelType ??= Il2CppType.From(typeof(UILabel));

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

    // Coverage gap found investigating BranchLeaderSettingTab(Clone) (game code calls
    // GlobalData.AddChild -> Object.Instantiate(prefabField, parent) directly on an
    // already-in-memory prefab reference, never routed through Resources.Load/AssetBundle.LoadAsset).
    // Instantiate copies serialized field values natively without invoking the managed text
    // setters our other hooks rely on, so any statically-baked (never runtime-reassigned) label
    // text on such a clone was never reachable by any existing hook. Mirrors the non-generic
    // overload-targeting approach AssetBundleLoadAssetPatch uses, since Object.Instantiate has
    // several non-generic overloads besides the generic Instantiate<T> convenience wrapper.
    [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.Instantiate), new[] { typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void Instantiate1_Postfix(ref UnityEngine.Object __result) => InstantiatePostfix(ref __result);

    [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.Instantiate), new[] { typeof(UnityEngine.Object), typeof(Transform) })]
    [HarmonyPostfix]
    private static void Instantiate2_Postfix(ref UnityEngine.Object __result) => InstantiatePostfix(ref __result);

    [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.Instantiate), new[] { typeof(UnityEngine.Object), typeof(Transform), typeof(bool) })]
    [HarmonyPostfix]
    private static void Instantiate3_Postfix(ref UnityEngine.Object __result) => InstantiatePostfix(ref __result);

    [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.Instantiate), new[] { typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion) })]
    [HarmonyPostfix]
    private static void Instantiate4_Postfix(ref UnityEngine.Object __result) => InstantiatePostfix(ref __result);

    [HarmonyPatch(typeof(UnityEngine.Object), nameof(UnityEngine.Object.Instantiate), new[] { typeof(UnityEngine.Object), typeof(Vector3), typeof(Quaternion), typeof(Transform) })]
    [HarmonyPostfix]
    private static void Instantiate5_Postfix(ref UnityEngine.Object __result) => InstantiatePostfix(ref __result);

    // Confirmed via live playtest: BranchLeaderSettingTab(Clone) is reached through
    // GlobalData.AddChild, which internally calls the GENERIC Object.Instantiate<T>(...)
    // convenience overload. That generic method can NOT be safely Harmony-patched itself - IL2CPP
    // shares one native method body across every reference-type T (GameObject, ColorGrading,
    // Bloom, ...), so detouring the "closed to GameObject" MethodInfo intercepts calls for every
    // T and force-casts unrelated types to GameObject, crashing the game (confirmed - see
    // /memories/repo/il2cpp-generic-instantiate-patch-danger.md). Patching this game-specific
    // wrapper method directly instead is safe: it's a concrete, non-shared method with its own
    // real GameObject return type. GlobalData has multiple overloaded AddChild methods (confirmed
    // via HarmonyException: AmbiguousMatchException), so resolved via reflection like
    // AssetBundleLoadAssetPatch instead of a plain [HarmonyPatch(typeof(GlobalData), "AddChild")].
    [HarmonyPatch(typeof(GlobalData))]
    internal static class GlobalDataAddChildPatch
    {
        [HarmonyTargetMethod]
        private static MethodBase TargetMethod()
        {
            return typeof(GlobalData)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Single(m => m.Name == "AddChild"
                    && !m.IsGenericMethod
                    && m.ReturnType == typeof(GameObject)
                    && m.GetParameters() is [{ ParameterType.Name: "GameObject" }, { ParameterType.Name: "GameObject" }]);
        }

        [HarmonyPostfix]
        private static void Postfix(ref GameObject __result)
        {
            try
            {
                if (__result == null || Replacements.Count == 0)
                    return;

                ProcessGameObjectRecursive(__result);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger?.LogError($"PrefabTextPatches.GlobalDataAddChildPatch failed: {ex}");
            }
        }
    }

    private static void InstantiatePostfix(ref UnityEngine.Object __result)
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
            MainPlugin.Logger?.LogError($"PrefabTextPatches.Instantiate_Postfix failed: {ex}");
        }
    }

    // Second, independent theory for the same still-Chinese symptom: Dropdown/TMP_Dropdown's own
    // RefreshShownValue() assigns captionText.text FROM its serialized `options` list (separate
    // baked data from any Text/TMP_Text component), and may run as engine-internal/AOT code that
    // never routes through the interop-patched TMP_Text.text/UI.Text.text setters at all (same
    // AOT-bypass class as the documented native String.Format case). Patched by string name since
    // RefreshShownValue is protected - re-applies the exact-match dictionary to captionText AFTER
    // Unity's own logic has (potentially) just overwritten it back to the raw baked value.
    [HarmonyPatch(typeof(Dropdown), "RefreshShownValue")]
    [HarmonyPostfix]
    private static void DropdownRefreshShownValue_Postfix(Dropdown __instance)
    {
        try
        {
            var caption = __instance?.captionText;
            DiagLog("Dropdown.RefreshShownValue", $"name='{__instance?.name}' captionText='{caption?.text}'");
            if (Replacements.Count == 0) return;
            if (caption != null)
                ReplaceIfKnown(caption.text, v => caption.text = v);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches.DropdownRefreshShownValue_Postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(TMP_Dropdown), "RefreshShownValue")]
    [HarmonyPostfix]
    private static void TmpDropdownRefreshShownValue_Postfix(TMP_Dropdown __instance)
    {
        try
        {
            var caption = __instance?.captionText;
            DiagLog("TMP_Dropdown.RefreshShownValue", $"name='{__instance?.name}' captionText='{caption?.text}'");
            if (Replacements.Count == 0) return;
            if (caption != null)
                ReplaceIfKnown(caption.text, v => caption.text = v);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches.TmpDropdownRefreshShownValue_Postfix failed: {ex}");
        }
    }

    // TEMPORARY diagnostic for the still-unresolved UpgradePriorityText investigation - remove
    // once resolved. Writes directly to a file (never MainPlugin.Logger, to avoid any reentrancy
    // risk) so a single playtest shows exactly which hooks fire, in what order, with what text.
    private static void DiagLog(string stage, string detail)
    {
        try
        {
            var path = Path.Combine(PluginDir, "prefabTextDiag.log");
            File.AppendAllText(path, $"[{DateTime.Now:HH:mm:ss.fff}] [{stage}] {detail}{Environment.NewLine}");
        }
        catch { /* best-effort */ }
    }

    private static bool IsDiagTarget(string text, string goName) =>
        (text != null && text.Contains("优先")) || (goName != null && goName.Contains("UpgradePriority"));

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

    [HarmonyPatch(typeof(UILabel), nameof(UILabel.text), MethodType.Setter)]
    [HarmonyPostfix]
    [HarmonyPriority(Priority.First)]
    private static void UiLabelSetText_Postfix(UILabel __instance)
    {
        ApplyExactMatchToComponentText(() => __instance.text, v => __instance.text = v);
    }

    // Detailed rationale and invariants: docs/prefabtextpatches-agent-reference.md
    private static void ApplyExactMatchToComponentText(Func<string> getText, Action<string> setText)
    {
        if (_inTextSetterPostfix)
            return;

        if (Replacements.Count == 0)
        {
            var probe = getText();
            if (IsDiagTarget(probe, null))
                DiagLog("SetterPostfix", $"SKIPPED - Replacements dictionary is EMPTY. current='{probe}'");
            return;
        }

        try
        {
            var current = getText();
            if (string.IsNullOrEmpty(current))
                return;

            if (IsDiagTarget(current, null))
                DiagLog("SetterPostfix", $"current='{current}'");

            var lookupKey = NormalizeForLookup(current);
            if (!Replacements.TryGetValue(lookupKey, out var replacement) || replacement == lookupKey)
            {
                if (IsDiagTarget(current, null))
                    DiagLog("SetterPostfix", $"NO DICTIONARY MATCH for '{current}' (normalized='{lookupKey}')");
                return;
            }

            _inTextSetterPostfix = true;
            try { setText(DenormalizeFromLookup(replacement)); }
            finally { _inTextSetterPostfix = false; }

            if (IsDiagTarget(current, null))
                DiagLog("SetterPostfix", $"REPLACED '{current}' -> '{replacement}'");
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

        try
        {
            foreach (var component in go.GetComponents(UiLabelType))
            {
                if (component == null)
                    continue;

                var uiLabel = new UILabel(component.Pointer);
                ReplaceIfKnown(uiLabel.text, replacement => uiLabel.text = replacement);
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PrefabTextPatches: failed reading UILabel components: {ex}");
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

        if (IsDiagTarget(currentText, null))
            DiagLog("ProcessGameObjectRecursive", $"found current='{currentText}'");

        if (Replacements.TryGetValue(NormalizeForLookup(currentText), out var replacement))
        {
            setText(DenormalizeFromLookup(replacement));
            if (IsDiagTarget(currentText, null))
                DiagLog("ProcessGameObjectRecursive", $"REPLACED '{currentText}' -> '{replacement}'");
        }
        else if (IsDiagTarget(currentText, null))
        {
            DiagLog("ProcessGameObjectRecursive", $"NO DICTIONARY MATCH for '{currentText}'");
        }
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
