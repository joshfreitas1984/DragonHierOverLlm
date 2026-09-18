using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using HarmonyLib;
using TMPro;
using UnityEngine.UI;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EnglishPatch;

// Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
internal static class DynamicStringPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");
    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string DictionaryFilePattern = "dynamicStrings*.txt.yaml";

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string PrefabTextFilePattern = "dumpedPrefabText*.txt.yaml";

    private static List<DictionaryEntry> _dictionary = new();

    // Perf: entries bucketed by Raw[0] so ApplyDictionary only ever considers entries that can
    // possibly match the current text, instead of scanning the whole (potentially huge) list.
    private static Dictionary<char, List<DictionaryEntry>> _dictionaryByFirstChar = new();

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static readonly Dictionary<string, string> _reverseDictionary = new();

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static List<DictionaryEntry> _templateDictionary = new();

    // Same perf bucketing as _dictionaryByFirstChar, for FormatPrefix's ApplyDictionary call.
    private static Dictionary<char, List<DictionaryEntry>> _templateDictionaryByFirstChar = new();

    // Longest Raw entry across both dictionaries - bounds the boundary-straddle check window in
    // IsSafeAppendBoundary (see ApplyToComponentText's append-only fast path).
    private static int _maxDictionaryRawLength;

    // Per-component (e.g. per TMP_Text/Text instance) last-seen raw/translated text, keyed by
    // reference identity so an append-only growing text (a scrolling log) only needs its newly
    // appended suffix translated, not the whole accumulated string. Entries are dropped
    // automatically once the component is garbage-collected.
    private sealed class ComponentTextCache
    {
        public string RawSnapshot;
        public string TranslatedSnapshot;

        // Only ever set true, and only consulted when MainPlugin.SkipKnownNonCjkComponentsEnabled
        // is on - see that toggle's config description for the risk this accepts.
        public bool ConfirmedNonCjk;

        // Set by a source-level patch (e.g. InfoListPatches) whose own prefix already translates
        // every fragment before it's appended here - lets ApplyToComponentText trust that only the
        // NEWLY GROWN suffix could possibly still need checking, instead of re-scanning the whole
        // (potentially huge, ever-growing) accumulated buffer for CJK on every single append.
        public bool TrustedAppendOnlySource;

        // Guards the typewriter-reveal fast path's residual-CJK log below - that fast path returns
        // on every tween step once a snapshot is seeded, so without this flag a seeded snapshot
        // that still contains untranslated CJK (e.g. RunGenericPipeline only partially translated
        // it) would either spam one log line per tween step or, before this flag existed, never
        // get logged at all (LogResidualCjkDebug lived only in the full-pipeline branch below,
        // which the fast path skips entirely). Reset whenever a new snapshot is seeded.
        public bool LoggedResidualCjkForSnapshot;

        // Computed once via IsKnownLogPanelPath(GetComponentPath(...)) on this component's first
        // pass through ApplyToComponentText, then reused for its lifetime - a component doesn't
        // get reparented between HeroDetailPanel/Log, AreaLog and PlotPanel/RecordScrollView, so
        // there's no need to re-walk the transform hierarchy on every single .text set. Null means
        // "not yet computed", not "false".
        public bool? IsKnownLogPanel;
    }

    private static readonly ConditionalWeakTable<object, ComponentTextCache> _componentTextCache = new();

    // Lets a source-level patch (e.g. PlotTextPatches.DOText_Prefix) that already knows a
    // component's full final text hand it over before any partial value (e.g. a typewriter
    // reveal tweening toward that text) is ever set on the component. ApplyToComponentText's
    // prefix check below then skips re-running the pipeline on every growing partial value -
    // self-correcting if the component is later reused for unrelated text, since that text won't
    // be a prefix of the stale TranslatedSnapshot and the normal pipeline resumes automatically.
    internal static void SeedComponentTranslatedSnapshot(object instance, string translatedFullText)
    {
        if (instance == null) return;
        var cache = _componentTextCache.GetOrCreateValue(instance);
        cache.TranslatedSnapshot = translatedFullText;
        cache.LoggedResidualCjkForSnapshot = false;
    }

    // Lets a source-level patch (e.g. InfoListPatches) declare that a component only ever grows
    // by appending already-translated fragments - see ComponentTextCache.TrustedAppendOnlySource.
    internal static void MarkTrustedAppendOnlySource(object instance)
    {
        if (instance == null) return;
        _componentTextCache.GetOrCreateValue(instance).TrustedAppendOnlySource = true;
    }

    // Bounded memoization of the (deterministic, dictionary-fixed-for-process-lifetime) translate
    // pipeline, keyed by exact input string. Inputs longer than maxInputLength are never cached -
    // a genuinely ever-growing, always-unique buffer (e.g. a live typewriter reveal mid-tween)
    // would never produce a cache hit, so caching it would only waste memory.
    //
    // Lock-protected (not just single-main-thread-safe) so RecordLogPrewarmPatches can populate
    // this cache from a background Task the moment a new HeroData/AreaData log entry is created -
    // by the time that entry is actually displayed (HeroDetailPanel/AreaLog/PlotPanel), the
    // translation is already cached instead of running cold on the UI thread. `compute` itself
    // deliberately runs OUTSIDE the lock (only the dictionary/queue reads/writes are locked) so a
    // slow/backtracking regex attempt on one thread never blocks an unrelated lookup on another -
    // two threads racing on the exact same uncached input can both compute it once each
    // (redundant, but harmless: same deterministic result, last write wins).
    private sealed class MemoCache
    {
        private readonly int _maxEntries;
        private readonly int _maxInputLength;
        private readonly Dictionary<string, string> _map = new();
        private readonly Queue<string> _order = new();
        private readonly object _lock = new();

        public MemoCache(int maxEntries, int maxInputLength)
        {
            _maxEntries = maxEntries;
            _maxInputLength = maxInputLength;
        }

        public string GetOrCompute(string input, Func<string, string> compute)
        {
            var cacheable = input.Length <= _maxInputLength;
            if (cacheable)
            {
                lock (_lock)
                {
                    if (_map.TryGetValue(input, out var cached))
                        return cached;
                }
            }

            var result = compute(input);

            if (cacheable)
            {
                lock (_lock)
                {
                    if (!_map.ContainsKey(input))
                    {
                        if (_map.Count >= _maxEntries && _order.Count > 0)
                            _map.Remove(_order.Dequeue());
                        _map[input] = result;
                        _order.Enqueue(input);
                    }
                }
            }
            return result;
        }
    }

    // Shared by GenericPostfix and ApplyToComponentText's full-pipeline branch - both run the
    // exact same templates+dictionary pipeline, so a hit in one benefits the other too. Confirmed
    // via perfStats.log that finished log-history entries (AreaLog / PlotPanel's RecordScrollView /
    // HeroDetailPanel's own Log tab) are the SAME finite, already-translated text redisplayed
    // verbatim across several different Text components - each redisplay used to re-run the full
    // template/dictionary pipeline from scratch (a single hit measured at 2.68s, almost entirely
    // regex work against long, already-partially-substituted text - see the "why cached" note
    // below) because these entries routinely exceed the old 500-char cap. Raised well past any
    // real log-entry length so this specific case actually gets cached; still bounded so an
    // unrelated pathological huge string can't grow this cache unbounded.
    private static readonly MemoCache _genericPipelineMemoCache = new(maxEntries: 5000, maxInputLength: 20000);

    // FormatPrefix runs a different pipeline (template-dictionary substitution only), so it needs
    // its own cache rather than sharing _genericPipelineMemoCache. Left at the original bounds -
    // no evidence yet that String.Format's inputs share the same long-finished-text reuse pattern.
    private static readonly MemoCache _formatPipelineMemoCache = new(maxEntries: 2000, maxInputLength: 500);

    // Compiled once per loaded _templateDictionary entry - see CompiledTemplate for what each
    // field means. Applied by ApplyTemplates against Concat/Format results and sink-level
    // component text, in addition to (not instead of) FormatPrefix's literal pre-substitution
    // match, since either mechanism alone misses cases the other catches.
    private static List<CompiledTemplate> _compiledTemplates = new();

    // Subset of _compiledTemplates (the SAME CompiledTemplate instances - never recompiled
    // separately) whose source DictionaryEntry.IsLogNarrative is true - see LogNarrativeFileName
    // and IsKnownLogPanelPath. Lets RunGenericPipeline try a much smaller candidate list first for
    // the three known log panels (docs/recordlog-translation-naturalness.md's stretch goal)
    // instead of the full corpus - those panels only ever display HeroData.AddLog/AreaData.AddLog
    // output, a small (~69-template) confirmed subset of _compiledTemplates.
    private static List<CompiledTemplate> _logNarrativeCompiledTemplates = new();

    // Packaged file name for the isolated "log narrative" AddLog-template family - see
    // Tests/DynamicStringSources.LogNarrativeTemplates and the "Log-narrative isolation" section of
    // Tests/docs/dynamicstrings-pipeline-architecture.md for the Tests/-side half of this split.
    // Matched by exact file name (not content-sniffed) since LoadDictionary already loads every
    // dynamicStrings*.txt.yaml file without otherwise distinguishing which file each entry came
    // from.
    private const string LogNarrativeFileName = "dynamicStringsLogNarratives.txt.yaml";

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static readonly Regex PlaceholderOrTokenRegex = new(@"\{(\d+)\}|#\$?[A-Za-z0-9_]+#", RegexOptions.Compiled);

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string PlaceholderCaptureClass = @"[^\p{IsCJKUnifiedIdeographs}\p{IsCJKSymbolsandPunctuation}\p{IsCJKCompatibilityIdeographs}]";

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string PermissivePlaceholderCaptureClass = @".";

    // Gated by MainPlugin.SentenceBoundaryAwareTemplateCaptureEnabled - excludes common
    // sentence-terminal punctuation (fullwidth period/bang/question mark, ellipsis, ASCII '.',
    // newline) from a merged run's capture so an unanchored regex search can't lock onto an
    // earlier, unrelated occurrence of the run's leading literal that sits before a sentence
    // boundary (see docs/dynamicstringpatches-blocked-template-false-anchor.md).
    private const string SentenceBoundaryAwarePermissiveClass = @"[^。！？…\.\n]";

    // Bounds a single compiled template's Pattern/PermissivePattern IsMatch/Replace attempt -
    // see the CompiledTemplate construction site below for why this exists (confirmed 200ms-2.8s
    // catastrophic-backtracking spikes via perfStats.log). Deliberately small: there can be
    // several templates in one ApplyTemplatesSinglePass call (each getting its own budget), and a
    // template that legitimately needs this long to match live text has never been observed -
    // every confirmed slow case was a template failing to match at all after exhausting
    // backtracking, not a real match that took a while to find.
    private static readonly TimeSpan TemplateRegexTimeout = TimeSpan.FromMilliseconds(25);

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private sealed class CompiledTemplate
    {
        public Regex Pattern;

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        public Regex PermissivePattern;
        public string ReplacementPattern;
        public List<string> LiteralSegments;

        // Perf: first char of each LiteralSegment - lets ApplyTemplates skip a template entirely
        // (no LiteralSegments.All(Contains) calls) when none of its trigger chars are present.
        public HashSet<char> TriggerChars = new();

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        public List<string> BlockingRawEntries = new();

        // Truncated copy of the source entry's Raw text - identifies which compiled template a
        // PerfInstrumentation slow-call sample came from (Pattern/PermissivePattern's own
        // ToString() is the compiled regex source, not the original Raw, and is far less readable).
        public string RawPreview = string.Empty;
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static CompiledTemplate BuildCompiledTemplate(DictionaryEntry entry)
    {
        var raw = entry.Raw ?? string.Empty;
        var patternBuilder = new System.Text.StringBuilder();
        var permissivePatternBuilder = new System.Text.StringBuilder();
        var literalSegments = new List<string>();
        var lastIndex = 0;
        var tokenIndex = 0;
        var result = entry.Result ?? string.Empty;

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        var placeholderMatches = PlaceholderOrTokenRegex.Matches(raw).Cast<Match>().ToList();

        // Identify maximal runs (start/end inclusive indices into placeholderMatches) of 2+
        // consecutive matches separated by zero raw literal text.
        var runs = new List<(int Start, int End)>();
        {
            var i = 0;
            while (i < placeholderMatches.Count)
            {
                var j = i;
                while (j + 1 < placeholderMatches.Count
                       && placeholderMatches[j + 1].Index == placeholderMatches[j].Index + placeholderMatches[j].Length)
                    j++;
                if (j > i) runs.Add((i, j));
                i = j + 1;
            }
        }

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        var runResultSpan = new Dictionary<int, string>(); // keyed by run Start index
        foreach (var (start, end) in runs)
        {
            var runPattern = string.Join(@"\s*", Enumerable.Range(start, end - start + 1).Select(k => Regex.Escape(placeholderMatches[k].Value)));
            var runMatch = Regex.Match(result, runPattern);
            if (!runMatch.Success)
            {
                MainPlugin.Logger.LogWarning(
                    $"[DynamicStringPatches] Skipping template with adjacent placeholders that Result splits apart (cannot be safely bounded by regex): '{raw}'");
                return null;
            }
            runResultSpan[start] = runMatch.Value;
        }

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        var lastGroupIsUnanchored = placeholderMatches.Count > 0
            && placeholderMatches[^1].Index + placeholderMatches[^1].Length == raw.Length;

        var runStartToEnd = runs.ToDictionary(r => r.Start, r => r.End);
        var runIndex = 0;
        var idx = 0;
        while (idx < placeholderMatches.Count)
        {
            if (runStartToEnd.TryGetValue(idx, out var runEnd))
            {
                // Merged run: one combined pass-through capture spanning the whole run, bounded
                // only by whatever literal precedes/follows the WHOLE run (not between its
                // members) - see the safety analysis above for why this is sound.
                var runStartMatch = placeholderMatches[idx];
                var runEndMatch = placeholderMatches[runEnd];
                var literal = raw.Substring(lastIndex, runStartMatch.Index - lastIndex);
                if (literal.Length > 0)
                {
                    var escapedLiteral = Regex.Escape(literal);
                    patternBuilder.Append(escapedLiteral);
                    permissivePatternBuilder.Append(escapedLiteral);
                    literalSegments.Add(literal);
                }

                var groupName = $"run{runIndex}";
                // CJK-permissive on both patterns (not just the fallback) - a merged run's value
                // is frequently a legitimately-CJK force name, so the strict non-CJK class would
                // never match here at all. See CONFIRMED BUG #6 above for the quantifier choice.
                var runQuantifier = (lastGroupIsUnanchored && runEnd == placeholderMatches.Count - 1) ? "*" : "*?";
                var runIsUnanchoredTrailing = lastGroupIsUnanchored && runEnd == placeholderMatches.Count - 1;
                var runCaptureClass = (runIsUnanchoredTrailing && MainPlugin.SentenceBoundaryAwareTemplateCaptureEnabled?.Value == true)
                    ? SentenceBoundaryAwarePermissiveClass
                    : PermissivePlaceholderCaptureClass;
                patternBuilder.Append($"(?<{groupName}>{runCaptureClass}{runQuantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{runCaptureClass}{runQuantifier})");

                // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
                var resultSpan = runResultSpan[idx];
                var sentinelIdx = result.IndexOf(resultSpan, StringComparison.Ordinal);
                if (sentinelIdx >= 0)
                {
                    var sentinel = $"\u0001RUN{runIndex}\u0001";
                    result = result.Substring(0, sentinelIdx) + sentinel + result.Substring(sentinelIdx + resultSpan.Length);
                }

                lastIndex = runEndMatch.Index + runEndMatch.Length;
                idx = runEnd + 1;
                runIndex++;
                continue;
            }

            var placeholder = placeholderMatches[idx];
            var singleLiteral = raw.Substring(lastIndex, placeholder.Index - lastIndex);
            if (singleLiteral.Length > 0)
            {
                var escapedLiteral = Regex.Escape(singleLiteral);
                patternBuilder.Append(escapedLiteral);
                permissivePatternBuilder.Append(escapedLiteral);
                literalSegments.Add(singleLiteral);
            }

            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            var isLastGroup = idx == placeholderMatches.Count - 1;
            var quantifier = (lastGroupIsUnanchored && isLastGroup) ? "*" : "*?";
            // A trailing unanchored single placeholder is just as prone as a merged run to
            // greedily swallowing past a sentence boundary into unrelated text (see the
            // "本战功绩第{0}名乃是{1}" investigation) - apply the same sentence-boundary-aware
            // permissive class here, not just in the merged-run branch above.
            var singleCaptureClass = (lastGroupIsUnanchored && isLastGroup
                    && MainPlugin.SentenceBoundaryAwareTemplateCaptureEnabled?.Value == true)
                ? SentenceBoundaryAwarePermissiveClass
                : PermissivePlaceholderCaptureClass;
            if (placeholder.Groups[1].Success)
            {
                var groupName = $"p{placeholder.Groups[1].Value}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{singleCaptureClass}{quantifier})");
            }
            else
            {
                var groupName = $"tok{tokenIndex}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{singleCaptureClass}{quantifier})");
                tokenIndex++;
            }

            lastIndex = placeholder.Index + placeholder.Length;
            idx++;
        }

        var trailingLiteral = raw.Substring(lastIndex);
        if (trailingLiteral.Length > 0)
        {
            // A dumped Raw string is often captured as a standalone sentence (with its own
            // sentence-final mark), but the SAME generated text can also get reused verbatim as a
            // sub-clause embedded inside a larger sentence elsewhere (e.g. AIController's
            // "{0}在{1}与{2}闲聊一阵。" hero-encounter log line getting recapped later via
            // "...将此前{0}之遭遇向你娓娓道来......" - the trailing "。" isn't there anymore once
            // it's embedded mid-clause). Treat a trailing CJK sentence-final mark as optional
            // (both in the LiteralSegments containment pre-filter below and in the compiled
            // regex/replacement) so this template still matches with or without it, instead of
            // silently failing the pre-filter and falling through to per-word dictionary
            // substitution. Deliberately narrow: only the FINAL trailing mark, only this fixed set
            // of single-character full-width terminators - not "……" (an ellipsis signals trailing
            // off, not a dropped sentence-final mark) and not ASCII "." (which can be genuine
            // structural text elsewhere, e.g. a "Family.Given" name template).
            var lastChar = trailingLiteral[^1];
            if (lastChar is '。' or '！' or '？')
            {
                var trimmedTrailingLiteral = trailingLiteral[..^1];
                var optionalMarkPattern = $"(?:{Regex.Escape(lastChar.ToString())})?";

                if (trimmedTrailingLiteral.Length > 0)
                {
                    var escapedTrimmed = Regex.Escape(trimmedTrailingLiteral);
                    patternBuilder.Append(escapedTrimmed).Append(optionalMarkPattern);
                    permissivePatternBuilder.Append(escapedTrimmed).Append(optionalMarkPattern);
                    // Only the required (non-optional) part needs to be present for the
                    // LiteralSegments.All(Contains) pre-filter to still be a valid early-out.
                    literalSegments.Add(trimmedTrailingLiteral);
                }
                else
                {
                    // The whole trailing literal was just the sentence-final mark itself (e.g.
                    // raw ends "...{0}。") - nothing left to require via the pre-filter at all.
                    patternBuilder.Append(optionalMarkPattern);
                    permissivePatternBuilder.Append(optionalMarkPattern);
                }
            }
            else
            {
                var escapedTrailingLiteral = Regex.Escape(trailingLiteral);
                patternBuilder.Append(escapedTrailingLiteral);
                permissivePatternBuilder.Append(escapedTrailingLiteral);
                literalSegments.Add(trailingLiteral);
            }
        }

        var replacementTokenIndex = 0;
        var replacementPattern = PlaceholderOrTokenRegex.Replace(result, m =>
        {
            if (m.Groups[1].Success) return $"${{p{m.Groups[1].Value}}}";
            var name = $"tok{replacementTokenIndex}";
            replacementTokenIndex++;
            return $"${{{name}}}";
        });

        // Swap each run's sentinel back to a real "${runN}" backreference now that the ordinary
        // per-placeholder Replace pass above (which never sees the sentinel text, since it
        // contains no "{n}"/"#Token#" markers) has finished.
        for (var r = 0; r < runIndex; r++)
            replacementPattern = replacementPattern.Replace($"\u0001RUN{r}\u0001", $"${{run{r}}}");

        return new CompiledTemplate
        {
            // MatchTimeout (see TemplateRegexTimeout) bounds a single catastrophic-backtracking
            // match/replace attempt to a small, fixed cost instead of letting it block for
            // seconds - confirmed live via perfStats.log: HeroData.recordLog/AreaData.recordLog
            // (persisted save fields - deliberately never translated at their source, only ever at
            // display time, so a save never gets English baked into it) can hand this pipeline
            // text a template's raw shape no longer matches at all once partially substituted, and
            // the unanchored permissive capture then forces worst-case backtracking trying every
            // possible split before giving up. This timeout is the actual fix for that cost, since
            // deliberately not translating at the source (see the memoization comment above
            // _genericPipelineMemoCache) means the same raw text keeps reaching this pipeline on
            // every redisplay across every future session too, not just once.
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled, TemplateRegexTimeout),
            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            PermissivePattern = new Regex(permissivePatternBuilder.ToString(), RegexOptions.Compiled | RegexOptions.Singleline, TemplateRegexTimeout),
            ReplacementPattern = replacementPattern,
            LiteralSegments = literalSegments,
            TriggerChars = new HashSet<char>(literalSegments.Where(s => s.Length > 0).Select(s => s[0])),
            RawPreview = raw.Length > 80 ? raw.Substring(0, 80) + "…" : raw,
        };
    }

    [ThreadStatic]
    private static bool _inTextSetterPostfix;

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    // Internal (not private) so InfoListPatches.cs can share the same re-entrancy guard.
    [ThreadStatic]
    internal static bool _inFormatConcatPatch;

    [ThreadStatic]
    internal static bool _suppressGenericTranslation;

    public sealed class DictionaryEntry
    {
        public string Raw { get; set; }
        public string Result { get; set; }

        // Deserialized from the packaged YAML's "isTemplate" key (see FanslationStudio.LlmKit's
        // DynamicStringResult.IsTemplate) - the pipeline computes this once at packaging time so
        // the plugin never has to re-derive "does Raw look like a String.Format template" from
        // the raw text itself at runtime.
        public bool IsTemplate { get; set; }

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        public char? ReplacementLeadChar { get; set; }
        public char? ReplacementTrailChar { get; set; }

        // Set (not deserialized - never present in the YAML itself) when this entry was loaded
        // from LogNarrativeFileName. See _logNarrativeCompiledTemplates.
        public bool IsLogNarrative { get; set; }
    }

    // Shared by PatchAll's raw-entry and translated-literal-variant compilation loops.
    private static void CompileTemplateInto(DictionaryEntry entry, List<(DictionaryEntry Entry, CompiledTemplate Compiled)> into)
    {
        try
        {
            var compiled = BuildCompiledTemplate(entry);
            if (compiled != null)
                into.Add((entry, compiled));
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to compile template '{entry.Raw}': {ex}");
        }
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    public static void PatchAll()
    {
        try
        {
            var loaded = LoadDictionary();
            _templateDictionary = loaded.Where(e => e.IsTemplate).ToList();
            _dictionary = loaded.Where(e => !e.IsTemplate).ToList();
            _dictionaryByFirstChar = BuildFirstCharIndex(_dictionary);
            _templateDictionaryByFirstChar = BuildFirstCharIndex(_templateDictionary);
            _maxDictionaryRawLength = Math.Max(
                _dictionary.Count > 0 ? _dictionary.Max(e => e.Raw?.Length ?? 0) : 0,
                _templateDictionary.Count > 0 ? _templateDictionary.Max(e => e.Raw?.Length ?? 0) : 0);

            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            foreach (var entry in _dictionary)
            {
                if (string.IsNullOrEmpty(entry.Result)) continue;
                if (!_reverseDictionary.ContainsKey(entry.Result))
                    _reverseDictionary[entry.Result] = entry.Raw;
            }

            // Compiled once per entry here, then split by IsLogNarrative below - never recompiled
            // separately for _logNarrativeCompiledTemplates, so that subset is always the exact
            // same Regex/CompiledTemplate instances as in _compiledTemplates (no double regex
            // compilation cost at load time, and no risk of the two lists drifting apart).
            //
            // NOTE: this used to also compile a "translated-literal variant" of each template (via
            // a since-removed BuildTranslatedLiteralVariant) as an extra fallback for the
            // meet-favor precedence bug - see docs/investigations/plugin/
            // dynamicstringpatches-meet-favor-template-precedence.md. Reverted: that mechanism
            // roughly doubled the compiled-template count (confirmed live: 2,789 -> 5,539) with no
            // proven benefit - the investigation's own verification trace confirmed the fix through
            // ordering + the existing CJK-inclusive PermissivePattern fallback alone, never through
            // a variant match. Worse, unlike a raw (Chinese-literal) template - which is naturally
            // idempotent, since a successful match removes the Chinese literal its own pattern
            // depends on - a translated-literal variant's pattern is built from English text that
            // can still resemble its own replacement output, so MultiPassTemplateApplicationEnabled
            // re-running the template list (or a later redisplay of the same cached log text
            // re-entering this pipeline) could match a variant's own prior output and re-insert
            // replacement fragments - confirmed live as runaway text corruption on combat/battle
            // logs (e.g. "Rumored ed ed ed ed ed ed ..."). The ordering fix below is the actual,
            // sufficient fix; only raw entries are compiled now.
            var rawPairs = new List<(DictionaryEntry Entry, CompiledTemplate Compiled)>();
            foreach (var entry in _templateDictionary)
                CompileTemplateInto(entry, rawPairs);

            var orderedRawPairs = rawPairs
                .OrderByDescending(p => p.Compiled.LiteralSegments.Sum(segment => segment.Length))
                .ThenByDescending(p => p.Entry.Raw?.Length ?? 0)
                .ToList();
            _compiledTemplates = orderedRawPairs.Select(p => p.Compiled).ToList();
            _logNarrativeCompiledTemplates = orderedRawPairs
                .Where(p => p.Entry.IsLogNarrative)
                .Select(p => p.Compiled)
                .ToList();

            // See CompiledTemplate.BlockingRawEntries for why this exists: computed once here
            // (not per-call) since both _dictionary and _compiledTemplates are already loaded and
            // fixed for the lifetime of the process.
            foreach (var template in _compiledTemplates)
            {
                template.BlockingRawEntries = _dictionary
                    .Where(e => !string.IsNullOrEmpty(e.Raw)
                        && template.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                    .Select(e => e.Raw)
                    .Distinct()
                    .ToList();
            }

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Loaded {_dictionary.Count} translated fragment(s) and {_templateDictionary.Count} template(s) ({_compiledTemplates.Count} compiled, {_logNarrativeCompiledTemplates.Count} log-narrative) from '{DictionaryFilePattern}'.");

            var harmony = new Harmony("EnglishPatch.DynamicStringPatches");
            var postfix = new HarmonyMethod(typeof(DynamicStringPatches), nameof(GenericPostfix));
            var formatPrefix = new HarmonyMethod(typeof(DynamicStringPatches), nameof(FormatPrefix));

            var targets = typeof(string)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => (m.Name == nameof(string.Concat) || m.Name == nameof(string.Format))
                    && m.ReturnType == typeof(string)
                    && !m.IsGenericMethod);

            var patched = 0;
            var formatPatched = 0;
            foreach (var method in targets)
            {
                try
                {
                    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
                    var isFormat = method.Name == nameof(string.Format);
                    harmony.Patch(method, prefix: isFormat ? formatPrefix : null, postfix: postfix);
                    patched++;
                    if (isFormat) formatPatched++;
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to patch {method}: {ex}");
                }
            }

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Patched {patched} String.Concat/Format overload(s) ({formatPatched} with template prefix).");

            // Sink-level patches: attribute-driven ([HarmonyPatch] on TmpTextSetText_Postfix /
            // UiTextSetText_Postfix below), applied via PatchAll(Type) rather than manual
            // reflection since the target methods are known/fixed at compile time.
            harmony.PatchAll(typeof(DynamicStringPatches));
            MainPlugin.Logger.LogInfo("[DynamicStringPatches] Patched TMP_Text.text/UI.Text.text setters.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] PatchAll failed: {ex}");
        }
    }

    private static List<DictionaryEntry> LoadDictionary()
    {
        try
        {
            var paths = FindResourceFiles(DictionaryFilePattern);
            if (paths.Count == 0) return new List<DictionaryEntry>();

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

            var entries = new List<DictionaryEntry>();
            foreach (var path in paths)
            {
                try
                {
                    var yaml = File.ReadAllText(path);
                    var fileEntries = deserializer.Deserialize<List<DictionaryEntry>>(yaml);
                    if (fileEntries == null) continue;

                    if (string.Equals(Path.GetFileName(path), LogNarrativeFileName, StringComparison.OrdinalIgnoreCase))
                        foreach (var entry in fileEntries) entry.IsLogNarrative = true;

                    entries.AddRange(fileEntries);
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load '{path}': {ex}");
                }
            }

            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            var existingRaw = new HashSet<string>(entries.Select(e => e.Raw).Where(r => !string.IsNullOrEmpty(r)));
            var mergedFromPrefabText = 0;
            foreach (var path in FindResourceFiles(PrefabTextFilePattern))
            {
                try
                {
                    var yaml = File.ReadAllText(path);
                    var fileEntries = deserializer.Deserialize<List<DictionaryEntry>>(yaml);
                    if (fileEntries == null) continue;

                    foreach (var entry in fileEntries)
                    {
                        if (string.IsNullOrEmpty(entry.Raw) || !existingRaw.Add(entry.Raw))
                            continue;

                        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
                        entry.Raw = entry.Raw.Replace("\\n", "\n");
                        if (entry.Result != null)
                            entry.Result = entry.Result.Replace("\\n", "\n");

                        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
                        entry.IsTemplate = PlaceholderOrTokenRegex.IsMatch(entry.Raw);
                        entries.Add(entry);
                        mergedFromPrefabText++;
                    }
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load '{path}': {ex}");
                }
            }

            if (mergedFromPrefabText > 0)
            {
                MainPlugin.Logger.LogInfo(
                    $"[DynamicStringPatches] Merged {mergedFromPrefabText} additional fragment(s) from '{PrefabTextFilePattern}'.");
            }

            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            var existingRawForLabels = new HashSet<string>(entries.Select(e => e.Raw).Where(r => !string.IsNullOrEmpty(r)));
            var labelEntries = new List<DictionaryEntry>();
            foreach (var entry in entries)
            {
                if (entry.IsTemplate || string.IsNullOrEmpty(entry.Raw)) continue;
                var semiIndex = entry.Raw.IndexOf(';');
                if (semiIndex <= 0) continue;

                var rawLabel = entry.Raw.Substring(0, semiIndex);
                if (!existingRawForLabels.Add(rawLabel)) continue;

                var result = entry.Result ?? string.Empty;
                var resultSemiIndex = result.IndexOf(';');
                var resultLabel = resultSemiIndex >= 0 ? result.Substring(0, resultSemiIndex) : result;

                labelEntries.Add(new DictionaryEntry { Raw = rawLabel, Result = resultLabel });
            }
            entries.AddRange(labelEntries);
            if (labelEntries.Count > 0)
            {
                MainPlugin.Logger.LogInfo(
                    $"[DynamicStringPatches] Added {labelEntries.Count} supplemental label-only fragment(s) split from ';'-suffixed dialogue option entries.");
            }

            // Precompute each entry's visible replacement edge chars once (see
            // DictionaryEntry.ReplacementLeadChar/ReplacementTrailChar) rather than on every match
            // at call time - see the perf note on those fields for why this matters.
            foreach (var entry in entries)
            {
                entry.ReplacementLeadChar = EffectiveLeadingChar(entry.Result ?? string.Empty);
                entry.ReplacementTrailChar = EffectiveTrailingChar(entry.Result ?? string.Empty);
            }

            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            return entries.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load dictionaries matching '{DictionaryFilePattern}': {ex}");
            return new List<DictionaryEntry>();
        }
    }

    private static List<string> FindResourceFiles(string filePattern)
    {
        return Directory.Exists(ResourcesDir)
            ? Directory.GetFiles(ResourcesDir, filePattern, SearchOption.AllDirectories).ToList()
            : new List<string>();
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    internal static bool ContainsCjk(string s)
    {
        foreach (var c in s)
        {
            // CJK Unified Ideographs (covers every confirmed Raw fragment seen so far) plus CJK
            // Symbols and Punctuation (the fullwidth colon/comma etc. that can appear in a
            // template's literal separator text, e.g. "：").
            if ((c >= '\u4E00' && c <= '\u9FFF') || (c >= '\u3000' && c <= '\u303F'))
                return true;
        }
        return false;
    }

    private const string ResidualCjkDebugLogFileName = "residualCjkDebug.log";

    public static void ClearResidualCjkDebugLog()
    {
        try
        {
            var path = Path.Combine(PluginDir, ResidualCjkDebugLogFileName);
            if (File.Exists(path)) File.Delete(path);
        }
        catch
        {
            // Best-effort diagnostic only - never let a logging failure affect translation.
        }
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    // `instance` (optional) is the component whose text this is - when supplied, its GameObject
    // hierarchy path is logged too, so a residual-CJK hit (e.g. an untranslated floor-item name
    // with no dictionary coverage) can be traced back to the actual prefab/scene object instead
    // of guessing from the dumped CSV data alone. Callers with no component in scope (GenericPostfix/
    // FormatPrefix, which patch String.Format/Concat rather than a component setter) omit it.
    internal static void LogResidualCjkDebug(string stage, string before, string after, object instance = null)
    {
        if (!MainPlugin.ResidualCjkDebugEnabledCached) return;
        if (!ContainsCjk(after)) return;

        try
        {
            var logPath = Path.Combine(PluginDir, ResidualCjkDebugLogFileName);
            var componentPath = instance != null ? GetComponentPath(instance) : "(no component)";
            File.AppendAllText(logPath,
                $"[{DateTime.Now:HH:mm:ss.fff}] {stage}{Environment.NewLine}" +
                $"  path:   {componentPath}{Environment.NewLine}" +
                $"  before: {before}{Environment.NewLine}" +
                $"  after:  {after}{Environment.NewLine}");
        }
        catch
        {
            // Best-effort diagnostic only - never let a logging failure affect translation.
        }
    }

    internal static void LogMissionDebug(string stage, string before, string after)
    {
        if (!MainPlugin.ResidualCjkDebugEnabledCached) return;

        try
        {
            var logPath = Path.Combine(PluginDir, ResidualCjkDebugLogFileName);
            File.AppendAllText(logPath,
                $"[{DateTime.Now:HH:mm:ss.fff}] {stage}{Environment.NewLine}" +
                $"  before: {before}{Environment.NewLine}" +
                $"  after:  {after}{Environment.NewLine}");
        }
        catch
        {
            // Best-effort diagnostic only - never let logging affect translation.
        }
    }

    // Manual type check (per the confirmed-safe pattern in dragonheirplugin.instructions.md) over
    // the concrete component types ApplyToComponentText's sink patches actually cover - never a
    // generic Cast<T>()/TryCast<T>() over `instance`. Walks the transform.parent chain via plain,
    // non-generic property reads only.
    private static string GetComponentPath(object instance)
    {
        try
        {
            UnityEngine.GameObject go = instance switch
            {
                TMP_Text tmp => tmp.gameObject,
                Text txt => txt.gameObject,
                UILabel lbl => lbl.gameObject,
                _ => null
            };
            if (go == null) return $"(unrecognized component type: {instance?.GetType().Name})";

            var sb = new System.Text.StringBuilder(go.name);
            var parent = go.transform.parent;
            while (parent != null)
            {
                sb.Insert(0, parent.name + "/");
                parent = parent.parent;
            }
            return sb.ToString();
        }
        catch (Exception ex)
        {
            return $"(path lookup failed: {ex.Message})";
        }
    }

    // Lets InfoListPatches.cs early-out without needing access to the private _compiledTemplates/
    // _dictionary fields (whose element types are private nested classes).
    internal static bool HasTranslationData => _compiledTemplates.Count > 0 || _dictionary.Count > 0;

    // The three known log panels the log-narrative routing stretch goal applies to (see
    // docs/recordlog-translation-naturalness.md), matched by substring against the same
    // GetComponentPath hierarchy string HandleTextSetter already receives. Confirmed (via
    // decompiled source - HeroData.cs/AreaData.cs's recordLog field) to only ever display AddLog
    // output, so RunGenericPipeline trusts _logNarrativeCompiledTemplates alone here rather than
    // also falling back to the full corpus - see that method's comment for why a fallback actively
    // backfired for the one case (a stale save entry's own template timing out) this exists to fix.
    private static bool IsKnownLogPanelPath(string path)
    {
        if (string.IsNullOrEmpty(path)) return false;
        return path.Contains("HeroDetailPanel/Log")
            || path.Contains("AreaLog")
            || (path.Contains("PlotPanel") && path.Contains("RecordScrollView"));
    }

    // Shared by GenericPostfix, ApplyToComponentText and InfoListPatches' InfoTextList.Add
    // source-level prefixes - the one place templates+dictionary actually get applied to a raw
    // string. Internal (not private) so InfoListPatches.cs can reuse it.
    // `preferLogNarrativeTemplates`: use ONLY the small isolated log-narrative list (see
    // _logNarrativeCompiledTemplates) instead of the full corpus - set by callers that know the
    // text can only ever be HeroData.AddLog/AreaData.AddLog output (RecordLogPrewarmPatches, and
    // ApplyToComponentText for a component under one of the three known log panels).
    //
    // Deliberately NO fallback to the full _compiledTemplates list when residual CJK remains -
    // an earlier version of this method fell back whenever ContainsCjk(r) was still true after the
    // narrow pass, which backfired: the exact stale-save-redisplay entries this routing exists to
    // help (see docs/recordlog-translation-naturalness.md) are the ones whose OWN template
    // times out and therefore STILL leaves CJK behind, which then triggered a full-corpus retry on
    // top of the narrow pass's own cost - doubling the worst case instead of shrinking it, for
    // precisely the case that mattered most. The three known log panels are confirmed (via
    // decompiled source - HeroData.cs/AreaData.cs's recordLog field) to only ever display AddLog
    // output, and the isolated template list's coverage was verified complete against every AddLog
    // call site (see recordlog-translation-naturalness.md), so trusting the narrow list alone
    // here is safe; ApplyDictionary below (non-template fragment substitution) still always runs
    // regardless, covering any plain-text UI chrome sharing the same component subtree.
    internal static string RunGenericPipeline(string input, bool preferLogNarrativeTemplates = false)
    {
        using var _ = PerfInstrumentation.Measure("DynamicStringPatches.RunGenericPipeline",
            () => input.Length > 60 ? input.Substring(0, 60) + "…" : input);

        return _genericPipelineMemoCache.GetOrCompute(input, s =>
        {
            var r = s;
            if (preferLogNarrativeTemplates && _logNarrativeCompiledTemplates.Count > 0)
                r = ApplyTemplates(r, _logNarrativeCompiledTemplates);
            else if (_compiledTemplates.Count > 0)
                r = ApplyTemplates(r, _compiledTemplates);

            if (_dictionary.Count > 0)
                r = ApplyDictionary(r, _dictionaryByFirstChar);
            return r;
        });
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static void GenericPostfix(ref string __result)
    {
        if (string.IsNullOrEmpty(__result) || _inFormatConcatPatch || _suppressGenericTranslation) return;
        if (_compiledTemplates.Count == 0 && _dictionary.Count == 0) return;
        if (!ContainsCjk(__result)) return;

        // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
        _inFormatConcatPatch = true;
        try
        {
            var original = __result;
            var result = RunGenericPipeline(original);
            LogResidualCjkDebug("GenericPostfix", original, result);
            __result = result;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Postfix failed: {ex}");
        }
        finally
        {
            _inFormatConcatPatch = false;
        }
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static void FormatPrefix(ref string format)
    {
        if (string.IsNullOrEmpty(format) || _templateDictionary.Count == 0 || _inFormatConcatPatch || _suppressGenericTranslation) return;
        if (!ContainsCjk(format)) return;

        // Guard MUST be set before any diagnostic logging below - see the recursion note in
        // GenericPostfix above (same root cause applies here: DebugEscape/SafeDebugLog's own
        // string operations compile to Concat calls that would otherwise re-enter unguarded).
        _inFormatConcatPatch = true;
        try
        {
            var original = format;
            format = _formatPipelineMemoCache.GetOrCompute(original, s => ApplyDictionary(s, _templateDictionaryByFirstChar));
            LogResidualCjkDebug("FormatPrefix", original, format);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] FormatPrefix failed: {ex}");
        }
        finally
        {
            _inFormatConcatPatch = false;
        }
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md and
    // docs/prefabtextpatches-agent-reference.md. These three setter postfixes used to be patched
    // separately by both this class AND PrefabTextPatches (each with its own ContainsCjk scan and
    // its own Harmony dispatch) - merged into HandleTextSetter below so every text assignment
    // anywhere in the UI only reads the current text, and scans it for CJK, once.
    [HarmonyPatch(typeof(TMP_Text), nameof(TMP_Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void TmpTextSetText_Postfix(TMP_Text __instance)
    {
        HandleTextSetter(__instance, () => __instance.text, v => __instance.text = v);
    }

    [HarmonyPatch(typeof(Text), nameof(Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiTextSetText_Postfix(Text __instance)
    {
        HandleTextSetter(__instance, () => __instance.text, v => __instance.text = v);
    }

    // NGUI's own label type - has its own get_text()/set_text(string), entirely separate from
    // UnityEngine.UI.Text/TMP_Text, so it was invisible to this sink patch until confirmed missing
    // (see PrefabTextPatches.cs's TryApplyExactMatch for the same gap on the exact-match side).
    [HarmonyPatch(typeof(UILabel), nameof(UILabel.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiLabelSetText_Postfix(UILabel __instance)
    {
        HandleTextSetter(__instance, () => __instance.text, v => __instance.text = v);
    }

    // Single entry point for all three text-setter sinks: reads the current text once, scans it
    // for CJK once, then runs PrefabTextPatches' whole-string exact-match pass (preserving its old
    // [HarmonyPriority(Priority.First)] "exact match wins" ordering) before falling through to this
    // class's substring dictionary/template pipeline via ApplyToComponentText. Guarded by
    // _inTextSetterPostfix so the setText() call below (which re-invokes the real setter, and so
    // this same postfix) doesn't recurse.
    private static void HandleTextSetter(object instance, Func<string> getText, Action<string> setText)
    {
        using var _ = PerfInstrumentation.Measure("DynamicStringPatches.HandleTextSetter", () => GetComponentPath(instance));

        if (_inTextSetterPostfix) return;

        string current;
        try
        {
            current = getText();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] HandleTextSetter failed reading current text: {ex}");
            return;
        }

        if (string.IsNullOrEmpty(current) || !ContainsCjk(current)) return;

        _inTextSetterPostfix = true;
        try
        {
            var afterExactMatch = PrefabTextPatches.TryApplyExactMatch(current);
            if (afterExactMatch != current)
            {
                setText(afterExactMatch);
                current = afterExactMatch;
            }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] HandleTextSetter exact-match pass failed: {ex}");
        }
        finally
        {
            _inTextSetterPostfix = false;
        }

        var capturedCurrent = current;
        ApplyToComponentText(instance, () => capturedCurrent, setText);
    }

    // AreaBuildController.BuildChoiceButtonClicked re-derives which build action was clicked by
    // comparing the clicked button's rendered label against LTLocalization.GetText("升级")/
    // "迁移"/"拆除" etc. With the game's own language left at "CN", that call returns the raw
    // Chinese key untouched, while the button's label already went through the sink-level setter
    // patches above and got translated - so the comparison always fails and the click silently
    // no-ops (looks like a permanently disabled button).
    //
    // Deliberately scoped to just these known routing literals, NOT every GetText call - many
    // other call sites (e.g. HeroSearchController's Tasks) pass a raw data-field value straight
    // through GetText, and those may still need to compare equal to an intentionally-untranslated
    // (SkipColumns) raw CSV field elsewhere; translating GetText's result unconditionally for
    // every caller would risk breaking that comparison in the opposite direction instead.
    // TutorialController's targetBuilding is the same class of bug but is fixed separately below
    // (a dynamic value, not a fixed literal, so it doesn't fit this whitelist).
    private static readonly HashSet<string> BuildActionRoutingKeys = new()
    {
        "升级", "迁移", "拆除", "新建", "取消建造", "取消升级", "取消拆除",
    };

    [HarmonyPatch(typeof(LTLocalization), nameof(LTLocalization.GetText), new[] { typeof(string), typeof(bool), typeof(bool) })]
    [HarmonyPostfix]
    private static void LtLocalizationGetText_Postfix(string key, ref string __result)
    {
        if (_inFormatConcatPatch || string.IsNullOrEmpty(__result)) return;
        if (!BuildActionRoutingKeys.Contains(key) && !_inHeroSearchNameCompare) return;

        _inFormatConcatPatch = true;
        try
        {
            __result = RunGenericPipeline(__result);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] LtLocalizationGetText_Postfix failed: {ex}");
        }
        finally
        {
            _inFormatConcatPatch = false;
        }
    }

    // HeroSearchController.RegenerateHeroIcon/RefreshFliter compare each hero's name against the
    // search InputField's text via LTLocalization.GetText(rawName) followed by String.Contains.
    // The InputField shows/accepts the already-translated (English) text, but GetText returns the
    // raw untranslated (Chinese) result for this dynamic, per-hero key - so the comparison never
    // matches and the hero list always renders empty regardless of what's typed. Same bug class as
    // the build-action routing keys above, but scoped by call-site (bracketing flag) instead of a
    // fixed key whitelist since the hero name key is dynamic, matching the TutorialController
    // dynamic-value pattern just above.
    [ThreadStatic]
    private static bool _inHeroSearchNameCompare;

    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.RegenerateHeroIcon))]
    [HarmonyPrefix]
    private static void HeroSearchRegenerateHeroIcon_Prefix() => _inHeroSearchNameCompare = true;

    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.RegenerateHeroIcon))]
    [HarmonyFinalizer]
    private static Exception HeroSearchRegenerateHeroIcon_Finalizer(Exception __exception)
    {
        _inHeroSearchNameCompare = false;
        return __exception;
    }

    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.RefreshFliter))]
    [HarmonyPrefix]
    private static void HeroSearchRefreshFliter_Prefix() => _inHeroSearchNameCompare = true;

    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.RefreshFliter))]
    [HarmonyFinalizer]
    private static Exception HeroSearchRefreshFliter_Finalizer(Exception __exception)
    {
        _inHeroSearchNameCompare = false;
        return __exception;
    }

    // TutorialController.TutorialFindBuildingButton/TutorialFindBuildingChoiceButton locate a
    // build/quick-button by scanning a grid for the child whose rendered label text equals
    // LTLocalization.GetText(targetBuilding) - same class of bug as the build-action routing
    // keys above, but targetBuilding is a dynamic building name rather than a fixed literal, so
    // it's translated at the call site instead of widening the GetText key whitelist.
    [HarmonyPatch(typeof(TutorialController), nameof(TutorialController.TutorialFindBuildingButton))]
    [HarmonyPrefix]
    private static void TutorialFindBuildingButton_Prefix(ref string targetBuilding)
    {
        if (!string.IsNullOrEmpty(targetBuilding))
            targetBuilding = RunGenericPipeline(targetBuilding);
    }

    [HarmonyPatch(typeof(TutorialController), nameof(TutorialController.TutorialFindBuildingChoiceButton))]
    [HarmonyPrefix]
    private static void TutorialFindBuildingChoiceButton_Prefix(ref string targetBuilding)
    {
        if (!string.IsNullOrEmpty(targetBuilding))
            targetBuilding = RunGenericPipeline(targetBuilding);
    }

    // MartialClubDataBase.FindMartialClub(areaName) linear-searches
    // GameDataController.Instance.martialclubDataBase (loaded once from MartialClubData.csv at
    // startup) comparing each entry's areaName field against the passed-in areaName. Confirmed via
    // live repro (dumping the list's actual contents) that GameDataController's own CSV-loading
    // code routes each row's area name through a patched String.Concat/Format call while
    // constructing each entry, so every areaName in that list ends up English in memory (e.g.
    // "Chengdu") - never the raw Chinese CSV text. Some callers of FindMartialClub still pass the
    // raw Chinese area name (e.g. "成都", read from a still-untranslated source field), which never
    // matches the English list, so FindMartialClub returns null and
    // PlotController.StudyMartialClubSkillStart has no null-guard on that result - crashing with a
    // NullReferenceException deeper in its body instead of finding the club. Same bug class as
    // TutorialFindBuildingButton/Choice above and the BuildActionRoutingKeys/HeroSearchController
    // cases further up this file - a translated value being compared against a differently-cased
    // (translated vs. raw) source - just resolved here by forward-translating the query to match
    // the already-English list, not by reverse-translating it.
    [HarmonyPatch(typeof(MartialClubDataBase), nameof(MartialClubDataBase.FindMartialClub))]
    [HarmonyPrefix]
    private static void FindMartialClub_Prefix(ref string areaName)
    {
        // CONFIRMED via live repro: GameDataController's own MartialClubData.csv-loading code
        // routes each row's area name through a patched String.Concat/Format call while
        // constructing each MartialClubDataBase entry, so EVERY entry in
        // GameDataController.Instance.martialclubDataBase.areaName is already English in memory
        // (dumped live: "Chengdu", "Hangzhou", "Fuzhou", ... - never the raw Chinese CSV text).
        // So the fix is a forward translation of the query, not a reverse one - mirrors
        // TutorialFindBuildingButton_Prefix above (translate the query to match already-translated
        // data), the opposite of what this method used to do. RunGenericPipeline is a no-op for
        // text with no CJK content, so an already-English areaName passes through unchanged.
        if (!string.IsNullOrEmpty(areaName))
            areaName = RunGenericPipeline(areaName);
    }

    private static void ApplyToComponentText(object instance, Func<string> getText, Action<string> setText)
    {
        if (_inTextSetterPostfix) return;

        // Guard set up-front (before diagnostic logging) for the same reason as
        // GenericPostfix/FormatPrefix above: SafeDebugLog/DebugEscape's own string operations
        // could otherwise re-enter this same setter postfix via a nested .text write.
        _inTextSetterPostfix = true;
        try
        {
            var cache = _componentTextCache.GetOrCreateValue(instance);
            if (MainPlugin.SkipKnownNonCjkComponentsEnabledCached && cache.ConfirmedNonCjk)
                return;

            cache.IsKnownLogPanel ??= _logNarrativeCompiledTemplates.Count > 0 && IsKnownLogPanelPath(GetComponentPath(instance));

            var current = getText();
            if (string.IsNullOrEmpty(current)) return;
            if (_compiledTemplates.Count == 0 && _dictionary.Count == 0) return;

            // Typewriter-reveal fast path: if a caller (e.g. PlotTextPatches) already ran the full
            // pipeline against this component's eventual full text via
            // SeedComponentTranslatedSnapshot, every partial value set while revealing toward it
            // is just a shorter prefix of already-translated text - skip re-running the pipeline
            // (and the ContainsCjk scan below, which would otherwise still fire on residual
            // fullwidth punctuation in an already-translated string) for those partial values.
            if (cache.TranslatedSnapshot != null && cache.TranslatedSnapshot.StartsWith(current, StringComparison.Ordinal))
            {
                // A seeded snapshot (e.g. from PlotTextPatches' pre-translate) can itself still
                // contain residual CJK if the pipeline only partially translated it - this fast
                // path would otherwise hide that from residualCjkDebug.log entirely, since it
                // returns before ever reaching the full-pipeline branch's LogResidualCjkDebug call
                // below. Log it once per seeded snapshot instead of every tween step.
                if (!cache.LoggedResidualCjkForSnapshot && ContainsCjk(cache.TranslatedSnapshot))
                {
                    LogResidualCjkDebug("ApplyToComponentText (typewriter snapshot)", current, cache.TranslatedSnapshot, instance);
                    cache.LoggedResidualCjkForSnapshot = true;
                }
                return;
            }

            // Trusted append-only fast path: a source-level patch already translates every
            // fragment before it reaches this component (see MarkTrustedAppendOnlySource), so
            // only the NEWLY GROWN suffix needs checking - avoids a full-buffer ContainsCjk scan
            // of the whole (potentially huge, ever-growing) accumulated text on every append.
            // Falls through to the normal full-pipeline path below if the buffer was reset/
            // replaced (current no longer starts with RawSnapshot) rather than grown, OR if the
            // suffix unexpectedly still has CJK (e.g. from an untranslated source this component
            // also receives text from) - translating just the suffix in that case could miss a
            // dictionary/template match straddling the old/new boundary, so let the full pipeline
            // below process the whole buffer instead of guessing.
            if (cache.TrustedAppendOnlySource && cache.RawSnapshot != null
                && current.Length > cache.RawSnapshot.Length
                && current.StartsWith(cache.RawSnapshot, StringComparison.Ordinal))
            {
                var appendedSuffix = current.Substring(cache.RawSnapshot.Length);
                if (!ContainsCjk(appendedSuffix))
                {
                    cache.RawSnapshot = current;
                    cache.TranslatedSnapshot += appendedSuffix;
                    return;
                }
            }

            if (!ContainsCjk(current))

            {
                if (MainPlugin.SkipKnownNonCjkComponentsEnabledCached)
                    cache.ConfirmedNonCjk = true;
                return;
            }

            string replaced;
            // No line-break heuristic here: a template's own Raw text can legitimately contain
            // "\n" (e.g. a two-line dialogue sentence), and its literal text could also span
            // across two separate .text=/+= calls (e.g. "component.Text = $"{value}"" followed by
            // "component.Text += $"{value2}""), so no boundary check can fully rule that out.
            // IsSafeAppendBoundary only catches the dictionary-entry case. MainPlugin.
            // AppendOnlySuffixTranslationEnabled gates the whole fast path off by default so this
            // can be compared against always running the full pipeline until the typewriter
            // reveal itself is addressed (see item 3 of the perf plan).
            if (MainPlugin.AppendOnlySuffixTranslationEnabledCached
                && cache.RawSnapshot != null
                && current.Length > cache.RawSnapshot.Length
                && current.StartsWith(cache.RawSnapshot, StringComparison.Ordinal)
                && IsSafeAppendBoundary(current, cache.RawSnapshot.Length))
            {
                // Append-only growth (e.g. the InfoList scrolling log) - translate only the newly
                // appended suffix instead of re-running the whole accumulated text every time.
                // NOTE: InfoTextList's own Add() overloads are now pre-translated at the source
                // (see InfoTextListAdd_Prefix below), so this branch should rarely have any CJK
                // left to do for that specific log - it stays here as a fallback for any other
                // append-only growing component this heuristic also happens to catch.
                var suffix = current.Substring(cache.RawSnapshot.Length);
                suffix = RunGenericPipeline(suffix, cache.IsKnownLogPanel == true);
                replaced = cache.TranslatedSnapshot + suffix;
            }
            else
            {
                replaced = RunGenericPipeline(current, cache.IsKnownLogPanel == true);
            }

            LogResidualCjkDebug("ApplyToComponentText", current, replaced, instance);
            cache.RawSnapshot = current;
            cache.TranslatedSnapshot = replaced;
            if (replaced == current) return;

            setText(replaced);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Text setter postfix failed: {ex}");
        }
        finally
        {
            _inTextSetterPostfix = false;
        }
    }

    // True if no dictionary/template Raw entry straddles the append boundary at `boundaryIndex`
    // (i.e. starts before it and ends at/after it) - guards against the suffix-only fast path
    // above missing a match that only exists when old and newly-appended text are joined.
    private static bool IsSafeAppendBoundary(string text, int boundaryIndex)
    {
        if (_maxDictionaryRawLength <= 1) return true;

        var windowStart = Math.Max(0, boundaryIndex - (_maxDictionaryRawLength - 1));
        var windowEnd = Math.Min(text.Length, boundaryIndex + (_maxDictionaryRawLength - 1));
        var window = text.Substring(windowStart, windowEnd - windowStart);
        var localBoundary = boundaryIndex - windowStart;
        var presentChars = BuildCharSet(window);

        foreach (var entry in CollectCandidates(_dictionaryByFirstChar, presentChars))
            if (StraddlesBoundary(window, localBoundary, entry.Raw)) return false;
        foreach (var entry in CollectCandidates(_templateDictionaryByFirstChar, presentChars))
            if (StraddlesBoundary(window, localBoundary, entry.Raw)) return false;
        return true;
    }

    private static bool StraddlesBoundary(string window, int boundary, string raw)
    {
        if (string.IsNullOrEmpty(raw) || raw.Length < 2) return false;
        var idx = window.IndexOf(raw, StringComparison.Ordinal);
        while (idx >= 0)
        {
            if (idx < boundary && idx + raw.Length > boundary) return true;
            idx = window.IndexOf(raw, idx + 1, StringComparison.Ordinal);
        }
        return false;
    }

    // Bounds MultiPassTemplateApplicationEnabled's repeat loop - see that flag's comment.
    private const int MaxTemplatePasses = 3;

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static string ApplyTemplates(string input, List<CompiledTemplate> templates)
    {
        var result = ApplyTemplatesSinglePass(input, templates);
        if (MainPlugin.MultiPassTemplateApplicationEnabledCached)
        {
            for (var pass = 1; pass < MaxTemplatePasses; pass++)
            {
                var next = ApplyTemplatesSinglePass(result, templates);
                if (next == result) break;
                result = next;
            }
        }
        return result;
    }

    private static string ApplyTemplatesSinglePass(string input, List<CompiledTemplate> templates)
    {
        var result = input;
        HashSet<char> presentChars = null;
        foreach (var template in templates)
        {
            if (template.LiteralSegments.Count > 0)
            {
                // Perf: skip the (potentially several) LiteralSegments.All(Contains) scans
                // entirely when none of this template's trigger chars appear in the text at all.
                presentChars ??= BuildCharSet(result);
                if (!template.TriggerChars.Overlaps(presentChars))
                    continue;
                if (!template.LiteralSegments.All(result.Contains))
                    continue;
            }

            // Measures every template that gets past the trigger-char/literal pre-filter above -
            // i.e. every actual regex IsMatch/Replace attempt, which is where a pathologically
            // backtracking pattern would show up (see the 2.68s HeroDetailPanel/Log spike found
            // via perfStats.log). Sample only formats template.RawPreview/a truncated `result` when
            // this attempt turns out to be the new slowest, or crosses the slow-call threshold, so
            // the common (fast, no-match-or-quick-match) case pays only the Stopwatch timestamp.
            using var _perfTemplateScope = PerfInstrumentation.Measure(
                "DynamicStringPatches.ApplyTemplatesSinglePass.Template",
                () => $"template='{template.RawPreview}' input='{(result.Length > 80 ? result.Substring(0, 80) + "…" : result)}'");

            // PLAN B: try the strict (non-CJK-capture) pattern first - unchanged bug #3/#4
            // behavior. Only fall back to the permissive (CJK-inclusive) pattern when the strict
            // one fails to match at all, so templates that already match correctly today never
            // reach the more permissive path (see PermissivePlaceholderCaptureClass's comment).
            //
            // Each IsMatch/Replace call below is bounded by TemplateRegexTimeout - a
            // RegexMatchTimeoutException here means this template's pattern is catastrophically
            // backtracking against `result` (confirmed live: e.g. HeroData.recordLog/
            // AreaData.recordLog entries - text already partially substituted by an earlier pass -
            // no longer match this template's raw shape at all, but the unanchored permissive
            // capture still tries every possible split before giving up - 200ms-2.8s per hit via
            // perfStats.log). Treat it exactly like "no match" and move on to the next template -
            // losing this one substitution is far better than blocking the whole pipeline (and the
            // UI thread) for seconds.
            var pattern = template.Pattern;
            try
            {
                if (!pattern.IsMatch(result))
                {
                    pattern = template.PermissivePattern;
                    if (!pattern.IsMatch(result))
                        continue;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                MainPlugin.Logger?.LogWarning(
                    $"[DynamicStringPatches] Template match timed out (>{TemplateRegexTimeout.TotalMilliseconds}ms), skipping: '{template.RawPreview}'");
                continue;
            }

            // See CompiledTemplate.BlockingRawEntries (CONFIRMED BUG #4) - captures the text at
            // the start of this template's pass so per-match overlap checks are computed against
            // a stable snapshot (Regex.Replace's MatchEvaluator runs against this same original
            // string for every match before any replacement is written back).
            var beforeThisTemplate = result;
            try
            {
                result = pattern.Replace(result, m =>
                {
                    var blocked = template.BlockingRawEntries.Count > 0
                        && OverlapsBlockingEntry(beforeThisTemplate, m, template.BlockingRawEntries);
                    return blocked ? m.Value : m.Result(template.ReplacementPattern);
                });
            }
            catch (RegexMatchTimeoutException)
            {
                // `result` is unchanged (the assignment above never completed) - same handling as
                // the IsMatch timeout above.
                MainPlugin.Logger?.LogWarning(
                    $"[DynamicStringPatches] Template replace timed out (>{TemplateRegexTimeout.TotalMilliseconds}ms), skipping: '{template.RawPreview}'");
                continue;
            }
            presentChars = null; // result changed - rebuild lazily for the next template
        }
        return result;
    }

    // Returns true if any of the template's BlockingRawEntries occurs in `text` at a position
    // overlapping this specific regex match's span - see CompiledTemplate.BlockingRawEntries for
    // the full "经验{0}%" vs "非本门弟子经验" motivating case.
    private static bool OverlapsBlockingEntry(string text, Match match, List<string> blockingRawEntries)
    {
        var matchStart = match.Index;
        var matchEnd = match.Index + match.Length;
        foreach (var raw in blockingRawEntries)
        {
            var idx = text.IndexOf(raw, StringComparison.Ordinal);
            while (idx >= 0)
            {
                var entryEnd = idx + raw.Length;
                if (idx < matchEnd && entryEnd > matchStart)
                    return true;
                idx = text.IndexOf(raw, idx + 1, StringComparison.Ordinal);
            }
        }
        return false;
    }

    // Public entry point for other patch classes (e.g. HeroNamePatches) that need to translate a
    // raw Chinese fragment - such as a family/given name sliced out of a native string
    // concatenation - using this same loaded substring dictionary, outside of the
    // Concat/Format/text-setter hooks this class patches itself.
    public static string TranslateFragment(string input) => ApplyDictionary(input, _dictionaryByFirstChar);

    // Public entry point for patch classes that need to undo this dictionary's substring replace -
    // see _reverseDictionary's comment and ItemIconPatches.GetItemIconName_Postfix for the
    // motivating case. Returns the original raw Chinese text for an EXACT translated match, or the
    // input unchanged if it isn't a recognized whole-string translation result.
    public static string ReverseTranslate(string translated)
    {
        if (string.IsNullOrEmpty(translated)) return translated;
        return _reverseDictionary.TryGetValue(translated, out var raw) ? raw : translated;
    }

    // Perf: builds the Raw[0] -> entries index consumed by ApplyDictionary, from an already
    // longest-first-sorted entry list (see LoadDictionary's OrderByDescending) - each bucket
    // preserves that same relative ordering since it's a single forward pass over the sorted list.
    private static Dictionary<char, List<DictionaryEntry>> BuildFirstCharIndex(List<DictionaryEntry> orderedEntries)
    {
        var index = new Dictionary<char, List<DictionaryEntry>>();
        foreach (var entry in orderedEntries)
        {
            if (string.IsNullOrEmpty(entry.Raw)) continue;
            var c = entry.Raw[0];
            if (!index.TryGetValue(c, out var bucket))
                index[c] = bucket = new List<DictionaryEntry>();
            bucket.Add(entry);
        }
        return index;
    }

    // Collects only the entries whose first char is actually present in the text, merged back
    // into longest-Raw-first order (the same invariant LoadDictionary's OrderByDescending
    // establishes) so earlier/longer matches still take priority over shorter overlapping ones.
    private static List<DictionaryEntry> CollectCandidates(Dictionary<char, List<DictionaryEntry>> byFirstChar, HashSet<char> presentChars)
    {
        var candidates = new List<DictionaryEntry>();
        foreach (var c in presentChars)
            if (byFirstChar.TryGetValue(c, out var bucket))
                candidates.AddRange(bucket);
        if (candidates.Count > 1)
            candidates.Sort((a, b) => (b.Raw?.Length ?? 0).CompareTo(a.Raw?.Length ?? 0));
        return candidates;
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static string ApplyDictionary(string input, Dictionary<char, List<DictionaryEntry>> byFirstChar)
    {
        if (byFirstChar.Count == 0) return input;

        var result = input;
        List<DictionaryEntry> candidates = null;
        var i = 0;
        while (true)
        {
            // Rebuilt from the CURRENT result whenever it changes (same as before), but now
            // scoped to only the entries whose first char is present, instead of the whole list.
            candidates ??= CollectCandidates(byFirstChar, BuildCharSet(result));
            if (i >= candidates.Count) break;

            var entry = candidates[i];
            if (result.Contains(entry.Raw))
            {
                result = ReplaceWithWordBoundarySpacing(result, entry);
                candidates = null; // result changed - rebuild lazily on next use
                i = 0;
                continue;
            }
            i++;
        }
        return result;
    }

    // Character-membership set for ApplyDictionary's pre-filter - allocated at most once per call
    // (and re-allocated only after an actual replacement), never on the zero-match common path.
    private static HashSet<char> BuildCharSet(string s)
    {
        var set = new HashSet<char>(s.Length);
        foreach (var c in s) set.Add(c);
        return set;
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static readonly Regex TrailingTagsRegex = new(@"(<\/?[A-Za-z][^<>]*>)+$", RegexOptions.Compiled);
    private static readonly Regex LeadingTagsRegex = new(@"^(<\/?[A-Za-z][^<>]*>)+", RegexOptions.Compiled);

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static char? EffectiveTrailingChar(string s)
    {
        var stripped = TrailingTagsRegex.Replace(s, string.Empty);
        return stripped.Length > 0 ? stripped[stripped.Length - 1] : (char?)null;
    }

    private static char? EffectiveLeadingChar(string s)
    {
        var stripped = LeadingTagsRegex.Replace(s, string.Empty);
        return stripped.Length > 0 ? stripped[0] : (char?)null;
    }

    // Allocation-free hot-path counterpart to EffectiveTrailingChar: walks backward from the end
    // of `sb` directly via its indexer (no ToString() copy of the whole accumulated buffer),
    // skipping over any complete tag(s) ("<...>"/"</...>") immediately at the end.
    private static char? EffectiveTrailingCharInBuilder(System.Text.StringBuilder sb)
    {
        var i = sb.Length - 1;
        while (i >= 0)
        {
            if (sb[i] == '>')
            {
                var tagStart = FindTagStartBackward(sb, i);
                if (tagStart >= 0)
                {
                    i = tagStart - 1;
                    continue;
                }
            }
            return sb[i];
        }
        return null;
    }

    // Finds the '<' that opens a tag closing at sb[closeIdx] ('>'), returning -1 if what precedes
    // closeIdx isn't actually a well-formed tag (mirrors TrailingTagsRegex/LeadingTagsRegex's
    // "<\/?[A-Za-z][^<>]*>" shape without allocating a substring to run a regex against).
    private static int FindTagStartBackward(System.Text.StringBuilder sb, int closeIdx)
    {
        var j = closeIdx - 1;
        while (j >= 0 && sb[j] != '<' && sb[j] != '>')
            j--;
        if (j < 0 || sb[j] != '<')
            return -1;

        var k = j + 1;
        if (k <= closeIdx - 1 && sb[k] == '/')
            k++;
        return k <= closeIdx - 1 && char.IsLetter(sb[k]) ? j : -1;
    }

    // Allocation-free hot-path counterpart to EffectiveLeadingChar: walks forward from `startIndex`
    // directly on `s` (no Substring() copy of the remaining tail), skipping over any complete
    // tag(s) immediately at that position.
    private static char? EffectiveLeadingCharAt(string s, int startIndex)
    {
        var i = startIndex;
        while (i < s.Length)
        {
            if (s[i] == '<')
            {
                var tagEnd = FindTagEndForward(s, i);
                if (tagEnd >= 0)
                {
                    i = tagEnd + 1;
                    continue;
                }
            }
            return s[i];
        }
        return null;
    }

    // Finds the '>' that closes a tag opening at s[openIdx] ('<'), returning -1 if what follows
    // openIdx isn't actually a well-formed tag.
    private static int FindTagEndForward(string s, int openIdx)
    {
        var j = openIdx + 1;
        while (j < s.Length && s[j] != '<' && s[j] != '>')
            j++;
        if (j >= s.Length || s[j] != '>')
            return -1;

        var k = openIdx + 1;
        if (k < j && s[k] == '/')
            k++;
        return k < j && char.IsLetter(s[k]) ? j : -1;
    }

    private static string ReplaceWithWordBoundarySpacing(string input, DictionaryEntry entry)
    {
        var raw = entry.Raw;
        var replacement = entry.Result ?? string.Empty;
        var sb = new System.Text.StringBuilder();
        var startIndex = 0;
        int idx;
        while ((idx = input.IndexOf(raw, startIndex, StringComparison.Ordinal)) >= 0)
        {
            sb.Append(input, startIndex, idx - startIndex);

            var prevChar = EffectiveTrailingCharInBuilder(sb);
            if (prevChar.HasValue && entry.ReplacementLeadChar.HasValue
                && char.IsLetterOrDigit(prevChar.Value) && char.IsLetterOrDigit(entry.ReplacementLeadChar.Value))
            {
                sb.Append(' ');
            }

            sb.Append(replacement);
            startIndex = idx + raw.Length;

            var nextChar = startIndex < input.Length ? EffectiveLeadingCharAt(input, startIndex) : null;
            if (entry.ReplacementTrailChar.HasValue && nextChar.HasValue
                && char.IsLetterOrDigit(entry.ReplacementTrailChar.Value) && char.IsLetterOrDigit(nextChar.Value))
            {
                sb.Append(' ');
            }
        }
        sb.Append(input, startIndex, input.Length - startIndex);
        return sb.ToString();
    }
}


