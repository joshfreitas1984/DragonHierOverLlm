using FanslationStudio.LlmKit.Support;

namespace Tests
{
    /// <summary>
    /// Per-line context for PlotData.csv: tells the translator whose action a stage direction describes and
    /// whether that speaker's gender is known, so it can write "he"/"she" where the game knows the gender and
    /// "they"/"you" where it does not (the player's gender is chosen per playthrough, so it is never assumed).
    /// Also marks speaker-less lines as narration addressed to the player ("you", never "I").
    ///
    /// The speaker comes from the 角色左/角色右 columns plus 高亮方 (which side is highlighted). Plot rows leave a
    /// 角色 column blank when the character is unchanged, so the current left/right characters carry over from
    /// the previous row and reset when a new 剧情编号 (scene id) starts. Gender comes from SpeHeroData.csv.
    /// Only stage directions and speaker-less narration get a context; ordinary spoken lines translate as before.
    /// Used only when Config.yaml's lineContextEnabled is true.
    /// </summary>
    public static class PlotLineContext
    {
        private const string PlotFile = "PlotData.csv";
        private const int ContentColumn = 10;

        // Maps a gender to the hint wording; the player and unknown speakers never get he/she.
        private const string MaleHint = "Context: the omitted subject of this stage direction is the speaker, a male character. Refer to him as he/his/him where a pronoun is needed. A name or pronoun in the text refers to whoever it names.";
        private const string FemaleHint = "Context: the omitted subject of this stage direction is the speaker, a female character. Refer to her as she/her where a pronoun is needed. A name or pronoun in the text refers to whoever it names.";
        private const string PlayerHint = "Context: the omitted subject of this stage direction is the player, whose gender is unknown. Write \"you\" or leave the subject out; never he or she.";
        private const string UnknownHint = "Context: the gender of the omitted subject of this stage direction is unknown. Use \"they\" or leave the subject out; never he or she.";
        private const string NarrationHint = "Context: this is narration addressed to the player. Write \"you\" or leave the subject out; never \"I\".";

        private static readonly Lazy<IReadOnlyDictionary<string, string>> HeroGenders = new(() => LoadHeroGenders(GameFileHandling.WorkingDirectory));

        public static IReadOnlyDictionary<TranslationSplit, LineContext> Provide(string workingDirectory, TextFileToSplit textFile, IReadOnlyList<TranslationLine> lines)
        {
            if (!string.Equals(textFile.Path, PlotFile, StringComparison.OrdinalIgnoreCase))
                return new Dictionary<TranslationSplit, LineContext>();

            // The cached lookup is for the game's own working directory; any other directory (a test copy) is read directly.
            var genders = string.Equals(workingDirectory, GameFileHandling.WorkingDirectory, StringComparison.Ordinal)
                ? HeroGenders.Value
                : LoadHeroGenders(workingDirectory);

            return Build(lines, genders);
        }

        /// <summary>Builds the contexts for a PlotData file's lines. <paramref name="heroGenders"/> maps a character name to 男 or 女.</summary>
        public static IReadOnlyDictionary<TranslationSplit, LineContext> Build(IReadOnlyList<TranslationLine> lines, IReadOnlyDictionary<string, string> heroGenders)
        {
            var contexts = new Dictionary<TranslationSplit, LineContext>();
            if (lines.Count == 0)
                return contexts;

            var header = lines[0].Raw.Split(',');
            var sceneColumn = 0;
            var leftColumn = Array.IndexOf(header, "角色左");
            var rightColumn = Array.IndexOf(header, "角色右");
            var highlightColumn = Array.FindIndex(header, column => column.StartsWith("高亮方", StringComparison.Ordinal));
            if (leftColumn < 0 || rightColumn < 0 || highlightColumn < 0)
                return contexts;

            string left = string.Empty, right = string.Empty;

            foreach (var line in lines.Skip(1))
            {
                // The first ten columns never contain a comma or quote; only 内容 (column 10) can.
                var columns = line.Raw.Split(',', ContentColumn + 1);
                if (columns.Length <= ContentColumn)
                    continue;

                if (columns[sceneColumn].Length > 0)
                    left = right = string.Empty;
                if (columns[leftColumn].Length > 0)
                    left = columns[leftColumn] == "无" ? string.Empty : columns[leftColumn];
                if (columns[rightColumn].Length > 0)
                    right = columns[rightColumn] == "无" ? string.Empty : columns[rightColumn];

                var side = columns[highlightColumn];
                var speaker = side switch { "左" => left, "右" => right, _ => string.Empty };
                // "皆" highlights both sides, so the speaker is ambiguous rather than absent.
                var ambiguous = side == "皆";

                foreach (var split in line.Splits)
                {
                    if (split.Split != ContentColumn || split.Text.Length == 0)
                        continue;

                    var isStageDirection = split.Text.TrimStart().StartsWith('（') || split.Text.TrimStart().StartsWith('(');
                    var context = ContextFor(isStageDirection, speaker, ambiguous, heroGenders);
                    if (context != null)
                        contexts[split] = context;
                }
            }

            return contexts;
        }

        private static LineContext? ContextFor(bool isStageDirection, string speaker, bool ambiguous, IReadOnlyDictionary<string, string> heroGenders)
        {
            if (speaker.Length == 0 && !ambiguous)
                return new LineContext(NarrationHint, GenderKnown: false);

            if (!isStageDirection)
                return null;

            if (speaker == "玩家")
                return new LineContext(PlayerHint, GenderKnown: false);

            if (heroGenders.TryGetValue(speaker, out var gender))
                return gender switch
                {
                    "男" => new LineContext(MaleHint, GenderKnown: true, LineContext.Male),
                    "女" => new LineContext(FemaleHint, GenderKnown: true, LineContext.Female),
                    _ => new LineContext(UnknownHint, GenderKnown: false),
                };

            return new LineContext(UnknownHint, GenderKnown: false);
        }

        /// <summary>Reads 名字 and 性别 from SpeHeroData.csv. Names are stored with a "." between family and given name; plot rows omit it.</summary>
        public static IReadOnlyDictionary<string, string> LoadHeroGenders(string workingDirectory)
        {
            var genders = new Dictionary<string, string>();
            var path = Path.Combine(workingDirectory, "Raw", "Dumped", "GameData", "SpeHeroData.csv");
            if (!File.Exists(path))
                return genders;

            var rows = File.ReadAllLines(path);
            if (rows.Length == 0)
                return genders;

            var header = rows[0].TrimStart('﻿').Split(',');
            var nameColumn = Array.IndexOf(header, "名字");
            var genderColumn = Array.IndexOf(header, "性别");
            if (nameColumn < 0 || genderColumn < 0)
                return genders;

            foreach (var row in rows.Skip(1))
            {
                var columns = row.Split(',');
                if (columns.Length > Math.Max(nameColumn, genderColumn))
                    genders[columns[nameColumn].Replace(".", string.Empty)] = columns[genderColumn];
            }

            return genders;
        }
    }
}
