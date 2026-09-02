using FanslationStudio.LlmKit;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System.IO.Compression;

namespace Tests;

public class FileOutputWorkflowTests
{
    [Fact(DisplayName = "6. Package to Game Files")]
    public static async Task PackageFinalTranslation()
    {
        await GameFileHandling.PackageFinalTranslationAsync(GameFileHandling.WorkingDirectory, 
            GameFileHandling.TextFilesToSplit);

        GameFileHandlingBase.CopyDirectory($"{GameFileHandling.WorkingDirectory}/Mod", 
            $"{GameFileHandling.GameFolder}/BepInEx/plugins/resources/GameData", true);

        TextResizerTests.MoveResizersIntoPathBasedFiles();
    }

    [Fact(DisplayName = "7. Zip Release")]
    public static async Task ZipRelease()
    {
        var version = GameFileHandlingBase.CalculateVersionNumber();

        string releaseFolder = $"{GameFileHandling.GameFolder}/ReleaseFolder/Files";
        var workingDirectory = GameFileHandling.WorkingDirectory;        

        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Resizers", $"{releaseFolder}/BepInEx/resizers", true);
        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Mod", $"{releaseFolder}/BepInEx/plugins/resources/GameData", true);

        // Delete the auto added resizers
        File.Delete($"{releaseFolder}/BepInEx/resizers/zzAddedResizers.yaml");

        ZipFile.CreateFromDirectory($"{releaseFolder}", $"{releaseFolder}/../EnglishPatch-{version}.zip");
        await Task.CompletedTask;
    }
}
