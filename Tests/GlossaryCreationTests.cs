using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using System.Xml.Linq;
using Tests.Code;
using ToolGood.Words;

namespace Tests;

public class GlossaryCreationTests
{
    [Fact]
    public async Task GetAreas()
    {
        await GenerateGlossaryFromIndex("AreaData.csv", 0, "Areas");
    }

    [Fact]
    public async Task GetFactions()
    {
        await GenerateGlossaryFromIndex("ForceData.csv", 0, "Factions");
    }

    [Fact]
    public async Task GetLoveInterest()
    {
        await GenerateGlossaryFromIndex("LoveableSpeHero.csv", 0, "LoveInterest");
    }

    [Fact]
    public async Task GetChatNames()
    {
        await GenerateGlossaryFromIndex("SpeHeroData.csv", 0, "ChatNames");
    }

    private static async Task GenerateGlossaryFromIndex(string path, int index, string name)
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            GameFileHandling.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != path)
                    return;

                foreach (var line in fileLines)
                {
                    var raw = line.Splits[index].Text;
                    if (items.Contains(raw))
                        continue;

                    items.Add(raw);

                    glossary.Add($"- raw: {raw}");
                    glossary.Add($"  result: {line.Splits[index].Translated}");
                    glossary.Add($"  badtrans: true");
                }

                await Task.CompletedTask;
            });

        File.WriteAllLines($"{workingDirectory}/TestResults/GlossaryExport/Export{name}.yaml", glossary);
    }

    [Fact]
    public void AnalyseGlossary()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var results = GlossaryWorkflow.AnalyseGlossaryForIssues(config.Runtime.GlossaryLines.ToArray());

        var yml = YamlHelper.CreateSerializer();
        var serialised = yml.Serialize(results);

        File.WriteAllText($"{workingDirectory}/TestResults/GlossaryAnalysis.yaml", serialised);
    }

    [Fact]
    public async Task GetNameDataOnly()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            GameFileHandling.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != "NameData.csv")
                    return;

                fileLines.RemoveAt(0);
                foreach (var line in fileLines)
                {
                    for (int i = 1; i < line.Splits.Count; i++)
                    {
                        //TODO: Find a library that can convert it to Pinyin without sending to LLM
                        var raw = line.Splits[i].Text;
                        var pinyin = WordsHelper.GetPinyin(raw).ToLower();
                        pinyin = char.ToUpper(pinyin[0]) + pinyin.Substring(1, pinyin.Length - 1);

                        if (items.Contains(raw))
                            continue;

                        items.Add(raw);
                        glossary.Add($"- raw: {raw}");
                        glossary.Add($"  result: {pinyin}");
                        //glossary.Add($"  result: {line.Splits[i].Translated}");
                        glossary.Add($"  badtrans: true");
                        glossary.Add($"  only: ");
                        glossary.Add($"    - NameData.csv ");
                    }
                }

                await Task.CompletedTask;
            });
        File.WriteAllLines($"{workingDirectory}/TestResults/GlossaryExport/ExportNameData.yaml", glossary);
    }
}
