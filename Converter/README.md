# Il2CppExplorer

Converts a Unity IL2CPP game's dummy `Assembly-CSharp.dll` + native `GameAssembly.dll` into readable pseudo-C# source files by driving Ghidra headless decompilation and applying a series of post-processing passes.

## How it works

```
Assembly-CSharp.dll  ──► DllParser ──► TypeInfo / MemberInfo
  (Cpp2IL dummy)            │               (fields, method sigs, RVAs)
                            │
                            ├──► ManifestWriter ──► _manifest.csv   (methods to decompile)
                            │                       _labels.csv     (RVA → name, for Ghidra)
                            │
GameAssembly.dll  ─────────►│
global-metadata.dat ────────►├──► NativeMethodExtractor  (LibCpp2IL)
                            │         extracts 50k+ Unity engine labels
                            │         merged into _labels.csv
                            │
                            ▼
                      Ghidra headless  (analyzeHeadless.bat)
                        + GhidraDecompile.java post-script
                            │
                            │  renames FUN_XXXXXX → ClassName__Method
                            │  decompiles each function to C
                            │  writes output/_decompiled/<class>/<method>.c
                            │
global-metadata.dat ───────►├──► StringMapExtractor
                            │         resolves 0xDAT_ addresses → string literals
                            │
                            ▼
                      SummaryWriter
                        post-processing passes 0–7 (see "Post-processing passes" below)
                            │
                            ▼
                      output/_NoNamespace/<ClassName>.cs
```

## Post-processing passes

Applied by `Services/SummaryWriter.cs` to each decompiled method body, in order:

| Pass | What it does |
|------|--------------|
| 0 | Strips Ghidra header comment, function signature, outer `{}` braces; de-indents body by 2 spaces |
| 0.5 | `DAT_` addresses already in `_string_map.csv` → quoted string literals (early substitution before guards run) |
| 1 | Strips IL2CPP class-init guard blocks: `if (DAT_X == '\0') { thunk_FUN(...); DAT_X = '\x01'; }` |
| 2 | Removes GC write-barrier thunk calls that immediately follow a pointer write |
| 2b | Strips Ghidra temp-variable declarations (`uVar1`, `plVar3`, `cVar2` etc.) from the top of the body |
| 2c | Strips multi-line IL2CPP class-init guard blocks (both `DAT_` and `ClassName_StaticsPtr` forms, single-line and split `0x133`/`0xe0`) |
| 2d | Collapses Ghidra C comma-expressions to C# assignment-in-condition form: `(X = EXPR, X != 0)` → `(X = EXPR) != null` |
| 2e | Strips IL2CPP vtable type-cast assertion boilerplate (14–17 line block: type-check → boolVar → null-init → cond-assign → throw). Three variants: (1) full pattern with throw → `DEST = SRC;`, (2) safe-cast without throw → `DEST = SRC;`, (3) standalone `else if` throw block (no bool) → removed entirely. Also strips preceding `if (X == null) { X = null; }` no-op guard when adjacent. |
| 3a | Replaces `*(self + 0xNN)` → `self.fieldName` using native IL2CPP field offsets from LibCpp2IL |
| 3b | Builds `varTypeMap` from `var x = new Type(...)`, `x = this.field`, and `x = CurrentClass.staticField` patterns. Game types take priority; BCL stub types (`List`, `Dictionary`, etc.) are used as lower-priority fallback so `List._items`/`Count` still resolve without overriding a game-typed variable. |
| 3c | Replaces `*(type*)(varName + 0xNN)` → `varName.fieldName` using `typeOffsets` registry |
| 3c2 | Resolves `*(type*)(self.FIELD + 0xNN)` → `self.FIELD.subField` and `*(type*)(var.FIELD + 0xNN)` → `var.FIELD.subField` |
| 3c3 | Collapses Ghidra address-of pointer pairs: `pVar = (type*)(BASE + 0xNN); *pVar = EXPR;` → `BASE.field = EXPR;`; standalone address-of rewrites to `pVar = &BASE.field;` |
| 3d | Hoists repeated statics-pointer derefs to a named local `pStatics` / `pClassName`. Recognises both `*(int64 *)(X + 0xb8)` (statics block ptr) and `*(int64 **)(X + 0xb8)` (double-deref / singleton form). When `_static_labels.csv` is present, `DAT_` identifiers are resolved to a class name (`datToClass` map) and added to `varToClass` for pass 3e. |
| 3e | Resolves `*(type*)(pClassName + 0xNN)` → `ClassName.fieldName` using native static field offsets. Chain forms: `*pVar` (standalone) → `ClassName.instance`; `*(type*)(*pVar + OFFSET)` → `ClassName.instance.instanceField` (follows the singleton through its first static field then resolves an instance field offset). |
| 3e cleanup | Removes `var pXxx = *(int64*)(... + 0xb8);` declarations when all uses were fully resolved by 3e |
| 3f | Inline single-use statics resolution. Named form: `*(type*)(*(int64*)(ClassName_StaticsPtr + 0xb8) + OFFSET)` → `ClassName.fieldName`; double-deref at offset 0: `**(type**)(ClassName_StaticsPtr + 0xb8)`. Chain forms: `*(type*)(*(int64 **)(ClassName_StaticsPtr + 0xb8) + OFFSET)` → `ClassName.instance.instanceField`; DAT_ variants of both when `datToClass` is available. |
| 3g | Collapses `pVar = &FIELD; *pVar = VALUE; il2cpp_internal(pVar, VALUE);` triplet → `FIELD = VALUE;` |
| 3g2 | Multi-use address-of pointer tracking: `pVar = &FIELD; ... *pVar ...` → replaces all uses with `FIELD` |
| 3h | Null-conditional simplification: `(X != null) && (X = X.FIELD) != null` → `(X = X?.FIELD) != null`; also LHS `!= 0` form |
| 3h2 | Collapses preceding assignment into null-conditional: `VAR = EXPR;` + `if ((VAR = VAR?.FIELD) op null)` → `if ((VAR = EXPR?.FIELD) op null)` |
| 3b2 | Second-pass type inference after 3e: scans `VAR = ClassName.fieldName;` for any game class, updates varTypeMap, re-runs 3c/3h/3h2. Two-level chain: also infers type from `VAR = ClassName.field1.field2` by following the chain through `crossFieldTypes`. |
| 4 | Collapses `il2cpp_internal(DAT) + ctor(var) + self.field = var` → `self.field = new Class(args)` |
| 4b | Null idioms: `== 0` / `!= 0` on object vars → `== null` / `!= null`. Covers `this.field`, named params, `lVar*` locals, and dot-notation expressions (e.g. `ClassName.instance != 0` → `!= null`). |
| 4c | Bool/char idioms: `'\0'` → `false`, `'\x01'` → `true`, `return 0/1` in bool methods |
| 4d | Bool literal comparisons: `X == false` → `!X`, `X == true` → `X`, etc. |
| 4e | Small hex literals (0x00–0xFF) → decimal; leaves large addresses/float bit-patterns unchanged |
| 4f | IL2CPP `List<T>[i]` / `array[i]` access: `*(T*)(*(int64*)(LIST + 16) + 32 + (int64)(int)IDX * STRIDE)` → `LIST[IDX]`; handles element strides 1, 2, 4, 8, 12, 16 and direct array-pointer forms |
| 4g | Post-4e decimal field resolution: re-runs 3c and 3c2 with decimal offsets (after 4e converted 0x10→16 etc.), resolving `*(T*)(var + 24)` → `var.Count`, `*(T*)(this.field + 16)` → `this.field._items`, etc. |
| 5 | Single-line `/* comment */` → `// comment` |
| 5a | Replaces remaining `DAT_XXXXXXXX` with resolved string literals |
| 5b | Goto-to-error-handler: `goto LAB_X` where target is a non-returning thrower → `throw; // [null/range check failed]`; strips dead label block |
| 5c | Goto restructuring: `if (cond) goto LAB_X; [body]; LAB_X:` → `if (!cond) { body }` |
| 5d | `ClassName__MethodName` → `ClassName.MethodName` (Ghidra label → dot notation) |
| 6 | Removes trailing implicit `return;` |
| 7 | Collapses consecutive blank lines |

## File responsibilities

- **`Services/SummaryWriter.cs`** — post-processing passes (most tuning work goes here); passes numbered 0–7 (see table above). `StripGhidraWrapper` also skips `/* WARNING: ... */` block-comment lines that Ghidra emits before the function signature when it removes unreachable blocks. `WriteAll` signature: `WriteAll(types, allTypes?, datToClass?)`. `datToClass` is a `Dictionary<string,string>` mapping hex DAT_ addresses (lower-case, no `0x` prefix) → class name, loaded from `_static_labels.csv` by `Program.cs` each run.
- **`Program.cs`** — loads `_static_labels.csv` into `datToClass` map before calling `summaryWriter.WriteAll`; also decodes static field offset encoding from `NativeMethodExtractor` (`-(offset+1)` → `offset`)
- **`Services/DllParser.cs`** — type/field/method parsing + `FormatTypeRef()` for generic types; field signatures now include access modifiers (`public`, `private`, `protected`, `static`, `const`, `readonly`)
- **`Services/NativeMethodExtractor.cs`** — LibCpp2IL integration for engine method labels; also exports `ExtractFieldOffsets()` which returns real IL2CPP field offsets (instance and static) for all types using `Il2CppFieldReflectionData.FieldOffset`. Static field encoding: uses `-(offset+1)` (not `-offset`) so offset 0 static fields are distinguishable from instance fields. `Program.cs` decodes with `-(value) - 1`.
- **`Services/StringMapExtractor.cs`** — IL2CPP string literal extraction. `ExtractDynamicStringCandidates` (the `--dynamic-string-candidates` mode) filters `_string_map.csv` for CJK-containing values and also drops BCL/ICU internal noise via `IsExoticScriptNoise`: legitimate-but-useless compiled-in .NET internal Unicode-category/culture data tables that happen to contain a stray CJK codepoint among thousands of others (confirmed NOT corrupted extraction — verified byte-for-byte identical against their `DAT_` source rows). Detected via two signals (either trips the filter): (1) the value touches 3+ unrelated exotic-script Unicode blocks (`ExoticScriptRegexes` — Hebrew/Arabic/Thai/Lao/Tibetan/Ethiopic/Khmer/Mongolian/Hangul/Coptic/halfwidth-fullwidth/control-pictures) since real Chinese dialogue never legitimately mixes these; or (2) the value contains a Unicode noncharacter codepoint (`U+FFFE`, `U+FFFF`, `U+FDD0`–`U+FDEF`) which can never appear in valid real text and only shows up in raw internal data tables.
- **`Scripts/GhidraDecompile.java`** — the Ghidra post-script; accepts 3 positional args: `<manifest_path>` (required), `<labels_path>` (RVA→name CSV for function renaming, optional), `<static_labels_path>` (RVA→name CSV applied as data symbols for statics pointers, optional).
- **`Decompilers/GhidraDecompiler.cs`** — drives Ghidra headless; constructor accepts `staticLabelsPath` to pass the 3rd arg.

## Game-specific paths (LongYinLiZhiZhuan)

Game directory: `G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan`

All paths below are auto-discovered when passing `--game-dir`:

| Item | Auto-discovered path |
|------|---------------------|
| Dummy DLL | `BepInEx\dummy\Assembly-CSharp.dll` |
| Native binary | `GameAssembly.dll` |
| Metadata | `LongYinLiZhiZhuan_Data\il2cpp_data\Metadata\global-metadata.dat` |
| Interop labels | `BepInEx\interop\` + `BepInEx\unity-libs\` |
| LibCpp2IL deps | `BepInEx\core\` (resolved automatically) |
| Unity version | `2020.3.48f1` (pass via `--unity-version`) |
| Ghidra | `G:\Dragon\Converter\ghidra\` (pass via `--ghidra`) |
| Ghidra project | `G:\Dragon\Converter\output\_ghidra_project\` |
| Output | `G:\Dragon\Converter\output\_NoNamespace\` |

## Output files

| File | Contents |
|------|----------|
| `output/_NoNamespace/<ClassName>.cs` | One file per class — field skeleton + decompiled method bodies |
| `output/_manifest.csv` | Method list passed to Ghidra (token, RVA, class, method name) |
| `output/_labels.csv` | RVA → label map used by Ghidra for function renaming |
| `output/_string_map.csv` | IL2CPP string literal address → value (cached between runs) |
| `output/_static_labels.csv` | Class statics-pointer RVA → symbol name — regenerated each run; fed back to Ghidra so `DAT_` addresses become `ClassName_StaticsPtr` on the next run |

## Prerequisites

- .NET 8 SDK
- Ghidra 11+ installed at `.\ghidra\` (with a pre-analysed `Il2CppProject` Ghidra project)
- `Assembly-CSharp.dll` produced by **Cpp2IL** with address injection (`[Cpp2ILInjected.Address]` attributes)
- BepInEx 6 installed in the game directory (for LibCpp2IL native label extraction)

## Build

```powershell
cd G:\Dragon\Converter
dotnet build
```

> Note: `dotnet build -q` may report a false "1 error" — use `dotnet build` (without `-q`) to confirm.

## Run commands

See [`.github/instructions/converter.instructions.md`](../.github/instructions/converter.instructions.md) for the full command reference (all flags, filtered/skip-decompile runs, `--game-dir` auto-discovery, common issues).

Quick start:

```powershell
cd G:\Dragon\Converter
dotnet run --no-build -- `
  --game-dir     "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra       ".\ghidra" `
  --output       ".\output" `
  --native-labels `
  --unity-version "2020.3.48f1"
```
