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

    // Mirrors DynamicStringPatches.LoadDictionary's PrefabTextFilePattern merge step (lines
    // ~664-701): dynamicStrings*.txt.yaml entries load first, then dumpedPrefabText*.txt.yaml
    // entries are merged in, deduped by Raw, with "\n"-escapes unescaped and IsTemplate
    // recomputed from PlaceholderOrTokenRegex (dumpedPrefabText*.txt.yaml never has its own
    // isTemplate: field at all - confirmed via `grep -c isTemplate` returning 0).
    private static List<DictEntry> LoadModDictionariesWithPrefabTextMerge(string modDir)
    {
        var entries = LoadModDictionaries(modDir);
        var existingRaw = new HashSet<string>(entries.Select(e => e.Raw).Where(r => !string.IsNullOrEmpty(r)));
        var merged = 0;
        foreach (var path in Directory.GetFiles(modDir, "dumpedPrefabText*.txt.yaml"))
        {
            DictEntry? current = null;
            var fileEntries = new List<DictEntry>();
            foreach (var line in File.ReadLines(path))
            {
                var rawMatch = RawLineRegex.Match(line);
                if (rawMatch.Success)
                {
                    if (current != null) fileEntries.Add(current);
                    current = new DictEntry { Raw = UnescapeYamlDoubleQuoted(rawMatch.Groups[1].Value) };
                    continue;
                }
                if (current == null) continue;
                var resultMatch = ResultLineRegex.Match(line);
                if (resultMatch.Success) { current.Result = UnescapeYamlDoubleQuoted(resultMatch.Groups[1].Value); continue; }
            }
            if (current != null) fileEntries.Add(current);

            foreach (var entry in fileEntries)
            {
                if (string.IsNullOrEmpty(entry.Raw) || !existingRaw.Add(entry.Raw)) continue;
                // Mirrors DynamicStringPatches.LoadDictionary lines 681-683 exactly: the packaged
                // YAML stores a literal two-char "\n" placeholder (already YAML-unescaped down to
                // that by YamlDotNet/UnescapeYamlDoubleQuoted) which still needs this manual
                // string.Replace to become a real newline character.
                entry.Raw = entry.Raw.Replace("\\n", "\n");
                if (entry.Result != null) entry.Result = entry.Result.Replace("\\n", "\n");
                entry.IsTemplate = PlaceholderOrTokenRegex.IsMatch(entry.Raw);
                entries.Add(entry);
                merged++;
            }
        }
        Console.WriteLine($"Merged {merged} entries from dumpedPrefabText*.txt.yaml (deduped against dynamicStrings*.txt.yaml).");
        return entries;
    }

    // Repro for the SIBLING "主管门派文书经藏事宜..." report (2026-09-22, still broken after the
    // alignment fix shipped and the town-level "主管治下城镇治安事宜" sibling started working).
    // Structural difference from the fixed sibling: this raw has an extra "全门派" literal segment
    // between the last two placeholders ("...提升全门派<b>#EffectForceSpeAdd#</b>" vs plain
    // "...提升<b>#EffectForceSpeAdd#</b>"). Full ACTUAL before/after text supplied by the user,
    // not reconstructed - use it verbatim.
    public static void RunSectJobDescribeRepro(string modDir) => RunSectJobDescribeReproFor(
        modDir,
        "主管门派文书经藏事宜",
        "主管门派文书经藏事宜\n\n提升任职者#EffectSkill#经验#ForceJobExpRate#\n同时根据任职者<b>#EffectSkill#技能</b>提升全门派<b>#EffectForceSpeAdd#</b>",
        "主管门派文书经藏事宜\n\n提升任职者学识经验<color=#00B400>60%</color>\n同时根据任职者<b>学识技能</b>提升全门派<b>技艺经验/科研效率</b>\n\n需要<color=#2779FA>正式弟子</color>以上");

    // 2026-09-22 follow-up report: sibling entry "主管门派医疗康养事宜" is STILL broken even after the
    // tiling-aware fix that resolved 文书经藏's sibling case. Unlike 文书经藏 (title line translated
    // fine), THIS report shows the title line "主管门派医疗康养事宜" itself left completely raw AND
    // the "医术/毒术" skill-name value translated inconsistently across its two occurrences
    // ("医术/Poison technique" vs "Medicine/毒术") - strong signal the big template never fired at
    // all here (falls back to bare fragment substitution for literally everything, including text
    // that SHOULD be covered by this template's own literal segments).
    public static void RunMedicalSectJobDescribeRepro(string modDir) => RunSectJobDescribeReproFor(
        modDir,
        "主管门派医疗康养事宜",
        "主管门派医疗康养事宜\n\n提升任职者#EffectSkill#经验#ForceJobExpRate#\n同时根据任职者<b>#EffectSkill#技能</b>提升全门派<b>#EffectForceSpeAdd#</b>",
        "主管门派医疗康养事宜\n\n提升任职者医术/毒术经验<color=#00B400>60%</color>\n同时根据任职者<b>医术/毒术技能</b>提升全门派<b>疗伤效率/恢复效率</b>\n\n需要<color=#2779FA>正式弟子</color>以上");

    private static void RunSectJobDescribeReproFor(string modDir, string label, string targetRaw, string before)
    {
        Console.WriteLine();
        Console.WriteLine($"=== RunSectJobDescribeRepro ({label}) ===");
        var entries = LoadModDictionariesWithPrefabTextMerge(modDir);
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        var templateEntries = entries.Where(e => e.IsTemplate).ToList();

        var targetEntry = entries.FirstOrDefault(e => e.Raw == targetRaw);
        if (targetEntry == null)
        {
            Console.WriteLine("Target entry not found! Near matches:");
            foreach (var e in entries.Where(e => e.Raw.Contains(label.Substring(4, 4))))
                Console.WriteLine($"  \"{e.Raw.Replace("\n", "\\n")}\" (IsTemplate={e.IsTemplate})");
            return;
        }
        Console.WriteLine($"Target entry found. IsTemplate={targetEntry.IsTemplate}");
        Console.WriteLine($"Target result: {targetEntry.Result!.Replace("\n", "\\n")}");

        var compiled = BuildCompiledTemplateFull(targetEntry, sentenceBoundaryAware: true);
        if (compiled == null) { Console.WriteLine("Failed to compile target template - THIS is the bug (skipped by adjacent-placeholder guard)."); return; }
        Console.WriteLine($"LiteralSegments: {string.Join(" | ", compiled.LiteralSegments.Select(s => s.Replace("\n", "\\n")))}");
        Console.WriteLine($"All literal segments present in 'before': {compiled.LiteralSegments.All(before.Contains)}");
        foreach (var seg in compiled.LiteralSegments)
            Console.WriteLine($"  literal \"{seg.Replace("\n", "\\n")}\" present: {before.Contains(seg)}");

        compiled.BlockingRawEntries = dictionary
            .Where(e => !string.IsNullOrEmpty(e.Raw)
                && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
            .Select(e => e.Raw)
            .Distinct()
            .ToList();
        Console.WriteLine($"BlockingRawEntries count: {compiled.BlockingRawEntries.Count}");

        var dictLongestFirst = dictionary.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        var strictMatch = compiled.Pattern.Match(before);
        Console.WriteLine($"Strict pattern matched: {strictMatch.Success}");
        var permissiveMatch = compiled.PermissivePattern.Match(before);
        Console.WriteLine($"Permissive pattern matched: {permissiveMatch.Success}");
        if (permissiveMatch.Success)
        {
            Console.WriteLine($"  Match span: [{permissiveMatch.Index}, {permissiveMatch.Index + permissiveMatch.Length}) = \"{permissiveMatch.Value.Replace("\n", "\\n")}\"");
            var blockedAligned = OverlapsBlockingEntryAligned(before, permissiveMatch, compiled.BlockingRawEntries, out var culpritAligned);
            Console.WriteLine($"  Blocked (alignment-aware only): {blockedAligned}" + (blockedAligned ? $" (culprit: \"{culpritAligned!.Replace("\n", "\\n")}\")" : ""));
            var blockedTiling = OverlapsBlockingEntryTilingAware(before, permissiveMatch, compiled.BlockingRawEntries, dictLongestFirst, out var culpritTiling);
            Console.WriteLine($"  Blocked (tiling-aware): {blockedTiling}" + (blockedTiling ? $" (culprit: \"{culpritTiling!.Replace("\n", "\\n")}\")" : ""));
            if (!blockedTiling)
                Console.WriteLine($"  Reconstructed replacement: \"{permissiveMatch.Result(compiled.ReplacementPattern).Replace("\n", "\\n")}\"");
        }
        else
        {
            Console.WriteLine("No match at all (strict or permissive) - investigating why via incremental literal-prefix test:");
            var prefixPattern = new System.Text.StringBuilder();
            foreach (var seg in compiled.LiteralSegments)
            {
                prefixPattern.Append(Regex.Escape(seg)).Append(".*?");
                var partial = new Regex(prefixPattern.ToString(), RegexOptions.Singleline);
                Console.WriteLine($"  After literal \"{seg.Replace("\n", "\\n")}\": partial-prefix matches = {partial.IsMatch(before)}");
            }
        }

        // Full pipeline trace to see if a DIFFERENT, higher-priority (more literal content) template
        // fires first and corrupts the string before this one ever gets a chance.
        Console.WriteLine();
        Console.WriteLine("--- Full ApplyTemplatesSinglePass trace (real order) ---");
        var compiledList = new List<(DictEntry Entry, CompiledTemplate Compiled)>();
        foreach (var t in templateEntries)
        {
            var c = BuildCompiledTemplateFull(t, sentenceBoundaryAware: true);
            if (c == null) continue;
            c.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && c.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            compiledList.Add((t, c));
        }
        compiledList = compiledList.OrderByDescending(x => x.Compiled.LiteralSegments.Sum(s => s.Length)).ToList();

        var result = before;
        var fired = 0;
        foreach (var (entry, c) in compiledList)
        {
            if (c.LiteralSegments.Count > 0 && !c.LiteralSegments.All(result.Contains)) continue;

            var pattern = c.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = c.PermissivePattern;
                if (!pattern.IsMatch(result)) continue;
            }

            var beforeThis = result;
            result = pattern.Replace(result, m =>
                c.BlockingRawEntries.Count > 0 && OverlapsBlockingEntryTilingAware(beforeThis, m, c.BlockingRawEntries, dictLongestFirst, out _)
                    ? m.Value
                    : m.Result(c.ReplacementPattern));

            if (result != beforeThis)
            {
                fired++;
                Console.WriteLine($"[{fired}] Template raw: \"{entry.Raw.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    before: \"{beforeThis.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    after:  \"{result.Replace("\n", "\\n")}\"");
                if (entry.Raw == targetRaw) break;
            }
        }
        Console.WriteLine($"Final result (after templates): \"{result.Replace("\n", "\\n")}\"");
        var afterBarePass = ApplyDictionarySimple(result, dictLongestFirst);
        Console.WriteLine($"Final result (after templates + bare-fragment pass, matches real RunGenericPipeline order): \"{afterBarePass.Replace("\n", "\\n")}\"");
    }

    // Repro for the "主管治下城镇治安事宜..." PopInfoPanel/SimpleDetail line reported 2026-09-22 as
    // garbled word-salad output instead of the correct full-sentence translation that IS present
    // in Files/Mod/dumpedPrefabTextFromOtherFields.txt.yaml. Uses the ACTUAL "before" text captured
    // from the ApplyToComponentText log (macros already resolved by ForceSettingController's native
    // String.Replace chain before the text ever reaches this pipeline), plus the real target raw
    // template with its unresolved "#EffectSkill#"/"#ForceJobExpRate#"/"#EffectForceSpeAdd#" tokens.
    public static void RunForceJobDescribeRepro(string modDir)
    {
        Console.WriteLine();
        Console.WriteLine("=== RunForceJobDescribeRepro (2026-09-22 PopInfoPanel report) ===");
        var entries = LoadModDictionariesWithPrefabTextMerge(modDir);
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        var templateEntries = entries.Where(e => e.IsTemplate).ToList();
        Console.WriteLine($"Loaded {entries.Count} entries ({dictionary.Count} bare, {templateEntries.Count} template).");

        const string targetRaw = "主管治下城镇治安事宜\n\n提升任职者#EffectSkill#经验#ForceJobExpRate#\n同时根据任职者<b>#EffectSkill#技能</b>提升<b>#EffectForceSpeAdd#</b>";
        var targetEntry = entries.FirstOrDefault(e => e.Raw == targetRaw);
        if (targetEntry == null)
        {
            Console.WriteLine("Target template entry not found in Mod data! Dumping near-matches:");
            foreach (var e in entries.Where(e => e.Raw.Contains("主管治下城镇治安")))
            {
                Console.WriteLine($"  Raw:  \"{e.Raw.Replace("\n", "\\n")}\"  (len={e.Raw.Length}, IsTemplate={e.IsTemplate})");
                Console.WriteLine($"  Same as target: {e.Raw == targetRaw}");
                for (var i = 0; i < Math.Min(e.Raw.Length, targetRaw.Length); i++)
                {
                    if (e.Raw[i] != targetRaw[i])
                    {
                        Console.WriteLine($"  First diff at index {i}: found U+{(int)e.Raw[i]:X4} '{e.Raw[i]}' vs expected U+{(int)targetRaw[i]:X4} '{targetRaw[i]}'");
                        break;
                    }
                }
                if (e.Raw.Length != targetRaw.Length)
                    Console.WriteLine($"  Length mismatch: found {e.Raw.Length} vs expected {targetRaw.Length}");
            }
            return;
        }
        Console.WriteLine($"Target entry found. IsTemplate={targetEntry.IsTemplate}");
        Console.WriteLine($"Target result: {targetEntry.Result!.Replace("\n", "\\n")}");

        // The actual runtime "before" text from the log (game-composed, macros already resolved).
        const string before = "主管治下城镇治安事宜\n\n提升任职者锻造经验<color=#00B400>60%</color>\n同时根据任职者<b>锻造技能</b>提升<b>全域治安</b>\n\n需要<color=#9A7CFF>亲传弟子</color>以上";

        var compiled = BuildCompiledTemplateFull(targetEntry, sentenceBoundaryAware: true);
        if (compiled == null) { Console.WriteLine("Failed to compile target template."); return; }
        Console.WriteLine($"LiteralSegments: {string.Join(" | ", compiled.LiteralSegments.Select(s => s.Replace("\n", "\\n")))}");
        Console.WriteLine($"All literal segments present in 'before': {compiled.LiteralSegments.All(before.Contains)}");

        compiled.BlockingRawEntries = dictionary
            .Where(e => !string.IsNullOrEmpty(e.Raw)
                && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
            .Select(e => e.Raw)
            .Distinct()
            .ToList();
        Console.WriteLine($"BlockingRawEntries count: {compiled.BlockingRawEntries.Count}");

        var dictLongestFirst = dictionary.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        var strictMatch = compiled.Pattern.Match(before);
        Console.WriteLine($"Strict pattern matched: {strictMatch.Success}");
        var permissiveMatch = compiled.PermissivePattern.Match(before);
        Console.WriteLine($"Permissive pattern matched: {permissiveMatch.Success}");
        if (permissiveMatch.Success)
        {
            Console.WriteLine($"  Match span: [{permissiveMatch.Index}, {permissiveMatch.Index + permissiveMatch.Length}) = \"{permissiveMatch.Value.Replace("\n", "\\n")}\"");
            var blocked = OverlapsBlockingEntry(before, permissiveMatch, compiled.BlockingRawEntries, out var culprit);
            Console.WriteLine($"  Blocked (old plain-overlap check): {blocked}" + (blocked ? $" (culprit raw entry: \"{culprit!.Replace("\n", "\\n")}\")" : ""));

            var blockedAligned = OverlapsBlockingEntryAligned(before, permissiveMatch, compiled.BlockingRawEntries, out var culpritAligned);
            Console.WriteLine($"  Blocked (alignment-aware check): {blockedAligned}" + (blockedAligned ? $" (culprit raw entry: \"{culpritAligned!.Replace("\n", "\\n")}\")" : ""));

            var blockedTiling = OverlapsBlockingEntryTilingAware(before, permissiveMatch, compiled.BlockingRawEntries, dictLongestFirst, out var culpritTiling);
            Console.WriteLine($"  Blocked (tiling-aware check): {blockedTiling}" + (blockedTiling ? $" (culprit raw entry: \"{culpritTiling!.Replace("\n", "\\n")}\")" : ""));
            if (!blockedTiling)
                Console.WriteLine($"  Reconstructed replacement: \"{permissiveMatch.Result(compiled.ReplacementPattern).Replace("\n", "\\n")}\"");
        }

        // Full pipeline trace: every template, real longest-literal-first order, same logic
        // ApplyTemplatesSinglePass runs, to see if some OTHER template fires first and corrupts
        // the string before our target template ever gets a chance.
        Console.WriteLine();
        Console.WriteLine("--- Full ApplyTemplatesSinglePass trace (real order) ---");
        var compiledList = new List<(DictEntry Entry, CompiledTemplate Compiled)>();
        foreach (var t in templateEntries)
        {
            var c = BuildCompiledTemplateFull(t, sentenceBoundaryAware: true);
            if (c == null) continue;
            c.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && c.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            compiledList.Add((t, c));
        }
        compiledList = compiledList.OrderByDescending(x => x.Compiled.LiteralSegments.Sum(s => s.Length)).ToList();

        var result = before;
        var fired = 0;
        foreach (var (entry, c) in compiledList)
        {
            if (c.LiteralSegments.Count > 0 && !c.LiteralSegments.All(result.Contains)) continue;

            var pattern = c.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = c.PermissivePattern;
                if (!pattern.IsMatch(result)) continue;
            }

            var beforeThis = result;
            result = pattern.Replace(result, m =>
                c.BlockingRawEntries.Count > 0 && OverlapsBlockingEntryTilingAware(beforeThis, m, c.BlockingRawEntries, dictLongestFirst, out _)
                    ? m.Value
                    : m.Result(c.ReplacementPattern));

            if (result != beforeThis)
            {
                fired++;
                Console.WriteLine($"[{fired}] Template raw: \"{entry.Raw.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    before: \"{beforeThis.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    after:  \"{result.Replace("\n", "\\n")}\"");
                if (entry.Raw == targetRaw) break;
            }
        }
        Console.WriteLine($"Final result (after templates): \"{result.Replace("\n", "\\n")}\"");
        Console.WriteLine($"Final result (after templates + bare-fragment pass): \"{ApplyDictionarySimple(result, dictLongestFirst).Replace("\n", "\\n")}\"");
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

    // Boundary-aware variant for the 2026-09-22 PopInfoPanel regression: the plain "any overlap"
    // check above blocks even when the overlapping blocking-entry occurrence is fully explained by
    // THIS template's own structure (e.g. "锻造经验" = [#EffectSkill#'s own captured value "锻造"] +
    // [this same template's own literal "经验"], not unrelated swallowed text). A blocking-entry
    // occurrence that extends outside the match, or that lands mid-segment (not aligned to a
    // capture-group/literal boundary this match itself defines), is still a genuine conflict and
    // blocks exactly as before - this only carves out the "fully explained by our own segments"
    // case. See docs/investigations/plugin/dynamicstringpatches-cjk-placeholder-fallback.md bug #4
    // for why the plain overlap check exists in the first place (must keep blocking that case).
    private static bool OverlapsBlockingEntryAligned(string text, Match match, List<string> blockingRawEntries, out string? culprit)
    {
        var matchStart = match.Index;
        var matchEnd = match.Index + match.Length;

        var boundaries = new HashSet<int> { matchStart, matchEnd };
        foreach (Group g in match.Groups)
        {
            if (!g.Success || g.Name == "0") continue;
            boundaries.Add(g.Index);
            boundaries.Add(g.Index + g.Length);
        }

        foreach (var raw in blockingRawEntries)
        {
            var idx = text.IndexOf(raw, StringComparison.Ordinal);
            while (idx >= 0)
            {
                var entryEnd = idx + raw.Length;
                if (idx < matchEnd && entryEnd > matchStart)
                {
                    var fullyWithinMatch = idx >= matchStart && entryEnd <= matchEnd;
                    var alignedToOwnSegments = fullyWithinMatch && boundaries.Contains(idx) && boundaries.Contains(entryEnd);
                    if (!alignedToOwnSegments) { culprit = raw; return true; }
                }
                idx = text.IndexOf(raw, idx + 1, StringComparison.Ordinal);
            }
        }
        culprit = null;
        return false;
    }

    private static bool IsCjkChar(char c) =>
        (c >= '一' && c <= '鿿') || (c >= '㐀' && c <= '䶿') ||
        (c >= '　' && c <= '〿') || (c >= '豈' && c <= '﫿');

    // Greedily tiles `run` left-to-right using the dictionary (longest-Raw-first, same priority
    // ApplyDictionary itself uses) - true only if every CJK character in `run` is covered by some
    // back-to-back dictionary entry (non-CJK characters, e.g. digits/punctuation, always pass).
    // Mirrors Verify/Program.cs's IsFullyCoveredByDictionary (same tiling idea, different caller).
    private static bool IsFullyCoveredByDictionary(string run, List<DictEntry> dictionaryLongestFirst)
    {
        var pos = 0;
        while (pos < run.Length)
        {
            if (!IsCjkChar(run[pos])) { pos++; continue; }
            var matched = false;
            foreach (var e in dictionaryLongestFirst)
            {
                if (string.IsNullOrEmpty(e.Raw)) continue;
                if (pos + e.Raw.Length <= run.Length && string.CompareOrdinal(run, pos, e.Raw, 0, e.Raw.Length) == 0)
                {
                    pos += e.Raw.Length;
                    matched = true;
                    break;
                }
            }
            if (!matched) return false;
        }
        return true;
    }

    // Minimal simulation of DynamicStringPatches.ApplyDictionary (longest-Raw-first substring
    // replace, no word-boundary spacing - good enough to prove whether a second bare-fragment pass
    // over the template's own output recovers translation the tiling-aware block decision deferred
    // to it, matching RunGenericPipeline's real ApplyTemplates-then-ApplyDictionary order).
    private static string ApplyDictionarySimple(string input, List<DictEntry> dictionaryLongestFirst)
    {
        var result = input;
        foreach (var e in dictionaryLongestFirst)
        {
            if (string.IsNullOrEmpty(e.Raw) || string.IsNullOrEmpty(e.Result)) continue;
            if (result.Contains(e.Raw, StringComparison.Ordinal))
                result = result.Replace(e.Raw, e.Result, StringComparison.Ordinal);
        }
        return result;
    }

    // Tiling-aware variant, unified further for the 2026-09-22 "主管门派医疗康养事宜" follow-up: the
    // earlier two-tier version (aligned-to-boundaries OR fully-within-one-group) still blocked when
    // a blocking entry straddled FROM inside a capture group INTO an immediately-adjacent literal
    // (e.g. "毒术经验" = the tail "毒术" of #EffectSkill#'s captured "医术/毒术" + the template's own
    // literal "经验" - neither aligned to the group's own start boundary, nor fully within the
    // group alone). The general principle that actually matters: literal text is always safe (it's
    // fixed, pre-translated Result text, matched via exact Regex.Escape - never ambiguous), and a
    // capture group's raw inserted value is always safe PROVIDED its own full content is tileable
    // by the bare dictionary (RunGenericPipeline's ApplyDictionary pass runs on the template's own
    // output afterward regardless of this decision, so tileable content gets translated either way -
    // see the tiling rationale above). So a blocking-entry occurrence only needs to check: does it
    // overlap any capture group whose FULL content (not just the overlapping slice) fails tiling?
    // If it overlaps zero groups (purely literal) or every group it touches is fully tileable, it's
    // not a genuine conflict - regardless of alignment. Still blocks bug #3 ("经验倍率＋0%" - "经验倍率"
    // overlaps the capture group holding uncovered "倍率＋0") - see RunExpRateBlockingPositiveControl.
    private static bool OverlapsBlockingEntryTilingAware(string text, Match match, List<string> blockingRawEntries, List<DictEntry> dictionaryLongestFirst, out string? culprit)
    {
        var matchStart = match.Index;
        var matchEnd = match.Index + match.Length;

        var groupSpans = new List<(int Start, int End)>();
        foreach (Group g in match.Groups)
        {
            if (!g.Success || g.Name == "0") continue;
            groupSpans.Add((g.Index, g.Index + g.Length));
        }

        var coverageCache = new Dictionary<(int, int), bool>();
        bool IsGroupFullyCovered(int start, int end)
        {
            if (coverageCache.TryGetValue((start, end), out var cached)) return cached;
            var covered = IsFullyCoveredByDictionary(text.Substring(start, end - start), dictionaryLongestFirst);
            coverageCache[(start, end)] = covered;
            return covered;
        }

        foreach (var raw in blockingRawEntries)
        {
            var idx = text.IndexOf(raw, StringComparison.Ordinal);
            while (idx >= 0)
            {
                var entryEnd = idx + raw.Length;
                if (idx < matchEnd && entryEnd > matchStart)
                {
                    var fullyWithinMatch = idx >= matchStart && entryEnd <= matchEnd;
                    if (!fullyWithinMatch) { culprit = raw; return true; }

                    foreach (var (gStart, gEnd) in groupSpans)
                    {
                        var overlapsGroup = idx < gEnd && entryEnd > gStart;
                        if (overlapsGroup && !IsGroupFullyCovered(gStart, gEnd))
                        {
                            culprit = raw;
                            return true;
                        }
                    }
                }
                idx = text.IndexOf(raw, idx + 1, StringComparison.Ordinal);
            }
        }
        culprit = null;
        return false;
    }

    // Positive control for the alignment fix above: reconstructs the "经验{0}%" vs "经验倍率＋0%"
    // scenario from the CJK-placeholder-fallback doc's bug #3 ("经验倍率" as a real standalone
    // dictionary entry causes the template's permissive capture to over-match "倍率" into the
    // placeholder value if not blocked). The blocking entry here overlaps the match but is NOT
    // aligned to the template's own segment boundaries (it ends mid-capture-group, at "倍率", not
    // at the capture group's true end) - OverlapsBlockingEntryAligned must still block this, or
    // the alignment fix would silently regress a previously-confirmed real bug.
    public static void RunExpRateBlockingPositiveControl()
    {
        Console.WriteLine();
        Console.WriteLine("=== RunExpRateBlockingPositiveControl (bug #3 regression guard) ===");
        var entry = new DictEntry { Raw = "经验{0}%", Result = "Experience {0}%" };
        var compiled = BuildCompiledTemplateFull(entry, sentenceBoundaryAware: false)!;
        const string before = "经验倍率＋0%";
        compiled.BlockingRawEntries = new List<string> { "经验倍率" };

        var match = compiled.Pattern.IsMatch(before) ? compiled.Pattern.Match(before) : compiled.PermissivePattern.Match(before);
        Console.WriteLine($"Matched: {match.Success}" + (match.Success ? $", span=[{match.Index},{match.Index + match.Length}) = \"{match.Value}\"" : ""));
        if (!match.Success) return;

        var oldBlocked = OverlapsBlockingEntry(before, match, compiled.BlockingRawEntries, out var oldCulprit);
        var newBlocked = OverlapsBlockingEntryAligned(before, match, compiled.BlockingRawEntries, out var newCulprit);
        Console.WriteLine($"Old (plain overlap) blocked: {oldBlocked}" + (oldBlocked ? $" (culprit: \"{oldCulprit}\")" : ""));
        Console.WriteLine($"Alignment-aware blocked: {newBlocked}" + (newBlocked ? $" (culprit: \"{newCulprit}\")" : ""));

        // Tiling-aware with NO coverage for "倍率" (realistic: it has no standalone dictionary
        // entry) - must still block, since the leftover raw "倍率" would never get translated by a
        // later bare-fragment pass either.
        var noCoverageDict = new List<DictEntry>();
        var tilingBlockedNoCoverage = OverlapsBlockingEntryTilingAware(before, match, compiled.BlockingRawEntries, noCoverageDict, out var tilingCulpritNoCoverage);
        Console.WriteLine($"Tiling-aware (no coverage for \"倍率\") blocked: {tilingBlockedNoCoverage}" + (tilingBlockedNoCoverage ? $" (culprit: \"{tilingCulpritNoCoverage}\")" : ""));

        // Tiling-aware WITH coverage for "倍率" (hypothetical: if it DID have its own entry) - may
        // now safely not-block, since ApplyDictionary would fix it up afterward anyway. Included to
        // document the tiling check's actual decision boundary, not as a pass/fail assertion.
        var withCoverageDict = new List<DictEntry> { new DictEntry { Raw = "倍率", Result = "Rate" } };
        var tilingBlockedWithCoverage = OverlapsBlockingEntryTilingAware(before, match, compiled.BlockingRawEntries, withCoverageDict, out var tilingCulpritWithCoverage);
        Console.WriteLine($"Tiling-aware (WITH coverage for \"倍率\") blocked: {tilingBlockedWithCoverage}" + (tilingBlockedWithCoverage ? $" (culprit: \"{tilingCulpritWithCoverage}\")" : ""));

        Console.WriteLine(newBlocked && tilingBlockedNoCoverage
            ? "PASS: both alignment-aware and tiling-aware (realistic, no coverage) still block the genuine bug #3 over-match."
            : "FAIL: a fix regressed bug #3 - it must still block under realistic (no \"倍率\" coverage) conditions!");
    }

    // Repro for the "此{0}{1}，论{2}，而{3}，且{4}，\n总体而言是一件{5}无疑。\n{6}" antique-identification
    // description line reported 2026-09-22: the game log's before/after showed only isolated words
    // swapped ("为" -> "For", "则为" -> "Then as", plus the item name via its own exact-match entry)
    // while the template's own literals ("此", "，论") stayed raw Chinese - meaning the big
    // whole-sentence template (which HAS a correct, QC-approved full translation packaged in
    // Files/Mod) never matched at all, and the fallback silently did bare word-substring
    // replacement instead. The full runtime "before" text wasn't captured/available for this
    // report (unlike RunForceJobDescribeRepro's), so this only exercises the confirmed prefix -
    // "此" + item name + "Condition为<color=#9A7CFF>High Grade</color>" + "，论" + "Age则为" - with a
    // synthetic tail appended just so the whole-template regex has something to match through to
    // {6}; only the PREFIX behavior (does the permissive match get blocked before reaching "，论"?)
    // is meaningful here, not the synthetic tail's content.
    public static void RunAntiqueIdentifyRepro(string modDir)
    {
        Console.WriteLine();
        Console.WriteLine("=== RunAntiqueIdentifyRepro (2026-09-22 item-identify report, partial log) ===");
        var entries = LoadModDictionariesWithPrefabTextMerge(modDir);
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        Console.WriteLine($"Loaded {entries.Count} entries ({dictionary.Count} bare, {entries.Count - dictionary.Count} template).");

        const string targetRaw = "此{0}{1}，论{2}，而{3}，且{4}，\n总体而言是一件{5}无疑。\n{6}";
        var targetEntry = entries.FirstOrDefault(e => e.Raw == targetRaw);
        if (targetEntry == null) { Console.WriteLine("Target template entry not found in Mod data!"); return; }
        Console.WriteLine($"Target result: \"{targetEntry.Result!.Replace("\n", "\\n")}\"");

        // Confirmed real bare entries from the actual before/after log (both fired independently
        // at runtime, proving the outer template did NOT match for this line).
        var forResult = dictionary.FirstOrDefault(e => e.Raw == "为");
        var thenAsResult = dictionary.FirstOrDefault(e => e.Raw == "则为");
        Console.WriteLine($"Bare entry \"为\" -> \"{forResult?.Result}\" (present: {forResult != null})");
        Console.WriteLine($"Bare entry \"则为\" -> \"{thenAsResult?.Result}\" (present: {thenAsResult != null})");

        // Confirmed prefix from the actual log, plus a synthetic tail (marked) only so the regex
        // has literals to match through to {6}. Do not read anything into the tail's specific text.
        const string confirmedPrefix = "此<color=#78BE00>忘忧清乐集</color>Condition为<color=#9A7CFF>High Grade</color>，论Age则为";
        const string syntheticTail = "尚可，而品相良好，且做工精细，\n总体而言是一件珍品无疑。\n";
        var before = confirmedPrefix + syntheticTail;

        var compiled = BuildCompiledTemplateFull(targetEntry, sentenceBoundaryAware: true);
        if (compiled == null) { Console.WriteLine("Failed to compile target template."); return; }
        Console.WriteLine($"LiteralSegments: {string.Join(" | ", compiled.LiteralSegments.Select(s => s.Replace("\n", "\\n")))}");

        compiled.BlockingRawEntries = dictionary
            .Where(e => !string.IsNullOrEmpty(e.Raw)
                && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
            .Select(e => e.Raw)
            .Distinct()
            .ToList();
        Console.WriteLine($"BlockingRawEntries count: {compiled.BlockingRawEntries.Count}");

        var strictMatch = compiled.Pattern.Match(before);
        Console.WriteLine($"Strict pattern matched: {strictMatch.Success}");
        var permissiveMatch = compiled.PermissivePattern.Match(before);
        Console.WriteLine($"Permissive pattern matched: {permissiveMatch.Success}");
        if (!permissiveMatch.Success) return;

        Console.WriteLine($"  Match span: [{permissiveMatch.Index}, {permissiveMatch.Index + permissiveMatch.Length}) = \"{permissiveMatch.Value.Replace("\n", "\\n")}\"");

        // The bare entries "为"/"则为" aren't in BlockingRawEntries (they're not substrings of this
        // template's OWN literal segments), so they can't be the blocker here via that mechanism -
        // demonstrate that explicitly, then check what actually blocks (if anything) using both
        // dictionary-derived BlockingRawEntries AND the two confirmed bare entries added manually,
        // to see whether the aligned-overlap fix still lets this one through.
        Console.WriteLine($"  \"为\" in BlockingRawEntries: {compiled.BlockingRawEntries.Contains("为")}");
        Console.WriteLine($"  \"则为\" in BlockingRawEntries: {compiled.BlockingRawEntries.Contains("则为")}");

        var blockedPlain = OverlapsBlockingEntry(before, permissiveMatch, compiled.BlockingRawEntries, out var culpritPlain);
        Console.WriteLine($"  Blocked (plain overlap, real BlockingRawEntries): {blockedPlain}" + (blockedPlain ? $" (culprit: \"{culpritPlain!.Replace("\n", "\\n")}\")" : ""));
        var blockedAligned = OverlapsBlockingEntryAligned(before, permissiveMatch, compiled.BlockingRawEntries, out var culpritAligned);
        Console.WriteLine($"  Blocked (aligned overlap, real BlockingRawEntries): {blockedAligned}" + (blockedAligned ? $" (culprit: \"{culpritAligned!.Replace("\n", "\\n")}\")" : ""));

        var withBareEntries = new List<string>(compiled.BlockingRawEntries) { "为", "则为" };
        var blockedAlignedWithBare = OverlapsBlockingEntryAligned(before, permissiveMatch, withBareEntries, out var culpritBare);
        Console.WriteLine($"  Blocked (aligned overlap, IF \"为\"/\"则为\" were treated as blocking): {blockedAlignedWithBare}" + (blockedAlignedWithBare ? $" (culprit: \"{culpritBare!.Replace("\n", "\\n")}\")" : ""));
        Console.WriteLine(blockedAlignedWithBare
            ? "  -> A bare entry landing INSIDE an opaque placeholder capture (not at any group boundary) still counts as \"not aligned\" and blocks - this is a different shape from bug #3/#4 (no boundary is crossed; the whole occurrence sits inside one placeholder's own captured value)."
            : "  -> Bare entries fully inside a placeholder capture do NOT block under the current aligned check.");

        var dictLongestFirstForAntique = dictionary.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        var blockedTilingWithBare = OverlapsBlockingEntryTilingAware(before, permissiveMatch, withBareEntries, dictLongestFirstForAntique, out var culpritTilingBare);
        Console.WriteLine($"  Blocked (TILING-aware, IF \"为\"/\"则为\" were treated as blocking): {blockedTilingWithBare}" + (blockedTilingWithBare ? $" (culprit: \"{culpritTilingBare!.Replace("\n", "\\n")}\")" : ""));
        Console.WriteLine("  -> Tiling-aware resolves this: \"为\"/\"则为\" sit fully inside opaque placeholder captures that are themselves short (1-2 char, non-CJK-heavy) fragments - covered or not depending on real dictionary content, not a hardcoded boundary rule.");

        var blockedTiling = OverlapsBlockingEntryTilingAware(before, permissiveMatch, compiled.BlockingRawEntries, dictLongestFirstForAntique, out var culpritTiling);
        if (!blockedTiling)
            Console.WriteLine($"  Reconstructed replacement (tiling-aware): \"{permissiveMatch.Result(compiled.ReplacementPattern).Replace("\n", "\\n")}\"");

        // The isolated single-template check above shows this template CAN match and ISN'T
        // blocked - so if the real game still shows only bare-word substitutions, something in the
        // full ~2200-template pipeline (a longer/earlier template, or plain bare-entry substitution
        // running first and corrupting the string) must be intervening before this template gets a
        // turn. Trace the real ApplyTemplatesSinglePass order against the same 'before' text.
        Console.WriteLine();
        Console.WriteLine("--- Full ApplyTemplatesSinglePass trace (real order) ---");
        var templateEntries = entries.Where(e => e.IsTemplate).ToList();
        var compiledList = new List<(DictEntry Entry, CompiledTemplate Compiled)>();
        foreach (var t in templateEntries)
        {
            var c = BuildCompiledTemplateFull(t, sentenceBoundaryAware: true);
            if (c == null) continue;
            c.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && c.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            compiledList.Add((t, c));
        }
        compiledList = compiledList.OrderByDescending(x => x.Compiled.LiteralSegments.Sum(s => s.Length)).ToList();
        Console.WriteLine($"Compiled {compiledList.Count} templates.");

        var result = before;
        var fired = 0;
        foreach (var (entry, c) in compiledList)
        {
            if (c.LiteralSegments.Count > 0 && !c.LiteralSegments.All(result.Contains)) continue;

            var pattern = c.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = c.PermissivePattern;
                if (!pattern.IsMatch(result)) continue;
            }

            var beforeThis = result;
            result = pattern.Replace(result, m =>
                c.BlockingRawEntries.Count > 0 && OverlapsBlockingEntryTilingAware(beforeThis, m, c.BlockingRawEntries, dictLongestFirstForAntique, out _)
                    ? m.Value
                    : m.Result(c.ReplacementPattern));

            if (result != beforeThis)
            {
                fired++;
                Console.WriteLine($"[{fired}] Template raw: \"{entry.Raw.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    before: \"{beforeThis.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    after:  \"{result.Replace("\n", "\\n")}\"");
                if (entry.Raw == targetRaw) break;
            }
        }
        Console.WriteLine($"Final result (after templates): \"{result.Replace("\n", "\\n")}\"");
        var afterBarePassAntique = ApplyDictionarySimple(result, dictLongestFirstForAntique);
        Console.WriteLine($"Final result (after templates + bare-fragment pass): \"{afterBarePassAntique.Replace("\n", "\\n")}\"");
        if (compiledList.All(x => x.Entry.Raw != targetRaw))
            Console.WriteLine("NOTE: target template did not compile into compiledList at all (see [BuildCompiledTemplateFull] skip messages above)!");
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

        var dictLongestFirstForRun = dictionary.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
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
                compiled.BlockingRawEntries.Count > 0 && OverlapsBlockingEntryTilingAware(before, m, compiled.BlockingRawEntries, dictLongestFirstForRun, out _)
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

    // Full, merged-run-aware copy of DynamicStringPatches.BuildCompiledTemplate (2026-09-06) -
    // the trimmed-down BuildCompiledTemplate above can't compile the "天下大势：{4}{0}..." template
    // correctly since it has an adjacent-placeholder run ({4}{0}) that needs the "runs" merging
    // logic to be bounded safely.
    private static CompiledTemplate? BuildCompiledTemplateFull(DictEntry entry, bool sentenceBoundaryAware)
    {
        var raw = entry.Raw;
        var patternBuilder = new StringBuilder();
        var permissivePatternBuilder = new StringBuilder();
        var literalSegments = new List<string>();
        var lastIndex = 0;
        var tokenIndex = 0;
        var result = entry.Result ?? "";

        var placeholderMatches = PlaceholderOrTokenRegex.Matches(raw).Cast<Match>().ToList();

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

        var runResultSpan = new Dictionary<int, string>();
        foreach (var (start, end) in runs)
        {
            var runPattern = string.Join(@"\s*", Enumerable.Range(start, end - start + 1).Select(k => Regex.Escape(placeholderMatches[k].Value)));
            var runMatch = Regex.Match(result, runPattern);
            if (!runMatch.Success)
            {
                Console.WriteLine($"  [BuildCompiledTemplateFull] Skipping template with adjacent placeholders Result splits apart: '{raw}'");
                return null;
            }
            runResultSpan[start] = runMatch.Value;
        }

        var lastGroupIsUnanchored = placeholderMatches.Count > 0
            && placeholderMatches[^1].Index + placeholderMatches[^1].Length == raw.Length;

        var runStartToEnd = runs.ToDictionary(r => r.Start, r => r.End);
        var runIndex = 0;
        var idx = 0;
        while (idx < placeholderMatches.Count)
        {
            if (runStartToEnd.TryGetValue(idx, out var runEnd))
            {
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
                var runQuantifier = (lastGroupIsUnanchored && runEnd == placeholderMatches.Count - 1) ? "*" : "*?";
                if (idx == 0 && runStartMatch.Index == 0) runQuantifier = "{1,10}?";
                var runIsUnanchoredTrailing = lastGroupIsUnanchored && runEnd == placeholderMatches.Count - 1;
                var runCaptureClass = (runIsUnanchoredTrailing && sentenceBoundaryAware) ? SentenceBoundaryAwarePermissiveClass : PermissivePlaceholderCaptureClass;
                patternBuilder.Append($"(?<{groupName}>{runCaptureClass}{runQuantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{runCaptureClass}{runQuantifier})");

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

            var isLastGroup = idx == placeholderMatches.Count - 1;
            var quantifier = (lastGroupIsUnanchored && isLastGroup) ? "*" : "*?";
            var singleCaptureClass = (lastGroupIsUnanchored && isLastGroup && sentenceBoundaryAware)
                ? SentenceBoundaryAwarePermissiveClass
                : PermissivePlaceholderCaptureClass;
            var permissiveQuantifier = (idx == 0 && placeholder.Index == 0) ? "{1,10}?" : quantifier;
            if (placeholder.Groups[1].Success)
            {
                var groupName = $"p{placeholder.Groups[1].Value}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{singleCaptureClass}{permissiveQuantifier})");
            }
            else
            {
                var groupName = $"tok{tokenIndex}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{singleCaptureClass}{permissiveQuantifier})");
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

        for (var r = 0; r < runIndex; r++)
            replacementPattern = replacementPattern.Replace($"\u0001RUN{r}\u0001", $"${{run{r}}}");

        return new CompiledTemplate
        {
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled),
            PermissivePattern = new Regex(permissivePatternBuilder.ToString(), RegexOptions.Compiled | RegexOptions.Singleline),
            ReplacementPattern = replacementPattern,
            LiteralSegments = literalSegments,
        };
    }

    // Repro for the 2026-09-06 regression report: "天下大势：{4}{0}门派 {1}攻击资源{4}门派 {2}攻击城镇
    // {4}门派 {3}攻击京城/总舵" (world-situation chapter-intro block) rendering with several
    // fragments left untranslated ("势：", "击", "击城镇", "击 Capital/总舵") instead of using this
    // template's own "The great trend of the world..." translation at all.
    public static void RunWorldSituationRepro(string modDir)
    {
        Console.WriteLine();
        Console.WriteLine("=== RunWorldSituationRepro (2026-09-06 regression) ===");
        var entries = LoadModDictionaries(modDir);
        var dictionary = entries.Where(e => !e.IsTemplate).ToList();
        var templateEntries = entries.Where(e => e.IsTemplate).ToList();

        const string targetRaw = "天下大势：{4}{0}门派 {1}攻击资源{4}门派 {2}攻击城镇{4}门派 {3}攻击京城/总舵";
        var targetEntry = entries.FirstOrDefault(e => e.Raw == targetRaw);
        if (targetEntry == null) { Console.WriteLine("Target template entry not found!"); return; }
        Console.WriteLine($"Target result: {targetEntry.Result!.Replace("\n", "\\n")}");

        const string before = "第1章 蜀中仙云映霞光\n天下大势：\n全局恶名修正0%\n门派 不可攻击资源\n门派 不可攻击城镇\n门派 不可攻击京城/总舵";

        var compiled = BuildCompiledTemplateFull(targetEntry, sentenceBoundaryAware: true);
        if (compiled == null) { Console.WriteLine("Failed to compile target template."); return; }
        var compiledNonSba = BuildCompiledTemplateFull(targetEntry, sentenceBoundaryAware: false);
        Console.WriteLine($"Non-SBA permissive pattern matched: {compiledNonSba!.PermissivePattern.IsMatch(before)}");
        Console.WriteLine($"LiteralSegments: {string.Join(" | ", compiled.LiteralSegments.Select(s => s.Replace("\n", "\\n")))}");

        compiled.BlockingRawEntries = dictionary
            .Where(e => !string.IsNullOrEmpty(e.Raw)
                && compiled.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
            .Select(e => e.Raw)
            .Distinct()
            .ToList();
        Console.WriteLine($"BlockingRawEntries count: {compiled.BlockingRawEntries.Count}");
        foreach (var b in compiled.BlockingRawEntries)
            Console.WriteLine($"  blocking raw: \"{b.Replace("\n", "\\n")}\"");

        var literalsAllPresent = compiled.LiteralSegments.All(before.Contains);
        Console.WriteLine($"All literal segments present in 'before': {literalsAllPresent}");

        Console.WriteLine($"Strict pattern regex: {compiled.Pattern}");
        Console.WriteLine($"Permissive pattern regex: {compiled.PermissivePattern}");
        var strictMatch = compiled.Pattern.Match(before);
        Console.WriteLine($"Strict pattern matched: {strictMatch.Success}");
        var permissiveMatch = compiled.PermissivePattern.Match(before);
        Console.WriteLine($"Permissive pattern matched: {permissiveMatch.Success}");

        // Diagnostic: duplicate named group "p4" appears 3x in the raw ("{4}" used as a repeated
        // newline-separator token) - construct an equivalent pattern with UNIQUED group names to
        // see if the duplicate-name reuse itself is what breaks the match.
        var seen = new Dictionary<string, int>();
        var uniquedPatternText = Regex.Replace(compiled.PermissivePattern.ToString(), @"\(\?<(\w+)>", m =>
        {
            var name = m.Groups[1].Value;
            var count = seen.TryGetValue(name, out var c) ? c + 1 : 0;
            seen[name] = count;
            return $"(?<{name}_{count}>";
        });
        Console.WriteLine($"Uniqued pattern: {uniquedPatternText}");
        var uniquedPermissive = new Regex(uniquedPatternText, RegexOptions.Singleline);
        Console.WriteLine($"Uniqued-group-name permissive pattern matched: {uniquedPermissive.IsMatch(before)}");

        // Diagnostic: test each literal segment boundary incrementally to find where the whole
        // pattern stops matching, by testing progressively longer literal-only prefixes.
        var prefixPattern = new StringBuilder();
        var literalsSoFar = new List<string>();
        foreach (var seg in compiled.LiteralSegments)
        {
            literalsSoFar.Add(seg);
            prefixPattern.Append(Regex.Escape(seg)).Append(".*?");
            var partial = new Regex(prefixPattern.ToString(), RegexOptions.Singleline);
            Console.WriteLine($"  After literal \"{seg.Replace("\n", "\\n")}\": partial-prefix-regex matches 'before' = {partial.IsMatch(before)}");
        }
        if (permissiveMatch.Success)
        {
            Console.WriteLine($"  Match span: [{permissiveMatch.Index}, {permissiveMatch.Index + permissiveMatch.Length}) = \"{permissiveMatch.Value.Replace("\n", "\\n")}\"");
            var blocked = OverlapsBlockingEntry(before, permissiveMatch, compiled.BlockingRawEntries, out var culprit);
            Console.WriteLine($"  Blocked: {blocked}" + (blocked ? $" (culprit: \"{culprit!.Replace("\n", "\\n")}\")" : ""));
            if (!blocked)
                Console.WriteLine($"  Reconstructed replacement: \"{permissiveMatch.Result(compiled.ReplacementPattern).Replace("\n", "\\n")}\"");
        }

        // Full pipeline trace: build every template with the merged-run-aware builder, re-sort by
        // literal length (the actual PatchAll fix), then run ApplyTemplatesSinglePass end to end.
        Console.WriteLine();
        Console.WriteLine("--- Full ApplyTemplatesSinglePass trace (merged-run-aware, real order) ---");
        var compiledList = new List<(DictEntry Entry, CompiledTemplate Compiled)>();
        foreach (var t in templateEntries)
        {
            var c = BuildCompiledTemplateFull(t, sentenceBoundaryAware: true);
            if (c == null) continue;
            c.BlockingRawEntries = dictionary
                .Where(e => !string.IsNullOrEmpty(e.Raw)
                    && c.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                .Select(e => e.Raw)
                .Distinct()
                .ToList();
            compiledList.Add((t, c));
        }
        compiledList = compiledList.OrderByDescending(x => x.Compiled.LiteralSegments.Sum(s => s.Length)).ToList();

        var dictLongestFirstForWorldSituation = dictionary.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        var result = before;
        var fired = 0;
        foreach (var (entry, c) in compiledList)
        {
            if (c.LiteralSegments.Count > 0 && !c.LiteralSegments.All(result.Contains)) continue;

            var pattern = c.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = c.PermissivePattern;
                if (!pattern.IsMatch(result)) continue;
            }

            var beforeThis = result;
            result = pattern.Replace(result, m =>
                c.BlockingRawEntries.Count > 0 && OverlapsBlockingEntryTilingAware(beforeThis, m, c.BlockingRawEntries, dictLongestFirstForWorldSituation, out _)
                    ? m.Value
                    : m.Result(c.ReplacementPattern));

            if (result != beforeThis)
            {
                fired++;
                Console.WriteLine($"[{fired}] Template raw: \"{entry.Raw.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    before: \"{beforeThis.Replace("\n", "\\n")}\"");
                Console.WriteLine($"    after:  \"{result.Replace("\n", "\\n")}\"");
            }
        }
        Console.WriteLine($"Final result: \"{result.Replace("\n", "\\n")}\"");
    }
}
