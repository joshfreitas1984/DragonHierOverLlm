using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests
{
    // Game-specific LLM repair/validation hooks and shared CSV helpers for this game's
    // translation pipeline. See docs/gamefilehandling-reference.md. The rest of the pipeline is
    // split across TextFileConfiguration, DynamicStringSources, DynamicStringExtraction,
    // TranslationExport, and TranslationPackaging.
    public static class GameFileHandling
    {
        public static readonly string WorkingDirectory = "../../../../Files";
        public static readonly string GameFolder = "G:\\SteamLibrary\\steamapps\\common\\LongYinLiZhiZhuan";

        // Game-specific placeholder handling: see docs/gamefilehandling-reference.md.
        internal static readonly CompoundFieldSplitterOptions SplitterOptions = new()
        {
            PlaceholderPatterns = [
                new Regex(@"#\$?\w+#", RegexOptions.Compiled),
                //new Regex(@"\{\d+\}", RegexOptions.Compiled), <- Dont split {0} placeholders - to test later with bigger model
            ]
        };

        // Game-specific translation repair/validation hooks, passed explicitly into every workflow
        // entry point that needs them (see call sites in TranslationWorkflowTests.cs etc.) instead
        // of being registered as a side effect of this type's static constructor running - the
        // previous approach silently left hooks unregistered whenever a test's only reference to
        // GameFileHandling was a field access rather than a method call.
        public static readonly GameHooks Hooks = new()
        {
            CustomPostRepair = RepairKnownLlmQuirks,
            CustomColumnRepair = RepairGameSpecificColumn,
            CustomColumnValidator = ValidateGameSpecificColumn,
        };

        // Repairs possessive/contraction suffixes placed inside placeholder wrappers.
        private static readonly Regex PlaceholderTrailingSuffixRegex =
            new(@"#(\$?[A-Za-z0-9_]+)('s|'re|'ve|'ll|'d|'t)#", RegexOptions.Compiled);

        // Repairs curly braces the LLM sometimes adds around this game's own #...# placeholder
        // tokens (e.g. "{#TargetInteractName#}" instead of "#TargetInteractName#") - see
        // docs/gamefilehandling-reference.md. This game doesn't use "{name}"-style placeholders at
        // all, so any brace-wrapped "#...#" token is always an LLM artifact, never legitimate text.
        private static readonly Regex BraceWrappedPlaceholderTokenRegex =
            new(@"\{(#\$?[A-Za-z0-9_]+#)\}", RegexOptions.Compiled);

        private static string RepairKnownLlmQuirks(string raw, string llmResult)
        {
            if (string.IsNullOrEmpty(llmResult))
                return llmResult;

            llmResult = BraceWrappedPlaceholderTokenRegex.Replace(llmResult, "$1");
            llmResult = PlaceholderTrailingSuffixRegex.Replace(llmResult, "#$1#$2");

            // Restore recognizable tokens when the LLM drops a '$', delimiter, or wrapper.
            foreach (Match match in GamePlaceholderTokenRegex.Matches(raw))
            {
                if (llmResult.Contains(match.Value))
                    continue;

                var coreName = match.Value.Trim('#').TrimStart('$');

                // Optional delimiters and word boundaries avoid matching a larger identifier.
                var corruptedTokenRegex = new Regex($@"#?\$?\b{Regex.Escape(coreName)}\b#?", RegexOptions.Compiled);
                var corruptedMatch = corruptedTokenRegex.Matches(llmResult)
                    .Cast<Match>()
                    .FirstOrDefault(m => m.Value != match.Value);

                if (corruptedMatch != null)
                    // Insert literally because a valid replacement token may contain '$'.
                    llmResult = llmResult.Remove(corruptedMatch.Index, corruptedMatch.Length).Insert(corruptedMatch.Index, match.Value);
            }

            // corruptedTokenRegex above only re-inserts the '#...#' wrapper around the bare name -
            // it doesn't consume any brace the LLM wrapped around that bare name (e.g. GLM4 turning
            // "#TargetInteractName#" into "{TargetInteractName}", where the '#'s were dropped AND
            // braces were added). That leaves a hybrid "{#TargetInteractName#}" behind, exactly the
            // shape the very first replace above targets - re-running it here cleans up any such
            // case the restore loop just (re)introduced.
            llmResult = BraceWrappedPlaceholderTokenRegex.Replace(llmResult, "$1");

            return llmResult;
        }

        // PlotData column 9 repair details: docs/gamefilehandling-reference.md.
        private static readonly char[] PlotChoiceStructuralDelimiters = ['|', ';'];

        private static string RepairGameSpecificColumn(TextFileToSplit? textFile, int? column, string raw, string result)
        {
            if (textFile?.Path == "PlotData.csv" && column == 9)
            {
                foreach (var delimiter in PlotChoiceStructuralDelimiters)
                    result = result.Replace(delimiter.ToString(), string.Empty);
            }

            return result;
        }

        // Defense-in-depth delimiter validation for PlotData column 9.
        private static readonly char[] PlotChoiceValidationDelimiters = PlotChoiceStructuralDelimiters;

        // Preserve this game's #...# placeholders; see docs/gamefilehandling-reference.md.
        // Restricted to ASCII identifier characters, not the Unicode-aware "\w" .NET regex uses by
        // default - a genuine engine placeholder (#PlayerName#, #TargetInteractName#, etc.) is
        // always an English field name, so requiring ASCII-only content excludes a raw string that
        // merely happens to be Chinese text wrapped in literal '#' characters (e.g. "#反馈#"/"Feedback"
        // as a hashtag-style dialogue label, "#英文双引号#" as a standalone dumped string) - those are
        // ordinary translatable text, not a value the engine substitutes at runtime, and requiring
        // them to survive byte-identical was a false positive.
        private static readonly Regex GamePlaceholderTokenRegex = new(@"#\$?[A-Za-z0-9_]+#", RegexOptions.Compiled);

        // Broader than GamePlaceholderTokenRegex - Unicode-aware "\w" like this game's original
        // (pre-ASCII-restriction) pattern, so it also counts a "#...#"-shaped span whose content is
        // Chinese (e.g. "#反馈#", "#英文双引号#") as one structural placeholder-shaped span. Used only
        // to size the "how many hash-wrapped spans is this result allowed to contain" budget below -
        // raw content is always Chinese-or-mixed at this stage, so counting only ASCII-named spans in
        // raw would make every genuine translation of a Chinese "#...#" label look like an invented
        // extra token, since its *translated* form is unavoidably ASCII.
        private static readonly Regex AnyHashWrappedSpanRegex = new(@"#\$?\w+#", RegexOptions.Compiled);

        private static string? ValidateGameSpecificColumn(TextFileToSplit textFile, int? column, string raw, string result)
        {
            foreach (Match match in GamePlaceholderTokenRegex.Matches(raw))
            {
                if (!result.Contains(match.Value))
                    return match.Value;
            }

            // Defense-in-depth: the LLM has also been observed duplicating a placeholder token
            // (or introducing an unrelated one, e.g. adding "#PlayerName#" alongside the source's
            // "#TargetInteractName#") rather than dropping it. Compare total span *counts* (raw via
            // the broad, content-agnostic regex; result via the ASCII-only one, since translated
            // text is English) rather than per-exact-string counts - a raw "#反馈#"/"#英文双引号#"
            // label legitimately translates into one ASCII "#Feedback#"/"#English Double..."
            // span with different text, which a per-string count comparison would wrongly flag as
            // an extra/invented token even though the overall span budget is unchanged.
            var rawSpanCount = AnyHashWrappedSpanRegex.Matches(raw).Count;
            var resultTokenMatches = GamePlaceholderTokenRegex.Matches(result).Cast<Match>().ToList();

            if (resultTokenMatches.Count > rawSpanCount)
            {
                // Name the most actionable offender: a token with no literal occurrence anywhere in
                // raw (most likely a genuinely hallucinated/duplicated placeholder) if one exists,
                // otherwise fall back to the last matched token.
                var unaccountedToken = resultTokenMatches
                    .Select(m => m.Value)
                    .FirstOrDefault(v => !raw.Contains(v))
                    ?? resultTokenMatches[^1].Value;

                return unaccountedToken;
            }

            if (textFile.Path == "PlotData.csv" && column == 9)
            {
                foreach (var delimiter in PlotChoiceValidationDelimiters)
                {
                    var rawCount = raw.Count(c => c == delimiter);
                    var resultCount = result.Count(c => c == delimiter);

                    if (resultCount != rawCount)
                        return delimiter.ToString();
                }
            }

            return null;
        }

        public static string[] ParseCsvRow(string line) => CompoundFieldSplitter.ParseCsvRow(line);

        public static string RebuildCsvRow(IEnumerable<string> fields) => CompoundFieldSplitter.RebuildCsvRow(fields);

        // Strips a trailing comma (and any trailing whitespace) from a translated cell - see the
        // call site in TranslationPackaging.PackageFinalTranslationAsync for why a comma directly
        // before RebuildCsvRow's closing quote is unsafe for this game's own CSV reader. Internal
        // (not private) so FileValidationTests can exercise it directly.
        internal static string StripTrailingCommaBeforeQuote(string field)
        {
            if (string.IsNullOrEmpty(field))
                return field;

            var trimmed = field.TrimEnd();
            return trimmed.EndsWith(',') ? trimmed.TrimEnd(',').TrimEnd() : field;
        }
    }
}
