using FanslationStudio.LlmKit.Support;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests;

public class CompoundFieldSplitterTests
{
    [Fact(DisplayName = "Digits glued to Chinese text stay in one fragment")]
    public void DigitsGluedToChineseStayInOneFragment()
    {
        var (template, fragments) = CompoundFieldSplitter.Decompose("累计在战斗中亲手击败500人");

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal("累计在战斗中亲手击败500人", fragments[0]);
    }

    [Fact(DisplayName = "Operators still separate stat name from its value")]
    public void OperatorsStillSeparateStatFromValue()
    {
        var (template, fragments) = CompoundFieldSplitter.Decompose("威望+10");

        Assert.Equal("{0}+10", template);
        Assert.Single(fragments);
        Assert.Equal("威望", fragments[0]);
    }

    [Fact(DisplayName = "Trivial whole-cell template is detected")]
    public void TrivialWholeCellTemplateIsDetected()
    {
        var (template, fragments) = CompoundFieldSplitter.Decompose("珍宝在鉴定后才能卖出更高价格");

        Assert.True(CompoundFieldSplitter.IsTrivialTemplate(template, fragments.Count));
    }

    [Fact(DisplayName = "Pre-existing literal {n} format placeholders don't collide with synthesized fragment placeholders")]
    public void LiteralNumericPlaceholdersDontCollideWithFragmentPlaceholders()
    {
        var original = "{0}年{1}月{2}日";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        var translated = fragments.Select(f => f switch
        {
            "年" => "Year",
            "月" => "Month",
            "日" => "Day",
            _ => f,
        }).ToList();

        Assert.Equal("{0}Year{1}Month{2}Day", CompoundFieldSplitter.Reconstruct(template, translated));
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Compound cell with role separators still splits into multiple fragments")]
    public void CompoundCellWithRoleSeparatorsStillSplits()
    {
        var original = "门派弟子?查看弟子相关信息--ShowForceHero;门派职位?管理门派特殊职位-我&长老-ManageForceSetting";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.False(CompoundFieldSplitter.IsTrivialTemplate(template, fragments.Count));
        Assert.Equal(["门派弟子", "查看弟子相关信息", "门派职位", "管理门派特殊职位", "我", "长老"], fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Empty Templates/Splits lists are omitted from serialized YAML")]
    public void EmptyTemplatesAndSplitsListsAreOmittedFromYaml()
    {
        var line = new TranslationLine("ID,Name") { Splits = [], Templates = [] };

        var serializer = YamlHelper.CreateSerializer();
        var yaml = serializer.Serialize(line);

        Assert.DoesNotContain("templates:", yaml);
        Assert.DoesNotContain("splits:", yaml);
    }

    [Fact(DisplayName = "Negative sentinel value glues with its surrounding parenthetical into one fragment")]
    public void NegativeSentinelValueGluesWithParentheticalIntoOneFragment()
    {
        var original = "占领门派（-99表示自动）";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal(original, fragments[0]);
    }

    [Fact(DisplayName = "Percentage threshold stays glued to the surrounding clause")]
    public void PercentageThresholdStaysGluedToClause()
    {
        var original = "同盟区域50%后进入门派/自宅";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}/{1}", template);
        Assert.Equal(["同盟区域50%后进入门派", "自宅"], fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Wide-char commas within a sentence stay glued into one fragment (punctuation can move during translation)")]
    public void WideCharCommasStayGluedIntoOneFragment()
    {
        var original = "成为门派掌门，正厅10级且人口200以上，取得掌门大会冠军后进入门派/自宅";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}/{1}", template);
        Assert.Equal(["成为门派掌门，正厅10级且人口200以上，取得掌门大会冠军后进入门派", "自宅"], fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Wide-char question mark and exclamation mark stay glued into the same fragment")]
    public void WideCharQuestionAndExclamationStayGluedIntoSameFragment()
    {
        var original = "确定要离开吗？此操作无法撤销！确定？";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal(original, fragments[0]);
    }

    [Fact(DisplayName = "Wide-char full stop ('。') stays glued into the same fragment as the sentence")]
    public void WideCharFullStopStaysGluedIntoSameFragment()
    {
        var original = "珍宝在鉴定后才能卖出更高价格。";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal(original, fragments[0]);
        Assert.True(CompoundFieldSplitter.IsTrivialTemplate(template, fragments.Count));
    }

    [Fact(DisplayName = "Mixed full-width punctuation across a whole multi-clause sentence stays one fragment")]
    public void MixedFullWidthPunctuationAcrossWholeSentenceStaysOneFragment()
    {
        var original = "门派的占领区域达到上限后，\\n就无法占领新的区域。真的要继续吗？请注意！";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        // '\\n' (an ASCII literal escape sequence used by the game, not a real newline character)
        // is not part of the CJK/fullwidth text classes, so it still forms a genuine boundary here.
        Assert.Equal("{0}\\n{1}", template);
        Assert.Equal(["门派的占领区域达到上限后，", "就无法占领新的区域。真的要继续吗？请注意！"], fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Curly Chinese quotation marks around a quoted word stay glued into the surrounding sentence")]
    public void CurlyChineseQuotationMarksStayGluedIntoSurroundingSentence()
    {
        var original = "嗯？当真如此？让我瞧瞧。\\n（将三本秘籍摊开，都翻到小数字为“一”的那一页）";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        // '\\n' is a genuine ASCII literal boundary (see MixedFullWidthPunctuationAcrossWholeSentenceStaysOneFragment),
        // but the curly quotes '“'/'”' around '一' must not split the parenthetical sentence apart.
        Assert.Equal("{0}\\n{1}", template);
        Assert.Equal(["嗯？当真如此？让我瞧瞧。", "（将三本秘籍摊开，都翻到小数字为“一”的那一页）"], fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Standalone signed numeric fields with no adjacent Chinese remain fully literal")]
    public void StandaloneSignedNumericFieldsRemainLiteral()
    {
        var original = "1000-12-0-0/1/2/3/4/5";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal(original, template);
        Assert.Empty(fragments);
    }

    [Fact(DisplayName = "Without placeholder options, a game placeholder token between two Chinese runs is a fixed boundary")]
    public void WithoutPlaceholderOptionsTokenIsFixedBoundary()
    {
        var original = "欢迎回来，#PlayerName#，今天也要加油哦";
        var (template, fragments) = CompoundFieldSplitter.Decompose(original);

        Assert.Equal("{0}#PlayerName#{1}", template);
        Assert.Equal(["欢迎回来，", "，今天也要加油哦"], fragments);
    }

    [Fact(DisplayName = "With placeholder options configured, a game placeholder token glues into a single fragment")]
    public void WithPlaceholderOptionsTokenGluesIntoSingleFragment()
    {
        var original = "欢迎回来，#PlayerName#，今天也要加油哦";
        var options = new CompoundFieldSplitterOptions
        {
            PlaceholderPatterns = [new Regex(@"#\w+#", RegexOptions.Compiled)]
        };

        var (template, fragments) = CompoundFieldSplitter.Decompose(original, options);

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal(original, fragments[0]);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "Placeholder token at the very start of a compound cell still glues to the following clause")]
    public void PlaceholderTokenAtStartStillGluesToFollowingClause()
    {
        var original = "#PlayerName#大人，欢迎回来";
        var options = new CompoundFieldSplitterOptions
        {
            PlaceholderPatterns = [new Regex(@"#\w+#", RegexOptions.Compiled)]
        };

        var (template, fragments) = CompoundFieldSplitter.Decompose(original, options);

        Assert.Equal("{0}", template);
        Assert.Single(fragments);
        Assert.Equal(original, fragments[0]);
    }

    [Fact(DisplayName = "A lone fullwidth punctuation mark stranded between two placeholder tokens still merges into the following sentence")]
    public void LoneFullwidthPunctuationBetweenPlaceholderTokensStillMerges()
    {
        var original = "#PlayerName#！#PlayerName#！都日上三竿了，怎么还在睡大觉呢！\\n嘴里还一直念叨着什么“看招”，“承让”，\\n怕不是又在梦里行侠仗义了。";
        var options = new CompoundFieldSplitterOptions
        {
            PlaceholderPatterns = [new Regex(@"#\w+#", RegexOptions.Compiled)]
        };

        var (template, fragments) = CompoundFieldSplitter.Decompose(original, options);

        // The two placeholder tokens and the lone fullwidth '！' between/after them are all glue -
        // none of them may act as a fixed fragment boundary, so the whole opening clause merges
        // into the first '\\n'-delimited sentence fragment instead of leaving a stray literal
        // "#PlayerName#！#PlayerName#" prefix (or splitting off just the second '！').
        Assert.Equal("{0}\\n{1}\\n{2}", template);
        Assert.Equal(
            [
                "#PlayerName#！#PlayerName#！都日上三竿了，怎么还在睡大觉呢！",
                "嘴里还一直念叨着什么“看招”，“承让”，",
                "怕不是又在梦里行侠仗义了。"
            ],
            fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }

    [Fact(DisplayName = "A placeholder token straight after a literal '\\n' boundary still glues into the following sentence, without pulling the boundary's own fragment along")]
    public void PlaceholderTokenAfterLiteralBoundaryGluesOnlyIntoFollowingSentence()
    {
        var original = "不错，本门以剑法闻名巴蜀，掌门更凭“无影乱剑”威震一方。\\n#PlayerName#若是整天使一手太祖长拳，让外人见了怕是要笑掉大牙。";
        var options = new CompoundFieldSplitterOptions
        {
            PlaceholderPatterns = [new Regex(@"#\w+#", RegexOptions.Compiled)]
        };

        var (template, fragments) = CompoundFieldSplitter.Decompose(original, options);

        // The literal "\\n" is a genuine boundary and must stay in the template, but "#PlayerName#"
        // immediately following it must glue into the sentence that follows it, not remain as its
        // own stranded literal prefix (the previous bug produced "{0}\\n#PlayerName#{1}").
        Assert.Equal("{0}\\n{1}", template);
        Assert.Equal(
            [
                "不错，本门以剑法闻名巴蜀，掌门更凭“无影乱剑”威震一方。",
                "#PlayerName#若是整天使一手太祖长拳，让外人见了怕是要笑掉大牙。"
            ],
            fragments);
        Assert.Equal(original, CompoundFieldSplitter.Reconstruct(template, fragments));
    }
}

