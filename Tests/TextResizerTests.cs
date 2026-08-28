using FanslationStudio.LlmKit.Utility;
using System.Diagnostics;

namespace Tests;

public class TextResizerTests
{
    [Fact] // Can only be run when VS is running in admin
    public void CreateSymlinkToResizer()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;

        var inputFolder = $"{workingDirectory}/Resizers";
        inputFolder = Path.GetFullPath(inputFolder);
        var outputFolder = $@"{GameFileHandling.GameFolder}\BepInEx\resizers";

        if (Directory.Exists(outputFolder))
        {
            Console.WriteLine("Output folder already exists. Deleting it...");
            Directory.Delete(outputFolder, true);
        }

        // Run mklink command to create a symbolic link
        string command = $"/C mklink /D \"{outputFolder}\" \"{inputFolder}\"";
        ProcessStartInfo psi = new ProcessStartInfo("cmd.exe", command)
        {
            RedirectStandardOutput = true,
            RedirectStandardError = true,
            UseShellExecute = false,
            CreateNoWindow = true,
            Verb = "runas" // Run as administrator
        };

        Process process = new Process { StartInfo = psi };
        process.Start();
        string output = process.StandardOutput.ReadToEnd();
        string error = process.StandardError.ReadToEnd();
        process.WaitForExit();

        // Display output or error
        if (!string.IsNullOrEmpty(output))
            Console.WriteLine("Success: " + output);
        if (!string.IsNullOrEmpty(error))
            throw new Exception("Error: " + error);
    }

    //[Fact]
    //public void ReserializeResizerTest()
    //{
    //    var workingDirectory = GameFileHandling.WorkingDirectory;
    //    var serializer = YamlHelper.CreateSerializer();
    //    var deserializer = YamlHelper.CreateDeserializer();
    //    var folder = $"{workingDirectory}/Resizers";

    //    foreach (var file in Directory.EnumerateFiles(folder))
    //    {
    //        var newResizers = deserializer.Deserialize<List<TextResizerContract>>(File.ReadAllText(file));
    //        var content = serializer.Serialize(newResizers);
    //        File.WriteAllText(file, content);
    //    }
    //}


    //[Fact]
    //public void BackupResizersTest()
    //{
    //    var folder = $@"G:\SteamLibrary\steamapps\common\下一站江湖Ⅱ\下一站江湖Ⅱ\BepInEx\resizers/";
    //    var outputFolder = $"{workingDirectory}/Resizers";
    //    if (Directory.Exists(outputFolder))
    //        Directory.Delete(outputFolder, true);

    //    Directory.CreateDirectory(outputFolder);

    //    foreach (var file in Directory.EnumerateFiles(folder))
    //        File.Copy(file, $"{outputFolder}/{Path.GetFileName(file)}", true);
    //}
}

