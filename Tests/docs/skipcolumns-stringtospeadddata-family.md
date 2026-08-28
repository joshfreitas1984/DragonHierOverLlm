# `SkipColumns` family: `StringToSpeAddData` label cross-reference crashes

> Read this when investigating a new "database ends up empty (`Count=0`), everything loaded after
> it is also null" crash in `GameDataController.LoadAllGameData`.

## Known-required `SkipColumns` additions: effect-string label columns that cross-reference other files

`HeroTagData.csv` ("效果"/"Effect", column index 4) and `ResourcePointTypeData.csv`
("守城效果"/"Defense effect", column index 4) both encode a `Label<sign><number>` cell (e.g.
`力道潜力+5;力道+5`, `;`-separated) where `Label` is not just display text — `GameDataController`
looks the label up by **exact string match** against label text in `ForceSpeAddDataBase.csv`
(`speAddDataBase`/`forceSpeAddDataBase`) to resolve which stat it modifies
(`GameDataController.StringToSpeAddData`, confirmed for `HeroTagData.csv` via decompiled
`GameDataController.cs`). Since this pipeline translates every file's label text independently,
an LLM can translate the "same" underlying Chinese label differently in `HeroTagData.csv` vs.
`ForceSpeAddDataBase.csv`, breaking the exact-match lookup — this was root-caused (see
`DragonHeirPlugin/KNOWN_ISSUES.md`'s "CONFIRMED root cause" section) as the cause of a
`LoadAllGameData` abort that cascaded into a `StartMenuController.ResetFaceSetting` /
`ResetPlayerTag` crash and an incomplete-resource-dump regression.

**Required fix**: add `SkipColumns = [4]` to the `HeroTagData.csv` entry, and `SkipColumns = [2, 3, 4]`
to the `ResourcePointTypeData.csv` entry, in `Tests/GameFileHandling.cs`'s `TextFilesToSplit` (same
pattern as `NameData.csv`'s `SkipColumns = [0]` and `AreaData.csv`'s `SkipColumns = [3]`) so these
cells are never decomposed/translated and pass through verbatim from the raw CSV.
`ResourcePointTypeData.csv` needed **three** columns skipped, not just the effect column that
matches `HeroTagData.csv`'s pattern — its "资源"/Resources column (2) and "加成"/Bonus column (3)
are *also* Label+Number compound cells cross-referenced by exact string match against other tables
(an internal resource-type table, and `forceTechDataBase`/`TechDataBase.csv`'s label column,
respectively) — decompiling only as far as the first obviously-matching column (the effect column)
undercounted the actual hazard surface for this file; when in doubt, decompile the *entire*
per-file load loop in `GameDataController.LoadAllGameData`, not just the column that looks like an
exact analog of an already-fixed file. After making this change, re-run the translation/package
workflow (steps in `Tests/*.cs`, per the numbered workflow in the instructions file) to regenerate
`Files/Mod/HeroTagData.csv` and `Files/Mod/ResourcePointTypeData.csv` with the affected columns
restored to original Chinese — per this repo's testing preference, don't hand-patch the
already-packaged `Files/Mod/*.csv` rows directly; fix `TextFilesToSplit` and re-run the pipeline
so the real fix is verified end-to-end.

**Also confirmed safe (don't need `SkipColumns`)**: `HeroTagData.csv`'s column 2 ("价值"/Value) is
plain numeric (`Int32.Parse`, e.g. `1`, `2`, `4`) and column 3 ("影响目标"/Affect the target) only
ever contains the ASCII enum-member literals `Self`/`SelfTeam` in the actual game data (verified by
scanning every row's raw column-3 value) — `Enum.Parse` against those two literal words is safe
since `CompoundFieldSplitter` never touches pure-ASCII cells with no CJK content, regardless of
`SkipColumns`.

**Second-order bug found while applying this fix**: after adding the first `SkipColumns` entries,
the crash still recurred identically. Root cause was a **separate, pre-existing packaging bug** in
`GameFileHandling.PackageFinalTranslationAsync` — it never checked `SkipColumns` at all in the
per-row template-reconstruction path, and its "plain columns" path's `SkipColumns` handling
(`splits[split.Split] = split.Text`) ran once per leftover `TranslationSplit` fragment, which for a
column with more than one fragment (exactly the shape of a stale multi-fragment entry left over in
`Files/Converted/*.csv.yaml` from before the column was added to `SkipColumns`) overwrote the cell
with only the *last* fragment's raw text instead of the whole original cell — an even worse
corruption than a bad translation, since the result isn't even valid `Label+Number;Label+Number`
syntax anymore. Both packaging loops now `continue`/skip entirely for any `SkipColumns` column,
leaving `splits[]` exactly as parsed from `line.Raw` by `ParseCsvRow` at the top of the row loop.
No manual cleanup of `Files/Converted/*.csv.yaml` is needed — once a column is skipped, the
packaging code never reads its stale `TranslationSplit`/`FieldTemplate` entries again regardless of
what's still sitting in that YAML file.

If another file is later found to have the same symptom (a database ending up empty/`Count=0`
with everything loaded after it in `LoadAllGameData` also null, rather than a graceful per-row
skip), suspect the same class of bug: search the file's columns for a `Label<sign><number>` or
similar compound cell and check whether `GameDataController` cross-references that label against
another CSV-backed table by exact string match, using `Converter --filter "GameDataController"`
grepped for the field name involved. Decompile the *entire* column-by-column load loop for that
specific `Resources.Load` call before concluding which column(s) need `SkipColumns` — as this file
demonstrated, more than one column in the same row can independently do a label cross-reference,
and stopping at the first match found can still leave the database silently empty.

## `SkinDataBase.csv` found to have the identical pattern (third file, same `StringToSpeAddData` lookup)

After fixing `HeroTagData.csv`/`ResourcePointTypeData.csv` and re-testing, the load sequence
progressed much further (`resourcePointTypeDataBase.Count=18`, `resourcePointDataBase.Count=130`,
`heroTagDataBase.Count=391`, `innDataBase.Count=10` all correctly populated) but still aborted
before `loveableSpeHeroList`, now stopping right after `SkinDataBase.csv` (`skinDataBase.Count=0`).
Decompiling that load loop confirmed column 2 ("加成效果"/Bonus effect, e.g. `伤害0.02`, `意志2`,
`学识4`) is fed through the same `GameDataController.StringToSpeAddData` label lookup as
`HeroTagData.csv`'s effect column. Fixed by adding `SkipColumns = [2]` to `SkinDataBase.csv`'s
`TextFilesToSplit` entry.

**General pattern confirmed across three files now**: any column whose cells look like
`ChineseLabel<sign><number>` (optionally `;`-separated for multiple stat bonuses in one cell) is
almost certainly fed into `StringToSpeAddData` and must be added to `SkipColumns`. When
investigating a new "database ends up empty" case, grep the raw dumped CSV for this cell shape
first (`Label` followed directly by `+`/`-` and a number) before doing a full decompile pass — it's
a fast, reliable heuristic that has held for `HeroTagData.csv`, `ResourcePointTypeData.csv`, and
`SkinDataBase.csv` so far. `GameDataController.StringToSpeAddData` is called from multiple places in
`LoadAllGameData` (grep the decompiled `GameDataController.cs` for every call site, not just the
first one found) as well as from `LoadSkillData` (used for `KungFuData.csv`/`SummonKungFuData.csv`)
— though note `kungfuSkillDataBase`/`summonSkillDataBase` were observed to be `null` even in a
confirmed-working run with `loveableSpeHeroList.Count=57`, suggesting those two databases are lazy
-loaded outside the title-screen `LoadAllGameData` pass and are not part of this crash's call path;
don't assume every `null`/`Count=0` field is a symptom of this bug without first checking whether
that same field is also `null`/`0` in a known-good baseline run.

**Verifying a `SkipColumns` fix without a full game relaunch**: the `"6. Package to Game Files"`
xUnit fact in `FileOutputWorkflowTests.cs` (`GameFileHandling.PackageFinalTranslationAsync` +
copying `Files/Mod` to the deployed `BepInEx/plugins/resources/GameData`) can be run directly via
the test runner after an edit to `TextFilesToSplit`/`GameFileHandling.cs` — it's pure local file
repackaging with no LLM calls involved, so it doesn't violate this repo's "don't batch-run the
numbered workflow facts" guidance (that guidance is about steps that call the LLM or mutate
`Files/Converted`'s accumulated translations, not this repackaging step). This confirms the
regenerated `Files/Mod/*.csv` and its deployed copy are correct before spending a full game
relaunch cycle checking `BepInEx/LogOutput.log`.
