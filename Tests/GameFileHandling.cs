using FanslationStudio.LlmKit;
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
        public const string WorkingDirectory = "../../../../Files";
        public const string GameFolder = "G:\\SteamLibrary\\steamapps\\common\\LongYinLiZhiZhuan";

        // Game-specific placeholder handling: see docs/gamefilehandling-reference.md.
        internal static readonly CompoundFieldSplitterOptions SplitterOptions = new()
        {
            PlaceholderPatterns = [
                new Regex(@"#\$?\w+#", RegexOptions.Compiled),
                //new Regex(@"\{\d+\}", RegexOptions.Compiled), <- Dont split {0} placeholders - to test later with bigger model
            ]
        };

        // Register game-specific translation repair and validation hooks.
        static GameFileHandling()
        {
            LineValidation.CustomPostRepair = RepairKnownLlmQuirks;
            LineValidation.CustomColumnRepair = RepairGameSpecificColumn;
            LineValidation.CustomColumnValidator = ValidateGameSpecificColumn;
        }

        // Repairs possessive/contraction suffixes placed inside placeholder wrappers.
        private static readonly Regex PlaceholderTrailingSuffixRegex =
            new(@"#(\$?\w+)('s|'re|'ve|'ll|'d|'t)#", RegexOptions.Compiled);

        private static string RepairKnownLlmQuirks(string raw, string llmResult)
        {
            if (string.IsNullOrEmpty(llmResult))
                return llmResult;

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
        private static readonly Regex GamePlaceholderTokenRegex = new(@"#\$?\w+#", RegexOptions.Compiled);

        private static string? ValidateGameSpecificColumn(TextFileToSplit textFile, int? column, string raw, string result)
        {
            foreach (Match match in GamePlaceholderTokenRegex.Matches(raw))
            {
                if (!result.Contains(match.Value))
                    return match.Value;
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
