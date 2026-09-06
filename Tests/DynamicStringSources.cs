using System.Text.RegularExpressions;

namespace Tests
{
    // Source-column tables and shared regexes consumed by DynamicStringExtraction. See
    // docs/gamefilehandling-reference.md.
    public static class DynamicStringSources
    {
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
            // Column 1 (Name) is a defense-in-depth entry for runtime-composed strings that
            // concatenate names across rows outside the CSV pipeline; see
            // docs/gamefilehandling-reference.md.
            ("ResourcePointData.csv", [1]),
            ("ResourcePointTypeData.csv", [1]),
            ("SpeAddDataBase.csv", [1, 11]),
            // SpeHeroData.csv is disabled in TextFileConfiguration.TextFilesToSplit, so its
            // display text (including position titles/nicknames) never reaches the CSV pipeline -
            // extracted here as whole-phrase entries instead. See
            // docs/gamefilehandling-reference.md.
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

            // BattleController-embedded obstacle name lists (e.g. "雕像"/statue, "城墙"/wall) -
            // same class of problem, combat screen instead of explore map. Dumped by the same
            // ExploreDataDumpPatches.cs (despite the file name, it now covers both screens).
            ("ObstacleDataBase.csv", [0]),
            ("ExplodeObstacleDataBase.csv", [0]),
        ];

        /// <summary>
        /// CSV name columns that are ALSO used verbatim as an atlas sprite lookup key at runtime
        /// (e.g. InnIconController.Init calling TextureController.LoadAtlasSprite("AreaIconAtlas",
        /// innData.innName) - see DragonHeirPlugin/AtlasIconPatches.cs). Unlike
        /// DynamicStringColumnSources, these columns are ALREADY translated whole-string via the
        /// normal per-row CSV pipeline (not re-sent through the LLM here) -
        /// TranslationPackaging.PackageFinalTranslationAsync just also copies each row's
        /// already-translated (Text, Translated) pair for these columns out into a dedicated flat
        /// raw/result file (e.g. innIconNames.txt.yaml) so the plugin can reverse-translate the
        /// sprite key via a small private exact-match dictionary instead of DynamicStringPatches'
        /// much larger fragment-substitution dictionary.
        /// </summary>
        public static readonly (string CsvFileName, int Column, string OutputFileName)[] AtlasSpriteNameColumnSources =
        [
            ("InnData.csv", 1, "innIconNames.txt"),
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
        // translate each part independently. Consumed by
        // DynamicStringExtraction.ExtractHeroNamePartCandidates, which writes into the dedicated
        // heroNameParts.txt file (NOT dynamicStringsFromColumns.txt) - see that
        // TextFileToSplit entry's comment for why these must stay out of the global
        // DynamicStringPatches substring-replace dictionary.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringNamePartColumnSources =
        [
            ("SpeHeroData.csv", [1]),
        ];

        // PlotData.csv columns 1/2 (speaker name) are SkipColumns'd entirely because the whole
        // cell can also be a structured "临时:Name&Gender;Age;RelationLevel[;...]" temporary-NPC-
        // spawn record parsed by PlotController.GetHeroData/GetTempPlotHeroData at runtime, whose
        // bare Name fragment is what's actually displayed as the NPC's nameplate - and is never
        // seen by any other extraction source. Extracted here via TempNpcNameRegex so it reaches
        // DynamicStringPatches' substring dictionary. See docs/gamefilehandling-reference.md.
        //
        // A cell without the "临时:" prefix is an ordinary PERMANENT NPC's plain speaker name (e.g.
        // "雷彤") - confirmed 2026-09-06 investigating an untranslated "雷彤" nameplate: she's a
        // plot-only character with no row in SpeHeroData.csv or any other GameData CSV, so nothing
        // else ever surfaces her name as a translation candidate despite being displayed raw via
        // the same nameplate component-text setter as the 临时: case. The extractor (see
        // DynamicStringExtraction.cs) now emits the whole cell verbatim whenever TempNpcNameRegex
        // doesn't match, so both shapes reach the dictionary from this one source.
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringTempNpcNameColumnSources =
        [
            ("PlotData.csv", [1, 2]),
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
        // plotText/tutorialText/describe/etc. are routed here (substring-replace) as a quick fix
        // rather than through PrefabTextPatches' whole-string match - deferred alternative design:
        // docs/prefabtext-generic-field-walk-plan.md.
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
        // and handled via structured extraction instead - see
        // DynamicStringExtraction.ExtractDynamicStringCandidatesFromOtherText.
        internal static readonly Regex PlotGetNewMailRegex =
            new(@"^PlotGetNewMail;[^-]+-(.+?)(?:-true)?$", RegexOptions.Compiled);

        // "spellEffectString"'s raw shape is "<CJK label><signed number>" with no delimiter (e.g.
        // "伤害-0.04"), the same shape DynamicStringLabelColumnSources already extracts from CSV
        // columns via StatLabelRegex below. Only the label is translatable text.
        internal static readonly string[] DynamicStringLabelOtherTextFields = ["spellEffectString"];

        // Runtime setter behavior: docs/gamefilehandling-reference.md.

        // Extracts the repeated label from a structured stat modifier.
        internal static readonly Regex StatLabelRegex = new(@"^[^\d+\-]+", RegexOptions.Compiled);

        // Extracts the Name (group 1) and optional Description (group 3) from a
        // "Name?Description-Condition-TriggerId" interactive-option item.
        internal static readonly Regex InteractionOptionRegex = new(@"^([^?\-]+)(\?([^-]*))?-", RegexOptions.Compiled);

        // Extracts the Name (group 1) from a "临时:Name" / "临时:Name&Gender;Age;RelationLevel[;...]"
        // temporary-NPC-spawn record - see DynamicStringTempNpcNameColumnSources above. A cell
        // with no "临时:" prefix (an ordinary plain speaker name) simply doesn't match.
        internal static readonly Regex TempNpcNameRegex = new(@"^临时:([^&]+)", RegexOptions.Compiled);

        // Identifies a bare ASCII PascalCase/camelCase field (e.g. "HospitalCureExternalInjury",
        // "AskHeroMakeFriend") - the game's own internal trigger/event routing id. Used as a
        // heuristic signal (see DynamicStringExtraction.ExtractStructuredRecordFragmentCandidates)
        // that a ';'-joined IL2CPP-scanned candidate is a genuine structured record
        // (Name;TriggerId;Condition...;Description - the same general shape
        // DynamicStringInteractionOptionColumnSources already recognizes for BuildingData.csv's
        // "互动选项" cells, just with a different delimiter ordering: '?'/'-' there vs plain ';'
        // here), rather than ordinary dialogue text that happens to contain a stray ASCII ';'.
        internal static readonly Regex AsciiIdentifierFieldRegex = new(@"^[A-Za-z][A-Za-z0-9]*$", RegexOptions.Compiled);

        // Matches a "<label>:<value>[ <value2>...]" / "<label>：<value>..." sub-shape found inside
        // one field of a structured record - e.g. "技能影响:医术", "技能影响:医术 内功". Group 1
        // captures the label (with colon) as its own standalone candidate; group 2 captures the
        // space-separated value(s) that follow, split further below.
        internal static readonly Regex LabeledFieldRegex = new(@"^([\p{IsCJKUnifiedIdeographs}]+[:：])(.+)$", RegexOptions.Compiled);
    }
}
