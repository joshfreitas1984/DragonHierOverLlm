using Code;
using FanslationStudio.LlmKit;
using Tests.Code;

namespace Tests;

public class FileInputWorkflowTests
{
    [Fact(DisplayName = "0. Copy raws to Working Directory")]
    public void CopyRaws()
    {
        var dumpedDirectory = $"{Constants.GameFolder}/BepinEx/plugins/raw";
        var rawDirectory = $"{Constants.WorkingDirectory}/Raw/Dumped";

        if (Directory.Exists(rawDirectory))
            Directory.Delete(rawDirectory, true);

        FileOutputHandling.CopyDirectory(dumpedDirectory, rawDirectory);
    }

    [Fact(DisplayName = "1. ExportAssetsIntoTranslated")]
    public void ExportAssetsIntoTranslated()
    {
        InputFileHandling.ExportGameSpecificTextAssetsToCustomFormat(Constants.WorkingDirectory);
    }

    [Fact(DisplayName = "2. MergeFilesIntoTranslated")]
    public async Task MergeFilesIntoTranslated()
    {
        await InputFileHandlingBase
            .MergeFilesIntoTranslatedAsync(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
    }

    [Fact(DisplayName = "99. Check File Lines Match")]
    public void CheckFileLinesMatch()
    {
        var badFiles = InputFileHandlingBase
            .CheckFileLinesMatch(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
        Assert.Empty(badFiles);
    }
}
