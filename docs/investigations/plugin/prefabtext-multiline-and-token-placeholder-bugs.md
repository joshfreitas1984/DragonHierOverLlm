# PrefabTextPatches multi-line escaping bug + DynamicStringWorkflow `#Token#` template bug (2026-08-28)

## `PrefabTextPatches` bug: multi-line strings never matched, silently falling through to `DynamicStringPatches`' bare-fragment corruption

Symptom (screenshot on the character-creation "choose sect" screen):
`"自由选择门派拜入，逐鹿天下或浪迹江湖。\n<color=green>..."` rendered as
`"Freedom选择SectJoin under，逐鹿SkyDown或浪迹Jianghu。..."` — individual characters/words
translated but the correct whole-string translation (already present in
`Files/Mod/dumpedPrefabText.txt.yaml`) never applied.

**Root cause**: `AssetDumperWorkflowTests.cs` dumps component text with real newlines collapsed to
a **literal** `"\n"` (two chars: backslash + `n`, via
`text.Replace("\n", "\\n").Replace("\r", "")`) so each entry stays one line in the flat
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
postfix and `ReplaceIfKnown`'s load-time tree-walk).

**General lesson**: whenever an exact-match dictionary is built from a serialized/escaped dump of
runtime data, verify the escaping is reversed (or reapplied) symmetrically at every point the
dictionary is both loaded from and looked up against — a one-way escape (dump time only) silently
breaks matching for any value containing the escaped character, without throwing or logging
anything.

## Follow-up bug, one layer up: `DynamicStringWorkflow.IsFormatTemplate` didn't recognize `#Token#`/`#$Token#` markers

`DynamicStringWorkflow.IsFormatTemplate` (sibling `FanslationStudio.LlmKit` repo,
`FanslationStudio.LlmKit/Workflow/DynamicStringWorkflow.cs`) only matched `{n}`-style
`String.Format` placeholders, not the game's own `#Token#`/`#$Token#` localization markers (e.g.
`#TargetInteractName#`, substituted with a real hero name by the game's own systems before the
string ever reaches a patched `Concat`/`Format` call or `TMP_Text`/`UI.Text` setter). A `Raw`
containing ONLY a `#Token#` marker (no `{n}`) was therefore never flagged `isTemplate: true` in
the packaged YAML, so it never reached `DynamicStringPatches.cs`'s `_compiledTemplates` regex
matcher — even though that matcher's own `PlaceholderOrTokenRegex` already correctly treats
`#Token#` markers as wildcards (see "CONFIRMED BUG #2" in `DynamicStringPatches.cs`). The entry
landed in the plain bare-fragment dictionary instead, where the full raw string (still containing
the literal, never-actually-present `#Token#` text) could never match, silently falling through to
bare-fragment substring corruption — e.g.
`"久闻#TargetInteractName#武功高强，不知是否愿意赐教一二。"` rendering as
`"久聞MasterMartial arts高強，不知是否愿意賜教One二0"` instead of the correct whole-sentence
translation already present in the dictionary.

**Fix**: extended `FormatPlaceholderRegex` in `DynamicStringWorkflow.cs` to
`@"\{\d+\}|#\$?[A-Za-z0-9_]+#"` (matching `DynamicStringPatches.cs`'s `PlaceholderOrTokenRegex`
shape), then re-ran the "6. Package to Game Files" fact (`FileOutputWorkflowTests`) to regenerate
`Files/Mod/dynamicStrings.txt.yaml` with `isTemplate: true` now set correctly — **no
re-dump/re-export needed**, since `IsTemplate` is computed fresh at packaging time from
`line.Raw`, not carried over from the export step.

**General lesson**: when two independent layers both need to recognize the same placeholder shape
(packaging-side classification vs. plugin-side structural matching), keep their regexes
explicitly cross-referenced in comments — a fix applied to only one layer's regex (as happened
here, and previously for the numbered-only `{n}` case) silently defeats the other layer's
already-correct logic without any error or warning.
