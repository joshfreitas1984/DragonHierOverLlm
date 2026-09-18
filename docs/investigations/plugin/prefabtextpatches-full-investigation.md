# `PrefabTextPatches` — full investigation history

> Current-state summary lives in `dragonheirplugin.instructions.md`. This doc has the fuller
> narrative: a wrong-scope correction, a design decision (why not lifecycle-callback patches), an
> interop-safety finding, and a scene-loading coverage gap.

## Correction (2026-08-28): `plotText`/`describe`-family fields ARE in scope, contrary to an earlier note

An earlier version of the current-state note claimed `plotText`/`describe`/etc. fields "already
round-trip through the existing CSV workflow" and were deliberately out of scope. **That was
WRONG** — confirmed by grepping every dumped GameData CSV that none of these values (`plotText`,
`describe`, `tutorialText`, `eventDescribe`, `startRemindText`, `choiceText`, plus short
name-fields like `name`/`eventName`/`plotName`) have a CSV source at all; they're populated from
`Files/Raw/Dumped/PrefabText/dumpedOtherText.txt` (the diagnostic-only dump
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
`Files/Mod/dumpedPrefabTextFromOtherFields.txt.yaml` and loaded alongside `dumpedPrefabText.txt.yaml`
via the `DictionaryFilePattern` multi-file glob. The extraction call moved from the `"1c."` fact to
`"1b."` in `Tests/FileInputWorkflowTests.cs` so it runs before `ExportPrefabTextAssetToCustomFormat`
packages whatever's on disk.

`TMP_Text.text`/`UI.Text.text` remain the only component fields patched directly — the two
"primary" fields `AssetDumperWorkflowTests.cs` dumps to `dumpedPrefabText.txt` (see
`IsPrimaryTextField`) — the fields above reach the same two setters at runtime regardless of which
data class they're read from, so no additional component-field coverage was needed to fix this.

## Design decision: why not `Awake`/`OnEnable`/`set_text` patches

A prefab's serialized field values come from native IL2CPP deserialization directly, bypassing C#
property setters/lifecycle callbacks for the initial baked-in value — those hooks may never fire
for the text already present on a freshly-loaded/instantiated prefab. Instead, `PrefabTextPatches`
Harmony-postfixes `Resources.Load(string, Il2CppSystem.Type)` and `AssetBundle.LoadAsset(string)`,
and if the result is a `GameObject`, manually walks its transform tree looking for
`TMP_Text`/`UI.Text` components to patch directly — mirroring both `AssetDumperWorkflowTests.cs`'s
offline scan and the old Mono-only `XUnity.ResourceRedirector`-based `TextReplacerPlugin`
(`G:\Xyzj2OverLlm\EnglishPatch\PrefabText\TextReplacerPlugin.cs` from a different game/repo) this
replaces — `XUnity.ResourceRedirector` itself doesn't support IL2CPP, hence the manual Harmony
patches here instead of that library's asset/resource-loaded hooks.

## Interop-safety finding: no `is`/`as` pattern matching against IL2CPP wrapper types either

The existing "no generic `Cast<T>()`/`TryCast<T>()`" rule extends to C#'s `is`/`as` operators when
used against Il2Cpp wrapper types — Il2CppInterop implements those operators via the same generic
`TryCast<T>()` machinery under the hood, so `component is TMP_Text` is just as unsafe as calling
`TryCast<TMP_Text>()` directly. `PrefabTextPatches` avoids this entirely by requesting components
by exact type up front instead of testing components after the fact:
`GameObject.GetComponents(Il2CppSystem.Type)` is Unity's own inheritance-aware native lookup, so
requesting `Il2CppType.From(typeof(TMP_Text))` (the **non-generic** `Il2CppType.From(System.Type)`
overload — not the generic `Il2CppType.Of<T>()`) already returns only `TMP_Text`-or-subclass
instances (e.g. `TextMeshProUGUI`), reconstructed via the confirmed-safe `(IntPtr)` pointer-wrap
constructor.

## Gap found by live testing: `Resources.Load`/`AssetBundle.LoadAsset` alone miss scene-embedded UI

A GameObject that's part of a scene file's own serialized contents (not a standalone prefab asset,
e.g. the Start/title screen) is instantiated directly by Unity's scene loader and never passes
through either load call, so the dictionary loaded fine but no on-screen text ever changed for
that screen.

**Fixed** by also patching
`[HarmonyPatch(typeof(UnityEngine.SceneManagement.SceneManager), "Internal_SceneLoaded")]` (a
private static method, patched by string name — confirmed non-ambiguous via reflection, only one
overload exists) and walking `scene.GetRootGameObjects()` with the same recursive tree-walk used
for the asset-load patches, once the scene has fully finished loading.

**If more untranslated text turns up later**: check whether it's genuinely scene-embedded vs. a
prefab loaded through some other call this doesn't cover yet (e.g. `AssetBundle.LoadAssetAsync`,
addressables) before assuming the dictionary itself is incomplete.
