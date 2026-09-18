namespace Tests
{
    public static class RoutedMailExport
    {
        private const string OutputFileName = "dynamicStringsRoutedMailBodies.txt";
        private const int MinimumSenderPrefixLength = 2;
        private const int MaximumSenderPrefixLength = 4;

        public static void AddBodyAliasesToRawDump(string workingDirectory)
        {
            workingDirectory = ResolveWorkingDirectory(workingDirectory);
            var outputPath = Path.Combine(workingDirectory, "Raw", "Dumped", "DynamicStrings", OutputFileName);

            var routedMails = ReadDumpedRoutedMails(workingDirectory)
                .Concat(ReadMasterRoutedMails(workingDirectory))
                .ToList();

            var original = File.Exists(outputPath) ? File.ReadAllLines(outputPath).ToList() : [];
            var updated = AddBodyAliases([], routedMails);
            if (!updated.SequenceEqual(original, StringComparer.Ordinal))
            {
                Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
                File.WriteAllLines(outputPath, updated);
            }
        }

        private static string ResolveWorkingDirectory(string workingDirectory)
        {
            var candidates = new List<string> { Path.GetFullPath(workingDirectory) };
            AddAncestorCandidates(candidates, Directory.GetCurrentDirectory());
            AddAncestorCandidates(candidates, AppContext.BaseDirectory);

            return candidates
                .Distinct(StringComparer.OrdinalIgnoreCase)
                .OrderByDescending(CountRoutedMailRecords)
                .First();
        }

        private static void AddAncestorCandidates(List<string> candidates, string startDirectory)
        {
            var directory = new DirectoryInfo(startDirectory);
            while (directory is not null)
            {
                candidates.Add(Path.Combine(directory.FullName, "Files"));
                directory = directory.Parent;
            }
        }

        private static int CountRoutedMailRecords(string workingDirectory)
        {
            var sourcePath = Path.Combine(workingDirectory, "Raw", "Dumped", "PrefabText", "dumpedOtherText.txt");
            return File.Exists(sourcePath)
                ? File.ReadLines(sourcePath).Count(line => line.StartsWith("- raw: PlotGetNewMail;", StringComparison.Ordinal))
                : 0;
        }

        private static IEnumerable<string> ReadDumpedRoutedMails(string workingDirectory)
        {
            var sourcePath = Path.Combine(workingDirectory, "Raw", "Dumped", "PrefabText", "dumpedOtherText.txt");
            if (!File.Exists(sourcePath))
                return [];

            return File.ReadAllLines(sourcePath)
                .Where(line => line.StartsWith("- raw: PlotGetNewMail;", StringComparison.Ordinal))
                .Select(line => line[7..].TrimEnd('\r', '\n'))
                .Where(raw => DynamicStringSources.PlotGetNewMailRegex.IsMatch(raw))
                .Select(raw => raw["PlotGetNewMail;".Length..]);
        }

        private static IEnumerable<string> ReadMasterRoutedMails(string workingDirectory)
        {
            var sourcePath = Path.Combine(workingDirectory, "Raw", "Dumped", "DynamicStrings", "dynamicStrings.txt");
            if (!File.Exists(sourcePath))
                return [];

            return File.ReadLines(sourcePath)
                .Where(line => IsMasterMailCandidate(line));
        }

        private static bool IsMasterMailCandidate(string value)
        {
            var separatorIndex = value.IndexOf('-');
            return separatorIndex >= MinimumSenderPrefixLength &&
                   separatorIndex <= MaximumSenderPrefixLength &&
                   value.Contains("#PlayerName#", StringComparison.Ordinal) &&
                   value.Contains("<b>", StringComparison.Ordinal);
        }

        public static List<string> AddBodyAliases(IEnumerable<string> dynamicStrings, IEnumerable<string> routedMails)
        {
            var results = dynamicStrings.ToList();
            var existing = results.ToHashSet(StringComparer.Ordinal);

            foreach (var routedMail in routedMails)
            {
                var separatorIndex = routedMail.IndexOf('-');
                if (separatorIndex < MinimumSenderPrefixLength ||
                    separatorIndex > MaximumSenderPrefixLength ||
                    separatorIndex == routedMail.Length - 1)
                    continue;

                var body = routedMail[(separatorIndex + 1)..];
                if (body.EndsWith("-true", StringComparison.Ordinal))
                    body = body[..^5];

                if (existing.Add(body))
                    results.Add(body);
            }

            return results;
        }
    }
}
