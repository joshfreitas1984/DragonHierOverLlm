# `UnityLogCapture` — why `Application.logMessageReceived` couldn't be used

BepInEx's built-in Unity log redirection did not fire for this game/build. The obvious fix,
`UnityEngine.Application.logMessageReceived`, **does not exist** in this game's stripped interop
build — verified by reading `BepInEx\interop\UnityEngine.CoreModule.dll`'s raw metadata directly
(`System.Reflection.Metadata`/`PEReader`, no assembly load or execution — regular
`Assembly.LoadFile`/`AssemblyLoadContext` reflection over these interop DLLs throws
`ReflectionTypeLoadException`/returns null `GetType` results outside the actual game process,
because IL2CPP interop stub assemblies have interdependencies that only resolve inside the running
game host). `UnityEngine.Application`'s type definition has **no** `logMessageReceived` event,
backing field, or add/remove method at all in this build — Il2CppInterop only generates members
that are actually referenced/used. Do not waste time trying to subscribe to it here; it will fail
to even compile (`CS0117`).

What *is* present and safe to use (confirmed via the same metadata dump): `UnityEngine.Debug`'s
`Log`, `LogWarning`, `LogError`, `LogException`, `LogAssertion`, each with a plain-`object`
overload and an `(object, UnityEngine.Object context)` overload, plus `*Format` variants. Since
virtually all engine- and game-originated log traffic funnels through these same `Debug` methods,
`UnityLogCapture.cs` Harmony-postfix-patches all of the non-Format overloads and writes every
message to `BepInEx\plugins\unity-log.txt`, plus mirrors errors/warnings/exceptions/asserts into
`MainPlugin.Logger`. Registered in `MainPlugin.Load()` via
`Harmony.CreateAndPatchAll(typeof(UnityLogCapture))` — no separate `Install()`/event-subscription
step needed since it's pure Harmony patching.

If a future Unity/BepInEx interop build *does* expose `logMessageReceived`, re-check with the same
metadata-dump technique before wiring it up — relying on compile-time IntelliSense/decompiled
signatures from a different game's interop build can be misleading.
