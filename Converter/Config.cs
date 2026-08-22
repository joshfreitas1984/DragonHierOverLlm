namespace Il2CppExplorer;

/// <summary>
/// All configuration parsed from command-line arguments.
/// </summary>
public class Config
{
    // ── Required ──────────────────────────────────────────────────────────────
    /// <summary>Path to the dummy Assembly-CSharp.dll.</summary>
    public string DllPath { get; set; } = "";

    /// <summary>Path to the native game binary (GameAssembly.dll / game.exe).</summary>
    public string BinaryPath { get; set; } = "";

    /// <summary>
    /// Path to global-metadata.dat.  When omitted, the tool looks next to --binary.
    /// Required for string literal resolution.
    /// </summary>
    public string MetadataPath { get; set; } = "";

    // ── Output ────────────────────────────────────────────────────────────────
    /// <summary>Root directory for all output files.</summary>
    public string OutputDir { get; set; } = "output";

    // ── Ghidra ────────────────────────────────────────────────────────────────
    /// <summary>Root of the Ghidra install (contains support/analyzeHeadless).</summary>
    public string GhidraInstallDir { get; set; } = "";

    /// <summary>Directory where the Ghidra project will be created/opened.</summary>
    public string GhidraProjectDir { get; set; } = "";

    /// <summary>Ghidra project name.</summary>
    public string GhidraProjectName { get; set; } = "Il2CppProject";

    // ── Behaviour ─────────────────────────────────────────────────────────────
    /// <summary>Dump raw custom-attribute names/values for the first few types and exit.</summary>
    public bool Diag { get; set; } = false;

    /// <summary>Only parse the DLL and write the manifest; do not run Ghidra.</summary>
    public bool SkipDecompile { get; set; } = false;

    /// <summary>
    /// When true (default), keep the _decompiled/ intermediate folder after a full run
    /// so that --skip-decompile can re-run post-processing without re-invoking Ghidra.
    /// Pass --clean-decompile to delete the folder after writing .cs files.
    /// </summary>
    public bool KeepDecompiled { get; set; } = true;

    /// <summary>
    /// When true, pass the file Offset to Ghidra instead of the RVA.
    /// Useful if the binary's image base doesn't match the expected value.
    /// </summary>
    public bool UseFileOffset { get; set; } = false;

    /// <summary>Seconds to allow Ghidra to decompile each function.</summary>
    public int DecompileTimeoutSeconds { get; set; } = 60;

    /// <summary>
    /// Optional filter: only process types whose FullName contains this string.
    /// Leave empty to process all types.
    /// </summary>
    public string TypeFilter { get; set; } = "";

    /// <summary>
    /// When false (default), only types with no namespace (_NoNamespace) are processed.
    /// Pass --all-namespaces to include library / framework types.
    /// </summary>
    public bool AllNamespaces { get; set; } = false;

    /// <summary>
    /// Paths to folders of Cpp2IL-generated interop DLLs (e.g. BepInEx/interop, BepInEx/unity-libs).
    /// Every DLL found there is parsed for [Cpp2ILInjected.Address] attributes and added
    /// to the Ghidra labels file so Unity engine / framework FUN_XXXXXX calls get renamed.
    /// Populated automatically from --game-dir, or manually via one or more --interop flags.
    /// </summary>
    public List<string> InteropDirs { get; set; } = new();

    /// <summary>
    /// Root directory of the Unity game installation.  When provided the tool
    /// auto-discovers: GameAssembly.dll, global-metadata.dat, Assembly-CSharp.dll
    /// (from BepInEx/dummy), BepInEx/interop, and BepInEx/unity-libs.
    /// Any path that is also supplied explicitly on the command line takes precedence.
    /// </summary>
    public string GameDir { get; set; } = "";

    /// <summary>
    /// Unity version string (e.g. "2020.3.48f1").  When combined with --native-labels,
    /// used by LibCpp2IL to parse the IL2CPP binary and extract ALL method RVAs including
    /// Unity engine types.
    /// </summary>
    public string UnityVersion { get; set; } = "";

    /// <summary>
    /// When true, run LibCpp2IL against --binary + --metadata to extract native method
    /// labels for the full IL2CPP type set (game + engine).  Requires --unity-version.
    /// The extracted labels are merged into _labels.csv before the Ghidra pass.
    /// </summary>
    public bool NativeLabels { get; set; } = false;

    // ── Parsing ───────────────────────────────────────────────────────────────
    public static Config Parse(string[] args)
    {
        var cfg = new Config();
        for (int i = 0; i < args.Length; i++)
        {
            switch (args[i].ToLowerInvariant())
            {
                case "--dll": cfg.DllPath = args[++i]; break;
                case "--binary": cfg.BinaryPath = args[++i]; break;
                case "--metadata": cfg.MetadataPath = args[++i]; break;
                case "--output": cfg.OutputDir = args[++i]; break;
                case "--ghidra": cfg.GhidraInstallDir = args[++i]; break;
                case "--project-dir": cfg.GhidraProjectDir = args[++i]; break;
                case "--project-name": cfg.GhidraProjectName = args[++i]; break;
                case "--filter": cfg.TypeFilter = args[++i]; break;
                case "--interop": cfg.InteropDirs.Add(args[++i]); break;
                case "--game-dir": cfg.GameDir = args[++i]; break;
                case "--unity-version": cfg.UnityVersion = args[++i]; break;
                case "--native-labels": cfg.NativeLabels = true; break;
                case "--timeout":
                    if (i + 1 < args.Length && int.TryParse(args[++i], out int t))
                        cfg.DecompileTimeoutSeconds = t;
                    break;
                case "--skip-decompile": cfg.SkipDecompile = true; break;
                case "--clean-decompile": cfg.KeepDecompiled = false; break;
                case "--use-offset": cfg.UseFileOffset = true; break;
                case "--diag": cfg.Diag = true; break;
                case "--all-namespaces": cfg.AllNamespaces = true; break;
                case "--help":
                case "-h":
                    PrintHelp();
                    Environment.Exit(0);
                    break;
            }
        }
        return cfg;
    }

    public void Validate()
    {
        // ── Auto-discover paths from --game-dir ───────────────────────────────
        // Must run BEFORE validation so that --game-dir alone is sufficient.
        if (!string.IsNullOrEmpty(GameDir))
        {
            string gd = Path.GetFullPath(GameDir);
            if (!Directory.Exists(gd))
                throw new DirectoryNotFoundException($"Game directory not found: {gd}");

            // --dll: BepInEx\dummy\Assembly-CSharp.dll
            if (string.IsNullOrEmpty(DllPath))
            {
                string c = Path.Combine(gd, "BepInEx", "dummy", "Assembly-CSharp.dll");
                if (File.Exists(c)) DllPath = c;
            }

            // --binary: GameAssembly.dll
            if (string.IsNullOrEmpty(BinaryPath))
            {
                string c = Path.Combine(gd, "GameAssembly.dll");
                if (File.Exists(c)) BinaryPath = c;
            }

            // --metadata: <gamename>_Data\il2cpp_data\Metadata\global-metadata.dat
            if (string.IsNullOrEmpty(MetadataPath))
            {
                string? dataDir = Directory.GetDirectories(gd, "*_Data", SearchOption.TopDirectoryOnly)
                                           .FirstOrDefault();
                if (dataDir != null)
                {
                    string c = Path.Combine(dataDir, "il2cpp_data", "Metadata", "global-metadata.dat");
                    if (File.Exists(c)) MetadataPath = c;
                }
            }

            // interop label sources: BepInEx\interop and BepInEx\unity-libs
            foreach (string subDir in new[] { "interop", "unity-libs" })
            {
                string candidate = Path.Combine(gd, "BepInEx", subDir);
                if (Directory.Exists(candidate) && !InteropDirs.Contains(candidate, StringComparer.OrdinalIgnoreCase))
                    InteropDirs.Add(candidate);
            }
        }

        // Auto-detect global-metadata.dat next to the binary (fallback)
        if (string.IsNullOrEmpty(MetadataPath) && !string.IsNullOrEmpty(BinaryPath))
        {
            string binDir = Path.GetDirectoryName(BinaryPath) ?? ".";
            string[] candidates =
            [
                Path.Combine(binDir, "global-metadata.dat"),
                Path.Combine(binDir, "..", "global-metadata.dat"),
                Path.Combine(Path.GetDirectoryName(DllPath) ?? ".", "global-metadata.dat"),
            ];
            foreach (string c in candidates)
            {
                string full = Path.GetFullPath(c);
                if (File.Exists(full)) { MetadataPath = full; break; }
            }
        }

        // ── Validate required paths (after auto-discovery) ────────────────────
        if (string.IsNullOrEmpty(DllPath))
            throw new ArgumentException("--dll <path>  is required (or use --game-dir to auto-discover)");
        if (!File.Exists(DllPath))
            throw new FileNotFoundException($"DLL not found: {DllPath}");

        if (Diag) return; // diag mode only needs the DLL

        if (!SkipDecompile)
        {
            if (string.IsNullOrEmpty(BinaryPath))
                throw new ArgumentException("--binary <path> is required. Use --skip-decompile to only parse + generate the manifest.");
            if (!File.Exists(BinaryPath))
                throw new FileNotFoundException($"Binary not found: {BinaryPath}");

            if (string.IsNullOrEmpty(GhidraInstallDir))
                throw new ArgumentException("--ghidra <ghidra_install_dir> is required. Use --skip-decompile to only parse + generate the manifest.");
            if (!Directory.Exists(GhidraInstallDir))
                throw new DirectoryNotFoundException($"Ghidra directory not found: {GhidraInstallDir}");

            if (string.IsNullOrEmpty(GhidraProjectDir))
                GhidraProjectDir = Path.Combine(OutputDir, "_ghidra_project");
        }
    }

    private static void PrintHelp()
    {
        Console.WriteLine("""
            Il2CppExplorer — decompile IL2CPP dummy DLL methods via Ghidra

            USAGE
              Il2CppExplorer --game-dir <path> --ghidra <C:\ghidra_10.x>
              Il2CppExplorer --dll <dummy.dll> --binary <GameAssembly.dll> --ghidra <C:\ghidra_10.x>

            GAME DIRECTORY (auto-discovers all game files)
              --game-dir  <path>   Root of the Unity game install.  Auto-detects:
                                     GameAssembly.dll
                                     <name>_Data\il2cpp_data\Metadata\global-metadata.dat
                                     BepInEx\dummy\Assembly-CSharp.dll
                                     BepInEx\interop\     (label sources)
                                     BepInEx\unity-libs\  (label sources)

            INDIVIDUAL PATHS (override or supplement --game-dir)
              --dll      <path>   Path to the dummy Assembly-CSharp.dll
              --binary   <path>   Path to the native binary (GameAssembly.dll / game.exe)
              --ghidra   <path>   Ghidra install directory
              --metadata <path>   Path to global-metadata.dat  (auto-detected if omitted)
              --interop  <dir>    Extra interop DLL folder (repeatable)

            OPTIONAL
              --output        <dir>    Output root  (default: output/)
              --project-dir   <dir>    Ghidra project directory (default: output/_ghidra_project)
              --project-name  <name>   Ghidra project name  (default: Il2CppProject)
              --filter        <text>   Only process types whose full name contains this string
              --timeout       <sec>    Per-function decompile timeout  (default: 60)
              --skip-decompile         Parse DLL & write manifest only; do not run Ghidra
              --use-offset             Pass file Offset to Ghidra instead of RVA
              --all-namespaces         Include all namespaces (default: _NoNamespace only)
              --help                   Show this message
            """);
    }
}
