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
            // Config-driven (not a directory scan) - matches ExportPrefabTextAssetToCustomFormat/
            // ExportDynamicStringTextAssetToCustomFormat below. A dumped file under
            // Raw/Dumped/GameData/ with no matching TextFileConfiguration entry is no longer
            // silently exported with an empty SkipColumns - every CSV file this pipeline cares
            // about is already listed there explicitly.
            foreach (var textFile in TextFileConfiguration.TextFilesToSplit.Where(t => t.TextFileType == TextFileType.RawCsv))
                CsvGameDataWorkflow.ExportToCustomFormat(workingDirectory, textFile, GameFileHandling.SplitterOptions);
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
