# DynamicStringPatches agent reference

Use this document before changing `DynamicStringPatches.cs`. The source intentionally keeps only short pointers; detailed investigations are indexed from `docs/KNOWN_ISSUES.md`.

## Ownership and flow

`PatchAll` loads all recursively discovered `dynamicStrings*.txt.yaml` files, merges compatible `dumpedPrefabText*.txt.yaml` entries, derives supplemental dialogue-label entries, precomputes replacement edge characters, and sorts bare entries longest-first. It then patches every public static non-generic string-returning `String.Concat` and `String.Format` overload, followed by the known TMP/UI text setters.

There are two translation passes:

- `ApplyTemplates` handles structural entries marked `IsTemplate` and must run before `ApplyDictionary`.
- `ApplyDictionary` handles bare exact-substring entries in longest-raw-first order.

`GenericPostfix` applies both passes to Concat/Format results. `FormatPrefix` applies the bare substring pass to the pre-substitution `String.Format` template argument. `ApplyToComponentText` applies both passes to text assigned through a TMP/UI/NGUI setter, which also catches literal assignments that never call Concat or Format. `TranslateFragment` and `ReverseTranslate` are public narrow helpers used by other patch classes.

`RunGenericPipeline` memoizes per mode: the full-corpus mode and the `preferLogNarrativeTemplates` mode (the small isolated log-narrative template list) have separate `MemoCache`s, because the two modes can return different translations for the same input.

## Text-setter sinks

`TmpTextSetText_Prefix`, `UiTextSetText_Prefix` and `UiLabelSetText_Prefix` are **prefixes that rewrite the incoming `ref string value`** before the native setter stores it. They are not postfixes that read `.text` back and assign it again. The native setters early-out when the new value equals the stored one. A postfix left English stored, so a label the game re-assigns with the same Chinese every frame was never equal to the stored value. Every such assignment then cost two native sets, two dirty marks and a canvas rebuild. `value` is the parameter name Il2CppInterop gives generated property setters (checked in the interop metadata for all three types); Harmony binds it by name.

`HandleTextSetter` scans for CJK once, runs `PrefabTextPatches.TryApplyExactMatch`, then `ApplyToComponentText`, which returns the string to store instead of calling a setter. Per-component state lives in `_componentTextCache` (`RawSnapshot`/`TranslatedSnapshot`). Its fast paths, in order:

1. **Repeat raw.** The incoming text equals `RawSnapshot`, so `TranslatedSnapshot` is returned unchanged. The native setter then sees an unchanged value and does no work.
2. **Typewriter.** The incoming text is a prefix of a seeded `TranslatedSnapshot`. `SeedComponentTranslatedSnapshot` clears `RawSnapshot`, so the repeat-raw path can never return seeded text for an older raw string.
3. **Trusted append-only source**, then the optional suffix-only append path.
4. **Full pipeline.**

## Template compiler rules

`BuildCompiledTemplate` walks `Raw` directly with `PlaceholderOrTokenRegex`; do not escape the complete raw string and attempt to recover placeholders afterward. `{n}` markers become named `pN` groups; game markers such as `#Token#` and `#$Token#` become ordered `tokN` groups. The replacement pattern is built from the corresponding markers in `Result`.

The primary capture class excludes CJK ideographs, CJK punctuation, and compatibility ideographs. This prevents a short template such as `经验{0}%` from consuming unrelated Chinese text. `ApplyTemplates` tries `PermissivePattern` only after the strict pattern fails, because legitimate token values can themselves be CJK. That fallback depends on `BlockingRawEntries` to protect overlapping, longer bare phrases; review that coverage before changing the fallback.

Adjacent raw placeholders have no intrinsic boundary. A maximal adjacent run is merged into one permissive pass-through capture only when `Result` contains the same markers in order with whitespace-only gaps. Otherwise the template is rejected. A final unanchored placeholder group uses a greedy zero-or-more quantifier; ordinary groups use lazy zero-or-more quantifiers so empty substitutions still match. Do not replace these targeted rules with blanket greedy matching or whole-input anchoring.

`LiteralSegments` is a cheap pre-filter. For each matching template, `OverlapsBlockingEntry` checks the original text span before replacement and leaves overlapping matches untouched so the later longest-first bare pass can translate the more specific phrase.

`CompiledTemplate` stores `PatternSource`/`PermissivePatternSource` and builds each `Regex` (still `RegexOptions.Compiled`, still with `TemplateRegexTimeout`) on first use. Building all ~5,500 eagerly was most of plugin load time, while the trigger-char/literal pre-filter means few templates reach a regex in a session. A pattern that fails to construct is logged once and its property returns null; `ApplyTemplatesSinglePass` skips that template, matching the old load-time drop. Concurrent first use from the prewarm thread is safe: `Interlocked.CompareExchange` publishes one instance. Do not switch to an interpreted regex for early uses. It is slower, so it could hit the 25 ms timeout on a match the compiled regex completes, and memoize a different translation.

`BlockingRawEntries` is computed with a char → entries index. Each segment is tested only against the entries containing its rarest character, and results are memoized per distinct segment. The final list is then re-sorted by `Rank`, so it equals the old full template × dictionary scan in content and order.

## Loading and data conventions

Prefab-text YAML uses literal `\\n` after deserialization; normalize only merged prefab entries to real newlines at load time. Never normalize the runtime string globally, because native dynamic-string YAML uses real newline characters.

Prefab-text entries containing game token markers are routed into the template dictionary. Semicolon-suffixed dialogue-option entries receive a supplemental label-only entry using the text before the first semicolon. Explicit label-only entries win. The packaged pipeline filters non-CJK raw entries, which is why `ContainsCjk` can gate the hot path.

The reverse dictionary is built from bare entries only and uses first-wins semantics after longest-first ordering. It is for exact translated whole-string lookup, not reverse substring translation.

## Re-entrancy and diagnostics

`GenericPostfix` and `FormatPrefix` must set `_inFormatConcatPatch` before any logging or diagnostic string work. BepInEx logging and interpolated/string helper operations can call the patched BCL methods again. Any string built while the guard is not held, and containing CJK, is itself run through the whole pipeline and memoized, pushing real translations out of the cache. `RunGenericPipeline` therefore sets the guard itself for its whole duration and restores the caller's value afterwards, so callers no longer have to remember to. Diagnostic helpers format their text inside `WithConcatGuard`, and `PerfInstrumentation` holds the guard while invoking sample delegates. The text-setter path has its separate `_inTextSetterPostfix` guard and must set it before reading, logging, or writing text.

Failures are best-effort: catch interop/runtime failures, log where safe, and leave the original value intact. `LogResidualCjkDebug`, `LogMissionDebug` and `LogUnexpectedQuestionMark` write to `residualCjkDebug.log` through one session-long buffered `StreamWriter` (`AppendDebugLog`). It is flushed at most once per second and on `MainPlugin.OnDestroy`, instead of the old `File.AppendAllText` per line; the log routinely reaches hundreds of MB per session when enabled. All are gated by `MainPlugin.ResidualCjkDebugEnabled`; never route them through the patched logger path. `LogUnexpectedQuestionMark` takes a state plus a `static` label builder, so the label (which embeds raw CJK text) is only built when logging is on and a `'?'` actually appeared. Do not go back to passing a pre-built interpolated label at every template/dictionary hit.

`GenericPostfix` calls `PerfInstrumentation.SampleCallerStack` while instrumentation is on. That logs each distinct managed caller stack (up to 25) to `perfStats.log`. It exists to settle an open question: the patch targets CoreCLR's `System.String.Concat`/`Format`, not IL2CPP's, so native game code may never reach it. A game-originated call would show Il2CppInterop trampoline frames.

## Performance and spacing

`ApplyDictionary`'s contract is: repeatedly apply the highest-`Rank` entry present in the current text until none is. `Rank` is the entry's position in its longest-Raw-first list, so ties are broken by load order. `BuildDictionaryIndex` (a `DictionaryIndex` per dictionary) buckets entries of two or more characters by their first two characters, and single-character entries by that character. `CollectIndexedCandidates` gathers only the buckets whose pair or character occurs in the text, sorted by `Rank`. Rebuild candidates only after a replacement.

Skip rule: after replacing an entry whose Result is non-empty and CJK-free (`ResultLeavesNoCjk`), an all-CJK entry (`RawIsAllCjk`) that already failed `Contains` cannot match. The replacement only removed CJK text and put non-CJK text between its neighbours. Such entries ranked at or before `skipThroughRank` are skipped after the restart. Any other replacement resets the rule. Keep the CJK character class used by these flags identical to `ContainsCjk`/`IsCjkCharSingle`, and keep `ReplaceWithWordBoundarySpacing` inserting only ASCII spaces; the rule depends on both.

Tie behaviour: before 2026-10-02, equal-length candidates were ordered by an unstable `List.Sort`. The winner among duplicate `Raw` entries with different Results (e.g. `天` → "Day"/"Days") could therefore depend on text length. Ordering by `Rank` makes the first-loaded entry always win.

`IsFullyCoveredByDictionary` tiles through `FindLongestDictionaryMatchAt`'s first-character buckets. It must not scan `_dictionary` linearly: it is called twice per candidate split point by `AdjacentRunSplitter`, inside regex match evaluators. Each bucket keeps longest-first order, so its first hit is the same entry a full scan would find.

`ApplyTemplatesSinglePass` checks `presentChars.Overlaps(template.TriggerChars)`. `HashSet.Overlaps` enumerates its argument, so the receiver must be the text's character set and the argument the template's small trigger set. Reversed, the check walks every distinct character in the text once per template. Replacement edge characters are precomputed once per entry with rich-text tags removed.

Hot-path `PerfInstrumentation.Measure` calls use the state-passing overload with a `static` lambda, so they allocate nothing while instrumentation is off.

`ReplaceWithWordBoundarySpacing` inserts a space only when both adjoining visible edges are alphanumeric. Its tag-aware helpers skip complete rich-text tags when finding those visible edges. Keep the allocation-free builder/string scans on the hot path; regex helpers are load-time only.

## Change checklist

When changing this file:

1. Preserve `ApplyTemplates` before `ApplyDictionary`.
2. Keep strict-then-permissive template matching and blocking-overlap checks together.
3. Keep all patched-call logging behind the appropriate thread-static guard.
4. Verify any new placeholder or newline convention against the pipeline and packaged YAML.
5. Add focused coverage in `Verify/` or the relevant existing test project when the logic can run outside IL2CPP.
6. Keep the text-setter hooks as `ref string value` prefixes that return the stored text, never postfixes that re-assign `.text`.
7. Preserve `ApplyDictionary`'s Rank ordering and skip-rule preconditions, and keep `Overlaps` called on the text's character set.
8. Read the matching issue document before modifying a confirmed bug fix: `dynamicstringpatches-template-regex-bug.md`, `dynamicstringpatches-cjk-placeholder-fallback.md`, `dynamicstringpatches-adjacent-placeholder-merge.md`, `prefabtext-multiline-and-token-placeholder-bugs.md`, `dynamicstrings-column-source-extraction.md`, and `performance-optimization-pass-2026-10-02.md`.
