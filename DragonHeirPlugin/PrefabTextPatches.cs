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
/// raw-string lookup against the flat raw/result dictionary(ies) produced by
/// FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow.PackagePrefabTextAsync
/// (Files/Mod/dumpedPrefabText*.txt.yaml, deployed to BepInEx\plugins\resources\ next to this
/// plugin - same "resources" folder ResourceIoPatches.cs already uses for CSV overrides):
/// <code>
/// - raw: 地图一览
///   result: Map Overview
/// </code>
///
/// Two source files are currently packaged, both loaded and merged into the same dictionary (see
/// DictionaryFilePattern/Replacements below):
///  - dumpedPrefabText.txt(.yaml): TMPro.TMP_Text/UnityEngine.UI.Text's "text" field only - the
///    two "primary" text fields AssetDumperWorkflowTests.cs dumps here (see IsPrimaryTextField
///    there).
///  - dumpedPrefabTextFromOtherFields.txt(.yaml): other MonoBehaviour fields (plotText, describe,
///    tutorialText, eventDescribe, startRemindText, choiceText, name, etc.) living on plain data
///    classes (SinglePlotData, InnData, EventData, ...) that AssetDumperWorkflowTests.cs dumps to
///    the diagnostic-only dumpedOtherText.txt - see Tests/GameFileHandling.cs's
///    DynamicStringOtherTextFields/ExtractDynamicStringCandidatesFromOtherText for exactly which
///    field names are trusted and why. **Moved here 2026-08-28** from the DynamicStrings
///    (substring/fragment) pipeline: an earlier version of this comment claimed these fields "are
///    already populated from the existing CSV workflow" - confirmed WRONG by grepping every
///    dumped GameData CSV (none of these values have a CSV source at all, see
///    GameFileHandling.cs's 2026-08-27 history note) - so they DO need their own runtime
///    replacement, same as the primary text fields above. Since every value on these fields is
///    always assigned as a complete, non-concatenated string (never built by runtime
///    String.Concat/Format), an exact match here is strictly safer than DynamicStringPatches'
///    bare-fragment substring dictionary (no risk of a shorter unrelated fragment mangling part of
///    an unmatched string).

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
/// **Second, sink-level patch added 2026-08-28 (TmpTextSetText_Postfix/UiTextSetText_Postfix):**
/// the load-time tree-walk above only ever sees a component's *baked* value at
/// Resources.Load/AssetBundle.LoadAsset/scene-load time. Some UI components (confirmed via an
/// in-game screenshot of a character-creation starting-bonus list showing
/// "Initial获得RandomlyWeapon", raw "初始获得随机武器") have their .text SET LATER AT RUNTIME by
/// game code (e.g. populating a dynamically-instantiated list item) - the load-time scan never
/// observes that value at all, since it isn't present on the GameObject tree yet when
/// Resources.Load/scene-load fires. Rather than only detect this per-value (see
/// Tests/GameFileHandling.cs's DynamicStringPrimaryTextOverrides history), this is fixed
/// generally: TMP_Text.text/UI.Text.text's setters are now ALSO postfixed here, doing an EXACT
/// whole-string lookup against the same Replacements dictionary this class already loads (no
/// separate dictionary/file needed - dumpedPrefabText.txt.yaml already has a correct whole-phrase
/// entry for any string AssetDumperWorkflowTests.cs's offline scan found, since that scan reads
/// each field's serialized *default* value, which is exactly what a runtime-populated component
/// is initialized with before/when the game sets it).
///
/// **Ordering vs. DynamicStringPatches.cs's own sink-level postfixes on the SAME two setters:**
/// this class is Harmony-patched first, in MainPlugin.Load(), before DynamicStringPatches.PatchAll()
/// runs - but patch APPLICATION order doesn't determine POSTFIX EXECUTION order, Harmony priority
/// does. TmpTextSetText_Postfix/UiTextSetText_Postfix below are marked [HarmonyPriority(Priority.First)]
/// so they always run before DynamicStringPatches' same-named postfixes (left at the default
/// Priority.Normal) regardless of patch registration order. This matters because an exact
/// whole-string match here is strictly safer than DynamicStringPatches' bare-fragment substring
/// dictionary for text that IS a byte-identical, non-concatenated copy of a dumped prefab string -
/// running first means the whole string gets replaced wholesale before DynamicStringPatches' own
/// postfix ever runs, so its bare-fragment fallback entries (e.g. "初始"->"Initial",
/// "随机"->"Randomly") have nothing left to corrupt (no Chinese substrings remain once this postfix
/// has already replaced the whole string). Genuinely runtime-COMPOSED strings (concatenated with
/// other data, e.g. a save-slot description) will never byte-match a whole dumped prefab entry
/// here, so they correctly fall through unmodified to DynamicStringPatches' template/fragment
/// matching, which remains the only mechanism that can handle those.
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
    // Glob rather than a single exact filename - mirrors DynamicStringPatches.DictionaryFilePattern.
    // PrefabTextWorkflow-packaged dictionary files all share the same "raw"/"result" flat-list
    // shape regardless of which TextFileToSplit produced them, e.g. "dumpedPrefabText.txt.yaml"
    // (AssetDumperWorkflowTests' primary m_Text/text field scan) and
    // "dumpedPrefabTextFromOtherFields.txt.yaml" (Tests/GameFileHandling.cs's
    // ExtractDynamicStringCandidatesFromOtherText - other MonoBehaviour fields, e.g. plotText/
    // describe/name, moved here 2026-08-28 from the DynamicStrings pipeline since these values are
    // always whole, non-concatenated strings and so are safer as an exact match). Every matching
    // file is loaded and merged into the same in-memory dictionary (see Replacements below), so
    // adding a new source file never requires a plugin-side path change.
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

    // Sink-level patches (see this class's doc comment "Second, sink-level patch added
    // 2026-08-28" section) - catch text assigned to a TMP_Text/UI.Text component at arbitrary
    // runtime, not just what's already baked into the GameObject tree at asset/scene-load time.
    // [HarmonyPriority(Priority.First)] guarantees these run before DynamicStringPatches' own
    // same-named setter postfixes (left at the default Priority.Normal there), regardless of which
    // class's Harmony patches were registered first in MainPlugin.Load().
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

    // Exact whole-string lookup only (never substring/fragment replace) - unlike
    // DynamicStringPatches' generic sink-level postfix, this reuses the SAME Replacements
    // dictionary the load-time tree-walk above already loads, so it's safe against bare-fragment
    // corruption: a value here either matches a dumped prefab string byte-for-byte (safe to
    // replace wholesale) or it doesn't match at all (left untouched, falls through to
    // DynamicStringPatches for template/fragment handling if applicable).
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

    // AssetDumperWorkflowTests.cs dumps multi-line component text with real newlines collapsed to
    // a literal "\n" (two chars: backslash + n) so each dumped entry stays a single line in the
    // flat dump/CSV/YAML files - see AssetDumperWorkflowTests.cs's `text.Replace("\n", "\\n").Replace("\r", "")`.
    // The Replacements dictionary (Raw/Result) is keyed/valued using that same escaped form, but a
    // live TMP_Text/UI.Text component's runtime .text contains REAL newline characters (baked into
    // the prefab via Unity's multi-line inspector fields), never the literal escaped form. Without
    // normalizing here, any multi-line dumped string (typically ones wrapped in <color=...> spanning
    // multiple lines) silently fails this exact-match lookup and falls through un-replaced to
    // DynamicStringPatches' bare-fragment substitution, which then partially/incorrectly mangles it
    // character-by-character (confirmed via an in-game screenshot: "自由选择门派拜入，逐鹿天下或
    // 浪迹江湖。" rendering as "Freedom选择SectJoin under，逐鹿SkyDown或浪迹Jianghu" instead of the
    // correct whole-string translation already present in dumpedPrefabText.txt.yaml).
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
