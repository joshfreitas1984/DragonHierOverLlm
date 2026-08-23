using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using static FanslationStudio.LlmKit.GameFileHandlingBase;

namespace Tests;

public class TranslationWorkflowTests
{

    [Fact(DisplayName = "0. Reset All Flags")]
    public async Task ResetAllFlags()
    {
        await TranslationWorkflow.ResetAllFlags(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "1. TranslateLinesBruteForce")]
    public async Task TranslateLinesBruteForce()
    {
        await TranslationWorkflow.TranslateLinesBruteForce(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "2. ApplyRulesToCurrentTranslation")]
    public async Task ApplyRulesToCurrentTranslation()
    {
        await TranslationWorkflow.ApplyAllRulesToCurrentTranslation(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "3. Translate Lines Only")]
    public async Task TranslateLines()
    {
        await TranslationWorkflow.TranslateLines(GameFileHandling.WorkingDirectory, GameFileHandling.TextFilesToSplit);
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
            GameFileHandling.TextFilesToSplit, badStrings);
    }

    [Fact(DisplayName = "5. Flag some regexes")]
    public async Task SetSplitAsInvalid()
    {
        var badStrings = new List<string>
        {
            "⑩",
        };

        await TranslationWorkflow.SetSplitAsInvalid(GameFileHandling.WorkingDirectory,
            GameFileHandling.TextFilesToSplit, badStrings);
    }

    [Fact(DisplayName = "6. Clean up some regexes")]
    public static async Task CleanUpSomeRegexes()
    {
        var regex = new List<(string pattern, string replacement)>
        {
            // Look for Number then "coin" or "wen" or "money" or "quan" or "liang", get the number portion
            (@"(\d+)(\s*)(coin|wen|money|quan|liang)", "$1 coin"),
        };

        await TranslationWorkflow.CleanUpSomeRegexes(GameFileHandling.WorkingDirectory,
            GameFileHandling.TextFilesToSplit, regex);
    }

    [Fact(DisplayName = "4. Find All Failing Translations")]
    public async Task FindAllFailingTranslations()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        (List<FailedTranslation> failures, List<string> forTheGlossary) =
            await GetFailedTranslations(workingDirectory, GameFileHandling.TextFilesToSplit);

        var serializer = YamlHelper.CreateSerializer();
        var yaml = serializer.Serialize(failures);
        File.WriteAllText($"{workingDirectory}/TestResults/FailedTranslations.yaml", yaml);
        File.WriteAllLines($"{workingDirectory}/TestResults/ForManualTrans.yaml", forTheGlossary);
    }
}