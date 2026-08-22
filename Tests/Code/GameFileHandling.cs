using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests.Code
{
    public static class GameFileHandling
    {
        public const string WorkingDirectory = "../../../../Files";
        public const string GameFolder = "G:\\SteamLibrary\\steamapps\\common\\LongYinLiZhiZhuan";

        public static readonly TextFileToSplit[] TextFilesToSplit = [
            new() {Path = "AchievementData.csv", PackageOutput = true },
            new() {Path = "AreaData.csv", PackageOutput = true },
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
            var pattern = LineValidation.ChineseCharPattern;

            var dir = new DirectoryInfo($"{workingDirectory}/Raw/Dumped/GameData/");
            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                //So far the game uses pure CSV files, so we can just read all lines and split by commas
                var lines = File.ReadAllLines(file.FullName);

                var foundLines = new List<TranslationLine>();
                var lineIncrement = 0;

                foreach (var line in lines)
                {
                    lineIncrement++;

                    var splits = line.Split(",");
                    var foundSplits = new List<TranslationSplit>();

                    // Find Chinese
                    for (int i = 0; i < splits.Length; i++)
                    {
                        if (Regex.IsMatch(splits[i], pattern))
                        {
                            foundSplits.Add(new TranslationSplit()
                            {
                                Split = i,
                                Text = splits[i],
                            });
                        }
                    }

                    //The translation line
                    foundLines.Add(new TranslationLine()
                    {
                        //LineNum = lineNum,
                        Raw = line,
                        Splits = foundSplits,
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
                    var splits = line.Raw.Split(',');
                    var failed = false;

                    foreach (var split in line.Splits)
                    {
                        if (!textFileToTranslate.PackageOutput
                            || split.FlaggedForRetranslation
                            || !split.SafeToTranslate) //Count Failure
                        {
                            failed = true;
                            break;
                        }

                        //Check line to be extra safe
                        //if (Regex.IsMatch(split.Translated, @"(?<!\\)\n"))
                        //    failed = true;
                        //else
                        if (!string.IsNullOrEmpty(split.Translated))
                            splits[split.Split] = $"\"{split.Translated}\"";
                        //If it was already blank its all good
                        else if (!string.IsNullOrEmpty(split.Text))
                            failed = true;
                    }

                    line.Translated = string.Join(',', splits);

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
