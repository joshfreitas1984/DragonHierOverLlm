---
applyTo: "Converter/**"
---

# Il2CppExplorer — Run Instructions

> **Workflow rule:** After completing any significant feature or fix, update **both**
> [`Converter/README.md`](../../Converter/README.md) **and** this file (the flags/common-issues
> reference here; the post-processing passes table and file responsibilities in the README). Keep
> this file short — it's auto-injected into context on every `Converter/**` edit. Put detailed
> decompiler bug/limitation narratives in a topic file under
> [`docs/investigations/converter/`](../../docs/investigations/converter/) instead (read on-demand, not auto-loaded, indexed by
> [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md)), and only summarize the
> current-state finding here. **Batch write-backs**: during a task, jot scratch notes in session
> memory as you find things — write ONE consolidated update (a new/extended `docs/*.md` file +
> this file's summary + a one-line index entry) at the end of the task, not after every individual
> fix.

See [`Converter/README.md`](../../Converter/README.md) for how the pipeline works end-to-end
(architecture diagram, the full post-processing passes table, and per-file responsibilities).

## Quick reference

### Full run (all classes, all improvements)
```powershell
cd G:\DragonHierOverLlm\Converter
dotnet run --no-build -- `
  --game-dir     "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra       ".\ghidra" `
  --output       ".\output" `
  --native-labels `
  --unity-version "2020.3.48f1"
```
> Takes 30–60 min. Ghidra re-uses the existing project; first run also does binary analysis.
> `--game-dir` auto-discovers: `GameAssembly.dll`, `global-metadata.dat`, `BepInEx\dummy\Assembly-CSharp.dll`, `BepInEx\interop\`, `BepInEx\unity-libs\`.

---

### Filtered run (single class — fast, for testing)
```powershell
dotnet run --no-build -- `
  --game-dir     "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra       ".\ghidra" `
  --output       ".\output" `
  --native-labels `
  --unity-version "2020.3.48f1" `
  --filter       "GameDataController"
```

---

### Skip decompile — re-run post-processing only
Use this to iterate on `SummaryWriter.cs` without re-running Ghidra.
Requires that `output/_decompiled/` still exists from a previous run  
*(comment out the `Directory.Delete` block in `Program.cs` first)*.

Pass `--unity-version` so that field offsets are loaded from LibCpp2IL (required for static and instance field name resolution).

```powershell
dotnet run --no-build -- `
  --game-dir      "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra        ".\ghidra" `
  --output        ".\output" `
  --skip-decompile `
  --unity-version "2020.3.48f1"
```

---

### Build only
```powershell
dotnet build
```
> Do not use `dotnet build -q` — it may report false errors.

---

## All flags

| Flag | Required | Description |
|------|----------|-------------|
| `--game-dir <path>` | Yes† | Root of the Unity game install — auto-discovers all game files (see below) |
| `--dll <path>` | Yes† | Cpp2IL dummy `Assembly-CSharp.dll` with `[Cpp2ILInjected.Address]` attributes |
| `--binary <path>` | Yes†* | Native game binary (`GameAssembly.dll`) |
| `--ghidra <path>` | Yes* | Ghidra install root (contains `support/analyzeHeadless.bat`) |
| `--output <path>` | No | Output directory (default: `output`) |
| `--metadata <path>` | No | `global-metadata.dat` — auto-discovered from `--game-dir` if omitted |
| `--filter <name>` | No | Only process types whose name contains this string |
| `--native-labels` | No | Use LibCpp2IL to extract 50k+ Unity engine method labels. Requires `--unity-version` |
| `--unity-version <ver>` | No | Unity version string e.g. `2020.3.48f1` — required when `--native-labels` is set; also enables native field offset extraction (recommended with `--skip-decompile`) |
| `--skip-decompile` | No | Parse DLL and write summary only; skip Ghidra entirely |
| `--clean-decompile` | No | Delete the `_decompiled/` intermediate folder after writing `.cs` files (default: keep it so `--skip-decompile` can re-process without re-running Ghidra) |
| `--all-namespaces` | No | Include library/framework namespaces (default: `_NoNamespace` only) |
| `--interop <path>` | No | Extra interop DLL folder — repeatable; auto-added from `--game-dir` |
| `--use-offset` | No | Pass file offsets to Ghidra instead of RVAs |
| `--timeout <sec>` | No | Per-function Ghidra decompile timeout (default: 60s) |
| `--diag` | No | Dump raw custom attributes from DLL and exit (debug tool) |

† Use `--game-dir` **or** supply `--dll` + `--binary` individually.  
\* Required unless `--skip-decompile` is set.

### What `--game-dir` auto-discovers

| Discovered path | Maps to |
|---|---|
| `GameAssembly.dll` | `--binary` |
| `<name>_Data\il2cpp_data\Metadata\global-metadata.dat` | `--metadata` |
| `BepInEx\dummy\Assembly-CSharp.dll` | `--dll` |
| `BepInEx\interop\` | interop label source |
| `BepInEx\unity-libs\` | interop label source |
| `BepInEx\core\` | LibCpp2IL dependency resolution (automatic) |

---

## Output location

See [`Converter/README.md`](../../Converter/README.md)'s "Output files" table — `output/_NoNamespace/<ClassName>.cs` is the main output (field skeleton + decompiled methods); `_manifest.csv`/`_labels.csv`/`_string_map.csv`/`_static_labels.csv` are intermediate/cached files consumed across runs.

---

## Post-processing invariants (current state)

`Services/SummaryWriter.cs` applies numbered passes 0–7 (full table in
[`Converter/README.md`](../../Converter/README.md)) to each decompiled method body, in a fixed
order that later passes depend on — e.g. pass 3d/3e's statics-pointer hoisting must run before
3f/3b2's chain resolution, and 4e's hex→decimal conversion must run before 4g's decimal-offset
re-resolution. When adding or reordering a pass, update the table in `Converter/README.md` (single
source of truth for pass numbering) in the same change.

**Editing entry points:**
- `Services/SummaryWriter.cs` — post-processing passes (most tuning work goes here).
- `Services/DllParser.cs` — type/field/method parsing.
- `Services/NativeMethodExtractor.cs` — LibCpp2IL label + field-offset extraction (static field
  offsets are encoded as `-(offset+1)`, decoded by `Program.cs`).
- `Services/StringMapExtractor.cs` — IL2CPP string literal extraction and CJK/dynamic-string
  candidate filtering.
- `Scripts/GhidraDecompile.java` / `Decompilers/GhidraDecompiler.cs` — the Ghidra post-script and
  its driver.

See [`Converter/README.md`](../../Converter/README.md)'s "File responsibilities" section for the
full current-state detail on each of these before making a non-trivial change.

---

## Known decompiler limitations / bugs found through real investigations

> Full narratives for each item below are in `docs/investigations/converter/` (indexed by
> [`docs/KNOWN_ISSUES.md`](../../docs/KNOWN_ISSUES.md)) — read the specific topic doc,
> not this whole file, when investigating a similar issue.

- **Fixed**: `NativeMethodExtractor.ExtractMethodLabels` used to mislabel shared-generic-code
  addresses (first-occurrence-wins), producing confidently wrong labels like bogus
  `Resources.Load(...)` calls. Now only labels addresses with exactly one candidate; ambiguous
  addresses stay unlabeled (`FUN_xxxxxxxx`). **Still open**: a few genuinely-distinct
  `Resources.Load`-labeled calls are wrong for a different, unfixed reason (native
  trampoline/icall stub code reuse, not a managed-metadata ambiguity — not solvable at the
  managed-methodDefs level we currently extract from). See
  `docs/nativemethodextractor-shared-generic-mislabeling.md`.
- **Open**: field-resolution passes 3d/3e don't resolve instance-field offsets on a singleton
  pointer that was hoisted into a separately-named local several statements before the offset
  access (only inline `*(type*)(*pVar + OFFSET)` chains resolve). Worked around at the
  investigation site via a runtime reflection diagnostic patch rather than fixing this pass. See
  `docs/field-resolution-hoisted-singleton-gap.md`.
- **Fixed**: `StringMapExtractor`'s `.data`-section scan silently dropped ~half of all string
  literals on IL2CPP metadata v27+ (Unity 2020.3.48f1) due to a missing `>>1` shift on the decoded
  usage index. Confirmed root-caused, fixed, and the full pipeline re-run afterward brought
  `_string_map.csv` from ~half to 19280/19283 entries resolved. New dynamic-string candidates
  surfaced by the re-run (3680) still need user review/merge into `dynamicStrings.txt` — not done
  automatically. See `docs/stringmapextractor-metadata-v27-shift-bug.md`.
- **Fixed**: `StringMapExtractor.CsvUnescape`'s sequential-`Replace`-based escaping could corrupt
  strings containing a literal backslash immediately followed by `n`/`r`/`t`/`"` (cross-boundary
  match between the `\\` and `\r`/`\n`/`\t`/`\"` escape passes). Now a single left-to-right atomic
  scan. See `docs/stringmapextractor-csvunescape-corruption.md`.

## Common issues

| Symptom | Fix |
|---------|-----|
| `Could not load file or assembly 'AssetRipper.Primitives'` | Set `<Private>true</Private>` in `.csproj` for both `LibCpp2IL` and `AssetRipper.Primitives` references |
| `dotnet build -q` shows "1 error" but code is fine | Run without `-q`; the quiet flag produces false positives |
| Ghidra stalls on a method | Increase `--timeout`; the default is 60s per function |
| `No types found` | Check `--filter` spelling; default scope is `_NoNamespace` only |
| String literals not resolved | Ensure `--metadata` points to `global-metadata.dat`; delete `_string_map.csv` to force regeneration |
| `--dll <path> is required` when using `--game-dir` alone | Fixed: auto-discovery now runs before validation. `--game-dir` alone is sufficient. |
