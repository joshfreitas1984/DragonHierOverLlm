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
        _componentTextCache.GetOrCreateValue(instance).TranslatedSnapshot = translatedFullText;
    }

    // Lets a source-level patch (e.g. InfoListPatches) declare that a component only ever grows
    // by appending already-translated fragments - see ComponentTextCache.TrustedAppendOnlySource.
    internal static void MarkTrustedAppendOnlySource(object instance)
    {
        if (instance == null) return;
        _componentTextCache.GetOrCreateValue(instance).TrustedAppendOnlySource = true;
    }

    // Bounded memoization of the (deterministic, dictionary-fixed-for-process-lifetime) translate
    // pipeline, keyed by exact input string. Long inputs are never cached - the InfoList's own
    // accumulated log text is huge and unique on every call, so caching it would only waste
    // memory without ever producing a hit.
    private sealed class MemoCache
    {
        private const int MaxEntries = 2000;
        private const int MaxInputLength = 500;
        private readonly Dictionary<string, string> _map = new();
        private readonly Queue<string> _order = new();

        public string GetOrCompute(string input, Func<string, string> compute)
        {
            var cacheable = input.Length <= MaxInputLength;
            if (cacheable && _map.TryGetValue(input, out var cached))
                return cached;

            var result = compute(input);

            if (cacheable && !_map.ContainsKey(input))
            {
                if (_map.Count >= MaxEntries && _order.Count > 0)
                    _map.Remove(_order.Dequeue());
                _map[input] = result;
                _order.Enqueue(input);
            }
            return result;
        }
    }

    // Shared by GenericPostfix and ApplyToComponentText's full-pipeline branch - both run the
    // exact same templates+dictionary pipeline, so a hit in one benefits the other too.
    private static readonly MemoCache _genericPipelineMemoCache = new();

    // FormatPrefix runs a different pipeline (template-dictionary substitution only), so it needs
    // its own cache rather than sharing _genericPipelineMemoCache.
    private static readonly MemoCache _formatPipelineMemoCache = new();

    // Compiled once per loaded _templateDictionary entry - see CompiledTemplate for what each
    // field means. Applied by ApplyTemplates against Concat/Format results and sink-level
    // component text, in addition to (not instead of) FormatPrefix's literal pre-substitution
    // match, since either mechanism alone misses cases the other catches.
    private static List<CompiledTemplate> _compiledTemplates = new();

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static readonly Regex PlaceholderOrTokenRegex = new(@"\{(\d+)\}|#\$?[A-Za-z0-9_]+#", RegexOptions.Compiled);

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string PlaceholderCaptureClass = @"[^\p{IsCJKUnifiedIdeographs}\p{IsCJKSymbolsandPunctuation}\p{IsCJKCompatibilityIdeographs}]";

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private const string PermissivePlaceholderCaptureClass = @".";

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
                patternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{runQuantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{runQuantifier})");

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
            if (placeholder.Groups[1].Success)
            {
                var groupName = $"p{placeholder.Groups[1].Value}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{quantifier})");
            }
            else
            {
                var groupName = $"tok{tokenIndex}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{quantifier})");
                tokenIndex++;
            }

            lastIndex = placeholder.Index + placeholder.Length;
            idx++;
        }

        var trailingLiteral = raw.Substring(lastIndex);
        if (trailingLiteral.Length > 0)
        {
            var escapedTrailingLiteral = Regex.Escape(trailingLiteral);
            patternBuilder.Append(escapedTrailingLiteral);
            permissivePatternBuilder.Append(escapedTrailingLiteral);
            literalSegments.Add(trailingLiteral);
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
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled),
            // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
            PermissivePattern = new Regex(permissivePatternBuilder.ToString(), RegexOptions.Compiled | RegexOptions.Singleline),
            ReplacementPattern = replacementPattern,
            LiteralSegments = literalSegments,
            TriggerChars = new HashSet<char>(literalSegments.Where(s => s.Length > 0).Select(s => s[0])),
        };
    }

    [ThreadStatic]
    private static bool _inTextSetterPostfix;

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    // Internal (not private) so InfoListPatches.cs can share the same re-entrancy guard.
    [ThreadStatic]
    internal static bool _inFormatConcatPatch;

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

            _compiledTemplates = _templateDictionary
                .Select(entry =>
                {
                    try { return BuildCompiledTemplate(entry); }
                    catch (Exception ex)
                    {
                        MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to compile template '{entry.Raw}': {ex}");
                        return null;
                    }
                })
                .Where(t => t != null)
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

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Loaded {_dictionary.Count} translated fragment(s) and {_templateDictionary.Count} template(s) ({_compiledTemplates.Count} compiled) from '{DictionaryFilePattern}'.");

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
                    if (fileEntries != null) entries.AddRange(fileEntries);
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
    internal static void LogResidualCjkDebug(string stage, string before, string after)
    {
        if (MainPlugin.ResidualCjkDebugEnabled?.Value != true) return;
        if (!ContainsCjk(after)) return;

        try
        {
            var path = Path.Combine(PluginDir, ResidualCjkDebugLogFileName);
            File.AppendAllText(path,
                $"[{DateTime.Now:HH:mm:ss.fff}] {stage}{Environment.NewLine}" +
                $"  before: {before}{Environment.NewLine}" +
                $"  after:  {after}{Environment.NewLine}");
        }
        catch
        {
            // Best-effort diagnostic only - never let a logging failure affect translation.
        }
    }

    // Lets InfoListPatches.cs early-out without needing access to the private _compiledTemplates/
    // _dictionary fields (whose element types are private nested classes).
    internal static bool HasTranslationData => _compiledTemplates.Count > 0 || _dictionary.Count > 0;

    // Shared by GenericPostfix, ApplyToComponentText and InfoListPatches' InfoTextList.Add
    // source-level prefixes - the one place templates+dictionary actually get applied to a raw
    // string. Internal (not private) so InfoListPatches.cs can reuse it.
    internal static string RunGenericPipeline(string input)
    {
        return _genericPipelineMemoCache.GetOrCompute(input, s =>
        {
            var r = s;
            if (_compiledTemplates.Count > 0)
                r = ApplyTemplates(r, _compiledTemplates);
            if (_dictionary.Count > 0)
                r = ApplyDictionary(r, _dictionaryByFirstChar);
            return r;
        });
    }

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    private static void GenericPostfix(ref string __result)
    {
        if (string.IsNullOrEmpty(__result) || _inFormatConcatPatch) return;
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
        if (string.IsNullOrEmpty(format) || _templateDictionary.Count == 0 || _inFormatConcatPatch) return;
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

    // Detailed rationale and invariants: docs/dynamicstringpatches-agent-reference.md
    [HarmonyPatch(typeof(TMP_Text), nameof(TMP_Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void TmpTextSetText_Postfix(TMP_Text __instance)
    {
        ApplyToComponentText(__instance, () => __instance.text, v => __instance.text = v);
    }

    [HarmonyPatch(typeof(Text), nameof(Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiTextSetText_Postfix(Text __instance)
    {
        ApplyToComponentText(__instance, () => __instance.text, v => __instance.text = v);
    }

    // NGUI's own label type - has its own get_text()/set_text(string), entirely separate from
    // UnityEngine.UI.Text/TMP_Text, so it was invisible to this sink patch until confirmed missing
    // (see PrefabTextPatches.cs's UiLabelSetText_Postfix for the same gap on the exact-match side).
    [HarmonyPatch(typeof(UILabel), nameof(UILabel.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiLabelSetText_Postfix(UILabel __instance)
    {
        ApplyToComponentText(__instance, () => __instance.text, v => __instance.text = v);
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
        if (_inFormatConcatPatch || string.IsNullOrEmpty(__result) || !BuildActionRoutingKeys.Contains(key)) return;

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
            if (MainPlugin.SkipKnownNonCjkComponentsEnabled?.Value == true && cache.ConfirmedNonCjk)
                return;

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
                return;

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
                if (MainPlugin.SkipKnownNonCjkComponentsEnabled?.Value == true)
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
            if (MainPlugin.AppendOnlySuffixTranslationEnabled?.Value == true
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
                suffix = RunGenericPipeline(suffix);
                replaced = cache.TranslatedSnapshot + suffix;
            }
            else
            {
                replaced = RunGenericPipeline(current);
            }

            LogResidualCjkDebug("ApplyToComponentText", current, replaced);
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
        if (MainPlugin.MultiPassTemplateApplicationEnabled?.Value == true)
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

            // PLAN B: try the strict (non-CJK-capture) pattern first - unchanged bug #3/#4
            // behavior. Only fall back to the permissive (CJK-inclusive) pattern when the strict
            // one fails to match at all, so templates that already match correctly today never
            // reach the more permissive path (see PermissivePlaceholderCaptureClass's comment).
            var pattern = template.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = template.PermissivePattern;
                if (!pattern.IsMatch(result))
                    continue;
            }

            // See CompiledTemplate.BlockingRawEntries (CONFIRMED BUG #4) - captures the text at
            // the start of this template's pass so per-match overlap checks are computed against
            // a stable snapshot (Regex.Replace's MatchEvaluator runs against this same original
            // string for every match before any replacement is written back).
            var beforeThisTemplate = result;
            result = pattern.Replace(result, m =>
                template.BlockingRawEntries.Count > 0 && OverlapsBlockingEntry(beforeThisTemplate, m, template.BlockingRawEntries)
                    ? m.Value
                    : m.Result(template.ReplacementPattern));
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


