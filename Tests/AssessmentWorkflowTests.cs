using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Workflow;

namespace Tests;

public class AssessmentWorkflowTests
{
    [Fact(DisplayName = "1. Assess configured translation models")]
    public async Task AssessConfiguredTranslationModels()
    {
        await TranslationAssessmentWorkflow.RunAsync(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit, GameFileHandling.Hooks);
    }

    [Fact(DisplayName = "2. Assess configured QC models")]
    public async Task AssessConfiguredQualityEvaluators()
    {
        await QualityEvaluatorAssessmentWorkflow.RunAsync(GameFileHandling.WorkingDirectory, GameFileHandling.Hooks);
    }
}