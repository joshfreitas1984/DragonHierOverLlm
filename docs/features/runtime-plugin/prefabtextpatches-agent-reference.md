# PrefabTextPatches agent reference

Read this before changing `PrefabTextPatches.cs`. The source keeps only short pointers; historical investigations are indexed in `docs/KNOWN_ISSUES.md`.

## Purpose and data

This patch translates whole strings known from prefab and other-field dumps. It loads every `dumpedPrefabText*.txt.yaml` recursively under the plugin `resources` directory and merges entries into `Replacements`. The primary file contains TMP/UI `text`; the `FromOtherFields` file contains allowlisted complete values such as `plotText`, `describe`, `tutorialText`, `eventDescribe`, `startRemindText`, `choiceText`, and `name`. These values do not have CSV sources and must remain exact-match replacements rather than DynamicStringPatches-style fragments.

## Hooks and ordering

`ResourcesLoad_Postfix` handles standalone GameObjects returned from `Resources.Load`. `AssetBundleLoadAssetPatch` resolves the non-generic `AssetBundle.LoadAsset(string)` overload explicitly because the generic overload makes name-and-parameter lookup ambiguous. `SceneLoaded_Postfix` walks scene roots because scene-embedded objects bypass both asset-load hooks.

`ProcessGameObjectTree` scans TMP, UI and NGUI `UILabel` text components using non-generic `Il2CppType.From`, `GameObject.GetComponentsInChildren(Il2CppSystem.Type, includeInactive: true)` and `(IntPtr)` wrapper constructors. That is one native call per text type for the whole tree, covering the root and inactive descendants. The old per-node recursion made three `GetComponents` calls plus transform/child interop calls for every GameObject. `IsGameObject` queries the native IL2CPP class for AssetBundle results instead of casting.

Text assigned after load is handled by `DynamicStringPatches.HandleTextSetter` (the `ref string value` setter prefixes; see the DynamicStringPatches reference). It calls `TryApplyExactMatch` first, so an exact whole-string replacement still wins over the broader fragment pipeline. `TryApplyExactMatch` is a pure lookup; a value that does not exactly match falls through unchanged.

## Matching and newline rules

`ApplyExactMatchToComponentText` and `ReplaceIfKnown` perform exact whole-string lookups only. They normalize live newlines to the dump convention before lookup and denormalize translated results before assignment. Dumped values use literal `\\n`; live TMP/UI text uses real newline characters. Do not normalize the runtime dictionary globally or replace these lookups with substring matching.

## Interop and failure behavior

Do not add generic `Cast<T>`, `TryCast<T>`, `AddComponent<T>`, `GetComponentsInChildren<T>`, or `FindObjectsOfType<T>` calls (the non-generic `GetComponentsInChildren(Il2CppSystem.Type, bool)` overload is fine), and do not use C# `is`/`as` against IL2CPP wrapper types. Use non-generic type lookup and pointer-wrap constructors. Every load hook and tree-walk step should remain best-effort: catch failures, log when safe, and leave original text untouched.

## Change checklist

1. Keep recursive dictionary discovery and CamelCase YAML deserialization.
2. Preserve exact-match semantics and newline normalization boundaries.
3. Keep the scene-load hook in addition to Resources and AssetBundle hooks.
4. Preserve exact-match-before-fragment ordering inside `DynamicStringPatches.HandleTextSetter` and keep `TryApplyExactMatch` side-effect free.
5. Verify IL2CPP signatures against the real interop assemblies before adding hooks.
6. Read `prefabtextpatches-full-investigation.md` and `prefabtext-multiline-and-token-placeholder-bugs.md` before changing matching or lifecycle behavior.
