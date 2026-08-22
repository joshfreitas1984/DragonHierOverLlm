using FanslationStudio.LlmKit;
using System.IO.Compression;

namespace Tests;

public class FileOutputWorkflowTests
{
    [Fact(DisplayName = "6. Package to Game Files")]
    public static async Task PackageFinalTranslation()
    {
        await GameFileHandling.PackageFinalTranslationAsync(GameFileHandling.WorkingDirectory, 
            GameFileHandling.TextFilesToSplit);
    }

    [Fact(DisplayName = "7. Zip Release")]
    public static async Task ZipRelease()
    {
        var version = GameFileHandlingBase.CalculateVersionNumber();

        string releaseFolder = $"{GameFileHandling.GameFolder}/ReleaseFolder/Files";
        var workingDirectory = GameFileHandling.WorkingDirectory;

        File.Copy($"{workingDirectory}/Mod/English/StringTable.csv", $"{releaseFolder}/Mods/English/StringTable.csv", true);


        GameFileHandlingBase.CopyDirectory($"{workingDirectory}/Resizers", $"{releaseFolder}/BepInEx/resizers", true);

        ZipFile.CreateFromDirectory($"{releaseFolder}", $"{releaseFolder}/../EnglishPatch-{version}.zip");
        await Task.CompletedTask;
    }
}
