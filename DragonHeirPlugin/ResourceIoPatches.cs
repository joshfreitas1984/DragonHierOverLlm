using System;
using System.IO;
using System.Reflection;
using System.Text;
using HarmonyLib;
using UnityEngine;

namespace EnglishPatch;

/// <summary>
/// Dumps every TextAsset the game loads via Resources.Load to ./raw/&lt;path&gt;.csv, and applies a
/// row-level CSV override merge from ./resources/&lt;path&gt;.csv when present (override wins per-row
/// by first-column ID; rows only in the base asset are kept as-is).
///
/// IL2CPP interop safety: all Il2Cpp object handling here is non-generic. TextAsset has no public
/// (string) constructor in this build (BepInEx.Unity.IL2CPP 6.0.0-be.785) — only a non-public
/// parameterless ctor and a public (IntPtr) pointer-wrap ctor. To build a new TextAsset from text
/// we invoke the cached non-public empty ctor via reflection, then call the native
/// TextAsset.Internal_CreateInstance(self, text) icall, mirroring Unity's own TextAsset(string)
/// source constructor. See .github/instructions/dragonheirplugin.instructions.md for the general
/// interop safety rules this patch follows (no TryCast&lt;T&gt;/Cast&lt;T&gt;, no generic helpers, etc).
/// </summary>
internal static class ResourceIoPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string RawDir = Path.Combine(PluginDir, "raw");
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");

    private static readonly ConstructorInfo TextAssetEmptyCtor =
        typeof(TextAsset).GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null);

    private static TextAsset CreateTextAsset(string text)
    {
        var ta = (TextAsset)TextAssetEmptyCtor.Invoke(null);
        TextAsset.Internal_CreateInstance(ta, text);
        return ta;
    }

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

    private static bool LooksLikeCsv(string text)
    {
        if (string.IsNullOrEmpty(text)) return false;
        var firstLine = text.Split('\n')[0];
        return firstLine.IndexOf(',') >= 0;
    }

    [HarmonyPatch(typeof(Resources), nameof(Resources.Load), new[] { typeof(string), typeof(Il2CppSystem.Type) })]
    [HarmonyPostfix]
    private static void Load_Postfix(string path, Il2CppSystem.Type systemTypeInstance, ref UnityEngine.Object __result)
    {
        try
        {
            if (__result == null || systemTypeInstance?.FullName != "UnityEngine.TextAsset")
            {
                return;
            }

            var ta = new TextAsset(__result.Pointer);
            var sanitizedPath = SanitizePath(path);

            var rawFile = Path.Combine(RawDir, sanitizedPath + ".csv");
            Directory.CreateDirectory(Path.GetDirectoryName(rawFile)!);
            File.WriteAllText(rawFile, ta.text, new UTF8Encoding(false));

            var overrideFile = Path.Combine(ResourcesDir, sanitizedPath + ".csv");
            if (!File.Exists(overrideFile))
            {
                return;
            }

            var overrideText = File.ReadAllText(overrideFile);
            string mergedText;
            if (LooksLikeCsv(ta.text) && LooksLikeCsv(overrideText))
            {
                mergedText = CsvMerger.MergeByFirstColumn(ta.text, overrideText);
            }
            else
            {
                // Not CSV-shaped (or base/override mismatch) — fall back to whole-file replace.
                mergedText = overrideText;
            }

            __result = CreateTextAsset(mergedText);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"ResourceIoPatches.Load_Postfix failed for '{path}': {ex}");
        }
    }
}
