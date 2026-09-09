using System.Text.RegularExpressions;
using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using FanslationStudio.LlmKit.Workflow;

namespace Tests
{
    // Packages translated CSV/PrefabText/DynamicStringsIL2CPP files into the final mod output,
    // including the forced result overrides and junk-entry filtering applied at packaging time.
    // See docs/gamefilehandling-reference.md.
    public static class TranslationPackaging
    {
        // Forced Result overrides for known-problematic DynamicStringsIL2CPP Raw templates,
        // applied unconditionally at packaging time (see ApplyDynamicStringResultOverrides) because
        // CompoundFieldSplitter.Reconstruct glues translated fragments directly against "{n}"
        // placeholders with no separator - individually-correct fragment translations (e.g.
        // "年"->"Year") still reconstruct unreadably ("1Year1Month17Day"). Keyed by the exact Raw
        // string. See docs/gamefilehandling-reference.md.
        private static readonly Dictionary<string, string> DynamicStringResultOverrides = new()
        {
            ["{0}年{1}月{2}日"] = "{0} Year {1} Month {2} Day",

            // Both entries below were reported garbled in-game (e.g. "Will do this previously
            // Jianghu Ranger XuanyuanChengXiu在Cancong Village And 仙霞 Sect Master He Chitchat
            // One 阵...and hear the tale of their encounter...") - the ORIGINAL LLM translations
            // were produced from fragments split right at the "{n}" placeholder boundary with no
            // surrounding-sentence context, so each half was translated blind and came out
            // ungrammatical. Overridden here to read as a single coherent sentence instead. NOTE:
            // the reported instance additionally has a "{2}他" (title+pronoun) variant of the
            // second raw string that this exact-Raw-match override does NOT fix - that variant
            // was never captured as its own dumped Raw entry, so it still falls through to
            // per-word dictionary substitution at runtime regardless of this fix.
            ["#TargetInteractName#将此前{0}之遭遇向你娓娓道来......"] =
                "#TargetInteractName# recounts to you in detail their previous encounter with {0}......",
            ["{0}在{1}与{2}闲聊一阵。"] = "{0} chatted with {2} for a while at {1}.",
        };

        // Same placeholder-adjacency problem as DynamicStringResultOverrides, but for a fragment
        // that recurs at varying placeholder indices (e.g. "{0}级"/"{1}级", the "Level N" reader
        // stat). Applied as substring fixups against the already-translated Result (not rebuilt
        // from Raw) so the rest of the sentence's translation survives.
        private static readonly (Regex Pattern, MatchEvaluator Evaluator)[] DynamicStringRegexResultOverrides =
        [
            // "{i}Level{j}"/"{i} Level {j}" -> "Level {i} {j}" - must run before the standalone
            // rule below so the trailing "{j}" isn't left to match on its own first.
            (new Regex(@"\{(\d+)\}\s*Level\s*\{(\d+)\}", RegexOptions.Compiled),
                m => $"Level {{{m.Groups[1].Value}}} {{{m.Groups[2].Value}}}"),

            // "{i}Level"/"{i} Level" standalone -> "Level {i}".
            (new Regex(@"\{(\d+)\}\s*Level\b", RegexOptions.Compiled),
                m => $"Level {{{m.Groups[1].Value}}}"),
        ];

        // Re-reads the just-packaged Files/Mod/{textFile.Path}.yaml and force-overwrites any
        // entry whose Raw matches DynamicStringResultOverrides, then rewrites the file. Runs
        // AFTER DynamicStringWorkflow.PackageDynamicStringsAsync on every packaging pass -
        // regardless of what's currently translated in Files/Converted - so a future re-export or
        // re-translation of this raw string can never silently regress the fix (editing the
        // Converted/Mod YAML directly, as done previously, gets undone the next time either step
        // re-runs).
        private static void ApplyDynamicStringResultOverrides(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var changed = false;
            foreach (var entry in results)
            {
                string? forcedResult = null;

                if (DynamicStringResultOverrides.TryGetValue(entry.Raw, out var exactResult))
                    forcedResult = exactResult;
                else
                {
                    var fixedResult = entry.Result;
                    foreach (var (pattern, evaluator) in DynamicStringRegexResultOverrides)
                        fixedResult = pattern.Replace(fixedResult, evaluator);

                    if (fixedResult != entry.Result)
                        forcedResult = fixedResult;
                }

                if (forcedResult != null && entry.Result != forcedResult)
                {
                    entry.Result = forcedResult;
                    changed = true;
                }
            }

            if (!changed)
                return;

            var serializer = YamlHelper.CreateSerializer();
            FileHelper.WriteAllTextWithRetry(modPath, serializer.Serialize(results));
        }

        // Drops junk dynamic-string dictionary entries whose Raw contains no Chinese characters at
        // all (same pattern as DragonHeirPlugin/MainPlugin.cs's ChineseCharPattern) - only text
        // containing real Chinese characters is ever a genuine translatable fragment. Filtering
        // here at packaging time means the plugin's runtime dictionary never re-checks this per
        // match on every hot-path call. See docs/gamefilehandling-reference.md.
        internal static readonly Regex ChineseCharPattern = new(@"\p{IsCJKUnifiedIdeographs}", RegexOptions.Compiled);

        private static void RemoveNonChineseDynamicStringEntries(string workingDirectory, TextFileToSplit textFile)
        {
            var modPath = $"{workingDirectory}/Mod/{textFile.Path}.yaml";
            if (!File.Exists(modPath))
                return;

            var deserializer = YamlHelper.CreateDeserializer();
            var results = deserializer.Deserialize<List<DynamicStringResult>>(File.ReadAllText(modPath)) ?? new();

            var filtered = results.Where(entry => !string.IsNullOrEmpty(entry.Raw) && ChineseCharPattern.IsMatch(entry.Raw)).ToList();
            if (filtered.Count == results.Count)
                return;

            var serializer = YamlHelper.CreateSerializer();
            FileHelper.WriteAllTextWithRetry(modPath, serializer.Serialize(filtered));
        }

        public static async Task PackageFinalTranslationAsync(string workingDirectory, TextFileToSplit[] textFiles)
        {
            string inputPath = $"{workingDirectory}/Converted";
            string outputPath = $"{workingDirectory}/Mod";

            // Quality-review-pass score gate (see docs/plans/quality-review-pass.md) - a column
            // whose QcQualityScore is non-null and below this falls into the same "not ready to
            // package" bucket as an unsafe/flagged/missing-translation column, further down.
            // Never touches Files/Converted - only what reaches Files/Mod.
            var minAcceptableScore = FanslationStudio.LlmKit.Configuration.ConfigurationExtensions
                .GetConfiguration(workingDirectory).QualityReview.MinAcceptableScore;

            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);

            Directory.CreateDirectory(outputPath);

            var finalDb = new List<string>();
            var passedCount = 0;
            var failedCount = 0;

            // Flat-text workflows are packaged separately from regular CSV files.
            var csvTextFiles = textFiles
                .Where(t => t.TextFileType != TextFileType.PrefabText && t.TextFileType != TextFileType.DynamicStringsIL2CPP)
                .ToArray();
            var prefabTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.PrefabText);
            var dynamicStringFiles = textFiles.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP);

            foreach (var prefabTextFile in prefabTextFiles)
            {
                var (passed, failed) = await PrefabTextWorkflow.PackagePrefabTextAsync(workingDirectory, prefabTextFile);
                passedCount += passed;
                failedCount += failed;
            }

            foreach (var dynamicStringFile in dynamicStringFiles)
            {
                var (passed, failed) = await DynamicStringWorkflow.PackageDynamicStringsAsync(workingDirectory, dynamicStringFile);
                passedCount += passed;
                failedCount += failed;

                // Force known-bad reconstructed template results regardless of whatever
                // translation currently sits in Files/Converted - see
                // DynamicStringResultOverrides for why this can't just be fixed by editing the
                // Converted/Mod YAML directly (re-export/re-translation would silently undo it).
                ApplyDynamicStringResultOverrides(workingDirectory, dynamicStringFile);

                // Drop junk entries whose Raw has no Chinese at all - see
                // RemoveNonChineseDynamicStringEntries.
                RemoveNonChineseDynamicStringEntries(workingDirectory, dynamicStringFile);
            }

            // Collected alongside the normal CSV packaging below - see
            // DynamicStringSources.AtlasSpriteNameColumnSources.
            var atlasSpriteNamePairs = new Dictionary<string, List<(string Raw, string Result)>>();

            await FileIteration.IterateTranslatedFilesAsync(workingDirectory,
                csvTextFiles,
                async (outputFile, textFileToTranslate, fileLines) =>
            {
                var failedLines = new List<string>();
                var outputLines = new List<string>();
                var atlasSpriteNameSources = DynamicStringSources.AtlasSpriteNameColumnSources
                    .Where(s => s.CsvFileName == textFileToTranslate.Path)
                    .ToArray();

                foreach (var line in fileLines)
                {
                    // Regular DB handling
                    var splits = GameFileHandling.ParseCsvRow(line.Raw);
                    var failed = false;
                    var templatedColumns = line.Templates.Select(t => t.Split)
                        .Where(s => !textFileToTranslate.SkipColumns.Contains(s)).ToHashSet();

                    foreach (var template in line.Templates)
                    {
                        if (template.Split < 0 || template.Split >= splits.Length)
                            continue;

                        // Preserve skipped columns, including stale converted templates.
                        if (textFileToTranslate.SkipColumns.Contains(template.Split))
                            continue;

                        var fragments = line.Splits
                            .Where(s => s.Split == template.Split)
                            .OrderBy(s => s.SubIndex)
                            .ToList();

                        // Whole-cell QC state lives only on the column's SubIndex == 0 fragment -
                        // see TranslationSplit.QcTranslated's doc comment. Only trust it if still
                        // fresh relative to the fragments' CURRENT Translated values (see
                        // QualityReviewHelpers.IsQcReviewFresh) - a retranslation since the last
                        // review (e.g. a glossary change flagging this column via
                        // ApplyAllRulesToCurrentTranslation) must never be silently overridden by
                        // a stale score/correction just because nobody has re-run the quality
                        // review pass yet. A fresh, non-empty QcTranslated bypasses Reconstruct
                        // entirely and is used as the literal cell value.
                        var anchor = fragments.FirstOrDefault(f => f.SubIndex == 0) ?? fragments.FirstOrDefault();
                        var qcFresh = anchor != null && QualityReviewHelpers.IsQcReviewFresh(anchor, template, fragments);

                        // A low QcQualityScore means "don't trust this correction" - not "this line
                        // has no valid translation at all". The pre-QC Translated text (used by the
                        // fragment-reconstruction fallback below, same path taken when there's no
                        // QcTranslated at all) is already an accepted translation from the main
                        // pipeline and shouldn't be discarded in favor of shipping raw source just
                        // because the QC model wasn't confident in its own proposed correction.
                        var useQcTranslated = qcFresh
                            && !string.IsNullOrEmpty(anchor!.QcTranslated)
                            && !(anchor.QcQualityScore is int templateScore && templateScore < minAcceptableScore);

                        if (useQcTranslated)
                        {
                            splits[template.Split] = anchor!.QcTranslated;
                            continue;
                        }

                        var translatedFragments = new List<string>();

                        foreach (var fragment in fragments)
                        {
                            if (!textFileToTranslate.PackageOutput
                                || fragment.FlaggedForRetranslation
                                || !fragment.SafeToTranslate) //Count Failure
                            {
                                failed = true;
                                break;
                            }

                            //Check line to be extra safe
                            //if (Regex.IsMatch(fragment.Translated, @"(?<!\\)\n"))
                            //    failed = true;
                            //else
                            if (!string.IsNullOrEmpty(fragment.Translated))
                                translatedFragments.Add(fragment.Translated);
                            //If it was already blank its all good
                            else if (!string.IsNullOrEmpty(fragment.Text))
                            {
                                failed = true;
                                break;
                            }
                            else
                                translatedFragments.Add(fragment.Text);
                        }

                        if (failed)
                            break;

                        splits[template.Split] = CompoundFieldSplitter.Reconstruct(template.Template, translatedFragments);
                    }

                    // Plain columns (whole cell is a single translatable fragment, no template needed)
                    if (!failed)
                    {
                        foreach (var split in line.Splits.Where(s => !templatedColumns.Contains(s.Split)))
                        {
                            if (split.Split < 0 || split.Split >= splits.Length)
                                continue;

                            // Preserve skipped columns; a stale compound split must not overwrite the cell.
                            if (textFileToTranslate.SkipColumns.Contains(split.Split))
                                continue;

                            if (!textFileToTranslate.PackageOutput
                                || split.FlaggedForRetranslation
                                || !split.SafeToTranslate) //Count Failure
                            {
                                failed = true;
                                break;
                            }

                            var plainQcFresh = QualityReviewHelpers.IsQcReviewFresh(split, null, [split]);

                            // Same reasoning as the templated-column path above: a low score distrusts
                            // the CORRECTION, not the original Translated - fall back to it instead of
                            // failing the whole line.
                            var usePlainQcTranslated = plainQcFresh
                                && !string.IsNullOrEmpty(split.QcTranslated)
                                && !(split.QcQualityScore is int plainScore && plainScore < minAcceptableScore);

                            var effectiveTranslated = usePlainQcTranslated ? split.QcTranslated : split.Translated;

                            if (!string.IsNullOrEmpty(effectiveTranslated))
                                splits[split.Split] = effectiveTranslated;
                            //If it was already blank its all good
                            else if (!string.IsNullOrEmpty(split.Text))
                            {
                                failed = true;
                                break;
                            }

                            // Also copy this row's already-translated (Text, effective Translated)
                            // pair for any AtlasSpriteNameColumnSources column - see that array's
                            // comment.
                            foreach (var source in atlasSpriteNameSources.Where(s => s.Column == split.Split))
                            {
                                if (string.IsNullOrEmpty(split.Text) || string.IsNullOrEmpty(effectiveTranslated))
                                    continue;
                                if (!atlasSpriteNamePairs.TryGetValue(source.OutputFileName, out var pairs))
                                    atlasSpriteNamePairs[source.OutputFileName] = pairs = new();
                                pairs.Add((split.Text, effectiveTranslated));
                            }
                        }
                    }

                    // Don't remove /n it makes lines even longer and less likely to wrap.
                    // if (textFileToTranslate.Path == "PlotData.csv" && splits.Length > 10)
                    //     splits[10] = splits[10].Replace("\\r\\n", " ").Replace("\\n", " ").Replace("\\r", " ");

                    // A translated cell ending in a bare comma (e.g. an LLM ending a sentence with
                    // "," instead of a period) is always safe per RFC 4180 quoting, but the game's
                    // own hand-rolled CSV parser (LTCSVLoader) miscounts quote balance when a
                    // quoted field's content ends in ",\"" - it treats the record as still open and
                    // silently merges the NEXT row into it, permanently dropping that next row from
                    // whatever dictionary/list it should have populated (see KungFuData.csv id=733's
                    // description swallowing id=734's row entirely). Skipped columns keep the raw
                    // row's byte-for-byte value and must not be touched.
                    for (var i = 0; i < splits.Length; i++)
                    {
                        if (textFileToTranslate.SkipColumns.Contains(i))
                            continue;

                        splits[i] = GameFileHandling.StripTrailingCommaBeforeQuote(splits[i]);
                    }

                    line.Translated = GameFileHandling.RebuildCsvRow(splits);

                    if (!failed)
                    {
                        //Reverse the Hyphen to a normal hyphen so it can be read in the game
                        line.Translated = line.Translated.Replace("\u2011", "-");
                        outputLines.Add(line.Translated);
                    }
                    else
                    {
                        outputLines.Add(line.Raw);
                        failedLines.Add(line.Raw);
                    }
                }


                FileHelper.WriteAllLinesWithRetry($"{outputPath}/{textFileToTranslate.Path}", outputLines);

                passedCount += outputLines.Count;
                failedCount += failedLines.Count;

                await Task.CompletedTask;
            });

            // Write out the small, dedicated atlas-sprite-name lookup file(s) collected above -
            // see DynamicStringSources.AtlasSpriteNameColumnSources. Flat raw/result YAML, same
            // shape as the packaged dynamicStrings*.txt.yaml files, so the plugin's existing
            // DictionaryEntry deserializer can load it directly.
            foreach (var (outputFileName, pairs) in atlasSpriteNamePairs)
            {
                var deduped = pairs
                    .GroupBy(p => p.Raw)
                    .Select(g => g.First());

                var yamlLines = deduped.Select(p =>
                    $"- raw: \"{EscapeYamlDoubleQuoted(p.Raw)}\"\n  result: \"{EscapeYamlDoubleQuoted(p.Result)}\"");

                FileHelper.WriteAllTextWithRetry($"{outputPath}/{outputFileName}.yaml", string.Join("\n", yamlLines) + "\n");
            }

            Console.WriteLine($"Passed: {passedCount}");
            Console.WriteLine($"Failed: {failedCount}");
        }

        // Minimal YAML double-quoted scalar escaping (backslash and double-quote only - none of
        // these source strings are expected to contain other control characters).
        private static string EscapeYamlDoubleQuoted(string s) => s.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}
