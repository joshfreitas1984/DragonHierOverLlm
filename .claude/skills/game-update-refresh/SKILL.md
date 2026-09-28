---
name: game-update-refresh
description: Walks the user through refreshing the translation pipeline after the game (Legend of Dragon Heir / LongYinLiZhiZhuan) receives an update - commit, regenerate BepInEx interop + raw dumps, rebuild the plugin, re-decompile, audit game-coupled plugin patches, copy raws, export, and merge - asking for explicit approval before running each step. Stops before translation, QC, packaging, and release, which it must never run. Use when the user says the game updated/patched and they need to pull in new strings or files.
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
needs updating. A clean build only proves the `nameof`/`typeof` targets still exist; patches
targeted by string or relying on game logic are checked in step 3b, and runtime binding is
checked after the user next launches the game with this build (see step 3b's last bullet).

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

### 3b. Audit game-coupled plugin patches

Plugin patches that a game update can break **without** a compile error are tagged in
`DragonHeirPlugin/` with `// [GameCoupled Class.Method kind] reason` comments (kinds: `replaces`,
`by-name`, `logic`, `ui-path` - see
[`dragonheirplugin.instructions.md`](../../../.github/instructions/dragonheirplugin.instructions.md)).
This step is read-only, so it needs no approval beyond the walkthrough itself. From the repo root:

```powershell
python Scripts/check_game_coupled_patches.py
```

It compares each tagged target in the new `Converter/output` against `HEAD`, so it must run
**before** the new decompile is committed. If it has already been committed, pass the last
pre-update revision instead, e.g.
`--rev <hash>~1`, where `<hash>` is the newest commit from
`git log -3 --format="%h %s" -- Converter/output/_NoNamespace/GameController.cs`.

Report the result table, most urgent first:

- **MISSING** - the tagged class/method is gone. The patch is dead or won't bind; flag it as
  needing a fix.
- **CHANGED** - the IL2CPP metadata changed: a signature, or the method's native code `Length`.
  This doesn't depend on Ghidra, but the compiled code size also shifts when nothing meaningful
  changed (static-field access or field offsets moved). Under each CHANGED method the script
  lists the string literals and `Class.Method` calls that were added or removed. "no string/call
  changes" is usually that kind of codegen churn. For methods that do list changes, read the
  patch next to its reason and the old vs new decompiled method (`git show <rev>:<path>`). Then
  say whether the assumption on the tag still holds. `replaces` tags are the top priority: the patch re-implements the original, so
  upstream changes must be mirrored by hand.
- **TEXT-ONLY** - same metadata, but the decompiled text differs. Almost always Ghidra drift
  between runs (fields shown as raw offsets, renamed labels). Only look closer for `replaces`
  tags.

Do not edit patches in this step. List the findings and ask whether the user wants to fix any of
them now or after the refresh. Remind them that once they relaunch the game with the rebuilt
plugin, `BepInEx/LogOutput.log` should be grepped for `Failed to patch`, `PatchAll failed` and
`HarmonyException`. That catches `by-name` targets that no longer bind, which the offline check
can only infer. Also check `RecordLogDisplayPatches`' `PATCHED`/`MISSING` line.

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

End with a short recap of which steps were run, skipped, or failed, including any open 3b
game-coupled findings.
