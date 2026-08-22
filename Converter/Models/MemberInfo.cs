namespace Il2CppExplorer.Models;

public class MemberInfo
{
    /// <summary>Method/field/property name as it appears in the C# dump.</summary>
    public string Name { get; set; } = "";

    /// <summary>One of: Method, Constructor, Field, Property, Event</summary>
    public string MemberKind { get; set; } = "Method";

    /// <summary>IL token from [Cpp2ILInjected.Token]</summary>
    public string Token { get; set; } = "";

    /// <summary>Address info from [Cpp2ILInjected.Address]; null if not present (e.g. fields).</summary>
    public AddressInfo? Address { get; set; }

    /// <summary>Full method signature string for the summary file.</summary>
    public string Signature { get; set; } = "";

    /// <summary>Absolute path where the decompiled .c file will be written.</summary>
    public string? DecompiledOutputPath { get; set; }

    /// <summary>Whether the method is static (affects Ghidra param_1 = this vs param_1 = first arg).</summary>
    public bool IsStatic { get; set; }

    /// <summary>Ordered parameter names from the C# signature, used to rename Ghidra param_N.</summary>
    public List<string> ParameterNames { get; set; } = new();
}
