# ResourceIoPatches — generic `Il2CppStructArray<byte>` crash on `TextAsset.bytes`

## Symptom

After a game session that had previously worked fine, every `ResourceIoPatches.Load_Postfix`
invocation started throwing, for every single TextAsset (`NameData`, `SpeAddDataBase`,
`ForceSpeAddDataBase`, `TechDataBase`, `AreaData`, etc.) — no other plugin/patch in the load was
affected:

```
System.TypeInitializationException: The type initializer for
'Il2CppInterop.Runtime.Il2CppClassPointerStore`1' threw an exception.
 ---> System.TypeInitializationException: The type initializer for
'Il2CppInterop.Runtime.InteropTypes.Arrays.Il2CppStructArray`1' threw an exception.
 ---> System.TypeInitializationException: The type initializer for
'Il2CppInterop.Runtime.Il2CppClassPointerStore`1' threw an exception.
 ---> System.NullReferenceException: Object reference not set to an instance of an object.
   at Il2CppInterop.Runtime.Il2CppClassPointerStore`1..cctor()
   ...
   at UnityEngine.TextAsset.get_bytes()
   at EnglishPatch.ResourceIoPatches.Load_Postfix(...)
```

## Investigation (ruled out)

- Not a stale-interop-assembly issue: full wipe of `BepInEx\interop`, `BepInEx\cache`, and
  `BepInEx\unity-libs` followed by a clean relaunch (regenerating all interop DLLs from the
  current `GameAssembly.dll`/metadata) did **not** fix it.
- Not a BepInEx-core-vs-game-metadata version mismatch (the classic cause of this exception
  shape) — same BepInEx version had worked before, no game update occurred.
- Confirmed via reflection that the regenerated `Il2Cppmscorlib.dll` resolves `Il2CppSystem.Byte`
  fine (`Assembly.GetType("Il2CppSystem.Byte")` non-null) — the interop assembly itself isn't
  missing the primitive wrapper type.

## Root cause (CONFIRMED)

`ResourceIoPatches.Load_Postfix` read `ta.bytes` (the generated `TextAsset.bytes` property),
whose return type is `Il2CppStructArray<byte>` — a **generic** IL2CPP interop wrapper. Per
`dragonheirplugin.instructions.md`'s "Confirmed-unsafe patterns" section, any generic Il2Cpp
interop call is unsafe in this plugin/build, and `ResourceIoPatches` was the *only* patch in the
entire plugin that ever touched a generic struct-array type — every other patch only deals with
non-generic wrapper types (`Il2CppSystem.Object`, `TextAsset` via its `(IntPtr)` ctor, etc.). That
is exactly why the crash was isolated to `ResourceIoPatches` while every other plugin/patch kept
working normally.

Accessing `.bytes` forces `Il2CppClassPointerStore<byte>`'s static constructor to run for the
first time in that session (lazy, per-generic-instantiation init) — and in this environment that
cctor now throws a `NullReferenceException` internally, unrelated to metadata/interop staleness.

## Fix

Added `ResourceIoPatches.GetTextAssetBytesRaw(TextAsset ta)`: invokes the native
`TextAsset::get_bytes` getter directly via non-generic `Il2CppInterop.Runtime.IL2CPP` static
calls (`il2cpp_object_get_class` → `il2cpp_class_get_method_from_name("get_bytes", 0)` →
`il2cpp_runtime_invoke`), then reads the resulting native array's raw bytes directly via pointer
arithmetic (`il2cpp_array_length` for the count, then `Marshal.Copy` starting
`4 * IntPtr.Size` bytes past the array pointer — skipping the `Il2CppObject` header (klass +
monitor) plus the array's `bounds`/`max_length` fields, mirroring `Il2CppArrayBase`'s private
`ArrayStartPointer` computation). This never constructs `Il2CppStructArray<byte>` or touches
`Il2CppClassPointerStore<byte>` at all, so the broken generic cctor path is fully bypassed.

Confirmed fixed by the user after redeploy — TextAsset dumping/override again works for all
GameData files.

## Lesson

When a `NullReferenceException`/`TypeInitializationException` chain bottoms out in
`Il2CppClassPointerStore<T>` or any other `<T>`-suffixed IL2CPP interop type, first check whether
the crashing code path is the ONLY one in the plugin exercising that particular generic
instantiation (e.g. `<byte>`, `<string>`) — a full interop/cache regen looks like the obvious fix
for this exception shape (it's the classic fix for a metadata-version mismatch) but does nothing
if the real cause is a plugin-side confirmed-unsafe generic call. Prefer rewriting that one call
site to use the native non-generic `IL2CPP.il2cpp_*` helpers directly, per the "Confirmed-safe
patterns" already documented in `dragonheirplugin.instructions.md`.
