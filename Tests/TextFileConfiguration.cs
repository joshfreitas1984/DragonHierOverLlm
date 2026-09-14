using FanslationStudio.LlmKit.Support;

namespace Tests
{
    // Authoritative translation/package configuration for this game's text files.
    // See docs/gamefilehandling-reference.md ("Column safety policy").
    public static class TextFileConfiguration
    {
        public static readonly TextFileToSplit[] TextFilesToSplit = [
            new() {Path = "AchievementData.csv", PackageOutput = true },
            // Skip-column rationale: docs/gamefilehandling-reference.md. Column 2 (类别/Category)
            // is exact-matched against the hardcoded literals "城市"/"村镇"/"门派" in
            // GameDataController's AreaData load loop - translating it breaks that check.
            new() {Path = "AreaData.csv", PackageOutput = true, SkipColumns = [2, 3], EnableQualityReview = false  },
            new() {Path = "ArmorData.csv", PackageOutput = true, EnableQualityReview = false  },
            //new() {Path = "BookTypeIconData.csv", PackageOutput = true },
            // Columns 8-12 are Label<sign><number>/lookup-key cells matched by GameDataController's
            // BuildingData load loop; see docs/gamefilehandling-reference.md.
            new() {Path = "BuildingData.csv", PackageOutput = true, SkipColumns = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18] },
            new() {Path = "FoodData.csv", PackageOutput = true, SkipColumns = [1, 15], EnableQualityReview = false },
            // Column 2 is an exact-match lookup key (ForceData.forceStyle); see
            // docs/gamefilehandling-reference.md.
            new() {Path = "ForceData.csv", PackageOutput = true, SkipColumns = [1, 2, 9, 10, 11] },
            // Lookup-key column; see docs/gamefilehandling-reference.md.
            new() {Path = "ForceSpeAddDataBase.csv", PackageOutput = true, SkipColumns = [1] },
            new() {Path = "HeroNatureTalkText.csv", PackageOutput = true },
            new() {Path = "HeroSpeTalkText.csv", PackageOutput = true },
            // All columns skipped: column 1 (Name) is itself an exact-match lookup key
            // (GameDataController.GetTagID); display text is captured separately via
            // DynamicStringSources.DynamicStringColumnSources below. See
            // docs/skipcolumns-stringtospeadddata-family.md.
            new() {Path = "HeroTagData.csv", PackageOutput = true, SkipColumns = [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12], EnableQualityReview = false },
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
            new() {Path = "MartialClubData.csv", PackageOutput = true, EnableQualityReview = false },
            new() {Path = "MedData.csv", PackageOutput = true, SkipColumns = [1, 15], EnableQualityReview = false },
            // Internal routing key; see docs/gamefilehandling-reference.md.
            new() {Path = "NameData.csv", PackageOutput = true, SkipColumns = [0], EnableQualityReview = false },
            new() {Path = "ResourcePointData.csv", PackageOutput = true, EnableQualityReview = false },
            // Structured lookup-key columns; see docs/gamefilehandling-reference.md.
            new() {Path = "ResourcePointTypeData.csv", PackageOutput = true, SkipColumns = [2, 3, 4], EnableQualityReview = false },
            new() {Path = "SkinDataBase.csv", PackageOutput = true, SkipColumns = [2], EnableQualityReview = false},
            // Columns 1/11 are exact-match lookup keys (HeroSpeAddDataBase.GetDescribe family);
            // see docs/gamefilehandling-reference.md.
            new() {Path = "SpeAddDataBase.csv", PackageOutput = true, SkipColumns = [1, 11] },
            // File disabled: all columns except Name are game-parsed lookup/enum values; column 2
            // (Gender) translation crashes GameController.GenerateHeroData. See
            // docs/spehero-relationship-and-skillfocus-crashes.md.
            //new() {Path = "SpeHeroData.csv", PackageOutput = true, SkipColumns = [0, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20] },
            //new() {Path = "SpeHeroFaceData.csv", PackageOutput = true },
            new() {Path = "SummonData.csv", PackageOutput = true,  SkipColumns = [7], EnableQualityReview = false},
            // Shares KungFuData.csv's lookup-key columns (same loader), but column 3 (Name) IS
            // safe here - GetSkillID only scans kungfuSkillDataBase, not this file. See
            // docs/gamefilehandling-reference.md.
            new() {Path = "SummonKungFuData.csv", PackageOutput = true, SkipColumns = [1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28], EnableQualityReview = false}, 
            // Columns 4/8 are exact-match cross-file lookup keys (ForceSpeAddDataBase.name /
            // force-weapon name dictionary); see docs/gamefilehandling-reference.md.
            new() {Path = "TechDataBase.csv", PackageOutput = true, SkipColumns = [4, 8], EnableQualityReview = false },
            new() {Path = "TipsData.csv", PackageOutput = true },
            //new() {Path = "WeaponData.csv", PackageOutput = true, SkipColumns = [1] },

            // Main dialogue table. Columns 1-8 are non-narrative asset/routing keys (speaker
            // name/temp-NPC spawn record, highlight side, background image/music/sfx, reflection-
            // based call-function dispatch) - see docs/gamefilehandling-reference.md. Column 9
            // (choices) stays translated via the CustomColumnRepair/CustomColumnValidator
            // delimiter-preservation pattern above, not SkipColumns. Any column-9 cell containing
            // a structural '|'/';' delimiter is excluded from the separate QC review pass via
            // GameFileHandling.ExcludePlotChoiceColumnFromQc (CustomQcExclusionRule) - see
            // docs/gamefilehandling-reference.md ("Quality review hooks").
            new() {Path = "PlotData.csv", PackageOutput = true, SkipColumns = [1, 2, 3, 4, 5, 6, 7, 8],  },

            // Flat prefab-text input; see docs/gamefilehandling-reference.md.
            new() {Path = "dumpedPrefabText.txt", PackageOutput = true, TextFileType = TextFileType.PrefabText, EnableQualityReview = true },

            // Additional flat PrefabText source; see docs/gamefilehandling-reference.md.
            new() {Path = "dumpedPrefabTextFromOtherFields.txt", PackageOutput = true, TextFileType = TextFileType.PrefabText, EnableQualityReview = true },

            // Flat IL2CPP dynamic-string input; see docs/gamefilehandling-reference.md. QC
            // enabled: ordinary template dialogue lines here benefit from review like any other
            // translated prose; the function-routed choice entries (raw "{label};FunctionName",
            // e.g. "出手抢夺;RobNPCItemSure") are protected from QC via
            // GameFileHandling.ExcludeFunctionRoutedDynamicStringFromQc (CustomQcExclusionRule),
            // not by disabling the whole file.
            new() {Path = "dynamicStrings.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = true },

            // Additional dynamic-string source; see docs/gamefilehandling-reference.md.
            new() {Path = "dynamicStringsFromColumns.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = true },

            // ';'-joined structured-record fragments parsed out of dynamicStrings.txt - split into
            // its own file (was previously mixed into dynamicStringsFromColumns.txt) so each
            // dynamic-string file's provenance is unambiguous. See
            // DynamicStringExtraction.ExtractStructuredRecordFragmentCandidates.
            new() {Path = "dynamicStringsFromStructuredFragments.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = true },

            // The "log narrative" AddLog-template family (HeroDetailPanel's Log tab, AreaLog,
            // PlotPanel's RecordScrollView) - carved out of dynamicStrings.txt into its own file so
            // every template needing a DynamicStringResultOverrides naturalness fix is trivial to
            // find, and so DragonHeirPlugin can eventually route known-log-panel text through a
            // smaller compiled-template list. See DynamicStringSources.LogNarrativeTemplates and
            // DynamicStringExtraction.ExtractLogNarrativeCandidates for how this list is curated/
            // re-derived and how the split is made to stick through re-extraction. QC review enabled
            // (matches dynamicStrings.txt, the file these entries were split out of) - these are
            // ordinary prose narrative lines, not lookup-key/fragment data.
            new() {Path = "dynamicStringsLogNarratives.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = true },

            // Stat-label fragments parsed out of dumpedOtherText.txt (e.g. "spellEffectString")
            // - split into its own file (was previously mixed into dynamicStringsFromColumns.txt).
            // See DynamicStringExtraction.ExtractOtherFieldLabelCandidates.
            new() {Path = "dynamicStringsFromOtherFieldLabels.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = true },

            // Poetry minigame ("对诗" fill-in-the-blank) candidates extracted directly from the
            // JSON TextAsset/PoetryData.txt - see PoetryDataWorkflow.ExtractPoetryCandidates.
            // QC disabled: free-verse text, where a "more natural"-sounding QC rewrite is less
            // faithful to the source than the original translation.
            new() {Path = "dynamicStringsPoetry.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = false },

            // Banquet/drinking minigame poem-quote comma-split halves - see
            // DrinkQuoteWorkflow.ExtractDrinkQuoteCandidates.
            // QC disabled: same free-verse/quote rationale as dynamicStringsPoetry.txt above.
            new() {Path = "dynamicStringsDrinkQuotes.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = false },

            // SpeHeroData family/given-name halves - a DEDICATED file, deliberately NOT named
            // "dynamicStrings*" so it never matches DynamicStringPatches' DictionaryFilePattern
            // glob and never gets merged into that plugin's global substring-replace dictionary
            // (a bare one/two-character surname is far too easy to accidentally match as a
            // substring of unrelated Chinese text elsewhere in the game). Reuses the same
            // DynamicStringsIL2CPP export/translate/package plumbing (see DynamicStringWorkflow -
            // it is generic over TextFileToSplit.Path, nothing here is hardcoded to "dynamicStrings"
            // specifically), but the packaged heroNameParts.txt.yaml is loaded and applied ONLY by
            // HeroNamePatches' own private, exact-match dictionary - see HeroNamePatches.cs.
            // QC disabled: these are bare name fragments (pinyin), not prose - the QC model's
            // glossary/naturalness-oriented review doesn't apply here.
            new() {Path = "heroNameParts.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = false },

            // ForceData's first-2-character name prefix (e.g. "仙霞" from "仙霞派") - same dedicated-
            // file treatment as heroNameParts.txt above and for the same reason (a bare 2-character
            // fragment is too easy to accidentally match as a substring elsewhere). Loaded and
            // applied ONLY by HeroNamePatches' own private, exact-match force-name-prefix
            // dictionary - see HeroNamePatches.cs.
            new() {Path = "forceNameParts.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = false },

            // SpeHeroData's family/given-name compound with the "." removed (e.g. "姜映泉") - a
            // whole-name counterpart to heroNameParts.txt above, used by DragonHeirPlugin's
            // PlotInteractControllerPatches.GetHero_Prefix to reverse-translate an already-
            // translated hero display name back to the raw name WorldData.GetHero looks records
            // up by. Same dedicated-file/QC-disabled treatment as heroNameParts.txt/
            // forceNameParts.txt above and for the same reason.
            new() {Path = "heroFullNames.txt", PackageOutput = true, TextFileType = TextFileType.DynamicStringsIL2CPP, EnableQualityReview = false },
        ];
    }
}
