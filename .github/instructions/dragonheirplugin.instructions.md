---
applyTo: "DragonHeirPlugin/**"
---

# DragonHeirPlugin — IL2CPP Interop Notes

> Keep this file short — it's auto-injected into context on every `DragonHeirPlugin/**` edit. Put
> detailed crash-investigation narratives/case studies in
> [`DragonHeirPlugin/KNOWN_ISSUES.md`](../../DragonHeirPlugin/KNOWN_ISSUES.md) instead (read
> on-demand, not auto-loaded), and only summarize the current-state rule/pattern here.

## Project shape

Single-game BepInEx.Unity.IL2CPP plugin (`GamePlugin.csproj`, namespace `EnglishPatch`) for
*LongYinLiZhiZhuan* ("Dragon Heir"), targeting `BepInEx.Unity.IL2CPP 6.0.0-be.785`. Compiled
directly against the game's real unhollowed assemblies in `BepInEx\interop\` — there is no
Shared/stub project split here, so the "Shared vs host assembly mismatch" failure mode seen in
other Fanslation-style repos does not apply. All other IL2CPP interop hazards below still apply.

Source of these findings: `G:\FanslationStudio.Plugins\.github\copilot-instructions.md` (more
exhaustive, multi-game-tested notes — check there first if a new interop crash is hit here).

## csproj interop references

`GamePlugin.csproj` only references `Assembly-CSharp`, `Unity.TextMeshPro`, and `UnityEngine.UI`
from `BepInEx\interop\` by default. If you need other UnityEngine/Il2Cpp types (e.g. `Resources`,
`TextAsset`, `Il2CppSystem.Type`), add explicit `<Reference>` + `<HintPath>` entries pointing at
the matching DLL under `BepInEx\interop\` — e.g. `UnityEngine.CoreModule.dll`, `Il2CppSystem.dll`,
`Il2Cppmscorlib.dll` (the latter two are both needed: `Il2CppSystem.Type` itself lives in
`Il2Cppmscorlib.dll`, not `Il2CppSystem.dll`). Also watch for `Object` ambiguity between
`UnityEngine.Object` and `System.Object`/`object` — fully qualify as `UnityEngine.Object` in method
signatures once both namespaces are in scope.

## Confirmed-unsafe patterns

- **Any generic Il2Cpp interop call** — `TryCast<T>()`, `Cast<T>()`, `AddComponent<T>()`, generic
  `FindObjectsOfType<T>()`, `ClassInjector.RegisterTypeInIl2Cpp<T>()` — anywhere in this plugin,
  not just inside `Load()`. Confirmed unsafe even during normal gameplay callbacks.
- Don't wrap interop-touching logic in a generic helper method — keep Harmony patch bodies and
  any IL2CPP-object-handling code as concrete, non-generic methods.
- `GetComponent(Type)`-style filtered lookups can return a wrong-typed result in this IL2CPP
  build family — guard with a manual type check rather than trusting the filter.

## Confirmed-safe patterns

- **Harmony patching** (prefix/postfix) is safe — ordinary `MethodInfo` resolution + IL detour,
  no generic-method reentrancy. Safe for per-frame hooks or API-intercept hooks (e.g. patching
  `Resources.Load`).
- **Non-generic `(IntPtr)` / `(string)` constructors** on IL2CPP wrapper types (e.g.
  `new TextAsset(ptr)`, `new TextAsset(text)`) are the safe way to convert/construct objects
  instead of generic `Cast<T>()`/`TryCast<T>()`.
  - **Caveat confirmed for this build (`be.785`):** `TextAsset` has **no public `(string)`
    constructor** — only a non-public `()` ctor and a public `(IntPtr)` pointer-wrap ctor.
  - **Confirmed-unsafe refinement:** invoking that non-public empty ctor via reflection
    (`GetConstructor(BindingFlags.Instance | BindingFlags.NonPublic, null, Type.EmptyTypes, null)`)
    and then calling `TextAsset.Internal_CreateInstance(self, text)` on the *freshly constructed*
    instance throws a `NullReferenceException` inside `Internal_CreateInstance` — the reflection-invoked
    empty ctor does not allocate a real native IL2CPP object, so the wrapper's native pointer is
    effectively invalid and the icall null-derefs. This only surfaces the first time a code path that
    builds a brand-new `TextAsset` actually runs (e.g. `ResourceIoPatches.Load_Postfix` only hits it
    when a matching override CSV file exists on disk), so it can look like an intermittent/asset-specific
    bug rather than a systemic one.
  - **Safe fix:** don't construct a new `TextAsset` at all — call
    `static void TextAsset.Internal_CreateInstance(TextAsset self, string text)` directly on the
    **already-loaded** `TextAsset` wrapper (e.g. the one obtained via `new TextAsset(__result.Pointer)`
    from an existing `UnityEngine.Object`), since it already has a valid native pointer. This mutates
    its text in place and mirrors Unity's own `TextAsset(string)` source constructor without ever
    needing to allocate a new native object. See `ResourceIoPatches.Load_Postfix` for the reference
    implementation. Don't assume other IL2CPP wrapper types have a `(string)` ctor either — verify
    per-type via reflection first, and be wary of the same "reflection ctor doesn't allocate a native
    object" trap for any wrapper type that lacks a public constructor.
- Guard on plain property reads (e.g. `Il2CppSystem.Type.FullName`) before doing anything — these
  are safe, non-invoking reads.

## Gotcha: `object`/`Exception` parameters on interop methods are `Il2CppSystem.Object`/`Exception`

Methods like `UnityEngine.Debug.Log(object message)` look like they take `System.Object` from
IntelliSense/decompiled signatures, but in this interop build they actually take
`Il2CppSystem.Object` (and `Debug.LogException` takes `Il2CppSystem.Exception`, not
`System.Exception`). A `[HarmonyPatch(typeof(Debug), nameof(Debug.Log), new[] { typeof(object) })]`
attribute using `System.Object`/`System.Exception` therefore silently fails to match any real
overload — Harmony throws `HarmonyException: Undefined target method` /
`AccessTools.DeclaredMethod: Could not find method ... and parameters (object)` at `Load()` time
(plugin fails to load entirely), not a subtler runtime bug. Fix: use `typeof(Il2CppSystem.Object)`
/ `typeof(Il2CppSystem.Exception)` in the `HarmonyPatch` attribute and as the patch method's
parameter type instead — the interop wrapper types convert to `object` fine as a plain upcast when
passed into ordinary C# helper methods (e.g. logging/formatting) afterward. See
`UnityLogCapture.cs` for the corrected patch signatures.

This was found by dumping raw IL metadata with fully-qualified type names (short names alone are
misleading — `Il2CppSystem.Object` and `System.Object` both print as just "Object" unless you also
resolve the type's namespace). When verifying interop method signatures via
`System.Reflection.Metadata`/`PEReader`, always resolve and print the parameter types' namespaces,
not just their short names.

## Gotcha: `Il2CppSystem.Object.ToString()` does not return the boxed value's real content

Even after fixing the patch signatures above, calling `.ToString()` directly on an
`Il2CppSystem.Object` parameter (e.g. a `Debug.Log` message) prints the literal string
`"Il2CppSystem.Object"` — the C# wrapper class's own default `Object.ToString()` (its full type
name) — instead of the actual boxed value (e.g. the real string that was logged). Same for
`Il2CppSystem.Exception.ToString()`, which returns `"Il2CppSystem.Exception"` instead of a
message+stacktrace dump; use `.Message`/`.StackTrace`/`.InnerException` directly instead (plain
safe property reads) — see `FormatException` in `UnityLogCapture.cs`.

For the general `Il2CppSystem.Object` case (most log messages are actually boxed strings), the fix
is to inspect the object's *real* IL2CPP class and, if it is `System.String`, read the text via the
native string accessor — all through plain, non-generic static methods on
`Il2CppInterop.Runtime.IL2CPP` (from `BepInEx\core\Il2CppInterop.Runtime.dll`), not the
confirmed-unsafe generic `Cast<T>()`/`TryCast<T>()`:

```csharp
var ptr = il2cppObj.Pointer; // Il2CppObjectBase.Pointer — safe property read
var klass = IL2CPP.il2cpp_object_get_class(ptr);
var ns = IL2CPP.il2cpp_class_get_namespace_(klass);   // "System"
var name = IL2CPP.il2cpp_class_get_name_(klass);      // "String"
if (ns == "System" && name == "String")
    text = IL2CPP.Il2CppStringToManaged(ptr);
```

`il2cpp_object_get_class`/`il2cpp_class_get_namespace_`/`il2cpp_class_get_name_`/
`Il2CppStringToManaged` are all plain static P/Invoke-wrapper methods with concrete (non-generic)
parameter/return types — safe per the interop rules above, since the "generic Il2Cpp interop call"
danger is specifically about generic methods like `Cast<T>`/`TryCast<T>`, not about calling
non-generic static helpers that happen to live in the interop runtime library. See
`UnityLogCapture.FormatMessage` for the full implementation and fallback behavior for non-string
boxed values (falls back to plain `ToString()`, which is fine for types that do override it).

Found via the same raw-metadata-dump technique as above, applied this time to
`BepInEx\core\Il2CppInterop.Runtime.dll` (not the game's own `BepInEx\interop\*.dll`) to enumerate
the `Il2CppInterop.Runtime.IL2CPP` static helper class's full method list and find the non-generic
string/class-name accessors.

## Debugging tips

Before writing any interop-touching code, verify real signatures against the actual
`BepInEx\interop\*.dll` rather than trusting stub/dummy assemblies:

```csharp
var asm = Assembly.LoadFile(@"G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan\BepInEx\interop\UnityEngine.CoreModule.dll");
Type[] types;
try { types = asm.GetTypes(); }
catch (ReflectionTypeLoadException ex) { types = ex.Types.Where(t => t != null).ToArray(); }
// then GetMethods()/GetConstructors() on the type you care about
```

Wrap any interop-touching plugin code in try/catch regardless — treat the IL2CPP host as
potentially unstable and fail safe (log, leave original values untouched) rather than throwing.

## `ResourceIoPatches` — CSV override strategy (whole-file replace, not row merge)

`ResourceIoPatches.Load_Postfix` patches `Resources.Load` to dump every loaded `TextAsset` to
`BepInEx\plugins\raw\<path>.csv` and, if a matching file exists at
`BepInEx\plugins\resources\<path>.csv`, overwrite the asset's text with that file's **entire
contents verbatim** — no row-level merging. `Tests/GameFileHandling.cs`'s
`PackageFinalTranslationAsync` already writes a complete drop-in file to `Files/Mod/*.csv` (every
row present, untranslated/failed rows kept as original raw text), so the override file is always
the full intended replacement, never a partial patch. `CsvMerger.MergeByFirstColumn` (unused,
still in `CsvMerger.cs`) was tried and abandoned — see `DragonHeirPlugin/KNOWN_ISSUES.md` for why a
row-level merge by column-0 ID doesn't hold up for every file.

## `UnityLogCapture` — capturing Unity engine log output without BepInEx's log hook

BepInEx's built-in Unity log redirection does not fire for this game/build, and
`UnityEngine.Application.logMessageReceived` does not exist in this stripped interop build (do not
try to use it — see `DragonHeirPlugin/KNOWN_ISSUES.md` for how this was verified). Instead,
`UnityLogCapture.cs` Harmony-postfix-patches `UnityEngine.Debug`'s `Log`/`LogWarning`/`LogError`/
`LogException`/`LogAssertion` overloads and writes every message to
`BepInEx\plugins\unity-log.txt`. Only `LogException` calls (Unity's signal for an exception that
propagated out of a callback uncaught by game code — i.e. genuinely unhandled) are mirrored into
the BepInEx console via `MainPlugin.Logger.LogError`; plain Log/Warning/Error/Assertion calls are
mostly harmless/known chatter and are recorded to `unity-log.txt` only, to keep the console
readable. Registered in `MainPlugin.Load()` via `Harmony.CreateAndPatchAll(typeof(UnityLogCapture))`.

## Adding a new external NuGet dependency (non-interop, non-BepInEx)

BepInEx sets `CopyLocalLockFileAssemblies = false` project-wide, so a plain `PackageReference`
DLL is never copied to `bin/` or deployed — it will crash the game at load time with
`FileNotFoundException` even though it compiles and builds fine locally. Any time you add a new
external dependency to `GamePlugin.csproj`:
1. Override `<CopyLocalLockFileAssemblies>true</CopyLocalLockFileAssemblies>` in the main
   `PropertyGroup`.
2. Embed it via **Costura.Fody** (already configured in this project — see `FodyWeavers.xml` and
   the `Costura.Fody`/`Fody` package references) so it merges into the single deployed plugin DLL.
3. Verify the specific dependency actually got embedded via `GetManifestResourceNames()` in a
   throwaway separate process (a bigger output DLL size alone is not proof) — look for
   `costura.<packagename>.dll.compressed` in the resource list.

See `DragonHeirPlugin/KNOWN_ISSUES.md` for the full investigation (the `System.Text.Encoding.CodePages`
case) including why Costura alone wasn't sufficient without step 1.

## Known confirmed crash root causes (see `KNOWN_ISSUES.md` for full writeups)

- `StartMenuController.ResetFaceSetting`/`ResetPlayerTag` crashes were downstream symptoms of
  `GameDataController.LoadAllGameData` aborting partway through its single sequential,
  non-isolated database-build pass — root cause was `HeroTagData.csv`/`ResourcePointTypeData.csv`
  effect-string columns breaking `GameDataController.StringToSpeAddData`. Fixed pipeline-side via
  `SkipColumns` in `Tests/GameFileHandling.cs` (see `Tests/KNOWN_ISSUES.md`); the plugin-side
  `DiagnosticPatches.cs`/`CrashMitigationPatches.cs` mitigation patches have since been removed.
- Same `StringToSpeAddData` bug class recurred via `GameDataController.LoadSkillData` on
  `KungFuData.csv`/`SummonKungFuData.csv` column 13, then again (different method,
  `StringToAttriRatio`, no try/catch) on the same files' columns 9/10 — both fixed via
  `SkipColumns`.
- **General lesson**: when `BepInEx/LogOutput.log` just stops mid-sequence with no exception
  logged, that means an uncaught exception occurred synchronously inside
  `GameDataController.LoadAllGameData` (or its Harmony-patched call chain) — check Unity's own
  `Player.log` (`%USERPROFILE%\AppData\LocalLow\TppStudio\LongYinLiZhiZhuan\Player.log`) for the
  actual stack trace, since BepInEx's own logging never gets a chance to react to a crash that
  fatal. When investigating a new "database ends up empty"/crash-on-load case, read
  `DragonHeirPlugin/KNOWN_ISSUES.md` and `Tests/KNOWN_ISSUES.md` first for the established
  methodology and known hazard patterns (`Label<sign><number>` cross-reference cells, etc.) before
  re-deriving them from scratch.




