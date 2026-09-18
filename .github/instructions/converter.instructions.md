---
applyTo: "Converter/**"
---

# Converter Instructions

This project decompiles the game's IL2CPP binaries. Keep this file operational; durable findings
belong in [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md) and
`docs/investigations/converter/`.

## Commands

Run from `G:\DragonHierOverLlm\Converter`.

Full run:

```powershell
dotnet run --no-build -- `
  --game-dir "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra ".\ghidra" `
  --output ".\output" `
  --native-labels `
  --unity-version "2020.3.48f1"
```

Use `--filter "TypeName"` for a focused run. Use `--skip-decompile` to rerun post-processing
against an existing `output/_decompiled/` directory; preserve that directory by disabling its
cleanup in `Program.cs` first. `--game-dir` discovers the game binary, metadata, dummy
`Assembly-CSharp.dll`, and BepInEx interop folders.

Build with `dotnet build`; do not use `dotnet build -q`, which can report false errors.

See [`Converter/README.md`](../../Converter/README.md) for the complete flag table, output layout,
post-processing pass table, and file responsibilities.

## Safety rules

- Keep `SummaryWriter` post-processing passes in their documented order. Update the pass table in
  `Converter/README.md` when adding or reordering a pass.
- Use `SummaryWriter.cs` for post-processing, `DllParser.cs` for parsing, `NativeMethodExtractor.cs`
  for native labels/offsets, `StringMapExtractor.cs` for string candidates, and the Ghidra driver
  files for decompilation orchestration.
- Treat native labels and decompiled field names as evidence, not guaranteed truth. Confirm
  ambiguous labels and suspicious field ownership against the real interop assemblies.
- Keep investigations and known limitations in the linked root documentation, not here.

## Common checks

- Missing `AssetRipper.Primitives`: ensure the relevant package references copy locally.
- Ghidra stalls: increase `--timeout`.
- No types: check `--filter` and the default `_NoNamespace` scope.
- Missing strings: verify metadata discovery and remove `_string_map.csv` when regeneration is
  required.
- Before debugging a known limitation, read the linked entry in
  [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md), especially the field-resolution and
  string-map investigations.
