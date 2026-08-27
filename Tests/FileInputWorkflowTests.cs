using FanslationStudio.LlmKit;

namespace Tests;

public class FileInputWorkflowTests
{
    [Fact(DisplayName = "0. Copy raws to Working Directory")]
    public void CopyRaws()
    {
        var dumpedDirectory = $"{GameFileHandling.GameFolder}/BepinEx/plugins/raw";
        var rawDirectory = $"{GameFileHandling.WorkingDirectory}/Raw/Dumped";

        if (Directory.Exists(rawDirectory))
            Directory.Delete(rawDirectory, true);

        GameFileHandlingBase.CopyDirectory(dumpedDirectory, rawDirectory);
    }

    [Fact(DisplayName = "1. ExportAssetsIntoTranslated")]
    public void ExportAssetsIntoTranslated()
    {
        GameFileHandling.ExportGameSpecificTextAssetsToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "1b. ExportPrefabTextIntoTranslated")]
    public void ExportPrefabTextIntoTranslated()
    {
        GameFileHandling.ExportPrefabTextAssetToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "1c. ExportDynamicStringsIntoTranslated")]
    public void ExportDynamicStringsIntoTranslated()
    {
        GameFileHandling.ExportDynamicStringTextAssetToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    // Repeatable, config-driven extraction of whole-phrase strings (force/sect names, hero rank
    // tags, etc.) from specific CSV columns - see GameFileHandling.DynamicStringColumnSources'
    // doc comment for why these need their own dictionary entries instead of relying on
    // DynamicStringPatches' bare single-character fallback entries. Must run before "1c." (which
    // exports whatever is in Raw/Dumped/DynamicStrings/*.txt, including the
    // dynamicStringsFromColumns.txt this produces) - safe to re-run any time, already-extracted
    // values are never duplicated.
    [Fact(DisplayName = "1c-pre. ExtractDynamicStringCandidatesFromColumns")]
    public void ExtractDynamicStringCandidatesFromColumns()
    {
        GameFileHandling.ExtractDynamicStringCandidatesFromColumns(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "2. MergeFilesIntoTranslated")]
    public async Task MergeFilesIntoTranslated()
    {
        await GameFileHandlingBase
            .MergeFilesIntoTranslatedAsync(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "99. Check File Lines Match")]
    public void CheckFileLinesMatch()
    {
        var badFiles = GameFileHandlingBase
            .CheckFileLinesMatch(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
        Assert.Empty(badFiles);
    }
}
