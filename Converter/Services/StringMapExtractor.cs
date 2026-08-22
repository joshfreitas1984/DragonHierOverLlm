using System.Text;

namespace Il2CppExplorer.Services;

/// <summary>
/// Extracts IL2CPP string literal → GameAssembly.dll DAT_ address mappings.
///
/// In Unity IL2CPP builds, the native binary's .data section contains
/// pre-initialised 8-byte slots. The lower 32 bits of each slot encode a
/// metadata usage: bits[31..29] = usageType, bits[28..0] = sourceIndex.
/// usageType 5 (kIl2CppMetadataUsageStringLiteral) means sourceIndex is
/// an index into the global-metadata.dat stringLiterals table.
///
/// Ghidra shows these slots as DAT_181dXXXXXX globals. This extractor scans
/// every 8-byte slot in .data, resolves the ones that are string literals,
/// and writes DAT_address → string value to _string_map.csv.
/// </summary>
public static class StringMapExtractor
{
    private const uint StringLiteralUsageType = 5; // kIl2CppMetadataUsageStringLiteral

    // ─────────────────────────────────────────────────────────────────────────

    /// <summary>
    /// Builds the DAT_address → string value map and writes it to
    /// <paramref name="outputDir"/>/_string_map.csv.
    /// Returns the map (keys lowercase hex, e.g. "DAT_181d6cbd0").
    /// Returns an empty dictionary if extraction fails.
    /// </summary>
    public static Dictionary<string, string> ExtractAndSave(
        string metadataPath,
        string binaryPath,
        string outputDir)
    {
        if (!File.Exists(metadataPath))
        {
            Console.WriteLine($"  [StringMap] global-metadata.dat not found: {metadataPath}");
            return new();
        }
        if (!File.Exists(binaryPath))
        {
            Console.WriteLine($"  [StringMap] GameAssembly.dll not found: {binaryPath}");
            return new();
        }

        Console.Write("  [StringMap] Loading files...");
        byte[] meta   = File.ReadAllBytes(metadataPath);
        byte[] binary = File.ReadAllBytes(binaryPath);
        Console.WriteLine(" done.");

        // ── 1. Validate global-metadata.dat ──────────────────────────────
        uint sanity  = BitConverter.ToUInt32(meta, 0);
        int  version = BitConverter.ToInt32(meta, 4);
        if (sanity != 0xFAB11BAF)
        {
            Console.WriteLine("  [StringMap] global-metadata.dat sanity check failed.");
            return new();
        }
        Console.WriteLine($"  [StringMap] Metadata version: {version}");

        // ── 2. Read string literals from metadata ─────────────────────────
        int slOff     = BitConverter.ToInt32(meta, 0x08);
        int slSize    = BitConverter.ToInt32(meta, 0x0C);
        int slDataOff = BitConverter.ToInt32(meta, 0x10);
        int strCount  = slSize / 8;   // each entry = (uint32 length, uint32 dataOffset)
        Console.WriteLine($"  [StringMap] String literals: {strCount}");

        var stringLiterals = new string[strCount];
        for (int i = 0; i < strCount; i++)
        {
            int ent     = slOff + i * 8;
            int len     = BitConverter.ToInt32(meta, ent);
            int dataIdx = BitConverter.ToInt32(meta, ent + 4);
            if (len <= 0 || len > 65536 || slDataOff + dataIdx + len > meta.Length)
            {
                stringLiterals[i] = string.Empty;
                continue;
            }
            stringLiterals[i] = Encoding.UTF8.GetString(meta, slDataOff + dataIdx, len);
        }

        // ── 3. Parse PE → find .data section ─────────────────────────────
        if (!ParsePE(binary, out ulong imageBase, out var sections))
        {
            Console.WriteLine("  [StringMap] Failed to parse GameAssembly.dll PE header.");
            return new();
        }
        var dataSection = sections.FirstOrDefault(s => s.Name is ".data");
        if (dataSection.FileSize == 0)
        {
            Console.WriteLine("  [StringMap] .data section not found in binary.");
            return new();
        }
        ulong dataVA = imageBase + dataSection.VirtualAddress;
        Console.WriteLine($"  [StringMap] ImageBase: 0x{imageBase:X}  .data VA: 0x{dataVA:X}  size: 0x{dataSection.FileSize:X}");

        // ── 4. Scan .data section for string literal cache slots ──────────
        // Each slot is 8 bytes. The lower 32 bits encode:
        //   bits[31..29] = usageType (5 = StringLiteral)
        //   bits[28..0]  = sourceIndex into stringLiterals[]
        Console.Write("  [StringMap] Scanning .data for string literal slots...");
        var map = new Dictionary<string, string>();
        int fo     = dataSection.FileOffset;
        int dataSz = dataSection.FileSize;

        for (int off = 0; off + 8 <= dataSz; off += 8)
        {
            uint val    = BitConverter.ToUInt32(binary, fo + off);
            uint utype  = val >> 29;
            uint srcIdx = val & 0x1FFFFFFFu;
            if (utype != StringLiteralUsageType || srcIdx >= (uint)strCount) continue;

            ulong  slotVA = dataVA + (ulong)off;
            string datKey = $"DAT_{slotVA:x}";
            if (!map.ContainsKey(datKey))
                map[datKey] = stringLiterals[srcIdx];
        }
        Console.WriteLine($" {map.Count} entries");

        // ── 5. Save CSV ───────────────────────────────────────────────────
        string csvPath = Path.Combine(outputDir, "_string_map.csv");
        Directory.CreateDirectory(outputDir);
        using (var w = new StreamWriter(csvPath, append: false, Encoding.UTF8))
        {
            w.WriteLine("DAT_Address,StringValue");
            foreach (var (k, v) in map.OrderBy(kv => kv.Key))
                w.WriteLine($"{k},{CsvEscape(v)}");
        }
        Console.WriteLine($"  [StringMap] Saved {map.Count} entries -> {csvPath}");
        return map;
    }

    // ── PE parser ─────────────────────────────────────────────────────────────

    private record struct PeSection(string Name, ulong VirtualAddress, ulong VirtualSize, int FileOffset, int FileSize);

    private static bool ParsePE(byte[] pe, out ulong imageBase, out List<PeSection> sections)
    {
        imageBase = 0;
        sections  = new();
        if (pe.Length < 0x40) return false;
        int peOff = BitConverter.ToInt32(pe, 0x3C);
        if (peOff + 24 >= pe.Length) return false;
        uint magic = BitConverter.ToUInt32(pe, peOff);
        if (magic != 0x00004550) return false;           // PE\0\0
        ushort optMagic = BitConverter.ToUInt16(pe, peOff + 24);
        if (optMagic != 0x020B) return false;            // PE32+ only
        imageBase = BitConverter.ToUInt64(pe, peOff + 24 + 24);

        ushort numSect = BitConverter.ToUInt16(pe, peOff + 6);
        ushort optSize = BitConverter.ToUInt16(pe, peOff + 20);
        int sectOff    = peOff + 24 + optSize;

        for (int i = 0; i < numSect; i++)
        {
            int s = sectOff + i * 40;
            if (s + 40 > pe.Length) break;
            string name = Encoding.ASCII.GetString(pe, s, 8).TrimEnd('\0');
            ulong va    = BitConverter.ToUInt32(pe, s + 12);
            ulong vsz   = BitConverter.ToUInt32(pe, s + 8);
            int   fo    = BitConverter.ToInt32(pe, s + 20);
            int   fsz   = BitConverter.ToInt32(pe, s + 16);
            sections.Add(new PeSection(name, va, vsz, fo, fsz));
        }
        return true;
    }

    // ── Public helper: load existing CSV without re-scanning ─────────────────

    public static Dictionary<string, string> LoadCsv(string csvPath)
    {
        if (!File.Exists(csvPath)) return new();
        var  map   = new Dictionary<string, string>();
        bool first = true;
        foreach (string raw in File.ReadLines(csvPath, Encoding.UTF8))
        {
            if (first) { first = false; continue; }
            int comma = raw.IndexOf(',');
            if (comma < 0) continue;
            map[raw[..comma]] = CsvUnescape(raw[(comma + 1)..]);
        }
        return map;
    }

    // ── CSV helpers ───────────────────────────────────────────────────────────

    private static string CsvEscape(string s) =>
        "\"" + s.Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\r", "\\r")
                .Replace("\n", "\\n")
                .Replace("\t", "\\t") + "\"";

    private static string CsvUnescape(string s)
    {
        if (s.Length >= 2 && s[0] == '"' && s[^1] == '"')
            s = s[1..^1];
        return s.Replace("\\\"", "\"")
                .Replace("\\r",  "\r")
                .Replace("\\n",  "\n")
                .Replace("\\t",  "\t")
                .Replace("\\\\", "\\");
    }
}
