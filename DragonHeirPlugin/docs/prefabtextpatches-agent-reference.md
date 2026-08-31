# PrefabTextPatches agent reference

Read this before changing `PrefabTextPatches.cs`. The source keeps only short pointers; historical investigations are indexed in `DragonHeirPlugin/KNOWN_ISSUES.md`.

## Purpose and data

This patch translates whole strings known from prefab and other-field dumps. It loads every `dumpedPrefabText*.txt.yaml` recursively under the plugin `resources` directory and merges entries into `Replacements`. The primary file contains TMP/UI `text`; the `FromOtherFields` file contains allowlisted complete values such as `plotText`, `describe`, `tutorialText`, `eventDescribe`, `startRemindText`, `choiceText`, and `name`. These values do not have CSV sources and must remain exact-match replacements rather than DynamicStringPatches-style fragments.

## Hooks and ordering

`ResourcesLoad_Postfix` handles standalone GameObjects returned from `Resources.Load`. `AssetBundleLoadAssetPatch` resolves the non-generic `AssetBundle.LoadAsset(string)` overload explicitly because the generic overload makes name-and-parameter lookup ambiguous. `SceneLoaded_Postfix` walks scene roots because scene-embedded objects bypass both asset-load hooks.

`ProcessGameObjectRecursive` scans TMP and UI text components using non-generic `Il2CppType.From`, `GetComponents(Il2CppSystem.Type)`, and `(IntPtr)` wrapper constructors. It then recurses through children. `IsGameObject` queries the native IL2CPP class for AssetBundle results instead of casting.

The TMP/UI setter postfixes catch text assigned after load. They use `[HarmonyPriority(Priority.First)]` so an exact whole-string replacement runs before DynamicStringPatches' broader fragment postfixes. A value that does not exactly match remains untouched and can fall through to DynamicStringPatches. `_inTextSetterPostfix` prevents the replacement write from re-entering this postfix.

## Matching and newline rules

`ApplyExactMatchToComponentText` and `ReplaceIfKnown` perform exact whole-string lookups only. They normalize live newlines to the dump convention before lookup and denormalize translated results before assignment. Dumped values use literal `\\n`; live TMP/UI text uses real newline characters. Do not normalize the runtime dictionary globally or replace these lookups with substring matching.

## Interop and failure behavior

Do not add generic `Cast<T>`, `TryCast<T>`, `AddComponent<T>`, `GetComponentsInChildren<T>`, or `FindObjectsOfType<T>` calls, and do not use C# `is`/`as` against IL2CPP wrapper types. Use non-generic type lookup and pointer-wrap constructors. Every load hook and tree-walk step should remain best-effort: catch failures, log when safe, and leave original text untouched.

## Change checklist

1. Keep recursive dictionary discovery and CamelCase YAML deserialization.
2. Preserve exact-match semantics and newline normalization boundaries.
3. Keep the scene-load hook in addition to Resources and AssetBundle hooks.
4. Preserve `Priority.First` relative to DynamicStringPatches and the setter re-entrancy guard.
5. Verify IL2CPP signatures against the real interop assemblies before adding hooks.
6. Read `prefabtextpatches-full-investigation.md` and `prefabtext-multiline-and-token-placeholder-bugs.md` before changing matching or lifecycle behavior.
