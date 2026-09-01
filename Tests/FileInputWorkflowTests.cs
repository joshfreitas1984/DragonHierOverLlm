using FanslationStudio.LlmKit;

namespace Tests;

public class FileInputWorkflowTests
{

    [Fact(DisplayName = "1. ExportAssetsIntoTranslated")]
    public void ExportAssetsIntoTranslated()
    {
        GameFileHandling.ExportGameSpecificTextAssetsToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "2. ExportPrefabTextIntoTranslated")]
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

    [Fact(DisplayName = "3. ExtractIl2CppStringMapCandidates")]
    public void ExtractIl2CppStringMapCandidates()
    {
        // Regenerates Converter/output/_dynamicStrings_candidates.txt FRESH (by shelling out to
        // the sibling Converter project) from the current Converter/output/_string_map.csv every
        // run, and appends any genuinely-new entries straight into the master dynamicStrings.txt
        // dump (also bootstraps that file the first time it's missing entirely). No-ops
        // gracefully if the Converter project hasn't produced a _string_map.csv yet - in that
        // case dynamicStrings.txt must already exist from a previous run or "1f." will find
        // nothing new to work from.
        GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "4a. ExtractColumnCandidates")]
    public void ExtractColumnCandidates()
    {
        // Config-driven extraction of whole-phrase strings (force/sect names, hero rank tags,
        // etc.) from specific CSV columns - see GameFileHandling.DynamicStringColumnSources' doc
        // comment for why these need their own dictionary entries instead of relying on
        // DynamicStringPatches' bare single-character fallback entries. Writes only
        // dynamicStringsFromColumns.txt. Idempotent (re-running never duplicates within this
        // file); cross-file duplicates are handled separately by "1i.".
        GameFileHandling.ExtractDynamicStringCandidatesFromColumns(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "4b. ExtractHeroNamePartCandidates")]
    public void ExtractHeroNamePartCandidates()
    {
        // SpeHeroData family/given-name halves, written to their OWN dedicated heroNameParts.txt
        // (never merged into DynamicStringPatches' global substring-replace dictionary) - see
        // GameFileHandling.ExtractHeroNamePartCandidates' doc comment.
        GameFileHandling.ExtractHeroNamePartCandidates(GameFileHandling.WorkingDirectory);
    }



    [Fact(DisplayName = "4c ExtractStructuredRecordFragmentCandidates")]
    public void ExtractStructuredRecordFragmentCandidates()
    {
        // Splits ';'-joined structured-record candidates (only ever found whole inside a binary
        // literal dumped by "3.", e.g. "包扎;HospitalCureExternalInjury;;;技能影响:医术") into
        // their own standalone Name/Description-style fragments - see
        // GameFileHandling.ExtractStructuredRecordFragmentCandidates' doc comment. Must run after
        // "3.", which is what refreshes the master dynamicStrings.txt dump this reads from.
        // Writes only dynamicStringsFromStructuredFragments.txt.
        GameFileHandling.ExtractStructuredRecordFragmentCandidates(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "4d. ExtractOtherFieldLabelCandidates")]
    public void ExtractOtherFieldLabelCandidates()
    {
        // Stat-label fragments (e.g. "spellEffectString") parsed out of dumpedOtherText.txt
        // (the same source "1b." reads) - see GameFileHandling.ExtractOtherFieldLabelCandidates'
        // doc comment. Writes only dynamicStringsFromOtherFieldLabels.txt.
        GameFileHandling.ExtractOtherFieldLabelCandidates(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "4e. ExtractPoetryCandidates")]
    public void ExtractPoetryCandidates()
    {
        // Poem minigame ("对诗") title/author/paragraph-line candidates read directly from the
        // JSON TextAsset/PoetryData.txt - see PoetryDataWorkflow.ExtractPoetryCandidates' doc
        // comment. Writes only dynamicStringsPoetry.txt.
        PoetryDataWorkflow.ExtractPoetryCandidates(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "5. DedupeDynamicStringFiles")]
    public void DedupeDynamicStringFiles()
    {
        // Final, authoritative cross-file dedup pass over every Raw/Dumped/DynamicStrings/*.txt
        // file - safe/idempotent regardless of which of 1c-1h ran, how many times, or in what
        // order. See GameFileHandling.DedupeDynamicStringFiles' doc comment for the priority
        // order used when a value exists in more than one file.
        GameFileHandling.DedupeDynamicStringFiles(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "6. ExportDynamicStringFilesIntoTranslated")]
    public void ExportDynamicStringFilesIntoTranslated()
    {
        // Pure "serialize whatever's on disk now" step - exports every configured
        // DynamicStringsIL2CPP file (dynamicStrings.txt, dynamicStringsFromColumns.txt,
        // dynamicStringsFromStructuredFragments.txt, dynamicStringsFromOtherFieldLabels.txt,
        // dynamicStringsPoetry.txt, heroNameParts.txt) into Files/Converted/*.yaml. Must run after
        // 1c-1i have populated/deduped Raw/Dumped/DynamicStrings/*.txt.
        GameFileHandling.ExportDynamicStringTextAssetToCustomFormat(GameFileHandling.WorkingDirectory);
    }

    [Fact(DisplayName = "99. MergeFilesIntoTranslated")]
    public async Task MergeFilesIntoTranslated()
    {
        await GameFileHandlingBase
            .MergeFilesIntoTranslatedAsync(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "999. Check File Lines Match")]
    public void CheckFileLinesMatch()
    {
        var badFiles = GameFileHandlingBase
            .CheckFileLinesMatch(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
        Assert.Empty(badFiles);
    }
}
