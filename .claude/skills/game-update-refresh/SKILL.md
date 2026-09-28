---
name: game-update-refresh
description: Walks the user through refreshing the translation pipeline after the game (Legend of Dragon Heir / LongYinLiZhiZhuan) receives an update - commit, regenerate BepInEx interop + raw dumps, rebuild the plugin, re-decompile, copy raws, export, and merge - asking for explicit approval before running each step. Stops before translation, QC, packaging, and release, which it must never run. Use when the user says the game updated/patched and they need to pull in new strings or files.
---

# Refresh the pipeline after a game update

This is a **guided, step-by-step** walkthrough. For every step:

1. Explain in one or two lines what the step does and what it changes on disk.
2. Ask the user (AskUserQuestion) whether to **run it**, **skip it** (they've done it / will do
   it themselves), or **stop**. Never batch several steps under one approval, and never assume
   approval carries over from a previous step or a previous session.
3. Only after an explicit "run it", execute the step, then report the outcome faithfully
   (failures with output, counts of changed files where cheap to get).
4. If a step fails, stop and help diagnose - do not continue down the list.

The export/merge facts are state-mutating (see
[`workflow-execution-reference.md`](../../../docs/features/translation-pipeline/workflow-execution-reference.md)).
The repository rule "never run export/merge facts on your own initiative" still applies - this
skill only relaxes it for the specific step the user has just approved.

## Hard boundary - steps 7 onwards are off-limits

You must **not** run, and must not offer to run, anything from step 7 onwards, even if asked
mid-walkthrough to "just finish it off":

- translation facts (`TranslationWorkflowTests`, any live LLM call),
- quality-review facts (`QualityControlWorkflowTests`),
- packaging (`FileOutputWorkflowTests.PackageFinalTranslation`),
- release zipping (`FileOutputWorkflowTests.ZipRelease`),
- any flag/QC reset facts.

After step 6, list steps 7-8 as things for the user to do themselves and end.

## Running a single fact

Workflow facts are run one at a time by method name from the repo root:

```powershell
dotnet test Tests --filter "FullyQualifiedName=Tests.<Class>.<Method>"
```

Build once first (`dotnet build Tests`) so each fact run isn't also a compile; use
`--no-build` on subsequent fact runs. Do not use `dotnet build -q`.

## Steps

### 0. Commit current work

Run `git status`. If `Files/` (especially `Files/Converted`, `Files/Glossary`,
`Files/Raw/Dumped`) has uncommitted changes, explain that merge/export will rewrite these and
offer to commit them (show the file list; ask for / propose a message). This gives a clean point
to diff and roll back to. Follow the repo's commit attribution rules.

### 1. Launch the updated game (user action)

You cannot do this - the user must. Tell them:

- Launching the updated game with BepInEx regenerates `BepInEx/interop/` - the Converter and the
  plugin both depend on it, so this must happen **before** decompiling.
- The plugin dumps TextAssets into `G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan\BepInEx\plugins\raw`
  only when the game loads them, so play far enough for the data to load.
- Optionally clear that `raw` folder first so stale files from the old version don't carry
  over. Offer to clear it for them (look at its contents first; this is a delete, so confirm).

Wait until they confirm the game has been run before continuing.

### 2. Rebuild the plugin against the new interop

```powershell
dotnet build DragonHeirPlugin
```

Report any compile errors - they usually mean a game type/signature changed and a Harmony patch
needs updating. Also suggest the user check `BepInEx/LogOutput.log` for patches that failed to
apply at runtime.

### 3. Re-decompile (Converter)

Full run - **no** `--skip-decompile`, so `_string_map.csv` is regenerated rather than loaded from
cache.

**First, delete the stale Ghidra project.** If `Converter/output/_ghidra_project` exists, the
Converter reuses it (`-process`) instead of re-importing (`-import`) the updated
`GameAssembly.dll` (see `Decompilers/GhidraDecompiler.cs`). After a game update that project
holds the *old* binary, so method addresses no longer line up and most methods come back
`NO_FUNC` (seen 2026-09-28: OK=3358 / FAIL=6278, with methods that decompiled fine before now
empty). The folder is a regenerable cache (~1 GB, not tracked in git). Confirm it is untracked
(`git ls-files Converter/output/_ghidra_project` is empty), explain why, ask, then delete it:

```powershell
Remove-Item -Recurse -Force "G:\DragonHierOverLlm\Converter\output\_ghidra_project" -Confirm:$false
```

Then from `G:\DragonHierOverLlm\Converter`:

```powershell
dotnet build
dotnet run --no-build -- `
  --game-dir "G:\SteamLibrary\steamapps\common\LongYinLiZhiZhuan" `
  --ghidra ".\ghidra" `
  --output ".\output" `
  --native-labels `
  --unity-version "2020.3.48f1"
```

This is long-running - run it in the background (redirect output to a log in the scratchpad) and
wait for completion. When it finishes, verify it before moving on:

- the logged `analyzeHeadless.bat` command should contain `-import "…GameAssembly.dll"` (followed
  by `ANALYZING all memory and code`), not `-process … -noanalysis` / `Opening existing project`
  - the latter means the stale project was reused. The import run does full Ghidra
  auto-analysis first, so expect it to take much longer than a `-process` run;
- read the `GhidraDecompile: done. OK=… FAIL=…` line. `FAIL` should be a small minority. If it's
  most of the methods, stop and diagnose rather than continuing;
- `_string_map.csv` comes from metadata + binary directly (not Ghidra), so it can be fine even
  when the decompile isn't. Step 5's `ExtractDrinkQuoteCandidates` reads decompiled code, though.
- `Converter/output` is tracked in git, so report `git status --short Converter/output` counts
  and spot-check a known class against `HEAD` to confirm the method bodies are present.

Check
[`converter.instructions.md`](../../../.github/instructions/converter.instructions.md) if it
stalls or produces no types/strings.

### 4. Copy raws into the working directory

`AssetDumperWorkflowTests`:

1. `CopyRaws` ("0. Copy raws to Working Directory")
2. `DumpChineseTextFromAssets` ("0b. Dump Chinese text from prefab/asset files")

**Warn before `CopyRaws`:** it deletes the whole of `Files/Raw/Dumped` - including
`DynamicStrings/` and `PrefabText/`, which the game's raw folder does not contain. The extraction
steps rebuild most of it, but any hand-curated removals from `dynamicStrings.txt` would be lost.
After it runs, offer to restore the curated folder:

```powershell
git checkout -- Files/Raw/Dumped/DynamicStrings
```

(Only `DynamicStrings/` - `PrefabText/` is regenerated by `0b`.) Then ask before running `0b`.

### 5. Export (in order)

`FileInputWorkflowTests`, one approval per fact:

| # | Method |
| --- | --- |
| 1 | `ExportAssetsIntoTranslated` |
| 2 | `ExportPrefabTextIntoTranslated` |
| 3 | `ExtractIl2CppStringMapCandidates` |
| 4a | `ExtractColumnCandidates` |
| 4b | `ExtractHeroNamePartCandidates` |
| 4b2 | `ExtractForceNamePrefixCandidates` |
| 4b3 | `ExtractHeroFullNameCandidates` |
| 4c | `ExtractStructuredRecordFragmentCandidates` |
| 4d | `ExtractOtherFieldLabelCandidates` |
| 4e | `ExtractPoetryCandidates` |
| 4f | `ExtractDrinkQuoteCandidates` |
| 4g | `ExtractLogNarrativeCandidates` |
| 4h | `ExtractMailBodies` |
| 5 | `DedupeDynamicStringFiles` |
| 6 | `ExportDynamicStringFilesIntoTranslated` |

Order matters (3 feeds 4c/4g; 5 must follow all of 4; 6 must follow 5). If the user asks to run
the 4a-4h group under one approval, that is fine - it's their explicit choice - but still run them
sequentially and stop on the first failure. Check the method list against
[`FileInputWorkflowTests.cs`](../../../Tests/FileInputWorkflowTests.cs) at the start of the
walkthrough in case facts were added, renamed, or reordered.

After step 6 of this list, run `git diff --stat -- Files/Raw/Dumped` and summarise which dynamic
string files gained lines.

### 6. Merge and verify

1. `MergeFilesIntoTranslated` ("99.")
2. `CheckFileLinesMatch` ("999.") - should pass (empty result). If it fails, report the bad files
   and stop.

Then summarise the impact: `git diff --stat -- Files/Converted`, and call out any file with an
unusually large change (a sign of a restructured source file rather than new strings).

### 7-8. Hand off (do NOT run)

Tell the user the remaining steps are theirs:

- **7. Translate** new/changed lines - `TranslationWorkflowTests` "3. Translate Lines Only", then
  the QC facts if they use QC.
- **8. Package & test** - `FileOutputWorkflowTests` "6. Package to Game Files", check in-game for
  untranslated text (the `investigate-missing-translation` skill helps here), then "7. Zip Release".

End with a short recap of which steps were run, skipped, or failed.
