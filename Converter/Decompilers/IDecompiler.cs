namespace Il2CppExplorer.Decompilers;

public interface IDecompiler
{
    /// <summary>
    /// Decompile all functions listed in the manifest CSV.
    /// Each row's OutputFile column is the destination .c file.
    /// </summary>
    Task DecompileAsync(string manifestPath, CancellationToken ct = default);
}
