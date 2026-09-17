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
            CustomTranslationExclusionRule = GetDanglingColorTagOverride,
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

        // Hand-written overrides for dynamicStrings.txt raw templates where a literal closing tag
        // (e.g. "</color>") appears with no matching literal opening tag anywhere in the raw text -
        // meaning the opening tag is a runtime-computed game value substituted through one of the
        // "{n}" placeholders (see EnhanceUIController.cs's plVar7 argument array, decompiled: {0}/{2}
        // are dynamically chosen "<color=...>" tags picked by game code depending on whether a
        // requirement is met). No mechanical validator can ever verify a rewritten sentence keeps
        // that placeholder positioned correctly relative to the literal close - ordinary,
        // grammatically-correct word reordering during translation is indistinguishable from a
        // corruption that silently breaks the color span (confirmed in production: QC's correction
        // of the "提升强化等级至" Enhance-UI string dropped the literal "级</color>" off the end of its
        // first line entirely, see docs/gamefilehandling-reference.md). Every entry here keeps the
        // exact "{n}" placeholder order/position from raw - only the literal text between them was
        // translated - so the color tag pairing can never be disturbed by a future re-translation or
        // QC pass touching these lines, because SafeToTranslate=false (set by
        // GetDanglingColorTagOverride below, wired via CustomTranslationExclusionRule) keeps both the
        // LLM and QC from ever seeing them again. Candidates identified by scanning
        // Files/Converted/dynamicStrings*.yaml and Files/Converted/dumpedPrefabText*.yaml raw text
        // for "a {n} placeholder is present AND a literal closing tag has no matching literal opening
        // tag" - dumpedPrefabText* had zero matches, so every entry below is a dynamicStrings.txt raw
        // string. Keyed by the exact raw text (same convention as
        // Tests.TranslationPackaging.DynamicStringResultOverrides).
        private static readonly Dictionary<string, string> DanglingColorTagOverrides = new()
        {
            ["<b>门派特性</b>\n{1}{0}</color>"] = "<b>Sect Traits</b>\n{1} {0}</color>",
            ["<i>{2}(因超过{0}级，练习只获取{1}%经验！)</color></i>"] =
                "<i>{2} (Due to exceeding Level {0}, practice only grants {1}% experience!)</color></i>",
            ["{0}(已习得 第{1}重)</color>"] = "{0} (Already learned Tier {1})</color>",
            ["{0}<b>作恶导致禁用{1}个月</b></color>"] = "{0}<b>Banned for {1} months due to misconduct</b></color>",
            // Confirmed via QuickDetail.cs/decompile: {1} is a pre-concatenated "{skillName}{level}"
            // blob (e.g. "Qinggong 3") and {2} is a pass/fail color tag - the line reads "Requires:
            // <color>SkillName Level</color>", not literal "passing" (通行 = "passage/traversal" here,
            // a terrain-obstacle skill gate, not the English verb "pass").
            ["{0}\n通行{2}{1}</color>"] = "{0}\nRequires {2}{1}</color>",
            ["{0}{1}日</color>"] = "{0} {1} Day</color>",
            ["{0}同盟</color>"] = "{0} Alliance</color>",
            ["{0}宗主</color>"] = "{0} Sect Leader</color>",
            ["{0}已{1}至满级</color>"] = "{0} has {1} reached the level cap</color>",
            ["{0}已拥有</color>"] = "{0} is already owned</color>",
            ["{0}未拥有</color>"] = "{0} Not owned</color>",
            ["{0}本门</color>"] = "{0} This Sect</color>",
            ["{0}禁用{1}个月</color>"] = "{0} Banned for {1} months</color>",
            ["{0}终点</color>"] = "{0} Finish</color>",
            ["{0}耐药性 {1}%</color>"] = "{0} Drug resistance {1}%</color>",
            ["{0}耐药性{1}%</color>"] = "{0} Drug resistance {1}%</color>",
            ["{0}附庸</color>"] = "{0} Vassal</color>",
            ["{1}[有毒{0}]</color>"] = "{1}[Toxic {0}]</color>",
            ["{1}休战{0}日</color>"] = "{1} Truce {0} Days</color>",
            ["{1}困难{0}</color>"] = "{1} Difficulty {0}</color>",
            ["{1}守卫熟络{0}</color>"] = "{1} Guard familiarity {0}</color>",
            ["{1}守卫警戒{0}</color>"] = "{1} Guard alertness {0}</color>",
            ["{1}容易{0}</color>"] = "{1} Easy {0}</color>",
            ["{1}有毒 {0}</color>"] = "{1} Toxic {0}</color>",
            ["{1}极易{0}</color>"] = "{1} is very easy {0}</color>",
            ["{1}极难{0}</color>"] = "{1} Extremely difficult {0}</color>",
            ["{1}较易{0}</color>"] = "{1} Easier {0}</color>",
            ["{1}较难{0}</color>"] = "{1} More difficult {0}</color>",
            ["♦忠诚小于50时，每月有概率叛离门派。\n{1}每月叛离概率:{0}%</color>"] =
                "♦When loyalty is less than 50, there is a monthly chance of defecting from the Sect.\n{1} Monthly chance of defection: {0}%</color>",
            ["体力{0}</color>"] = "Stamina {0}</color>",
            ["内力{0}</color>"] = "Inner Power {0}</color>",
            ["因招募{4}{0}，所有门派对{1}{5}好感{2}</color>且全弟子{5}忠诚{3}</color>！"] =
                "Recruiting {4} {0} increases all sects' {1} {5} favorability by {2}</color> and all disciples' {5} loyalty by {3}</color>!",
            ["因门派银钱告罄，全弟子{0}忠诚-20</color>！"] =
                "Due to the sect's treasury being exhausted, all disciples' {0} loyalty -20</color>!",
            ["对方好感 60{1}(当前{0})</color>"] = "The other party's affinity 60 {1} (Current: {0})</color>",
            ["提升强化等级至+{6}\n{0}需要建筑等级 {1}级</color>\n{2}需要{5}技能 {3}</color>\n{4}"] =
                "Increase the enhancement level to +{6}\n{0}Requires building level {1}</color>\n{2}Requires {5} skill {3}</color>\n{4}",
            ["每月产出\n{2}{0}</color>\n\n周边效率+{1}%"] = "Monthly production\n{2} {0}</color>\n\nSurrounding efficiency+{1}%",
            ["特殊建筑 {0}({1}</color>)"] = "Special buildings {0} ({1}</color>)",
            ["生命{0}</color>"] = "Health {0}</color>",
            ["随机打通下{0}个穴位</color>"] = "Randomly unblock {0} acupoints</color>",
            ["随机揭示{0}个点</color>"] = "Randomly reveal {0} points</color>",
            ["需要:{2}{0}{1}</color>"] = "Need: {2} {0} {1}</color>",
            ["需要\n{0} {1}级</color>"] = "Need\n{0} {1} Level</color>",
            ["需要\n{0}人口 {1}</color>"] = "Need\n{0} Population {1}</color>",
            ["需要\n{0}弟子 {1}</color>"] = "Need\n{0} Disciple {1}</color>",
        };

        private static string? GetDanglingColorTagOverride(TextFileToSplit textFile, int? column, string raw)
        {
            if (textFile.TextFileType != TextFileType.DynamicStringsIL2CPP || string.IsNullOrEmpty(raw))
                return null;

            return DanglingColorTagOverrides.TryGetValue(raw, out var overrideResult) ? overrideResult : null;
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
