namespace Tests;

public class DynamicStringExportTests
{
    private const string BodyRaw = "小师妹突发高烧，卧病在床！#PlayerName#<b>速回门派</b>，和大家一起想想办法！";
    private const string FullRaw = "姜婉-" + BodyRaw;

    [Fact]
    public void AddsAllRoutedMailBodiesAndPreservesFullEntries()
    {
        var results = RoutedMailExport.AddBodyAliases(
            [FullRaw, "Other entry"],
            [FullRaw, "叶寒-另一封邮件"]);

        Assert.Equal(4, results.Count);
        Assert.Equal(FullRaw, results[0]);
        Assert.Equal("Other entry", results[1]);
        Assert.Equal(BodyRaw, results[2]);
        Assert.Equal("另一封邮件", results[3]);
    }

    [Fact]
    public void DoesNotDuplicateExistingBodyAliases()
    {
        var results = RoutedMailExport.AddBodyAliases([BodyRaw], [FullRaw]);

        Assert.Single(results);
        Assert.Equal(BodyRaw, results[0]);
    }

    [Fact]
    public void IgnoresUnboundedHyphenatedText()
    {
        var results = RoutedMailExport.AddBodyAliases([], ["Unrelated text - with a hyphen"]);

        Assert.Empty(results);
    }
}