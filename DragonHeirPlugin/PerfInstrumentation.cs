using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Text;

namespace EnglishPatch;

// Temporary diagnostic tool for investigating reports that HeroDetailPanel is slow to open.
// Times the two patch pipelines suspected of being the bottleneck - DynamicStringPatches' per-
// text-setter translation pipeline and PrefabTextPatches' per-instantiation GameObject tree walk
// - and periodically dumps aggregated counts/durations to perfStats.log next to the plugin DLL,
// plus logs any single call slow enough to be individually noticeable. Not scoped to any specific
// panel - reads as a burst in the timeline (count/total spike over a ~2s window) when a
// text/prefab-heavy panel like HeroDetailPanel opens, against a near-zero idle baseline.
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

    private static readonly Dictionary<string, Bucket> _buckets = new();

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

        lock (WriteLock)
        {
            if (!_buckets.TryGetValue(bucket, out var b))
            {
                b = new Bucket();
                _buckets[bucket] = b;
            }

            b.Count++;
            b.TotalStopwatchTicks += elapsedStopwatchTicks;
            if (elapsedStopwatchTicks > b.MaxStopwatchTicks)
            {
                b.MaxStopwatchTicks = elapsedStopwatchTicks;
                b.MaxSample = sampleDescription?.Invoke();
            }
        }

        if (ms >= SlowCallMillisecondsThreshold)
            AppendLine($"[SLOW] {bucket}: {ms:F2}ms - {sampleDescription?.Invoke() ?? "(no sample)"}", flushNow: true);
    }

    // Called once per frame (already de-duplicated by the caller) from PlotTextSizePatches'
    // Time.deltaTime tick. Dumps and resets whichever buckets saw activity since the last dump, so
    // perfStats.log reads as a timeline of bursts rather than one giant running total.
    public static void PeriodicTick()
    {
        if (!MainPlugin.PerfInstrumentationEnabledCached) return;

        var now = DateTime.UtcNow.Ticks;
        if (now - _lastDumpTicks < DumpIntervalTicks) return;
        _lastDumpTicks = now;

        List<string> lines;
        lock (WriteLock)
        {
            if (_buckets.Count == 0) return;
            lines = new List<string>();
            foreach (var kvp in _buckets)
            {
                var b = kvp.Value;
                if (b.Count == 0) continue;
                var totalMs = b.TotalStopwatchTicks * 1000.0 / Stopwatch.Frequency;
                var maxMs = b.MaxStopwatchTicks * 1000.0 / Stopwatch.Frequency;
                lines.Add(
                    $"{kvp.Key}: count={b.Count} total={totalMs:F2}ms avg={(totalMs / b.Count):F3}ms max={maxMs:F2}ms" +
                    (b.MaxSample != null ? $" (slowest: {b.MaxSample})" : ""));
            }
            _buckets.Clear();
        }

        if (lines.Count == 0) return;
        AppendLine($"--- {DateTime.Now:HH:mm:ss.fff} ---", flushNow: true);
        foreach (var line in lines) AppendLine(line, flushNow: false);
        FlushWriter();
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
