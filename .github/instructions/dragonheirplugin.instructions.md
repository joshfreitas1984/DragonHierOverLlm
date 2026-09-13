---
applyTo: "DragonHeirPlugin/**"
---

# DragonHeirPlugin — IL2CPP Interop Notes

> Keep this file short — it's auto-injected into context on every `DragonHeirPlugin/**` edit. Put
> detailed crash-investigation narratives/case studies in a topic file under
> [`DragonHeirPlugin/docs/`](../../DragonHeirPlugin/docs/) instead (read on-demand, not
> auto-loaded, indexed by [`DragonHeirPlugin/KNOWN_ISSUES.md`](../../DragonHeirPlugin/KNOWN_ISSUES.md)),
> and only summarize the current-state rule/pattern here. **Batch write-backs**: during a task,
> jot scratch notes in session memory as you find things — write ONE consolidated update (a
> new/extended `docs/*.md` file + this file's summary + a one-line index entry) at the end of the
> task, not after every individual fix.

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
- **`is T`/`as T` pattern-matching against an element from `GetComponents<Component>()`** silently
  fails to match even when the component genuinely IS that type — confirmed for `ContentSizeFitter`
  and `VerticalLayoutGroup` (reading the real IL2CPP native class name directly proved both were
  present while `is ContentSizeFitter`/`is LayoutGroup` kept missing them). Use a direct,
  statically-typed `GetComponent<T>()` call instead of enumerating `GetComponents<Component>()` and
  pattern-matching each element. See
  `DragonHeirPlugin/docs/plottext-width-overflow-investigation.md`.
- **`RectTransform.GetWorldCorners`** does not marshal correctly through this game's IL2CPP
  interop — it always returns 4 identical, effectively-zeroed corners regardless of the
  RectTransform's real bounds. Use `.position` (a plain property read) plus
  `RectTransformUtility.WorldToScreenPoint` instead for a screen-space ground-truth check.

## Confirmed-safe patterns

- **Harmony patching** (prefix/postfix) is safe — ordinary `MethodInfo` resolution + IL detour,
  no generic-method reentrancy. Safe for per-frame hooks or API-intercept hooks (e.g. patching
  `Resources.Load`).
- **Non-generic `(IntPtr)` / `(string)` constructors** on IL2CPP wrapper types (e.g.
  `new TextAsset(ptr)`, `new TextAsset(text)`) are the safe way to convert/construct objects
  instead of generic `Cast<T>()`/`TryCast<T>()`. **Caveat confirmed for build `be.785`:**
  `TextAsset` has no public `(string)` constructor — mutate an already-loaded wrapper via
  `TextAsset.Internal_CreateInstance(self, text)` instead of constructing a new one; see
  [`DragonHeirPlugin/docs/resourceiopatches-agent-reference.md`](../../DragonHeirPlugin/docs/resourceiopatches-agent-reference.md)
  for why and the reference implementation. Verify per-type via reflection before assuming any
  other wrapper type has a usable `(string)` ctor.
- Guard on plain property reads (e.g. `Il2CppSystem.Type.FullName`) before doing anything — these
  are safe, non-invoking reads.

## Gotcha: interop `object`/`Exception` parameters are `Il2CppSystem.Object`/`Il2CppSystem.Exception`

Methods like `UnityEngine.Debug.Log(object message)` take `Il2CppSystem.Object` in this interop
build, not `System.Object` (and `LogException` takes `Il2CppSystem.Exception`). A
`[HarmonyPatch]` attribute typed against `System.Object`/`System.Exception` silently fails to
match — `Harmony.CreateAndPatchAll()` throws `Undefined target method` and the whole plugin fails
to load. Always verify a method's real parameter *namespaces* against the actual
`BepInEx\interop\*.dll` before writing the attribute — short type names are misleading, since both
`Il2CppSystem.Object` and `System.Object` print as just "Object".

`Il2CppSystem.Object.ToString()`/`Il2CppSystem.Exception.ToString()` also don't return the boxed
value — they print the wrapper's own type name. Read `.Message`/`.StackTrace`/`.InnerException`
directly for exceptions; for a boxed `Il2CppSystem.Object`, inspect its real IL2CPP class via the
non-generic static helpers `IL2CPP.il2cpp_object_get_class`/`il2cpp_class_get_name_`/
`Il2CppStringToManaged` (safe — the "generic interop call" danger is specifically about generic
methods like `Cast<T>`, not non-generic static helpers).

See [`DragonHeirPlugin/docs/unitylogcapture-reference.md`](../../DragonHeirPlugin/docs/unitylogcapture-reference.md)
for the concrete implementation (`UnityLogCapture.cs`) and
[`DragonHeirPlugin/docs/unitylogcapture-no-logmessagereceived.md`](../../DragonHeirPlugin/docs/unitylogcapture-no-logmessagereceived.md)
for how both gotchas were found.

## Gotcha: Harmony prefix/postfix parameter names must match the real IL2CPP parameter name

Harmony matches patch parameters to the original method's parameters **by name**, not just
type/position. A mismatch fails silently at `Harmony.CreateAndPatchAll()`/plugin-load time (not
compile time — `nameof(...)` attribute resolution finds the method fine either way) with
`HarmonyException: IL Compile Error` / `Parameter "X" not found`, and can stop every remaining
patch in the same class from applying (confirmed: two `GlobalData` prefixes with wrong
name-and/or-type parameters — `ConvertNumToChinese`, `GetChineseNumText` — the first error had to
be fixed and redeployed before the second even surfaced in the log). Always verify the original
method's exact parameter names and types via the interop DLL (see "Debugging tips" below) before
writing a patch, and after any such failure re-check every prefix in the file rather than fixing
one at a time reactively.

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

## `ResourceIoPatches` — never read `TextAsset.bytes` directly (generic wrapper crash)

Don't call `TextAsset.bytes` (the generated property) — its return type is
`Il2CppStructArray<byte>`, a generic IL2CPP wrapper, which is confirmed-unsafe per the rules above
and has been observed to throw a `NullReferenceException` deep in
`Il2CppClassPointerStore<byte>`'s static ctor (survives a full interop/cache/unity-libs regen —
not a metadata-staleness issue). Use `ResourceIoPatches.GetTextAssetBytesRaw(TextAsset)` instead,
which invokes the native `get_bytes` getter and reads the resulting array via raw pointer/`Marshal.Copy`
instead of constructing any generic wrapper. See
`DragonHeirPlugin/docs/resourceio-generic-bytearray-classpointerstore-crash.md` for the full
investigation.

## `ResourceIoPatches` — CSV override strategy (whole-file replace, not row merge)

`ResourceIoPatches.Load_Postfix` patches `Resources.Load` to dump every loaded `TextAsset` to
`BepInEx\plugins\raw\<path>.csv` and, if a matching file exists at
`BepInEx\plugins\resources\<path>.csv`, overwrite the asset's text with that file's **entire
contents verbatim** — no row-level merging. `Tests/GameFileHandling.cs`'s
`PackageFinalTranslationAsync` already writes a complete drop-in file to `Files/Mod/*.csv` (every
row present, untranslated/failed rows kept as original raw text), so the override file is always
the full intended replacement, never a partial patch. `CsvMerger.MergeByFirstColumn` (unused,
still in `CsvMerger.cs`) was tried and abandoned — see
`DragonHeirPlugin/docs/resourceio-csv-merge-abandoned.md` for why a row-level merge by column-0 ID
doesn't hold up for every file.

## `UnityLogCapture` — capturing Unity engine log output without BepInEx's log hook

BepInEx's built-in Unity log redirection does not fire for this game/build, and
`UnityEngine.Application.logMessageReceived` does not exist in this stripped interop build (do not
try to use it — see `DragonHeirPlugin/docs/unitylogcapture-no-logmessagereceived.md` for how this
was verified). Instead,
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

See `DragonHeirPlugin/docs/costura-embedded-dependencies.md` for the full investigation (the
`System.Text.Encoding.CodePages` case) including why Costura alone wasn't sufficient without step 1.

## `DynamicStringPatches` — composite `String.Format` templates (current state)

`DynamicStringPatches` compiles each `isTemplate: true` dictionary entry into a `CompiledTemplate`
regex over `Raw`'s literal segments, replayed against `Result`. `ApplyTemplates` runs before the
bare-fragment `ApplyDictionary` pass in both `GenericPostfix` and the sink-level
`ApplyToComponentText`. `FormatPrefix` is a separate, complementary pass over a real
`String.Format` call's pre-substitution template argument.

**Two hazards to remember when touching this code:**
- Never log (or call anything that might call `String.Format`/`Concat`) from inside a patch on
  `String.Format`/`Concat` itself without the `[ThreadStatic]` re-entrancy guard
  (`_inFormatConcatPatch`) — BepInEx's own logger calls `String.Format` internally, causing
  infinite recursion.
- `Regex.Escape` is not symmetric for `{`/`}` — never round-trip a whole raw string through
  `Regex.Escape` and reverse-engineer placeholder positions; walk `Raw` directly, escaping only
  the literal segments between `{n}` tokens (`BuildCompiledTemplate`).

Full current-state design (template compiler rules, CJK-permissive fallback, short-entry
word-boundary spacing, re-entrancy, loading conventions, change checklist) is in
[`DragonHeirPlugin/docs/dynamicstringpatches-agent-reference.md`](../../DragonHeirPlugin/docs/dynamicstringpatches-agent-reference.md).
Confirmed-bug narratives (`Regex.Escape` root cause, CJK-placeholder fallback, adjacent-placeholder-merge
bugs #5–#9, and the still-unfixed `"在下#$PlayerName#"` prefix false-positive) are indexed from
[`DragonHeirPlugin/KNOWN_ISSUES.md`](../../DragonHeirPlugin/KNOWN_ISSUES.md) — read the specific
doc before modifying a confirmed bug fix.

## Dynamic-string dictionary: `DynamicStringColumnSources`/`DynamicStringLabelColumnSources`

Config-driven extraction (not manual dictionary curation) avoids `ApplyDictionary`'s bare-fragment
substring replace corrupting whole-phrase compounds with no dedicated entry (e.g. save-slot
force/sect names). `Tests/GameFileHandling.cs`'s `DynamicStringColumnSources`/
`DynamicStringLabelColumnSources` feed `dynamicStringsFromColumns.txt`, loaded via the same
`dynamicStrings*.txt.yaml` glob — adding a new dynamicStrings-family file never requires a plugin
change. Full narrative:
[`DragonHeirPlugin/docs/dynamicstrings-column-source-extraction.md`](../../DragonHeirPlugin/docs/dynamicstrings-column-source-extraction.md);
follow-on multi-line/token-placeholder bugs:
[`DragonHeirPlugin/docs/prefabtext-multiline-and-token-placeholder-bugs.md`](../../DragonHeirPlugin/docs/prefabtext-multiline-and-token-placeholder-bugs.md).

**General debugging lesson**: if `BepInEx/LogOutput.log` stops mid-sequence with no exception
logged, an uncaught exception occurred synchronously inside `GameDataController.LoadAllGameData`
(or its patched call chain) — check Unity's own `Player.log`
(`%USERPROFILE%\AppData\LocalLow\TppStudio\LongYinLiZhiZhuan\Player.log`) for the real stack
trace, since BepInEx's own logging never gets a chance to react to a crash that fatal. See
[`DragonHeirPlugin/KNOWN_ISSUES.md`](../../DragonHeirPlugin/KNOWN_ISSUES.md) and
[`Tests/KNOWN_ISSUES.md`](../../Tests/KNOWN_ISSUES.md) for the established crash/data-loss
investigation methodology and known hazard patterns (`Label<sign><number>` cross-reference cells,
etc.) before re-deriving them from scratch.

## `PrefabTextPatches` — runtime replacement of hardcoded prefab UI text (TMP_Text/UI.Text only)

Harmony-postfixes `Resources.Load`, `AssetBundle.LoadAsset`, and
`SceneManager.Internal_SceneLoaded` (needed for scene-embedded UI, e.g. the title screen, which
never passes through either load call), walking the resulting `GameObject` tree for
`TMP_Text`/`UI.Text` components via non-generic `GetComponents(Il2CppType.From(...))` +
`(IntPtr)` wrapper construction — never `is`/`as`/`TryCast<T>()`.

Does an **exact whole-string** match against a `Replacements` dictionary loaded from every
`dumpedPrefabText*.txt.yaml` file (searched recursively). Runtime text is newline-normalized
before/after lookup (dump escapes `\n`, live text doesn't). **Deserializer gotcha**: YAML keys are
lowercase `raw`/`result` — `DeserializerBuilder` must use `CamelCaseNamingConvention` +
`IgnoreUnmatchedProperties()`.

**Harmony `[HarmonyTargetMethod]` gotcha**: a nested patch class using `[HarmonyTargetMethod]`
must have a class-level `[HarmonyPatch(...)]` specifying **only the declaring type** — adding a
method name/args overload throws `ArgumentException` at `Harmony.CreateAndPatchAll` time (plugin
fails to load entirely).

Full current-state design and change checklist:
[`DragonHeirPlugin/docs/prefabtextpatches-agent-reference.md`](../../DragonHeirPlugin/docs/prefabtextpatches-agent-reference.md).
Investigation narrative:
[`DragonHeirPlugin/docs/prefabtextpatches-full-investigation.md`](../../DragonHeirPlugin/docs/prefabtextpatches-full-investigation.md).

## `HeroNamePatches` — relationship-title translation for `GameController.GetHeroName`

`GameController.GetHeroName(int,int)`/`GetHeroName(HeroData,HeroData)` natively compute a
relationship title (surname/given-name + relation word, e.g. "姜师姐") via field-offset branching
that isn't worth reimplementing. `HeroNamePatches` (registered via
`Harmony.CreateAndPatchAll(typeof(HeroNamePatches))` in `MainPlugin.Load()`) instead
Harmony-**postfixes** both overloads and translates the already-computed Chinese `__result`:
standalone titles (`StandaloneTitles`), a known relation-word suffix stripped off the end and
translated (`RelationSuffixes`, longest-match-first) with the remaining prefix looked up via
`TranslateNamePart`, a trailing "儿" child-affix strip, or (fallback) the bare string looked up
the same way.

**`TranslateNamePart` is `HeroNamePatches`' own private, exact-match dictionary — NOT
`DynamicStringPatches.TranslateFragment`.** A bare one/two-character surname is too easy to
accidentally match as a substring elsewhere, so name parts are packaged to their own
`heroNameParts.txt.yaml` (deliberately NOT matching `DynamicStringPatches`' `dynamicStrings*`
glob) and loaded separately via `HeroNamePatches.LoadNamePartDictionary()` before
`Harmony.CreateAndPatchAll(typeof(HeroNamePatches))`. Pipeline-side: `Tests/GameFileHandling.cs`'s
`ExtractHeroNamePartCandidates`/`DynamicStringNamePartColumnSources` extract `SpeHeroData.csv`
column 1's "Family.Given" compound into two standalone raw fragments, flowing through the same
`DynamicStringsIL2CPP` pipeline as `dynamicStrings.txt` (reusing the pipeline plumbing only — the
packaged file is never merged into `DynamicStringPatches`' dictionary).

**Gotcha (confirmed): `LoadNamePartDictionary` must search recursively.** `heroNameParts.txt.yaml`
deploys one level deeper than `resources\` itself. A flat `Path.Combine` + `File.Exists` check
silently finds nothing (no exception, empty dictionary) — every `GetHeroName` postfix then leaves
the surname/given-name part untranslated while the relation-word suffix still translates, looking
like only "half" the patch works. Use `Directory.GetFiles(resourcesDir, fileName,
SearchOption.AllDirectories)` (mirroring `DynamicStringPatches.FindResourceFiles`) — default any
future lookup dictionary to a recursive search under `resources\`, not a flat path check.

## `PlotTextSizePatches` — dialogue speech bubble width clamp (current state)

`Canvas/PlotPanel/PlotTextBack/PlotText`'s `VerticalLayoutGroup` does not control child width, so
`PlotText` (legacy `UnityEngine.UI.Text`) sizes itself to its own unconstrained single-line
`Text.preferredWidth` — long/translated dialogue routinely overflows the screen.
`PlotTextSizePatches.cs` Harmony-postfixes `Text.preferredWidth`'s getter and clamps it to a safe
value computed from the canvas's own reference-resolution width and `PlotTextBack`'s real anchor
offset (never a hand-guessed flat constant as the primary path). **Clamp the layout system's
*input* (`Text.preferredWidth`), not its *output* (`RectTransform.sizeDelta`)** — clamping the
output directly was tried first and caused position/size disagreement (the box visibly drifted
across the screen instead of converging), since `VerticalLayoutGroup` had already used the
uncapped `preferredWidth` to calculate the child's aligned position before the clamped size was
ever written.

A config-bound `KeyboardShortcut` (`ForceTestPlotTextHotkey`, default disabled) forces a long test
string into the currently cached `PlotText` for manual verification. Since `BasePlugin` never gets
a real `Update()` call and `AddComponent<T>`/`ClassInjector` crash here (per "Confirmed-unsafe
patterns" above), its tick is driven by Harmony-patching `Time.deltaTime`'s getter (read every
frame by ordinary game code), deduped by `Time.frameCount` — the same pattern already proven in
`FanslationStudio.Plugins.TextResizerPlugin`.

Full rationale, formulas, and change checklist:
[`DragonHeirPlugin/docs/plottextsizepatches-agent-reference.md`](../../DragonHeirPlugin/docs/plottextsizepatches-agent-reference.md).
Investigation narrative (the wrong-node and wrong-formula misdiagnoses along the way):
[`DragonHeirPlugin/docs/plottext-width-overflow-investigation.md`](../../DragonHeirPlugin/docs/plottext-width-overflow-investigation.md).

