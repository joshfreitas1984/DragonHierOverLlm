# ResourceIoPatches agent reference

Read this before changing `ResourceIoPatches.cs`. The source keeps only short pointers; detailed investigations are indexed in `DragonHeirPlugin/KNOWN_ISSUES.md`.

## Purpose and flow

`Load_Postfix` handles `Resources.Load(string, Il2CppSystem.Type)` results whose requested type is `UnityEngine.TextAsset`. It wraps the already-loaded native object with `new TextAsset(__result.Pointer)`, decodes its raw bytes, writes a diagnostic copy under `raw/<path>.csv`, and applies `resources/<path>.csv` when that complete replacement exists.

The packaged override is a whole-file drop-in produced by `GameFileHandling.PackageFinalTranslationAsync`; it contains translated rows plus untranslated/failed rows retained verbatim. Do not reintroduce row-level merging by column 0. That assumption is invalid for files such as `NameData.csv`; see `resourceio-csv-merge-abandoned.md`.

## Byte and encoding rules

Do not read `TextAsset.bytes`. Its return type is the generic `Il2CppStructArray<byte>` wrapper and can trigger the confirmed `Il2CppClassPointerStore<byte>` crash. `GetTextAssetBytesRaw` invokes the native `get_bytes` method through non-generic `IL2CPP.il2cpp_*` calls, reads the native array length, and copies from the array data offset with `Marshal.Copy`. Do not construct a new TextAsset through its non-public parameterless constructor; mutate the already-loaded wrapper with `TextAsset.Internal_CreateInstance(ta, overrideText)`.

`DecodeAssetBytes` performs strict UTF-8 decoding first and falls back to GBK codepage 936 on `DecoderFallbackException`. The codepage provider is registered by `MainPlugin.Load`. This avoids silent replacement-character corruption in known GBK assets such as `SpeHeroFaceData.csv`. See `resourceio-generic-bytearray-classpointerstore-crash.md` for the raw-byte crash investigation.

## Safety and path handling

`SanitizePath` preserves the resource path structure while replacing invalid filename characters. Keep directory creation before raw-file output. The entire Harmony postfix is best-effort: catch failures, log safely, and leave the original loaded asset untouched. Keep all IL2CPP object handling non-generic and verify signatures against the real interop assemblies before adding calls.

## Change checklist

1. Preserve the `TextAsset` type guard and already-loaded pointer-wrap construction.
2. Keep raw-byte extraction separate from the generated generic `.bytes` property.
3. Keep strict UTF-8 then GBK fallback behavior.
4. Keep override application whole-file and in-place.
5. Compare actual dumped/overridden content when validating, not only log success.
6. Read `resourceio-csv-merge-abandoned.md` and `resourceio-generic-bytearray-classpointerstore-crash.md` before changing merge or byte access behavior.
