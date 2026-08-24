# DragonHeirPlugin — crash investigation case studies

> Detailed historical investigation notes for `DragonHeirPlugin/` crashes and interop findings.
> **Not** auto-loaded into agent context (unlike
> `.github/instructions/dragonheirplugin.instructions.md`, which has `applyTo: DragonHeirPlugin/**`)
> — read this explicitly when investigating a new crash or when you need the full reasoning behind
> an existing mitigation/fix. Keep the instructions file itself short; put new deep-dive narratives
> here instead of growing that file again.

## `ResourceIoPatches` CSV override — why row-level merge was abandoned

`Load_Postfix` used to go through `CsvMerger.MergeByFirstColumn` (still present in `CsvMerger.cs`
but no longer called), which matched base/override rows by each row's first CSV column, on the
assumption that column 0 is a stable per-row ID. **That assumption is false for at least
`NameData.csv`**: column 0 there is a repeated category label (`姓`/"Surname"), not a unique ID,
and the override file's own column 0 gets translated too (`姓` → `"Surname"`). Every base row's
lookup by `"姓"` then missed every override row keyed by `"Surname"`, so **every row silently fell
back to the original untranslated text** — no exception was thrown, the log line even reported a
successful merge with a plausible non-zero output length, but the actual in-game text never
changed. This is a good example of why "no error + plausible-looking log output" isn't sufficient
evidence a transform actually worked — always compare a snippet of the *actual resulting content*,
not just whether an operation completed without throwing.

The real reason a row-level merge isn't needed at all: `Tests/GameFileHandling.cs`'s
`PackageFinalTranslationAsync` already writes a **complete drop-in file** to `Files/Mod/*.csv` —
every row is present, with translated rows using the translated text and untranslated/failed rows
written back as their original raw text. So the file the plugin picks up under
`resources/<path>.csv` is never a partial patch; it's always the full intended replacement, and
`Load_Postfix` should just use it wholesale. If you ever reintroduce any kind of merge logic here,
first re-verify the "column 0 is a stable ID" assumption per-file — it does not hold universally.

## `UnityLogCapture` — why `Application.logMessageReceived` couldn't be used

BepInEx's built-in Unity log redirection did not fire for this game/build. The obvious fix,
`UnityEngine.Application.logMessageReceived`, **does not exist** in this game's stripped interop
build — verified by reading `BepInEx\interop\UnityEngine.CoreModule.dll`'s raw metadata directly
(`System.Reflection.Metadata`/`PEReader`, no assembly load or execution — regular
`Assembly.LoadFile`/`AssemblyLoadContext` reflection over these interop DLLs throws
`ReflectionTypeLoadException`/returns null `GetType` results outside the actual game process,
because IL2CPP interop stub assemblies have interdependencies that only resolve inside the running
game host). `UnityEngine.Application`'s type definition has **no** `logMessageReceived` event,
backing field, or add/remove method at all in this build — Il2CppInterop only generates members
that are actually referenced/used. Do not waste time trying to subscribe to it here; it will fail
to even compile (`CS0117`).

What *is* present and safe to use (confirmed via the same metadata dump): `UnityEngine.Debug`'s
`Log`, `LogWarning`, `LogError`, `LogException`, `LogAssertion`, each with a plain-`object`
overload and an `(object, UnityEngine.Object context)` overload, plus `*Format` variants. Since
virtually all engine- and game-originated log traffic funnels through these same `Debug` methods,
`UnityLogCapture.cs` Harmony-postfix-patches all of the non-Format overloads and writes every
message to `BepInEx\plugins\unity-log.txt`, plus mirrors errors/warnings/exceptions/asserts into
`MainPlugin.Logger`. Registered in `MainPlugin.Load()` via
`Harmony.CreateAndPatchAll(typeof(UnityLogCapture))` — no separate `Install()`/event-subscription
step needed since it's pure Harmony patching.

If a future Unity/BepInEx interop build *does* expose `logMessageReceived`, re-check with the same
metadata-dump technique before wiring it up — relying on compile-time IntelliSense/decompiled
signatures from a different game's interop build can be misleading.

## Post-resource-load errors — encoding mismatch investigation (real bug, but NOT the actual crash cause — see correction)

Investigated a `System.ArgumentOutOfRangeException` in `StartMenuController.ResetFaceSetting`
(via Unity log captured by `UnityLogCapture`). Initial theory: `Files/Raw/Dumped/GameData/SpeHeroFaceData.csv`
(and its `TextAsset` source) is **GBK-encoded on disk, not UTF-8**, unlike every other game data
CSV. Confirmed by hex-dumping `Files/Raw/Dumped/GameData/*.csv`: every file decodes as clean UTF-8
except `SpeHeroFaceData.csv`, which is full of `EF BF BD` (U+FFFD replacement character) sequences
— i.e. irreversibly corrupted once read via `TextAsset.text`. Unity's `TextAsset.text` getter
always assumes UTF-8 regardless of the asset's real source encoding, so any GBK-sourced asset gets
silently mangled with no exception at read time — the corruption only surfaces later as a
downstream crash.

Decompiling `StartMenuController.ResetFaceSetting` (`Converter --filter "StartMenuController"`)
confirmed the game does a hardcoded-literal comparison (`String.Equals(value, DAT_181d76148, 0)`)
against a column read at a row index, with a bounds check on a list count that could plausibly
throw if a lookup returned the wrong value/count — the same class of bug already known and guarded
for in `Tests/GameFileHandling.cs`'s `NameData.csv` handling.

**Fix applied (real bug, still worth keeping, but unrelated to this specific crash — see
correction below)**: `ResourceIoPatches.Load_Postfix` no longer reads `TextAsset.text` (lossy,
UTF-8 only). It now reads `TextAsset.bytes` directly and decodes via `DecodeAssetBytes`: strict
UTF-8 first (`throwOnInvalidBytes: true`), falling back to GBK (codepage 936,
`Encoding.GetEncoding(936)`) when the bytes aren't valid UTF-8. Requires
`Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)` (registered once in
`MainPlugin.Load()`) and the `System.Text.Encoding.CodePages` NuGet package (see the Costura
section below for what it took to get this dependency working at runtime). The override
write-back path is unaffected — translated override files are already plain UTF-8.

### Correction: `SpeHeroFaceData.csv` encoding was NOT the cause of the `ResetFaceSetting` crash

After deploying the encoding fix and re-launching, the exact same `ArgumentOutOfRangeException`
recurred immediately on reaching `TitleScene` — **before** `SpeHeroFaceData` was ever loaded.
Confirmed via `BepInEx/LogOutput.log`: only six `Resources.Load` calls for `GameData/*` were
logged before the crash (`NameData`, `SpeAddDataBase`, `ForceSpeAddDataBase`, `TechDataBase`,
`AreaData`, `ResourcePointTypeData`) — `SpeHeroFaceData` was never among them. So the earlier
hypothesis was **wrong** — that file isn't even in the call path that crashes.

Decompiling `StartMenuController.ShowStartMenu` (the caller) confirmed
`ResetFaceSetting()`/`ResetPlayerSkeleton()`/`ResetPlayerTag()` run **unconditionally** the moment
`this.attriRoot != null` — as soon as the title screen shows its character-creation panel, not
gated behind any of our translated CSVs at all. The loop inside `ResetFaceSetting` that ultimately
throws is bounded by a list-count read from a **different, unlabeled** class's static instance
(`DAT_181d81570` in the decompiled output — not `GameDataController`). `_static_labels.csv`
doesn't have a resolved class name for `DAT_181d81570`, so static analysis alone couldn't pin down
which list is actually out of range at this point in the investigation (later resolved — see
"CONFIRMED root cause" below).

**Lesson**: don't trust a plausible-sounding correlation (matching row-ID shapes, matching CSV
encoding corruption) as proof of causation without confirming the actual runtime call path via
logs — this was the second time a "looks right" theory turned out to be wrong when checked
against real log/runtime evidence (the `NameData.csv` merge bug above was the first). Always check
`BepInEx/LogOutput.log` for what actually loaded/ran before the crash, not just what plausibly
could have.

### Temporary mitigation: `ResetPlayerTag` cascading crash + `CrashMitigationPatches.cs`

Once `CrashMitigationPatches.ResetFaceSetting_Finalizer` suppresses the original exception,
`StartMenuController.ResetPlayerTag` (called immediately after `ResetFaceSetting` inside
`ShowStartMenu`'s unconditional sequence) throws a **cascading** `NullReferenceException`.
Decompiling both methods confirmed they share the same unresolved statics pointer chain
(`var pStatics = *(int64*)(DAT_181d81570 + 184);` in both). Working theory: `ResetFaceSetting`
normally finishes initializing whatever object lives at `*pStatics + 24` before `ResetPlayerTag`
runs, and aborting `ResetFaceSetting` mid-execution leaves that shared object in a state
`ResetPlayerTag` doesn't expect. **Mitigated** the same way — added a second
`[HarmonyFinalizer]` patch (`ResetPlayerTag_Finalizer`) in `CrashMitigationPatches.cs` that logs
and suppresses this cascade too, so testing isn't blocked by a second crash while the real root
cause is investigated. **Lesson**: suppressing an exception mid-method via a Harmony Finalizer can
leave shared/global state half-initialized, causing failures in whatever code runs next and
depends on that state.

### Diagnostic patch added to find the actual crashing field

The bounds check that ultimately throws `ArgumentOutOfRangeException` in `ResetFaceSetting`
derives its loop bound from `DAT_181d81570`'s statics-pointer chain, but the value actually being
*indexed* per-iteration comes from a **different** object:
`*(int64*)(pGameDataController + 0x1d8)` on the resolved `GameDataController` singleton instance.
Neither `DAT_181d81570` nor the specific field at instance offset `+0x1d8` could be identified via
`_string_map.csv`/decompiled output alone (see the Converter decompiler limitation note in
`converter.instructions.md`).

Added `DiagnosticPatches.cs`: `[HarmonyPrefix]` patches on both `ResetFaceSetting` and
`ResetPlayerTag` that reflect over the live `GameDataController.Instance`'s public instance fields
(plain `System.Reflection` on the wrapper object — safe, not a generic Il2Cpp interop call) and log
each field's declared type plus `Count` (when the value exposes one) *before* the original method
body runs. Registered alongside the other patch classes via
`Harmony.CreateAndPatchAll(typeof(DiagnosticPatches))`. Remove `DiagnosticPatches.cs` once the
actual root cause is found and the real fix is in place (it has since been removed — see "CONFIRMED
root cause" below).

**Ruled out** during this pass: comparing every `Files/Raw/Dumped/GameData/*.csv` against its
corresponding `Files/Mod/*.csv` output showed **zero row-count differences** across all 27 files —
so the crash was not caused by the translation pipeline changing a file's row count; look instead
at content/value changes (e.g. a column whose *value* the game does a hardcoded literal-string
comparison against).

**Also fixed in this pass**: `SpeHeroFaceData.csv` under `Files/Raw/Dumped/GameData/` had been
dumped *before* the encoding fix, so its corruption was baked in — it remains commented out of
`Tests/GameFileHandling.cs`'s `TextFilesToSplit` (never added to translation).

## Gotcha: plain `PackageReference` dependencies are never copied to the plugin output — must embed via Costura.Fody, AND override `CopyLocalLockFileAssemblies`

Adding `System.Text.Encoding.CodePages` as a normal `PackageReference` (for the GBK decode fix
above) compiled fine locally, but crashed the game at plugin load time:
`System.IO.FileNotFoundException: Could not load file or assembly
'System.Text.Encoding.CodePages, ...'`. Confirmed via `dotnet build -v:diag` (search for
`CopyLocalLockFileAssemblies`): BepInEx's SDK/props set `CopyLocalLockFileAssemblies = false`
project-wide, so **no** `PackageReference`-resolved DLL is ever copied into `bin/Debug/<tfm>/`,
even locally — this is intentional BepInEx behavior (avoids duplicating/conflicting with
assemblies already present in `BepInEx\core`/`BepInEx\interop`), but it silently breaks any *new*,
non-BepInEx-provided managed dependency you add.

**First fix attempt (incomplete)**: adding Costura.Fody alone was **not** sufficient — Costura
embeds by scanning the build output folder (`bin/`) for reference assemblies, and since
`CopyLocalLockFileAssemblies=false` meant the CodePages DLL was never copied into `bin/` in the
first place, Costura had nothing to find and embed for that specific package (the build "succeeded"
and the DLL size grew, which *looked* like a successful embed but wasn't for the one assembly that
actually mattered). Don't trust an increased output size alone as proof a specific dependency got
embedded — verify the actual embedded resource name.

**Complete fix**: both required.
1. Override `CopyLocalLockFileAssemblies` back to `true` in `GamePlugin.csproj`'s main
   `PropertyGroup` so package-reference DLLs land in `bin/` again, where Costura can see them.
2. Embed the dependency into the plugin DLL at build time via **Costura.Fody**:
   ```xml
   <PackageReference Include="System.Text.Encoding.CodePages" Version="7.0.0" />
   <PackageReference Include="Costura.Fody" Version="6.0.0">
     <PrivateAssets>all</PrivateAssets>
   </PackageReference>
   <PackageReference Include="Fody" Version="6.8.2">
     <PrivateAssets>all</PrivateAssets>
     <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   ```
   Also requires a `FodyWeavers.xml` at the project root containing just
   `<Weavers><Costura /></Weavers>` — without it, the packages restore but the weaver never
   actually runs and nothing gets embedded.

**How to actually verify a specific dependency got embedded**: spawn a short-lived separate
process to load the built DLL and list `GetManifestResourceNames()`, filtering for the dependency
name — via a disposable `.ps1` run through `powershell -NoProfile -File script.ps1` (a *separate*
process, not inline in the same terminal session — `Assembly.LoadFile` locks the DLL for the
lifetime of the loading process, which then blocks the next `dotnet build`'s copy step with
`MSB3027`/file-in-use errors until that process is killed). Look for
`costura.system.text.encoding.codepages.dll.compressed` in the resource list. Confirmed working
end-to-end: full clean rebuild grew `FanslationStudio.EnglishPatch.dll` to ~10.2 MB (up from
~6.8 MB once `CopyLocalLockFileAssemblies` was also fixed), and the resource list included the
CodePages entry. No changes were needed to the existing `PostBuild` `XCOPY` target since Costura
merges everything into that one already-deployed file.

**Rule of thumb going forward**: any time a *new* external (non-interop, non-BepInEx) NuGet
dependency is needed in this plugin, assume by default it will neither be copied to `bin/` nor
embedded by Costura automatically — set `CopyLocalLockFileAssemblies=true` and add the Costura
pattern together from the start, then verify via `GetManifestResourceNames()` in a throwaway
process before assuming it's fixed.

## CONFIRMED root cause of the `ResetFaceSetting`/`ResetPlayerTag` crash: a translated effect-string breaks `GameDataController.StringToSpeAddData`, which aborts the rest of `LoadAllGameData`

Found via systematic A/B testing (rename `BepInEx\plugins\resources\**` on/off, then isolate
individual override files) combined with `DiagnosticPatches.cs`'s field/property dump:

- With the **entire** `resources` override folder disabled (raw/untranslated game data only),
  every `GameDataController` database populates correctly (`loveableSpeHeroList.Count=57`, etc.)
  and neither crash occurs.
- With overrides re-enabled but **only `LoveableSpeHero.csv` disabled**, the crash still occurred
  and `loveableSpeHeroList.Count=0` — ruling out that specific file.
- With overrides re-enabled but **only `ResourcePointTypeData.csv` disabled**,
  `resourcePointTypeDataBase` (which had been `Count=0` in every prior run) came back to its
  correct `Count=18`, and the load sequence progressed further — but `heroTagDataBase` was now
  `Count=0` instead, and everything loaded after it was still `null`/empty, and `ResetPlayerTag`
  crashed with a **different** exception (`KeyNotFoundException` in
  `StartMenuController.RefreshTagMenu`, not the original `NullReferenceException`).

This proves `GameDataController.LoadAllGameData` builds its ~30 databases in a single sequential
pass with **no per-file exception isolation** — whichever database's CSV parse throws first leaves
that dictionary/list empty (not partially filled) and **aborts the entire rest of the load
sequence**, leaving every database initialized later than the failure point at its default value
(`null` for reference types). Both `ResetFaceSetting`'s and `ResetPlayerTag`'s crashes are
downstream symptoms of *whichever* database failed to load, not bugs in those two methods
themselves — this also fully explains the earlier-reported "files aren't always being dumped like
they used to" regression: once `LoadAllGameData` aborts partway through, every `Resources.Load`
call for a database later in the sequence simply never happens.

**Confirmed mechanism** (via decompiling `GameDataController.cs`): `HeroTagData.csv`'s "效果"
column (index 4) is fed straight into `GameDataController.StringToSpeAddData(string resource)`
while building `heroTagDataBase`. That method splits the cell on `;`, strips the trailing signed
number off each fragment via regex to recover a label, then linear-searches
`this.forceSpeAddDataBase` (built independently from `ForceSpeAddDataBase.csv`, also translated)
for an entry whose own label field is an **exact `String.Equals` match**. If no match is found it
just logs `"StringToSpeAddData Error: <fragment>"` and continues (this recoverable path is what
produces the many "StringToSpeAddData Error" log lines seen even against untranslated raw data —
a harmless, pre-existing vanilla logging quirk unrelated to translation). But if a match *is*
found, it does `Single.Parse` on the remaining numeric text with **no surrounding try/catch** —
any `FormatException` here propagates all the way up through `LoadAllGameData` uncaught. Because
the pipeline translates the label text embedded in `HeroTagData.csv`/`ResourcePointTypeData.csv`
*and* the label text in `ForceSpeAddDataBase.csv`/`SpeAddDataBase.csv` **independently, file by
file**, an LLM can plausibly translate the "same" underlying Chinese label differently across
files, leading to a `Single.Parse` on a non-numeric leftover string. `ResourcePointTypeData.csv`'s
analogous "守城效果" column is presumed to hit the same or a structurally identical failure mode
(same behavioral signature: dict ends up `Count=0`, not partially filled).

**Real fix (pipeline-side, not this plugin)**: mark the effect-string columns on
`HeroTagData.csv` (column 4) and `ResourcePointTypeData.csv` (column 4) as `SkipColumns` in
`Tests/GameFileHandling.cs`'s `TextFilesToSplit` — see `Tests/KNOWN_ISSUES.md` for the pipeline
change and re-run instructions. `DiagnosticPatches.cs`/`CrashMitigationPatches.cs` in this plugin
have since been removed now that the pipeline fix is applied and confirmed.

### Same bug class found in a second call path: `KungFuData.csv`/`SummonKungFuData.csv` column 13 via `GameDataController.LoadSkillData`

Found via a real playtest's `Player.log` after the `PlotData.csv`/`ResourcePointTypeData.csv`/
`HeroTagData.csv`/`SkinDataBase.csv` fixes above were already in place: the game progressed all the
way past `PlotData.csv` loading with no crash, but then hit an **uncaught
`ArgumentException: oldValue is the empty string`** thrown from `System.String.Replace` inside
`GameDataController.StringToSpeAddData`, called from `GameDataController.LoadSkillData`, called
from `LoadAllGameData`.

Decompiling `GameDataController` shows `LoadSkillData` feeds THREE columns into
`StringToSpeAddData` unconditionally: columns 7, 8, and 13 — the exact same
`Label<sign><number>;...` compound-cell/cross-reference pattern as `HeroTagData.csv`'s "效果"
column, just reached via a different loader method. Column headers: 7/8 are `修炼效果`/"Training
effect" and `运功效果`/"Skill effect"; column 13 is `使用特效`/"Use special effects".

**Important correction**: an initial fix only added `SkipColumns = [7, 8]`. This did NOT fix the
crash — columns 7/8 are **always empty** in every row of this game's actual data (`LoadSkillData`
checks for empty before calling `StringToSpeAddData`, so an empty cell never reaches it), meaning
the initial fix was harmless but didn't address the real cause. **Column 13** is populated in
nearly every row and is the column that actually triggers the crash. Lesson: when a decompiled
function feeds multiple columns into the same hazardous call, grep the RAW source CSV/TextAsset to
confirm which of those columns are actually populated in this game's real data before assuming the
"obviously similar-looking" one is the culprit.

Unlike the previously-documented cases (which only hit `Single.Parse` after a *successful* label
match), this crash occurs one step earlier, inside `StringToSpeAddData`'s own regex-based
label-stripping: it does `Regex.Replace(fragment, <trailing-signed-number-pattern>, "")` to
recover just the label text, then `String.Replace(fragment, strippedLabel, "")` to strip the label
back out — if the translated label text has been reduced to nothing at all (an empty string),
`String.Replace` throws `ArgumentException: oldValue is the empty string` rather than merely
logging a mismatch and moving on. Different failure signature, same root cause and fix: never let
translation touch these compound label cells at all.

**Fix applied**: `SkipColumns = [7, 8, 13]` on both `KungFuData.csv` and `SummonKungFuData.csv`'s
`TextFilesToSplit` entries (7/8 kept for completeness/future-proofing even though currently
always-empty; 13 is the column that actually mattered).

### Third occurrence: `StringToAttriRatio` (fatal, no try/catch) on the same two files' columns 9/10

See `Tests/KNOWN_ISSUES.md`'s "`KungFuData.csv`/`SummonKungFuData.csv` columns 9/10 —
`StringToAttriRatio`" section for the full writeup — same file/row, but a *different* decompiled
method (`StringToAttriRatio`, not `StringToSpeAddData`) with no try/catch at all around
`Single.Parse`, making it immediately fatal rather than merely logged. Fixed by adding columns `9,
10` to the same `SkipColumns` lists.
