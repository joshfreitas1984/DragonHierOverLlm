using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;
using System.Xml.Linq;
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

    [Fact]
    public async Task GetSpeAddLabels()
    {
        // SpeAddDataBase.csv and ForceSpeAddDataBase.csv's label column (split 1, "特效"/"Special
        // effects" header) is looked up by GameDataController.StringToSpeAddData via an exact
        // String.Equals against the label half of a "Label+Number" fragment embedded in
        // HeroTagData.csv's "效果" column and ResourcePointTypeData.csv's "守城效果" column (both
        // currently SkipColumns'd in GameFileHandling.cs - see dragonheirplugin.instructions.md's
        // "CONFIRMED root cause" section for the game-data-load abort/crash this caused when the
        // two sides were translated inconsistently). This glossary pins every label to a single,
        // consistent English translation across all four files, restricted via "only" so it
        // doesn't leak into unrelated translations. Once this glossary is populated and reviewed,
        // the SkipColumns entries for HeroTagData.csv/ResourcePointTypeData.csv can be removed and
        // the pipeline re-run to translate those columns safely.
        var only = new List<string>
        {
            "SpeAddDataBase.csv",
            "ForceSpeAddDataBase.csv",
            "HeroTagData.csv",
            "ResourcePointTypeData.csv",
        };

        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            GameFileHandling.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != "SpeAddDataBase.csv" && textFileToTranslate.Path != "ForceSpeAddDataBase.csv")
                    return;

                foreach (var line in fileLines)
                {
                    if (line.Splits.Count <= 1)
                        continue;

                    var raw = line.Splits[1].Text;
                    if (string.IsNullOrEmpty(raw) || items.Contains(raw))
                        continue;

                    items.Add(raw);

                    glossary.Add($"- raw: {raw}");
                    glossary.Add($"  result: {line.Splits[1].Translated}");
                    glossary.Add($"  badtrans: true");
                    glossary.Add($"  only: ");
                    foreach (var file in only)
                        glossary.Add($"    - {file}");
                }

                await Task.CompletedTask;
            });

        File.WriteAllLines($"{workingDirectory}/TestResults/GlossaryExport/ExportSpeAddLabels.yaml", glossary);
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
                        glossary.Add($"  badtrans: false");
                        glossary.Add($"  only: ");
                        glossary.Add($"    - NameData.csv ");
                    }
                }

                await Task.CompletedTask;
            });
        File.WriteAllLines($"{workingDirectory}/TestResults/GlossaryExport/ExportNameData.yaml", glossary);
    }
}
