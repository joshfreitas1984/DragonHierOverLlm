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

            // BattleController.speGridObjDataBase (name+multi-line describe per SpeGridObjType,
            // e.g. "异果"/StrangeFruit -> "体力+30%\n内力+10%") - same embedded-list problem as the
            // two obstacle lists above, dumped by the same ExploreDataDumpPatches.cs.
            ("SpeGridObjDataBase.csv", [0, 1]),

            // Four more controllers with the same embedded-list-never-assigned-in-code shape,
            // dumped by ExploreDataDumpPatches.cs alongside the ones above.
            ("BattlePrepareSpellDataBase.csv", [0, 1]),
            ("WeatherDataBase.csv", [0]),
            ("WorldEventDataBase.csv", [0]),
            ("ReadBookTextTypeDataBase.csv", [0, 1, 2]),
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

        /// <summary>
        /// Curated allowlist of the "log narrative" String.Format templates feeding
        /// HeroData.AddLog/AreaData.AddLog (HeroDetailPanel's Log tab, AreaLog, PlotPanel's
        /// RecordScrollView) - confirmed via decompiled source across
        /// Converter/output/_NoNamespace/AIController.cs, GameController.cs, HeroData.cs,
        /// AreaData.cs and PlotController.cs (2026-09-13 trace). Consumed by
        /// DynamicStringExtraction.ExtractLogNarrativeCandidates, which pulls any matching line out
        /// of the master dynamicStrings.txt dump into its own dedicated dynamicStringsLogNarratives.txt
        /// file - see that method's doc comment and docs/dynamicstrings-pipeline-architecture.md for
        /// why a dedicated file (not a tag/category field) is used, matching the existing
        /// heroNameParts.txt/forceNameParts.txt precedent. Isolating these makes every template that
        /// needs a DynamicStringResultOverrides naturalness fix (see TranslationPackaging.cs) trivial
        /// to find, and lets DragonHeirPlugin route known-log-panel text through a smaller
        /// compiled-template list (see DragonHeirPlugin/docs/recordlog-translation-naturalness.md).
        ///
        /// This list is HAND-CURATED (these are baked-in game-code literals, not derivable from any
        /// CSV/column/asset source the way the other extractors' inputs are), but it does not need to
        /// be re-curated by hand forever: if the game gets a content update and
        /// Converter/output/_NoNamespace/*.cs is regenerated, re-run
        /// Converter/Scripts/ExtractAddLogTemplates.ps1 against the fresh decompile to regenerate a
        /// candidate list for review (it reproduces this list almost entirely on its own; see the
        /// script's header for its one known gap - a single call site in GameController.cs that
        /// inlines several sibling-branch literals directly into String.Format rather than assigning
        /// through one variable, which still needs manual expansion each time).
        ///
        /// Six other AddLog call sites (GameController.cs:15358/15507/15572/27289,
        /// HeroData.cs:7488/7797) are deliberately EXCLUDED - they build their log line via
        /// String.Concat gluing short, highly generic literal fragments (e.g. "的", "了", "拜入了")
        /// around dynamic values rather than a single self-contained String.Format template. Those
        /// fragments are shared all over the rest of the corpus, so pulling them into a
        /// log-narrative-only file would risk breaking unrelated non-log text that reuses the same
        /// fragment. If one of those renders awkwardly, fix it via DynamicStringResultOverrides
        /// individually instead (its Raw fragment, not a whole template, would need to be matched).
        /// </summary>
        public static readonly string[] LogNarrativeTemplates =
        [
            // AIController.cs
            "{0}在{1}结束关押，恢复了自由之身。",
            "{0}在{1}闲逛之时，意外获取了{2}两银钱。",
            "{0}在{1}闲逛之时，意外获取了一件{2}。",
            "{0}在{1}修习了武功{2}。",
            "{0}在{1}修习了{2}技艺。",
            "{0}在{1}辛勤劳作，为门派收获了{2}。",
            "{0}在{1}打工赚钱，获取了{2}两银钱。",
            "{0}在{1}四下探索之时，意外发现了{2}。",
            "{0}在{1}与{2}相谈盛欢，一见如故，结为知己好友。",
            "{0}在{1}欲下毒暗害{2}，{3}。",
            "{0}在{1}欲{5}{2}的{3}，{4}。",
            "{0}在{1}欲偷师{2}的{3}，{4}。",
            "{0}在{1}与{2}心生嫌隙，结下了深仇大恨。",
            "{0}在{1}与{2}闲聊一阵。",
            "{0}在{1}与{2}交流心得，切磋武艺，最终{3}。",
            "{0}在{1}袭击了{2}，血战一场最终{3}。",
            "{0}在{1}完成了重要委托，名望{2}，银两{3}，并获得了{4}。",
            "{0}在{1}遭逢{5}奇遇，名望{2}，银两{3}，并获得了{4}。",
            "{0}在{1}上下打点，花费{3}银两降低了{2}点恶名。",
            "{0}在{1}习得了新武功{2}。",
            "{0}在{1}暗中破坏，使该地{2}降低{3}点。",
            "{0}烹饪了{1}并放入行囊(消耗{2}银钱{3})",
            "{0}烹饪了{1}并放入门派仓库(消耗{2}粮食{3})",
            "{0}烹饪了{1}，由于门派仓库已满只得放入行囊(消耗{2}粮食{3})",
            "{0}炼制了{1}并放入行囊(消耗{2}银钱{3})",
            "{0}炼制了{1}并放入门派仓库(消耗{2}药材{3})",
            "{0}炼制了{1}，由于门派仓库已满只得放入行囊(消耗{2}药材{3})",
            "{0}制造了{1}并放入行囊(消耗{2}银钱{3})",
            "{0}制造了{1}并放入门派仓库(消耗{2}木料矿石{3})",
            "{0}制造了{1}，由于门派仓库已满只得放入行囊(消耗{2}木料矿石{3})",
            "{0}在{1}买卖交易，出售了闲置物品{2}{3}。",
            "{0}使用门派银钱{1}两，购买{2}。",
            "{0}出售门派{1}，换取门派银钱{2}两。",
            "{0}与{1}情谊渐浅，断绝了好友关系。",
            "{0}与{1}冰释前嫌，化解了二人间的仇恨。",
            "{0}被{1}抓捕入狱，关押在{2}之中。",
            "{0}向{3}仓库捐赠了{1}，获取功绩{2}",
            "{0}从{3}仓库购买了{1}，花费银两{2}",

            // GameController.cs
            "{0}的{1}结束{2}了。",
            "{0}<b>{1}</b>{2}，买卖价格{3}。",
            "{0}收到门派{1}银钱嘉奖，忠诚+3",
            "{0}在{1}参加{6}，勇夺第{2}名，银两+{3}，{4}，并获得了奖品{5}。",
            "{0}在{1}参加{5}赛马大会，勇夺第{2}名，银两+{3}，声望+{4}。",
            "{0}在{1}参加{2}拍卖大会，花费{3}两购得一件{4}。",
            // Random-treasure-event family - all 9 flow to the same call site
            // (GameController.cs:22925); the automated re-extraction script only picks up one of
            // these per run (see script header) - the rest must be re-added by hand after a
            // decompile refresh.
            "{0}吉人天相，寻得高人所刻石碑，潜心研读后提升了{1}潜力。",
            "{0}吉人天相，{2}，学会了武功{1}。",
            "{0}吉人天相，寻得前朝皇家宝库，获得了{1}等诸多珍宝。",
            "{0}气运过人，寻得一本失传秘籍，鉴别后竟是传说中的{1}。",
            "{0}吉星高照，得到一株异草，服食后生命上限增加{1}。",
            "{0}吉星高照，寻得失落宝藏，搜刮后获得了{1}两银钱。",
            "{0}吉星高照，得到一枚灵果，服食后内力上限增加{1}。",
            "{0}气运过人，寻得一件神兵利器，鉴别后竟是传说中的{1}。",
            "{0}气运过人，寻得一匹千里名驹，鉴别后竟是传说中的{1}。",
            "{0}近日大兴土木，开始修缮升级{1}{2}({3}级)",
            "{0}近日大兴土木，开始在{1}新建{2}",
            "{0}近日大兴土木，开始拆除{1}{2}({3}级)",
            "{0}掌门{1}将《{2}》{3}秘籍放入藏经阁，供全派弟子参阅。",
            "{0}掌门{1}用《{2}》{3}替换了藏经阁内的《{2}》{4}秘籍，供全派弟子参阅。",
            "{0}因功勋卓著，被晋升为{1}。",
            "{0}攻击了{2}掌控下的{1}，最终{3}。",
            "{0}加入了由{1}领导的队伍。",
            "{0}离开了由{1}领导的队伍。",

            // HeroData.cs
            "{0}对自身装备的{1}进行了粹毒。",
            "{0}对自身的{1}上进行了下毒。",
            "{0}领悟了天赋：{1}",
            "{0}{1}{2}，{3}",

            // AreaData.cs
            "{0}近日开始加强{1}分舵之{2}防御等级({3}级)",

            // PlotController.cs
            "{0}在{1}暗中破坏，使该地{2}降低了{3}点。",
            "{0}在{1}开展治理，使该地{2}提升了{3}点。",
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

        // ForceData.csv column 1 (名字/force-sect name, e.g. "仙霞派") truncated to its first 2
        // characters (e.g. "仙霞") - HeroData.GetHeroForceLvDescribe(fullName: false) builds the
        // compact battle-UI force tag via String.Substring(forceName, 0, 2), bypassing the
        // already-translated whole-name dictionary entry that DynamicStringColumnSources extracts
        // for the untruncated name. Confirmed 2026-09-07 investigating an untranslated "仙霞" tag
        // on the Canvas/BattleUIPanel NowActiveHero/NameBack/Force UI element (the trailing colored
        // rank text translated fine via the ordinary dictionary; only the truncated force-name
        // prefix didn't).
        //
        // NOTE: for the 10 minor/background forces (ForceData.csv ids 20-29, e.g. 仙霞派/巨鲸帮/
        // 金龙帮/青城派), the row's own bold trait-description column (门派特性, e.g. "<b>仙霞</b>：
        // 所有经验获取+5%。") happens to wrap this exact same 2-char prefix, so
        // Files/Converted/ForceData.csv.yaml already has a correct translation for those 10
        // specific prefixes as a byproduct - reusable without a fresh translation pass. This does
        // NOT hold for the 20 major forces (ids 0-19): their bold trait-description text is an
        // unrelated skill/trait name (e.g. 唐门's is "<b>暗器</b>"/Hidden Weapon, nothing to do with
        // the force name), so their truncated-name prefixes (e.g. 药王谷→药王, 少林寺→少林, 武当派→
        // 武当) still need a genuine translation from the normal export/translate pipeline - do NOT
        // copy a positionally-corresponding split-15 value for those. Written to its own dedicated
        // forceNameParts.txt (see
        // DynamicStringExtraction.ExtractForceNamePrefixCandidates), consumed only by
        // HeroNamePatches' private exact-match dictionary - NOT DynamicStringPatches' global
        // substring-replace dictionary - for the same false-positive-risk reason documented on
        // DynamicStringNamePartColumnSources above (a bare 2-character fragment is too easy to
        // accidentally match as a substring of unrelated CJK text elsewhere in the game).
        public static readonly (string CsvFileName, int[] Columns)[] DynamicStringForceNamePrefixColumnSources =
        [
            ("ForceData.csv", [1]),
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
