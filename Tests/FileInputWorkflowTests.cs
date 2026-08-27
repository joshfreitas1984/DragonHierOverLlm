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
        // All three automated candidate-extraction sources run first, in-process, so this single
        // fact covers the whole dynamic-strings workflow end to end - all are idempotent/safe to
        // re-run (already-extracted values are never duplicated) and must run before the export
        // below, which exports whatever ends up in Raw/Dumped/DynamicStrings/*.txt (including
        // dynamicStringsFromColumns.txt, which all three populate).
        //
        // Source 1: config-driven extraction of whole-phrase strings (force/sect names, hero rank
        // tags, etc.) from specific CSV columns - see GameFileHandling.DynamicStringColumnSources'
        // doc comment for why these need their own dictionary entries instead of relying on
        // DynamicStringPatches' bare single-character fallback entries.
        GameFileHandling.ExtractDynamicStringCandidatesFromColumns(GameFileHandling.WorkingDirectory);

        // Source 2: extraction from Files/Raw/Dumped/PrefabText/dumpedOtherText.txt (produced by
        // the separate, one-off AssetDumperWorkflowTests.DumpChineseTextFromAssets asset scan) -
        // see GameFileHandling.DynamicStringOtherTextFields' doc comment for exactly which
        // MonoBehaviour field names are trusted and why. Only finds anything new after the asset
        // dumper has been (re-)run at least once.
        GameFileHandling.ExtractDynamicStringCandidatesFromOtherText(GameFileHandling.WorkingDirectory);

        // Source 3: regenerates Converter/output/_dynamicStrings_candidates.txt FRESH (by shelling
        // out to the sibling Converter project) from the current Converter/output/_string_map.csv
        // every run, rather than trusting whatever candidates file happens to already be on disk -
        // see GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap's doc comment for
        // why this exists (a stale candidates file previously hid genuinely-new strings after a
        // game patch). No-ops gracefully if the Converter project hasn't produced a _string_map.csv
        // yet (e.g. a fresh clone that hasn't run the full decompile pipeline).
        GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap(GameFileHandling.WorkingDirectory);

        GameFileHandling.ExportDynamicStringTextAssetToCustomFormat(GameFileHandling.WorkingDirectory);
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
