# DynamicStringPatches agent reference

Use this document before changing `DynamicStringPatches.cs`. The source intentionally keeps only short pointers; detailed investigations are indexed from `DragonHeirPlugin/KNOWN_ISSUES.md`.

## Ownership and flow

`PatchAll` loads all recursively discovered `dynamicStrings*.txt.yaml` files, merges compatible `dumpedPrefabText*.txt.yaml` entries, derives supplemental dialogue-label entries, precomputes replacement edge characters, and sorts bare entries longest-first. It then patches every public static non-generic string-returning `String.Concat` and `String.Format` overload, followed by the known TMP/UI text setters.

There are two translation passes:

- `ApplyTemplates` handles structural entries marked `IsTemplate` and must run before `ApplyDictionary`.
- `ApplyDictionary` handles bare exact-substring entries in longest-raw-first order.

`GenericPostfix` applies both passes to Concat/Format results. `FormatPrefix` applies the bare substring pass to the pre-substitution `String.Format` template argument. `ApplyToComponentText` applies both passes after a TMP/UI setter, which also catches literal assignments that never call Concat or Format. `TranslateFragment` and `ReverseTranslate` are public narrow helpers used by other patch classes.

## Template compiler rules

`BuildCompiledTemplate` walks `Raw` directly with `PlaceholderOrTokenRegex`; do not escape the complete raw string and attempt to recover placeholders afterward. `{n}` markers become named `pN` groups; game markers such as `#Token#` and `#$Token#` become ordered `tokN` groups. The replacement pattern is built from the corresponding markers in `Result`.

The primary capture class excludes CJK ideographs, CJK punctuation, and compatibility ideographs. This prevents a short template such as `经验{0}%` from consuming unrelated Chinese text. `ApplyTemplates` tries `PermissivePattern` only after the strict pattern fails, because legitimate token values can themselves be CJK. That fallback depends on `BlockingRawEntries` to protect overlapping, longer bare phrases; review that coverage before changing the fallback.

Adjacent raw placeholders have no intrinsic boundary. A maximal adjacent run is merged into one permissive pass-through capture only when `Result` contains the same markers in order with whitespace-only gaps. Otherwise the template is rejected. A final unanchored placeholder group uses a greedy zero-or-more quantifier; ordinary groups use lazy zero-or-more quantifiers so empty substitutions still match. Do not replace these targeted rules with blanket greedy matching or whole-input anchoring.

`LiteralSegments` is a cheap pre-filter. For each matching template, `OverlapsBlockingEntry` checks the original text span before replacement and leaves overlapping matches untouched so the later longest-first bare pass can translate the more specific phrase.

## Loading and data conventions

Prefab-text YAML uses literal `\\n` after deserialization; normalize only merged prefab entries to real newlines at load time. Never normalize the runtime string globally, because native dynamic-string YAML uses real newline characters.

Prefab-text entries containing game token markers are routed into the template dictionary. Semicolon-suffixed dialogue-option entries receive a supplemental label-only entry using the text before the first semicolon. Explicit label-only entries win. The packaged pipeline filters non-CJK raw entries, which is why `ContainsCjk` can gate the hot path.

The reverse dictionary is built from bare entries only and uses first-wins semantics after longest-first ordering. It is for exact translated whole-string lookup, not reverse substring translation.

## Re-entrancy and diagnostics

`GenericPostfix` and `FormatPrefix` must set `_inFormatConcatPatch` before any logging or diagnostic string work. BepInEx logging and interpolated/string helper operations can call the patched BCL methods again. The text-setter path has its separate `_inTextSetterPostfix` guard and must set it before reading, logging, or writing text.

Failures are best-effort: catch interop/runtime failures, log where safe, and leave the original value intact. `LogResidualCjkDebug` writes directly to `residualCjkDebug.log` and is gated by `MainPlugin.ResidualCjkDebugEnabled`; never route that diagnostic through the patched logger path.

## Performance and spacing

`ApplyDictionary` uses a lazily-built character set to reject entries whose first raw character cannot occur in the current result. Rebuild it only after a replacement. Replacement edge characters are precomputed once per entry with rich-text tags removed.

`ReplaceWithWordBoundarySpacing` inserts a space only when both adjoining visible edges are alphanumeric. Its tag-aware helpers skip complete rich-text tags when finding those visible edges. Keep the allocation-free builder/string scans on the hot path; regex helpers are load-time only.

## Change checklist

When changing this file:

1. Preserve `ApplyTemplates` before `ApplyDictionary`.
2. Keep strict-then-permissive template matching and blocking-overlap checks together.
3. Keep all patched-call logging behind the appropriate thread-static guard.
4. Verify any new placeholder or newline convention against the pipeline and packaged YAML.
5. Add focused coverage in `Verify/` or the relevant existing test project when the logic can run outside IL2CPP.
6. Read the matching issue document before modifying a confirmed bug fix: `dynamicstringpatches-template-regex-bug.md`, `dynamicstringpatches-cjk-placeholder-fallback.md`, `dynamicstringpatches-adjacent-placeholder-merge.md`, `prefabtext-multiline-and-token-placeholder-bugs.md`, and `dynamicstrings-column-source-extraction.md`.
