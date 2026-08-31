using FanslationStudio.LlmKit.Utility;
using System.Diagnostics;

namespace Tests;

public class TextResizerTests
{
    // Splits Defaults.yaml/zzAddedResizers.yaml resizer entries into one file per top-level
    // path prefix (first two path segments), e.g. "Canvas/MonthMissionPanel/..." -> Canvas_MonthMissionPanel.yaml
    [Fact]
    public static void MoveResizersIntoPathBasedFiles()
    {
        var workingDirectory = GameFileHandling.WorkingDirectory;
        var resizersFolder = Path.GetFullPath($"{workingDirectory}/Resizers");
        var sourceFiles = new[] { "Defaults.yaml", "zzAddedResizers.yaml" };

        var deserializer = YamlHelper.CreateDeserializer();
        var serializer = YamlHelper.CreateSerializer();

        var groups = new Dictionary<string, List<Dictionary<string, object>>>();

        foreach (var sourceFile in sourceFiles)
        {
            var sourcePath = Path.Combine(resizersFolder, sourceFile);
            var entries = deserializer.Deserialize<List<Dictionary<string, object>>>(File.ReadAllText(sourcePath))
                ?? [];

            foreach (var entry in entries)
            {
                if (!entry.TryGetValue("path", out var pathValue) || pathValue is not string path)
                    continue;

                var segments = path.Split('/');
                var key = segments.Length >= 2
                    ? $"{segments[0]}_{segments[1]}"
                    : segments[0];

                if (!groups.TryGetValue(key, out var group))
                    groups[key] = group = [];

                group.Add(entry);
            }

            // All entries have been moved out of the source file.
            File.WriteAllText(sourcePath, serializer.Serialize(new List<Dictionary<string, object>>()));
        }

        foreach (var (key, entries) in groups)
        {
            var outputPath = Path.Combine(resizersFolder, $"{key}.yaml");
            File.WriteAllText(outputPath, serializer.Serialize(entries));
        }
    }
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

