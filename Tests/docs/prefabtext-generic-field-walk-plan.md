# Deferred alternative: generic PrefabText-style field-walk for plotText/tutorialText/etc.

**Status: Open / deferred.** Not implemented. The quick fix below is in place and works; this is
the more architecturally precise alternative, kept here in case the quick fix's tradeoffs become
a problem later.

## Current state (quick fix, implemented 2026-08-27)

`plotText`, `tutorialText`, `choiceText`, `startRemindText`, `describe`, `eventDescribe`,
`jobDescribe` were added to `Tests/GameFileHandling.cs`'s `DynamicStringOtherTextFields`, routing
them through the DynamicStrings substring-replace mechanism
(`DragonHeirPlugin/DynamicStringPatches.cs`'s `TMP_Text.text`/`UI.Text.text` setter patches). This
works but is "good enough," not the most precise mechanism available.

## Why this exists / the tradeoff

These fields are genuinely GameObject/MonoBehaviour-sourced data (confirmed via
`AssetDumperWorkflowTests`'s asset scan), so they arguably belong in the PrefabText pipeline
(whole-string exact-match, mutated in place at load time) rather than DynamicStrings
(substring-replace on the `.text` setter, sink-level). The blocker: `PrefabTextPatches.cs`'s
`ProcessGameObjectRecursive` only reads `TMP_Text.text`/`UI.Text.text` - two fixed Unity types with
real C# wrappers. `plotText`/`describe`/etc. live on custom game-specific classes (`SinglePlotData`,
`InnData`, `EventData`-like types) that aren't in any reference assembly the plugin has - reading/
writing them requires generic IL2CPP field reflection by string name (not a typed property
access), which `PrefabTextPatches` doesn't currently do at all. That's a materially bigger, riskier
lift than the DynamicStrings config change, so the DynamicStrings route was implemented first.

## The proper alternative plan (to do later, if picked back up)

1. **Research first (no code)**: use Converter's decompiler (`--filter` on the class declaring
   `plotText`/`tutorialText`/`describe`/etc.) to find the exact class name(s) and how they're
   reached from a root MonoBehaviour (direct field vs. nested in a `List<T>`/array). Also confirm
   these values are actually present on the object at load time (same timing `PrefabTextPatches`
   already hooks) rather than being constructed/concatenated dynamically later in code - if the
   latter, this whole approach is moot and DynamicStrings is actually the more correct mechanism.
2. **Build a generic IL2CPP field-walker**: use `il2cpp_class_get_fields`/`il2cpp_field_get_value`/
   `il2cpp_field_set_value` (or Il2CppInterop equivalents) to read/write a MonoBehaviour instance's
   fields by string name without a compile-time C# type for the nested class. Extend
   `ProcessGameObjectRecursive` (or add a sibling method) to walk these custom fields too,
   recursing into `List<T>`/array fields to reach nested per-entry structs. Follow the IL2CPP
   interop safety rules in `dragonheirplugin.instructions.md` (no generic `Cast<T>`, `(IntPtr)`
   wrap constructors, try/catch every step, fail-safe on error).
3. **Reuse `dumpedPrefabText.txt.yaml`'s lookup format** - still exact whole-string match, so only
   the write side (how replacement gets applied) is new, not the dictionary format. Decide whether
   to widen `AssetDumperWorkflowTests.IsPrimaryTextField` for these field names or add a new
   dedicated file/allowlist so PrefabText stays the source of truth for whole-string content.
4. **If successful, roll back the `DynamicStringOtherTextFields` addition** - remove `plotText`/
   `tutorialText`/`choiceText`/`startRemindText`/`describe`/`eventDescribe`/`jobDescribe` from that
   list (keep the name-family entries there, those are genuinely fine as substring-replace) and
   move them to the PrefabText allowlist instead - whole-string exact-match is more precise than
   substring replace for paragraph-length text.
5. **Test plan**: verify field discovery via decompiled-code read before writing the runtime
   patch. Add temporary logging counting instances of each target field found/mutated per
   scene/prefab load (mirroring `AssetDumperWorkflowTests`'s `monoBehavioursSkipped` counter
   pattern). In-game verification on the same screens as before (plot dialogs, tutorial popups,
   inn interactions).
