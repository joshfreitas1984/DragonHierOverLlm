// Quick diagnostic: dump attribute types on the first few methods in the DLL
// Run with: dotnet script DiagAttributes.csx -- <path-to-dll>
// Or paste into a test project.
// This is intentionally a standalone C# script (no class wrapper).

#r "nuget: Mono.Cecil, 0.11.5"
using Mono.Cecil;

var dllPath = Args.Count > 0 ? Args[0] : @"Assembly-CSharp.dll";
Console.WriteLine($"Reading: {dllPath}\n");

var asm = AssemblyDefinition.ReadAssembly(dllPath, new ReaderParameters { ReadSymbols = false });

int typeCount = 0, methodCount = 0;
foreach (var module in asm.Modules)
{
    foreach (var type in module.Types)
    {
        if (typeCount++ > 3) break;

        Console.WriteLine($"TYPE: {type.FullName}");
        Console.WriteLine($"  Type custom attrs: {type.CustomAttributes.Count}");
        foreach (var a in type.CustomAttributes)
            Console.WriteLine($"    [{a.AttributeType.Namespace}] {a.AttributeType.Name}");

        foreach (var method in type.Methods.Take(2))
        {
            Console.WriteLine($"  METHOD: {method.Name}");
            Console.WriteLine($"    Method custom attrs: {method.CustomAttributes.Count}");
            foreach (var a in method.CustomAttributes)
            {
                Console.WriteLine($"    ATTR ns='{a.AttributeType.Namespace}' name='{a.AttributeType.Name}'");
                foreach (var p in a.Properties)
                    Console.WriteLine($"      .{p.Name} = {p.Argument.Value}");
                foreach (var f in a.Fields)
                    Console.WriteLine($"      field:{f.Name} = {f.Argument.Value}");
                if (a.ConstructorArguments.Count > 0)
                {
                    Console.Write("      ctor-args: ");
                    Console.WriteLine(string.Join(", ", a.ConstructorArguments.Select(c => c.Value)));
                }
            }
            methodCount++;
        }
    }
}

Console.WriteLine($"\nDone. Inspected {typeCount} types, {methodCount} methods.");
