using System.Text;
using Il2CppExplorer.Models;
using System.Text.RegularExpressions;

namespace Il2CppExplorer.Services;

/// <summary>
/// Writes one .cs file per type containing the class skeleton with every
/// method's decompiled C inlined as // line comments.
/// </summary>
public class SummaryWriter
{
    private readonly Dictionary<string, string> _stringMap;

    /// <summary>
    /// Accumulated during WriteAll: DAT-address (hex, no prefix) → (className → occurrence count).
    /// Used by WriteStaticLabels to produce _static_labels.csv for the next Ghidra run.
    /// </summary>
    private readonly Dictionary<string, Dictionary<string, int>> _staticsUsage =
        new(StringComparer.OrdinalIgnoreCase);

    public SummaryWriter(Dictionary<string, string>? stringMap = null)
    {
        _stringMap = stringMap ?? new();
        if (_stringMap.Count > 0)
            Console.WriteLine($"  [StringMap] Loaded {_stringMap.Count} string literal substitutions.");
    }

    public void WriteAll(List<TypeInfo> types, List<TypeInfo>? allTypes = null, Dictionary<string, string>? datToClass = null)
    {
        // Build cross-type field-offset registry for non-self pointer resolution (Pass 3c).
        // Use allTypes when available so cross-class pointer resolution works even when
        // a --filter is active and only a subset of types are being written.
        var registrySource = allTypes ?? types;
        var typeOffsets = BuildTypeOffsetRegistry(registrySource);
        // Build static field-offset registry for Pass 3e
        var staticTypeOffsets = BuildStaticTypeOffsetRegistry(registrySource);
        // Game-type names: only DLL-sourced types (used in pass 3b to exclude BCL stubs
        // like "List" from type inference, preventing wrong varTypeMap entries).
        var gameTypeNames = new HashSet<string>(
            registrySource.Select(t => t.ClassName), StringComparer.OrdinalIgnoreCase);

        int written = 0;
        foreach (var type in types)
        {
            if (type.SummaryOutputPath == null) continue;
            Directory.CreateDirectory(Path.GetDirectoryName(type.SummaryOutputPath)!);
            WriteSummary(type, _stringMap, typeOffsets, staticTypeOffsets, _staticsUsage, gameTypeNames, registrySource, datToClass);
            written++;
        }
        Console.WriteLine($"  Class files written: {written}");
    }

    /// <summary>
    /// Writes <paramref name="outputDir"/>/_static_labels.csv mapping each
    /// IL2CPP class-statics-pointer DAT_ address to a readable Ghidra label
    /// (e.g. GameDataController_StaticsPtr).  On the next run Ghidra applies
    /// these as data symbols so DAT_ addresses are replaced in decompiled output.
    ///
    /// The file is regenerated every run (overwritten); call after WriteAll.
    /// No-op if no statics-pointer patterns were seen during this run.
    /// </summary>
    public void WriteStaticLabels(string outputDir)
    {
        if (_staticsUsage.Count == 0) return;

        string csvPath = Path.Combine(outputDir, "_static_labels.csv");
        Directory.CreateDirectory(outputDir);
        using var w = new StreamWriter(csvPath, append: false, Encoding.UTF8);
        w.WriteLine("RVA,Label");

        // For each DAT_ address, the class that uses it most often "owns" it.
        int written = 0;
        foreach (var (addr, classMap) in _staticsUsage.OrderBy(kv => kv.Key))
        {
            string owner = classMap.OrderByDescending(kv => kv.Value).First().Key;
            string label = SanitizeLabel(owner) + "_StaticsPtr";
            w.WriteLine($"0x{addr},{label}");
            written++;
        }
        Console.WriteLine($"  Static labels written: {written} → {csvPath}");
    }

    private static string SanitizeLabel(string name) =>
        Regex.Replace(name, @"[^A-Za-z0-9_]", "_");

    /// <summary>
    /// Scans raw Ghidra C lines for the IL2CPP statics-pointer pattern
    ///   *(int64 *)(DAT_XXXX + 0xb8)
    /// and accumulates (DAT address → className → count) into <paramref name="staticsUsage"/>.
    /// Called on raw (unprocessed) lines so string-literal substitutions don't obscure the pattern.
    /// </summary>
    private static readonly Regex _staticsPointerScanRe = new(
        @"\*\((?:int64|longlong) \*\)\(DAT_([0-9a-fA-F]+) \+ 0xb8\)",
        RegexOptions.IgnoreCase | RegexOptions.Compiled);

    private static void ScanStaticsPointers(
        string[] lines, string className,
        Dictionary<string, Dictionary<string, int>> staticsUsage)
    {
        foreach (string line in lines)
            foreach (Match m in _staticsPointerScanRe.Matches(line))
            {
                string addr = m.Groups[1].Value.ToLowerInvariant();
                if (!staticsUsage.TryGetValue(addr, out var classMap))
                    staticsUsage[addr] = classMap = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
                classMap[className] = classMap.GetValueOrDefault(className) + 1;
            }
    }

    /// <summary>
    /// Builds a registry of typeName (case-insensitive) → (byteOffset → fieldName)
    /// from all known types.  BCL IL2CPP layouts are hardcoded.
    /// </summary>
    private static Dictionary<string, Dictionary<int, string>> BuildTypeOffsetRegistry(
        IEnumerable<TypeInfo> types)
    {
        var reg = new Dictionary<string, Dictionary<int, string>>(StringComparer.OrdinalIgnoreCase);

        // Well-known IL2CPP BCL layouts (x64, 16-byte object header)
        reg["List"] = new() { [0x10] = "_items", [0x18] = "Count", [0x1c] = "_version" };
        reg["BetterList"] = new() { [0x10] = "buffer", [0x18] = "size" };
        reg["Dictionary"] = new()
        {
            [0x10] = "buckets",
            [0x18] = "entries",
            [0x20] = "count",
            [0x28] = "version",
            [0x2c] = "freeList"
        };
        // Array (Il2CppArrayBase): bounds at 0x10, max_length at 0x18
        reg["Array"] = new() { [0x18] = "Length" };

        foreach (var t in types)
        {
            if (t.FieldOffsets.Count == 0) continue;
            var inv = new Dictionary<int, string>();
            foreach (var (fn, fo) in t.FieldOffsets)
                inv.TryAdd(fo, fn);
            // Game type wins over BCL defaults if present
            reg[t.ClassName] = inv;
        }
        return reg;
    }

    /// <summary>
    /// Builds a registry of typeName (case-insensitive) → (staticByteOffset → fieldName)
    /// for static fields only. Static structs have no object header, so offsets start at 0.
    /// </summary>
    private static Dictionary<string, Dictionary<int, string>> BuildStaticTypeOffsetRegistry(
        IEnumerable<TypeInfo> types)
    {
        var reg = new Dictionary<string, Dictionary<int, string>>(StringComparer.OrdinalIgnoreCase);
        foreach (var t in types)
        {
            if (t.StaticFieldOffsets.Count == 0) continue;
            var inv = new Dictionary<int, string>();
            foreach (var (fn, fo) in t.StaticFieldOffsets)
                inv.TryAdd(fo, fn);
            reg[t.ClassName] = inv;
        }
        return reg;
    }

    private static void WriteSummary(TypeInfo type, Dictionary<string, string> stringMap,
        Dictionary<string, Dictionary<int, string>> typeOffsets,
        Dictionary<string, Dictionary<int, string>> staticTypeOffsets,
        Dictionary<string, Dictionary<string, int>> staticsUsage,
        HashSet<string> gameTypeNames,
        List<TypeInfo> registryTypes,
        Dictionary<string, string>? datToClass = null)
    {
        using var w = new StreamWriter(type.SummaryOutputPath!);

        w.WriteLine($"// ============================================================");
        w.WriteLine($"// Type  : {type.FullName}");
        w.WriteLine($"// Token : {type.Token}");
        w.WriteLine($"// ============================================================");
        w.WriteLine();

        if (!string.IsNullOrEmpty(type.Namespace))
        {
            w.WriteLine($"namespace {type.Namespace}");
            w.WriteLine($"{{");
        }

        w.WriteLine($"public class {type.ClassName}");
        w.WriteLine($"{{");

        var fields = type.Members.Where(m => m.MemberKind == "Field").ToList();
        if (fields.Any())
        {
            w.WriteLine($"    // ── Fields ───────────────────────────────────────────────────");
            foreach (var f in fields)
            {
                if (!string.IsNullOrEmpty(f.Token))
                    w.WriteLine($"    // Token: {f.Token}");
                w.WriteLine($"    {CleanSignature(f.Signature)};");
                w.WriteLine();
            }
        }

        var methods = type.Members.Where(m => m.MemberKind is "Method" or "Constructor").ToList();
        if (methods.Any())
        {
            w.WriteLine($"    // ── Methods ──────────────────────────────────────────────────");
            foreach (var m in methods)
            {
                if (!string.IsNullOrEmpty(m.Token))
                    w.WriteLine($"    // Token : {m.Token}");

                if (m.Address != null)
                    w.WriteLine($"    // RVA   : {m.Address.RVA}   Offset: {m.Address.Offset}   Length: {m.Address.Length}");
                else
                    w.WriteLine($"    // (no native address)");

                w.WriteLine($"    {CleanSignature(m.Signature)}");
                w.WriteLine($"    {{");

                if (m.DecompiledOutputPath != null && File.Exists(m.DecompiledOutputPath))
                {
                    var rawLines = File.ReadAllLines(m.DecompiledOutputPath);
                    ScanStaticsPointers(rawLines, type.ClassName, staticsUsage);
                    var cleaned = CleanDecompiledC(rawLines, m, type, stringMap, typeOffsets, staticTypeOffsets, gameTypeNames, registryTypes, datToClass);
                    foreach (var line in cleaned)
                        w.WriteLine(string.IsNullOrWhiteSpace(line) ? "" : $"        {line}");
                }

                w.WriteLine($"    }}");
                w.WriteLine();
            }
        }

        w.WriteLine($"}}");
        if (!string.IsNullOrEmpty(type.Namespace))
            w.WriteLine($"}}");
    }

    // ── Signature cleaner ─────────────────────────────────────────────────────

    private static readonly Dictionary<string, string> PrimitiveMap = new(StringComparer.Ordinal)
    {
        ["Void"] = "void",
        ["Boolean"] = "bool",
        ["Byte"] = "byte",
        ["SByte"] = "sbyte",
        ["Int16"] = "short",
        ["UInt16"] = "ushort",
        ["Int32"] = "int",
        ["UInt32"] = "uint",
        ["Int64"] = "long",
        ["UInt64"] = "ulong",
        ["Single"] = "float",
        ["Double"] = "double",
        ["Char"] = "char",
        ["String"] = "string",
        ["Object"] = "object",
    };

    public static string CleanSignature(string sig)
    {
        sig = sig.Replace(".ctor", "/*ctor*/").Replace(".cctor", "/*cctor*/");
        sig = Regex.Replace(sig, @"(\w+)`(\d+)", m =>
        {
            int arity = int.Parse(m.Groups[2].Value);
            string typeParams = string.Join(", ", Enumerable.Range(1, arity).Select(i => $"T{i}"));
            return $"{m.Groups[1].Value}<{typeParams}>";
        });
        foreach (var (il, cs) in PrimitiveMap)
            sig = Regex.Replace(sig, $@"\b{il}\b", cs);
        return sig;
    }

    // ── Ghidra C output cleaner ───────────────────────────────────────────────

    private static readonly (string From, string To)[] GhidraTypeAliases =
    [
        ("undefined8", "uint64"),
        ("undefined4", "uint32"),
        ("undefined2", "uint16"),
        ("undefined1", "uint8"),
        ("undefined *", "void *"),
        ("undefined",  "byte"),
        ("longlong",   "int64"),
        ("ulonglong",  "uint64"),
        ("uint",       "uint32"),
        ("ushort",     "uint16"),
        ("uchar",      "uint8"),
    ];

    /// <summary>
    /// Post-processes raw Ghidra C output into clean, readable pseudo-C# lines.
    ///
    /// Pass 0  — Strip Ghidra header comment, function signature, outer braces;
    ///           de-indent body by 2 spaces.
    /// Pass 1  — Remove IL2CPP class-init guard blocks (pure boilerplate).
    /// Pass 2  — Remove GC write-barrier thunk calls (always follows field write).
    /// Per-line — Ghidra type aliases; param_N → C# names; thunk_ → il2cpp_internal.
    /// Pass 3  — Field reads/writes on self: *(type*)(self+0xNN) → self.fieldName.
    /// Pass 3e — Static field reads/writes: *(type*)(pClassName+0xNN) → ClassName.fieldName.
    /// Pass 4  — new-object pattern: il2cpp_internal + __ctor + self.field = var
    ///           → self.field = new ClassName(args).
    /// Pass 5  — Single-line /* comment */ → // comment (avoids nested /* */ issues).
    /// Pass 6  — Remove trailing solo `return;`.
    /// Pass 7  — Collapse consecutive blank lines; trim trailing blank lines.
    /// </summary>
    private static string[] CleanDecompiledC(
        string[] rawLines, MemberInfo member, TypeInfo type,
        Dictionary<string, string> stringMap,
        Dictionary<string, Dictionary<int, string>> typeOffsets,
        Dictionary<string, Dictionary<int, string>> staticTypeOffsets,
        HashSet<string> gameTypeNames,
        List<TypeInfo> registryTypes,
        Dictionary<string, string>? datToClass = null)
    {
        // ── Build lookup tables ────────────────────────────────────────────
        var paramMap = new Dictionary<string, string>();
        int gi = 1;
        if (!member.IsStatic) paramMap[$"param_{gi++}"] = "this";
        foreach (var name in member.ParameterNames)
        {
            if (!string.IsNullOrEmpty(name)) paramMap[$"param_{gi}"] = name;
            gi++;
        }

        var fieldByOffset = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        foreach (var (fn, fo) in type.FieldOffsets)
            fieldByOffset[$"0x{fo:x}"] = fn;

        // ── Pass 0: strip header, signature, outer braces; de-indent ──────
        var lines = StripGhidraWrapper(rawLines);

        // ── Pass 0.5: substitute DAT_ addresses with string literals ──────
        // DAT_181dXXXXXX used as string arguments → "actual value"
        // Non-string DATs (class/method metadata) are left untouched.
        if (stringMap.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = Regex.Replace(lines[i],
                    @"\bDAT_[0-9a-fA-F]+\b",
                    m => stringMap.TryGetValue(m.Value, out string? sv)
                         ? FormatStringLiteral(sv)
                         : m.Value);
            }
        }

        // ── Pass 1: remove class-init guard blocks ─────────────────────────
        // Pattern:
        //   if (DAT_XXXXXXXX == '\0') {
        //     thunk_FUN_XXXX(...);   ← zero or more
        //     DAT_XXXXXXXX = '\x01';
        //   }
        {
            var p = new List<string>(lines.Count);
            int i = 0;
            while (i < lines.Count)
            {
                string t = lines[i].TrimStart();
                if (Regex.IsMatch(t, @"^if \(DAT_[0-9a-fA-F]+ == '\\0'\) \{"))
                {
                    int j = i + 1; bool pure = false;
                    while (j < lines.Count)
                    {
                        string inner = lines[j].TrimStart();
                        if (inner == "}") { pure = true; break; }
                        if (inner == "" ||
                            Regex.IsMatch(inner, @"^(?:\w+ = )?(?:thunk_FUN_[0-9a-fA-F]+|il2cpp_runtime_class_init)\(") ||
                            Regex.IsMatch(inner, @"^DAT_[0-9a-fA-F]+ = '\\x01';"))
                        { j++; continue; }
                        break;
                    }
                    if (pure) { i = j + 1; continue; }
                }
                p.Add(lines[i]);
                i++;
            }
            lines = p;
        }

        // ── Pass 2: remove GC write-barrier lines ─────────────────────────
        // A standalone thunk_FUN_ call immediately after *(ptr) = val is the
        // IL2CPP GC write barrier — it carries no new information.
        {
            var p = new List<string>(lines.Count);
            for (int i = 0; i < lines.Count; i++)
            {
                string t = lines[i].TrimStart();
                if (Regex.IsMatch(t, @"^thunk_FUN_[0-9a-fA-F]+\(") && t.EndsWith(";"))
                {
                    int prev = i - 1;
                    while (prev >= 0 && lines[prev].Trim() == "") prev--;
                    if (prev >= 0 && Regex.IsMatch(lines[prev].TrimStart(), @"^\*\(.*\) ="))
                        continue; // drop it
                }
                p.Add(lines[i]);
            }
            lines = p;
        }

        // ── Per-line: type aliases + param substitution + thunk rename ─────
        for (int i = 0; i < lines.Count; i++)
        {
            string line = lines[i];

            // Ghidra type aliases → readable equivalents
            foreach (var (from, to) in GhidraTypeAliases)
                line = Regex.Replace(line, $@"\b{Regex.Escape(from)}\b", to);

            // param_N → C# parameter names (highest index first)
            foreach (var (gn, cn) in paramMap.OrderByDescending(kv => kv.Key))
                line = Regex.Replace(line, $@"\b{Regex.Escape(gn)}\b", cn);

            // thunk_FUN_XXXX(&DAT_...) → il2cpp_runtime_class_init(&DAT_...)
            line = Regex.Replace(line,
                @"\bthunk_FUN_[0-9a-fA-F]+\((&DAT_[0-9a-fA-F]+)\)",
                "il2cpp_runtime_class_init($1)");
            // Any remaining thunk_ call → il2cpp_internal
            line = Regex.Replace(line, @"\bthunk_FUN_[0-9a-fA-F]+\b", "il2cpp_internal");

            lines[i] = line;
        }

        // ── Pass 2b: convert Ghidra temp-variable declarations to C# ─────────
        // Lines like `uint64 uVar1;` / `int64 *plVar1;` / `char cVar3;` appear at the
        // top of each function body. Pointer types and stack arrays are dropped (they
        // are implementation artefacts or resolved by later passes); primitive value
        // types are converted to their C# equivalents and kept so the variable names
        // are properly declared in the output.
        var declaredVars = new HashSet<string>(StringComparer.Ordinal);
        {
            // Ghidra type → C# type mapping
            static string GhidraTypeToCSharp(string ghidraType) => ghidraType.ToLower() switch
            {
                "char" => "bool",   // Ghidra uses char for IL2CPP bool
                "int" => "int",
                "uint" => "uint",
                "int8" => "sbyte",
                "uint8" => "byte",
                "int16" => "short",
                "uint16" => "ushort",
                "int32" => "int",
                "uint32" => "uint",
                "int64" => "long",
                "longlong" => "long",
                "uint64" => "ulong",
                "ulonglong" => "ulong",
                "float" => "float",
                "double" => "double",
                "undefined" => "byte",
                "undefined1" => "byte",
                "undefined2" => "ushort",
                "undefined4" => "uint",
                "undefined8" => "ulong",
                _ => ""        // unknown → drop
            };

            var p = new List<string>(lines.Count);
            bool inVarBlock = true;
            for (int i = 0; i < lines.Count; i++)
            {
                string t = lines[i].TrimStart();
                if (inVarBlock)
                {
                    if (t == "") { continue; }
                    // Parse: <ghidra-type> [*] <tempVarName> [array-dim] ;
                    // Split on whitespace and work from the right to identify var name.
                    if (!t.Contains("=") && t.EndsWith(';'))
                    {
                        string[] parts = t.TrimEnd(';').Trim()
                                          .Split(new[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                        if (parts.Length >= 2)
                        {
                            // Last token may be array dimension like [2], or var name
                            string lastTok = parts[^1];
                            bool isArray = lastTok.StartsWith('[');
                            // If array dim is last, var name is the token before it
                            string varTok = isArray && parts.Length >= 3 ? parts[^2] : lastTok;
                            bool isPtr = varTok.StartsWith('*');
                            string varName = varTok.TrimStart('*');
                            // Ghidra temp names: lowercase-start, mixed-case, ending in digit(s)
                            bool isTempVar = Regex.IsMatch(varName, @"^[a-z][A-Za-z_]*[0-9]+$")
                                          || varName.StartsWith("in_", StringComparison.Ordinal);
                            if (isTempVar)
                            {
                                if (!isPtr && !isArray)
                                {
                                    // Collect all type tokens (everything before varTok)
                                    string rawType = string.Join(" ",
                                        parts[..^1].Select(p => p.TrimEnd('*'))).Trim();
                                    string csType = GhidraTypeToCSharp(rawType);
                                    if (!string.IsNullOrEmpty(csType))
                                    {
                                        string indent2 = lines[i][..(lines[i].Length - t.Length)];
                                        p.Add($"{indent2}{csType} {varName};");
                                        declaredVars.Add(varName);
                                    }
                                    // else: unknown type → drop
                                }
                                else if (!isPtr && isArray)
                                {
                                    // Stack-allocated array — emit as C# array declaration
                                    // e.g. `int local_res18 [2];` → `int[] local_res18 = new int[2];`
                                    string rawType = string.Join(" ",
                                        parts[..^2].Select(p2 => p2.TrimEnd('*'))).Trim();
                                    string csType = GhidraTypeToCSharp(rawType);
                                    string sizeStr = lastTok.Trim('[', ']');
                                    if (!string.IsNullOrEmpty(csType) && int.TryParse(sizeStr, out int arraySize))
                                    {
                                        string indent2 = lines[i][..(lines[i].Length - t.Length)];
                                        p.Add($"{indent2}{csType}[] {varName} = new {csType}[{arraySize}];");
                                        declaredVars.Add(varName);
                                    }
                                }
                                // Drop pointer declarations
                                continue;
                            }
                        }
                    }
                    inVarBlock = false;
                }
                p.Add(lines[i]);
            }
            lines = p;
        }

        // ── Pass 2c: strip remaining il2cpp_runtime_class_init guard blocks ──
        // Two forms emitted by Ghidra:
        //   Form A: if (((*(byte *)(DAT_XXX + 0x133) & 4) != 0) && ...) { ... }  (brace on same line)
        //   Form B: if (...) \n {  (brace on next line)
        {
            var p = new List<string>(lines.Count);
            int i = 0;
            while (i < lines.Count)
            {
                string t = lines[i].TrimStart();
                // Guard may split across two lines:
                //   if (((*(byte *)(DAT_XXX + 0x133) & 4) != 0) &&
                //   (*(int *)(DAT_XXX + 0xe0) == 0)) {
                int condEndIdx = i;
                if (Regex.IsMatch(t, @"^if \(\(\(\*\(byte \*\)\((?:DAT_\w+|\w+_StaticsPtr)") && t.Contains("0x133") &&
                    !t.Contains("0xe0") && i + 1 < lines.Count && lines[i + 1].Contains("0xe0"))
                    condEndIdx = i + 1;

                bool isInitGuard = Regex.IsMatch(t, @"^if \(\(\(\*\(byte \*\)\((?:DAT_\w+|\w+_StaticsPtr)") &&
                                   t.Contains("0x133") &&
                                   (t.Contains("0xe0") || condEndIdx > i);
                if (isInitGuard)
                {
                    // Scan forward from condEndIdx to find the opening brace.
                    // Ghidra emits 1–3 continuation lines (`) {`, `{`, or brace on same line).
                    int braceLineIdx = -1;
                    if (lines[condEndIdx].TrimEnd().EndsWith("{"))
                    {
                        braceLineIdx = condEndIdx;
                    }
                    else
                    {
                        // Look ahead up to 3 lines for a line that ends with `{`
                        int peek = condEndIdx + 1;
                        while (peek < lines.Count && peek <= condEndIdx + 3)
                        {
                            string pl = lines[peek].Trim();
                            if (pl.EndsWith("{")) { braceLineIdx = peek; break; }
                            if (pl == "" || Regex.IsMatch(pl, @"^[\)\s]+$")) { peek++; continue; }
                            break; // non-continuation line
                        }
                    }
                    if (braceLineIdx >= 0)
                    {
                        int j = braceLineIdx + 1; bool pure = false;
                        while (j < lines.Count)
                        {
                            string inner = lines[j].TrimStart();
                            if (inner == "}") { pure = true; break; }
                            if (inner == "" ||
                                Regex.IsMatch(inner, @"^il2cpp_runtime_class_init\("))
                            { j++; continue; }
                            break;
                        }
                        if (pure) { i = j + 1; continue; }
                    }
                }
                p.Add(lines[i]);
                i++;
            }
            lines = p;
        }

        // ── Pass 2d: collapse Ghidra comma-expressions in conditions ───────────
        // Ghidra emits C comma-expressions like:  (X = EXPR, X != 0)
        // which is not valid C#.  Rewrite to assignment-in-condition form:
        //   (X = EXPR, X != 0)    →  (X = EXPR) != null
        //   (X = EXPR, X == 0)    →  (X = EXPR) == null
        //   (X = EXPR, X != null) →  (X = EXPR) != null
        //   (X = EXPR, X == null) →  (X = EXPR) == null
        // Note: use =(?!=) to avoid matching the first = in a == comparison.
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = Regex.Replace(lines[i],
                @"\((\w+)\s*=(?!=)\s*(.+?),\s*\1\s*(!=|==)\s*(null|0)\)",
                mo =>
                {
                    string op = mo.Groups[3].Value;
                    return $"({mo.Groups[1].Value} = {mo.Groups[2].Value.Trim()}) {op} null";
                });
        }

        // ── Pass 2e: strip IL2CPP type-cast assertion boilerplate ────────────
        // IL2CPP emits a vtable type-check + bool assignment + null-init + conditional-assign +
        // null-check-throw pattern as a 14–17 line block before every checked cast.
        // Collapses the whole block to just: DEST = SRC;
        //
        //   if ((*(byte*)(VTVAR + 300) < *(byte*)(TYPE + 300)) || (...)) {
        //     bVar = false;
        //   } else { bVar = true; }
        //   DEST = (int64*)0;
        //   if (bVar) { DEST = SRC; }
        //   if (DEST == (int64*)0) { FUN_throw(SRC, TYPE); }   // non-returning
        //   → DEST = SRC;
        {
            for (int i = 0; i < lines.Count - 14; i++)
            {
                string t = lines[i].TrimStart();
                // Detect start: if ((*(byte *)(X + 300) < ...
                if (!t.StartsWith("if ((*(byte *)") || !t.Contains("+ 300)")) continue;

                string? boolVar = null, destVar = null, srcVar = null;

                // Find: boolVar = false;  within next 8 lines
                int falseIdx = -1;
                for (int j = i + 1; j <= i + 8 && j < lines.Count; j++)
                {
                    var fm = Regex.Match(lines[j].TrimStart(), @"^(\w+)\s*=\s*false\s*;$");
                    if (fm.Success) { boolVar = fm.Groups[1].Value; falseIdx = j; break; }
                }
                if (boolVar == null) continue;

                // Find: boolVar = true;  within next 5 lines
                int trueIdx = -1;
                for (int j = falseIdx + 1; j <= falseIdx + 5 && j < lines.Count; j++)
                {
                    var tm = Regex.Match(lines[j].TrimStart(), $@"^{Regex.Escape(boolVar)}\s*=\s*true\s*;$");
                    if (tm.Success) { trueIdx = j; break; }
                }
                if (trueIdx == -1) continue;

                // Find closing } of else block (1-3 lines after trueIdx)
                int elseCloseIdx = -1;
                for (int j = trueIdx + 1; j <= trueIdx + 3 && j < lines.Count; j++)
                {
                    if (lines[j].TrimStart() == "}") { elseCloseIdx = j; break; }
                }
                if (elseCloseIdx == -1) continue;

                // Find: DEST = (int64*)0x0;  within next 4 lines
                // (Ghidra emits null pointers as 0x0; pass 4e converts them later)
                int nullInitIdx = -1;
                for (int j = elseCloseIdx + 1; j <= elseCloseIdx + 4 && j < lines.Count; j++)
                {
                    var nm = Regex.Match(lines[j].TrimStart(), @"^(\w+)\s*=\s*\(int64 \*\)0x0\s*;$");
                    if (nm.Success) { destVar = nm.Groups[1].Value; nullInitIdx = j; break; }
                }
                if (destVar == null) continue;

                // Find: if (boolVar) { DEST = SRC; }  (exactly 3 lines)
                int condAssignEndIdx = -1;
                for (int j = nullInitIdx + 1; j <= nullInitIdx + 3 && j < lines.Count; j++)
                {
                    if (lines[j].TrimStart() == $"if ({boolVar})" + " {" && j + 2 < lines.Count)
                    {
                        var am = Regex.Match(lines[j + 1].TrimStart(), $@"^{Regex.Escape(destVar)}\s*=\s*(.+?)\s*;$");
                        if (am.Success && lines[j + 2].TrimStart() == "}")
                        {
                            srcVar = am.Groups[1].Value;
                            condAssignEndIdx = j + 2;
                            break;
                        }
                    }
                }
                if (srcVar == null) continue;

                // Find: if (DEST == (int64*)0x0) { ... FUN_throw ... }
                int throwBlockEnd = -1;
                for (int j = condAssignEndIdx + 1; j <= condAssignEndIdx + 4 && j < lines.Count; j++)
                {
                    if (!lines[j].TrimStart().StartsWith($"if ({destVar} == (int64 *)0x0)")) continue;
                    // Scan for matching closing brace
                    int depth = 0; bool hasFun = false;
                    for (int k = j; k < lines.Count && k <= j + 8; k++)
                    {
                        string tk = lines[k].TrimStart();
                        foreach (char c in tk) { if (c == '{') depth++; else if (c == '}') depth--; }
                        if (Regex.IsMatch(tk, @"^FUN_[0-9a-fA-F]+\(")) hasFun = true;
                        if (depth == 0 && k > j) { if (hasFun) throwBlockEnd = k; break; }
                    }
                    break;
                }
                if (throwBlockEnd == -1)
                {
                    // No throw found — "safe cast": just the bool pattern with no throw.
                    // Still collapse type-check + null-init + cond-assign to DEST = SRC;
                    // Use condAssignEndIdx as the end of what we strip.
                    string indent2 = new string(' ', lines[i].Length - t.Length);
                    int stripFrom2 = i;
                    if (i > 0)
                    {
                        var vtM2 = Regex.Match(lines[i - 1].TrimStart(), @"^(\w+)\s*=\s*\*(\w+)\s*;$");
                        if (vtM2.Success && vtM2.Groups[2].Value == srcVar)
                            stripFrom2 = i - 1;
                    }
                    lines.RemoveRange(stripFrom2, condAssignEndIdx - stripFrom2 + 1);
                    lines.Insert(stripFrom2, $"{indent2}{destVar} = {srcVar};");
                    i = stripFrom2;
                    continue;
                }

                // Full pattern found: lines[i..throwBlockEnd] → DEST = SRC;
                string indent = new string(' ', lines[i].Length - t.Length);

                // Optionally strip preceding vtable load:  VTVAR = *srcVar;
                int stripFrom = i;
                if (i > 0)
                {
                    var vtM = Regex.Match(lines[i - 1].TrimStart(), @"^(\w+)\s*=\s*\*(\w+)\s*;$");
                    if (vtM.Success && vtM.Groups[2].Value == srcVar)
                        stripFrom = i - 1;
                }

                lines.RemoveRange(stripFrom, throwBlockEnd - stripFrom + 1);
                lines.Insert(stripFrom, $"{indent}{destVar} = {srcVar};");
                i = stripFrom; // re-scan from insertion point
            }
        }

        // ── Pass 2e (variant 2): strip inline IL2CPP type-assertion throw blocks ──
        // Second variant: no bool intermediate — the type check + throw is directly inside
        // an outer null guard or else-if branch.  This block just asserts the type; strip it.
        //
        //   if/else if ((*(byte *)(*pVar + 300) < *(byte *)(TYPE + 300)) || (...)) {
        //     // WARNING: Subroutine does not return
        //     FUN_throw(...)
        //   }
        //   → (removed)
        //
        // Also strips the preceding no-op null guard when it appears as the if-branch:
        //   if (X == (int64 *)0x0) { X = (int64 *)0x0; }   ← no-op
        //   else if (type_check_fails) { FUN_throw(X); }
        //   → (both removed)
        {
            for (int i = 0; i < lines.Count - 4; i++)
            {
                string t = lines[i].TrimStart();
                bool isElseIf = t.StartsWith("else if ((*(byte *)");
                if (!isElseIf && !t.StartsWith("if ((*(byte *)")) continue;
                if (!t.Contains("+ 300)")) continue;

                // Within next 6 lines, look for the closing `}` of the block, containing
                // ONLY WARNING comments and a FUN_throw call (no bool assignments).
                int braceIdx = -1;
                for (int j = i; j <= i + 5 && j < lines.Count; j++)
                {
                    if (lines[j].TrimEnd().EndsWith("{")) { braceIdx = j; break; }
                }
                if (braceIdx == -1) continue;

                // Scan the body: must contain only WARNING comments and FUN_throw
                int closeIdx = -1;
                bool hasFun = false, hasBoolAssign = false;
                for (int k = braceIdx + 1; k < lines.Count && k <= braceIdx + 6; k++)
                {
                    string tk = lines[k].TrimStart();
                    if (tk == "}") { closeIdx = k; break; }
                    if (tk == "") continue;
                    if (tk.StartsWith("// WARNING:") || tk.StartsWith("/* WARNING:")) continue;
                    if (Regex.IsMatch(tk, @"^FUN_[0-9a-fA-F]+\(")) { hasFun = true; continue; }
                    if (Regex.IsMatch(tk, @"^\w+\s*=\s*(true|false)\s*;")) { hasBoolAssign = true; break; }
                    break;
                }
                if (closeIdx == -1 || !hasFun || hasBoolAssign) continue;

                // Strip lines[i..closeIdx]
                int stripFrom = i;

                // If this is an else-if, also check whether the preceding if-branch is a no-op:
                //   if (VAR == (int64 *)0x0) { VAR = (int64 *)0x0; }  [i-3..i-1 lines before]
                if (isElseIf && i >= 3)
                {
                    // Look backwards from i for: }  (close of preceding if-branch)
                    int prevClose = i - 1;
                    while (prevClose > 0 && lines[prevClose].Trim() == "") prevClose--;
                    if (prevClose >= 0 && lines[prevClose].Trim() == "}")
                    {
                        // Look for: VAR = (int64 *)0x0;
                        int prevBody = prevClose - 1;
                        while (prevBody > 0 && lines[prevBody].Trim() == "") prevBody--;
                        var noopM = Regex.Match(lines[prevBody].TrimStart(), @"^(\w+)\s*=\s*\(int64 \*\)0x0\s*;$");
                        if (noopM.Success)
                        {
                            // Look for: if (VAR == (int64 *)0x0) { 
                            int prevOpen = prevBody - 1;
                            while (prevOpen > 0 && lines[prevOpen].Trim() == "") prevOpen--;
                            string prevOpenT = lines[prevOpen].TrimStart();
                            string noopVar = noopM.Groups[1].Value;
                            if (Regex.IsMatch(prevOpenT, $@"^if \({Regex.Escape(noopVar)} == \(int64 \*\)0x0\)") &&
                                prevOpenT.TrimEnd().EndsWith("{"))
                            {
                                stripFrom = prevOpen;
                            }
                        }
                    }
                }

                lines.RemoveRange(stripFrom, closeIdx - stripFrom + 1);
                i = Math.Max(0, stripFrom - 1); // re-check
            }
        }

        // ── Pass 3: field reads/writes on self ─────────────────────────────
        // *(type *)(self + 0xNN) → self.fieldName  (both reads and writes)
        if (fieldByOffset.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(this \+ (0x[0-9a-fA-F]+)\)",
                    mo =>
                    {
                        string offset = mo.Groups[1].Value.ToLower();
                        return fieldByOffset.TryGetValue(offset, out string? fn)
                            ? $"this.{fn}"
                            : mo.Value;
                    });
            }
        }

        // ── Pass 3b: build variable-type map ───────────────────────────────────
        // Infer types of local variables from common assignment patterns so that
        // Pass 3c can resolve *(type*)(var + offset) on non-self pointers.
        //
        // Sources tracked:
        //   var X = new TypeName(...)          →  X is TypeName
        //   X = this.fieldName                 →  X is type of fieldName (if in registry)
        //   X = CurrentClass.fieldName         →  X is type of fieldName (instance or static)
        //
        // Priority: game types always win; BCL stub types (List, Dictionary, etc.) are used
        // as a lower-priority fallback so that List fields still get _items/Count resolution
        // without overriding a game-typed variable that was seen earlier.
        var varTypeMap = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        {
            // Split field maps: game-typed fields (high priority) vs BCL stub fields (fallback).
            var gameFieldTypes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            var bclFieldTypes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
            foreach (var m in type.Members.Where(m => m.MemberKind == "Field"))
            {
                string baseType = ExtractBaseTypeFromSignature(m.Signature);
                bool inRegistry = typeOffsets.ContainsKey(baseType) || staticTypeOffsets.ContainsKey(baseType);
                if (!inRegistry) continue;
                if (gameTypeNames.Contains(baseType))
                    gameFieldTypes[m.Name] = baseType;
                else
                    bclFieldTypes[m.Name] = baseType; // e.g. List<T>, Dictionary<K,V>
            }

            foreach (var line in lines)
            {
                string t2 = line.TrimStart();
                // var X = new TypeName(...)
                var m1 = Regex.Match(t2, @"^var\s+(\w+)\s*=\s*new\s+(\w+)\s*\(");
                if (m1.Success && typeOffsets.ContainsKey(m1.Groups[2].Value))
                {
                    varTypeMap[m1.Groups[1].Value] = m1.Groups[2].Value;
                    continue;
                }
                // X = this.fieldName;
                var m2 = Regex.Match(t2, @"^(?:[\w\s\*]+\s+)?(\w+)\s*=\s*this\.(\w+)\s*;");
                if (m2.Success)
                {
                    string varN = m2.Groups[1].Value;
                    string fldN = m2.Groups[2].Value;
                    if (gameFieldTypes.TryGetValue(fldN, out string? bt))
                        varTypeMap[varN] = bt;                                   // game type: always override
                    else if (bclFieldTypes.TryGetValue(fldN, out string? bclBt) &&
                             !varTypeMap.ContainsKey(varN))                       // BCL: only if untyped
                        varTypeMap[varN] = bclBt;
                    continue;
                }
                // X = CurrentClass.fieldName;  (static field of the type being processed)
                var m3 = Regex.Match(t2, $@"^(?:[\w\s\*]+\s+)?(\w+)\s*=\s*{Regex.Escape(type.ClassName)}\.(\w+)\s*;");
                if (m3.Success)
                {
                    string varN = m3.Groups[1].Value;
                    string fldN = m3.Groups[2].Value;
                    if (gameFieldTypes.TryGetValue(fldN, out string? bt))
                        varTypeMap[varN] = bt;
                    else if (bclFieldTypes.TryGetValue(fldN, out string? bclBt) &&
                             !varTypeMap.ContainsKey(varN))
                        varTypeMap[varN] = bclBt;
                }
            }
        }

        // ── Pass 3c: resolve *(type*)(var + 0xNN) → var.fieldName ──────────────
        if (varTypeMap.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\((\w+)\s*\+\s*(0x[0-9a-fA-F]+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        if (!varTypeMap.TryGetValue(varName, out string? typeName)) return mo.Value;
                        string offStr = mo.Groups[2].Value.ToLower();
                        int offset;
                        try { offset = Convert.ToInt32(offStr, 16); } catch { return mo.Value; }
                        if (!typeOffsets.TryGetValue(typeName, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fieldName)) return mo.Value;
                        return $"{varName}.{fieldName}";
                    });
            }
        }

        // ── Pass 3c2: resolve *(type*)(self.FIELD + 0xNN) → self.FIELD.subField ─
        // Handles field accesses on objects that are themselves fields of self.
        // e.g. *(int *)(self.Tasks + 0x18) → self.Tasks.Count
        //      *(int64 *)(self.Tasks + 0x20) → self.Tasks._items   (for List<T>)
        // Build fieldName → baseTypeName for current class's instance fields (used here and in 3c3)
        var selfFieldTypes = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        if (typeOffsets.Count > 0)
        {
            foreach (var m in type.Members.Where(m => m.MemberKind == "Field"))
            {
                string baseType = ExtractBaseTypeFromSignature(m.Signature);
                if (typeOffsets.ContainsKey(baseType))
                    selfFieldTypes[m.Name] = baseType;
            }
        }

        if (selfFieldTypes.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                // Match *(type*)(this.FIELD + 0xNN)
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(this\.(\w+)\s*\+\s*(0x[0-9a-fA-F]+)\)",
                    mo =>
                    {
                        string fieldRef = mo.Groups[1].Value;
                        if (!selfFieldTypes.TryGetValue(fieldRef, out string? typeName)) return mo.Value;
                        string offStr = mo.Groups[2].Value.ToLower();
                        int offset;
                        try { offset = Convert.ToInt32(offStr, 16); } catch { return mo.Value; }
                        if (!typeOffsets.TryGetValue(typeName, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? subField)) return mo.Value;
                        return $"this.{fieldRef}.{subField}";
                    });

                // Also handle *(type*)(varName.FIELD + 0xNN) where varName is in varTypeMap
                // and FIELD is a field on that type whose base type has offset data.
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\((\w+)\.(\w+)\s*\+\s*(0x[0-9a-fA-F]+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        string fieldRef = mo.Groups[2].Value;
                        string offStr = mo.Groups[3].Value.ToLower();
                        int offset;
                        try { offset = Convert.ToInt32(offStr, 16); } catch { return mo.Value; }
                        // varName must have a known type
                        if (!varTypeMap.TryGetValue(varName, out string? varTypeName)) return mo.Value;
                        // fieldRef must be a field on that type — find its base type via selfFieldTypes
                        // (only works if varTypeName == current type's class; skip otherwise)
                        if (!varTypeName.Equals(type.ClassName, StringComparison.OrdinalIgnoreCase)) return mo.Value;
                        if (!selfFieldTypes.TryGetValue(fieldRef, out string? subTypeName)) return mo.Value;
                        if (!typeOffsets.TryGetValue(subTypeName, out var subOffMap)) return mo.Value;
                        if (!subOffMap.TryGetValue(offset, out string? subField)) return mo.Value;
                        return $"{varName}.{fieldRef}.{subField}";
                    });
            }
        }

        // ── Pass 3c3: resolve address-of pointer assignments ──────────────────
        // Ghidra emits writes to fields via a temp pointer variable:
        //   pVar = (type*)(BASE + OFFSET);   then   *pVar = EXPR;
        // which is effectively:  BASE.field = EXPR;
        //
        // Two-line adjacent collapse only — global substitution is unsafe because
        // Ghidra reuses temp pointer vars (puVar9, plVar9) across multiple assignments.
        //
        // Supports BASE = self or any variable in varTypeMap or selfFieldTypes.
        {
            // Regex for:  PVAR = (type*)(BASE + OFFSET);
            var addrOfRe = new Regex(
                @"^(\w+)\s*=\s*\([^)]+\*\s*\)\((\w+(?:\.\w+)?)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)\s*;$",
                RegexOptions.IgnoreCase);

            for (int i = 0; i < lines.Count; i++)
            {
                string trimmed = lines[i].TrimStart();
                var m = addrOfRe.Match(trimmed);
                if (!m.Success) continue;

                string ptrVar = m.Groups[1].Value;
                string baseExpr = m.Groups[2].Value; // "this" or "lVar6" or "this.field"
                string offStr = m.Groups[3].Value;
                int offset;
                try
                {
                    offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                    ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                }
                catch { continue; }

                // Resolve baseExpr to a field reference string
                string? resolvedField = null;
                if (baseExpr.Equals("this", StringComparison.OrdinalIgnoreCase))
                {
                    string hexOff = $"0x{offset:x}";
                    if (fieldByOffset.TryGetValue(hexOff, out string? fn))
                        resolvedField = $"this.{fn}";
                }
                else if (baseExpr.Contains('.'))
                {
                    int dot = baseExpr.IndexOf('.');
                    string baseVar = baseExpr[..dot];
                    string baseField = baseExpr[(dot + 1)..];
                    if (baseVar.Equals("this", StringComparison.OrdinalIgnoreCase) &&
                        selfFieldTypes.TryGetValue(baseField, out string? subType) &&
                        typeOffsets.TryGetValue(subType, out var subMap) &&
                        subMap.TryGetValue(offset, out string? subFn))
                        resolvedField = $"{baseExpr}.{subFn}";
                }
                else if (varTypeMap.TryGetValue(baseExpr, out string? varType) &&
                         typeOffsets.TryGetValue(varType, out var offMap) &&
                         offMap.TryGetValue(offset, out string? fn))
                {
                    resolvedField = $"{baseExpr}.{fn}";
                }

                if (resolvedField == null) continue;

                // Look at the immediately following non-empty line
                int next = i + 1;
                while (next < lines.Count && lines[next].Trim() == "") next++;

                if (next < lines.Count)
                {
                    string nt = lines[next].TrimStart();
                    string indentNext = lines[next][..(lines[next].Length - nt.Length)];
                    string indent = lines[i][..(lines[i].Length - trimmed.Length)];

                    // Write: *ptrVar = EXPR;
                    var wm = Regex.Match(nt, $@"^\*{Regex.Escape(ptrVar)}\s*=\s*(.+?)\s*;$",
                        RegexOptions.IgnoreCase);
                    if (wm.Success)
                    {
                        lines[i] = $"{indent}{resolvedField} = {wm.Groups[1].Value};";
                        lines[next] = "";
                        // Also drop the GC write-barrier that immediately follows
                        int after2 = next + 1;
                        while (after2 < lines.Count && lines[after2].Trim() == "") after2++;
                        if (after2 < lines.Count && Regex.IsMatch(lines[after2].TrimStart(),
                            $@"^il2cpp_internal\({Regex.Escape(ptrVar)}\s*,", RegexOptions.IgnoreCase))
                            lines[after2] = "";
                        continue;
                    }

                    // Read: VAR = *ptrVar;
                    var rm = Regex.Match(nt, $@"^([\w\s\*]+?)\s*=\s*\*{Regex.Escape(ptrVar)}\s*;$",
                        RegexOptions.IgnoreCase);
                    if (rm.Success)
                    {
                        lines[i] = "";
                        lines[next] = $"{indentNext}{rm.Groups[1].Value.Trim()} = {resolvedField};";
                        continue;
                    }
                }

                // Not immediately consumed — rewrite as address-of for clarity
                string indent2 = lines[i][..(lines[i].Length - trimmed.Length)];
                lines[i] = $"{indent2}{ptrVar} = &{resolvedField};";
            }

            // Remove blank lines left by the two-line collapse
            lines = lines.Where(ln => ln != "").ToList();
        }

        // ── Pass 3g2: multi-use address-of pointer tracking ──────────────────
        // Pass 3g only handles adjacent write pairs. When `pVar = &FIELD` is
        // followed by multiple `*pVar` reads/writes further down the body,
        // replace all of them and remove the address-of declaration.
        {
            // Collect pVar → FIELD for all remaining `pVar = &FIELD;` lines
            // (Ghidra temp pointer names: lowercase start, ends with digit)
            var addrOf = new Dictionary<string, string>(StringComparer.Ordinal);
            var addrOfIdx = new Dictionary<string, int>(StringComparer.Ordinal);
            for (int i = 0; i < lines.Count; i++)
            {
                string t = lines[i].TrimStart();
                var m = Regex.Match(t, @"^([a-z][A-Za-z_]*[0-9]+)\s*=\s*&(.+?)\s*;$");
                if (m.Success)
                {
                    addrOf[m.Groups[1].Value] = m.Groups[2].Value;
                    addrOfIdx[m.Groups[1].Value] = i;
                }
            }

            foreach (var (pVar, field) in addrOf)
            {
                int startLine = addrOfIdx[pVar];
                // Find next reassignment of pVar (if any) — limit replacement range
                int endLine = lines.Count;
                for (int i = startLine + 1; i < lines.Count; i++)
                {
                    string t2 = lines[i].TrimStart();
                    // Stop if pVar is assigned something else
                    if (Regex.IsMatch(t2, $@"^{Regex.Escape(pVar)}\s*=(?![=])") &&
                        !t2.Contains($"= &{field}"))
                    {
                        endLine = i;
                        break;
                    }
                }

                // Replace *pVar with field in [startLine+1, endLine)
                bool anyReplaced = false;
                for (int i = startLine + 1; i < endLine; i++)
                {
                    var replaced = Regex.Replace(lines[i],
                        $@"\*{Regex.Escape(pVar)}\b", field,
                        RegexOptions.IgnoreCase);
                    if (replaced != lines[i]) { lines[i] = replaced; anyReplaced = true; }
                }

                // Remove the `pVar = &FIELD;` line if pVar no longer appears
                if (anyReplaced)
                {
                    bool stillUsed = lines
                        .Where((_, idx) => idx != startLine)
                        .Any(ln => Regex.IsMatch(ln, $@"\b{Regex.Escape(pVar)}\b"));
                    if (!stillUsed)
                        lines[startLine] = "";
                }
            }
            lines = lines.Where(ln => ln != "").ToList();
        }

        // ── Pass 3d: extract repeated statics-pointer derefs ──────────────────
        // IL2CPP stores each class's static fields behind a statics pointer:
        //   *(type *)(*(int64 *)(DAT_CLASSPTR + 0xb8) + FIELD_OFFSET)
        // When the same CLASSPTR appears ≥ 2 times, hoist the inner
        // dereference to a named local to reduce noise.
        //
        // Handles two forms of CLASSPTR:
        //   DAT_XXXX           — first run, Ghidra hasn't labelled the address yet
        //   ClassName_StaticsPtr — subsequent runs after _static_labels.csv was applied
        //
        // Produces varToClass: varName → className (only for named-symbol form), used by pass 3e.
        var varToClass = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        {
            var staticsRe = new Regex(
                @"\*\(int64 \*\*?\)\((DAT_[0-9a-fA-F]+|\w+) \+ 0xb8\)",
                RegexOptions.IgnoreCase);
            var counts = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var ln in lines)
                foreach (Match sm in staticsRe.Matches(ln))
                    counts[sm.Groups[1].Value] = counts.GetValueOrDefault(sm.Groups[1].Value) + 1;

            var repeated = counts.Where(kv => kv.Value >= 2).Select(kv => kv.Key).ToList();
            if (repeated.Count > 0)
            {
                // DAT_-style identifiers (first run)
                int datCount = repeated.Count(id => id.StartsWith("DAT_", StringComparison.OrdinalIgnoreCase));

                var varNames = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                foreach (var id in repeated)
                {
                    string varName;
                    if (id.StartsWith("DAT_", StringComparison.OrdinalIgnoreCase))
                    {
                        string addr = id[4..];
                        string suffix = addr.Length >= 4 ? addr[^4..] : addr;
                        varName = datCount == 1 ? "pStatics" : $"pStatics_{suffix}";
                        // If datToClass knows this address, expose the class for pass 3e/3f
                        if (datToClass != null &&
                            datToClass.TryGetValue(addr.ToLowerInvariant(), out string? cls))
                            varToClass[varName] = cls;
                    }
                    else
                    {
                        // Named symbol from Ghidra label (e.g. GameDataController_StaticsPtr)
                        string baseName = id.EndsWith("_StaticsPtr", StringComparison.OrdinalIgnoreCase)
                            ? id[..^"_StaticsPtr".Length]
                            : id;
                        varName = $"p{baseName}";
                        varToClass[varName] = baseName; // capture for pass 3e
                    }
                    varNames[id] = varName;
                }

                // Replace inner dereference with the variable name
                for (int i = 0; i < lines.Count; i++)
                    lines[i] = staticsRe.Replace(lines[i],
                        m => varNames.TryGetValue(m.Groups[1].Value, out string? vn) ? vn : m.Value);

                // Prepend declarations at top of method body
                var decls = varNames
                    .OrderBy(kv => kv.Value)
                    .Select(kv => $"var {kv.Value} = *(int64*)({kv.Key} + 0xb8);")
                    .ToList();
                lines.InsertRange(0, decls);
                lines.Insert(decls.Count, ""); // blank separator
            }
        }

        // ── Pass 3e: resolve static field accesses ─────────────────────────────
        // For each pClassName variable known from pass 3d, replace:
        //   *(type*)(pClassName + 0xNN)  →  ClassName.fieldName     (read/write)
        //   (type*)(pClassName + 0xNN)   →  &ClassName.fieldName    (address-of)
        // Supports both hex (0xNN) and decimal offsets.
        // This requires the named-symbol form (pass 3d assigned varToClass entries).
        if (varToClass.Count > 0 && staticTypeOffsets.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                // Dereference form:  *(type*)(pVar + offset)  →  ClassName.field
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\((\w+)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        if (!varToClass.TryGetValue(varName, out string? className)) return mo.Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16)
                            : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(className, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fieldName)) return mo.Value;
                        return $"{className}.{fieldName}";
                    });

                // Address-of form:  (type*)(pVar + offset)  →  &ClassName.field
                lines[i] = Regex.Replace(lines[i],
                    @"(?<!\*)\((?:[^)]+\*)\)\((\w+)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        if (!varToClass.TryGetValue(varName, out string? className)) return mo.Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16)
                            : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(className, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fieldName)) return mo.Value;
                        return $"&{className}.{fieldName}";
                    });
            }

            // ── Pass 3e chain: resolve *pVar (static field at offset 0) and
            //    *(type*)(*pVar + OFFSET) → ClassName.staticField0.instanceField
            // *pVar is the singleton instance (the first static field, offset 0).
            // The outer OFFSET is then an instance field of that singleton's class.
            for (int i = 0; i < lines.Count; i++)
            {
                // Chain form first so we don't prematurely substitute *pVar standalone.
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(\*(\w+)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        if (!varToClass.TryGetValue(varName, out string? className)) return mo.Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(className, out var statOff)) return mo.Value;
                        if (!statOff.TryGetValue(0, out string? staticField)) return mo.Value;
                        if (!typeOffsets.TryGetValue(className, out var instOff)) return mo.Value;
                        if (!instOff.TryGetValue(offset, out string? instanceField)) return mo.Value;
                        return $"{className}.{staticField}.{instanceField}";
                    });

                // Standalone *pVar → ClassName.staticField0
                foreach (var (varName, className) in varToClass)
                {
                    if (!staticTypeOffsets.TryGetValue(className, out var statOff)) continue;
                    if (!statOff.TryGetValue(0, out string? staticField)) continue;
                    lines[i] = Regex.Replace(lines[i],
                        $@"(?<!\*)\*{Regex.Escape(varName)}\b",
                        $"{className}.{staticField}");
                }
            }

            // ── Pass 3e cleanup: remove statics-pointer declarations whose variable
            // is no longer referenced (all accesses were fully resolved above).
            lines = lines.Where(ln =>
            {
                // Matches: var pXxx = *(int64*)(... + 0xb8);
                var dm = Regex.Match(ln.TrimStart(), @"^var\s+(p\w+)\s*=\s*\*\(int64\*\)\(.+ \+ 0xb8\);$");
                if (!dm.Success) return true;
                string vn = dm.Groups[1].Value;
                // Keep if any other line still references the variable
                return lines.Any(other => other != ln && Regex.IsMatch(other, $@"\b{Regex.Escape(vn)}\b"));
            }).ToList();
        }

        // ── Pass 3f: inline statics-pointer single-use resolution ─────────────
        // For methods where the statics pointer is accessed only once (pass 3d
        // didn't hoist it), resolve the inline double-dereference directly:
        //   *(type*)(*(int64*|longlong*)(ClassName_StaticsPtr + 0xb8) + OFFSET)
        //   →  ClassName.fieldName
        // Address-of form:
        //   (type*)(*(int64*|longlong*)(ClassName_StaticsPtr + 0xb8) + OFFSET)
        //   →  &ClassName.fieldName
        if (staticTypeOffsets.Count > 0)
        {
            var namedPtrRe = new Regex(
                @"\*\((?:int64|longlong) \*\)\((\w+)_StaticsPtr \+ 0xb8\)",
                RegexOptions.IgnoreCase);

            for (int i = 0; i < lines.Count; i++)
            {
                // Dereference:  *(type*)(*(int64*)(ClassName_StaticsPtr + 0xb8) + OFFSET)
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(\*\((?:int64|longlong) \*\)\((\w+)_StaticsPtr \+ 0xb8\)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string cls = mo.Groups[1].Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(cls, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fn)) return mo.Value;
                        return $"{cls}.{fn}";
                    },
                    RegexOptions.IgnoreCase);

                // Double-deref at offset 0:  **(type**)(ClassName_StaticsPtr + 0xb8)
                // = static field at offset 0 of ClassName's statics block
                lines[i] = Regex.Replace(lines[i],
                    @"\*\*\([^)]+\*\s*\*\)\((\w+)_StaticsPtr \+ 0xb8\)",
                    mo =>
                    {
                        string cls = mo.Groups[1].Value;
                        if (!staticTypeOffsets.TryGetValue(cls, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(0, out string? fn)) return mo.Value;
                        return $"{cls}.{fn}";
                    },
                    RegexOptions.IgnoreCase);

                // Named form chain: *(type*)(*(int64 **)(ClassName_StaticsPtr + 0xb8) + OFFSET)
                // The inner double-deref gives the first static (singleton), outer OFFSET is an
                // instance field of that singleton's class.
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(\*\((?:int64|longlong) \*\*\)\((\w+)_StaticsPtr \+ 0xb8\)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string cls = mo.Groups[1].Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(cls, out var statOff)) return mo.Value;
                        if (!statOff.TryGetValue(0, out string? staticField)) return mo.Value;
                        if (!typeOffsets.TryGetValue(cls, out var instOff)) return mo.Value;
                        if (!instOff.TryGetValue(offset, out string? instField)) return mo.Value;
                        return $"{cls}.{staticField}.{instField}";
                    },
                    RegexOptions.IgnoreCase);

                // DAT_ form chain + standalone (requires datToClass map from previous run)
                if (datToClass != null)
                {
                    // *(type*)(*(int64 **)(DAT_XXXX + 0xb8) + OFFSET) → chain resolution
                    lines[i] = Regex.Replace(lines[i],
                        @"\*\([^)]+\*\)\(\*\((?:int64|longlong) \*\*\)\(DAT_([0-9a-fA-F]+) \+ 0xb8\)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                        mo =>
                        {
                            string addr = mo.Groups[1].Value.ToLowerInvariant();
                            if (!datToClass.TryGetValue(addr, out string? cls)) return mo.Value;
                            string offStr = mo.Groups[2].Value;
                            int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                                ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                            if (!staticTypeOffsets.TryGetValue(cls, out var statOff)) return mo.Value;
                            if (!statOff.TryGetValue(0, out string? staticField)) return mo.Value;
                            if (!typeOffsets.TryGetValue(cls, out var instOff)) return mo.Value;
                            if (!instOff.TryGetValue(offset, out string? instField)) return mo.Value;
                            return $"{cls}.{staticField}.{instField}";
                        },
                        RegexOptions.IgnoreCase);

                    // **(int64 **)(DAT_XXXX + 0xb8) → ClassName.staticField0  (standalone)
                    lines[i] = Regex.Replace(lines[i],
                        @"\*\*\((?:int64|longlong) \*\*\)\(DAT_([0-9a-fA-F]+) \+ 0xb8\)",
                        mo =>
                        {
                            string addr = mo.Groups[1].Value.ToLowerInvariant();
                            if (!datToClass.TryGetValue(addr, out string? cls)) return mo.Value;
                            if (!staticTypeOffsets.TryGetValue(cls, out var statOff)) return mo.Value;
                            if (!statOff.TryGetValue(0, out string? staticField)) return mo.Value;
                            return $"{cls}.{staticField}";
                        },
                        RegexOptions.IgnoreCase);
                }

                // Address-of:  (type*)(*(int64*)(ClassName_StaticsPtr + 0xb8) + OFFSET)
                lines[i] = Regex.Replace(lines[i],
                    @"(?<!\*)\([^)]+\*\)\(\*\((?:int64|longlong) \*\)\((\w+)_StaticsPtr \+ 0xb8\)\s*\+\s*(0x[0-9a-fA-F]+|\d+)\)",
                    mo =>
                    {
                        string cls = mo.Groups[1].Value;
                        string offStr = mo.Groups[2].Value;
                        int offset = offStr.StartsWith("0x", StringComparison.OrdinalIgnoreCase)
                            ? Convert.ToInt32(offStr, 16) : int.Parse(offStr);
                        if (!staticTypeOffsets.TryGetValue(cls, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fn)) return mo.Value;
                        return $"&{cls}.{fn}";
                    },
                    RegexOptions.IgnoreCase);
            }
        }

        // ── Pass 3g: collapse address-of write-barrier triplet ────────────────
        // After passes 3c3/3e/3f produce `pVar = &FIELD`, the subsequent write and
        // optional GC write-barrier call are still present:
        //   pVar = &FIELD;          (from 3c3 / 3e address-of form)
        //   *pVar = VALUE;          (the actual field write)
        //   il2cpp_internal(pVar, VALUE);   (GC write barrier — optional, drop)
        // → FIELD = VALUE;
        {
            var addrOfAssignRe = new Regex(
                @"^(\w+)\s*=\s*&(.+?)\s*;$",
                RegexOptions.IgnoreCase);

            for (int i = 0; i < lines.Count; i++)
            {
                string trimmed = lines[i].TrimStart();
                var m = addrOfAssignRe.Match(trimmed);
                if (!m.Success) continue;

                string ptrVar = m.Groups[1].Value;
                string fieldExpr = m.Groups[2].Value;

                // Next non-empty line must be: *pVar = EXPR;
                int next = i + 1;
                while (next < lines.Count && lines[next].Trim() == "") next++;
                if (next >= lines.Count) continue;

                string nt = lines[next].TrimStart();
                var wm = Regex.Match(nt, $@"^\*{Regex.Escape(ptrVar)}\s*=\s*(.+?)\s*;$",
                    RegexOptions.IgnoreCase);
                if (!wm.Success) continue;

                string indent = lines[i][..(lines[i].Length - trimmed.Length)];
                string value = wm.Groups[1].Value;
                lines[i] = $"{indent}{fieldExpr} = {value};";
                lines[next] = "";

                // Drop the GC write-barrier call immediately following, if present
                int after = next + 1;
                while (after < lines.Count && lines[after].Trim() == "") after++;
                if (after < lines.Count)
                {
                    string at = lines[after].TrimStart();
                    if (Regex.IsMatch(at,
                        $@"^il2cpp_internal\({Regex.Escape(ptrVar)}\s*,", RegexOptions.IgnoreCase))
                        lines[after] = "";
                }
            }
            lines = lines.Where(ln => ln != "").ToList();
        }

        // ── Pass 3h: null-conditional simplification ─────────────────────────
        // After passes 2d and 3c, conditions like:
        //   (VAR != null) && (VAR = VAR.FIELD) != null
        // can be simplified to the C# null-conditional form:
        //   (VAR = VAR?.FIELD) != null
        // Similarly the "null or" form:
        //   (VAR == null) || (VAR = VAR.FIELD) == null  →  (VAR = VAR?.FIELD) == null
        // NOTE: the LHS guard may still use 0 instead of null (pass 4b runs later),
        // so we accept both.
        for (int i = 0; i < lines.Count; i++)
        {
            // && form: (VAR != null/0) && (VAR = VAR.FIELD) != null
            lines[i] = Regex.Replace(lines[i],
                @"\((\w+)\s*!=\s*(?:null|0)\)\s*&&\s*\(\1\s*=\s*\1(\.\w+)\)\s*!=\s*null",
                mo => $"({mo.Groups[1].Value} = {mo.Groups[1].Value}?{mo.Groups[2].Value}) != null");
            // || form: (VAR == null/0) || (VAR = VAR.FIELD) == null
            lines[i] = Regex.Replace(lines[i],
                @"\((\w+)\s*==\s*(?:null|0)\)\s*\|\|\s*\(\1\s*=\s*\1(\.\w+)\)\s*==\s*null",
                mo => $"({mo.Groups[1].Value} = {mo.Groups[1].Value}?{mo.Groups[2].Value}) == null");
        }

        // ── Pass 3h2: collapse preceding assignment into null-conditional ─────
        // After pass 3h, conditions are in the form  (VAR = VAR?.FIELD) op null.
        // When the immediately preceding line assigns  VAR = EXPR;  (EXPR doesn't
        // contain VAR), we can substitute EXPR for VAR in the null-conditional and
        // drop the assignment line:
        //   VAR = EXPR;
        //   if ((VAR = VAR?.FIELD) op null) ...
        // → if ((VAR = EXPR?.FIELD) op null) ...
        for (int i = 0; i < lines.Count; i++)
        {
            string trimmed = lines[i].TrimStart();
            var assignM = Regex.Match(trimmed, @"^(\w+)\s*=\s*(.+?)\s*;$");
            if (!assignM.Success) continue;

            string varName = assignM.Groups[1].Value;
            string expr = assignM.Groups[2].Value.Trim();

            // Skip if EXPR itself references VAR (circular / not safe to inline)
            if (Regex.IsMatch(expr, $@"\b{Regex.Escape(varName)}\b")) continue;

            // Find next non-blank line
            int next = i + 1;
            while (next < lines.Count && lines[next].Trim() == "") next++;
            if (next >= lines.Count) continue;

            // Only substitute if next line contains exactly the null-conditional pattern
            string nextLine = lines[next];
            string replaced = Regex.Replace(nextLine,
                $@"\({Regex.Escape(varName)}\s*=\s*{Regex.Escape(varName)}\?",
                $"({varName} = {expr}?");

            if (!ReferenceEquals(replaced, nextLine) && replaced != nextLine)
            {
                lines[next] = replaced;
                lines[i] = "";
            }
        }

        // ── Pass 3b2 / 3c2b: second-pass type inference after static fields resolved ──
        // After pass 3e resolves static field accesses (e.g. DAT_xxx → ClassName.fieldName),
        // scan for  VAR = ClassName.fieldName;  patterns across ALL game classes and re-run
        // pass 3c so the resolved variable names get their pointer dereferences simplified.
        {
            // Build cross-class className → (fieldName → baseType) lookup from registryTypes.
            var crossFieldTypes = new Dictionary<string, Dictionary<string, string>>(StringComparer.OrdinalIgnoreCase);

            foreach (var rt in registryTypes)
            {
                Dictionary<string, string>? fldMap = null;
                foreach (var mf in rt.Members.Where(f => f.MemberKind == "Field"))
                {
                    string bt = ExtractBaseTypeFromSignature(mf.Signature);
                    if (gameTypeNames.Contains(bt) &&
                        (typeOffsets.ContainsKey(bt) || staticTypeOffsets.ContainsKey(bt)))
                    {
                        fldMap ??= new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
                        fldMap.TryAdd(mf.Name, bt);
                    }
                }
                if (fldMap != null)
                    crossFieldTypes[rt.ClassName] = fldMap;
            }

            if (crossFieldTypes.Count > 0)
            {
                // Scan resolved lines for: VAR = ClassName.fieldName;
                var anyClassFieldRe = new Regex(
                    @"^(?:[\w\s\*]+\s+)?(\w+)\s*=\s*(\w+)\.(\w+)\s*;$",
                    RegexOptions.IgnoreCase);
                // Two-level chain (condition or statement form): VAR = ClassName.field1.field2
                var twoLevelChainRe = new Regex(
                    @"\b(\w+)\s*=\s*(\w+)\.(\w+)\.(\w+)\b",
                    RegexOptions.IgnoreCase);

                bool changed = false;
                foreach (var line in lines)
                {
                    string t2 = line.TrimStart();
                    var mo = anyClassFieldRe.Match(t2);
                    if (mo.Success)
                    {
                        string varN = mo.Groups[1].Value;
                        string clsN = mo.Groups[2].Value;
                        string fldN = mo.Groups[3].Value;
                        if (crossFieldTypes.TryGetValue(clsN, out var fldMap2) &&
                            fldMap2.TryGetValue(fldN, out string? bt2))
                        {
                            varTypeMap[varN] = bt2;
                            changed = true;
                        }
                    }
                    // Two-level: VAR = ClassName.field1.field2 → follow chain to infer VAR's type
                    foreach (Match tmo in twoLevelChainRe.Matches(line))
                    {
                        string varN = tmo.Groups[1].Value;
                        string cls1 = tmo.Groups[2].Value;
                        string fld1 = tmo.Groups[3].Value;
                        string fld2 = tmo.Groups[4].Value;
                        if (!crossFieldTypes.TryGetValue(cls1, out var map1)) continue;
                        if (!map1.TryGetValue(fld1, out string? cls2)) continue;
                        if (!crossFieldTypes.TryGetValue(cls2, out var map2)) continue;
                        if (!map2.TryGetValue(fld2, out string? bt2)) continue;
                        varTypeMap[varN] = bt2;
                        changed = true;
                    }
                }

                // Re-run pass 3c with the updated varTypeMap
                if (changed)
                {
                    for (int i = 0; i < lines.Count; i++)
                    {
                        lines[i] = Regex.Replace(lines[i],
                            @"\*\([^)]+\*\)\((\w+)\s*\+\s*(0x[0-9a-fA-F]+)\)",
                            mo2 =>
                            {
                                string vn = mo2.Groups[1].Value;
                                if (!varTypeMap.TryGetValue(vn, out string? tn)) return mo2.Value;
                                string offStr2 = mo2.Groups[2].Value.ToLower();
                                int off2;
                                try { off2 = Convert.ToInt32(offStr2, 16); } catch { return mo2.Value; }
                                if (!typeOffsets.TryGetValue(tn, out var offMap2)) return mo2.Value;
                                if (!offMap2.TryGetValue(off2, out string? fn2)) return mo2.Value;
                                return $"{vn}.{fn2}";
                            });
                    }

                    // Re-run 3h: null-conditional after new field names resolved
                    for (int i = 0; i < lines.Count; i++)
                    {
                        lines[i] = Regex.Replace(lines[i],
                            @"\((\w+)\s*!=\s*(?:null|0)\)\s*&&\s*\(\1\s*=\s*\1(\.\w+)\)\s*!=\s*null",
                            mo3 => $"({mo3.Groups[1].Value} = {mo3.Groups[1].Value}?{mo3.Groups[2].Value}) != null");
                        lines[i] = Regex.Replace(lines[i],
                            @"\((\w+)\s*==\s*(?:null|0)\)\s*\|\|\s*\(\1\s*=\s*\1(\.\w+)\)\s*==\s*null",
                            mo3 => $"({mo3.Groups[1].Value} = {mo3.Groups[1].Value}?{mo3.Groups[2].Value}) == null");
                    }

                    // Re-run 3h2: collapse preceding assignment into null-conditional
                    for (int i = 0; i < lines.Count; i++)
                    {
                        string trimmed2 = lines[i].TrimStart();
                        var assignM2 = Regex.Match(trimmed2, @"^(\w+)\s*=\s*(.+?)\s*;$");
                        if (!assignM2.Success) continue;
                        string varName2 = assignM2.Groups[1].Value;
                        string expr2 = assignM2.Groups[2].Value.Trim();
                        if (Regex.IsMatch(expr2, $@"\b{Regex.Escape(varName2)}\b")) continue;
                        int next2 = i + 1;
                        while (next2 < lines.Count && lines[next2].Trim() == "") next2++;
                        if (next2 >= lines.Count) continue;
                        string nextLine2 = lines[next2];
                        string replaced2 = Regex.Replace(nextLine2,
                            $@"\({Regex.Escape(varName2)}\s*=\s*{Regex.Escape(varName2)}\?",
                            $"({varName2} = {expr2}?");
                        if (!ReferenceEquals(replaced2, nextLine2) && replaced2 != nextLine2)
                        {
                            lines[next2] = replaced2;
                            lines[i] = "";
                        }
                    }
                }
            }
        }

        // After field simplification and thunk renaming, this pattern appears:
        //   varN = il2cpp_internal(DAT_XXX);
        //   ClassName__ctor(varN[, args]);
        //   self.field = varN;
        // → self.field = new ClassName([args]);
        //
        // Without field assignment:
        //   varN = il2cpp_internal(DAT_XXX);
        //   ClassName__ctor(varN[, args]);
        // → var varN = new ClassName([args]);
        {
            var p = new List<string>(lines.Count);
            int i = 0;
            while (i < lines.Count)
            {
                string t = lines[i].TrimStart();
                var allocM = Regex.Match(t, @"^(\w+) = il2cpp_internal\(DAT_[0-9a-fA-F]+\);$");
                if (allocM.Success)
                {
                    string varN = allocM.Groups[1].Value;
                    int indent = lines[i].Length - t.Length;

                    // Find next non-blank line
                    int j = i + 1;
                    while (j < lines.Count && string.IsNullOrWhiteSpace(lines[j])) j++;

                    if (j < lines.Count)
                    {
                        var ctorM = Regex.Match(lines[j].TrimStart(),
                            @"^(\w+)__\w+\(" + Regex.Escape(varN) + @"(?:,\s*(.+?))?\);$");
                        if (ctorM.Success)
                        {
                            string cls = ctorM.Groups[1].Value;
                            string args = ctorM.Groups[2].Success ? ctorM.Groups[2].Value : "";

                            // Find next non-blank after ctor
                            int k = j + 1;
                            while (k < lines.Count && string.IsNullOrWhiteSpace(lines[k])) k++;

                            if (k < lines.Count)
                            {
                                // Try: self.field = varN;
                                var assignM = Regex.Match(lines[k].TrimStart(),
                                    @"^(this\.\w+) = " + Regex.Escape(varN) + @";$");
                                if (assignM.Success)
                                {
                                    string newExpr = string.IsNullOrEmpty(args)
                                        ? $"{assignM.Groups[1].Value} = new {cls}();"
                                        : $"{assignM.Groups[1].Value} = new {cls}({args});";
                                    p.Add(new string(' ', indent) + newExpr);
                                    i = k + 1;
                                    continue;
                                }
                            }

                            // No field assignment — collapse to: var varN = new ClassName(args);
                            string decl = string.IsNullOrEmpty(args)
                                ? $"var {varN} = new {cls}();"
                                : $"var {varN} = new {cls}({args});";
                            p.Add(new string(' ', indent) + decl);
                            i = j + 1;
                            continue;
                        }
                    }
                }
                p.Add(lines[i]);
                i++;
            }
            lines = p;
        }

        // ── Pass 4 cleanup: remove redundant `var` prefix on pre-declared vars ──
        // Pass 4 generates `var X = new ...` which conflicts with the `type X;`
        // declaration that pass 2b emitted. Strip the `var ` prefix so the
        // assignment is just `X = new ...`.
        if (declaredVars.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                var m = Regex.Match(lines[i], @"^(\s*)var\s+(\w+)\s*=\s*");
                if (m.Success && declaredVars.Contains(m.Groups[2].Value))
                    lines[i] = m.Groups[1].Value + lines[i].TrimStart()[4..]; // remove "var "
            }
        }

        // ── Pass 4b: null-check cleanup ────────────────────────────────────
        // After field substitution (Pass 3) and new-object (Pass 4), comparisons
        // of named reference fields/pointers to 0 are always null checks.
        //
        // Handles:
        //   self.FIELD == 0   →  self.FIELD == null
        //   self.FIELD != 0   →  self.FIELD != null
        //   ClassName.field == 0  →  ClassName.field == null  (static or chained)
        //   lVarN == 0 / != 0 →  lVarN == null / != null   (lVar prefix = int64 ptr)
        //   varN == 0 / != 0  same, when assigned from a function call
        for (int i = 0; i < lines.Count; i++)
        {
            // self.field comparisons
            lines[i] = Regex.Replace(lines[i],
                @"(this\.\w+)\s*==\s*0\b", "$1 == null");
            lines[i] = Regex.Replace(lines[i],
                @"(this\.\w+)\s*!=\s*0\b", "$1 != null");
            // named parameter comparisons (reference-type params after rename)
            foreach (var pname in member.ParameterNames.Where(n => !string.IsNullOrEmpty(n)))
            {
                lines[i] = Regex.Replace(lines[i],
                    $@"\b({Regex.Escape(pname)})\s*==\s*0\b", "$1 == null");
                lines[i] = Regex.Replace(lines[i],
                    $@"\b({Regex.Escape(pname)})\s*!=\s*0\b", "$1 != null");
            }
            // Ghidra lVar* (int64 pointer locals) comparisons
            lines[i] = Regex.Replace(lines[i],
                @"\b(l[A-Za-z]+\d+)\s*==\s*0\b", "$1 == null");
            lines[i] = Regex.Replace(lines[i],
                @"\b(l[A-Za-z]+\d+)\s*!=\s*0\b", "$1 != null");
            // Dot-notation expressions: ClassName.field or ClassName.field.field (static / chain)
            lines[i] = Regex.Replace(lines[i],
                @"(\w+(?:\.\w+)+)\s*==\s*0\b", "$1 == null");
            lines[i] = Regex.Replace(lines[i],
                @"(\w+(?:\.\w+)+)\s*!=\s*0\b", "$1 != null");
            // Pointer dereference null check: if (*(int64*)(x) == 0) → keep raw (can't infer)
        }

        // ── Pass 4c: bool/char idioms ──────────────────────────────────────
        // Ghidra represents booleans as `char` (cVarN).
        //   == '\0'  →  == false
        //   != '\0'  →  (drop comparison, use value directly)
        //   '\0'     →  false  (standalone, e.g. in return)
        //   '\x01'   →  true
        //   return 0 / return 1 in bool-returning methods  →  return false / true
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = lines[i].Replace("== '\\0'", "== false");
            lines[i] = lines[i].Replace("!= '\\0'", "!= false");
            lines[i] = lines[i].Replace("'\\0'", "false");
            lines[i] = lines[i].Replace("'\\x01'", "true");
        }

        bool isBoolReturn = Regex.IsMatch(member.Signature, @"\bbool\b");
        if (isBoolReturn)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                if (lines[i].TrimStart() == "return 0;")
                    lines[i] = new string(' ', lines[i].Length - lines[i].TrimStart().Length) + "return false;";
                else if (lines[i].TrimStart() == "return 1;")
                    lines[i] = new string(' ', lines[i].Length - lines[i].TrimStart().Length) + "return true;";
            }
        }

        // ── Pass 4d: bool literal comparison cleanup ──────────────────────
        // C# code never needs `== false` or `== true` — simplify to `!X` / `X`.
        //   X == false  →  !X
        //   X != false  →  X
        //   X == true   →  X
        //   X != true   →  !X
        // Only applied when X is an identifier, dotted path, or simple () expression
        // (not already a comparison).
        for (int i = 0; i < lines.Count; i++)
        {
            // == false → !X  (but not !=, and not inside a string)
            lines[i] = Regex.Replace(lines[i],
                @"((?:[\w]+\.)*[\w]+)\s*==\s*false\b",
                mo => $"!{mo.Groups[1].Value}");
            // != false → X
            lines[i] = Regex.Replace(lines[i],
                @"((?:[\w]+\.)*[\w]+)\s*!=\s*false\b",
                mo => mo.Groups[1].Value);
            // == true → X
            lines[i] = Regex.Replace(lines[i],
                @"((?:[\w]+\.)*[\w]+)\s*==\s*true\b",
                mo => mo.Groups[1].Value);
            // != true → !X
            lines[i] = Regex.Replace(lines[i],
                @"((?:[\w]+\.)*[\w]+)\s*!=\s*true\b",
                mo => $"!{mo.Groups[1].Value}");
        }

        // ── Pass 4e: small hex literals → decimal ─────────────────────────
        // Hex constants ≤ 0xFF in comparisons and assignments are almost always
        // platform enum values, loop bounds, or small integers — decimal is more
        // readable. Larger values (addresses, float bit-patterns, etc.) are left.
        for (int i = 0; i < lines.Count; i++)
        {
            lines[i] = Regex.Replace(lines[i],
                @"\b0x([0-9a-fA-F]{1,2})\b",
                mo =>
                {
                    int v = Convert.ToInt32(mo.Value, 16);
                    return v.ToString();
                });
        }

        // ── Pass 4f: IL2CPP List/array indexed access ─────────────────────
        // IL2CPP inlines List<T>[i] as a direct pointer walk through the backing array:
        //   *(type*)(*(int64*)(LIST + 16) + 32 + (int64)(int)IDX * STRIDE)
        // where:
        //   LIST + 16   = List._items  (backing T[] pointer, offset 0x10)
        //   + 32        = skip Il2CppArray header (16-byte Il2CppObject + bounds 8 + length 8)
        //   + IDX*STRIDE = element index; stride: 1(byte) 2(short) 4(int/float) 8(ref/long) 12(Vector3) 16(Vector4)
        // Also handles direct array-pointer forms (when _items already in a local).
        for (int i = 0; i < lines.Count; i++)
        {
            // List<T>[idx] via _items pointer — all element strides
            foreach (int stride in new[] { 8, 4, 16, 12, 2, 1 })
            {
                lines[i] = Regex.Replace(lines[i],
                    $@"\*\([^)]+\*\)\(\*\(int64 \*\)\((\w[\w.]*) \+ 16\) \+ 32 \+ \(int64\)\(int\)(\w+) \* {stride}\)",
                    "$1[$2]");
            }

            // Direct array pointer[idx] (when _items is already dereffed into a local)
            foreach (int stride in new[] { 8, 4, 16, 12, 2, 1 })
            {
                lines[i] = Regex.Replace(lines[i],
                    $@"\*\([^)]+\*\)\((\w[\w.]*) \+ 32 \+ \(int64\)\(int\)(\w+) \* {stride}\)",
                    "$1[$2]");
            }
        }

        // ── Pass 4g: re-run field resolution with decimal offsets ──────────────
        // After pass 4e converted small hex literals to decimal, *(T*)(var + N)
        // patterns that had hex offsets (0x10→16, 0x18→24, etc.) are now decimal
        // and can be resolved against varTypeMap / selfFieldTypes.
        // This handles BCL types (List._items at +16, List.Count at +24) and any
        // game-type fields that were not caught by the earlier hex-only passes.
        if (varTypeMap.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                // *(T*)(var + N)  →  var.fieldName
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\((\w+)\s*\+\s*(\d+)\)",
                    mo =>
                    {
                        string varName = mo.Groups[1].Value;
                        if (!varTypeMap.TryGetValue(varName, out string? typeName)) return mo.Value;
                        if (!int.TryParse(mo.Groups[2].Value, out int offset)) return mo.Value;
                        if (!typeOffsets.TryGetValue(typeName, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? fieldName)) return mo.Value;
                        return $"{varName}.{fieldName}";
                    });
            }
        }
        if (selfFieldTypes.Count > 0)
        {
            for (int i = 0; i < lines.Count; i++)
            {
                // *(T*)(this.FIELD + N)  →  this.FIELD.subField
                lines[i] = Regex.Replace(lines[i],
                    @"\*\([^)]+\*\)\(this\.(\w+)\s*\+\s*(\d+)\)",
                    mo =>
                    {
                        string fieldRef = mo.Groups[1].Value;
                        if (!selfFieldTypes.TryGetValue(fieldRef, out string? typeName)) return mo.Value;
                        if (!int.TryParse(mo.Groups[2].Value, out int offset)) return mo.Value;
                        if (!typeOffsets.TryGetValue(typeName, out var offMap)) return mo.Value;
                        if (!offMap.TryGetValue(offset, out string? subField)) return mo.Value;
                        return $"this.{fieldRef}.{subField}";
                    });
            }
        }

        // ── Pass 5: single-line /* comment */ → // comment ─────────────────
        for (int i = 0; i < lines.Count; i++)
            lines[i] = Regex.Replace(lines[i], @"/\*\s*(.*?)\s*\*/", "// $1");

        // ── Pass 5b: resolve goto-to-error-handler patterns ────────────────
        // Ghidra emits every early-exit as `goto LAB_XXXX` where the label
        // leads to a non-returning error handler (null/range check failure).
        // Pattern:
        //   LAB_XXXX:
        //     // WARNING: Subroutine does not return
        //     FUN_XXXXXXXX();          ← the error thrower
        //
        // We:
        //   • replace `goto LAB_XXXX;` → `throw; // [error handler]`
        //   • remove the label block itself (dead code after the rewrite)
        {
            // Step 1: identify which labels are pure error handlers
            var errorLabels = new HashSet<string>();
            for (int i = 0; i < lines.Count; i++)
            {
                var lm = Regex.Match(lines[i].TrimStart(), @"^(LAB_[0-9a-fA-F]+):$");
                if (!lm.Success) continue;
                string label = lm.Groups[1].Value;
                int j = i + 1;
                bool hasCall = false, hasOther = false;
                while (j < lines.Count)
                {
                    string inner = lines[j].TrimStart();
                    if (inner == "" || inner.StartsWith("// WARNING:")) { j++; continue; }
                    if (!hasCall && Regex.IsMatch(inner, @"^FUN_[0-9a-fA-F]+\(.*\);$"))
                    { hasCall = true; j++; continue; }
                    hasOther = true; break;
                }
                if (hasCall && !hasOther)
                    errorLabels.Add(label);
            }

            if (errorLabels.Count > 0)
            {
                // Step 2: rewrite gotos and strip label blocks
                var p = new List<string>(lines.Count);
                int i = 0;
                while (i < lines.Count)
                {
                    string t = lines[i].TrimStart();
                    int indent = lines[i].Length - t.Length;

                    // Full-line: goto LAB_XXXX; → throw;
                    var gm = Regex.Match(t, @"^goto (LAB_[0-9a-fA-F]+);$");
                    if (gm.Success && errorLabels.Contains(gm.Groups[1].Value))
                    {
                        p.Add(new string(' ', indent) + "throw; // [null/range check failed]");
                        i++; continue;
                    }

                    // Inline: if (cond) goto LAB_XXXX; → if (cond) throw;
                    string replaced = Regex.Replace(lines[i],
                        @"\bgoto (LAB_[0-9a-fA-F]+);",
                        m => errorLabels.Contains(m.Groups[1].Value)
                             ? "throw; // [null/range check failed]"
                             : m.Value);
                    if (replaced != lines[i]) { p.Add(replaced); i++; continue; }

                    // LAB_XXXX: ... FUN_() → drop the whole block
                    var lm = Regex.Match(t, @"^(LAB_[0-9a-fA-F]+):$");
                    if (lm.Success && errorLabels.Contains(lm.Groups[1].Value))
                    {
                        i++;
                        while (i < lines.Count)
                        {
                            string inner = lines[i].TrimStart();
                            if (inner == "" || inner.StartsWith("// WARNING:") ||
                                Regex.IsMatch(inner, @"^FUN_[0-9a-fA-F]+\("))
                            { i++; continue; }
                            break;
                        }
                        continue;
                    }

                    p.Add(lines[i]);
                    i++;
                }
                lines = p;
            }

            // Also strip fall-through error handlers at end of function body:
            //   // WARNING: Subroutine does not return
            //   FUN_XXXXXXXX();
            // These appear when all paths through a loop body throw (no label needed).
            while (lines.Count >= 2)
            {
                int last = lines.Count - 1;
                // Skip trailing blanks to find the last real line
                int callIdx = last;
                while (callIdx >= 0 && string.IsNullOrWhiteSpace(lines[callIdx])) callIdx--;
                if (callIdx < 0) break;
                if (!Regex.IsMatch(lines[callIdx].TrimStart(), @"^FUN_[0-9a-fA-F]+\(.*\);$")) break;
                int warnIdx = callIdx - 1;
                while (warnIdx >= 0 && string.IsNullOrWhiteSpace(lines[warnIdx])) warnIdx--;
                if (warnIdx >= 0 && lines[warnIdx].TrimStart().StartsWith("// WARNING:"))
                {
                    lines.RemoveRange(warnIdx, lines.Count - warnIdx);
                }
                else break;
            }
        }

        // ── Pass 5c: restructure remaining forward gotos ──────────────────────
        // After error-handler gotos (pass 5b), handle structural gotos:
        //   1. If-skip:  if (cond) goto LAB_X; ..small block..; LAB_X:
        //              → if (!cond) { ..block.. }
        //   2. No-op:   goto LAB_X; LAB_X:  → remove both
        //   3. Orphaned LAB_ label lines with no remaining goto source → strip
        {
            // Count remaining goto references per label
            var remaining = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            foreach (var line in lines)
            {
                var gm = Regex.Match(line.TrimStart(), @"\bgoto (LAB_[0-9a-fA-F]+)\b");
                if (gm.Success)
                    remaining[gm.Groups[1].Value] = remaining.GetValueOrDefault(gm.Groups[1].Value) + 1;
            }

            if (remaining.Count > 0)
            {
                var p = new List<string>(lines.Count);
                int i = 0;
                while (i < lines.Count)
                {
                    string t = lines[i].TrimStart();
                    int baseIndent = lines[i].Length - t.Length;

                    // Pattern: if (cond) goto LAB_X;
                    var ifGoto = Regex.Match(t, @"^if \((.+)\) goto (LAB_[0-9a-fA-F]+);$");
                    if (ifGoto.Success)
                    {
                        string condStr = ifGoto.Groups[1].Value;
                        string lbl = ifGoto.Groups[2].Value;

                        if (remaining.GetValueOrDefault(lbl) == 1)
                        {
                            // Find label forward within 12 lines
                            int labelIdx = -1;
                            for (int j = i + 1; j < lines.Count && j <= i + 12; j++)
                                if (lines[j].TrimStart() == $"{lbl}:") { labelIdx = j; break; }

                            if (labelIdx > 0)
                            {
                                var body = lines.GetRange(i + 1, labelIdx - i - 1);
                                bool bodyClean = body.All(bl =>
                                    !Regex.IsMatch(bl.TrimStart(), @"^LAB_[0-9a-fA-F]+:") &&
                                    !Regex.IsMatch(bl.TrimStart(), @"^goto "));

                                if (bodyClean && body.Count <= 8)
                                {
                                    string invCond = InvertCondition(condStr);
                                    p.Add(new string(' ', baseIndent) + $"if ({invCond})");
                                    p.Add(new string(' ', baseIndent) + "{");
                                    foreach (var bl in body)
                                        p.Add(string.IsNullOrWhiteSpace(bl) ? ""
                                            : new string(' ', baseIndent + 2) + bl.TrimStart());
                                    p.Add(new string(' ', baseIndent) + "}");
                                    i = labelIdx + 1;
                                    continue;
                                }
                            }
                        }
                    }

                    // Pattern: unconditional goto immediately before its label
                    var unconditional = Regex.Match(t, @"^goto (LAB_[0-9a-fA-F]+);$");
                    if (unconditional.Success)
                    {
                        string lbl = unconditional.Groups[1].Value;
                        int j = i + 1;
                        while (j < lines.Count && string.IsNullOrWhiteSpace(lines[j])) j++;
                        if (j < lines.Count && lines[j].TrimStart() == $"{lbl}:")
                        { i = j + 1; continue; } // skip goto + label
                    }

                    p.Add(lines[i]);
                    i++;
                }
                lines = p;
            }

            // Strip any LAB_ labels that now have no goto references
            var stillReferenced = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
            foreach (var line in lines)
            {
                var gm = Regex.Match(line.TrimStart(), @"\bgoto (LAB_[0-9a-fA-F]+)\b");
                if (gm.Success) stillReferenced.Add(gm.Groups[1].Value);
            }
            lines = lines
                .Where(l =>
                {
                    var lm = Regex.Match(l.TrimStart(), @"^(LAB_[0-9a-fA-F]+):$");
                    return !lm.Success || stillReferenced.Contains(lm.Groups[1].Value);
                })
                .ToList();
        }

        // ── Pass 5d: ClassName__MethodName → ClassName.MethodName ────────────
        // Labels were written as Class__Method for Ghidra compatibility; rewrite
        // them to dot notation in the final pseudocode for readability.
        for (int i = 0; i < lines.Count; i++)
            lines[i] = Regex.Replace(lines[i],
                @"\b([A-Za-z_][A-Za-z0-9_]*)__([A-Za-z_][A-Za-z0-9_]*)\b",
                "$1.$2");

        // ── Pass 6: remove trailing `return;` (implicit) ───────────────────
        while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[lines.Count - 1]))
            lines.RemoveAt(lines.Count - 1);
        if (lines.Count > 0 && lines[lines.Count - 1].TrimStart() == "return;")
            lines.RemoveAt(lines.Count - 1);

        // ── Pass 7: collapse consecutive blank lines; trim trailing ────────
        var result = new List<string>(lines.Count);
        bool lastBlank = false;
        foreach (var line in lines)
        {
            bool blank = string.IsNullOrWhiteSpace(line);
            if (blank && lastBlank) continue;
            result.Add(blank ? "" : line);
            lastBlank = blank;
        }
        while (result.Count > 0 && string.IsNullOrWhiteSpace(result[result.Count - 1]))
            result.RemoveAt(result.Count - 1);

        return result.ToArray();
    }

    /// <summary>
    /// Formats a raw string literal value as a C# verbatim string for display.
    /// Short single-line strings use regular quotes; multiline or long strings
    /// use @"..." verbatim syntax.
    /// </summary>
    /// <summary>Inverts a simple comparison condition for goto-if-skip restructuring.</summary>
    private static string InvertCondition(string cond)
    {
        if (cond.Contains("&&") || cond.Contains("||")) return $"!({cond})";
        if (cond.Contains(" == ")) return cond.Replace(" == ", " != ");
        if (cond.Contains(" != ")) return cond.Replace(" != ", " == ");
        if (cond.Contains(" <= ")) return cond.Replace(" <= ", " > ");
        if (cond.Contains(" >= ")) return cond.Replace(" >= ", " < ");
        if (cond.Contains(" < ")) return cond.Replace(" < ", " >= ");
        if (cond.Contains(" > ")) return cond.Replace(" > ", " <= ");
        return $"!({cond})";
    }

    /// <summary>
    /// Returns the index of the last space character at nesting depth 0
    /// (i.e., outside angle brackets). Used to split generic type signatures.
    /// </summary>
    private static int FindLastTopLevelSpace(string s)
    {
        int depth = 0, lastSpace = -1;
        for (int k = 0; k < s.Length; k++)
        {
            char c = s[k];
            if (c == '<') depth++;
            else if (c == '>') depth--;
            else if (c == ' ' && depth == 0) lastSpace = k;
        }
        return lastSpace;
    }

    private static readonly HashSet<string> _fieldModifiers = new(StringComparer.Ordinal)
        { "public", "private", "protected", "internal", "static", "readonly", "const", "volatile" };

    /// <summary>
    /// Extracts the base type name from a field signature that may include access/modifier words.
    /// e.g. "private static List&lt;Task&gt; Tasks" → "List"
    ///      "public int count"                     → "int"
    /// </summary>
    private static string ExtractBaseTypeFromSignature(string sig)
    {
        int lastSp = FindLastTopLevelSpace(sig);
        if (lastSp <= 0) return sig; // no space — degenerate
        string typePart = sig[..lastSp]; // everything before the field name
        // Strip leading modifier words (public, private, static, etc.)
        while (true)
        {
            typePart = typePart.TrimStart();
            int sp = typePart.IndexOf(' ');
            if (sp < 0) break;
            string word = typePart[..sp];
            if (_fieldModifiers.Contains(word))
                typePart = typePart[(sp + 1)..];
            else
                break;
        }
        // Strip generic suffix to get base type name
        int tick = typePart.IndexOf('<');
        return tick >= 0 ? typePart[..tick] : typePart;
    }

    private static string FormatStringLiteral(string s)
    {
        if (s.Length == 0) return "\"\"";
        // Always use regular quoted string with escape sequences — keeps output single-line.
        return "\"" + s
            .Replace("\\", "\\\\")
            .Replace("\"", "\\\"")
            .Replace("\r\n", "\\n")
            .Replace("\r", "\\n")
            .Replace("\n", "\\n")
            .Replace("\t", "\\t")
            .Replace("\0", "\\0")
            + "\"";
    }

    /// <summary>
    /// Strips the Ghidra-generated header comment, the C function signature,
    /// and the outer { } of the function body, then de-indents the body by 2
    /// spaces (Ghidra's default indentation for the function body).
    /// </summary>
    private static List<string> StripGhidraWrapper(string[] lines)
    {
        int i = 0;

        // Skip: // Type  : ..., // Member: ..., // RVA   : ...,
        //       // ─────────... separator, and surrounding blank lines
        while (i < lines.Length)
        {
            string t = lines[i].TrimStart();
            if (string.IsNullOrWhiteSpace(lines[i]) ||
                Regex.IsMatch(t, @"^// (Type|Member|RVA)\s*:") ||
                Regex.IsMatch(t, @"^// (.)\1{2,}$"))   // e.g. // ──────── or // ===
            { i++; continue; }
            break;
        }

        // Skip any /* WARNING: ... */ block-comment lines that appear before the signature
        // (Ghidra emits these before the function header when it removes unreachable blocks)
        while (i < lines.Length)
        {
            string t = lines[i].TrimStart();
            if (string.IsNullOrWhiteSpace(lines[i]) ||
                Regex.IsMatch(t, @"^/\* WARNING:"))
            { i++; continue; }
            break;
        }

        // Skip the C function signature line: has ClassName__MethodName( pattern
        if (i < lines.Length &&
            Regex.IsMatch(lines[i].TrimStart(), @"^\w[\w\s\*]*\s+\w+__\w+\s*\("))
            i++;

        // Skip blank lines before opening brace
        while (i < lines.Length && string.IsNullOrWhiteSpace(lines[i])) i++;

        // Skip the opening { on its own line
        if (i < lines.Length && lines[i].Trim() == "{") i++;

        // Find the closing } — last non-blank line of the function
        int end = lines.Length - 1;
        while (end > i && string.IsNullOrWhiteSpace(lines[end])) end--;
        if (end >= i && lines[end].Trim() == "}") end--;

        // Collect body, removing the 2-space indent Ghidra adds to every body line
        var result = new List<string>(Math.Max(0, end - i + 1));
        for (int j = i; j <= end; j++)
        {
            string line = lines[j];
            if (line.Length >= 2 && line[0] == ' ' && line[1] == ' ')
                line = line[2..];
            result.Add(line);
        }
        return result;
    }
}
