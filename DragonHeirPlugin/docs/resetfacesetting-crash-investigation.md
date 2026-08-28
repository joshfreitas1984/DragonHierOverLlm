# `ResetFaceSetting`/`ResetPlayerTag` crash — full investigation (encoding red herring → CONFIRMED root cause)

> This is the fullest single investigation in this project's history — kept intact as a case study
> in not trusting a plausible-looking correlation, and in how `LoadAllGameData`'s "abort on first
> exception, no per-file isolation" behavior turned an unrelated crash into a wild goose chase.
> **Real, currently-applied fix** is the `SkipColumns` pipeline change described at the bottom —
> read that section first if you just need the current-state summary; the rest is how we got
> there.

## Encoding mismatch theory (real bug, but NOT the actual crash cause)

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
`MainPlugin.Load()`) and the `System.Text.Encoding.CodePages` NuGet package (see
`costura-embedded-dependencies.md` for what it took to get this dependency working at runtime).
The override write-back path is unaffected — translated override files are already plain UTF-8.

## Correction: `SpeHeroFaceData.csv` encoding was NOT the cause of the `ResetFaceSetting` crash

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
against real log/runtime evidence (the `NameData.csv` merge bug in
`resourceio-csv-merge-abandoned.md` was the first). Always check `BepInEx/LogOutput.log` for what
actually loaded/ran before the crash, not just what plausibly could have.

## Temporary mitigation: `ResetPlayerTag` cascading crash + `CrashMitigationPatches.cs`

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

## Diagnostic patch added to find the actual crashing field

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

## CONFIRMED root cause: a translated effect-string breaks `GameDataController.StringToSpeAddData`, which aborts the rest of `LoadAllGameData`

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
`Tests/GameFileHandling.cs`'s `TextFilesToSplit` — see
`Tests/docs/skipcolumns-stringtospeadddata-family.md` for the pipeline change and re-run
instructions. `DiagnosticPatches.cs`/`CrashMitigationPatches.cs` in this plugin have since been
removed now that the pipeline fix is applied and confirmed.
