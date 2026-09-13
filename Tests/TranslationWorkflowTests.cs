using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using ToolGood.Words;
using static FanslationStudio.LlmKit.GameFileHandlingBase;

namespace Tests;

public class TranslationWorkflowTests
{

    [Fact(DisplayName = "0. Reset All Flags")]
    public async Task ResetAllFlags()
    {
        await TranslationWorkflow.ResetAllFlags(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit);
    }

    [Fact(DisplayName = "1. TranslateLinesBruteForce")]
    public async Task TranslateLinesBruteForce()
    {
        await TranslationWorkflow.TranslateLinesBruteForce(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
        await FileOutputWorkflowTests.PackageFinalTranslation();
    }

    // The full "I changed the glossary / got file updates / exported more dynamic strings / added a
    // bad word / needed a new game repair" workflow in one call: brute-forces Translated back to
    // clean (TranslationWorkflow.TranslateLinesBruteForce), then does the same for QcTranslated
    // (QualityReviewWorkflow.RunBruteForce - a no-op if qualityReview.enabled is false), then
    // packages. Use this instead of running "1" and "3b" separately when you want QC kept in sync
    // too.
    [Fact(DisplayName = "1a. TranslateAndQualityReviewBruteForce")]
    public async Task TranslateAndQualityReviewBruteForce()
    {
        await TranslationWorkflow.TranslateLinesBruteForce(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
        await QualityReviewWorkflow.RunBruteForce(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, hooks: GameFileHandling.Hooks);
        await FileOutputWorkflowTests.PackageFinalTranslation();
    }

    [Fact(DisplayName = "2. ApplyRulesToCurrentTranslation")]
    public async Task ApplyRulesToCurrentTranslation()
    {
        await TranslationWorkflow.ApplyAllRulesToCurrentTranslation(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
    }

    [Fact(DisplayName = "2. ApplyRulesToQCReview")]
    public async Task ApplyRulesToQCReview()
    {
        await QualityReviewWorkflow.ApplyRulesToCurrentQcTranslated(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
    }

    [Fact(DisplayName = "3. Translate Lines Only")]
    public async Task TranslateLines()
    {
        await TranslationWorkflow.TranslateLines(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
        await FileOutputWorkflowTests.PackageFinalTranslation();
    }

    // Run this BEFORE "3b" the first time you try a candidate qualityReview model - reviews only a
    // small random sample (see QualityReviewWorkflow.RunAsync's sampleSize) instead of every
    // eligible column, so you can judge a model's real speed/score-distribution/correction-quality
    // on your hardware before committing an entire run to it. See docs/plans/quality-review-pass.md's
    // "Sample run before committing to a full-corpus pass". A no-op if qualityReview.enabled is
    // false.
    [Fact(DisplayName = "3a. RunQualityReviewPassSample")]
    public async Task RunQualityReviewPassSample()
    {
        await QualityReviewWorkflow.RunAsync(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, sampleSize: 300, hooks: GameFileHandling.Hooks);
    }

    // Independent of the main translate/apply-rules/translate-lines steps above - reviews
    // already-translated text against a separately configured model (Config.yaml's
    // qualityReview: section), proposes corrections, and validates them before writing anything.
    // See docs/plans/quality-review-pass.md. A no-op (logs and returns) if qualityReview.enabled
    // is false, so it's safe to run even before the feature is configured for a real run.
    [Fact(DisplayName = "3b. RunQualityReviewPass")]
    public async Task RunQualityReviewPass()
    {
        await QualityReviewWorkflow.RunAsync(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit, hooks: GameFileHandling.Hooks);
    }

    // Reporting-only, mirrors "4. Find All Failing Translations" but scoped to quality-review
    // flags (a rejected correction, or a low QcQualityScore) instead of translation failures - see
    // QualityReviewWorkflow.GetFlaggedQcReviews.
    [Fact(DisplayName = "3c. Find Flagged Quality Review Items")]
    public async Task FindFlaggedQcReviews()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var flagged = await QualityReviewWorkflow.GetFlaggedQcReviews(workingDirectory, TextFileConfiguration.TextFilesToSplit);

        var serializer = YamlHelper.CreateSerializer();
        var yaml = serializer.Serialize(flagged);
        FileHelper.WriteAllTextWithRetry($"{workingDirectory}/TestResults/FlaggedQcReviews.yaml", yaml);
    }

    // Run this after fixing whatever was causing a persistent QC rule violation (e.g. removed a
    // false-positive bad word, loosened a glossary rule) so columns QualityReviewWorkflow.RunBruteForce
    // already gave up on (see TranslationSplit.QcRuleCheckFailureCount) get retried instead of
    // staying parked forever. A no-op for everything else.
    [Fact(DisplayName = "3d. Reset Qc Retry Limits")]
    public async Task ResetQcRetryLimits()
    {
        await QualityReviewWorkflow.ResetQcRetryLimits(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit);
    }

    // Sweeps every already-QC'd column for a stored QcTranslated/QcRejectedCorrection that leaked QC
    // protocol text (a stray "NONE", "SCORE:", "CORRECTED:", etc. - see
    // QualityReviewWorkflow.ContainsLeakedProtocolText) rather than a clean correction. This catches
    // corruption that got past an earlier, narrower version of the leak guard - e.g. the
    // "Sword Technique Power NONE" case, where the guard only rejected a response that was *exactly*
    // "NONE", not one with "NONE" stuck onto real text. Any match is reset back to QcStatus.NotReviewed
    // (full TranslationSplit.ResetQcState) so the next "3a"/"3b" run gives it a genuinely fresh review.
    // Safe to run any time - a no-op once the corpus is clean.
    [Fact(DisplayName = "3e. Reset Leaked Quality Review Corrections")]
    public async Task ResetLeakedQcCorrections()
    {
        await QualityReviewWorkflow.ResetLeakedQcCorrections(GameFileHandling.WorkingDirectory, TextFileConfiguration.TextFilesToSplit);
    }

    // Dedicated single-row QC sample: forces a fresh QualityReviewWorkflow review of exactly ONE
    // known PlotData.csv row (the master's "别慌..." collapse line, split 10 - see
    // Files/Converted/PlotData.csv.yaml) instead of a random sampleSize=N slice
    // (RunQualityReviewPassSample) or a full corpus pass (RunQualityReviewPass). Useful for
    // iterating on the BaseQualityReviewPrompt/model/glossary and immediately seeing how just this
    // row's QC verdict changes, without waiting on (or perturbing the Qc state of) every other
    // already-reviewed row. Scoping textFiles to only PlotData.csv keeps RunAsync's freshness check
    // from doing any real work outside this one row - every other row/column in the file is still
    // "fresh" (its QcReviewedText already matches its current Translated) and gets skipped with no
    // LLM call, exactly like a normal RunAsync pass would treat it.
    //
    // To point this at a different row, change TargetRawFragment below to the exact `text` of the
    // split-10 (or whichever column) anchor fragment you want to compare, as it appears in
    // Files/Converted/PlotData.csv.yaml.
    [Fact(DisplayName = "3f. RunQualityReviewSampleForOneLine")]
    public async Task RunQualityReviewSampleForOneLine()
    {
        const string TargetFile = "PlotData.csv";
        const string TargetRawFragment = "莫慌，让为师看看……";

        var workingDirectory = GameFileHandling.WorkingDirectory;
        var textFiles = TextFileConfiguration.TextFilesToSplit
            .Where(t => t.Path == TargetFile)
            .ToArray();

        Assert.True(textFiles.Length > 0, $"No configured TextFileToSplit entry for '{TargetFile}'.");

        TranslationLine? targetLine = null;
        TranslationSplit? targetAnchor = null;
        string? beforeReviewedText = null;
        string? beforeQcTranslated = null;
        QcStatus? beforeStatus = null;
        int? beforeScore = null;

        // Pass 1: locate the row, snapshot its current Qc state, then force a fresh review by
        // resetting just this one column's Qc fields (ResetQcState) - everything else in the file
        // is left untouched.
        await FileIteration.IterateTranslatedFilesAsync(workingDirectory, textFiles, async (outputFile, textFile, fileLines) =>
        {
            foreach (var line in fileLines)
            {
                var anchor = line.Splits.FirstOrDefault(s => s.Text == TargetRawFragment && s.SubIndex == 0);
                if (anchor == null)
                    continue;

                targetLine = line;
                targetAnchor = anchor;
                beforeReviewedText = anchor.QcReviewedText;
                beforeQcTranslated = anchor.QcTranslated;
                beforeStatus = anchor.QcStatus;
                beforeScore = anchor.QcQualityScore;

                anchor.ResetQcState();
                break;
            }

            if (targetAnchor != null)
            {
                var serializer = YamlHelper.CreateSerializer();
                await FileHelper.WriteAllTextWithRetryAsync(outputFile, serializer.Serialize(fileLines));
            }
        });

        Assert.True(targetAnchor != null, $"Could not find a split-10 anchor in '{TargetFile}' with text '{TargetRawFragment}'.");

        // Pass 2: the actual QC pass, scoped to just this one file (and, thanks to the reset above,
        // effectively just this one row - every other row is still fresh and gets skipped for free).
        await QualityReviewWorkflow.RunAsync(workingDirectory, textFiles, hooks: GameFileHandling.Hooks);

        // Pass 3: re-read and report the before/after comparison, reusing the same shape
        // QualityReviewWorkflow.FlaggedQcReview already uses so this slots into the existing
        // FlaggedQcReviews.yaml reporting conventions.
        string? afterReviewedText = null;
        string? afterQcTranslated = null;
        QcStatus? afterStatus = null;
        int? afterScore = null;
        string? afterRejectedCorrection = null;
        string? afterFailureReason = null;
        string rawText = TargetRawFragment;

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory, textFiles, async (_, textFile, fileLines) =>
        {
            foreach (var line in fileLines)
            {
                var anchor = line.Splits.FirstOrDefault(s => s.Text == TargetRawFragment && s.SubIndex == 0);
                if (anchor == null)
                    continue;

                var template = line.Templates.FirstOrDefault(t => t.Split == anchor.Split);
                var fragments = line.Splits.Where(s => s.Split == anchor.Split).OrderBy(s => s.SubIndex).ToList();
                rawText = template != null
                    ? CompoundFieldSplitter.Reconstruct(template.Template, fragments.Select(f => f.Text).ToList())
                    : anchor.Text;

                afterReviewedText = anchor.QcReviewedText;
                afterQcTranslated = anchor.QcTranslated;
                afterStatus = anchor.QcStatus;
                afterScore = anchor.QcQualityScore;
                afterRejectedCorrection = string.IsNullOrEmpty(anchor.QcRejectedCorrection) ? null : anchor.QcRejectedCorrection;
                afterFailureReason = string.IsNullOrEmpty(anchor.QcFailureReason) ? null : anchor.QcFailureReason;
                break;
            }

            await Task.CompletedTask;
        });

        var comparison = new
        {
            filePath = TargetFile,
            text = rawText,
            before = new { qcReviewedText = beforeReviewedText, qcTranslated = beforeQcTranslated, qcStatus = beforeStatus, qcQualityScore = beforeScore },
            after = new { qcReviewedText = afterReviewedText, qcTranslated = afterQcTranslated, qcStatus = afterStatus, qcQualityScore = afterScore, rejectedCorrection = afterRejectedCorrection, reason = afterFailureReason },
        };

        var reportSerializer = YamlHelper.CreateSerializer();
        var yaml = reportSerializer.Serialize(comparison);
        FileHelper.WriteAllTextWithRetry($"{workingDirectory}/TestResults/QcReviewSample_SingleLine.yaml", yaml);

        Console.WriteLine(yaml);
    }

    [Fact(DisplayName = "5. Flag lines corrupted by bracket-split bug for retranslation")]
    public async Task SetBracketSplitBugLinesAsInvalid()
    {
        // FanslationStudio.LlmKit's TranslationService.SplitBracketsRegexIfNeededAsync had a bug:
        // it translated each bracket's inner content, then discarded that translation and spliced
        // in a mangled substring of an internal placeholder number instead (usually empty, or a
        // single digit) when restoring the bracket in the final result. This was live while
        // splitRegexPatterns included these bracket pairs (enabled in the "First cut of
        // translation"/"Second round" commits, disabled again in "Pre-run") - any split whose raw
        // Text contains one of these bracket characters went through that path and needs
        // retranslation now that the bug is fixed.
        var badStrings = new List<string>
        {
            "《", "》",
            "〈", "〉",
            "「", "」",
            "『", "』",
            "【", "】",
            "〖", "〗",
            "\u201C", "\u201D", // “ ”
        };

        await TranslationWorkflow.SetSplitAsInvalid(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit, badStrings);
    }

    [Fact(DisplayName = "5. Flag some regexes")]
    public async Task SetSplitAsInvalid()
    {
        var badStrings = new List<string>
        {
            "⑩",
        };

        await TranslationWorkflow.SetSplitAsInvalid(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit, badStrings);
    }

    [Fact(DisplayName = "5. Flag single Chinese character strings")]
    public async Task SetSingleChineseCharacterSplitsAsInvalid()
    {
        var badPatterns = new List<string>
        {
            // Matches a split whose entire text (after trimming whitespace) is exactly one CJK character.
            @"^\s*\p{IsCJKUnifiedIdeographs}\s*$",
        };

        await TranslationWorkflow.SetSplitAsInvalidByRegex(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit, badPatterns);
    }

    [Fact(DisplayName = "6. Clean up some regexes")]
    public static async Task CleanUpSomeRegexes()
    {
        var regex = new List<(string pattern, string replacement)>
        {
            // Look for Number then "coin" or "wen" or "money" or "quan" or "liang", get the number portion
            (@"(\d+)(\s*)(coin|wen|money|quan|liang)", "$1 coin"),

            // Game placeholder tokens (#PlayerName#, #$TargetInteractName#, etc.) can end up glued
            // directly onto adjacent translated words with no space, since the translated sentence
            // doesn't preserve the original Chinese's lack of word-spacing around the token. Insert
            // a space on whichever side is missing one, without touching sides that already have a
            // space, punctuation, or are at the start/end of the string.
            // Two placeholder tokens can appear back-to-back sharing a single '#' between them
            // (e.g. "#TargetForceDescribe#$TargetInteractName#" - only 3 '#' chars total, not 4),
            // so the token pattern must match the whole chain in one go (`(?:\$?\w+#)+`) - otherwise
            // the letter at the end of the first token's name gets treated as a real translated
            // word glued to the second token, and a space gets wrongly inserted *inside* the chain.
            (@"(#(?:\$?\w+#)+)([A-Za-z])", "$1 $2"),
            (@"([A-Za-z])(#(?:\$?\w+#)+)", "$1 $2"),
        };

        await TranslationWorkflow.CleanUpSomeRegexes(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit, regex);
    }

    [Fact(DisplayName = "4. Find All Failing Translations")]
    public async Task FindAllFailingTranslations()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        (List<FailedTranslation> failures, List<string> forTheGlossary) =
            await GetFailedTranslations(workingDirectory, TextFileConfiguration.TextFilesToSplit);

        var serializer = YamlHelper.CreateSerializer();
        var yaml = serializer.Serialize(failures);
        FileHelper.WriteAllTextWithRetry($"{workingDirectory}/TestResults/FailedTranslations.yaml", yaml);
        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/ForManualTrans.yaml", forTheGlossary);
    }

    [Fact(DisplayName = "7. Reset hero names")]
    public async Task ResetHeroNames()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var output = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            TextFileConfiguration.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != "heroNameParts.txt")
                    return;

                foreach (var line in fileLines)
                {
                    for (int i = 0; i < line.Splits.Count; i++)
                    {
                        var raw = line.Splits[i].Text;
                        var pinyin = WordsHelper.GetPinyin(raw).ToLower();
                        pinyin = char.ToUpper(pinyin[0]) + pinyin.Substring(1, pinyin.Length - 1);

                        line.Splits[i].Translated = pinyin;
                    }
                }

                var serializer = YamlHelper.CreateSerializer();
                var content = serializer.Serialize(fileLines);

                FileHelper.WriteAllTextWithRetry($"{workingDirectory}/Converted/heroNameParts.txt.yaml", content);

                await Task.CompletedTask;
            });
    }
}