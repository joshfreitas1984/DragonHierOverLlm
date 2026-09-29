using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Release;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace Tests;

public class FileOutputWorkflowTests
{
    const string GitHubRepo = "joshfreitas1984/DragonHierOverLlm";

    // Set to a gh account name to publish with `gh release create` as that account. Null opens the
    // prefilled releases/new page instead; ambient gh/git auth is never used.
    const string? GhAccount = null;

    [Fact(DisplayName = "6. Package to Game Files")]
    public static async Task PackageFinalTranslation()
    {
        await TranslationPackaging.PackageFinalTranslationAsync(GameFileHandling.WorkingDirectory,
            TextFileConfiguration.TextFilesToSplit);

        GameFileHandlingBase.CopyDirectory($"{GameFileHandling.WorkingDirectory}/Mod",
            $"{GameFileHandling.GameFolder}/BepInEx/plugins/resources/GameData", true);

        TextResizerTests.MoveResizersIntoPathBasedFiles();
        TextResizerTests.MoveSpritesIntoPathBasedFiles();
        TextResizerTests.MoveLayoutsIntoPathBasedFiles();
    }

    [Fact(DisplayName = "7. Package Release")]
    public static async Task PackageRelease()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var outputFolder = $"{GameFileHandling.GameFolder}/ReleaseFolder";

        var notes = BuildReleaseNotes();

        var result = ReleasePackager.Package(new ReleaseOptions
        {
            ReleaseNotes = notes,
            Version = GameFileHandlingBase.CalculateVersionNumber(),
            // Plugin PostBuild steps write DLLs and configs straight into the staging folder.
            StagingFolder = $"{outputFolder}/Files",
            OutputFolder = outputFolder,
            ZipPrefix = "EnglishPatch",
            Mappings =
            [
                new($"{workingDirectory}/Resizers", "BepInEx/resizers"),
                new($"{workingDirectory}/Layouts", "BepInEx/layouts"),
                new($"{workingDirectory}/Sprites", "BepInEx/sprites2"),
                new($"{workingDirectory}/Mod", "BepInEx/plugins/resources/GameData"),
            ],
            OwnedFolders = ["BepInEx/resizers", "BepInEx/layouts", "BepInEx/sprites2", "BepInEx/plugins/resources/GameData"],
            // The auto added resizers
            RemoveAfterStaging =
            [
                "BepInEx/resizers/zzAddedResizers.yaml",
                "BepInEx/layouts/zzAddedLayouts.yaml",
                "BepInEx/sprites2/zzAddedSprites.yaml",
            ],
            SeedOnly = ["BepInEx/config/**"],
        });

        var assets = new[] { result.ZipPath, result.ManifestPath };
        var url = ReleasePublisher.BuildReleaseUrl(GitHubRepo, result.Version, notes);

        var ghFailure = GhAccount == null
            ? "no ghAccount configured"
            : ReleasePublisher.TryPublishWithGh(GitHubRepo, GhAccount, result.Version, assets, result.NotesPath);

        if (ghFailure != null)
        {
            Console.WriteLine($"Not published automatically ({ghFailure}). Attach {Path.GetFileName(result.ZipPath)} at {url}");
            ReleasePublisher.TryOpen(Path.GetFullPath(outputFolder));
            ReleasePublisher.TryOpen(url);
        }

        await Task.CompletedTask;
    }

    const string PackagingInputsFolder = "../../../../Files/Packaging";

    // Game version (Files/Packaging/GameVersion.txt, required, one line) first, then the git commits
    // since the newest tag. Tags are fetched from origin first (read-only). The notes prefill the
    // GitHub release page, where they can be edited before publishing.
    static string BuildReleaseNotes()
    {
        var versionFile = $"{PackagingInputsFolder}/GameVersion.txt";

        if (!File.Exists(versionFile) || string.IsNullOrWhiteSpace(File.ReadAllText(versionFile)))
            throw new FileNotFoundException($"Put the current game version on one line in {Path.GetFullPath(versionFile)}");

        var notes = $"**Game version: {File.ReadAllText(versionFile).Trim()}**";

        // Git problems must not block a release, but must be visible rather than silently dropping the changes.
        string commits;
        try
        {
            commits = GitReleaseNotes.Generate(Path.GetFullPath($"{PackagingInputsFolder}/../.."), fetchTags: true);
        }
        catch (Exception ex)
        {
            commits = $"_Could not generate the change list: {ex.Message}_";
            Console.WriteLine(commits);
        }

        notes += $"{Environment.NewLine}{Environment.NewLine}{commits}";

        return notes + Environment.NewLine;
    }
}
