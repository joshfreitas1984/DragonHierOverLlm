using System.Text.Json;
using System.Text.RegularExpressions;

namespace Tests;

/// <summary>
/// Extracts translation candidates for the "对诗" (poem fill-in-the-blank) minigame from the raw
/// JSON TextAsset <c>TextAsset/PoetryData.txt</c> (366 poems: title/author/paragraphs, loaded by
/// GameDataController into poetryDataBase). This is genuinely new source data - unlike every other
/// TextAsset file, it's JSON rather than CSV, and its content is never baked into a compiled
/// string literal, so it can't be picked up by IL2CPP string-map scanning; PlotController picks a
/// random poem + a random paragraph line at runtime, splits it on CJK punctuation, and shows one
/// half as a fill-in-the-blank choice (see plotdata/PlotController investigation for the
/// "经冬犹绿林"/"从今又几年" case this was built for). Title and author are included alongside
/// paragraph lines since they're shown in-game too.
///
/// Writes into its OWN dedicated dynamicStringsPoetry.txt (see GameFileHandling.TextFilesToSplit)
/// so this source's provenance stays unambiguous - reuses the same DynamicStringsIL2CPP raw/result
/// export-translate-package plumbing as dynamicStrings.txt/dynamicStringsFromColumns.txt, nothing
/// poetry-specific needed there. Idempotent: re-running never duplicates an already-extracted
/// value in this file. Cross-file duplicates (a value that also exists in another dynamic-string
/// file) are resolved separately by GameFileHandling.DedupeDynamicStringFiles.
/// </summary>
public static class PoetryDataWorkflow
{
    // Splits a paragraph line on the CJK punctuation marks PlotController uses to break a couplet
    // into its displayed choice halves (e.g. "江南有丹橘，经冬犹绿林。" -> "江南有丹橘" / "经冬犹绿林").
    private static readonly Regex CjkPunctuationSplit = new(@"[，。？！；、]+", RegexOptions.Compiled);

    private sealed class PoemEntry
    {
        public string? Title { get; set; }
        public string? Author { get; set; }
        public List<string>? Paragraphs { get; set; }
    }

    public static void ExtractPoetryCandidates(string workingDirectory)
    {
        var poetryDataPath = Path.Combine(workingDirectory, "..", "TextAsset", "PoetryData.txt");
        if (!File.Exists(poetryDataPath)) return;

        var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsPoetry.txt";
        var seen = GameFileHandling.GetExistingDynamicStringValues(outputPath);

        var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
        var poems = JsonSerializer.Deserialize<List<PoemEntry>>(File.ReadAllText(poetryDataPath), options) ?? [];

        var found = new List<string>();

        void AddCandidate(string? value)
        {
            if (string.IsNullOrWhiteSpace(value)) return;
            if (!seen.Add(value)) return;
            found.Add(value);
        }

        foreach (var poem in poems)
        {
            AddCandidate(poem.Title);
            AddCandidate(poem.Author);

            foreach (var line in poem.Paragraphs ?? [])
            {
                AddCandidate(line);

                foreach (var half in CjkPunctuationSplit.Split(line))
                    AddCandidate(half);
            }
        }

        Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
        File.AppendAllLines(outputPath, found);
    }
}
