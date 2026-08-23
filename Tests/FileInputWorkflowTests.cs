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

    [Fact(DisplayName = "CSV rows round-trip without breaking quoted fields")]
    public void CsvRowsRoundTripWithoutBreakingQuotedFields()
    {
        var raw = "0,正厅,0,\"门派弟子?查看弟子相关信息--ShowForceHero;门派职位?管理门派特殊职位-我&长老-ManageForceSetting\",1,1,0";

        var parts = GameFileHandling.ParseCsvRow(raw);
        Assert.Equal(7, parts.Length);
        Assert.Equal("门派弟子?查看弟子相关信息--ShowForceHero;门派职位?管理门派特殊职位-我&长老-ManageForceSetting", parts[3]);
        Assert.Equal(raw, GameFileHandling.RebuildCsvRow(parts));
    }
}
