using System.Reflection;
using System.Runtime.Loader;
using AssetRipper.Primitives;
using LibCpp2IL;
using LibCpp2IL.Metadata;

namespace Il2CppExplorer.Services;

/// <summary>
/// Uses LibCpp2IL to parse the IL2CPP binary + global-metadata.dat and extract
/// the RVA and a readable label for every method across ALL assemblies (game AND
/// Unity engine / framework types).
///
/// The result is merged into the Ghidra labels CSV so that calls like
/// FUN_1816fb040 get renamed to String__Concat before the C decompilation pass.
/// </summary>
public static class NativeMethodExtractor
{
    private static string? _libDir;
    private static bool _resolverRegistered;

    /// <summary>
    /// Registers an AssemblyResolve handler so that LibCpp2IL's transitive
    /// dependencies (Iced, Disarm, AsmResolver.*, etc.) are resolved from the
    /// same directory as LibCpp2IL.dll (BepInEx/core).
    /// </summary>
    private static void EnsureAssemblyResolver(string libDir)
    {
        if (_resolverRegistered) return;
        _libDir = libDir;
        AssemblyLoadContext.Default.Resolving += (ctx, name) =>
        {
            if (_libDir is null) return null;
            string path = Path.Combine(_libDir, name.Name + ".dll");
            return File.Exists(path) ? ctx.LoadFromAssemblyPath(path) : null;
        };
        _resolverRegistered = true;
    }

    /// <summary>
    /// Parses the binary + metadata and returns a dictionary of
    ///   RVA-hex-string (e.g. "0x1816fb040") → Ghidra label (e.g. "String__Concat")
    /// for every method that has a non-zero native pointer.
    ///
    /// Returns an empty dictionary if parsing fails (bad paths, wrong version, etc.).
    /// </summary>
    public static Dictionary<string, string> ExtractMethodLabels(
        string binaryPath,
        string metadataPath,
        string unityVersion)
    {
        if (!File.Exists(binaryPath))
        {
            Console.WriteLine($"  [NativeLabels] Binary not found: {binaryPath}");
            return new();
        }
        if (!File.Exists(metadataPath))
        {
            Console.WriteLine($"  [NativeLabels] Metadata not found: {metadataPath}");
            return new();
        }

        // Probe BepInEx/core (relative to game dir) for LibCpp2IL's transitive deps
        string gameDir = Path.GetDirectoryName(Path.GetFullPath(binaryPath))!;
        string libDir = Path.Combine(gameDir, "BepInEx", "core");
        if (Directory.Exists(libDir))
            EnsureAssemblyResolver(libDir);

        UnityVersion version;
        try
        {
            version = UnityVersion.Parse(unityVersion);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"  [NativeLabels] Could not parse Unity version '{unityVersion}': {ex.Message}");
            return new();
        }

        Console.Write($"  [NativeLabels] Loading IL2CPP metadata ({Path.GetFileName(metadataPath)}) ...");
        try
        {
            bool ok = LibCpp2IlMain.LoadFromFile(binaryPath, metadataPath, version);
            if (!ok || LibCpp2IlMain.TheMetadata == null)
            {
                Console.WriteLine(" failed (LoadFromFile returned false).");
                return new();
            }
            Console.WriteLine(" done.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($" failed: {ex.Message}");
            return new();
        }

        // IL2CPP "generic sharing": methods whose generic args are all reference types
        // (e.g. Dictionary<string, HeroTagDataBase>.TryGetValue and Dictionary<string, Foo>.TryGetValue)
        // legitimately compile down to the SAME native code address, since the generated code only
        // ever touches object pointers generically. That means a single RVA can correspond to dozens
        // of unrelated methods. Blindly keeping "first occurrence wins" (the old behavior) silently
        // mislabels every other method at that address with an arbitrary, confidently-wrong name
        // picked purely by metadata table order - e.g. we observed calls with string args like
        // "[DOTween]"/"[BoundingBox]" (clearly not resource paths) labeled "Resources.Load" this way,
        // because some unrelated shared-generic method happened to be first in the table at that
        // address. See .github/instructions/converter.instructions.md for the full writeup.
        //
        // Fix: collect ALL candidate labels per address first, then only emit a concrete label for
        // addresses with exactly one candidate. Ambiguous addresses are left unlabeled (Ghidra keeps
        // its default FUN_xxxxxxxx name) rather than guessing - a missing label is far less harmful
        // than a wrong one, since a wrong one actively misleads investigation (see the lesson in
        // dragonheirplugin.instructions.md about not trusting plausible-but-unverified correlations).
        var candidatesByAddress = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);

        foreach (Il2CppMethodDefinition method in LibCpp2IlMain.TheMetadata.methodDefs)
        {
            ulong ptr = method.MethodPointer;
            if (ptr == 0) continue;

            string className = SanitizeSymbol(method.DeclaringType?.Name ?? "Unknown");
            string methodName = SanitizeSymbol(method.Name ?? "unknown");
            string label = $"{className}__{methodName}";
            string rvaHex = $"0x{ptr:X}";

            if (!candidatesByAddress.TryGetValue(rvaHex, out var list))
                candidatesByAddress[rvaHex] = list = new List<string>();
            if (!list.Contains(label))
                list.Add(label);
        }

        var result = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        int ambiguousCount = 0;
        foreach (var (rvaHex, candidates) in candidatesByAddress)
        {
            if (candidates.Count == 1)
            {
                result[rvaHex] = candidates[0];
            }
            else
            {
                ambiguousCount++;
            }
        }

        Console.WriteLine($"  [NativeLabels] Extracted {result.Count} unambiguous method labels from IL2CPP metadata ({ambiguousCount} addresses skipped as ambiguous/shared-generic).");
        return result;
    }

    /// <summary>
    /// Temporary diagnostic: dump all public members of Il2CppBinary to discover the API.
    /// Remove after we learn the right property names.
    /// </summary>
    public static void DumpBinaryApi()
    {
        var binary = LibCpp2IlMain.Binary;
        if (binary == null) { Console.WriteLine("[API] Binary is null"); return; }
        var t = binary.GetType();

        // The DAT_* addresses store encoded type handles like 0x20005ABB.
        // Try GetRawMetadataUsage to decode them.
        var grmup = t.GetMethod("GetRawMetadataUsage",
            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        Console.WriteLine($"[API] GetRawMetadataUsage method: {grmup != null}");
        if (grmup != null)
            Console.WriteLine($"[API] GetRawMetadataUsage params: {string.Join(", ", grmup.GetParameters().Select(p => $"{p.ParameterType.FullName} {p.Name}"))}");

        // Try GetIl2CppTypeFromPointer with the known encoded handles
        var gilfp = t.GetMethod("GetIl2CppTypeFromPointer",
            System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
        Console.WriteLine($"[API] GetIl2CppTypeFromPointer params: {string.Join(", ", gilfp?.GetParameters().Select(p => $"{p.ParameterType.Name} {p.Name}") ?? Array.Empty<string>())}");

        // Try decoding 0x20005ABB as a type handle
        // Pattern: call GetIl2CppTypeFromPointer with the encoded value
        if (gilfp != null)
        {
            ulong[] testHandles = { 0x20005ABBUL, 0x2000662DUL, 0x20005AB5UL };
            foreach (var h in testHandles)
            {
                try
                {
                    var result = gilfp.Invoke(binary, new object[] { h });
                    Console.WriteLine($"[API] GetIl2CppTypeFromPointer(0x{h:X}) = {result?.GetType().FullName ?? "null"}: {result}");
                    if (result != null)
                    {
                        var resultType = result.GetType();
                        // Try to get the type definition
                        foreach (var prop in resultType.GetProperties())
                            Console.WriteLine($"[API]   .{prop.Name} = {prop.GetValue(result)}");
                    }
                }
                catch (Exception ex) { Console.WriteLine($"[API] Error: {ex.InnerException?.Message ?? ex.Message}"); break; }
            }
        }

        // Also check what GetFieldOffsetFromIndex returns for GameDataController's static fields
        // Check the metadata
        var meta = LibCpp2IlMain.TheMetadata;
        if (meta?.typeDefs != null)
        {
            for (int ti = 0; ti < meta.typeDefs.Length; ti++)
            {
                if (meta.typeDefs[ti].Name == "GameDataController")
                {
                    var td = meta.typeDefs[ti];
                    Console.WriteLine($"[API] GameDataController typeDef idx={ti}");
                    // Check its token - the encoded handle might be (typeIndex << N) | flags
                    // encoded for GameDataController DAT_181d4e010 = 0x20005ABB
                    // Try: 0x5ABB = type idx shifted?
                    Console.WriteLine($"[API]   ti={ti} => 0x{ti:X}, 0x5ABB={0x5ABB}, ti*4+something?");
                    break;
                }
            }
        }
    }

    /// <summary>
    /// Extracts the actual IL2CPP field offsets (both instance and static) for all types,
    /// using the already-loaded LibCpp2IL binary/metadata.
    ///
    /// Must be called after <see cref="ExtractMethodLabels"/> has initialised LibCpp2IL,
    /// or after LibCpp2IlMain.LoadFromFile has been called separately.
    ///
    /// Returns: typeName → (fieldName → offset).
    ///   Static fields have negative offsets (sign convention used by callers to split them out).
    ///   Instance fields are non-negative (include the 16-byte object header IL2CPP uses).
    /// </summary>
    public static Dictionary<string, Dictionary<string, int>> ExtractFieldOffsets()
    {
        var meta = LibCpp2IlMain.TheMetadata;
        if (meta == null) return new();

        var result = new Dictionary<string, Dictionary<string, int>>(StringComparer.Ordinal);

        foreach (var typeDef in meta.typeDefs)
        {
            string typeName = typeDef.Name ?? "";
            if (string.IsNullOrEmpty(typeName)) continue;

            var fieldInfos = typeDef.FieldInfos;
            if (fieldInfos == null || fieldInfos.Length == 0) continue;

            var fieldOffsets = new Dictionary<string, int>(StringComparer.Ordinal);

            foreach (var fi in fieldInfos)
            {
                string fieldName = fi.Field?.Name ?? "";
                if (string.IsNullOrEmpty(fieldName)) continue;

                // FieldAttributes.Static = 0x10
                bool isStatic = (fi.Attributes & System.Reflection.FieldAttributes.Static) != 0;
                int offset = fi.FieldOffset;

                // Encode static fields as -(offset+1) so offset==0 stays distinguishable from instance fields
                fieldOffsets[fieldName] = isStatic ? -(offset + 1) : offset;
            }

            if (fieldOffsets.Count > 0)
                result[typeName] = fieldOffsets;
        }

        Console.WriteLine($"  [NativeLabels] Extracted field offsets for {result.Count} types.");
        return result;
    }

    private static string SanitizeSymbol(string s)
    {
        var sb = new System.Text.StringBuilder(s.Length);
        foreach (char c in s)
            sb.Append(char.IsLetterOrDigit(c) || c == '_' ? c : '_');
        string result = sb.ToString().Trim('_');
        return result.Length > 0 ? result : "_";
    }
}
