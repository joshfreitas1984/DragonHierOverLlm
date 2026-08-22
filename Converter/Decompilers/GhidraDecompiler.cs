using System.Diagnostics;
using System.Runtime.InteropServices;

namespace Il2CppExplorer.Decompilers;

/// <summary>
/// Drives Ghidra's headless analyser to decompile all functions listed in
/// the manifest CSV.
///
/// Workflow
/// --------
/// 1. On first run the binary is imported into a Ghidra project (-import).
///    Subsequent runs reuse it (-process) for speed.
/// 2. GhidraDecompile.py is invoked as a -postScript.  It reads the manifest,
///    decompiles every function via Ghidra's DecompInterface, and writes the
///    resulting C to the paths specified in the manifest.
/// 3. Ghidra stdout/stderr is forwarded to the console so progress is visible.
/// </summary>
public class GhidraDecompiler : IDecompiler
{
    private readonly string _ghidraInstallDir;
    private readonly string _projectDir;
    private readonly string _projectName;
    private readonly string _binaryPath;
    private readonly string _scriptDir;
    private readonly int _timeoutSeconds;
    private readonly string? _labelsPath;
    private readonly string? _staticLabelsPath;

    public GhidraDecompiler(
        string ghidraInstallDir,
        string projectDir,
        string projectName,
        string binaryPath,
        string scriptDir,
        int timeoutSeconds = 60,
        string? labelsPath = null,
        string? staticLabelsPath = null)
    {
        _ghidraInstallDir = ghidraInstallDir;
        _projectDir = projectDir;
        _projectName = projectName;
        _binaryPath = binaryPath;
        _scriptDir = scriptDir;
        _timeoutSeconds = timeoutSeconds;
        _labelsPath = labelsPath;
        _staticLabelsPath = staticLabelsPath;
    }

    public async Task DecompileAsync(string manifestPath, CancellationToken ct = default)
    {
        Directory.CreateDirectory(_projectDir);

        // Ghidra 12+ requires all paths to be absolute (no leading '.')
        string absProjectDir = Path.GetFullPath(_projectDir);
        string absBinaryPath = Path.GetFullPath(_binaryPath);
        string absManifest = Path.GetFullPath(manifestPath);
        string absScriptDir = Path.GetFullPath(_scriptDir);
        string absLogFile = Path.Combine(absProjectDir, "ghidra_run.log");

        string analyzeHeadless = GetAnalyzeHeadlessPath();
        if (!File.Exists(analyzeHeadless))
            throw new FileNotFoundException($"analyzeHeadless not found at: {analyzeHeadless}");

        // Decide between -import (first run) and -process (project already exists)
        string binaryName = Path.GetFileName(absBinaryPath);
        bool projectExists = Directory.GetFiles(absProjectDir, $"{_projectName}.gpr").Length > 0 ||
                             Directory.GetFiles(absProjectDir, $"{_projectName}.rep", SearchOption.AllDirectories).Length > 0;

        string importOrProcess = projectExists
            ? $"-process \"{binaryName}\""
            : $"-import \"{absBinaryPath}\"";

        // Escape the manifest path for passing as a script argument (no double-backslash needed for Java)
        string escapedManifest = absManifest.Replace("\"", "\\\"");
        // Positional: manifest [labels [staticLabels]]
        // If staticLabels is set but labels is not, pass "" as labels placeholder
        string labelsArg = !string.IsNullOrEmpty(_labelsPath)
            ? $" \"{Path.GetFullPath(_labelsPath).Replace("\"", "\\\"")}\""
            : !string.IsNullOrEmpty(_staticLabelsPath) ? " \"\"" : "";
        string staticLabelsArg = !string.IsNullOrEmpty(_staticLabelsPath)
            ? $" \"{Path.GetFullPath(_staticLabelsPath).Replace("\"", "\\\"")}\""
            : "";

        string args = string.Join(" ",
            $"\"{absProjectDir}\"",
            $"\"{_projectName}\"",
            importOrProcess,
            $"-postScript GhidraDecompile \"{escapedManifest}\"{labelsArg}{staticLabelsArg}",
            $"-scriptPath \"{absScriptDir}\"",
            "-noanalysis", // skip full analysis on re-runs; removed on first import below
            $"-log \"{absLogFile}\""
        );

        // On first import we DO want analysis so Ghidra can resolve functions
        if (!projectExists)
            args = args.Replace("-noanalysis", "");

        Console.WriteLine();
        Console.WriteLine($"  Running Ghidra headless analyser...");
        Console.WriteLine($"  {analyzeHeadless} {args}");
        Console.WriteLine();

        var psi = new ProcessStartInfo
        {
            FileName = analyzeHeadless,
            Arguments = args,
            UseShellExecute = false,
            RedirectStandardOutput = true,
            RedirectStandardError = true,
        };

        using var process = new Process { StartInfo = psi };

        process.OutputDataReceived += (_, e) => { if (e.Data != null) Console.WriteLine($"  [Ghidra] {e.Data}"); };
        process.ErrorDataReceived += (_, e) => { if (e.Data != null) Console.Error.WriteLine($"  [Ghidra ERR] {e.Data}"); };

        process.Start();
        process.BeginOutputReadLine();
        process.BeginErrorReadLine();

        try
        {
            await process.WaitForExitAsync(ct);
        }
        catch (OperationCanceledException)
        {
            process.Kill(entireProcessTree: true);
            throw;
        }

        if (process.ExitCode != 0)
            Console.Error.WriteLine($"  [WARNING] Ghidra exited with code {process.ExitCode}. Check {Path.Combine(_projectDir, "ghidra_run.log")}");
        else
            Console.WriteLine($"  Ghidra finished successfully.");
    }

    // ── Platform-specific path resolution ────────────────────────────────────

    private string GetAnalyzeHeadlessPath()
    {
        // Ghidra ≥ 10.x  →  support/analyzeHeadless  (or .bat on Windows)
        string subPath = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? Path.Combine("support", "analyzeHeadless.bat")
            : Path.Combine("support", "analyzeHeadless");

        return Path.Combine(_ghidraInstallDir, subPath);
    }
}
