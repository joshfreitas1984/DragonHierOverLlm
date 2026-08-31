using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using HarmonyLib;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace EnglishPatch;

// Detailed rationale and invariants: docs/resourceiopatches-agent-reference.md
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
            MainPlugin.Logger?.LogDebug($"ResourceIoPatches.Load_Postfix called for '{path}' (type='{systemTypeInstance?.FullName}', resultNull={__result == null})");

            if (__result == null || systemTypeInstance?.FullName != "UnityEngine.TextAsset")
            {
                return;
            }

            var ta = new TextAsset(__result.Pointer);
            var sanitizedPath = SanitizePath(path);

            // Detailed rationale and invariants: docs/resourceiopatches-agent-reference.md
            byte[] rawBytes = GetTextAssetBytesRaw(ta);
            var text = DecodeAssetBytes(rawBytes, path);

            var rawFile = Path.Combine(RawDir, sanitizedPath + ".csv");
            Directory.CreateDirectory(Path.GetDirectoryName(rawFile)!);
            File.WriteAllText(rawFile, text, new UTF8Encoding(false));
            MainPlugin.Logger?.LogDebug($"ResourceIoPatches: dumped raw TextAsset '{path}' -> '{rawFile}' ({text?.Length ?? 0} chars)");

            var overrideFile = Path.Combine(ResourcesDir, sanitizedPath + ".csv");
            if (!File.Exists(overrideFile))
            {
                MainPlugin.Logger?.LogDebug($"ResourceIoPatches: no override file at '{overrideFile}' for '{path}' — leaving asset untouched");
                return;
            }

            // The override file is a complete drop-in replacement (see class remarks) — use it
            // wholesale rather than attempting a row-level merge.
            var overrideText = File.ReadAllText(overrideFile);

            // Overwrite the already-loaded TextAsset's text in place — it already has a valid
            // native pointer, so no new instance needs to be constructed. __result already refers
            // to the same native object as `ta`, so no reassignment is needed either.
            TextAsset.Internal_CreateInstance(ta, overrideText);
            MainPlugin.Logger?.LogDebug($"ResourceIoPatches: applied whole-file override '{overrideFile}' to TextAsset '{path}' ({overrideText.Length} chars). Post-write text starts with: '{ta.text?.Substring(0, Math.Min(40, ta.text?.Length ?? 0))}'");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"ResourceIoPatches.Load_Postfix failed for '{path}': {ex}");
        }
    }

    // Detailed rationale and invariants: docs/resourceiopatches-agent-reference.md
    private static unsafe byte[] GetTextAssetBytesRaw(TextAsset ta)
    {
        var objPtr = ta.Pointer;
        var klass = IL2CPP.il2cpp_object_get_class(objPtr);
        var method = IL2CPP.il2cpp_class_get_method_from_name(klass, "get_bytes", 0);
        if (method == IntPtr.Zero)
        {
            throw new InvalidOperationException("TextAsset::get_bytes native method not found");
        }

        var exception = IntPtr.Zero;
        var arrayPtr = IL2CPP.il2cpp_runtime_invoke(method, objPtr, null, ref exception);
        if (exception != IntPtr.Zero)
        {
            throw new InvalidOperationException("Native invocation of TextAsset::get_bytes threw an IL2CPP exception");
        }

        if (arrayPtr == IntPtr.Zero)
        {
            return Array.Empty<byte>();
        }

        var length = (int)IL2CPP.il2cpp_array_length(arrayPtr);
        if (length <= 0)
        {
            return Array.Empty<byte>();
        }

        var headerSize = 4 * IntPtr.Size; // klass + monitor + bounds + max_length
        var dataPtr = IntPtr.Add(arrayPtr, headerSize);
        var result = new byte[length];
        Marshal.Copy(dataPtr, result, 0, length);
        return result;
    }

    // Detailed rationale and invariants: docs/resourceiopatches-agent-reference.md
    private static string DecodeAssetBytes(byte[] bytes, string path)
    {
        if (bytes == null || bytes.Length == 0)
            return string.Empty;

        try
        {
            // Strict UTF-8 decode: throws on any invalid byte sequence instead of silently
            // substituting U+FFFD, so we can reliably detect non-UTF-8 source data.
            var strictUtf8 = new UTF8Encoding(encoderShouldEmitUTF8Identifier: false, throwOnInvalidBytes: true);
            return strictUtf8.GetString(bytes);
        }
        catch (DecoderFallbackException)
        {
            MainPlugin.Logger?.LogWarning($"ResourceIoPatches: '{path}' is not valid UTF-8 — falling back to GBK (codepage 936) decode");
            try
            {
                return Encoding.GetEncoding(936).GetString(bytes);
            }
            catch (Exception gbkEx)
            {
                MainPlugin.Logger?.LogError($"ResourceIoPatches: GBK fallback decode failed for '{path}': {gbkEx}. Falling back to lossy UTF-8.");
                return Encoding.UTF8.GetString(bytes);
            }
        }
    }

}
