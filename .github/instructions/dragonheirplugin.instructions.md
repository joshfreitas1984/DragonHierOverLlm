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

## Gotcha: Harmony prefix parameter name must match the real IL2CPP parameter name (not just type)

Harmony matches prefix/postfix parameters to the original method's parameters **by name**, not
just by position/type. Two `GlobalData` patches broke this way and both only surfaced at
`Harmony.CreateAndPatchAll()` / plugin-load time (not compile time, and not even at `HarmonyPatch`
attribute resolution — `nameof(GlobalData.X)` finds the method fine), deep in IL emission:
`HarmonyException: IL Compile Error` → `System.Exception: Parameter "<wrong-name>" not found in
method ...`, crashing the whole plugin load (every patch in the same `PatchAll` call fails to
apply as a result):
- `ConvertNumToChinese_Prefix` was declared `(uint num, ref string __result)` but the real
  interop signature is `static string ConvertNumToChinese(int input)` — wrong type (`uint` vs
  `int`) *and* wrong name (`num` vs `input`).
- `GetChineseNumText_Prefix` was declared `(int num, ref char __result)` but the real signature is
  `static char GetChineseNumText(int id)` — right type, wrong name (`num` vs `id`).
- `GetNumText_Prefix`'s `(int num, ...)` happens to already match the real parameter name (`num`),
  which is why it never broke.

Fix in both cases: rename the prefix parameter to match the real name exactly and match its real
type. Note that `HarmonyManipulator.WritePrefixes` appears to stop applying further patches in the
same class after the first one throws during IL compilation — the `ConvertNumToChinese` error had
to be fixed and redeployed before the *next* bad patch (`GetChineseNumText`) even surfaced in the
log, so don't assume a single fix-and-retry cycle catches every bad patch in the file; re-check
all `[HarmonyPatch(typeof(GlobalData), ...)]` (and other interop-type) prefixes' parameter names
against the real DLL after any such failure, rather than fixing one at a time reactively. When
adding a new Harmony patch, verify the original method's exact parameter names via the interop DLL
(see "Debugging tips" below) rather than guessing from decompiled/legacy variable names.

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

## `DynamicStringPatches` bug found (2026-08-27): composite `String.Format` templates never
matched, leaking unrelated bare-character translations into their place

Symptom (reported via a save-slot describe screen screenshot): a date rendered as
`1Nian2Yue5日` — `年`→`Nian` and `月`→`Yue` translated, but `日` left untranslated, producing a
mixed-language mess.

**First (incomplete) diagnosis**: assumed the game builds this date via
`String.Format("{0}年{1}月{2}日", y, m, d)`, and that a literal pre-substitution match on the
Format template argument (`FormatPrefix`) would fix it. **This was wrong** — after deploying that
fix and confirming (via `BepInEx/LogOutput.log`) it loaded and patched correctly, the date still
rendered exactly the same broken way. Tracing `GetRecentSaveSlotDescribe`/`GameDataController`
in the decompiled output (`Converter/output/_NoNamespace/GameDataController.cs` around
`GetSaveInfo`) showed the actual call is `DateTime.get_Now()` → a **parameterless**
`DateTime.ToString()` — .NET's own internal date-formatting machinery under the game's zh-CN
culture, which bakes in `"年"`/`"月"`/`"日"` as the culture's own date separators. This *never*
calls `System.String.Format`/`Concat` with the `"{0}年{1}月{2}日"` template at all — that dumped
`dynamicStrings.txt` entry is dead weight for this bug (it may still be genuinely used by some
other, undiscovered call site, decompiled or not — the pipeline can't attribute a literal back to
its call site, see the `DynamicStringsIL2CPP pipeline` section in
`tests-translation-workflow.instructions.md`). The reason `"年"`/`"月"` were *ever* partially
translated (proving *something* was live) is `DynamicStringPatches`' own sink-level
`TMP_Text`/`UI.Text` `.text`-setter postfix (`ApplyToComponentText`) — a blind bare-fragment
substring scan that runs on **any** text that reaches a UI component regardless of how it was
built. `"年"`/`"月"` happen to have their own standalone single-character dictionary entries (for
unrelated call sites elsewhere); `"日"` correctly has none — a bare single-hanzi entry for `日`
would be far too dangerous to substring-replace globally (`生日`/`节日`/`今日`/... would all get
corrupted), so it was never curated as one.

**General lesson reinforced**: don't assume a dumped `"{0}...{1}...{2}"`-shaped literal is
necessarily consumed via `System.String.Format` just because it looks like a format template —
trace the actual call site in the decompiled output before trusting that assumption, especially
when a fix that should be mechanically correct (confirmed via load-time logging) still produces
identical runtime behavior. Identical output after a supposedly-correct fix is itself strong
evidence the fix targeted the wrong code path, not that the fix "didn't take."

**Actual fix**: since the literal `"{0}"`/`"{1}"`/`"{2}"` text never survives into the rendered
string regardless of which BCL mechanism produced it (`String.Format`, `DateTime.ToString()`, or
anything else), a template can only be recognized *structurally* once its placeholders have
already been substituted with real data. `DynamicStringPatches` now compiles each `isTemplate:
true` dictionary entry (see `FanslationStudio.LlmKit`'s `DynamicStringResult.IsTemplate`, computed
once at packaging time rather than re-derived at runtime) into a `CompiledTemplate`: a regex built
from `Raw` (via `Regex.Escape` + replacing escaped `\{n\}` tokens with named capture groups
`(?<pN>.+?)`) paired with a `.NET` regex replacement string built from `Result` (same `{n}` tokens
rewritten as `${pN}` group references). `ApplyTemplates` runs this regex match+reconstruct pass —
with a cheap `LiteralSegments`-`Contains` pre-filter per template to avoid running ~400 regexes on
every call — in both `GenericPostfix` (Concat/Format's *result*) and the sink-level
`ApplyToComponentText`, **before** the existing bare-fragment `ApplyDictionary` pass, so a matched
composite's own literal separators are fully translated first and never left exposed to
accidental partial collisions from unrelated single-character bare entries. `FormatPrefix` (the
literal pre-substitution match on an actual `String.Format` call's template argument) is kept
alongside this as a second, complementary mechanism for the cases where a genuine `String.Format`
call really is involved — the two do not conflict, since `FormatPrefix` only ever sees literal
`"{n}"` text (before substitution) while `ApplyTemplates` only ever sees already-substituted text.

**Follow-up crash found while adding temporary diagnostic logging to investigate the above (still
2026-08-27): infinite recursion via `MainPlugin.Logger` itself.** Added a `LogInfo` call inside
`GenericPostfix`/`FormatPrefix` (guarded on a cheap regex pre-check) to empirically trace which
patch entry point observed the date string — this immediately stack-overflowed. Root cause:
BepInEx's `Logger`/`DiskLogListener.LogEvent` internally calls `System.String.Format` itself to
build the log line — which is one of the exact methods `DynamicStringPatches` patches — so any
`MainPlugin.Logger.LogInfo`/`LogError` call made **from inside** `GenericPostfix`/`FormatPrefix`
(including from a `catch` block's error log — not just deliberate diagnostic logging) re-enters
the same patch and recurses forever (confirmed via the stack trace: `GenericPostfix` →
`DynamicClass.DMD<String::Format>` → `DiskLogListener.LogEvent` → ... → `GenericPostfix` → ...).
**Fix (kept permanently, not just for the diagnostic)**: a `[ThreadStatic] _inFormatConcatPatch`
guard now wraps the entire body of both `GenericPostfix` and `FormatPrefix` (checked at entry,
set/reset around the whole `try`/`catch`/`finally`), so *any* nested `String.Format`/`Concat` call
triggered from inside them — whether from our own logging or anything else — is a cheap, silent
no-op instead of recursing. **General lesson**: never log (or call anything that might internally
call `String.Format`/`Concat`) from inside a Harmony patch on `String.Format`/`Concat` itself
without a re-entrancy guard around the whole patch body first — this applies to error-path
logging in `catch` blocks just as much as deliberate diagnostic logging, since both are equally
capable of triggering the recursion.

**ACTUAL ROOT CAUSE FOUND AND FIXED (2026-08-27): `BuildCompiledTemplate`'s placeholder-detection
regex never matched anything, so `ApplyTemplates`/`_compiledTemplates` never fired at all, for the
entire lifetime of this feature.** After fixing the recursion bug above, a second, safe diagnostic
(`SafeDebugLog`, writing directly to a plain file via `File.AppendAllText` — deliberately NOT
through `MainPlugin.Logger`, to avoid any repeat of the recursion bug) was added temporarily to
`GenericPostfix`/`FormatPrefix`/`ApplyToComponentText`, gated on a cheap CJK date-separator regex
pre-check. The resulting trace showed the save-slot date's `"1年2月5日"` converting to
`"1Year2Month5日"` — i.e. the `"年"`/`"月"` separators got translated but the trailing
`"{2}日"` → `"Day"` never did, even though there was no competing shorter template. Root-caused by
reproducing `BuildCompiledTemplate`'s old logic in isolation: it called `Regex.Escape(entry.Raw)`
first and then tried to find/replace the escaped `"{n}"` placeholder tokens back into named capture
groups via `Regex.Replace(escapedRaw, @"\\\{(\d+)\\\}", ...)` — but **`Regex.Escape` only escapes
the opening brace** (`Regex.Escape("{0}")` → `"\{0}"`, not `"\{0\}"` — confirmed via direct testing
in isolation), so that placeholder-finder regex (which required a backslash before the *closing*
brace too) never matched anything. Every compiled template's `Pattern` silently degraded into a
regex requiring the literal, pre-substitution text `"{0}年{1}月{2}日"` (with actual braces) to
still be present in the input — which can never happen once real data has replaced the
placeholders — so `ApplyTemplates` has been a complete no-op since this feature was introduced, and
every "fix" that touched `ApplyTemplates`/`_compiledTemplates` this session (including the earlier
"composite template" diagnosis for this same bug) was chasing a dead consumer while the real,
silently-broken code path went unnoticed.

**Fix**: `BuildCompiledTemplate` was rewritten to build the regex pattern by walking `Raw` directly
— finding each `{n}` placeholder token via `PlaceholderRegex.Matches(raw)`, `Regex.Escape`-ing only
the *literal text segments* in between (never touching the placeholder tokens themselves), and
inserting `(?<pN>.+?)` capture groups at the placeholder positions — instead of round-tripping
through `Regex.Escape` on the whole string and trying to reverse-engineer the escaping afterward.
Verified in isolation (outside the game) that the new approach correctly matches `"1年2月5日"` and
replaces it with `"1Year2Month5Day"` in one pass. **General lesson**: never assume
`Regex.Escape`'s output is symmetric/reversible for a specific character — check its actual
behavior for the specific characters you care about (here: `{` vs `}`) rather than assuming both
sides of a delimiter pair are escaped the same way. This is also a broader lesson about this whole
investigation: repeated "the fix made no difference" reports should have been a strong signal much
earlier to empirically verify each individual mechanism in isolation (e.g. a throwaway console/test
snippet exercising just `BuildCompiledTemplate`+`ApplyTemplates`) rather than only tracing the
in-game call path — the bug was entirely inside this plugin's own regex-building code, not in any
uncertainty about which game method/component was involved.

## Bare-fragment dictionary corruption of compound words + `DynamicStringColumnSources` fix (2026-08-27)

Follow-up to the template bug above: the same save-slot debug output showed
`ApplyDictionary`'s plain sequential substring-replace corrupting whole-phrase compounds that had
no dedicated dictionary entry of their own — e.g. `外门弟子` → `外门Disciple` (bare `弟子` →
`Disciple` fired instead), `仙霞派` (a force/sect name) left entirely untranslated in this code
path even though `Files/Converted/ForceData.csv.yaml` already has a correct "Xianxia Sect"
translation — because the save-slot description is built from raw save data
(`GameDataController.GetSaveInfo`/`SaveLoadMenuController.GetRecentSaveSlotDescribe`), bypassing
the already-translated CSV lookups entirely. Root cause was **data completeness, not a mechanism
bug** — `LoadDictionary`'s longest-`Raw`-first sort is correct, it just had no more-specific entry
to prefer over the generic single-character fallbacks for these particular compounds.

**Fix — repeatable, config-driven extraction instead of manual dictionary curation:**
`Tests/GameFileHandling.cs`'s `DynamicStringColumnSources` declares `(CsvFileName, int[] Columns)`
pairs for CSV columns known to hold whole-phrase display strings read raw by some IL2CPP code path
(currently `ForceData.csv` column 1 = force/sect name, `SpeHeroData.csv` column 5 = rank/tier tag).
`ExtractDynamicStringCandidatesFromColumns` reads each configured raw CSV under
`Files/Raw/Dumped/GameData/`, pulls every distinct non-empty value from the specified columns, and
appends any not already present in the master `dynamicStrings.txt` (or a previous run of this same
method) to a **separate** dump file, `Files/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt`
— kept distinct from `dynamicStrings.txt` (itself populated by reviewing/merging
  `Converter/output/_dynamicStrings_candidates.txt`, not hand-authored) purely for traceability (obvious at a
glance which entries were auto-pulled from CSV columns vs. manually found in decompiled code).
Registered as its own `TextFileToSplit` entry (same `TextFileType.DynamicStringsIL2CPP`), so it
flows through the *existing* `DynamicStringWorkflow`/`"1c." export`/merge/package pipeline
unchanged — no new Workflow class or TextFileType enum value needed. Run via `FileInputWorkflowTests`'s
`"1c-pre. ExtractDynamicStringCandidatesFromColumns"` fact, which must run before `"1c."` (idempotent,
safe to re-run any time a new `DynamicStringColumnSources` entry is added).

Packaging produces a second `Files/Mod/dynamicStringsFromColumns.txt.yaml` alongside the existing
`dynamicStrings.txt.yaml`. **Plugin-side change required:** `DynamicStringPatches.LoadDictionary`
previously looked up one exact filename (`dynamicStrings.txt.yaml`) via `FindResourceFile` — this
was generalized to `FindResourceFiles` + a glob (`DictionaryFilePattern = "dynamicStrings*.txt.yaml"`),
loading and merging every matching file's entries into one dictionary before the longest-first
sort. Adding further dynamicStrings-family dump files in future never requires another plugin
change — they just need to match the glob and be listed in `TextFilesToSplit`.

**Second extraction mode — `DynamicStringLabelColumnSources` (2026-08-27):** several other
`SkipColumns` entries (`KungFuData.csv`/`SummonKungFuData.csv` cols 7,8,9,10,13,
`ResourcePointTypeData.csv` cols 2-4, `SkinDataBase.csv` col 2) aren't single discrete values like
a force name — they're compound `Label<sign><number>[;Label<sign><number>...]` stat/resource
modifier cells (e.g. `内功1;经脉1`, `威望+2,药材+1`). Extracting the whole cell/item would be
useless (the number differs every row, e.g. `内功1` vs `内功4`), so `ExtractDynamicStringCandidatesFromColumns`
additionally splits each cell on `;`/`,` and strips the trailing sign+number via `StatLabelRegex`
(`^[^\d+\-]+`) to keep only the repeated Label vocabulary (e.g. `内功`, `威望`, `技艺经验`) —
config lives in the sibling `DynamicStringLabelColumnSources` array right next to
`DynamicStringColumnSources`. `NameData.csv`'s `SkipColumns=[0]` (`类别`: `姓`/`名`/`男名`/`女名`)
was deliberately excluded from both — it's a pure internal routing key never displayed to the
player, so there's nothing to translate. A real run against this game's data found ~110 distinct
labels this way, several already covered by existing whole-sentence entries in `dynamicStrings.txt`
(dedup correctly skipped `威望`/`学识` etc., already present there).



- **`PrefabTextPatches` bug found (2026-08-28): multi-line strings never matched, silently falling
  through to `DynamicStringPatches`' bare-fragment corruption.** Symptom (screenshot on the
  character-creation "choose sect" screen): `"自由选择门派拜入，逐鹿天下或浪迹江湖。\n<color=green>..."`
  rendered as `"Freedom选择SectJoin under，逐鹿SkyDown或浪迹Jianghu。..."` — individual
  characters/words translated but the correct whole-string translation (already present in
  `Files/Mod/dumpedPrefabText.txt.yaml`) never applied. Root cause: `AssetDumperWorkflowTests.cs`
  dumps component text with real newlines collapsed to a **literal** `"\n"` (two chars: backslash +
  `n`, via `text.Replace("\n", "\\n").Replace("\r", "")`) so each entry stays one line in the flat
  dump/CSV/YAML files — every `Raw`/`Result` key in the packaged dictionary uses that escaped form.
  But a live `TMP_Text`/`UI.Text` component's runtime `.text` contains **real** newline characters
  (baked into the prefab via Unity's multi-line inspector fields), never the escaped form — so
  `PrefabTextPatches`' exact-match `Dictionary<string,string>.TryGetValue(currentText, ...)` never
  matched any multi-line entry (typically `<color=...>`-wrapped multi-line descriptions), silently
  fell through unreplaced, and the still-Chinese text then reached `DynamicStringPatches`' same
  `.text`-setter postfix (lower Harmony priority, runs second), which bare-fragment-substituted
  individual words/characters into the untouched Chinese, producing the mixed-language mess.
  **Fix**: added `NormalizeForLookup`/`DenormalizeFromLookup` helpers in `PrefabTextPatches.cs` —
  runtime text is normalized (real newline → literal `\n`) before the dictionary lookup, and the
  matched `Result` is denormalized (literal `\n` → real newline) before being assigned back to the
  component. Applied at both call sites (`ApplyExactMatchToComponentText`'s sink-level setter
  postfix and `ReplaceIfKnown`'s load-time tree-walk). **General lesson**: whenever an exact-match
  dictionary is built from a serialized/escaped dump of runtime data, verify the escaping is
  reversed (or reapplied) symmetrically at every point the dictionary is both loaded from and
  looked up against — a one-way escape (dump time only) silently breaks matching for any value
  containing the escaped character, without throwing or logging anything.
- **Follow-up bug found (2026-08-28), one layer up in the pipeline**: `DynamicStringWorkflow.
  IsFormatTemplate` (sibling `FanslationStudio.LlmKit` repo,
  `FanslationStudio.LlmKit/Workflow/DynamicStringWorkflow.cs`) only matched `{n}`-style
  `String.Format` placeholders, not the game's own `#Token#`/`#$Token#` localization markers (e.g.
  `#TargetInteractName#`, substituted with a real hero name by the game's own systems before the
  string ever reaches a patched `Concat`/`Format` call or `TMP_Text`/`UI.Text` setter). A `Raw`
  containing ONLY a `#Token#` marker (no `{n}`) was therefore never flagged `isTemplate: true` in
  the packaged YAML, so it never reached `DynamicStringPatches.cs`'s `_compiledTemplates` regex
  matcher — even though that matcher's own `PlaceholderOrTokenRegex` already correctly treats
  `#Token#` markers as wildcards (see "CONFIRMED BUG #2" in `DynamicStringPatches.cs`). The entry
  landed in the plain bare-fragment dictionary instead, where the full raw string (still containing
  the literal, never-actually-present `#Token#` text) could never match, silently falling through
  to bare-fragment substring corruption — e.g.
  `"久闻#TargetInteractName#武功高强，不知是否愿意赐教一二。"` rendering as
  `"久聞MasterMartial arts高強，不知是否愿意賜教One二0"` instead of the correct whole-sentence
  translation already present in the dictionary. **Fix**: extended `FormatPlaceholderRegex` in
  `DynamicStringWorkflow.cs` to `@"\{\d+\}|#\$?[A-Za-z0-9_]+#"` (matching
  `DynamicStringPatches.cs`'s `PlaceholderOrTokenRegex` shape), then re-ran the "6. Package to Game
  Files" fact (`FileOutputWorkflowTests`) to regenerate `Files/Mod/dynamicStrings.txt.yaml` with
  `isTemplate: true` now set correctly — **no re-dump/re-export needed**, since `IsTemplate` is
  computed fresh at packaging time from `line.Raw`, not carried over from the export step.
  **General lesson**: when two independent layers both need to recognize the same placeholder
  shape (packaging-side classification vs. plugin-side structural matching), keep their regexes
  explicitly cross-referenced in comments — a fix applied to only one layer's regex (as happened
  here, and previously for the numbered-only `{n}` case) silently defeats the other layer's
  already-correct logic without any error or warning.
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
- **Same bug class found in `ForceData.csv` (2026-08-28), causing an uncaught
  `ArgumentOutOfRangeException` ("Index was out of range...") in
  `HandBookMenuController.ShowForceSkill`** (reached via the faction handbook screen's
  `SkillHandBookForceTab.OnClick`). `ForceData.csv` had **no `SkipColumns` at all** before this
  fix. Decompiling `GameDataController`'s CSV loader for `GameData/ForceData`
  (`Converter --filter "GameDataController"`) found three unprotected label-cross-reference
  columns, all following the same "split cell, look up label text against a fixed internal
  dictionary" shape as the already-documented `HeroTagData`/`KungFuData`/`ResourcePointTypeData`
  cases: column 9 (`武功专长`/"Combat specialty", `;`-separated, e.g. `轻功;刀法;射术`), column 10
  (`技艺专长`/"Craft specialty", same shape), and column 11 (`特色物品`/"Signature item",
  `:`-separated `Label:Number`, e.g. `珍宝:1.5` — same lookup helper call site as
  `ResourcePointTypeData.csv`'s "资源" column). Translating these labels makes the lookup miss,
  and the resulting default/invalid index later gets used to index a small fixed-size collection
  elsewhere in the HandBook UI, producing the out-of-range crash. **Fix**: `SkipColumns = [9, 10,
  11]` added to `ForceData.csv`'s `TextFilesToSplit` entry in `Tests/GameFileHandling.cs`. Note
  `ForceSpeAddDataBase.csv` (column 1, `特效`) is itself the match *target* for
  `StringToSpeAddData`-style lookups from other files (`HeroTagData.csv`/`KungFuData.csv`/etc.,
  whose effect columns are already `SkipColumns`-protected and stay in Chinese) — translating
  `ForceSpeAddDataBase.csv`'s own label column to English means those untouched-Chinese lookups
  can now never match at all going forward (a silent, logged-only no-op per
  `StringToSpeAddData`'s own catch-and-log behavior, not a crash) - not yet fixed, flagged here for
  awareness if a "translated effect text isn't applying its stat bonus" report ever surfaces.

## `PrefabTextPatches` — runtime replacement of hardcoded prefab UI text (TMP_Text/UI.Text only)

**Correction (2026-08-28):** an earlier version of this note claimed `plotText`/`describe`/etc.
fields "already round-trip through the existing CSV workflow" and were deliberately out of scope.
That was WRONG — confirmed by grepping every dumped GameData CSV that none of these values
(`plotText`, `describe`, `tutorialText`, `eventDescribe`, `startRemindText`, `choiceText`, plus
short name-fields like `name`/`eventName`/`plotName`) have a CSV source at all; they're populated
from `Files/Raw/Dumped/PrefabText/dumpedOtherText.txt` (the diagnostic-only dump
`AssetDumperWorkflowTests.cs` writes for every non-primary MonoBehaviour field) instead. See
`Tests/GameFileHandling.cs`'s `DynamicStringOtherTextFields`/
`ExtractDynamicStringCandidatesFromOtherText` for exactly which field names are trusted (each
individually sampled for ASCII/underscore noise before being promoted) and how they're extracted.
These fields were originally routed through `DynamicStringPatches`' substring/fragment dictionary
(`dynamicStringsFromColumns.txt`), then **moved here** 2026-08-28: since every value on these
fields is always assigned as a complete, non-concatenated string, an exact whole-string match is
strictly safer than a bare-fragment substring replace (no risk of a shorter unrelated fragment
mangling part of an unmatched string). They now feed a second dump file,
`Files/Raw/Dumped/PrefabText/dumpedPrefabTextFromOtherFields.txt` (registered as its own
`TextFileToSplit` entry, `TextFileType.PrefabText`), packaged to
`Files/Mod/dumpedPrefabTextFromOtherFields.txt.yaml` and loaded here alongside
`dumpedPrefabText.txt.yaml` (see the `DictionaryFilePattern`/multi-file glob note below). The
extraction call moved from the `"1c."` fact to `"1b."` in `Tests/FileInputWorkflowTests.cs` so it
runs before `ExportPrefabTextAssetToCustomFormat` packages whatever's on disk.

`TMP_Text.text`/`UI.Text.text` remain the only component fields patched directly — the two
"primary" fields `AssetDumperWorkflowTests.cs` dumps to `dumpedPrefabText.txt` (see
`IsPrimaryTextField`) — the fields above reach the same two setters at runtime regardless of which
data class they're read from, so no additional component-field coverage was needed to fix this.

**Why not `Awake`/`OnEnable`/`set_text` patches (tried and rejected):** a prefab's serialized field
values come from native IL2CPP deserialization directly, bypassing C# property setters/lifecycle
callbacks for the initial baked-in value — those hooks may never fire for the text already present
on a freshly-loaded/instantiated prefab. Instead, `PrefabTextPatches` Harmony-postfixes
`Resources.Load(string, Il2CppSystem.Type)` and `AssetBundle.LoadAsset(string)`, and if the result
is a `GameObject`, manually walks its transform tree looking for `TMP_Text`/`UI.Text` components to
patch directly — mirroring both `AssetDumperWorkflowTests.cs`'s offline scan and the old
Mono-only `XUnity.ResourceRedirector`-based `TextReplacerPlugin` (`G:\Xyzj2OverLlm\EnglishPatch\
PrefabText\TextReplacerPlugin.cs` from a different game/repo) this replaces —
`XUnity.ResourceRedirector` itself doesn't support IL2CPP, hence the manual Harmony patches here
instead of that library's asset/resource-loaded hooks.

**New interop-safety finding: no `is`/`as` pattern matching against IL2CPP wrapper types either.**
The existing "no generic `Cast<T>()`/`TryCast<T>()`" rule extends to C#'s `is`/`as` operators when
used against Il2Cpp wrapper types — Il2CppInterop implements those operators via the same generic
`TryCast<T>()` machinery under the hood, so `component is TMP_Text` is just as unsafe as calling
`TryCast<TMP_Text>()` directly. `PrefabTextPatches` avoids this entirely by requesting components
by exact type up front instead of testing components after the fact:
`GameObject.GetComponents(Il2CppSystem.Type)` is Unity's own inheritance-aware native lookup, so
requesting `Il2CppType.From(typeof(TMP_Text))` (the **non-generic** `Il2CppType.From(System.Type)`
overload — not the generic `Il2CppType.Of<T>()`) already returns only `TMP_Text`-or-subclass
instances (e.g. `TextMeshProUGUI`), reconstructed via the confirmed-safe `(IntPtr)` pointer-wrap
constructor (`new TMP_Text(component.Pointer)`) — same pattern as `ResourceIoPatches`'
`new TextAsset(__result.Pointer)`. Confirmed via reflection against the real interop DLLs that both
`TMP_Text` and `UI.Text` expose a public `(IntPtr)` constructor, and that
`GameObject.GetComponents` only has a `(Il2CppSystem.Type)` overload (not a `(System.Type)` one) in
this build.

**`AssetBundle.LoadAsset(string)` has no requested-`Type` parameter** to check against (unlike
`Resources.Load(string, Il2CppSystem.Type)`), so `PrefabTextPatches.IsGameObject` queries the
returned object's real IL2CPP class directly via `IL2CPP.il2cpp_object_get_class` +
`il2cpp_class_get_namespace_`/`il2cpp_class_get_name_` — the same non-generic technique
`UnityLogCapture.FormatMessage` already uses for `Il2CppSystem.Object` — rather than casting.

**Dictionary format/location:** `PrefabTextPatches` searches recursively under
`BepInEx\plugins\resources\` for every file matching the glob `dumpedPrefabText*.txt.yaml`
(`DictionaryFilePattern`, mirroring `DynamicStringPatches.DictionaryFilePattern`'s
`dynamicStrings*.txt.yaml` — currently matches both `dumpedPrefabText.txt.yaml` and
`dumpedPrefabTextFromOtherFields.txt.yaml`, NOT a fixed flat path - they're actually deployed at
`resources\GameData\...`, mirroring the CSV overrides' subfolder convention), loading and merging
every matching file's entries into one dictionary — adding a further `dumpedPrefabText`-family dump
file in future never requires another plugin change, it just needs to match the glob and be listed
in `TextFilesToSplit`. Each file is the flat raw/result YAML list produced by
`FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow.PackagePrefabTextAsync`
(e.g. `Files/Mod/dumpedPrefabText.txt.yaml`) — via a `YamlDotNet` `PackageReference` embedded through
Costura.Fody (same `CopyLocalLockFileAssemblies=true` + Costura pattern as
`System.Text.Encoding.CodePages`; confirmed embedded by checking
`costura.yamldotnet.dll.compressed` appears in the built DLL's `GetManifestResourceNames()`).
Replacement is an exact raw-string dictionary lookup, matching each component's current
`.text` verbatim before overwriting it. **Deserializer gotcha:** the dictionary YAML keys are
lowercase (`raw`/`result` — matching `PrefabTextResult`'s YamlDotNet-serialized camelCase output),
so the plugin's `DeserializerBuilder` must configure `.WithNamingConvention(CamelCaseNamingConvention.Instance)`
(and `.IgnoreUnmatchedProperties()`) — a plain `new DeserializerBuilder().Build()` with no naming
convention requires an exact PascalCase match and throws
`YamlException: Property 'raw' not found on type '...PrefabTextEntry'` for every entry.

**Harmony `[HarmonyTargetMethod]` + class-level `[HarmonyPatch]` gotcha:** when a nested patch
class uses `[HarmonyTargetMethod]` to manually resolve an ambiguous overload (see
`AssetBundleLoadAssetPatch` above), the class-level `[HarmonyPatch(...)]` attribute must specify
**only the declaring type** — adding a method name/args overload to that same attribute (e.g.
`[HarmonyPatch(typeof(AssetBundle), nameof(AssetBundle.LoadAsset))]`) throws
`ArgumentException: You cannot combine TargetMethod, TargetMethods or [HarmonyPatchAll] with
individual annotations` at `Harmony.CreateAndPatchAll` time (plugin fails to load entirely) — the
`TargetMethod()` resolver must be the *only* way Harmony determines what to patch on that class.

**Gap found by live testing: `Resources.Load`/`AssetBundle.LoadAsset` alone miss scene-embedded
UI (e.g. the Start/title screen).** A GameObject that's part of a scene file's own serialized
contents (not a standalone prefab asset) is instantiated directly by Unity's scene loader and
never passes through either load call, so the dictionary loaded fine but no on-screen text ever
changed for that screen. Fixed by also patching
`[HarmonyPatch(typeof(UnityEngine.SceneManagement.SceneManager), "Internal_SceneLoaded")]` (a
private static method, patched by string name — confirmed non-ambiguous via reflection, only one
overload exists) and walking `scene.GetRootGameObjects()` with the same recursive tree-walk used
for the asset-load patches, once the scene has fully finished loading. If more untranslated text
turns up later, check whether it's genuinely scene-embedded vs. a prefab loaded through some other
call this doesn't cover yet (e.g. `AssetBundle.LoadAssetAsync`, addressables) before assuming the
dictionary itself is incomplete.



