using FanslationStudio.Installer.Core;
using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Release;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;

namespace Tests;

public class FileOutputWorkflowTests
{
    // Repo, gh account and zip name come from Installer/installer.json. A null ghAccount opens the
    // prefilled releases/new page instead; ambient gh/git auth is never used.
    static InstallerConfig LoadInstallerConfig() => InstallerConfig.Load("../../../../Installer/installer.json");

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

        var installer = LoadInstallerConfig();
        var notes = BuildReleaseNotes(installer);

        var result = ReleasePackager.Package(new ReleaseOptions
        {
            ReleaseNotes = notes,
            Version = GameFileHandlingBase.CalculateVersionNumber(),
            // Plugin PostBuild steps write DLLs and configs straight into the staging folder.
            StagingFolder = $"{outputFolder}/Files",
            OutputFolder = outputFolder,
            ZipPrefix = installer.PatchZipPrefix,
            // Lets the in-game updater find its repo and relaunch the game without any per-game config.
            GitHubRepo = installer.GitHubRepo,
            SteamAppId = installer.SteamAppId,
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
        var url = ReleasePublisher.BuildReleaseUrl(installer.GitHubRepo, result.Version, notes);

        var ghFailure = installer.GhAccount == null
            ? "no ghAccount configured"
            : ReleasePublisher.TryPublishWithGh(installer.GitHubRepo, installer.GhAccount, result.Version, assets, result.NotesPath);

        if (ghFailure != null)
        {
            Console.WriteLine($"Not published automatically ({ghFailure}). Attach {Path.GetFileName(result.ZipPath)} at {url}");
            ReleasePublisher.TryOpen(Path.GetFullPath(outputFolder));
            ReleasePublisher.TryOpen(url);
        }

        await Task.CompletedTask;
    }

    // Only needed when the installer code or Installer/installer.json changes (e.g. a new BepInEx pin). The
    // binaries go on one rolling "installer" pre-release with a fixed download URL, so the in-game updater and
    // new players always fetch the latest, and patch releases never rebuild or re-upload them.
    [Fact(DisplayName = "7b. Package Installer")]
    public static void PackageInstaller()
    {
        var installer = LoadInstallerConfig();
        var outputFolder = $"{GameFileHandling.GameFolder}/ReleaseFolder";
        const string project = "../../../../Installer/Installer.csproj";

        var assets = new[]
        {
            DotnetPublisher.PublishSingleFile(project, "win-x64", outputFolder, "Installer", InstallerAssets.WindowsFileName),
            DotnetPublisher.PublishSingleFile(project, "linux-x64", outputFolder, "Installer", InstallerAssets.LinuxFileName),
        };

        var ghFailure = installer.GhAccount == null
            ? "no ghAccount configured"
            : ReleasePublisher.TryPublishRollingWithGh(installer.GitHubRepo, installer.GhAccount, InstallerAssets.ReleaseTag, "Installer", assets);

        if (ghFailure != null)
        {
            // The rolling release normally exists already: then the two files are replaced on its edit page
            // (delete the old ones, upload the new ones). Only the first ever run needs the new-release form.
            var exists = ReleasePublisher.TryReleaseExists(installer.GitHubRepo, InstallerAssets.ReleaseTag);
            var url = exists == true
                ? InstallerAssets.EditReleaseUrl(installer.GitHubRepo)
                : InstallerAssets.NewReleaseUrl(installer.GitHubRepo);

            Console.WriteLine($"Not published automatically ({ghFailure}).");
            Console.WriteLine(exists == true
                ? $"The '{InstallerAssets.ReleaseTag}' release exists: on the edit page, delete the old files and upload {string.Join(" and ", assets.Select(Path.GetFileName))}. Then Update release."
                : $"Attach {string.Join(" and ", assets.Select(Path.GetFileName))} at {url} (tick 'pre-release' and keep the tag 'installer').");
            ReleasePublisher.TryOpen(Path.GetFullPath(outputFolder));
            ReleasePublisher.TryOpen(url);
        }
    }

    const string PackagingInputsFolder = "../../../../Files/Packaging";

    // Game version (Files/Packaging/GameVersion.txt, required, one line) first, then the installer links, then the git commits
    // since the newest tag. Tags are fetched from origin first (read-only). The notes prefill the
    // GitHub release page, where they can be edited before publishing.
    static string BuildReleaseNotes(InstallerConfig installer)
    {
        var versionFile = $"{PackagingInputsFolder}/GameVersion.txt";

        if (!File.Exists(versionFile) || string.IsNullOrWhiteSpace(File.ReadAllText(versionFile)))
            throw new FileNotFoundException($"Put the current game version on one line in {Path.GetFullPath(versionFile)}");

        var notes = $"**Game version: {File.ReadAllText(versionFile).Trim()}**";

        // Always present: new players land on a release page without having the installer yet.
        notes += $"{Environment.NewLine}{Environment.NewLine}New install? Download the installer: " +
                 $"[Windows]({InstallerAssets.DownloadUrl(installer.GitHubRepo, true)}) | " +
                 $"[Linux]({InstallerAssets.DownloadUrl(installer.GitHubRepo, false)}). " +
                 "Already installed? The game offers the update when it starts.";

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
