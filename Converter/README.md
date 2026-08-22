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
                        post-processing passes:
                          0.  Ghidra header/signature/outer-braces stripping; 2-space de-indent
                          0.5 DAT_ addresses → resolved string literals (early, before guards)
                          1.  Class-init guard blocks stripped
                              (`if (DAT_X == '\0') { thunk_FUN(...); DAT_X = '\x01'; }`)
                          2.  GC write-barrier thunk calls removed
                          2b. Ghidra temp-variable declarations stripped/converted (uVar1→ulong, cVar1→bool, arrays emitted as `type[]`)
                          2c. Multi-line IL2CPP class-init guard blocks stripped
                              (both `DAT_` and `ClassName_StaticsPtr` forms, single-line and split `0x133`/`0xe0`)
                          2d. Ghidra C comma-expressions collapsed: `(X = EXPR, X != 0)` → `(X = EXPR) != null`
                          2e. IL2CPP vtable type-cast boilerplate stripped: full throw, safe-cast, and standalone `else if` throw variants → `DEST = SRC;` or removed
                          3a. `*(this + 0xNN)` → `this.fieldName` (native IL2CPP field offsets from LibCpp2IL)
                          3b. varTypeMap from `var x = new Type(...)`, `x = this.field`, `x = CurrentClass.staticField`.
                              Game types take priority; BCL stubs (List, Dictionary) allowed as fallback
                              so List._items/Count resolve without overriding game-typed variables.
                          3c. `*(type*)(var + 0xNN)` → `var.fieldName` (cross-type offsets)
                          3c2. `*(type*)(this.FIELD + 0xNN)` → `this.FIELD.subField`
                          3c3. `pVar=(type*)(BASE+0xNN); *pVar=EXPR;` → `BASE.field=EXPR;`
                          3d. Repeated statics-pointer derefs hoisted to named local.
                              Recognises both single-deref `*(int64*)(X + 0xb8)` and double-deref
                              `*(int64**)(X + 0xb8)` (singleton form). When `_static_labels.csv`
                              is present, DAT_ addresses are resolved to class names (datToClass)
                              so pass 3e can follow singleton chains.
                          3e. `*(type*)(pClassName + 0xNN)` → `ClassName.fieldName` (static fields).
                              Chain forms: `*pVar` → `ClassName.instance`;
                              `*(type*)(*pVar + OFFSET)` → `ClassName.instance.instanceField`.
                          3f. Inline statics single-use resolver:
                              named: `*(type*)(*(int64*)(ClassName_StaticsPtr+0xb8)+0xNN)` → field;
                              double-deref at offset 0: `**(type**)(ClassName_StaticsPtr+0xb8)`.
                              Chain forms: `*(type*)(*(int64**)(ClassName_StaticsPtr+0xb8)+0xNN)` →
                              `ClassName.instance.instanceField`; DAT_ variants via datToClass.
                          3g. `pVar = &FIELD; *pVar = VALUE; il2cpp_internal(pVar,VALUE);` → `FIELD = VALUE;`
                          3g2. Multi-use `pVar = &FIELD` tracking; replaces all `*pVar` uses with `FIELD`
                          3h. Null-conditional: `(X != null) && (X = X.FIELD) != null` → `(X = X?.FIELD) != null`
                          3h2. Collapses preceding `VAR = EXPR;` into null-conditional: `if ((VAR = EXPR?.FIELD) op null)`
                          3b2. Second-pass type inference after 3e: `VAR = ClassName.fieldName;` → update varTypeMap.
                               Two-level chain: `VAR = ClassName.field1.field2` also followed.
                               Re-runs 3c, 3h, 3h2 with updated types.
                          4.  new-object allocation pattern collapse
                          4b. `== 0` / `!= 0` on object vars → `== null` / `!= null`.
                              Covers this.field, named params, lVar* locals, and dot-notation
                              (e.g. `GameController._instance != 0` → `!= null`).
                          4c. Bool/char idioms (`'\0'`→`false`, `'\x01'`→`true`)
                          4d. Bool literal comparisons: `X == false` → `!X`, `X == true` → `X`
                          4e. Small hex literals (0x00–0xFF) → decimal
                          4f. IL2CPP List<T>/array indexer:
                              `*(T*)(*(int64*)(LIST + 16) + 32 + (int64)(int)IDX * STRIDE)` → `LIST[IDX]`
                              element strides: 1, 2, 4, 8, 12, 16; direct array-pointer form too.
                          4g. Post-4e decimal field re-resolution:
                              re-runs 3c/3c2 with decimal offsets (after 4e converts 0x10→16 etc.)
                              e.g. `*(T*)(var + 24)` → `var.Count`, `*(T*)(this.field + 16)` → `this.field._items`.
                          5.  `/* comment */` → `// comment`
                          5a. `DAT_...` → resolved string literals (non-string DATs left as-is)
                          5b. `goto LAB_X` → `throw; // [null/range check failed]` (error handlers)
                          5c. `if (cond) goto LAB_X; [body]; LAB_X:` → `if (!cond) { body }`
                          5d. `Class__Method` → `Class.Method` (dot notation)
                          6.  Trailing implicit `return;` removal
                          7.  Blank line collapsing
                            │
                            ▼
                      output/_NoNamespace/<ClassName>.cs
```

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

See [.github/copilot-instructions.md](.github/copilot-instructions.md) for the full command reference.

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
