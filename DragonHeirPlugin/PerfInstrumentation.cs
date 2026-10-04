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
    // A default (bucket == null) Scope is a no-op - returned by Measure while instrumentation is off,
    // so a disabled measurement costs neither Stopwatch timestamps nor a Record call.
    public readonly struct Scope : IDisposable
    {
        private readonly string _bucket;
        private readonly long _start;
        private readonly Func<string> _sampleDescription;

        public Scope(string bucket, Func<string> sampleDescription)
        {
            _bucket = bucket;
            _sampleDescription = sampleDescription;
            EnterScope();
            _start = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            if (_bucket == null) return;
            var elapsed = Stopwatch.GetTimestamp() - _start;
            ExitScope(_bucket, elapsed);
            Record(_bucket, elapsed, _sampleDescription);
        }
    }

    // --- Thread attribution + per-frame main-thread accounting ---
    //
    // Buckets used to mix main-thread and background work (RecordLogPrewarmPatches runs the same
    // pipeline on a Task), so a 2s window's total couldn't say how much of it actually stalled a
    // frame. Background calls are now recorded under "<bucket>[bg]"; main-thread ones keep the
    // plain name. And the OUTERMOST measured scope on the main thread is also summed per frame
    // (nested scopes, e.g. RunGenericPipeline inside HandleTextSetter, are not double-counted) and
    // logged as a [FRAME] line when a single frame's plugin work crosses FrameLogThresholdMs.
    private const double FrameLogThresholdMs = 8.0;
    private static int _mainThreadId = -1;
    [ThreadStatic] private static int _scopeDepth;
    private static long _frameTicks;
    private static readonly Dictionary<string, long> _frameBuckets = new();

    // Called from MainPlugin.Load, which runs on the game's main thread.
    public static void MarkMainThread() => _mainThreadId = Environment.CurrentManagedThreadId;

    private static bool IsMainThread => Environment.CurrentManagedThreadId == _mainThreadId;

    private static void EnterScope() => _scopeDepth++;

    private static void ExitScope(string bucket, long elapsedTicks)
    {
        // Clamp: a scope whose End never ran (original threw) must not wedge the depth above zero.
        if (_scopeDepth > 0) _scopeDepth--;
        if (_scopeDepth != 0 || !IsMainThread) return;
        _frameTicks += elapsedTicks;
        _frameBuckets.TryGetValue(bucket, out var prior);
        _frameBuckets[bucket] = prior + elapsedTicks;
    }

    // State-passing variant for hot paths (per text set, per template attempt): with a `static`
    // lambda the call site captures nothing, so it allocates no closure on every call while
    // instrumentation is off. The closure binding state to the delegate is only created on Dispose
    // of an enabled scope.
    public readonly struct Scope<TState> : IDisposable
    {
        private readonly string _bucket;
        private readonly long _start;
        private readonly TState _state;
        private readonly Func<TState, string> _sampleDescription;

        public Scope(string bucket, TState state, Func<TState, string> sampleDescription)
        {
            _bucket = bucket;
            _state = state;
            _sampleDescription = sampleDescription;
            EnterScope();
            _start = Stopwatch.GetTimestamp();
        }

        public void Dispose()
        {
            if (_bucket == null) return;
            var elapsed = Stopwatch.GetTimestamp() - _start;
            ExitScope(_bucket, elapsed);
            var state = _state;
            var describe = _sampleDescription;
            Record(_bucket, elapsed, describe == null ? null : () => describe(state));
        }
    }

    public static Scope Measure(string bucket, Func<string> sampleDescription = null) =>
        MainPlugin.PerfInstrumentationEnabledCached ? new(bucket, sampleDescription) : default;

    public static Scope<TState> Measure<TState>(string bucket, TState state, Func<TState, string> sampleDescription) =>
        MainPlugin.PerfInstrumentationEnabledCached ? new(bucket, state, sampleDescription) : default;

    // Distinct managed caller stacks seen per bucket - see SampleCallerStack.
    private static readonly Dictionary<string, HashSet<string>> _sampledStacks = new();
    private const int MaxSampledStacksPerBucket = 25;

    // Logs each DISTINCT managed call stack reaching `bucket` (up to MaxSampledStacksPerBucket) to
    // perfStats.log. Built to answer whether DynamicStringPatches.GenericPostfix (a Harmony patch on
    // CoreCLR's System.String.Concat/Format, not IL2CPP's) is ever reached from native game code -
    // such a call would show Il2CppInterop trampoline frames - or only from managed callers (this
    // plugin, BepInEx, YamlDotNet). Only called while instrumentation is on.
    public static void SampleCallerStack(string bucket)
    {
        if (!MainPlugin.PerfInstrumentationEnabledCached) return;

        var previousGuard = DynamicStringPatches._inFormatConcatPatch;
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            var stack = new StackTrace(2, false).ToString();
            lock (WriteLock)
            {
                if (!_sampledStacks.TryGetValue(bucket, out var seen))
                    _sampledStacks[bucket] = seen = new HashSet<string>();
                if (seen.Count >= MaxSampledStacksPerBucket || !seen.Add(stack)) return;
            }
            AppendLine($"[STACK] {bucket} caller #{_sampledStacks[bucket].Count}:{Environment.NewLine}{stack}", flushNow: true);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"PerfInstrumentation: SampleCallerStack failed: {ex}");
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = previousGuard;
        }
    }

    private static void Record(string bucket, long elapsedStopwatchTicks, Func<string> sampleDescription)
    {
        if (!MainPlugin.PerfInstrumentationEnabledCached) return;

        // Sample delegates build strings (truncation/concatenation) that would otherwise re-enter
        // DynamicStringPatches.GenericPostfix through the patched String.Concat and get run
        // through the whole translation pipeline themselves.
        var previousGuard = DynamicStringPatches._inFormatConcatPatch;
        DynamicStringPatches._inFormatConcatPatch = true;
        try
        {
            RecordCore(bucket, elapsedStopwatchTicks, sampleDescription);
        }
        finally
        {
            DynamicStringPatches._inFormatConcatPatch = previousGuard;
        }
    }

    private static void RecordCore(string bucket, long elapsedStopwatchTicks, Func<string> sampleDescription)
    {
        var ms = elapsedStopwatchTicks * 1000.0 / Stopwatch.Frequency;
        if (_mainThreadId != -1 && !IsMainThread) bucket += "[bg]";

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

    // Wall-clock frame time = gap between consecutive ticks. A frame is logged as a [HITCH] when it
    // runs long, with how much of it was this plugin's measured main-thread work - the remainder is
    // game/engine time (saves, GC, native code), which is what tells "our patch" from "not ours".
    private const double HitchFrameMilliseconds = 50.0;
    private static long _lastFrameTimestamp;
    private static int _lastGc0, _lastGc1, _lastGc2;

    // Logs and resets the per-frame accumulator; run at the top of every PeriodicTick (once per
    // frame), so what has accumulated is the previous frame's main-thread plugin work.
    private static void FlushFrameAccounting()
    {
        var nowTs = Stopwatch.GetTimestamp();
        var frameMs = _lastFrameTimestamp == 0 ? 0 : (nowTs - _lastFrameTimestamp) * 1000.0 / Stopwatch.Frequency;
        _lastFrameTimestamp = nowTs;

        // .NET (CoreCLR) collections since the previous frame. A gen-2 (or gen-1) collection suspends
        // every managed thread, so allocation-heavy background work (the translation prewarm) could
        // stall the main thread without any measured plugin scope showing it - this tells whether a
        // hitch frame coincides with one. (Unity's own IL2CPP GC is separate and not visible here.)
        var gc0 = GC.CollectionCount(0); var gc1 = GC.CollectionCount(1); var gc2 = GC.CollectionCount(2);
        var gcDelta = $"gc(g0/g1/g2)=+{gc0 - _lastGc0}/+{gc1 - _lastGc1}/+{gc2 - _lastGc2}";
        _lastGc0 = gc0; _lastGc1 = gc1; _lastGc2 = gc2;

        var ms = _frameTicks * 1000.0 / Stopwatch.Frequency;
        var hitch = frameMs >= HitchFrameMilliseconds;
        if (ms >= FrameLogThresholdMs || hitch)
        {
            var previousGuard = DynamicStringPatches._inFormatConcatPatch;
            DynamicStringPatches._inFormatConcatPatch = true;
            try
            {
                var parts = new List<string>();
                foreach (var kvp in _frameBuckets)
                    parts.Add($"{kvp.Key}={kvp.Value * 1000.0 / Stopwatch.Frequency:F1}ms");
                var tag = hitch ? "[HITCH+FRAME]" : "[FRAME]";
                AppendLine($"{tag} {DateTime.Now:HH:mm:ss.fff} frame={frameMs:F0}ms {gcDelta} main-thread plugin work {ms:F1}ms: {string.Join(", ", parts)}", flushNow: true);
            }
            finally
            {
                DynamicStringPatches._inFormatConcatPatch = previousGuard;
            }
        }
        _frameTicks = 0;
        _frameBuckets.Clear();
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

        // Authoritative: this tick runs from Time.deltaTime's getter, i.e. Unity's main thread
        // (MarkMainThread from plugin Load is only a best-effort early value).
        MarkMainThread();
        FlushFrameAccounting();

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
        // The log lines built below embed raw CJK sample text; without the Concat guard they run
        // back through GenericPostfix's translation pipeline (seen in perfStats.log as
        // "(slowest: template=..." inputs) and inflate the very numbers being reported.
        var previousGuard = DynamicStringPatches._inFormatConcatPatch;
        DynamicStringPatches._inFormatConcatPatch = true;
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
            DynamicStringPatches._inFormatConcatPatch = previousGuard;
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
