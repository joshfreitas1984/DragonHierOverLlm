using System.Diagnostics;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;

namespace Tests
{
    // Extraction passes that populate Raw/Dumped/DynamicStrings/*.txt from CSV columns, dumped
    // prefab fields, and the IL2CPP string map. See docs/gamefilehandling-reference.md.
    public static class DynamicStringExtraction
    {
        // Directory holding every dynamic-string dump/candidate file (dynamicStrings.txt,
        // dynamicStringsFromColumns.txt, dynamicStringsFromStructuredFragments.txt,
        // dynamicStringsFromOtherFieldLabels.txt, dynamicStringsPoetry.txt, heroNameParts.txt).
        internal static string DynamicStringsDumpDirectory(string workingDirectory) =>
            $"{workingDirectory}/Raw/Dumped/DynamicStrings";

        /// <summary>
        /// Unions every raw value already present in ONE dynamic-string dump file (this
        /// extractor's own output file) - just enough for re-run idempotency. Deliberately does
        /// NOT cross-check every other dynamic-string file: that's DedupeDynamicStringFiles' job
        /// alone (the one authoritative cross-file pass, run once at "1i."), so each extractor
        /// stays independent of every other one and doesn't care what order 1c-1h ran in.
        /// </summary>
        internal static HashSet<string> GetExistingDynamicStringValues(string outputPath)
        {
            var seen = new HashSet<string>();
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            return seen;
        }

        /// <summary>Extracts configured whole values and structured labels idempotently.</summary>

        public static void ExtractDynamicStringCandidatesFromColumns(string workingDirectory)
        {
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt";

            var seen = GetExistingDynamicStringValues(outputPath);

            var found = new List<string>();

            void ExtractFrom(string csvFileName, int[] columns, Func<string, IEnumerable<string>> valueExtractor)
            {
                var csvPath = $"{workingDirectory}/Raw/Dumped/GameData/{csvFileName}";
                if (!File.Exists(csvPath)) return;

                // Skip the header row.
                foreach (var line in File.ReadAllLines(csvPath).Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var fields = GameFileHandling.ParseCsvRow(line);
                    foreach (var column in columns)
                    {
                        if (column >= fields.Length) continue;

                        var cell = fields[column];
                        if (string.IsNullOrWhiteSpace(cell)) continue;

                        foreach (var value in valueExtractor(cell))
                        {
                            if (string.IsNullOrWhiteSpace(value)) continue;
                            if (!seen.Add(value)) continue;

                            found.Add(value);
                        }
                    }
                }
            }

            foreach (var (csvFileName, columns) in DynamicStringSources.DynamicStringColumnSources)
                ExtractFrom(csvFileName, columns, cell => [cell]);

            foreach (var (csvFileName, columns) in DynamicStringSources.DynamicStringLabelColumnSources)
            {
                ExtractFrom(csvFileName, columns, cell => cell
                    .Split([';', ','], StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => DynamicStringSources.StatLabelRegex.Match(item).Value));
            }

            foreach (var (csvFileName, columns) in DynamicStringSources.DynamicStringInteractionOptionColumnSources)
            {
                ExtractFrom(csvFileName, columns, cell => cell
                    .Split(';', StringSplitOptions.RemoveEmptyEntries)
                    .SelectMany(item =>
                    {
                        var match = DynamicStringSources.InteractionOptionRegex.Match(item);
                        if (!match.Success) return [];
                        return new[] { match.Groups[1].Value, match.Groups[3].Value };
                    }));
            }

            foreach (var (csvFileName, columns) in DynamicStringSources.DynamicStringTempNpcNameColumnSources)
            {
                ExtractFrom(csvFileName, columns, cell =>
                {
                    var match = DynamicStringSources.TempNpcNameRegex.Match(cell);
                    return match.Success ? [match.Groups[1].Value] : [];
                });
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Scans the master IL2CPP-scanned dump (dynamicStrings.txt) for ';'-joined structured-
        /// record literals (e.g. "包扎;HospitalCureExternalInjury;;;技能影响:医术") that the raw
        /// scan dumps as one whole-string candidate, even though only the individual CJK fields
        /// (Name/Description) are ever displayed - a whole-string dictionary entry for these never
        /// matches at runtime. Identifies a genuine record via AsciiIdentifierFieldRegex (at least
        /// one ';'-split field must be a bare ASCII trigger-id) and emits each remaining
        /// CJK-containing field as its own candidate, further splitting a "<label>:<value>" shaped
        /// field (LabeledFieldRegex) into the label and each space-separated value. See
        /// docs/gamefilehandling-reference.md.
        ///
        /// Must run AFTER ExtractDynamicStringCandidatesFromIl2CppStringMap, which populates the
        /// master dump this reads from. Idempotent: re-running never duplicates an already-
        /// extracted value.
        /// </summary>
        public static void ExtractStructuredRecordFragmentCandidates(string workingDirectory)
        {
            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStrings.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromStructuredFragments.txt";
            if (!File.Exists(masterDumpPath)) return;

            var seen = GetExistingDynamicStringValues(outputPath);

            var found = new List<string>();

            void AddCandidate(string value)
            {
                if (string.IsNullOrWhiteSpace(value)) return;
                if (!TranslationPackaging.ChineseCharPattern.IsMatch(value)) return;
                if (!seen.Add(value)) return;
                found.Add(value);
            }

            foreach (var line in File.ReadAllLines(masterDumpPath))
            {
                if (string.IsNullOrEmpty(line)) continue;

                var fields = line.Split(';');
                if (fields.Length < 3) continue;
                if (!fields.Any(f => DynamicStringSources.AsciiIdentifierFieldRegex.IsMatch(f))) continue;

                foreach (var field in fields)
                {
                    if (string.IsNullOrWhiteSpace(field)) continue;
                    if (!TranslationPackaging.ChineseCharPattern.IsMatch(field)) continue;

                    var labeled = DynamicStringSources.LabeledFieldRegex.Match(field);
                    if (labeled.Success)
                    {
                        AddCandidate(labeled.Groups[1].Value);
                        foreach (var value in labeled.Groups[2].Value.Split([' ', '　'], StringSplitOptions.RemoveEmptyEntries))
                            AddCandidate(value);
                    }
                    else
                    {
                        AddCandidate(field);
                    }
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Extracts SpeHeroData's "."-joined family/given-name halves (see
        /// DynamicStringSources.DynamicStringNamePartColumnSources) into their OWN dedicated dump
        /// file (Raw/Dumped/DynamicStrings/heroNameParts.txt) - deliberately separate from
        /// dynamicStrings.txt/dynamicStringsFromColumns.txt so these short name fragments never
        /// end up merged into DynamicStringPatches' global substring-replace dictionary (see the
        /// "heroNameParts.txt" TextFileToSplit entry's comment). Idempotent: re-running never
        /// duplicates an already-extracted value.
        /// </summary>
        public static void ExtractHeroNamePartCandidates(string workingDirectory)
        {
            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/heroNameParts.txt";

            var seen = GetExistingDynamicStringValues(outputPath);

            var found = new List<string>();

            foreach (var (csvFileName, columns) in DynamicStringSources.DynamicStringNamePartColumnSources)
            {
                var csvPath = $"{workingDirectory}/Raw/Dumped/GameData/{csvFileName}";
                if (!File.Exists(csvPath)) continue;

                // Skip the header row.
                foreach (var line in File.ReadAllLines(csvPath).Skip(1))
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    var fields = GameFileHandling.ParseCsvRow(line);
                    foreach (var column in columns)
                    {
                        if (column >= fields.Length) continue;

                        var cell = fields[column];
                        if (string.IsNullOrWhiteSpace(cell)) continue;

                        foreach (var value in cell.Split('.', StringSplitOptions.RemoveEmptyEntries))
                        {
                            if (string.IsNullOrWhiteSpace(value)) continue;
                            if (!seen.Add(value)) continue;

                            found.Add(value);
                        }
                    }
                }
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>Extracts allowlisted dumped fields into the exact-match PrefabText input.</summary>
        public static void ExtractDynamicStringCandidatesFromOtherText(string workingDirectory)
        {
            var otherTextPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedOtherText.txt";
            if (!File.Exists(otherTextPath))
                throw new InvalidOperationException("You need to run Dump Chinese Text");

            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabText.txt";
            var outputPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedPrefabTextFromOtherFields.txt";

            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));
            if (File.Exists(outputPath))
                seen.UnionWith(File.ReadAllLines(outputPath).Where(l => !string.IsNullOrEmpty(l)));

            var allowedFields = new HashSet<string>(DynamicStringSources.DynamicStringOtherTextFields, StringComparer.OrdinalIgnoreCase);
            var labelFields = new HashSet<string>(DynamicStringSources.DynamicStringLabelOtherTextFields, StringComparer.OrdinalIgnoreCase);

            // Use dictionaries because the dumped-entry record has no parameterless constructor.
            var deserializer = YamlHelper.CreateDeserializer();
            var entries = deserializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(otherTextPath)) ?? [];

            var found = new List<string>();
            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("raw", out var raw) || string.IsNullOrWhiteSpace(raw)) continue;
                if (!entry.TryGetValue("field", out var field)) continue;

                if (string.Equals(field, "startCallSpeFuc", StringComparison.OrdinalIgnoreCase))
                {
                    var match = DynamicStringSources.PlotGetNewMailRegex.Match(raw);
                    if (!match.Success) continue;

                    var message = match.Groups[1].Value;
                    if (string.IsNullOrWhiteSpace(message) || !seen.Add(message)) continue;

                    found.Add(message);
                    continue;
                }

                // Labels are now extracted separately - see ExtractOtherFieldLabelCandidates.
                if (labelFields.Contains(field)) continue;

                if (!allowedFields.Contains(field)) continue;
                if (!seen.Add(raw)) continue;

                found.Add(raw);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Extracts the stat-label sub-source (e.g. "spellEffectString") out of
        /// dumpedOtherText.txt into its OWN dedicated file
        /// (Raw/Dumped/DynamicStrings/dynamicStringsFromOtherFieldLabels.txt) - split out of
        /// dynamicStringsFromColumns.txt (formerly written there by
        /// ExtractDynamicStringCandidatesFromOtherText) so each dynamic-string file's provenance
        /// is unambiguous. Idempotent: re-running never duplicates an already-extracted value.
        /// </summary>
        public static void ExtractOtherFieldLabelCandidates(string workingDirectory)
        {
            var otherTextPath = $"{workingDirectory}/Raw/Dumped/PrefabText/dumpedOtherText.txt";
            if (!File.Exists(otherTextPath)) return;

            var outputPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStringsFromOtherFieldLabels.txt";
            var seen = GetExistingDynamicStringValues(outputPath);

            var labelFields = new HashSet<string>(DynamicStringSources.DynamicStringLabelOtherTextFields, StringComparer.OrdinalIgnoreCase);

            // Use dictionaries because the dumped-entry record has no parameterless constructor.
            var deserializer = YamlHelper.CreateDeserializer();
            var entries = deserializer.Deserialize<List<Dictionary<string, string>>>(File.ReadAllText(otherTextPath)) ?? [];

            var found = new List<string>();
            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("raw", out var raw) || string.IsNullOrWhiteSpace(raw)) continue;
                if (!entry.TryGetValue("field", out var field)) continue;
                if (!labelFields.Contains(field)) continue;

                var label = DynamicStringSources.StatLabelRegex.Match(raw).Value;
                if (string.IsNullOrWhiteSpace(label) || !seen.Add(label)) continue;

                found.Add(label);
            }

            Directory.CreateDirectory(Path.GetDirectoryName(outputPath)!);
            File.AppendAllLines(outputPath, found);
        }

        /// <summary>
        /// Refreshes IL2CPP string-map candidates and appends new entries idempotently directly
        /// into the master <c>dynamicStrings.txt</c> dump, regenerating it from the Converter's
        /// <c>_dynamicStrings_candidates.txt</c> output - this is not a hand-curated file. Also
        /// bootstraps the master dump file the first time this runs (e.g. fresh clone), which
        /// "1c." depends on existing before it can export.
        /// </summary>
        public static void ExtractDynamicStringCandidatesFromIl2CppStringMap(string workingDirectory)
        {
            var converterDir = Path.GetFullPath(Path.Combine(workingDirectory, "..", "Converter"));
            var converterProjectPath = Path.Combine(converterDir, "Converter.csproj");
            var converterOutputDir = Path.Combine(converterDir, "output");
            var stringMapPath = Path.Combine(converterOutputDir, "_string_map.csv");

            if (!File.Exists(converterProjectPath) || !File.Exists(stringMapPath)) return;

            var masterDumpPath = $"{workingDirectory}/Raw/Dumped/DynamicStrings/dynamicStrings.txt";
            var candidatesPath = Path.Combine(converterOutputDir, "_dynamicStrings_candidates.txt");

            var psi = new ProcessStartInfo("dotnet")
            {
                WorkingDirectory = converterDir,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
            };
            psi.ArgumentList.Add("run");
            psi.ArgumentList.Add("--no-build");
            psi.ArgumentList.Add("--");
            psi.ArgumentList.Add("--dynamic-string-candidates");
            psi.ArgumentList.Add("--output");
            psi.ArgumentList.Add(converterOutputDir);
            psi.ArgumentList.Add("--exclude-file");
            psi.ArgumentList.Add(Path.GetFullPath(masterDumpPath));

            try
            {
                using var process = Process.Start(psi);
                if (process == null) return;
                process.WaitForExit();
                if (process.ExitCode != 0 || !File.Exists(candidatesPath)) return;
            }
            catch
            {
                // Converter isn't built / dotnet isn't on PATH / etc. - fall back to whatever
                // candidates file (if any) already exists rather than failing the whole test run.
                if (!File.Exists(candidatesPath)) return;
            }

            // Dedup against the master dump itself only (idempotent re-runs never duplicate a
            // line already recorded there). Deliberately does NOT also cross-check
            // dynamicStringsFromColumns.txt - that file may already contain stale long-sentence
            // candidates left over from an older version of this method that (incorrectly)
            // appended here instead of to the master dump; treating those as "already seen" would
            // permanently block this method from ever writing anything to dynamicStrings.txt. See
            // the "dynamicStringsFromColumns.txt contamination" note in
            // Tests/docs/dynamicstrings-pipeline-architecture.md for the one-time cleanup needed
            // if that file still has this legacy contamination.
            var seen = new HashSet<string>();
            if (File.Exists(masterDumpPath))
                seen.UnionWith(File.ReadAllLines(masterDumpPath).Where(l => !string.IsNullOrEmpty(l)));

            var found = File.ReadAllLines(candidatesPath)
                .Where(l => !string.IsNullOrEmpty(l))
                .Where(seen.Add)
                .ToList();

            Directory.CreateDirectory(Path.GetDirectoryName(masterDumpPath)!);
            File.AppendAllLines(masterDumpPath, found);
        }

        // Fixed priority order for cross-file dedup: when a raw value exists in more than one
        // dynamic-string dump file, it's kept in whichever file appears EARLIEST here and removed
        // from the rest. Any file under Raw/Dumped/DynamicStrings/ not listed here is treated as
        // lowest priority (kept last).
        private static readonly string[] DynamicStringDedupePriorityOrder =
        [
            "dynamicStrings.txt",
            "dynamicStringsFromColumns.txt",
            "dynamicStringsFromStructuredFragments.txt",
            "dynamicStringsFromOtherFieldLabels.txt",
            "dynamicStringsPoetry.txt",
            "dynamicStringsDrinkQuotes.txt",
        ];

        /// <summary>
        /// Final, authoritative cross-file dedup pass for Raw/Dumped/DynamicStrings/*.txt - the
        /// one place duplicates across files get resolved, regardless of which extraction Facts
        /// ran, how many times, or in what order (each extractor only needs to avoid duplicating
        /// within its OWN file via GetExistingDynamicStringValues; this pass handles anything that
        /// ends up in more than one file). Safe/idempotent - re-running when there are no
        /// cross-file duplicates left is a no-op.
        /// </summary>
        public static void DedupeDynamicStringFiles(string workingDirectory)
        {
            var dir = DynamicStringsDumpDirectory(workingDirectory);
            if (!Directory.Exists(dir)) return;

            var files = Directory.GetFiles(dir, "dynamic*.txt")
                .OrderBy(f =>
                {
                    var index = Array.IndexOf(DynamicStringDedupePriorityOrder, Path.GetFileName(f));
                    return index < 0 ? int.MaxValue : index;
                })
                .ToList();

            var seen = new HashSet<string>();
            foreach (var file in files)
            {
                var lines = File.ReadAllLines(file);
                var deduped = lines.Where(l => string.IsNullOrEmpty(l) || seen.Add(l)).ToList();

                if (deduped.Count != lines.Length)
                    File.WriteAllLines(file, deduped);
            }
        }
    }
}
