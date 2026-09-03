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
            new() {Path = "BuildingData.csv", PackageOutput = true, SkipColumns = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18] },
            new() {Path = "FoodData.csv", PackageOutput = true, SkipColumns = [1, 15]  },
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
            new() {Path = "HorseData.csv", PackageOutput = true, SkipColumns = [1] },
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
            new() {Path = "KungFuData.csv", PackageOutput = true, SkipColumns = [1, 3, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28] },
            //new() {Path = "LoveableSpeHero.csv", PackageOutput = true },
            new() {Path = "MartialClubData.csv", PackageOutput = true },
            new() {Path = "MedData.csv", PackageOutput = true, SkipColumns = [1, 15] },
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
            new() {Path = "SummonKungFuData.csv", PackageOutput = true, SkipColumns = [1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28] },
            // Column 4 (加成对象/Target for buff) is exact-matched via String.Equals against
            // ForceSpeAddDataBase.name (cross-file lookup key). Column 8 (消耗资源/Consume
            // resources) goes through the same FUN_1817ff280 name-lookup dictionary used for
            // force/weapon name resolution elsewhere. Column 1 (名称/Name) is only stored raw.
            new() {Path = "TechDataBase.csv", PackageOutput = true, SkipColumns = [4, 8] },
            new() {Path = "TipsData.csv", PackageOutput = true },
            new() {Path = "WeaponData.csv", PackageOutput = true, SkipColumns = [1] },

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

            // ';'-joined structured-record fragments parsed out of dynamicStrings.txt - split into
            // its own file (was previously mixed into dynamicStringsFromColumns.txt) so each
            // dynamic-string file's provenance is unambiguous. See
            // ExtractStructuredRecordFragmentCandidates.
            new() {Path = "dynamicStringsFromStructuredFragments.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // Stat-label fragments parsed out of dumpedOtherText.txt (e.g. "spellEffectString")
            // - split into its own file (was previously mixed into dynamicStringsFromColumns.txt).
            // See ExtractOtherFieldLabelCandidates.
            new() {Path = "dynamicStringsFromOtherFieldLabels.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // Poetry minigame ("对诗" fill-in-the-blank) candidates extracted directly from the
            // JSON TextAsset/PoetryData.txt - see PoetryDataWorkflow.ExtractPoetryCandidates.
            new() {Path = "dynamicStringsPoetry.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // Banquet/drinking minigame poem-quote comma-split halves - see
            // DrinkQuoteWorkflow.ExtractDrinkQuoteCandidates.
            new() {Path = "dynamicStringsDrinkQuotes.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },

            // SpeHeroData family/given-name halves - a DEDICATED file, deliberately NOT named
            // "dynamicStrings*" so it never matches DynamicStringPatches' DictionaryFilePattern
            // glob and never gets merged into that plugin's global substring-replace dictionary
            // (a bare one/two-character surname is far too easy to accidentally match as a
            // substring of unrelated Chinese text elsewhere in the game). Reuses the same
            // DynamicStringsIL2CPP export/translate/package plumbing (see DynamicStringWorkflow -
            // it is generic over TextFileToSplit.Path, nothing here is hardcoded to "dynamicStrings"
            // specifically), but the packaged heroNameParts.txt.yaml is loaded and applied ONLY by
            // HeroNamePatches' own private, exact-match dictionary - see HeroNamePatches.cs.
            new() {Path = "heroNameParts.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP },
        ];

        // Whole-phrase raw display sources; see docs/gamefilehandling-reference.md.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringColumnSources =
        [
            ("AreaData.csv", [1, 2]),
            ("BuildingData.csv", [1]),
            ("FoodData.csv", [1, 15]),
            ("ForceData.csv", [1, 2, 9, 10, 11]),
            ("ForceSpeAddDataBase.csv", [1]),
            ("HorseData.csv", [1]),
            ("HeroTagData.csv", [1, 5, 6, 7, 10, 11]),
            ("KungFuData.csv", [3, 7, 8, 9, 10, 13, 17, 18, 24]),
            ("MedData.csv", [1, 15]),
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
            ("ResourcePointData.csv", [1]),
            ("ResourcePointTypeData.csv", [1]),
            ("SpeAddDataBase.csv", [1, 11]),
            // Column 5 (等级/position title, e.g. 掌门/副掌门) plus column 15 (绰号/nickname,
            // e.g. "无为真人") - since 2026-08-29. SpeHeroData.csv is fully commented out of
            // TextFilesToSplit (see the crash-avoidance note above that entry), so this file's
            // display text never reaches the normal per-row CSV pipeline at all; nicknames were
            // previously getting corrupted by DynamicStringPatches' bare single-character
            // dictionary entries (e.g. "无"->"None", "为"->"For" matching inside "无为真人",
            // producing "None For 真人") because no whole-phrase entry existed to win the
            // longest-match-first ordering. Extracting the whole nickname here fixes every hero
            // uniformly instead of manually patching one Raw value at a time.
            ("SpeHeroData.csv", [1, 2, 3, 4, 5, 6, 7, 8, 10, 11, 12, 14, 15, 18]),
            ("SummonKungFuData.csv", [1, 13, 24]),
            ("TechDataBase.csv", [4, 8]),
            ("WeaponData.csv", [1]),

            // ExploreController-embedded lists (Road/Plane/Forest/Mountain/River ground names,
            // per-tile event/content type names, per-map biome flavor names) - not loaded via any
            // Resources.Load(TextAsset) call, so there's no override load-point for the normal
            // row-based CSV pipeline. Dumped live at runtime by
            // DragonHeirPlugin/ExploreDataDumpPatches.cs into these same GameData-shaped raw CSVs
            // purely so this column-source extractor can read them; only ever consumed as
            // dynamic-string dictionary entries, never packaged/repackaged as a CSV file.
            ("ExploreTileGroundDataBase.csv", [0]),
            ("ExploreTileTypeDataBase.csv", [0]),
            ("ExploreMapTypeDataBase.csv", [0]),
        ];

        /// <summary>CSV columns containing structured labels used by dynamic-string extraction.</summary>
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringLabelColumnSources =
        [
            // 每月产出/每月维护/加成/增加效率/升级消耗 - e.g. "威望+10", "银钱+100", "木匠-0.2;石坊-0.2".
            // Columns 8/9/10/12 match resource names against forceSpeAddDataBase's label list
            // (AreaBuildingDataBase.GetDescribe concatenates the raw label into the building info
            // panel); column 11's label is a cross-referenced building name
            // (AreaBuildingRateChange.targetBuildingName, concatenated by GetAreaBuildRateChangeText).
            // Column 7 (互动选项) is NOT a Label<sign><number> cell - see
            // DynamicStringInteractionOptionColumnSources below for its own extractor.
            ("BuildingData.csv", [3, 8, 9, 10, 11, 12]),
            ("HeroTagData.csv", [9]),
            // 修炼效果/运功效果/威力系数/修炼需求/使用特效 - e.g. "内功1;经脉1", "生命上限20;内力上限20;内功4".
            ("KungFuData.csv", [7, 8, 9, 10, 13]),
            // 资源/加成/守城效果 - e.g. "威望+2,药材+1", "技艺经验0.01", "速度+0.05".
            ("ResourcePointTypeData.csv", [2, 3, 4]),
            // 加成效果 - e.g. "伤害0.02", "学识4".
            ("SkinDataBase.csv", [2]),
            ("SpeHeroData.csv", [11, 12, 14, 18]),
            ("SummonKungFuData.csv", [13]),
        ];

        // CSV columns holding a "."-joined compound value where each half needs its own standalone
        // translated entry, not just the whole joined string. SpeHeroData.csv column 1 (名字/Name,
        // e.g. "姜.映泉") is the only known case: GameDataController strips the "." separator when
        // loading the row into HeroData, storing the family-name half in HeroData.heroFamilyName
        // ("姜") and the full name (family+given, no dot) in HeroData.heroName - so a dictionary
        // entry for the whole dotted string (already extracted via DynamicStringColumnSources
        // above) never matches anything at runtime; the family name and given name need to exist
        // as their own raw candidates so GameController.GetHeroName's relation-title concatenation
        // (see DragonHeirPlugin/HeroNamePatches.cs) and its bare given-name "former lover" case can
        // translate each part independently. Consumed by ExtractHeroNamePartCandidates, which
        // writes into the dedicated heroNameParts.txt file (NOT dynamicStringsFromColumns.txt) -
        // see that TextFileToSplit entry's comment for why these must stay out of the global
        // DynamicStringPatches substring-replace dictionary.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringNamePartColumnSources =
        [
            ("SpeHeroData.csv", [1]),
        ];

        // BuildingData.csv column 7 (互动选项/Interactive options) holds ';'-separated items shaped
        // like "Name?Description-Condition-TriggerId" (description optional, e.g. "交易--
        // ShowBuildingShop" has none) where AreaBuildingDataBase concatenates Name (and, when
        // present, Description) into the building's clickable option list shown to the player;
        // Condition (我/非我/敌/长老/... combined with &/|) and TriggerId are internal routing
        // never displayed raw. This doesn't fit the Label<sign><number> shape handled by
        // DynamicStringLabelColumnSources, so it gets its own extractor
        // (InteractionOptionRegex) that pulls just Name and Description.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringInteractionOptionColumnSources =
        [
            ("BuildingData.csv", [7]),
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

        // "startCallSpeFuc"'s raw shape is a speFuc call convention (like tutorialSpeFuc/
        // clickCallFuc/callParam), not plain display text: "PlotGetNewMail;<HeroName>-<Message>
        // [-true]". Only the embedded <Message> is real, untranslated player-facing text (shown
        // in a mail notification); the hero name and optional trailing "-true" flag must stay
        // untouched, so this field is deliberately absent from DynamicStringOtherTextFields above
        // and handled via structured extraction instead - see ExtractDynamicStringCandidatesFromOtherText.
        private static readonly Regex PlotGetNewMailRegex =
            new(@"^PlotGetNewMail;[^-]+-(.+?)(?:-true)?$", RegexOptions.Compiled);

        // "spellEffectString"'s raw shape is "<CJK label><signed number>" with no delimiter (e.g.
        // "伤害-0.04"), the same shape DynamicStringLabelColumnSources already extracts from CSV
        // columns via StatLabelRegex below. Only the label is translatable text.
        private static readonly string[] DynamicStringLabelOtherTextFields = ["spellEffectString"];

        // Runtime setter behavior: docs/gamefilehandling-reference.md.

        // Extracts the repeated label from a structured stat modifier.
        private static readonly Regex StatLabelRegex = new(@"^[^\d+\-]+", RegexOptions.Compiled);

        // Extracts the Name (group 1) and optional Description (group 3) from a
        // "Name?Description-Condition-TriggerId" interactive-option item.
        private static readonly Regex InteractionOptionRegex = new(@"^([^?\-]+)(\?([^-]*))?-", RegexOptions.Compiled);

        // Identifies a bare ASCII PascalCase/camelCase field (e.g. "HospitalCureExternalInjury",
        // "AskHeroMakeFriend") - the game's own internal trigger/event routing id. Used as a
        // heuristic signal (see ExtractStructuredRecordFragmentCandidates) that a ';'-joined
        // IL2CPP-scanned candidate is a genuine structured record (Name;TriggerId;Condition...;
        // Description - the same general shape DynamicStringInteractionOptionColumnSources
        // already recognizes for BuildingData.csv's "互动选项" cells, just with a different
        // delimiter ordering: '?'/'-' there vs plain ';' here), rather than ordinary dialogue text
        // that happens to contain a stray ASCII ';'.
        private static readonly Regex AsciiIdentifierFieldRegex = new(@"^[A-Za-z][A-Za-z0-9]*$", RegexOptions.Compiled);

        // Matches a "<label>:<value>[ <value2>...]" / "<label>：<value>..." sub-shape found inside
        // one field of a structured record - e.g. "技能影响:医术", "技能影响:医术 内功". Group 1
        // captures the label (with colon) as its own standalone candidate; group 2 captures the
        // space-separated value(s) that follow, split further below.
        private static readonly Regex LabeledFieldRegex = new(@"^([\p{IsCJKUnifiedIdeographs}]+[:：])(.+)$", RegexOptions.Compiled);

        // Directory holding every dynamic-string dump/candidate file (dynamicStrings.txt,
        // dynamicStringsFromColumns.txt, dynamicStringsFromStructuredFragments.txt,
        // dynamicStringsFromOtherFieldLabels.txt, dynamicStringsPoetry.txt, heroNameParts.txt).
        internal static string DynamicStringsDumpDirectory(string workingDirectory) =>
            $"{workingDirectory}/Raw/Dumped/DynamicStrings";

        /// <summary>
        /// Unions every raw value already present in ONE dynamic-string dump file (this
        /// extractor's own output file) - just enough for re-run idempotency. Deliberately does
        /// NOT cross-check every other dynamic-string file: that's DedupeDynamicStringFiles' job
        /// alone (the one authoritative cross-file pass, run once at "1i."), so each extractor
        /// stays independent of every other one and doesn't care what order 1c-1h ran in.
        /// </summary>
        internal static HashSet<string> GetExistingDynamicStringValues(string outputPath)
        {
            var seen = new HashSet<string>();
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            return seen;
        }

        /// <summary>Extracts configured whole values and structured labels idempotently.</summary>

        public static void ExtractDynamicStringCandidatesFromColumns(string workingDirectory)
        {
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt";

            var seen = GetExistingDynamicStringValues(outputPath);

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

            foreach (var (csvFileName, columns) in DynamicStringInteractionOptionColumnSources)
            {
                ExtractFrom(csvFileName, columns, cell => cell
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .SelectMany(item =>
                    {
                        var match = InteractionOptionRegex.Match(item);
                        if (!match.Success) return [];
                        return new[] { match.Groups[1].Value, match.Groups[3].Value };
                    }));
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Scans the master IL2CPP-scanned dump (dynamicStrings.txt) for ';'-joined structured-
        /// record candidates - the same general "Name;TriggerId;Condition...;Description" shape
        /// DynamicStringInteractionOptionColumnSources already recognizes for BuildingData.csv's
        /// "互动选项" cells (there shaped "Name?Description-Condition-TriggerId" - same idea,
        /// different delimiter ordering), except these particular records are hardcoded string
        /// literals baked directly into game code (e.g. clinic/hospital interaction menu entries -
        /// confirmed 2026-08-30, "技能 影响:医术" screenshot case) rather than CSV-driven, so the
        /// IL2CPP scan has no notion of this field shape and dumps the WHOLE ';'-joined literal as
        /// one candidate, e.g. "包扎;HospitalCureExternalInjury;;;技能影响:医术". Only the
        /// individual CJK-containing fields (Name/Description) are ever actually displayed on
        /// screen, never the whole joined literal, so the whole-string dictionary entry this
        /// produces can never match at runtime; DynamicStringPatches' bare dictionary then falls
        /// back to whatever shorter standalone fragments happen to exist, corrupting text like
        /// "技能影响:医术" into "Skills 影响:Medicine".
        ///
        /// Fix: split every dump line on ';', identify it as a genuine structured record via
        /// AsciiIdentifierFieldRegex (at least one field must be a bare ASCII trigger-id - the
        /// same signal that distinguishes a real record from ordinary dialogue that happens to
        /// contain a stray ASCII ';'), and emit each remaining CJK-containing field as its own
        /// standalone candidate - further splitting a "<label>:<value>" shaped field (see
        /// LabeledFieldRegex) into the label and each individual space-separated value. A field
        /// with no such label shape (e.g. a plain Name like "包扎", or a multi-line "♦..." bullet
        /// description) is kept whole, consistent with how multi-line literals are treated
        /// elsewhere in this pipeline (see StringMapExtractor.ExtractDynamicStringCandidates'
        /// doc comment).
        ///
        /// Must run AFTER ExtractDynamicStringCandidatesFromIl2CppStringMap, which is what
        /// populates/refreshes the master dump this reads from. Idempotent: re-running never
        /// duplicates an already-extracted value.
        /// </summary>
        public static void ExtractStructuredRecordFragmentCandidates(string workingDirectory)
        {
            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStrings.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromStructuredFragments.txt";
            if (!File.Exists(masterDumpPath)) return;

            var seen = GetExistingDynamicStringValues(outputPath);

            var found = new List<string>();

            void AddCandidate(string value)
            {
                if (string.IsNullOrWhiteSpace(value)) return;
                if (!ChineseCharPattern.IsMatch(value)) return;
                if (!seen.Add(value)) return;
                found.Add(value);
            }

            foreach (var line in File.ReadAllLines(masterDumpPath))
            {
                if (string.IsNullOrEmpty(line)) continue;

                var fields = line.Split(';');
                if (fields.Length < 3) continue;
                if (!fields.Any(f => AsciiIdentifierFieldRegex.IsMatch(f))) continue;

                foreach (var field in fields)
                {
                    if (string.IsNullOrWhiteSpace(field)) continue;
                    if (!ChineseCharPattern.IsMatch(field)) continue;

                    var labeled = LabeledFieldRegex.Match(field);
                    if (labeled.Success)
                    {
                        AddCandidate(labeled.Groups[1].Value);
                        foreach (var value in labeled.Groups[2].Value.Split([' ', '\u3000'], StringSplitOptions.RemoveEmptyEntries))
                            AddCandidate(value);
                    }
                    else
                    {
                        AddCandidate(field);
                    }
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Extracts SpeHeroData's "."-joined family/given-name halves (see
        /// DynamicStringNamePartColumnSources) into their OWN dedicated dump file
        /// (Raw/Dumped/DynamicStrings/heroNameParts.txt) - deliberately separate from
        /// dynamicStrings.txt/dynamicStringsFromColumns.txt so these short name fragments never
        /// end up merged into DynamicStringPatches' global substring-replace dictionary (see the
        /// "heroNameParts.txt" TextFileToSplit entry's comment). Idempotent: re-running never
        /// duplicates an already-extracted value.
        /// </summary>
        public static void ExtractHeroNamePartCandidates(string workingDirectory)
        {
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/heroNameParts.txt";

            var seen = GetExistingDynamicStringValues(outputPath);

            var found = new List<string>();

            foreach (var (csvFileName, columns) in DynamicStringNamePartColumnSources)
            {
                var csvPath = $"{workingDirectory}/Raw/Dumped/GameData/{csvFileName}";
                if (!File.Exists(csvPath)) continue;

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

                        foreach (var value in cell.Split('.', StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (string.IsNullOrWhiteSpace(value)) continue;
                            if (!seen.Add(value)) continue;

                            found.Add(value);
                        }
                    }
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>Extracts allowlisted dumped fields into the exact-match PrefabText input.</summary>
        public static void ExtractDynamicStringCandidatesFromOtherText(string workingDirectory)
        {
            var otherTextPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedOtherText.txt";
            if (!File.Exists(otherTextPath))
                throw new InvalidOperationException("You need to run Dump Chinese Text");

            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabText.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabTextFromOtherFields.txt";

            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            var allowedFields = new HashSet<string>(DynamicStringOtherTextFields, StringComparer.OrdinalIgnoreCase);
            var labelFields = new HashSet<string>(DynamicStringLabelOtherTextFields, StringComparer.OrdinalIgnoreCase);

            // Use dictionaries because the dumped-entry record has no parameterless constructor.
            var deserializer = YamlHelper.CreateDeserializer();
            var entries = deserializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(otherTextPath)) ?? [];

            var found = new List<string>();
            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("raw", out var raw) || string.IsNullOrWhiteSpace(raw)) continue;
                if (!entry.TryGetValue("field", out var field)) continue;

                if (string.Equals(field, "startCallSpeFuc", StringComparison.OrdinalIgnoreCase))
                {
                    var match = PlotGetNewMailRegex.Match(raw);
                    if (!match.Success) continue;

                    var message = match.Groups[1].Value;
                    if (string.IsNullOrWhiteSpace(message) || !seen.Add(message)) continue;

                    found.Add(message);
                    continue;
                }

                // Labels are now extracted separately - see ExtractOtherFieldLabelCandidates.
                if (labelFields.Contains(field)) continue;

                if (!allowedFields.Contains(field)) continue;
                if (!seen.Add(raw)) continue;

                found.Add(raw);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Extracts the stat-label sub-source (e.g. "spellEffectString") out of
        /// dumpedOtherText.txt into its OWN dedicated file
        /// (Raw/Dumped/DynamicStrings/dynamicStringsFromOtherFieldLabels.txt) - split out of
        /// dynamicStringsFromColumns.txt (formerly written there by
        /// ExtractDynamicStringCandidatesFromOtherText) so each dynamic-string file's provenance
        /// is unambiguous. Idempotent: re-running never duplicates an already-extracted value.
        /// </summary>
        public static void ExtractOtherFieldLabelCandidates(string workingDirectory)
        {
            var otherTextPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedOtherText.txt";
            if (!File.Exists(otherTextPath)) return;

            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromOtherFieldLabels.txt";
            var seen = GetExistingDynamicStringValues(outputPath);

            var labelFields = new HashSet<string>(DynamicStringLabelOtherTextFields, StringComparer.OrdinalIgnoreCase);

            // Use dictionaries because the dumped-entry record has no parameterless constructor.
            var deserializer = YamlHelper.CreateDeserializer();
            var entries = deserializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(otherTextPath)) ?? [];

            var found = new List<string>();
            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("raw", out var raw) || string.IsNullOrWhiteSpace(raw)) continue;
                if (!entry.TryGetValue("field", out var field)) continue;
                if (!labelFields.Contains(field)) continue;

                var label = StatLabelRegex.Match(raw).Value;
                if (string.IsNullOrWhiteSpace(label) || !seen.Add(label)) continue;

                found.Add(label);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Refreshes IL2CPP string-map candidates and appends new entries idempotently directly
        /// into the master <c>dynamicStrings.txt</c> dump - this is NOT a hand-curated/manually
        /// reviewed file despite older doc comments claiming otherwise (there is no manual review
        /// step in practice; the master dump IS whatever this method regenerates from the
        /// Converter's <c>_dynamicStrings_candidates.txt</c> output). Also bootstraps the master
        /// dump file itself the first time this runs (e.g. fresh clone / after deleting
        /// Raw/Dumped), which is what "1c." depends on existing before it can export.
        /// </summary>
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

            // Dedup against the master dump itself only (idempotent re-runs never duplicate a
            // line already recorded there). Deliberately does NOT also cross-check
            // dynamicStringsFromColumns.txt - that file may already contain stale long-sentence
            // candidates left over from an older version of this method that (incorrectly)
            // appended here instead of to the master dump; treating those as "already seen" would
            // permanently block this method from ever writing anything to dynamicStrings.txt. See
            // the "dynamicStringsFromColumns.txt contamination" note in
            // Tests/docs/dynamicstrings-pipeline-architecture.md for the one-time cleanup needed
            // if that file still has this legacy contamination.
            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));

            var found = File.ReadAllLines(candidatesPath)
                .Where(l => !string.IsNullOrEmpty(l))
                .Where(seen.Add)
                .ToList();

            Directory.CreateDirectory(Path.GetDirectoryName(masterDumpPath)!);
            File.AppendAllLines(masterDumpPath, found);
        }

        // Fixed priority order for cross-file dedup: when a raw value exists in more than one
        // dynamic-string dump file, it's kept in whichever file appears EARLIEST here and removed
        // from the rest. Any file under Raw/Dumped/DynamicStrings/ not listed here is treated as
        // lowest priority (kept last).
        private static readonly string[] DynamicStringDedupePriorityOrder =
        [
            "dynamicStrings.txt",
            "dynamicStringsFromColumns.txt",
            "dynamicStringsFromStructuredFragments.txt",
            "dynamicStringsFromOtherFieldLabels.txt",
            "dynamicStringsPoetry.txt",
            "dynamicStringsDrinkQuotes.txt",
        ];

        /// <summary>
        /// Final, authoritative cross-file dedup pass for Raw/Dumped/DynamicStrings/*.txt - the
        /// one place duplicates across files get resolved, regardless of which extraction Facts
        /// ran, how many times, or in what order (each extractor only needs to avoid duplicating
        /// within its OWN file via GetExistingDynamicStringValues; this pass handles anything that
        /// ends up in more than one file). Safe/idempotent - re-running when there are no
        /// cross-file duplicates left is a no-op.
        /// </summary>
        public static void DedupeDynamicStringFiles(string workingDirectory)
        {
            var dir = DynamicStringsDumpDirectory(workingDirectory);
            if (!Directory.Exists(dir)) return;

            var files = Directory.GetFiles(dir, "dynamic*.txt")
                .OrderBy(f =>
                {
                    var index = Array.IndexOf(DynamicStringDedupePriorityOrder, Path.GetFileName(f));
                    return index < 0 ? int.MaxValue : index;
                })
                .ToList();

            var seen = new HashSet<string>();
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                var deduped = lines.Where(l => string.IsNullOrEmpty(l) || seen.Add(l)).ToList();

                if (deduped.Count != lines.Length)
                    File.WriteAllLines(file, deduped);
            }
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

        // Drops junk dynamic-string dictionary entries whose Raw contains no Chinese characters at
        // all (same detection pattern as DragonHeirPlugin/MainPlugin.cs's ChineseCharPattern /
        // Tests/AssetDumperWorkflowTests.cs's ChineseCharPattern). Originally just a digit-only
        // check (see the runtime symptom this prevents in DynamicStringPatches.cs's ApplyDictionary
        // comment: "50%" -> "5 0 %", "100/100" -> "1 0 0 / 1 0 0"), but extended 2026-08-29 after
        // finding the same class of bug from non-digit junk entries too - e.g. IL2CPP string-map
        // candidate extraction occasionally captures a Unicode-range dump like
        // "-.09AZ__az··ÀÖØöøıĴľŁ...一龥" (glyph-atlas coverage strings with only a token amount of
        // trailing CJK) or plain ASCII/Latin identifiers with no Chinese at all. None of these ever
        // need dictionary translation - only text containing real Chinese characters is ever a
        // genuine translatable fragment - so the same filter now catches both digit-only AND any
        // other non-CJK-containing Raw, rather than special-casing digits alone. Filtering here at
        // packaging time (once, when Files/Mod/*.yaml is produced) means the plugin's runtime
        // dictionary never has to re-check this per match on every hot-path call.
        private static readonly Regex ChineseCharPattern = new(@"\p{IsCJKUnifiedIdeographs}", RegexOptions.Compiled);

        private static void RemoveNonChineseDynamicStringEntries(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var filtered = results.Where(entry => !string.IsNullOrEmpty(entry.Raw) && ChineseCharPattern.IsMatch(entry.Raw)).ToList();
            if (filtered.Count == results.Count)
                return;

            var serializer = YamlHelper.CreateSerializer();
            File.WriteAllText(modPath, serializer.Serialize(filtered));
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

                // Drop junk entries whose Raw has no Chinese at all - see
                // RemoveNonChineseDynamicStringEntries.
                RemoveNonChineseDynamicStringEntries(workingDirectory, dynamicStringFile);
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
                        //Reverse the Hyphen to a normal hyphen so it can be read in the game
                        line.Translated = line.Translated.Replace("\u2011", "-");
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
