using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;

namespace Tests
{
    // Exports dumped GameData/PrefabText/DynamicStringsIL2CPP assets into the custom translation
    // format ahead of LLM translation. See docs/gamefilehandling-reference.md.
    public static class TranslationExport
    {
        public static void ExportGameSpecificTextAssetsToCustomFormat(string workingDirectory)
        {
            string exportPath = $"{workingDirectory}/Raw/Export";
            string convertedPath = $"{workingDirectory}/Converted";

            if (!Directory.Exists(exportPath))
                Directory.CreateDirectory(exportPath);

            if (!Directory.Exists(convertedPath))
                Directory.CreateDirectory(convertedPath);

            var serializer = YamlHelper.CreateSerializer();
            var configByFileName = TextFileConfiguration.TextFilesToSplit.ToDictionary(t => t.Path, t => t);

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

                    var splits = GameFileHandling.ParseCsvRow(line);
                    var foundSplits = new List<TranslationSplit>();
                    var foundTemplates = new List<FieldTemplate>();

                    // Decompose translatable cells and retain templates for structured cells.
                    for (int i = 0; i < splits.Length; i++)
                    {
                        if (skipColumns.Contains(i))
                            continue;

                        var (template, fragments) = CompoundFieldSplitter.Decompose(splits[i], GameFileHandling.SplitterOptions);
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
            foreach (var textFile in TextFileConfiguration.TextFilesToSplit.Where(t => t.TextFileType == TextFileType.PrefabText))
                PrefabTextWorkflow.ExportPrefabTextToCustomFormat(workingDirectory, textFile, GameFileHandling.SplitterOptions);
        }

        public static void ExportDynamicStringTextAssetToCustomFormat(string workingDirectory)
        {
            foreach (var textFile in TextFileConfiguration.TextFilesToSplit.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP))
                DynamicStringWorkflow.ExportDynamicStringsToCustomFormat(workingDirectory, textFile, GameFileHandling.SplitterOptions);
        }
    }
}
