using FanslationStudio.LlmKit;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using System.IO.Compression;

namespace Tests;

public class FileOutputWorkflowTests
{
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

    [Fact(DisplayName = "7. Zip Release")]
    public static async Task ZipRelease()
    {
        var version = GameFileHandlingBase.CalculateVersionNumber();

        string releaseFolder = $"{GameFileHandling.GameFolder}/ReleaseFolder/Files";
        var workingDirectory = GameFileHandling.WorkingDirectory;        

        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Resizers", $"{releaseFolder}/BepInEx/resizers", true);
        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Layouts", $"{releaseFolder}/BepInEx/layouts", true);
        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Sprites", $"{releaseFolder}/BepInEx/sprites2", true);
        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Mod", $"{releaseFolder}/BepInEx/plugins/resources/GameData", true);

        // Delete the auto added resizers
        File.Delete($"{releaseFolder}/BepInEx/resizers/zzAddedResizers.yaml");
        File.Delete($"{releaseFolder}/BepInEx/layouts/zzAddedLayouts.yaml");
        File.Delete($"{releaseFolder}/BepInEx/sprites2/zzAddedSprites.yaml");

        ZipFile.CreateFromDirectory($"{releaseFolder}", $"{releaseFolder}/../EnglishPatch-{version}.zip");
        await Task.CompletedTask;
    }
}
