using System;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using HarmonyLib;
using Il2CppInterop.Runtime;
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
            MainPlugin.Logger?.LogDebug($"ResourceIoPatches.Load_Postfix called for '{path}' (type='{systemTypeInstance?.FullName}', resultNull={__result == null})");

            if (__result == null || systemTypeInstance?.FullName != "UnityEngine.TextAsset")
            {
                return;
            }

            var ta = new TextAsset(__result.Pointer);
            var sanitizedPath = SanitizePath(path);

            // Decode from the raw bytes ourselves rather than trusting TextAsset.text - Unity's
            // .text getter always assumes UTF-8, but at least one game data file
            // (SpeHeroFaceData.csv) is actually GBK-encoded on disk. Reading that asset via .text
            // silently mangles every CJK cell into U+FFFD replacement characters with no error -
            // the corruption is irreversible once dumped that way. See DecodeAssetBytes.
            //
            // NOTE: read via GetTextAssetBytesRaw, NOT the generated `ta.bytes` property. That
            // property returns Il2CppStructArray<byte>, a GENERIC IL2CPP wrapper type - a
            // confirmed-unsafe pattern per dragonheirplugin.instructions.md ("Any generic Il2Cpp
            // interop call... anywhere in this plugin"). It forces
            // Il2CppClassPointerStore<byte>'s static ctor to run for the first time (this is the
            // only place in the whole plugin that touches a byte[]/struct array), and that cctor
            // has been observed to throw NullReferenceException even after a full BepInEx
            // interop/cache/unity-libs regen - see
            // DragonHeirPlugin/docs/resourceio-generic-bytearray-classpointerstore-crash.md.
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

    /// <summary>
    /// Reads TextAsset.bytes without ever constructing the generic Il2CppStructArray&lt;byte&gt;
    /// wrapper (see remarks on the call site in Load_Postfix). Invokes the native
    /// TextAsset::get_bytes getter directly via non-generic IL2CPP runtime calls and reads the
    /// resulting native byte array's contents straight out of its raw memory layout: an
    /// Il2CppObject header (class pointer + monitor, 2 pointers) followed by the array's bounds
    /// pointer and max_length field (1 pointer each), then the raw element data - matching
    /// Il2CppArrayBase's own (private) ArrayStartPointer computation.
    /// </summary>
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

    /// <summary>
    /// Decodes raw TextAsset bytes as UTF-8, falling back to GBK (codepage 936) when the bytes
    /// aren't valid UTF-8. Unity's TextAsset.text getter always assumes UTF-8 regardless of the
    /// asset's actual source encoding, so any GBK-sourced asset (confirmed for
    /// SpeHeroFaceData.csv, possibly others) gets silently mangled into U+FFFD replacement
    /// characters if read via .text instead of .bytes. Requires
    /// Encoding.RegisterProvider(CodePagesEncodingProvider.Instance) to have been called
    /// (done once in MainPlugin.Load) since .NET Core doesn't ship codepage 936 by default.
    /// </summary>
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
