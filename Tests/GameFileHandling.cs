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
            CustomQcExclusionRule = (textFile, column, raw) =>
                ExcludeFunctionRoutedDynamicStringFromQc(textFile, column, raw) ||
                ExcludePlotChoiceColumnFromQc(textFile, column, raw),
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

        // Excludes this game's function-routed dynamic-string choice/dialogue entries from the QC
        // pass - see docs/gamefilehandling-reference.md. Raw/effective-translated shape is always
        // "{choiceText};FunctionName" (confirmed via decompile, e.g. PlotController.cs's hardcoded
        // "出手抢夺;RobNPCItemSure"), the same ';'-suffixed convention DynamicStringPatches.cs's own
        // LoadDictionary already uses to derive a bare-label dictionary entry. A QC model has no
        // way to know 'FunctionName' is an opaque runtime identifier rather than text to
        // rewrite/"fix", and unlike PlotData.csv column 9 there is no CustomColumnValidator
        // registered here to catch a corrupted ';' count in a proposed correction - excluding these
        // columns from ever becoming a QC work item is cheaper and safer than reviewing them.
        // Scoped to the DynamicStringsIL2CPP file family (not a single path) since the ';'-suffix
        // convention is a property of that pipeline's raw dumps, not any one specific file - a
        // literal ASCII ';' essentially never appears in ordinary dumped Chinese text otherwise.
        private static bool ExcludeFunctionRoutedDynamicStringFromQc(TextFileToSplit textFile, int? column, string raw)
        {
            if (textFile.TextFileType != TextFileType.DynamicStringsIL2CPP || string.IsNullOrEmpty(raw))
                return false;

            var semiIndex = raw.IndexOf(';');
            return semiIndex > 0;
        }

        // Excludes PlotData.csv column 9 (the interaction-choice column, see
        // plotdata-column9-crash-and-repair-pattern.md) from the QC pass - same rationale as
        // ExcludeFunctionRoutedDynamicStringFromQc above, applied here because this column has the
        // same "machine record, not prose" shape. During ordinary translation this column is safe:
        // CompoundFieldSplitter decomposes each cell into its individual choiceText fragments (never
        // '|'/';' themselves), translates only those, and RepairGameSpecificColumn/
        // ValidateGameSpecificColumn guard each fragment/reconstructed cell against a leaked
        // delimiter. But the QC review pass hands the model the whole reconstructed cell - e.g.
        // "内功 吐纳法;ForceFightChooseStartSkill;0|轻功 轻身术;ForceFightChooseStartSkill;1" - as one
        // block of text to "improve" rather than fragment-by-fragment, and a model asked to smooth a
        // multi-choice blob like that into fluent prose reliably drops every '|'/';' it contains.
        // ValidateGameSpecificColumn's delimiter-count check already prevents that corrupted
        // correction from ever being accepted (confirmed via a real triage cluster: every proposed
        // correction for this shape was rejected for the same reason, the count mismatch on '|'),
        // so no data gets corrupted either way - but every such entry keeps generating a QC work
        // item that is guaranteed to fail, forever. Cheaper and safer to keep them out of the QC
        // queue entirely, same as the DynamicStringsIL2CPP case above.
        private static bool ExcludePlotChoiceColumnFromQc(TextFileToSplit textFile, int? column, string raw)
        {
            if (textFile.Path != "PlotData.csv" || column != 9 || string.IsNullOrEmpty(raw))
                return false;

            return raw.IndexOfAny(PlotChoiceStructuralDelimiters) > 0;
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
