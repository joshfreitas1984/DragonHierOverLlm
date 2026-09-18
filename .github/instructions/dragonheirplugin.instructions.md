---
applyTo: "DragonHeirPlugin/**"
---

# DragonHeirPlugin Instructions

This is a single-game BepInEx Unity IL2CPP plugin compiled directly against the deployed game's
real assemblies in `BepInEx\interop\`. Keep this file focused on interop safety and runtime
invariants. Detailed feature references and investigations live under the root `docs/` tree and
are indexed by [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md).

## Interop safety

- Verify namespaces, constructors, properties, fields, method signatures, and Harmony parameter
  names against the deployed interop DLLs. Do not trust dummy assemblies or decompiler pseudocode.
- Do not use generic IL2CPP interop calls such as `Cast<T>()`, `TryCast<T>()`, `AddComponent<T>()`,
  or generic helpers around IL2CPP objects. Prefer concrete methods and non-generic pointer/string
  conversions.
- Do not use `is`/`as` pattern matching on components returned from `GetComponents<Component>()`
  in this game. Use a direct typed lookup or inspect the native class explicitly.
- Wrap interop-touching code in fail-safe exception handling; leave original values unchanged when
  a runtime lookup fails.
- Register every Harmony patch class explicitly from `MainPlugin.Load()`, and verify both that the
  target was bound and that the patch executes at runtime.
- Keep `UnityEngine.Object` and `Il2CppSystem.Object` types distinct in signatures and patch
  attributes.

For the concrete raw-pointer, TextAsset, Unity logging, and prefab patterns, read the relevant
references under [`docs/features/runtime-plugin/`](../../docs/features/runtime-plugin/).

## Runtime invariants

- `ResourceIoPatches` must read `TextAsset` bytes through its raw native helper, never the generic
  `TextAsset.bytes` wrapper.
- Packaged CSV resources are complete file replacements, not row-level merges. Preserve all rows,
  including raw fallback rows, in the generated drop-in file.
- Never translate at a source method when the value is persisted in save state. Source translation
  is only safe for genuinely transient buffers.
- Preserve recursive resource-file lookup and exact whole-string replacement behavior for prefab
  text and dynamic-string dictionaries.
- Keep template regex timeouts and the `[ThreadStatic]` re-entrancy guard around String.Format /
  String.Concat patches.
- New external NuGet dependencies require the existing copy-local override and Costura embedding;
  verify the dependency is actually embedded before deploying.

## Before shipping a patch

1. Build against the real interop references.
2. Confirm Harmony binding and first execution in the game log.
3. Check the matching feature reference and investigation in the root docs.
4. Keep game-specific extraction/configuration changes in `Translate/` or `Tests/`, not in the
   runtime plugin, unless the behavior truly belongs at runtime.
