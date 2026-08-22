namespace Il2CppExplorer.Models;

public class TypeInfo
{
    public string Namespace { get; set; } = "";
    public string ClassName { get; set; } = "";

    /// <summary>Dot-separated full name (Namespace.ClassName or just ClassName if no namespace).</summary>
    public string FullName => string.IsNullOrEmpty(Namespace) ? ClassName : $"{Namespace}.{ClassName}";

    /// <summary>IL token from [Cpp2ILInjected.Token]</summary>
    public string Token { get; set; } = "";

    public List<MemberInfo> Members { get; set; } = new();

    /// <summary>Absolute path where the summary .cs file will be written.</summary>
    public string? SummaryOutputPath { get; set; }

    /// <summary>
    /// Maps field name → byte offset from the start of the IL2CPP object.
    /// Computed from the C# field layout (IL2CPP object header = 16 bytes on x64).
    /// </summary>
    public Dictionary<string, int> FieldOffsets { get; set; } = new();

    /// <summary>
    /// Maps static field name → byte offset within the IL2CPP statics struct
    /// (no object header; starts at 0).
    /// </summary>
    public Dictionary<string, int> StaticFieldOffsets { get; set; } = new();
}
