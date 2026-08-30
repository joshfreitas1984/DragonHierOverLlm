using FanslationStudio.LlmKit;

namespace Tests;

public class FileInputWorkflowTests
{


    [Fact(DisplayName = "1. ExportAssetsIntoTranslated")]
    public void ExportAssetsIntoTranslated()
    {
        GameFileHandling.ExportGameSpecificTextAssetsToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "1b. ExportPrefabTextIntoTranslated")]
    public void ExportPrefabTextIntoTranslated()
    {
        // Must run before the export below, which exports whatever ends up in
        // Raw/Dumped/PrefabText/*.txt (including dumpedPrefabTextFromOtherFields.txt) - see
        // GameFileHandling.DynamicStringOtherTextFields' doc comment for exactly which
        // MonoBehaviour field names are trusted and why, and
        // ExtractDynamicStringCandidatesFromOtherText's own doc comment for why this now feeds
        // the PrefabText (exact-match) pipeline instead of DynamicStringsIL2CPP
        // (substring-match). Idempotent/safe to re-run (already-extracted values are never
        // duplicated) and only finds anything new after AssetDumperWorkflowTests'
        // DumpChineseTextFromAssets asset scan has been (re-)run at least once.
        GameFileHandling.ExtractDynamicStringCandidatesFromOtherText(GameFileHandling.WorkingDirectory);

        GameFileHandling.ExportPrefabTextAssetToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "1c. ExportDynamicStringsIntoTranslated")]
    public void ExportDynamicStringsIntoTranslated()
    {
        // Both remaining automated candidate-extraction sources run first, in-process, so this
        // single fact covers the whole dynamic-strings workflow end to end - both are
        // idempotent/safe to re-run (already-extracted values are never duplicated) and must run
        // before the export below, which exports whatever ends up in
        // Raw/Dumped/DynamicStrings/*.txt (including dynamicStringsFromColumns.txt, which both
        // populate).
        //
        // Source 1: config-driven extraction of whole-phrase strings (force/sect names, hero rank
        // tags, etc.) from specific CSV columns - see GameFileHandling.DynamicStringColumnSources'
        // doc comment for why these need their own dictionary entries instead of relying on
        // DynamicStringPatches' bare single-character fallback entries.
        GameFileHandling.ExtractDynamicStringCandidatesFromColumns(GameFileHandling.WorkingDirectory);

        // Source 1b: SpeHeroData family/given-name halves, written to their OWN dedicated
        // heroNameParts.txt (NOT merged into dynamicStringsFromColumns.txt above) - see
        // GameFileHandling.ExtractHeroNamePartCandidates' doc comment for why these must stay out
        // of DynamicStringPatches' global substring-replace dictionary.
        GameFileHandling.ExtractHeroNamePartCandidates(GameFileHandling.WorkingDirectory);

        // Source 2 (formerly "Source 2" here, extracting from dumpedOtherText.txt) now runs in
        // "1b" above instead, feeding the PrefabText pipeline rather than this one - see
        // ExtractDynamicStringCandidatesFromOtherText's doc comment.
        //
        // Source 3: regenerates Converter/output/_dynamicStrings_candidates.txt FRESH (by shelling
        // out to the sibling Converter project) from the current Converter/output/_string_map.csv
        // every run, rather than trusting whatever candidates file happens to already be on disk,
        // and appends any genuinely-new entries STRAIGHT into the master dynamicStrings.txt dump
        // (also bootstraps that file the first time it's missing entirely, e.g. fresh clone or
        // after deleting Raw/Dumped) - there is no manual review/curation step in practice, despite
        // older doc comments implying one; dynamicStrings.txt IS this candidates file, deduped and
        // accumulated over time. No-ops gracefully if the Converter project hasn't produced a
        // _string_map.csv yet (e.g. a fresh clone that hasn't run the full decompile pipeline) - in
        // that case dynamicStrings.txt must already exist from a previous run or "1c." will fail.
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
