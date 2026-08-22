using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests.Code
{
    public static class InputFileHandling
    {
        public static void ExportDynamicStringTextAssetToCustomFormat(string workingDirectory)
        {
            throw new NotImplementedException();
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
    }
}
