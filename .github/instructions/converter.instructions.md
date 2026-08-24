---
applyTo: "Converter/**"
---

# Il2CppExplorer — Run Instructions

> **Workflow rule:** After completing any significant feature or fix, update **both** `Converter/README.md` **and** this file — the passes table, Editing tips, and any new flags. These are the primary source of truth for future sessions.

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

```
output/
  _NoNamespace/
    <ClassName>.cs      ← main output: field skeleton + decompiled methods
  _manifest.csv         ← method list for Ghidra
  _labels.csv           ← RVA → label map (53k+ entries with --native-labels)
  _string_map.csv       ← IL2CPP string literals (cached, delete to regenerate)
  _static_labels.csv    ← class statics-pointer RVA → symbol name (regenerated each run; fed to Ghidra on the next run)
  _ghidra_project/      ← Ghidra project (reused across runs)
```

---

## Post-processing passes applied to each method

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
| 3e | Resolves `*(type*)(pClassName + 0xNN)` → `ClassName.fieldName` using native static field offsets. **Chain forms (new):** `*pVar` (standalone) → `ClassName.instance`; `*(type*)(*pVar + OFFSET)` → `ClassName.instance.instanceField` (follows the singleton through its first static field then resolves an instance field offset). |
| 3e cleanup | Removes `var pXxx = *(int64*)(... + 0xb8);` declarations when all uses were fully resolved by 3e |
| 3f | Inline single-use statics resolution. Named form: `*(type*)(*(int64*)(ClassName_StaticsPtr + 0xb8) + OFFSET)` → `ClassName.fieldName`; double-deref at offset 0: `**(type**)(ClassName_StaticsPtr + 0xb8)`. **Chain forms (new):** `*(type*)(*(int64 **)(ClassName_StaticsPtr + 0xb8) + OFFSET)` → `ClassName.instance.instanceField`; DAT_ variants of both when `datToClass` is available. |
| 3g | Collapses `pVar = &FIELD; *pVar = VALUE; il2cpp_internal(pVar, VALUE);` triplet → `FIELD = VALUE;` |
| 3g2 | Multi-use address-of pointer tracking: `pVar = &FIELD; ... *pVar ...` → replaces all uses with `FIELD` |
| 3h | Null-conditional simplification: `(X != null) && (X = X.FIELD) != null` → `(X = X?.FIELD) != null`; also LHS `!= 0` form |
| 3h2 | Collapses preceding assignment into null-conditional: `VAR = EXPR;` + `if ((VAR = VAR?.FIELD) op null)` → `if ((VAR = EXPR?.FIELD) op null)` |
| 3b2 | Second-pass type inference after 3e: scans `VAR = ClassName.fieldName;` for any game class, updates varTypeMap, re-runs 3c/3h/3h2. **Two-level chain (new):** also infers type from `VAR = ClassName.field1.field2` by following the chain through `crossFieldTypes`. |
| 4 | Collapses `il2cpp_internal(DAT) + ctor(var) + self.field = var` → `self.field = new Class(args)` |
| 4b | Null idioms: `== 0` / `!= 0` on object vars → `== null` / `!= null`. Covers `this.field`, named params, `lVar*` locals, and **dot-notation expressions** (e.g. `ClassName.instance != 0` → `!= null`). |
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

---

## Editing tips

- **`Services/SummaryWriter.cs`** — post-processing passes (most tuning work goes here); passes numbered 0–7. `StripGhidraWrapper` now also skips `/* WARNING: ... */` block-comment lines that Ghidra emits before the function signature when it removes unreachable blocks. `WriteAll` signature: `WriteAll(types, allTypes?, datToClass?)`. `datToClass` is a `Dictionary<string,string>` mapping hex DAT_ addresses (lower-case, no `0x` prefix) → class name, loaded from `_static_labels.csv` by `Program.cs` each run.
- **`Program.cs`** — loads `_static_labels.csv` into `datToClass` map before calling `summaryWriter.WriteAll`; also decodes static field offset encoding from `NativeMethodExtractor` (`-(offset+1)` → `offset`)
- **`Services/DllParser.cs`** — type/field/method parsing + `FormatTypeRef()` for generic types; field signatures now include access modifiers (`public`, `private`, `protected`, `static`, `const`, `readonly`)
- **`Services/NativeMethodExtractor.cs`** — LibCpp2IL integration for engine method labels; also exports `ExtractFieldOffsets()` which returns real IL2CPP field offsets (instance and static) for all types using `Il2CppFieldReflectionData.FieldOffset`. **Static field encoding**: uses `-(offset+1)` (not `-offset`) so offset 0 static fields are distinguishable from instance fields. Program.cs decodes with `-(value) - 1`.
- **`Services/StringMapExtractor.cs`** — IL2CPP string literal extraction
- **`Scripts/GhidraDecompile.java`** — the Ghidra post-script; accepts 3 positional args:
  1. `<manifest_path>` (required)
  2. `<labels_path>` — RVA→name CSV for function renaming (optional)
  3. `<static_labels_path>` — RVA→name CSV applied as data symbols for statics pointers (optional)
- **`Decompilers/GhidraDecompiler.cs`** — drives Ghidra headless; constructor accepts `staticLabelsPath` to pass the 3rd arg

---

## Known decompiler limitations / bugs found through real investigations

- **Fixed: `NativeMethodExtractor.ExtractMethodLabels` mislabeled shared-generic-code addresses.**
  IL2CPP "generic sharing" compiles many distinct managed methods (e.g. `Dictionary<string, T>`
  members instantiated over different reference-type `T`s) down to the **same native code
  address**. The extractor used to do `result.TryAdd(rvaHex, label)` — "keep whichever method
  happens to be first in the metadata table" — which silently mislabels every other method at that
  shared address with a plausible-looking but WRONG name. Confirmed in the wild: several calls in
  `GameDataController.cs` with args like `"[DOTween]"`, `"[BoundingBox]"`, `"[CDATA["` were labeled
  `Resources.Load(...)` even though those are obviously not resource paths — some unrelated
  shared-generic method (not `Resources.Load`) happened to occupy that address and win the
  first-occurrence race. **Fix applied**: collect ALL candidate labels per native address first;
  only emit a label when an address has exactly one candidate. Ambiguous addresses are left
  unlabeled (Ghidra's default `FUN_xxxxxxxx`) rather than guessing — a missing label is far less
  harmful than a confidently wrong one, since a wrong label actively misleads investigation. Console
  output now reports both counts, e.g. `Extracted N unambiguous method labels ... (M addresses
  skipped as ambiguous/shared-generic)`. Verified by re-running `--filter "GameDataController"`
  before/after: the bogus `Resources.Load("[DOTween]", ...)`-style calls are gone post-fix (now
  render as unresolved `FUN_...` calls instead).
- **Still open: some `Resources.Load`-labeled calls are still wrong, for a DIFFERENT reason.**
  After the fix above, `GameDataController.cs` still contains calls like
  `Resources.Load("[CDATA[", ...)`, `Resources.Load("[NGUI] ", ...)`, `Resources.Load("[/sub]",
  ...)` — clearly log/XML-tag-parsing strings, not resource paths. Checked `_labels.csv`: the real
  `Resources.Load` managed method genuinely maps to exactly 3 distinct, unambiguous native
  addresses (one per overload) — so this is NOT the same "shared managed-metadata address" bug
  fixed above. This looks like IL2CPP/the game binary reusing the *same native trampoline/icall
  stub code* for `Resources.Load` and some unrelated string-processing routine at the **native**
  level — something our metadata-only (`LibCpp2IL`/managed methodDefs) extraction approach can't
  see or disambiguate, since it only knows about managed method → address mappings, not
  native-code-level code reuse. Not yet fixed; if this needs solving, it would require actually
  inspecting/disassembling the native function bodies at those addresses (e.g. via Ghidra's own
  analysis) to tell whether they're truly identical code or just coincidentally-adjacent, rather
  than anything achievable in `NativeMethodExtractor` alone.
- **Field-resolution passes (3d/3e) miss instance-field offsets when the singleton pointer is
  hoisted across statements.** For a singleton chain written as:
  ```csharp
  var pGameDataController = *(int64*)(GameDataController_StaticsPtr + 184);
  // ...several lines later...
  lVar3 = *(int64 *)(pGameDataController + 0x1d8);
  ```
  passes 3d/3e currently treat the hoisted `pClassName`-named local strictly as a "statics block
  pointer" (for resolving further `ClassName.staticField` reads), not as the resolved *instance*
  pointer it actually is in this shape (offset `0xb8`/184 here holds the singleton instance
  pointer directly, one dereference deep — not a statics-block base to add further static offsets
  to). The existing chain-form resolution in 3e/3f (`*(type*)(*pVar + OFFSET) →
  ClassName.instance.instanceField`) only fires when the dereference and offset-add appear
  together in one inline expression; it doesn't fire once the singleton pointer has already been
  captured into a separately-named local several statements earlier. Net effect: instance field
  offsets like `+0x1d8` on a hoisted singleton local are left as raw pointer arithmetic instead of
  being resolved to `GameDataController.someFieldName`. Found while investigating the
  `StartMenuController.ResetFaceSetting`/`ResetPlayerTag` crash (see
  `dragonheirplugin.instructions.md`) — worked around there via a runtime reflection-based
  diagnostic patch instead of fixing this pass, since getting real field names from a live process
  is more reliable than perfecting this disambiguation. If tackled properly, the fix likely belongs
  in pass 3e/3f: track hoisted `pClassName` locals that were assigned from a *known instance-typed*
  static field offset (e.g. an `_instance`/`Instance` static field, commonly at `0xb8` for
  singletons) and route subsequent `pClassName + OFFSET` accesses through `type.FieldOffsets`
  (instance offsets) rather than `type.StaticFieldOffsets`.

## Common issues

| Symptom | Fix |
|---------|-----|
| `Could not load file or assembly 'AssetRipper.Primitives'` | Set `<Private>true</Private>` in `.csproj` for both `LibCpp2IL` and `AssetRipper.Primitives` references |
| `dotnet build -q` shows "1 error" but code is fine | Run without `-q`; the quiet flag produces false positives |
| Ghidra stalls on a method | Increase `--timeout`; the default is 60s per function |
| `No types found` | Check `--filter` spelling; default scope is `_NoNamespace` only |
| String literals not resolved | Ensure `--metadata` points to `global-metadata.dat`; delete `_string_map.csv` to force regeneration |
| `--dll <path> is required` when using `--game-dir` alone | Fixed: auto-discovery now runs before validation. `--game-dir` alone is sufficient. |
