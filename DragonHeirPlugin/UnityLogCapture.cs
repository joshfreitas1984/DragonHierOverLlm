using System;
using System.IO;
using System.Reflection;
using System.Text;
using HarmonyLib;
using Il2CppInterop.Runtime;
using UnityEngine;

namespace EnglishPatch;

/// <summary>
/// Captures Unity Debug output to a file and mirrors exceptions to the BepInEx console.
/// Detailed hook, formatting, and interop rationale: docs/unitylogcapture-reference.md.
/// </summary>
internal static class UnityLogCapture
{
    // Detailed hook, formatting, and interop rationale: docs/unitylogcapture-reference.md.
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string LogFile = Path.Combine(PluginDir, "unity-log.txt");
    private static readonly object WriteLock = new();

    // Kept open for the plugin's lifetime instead of opening/closing the file on every single
    // Debug.Log* call (this hook fires for ALL Unity engine logging, which can be many times per
    // frame). AutoFlush is off - a flushed disk write on every single log line is unnecessary I/O
    // cost for ordinary chatter, so writes are instead flushed periodically (see FlushIntervalTicks)
    // and immediately/unconditionally for "Exception" level, which is the case crash-safety
    // actually cares about. Also flushed explicitly on DeleteLogFile/shutdown.
    private static StreamWriter _writer;

    // ~1 second between periodic flushes of ordinary (non-exception) log lines.
    private static readonly long FlushIntervalTicks = TimeSpan.FromSeconds(1).Ticks;
    private static long _lastFlushTicks;

    private static StreamWriter GetWriter()
    {
        if (_writer != null)
            return _writer;

        _writer = new StreamWriter(new FileStream(LogFile, FileMode.Append, FileAccess.Write, FileShare.Read), new UTF8Encoding(false))
        {
            AutoFlush = false
        };
        return _writer;
    }

    public static void DeleteLogFile()
    {
        try
        {
            _writer?.Dispose();
            _writer = null;
            if (File.Exists(LogFile))
                File.Delete(LogFile);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"UnityLogCapture.DeleteLogFile failed: {ex}");
        }
    }

    // Called from MainPlugin.OnDestroy so the tail of the log isn't stuck unflushed in the buffer
    // on a clean shutdown - a hard crash still relies on the periodic/exception flushes below.
    public static void FlushLogFile()
    {
        try
        {
            lock (WriteLock)
            {
                _writer?.Flush();
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"UnityLogCapture.FlushLogFile failed: {ex}");
        }
    }

    private static void Write(string level, object message)
    {
        try
        {
            var text = message is Il2CppSystem.Exception il2cppEx
                ? FormatException(il2cppEx)
                : FormatMessage(message);
            var isException = string.Equals(level, "Exception", StringComparison.OrdinalIgnoreCase);
            lock (WriteLock)
            {
                var line = $"[{DateTime.Now:HH:mm:ss.fff}] [{level}] {text}";
                var writer = GetWriter();
                writer.WriteLine(line);

                var now = DateTime.UtcNow.Ticks;
                if (isException || now - _lastFlushTicks >= FlushIntervalTicks)
                {
                    writer.Flush();
                    _lastFlushTicks = now;
                }
            }

            // Keep ordinary Unity chatter in the file; mirror exception signals to the console.
            if (isException)
            {
                MainPlugin.Logger?.LogError($"[UnityLog:{level}] {text}");
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"UnityLogCapture.Write failed: {ex}");
        }
    }

    /// <summary>Extracts readable text from an IL2CPP log message.</summary>
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

    /// <summary>Builds readable exception text from its message, stack, and inner exceptions.</summary>
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
