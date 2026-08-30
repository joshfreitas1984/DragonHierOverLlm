using System;
using System.IO;
using System.Reflection;
using System.Text;
using HarmonyLib;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace EnglishPatch;

/// <summary>
/// Captures Unity engine log output (errors/warnings/exceptions/asserts) to our own file, since
/// BepInEx's built-in Unity log hook does not appear to fire in this build.
///
/// <see cref="Application.logMessageReceived"/> is NOT usable here — verified by reading the raw
/// metadata of BepInEx\interop\UnityEngine.CoreModule.dll directly (System.Reflection.Metadata,
/// no assembly load/execution) with a throwaway console app: UnityEngine.Application in this
/// stripped interop build exposes no logMessageReceived event, field, or add/remove method at
/// all — only the properties/methods actually referenced elsewhere get generated into the interop
/// stub. So instead we Harmony-patch every overload of <see cref="Debug"/>'s logging entry points
/// directly (confirmed present via the same metadata dump: Log, LogWarning, LogError,
/// LogException, LogAssertion, each with a message-only overload and a (message, context)
/// overload, plus *Format variants). Since virtually all engine- and game-originated log traffic
/// funnels through these Debug methods (the same ones ResourceIoPatches/MainPlugin already use for
/// our own logging), patching them directly catches the same messages
/// Application.logMessageReceived would have, without depending on an event that isn't actually
/// generated in this interop build.
///
/// IMPORTANT interop signature gotcha (found by patch registration failing with "Undefined target
/// method" / HarmonyX "Could not find method ... for type UnityEngine.Debug and name Log and
/// parameters (object)"): the metadata dump only prints short type names by default, which made
/// the message/context parameters look like ordinary System.Object. Re-running the same dump with
/// fully-qualified names showed the real parameter types are <c>Il2CppSystem.Object</c> (not
/// System.Object) for the message param, <c>Il2CppSystem.Exception</c> (not System.Exception) for
/// LogException, and <c>UnityEngine.Object</c> for the context param. HarmonyPatch's
/// `new[] { typeof(object) }` / `typeof(Exception)` therefore never matched any real overload —
/// always verify full parameter type names (namespace included), not just short names, when
/// reflecting over these interop DLLs.
///
/// Writes to BepInEx\plugins\unity-log.txt next to the plugin DLL, and mirrors only unhandled
/// exceptions (Debug.LogException) into BepInEx's own console log via MainPlugin.Logger — plain
/// Log/Warning/Error/Assertion calls are typically harmless/known engine chatter and would
/// otherwise spam the console, drowning out real problems; they are still recorded to
/// unity-log.txt for offline inspection. All work is wrapped in try/catch per the interop
/// safety rules in .github/instructions/dragonheirplugin.instructions.md — treat the IL2CPP host
/// as potentially unstable and never let a logging failure take down the game. Patch bodies are
/// concrete/non-generic per those same rules.
///
/// ANOTHER gotcha: calling Il2CppSystem.Object.ToString() directly on the message parameter does
/// NOT dispatch to the boxed value's real content — it returns the literal string
/// "Il2CppSystem.Object" (the C# wrapper type's own default Object.ToString(), i.e. its full type
/// name) instead of the actual native/boxed value's text, even though the vast majority of
/// Debug.Log(...) calls in practice pass a plain string. The fix is to check the message's real
/// IL2CPP class via IL2CPP.il2cpp_object_get_class + IL2CPP.il2cpp_class_get_namespace_ /
/// IL2CPP.il2cpp_class_get_name_ (all plain, non-generic static P/Invoke wrapper calls on
/// Il2CppInterop.Runtime.IL2CPP — not the confirmed-unsafe generic Cast&lt;T&gt;/TryCast&lt;T&gt;), and if
/// it's "System.String", read the actual text via IL2CPP.Il2CppStringToManaged on the same
/// pointer. See <see cref="FormatMessage"/> for the implementation.
/// </summary>
internal static class UnityLogCapture
{
    // Detailed hook, formatting, and interop rationale: docs/unitylogcapture-reference.md.
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string LogFile = Path.Combine(PluginDir, "unity-log.txt");
    private static readonly object WriteLock = new();

    public static void DeleteLogFile()
    {
        try
        {
            if (File.Exists(LogFile))
                File.Delete(LogFile);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"UnityLogCapture.DeleteLogFile failed: {ex}");
        }
    }

    private static void Write(string level, object message)
    {
        try
        {
            var text = message is Il2CppSystem.Exception il2cppEx
                ? FormatException(il2cppEx)
                : FormatMessage(message);
            lock (WriteLock)
            {
                var line = $"[{DateTime.Now:HH:mm:ss.fff}] [{level}] {text}";
                File.AppendAllText(LogFile, line + Environment.NewLine, new UTF8Encoding(false));
            }

            // Only mirror unhandled exceptions (Debug.LogException) to the BepInEx console — Unity
            // calls LogException specifically when an exception propagates out of a callback
            // uncaught by game code, which is exactly the "unhandled" signal we care about here.
            // Plain Log/Warning/Error/Assertion calls are extremely noisy (mostly harmless/known
            // engine chatter) and would otherwise drown out real problems in the console; they
            // still get written to unity-log.txt above for offline inspection.
            if (string.Equals(level, "Exception", StringComparison.OrdinalIgnoreCase))
            {
                MainPlugin.Logger?.LogError($"[UnityLog:{level}] {text}");
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"UnityLogCapture.Write failed: {ex}");
        }
    }

    /// <summary>
    /// Extracts a readable string from an Il2CppSystem.Object log message. See the class remarks
    /// for why plain ToString() doesn't work here: it returns the wrapper type's own name
    /// ("Il2CppSystem.Object") instead of the boxed value's real content. Instead, look up the
    /// object's actual IL2CPP class by pointer and, if it's really a boxed System.String, read the
    /// text via IL2CPP.Il2CppStringToManaged. Falls back to ToString() (and finally the class name)
    /// for any other boxed type, since most non-string log arguments do have a meaningful override.
    /// </summary>
    private static string FormatMessage(object message)
    {
        if (message is Il2CppSystem.Object il2cppObj)
        {
            var ptr = il2cppObj.Pointer;
            if (ptr == IntPtr.Zero) return "null";

            var klass = IL2CPP.il2cpp_object_get_class(ptr);
            if (klass != IntPtr.Zero)
            {
                var ns = IL2CPP.il2cpp_class_get_namespace_(klass);
                var name = IL2CPP.il2cpp_class_get_name_(klass);
                if (ns == "System" && name == "String")
                {
                    return IL2CPP.Il2CppStringToManaged(ptr) ?? "null";
                }
            }
        }

        return message?.ToString() ?? "null";
    }

    /// <summary>
    /// Builds a useful message+stacktrace string for an Il2Cpp exception wrapper. Calling
    /// <c>ToString()</c> directly on <see cref="Il2CppSystem.Exception"/> only returns the type
    /// name here (e.g. "Il2CppSystem.Exception") instead of the formatted .NET-style exception
    /// dump — the interop wrapper doesn't dispatch ToString() through the native vtable the way
    /// managed System.Exception.ToString() does. Reading .Message/.StackTrace/.InnerException are
    /// plain, safe, non-invoking-generic property reads (per the interop safety rules), so build
    /// the readable text from those directly instead of trusting ToString().
    /// </summary>
    private static string FormatException(Il2CppSystem.Exception ex)
    {
        var sb = new StringBuilder();
        var current = ex;
        while (current != null)
        {
            sb.Append(current.Message);
            if (!string.IsNullOrEmpty(current.StackTrace))
            {
                sb.Append(Environment.NewLine).Append(current.StackTrace);
            }
            current = current.InnerException;
            if (current != null)
            {
                sb.Append(Environment.NewLine).Append(" ---> ");
            }
        }
        return sb.ToString();
    }

    [HarmonyPatch(typeof(Debug), nameof(Debug.Log), new[] { typeof(Il2CppSystem.Object) })]
    [HarmonyPostfix]
    private static void Log_Postfix(Il2CppSystem.Object message) => Write("Log", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.Log), new[] { typeof(Il2CppSystem.Object), typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void LogWithContext_Postfix(Il2CppSystem.Object message) => Write("Log", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), new[] { typeof(Il2CppSystem.Object) })]
    [HarmonyPostfix]
    private static void LogWarning_Postfix(Il2CppSystem.Object message) => Write("Warning", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogWarning), new[] { typeof(Il2CppSystem.Object), typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void LogWarningWithContext_Postfix(Il2CppSystem.Object message) => Write("Warning", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogError), new[] { typeof(Il2CppSystem.Object) })]
    [HarmonyPostfix]
    private static void LogError_Postfix(Il2CppSystem.Object message) => Write("Error", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogError), new[] { typeof(Il2CppSystem.Object), typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void LogErrorWithContext_Postfix(Il2CppSystem.Object message) => Write("Error", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogException), new[] { typeof(Il2CppSystem.Exception) })]
    [HarmonyPostfix]
    private static void LogException_Postfix(Il2CppSystem.Exception exception) => Write("Exception", exception);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogException), new[] { typeof(Il2CppSystem.Exception), typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void LogExceptionWithContext_Postfix(Il2CppSystem.Exception exception) => Write("Exception", exception);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogAssertion), new[] { typeof(Il2CppSystem.Object) })]
    [HarmonyPostfix]
    private static void LogAssertion_Postfix(Il2CppSystem.Object message) => Write("Assertion", message);

    [HarmonyPatch(typeof(Debug), nameof(Debug.LogAssertion), new[] { typeof(Il2CppSystem.Object), typeof(UnityEngine.Object) })]
    [HarmonyPostfix]
    private static void LogAssertionWithContext_Postfix(Il2CppSystem.Object message) => Write("Assertion", message);
}
