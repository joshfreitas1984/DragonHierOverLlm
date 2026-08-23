using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests;

/// <summary>
/// Read-only sanity checks against the real working-directory files
/// (Files/Raw/Dumped/GameData, Files/Converted, Files/Mod). Unlike the numbered workflow Facts in
/// FileInputWorkflowTests / FileOutputWorkflowTests / TranslationWorkflowTests, nothing here
/// mutates state under Files/, so these are safe to run at any point mid-translation, in any
/// order, or as a batch - they just report on whatever currently exists on disk.
///
/// The CSV load-rule checks encode the same conventions documented in
/// tests-translation-workflow.instructions.md: the game loads these as fixed-schema CSVs (every
/// row must have the same column count as the header), so a compound-field template that gets
/// reconstructed slightly wrong (extra/missing comma, unbalanced quote, leftover "{n}" placeholder)
/// would silently corrupt the game's data rather than just look wrong to a human.
/// </summary>
public class FileValidationTests
{
    private static readonly Regex UnresolvedPlaceholderPattern = new(@"\{\d+\}", RegexOptions.Compiled);

    private static IEnumerable<TextFileToSplit> PackagedTextFiles =>
        GameFileHandling.TextFilesToSplit.Where(t => t.PackageOutput);

    [Fact(DisplayName = "Packaged Mod CSVs have a consistent column count per row")]
    public void PackagedModFilesHaveConsistentColumnCounts()
    {
        var problems = new List<string>();

        foreach (var textFile in PackagedTextFiles)
        {
            var modPath = $"{GameFileHandling.WorkingDirectory}/Mod/{textFile.Path}";
            if (!File.Exists(modPath))
                continue;

            var lines = File.ReadAllLines(modPath);
            if (lines.Length == 0)
                continue;

            var headerColumnCount = GameFileHandling.ParseCsvRow(lines[0]).Length;

            for (int i = 1; i < lines.Length; i++)
            {
                if (string.IsNullOrEmpty(lines[i]))
                    continue;

                var columnCount = GameFileHandling.ParseCsvRow(lines[i]).Length;
                if (columnCount != headerColumnCount)
                    problems.Add($"{textFile.Path} line {i + 1}: expected {headerColumnCount} columns (per header), found {columnCount}");
            }
        }

        Assert.Empty(problems);
    }

    [Fact(DisplayName = "Packaged Mod CSVs have the same row count as the raw dumped CSVs (no rows dropped/added)")]
    public void PackagedModFilesHaveSameRowCountAsRaw()
    {
        var problems = new List<string>();
        var rawDir = $"{GameFileHandling.WorkingDirectory}/Raw/Dumped/GameData";

        foreach (var textFile in PackagedTextFiles)
        {
            var rawPath = $"{rawDir}/{textFile.Path}";
            var modPath = $"{GameFileHandling.WorkingDirectory}/Mod/{textFile.Path}";

            if (!File.Exists(rawPath) || !File.Exists(modPath))
                continue;

            var rawCount = File.ReadAllLines(rawPath).Length;
            var modCount = File.ReadAllLines(modPath).Length;

            if (rawCount != modCount)
                problems.Add($"{textFile.Path}: raw has {rawCount} lines, Mod has {modCount} lines");
        }

        Assert.Empty(problems);
    }

    [Fact(DisplayName = "Packaged Mod CSV rows round-trip through the CSV parser without corruption")]
    public void PackagedModFilesRoundTripThroughCsvParser()
    {
        var problems = new List<string>();

        foreach (var textFile in PackagedTextFiles)
        {
            var modPath = $"{GameFileHandling.WorkingDirectory}/Mod/{textFile.Path}";
            if (!File.Exists(modPath))
                continue;

            var lines = File.ReadAllLines(modPath);
            for (int i = 0; i < lines.Length; i++)
            {
                var line = lines[i];
                if (string.IsNullOrEmpty(line))
                    continue;

                var parsed = GameFileHandling.ParseCsvRow(line);
                var rebuilt = GameFileHandling.RebuildCsvRow(parsed);

                // A mismatch here means a cell needed quoting/escaping (embedded comma, quote or
                // newline) that either wasn't applied on write, or was applied inconsistently -
                // either way the game's CSV loader would misread the row's column boundaries.
                if (rebuilt != line)
                    problems.Add($"{textFile.Path} line {i + 1}: CSV round-trip mismatch{Environment.NewLine}  original: {line}{Environment.NewLine}  rebuilt:  {rebuilt}");
            }
        }

        Assert.Empty(problems);
    }

    [Fact(DisplayName = "Packaged Mod cells contain no unresolved '{n}' template placeholders")]
    public void PackagedModFilesHaveNoUnresolvedPlaceholders()
    {
        var problems = new List<string>();

        foreach (var textFile in PackagedTextFiles)
        {
            var modPath = $"{GameFileHandling.WorkingDirectory}/Mod/{textFile.Path}";
            if (!File.Exists(modPath))
                continue;

            var lines = File.ReadAllLines(modPath);
            for (int i = 0; i < lines.Length; i++)
            {
                // A literal "{0}"/"{1}" surviving into the packaged output means
                // CompoundFieldSplitter.Reconstruct ran with fewer translated fragments than the
                // template expected (e.g. a fragment kept because it was untranslated-but-blank),
                // which would show up as broken placeholder text in-game instead of a sentence.
                if (UnresolvedPlaceholderPattern.IsMatch(lines[i]))
                    problems.Add($"{textFile.Path} line {i + 1}: unresolved template placeholder left in output: {lines[i]}");
            }
        }

        Assert.Empty(problems);
    }

    [Fact(DisplayName = "Report cells that look like internal ids/lookups rather than user-facing text")]
    public async Task ReportLikelyIdOrLookupCells()
    {
        var deserializer = YamlHelper.CreateDeserializer();
        var convertedDir = $"{GameFileHandling.WorkingDirectory}/Converted";
        var report = new List<string>();

        foreach (var textFile in GameFileHandling.TextFilesToSplit)
        {
            var path = $"{convertedDir}/{textFile.Path}.yaml";
            if (!File.Exists(path))
                continue;

            var content = await File.ReadAllTextAsync(path);
            var lines = deserializer.Deserialize<List<TranslationLine>>(content) ?? [];

            // Heuristic A: a fragment's text is byte-for-byte identical to another column's
            // fragment on the *same row*. This is exactly the AreaData "图标" bug that
            // SkipColumns = [3] already fixes for that file (the icon column just copies the
            // area's name to use as a lookup key) - a column that keeps doing this across many
            // rows is very likely a reference/lookup column, not independent user-facing text.
            foreach (var line in lines)
            {
                var textsBySplit = line.Splits
                    .GroupBy(s => s.Split)
                    .ToDictionary(g => g.Key, g => g.Select(s => s.Text).ToList());

                foreach (var (split, texts) in textsBySplit)
                {
                    if (textFile.SkipColumns.Contains(split))
                        continue;

                    foreach (var text in texts.Distinct())
                    {
                        var duplicatesOtherColumn = textsBySplit
                            .Any(other => other.Key != split && other.Value.Contains(text));

                        if (duplicatesOtherColumn)
                            report.Add($"{textFile.Path} col {split}: \"{text}\" duplicates another column's value on the same row (raw: {line.Raw})");
                    }
                }
            }

            // Heuristic B: a column whose values are short and heavily repeated across the whole
            // file behaves like an enum/lookup key (e.g. HeroTagData's "同义组"/"反义组" synonym
            // group columns, which reuse other rows' own names as a grouping key) rather than
            // free-form user-facing text, even though every individual value is genuine Chinese.
            var candidateSplits = lines
                .SelectMany(l => l.Splits)
                .Where(s => !textFile.SkipColumns.Contains(s.Split))
                .GroupBy(s => s.Split);

            foreach (var group in candidateSplits)
            {
                var texts = group.Select(s => s.Text).ToList();
                if (texts.Count < 8)
                    continue;

                var distinct = texts.Distinct().ToList();
                var avgLength = texts.Average(t => t.Length);
                var repetitionRatio = 1.0 - (double)distinct.Count / texts.Count;

                if (distinct.Count <= 12 && avgLength <= 6 && repetitionRatio >= 0.5)
                {
                    report.Add($"{textFile.Path} col {group.Key}: {distinct.Count} distinct values across {texts.Count} cells " +
                        $"(avg len {avgLength:F1}, {repetitionRatio:P0} repeated) - looks like an enum/lookup column, " +
                        $"e.g. [{string.Join(", ", distinct.Take(8))}]. Consider adding to SkipColumns if confirmed.");
                }
            }
        }

        var reportPath = $"{GameFileHandling.WorkingDirectory}/TestResults/Likely_id_or_lookup_columns.txt";
        Directory.CreateDirectory(Path.GetDirectoryName(reportPath)!);
        await File.WriteAllLinesAsync(reportPath, report);

        Console.WriteLine($"Found {report.Count} suspicious cell(s)/column(s) - full report written to {reportPath}");
        foreach (var entry in report.Take(50))
            Console.WriteLine(entry);
    }
}
