namespace Il2CppExplorer.Models;

/// <summary>
/// Holds the address attributes from [Cpp2ILInjected.Address(RVA = "...", Offset = "...", Length = "...")]
/// </summary>
public record AddressInfo(string RVA, string Offset, string Length)
{
    /// <summary>RVA as a long (strips "0x" prefix).</summary>
    public long RVAValue => Convert.ToInt64(RVA, 16);

    /// <summary>File offset as a long (strips "0x" prefix).</summary>
    public long OffsetValue => Convert.ToInt64(Offset, 16);

    /// <summary>Function length in bytes.</summary>
    public long LengthValue => Convert.ToInt64(Length, 16);
}
