using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using System.Text.RegularExpressions;

namespace Tests
{
    public static class GameFileHandling
    {
        public const string WorkingDirectory = "../../../../Files";
        public const string GameFolder = "G:\\SteamLibrary\\steamapps\\common\\LongYinLiZhiZhuan";

        // This game wraps dynamic placeholder tokens in '#' (e.g. "#PlayerName#"). Their position
        // can move during translation, so they must be glued into whichever Chinese run they're
        // touching rather than treated as a fixed fragment boundary - see the "#PlayerName#" note
        // in tests-translation-workflow.instructions.md. This is opted in here, at the game level,
        // rather than baked into the shared CompoundFieldSplitter, since another game could just as
        // easily use '#' as a genuine structural separator.
        private static readonly CompoundFieldSplitterOptions SplitterOptions = new()
        {
            // '\$?' allows this game's '#$PlayerName#'/'#$SourceInteractName#'/'#$TargetInteractName#'
            // variants (a leading '$' inside the '#...#' wrapper) in addition to the plain
            // '#PlayerName#'/'#SourceForceName#' form - '\w' alone doesn't include '$', so without
            // this the '$'-prefixed tokens weren't recognized as placeholders at all.
            PlaceholderPatterns = [new Regex(@"#\$?\w+#", RegexOptions.Compiled)]
        };

        // Registers this game's LLM-result post-repair hook (see LineValidation.CustomPostRepair)
        // the first time GameFileHandling is touched - which every workflow test does, since they
        // all reference GameFileHandling.WorkingDirectory/TextFilesToSplit before kicking off a
        // translation run. This runs after every LLM call (including each retry/correction round)
        // and before CheckTransalationSuccessful validates the result, so a known, deterministic
        // LLM quirk can be fixed here instead of burning a retry round-trip.
        static GameFileHandling()
        {
            LineValidation.CustomPostRepair = RepairKnownLlmQuirks;
            LineValidation.CustomColumnRepair = RepairGameSpecificColumn;
            LineValidation.CustomColumnValidator = ValidateGameSpecificColumn;
        }

        // Matches an English possessive/contraction suffix the LLM sometimes glues inside a
        // "#PlaceholderToken#" wrapper instead of after it, e.g. "#PlayerName's#" - the placeholder
        // itself must stay exactly "#PlayerName#" (or "#$PlayerName#" for this game's '$'-prefixed
        // variants) for the game engine to substitute it at runtime, so the suffix needs to be moved
        // outside the closing '#' rather than sent back for a retry. '\$?' mirrors SplitterOptions'
        // PlaceholderPatterns regex so both token flavors get the same repair.
        private static readonly Regex PlaceholderTrailingSuffixRegex =
            new(@"#(\$?\w+)('s|'re|'ve|'ll|'d|'t)#", RegexOptions.Compiled);

        private static string RepairKnownLlmQuirks(string raw, string llmResult)
        {
            if (string.IsNullOrEmpty(llmResult))
                return llmResult;

            return PlaceholderTrailingSuffixRegex.Replace(llmResult, "#$1#$2");
        }

        // Per-file, per-column structural characters that can NEVER legitimately appear in a
        // translated fragment - see LineValidation.CustomColumnRepair's doc comment in
        // FanslationStudio.LlmKit for why this lives here (game-specific) rather than as a generic
        // repair in the shared library. CompoundFieldSplitter.Reconstruct only ever substitutes a
        // translated fragment positionally into "{n}" placeholders inside a fixed literal template
        // (see that method), so the template's own delimiter shape can never be corrupted by
        // whatever a fragment contains - the ONLY way structural corruption can happen is if a
        // fragment's own translated text contains one of the characters the template already uses
        // as a real separator elsewhere in the cell, since the game's own runtime CSV/choice parser
        // can't tell the difference between the two once they're substituted into the same string.
        //
        // PlotData.csv column 9 (选项/Choice): CompoundFieldSplitter keeps '|' (separates multiple
        // choice-options in one cell) and ';' (separates choiceText;callFuc;callParam;... within
        // one option - see GameDataController.SetChoiceDataTexts/SinglePlotChoiceData..ctor) as
        // literal template text, so a raw choiceText fragment for this column is always a single
        // isolated Chinese run with zero '|'/';' in it - there is no legitimate reason for either
        // character to appear in its translation. That means, unlike most translation-quality
        // problems, this one can be fixed deterministically rather than merely detected: strip any
        // '|'/';' the LLM introduces before the result is ever validated or saved, preventing the
        // desync in SetChoiceDataTexts's indexing at the source instead of relying on a retry loop
        // to eventually avoid it (the crash class documented in
        // tests-translation-workflow.instructions.md). Restricted to this exact file+column so a
        // legitimate '|'/';' elsewhere is never touched.
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

        // Backstop for ValidateGameSpecificColumn/RepairGameSpecificColumn: with the repair above in
        // place this should never actually trigger for PlotData.csv column 9 any more (the repair
        // already strips the only characters this checks for before validation ever runs), but it's
        // kept as defense-in-depth in case a future change to the repair/decompose logic causes a
        // count mismatch to slip through undetected.
        private static readonly char[] PlotChoiceValidationDelimiters = PlotChoiceStructuralDelimiters;

        // Applies to every file/column (unlike the PlotData.csv-scoped check below) - the built-in
        // placeholder-preservation check in LineValidation.CheckTransalationSuccessful only guards
        // curly-brace "{0}"-style placeholders (LineValidation.PlaceholderMatchPattern); it has no
        // awareness of this game's '#PlayerName#'/'#$SourceInteractName#'/'#$TargetInteractName#'
        // tokens at all, so without this an LLM silently dropping the whole token (or just its '$')
        // would pass validation unnoticed. One generic regex covers both the plain and '$'-prefixed
        // forms (mirrors SplitterOptions.PlaceholderPatterns) - no per-token special casing needed.
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

        public static readonly TextFileToSplit[] TextFilesToSplit = [
            new() {Path = "AchievementData.csv", PackageOutput = true },
            // Column 3 (图标 / icon) is a resource path, not user-facing text - never translate it.
            new() {Path = "AreaData.csv", PackageOutput = true, SkipColumns = [3] },
            new() {Path = "ArmorData.csv", PackageOutput = true },
            //new() {Path = "BookTypeIconData.csv", PackageOutput = true },
            new() {Path = "BuildingData.csv", PackageOutput = true },
            new() {Path = "FoodData.csv", PackageOutput = true },
            new() {Path = "ForceData.csv", PackageOutput = true },
            new() {Path = "ForceSpeAddDataBase.csv", PackageOutput = true },
            new() {Path = "HeroNatureTalkText.csv", PackageOutput = true },
            new() {Path = "HeroSpeTalkText.csv", PackageOutput = true },
            // Column 4 (效果 / effect: e.g. "力道潜力+5;力道+5") is a Label<sign><number> cell
            // whose Label half is looked up by GameDataController.StringToSpeAddData via an exact
            // String.Equals match against ForceSpeAddDataBase.csv's (also translated) label text -
            // translating both files independently can produce mismatched label wording, which
            // either silently fails the lookup (logged, harmless) or matches the wrong entry and
            // then throws an uncaught FormatException in Single.Parse, aborting the rest of
            // GameDataController.LoadAllGameData entirely (see dragonheirplugin.instructions.md's
            // "CONFIRMED root cause" section). Never translate this column.
            new() {Path = "HeroTagData.csv", PackageOutput = true, SkipColumns = [4] },
            new() {Path = "HorseData.csv", PackageOutput = true },
            new() {Path = "InnData.csv", PackageOutput = true },
            // Columns 7 (修炼效果/Training effect), 8 (运功效果/Skill effect), and 13
            // (使用特效/Use special effects) are all Label<sign><number>;Label<sign><number>;...
            // compound cells, e.g. "内功1;经脉1", "生命上限20;内力上限20;内功4;智力4;经脉4", and
            // "流血0.08" - each ';'-separated label is cross-referenced by exact String.Equals
            // against forceSpeAddDataBase/speAddDataBase (built independently from
            // ForceSpeAddDataBase.csv/SpeAddDataBase.csv, which we also translate) inside
            // GameDataController.StringToSpeAddData, called from LoadSkillData for every
            // KungFuData.csv/SummonKungFuData.csv row (confirmed via decompiling GameDataController
            // with Converter --filter "GameDataController" - LoadSkillData.c calls
            // StringToSpeAddData on columns 7, 8, AND 0xd/13 unconditionally). Column 13 is the one
            // that actually crashed a real playtest (see below) - columns 7/8 are always empty in
            // this game's actual CSV data, so they're harmless in practice, but are still skipped
            // since the game code treats them identically and there's no guarantee some rows won't
            // populate them. This is the exact same label-cross-reference hazard as HeroTagData.csv's
            // "效果" column and ResourcePointTypeData.csv's columns 2-4 (see
            // dragonheirplugin.instructions.md's "CONFIRMED root cause" section) - translating the
            // label text here independently from ForceSpeAddDataBase.csv/SpeAddDataBase.csv risks
            // the two ending up worded differently, which either fails the lookup harmlessly
            // (logged "StringToSpeAddData Error: ..." - the vanilla no-op case already seen in
            // BepInEx logs) or - observed via Player.log after a real playtest, on column 13 -
            // crashes GameDataController.LoadAllGameData outright with an uncaught
            // ArgumentException ("oldValue is the empty string") inside StringToSpeAddData's
            // regex-label-stripping step when a translated label's Chinese text got reduced to
            // nothing. Never translate these columns.
            //
            // Columns 9 (威力系数/Power ratio) and 10 (修炼需求/Cultivation requirement) are a
            // SEPARATE but analogous hazard: both are also Label<number>[;Label<number>...] cells
            // (e.g. "内功10", "轻功5") but are fed through GameDataController.StringToAttriRatio
            // instead of StringToSpeAddData - it splits on ';', regex-strips the label text from
            // each piece, then calls Single.Parse on whatever's left. Unlike StringToSpeAddData
            // (which catches the lookup failure and only logs "StringToSpeAddData Error: ..."),
            // StringToAttriRatio has NO try/catch around Single.Parse - if the label text doesn't
            // get fully stripped (near-certain once it's been translated to English, since the
            // regex targets the original Chinese label text), Single.Parse throws an uncaught
            // FormatException that kills LoadAllGameData with no exception logged to
            // BepInEx/LogOutput.log (only visible in Player.log) - confirmed via a real playtest
            // after the PlotData.csv column-9 fix let the load sequence progress this far. Must
            // stay untranslated for the same reason as columns 7/8/13.
            new() {Path = "KungFuData.csv", PackageOutput = true, SkipColumns = [7, 8, 9, 10, 13] },
            new() {Path = "LoveableSpeHero.csv", PackageOutput = true },
            new() {Path = "MartialClubData.csv", PackageOutput = true },
            new() {Path = "MedData.csv", PackageOutput = true },
            // Column 0 (类别 / category: 姓/名/男名/女名) is compared verbatim by the game's own
            // LoadAllGameData routing logic (String.Equals against hardcoded Chinese literals) to
            // decide which of familyNameDataBase/givenNameDataBase/maleGivenNameDataBase/
            // femaleGivenNameDataBase a row's names go into - translating it breaks that routing
            // silently (no crash, but every list stays empty since nothing matches).
            new() {Path = "NameData.csv", PackageOutput = true, SkipColumns = [0] },
            new() {Path = "ResourcePointData.csv", PackageOutput = true },
            // Columns 2, 3, and 4 all encode Label<sign><number>/Label+number compound cells whose
            // Label half is cross-referenced by exact string match against other (also translated)
            // data tables in GameDataController.LoadAllGameData:
            //   - Column 2 (资源 / Resources, e.g. "威望+2,药材+1"): each ','-separated item is
            //     split on '+' and the label looked up against an internal resource-type table.
            //   - Column 3 (加成 / Bonus, e.g. "技艺经验0.01"): ';'-separated labels matched via
            //     String.Equals against forceTechDataBase (built from TechDataBase.csv).
            //   - Column 4 (守城效果 / Defense effect): same StringToSpeAddData label lookup as
            //     HeroTagData.csv's effect column (see comment there).
            // All three must stay untranslated - see dragonheirplugin.instructions.md's "CONFIRMED
            // root cause" section for the LoadAllGameData abort this causes when translated.
            new() {Path = "ResourcePointTypeData.csv", PackageOutput = true, SkipColumns = [2, 3, 4] },
            new() {Path = "SkinDataBase.csv", PackageOutput = true, SkipColumns = [2] },
            new() {Path = "SpeAddDataBase.csv", PackageOutput = true },
            // Column 18 (关系设定/"Relationship setting", e.g. "朋友:2;亲属:7;仇人:65") is a
            // Label:ID;Label:ID;... compound cell where each Label (朋友/Friend, 亲属/Relatives,
            // 仇人/Enemy, 师父/Master, 结拜/Brotherhood by blood) is compared verbatim by the game's
            // own relationship-setup code to route the paired hero ID into the right
            // Friends/Relatives/Haters/Teacher/Brothers list on HeroData. Confirmed via a real
            // playtest: once this column got translated, Unity log showed a wave of non-fatal
            // "角色关系<TranslatedLabel>未设置" ("Character relationship <label> not set") Debug.Log
            // messages right after SpeHeroData.csv's override was applied - using the ALREADY-
            // TRANSLATED English label text embedded in the message, confirming the label lookup
            // is comparing against a fixed/hardcoded set of Chinese keywords (not another
            // translated CSV) and silently failing to route the relationship once translated. Same
            // class of bug as NameData.csv's SkipColumns=[0] (a cell value used as an internal
            // routing/lookup key, not just displayed) - not fatal like the StringToSpeAddData/
            // StringToAttriRatio cases, but real data loss (hero relationships never get set up).
            new() {Path = "SpeHeroData.csv", PackageOutput = true, SkipColumns = [18] },
            //new() {Path = "SpeHeroFaceData.csv", PackageOutput = true },
            new() {Path = "SummonData.csv", PackageOutput = true },
            // Same column layout/hazard as KungFuData.csv above (both loaded via
            // GameDataController.LoadSkillData, just with a different summon-skill flag) - columns
            // 7/8/13 (修炼效果/运功效果/使用特效) are label-cross-reference cells that must stay
            // untranslated. Column 13 is populated in nearly every row of this file and is what
            // actually crashed a real playtest (see the comment on KungFuData.csv above). Columns
            // 9/10 carry the same StringToAttriRatio fatal-FormatException hazard described there
            // too.
            new() {Path = "SummonKungFuData.csv", PackageOutput = true, SkipColumns = [7, 8, 9, 10, 13] },
            new() {Path = "TechDataBase.csv", PackageOutput = true },
            new() {Path = "TipsData.csv", PackageOutput = true },
            new() {Path = "WeaponData.csv", PackageOutput = true },

            // Main one
            // Column 9 (选项/Choice) is a compound field: '|'-separated choice options, each
            // further ';'-separated into choiceText;callFuc;callParam;... (see
            // GameDataController.SetChoiceDataTexts/SinglePlotChoiceData..ctor). CompoundFieldSplitter
            // already decomposes this correctly on its own - '|' and ';' are plain ASCII separators
            // it never absorbs into a fragment, so only the individual Chinese choiceText runs get
            // sent to the LLM and the delimiter structure survives as literal template text. The
            // real risk isn't the splitting itself, it's the LLM occasionally bleeding a literal
            // '|' into a translated fragment (e.g. explaining alternatives as "Option A | Option B"),
            // which would silently add an extra choice-option and desync SetChoiceDataTexts's
            // indexing - guarded against in LineValidation.CheckTransalationSuccessful's generic
            // '|' check (see that file) rather than by skipping this column outright.
            new() {Path = "PlotData.csv", PackageOutput = true },

            // Hardcoded UI/prefab text baked directly into MonoBehaviour/TMP_Text components
            // rather than a game-data CSV - see AssetDumperWorkflowTests.DumpChineseTextFromAssets,
            // which dumps this as one distinct Chinese string per line to
            // Files/Raw/Dumped/PrefabText/dumpedPrefabText.txt (m_Text/text fields only - every
            // other field found by that scan goes to the sibling dumpedOtherText.txt instead, which
            // is diagnostic-only and never fed into this pipeline). Handled by the generic,
            // game-agnostic FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow instead of the CSV
            // column-decomposition path above - there's no row/column structure here, each line IS
            // the whole translatable unit.
            new() {Path = "dumpedPrefabText.txt", PackageOutput = true, TextFileType = TextFileType.PrefabText },

            // Hardcoded, runtime-assembled string literal fragments baked directly into IL2CPP
            // game code (String.Concat/String.Format calls mixing Chinese literals with data).
            // Candidates are discovered offline/statically via Converter's
            // --dynamic-string-candidates mode (filters output/_string_map.csv for CJK values - no
            // game run needed) - see the "dynamic/hardcoded in-code string translation plan" repo
            // memory and DragonHeirPlugin/DynamicStringPatches.cs. Reviewed candidates are merged
            // into Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt, a flat list of one distinct
            // literal fragment per line, e.g. "架势". Handled by the generic
            // FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow (same flat-list mechanics as
            // PrefabTextWorkflow, kept as a distinct TextFileType/Workflow pair since the runtime
            // consumption model differs - see DynamicStringWorkflow's doc comment). The plugin
            // patches System.String.Concat/Format globally and applies the packaged raw/result
            // dictionary as a substring replace, so no per-method configuration is needed here.
            new() {Path = "dynamicStrings.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // Second, separately-sourced DynamicStringsIL2CPP file - see
            // ExtractDynamicStringCandidatesFromColumns/DynamicStringColumnSources below. Kept as
            // its own file (rather than merged into dynamicStrings.txt) purely so it's obvious
            // which entries were hand-curated from decompiled code vs. auto-pulled from CSV
            // columns - the runtime plugin loads every "dynamicStrings*.txt.yaml" file it finds
            // and merges them into one dictionary (see DynamicStringPatches.LoadDictionary), so
            // this needs no special handling anywhere else in the pipeline.
            new() {Path = "dynamicStringsFromColumns.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },
        ];

        // Declares which CSV columns hold whole-phrase display strings (force/sect names, hero
        // rank/tier tags, etc.) that are known to also get read "raw" by some IL2CPP code path
        // outside the normal per-column CSV translation (e.g. GameDataController.GetSaveInfo's
        // save-slot description embeds a force name and a rank tag straight from save data,
        // bypassing the already-translated ForceData/SpeHeroData lookups entirely - see the
        // save-slot mixed-language investigation in dragonheirplugin.instructions.md). Without an
        // explicit whole-phrase dictionary entry for these, DynamicStringPatches' bare
        // single-character fallback entries (e.g. "弟子" -> "Disciple", "情" -> "Qing") are the
        // only thing that can match, which mangles any compound word containing that character
        // (e.g. "外门弟子" -> "外门Disciple", "剧情" -> "剧Qing"). Column indices are 0-based and
        // match the raw CSV layout under Files/Raw/Dumped/GameData/ (i.e. before any
        // SkipColumns/decomposition is applied).
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringColumnSources =
        [
            // 名字 (name) - force/sect display name, e.g. "仙霞派".
            ("ForceData.csv", [1]),
            // 职位 (rank/tier tag) - e.g. "外门弟子", "亲传弟子", "掌门", "长老".
            ("SpeHeroData.csv", [5]),
        ];

        // Matches the LABEL portion of a "Label<sign><number>" stat-modifier item (e.g. "内功1",
        // "威望+2", "技艺经验0.01") - i.e. everything before the first digit or '+'/'-' sign. Used
        // by DynamicStringLabelColumnSources below for compound cells where the whole cell/item
        // isn't a stable, repeated piece of vocabulary (the number differs per row) but the label
        // is - unlike DynamicStringColumnSources' whole-value columns (force names, rank tags),
        // which are already a single discrete value with no numeric suffix to strip.
        private static readonly Regex StatLabelRegex = new(@"^[^\d+\-]+", RegexOptions.Compiled);

        /// <summary>
        /// Same purpose as DynamicStringColumnSources, but for columns whose cells are compound
        /// "Label&lt;sign&gt;&lt;number&gt;[;Label&lt;sign&gt;&lt;number&gt;...]" stat/resource
        /// modifiers (e.g. KungFuData.csv's "内功1;经脉1", ResourcePointTypeData.csv's
        /// "威望+2,药材+1") rather than a single discrete display value - these are exactly the
        /// SkipColumns entries in TextFilesToSplit above that are never translated because their
        /// Label half is cross-referenced by exact string match against another (also translated)
        /// table, per each SkipColumns comment. Extracting the WHOLE cell/item here would be
        /// useless (every row has a different number glued to the same label, e.g. "内功1" vs
        /// "内功4"), so this strips the numeric suffix via StatLabelRegex and keeps only the
        /// repeated Label vocabulary (e.g. "内功", "威望", "技艺经验") - guarding against the same
        /// bare-fragment corruption DynamicStringColumnSources targets, in case any of these
        /// labels are ever displayed raw (e.g. a tooltip built directly from this cell) bypassing
        /// the translated lookup table this column is intentionally left unlinked from.
        /// NameData.csv's SkipColumns=[0] ("类别": 姓/名/男名/女名) is deliberately NOT listed here
        /// - it's a pure internal routing key (which name list a row's names go into), never
        /// displayed to the player, so there's nothing to translate.
        /// </summary>
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringLabelColumnSources =
        [
            // 修炼效果/运功效果/威力系数/修炼需求/使用特效 - e.g. "内功1;经脉1", "生命上限20;内力上限20;内功4".
            ("KungFuData.csv", [7, 8, 9, 10, 13]),
            ("SummonKungFuData.csv", [7, 8, 9, 10, 13]),
            // 资源/加成/守城效果 - e.g. "威望+2,药材+1", "技艺经验0.01", "速度+0.05".
            ("ResourcePointTypeData.csv", [2, 3, 4]),
            // 加成效果 - e.g. "伤害0.02", "学识4".
            ("SkinDataBase.csv", [2]),
        ];

        /// <summary>
        /// Repeatable, config-driven alternative to manually grepping decompiled output for
        /// compound words that DynamicStringPatches' bare-fragment dictionary would otherwise
        /// mangle (see DynamicStringColumnSources' doc comment). For each configured
        /// (CsvFileName, Columns) pair, reads the corresponding raw CSV under
        /// Files/Raw/Dumped/GameData/, pulls out every distinct non-empty value from the
        /// specified columns (or, for DynamicStringLabelColumnSources, every distinct Label
        /// stripped from each ';'/','-separated compound item), and writes any that aren't
        /// already present in the master dynamicStrings.txt dump (or a previous run of this same
        /// method) to Files/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt - a flat
        /// one-entry-per-line dump in the exact same format
        /// DynamicStringWorkflow.ExportDynamicStringsToCustomFormat expects, so it flows through
        /// the existing "1c. ExportDynamicStringsIntoTranslated" / "2. MergeFilesIntoTranslated" /
        /// "6. Package to Game Files" steps unchanged. Safe to re-run at any time (e.g. after
        /// adding a new source entry) - already-extracted/dumped values are never duplicated.
        /// </summary>
        public static void ExtractDynamicStringCandidatesFromColumns(string workingDirectory)
        {
            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStrings.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt";

            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            var found = new List<string>();

            void ExtractFrom(string csvFileName, int[] columns, Func<string, IEnumerable<string>> valueExtractor)
            {
                var csvPath = $"{workingDirectory}/Raw/Dumped/GameData/{csvFileName}";
                if (!File.Exists(csvPath)) return;

                // Skip the header row (row 0) - every configured file here is a plain header+data
                // CSV, same as the main ExportGameSpecificTextAssetsToCustomFormat path.
                foreach (var line in File.ReadAllLines(csvPath).Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var fields = ParseCsvRow(line);
                    foreach (var column in columns)
                    {
                        if (column >= fields.Length) continue;

                        var cell = fields[column];
                        if (string.IsNullOrWhiteSpace(cell)) continue;

                        foreach (var value in valueExtractor(cell))
                        {
                            if (string.IsNullOrWhiteSpace(value)) continue;
                            if (!seen.Add(value)) continue;

                            found.Add(value);
                        }
                    }
                }
            }

            foreach (var (csvFileName, columns) in DynamicStringColumnSources)
                ExtractFrom(csvFileName, columns, cell => [cell]);

            foreach (var (csvFileName, columns) in DynamicStringLabelColumnSources)
            {
                ExtractFrom(csvFileName, columns, cell => cell
                    .Split([';', ','], StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => StatLabelRegex.Match(item).Value));
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        public static void ExportGameSpecificTextAssetsToCustomFormat(string workingDirectory)
        {
            string exportPath = $"{workingDirectory}/Raw/Export";
            string convertedPath = $"{workingDirectory}/Converted";

            if (!Directory.Exists(exportPath))
                Directory.CreateDirectory(exportPath);

            if (!Directory.Exists(convertedPath))
                Directory.CreateDirectory(convertedPath);

            var serializer = YamlHelper.CreateSerializer();
            var configByFileName = TextFilesToSplit.ToDictionary(t => t.Path, t => t);

            var dir = new DirectoryInfo($"{workingDirectory}/Raw/Dumped/GameData/");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                configByFileName.TryGetValue(file.Name, out var fileConfig);
                var skipColumns = fileConfig?.SkipColumns ?? [];

                //So far the game uses pure CSV files, so we can just read all lines and split by commas
                var lines = File.ReadAllLines(file.FullName);

                var foundLines = new List<TranslationLine>();
                var lineIncrement = 0;

                foreach (var line in lines)
                {
                    lineIncrement++;

                    var splits = ParseCsvRow(line);
                    var foundSplits = new List<TranslationSplit>();
                    var foundTemplates = new List<FieldTemplate>();

                    // Find Chinese fragments per column. A column may pack several fragments together
                    // with structural separators (';', '-', '&', '|', etc.) - e.g. BuildingData's
                    // action column - so we pull out each Chinese run individually and keep everything
                    // else (ids, delimiters, method names) in a template used to rebuild the cell later.
                    // Columns that are nothing but a single Chinese fragment (no surrounding structure)
                    // don't need a template at all - they're recorded as a plain whole-cell split.
                    // Columns listed in the file's SkipColumns (e.g. AreaData's icon column) are left
                    // completely untouched - never decomposed at all, regardless of what fragments
                    // they would otherwise have produced.
                    for (int i = 0; i < splits.Length; i++)
                    {
                        if (skipColumns.Contains(i))
                            continue;

                        var (template, fragments) = CompoundFieldSplitter.Decompose(splits[i], SplitterOptions);
                        if (fragments.Count == 0)
                            continue;

                        if (CompoundFieldSplitter.IsTrivialTemplate(template, fragments.Count))
                        {
                            foundSplits.Add(new TranslationSplit(i, 0, fragments[0]));
                            continue;
                        }

                        foundTemplates.Add(new FieldTemplate(i, template));

                        for (int f = 0; f < fragments.Count; f++)
                        {
                            foundSplits.Add(new TranslationSplit(i, f, fragments[f]));
                        }
                    }

                    //The translation line
                    foundLines.Add(new TranslationLine()
                    {
                        //LineNum = lineNum,
                        Raw = line,
                        Splits = foundSplits,
                        Templates = foundTemplates,
                    });
                }

                // Write the found lines
                var yaml = serializer.Serialize(foundLines);
                File.WriteAllText($"{exportPath}/{file.Name}.yaml", yaml);

                // Add missing converted file if it doesnt exist yet
                if (!File.Exists($"{convertedPath}/{file.Name}.yaml"))
                    File.Copy($"{exportPath}/{file.Name}.yaml", $"{convertedPath}/{file.Name}.yaml");
            }
        }

        public static void ExportPrefabTextAssetToCustomFormat(string workingDirectory)
        {
            foreach (var textFile in TextFilesToSplit.Where(t => t.TextFileType == TextFileType.PrefabText))
                PrefabTextWorkflow.ExportPrefabTextToCustomFormat(workingDirectory, textFile, SplitterOptions);
        }

        public static void ExportDynamicStringTextAssetToCustomFormat(string workingDirectory)
        {
            foreach (var textFile in TextFilesToSplit.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP))
                DynamicStringWorkflow.ExportDynamicStringsToCustomFormat(workingDirectory, textFile, SplitterOptions);
        }

        public static async Task PackageFinalTranslationAsync(string workingDirectory, TextFileToSplit[] textFiles)
        {
            string inputPath = $"{workingDirectory}/Converted";
            string outputPath = $"{workingDirectory}/Mod";

            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);

            Directory.CreateDirectory(outputPath);

            var finalDb = new List<string>();
            var passedCount = 0;
            var failedCount = 0;

            // PrefabText/DynamicStringsIL2CPP files have no CSV row/column structure to
            // reconstruct - ParseCsvRow below would misinterpret their plain-string Raw lines as
            // CSV cells. Package those through their own generic workflows instead, and only run
            // the CSV reconstruction loop against genuine RegularDb files.
            var csvTextFiles = textFiles
                .Where(t => t.TextFileType != TextFileType.PrefabText && t.TextFileType != TextFileType.DynamicStringsIL2CPP)
                .ToArray();
            var prefabTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.PrefabText);
            var dynamicStringFiles = textFiles.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP);

            foreach (var prefabTextFile in prefabTextFiles)
            {
                var (passed, failed) = await PrefabTextWorkflow.PackagePrefabTextAsync(workingDirectory, prefabTextFile);
                passedCount += passed;
                failedCount += failed;
            }

            foreach (var dynamicStringFile in dynamicStringFiles)
            {
                var (passed, failed) = await DynamicStringWorkflow.PackageDynamicStringsAsync(workingDirectory, dynamicStringFile);
                passedCount += passed;
                failedCount += failed;
            }

            await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
                csvTextFiles,
                async (outputFile, textFileToTranslate, fileLines) =>
            {
                var failedLines = new List<string>();
                var outputLines = new List<string>();

                foreach (var line in fileLines)
                {
                    // Regular DB handling
                    var splits = ParseCsvRow(line.Raw);
                    var failed = false;
                    var templatedColumns = line.Templates.Select(t => t.Split)
                        .Where(s => !textFileToTranslate.SkipColumns.Contains(s)).ToHashSet();

                    foreach (var template in line.Templates)
                    {
                        if (template.Split < 0 || template.Split >= splits.Length)
                            continue;

                        // Never reconstruct a column the file's config says to skip - splits[]
                        // already holds this column's original raw value from ParseCsvRow(line.Raw)
                        // above, which is exactly what we want to leave untouched. This guards
                        // against stale FieldTemplate/TranslationSplit entries left over in
                        // Files/Converted/*.csv.yaml from before a column was added to
                        // SkipColumns - without this check, a stale template would still get
                        // reconstructed here even though ExportGameSpecificTextAssetsToCustomFormat
                        // no longer produces new templates for skipped columns.
                        if (textFileToTranslate.SkipColumns.Contains(template.Split))
                            continue;

                        var fragments = line.Splits
                            .Where(s => s.Split == template.Split)
                            .OrderBy(s => s.SubIndex)
                            .ToList();

                        var translatedFragments = new List<string>();

                        foreach (var fragment in fragments)
                        {
                            if (!textFileToTranslate.PackageOutput
                                || fragment.FlaggedForRetranslation
                                || !fragment.SafeToTranslate) //Count Failure
                            {
                                failed = true;
                                break;
                            }

                            //Check line to be extra safe
                            //if (Regex.IsMatch(fragment.Translated, @"(?<!\\)\n"))
                            //    failed = true;
                            //else
                            if (!string.IsNullOrEmpty(fragment.Translated))
                                translatedFragments.Add(fragment.Translated);
                            //If it was already blank its all good
                            else if (!string.IsNullOrEmpty(fragment.Text))
                            {
                                failed = true;
                                break;
                            }
                            else
                                translatedFragments.Add(fragment.Text);
                        }

                        if (failed)
                            break;

                        splits[template.Split] = CompoundFieldSplitter.Reconstruct(template.Template, translatedFragments);
                    }

                    // Plain columns (whole cell is a single translatable fragment, no template needed)
                    if (!failed)
                    {
                        foreach (var split in line.Splits.Where(s => !templatedColumns.Contains(s.Split)))
                        {
                            if (split.Split < 0 || split.Split >= splits.Length)
                                continue;

                            // Never touch a column the file's config says to skip - splits[] already
                            // holds this column's original raw value from ParseCsvRow(line.Raw), which
                            // is exactly what we want. Assigning split.Text here (as opposed to
                            // skipping entirely) is unsafe for a compound/multi-fragment column: this
                            // loop runs once per TranslationSplit sub-fragment, so for a column with
                            // more than one fragment (e.g. a stale entry left over in
                            // Files/Converted/*.csv.yaml from before this column was added to
                            // SkipColumns) it would overwrite splits[] once per fragment, leaving only
                            // the last fragment's raw text instead of the whole original cell.
                            if (textFileToTranslate.SkipColumns.Contains(split.Split))
                                continue;

                            if (!textFileToTranslate.PackageOutput
                                || split.FlaggedForRetranslation
                                || !split.SafeToTranslate) //Count Failure
                            {
                                failed = true;
                                break;
                            }

                            if (!string.IsNullOrEmpty(split.Translated))
                                splits[split.Split] = split.Translated;
                            //If it was already blank its all good
                            else if (!string.IsNullOrEmpty(split.Text))
                            {
                                failed = true;
                                break;
                            }
                        }
                    }

                    line.Translated = RebuildCsvRow(splits);

                    if (!failed)
                    {
                        outputLines.Add(line.Translated);
                    }
                    else
                    {
                        outputLines.Add(line.Raw);
                        failedLines.Add(line.Raw);
                    }
                }


                File.WriteAllLines($"{outputPath}/{textFileToTranslate.Path}", outputLines);

                passedCount += outputLines.Count;
                failedCount += failedLines.Count;

                await Task.CompletedTask;
            });


            Console.WriteLine($"Passed: {passedCount}");
            Console.WriteLine($"Failed: {failedCount}");
        }
    }
}
