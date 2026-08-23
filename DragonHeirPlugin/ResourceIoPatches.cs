using System;
using System.IO;
using System.Reflection;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace EnglishPatch;

/// <summary>
/// Dumps every TextAsset the game loads via Resources.Load to ./raw/&lt;path&gt;.csv, and applies a
/// full whole-file override from ./resources/&lt;path&gt;.csv when present. The override file is a
/// complete drop-in replacement (produced by GameFileHandling.PackageFinalTranslationAsync in the
/// Tests project, which always writes every row — translated rows plus untranslated/failed rows
/// kept verbatim as their original raw text) — not a partial patch, so no row-level merge is
/// needed or safe here.
///
/// A prior version of this patch used a row-level CSV merge keyed by each row's first column
/// (see CsvMerger.MergeByFirstColumn), on the assumption that column 0 was a stable per-row ID.
/// That assumption doesn't hold for every file — e.g. NameData.csv's column 0 is a repeated
/// category label ("姓"/Surname, not a unique ID), and the override file had already translated
/// that same label ("姓" → "Surname"). Every row's lookup by column 0 then missed (base rows keyed
/// by "姓", override rows keyed by "Surname"), so every row silently fell back to the original
/// untranslated text — the merge appeared to succeed (no exception, non-trivial output length) but
/// produced unchanged Chinese output. Since the override file is already a complete replacement,
/// the fix is to use it wholesale instead of trying to merge by row.
///
/// IL2CPP interop safety: all Il2Cpp object handling here is non-generic. TextAsset has no public
/// (string) constructor in this build (BepInEx.Unity.IL2CPP 6.0.0-be.785) — only a non-public
/// parameterless ctor and a public (IntPtr) pointer-wrap ctor. Constructing a *brand-new* instance
/// via the non-public empty ctor is unsafe here: that ctor does not allocate a real native IL2CPP
/// object (the wrapper's Pointer stays IntPtr.Zero), so calling the native
/// TextAsset.Internal_CreateInstance(self, text) icall on it null-derefs and surfaces as a
/// NullReferenceException. Instead we call Internal_CreateInstance directly on the *already loaded*
/// TextAsset (which already has a valid native pointer from Resources.Load) to overwrite its text
/// in place — this mirrors Unity's own TextAsset(string) source constructor without needing to
/// allocate a new native object at all. See .github/instructions/dragonheirplugin.instructions.md
/// for the general interop safety rules this patch follows (no TryCast&lt;T&gt;/Cast&lt;T&gt;, no generic
/// helpers, etc).
/// </summary>
internal static class ResourceIoPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string RawDir = Path.Combine(PluginDir, "raw");
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");

    private static string SanitizePath(string path)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var segments = path.Split('/');
        for (int i = 0; i < segments.Length; i++)
        {
            foreach (var c in invalid)
            {
                segments[i] = segments[i].Replace(c, '_');
            }
        }
        return string.Join("/", segments);
    }

    [HarmonyPatch(typeof(Resources), nameof(Resources.Load), new[] { typeof(string), typeof(Il2CppSystem.Type) })]
    [HarmonyPostfix]
    private static void Load_Postfix(string path, Il2CppSystem.Type systemTypeInstance, ref UnityEngine.Object __result)
    {
        try
        {
            MainPlugin.Logger?.LogInfo($"ResourceIoPatches.Load_Postfix called for '{path}' (type='{systemTypeInstance?.FullName}', resultNull={__result == null})");

            if (__result == null || systemTypeInstance?.FullName != "UnityEngine.TextAsset")
            {
                return;
            }

            var ta = new TextAsset(__result.Pointer);
            var sanitizedPath = SanitizePath(path);

            var rawFile = Path.Combine(RawDir, sanitizedPath + ".csv");
            Directory.CreateDirectory(Path.GetDirectoryName(rawFile)!);
            File.WriteAllText(rawFile, ta.text, new UTF8Encoding(false));
            MainPlugin.Logger?.LogInfo($"ResourceIoPatches: dumped raw TextAsset '{path}' -> '{rawFile}' ({ta.text?.Length ?? 0} chars)");

            var overrideFile = Path.Combine(ResourcesDir, sanitizedPath + ".csv");
            if (!File.Exists(overrideFile))
            {
                MainPlugin.Logger?.LogInfo($"ResourceIoPatches: no override file at '{overrideFile}' for '{path}' — leaving asset untouched");
                return;
            }

            // The override file is a complete drop-in replacement (see class remarks) — use it
            // wholesale rather than attempting a row-level merge.
            var overrideText = File.ReadAllText(overrideFile);

            // Overwrite the already-loaded TextAsset's text in place — it already has a valid
            // native pointer, so no new instance needs to be constructed. __result already refers
            // to the same native object as `ta`, so no reassignment is needed either.
            TextAsset.Internal_CreateInstance(ta, overrideText);
            MainPlugin.Logger?.LogInfo($"ResourceIoPatches: applied whole-file override '{overrideFile}' to TextAsset '{path}' ({overrideText.Length} chars). Post-write text starts with: '{ta.text?.Substring(0, Math.Min(40, ta.text?.Length ?? 0))}'");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"ResourceIoPatches.Load_Postfix failed for '{path}': {ex}");
        }
    }
}
