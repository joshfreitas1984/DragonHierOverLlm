using FanslationStudio.LlmKit.Support;

namespace Tests;

public class PlotLineContextTests
{
    private const string Header = "剧情编号,角色左,角色右,高亮方 右/左/无/皆,背景图片,背景音乐,播放音效,PlotShock,调用函数,选项,内容";

    private static readonly Dictionary<string, string> Genders = new() { ["杨思迟"] = "男", ["雷殷殷"] = "女" };

    private static TranslationLine Row(string columns, string content, int column = 10) => new()
    {
        Raw = $"{columns}{content}",
        Splits = [new TranslationSplit { Split = column, Text = content }],
    };

    private static LineContext? ContextOf(IReadOnlyDictionary<TranslationSplit, LineContext> contexts, TranslationLine line) =>
        contexts.TryGetValue(line.Splits[0], out var context) ? context : null;

    [Fact(DisplayName = "PlotLineContext gives stage directions the speaker's gender, carries speakers across rows and resets per scene")]
    public void StageDirections_GetSpeakerContext()
    {
        var maleFirst = Row("1,无,杨思迟,右,,,,,,,", "（摸了摸眼泪）");
        var maleCarried = Row(",,,右,,,,,,,", "（揉了揉眼睛）");
        var female = Row(",雷殷殷,,左,,,,,,,", "（微微一笑）");
        var player = Row(",玩家,,左,,,,,,,", "（扑通一声跪在地上）");
        var temp = Row(",临时:钱捕头,,左,,,,,,,", "（拍了拍桌子）");
        var both = Row(",雷殷殷,杨思迟,皆,,,,,,,", "（同时点了点头）");
        var narration = Row("2,无,无,无,,,,,,,", "只见一个人影出现在崖边，");
        var sceneReset = Row("3,,,右,,,,,,,", "（低头不语）");
        var lines = new List<TranslationLine> { new() { Raw = Header }, maleFirst, maleCarried, female, player, temp, both, narration, sceneReset };

        var contexts = PlotLineContext.Build(lines, Genders);

        Assert.True(ContextOf(contexts, maleFirst)!.GenderKnown);
        Assert.Equal(LineContext.Male, ContextOf(contexts, maleFirst)!.Gender);
        Assert.Contains("male character", ContextOf(contexts, maleFirst)!.Prompt);
        Assert.DoesNotContain("female", ContextOf(contexts, maleFirst)!.Prompt);

        // 角色 left blank on the next row: the same speaker carries over.
        Assert.Equal(ContextOf(contexts, maleFirst), ContextOf(contexts, maleCarried));

        Assert.True(ContextOf(contexts, female)!.GenderKnown);
        Assert.Equal(LineContext.Female, ContextOf(contexts, female)!.Gender);
        Assert.Contains("female character", ContextOf(contexts, female)!.Prompt);

        // The player's gender is never assumed.
        Assert.False(ContextOf(contexts, player)!.GenderKnown);
        Assert.Contains("player", ContextOf(contexts, player)!.Prompt);

        Assert.False(ContextOf(contexts, temp)!.GenderKnown);
        Assert.Contains("unknown", ContextOf(contexts, temp)!.Prompt);

        // 皆 highlights both sides, so the speaker is ambiguous, not a known gender.
        Assert.False(ContextOf(contexts, both)!.GenderKnown);

        Assert.False(ContextOf(contexts, narration)!.GenderKnown);
        Assert.Contains("narration", ContextOf(contexts, narration)!.Prompt);

        // A new scene id clears the carried characters, so a right-side stage direction has no speaker left.
        Assert.Contains("narration", ContextOf(contexts, sceneReset)!.Prompt);
    }

    [Fact(DisplayName = "PlotLineContext leaves spoken lines and non-content columns alone")]
    public void SpokenLinesAndOtherColumns_GetNoContext()
    {
        var spoken = Row("1,无,杨思迟,右,,,,,,,", "我今天一定要赢！");
        var choice = Row(",,,右,,,,,,", "选项文字", column: 9);
        var lines = new List<TranslationLine> { new() { Raw = Header }, spoken, choice };

        var contexts = PlotLineContext.Build(lines, Genders);

        Assert.Null(ContextOf(contexts, spoken));
        Assert.Null(ContextOf(contexts, choice));
    }

    [Fact(DisplayName = "PlotLineContext hints any split containing an unknown-gender person token, in any file, without overriding a speaker context")]
    public void TokenLines_GetUnknownGenderHint()
    {
        var spoken = Row("1,无,杨思迟,右,,,,,,,", "#PlayerName#手脚挺快，");
        var stage = Row(",雷殷殷,,左,,,,,,,", "（拍了拍#PlayerName#的肩膀）");
        var target = new TranslationLine { Raw = "x", Splits = [new TranslationSplit { Split = 3, Text = "#TargetInteractName#来了" }] };
        var faction = new TranslationLine { Raw = "y", Splits = [new TranslationSplit { Split = 3, Text = "#PlayerForceName#来了" }] };
        var plot = new List<TranslationLine> { new() { Raw = Header }, spoken, stage };

        var contexts = PlotLineContext.Build(plot, Genders).ToDictionary();
        PlotLineContext.AddTokenContexts(contexts, plot);
        PlotLineContext.AddTokenContexts(contexts, [target, faction]);

        Assert.False(ContextOf(contexts, spoken)!.GenderKnown);
        Assert.Contains("gender is unknown", ContextOf(contexts, spoken)!.Prompt);
        // The stage direction keeps its speaker context (a known female speaker).
        Assert.True(ContextOf(contexts, stage)!.GenderKnown);
        Assert.Contains("female character", ContextOf(contexts, stage)!.Prompt);
        Assert.Contains("gender is unknown", ContextOf(contexts, target)!.Prompt);
        // A faction token is not a person.
        Assert.Null(ContextOf(contexts, faction));
    }

    [Fact(DisplayName = "PlotLineContext does nothing without the expected header columns")]
    public void MissingHeader_GivesNoContext()
    {
        var lines = new List<TranslationLine> { new() { Raw = "a,b,c" }, Row("1,无,杨思迟,右,,,,,,,", "（笑了笑）") };

        Assert.Empty(PlotLineContext.Build(lines, Genders));
    }

    [Fact(DisplayName = "PlotLineContext reads hero genders from SpeHeroData.csv and drops the name separator")]
    public void LoadHeroGenders_ReadsNamesAndGenders()
    {
        var genders = PlotLineContext.LoadHeroGenders(GameFileHandling.WorkingDirectory);

        Assert.True(genders.Count > 100);
        Assert.Equal("男", genders["姜映泉"]);
    }
}
