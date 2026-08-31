# UnityLogCapture agent reference

Read this before changing `UnityLogCapture.cs`. The source keeps only short pointers; the metadata investigation is in `unitylogcapture-no-logmessagereceived.md` and is indexed by `DragonHeirPlugin/KNOWN_ISSUES.md`.

## Hook contract

`UnityEngine.Application.logMessageReceived` is absent from this stripped interop build. Do not add an event subscription. `UnityLogCapture` instead Harmony-postfixes the non-Format overloads of `Debug.Log`, `LogWarning`, `LogError`, `LogException`, and `LogAssertion`, including their context overloads. The patches are registered through the class-level Harmony scan in `MainPlugin.Load`.

Use the exact interop parameter types in patch attributes: `Il2CppSystem.Object` for ordinary messages, `Il2CppSystem.Exception` for exceptions, and `UnityEngine.Object` for context. Short type names in metadata are misleading; verify namespaces against the real interop DLL when adding or changing overloads.

## Message formatting

`Write` appends timestamped entries to `unity-log.txt`. Only `Debug.LogException` output is mirrored to the BepInEx console; ordinary log, warning, error, and assertion traffic remains file-only to avoid console noise. Keep the entire path best-effort and wrapped in exception handling.

`FormatMessage` must not rely on `Il2CppSystem.Object.ToString()`, which returns the wrapper type name rather than boxed string content. Inspect the native class from the object pointer and use `IL2CPP.Il2CppStringToManaged` for `System.String`; use the ordinary fallback only for other boxed values. `FormatException` reads `Message`, `StackTrace`, and `InnerException` directly instead of calling the wrapper `ToString()`.

## Interop and safety

Keep patch methods concrete and non-generic. Use non-generic IL2CPP class and string helpers. Logging failures must never take down the game, and any diagnostic logging added around patched methods must account for re-entrancy through the logging/string APIs.

## Change checklist

1. Confirm the target overload's fully qualified parameter types before changing attributes.
2. Keep `Application.logMessageReceived` out of this implementation unless the interop metadata changes.
3. Preserve file logging for all levels and console mirroring for exceptions only.
4. Preserve native class inspection for boxed messages and property reads for exceptions.
5. Read `unitylogcapture-no-logmessagereceived.md` before changing hook coverage or interop assumptions.
