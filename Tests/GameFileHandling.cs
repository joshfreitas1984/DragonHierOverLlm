using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Tests
{
    public static class GameFileHandling
    {
        public const string WorkingDirectory = "../../../../Files";
        public const string GameFolder = "G:\\SteamLibrary\\steamapps\\common\\LongYinLiZhiZhuan";

        // Game-specific placeholder handling: see docs/gamefilehandling-reference.md.
        private static readonly CompoundFieldSplitterOptions SplitterOptions = new()
        {
            PlaceholderPatterns = [new Regex(@"#\$?\w+#", RegexOptions.Compiled)]
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

        public static readonly TextFileToSplit[] TextFilesToSplit = [
            new() {Path = "AchievementData.csv", PackageOutput = true },
            // Skip-column rationale: docs/gamefilehandling-reference.md. Column 2 (类别/Category)
            // is exact-matched against the hardcoded literals "城市"/"村镇"/"门派" in
            // GameDataController's AreaData load loop - translating it breaks that check.
            new() {Path = "AreaData.csv", PackageOutput = true, SkipColumns = [2, 3] },
            new() {Path = "ArmorData.csv", PackageOutput = true },
            //new() {Path = "BookTypeIconData.csv", PackageOutput = true },
            // Columns 8/9/10/12 (每月产出/每月维护/加成/升级消耗 - Monthly production/
            // maintenance/Bonus/Upgrade consumption) are all Label<sign><number> cells matched via
            // String.Contains/String.Replace against a fixed resource-name list (and, for column
            // 10, also against forceSpeAddDataBase's label list) in GameDataController's
            // BuildingData load loop. Column 11 (增加效率/Increase efficiency) stores its
            // label half as AreaBuildingRateChange.targetBuildingName, a building-name lookup key.
            // Translating any of these breaks the corresponding lookup.
            new() {Path = "BuildingData.csv", PackageOutput = true, SkipColumns = [0, 1, 2, 3, 4, 5, 6, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18] },
            new() {Path = "FoodData.csv", PackageOutput = true },
            // Column 2 (行事风格/Operating style) is exact-matched against the hardcoded literal
            // "中庸" in ForceData.cs (String.Equals(this.forceStyle,"中庸",0)) to drive sect
            // behavior - translating it breaks that check, so it must stay raw alongside the
            // existing lookup/routing columns.
            new() {Path = "ForceData.csv", PackageOutput = true, SkipColumns = [1, 2, 9, 10, 11] },
            // Lookup-key column; see docs/gamefilehandling-reference.md.
            new() {Path = "ForceSpeAddDataBase.csv", PackageOutput = true, SkipColumns = [1] },
            new() {Path = "HeroNatureTalkText.csv", PackageOutput = true },
            new() {Path = "HeroSpeTalkText.csv", PackageOutput = true },
            // Every column skipped, including column 1 (名称/Name) - that column is itself the
            // exact-match lookup key SpeHeroData.csv's raw (untranslated) 标签/Tags column is
            // compared against via GameDataController.GetTagID, so it isn't real player-facing
            // text and must stay raw too (see docs/gamefilehandling-reference.md and
            // docs/skipcolumns-stringtospeadddata-family.md). Its actual display text is captured
            // separately for translation via DynamicStringColumnSources below.
            new() {Path = "HeroTagData.csv", PackageOutput = true, SkipColumns = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12] },
            new() {Path = "HorseData.csv", PackageOutput = true },
            new() {Path = "InnData.csv", PackageOutput = true },
            // Structured lookup-key columns; see docs/gamefilehandling-reference.md and
            // docs/spehero-relationship-and-skillfocus-crashes.md (column 3/Name is exact-matched
            // by GameDataController.GetSkillID against SpeHeroData.csv column 13's raw skill names).
            // Columns 17/18 (攻击架势/防御架势, Attack/Defense stance) are parsed by
            // PartPostureData's ctor via String.Contains against a fixed body-part vocabulary.
            // Column 23 (特效/Special effects) stores each fragment's label half as
            // SkillSpeEffectData.speName, exact-matched via String.Equals and used to build a
            // Resources.Load("SpeEffect/"+speName) asset path (BattleController.CreateSpeEffect).
            // Column 24 (使用武器/Use weapons) is exact-matched via the same FUN_1817ff280
            // dictionary lookup used elsewhere and concatenated into a
            // Resources.Load("武器/"+weaponName) asset path (HeroData.SetHeroWeapon/SetSkillWeapon).
            // Column 21 (动作/Action) is animationName, passed to SkeletonData.FindAnimation/
            // AnimationState.SetAnimation - an exact-match Spine animation clip name. Column 25
            // (伤害顺序/Order of damage dealt) is Enum.Parse'd into skillDamageOrder.
            new() {Path = "KungFuData.csv", PackageOutput = true, SkipColumns = [1, 3, 7, 8, 9, 10, 13, 17, 18, 21, 23, 24, 25] },
            //new() {Path = "LoveableSpeHero.csv", PackageOutput = true },
            new() {Path = "MartialClubData.csv", PackageOutput = true },
            new() {Path = "MedData.csv", PackageOutput = true },
            // Internal routing key; see docs/gamefilehandling-reference.md.
            new() {Path = "NameData.csv", PackageOutput = true, SkipColumns = [0] },
            new() {Path = "ResourcePointData.csv", PackageOutput = true },
            // Structured lookup-key columns; see docs/gamefilehandling-reference.md.
            new() {Path = "ResourcePointTypeData.csv", PackageOutput = true, SkipColumns = [2, 3, 4] },
            new() {Path = "SkinDataBase.csv", PackageOutput = true, SkipColumns = [2] },
            // Lookup-key column; see docs/gamefilehandling-reference.md.
            // Column 11 (特效价值类别/fightValueType) is exact-matched against "我方"/"敌方"/"伤害"
            // in HeroSpeAddDataBase.GetDescribe/GetTriggerDescribe/GetTargetDescribe. Columns 3/4
            // (正面词缀/负面词缀) and 10 (描述) are only concatenated for display, no lookup found.
            new() {Path = "SpeAddDataBase.csv", PackageOutput = true, SkipColumns = [1, 11] },
            // Only column 1 (名字/Name) is translated - every other column is a game-parsed
            // lookup/enum/numeric value (see docs/gamefilehandling-reference.md and
            // docs/spehero-relationship-and-skillfocus-crashes.md), including column 2
            // (性别/Gender, exact-matched against 男/女 - confirmed cause of the
            // GameController.GenerateHeroData ArgumentOutOfRangeException crash at new-game hero
            // generation when translated).
            //new() {Path = "SpeHeroData.csv", PackageOutput = true, SkipColumns = [0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20] },
            //new() {Path = "SpeHeroFaceData.csv", PackageOutput = true },
            new() {Path = "SummonData.csv", PackageOutput = true,  SkipColumns = [7]},
            // Structured lookup-key columns; see docs/gamefilehandling-reference.md.
            // Structured lookup-key columns; see docs/gamefilehandling-reference.md. Same schema
            // and shared GameDataController.LoadSkillData loader as KungFuData.csv, so columns
            // 17/18/21/23/24/25 are unsafe for the same reasons (see its comment above). Column 3
            // (名字/Name) IS safe here though - GetSkillID's name lookup only scans
            // kungfuSkillDataBase, not the summon variant, so summon skill names aren't matched
            // against SpeHeroData.csv column 13 like regular KungFuData.csv names are.
            new() {Path = "SummonKungFuData.csv", PackageOutput = true, SkipColumns = [1, 7, 8, 9, 10, 13, 17, 18, 21, 23, 24, 25] },
            // Column 4 (加成对象/Target for buff) is exact-matched via String.Equals against
            // ForceSpeAddDataBase.name (cross-file lookup key). Column 8 (消耗资源/Consume
            // resources) goes through the same FUN_1817ff280 name-lookup dictionary used for
            // force/weapon name resolution elsewhere. Column 1 (名称/Name) is only stored raw.
            new() {Path = "TechDataBase.csv", PackageOutput = true, SkipColumns = [4, 8] },
            new() {Path = "TipsData.csv", PackageOutput = true },
            new() {Path = "WeaponData.csv", PackageOutput = true },

            // Main dialogue table; column-specific repair is documented in the reference.
            // Columns 1/2/3/4/5/6/8 are non-narrative asset/routing keys, not display text:
            // - Columns 1/2 (角色左/角色右, speaker name) - NOT just a cosmetic display label as
            //   originally assumed: confirmed 2026-08-28 that both columns also encode a
            //   structured "临时:Name&Gender;Age;RelationLevel[;...]" temporary-NPC-spawn record
            //   (e.g. "临时:莺莺&女;24;0;4", "临时:侠客甲&男;20;-1;1") on many rows, parsed by
            //   the game at runtime to spawn a one-off NPC - translating the name/gender fragments
            //   inside that record risks breaking the parse. Genuine plain speaker names (no
            //   "临时:" prefix) are cosmetic-only, but the column can't be split further than
            //   whole-column, so the whole column is skipped. The unrelated hardcoded-name lookup
            //   hazard is still HardcodedHeroNamePatches.cs in DragonHeirPlugin (raw Chinese
            //   literals baked into GameController.cs's own compiled code, matched against
            //   WorldData.HerosDict which is keyed by SpeHeroData.csv's translated name column).
            // - Column 3 (高亮方/highlight side) exact-matched against "左"/"右"/"无"/"皆".
            // - Column 4 (背景图片/background image) - background sprite reference.
            // - Column 5 (背景音乐/background music) is concatenated/passed to
            //   BGMController.SetPlotBgm as a music asset name.
            // - Column 6 (播放音效/play sound effect) is concatenated into
            //   "Sound/SoundEffect/"+value (or "Sound/"+value for "Environment" cases) and passed
            //   to Resources.Load.
            // - Column 8 (调用函数/call function) is split on ';'/'-' and dispatched via
            //   Component.SendMessage(this, functionName, ...) - a reflection-based call by name.
            // Column 9 (选项/choices) stays translated - it's covered by the CustomColumnRepair/
            // CustomColumnValidator delimiter-preservation pattern above, not SkipColumns.
            new() {Path = "PlotData.csv", PackageOutput = true, SkipColumns = [1, 2, 3, 4, 5, 6, 7, 8] },

            // Flat prefab-text input; see docs/gamefilehandling-reference.md.
            new() {Path = "dumpedPrefabText.txt", PackageOutput = true, TextFileType = TextFileType.PrefabText },

            // Additional flat PrefabText source; see docs/gamefilehandling-reference.md.
            new() {Path = "dumpedPrefabTextFromOtherFields.txt", PackageOutput = true, TextFileType = TextFileType.PrefabText },

            // Flat IL2CPP dynamic-string input; see docs/gamefilehandling-reference.md.
            new() {Path = "dynamicStrings.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // Additional dynamic-string source; see docs/gamefilehandling-reference.md.
            new() {Path = "dynamicStringsFromColumns.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },
        ];

        // Whole-phrase raw display sources; see docs/gamefilehandling-reference.md.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringColumnSources =
        [
            ("ForceData.csv", [1]),
            // Column 5 (等级/position title, e.g. 掌门/副掌门) plus column 15 (绰号/nickname,
            // e.g. "无为真人") - since 2026-08-29. SpeHeroData.csv is fully commented out of
            // TextFilesToSplit (see the crash-avoidance note above that entry), so this file's
            // display text never reaches the normal per-row CSV pipeline at all; nicknames were
            // previously getting corrupted by DynamicStringPatches' bare single-character
            // dictionary entries (e.g. "无"->"None", "为"->"For" matching inside "无为真人",
            // producing "None For 真人") because no whole-phrase entry existed to win the
            // longest-match-first ordering. Extracting the whole nickname here fixes every hero
            // uniformly instead of manually patching one Raw value at a time.
            ("SpeHeroData.csv", [5, 15]),
            ("HeroTagData.csv", [1]),
            ("KungFuData.csv", [3]),
            // Column 2 (类别/Category) plus, since 2026-08-29, column 1 (名字/Name) - see the
            // defense-in-depth note below for why the name column was added.
            // Defense-in-depth (2026-08-29): column 1 on AreaData/ResourcePointData/
            // ResourcePointTypeData is already fully translated via the normal per-row CSV
            // pipeline (none of them SkipColumns it), so this isn't filling a coverage gap. It's a
            // safety net for runtime-composed strings that concatenate these names together
            // outside any single CSV row (e.g. an owner-prefixed resource-point display list like
            // "杭州甘泉" - AreaData.areaName + ResourcePointData.resourcePointName joined with
            // "\n") - those never flow through the CSV pipeline at all, only through
            // DynamicStringPatches' substring dictionary.
            ("AreaData.csv", [1, 2]),
            ("ResourcePointData.csv", [1]),
            ("ResourcePointTypeData.csv", [1]),
            ("BuildingData.csv", [1]),
        ];

        /// <summary>CSV columns containing structured labels used by dynamic-string extraction.</summary>
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringLabelColumnSources =
        [
            // 修炼效果/运功效果/威力系数/修炼需求/使用特效 - e.g. "内功1;经脉1", "生命上限20;内力上限20;内功4".
            ("KungFuData.csv", [7, 8, 9, 10, 13]),
            ("SummonKungFuData.csv", [7, 8, 9, 10, 13]),
            // 资源/加成/守城效果 - e.g. "威望+2,药材+1", "技艺经验0.01", "速度+0.05".
            ("ResourcePointTypeData.csv", [2, 3, 4]),
            // 加成效果 - e.g. "伤害0.02", "学识4".
            ("SkinDataBase.csv", [2]),
            // 每月产出/每月维护/加成/增加效率/升级消耗 - e.g. "威望+10", "银钱+100", "木匠-0.2;石坊-0.2".
            // Columns 8/9/10/12 match resource names against forceSpeAddDataBase's label list
            // (AreaBuildingDataBase.GetDescribe concatenates the raw label into the building info
            // panel); column 11's label is a cross-referenced building name
            // (AreaBuildingRateChange.targetBuildingName, concatenated by GetAreaBuildRateChangeText).
            ("BuildingData.csv", [8, 9, 10, 11, 12]),
        ];

        // Confirmed-safe MonoBehaviour fields for the exact-match PrefabText source.
        // The allowlist was sampled against real dumps; noisy/internal fields are intentionally absent.
        // Field selection and exact-match setter rationale: docs/gamefilehandling-reference.md.
        public static readonly string[] DynamicStringOtherTextFields =
        [
            "name", "eventName", "tutorialName", "showName", "bulletName", "fullName",
            "jobName", "spellName", "pointName", "sourceName", "plotName",
            "plotText", "tutorialText", "choiceText", "startRemindText", "describe",
            "eventDescribe", "jobDescribe",
        ];

        // Runtime setter behavior: docs/gamefilehandling-reference.md.

        // Extracts the repeated label from a structured stat modifier.
        private static readonly Regex StatLabelRegex = new(@"^[^\d+\-]+", RegexOptions.Compiled);



        /// <summary>Extracts configured whole values and structured labels idempotently.</summary>
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

                // Skip the header row.
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

        /// <summary>Extracts allowlisted dumped fields into the exact-match PrefabText input.</summary>
        public static void ExtractDynamicStringCandidatesFromOtherText(string workingDirectory)
        {
            var otherTextPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedOtherText.txt";
            if (!File.Exists(otherTextPath)) return;

            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabText.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabTextFromOtherFields.txt";

            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            var allowedFields = new HashSet<string>(DynamicStringOtherTextFields, StringComparer.OrdinalIgnoreCase);

            // Use dictionaries because the dumped-entry record has no parameterless constructor.
            var deserializer = YamlHelper.CreateDeserializer();
            var entries = deserializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(otherTextPath)) ?? [];

            var found = new List<string>();
            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("raw", out var raw) || string.IsNullOrWhiteSpace(raw)) continue;
                if (!entry.TryGetValue("field", out var field) || !allowedFields.Contains(field)) continue;
                if (!seen.Add(raw)) continue;

                found.Add(raw);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>Refreshes IL2CPP string-map candidates and appends new entries idempotently.</summary>
        public static void ExtractDynamicStringCandidatesFromIl2CppStringMap(string workingDirectory)
        {
            var converterDir = Path.GetFullPath(Path.Combine(workingDirectory, "..", "Converter"));
            var converterProjectPath = Path.Combine(converterDir, "Converter.csproj");
            var converterOutputDir = Path.Combine(converterDir, "output");
            var stringMapPath = Path.Combine(converterOutputDir, "_string_map.csv");

            if (!File.Exists(converterProjectPath) || !File.Exists(stringMapPath)) return;

            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStrings.txt";
            var candidatesPath = Path.Combine(converterOutputDir, "_dynamicStrings_candidates.txt");

            var psi = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = converterDir,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
            psi.ArgumentList.Add("run");
            psi.ArgumentList.Add("--no-build");
            psi.ArgumentList.Add("--");
            psi.ArgumentList.Add("--dynamic-string-candidates");
            psi.ArgumentList.Add("--output");
            psi.ArgumentList.Add(converterOutputDir);
            psi.ArgumentList.Add("--exclude-file");
            psi.ArgumentList.Add(Path.GetFullPath(masterDumpPath));

            try
            {
                using var process = Process.Start(psi);
                if (process == null) return;
                process.WaitForExit();
                if (process.ExitCode != 0 || !File.Exists(candidatesPath)) return;
            }
            catch
            {
                // Converter isn't built / dotnet isn't on PATH / etc. - fall back to whatever
                // candidates file (if any) already exists rather than failing the whole test run.
                if (!File.Exists(candidatesPath)) return;
            }

            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt";

            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            var found = File.ReadAllLines(candidatesPath)
                .Where(l => !string.IsNullOrEmpty(l))
                .Where(seen.Add)
                .ToList();

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

                var lines = File.ReadAllLines(file.FullName);

                var foundLines = new List<TranslationLine>();
                var lineIncrement = 0;

                foreach (var line in lines)
                {
                    lineIncrement++;

                    var splits = ParseCsvRow(line);
                    var foundSplits = new List<TranslationSplit>();
                    var foundTemplates = new List<FieldTemplate>();

                    // Decompose translatable cells and retain templates for structured cells.
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

        // Forced Result overrides for specific, known-problematic DynamicStringsIL2CPP Raw
        // templates, applied unconditionally at packaging time - see
        // ApplyDynamicStringResultOverrides. Keyed by the exact Raw string (not the translated
        // fragments), since the bug is in how CompoundFieldSplitter.Reconstruct glues translated
        // fragments directly against the "{n}" placeholders with no separator, not in the
        // fragment translations themselves (e.g. "年"->"Year" is a correct translation on its
        // own). "{0}年{1}月{2}日" (a save-slot date built via DateTime.ToString(), see
        // DynamicStringPatches.cs's _compiledTemplates comments) reconstructs to
        // "{0}Year{1}Month{2}Day" with no fix, producing unreadable output like
        // "1Year1Month17Day" - forced here to "{0} Year {1} Month {2} Day" instead.
        private static readonly Dictionary<string, string> DynamicStringResultOverrides = new()
        {
            ["{0}年{1}月{2}日"] = "{0} Year {1} Month {2} Day",
        };

        // Re-reads the just-packaged Files/Mod/{textFile.Path}.yaml and force-overwrites any
        // entry whose Raw matches DynamicStringResultOverrides, then rewrites the file. Runs
        // AFTER DynamicStringWorkflow.PackageDynamicStringsAsync on every packaging pass -
        // regardless of what's currently translated in Files/Converted - so a future re-export or
        // re-translation of this raw string can never silently regress the fix (editing the
        // Converted/Mod YAML directly, as done previously, gets undone the next time either step
        // re-runs).
        private static void ApplyDynamicStringResultOverrides(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var changed = false;
            foreach (var entry in results)
            {
                if (DynamicStringResultOverrides.TryGetValue(entry.Raw, out var forcedResult) && entry.Result != forcedResult)
                {
                    entry.Result = forcedResult;
                    changed = true;
                }
            }

            if (!changed)
                return;

            var serializer = YamlHelper.CreateSerializer();
            File.WriteAllText(modPath, serializer.Serialize(results));
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

            // Flat-text workflows are packaged separately from regular CSV files.
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

                // Force known-bad reconstructed template results regardless of whatever
                // translation currently sits in Files/Converted - see
                // DynamicStringResultOverrides for why this can't just be fixed by editing the
                // Converted/Mod YAML directly (re-export/re-translation would silently undo it).
                ApplyDynamicStringResultOverrides(workingDirectory, dynamicStringFile);
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

                        // Preserve skipped columns, including stale converted templates.
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

                            // Preserve skipped columns; a stale compound split must not overwrite the cell.
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

                    // Don't remove /n it makes lines even longer and less likely to wrap.
                    // if (textFileToTranslate.Path == "PlotData.csv" && splits.Length > 10)
                    //     splits[10] = splits[10].Replace("\\r\\n", " ").Replace("\\n", " ").Replace("\\r", " ");

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
