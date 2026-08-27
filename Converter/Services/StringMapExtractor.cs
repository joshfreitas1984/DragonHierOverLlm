using System.Text;

namespace Il2CppExplorer.Services;

/// <summary>
/// Extracts IL2CPP string literal → GameAssembly.dll DAT_ address mappings.
///
/// In Unity IL2CPP builds, the native binary's .data section contains
/// pre-initialised 8-byte slots. The lower 32 bits of each slot encode a
/// metadata usage: bits[31..29] = usageType, bits[28..0] = an encoded index.
/// usageType 5 (kIl2CppMetadataUsageStringLiteral) means the encoded index
/// resolves to an index into the global-metadata.dat stringLiterals table.
///
/// IMPORTANT (metadata v27+, which removed the separate metadataUsagePairs
/// indirection table): the raw 29-bit value is NOT the string-literal index
/// directly - it must be right-shifted by 1 first (confirmed against
/// LibCpp2IL's MetadataUsage.DecodeMetadataUsage: "if (metadataVersion >= 27)
/// index >>= 1;"). Without this shift, srcIdx values come out roughly double
/// their real value and get silently rejected by the strCount bounds check,
/// even though the usageType matched correctly - this was a real bug found
/// investigating CustomDifficultyData's untranslated slider labels (see
/// converter.instructions.md).
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
        byte[] meta = File.ReadAllBytes(metadataPath);
        byte[] binary = File.ReadAllBytes(binaryPath);
        Console.WriteLine(" done.");

        // ── 1. Validate global-metadata.dat ──────────────────────────────
        uint sanity = BitConverter.ToUInt32(meta, 0);
        int version = BitConverter.ToInt32(meta, 4);
        if (sanity != 0xFAB11BAF)
        {
            Console.WriteLine("  [StringMap] global-metadata.dat sanity check failed.");
            return new();
        }
        Console.WriteLine($"  [StringMap] Metadata version: {version}");

        // ── 2. Read string literals from metadata ─────────────────────────
        int slOff = BitConverter.ToInt32(meta, 0x08);
        int slSize = BitConverter.ToInt32(meta, 0x0C);
        int slDataOff = BitConverter.ToInt32(meta, 0x10);
        int strCount = slSize / 8;   // each entry = (uint32 length, uint32 dataOffset)
        Console.WriteLine($"  [StringMap] String literals: {strCount}");

        var stringLiterals = new string[strCount];
        for (int i = 0; i < strCount; i++)
        {
            int ent = slOff + i * 8;
            int len = BitConverter.ToInt32(meta, ent);
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
        //   bits[28..0]  = encoded index; on metadata v27+ this must be >>1
        //                  to get the real index into stringLiterals[]
        //                  (see LibCpp2IL MetadataUsage.DecodeMetadataUsage)
        Console.Write("  [StringMap] Scanning .data for string literal slots...");
        var map = new Dictionary<string, string>();
        int fo = dataSection.FileOffset;
        int dataSz = dataSection.FileSize;

        for (int off = 0; off + 8 <= dataSz; off += 8)
        {
            uint val = BitConverter.ToUInt32(binary, fo + off);
            uint utype = val >> 29;
            uint srcIdx = val & 0x1FFFFFFFu;
            if (version >= 27) srcIdx >>= 1;
            if (utype != StringLiteralUsageType || srcIdx >= (uint)strCount) continue;

            ulong slotVA = dataVA + (ulong)off;
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
        sections = new();
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
        int sectOff = peOff + 24 + optSize;

        for (int i = 0; i < numSect; i++)
        {
            int s = sectOff + i * 40;
            if (s + 40 > pe.Length) break;
            string name = Encoding.ASCII.GetString(pe, s, 8).TrimEnd('\0');
            ulong va = BitConverter.ToUInt32(pe, s + 12);
            ulong vsz = BitConverter.ToUInt32(pe, s + 8);
            int fo = BitConverter.ToInt32(pe, s + 20);
            int fsz = BitConverter.ToInt32(pe, s + 16);
            sections.Add(new PeSection(name, va, vsz, fo, fsz));
        }
        return true;
    }

    // ── Public helper: load existing CSV without re-scanning ─────────────────

    public static Dictionary<string, string> LoadCsv(string csvPath)
    {
        if (!File.Exists(csvPath)) return new();
        var map = new Dictionary<string, string>();
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

    // ── Dynamic-string candidate extraction (static, no game run needed) ────
    //
    // _string_map.csv already contains EVERY string literal compiled into the game's
    // code (the same source the decompiler substitutes DAT_ addresses from), so it is a
    // complete, offline inventory of candidate hardcoded UI/dialogue fragments for case-4
    // dynamic-string translation (see the "dynamic-string-translation-plan" repo memory in
    // DragonHierOverLlm) - filtering it for CJK-containing values finds every candidate
    // fragment without ever needing to launch the game to trigger a particular code path.
    private static readonly System.Text.RegularExpressions.Regex CjkRegex =
        new(@"[\u4e00-\u9fff]", System.Text.RegularExpressions.RegexOptions.Compiled);

    // Confirmed (2026-08-27, via _string_map.csv cross-reference on DAT_181d62558/DAT_181d95d80/
    // DAT_181d95e88) false-positive class: .NET/ICU internal Unicode-category/culture boundary
    // data tables that happen to get compiled as string literals into the game assembly (likely
    // via some BCL API touching CharUnicodeInfo/RegexCharClass/globalization tables) and happen to
    // contain a CJK codepoint or two among thousands of others, so they pass CjkRegex despite
    // being pure noise - never real user-facing dialogue/UI text. These are NOT corrupted/garbled
    // extraction (verified byte-for-byte identical against _string_map.csv - the extraction itself
    // is correct), just genuine but useless BCL data. Real Chinese game text never legitimately
    // mixes in Hebrew/Arabic/Thai/Lao/Tibetan/Ethiopic/Khmer/Mongolian/Hangul-Jamo/Coptic/
    // halfwidth-fullwidth-form/control-picture codepoints alongside CJK ideographs, so a candidate
    // touching several of these unrelated scripts at once is a reliable signal for this exact
    // noise class rather than a hand-authored heuristic that could misfire on legitimate long
    // templated dialogue (which stays within CJK + ASCII + basic punctuation).
    private static readonly System.Text.RegularExpressions.Regex[] ExoticScriptRegexes =
    [
        new(@"[\u0590-\u05FF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Hebrew
        new(@"[\u0600-\u06FF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Arabic
        new(@"[\u0E00-\u0E7F]", System.Text.RegularExpressions.RegexOptions.Compiled), // Thai
        new(@"[\u0E80-\u0EFF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Lao
        new(@"[\u0F00-\u0FFF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Tibetan
        new(@"[\u1200-\u137F]", System.Text.RegularExpressions.RegexOptions.Compiled), // Ethiopic
        new(@"[\u1780-\u17FF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Khmer
        new(@"[\u1800-\u18AF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Mongolian
        new(@"[\u1100-\u11FF\u3130-\u318F]", System.Text.RegularExpressions.RegexOptions.Compiled), // Hangul Jamo
        new(@"[\u2C80-\u2CFF]", System.Text.RegularExpressions.RegexOptions.Compiled), // Coptic
        new(@"[\uFF00-\uFFEF\u2400-\u243F]", System.Text.RegularExpressions.RegexOptions.Compiled), // Halfwidth/Fullwidth + Control Pictures
    ];

    // A genuine BCL noise string touches several of these unrelated scripts at once (the confirmed
    // instances touch 8+); real Chinese dialogue never touches more than one (if any). Requiring 3
    // distinct hits keeps a wide margin against false-positives on legitimate text.
    private static bool IsExoticScriptNoise(string value) =>
        ExoticScriptRegexes.Count(r => r.IsMatch(value)) >= 3;

    /// <summary>
    /// Filters an already-extracted _string_map.csv for CJK-containing values and writes each as
    /// its own candidate line. A value with an embedded real newline (`\r\n`/`\n`/`\r`) is kept as
    /// a SINGLE candidate rather than being split into separate lines - the newline is instead
    /// escaped to a literal two-character `\n` sequence so the "one candidate per line" plain-text
    /// file format can still represent it without corruption. This matters because
    /// <c>FanslationStudio.LlmKit.Utility.CompoundFieldSplitter</c> (used by the Export step, see
    /// <c>DynamicStringWorkflow.ExportDynamicStringsToCustomFormat</c>) already treats a real `\n`
    /// as a natural fragment boundary on its own - each line still gets translated as its own
    /// unit via `Decompose`'s per-fragment splits/template, so splitting here first would only
    /// throw away the surrounding structure for no translation-quality benefit. Keeping the whole
    /// multi-line literal as ONE candidate/dictionary entry also means the runtime substring-match
    /// (see DragonHeirPlugin/DynamicStringPatches.cs) matches against the entire multi-line
    /// literal exactly as it's compiled into the game - a longer, far more specific match with
    /// much lower false-positive/collision risk than N independent single-line fragments would
    /// have. Placeholders (e.g. `#$PlayerName#`), punctuation (e.g. `，`), and all other
    /// surrounding text are preserved intact within a candidate. Excludes any candidate already
    /// present in <paramref name="excludeFile"/> (one raw fragment per line, in the same escaped
    /// form - typically the pipeline's dynamicStrings.txt input, itself populated by reviewing and
    /// merging entries from this same method's own output rather than hand-authored), as well as
    /// any value identified as BCL/ICU internal noise (see <see cref="IsExoticScriptNoise"/>), and
    /// writes the remaining distinct candidates to <paramref name="outputPath"/>, one per line,
    /// sorted for reproducible diffs. Returns the number of candidates written.
    /// </summary>
    public static int ExtractDynamicStringCandidates(string stringMapCsvPath, string outputPath, string? excludeFile)
        => ExtractDynamicStringCandidates(stringMapCsvPath, outputPath, excludeFile, null);

    /// <summary>
    /// Same as <see cref="ExtractDynamicStringCandidates(string, string, string?)"/>, but also
    /// excludes any candidate whose value matches one found (via <see cref="FindLogOnlyStringValues"/>)
    /// to be passed only to a Unity <c>Debug.Log</c>-family call - i.e. developer/diagnostic
    /// output rather than user-facing UI/dialogue text - when <paramref name="decompiledDir"/> is
    /// provided (the Converter's <c>output/_decompiled</c> folder).
    /// </summary>
    public static int ExtractDynamicStringCandidates(string stringMapCsvPath, string outputPath, string? excludeFile, string? decompiledDir)
    {
        var map = LoadCsv(stringMapCsvPath);

        var exclude = new HashSet<string>();
        if (!string.IsNullOrEmpty(excludeFile) && File.Exists(excludeFile))
        {
            foreach (var line in File.ReadAllLines(excludeFile, Encoding.UTF8))
            {
                if (!string.IsNullOrWhiteSpace(line))
                    exclude.Add(line.Trim());
            }
        }

        if (!string.IsNullOrEmpty(decompiledDir) && Directory.Exists(decompiledDir))
        {
            var logOnly = FindLogOnlyStringValues(decompiledDir, map);
            Console.WriteLine($"  [StringMap] Found {logOnly.Count} string value(s) passed to Debug.Log-family/exception-message calls - excluding from candidates.");
            exclude.UnionWith(logOnly.Select(EscapeNewlinesForFlatFile));
        }

        var candidates = map.Values
            .Where(v => !string.IsNullOrWhiteSpace(v))
            .Select(v => v.Trim())
            .Where(v => v.Length > 0 && CjkRegex.IsMatch(v))
            .Where(v => !IsExoticScriptNoise(v))
            .Select(EscapeNewlinesForFlatFile)
            .Where(v => !exclude.Contains(v))
            .Distinct()
            .OrderBy(v => v, StringComparer.Ordinal)
            .ToList();

        Directory.CreateDirectory(Path.GetDirectoryName(Path.GetFullPath(outputPath))!);
        File.WriteAllLines(outputPath, candidates, Encoding.UTF8);
        return candidates.Count;
    }

    // Matches a Debug.Log-family call (UnityEngine.Debug.Log/LogWarning/LogError/LogFormat/
    // LogException/LogErrorFormat/LogWarningFormat, or NGUI's NGUIDebug.Log/LogString - both
    // families show up under these exact decompiled symbol names, see _labels.csv) and captures
    // its first argument token verbatim (up to the next ',' or ')') - e.g. "DAT_181d85490",
    // "uVar4", "param_2". Multiple call-site variants (varying arg count/trailing NULL) are all
    // covered since only the first argument is captured.
    private static readonly System.Text.RegularExpressions.Regex LogCallRegex = new(
        @"(?:Debug__Log\w*|NGUIDebug__Log\w*)\(\s*([A-Za-z_][A-Za-z0-9_]*)\s*[,)]",
        System.Text.RegularExpressions.RegexOptions.Compiled);

    // Matches an exception constructor call with a message argument, e.g.
    // "Exception__ctor(uVar9,uVar8,0)", "NotImplementedException__ctor(uVar3,uVar2,0)",
    // "InvalidOperationException__ctor(uVar2,uVar8,0)". IL2CPP compiles these as
    // "<Type>Exception__ctor(this, message, methodInfo)" - message is the SECOND argument, unlike
    // Debug.Log where the message is the first, so this needs its own regex/argument index. The
    // trailing "," after the captured group (rather than requiring "," or ")") deliberately
    // excludes the parameterless-message ctor form (e.g. "NotSupportedException__ctor(uVar1,0)",
    // only 2 total args - this/methodInfo, no message) since there's no comma after a 2-arg call's
    // second token. It also naturally excludes a literal "0" (used for "no message"/methodInfo)
    // as the captured token, since "0" cannot match an identifier's leading [A-Za-z_].
    private static readonly System.Text.RegularExpressions.Regex ExceptionCtorRegex = new(
        @"\w*Exception__ctor\(\s*[^,]+,\s*([A-Za-z_][A-Za-z0-9_]*)\s*,",
        System.Text.RegularExpressions.RegexOptions.Compiled);

    // Matches a simple local assignment "<var> = <expr>;" so a log call argument that's a local
    // variable/parameter (e.g. "uVar4") can be traced back to whatever DAT_ literal(s) fed into
    // it - e.g. "uVar4 = String__Format(DAT_181d85490,...);" or "uVar4 = DAT_181d85490;", and
    // (multi-hop) "uVar4 = uVar9; ... uVar9 = String__Format(DAT_181d85490,...);".
    private static readonly System.Text.RegularExpressions.Regex AssignmentRegex = new(
        @"\b([A-Za-z_][A-Za-z0-9_]*)\s*=\s*([^;]*);",
        System.Text.RegularExpressions.RegexOptions.Compiled);

    private static readonly System.Text.RegularExpressions.Regex DatTokenRegex = new(
        @"DAT_[0-9a-fA-F]+", System.Text.RegularExpressions.RegexOptions.Compiled);

    // Identifier tokens found in an assignment's RHS that are themselves candidates to keep
    // tracing backward (excludes "DAT_..." literals, handled separately, and C keywords/literal
    // constants that could otherwise be misidentified as variable names).
    private static readonly System.Text.RegularExpressions.Regex IdentifierRegex = new(
        @"\b[A-Za-z_][A-Za-z0-9_]*\b", System.Text.RegularExpressions.RegexOptions.Compiled);

    private static readonly HashSet<string> NonVariableIdentifiers = new(StringComparer.Ordinal)
    {
        "if", "else", "return", "goto", "while", "for", "do", "switch", "case", "default",
        "sizeof", "NULL", "true", "false", "const", "unsigned", "signed", "void", "int", "long",
        "float", "double", "char", "short", "undefined8", "undefined4", "undefined2", "undefined1",
        "undefined", "byte", "uint", "ulong", "ushort",
    };

    /// <summary>
    /// Scans every decompiled .c file under <paramref name="decompiledDir"/> for non-user-facing
    /// diagnostic sink calls - Debug.Log-family calls (<see cref="LogCallRegex"/>) and exception
    /// constructor message arguments (<see cref="ExceptionCtorRegex"/>) - and returns the set of
    /// string VALUES (resolved via <paramref name="stringMap"/>, the already-loaded
    /// _string_map.csv) passed to them, either directly as a "DAT_xxx" literal argument, or via a
    /// MULTI-HOP backward trace through local variables/parameters within the same function body
    /// (e.g. "uVar4 = uVar9; ... uVar9 = String__Format(DAT_xxx,...); ... Debug__Log(uVar4,0);").
    /// Exception messages are included on the same reasoning as Debug.Log calls: a thrown
    /// exception's message string is developer/diagnostic text (surfaced in a crash log/stack
    /// trace, e.g. LTCSVLoader's out-of-range messages or ConvertNumToChinese's overflow message),
    /// never end-user-facing UI/dialogue text, so it's exactly the same class of false-positive
    /// candidate as a Debug.Log argument. Each hop only follows the LAST assignment to a given
    /// variable name that appears strictly BEFORE the point being traced from (preserving genuine
    /// backward-data-flow order rather than matching any assignment anywhere in the file), a
    /// visited-variable set prevents revisiting the same variable twice in one trace (guards
    /// against assignment cycles, e.g. "a = b; b = a;"), and a hop-count cap bounds the total work
    /// per sink call. This is still a best-effort heuristic (no real control-flow/data-flow
    /// analysis - a variable fed through a helper method call, a conditional with multiple
    /// candidate assignments, or a loop-carried value won't be traced correctly), intended to
    /// filter obvious developer/diagnostic-only strings out of the dynamic-string translation
    /// candidate list rather than to be a complete/precise classifier. A string value found here
    /// is excluded from candidates game-wide (by value, not by DAT_ address/call-site), so a
    /// literal that happens to ALSO be used as genuine user-facing text elsewhere (same string
    /// value, different DAT_ slot or reused slot) will be excluded too - review the resulting
    /// candidate list if you suspect this for a particular case. Adding more sink patterns/hops
    /// only ever adds MORE strings to the exclude set, never fewer - so widening the scan is safe
    /// in the sense that it can't cause a genuine user-facing string to start being included when
    /// it shouldn't be; the only risk is the reverse (a genuinely user-facing string incorrectly
    /// excluded because it happens to share a variable-assignment chain with a sink call), which is
    /// why results are still worth spot-checking.
    /// </summary>
    public static HashSet<string> FindLogOnlyStringValues(string decompiledDir, Dictionary<string, string> stringMap)
    {
        const int maxHops = 8;
        var values = new HashSet<string>();
        var sinkRegexes = new[] { LogCallRegex, ExceptionCtorRegex };

        foreach (var file in Directory.EnumerateFiles(decompiledDir, "*.c", SearchOption.AllDirectories))
        {
            string content;
            try { content = File.ReadAllText(file, Encoding.UTF8); }
            catch { continue; }

            // Cache: variable name -> all its assignment matches, sorted by position. Built once
            // per file (not per sink call) since a single function/file may have several sink calls.
            var assignmentsByVar = new Dictionary<string, List<System.Text.RegularExpressions.Match>>(StringComparer.Ordinal);
            foreach (System.Text.RegularExpressions.Match assign in AssignmentRegex.Matches(content))
            {
                var name = assign.Groups[1].Value;
                if (!assignmentsByVar.TryGetValue(name, out var list))
                    assignmentsByVar[name] = list = new List<System.Text.RegularExpressions.Match>();
                list.Add(assign);
            }

            foreach (var sinkRegex in sinkRegexes)
            foreach (System.Text.RegularExpressions.Match sinkMatch in sinkRegex.Matches(content))
            {
                var arg = sinkMatch.Groups[1].Value;

                if (arg.StartsWith("DAT_", StringComparison.Ordinal))
                {
                    if (stringMap.TryGetValue(arg, out var direct))
                        values.Add(direct);
                    continue;
                }

                var visited = new HashSet<string>(StringComparer.Ordinal) { arg };
                var frontier = new Queue<(string Variable, int BeforePos)>();
                frontier.Enqueue((arg, sinkMatch.Index));
                int hops = 0;

                while (frontier.Count > 0 && hops < maxHops)
                {
                    hops++;
                    var (variable, beforePos) = frontier.Dequeue();

                    if (!assignmentsByVar.TryGetValue(variable, out var candidates)) continue;

                    // Last assignment strictly before beforePos.
                    System.Text.RegularExpressions.Match? best = null;
                    foreach (var assign in candidates)
                    {
                        if (assign.Index >= beforePos) continue;
                        if (best == null || assign.Index > best.Index) best = assign;
                    }
                    if (best == null) continue;

                    var expr = best.Groups[2].Value;
                    var exprPos = best.Index;

                    foreach (System.Text.RegularExpressions.Match datMatch in DatTokenRegex.Matches(expr))
                    {
                        if (stringMap.TryGetValue(datMatch.Value, out var traced))
                            values.Add(traced);
                    }

                    foreach (System.Text.RegularExpressions.Match idMatch in IdentifierRegex.Matches(expr))
                    {
                        var id = idMatch.Value;
                        if (id.StartsWith("DAT_", StringComparison.Ordinal)) continue;
                        if (NonVariableIdentifiers.Contains(id)) continue;
                        if (!visited.Add(id)) continue; // already traced this variable in this chain
                        frontier.Enqueue((id, exprPos));
                    }
                }
            }
        }

        return values;
    }

    // Escapes real newline characters to a literal two-character "\n" sequence (and normalizes
    // "\r\n"/"\r" to the same form) so a multi-line string value can be written as a SINGLE line
    // in the plain-text "one candidate per line" dynamicStrings.txt format without corrupting it.
    // Consuming code (FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow's export step) is
    // expected to reverse this - unescaping literal "\n" back to a real newline - before handing
    // the value to CompoundFieldSplitter.Decompose, which already treats a real newline as a
    // natural fragment boundary on its own.
    private static string EscapeNewlinesForFlatFile(string s) =>
        s.Replace("\r\n", "\n").Replace("\r", "\n").Replace("\n", "\\n");

    // ── CSV helpers ───────────────────────────────────────────────────────────

    private static string CsvEscape(string s) =>
        "\"" + s.Replace("\\", "\\\\")
                .Replace("\"", "\\\"")
                .Replace("\r", "\\r")
                .Replace("\n", "\\n")
                .Replace("\t", "\\t") + "\"";

    // Single-pass, left-to-right unescape. This MUST NOT be implemented as a sequence of global
    // string.Replace calls (as it previously was: unescaping \" \r \n \t before \\): a source
    // string containing a literal backslash immediately followed by a literal 'n'/'r'/'t'/'"'
    // (e.g. a Windows path or a regex-like fragment embedded in game text) round-trips through
    // CsvEscape as "\\" + "n" (backslash escaped to \\\\, followed by the untouched letter n).
    // Replacing "\\n" -> "\n" BEFORE "\\\\" -> "\\" then matches across that boundary (the second
    // backslash of the escaped pair + the following literal 'n'), silently turning a real
    // backslash+letter sequence into a newline and eating one of the two backslashes - genuine
    // string corruption on decompiled output substitution (pass 5a). A single left-to-right scan
    // that consumes each recognised two-character escape atomically has no such cross-boundary
    // ambiguity.
    private static string CsvUnescape(string s)
    {
        if (s.Length >= 2 && s[0] == '"' && s[^1] == '"')
            s = s[1..^1];

        var sb = new StringBuilder(s.Length);
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            if (c == '\\' && i + 1 < s.Length)
            {
                char next = s[i + 1];
                switch (next)
                {
                    case '\\': sb.Append('\\'); i++; continue;
                    case '"': sb.Append('"'); i++; continue;
                    case 'r': sb.Append('\r'); i++; continue;
                    case 'n': sb.Append('\n'); i++; continue;
                    case 't': sb.Append('\t'); i++; continue;
                    default: break; // not a recognised escape - keep the backslash literal
                }
            }
            sb.Append(c);
        }
        return sb.ToString();
    }
}
