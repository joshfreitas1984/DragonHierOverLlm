---
applyTo: "DragonHeirPlugin/**"
---

# DragonHeirPlugin — IL2CPP Interop Notes

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
contents verbatim** — no row-level merging.

This used to go through `CsvMerger.MergeByFirstColumn` (still present in `CsvMerger.cs` but no
longer called), which matched base/override rows by each row's first CSV column, on the assumption
that column 0 is a stable per-row ID. **That assumption is false for at least `NameData.csv`**:
column 0 there is a repeated category label (`姓`/"Surname"), not a unique ID, and the override
file's own column 0 gets translated too (`姓` → `"Surname"`). Every base row's lookup by `"姓"`
then missed every override row keyed by `"Surname"`, so **every row silently fell back to the
original untranslated text** — no exception was thrown, the log line even reported a successful
merge with a plausible non-zero output length, but the actual in-game text never changed. This is
a good example of why "no error + plausible-looking log output" isn't sufficient evidence a
transform actually worked — always compare a snippet of the *actual resulting content*, not just
whether an operation completed without throwing.

The real reason a row-level merge isn't needed at all: `Tests/GameFileHandling.cs`'s
`PackageFinalTranslationAsync` (see `.github/instructions/tests-translation-workflow.instructions.md`)
already writes a **complete drop-in file** to `Files/Mod/*.csv` — every row is present, with
translated rows using the translated text and untranslated/failed rows written back as their
original raw text (`outputLines.Add(line.Raw)`). So the file the plugin picks up under
`resources/<path>.csv` is never a partial patch; it's always the full intended replacement, and
`Load_Postfix` should just use it wholesale. If you ever reintroduce any kind of merge logic here,
first re-verify the "column 0 is a stable ID" assumption per-file — it does not hold universally.
