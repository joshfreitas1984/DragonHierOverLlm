// Reproduction harness for the "本战功绩第{0}名乃是{1}，\n{2}" template still falling through to
// bare word-by-word substitution even after the sentence-boundary-aware capture fix landed in
// DynamicStringPatches.BuildCompiledTemplate. Loads the REAL packaged Files/Mod dictionary (the
// same data DynamicStringPatches.LoadDictionary reads at runtime, just via a lightweight
// single-line-scalar parser instead of YamlDotNet, since every "- raw:"/"result:" line in these
// files is a single-line double-quoted scalar) and re-runs the exact BuildCompiledTemplate +
// ApplyTemplatesSinglePass + BlockingRawEntries logic against the reported before-text, to find
// out empirically whether the template matches and, if not, exactly why - instead of continuing
// to guess. See .github/copilot-instructions.md's "Verification harnesses" rule for why this
// lives here instead of a throwaway project.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace VerifyRepro;

public sealed class DictEntry
{
    public string Raw = "";
    public string? Result;
    public bool IsTemplate;
}

public static class TemplateBlockingRepro
{
    private static readonly Regex PlaceholderOrTokenRegex = new(@"\{(\d+)\}|#\$?[A-Za-z0-9_]+#", RegexOptions.Compiled);
    private const string PlaceholderCaptureClass = @"[^\p{IsCJKUnifiedIdeographs}\p{IsCJKSymbolsandPunctuation}\p{IsCJKCompatibilityIdeographs}]";
    private const string PermissivePlaceholderCaptureClass = @".";
    private const string SentenceBoundaryAwarePermissiveClass = @"[^\u3002\uFF01\uFF1F\u2026\.\n]";

    // Un-escapes a YAML double-quoted scalar body (the text between the outer quotes) the same
    // way YamlDotNet would: \" -> ", \\ -> \, \n -> an actual newline char.
    private static string UnescapeYamlDoubleQuoted(string body)
    {
        var sb = new StringBuilder(body.Length);
        for (var i = 0; i < body.Length; i++)
        {
            if (body[i] == '\\' && i + 1 < body.Length)
            {
                var next = body[i + 1];
                if (next == 'n') { sb.Append('\n'); i++; continue; }
                if (next == '"') { sb.Append('"'); i++; continue; }
                if (next == '\\') { sb.Append('\\'); i++; continue; }
            }
            sb.Append(body[i]);
        }
        return sb.ToString();
    }

    private static readonly Regex RawLineRegex = new(@"^- raw: ""(.*)""\s*$", RegexOptions.Compiled);
    private static readonly Regex ResultLineRegex = new(@"^\s*result: ""(.*)""\s*$", RegexOptions.Compiled);
    private static readonly Regex IsTemplateLineRegex = new(@"^\s*isTemplate:\s*true\s*$", RegexOptions.Compiled);

    private static List<DictEntry> LoadModDictionaries(string modDir)
    {
        var entries = new List<DictEntry>();
        foreach (var path in Directory.GetFiles(modDir, "dynamicStrings*.txt.yaml"))
        {
            DictEntry? current = null;
            foreach (var line in File.ReadLines(path))
            {
                var rawMatch = RawLineRegex.Match(line);
                if (rawMatch.Success)
                {
                    if (current != null) entries.Add(current);
                    current = new DictEntry { Raw = UnescapeYamlDoubleQuoted(rawMatch.Groups[1].Value) };
                    continue;
                }
                if (current == null) continue;
                var resultMatch = ResultLineRegex.Match(line);
                if (resultMatch.Success) { current.Result = UnescapeYamlDoubleQuoted(resultMatch.Groups[1].Value); continue; }
                if (IsTemplateLineRegex.IsMatch(line)) current.IsTemplate = true;
            }
            if (current != null) entries.Add(current);
        }
        foreach (var e in entries)
            e.IsTemplate = e.IsTemplate || PlaceholderOrTokenRegex.IsMatch(e.Raw);
        return entries;
    }

    private sealed class CompiledTemplate
    {
        public Regex Pattern = null!;
        public Regex PermissivePattern = null!;
        public string ReplacementPattern = "";
        public List<string> LiteralSegments = new();
        public List<string> BlockingRawEntries = new();
    }

    // Trimmed-down copy of DynamicStringPatches.BuildCompiledTemplate - no merged-run handling
    // needed since our target template has no adjacent placeholders.
    private static CompiledTemplate? BuildCompiledTemplate(DictEntry entry, bool sentenceBoundaryAware)
    {
        var raw = entry.Raw;
        var patternBuilder = new StringBuilder();
        var permissivePatternBuilder = new StringBuilder();
        var literalSegments = new List<string>();
        var lastIndex = 0;
        var tokenIndex = 0;
        var result = entry.Result ?? "";

        var placeholderMatches = PlaceholderOrTokenRegex.Matches(raw).Cast<Match>().ToList();
        var lastGroupIsUnanchored = placeholderMatches.Count > 0
            && placeholderMatches[^1].Index + placeholderMatches[^1].Length == raw.Length;

        for (var idx = 0; idx < placeholderMatches.Count; idx++)
        {
            var placeholder = placeholderMatches[idx];
            var singleLiteral = raw.Substring(lastIndex, placeholder.Index - lastIndex);
            if (singleLiteral.Length > 0)
            {
                var escaped = Regex.Escape(singleLiteral);
                patternBuilder.Append(escaped);
                permissivePatternBuilder.Append(escaped);
                literalSegments.Add(singleLiteral);
            }

            var isLastGroup = idx == placeholderMatches.Count - 1;
            var quantifier = (lastGroupIsUnanchored && isLastGroup) ? "*" : "*?";
            var singleCaptureClass = (lastGroupIsUnanchored && isLastGroup && sentenceBoundaryAware)
                ? SentenceBoundaryAwarePermissiveClass
                : PermissivePlaceholderCaptureClass;
            var permissiveQuantifier = (idx == 0 && placeholder.Index == 0) ? "{1,10}?" : quantifier;

            string groupName;
            if (placeholder.Groups[1].Success) groupName = $"p{placeholder.Groups[1].Value}";
            else groupName = $"tok{tokenIndex++}";
            patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
            permissivePatternBuilder.Append($"(?<{groupName}>{singleCaptureClass}{permissiveQuantifier})");

            lastIndex = placeholder.Index + placeholder.Length;
        }

        var trailingLiteral = raw.Substring(lastIndex);
        if (trailingLiteral.Length > 0)
        {
            var escaped = Regex.Escape(trailingLiteral);
            patternBuilder.Append(escaped);
            permissivePatternBuilder.Append(escaped);
            literalSegments.Add(trailingLiteral);
        }

        var replacementTokenIndex = 0;
        var replacementPattern = PlaceholderOrTokenRegex.Replace(result, m =>
        {
            if (m.Groups[1].Success) return $"${{p{m.Groups[1].Value}}}";
            return $"${{tok{replacementTokenIndex++}}}";
        });

        return new CompiledTemplate
        {
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled),
            PermissivePattern = new Regex(permissivePatternBuilder.ToString(), RegexOptions.Compiled | RegexOptions.Singleline),
            ReplacementPattern = replacementPattern,
            LiteralSegments = literalSegments,
        };
    }

    private static bool OverlapsBlockingEntry(string text, Match match, List<string> blockingRawEntries, out string? culprit)
    {
        var matchStart = match.Index;
        var matchEnd = match.Index + match.Length;
        foreach (var raw in blockingRawEntries)
        {
            var idx = text.IndexOf(raw, StringComparison.Ordinal);
            while (idx >= 0)
            {
                var entryEnd = idx + raw.Length;
                if (idx < matchEnd && entryEnd > matchStart) { culprit = raw; return true; }
                idx = text.IndexOf(raw, idx + 1, StringComparison.Ordinal);
            }
        }
        culprit = null;
        return false;
    }

    public static void Run(string modDir)
    {
        Console.WriteLine("=== TemplateBlockingRepro ===");
        Console.WriteLine($"Loading Mod dictionaries from: {modDir}");
        var entries = LoadModDictionaries(modDir);
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        Console.WriteLine($"Loaded {entries.Count} entries ({dictionary.Count} bare, {entries.Count - dictionary.Count} template).");

        const string targetRaw = "本战功绩第{0}名乃是{1}，\n{2}";
        var targetEntry = entries.FirstOrDefault(e => e.Raw == targetRaw);
        if (targetEntry == null) { Console.WriteLine("Target template entry not found in Mod data!"); return; }
        Console.WriteLine($"Target result: {targetEntry.Result}");

        foreach (var sentenceBoundaryAware in new[] { false, true })
        {
            Console.WriteLine();
            Console.WriteLine($"--- SentenceBoundaryAwareTemplateCaptureEnabled = {sentenceBoundaryAware} ---");
            var compiled = BuildCompiledTemplate(targetEntry, sentenceBoundaryAware);
            if (compiled == null) { Console.WriteLine("Failed to compile."); continue; }

            compiled.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            Console.WriteLine($"BlockingRawEntries count: {compiled.BlockingRawEntries.Count}");

            // Real residualCjkDebug.log capture (2026-09-04 11:37:46) - note the "CaoLight: " name
            // prefix ahead of the template text, absent from the earlier hand-typed repro string.
            const string before = "CaoLight: 本战功绩第1名乃是白云天，\n此战能够取胜，Yuntian居功至伟。本门获你助力，真可谓如鱼得水，如虎添翼。";

            var strictMatch = compiled.Pattern.Match(before);
            Console.WriteLine($"Strict pattern matched: {strictMatch.Success}");

            var permissiveMatch = compiled.PermissivePattern.Match(before);
            Console.WriteLine($"Permissive pattern matched: {permissiveMatch.Success}");
            if (permissiveMatch.Success)
            {
                Console.WriteLine($"  Match span: [{permissiveMatch.Index}, {permissiveMatch.Index + permissiveMatch.Length}) = \"{permissiveMatch.Value.Replace("\n", "\\n")}\"");
                var blocked = OverlapsBlockingEntry(before, permissiveMatch, compiled.BlockingRawEntries, out var culprit);
                Console.WriteLine($"  Blocked: {blocked}" + (blocked ? $" (culprit raw entry: \"{culprit!.Replace("\n", "\\n")}\")" : ""));
                if (!blocked)
                {
                    var replaced = permissiveMatch.Result(compiled.ReplacementPattern);
                    Console.WriteLine($"  Reconstructed replacement: \"{replaced.Replace("\n", "\\n")}\"");
                }
            }
        }

        RunFormatPrefixCheck(entries, targetEntry);
        RunFullPipelineTrace(entries);
    }

    // FormatPrefix (the actual call site this raw string reaches via a native String.Format call,
    // per Converter/output/_NoNamespace/PlotController.cs) never goes through BuildCompiledTemplate/
    // ApplyTemplates at all - it does a literal substring replace of the WHOLE pre-substitution
    // format string (still containing literal "{0}"/"{1}"/"{2}" tokens) via ApplyDictionary against
    // _templateDictionaryByFirstChar, using DictionaryEntry.Raw/Result as flat find/replace pairs.
    // Check that path directly, since the BuildCompiledTemplate path above was a red herring if
    // this call site never reaches GenericPostfix/ApplyToComponentText at all.
    private static void RunFormatPrefixCheck(List<DictEntry> entries, DictEntry targetEntry)
    {
        Console.WriteLine();
        Console.WriteLine("--- FormatPrefix literal-substring path (ApplyDictionary over _templateDictionary) ---");
        const string format = "本战功绩第{0}名乃是{1}，\n{2}";
        var templateEntries = entries.Where(e => e.IsTemplate).ToList();
        var firstCharBucket = templateEntries.Where(e => e.Raw.Length > 0 && e.Raw[0] == format[0]).ToList();
        Console.WriteLine($"Template entries starting with '{format[0]}': {firstCharBucket.Count}");

        // Same candidate order ApplyDictionary uses: longest-Raw-first (LoadDictionary's global sort).
        var candidates = firstCharBucket.OrderByDescending(e => e.Raw.Length).ToList();
        var matches = candidates.Where(e => format.Contains(e.Raw, StringComparison.Ordinal)).ToList();
        Console.WriteLine($"Candidates whose Raw is contained in the literal format string: {matches.Count}");
        foreach (var m in matches)
            Console.WriteLine($"  \"{m.Raw.Replace("\n", "\\n")}\" -> \"{(m.Result ?? "").Replace("\n", "\\n")}\"");

        var exact = matches.FirstOrDefault(m => m.Raw == targetEntry.Raw);
        Console.WriteLine(exact != null
            ? $"Target entry IS present among matches -> FormatPrefix should rewrite the format string to: \"{exact.Result!.Replace("\n", "\\n")}\""
            : "Target entry NOT found among matches - FormatPrefix would leave the format string untouched!");
    }

    // Runs the REAL ApplyTemplatesSinglePass loop (all ~2000 templates, in the same
    // longest-Raw-first order, same LiteralSegments/TriggerChars pre-filter, same strict-then-
    // permissive-then-BlockingRawEntries logic) against the exact residualCjkDebug.log capture,
    // printing every template that actually fires (in order) - the isolated single-template test
    // above can't see a DIFFERENT template corrupting the string first.
    private static void RunFullPipelineTrace(List<DictEntry> entries)
    {
        Console.WriteLine();
        Console.WriteLine("--- Full ApplyTemplatesSinglePass trace (all templates, real order) ---");
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        var templates = entries.Where(e => e.IsTemplate).OrderByDescending(e => e.Raw.Length).ToList();

        var compiledList = new List<(DictEntry Entry, CompiledTemplate Compiled)>();
        foreach (var t in templates)
        {
            var compiled = BuildCompiledTemplate(t, sentenceBoundaryAware: true);
            if (compiled == null) continue;
            compiled.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            compiledList.Add((t, compiled));
        }
        // Mirrors the real DynamicStringPatches.PatchAll fix: re-sort by actual literal content
        // length (not raw.Length, which is skewed by placeholder/token bracket syntax) so a more
        // specific template (more literal text) always gets first refusal over a generic
        // single-token template like "#SourceForceName#功绩".
        compiledList = compiledList
            .OrderByDescending(x => x.Compiled.LiteralSegments.Sum(s => s.Length))
            .ToList();
        Console.WriteLine($"Compiled {compiledList.Count} templates.");

        var result = "CaoLight: 本战功绩第1名乃是白云天，\n此战能够取胜，Yuntian居功至伟。本门获你助力，真可谓如鱼得水，如虎添翼。";
        var fired = 0;
        foreach (var (entry, compiled) in compiledList)
        {
            if (compiled.LiteralSegments.Count > 0 && !compiled.LiteralSegments.All(result.Contains)) continue;

            var pattern = compiled.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = compiled.PermissivePattern;
                if (!pattern.IsMatch(result)) continue;
            }

            var before = result;
            result = pattern.Replace(result, m =>
                compiled.BlockingRawEntries.Count > 0 && OverlapsBlockingEntry(before, m, compiled.BlockingRawEntries, out _)
                    ? m.Value
                    : m.Result(compiled.ReplacementPattern));

            if (result != before)
            {
                fired++;
                Console.WriteLine($"[{fired}] Template raw: \"{entry.Raw.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    before: \"{before.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    after:  \"{result.Replace("\n", "\\n")}\"");
            }
        }
        Console.WriteLine($"Final result: \"{result.Replace("\n", "\\n")}\"");
    }
}
