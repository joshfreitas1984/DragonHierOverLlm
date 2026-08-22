using System;
using System.Collections.Generic;
using System.Text;

namespace EnglishPatch;

/// <summary>
/// Pure string-based CSV merge helper (no Il2Cpp objects touched — no interop safety concerns).
/// Merges an override CSV into a base CSV by matching the first column (unique ID). Rows only
/// present in the base file (e.g. new game content not yet translated) are kept unchanged.
/// </summary>
internal static class CsvMerger
{
    public static string[] SplitCsvLine(string line)
    {
        var fields = new List<string>();
        var current = new StringBuilder();
        bool inQuotes = false;

        for (int i = 0; i < line.Length; i++)
        {
            char c = line[i];
            if (inQuotes)
            {
                if (c == '"')
                {
                    if (i + 1 < line.Length && line[i + 1] == '"')
                    {
                        current.Append('"');
                        i++;
                    }
                    else
                    {
                        inQuotes = false;
                    }
                }
                else
                {
                    current.Append(c);
                }
            }
            else
            {
                if (c == '"')
                {
                    inQuotes = true;
                }
                else if (c == ',')
                {
                    fields.Add(current.ToString());
                    current.Clear();
                }
                else
                {
                    current.Append(c);
                }
            }
        }

        fields.Add(current.ToString());
        return fields.ToArray();
    }

    public static string MergeByFirstColumn(string baseText, string overrideText)
    {
        var baseLines = SplitLines(baseText);
        var overrideLines = SplitLines(overrideText);

        if (baseLines.Length == 0)
        {
            return baseText;
        }

        var overrideById = new Dictionary<string, string>();
        for (int i = 1; i < overrideLines.Length; i++)
        {
            var line = overrideLines[i];
            if (string.IsNullOrEmpty(line)) continue;

            var fields = SplitCsvLine(line);
            if (fields.Length == 0) continue;

            overrideById[fields[0]] = line;
        }

        var result = new StringBuilder();
        result.Append(baseLines[0]);

        for (int i = 1; i < baseLines.Length; i++)
        {
            var line = baseLines[i];
            if (string.IsNullOrEmpty(line)) continue;

            var fields = SplitCsvLine(line);
            var id = fields.Length > 0 ? fields[0] : null;

            result.Append('\n');
            if (id != null && overrideById.TryGetValue(id, out var overrideLine))
            {
                result.Append(overrideLine);
            }
            else
            {
                result.Append(line);
            }
        }

        return result.ToString();
    }

    private static string[] SplitLines(string text)
    {
        if (string.IsNullOrEmpty(text)) return Array.Empty<string>();
        return text.Replace("\r\n", "\n").Replace("\r", "\n").Split('\n');
    }
}
