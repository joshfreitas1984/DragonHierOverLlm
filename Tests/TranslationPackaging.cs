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

            // The HeroData.AddLog/AreaData.AddLog "log narrative" family (see
            // DynamicStringSources.LogNarrativeTemplates and dynamicStringsLogNarratives.txt) -
            // added 2026-09-13 after inspecting this family's actual packaged Results in
            // Files/Mod/dynamicStrings.txt.yaml. Every one of them showed the same
            // fragment-translation symptoms: a capitalized fragment mid-sentence right after the
            // "{0}"/"{1}" placeholder (translated independently of the words around it, so it reads
            // like a sentence fragment rather than a continuation - "{0} In {1} Practiced martial
            // arts {2}."), retained full-width Chinese punctuation ("，"/"。") glued onto an English
            // sentence, and missing connective words ("and", "at", possessives) that a human
            // translator would supply from context a template-fragment translation never sees.
            // Rewritten below as single natural sentences with a placeholder kept only where it
            // carries real content (a name, place, or number) - never as a sentence-initial
            // fragment. Uses gender-neutral "they/their" throughout since {0} may be any hero
            // regardless of gender (the original fragment translation hardcoded "he" in at least one
            // case - "被晋升为" below).
            ["{0}在{1}结束关押，恢复了自由之身。"] = "{0} was released from custody at {1} and regained their freedom.",
            ["{0}在{1}闲逛之时，意外获取了{2}两银钱。"] = "{0} was strolling around {1} and unexpectedly came into {2} silver.",
            ["{0}在{1}闲逛之时，意外获取了一件{2}。"] = "{0} was strolling around {1} and unexpectedly picked up a {2}.",
            ["{0}在{1}修习了武功{2}。"] = "{0} practiced the martial art {2} at {1}.",
            ["{0}在{1}修习了{2}技艺。"] = "{0} practiced the {2} skill at {1}.",
            ["{0}在{1}辛勤劳作，为门派收获了{2}。"] = "{0} worked hard at {1} and brought in {2} for the sect.",
            ["{0}在{1}打工赚钱，获取了{2}两银钱。"] = "{0} took on odd jobs at {1} and earned {2} silver.",
            ["{0}在{1}四下探索之时，意外发现了{2}。"] = "{0} was exploring around {1} and stumbled upon {2}.",
            ["{0}在{1}与{2}相谈盛欢，一见如故，结为知己好友。"] =
                "{0} had a wonderful conversation with {2} at {1}; they hit it off at once and became close friends.",
            ["{0}在{1}欲下毒暗害{2}，{3}。"] = "{0} tried to poison {2} at {1} - {3}.",
            ["{0}在{1}欲{5}{2}的{3}，{4}。"] = "{0} tried to {5} {2}'s {3} at {1} - {4}.",
            ["{0}在{1}欲偷师{2}的{3}，{4}。"] = "{0} tried to secretly learn {2}'s {3} at {1} - {4}.",
            ["{0}在{1}与{2}心生嫌隙，结下了深仇大恨。"] = "{0} had a falling out with {2} at {1}, and a deep grudge formed between them.",
            ["{0}在{1}与{2}交流心得，切磋武艺，最终{3}。"] = "{0} traded notes and sparred with {2} at {1}, and in the end {3}.",
            ["{0}在{1}袭击了{2}，血战一场最终{3}。"] = "{0} attacked {2} at {1}; after a bloody battle, {3}.",
            ["{0}在{1}完成了重要委托，名望{2}，银两{3}，并获得了{4}。"] =
                "{0} completed an important commission at {1}, gaining {2} renown and {3} silver, and receiving {4}.",
            ["{0}在{1}遭逢{5}奇遇，名望{2}，银两{3}，并获得了{4}。"] =
                "{0} had a {5} encounter at {1}, gaining {2} renown and {3} silver, and receiving {4}.",
            ["{0}在{1}上下打点，花费{3}银两降低了{2}点恶名。"] = "{0} greased some palms at {1}, spending {3} silver to lower their infamy by {2}.",
            ["{0}在{1}习得了新武功{2}。"] = "{0} learned the new martial art {2} at {1}.",
            ["{0}在{1}暗中破坏，使该地{2}降低{3}点。"] = "{0} secretly sabotaged {1}, lowering its {2} by {3}.",
            ["{0}烹饪了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} cooked {1} and put it in their bag (spent {2} silver{3})",
            ["{0}烹饪了{1}并放入门派仓库(消耗{2}粮食{3})"] = "{0} cooked {1} and put it in the sect's storehouse (spent {2} food{3})",
            ["{0}烹饪了{1}，由于门派仓库已满只得放入行囊(消耗{2}粮食{3})"] =
                "{0} cooked {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} food{3})",
            ["{0}炼制了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} crafted {1} and put it in their bag (spent {2} silver{3})",
            ["{0}炼制了{1}并放入门派仓库(消耗{2}药材{3})"] = "{0} crafted {1} and put it in the sect's storehouse (spent {2} herbs{3})",
            ["{0}炼制了{1}，由于门派仓库已满只得放入行囊(消耗{2}药材{3})"] =
                "{0} crafted {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} herbs{3})",
            ["{0}制造了{1}并放入行囊(消耗{2}银钱{3})"] = "{0} made {1} and put it in their bag (spent {2} silver{3})",
            ["{0}制造了{1}并放入门派仓库(消耗{2}木料矿石{3})"] = "{0} made {1} and put it in the sect's storehouse (spent {2} timber and ore{3})",
            ["{0}制造了{1}，由于门派仓库已满只得放入行囊(消耗{2}木料矿石{3})"] =
                "{0} made {1}, but the sect's storehouse was full, so it went into their bag instead (spent {2} timber and ore{3})",
            ["{0}在{1}买卖交易，出售了闲置物品{2}{3}。"] = "{0} traded at {1}, selling off unused {2}{3}.",
            ["{0}使用门派银钱{1}两，购买{2}。"] = "{0} spent {1} silver from the sect's coffers to buy {2}.",
            ["{0}出售门派{1}，换取门派银钱{2}两。"] = "{0} sold {1} from the sect, earning {2} silver for the sect's coffers.",
            ["{0}与{1}情谊渐浅，断绝了好友关系。"] = "{0} and {1} grew apart, and their friendship came to an end.",
            ["{0}与{1}冰释前嫌，化解了二人间的仇恨。"] = "{0} and {1} put their old grievances behind them and made peace.",
            ["{0}被{1}抓捕入狱，关押在{2}之中。"] = "{0} was captured by {1} and thrown into {2}.",
            ["{0}向{3}仓库捐赠了{1}，获取功绩{2}"] = "{0} donated {1} to {3}'s storehouse, earning {2} merit",
            ["{0}从{3}仓库购买了{1}，花费银两{2}"] = "{0} bought {1} from {3}'s storehouse, spending {2} silver",
            // {0} is a product/listing name, {1} an area, {2} either "风靡" (a hit) or "滞销"
            // (unsold) - see GameController.cs:20086-20091.
            ["{0}的{1}结束{2}了。"] = "{0}'s {1} run at {2} has ended.",
            ["{0}<b>{1}</b>{2}，买卖价格{3}。"] = "{0} <b>{1}</b>{2}, trade price {3}.",
            ["{0}收到门派{1}银钱嘉奖，忠诚+3"] = "{0} received a {1} silver reward from the sect, loyalty +3",
            ["{0}在{1}参加{6}，勇夺第{2}名，银两+{3}，{4}，并获得了奖品{5}。"] =
                "{0} took part in {6} at {1}, took {2} place, +{3} silver, {4}, and won the prize {5}.",
            ["{0}在{1}参加{5}赛马大会，勇夺第{2}名，银两+{3}，声望+{4}。"] =
                "{0} took part in the {5} horse race at {1}, took {2} place, +{3} silver, +{4} renown.",
            ["{0}在{1}参加{2}拍卖大会，花费{3}两购得一件{4}。"] = "{0} attended the {2} auction at {1}, spending {3} silver to win {4}.",
            ["{0}吉人天相，寻得高人所刻石碑，潜心研读后提升了{1}潜力。"] =
                "{0} had a stroke of good fortune, finding a stone tablet carved by a master. Studying it closely raised their {1} potential.",
            ["{0}吉人天相，{2}，学会了武功{1}。"] = "{0} had a stroke of good fortune - {2} - and learned the martial art {1}.",
            ["{0}吉人天相，寻得前朝皇家宝库，获得了{1}等诸多珍宝。"] =
                "{0} had a stroke of good fortune, finding a royal treasury from the last dynasty and coming away with {1} and other treasures.",
            ["{0}气运过人，寻得一本失传秘籍，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a lost manual, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}吉星高照，得到一株异草，服食后生命上限增加{1}。"] =
                "{0}'s stars aligned, and they found a strange herb; eating it raised their max health by {1}.",
            ["{0}吉星高照，寻得失落宝藏，搜刮后获得了{1}两银钱。"] =
                "{0}'s stars aligned, and they found a lost treasure, coming away with {1} silver.",
            ["{0}吉星高照，得到一枚灵果，服食后内力上限增加{1}。"] =
                "{0}'s stars aligned, and they found a spirit fruit; eating it raised their max internal energy by {1}.",
            ["{0}气运过人，寻得一件神兵利器，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a divine weapon, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}气运过人，寻得一匹千里名驹，鉴别后竟是传说中的{1}。"] =
                "{0}'s luck ran high - they found a swift, thousand-mile steed, and on closer inspection it turned out to be the legendary {1}.",
            ["{0}近日大兴土木，开始修缮升级{1}{2}({3}级)"] = "{0} has begun major construction, upgrading {1} {2} (Level {3})",
            ["{0}近日大兴土木，开始在{1}新建{2}"] = "{0} has begun major construction, building a new {2} at {1}",
            ["{0}近日大兴土木，开始拆除{1}{2}({3}级)"] = "{0} has begun major construction, demolishing {1} {2} (Level {3})",
            // {0} is the sect name, {1} its Sect Master - see GameController.cs:28074.
            ["{0}掌门{1}将《{2}》{3}秘籍放入藏经阁，供全派弟子参阅。"] =
                "{0}'s Sect Master {1} placed the manual 《{2}》 ({3}) in the Scripture Pavilion for all disciples to study.",
            ["{0}掌门{1}用《{2}》{3}替换了藏经阁内的《{2}》{4}秘籍，供全派弟子参阅。"] =
                "{0}'s Sect Master {1} replaced the Scripture Pavilion's 《{2}》 ({4}) with 《{2}》 ({3}), for all disciples to study.",
            ["{0}因功勋卓著，被晋升为{1}。"] = "{0} was promoted to {1} for their outstanding service.",
            ["{0}攻击了{2}掌控下的{1}，最终{3}。"] = "{0} attacked {1}, under {2}'s control, and in the end {3}.",
            ["{0}加入了由{1}领导的队伍。"] = "{0} joined the team led by {1}.",
            ["{0}离开了由{1}领导的队伍。"] = "{0} left the team led by {1}.",
            ["{0}对自身装备的{1}进行了粹毒。"] = "{0} coated their own {1} with poison.",
            ["{0}对自身的{1}上进行了下毒。"] = "{0} poisoned their own {1}.",
            ["{0}领悟了天赋：{1}"] = "{0} gained the talent: {1}",
            ["{0}近日开始加强{1}分舵之{2}防御等级({3}级)"] = "{0} has begun reinforcing the {2} defenses of the {1} branch (Level {3})",
            ["{0}在{1}暗中破坏，使该地{2}降低了{3}点。"] = "{0} secretly sabotaged {1}, lowering its {2} by {3}.",
            ["{0}在{1}开展治理，使该地{2}提升了{3}点。"] = "{0} carried out improvements at {1}, raising its {2} by {3}.",
            // "{0}{1}{2}，{3}" (HeroData.cs:18642) is deliberately NOT overridden here - it has no
            // fixed literal words at all (every segment is a placeholder), so there is no
            // connective-tissue mistranslation to fix; whatever awkwardness it has comes entirely
            // from its own filled-in argument values, which this exact-Raw override mechanism can't
            // address.
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
            string outputPath = $"{workingDirectory}/Mod";

            if (Directory.Exists(outputPath))
                Directory.Delete(outputPath, true);

            Directory.CreateDirectory(outputPath);

            var passedCount = 0;
            var qcRejectedCount = 0;
            var rawFallbackCount = 0;

            // Flat-text workflows are packaged separately from CSV files.
            var csvTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.RawCsv);
            var prefabTextFiles = textFiles.Where(t => t.TextFileType == TextFileType.PrefabText);
            var dynamicStringFiles = textFiles.Where(t => t.TextFileType == TextFileType.DynamicStringsIL2CPP);

            foreach (var prefabTextFile in prefabTextFiles)
            {
                var (passed, qcRejected, rawFallback) = await PrefabTextWorkflow.PackagePrefabTextAsync(workingDirectory, prefabTextFile);
                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;
            }

            foreach (var dynamicStringFile in dynamicStringFiles)
            {
                var (passed, qcRejected, rawFallback) = await DynamicStringWorkflow.PackageDynamicStringsAsync(workingDirectory, dynamicStringFile);
                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;

                // Force known-bad reconstructed template results regardless of whatever
                // translation currently sits in Files/Converted - see
                // DynamicStringResultOverrides for why this can't just be fixed by editing the
                // Converted/Mod YAML directly (re-export/re-translation would silently undo it).
                ApplyDynamicStringResultOverrides(workingDirectory, dynamicStringFile);

                // Drop junk entries whose Raw has no Chinese at all - see
                // RemoveNonChineseDynamicStringEntries.
                RemoveNonChineseDynamicStringEntries(workingDirectory, dynamicStringFile);
            }

            // Collected via CsvGameDataWorkflow.PackageAsync's onColumnPackaged callback below -
            // see DynamicStringSources.AtlasSpriteNameColumnSources.
            var atlasSpriteNamePairs = new Dictionary<string, List<(string Raw, string Result)>>();

            foreach (var textFile in csvTextFiles)
            {
                var atlasSpriteNameSources = DynamicStringSources.AtlasSpriteNameColumnSources
                    .Where(s => s.CsvFileName == textFile.Path)
                    .ToArray();

                var (passed, qcRejected, rawFallback) = await CsvGameDataWorkflow.PackageAsync(
                    workingDirectory,
                    textFile,
                    onColumnPackaged: (column, rawText, packagedText) =>
                    {
                        // Copy this row's already-translated (Text, Translated) pair for any
                        // AtlasSpriteNameColumnSources column - see that array's comment.
                        foreach (var source in atlasSpriteNameSources.Where(s => s.Column == column))
                        {
                            if (string.IsNullOrEmpty(rawText) || string.IsNullOrEmpty(packagedText))
                                continue;
                            if (!atlasSpriteNamePairs.TryGetValue(source.OutputFileName, out var pairs))
                                atlasSpriteNamePairs[source.OutputFileName] = pairs = new();
                            pairs.Add((rawText, packagedText));
                        }
                    },
                    rowPostProcess: splits =>
                    {
                        // A translated cell ending in a bare comma (e.g. an LLM ending a sentence
                        // with "," instead of a period) is always safe per RFC 4180 quoting, but
                        // the game's own hand-rolled CSV parser (LTCSVLoader) miscounts quote
                        // balance when a quoted field's content ends in ",\"" - it treats the
                        // record as still open and silently merges the NEXT row into it,
                        // permanently dropping that next row from whatever dictionary/list it
                        // should have populated (see KungFuData.csv id=733's description
                        // swallowing id=734's row entirely). Skipped columns keep the raw row's
                        // byte-for-byte value and must not be touched.
                        for (var i = 0; i < splits.Length; i++)
                        {
                            if (textFile.SkipColumns.Contains(i))
                                continue;

                            splits[i] = GameFileHandling.StripTrailingCommaBeforeQuote(splits[i]);
                        }

                        return splits;
                    });

                passedCount += passed;
                qcRejectedCount += qcRejected;
                rawFallbackCount += rawFallback;
            }

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
            Console.WriteLine($"QC failures: {qcRejectedCount}");
            Console.WriteLine($"Fell back to raw: {rawFallbackCount}");
        }

        // Minimal YAML double-quoted scalar escaping (backslash and double-quote only - none of
        // these source strings are expected to contain other control characters).
        private static string EscapeYamlDoubleQuoted(string s) => s.Replace("\\", "\\\\").Replace("\"", "\\\"");
    }
}
