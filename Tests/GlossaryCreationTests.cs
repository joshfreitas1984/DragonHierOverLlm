using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Configuration;
using FanslationStudio.LlmKit.Support;
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
    public async Task GetNicknames()
    {
        await GenerateGlossaryFromDumpedRaw("SpeHeroData.csv", 15, "Nicknames");
    }

    [Fact]
    public async Task GetTalents()
    {
        await GenerateGlossaryFromDumpedRaw("HeroTagData.csv", 1, "Talents",
            translate: true,
            only: ["dynamicStringsFromColumns.txt"]);
    }

    [Fact]
    public async Task GetDebuffs()
    {
        await GenerateGlossaryFromDumpedRaw("SpeAddDataBase.csv", 1, "Debuffs",
            translate: true//,
            //only: ["dynamicStringsFromColumns.txt"]
            );
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
    public async Task GetKungfuNames()
    {
        await GenerateGlossaryFromIndex("KungFuData2.csv", 0, "KungfuNames");
    }

    [Fact]
    public async Task GetSpeAddLabels()
    {
        // SpeAddDataBase.csv and ForceSpeAddDataBase.csv's label column (split 1, "特效"/"Special
        // effects" header) is looked up by GameDataController.StringToSpeAddData via an exact
        // String.Equals against the label half of a "Label+Number" fragment embedded in
        // HeroTagData.csv's "效果" column and ResourcePointTypeData.csv's "守城效果" column (both
        // currently SkipColumns'd in TextFileConfiguration.cs - see dragonheirplugin.instructions.md's
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
            TextFileConfiguration.TextFilesToSplit,
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

        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/ExportSpeAddLabels.yaml", glossary);
    }

    private static async Task GenerateGlossaryFromIndex(string path, int index, string name)
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            TextFileConfiguration.TextFilesToSplit,
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

        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/Export{name}.yaml", glossary);
    }

    /// <summary>
    /// Like <see cref="GenerateGlossaryFromIndex"/>, but indexes into the raw CSV row instead of
    /// <see cref="TranslationLine.Splits"/>. Use this when the column you want is one of the
    /// TextFileConfiguration.cs SkipColumns entries for this file - those columns never get a
    /// TranslationSplit (and never get translated), so line.Splits[index] either throws or points
    /// at the wrong (post-skip, renumbered) field. Re-parsing line.Raw with
    /// CompoundFieldSplitter.ParseCsvRow recovers the true raw column position regardless of what
    /// was skipped.
    /// </summary>
    private static async Task GenerateGlossaryFromRawIndex(string path, int rawIndex, string name)
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            TextFileConfiguration.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != path)
                    return;

                foreach (var line in fileLines)
                {
                    var rawFields = CompoundFieldSplitter.ParseCsvRow(line.Raw);
                    if (rawIndex >= rawFields.Length)
                        continue;

                    var raw = rawFields[rawIndex];
                    if (items.Contains(raw))
                        continue;

                    items.Add(raw);

                    var translated = line.Splits.FirstOrDefault(s => s.Split == rawIndex)?.Translated ?? raw;

                    glossary.Add($"- raw: {raw}");
                    glossary.Add($"  result: {translated}");
                    glossary.Add($"  badtrans: true");
                }

                await Task.CompletedTask;
            });

        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/Export{name}.yaml", glossary);
    }

    /// <summary>
    /// Like <see cref="GenerateGlossaryFromRawIndex"/>, but for a file that isn't in
    /// TextFileConfiguration.TextFilesToSplit at all (e.g. commented out) - there's no Converted or
    /// even a fresh Raw/Export yaml to read, since both are only written for entries
    /// FileIteration's callers actually iterate. The one thing that always exists regardless of
    /// config is the plain CSV dump at Raw/Dumped/GameData/{path} (see
    /// CsvGameDataWorkflow.ExportToCustomFormat, which reads that same file when a file IS
    /// enabled). This reads it directly and parses rows with CompoundFieldSplitter.ParseCsvRow, so
    /// it works even for a file with zero pipeline processing. There's no translation to report -
    /// result is just the raw text, ready to be filled in/reviewed by hand.
    /// </summary>
    /// <param name="translate">
    /// When true, each unique raw value is run through the normal translation process
    /// (TranslationService.TranslateSplitAsync - same prompts, glossary and validation as the
    /// pipeline) using the TextFilesToSplit entry for <paramref name="path"/> (or a default entry if
    /// the file isn't configured), and the result is written instead of a blank.
    /// </param>
    /// <param name="only">
    /// When non-empty, each glossary entry is restricted with an "only:" list of these files.
    /// </param>
    private static async Task GenerateGlossaryFromDumpedRaw(string path, int rawIndex, string name,
        bool translate = false, IReadOnlyList<string>? only = null)
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;

        LlmConfig? config = null;
        TextFileToSplit? textFile = null;
        HttpClient? client = null;
        if (translate)
        {
            config = ConfigurationExtensions.GetConfiguration(workingDirectory, GameFileHandling.Hooks);
            textFile = TextFileConfiguration.TextFilesToSplit
                           .FirstOrDefault(x => string.Equals(x.Path, path, StringComparison.OrdinalIgnoreCase))
                       ?? new TextFileToSplit { Path = path };
            client = new HttpClient { Timeout = TimeSpan.FromSeconds(300) };
        }

        var glossary = new List<string>();
        var items = new List<string>();

        var dumpedPath = $"{workingDirectory}/Raw/Dumped/GameData/{path}";
        var lines = await File.ReadAllLinesAsync(dumpedPath);

        foreach (var line in lines)
        {
            var rawFields = CompoundFieldSplitter.ParseCsvRow(line);
            if (rawIndex >= rawFields.Length)
                continue;

            var raw = rawFields[rawIndex];
            if (string.IsNullOrEmpty(raw) || items.Contains(raw))
                continue;

            items.Add(raw);

            var result = string.Empty;
            if (translate)
            {
                var translation = await TranslationService.TranslateSplitAsync(config!, raw, client!, textFile!, column: rawIndex);
                if (translation.Valid)
                    result = translation.Result;
                else
                    Console.WriteLine($"Translation failed for '{raw}': {translation.CorrectionPrompt}");
            }

            glossary.Add($"- raw: {raw}");
            glossary.Add($"  result: {result}");
            if (only is { Count: > 0 })
            {
                glossary.Add($"  only: ");
                foreach (var file in only)
                    glossary.Add($"    - {file}");
            }
        }

        client?.Dispose();
        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/Export{name}.yaml", glossary);
    }

    [Fact]
    public void AnalyseGlossary()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var results = GlossaryWorkflow.AnalyseGlossaryForIssues(config.Runtime.GlossaryLines.ToArray());

        var yml = YamlHelper.CreateSerializer();
        var serialised = yml.Serialize(results);

        FileHelper.WriteAllTextWithRetry($"{workingDirectory}/TestResults/GlossaryAnalysis.yaml", serialised);
    }

    [Fact]
    public async Task GetNameDataOnly()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            TextFileConfiguration.TextFilesToSplit,
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
        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/ExportNameData.yaml", glossary);
    }

    [Fact]
    public async Task GetHeroFullNames()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var config = ConfigurationExtensions.GetConfiguration(workingDirectory);

        var glossary = new List<string>();
        var items = new List<string>();

        await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
            TextFileConfiguration.TextFilesToSplit,
            async (outputFile, textFileToTranslate, fileLines) =>
            {
                if (textFileToTranslate.Path != "heroFullNames.txt")
                    return;

                foreach (var line in fileLines)
                {
                    var raw = line.Splits[0].Text;
                    if (string.IsNullOrEmpty(raw) || items.Contains(raw))
                        continue;

                    items.Add(raw);

                    glossary.Add($"- raw: {line.Splits[0].Text}");
                    glossary.Add($"  result: {line.Splits[0].Translated}");
                    glossary.Add($"  badtrans: true");
                    //glossary.Add($"  only: ");
                    //foreach (var file in only)
                    //    glossary.Add($"    - {file}");
                }

                await Task.CompletedTask;
            });

        FileHelper.WriteAllLinesWithRetry($"{workingDirectory}/TestResults/GlossaryExport/HeroFullNames.yaml", glossary);
    }
}
