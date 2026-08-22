using Il2CppExplorer.Models;

namespace Il2CppExplorer.Services;

/// <summary>
/// Writes a CSV manifest consumed by the Ghidra Python script.
/// Also assigns the DecompiledOutputPath on every MemberInfo so the rest of
/// the pipeline knows where to expect the decompiled .c files.
/// </summary>
public class ManifestWriter
{
    /// <summary>
    /// Determines output paths for all members that have an address, then writes
    /// the manifest CSV.  Returns the path to the written manifest.
    /// </summary>
    public string Write(List<TypeInfo> types, string outputDir, bool useFileOffset)
    {
        Directory.CreateDirectory(outputDir);

        // Assign output paths ─────────────────────────────────────────────────
        // Temp .c files go to _decompiled/ (cleaned up after summaries are written).
        // One summary .cs per class, flat inside the namespace folder.
        string decompDir = Path.Combine(outputDir, "_decompiled");
        foreach (var type in types)
        {
            string nsFolder = string.IsNullOrEmpty(type.Namespace)
                ? "_NoNamespace"
                : type.Namespace.Replace('.', Path.DirectorySeparatorChar);

            // Single output file per class
            type.SummaryOutputPath = Path.Combine(outputDir, nsFolder, $"{Sanitize(type.ClassName)}.cs");

            // Temp per-method .c files in _decompiled/
            string tempTypeDir = Path.Combine(decompDir, nsFolder, Sanitize(type.ClassName));
            foreach (var member in type.Members)
            {
                if (member.Address == null) continue;
                member.DecompiledOutputPath = Path.Combine(tempTypeDir, $"{Sanitize(member.Name)}.c");
            }
        }

        // Write manifest CSV ──────────────────────────────────────────────────
        string manifestPath = Path.Combine(outputDir, "_manifest.csv");
        using var writer = new StreamWriter(manifestPath);
        writer.WriteLine("Address,OutputFile,Length,TypeName,MemberName");

        foreach (var type in types)
        {
            foreach (var member in type.Members)
            {
                if (member.Address == null || member.DecompiledOutputPath == null) continue;

                string addr = useFileOffset ? member.Address.Offset : member.Address.RVA;
                // Escape paths that may contain commas
                string escapedPath = $"\"{member.DecompiledOutputPath.Replace("\"", "\"\"")}\"";
                writer.WriteLine(
                    $"{addr},{escapedPath},{member.Address.Length}," +
                    $"{type.FullName},{member.Name}");
            }
        }

        Console.WriteLine($"  Manifest written to: {manifestPath}");
        return manifestPath;
    }


    /// <summary>Replaces characters that are illegal in file/directory names.</summary>
    public static string Sanitize(string name)
    {
        var invalid = Path.GetInvalidFileNameChars();
        var sb = new System.Text.StringBuilder(name.Length);
        foreach (char c in name)
            sb.Append(invalid.Contains(c) ? '_' : c);
        return sb.ToString();
    }

    /// <summary>
    /// Writes a labels CSV (RVA,GhidraLabel) for ALL methods across all types.
    /// The Ghidra script reads this to rename FUN_XXXXXXXX symbols before decompiling,
    /// making cross-calls between known methods readable.
    ///
    /// <paramref name="extraLabels"/> is an optional RVA→label map (e.g. from
    /// NativeMethodExtractor) that is merged in; existing entries take priority.
    /// </summary>
    public string WriteLabels(List<TypeInfo> allTypes, string outputDir, bool useFileOffset,
        Dictionary<string, string>? extraLabels = null)
    {
        Directory.CreateDirectory(outputDir);
        string labelsPath = Path.Combine(outputDir, "_labels.csv");
        using var w = new StreamWriter(labelsPath);
        w.WriteLine("RVA,Label");

        // Track written RVAs so extraLabels doesn't re-emit ones already covered by the typed parse
        var written = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var type in allTypes)
        {
            foreach (var member in type.Members)
            {
                if (member.Address == null) continue;
                string addr = useFileOffset ? member.Address.Offset : member.Address.RVA;
                w.WriteLine($"{addr},{MakeGhidraLabel(type.ClassName, member.Name)}");
                written.Add(addr);
            }
        }

        // Merge in native-extracted labels for methods not covered above (Unity engine etc.)
        if (extraLabels != null)
        {
            int extra = 0;
            foreach (var (rva, label) in extraLabels)
            {
                if (written.Contains(rva)) continue;
                w.WriteLine($"{rva},{label}");
                extra++;
            }
            if (extra > 0)
                Console.WriteLine($"  Labels+  : +{extra} native IL2CPP labels merged");
        }

        return labelsPath;
    }

    // ClassName__MethodName — readable in Ghidra, unique enough for game classes
    private static string MakeGhidraLabel(string className, string methodName)
    {
        methodName = methodName.Replace(".ctor", "ctor").Replace(".cctor", "cctor");
        return $"{SanitizeSymbol(className)}__{SanitizeSymbol(methodName)}";
    }

    private static string SanitizeSymbol(string s)
    {
        var sb = new System.Text.StringBuilder(s.Length);
        foreach (char c in s)
            sb.Append(char.IsLetterOrDigit(c) || c == '_' ? c : '_');
        // Trim leading/trailing underscores for cleanliness
        string result = sb.ToString().Trim('_');
        return result.Length > 0 ? result : "_";
    }
}
