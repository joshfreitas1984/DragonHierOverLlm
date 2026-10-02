# Performance optimization pass (2026-10-02)

**Status: implemented and built against the real interop assemblies; in-game smoke test still
outstanding** (see [Verification](#verification)).

A full read-through review of every plugin patch class for performance, followed by
implementation. Unlike the [2026-09-13 pass](performance-optimization-pass-2026-09-13.md), several
of these changes touch the translation algorithms themselves. Each algorithm change was checked for
output equivalence, and the one observable difference (tie-breaking) is described below.
Current-state rules live in the runtime-plugin references; this record keeps the reasoning and
measurements.

## Measurements

These numbers come from an out-of-game harness. It compiled the real `DynamicStringPatches.cs`
against stub Unity/Harmony types and ran the shipped `Files/Mod` dictionaries (19,754 fragments,
2,735 templates) over a 5,750-line corpus. The corpus was a random sample of fragment raws,
template raws, templates filled with random fragments/names/numbers, 3–8-line concatenations of
filled templates, multi-fragment concatenations, and `PlotData.csv` rows.

| Stage | Before | After |
|---|---|---|
| `PatchAll` (load) | 5.2 s | 0.96 s |
| Full pipeline, steady state (regexes already built) | 20.5 s | 3.3 s |
| Full pipeline, first pass (includes lazy regex construction) | 20.5 s | 12.4 s |
| Log-narrative pipeline | 4.6 s | 0.8 s |
| `TranslateFragment` (dictionary pass only) | 4.3 s | 0.66 s |
| `IsFullyCoveredByDictionary` | 1.47 s | 10 ms |
| Simulated text setter (set, re-set, append) | 11.8 s | 3.8 s |

The first-pass figure is pessimistic: this corpus touches nearly every template, while a real
session only builds the regexes its text actually reaches (roughly 2–3 ms each, once).

## Equivalence check and the one behaviour change

Comparing old and new outputs over every entry point initially showed ~0.6% of strings differing.
They were all ties between equal-length dictionary candidates. The old `CollectCandidates` sorted
by length with `List.Sort`, which is unstable: insertion sort (stable) below 17 candidates,
introsort above. So among duplicate `Raw` entries with different Results (e.g. `天` → "Day" and
"Days", both in `dynamicStrings.txt.yaml`), which one won depended on how long the text was. With
the old code's tie-break made deterministic (length, then load order), old and new matched exactly:
0 differences across 43,125 outputs, including the setter re-set and append scenarios.

The new ordering (`Rank`: longest first, then load order) is what the code's own comments describe
as the intended invariant. It now applies consistently: **the first-loaded duplicate always wins**.
If a duplicate `Raw` resolves differently in-game than it did before, that is why; fix it in the
data by removing the unwanted duplicate.

## Changes

### Text-setter sinks: postfix → `ref string value` prefix

The native `Text`/`TMP_Text`/`UILabel` setters early-out when the new value equals the stored one.
The old postfix re-assigned English after the game stored Chinese, so a label the game refreshes
with the same Chinese every frame was never equal to what was stored. Each such assignment cost two
native sets, two dirty marks and a canvas rebuild, plus an interop `.text` read. Translating in a
prefix (plus a repeat-raw fast path returning the component's cached translation) makes repeat
assignments arrive equal to the stored text, so the native setter does nothing. `value` was
confirmed as the setter parameter name for all three types by reading the interop DLL metadata.
`SeedComponentTranslatedSnapshot` now clears `RawSnapshot` so the fast path can't pair seeded
typewriter text with an older raw string.

### Template pass

- `template.TriggerChars.Overlaps(presentChars)` → `presentChars.Overlaps(template.TriggerChars)`.
  `HashSet.Overlaps` enumerates its argument, so the old form walked every distinct character in
  the text once per template (2,735 times per pass).
- `Regex` objects are built on first use instead of at `PatchAll`. An interpreted warm-up regex was
  considered and rejected: being slower, it could hit the 25 ms `TemplateRegexTimeout` on a match
  the compiled regex finishes, and memoize a different translation.
- `BlockingRawEntries` at load: a char → entries index tests each literal segment only against the
  entries containing its rarest character, memoized per distinct segment. The old version was a
  2,735 × 19,754 `Contains` scan.

### Dictionary pass

- Candidates are bucketed by first two characters (`DictionaryIndex`) instead of first character.
  Long text contains most CJK characters, so first-character buckets dragged in most of the
  dictionary; distinct character pairs are far more selective.
- Skip rule: after a replacement whose Result is non-empty and CJK-free, all-CJK entries that
  already failed `Contains` are skipped instead of re-scanned after the restart from index 0. The
  argument, and the preconditions it depends on, are in the DynamicStringPatches reference.
- `IsFullyCoveredByDictionary` used a linear scan of all ~20k entries per CJK position. It is
  called twice per candidate split point by `AdjacentRunSplitter`, inside regex match evaluators.
  It now uses the first-character buckets.

### Memo cache, re-entrancy and diagnostics

- **Separate memo caches.** `RunGenericPipeline`'s log-narrative mode now has its own memo cache.
  Previously both modes shared one key space, so whichever mode saw an input first decided what the
  other returned (a correctness bug as well as wasted prewarm work).
- **Concat guard held by the pipeline.** `RunGenericPipeline` holds `_inFormatConcatPatch` itself.
  Several callers (text setters, `RecordLogDisplayPatches`, the prewarm `Task`, the
  Tutorial/MartialClub prefixes) never set it.
- **Diagnostic labels no longer translated.** The `'?'` diagnostic labels were interpolated strings
  embedding raw CJK, built at every template/dictionary hit even with logging off. Built through the
  patched `String.Concat` without the guard, they ran the whole pipeline on themselves and were
  memoized, evicting real translations. They are now built lazily and under the guard.
- **Buffered debug log.** `residualCjkDebug.log` uses one buffered writer instead of an
  `AppendAllText` per line. With `ResidualCjkDebugLogging` on, the log had reached 249 MB in a
  single session.
- **No-op perf scopes.** `PerfInstrumentation.Measure` returns a no-op scope when instrumentation is
  off. A state-passing overload with `static` lambdas removes the per-call closure allocations on
  hot paths, and `Record` holds the Concat guard while running sample delegates.

### Other patches

- **`PrefabTextPatches`:** one `GetComponentsInChildren(type, includeInactive: true)` per text type
  replaces the per-node recursion, which made three `GetComponents` calls plus transform/child
  calls for every GameObject.
- **`PlotTextSizePatches`:** the `Time.deltaTime` frame tick (`FrameTickPatch`) is only registered
  when perf instrumentation or a debug hotkey needs it. The PlotText check in the
  `Text.preferredWidth` postfix is cached per component instead of reading `.name` on every layout
  call.
- **`HorseMountedIconPatches`:** the per-frame sprite key build plus `LoadAtlasSprite` is cached per
  horse item ID and the `Image` per controller, and the sprite setter is skipped when the icon
  already shows the right sprite.
- **`ResourceIoPatches` / `ExploreDataDumpPatches`:** the raw dumps are now behind `[Debug]
  DumpRawAssets`, off by default, because they cost a full read, decode and write of every CSV on
  every load for players. The `game-update-refresh` skill now tells you to enable it before
  launching.
- **`UnityLogCapture`:** registered only when `[Debug] CaptureUnityLog` is on (on by default).
- **`GlobalDataListOverrides`:** the `GetAttriLv` postfix is unpatched once the tier lists are
  applied. The unpatch is done from the `PlotController.Awake`/`ShowHeroDetail` trigger, never from
  inside `GetAttriLv`'s own patch.
- **`MultiPassTemplateApplication`:** the description now says it is on by default (as the code
  always was) and notes its extra-pass cost.

## Open question: does game code reach the Concat/Format patch?

`DynamicStringPatches` patches `typeof(string)`'s `Concat`/`Format`, which is CoreCLR's
`System.String`. IL2CPP game code calls IL2CPP's own native `String.Concat`, which those Harmony
patches never detour. So `GenericPostfix`/`FormatPrefix` may only ever see managed strings from the
plugin, BepInEx, YamlDotNet and interop. Some earlier investigations assumed it saw game strings.
`PerfInstrumentation.SampleCallerStack` now logs each distinct caller stack to `perfStats.log`
while instrumentation is on. A game-originated call would show Il2CppInterop trampoline frames.
Removing the patch would change behaviour even if nothing native reaches it, since plugin code
implicitly relies on it (e.g. string building in `HeroNamePatches` fallbacks).

## Verification

Done:

- The plugin builds against the real interop references with 0 errors.
- The non-generic `GetComponentsInChildren(Il2CppSystem.Type, bool)` overload exists in this
  build: it compiled against the generated interop.
- Setter parameter names were read from the interop metadata.
- The out-of-game equivalence check described above.

Still needed in game:

1. **Text translation.** Dialogue, logs, tooltips, prefab-heavy panels (HeroDetailPanel,
   BranchLeaderSettingTab) and the plot typewriter reveal still translate.
2. **`GetAttriLv` unpatch.** The log shows `[GlobalDataListOverrides] Unpatched
   GlobalData.GetAttriLv` with no crash. Runtime unpatching under Il2CppInterop is new to this
   plugin.
3. **Frame tick.** With `PerfInstrumentation` on, `perfStats.log` still gets periodic dumps,
   confirming `FrameTickPatch` registers.
