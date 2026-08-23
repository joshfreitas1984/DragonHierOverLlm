using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
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
            PlaceholderPatterns = [new Regex(@"#\w+#", RegexOptions.Compiled)]
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
        }

        // Matches an English possessive/contraction suffix the LLM sometimes glues inside a
        // "#PlaceholderToken#" wrapper instead of after it, e.g. "#PlayerName's#" - the placeholder
        // itself must stay exactly "#PlayerName#" for the game engine to substitute it at runtime,
        // so the suffix needs to be moved outside the closing '#' rather than sent back for a retry.
        private static readonly Regex PlaceholderTrailingSuffixRegex =
            new(@"#(\w+)('s|'re|'ve|'ll|'d|'t)#", RegexOptions.Compiled);

        private static string RepairKnownLlmQuirks(string raw, string llmResult)
        {
            if (string.IsNullOrEmpty(llmResult))
                return llmResult;

            return PlaceholderTrailingSuffixRegex.Replace(llmResult, "#$1#$2");
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
            new() {Path = "HeroTagData.csv", PackageOutput = true },
            new() {Path = "HorseData.csv", PackageOutput = true },
            new() {Path = "InnData.csv", PackageOutput = true },
            new() {Path = "KungFuData.csv", PackageOutput = true },
            new() {Path = "LoveableSpeHero.csv", PackageOutput = true },
            new() {Path = "MartialClubData.csv", PackageOutput = true },
            new() {Path = "MedData.csv", PackageOutput = true },
            new() {Path = "NameData.csv", PackageOutput = true,  },
            new() {Path = "ResourcePointTypeData.csv", PackageOutput = true },
            new() {Path = "SkinDataBase.csv", PackageOutput = true },
            new() {Path = "SpeAddDataBase.csv", PackageOutput = true },
            new() {Path = "SpeHeroData.csv", PackageOutput = true },
            //new() {Path = "SpeHeroFaceData.csv", PackageOutput = true },
            new() {Path = "SummonData.csv", PackageOutput = true },
            new() {Path = "SummonKungFuData.csv", PackageOutput = true },
            new() {Path = "TechDataBase.csv", PackageOutput = true },
            new() {Path = "TipsData.csv", PackageOutput = true },
            new() {Path = "WeaponData.csv", PackageOutput = true },

            // Main one
            new() {Path = "PlotData.csv", PackageOutput = true },
        ];

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
            throw new NotImplementedException();
        }

        public static void ExportDynamicStringTextAssetToCustomFormat(string workingDirectory)
        {
            throw new NotImplementedException();
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

            await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
                textFiles,
                async (outputFile, textFileToTranslate, fileLines) =>
            {
                var failedLines = new List<string>();
                var outputLines = new List<string>();

                foreach (var line in fileLines)
                {
                    // Regular DB handling
                    var splits = ParseCsvRow(line.Raw);
                    var failed = false;
                    var templatedColumns = line.Templates.Select(t => t.Split).ToHashSet();

                    foreach (var template in line.Templates)
                    {
                        if (template.Split < 0 || template.Split >= splits.Length)
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
