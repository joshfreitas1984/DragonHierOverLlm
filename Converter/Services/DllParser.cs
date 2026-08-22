using Il2CppExplorer.Models;
using Mono.Cecil;

namespace Il2CppExplorer.Services;

/// <summary>
/// Parses a dummy Assembly-CSharp.dll produced by Cpp2IL / Il2CppDumper.
/// Reads [Cpp2ILInjected.Token] and [Cpp2ILInjected.Address] attributes
/// to build the list of types and their members with native addresses.
/// </summary>
public class DllParser
{
    private const string AddressAttrName = "AddressAttribute";
    private const string TokenAttrName = "TokenAttribute";
    private const string InjectedNs = "Cpp2ILInjected";

    /// <summary>
    /// Prints the raw custom attributes found on the first few types and methods.
    /// Use to diagnose attribute namespace/name mismatches.
    /// </summary>
    public void RunDiagnostic(string dllPath)
    {
        var readerParams = new ReaderParameters { ReadSymbols = false };
        using var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);

        Console.WriteLine($"  Assembly: {assembly.FullName}");
        int typesChecked = 0;
        foreach (var module in assembly.Modules)
        {
            foreach (var type in module.Types)
            {
                if (typesChecked++ >= 5) break;
                Console.WriteLine($"\n  TYPE: {type.FullName}");
                foreach (var a in type.CustomAttributes)
                    Console.WriteLine($"    [attr] ns='{a.AttributeType.Namespace}' name='{a.AttributeType.Name}'  props={a.Properties.Count}  fields={a.Fields.Count}  ctorArgs={a.ConstructorArguments.Count}");

                int methodsChecked = 0;
                foreach (var method in type.Methods)
                {
                    if (methodsChecked++ >= 3) break;
                    if (method.CustomAttributes.Count == 0) continue;
                    Console.WriteLine($"    METHOD: {method.Name}");
                    foreach (var a in method.CustomAttributes)
                    {
                        Console.WriteLine($"      [attr] ns='{a.AttributeType.Namespace}' name='{a.AttributeType.Name}'  props={a.Properties.Count}  fields={a.Fields.Count}  ctorArgs={a.ConstructorArguments.Count}");
                        foreach (var p in a.Properties)
                            Console.WriteLine($"        prop  {p.Name} = '{p.Argument.Value}'");
                        foreach (var f in a.Fields)
                            Console.WriteLine($"        field {f.Name} = '{f.Argument.Value}'");
                        foreach (var c in a.ConstructorArguments)
                            Console.WriteLine($"        ctor  ({c.Type.Name}) '{c.Value}'");
                    }
                }
            }
        }
    }

    /// <summary>Parses all types without any filtering — used for generating the Ghidra labels file.</summary>
    public List<TypeInfo> ParseAll(string dllPath)
    {
        var readerParams = new ReaderParameters { ReadSymbols = false };
        using var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);
        var result = new List<TypeInfo>();
        foreach (var module in assembly.Modules)
            foreach (var type in module.Types)
                CollectType(type, result, "", noNamespaceOnly: false);
        return result;
    }

    public List<TypeInfo> Parse(string dllPath, string typeFilter = "", bool noNamespaceOnly = true)
    {
        var readerParams = new ReaderParameters { ReadSymbols = false };
        using var assembly = AssemblyDefinition.ReadAssembly(dllPath, readerParams);

        var result = new List<TypeInfo>();
        foreach (var module in assembly.Modules)
        {
            foreach (var type in module.Types)
                CollectType(type, result, typeFilter, noNamespaceOnly);
        }

        Console.WriteLine($"  Parsed {result.Count} types, " +
                          $"{result.Sum(t => t.Members.Count)} total members, " +
                          $"{result.Sum(t => t.Members.Count(m => m.Address != null))} with addresses.");
        return result;
    }

    // ── Recursion (handles nested types) ─────────────────────────────────────

    private static void CollectType(TypeDefinition typeDef, List<TypeInfo> result, string filter, bool noNamespaceOnly = true)
    {
        var typeInfo = new TypeInfo
        {
            Namespace = typeDef.Namespace ?? "",
            ClassName = typeDef.Name,
            Token = ReadToken(typeDef.CustomAttributes),
            FieldOffsets = ComputeFieldOffsets(typeDef),
            StaticFieldOffsets = ComputeStaticFieldOffsets(typeDef),
        };

        // Methods (includes constructors, property accessors, event handlers)
        foreach (var method in typeDef.Methods)
        {
            var member = new MemberInfo
            {
                Name = method.Name,
                MemberKind = method.IsConstructor ? "Constructor" : "Method",
                Token = ReadToken(method.CustomAttributes),
                Address = ReadAddress(method.CustomAttributes),
                Signature = BuildMethodSignature(method),
                IsStatic = method.IsStatic,
                ParameterNames = method.Parameters.Select(p => p.Name).ToList(),
            };
            typeInfo.Members.Add(member);
        }

        // Fields (no native address, included in summary only)
        foreach (var field in typeDef.Fields)
        {
            var fa = field.Attributes;
            string access = (fa & Mono.Cecil.FieldAttributes.FieldAccessMask) switch
            {
                Mono.Cecil.FieldAttributes.Public => "public",
                Mono.Cecil.FieldAttributes.Family => "protected",
                Mono.Cecil.FieldAttributes.Assembly => "internal",
                Mono.Cecil.FieldAttributes.Private => "private",
                _ => "private",
            };
            string staticMod = field.IsStatic && !field.IsLiteral ? " static" : "";
            string constMod = field.IsLiteral ? " const" : "";
            string readonlyMod = field.IsInitOnly ? " readonly" : "";
            typeInfo.Members.Add(new MemberInfo
            {
                Name = field.Name,
                MemberKind = "Field",
                Token = ReadToken(field.CustomAttributes),
                Signature = $"{access}{staticMod}{constMod}{readonlyMod} {FormatTypeRef(field.FieldType)} {field.Name}",
            });
        }

        bool passesNsFilter = !noNamespaceOnly || string.IsNullOrEmpty(typeInfo.Namespace);
        bool passesFilter = string.IsNullOrEmpty(filter) ||
                            typeInfo.FullName.Contains(filter, StringComparison.OrdinalIgnoreCase);

        if (passesNsFilter && passesFilter)
            result.Add(typeInfo);

        foreach (var nested in typeDef.NestedTypes)
            CollectType(nested, result, filter, noNamespaceOnly);
    }

    // ── IL2CPP field layout ───────────────────────────────────────

    /// <summary>
    /// Computes the byte offset of each instance field inside the IL2CPP object.
    /// x64 layout: 0x0 = klass* (8), 0x8 = monitor* (8), 0x10 = first field.
    /// Fields are aligned to their natural alignment (max 8).
    /// Reference types and unknown types are treated as 8-byte pointers.
    /// </summary>
    private static Dictionary<string, int> ComputeFieldOffsets(TypeDefinition typeDef)
    {
        var offsets = new Dictionary<string, int>();
        int offset = 16; // IL2CPP object header on 64-bit
        foreach (var field in typeDef.Fields)
        {
            if (field.IsStatic) continue;
            var (size, align) = GetFieldTypeLayout(field.FieldType);
            // Align to natural boundary
            offset = (offset + align - 1) & ~(align - 1);
            offsets[field.Name] = offset;
            offset += size;
        }
        return offsets;
    }

    /// <summary>
    /// Computes the byte offset of each static field within the IL2CPP statics struct.
    /// The statics struct has no object header, so the first field starts at offset 0.
    /// </summary>
    private static Dictionary<string, int> ComputeStaticFieldOffsets(TypeDefinition typeDef)
    {
        var offsets = new Dictionary<string, int>();
        int offset = 0; // statics struct — no object header
        foreach (var field in typeDef.Fields)
        {
            if (!field.IsStatic) continue;
            var (size, align) = GetFieldTypeLayout(field.FieldType);
            offset = (offset + align - 1) & ~(align - 1);
            offsets[field.Name] = offset;
            offset += size;
        }
        return offsets;
    }

    private static (int size, int align) GetFieldTypeLayout(TypeReference t)
    {
        return t.FullName switch
        {
            "System.Boolean" or "System.Byte" or "System.SByte" => (1, 1),
            "System.Int16" or "System.UInt16" or "System.Char" => (2, 2),
            "System.Int32" or "System.UInt32" or "System.Single" => (4, 4),
            "System.Int64" or "System.UInt64" or "System.Double"
                or "System.IntPtr" or "System.UIntPtr" => (8, 8),
            _ => (8, 8), // reference type pointer or unknown value type
        };
    }

    // ── Attribute readers ────────────────────────────────────────────────────

    private static string ReadToken(IEnumerable<CustomAttribute> attrs)
    {
        var attr = FindAttr(attrs, TokenAttrName);
        if (attr == null) return "";
        return GetNamedArg(attr, "Token") ?? "";
    }

    private static AddressInfo? ReadAddress(IEnumerable<CustomAttribute> attrs)
    {
        var attr = FindAttr(attrs, AddressAttrName);
        if (attr == null) return null;

        var rva = GetNamedArg(attr, "RVA");
        var offset = GetNamedArg(attr, "Offset") ?? "0x0";
        var length = GetNamedArg(attr, "Length") ?? "0x0";

        return rva != null ? new AddressInfo(rva, offset, length) : null;
    }

    private static CustomAttribute? FindAttr(IEnumerable<CustomAttribute> attrs, string attrSimpleName)
        => attrs.FirstOrDefault(a =>
               a.AttributeType.Namespace == InjectedNs &&
               a.AttributeType.Name == attrSimpleName);

    private static string? GetNamedArg(CustomAttribute attr, string name)
    {
        // Named properties (most common in Cpp2IL output)
        foreach (var prop in attr.Properties)
            if (prop.Name == name)
                return prop.Argument.Value?.ToString();

        // Named fields (less common but possible)
        foreach (var field in attr.Fields)
            if (field.Name == name)
                return field.Argument.Value?.ToString();

        return null;
    }

    // ── Signature builder ────────────────────────────────────────────────────

    private static string BuildMethodSignature(MethodDefinition method)
    {
        var sb = new System.Text.StringBuilder();

        if (method.IsPublic) sb.Append("public ");
        else if (method.IsFamily) sb.Append("protected ");
        else if (method.IsAssembly) sb.Append("internal ");
        else if (method.IsPrivate) sb.Append("private ");

        if (method.IsStatic) sb.Append("static ");
        if (method.IsVirtual && !method.IsNewSlot) sb.Append("override ");
        else if (method.IsVirtual) sb.Append("virtual ");

        sb.Append(FormatTypeRef(method.ReturnType));
        sb.Append(' ');
        sb.Append(method.Name);
        if (method.HasGenericParameters)
        {
            sb.Append('<');
            sb.Append(string.Join(", ", method.GenericParameters.Select(p => p.Name)));
            sb.Append('>');
        }
        sb.Append('(');
        sb.Append(string.Join(", ", method.Parameters.Select(p => $"{FormatTypeRef(p.ParameterType)} {p.Name}")));
        sb.Append(')');

        return sb.ToString();
    }

    /// <summary>
    /// Converts a Mono.Cecil TypeReference to a readable C# type name,
    /// correctly expanding generic instantiations (e.g. List`1<TaskData>)
    /// and mapping IL primitive names to C# keywords.
    /// </summary>
    internal static string FormatTypeRef(TypeReference t)
    {
        if (t is GenericInstanceType git)
        {
            string baseName = git.ElementType.Name;
            int tick = baseName.IndexOf('`');
            if (tick >= 0) baseName = baseName[..tick];
            string args = string.Join(", ", git.GenericArguments.Select(FormatTypeRef));
            return $"{baseName}<{args}>";
        }
        if (t is ArrayType at)
            return $"{FormatTypeRef(at.ElementType)}[]";
        if (t is ByReferenceType brt)
            return $"ref {FormatTypeRef(brt.ElementType)}";
        return t.Name switch
        {
            "Void" => "void",
            "Boolean" => "bool",
            "Byte" => "byte",
            "SByte" => "sbyte",
            "Int16" => "short",
            "UInt16" => "ushort",
            "Int32" => "int",
            "UInt32" => "uint",
            "Int64" => "long",
            "UInt64" => "ulong",
            "Single" => "float",
            "Double" => "double",
            "Char" => "char",
            "String" => "string",
            "Object" => "object",
            _ => t.Name,
        };
    }
}
