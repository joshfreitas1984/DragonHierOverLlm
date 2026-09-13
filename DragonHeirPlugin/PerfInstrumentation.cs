using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace EnglishPatch;

// General-purpose perf diagnostic, gated OFF by default (MainPlugin.PerfInstrumentationEnabled,
// "Debug" config section) - built to investigate the HeroDetailPanel slow-open report (see
// DragonHeirPlugin/docs/herodetailpanel-slow-load-investigation.md for that investigation and its
// outcome), kept in the codebase for the next performance report rather than a one-off throwaway.
// Times the two patch pipelines that turned out to matter - DynamicStringPatches' per-text-setter
// translation pipeline and PrefabTextPatches' per-instantiation GameObject tree walk - and
// periodically dumps aggregated counts/durations to perfStats.log next to the plugin DLL, plus
// logs any single call slow enough to be individually noticeable. Not scoped to any specific
// panel - reads as a burst in the timeline (count/total spike over a ~2s window) when a
// text/prefab-heavy panel opens, against a near-zero idle baseline. To reuse: flip
// PerfInstrumentationEnabled on in the BepInEx config, reproduce, then read perfStats.log.
//
// Ticked from PlotTextSizePatches.OnDeltaTimeRead_Postfix's existing per-frame hook rather than
// adding a new one - BasePlugin has no real Update() and AddComponent<T>/ClassInjector crash under
// this game's IL2CPP build (see that file for the full rationale), and Time.deltaTime's getter is
// already the one safe once-per-frame tick this plugin uses.
internal static class PerfInstrumentation
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string LogFile = Path.Combine(PluginDir, "perfStats.log");
    private static readonly object WriteLock = new();
    private static StreamWriter _writer;

    // Any single call slower than this is logged immediately (with a sample label so it can be
    // traced back to the responsible component/GameObject), in addition to the periodic aggregate.
    private const double SlowCallMillisecondsThreshold = 2.0;

    // ~2 seconds between periodic aggregate dumps - frequent enough to catch a single panel-open
    // spike as its own block in the log, without spamming it every frame.
    private static readonly long DumpIntervalTicks = TimeSpan.FromSeconds(2).Ticks;
    private static long _lastDumpTicks;

    private sealed class Bucket
    {
        public long Count;
        public long TotalStopwatchTicks;
        public long MaxStopwatchTicks;
        public string MaxSample;
    }

    // NOT readonly - PeriodicTick swaps this reference out for a fresh dictionary under lock
    // rather than enumerating-then-Clear()-ing the live one in place. See PeriodicTick's comment.
    private static Dictionary<string, Bucket> _buckets = new();

    // Detects PeriodicTick being re-entered on the SAME thread (see that method's comment) - a
    // real, confirmed-live "Collection was modified" crash was reported from this exact call path
    // (Time.deltaTime's getter -> PeriodicTick), and the swap-based drain below eliminates the
    // crash regardless of mechanism, but this flag additionally lets us CONFIRM whether same-
    // thread reentrancy is actually occurring (a warning in the log) rather than guessing.
    [ThreadStatic] private static bool _tickReentered;

    // Wrap a measured block with `using (PerfInstrumentation.Measure("Bucket", () => label))`.
    // `sampleDescription` is only invoked when the call becomes the new slowest seen for its
    // bucket, or crosses SlowCallMillisecondsThreshold - cheap for the overwhelmingly common case
    // of a fast call that is neither.
    public readonly struct Scope : IDisposable
    {
        private readonly string _bucket;
        private readonly long _start;
        private readonly Func<string> _sampleDescription;

        public Scope(string bucket, Func<string> sampleDescription)
        {
            _bucket = bucket;
            _sampleDescription = sampleDescription;
            _start = Stopwatch.GetTimestamp();
        }

        public void Dispose() => Record(_bucket, Stopwatch.GetTimestamp() - _start, _sampleDescription);
    }

    public static Scope Measure(string bucket, Func<string> sampleDescription = null) => new(bucket, sampleDescription);

    private static void Record(string bucket, long elapsedStopwatchTicks, Func<string> sampleDescription)
    {
        if (!MainPlugin.PerfInstrumentationEnabledCached) return;

        var ms = elapsedStopwatchTicks * 1000.0 / Stopwatch.Frequency;

        // `sampleDescription` is a caller-supplied delegate that can do arbitrary work (e.g.
        // HandleTextSetter's sample walks a live Unity transform hierarchy via GetComponentPath) -
        // never invoke it while holding WriteLock. Running arbitrary code under a shared lock is
        // exactly the kind of thing that can trigger unexpected reentrancy into this same class
        // (see PeriodicTick's _tickReentered guard/comment for the crash this can cause), so the
        // lock below only ever touches the dictionary/Bucket bookkeeping, never a delegate.
        var isNewMax = false;
        Bucket b;
        lock (WriteLock)
        {
            if (!_buckets.TryGetValue(bucket, out b))
            {
                b = new Bucket();
                _buckets[bucket] = b;
            }

            b.Count++;
            b.TotalStopwatchTicks += elapsedStopwatchTicks;
            if (elapsedStopwatchTicks > b.MaxStopwatchTicks)
            {
                b.MaxStopwatchTicks = elapsedStopwatchTicks;
                isNewMax = true;
            }
        }

        // Invoked outside the lock (see above). Benign, rare race if two threads both set a new
        // max for the same bucket concurrently (whichever MaxSample write lands last wins) - an
        // acceptable trade-off for a best-effort diagnostic string, versus the alternative of
        // running arbitrary caller code under a shared lock.
        if (isNewMax)
            b.MaxSample = sampleDescription?.Invoke();

        if (ms >= SlowCallMillisecondsThreshold)
            AppendLine($"[SLOW] {bucket}: {ms:F2}ms - {sampleDescription?.Invoke() ?? "(no sample)"}", flushNow: true);
    }

    // Called once per frame (already de-duplicated by the caller) from PlotTextSizePatches'
    // Time.deltaTime tick. Dumps and resets whichever buckets saw activity since the last dump, so
    // perfStats.log reads as a timeline of bursts rather than one giant running total.
    //
    // 2026-09 crash report: "System.InvalidOperationException: Collection was modified" from this
    // method's foreach, reported live even after confirming Record/PeriodicTick both only ever
    // touched _buckets under WriteLock. The likely mechanism: Time.deltaTime's getter (which every
    // read of it anywhere in the game re-enters THIS method through, via PlotTextSizePatches'
    // postfix) got invoked again on the SAME thread while already inside this method's own
    // enumeration - Monitor's reentrant locking would let a nested call straight back into the
    // `lock (WriteLock)` below (same thread re-acquiring its own lock never blocks), so a nested
    // call could run its own foreach+Clear() concurrently with the outer one's still-active
    // enumerator. This is not confirmed with certainty (the exact trigger for a nested
    // Time.deltaTime read was not pinned down), so rather than guess further: the swap-based drain
    // below (detach `_buckets` into a private, orphaned `snapshot` reference before enumerating,
    // so nothing else can ever reach the object being iterated) eliminates the crash regardless of
    // mechanism, and _tickReentered logs a warning if same-thread reentrancy is in fact occurring -
    // giving real confirmation from the next report instead of another guess.
    public static void PeriodicTick()
    {
        if (!MainPlugin.PerfInstrumentationEnabledCached) return;

        var now = DateTime.UtcNow.Ticks;
        if (now - _lastDumpTicks < DumpIntervalTicks) return;
        _lastDumpTicks = now;

        if (_tickReentered)
        {
            MainPlugin.Logger?.LogWarning(
                "[PerfInstrumentation] PeriodicTick re-entered on the same thread - skipping nested call. " +
                "This confirms the same-thread-reentrancy theory behind the 'Collection was modified' crash report.");
            return;
        }

        _tickReentered = true;
        try
        {
            Dictionary<string, Bucket> snapshot;
            lock (WriteLock)
            {
                if (_buckets.Count == 0) return;
                snapshot = _buckets;
                _buckets = new Dictionary<string, Bucket>();
            }

            var lines = new List<string>();
            foreach (var kvp in snapshot)
            {
                var b = kvp.Value;
                if (b.Count == 0) continue;
                var totalMs = b.TotalStopwatchTicks * 1000.0 / Stopwatch.Frequency;
                var maxMs = b.MaxStopwatchTicks * 1000.0 / Stopwatch.Frequency;
                lines.Add(
                    $"{kvp.Key}: count={b.Count} total={totalMs:F2}ms avg={(totalMs / b.Count):F3}ms max={maxMs:F2}ms" +
                    (b.MaxSample != null ? $" (slowest: {b.MaxSample})" : ""));
            }

            if (lines.Count == 0) return;
            AppendLine($"--- {DateTime.Now:HH:mm:ss.fff} ---", flushNow: true);
            foreach (var line in lines) AppendLine(line, flushNow: false);
            FlushWriter();
        }
        finally
        {
            _tickReentered = false;
        }
    }

    private static StreamWriter GetWriter()
    {
        if (_writer != null) return _writer;
        _writer = new StreamWriter(new FileStream(LogFile, FileMode.Append, FileAccess.Write, FileShare.Read), new UTF8Encoding(false))
        {
            AutoFlush = false
        };
        return _writer;
    }

    private static void AppendLine(string line, bool flushNow)
    {
        try
        {
            lock (WriteLock)
            {
                var writer = GetWriter();
                writer.WriteLine(line);
                if (flushNow) writer.Flush();
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PerfInstrumentation: failed writing perfStats.log: {ex}");
        }
    }

    private static void FlushWriter()
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
            MainPlugin.Logger?.LogError($"PerfInstrumentation: flush failed: {ex}");
        }
    }

    public static void ClearLog()
    {
        try
        {
            lock (WriteLock)
            {
                _writer?.Dispose();
                _writer = null;
                if (File.Exists(LogFile)) File.Delete(LogFile);
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PerfInstrumentation: ClearLog failed: {ex}");
        }
    }
}
