using Code;
using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using Tests.Code;

namespace Tests;

public class TranslationWorkflowTests
{

    [Fact(DisplayName = "0. Reset All Flags")]
    public async Task ResetAllFlags()
    {
        await TranslationWorkflow.ResetAllFlags(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
    }

    [Fact(DisplayName = "1. TranslateLinesBruteForce")]
    public async Task TranslateLinesBruteForce()
    {
        await TranslationWorkflow.TranslateLinesBruteForce(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
    }

    [Fact(DisplayName = "2. ApplyRulesToCurrentTranslation")]
    public async Task ApplyRulesToCurrentTranslation()
    {
        await TranslationWorkflow.ApplyAllRulesToCurrentTranslation(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
    }

    [Fact(DisplayName = "3. Translate Lines Only")]
    public async Task TranslateLines()
    {
        await TranslationWorkflow.TranslateLines(Constants.WorkingDirectory, GameTextFiles.TextFilesToSplit);
    }

    [Fact(DisplayName = "5. Flag some regexes")]
    public async Task SetSplitAsInvalid()
    {
        var badStrings = new List<string>
        {
            "⑩",
        };

        await TranslationWorkflow.SetSplitAsInvalid(Constants.WorkingDirectory, 
            GameTextFiles.TextFilesToSplit, badStrings);
    }

    [Fact(DisplayName = "6. Clean up some regexes")]
    public static async Task CleanUpSomeRegexes()
    {
        var regex = new List<(string pattern, string replacement)>
        {
            // Look for Number then "coin" or "wen" or "money" or "quan" or "liang", get the number portion
            (@"(\d+)(\s*)(coin|wen|money|quan|liang)", "$1 coin"),
        };

        await TranslationWorkflow.CleanUpSomeRegexes(Constants.WorkingDirectory,
            GameTextFiles.TextFilesToSplit, regex);
    }
}