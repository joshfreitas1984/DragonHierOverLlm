# `DynamicStringColumnSources`/`DynamicStringLabelColumnSources` — bare-fragment dictionary corruption fix (2026-08-27)

## Symptom and root cause

A save-slot debug output showed `DynamicStringPatches.ApplyDictionary`'s plain sequential
substring-replace corrupting whole-phrase compounds that had no dedicated dictionary entry of
their own — e.g. `外门弟子` → `外门Disciple` (bare `弟子` → `Disciple` fired instead), `仙霞派` (a
force/sect name) left entirely untranslated in this code path even though
`Files/Converted/ForceData.csv.yaml` already has a correct "Xianxia Sect" translation — because
the save-slot description is built from raw save data (`GameDataController.GetSaveInfo`/
`SaveLoadMenuController.GetRecentSaveSlotDescribe`), bypassing the already-translated CSV lookups
entirely. Root cause was **data completeness, not a mechanism bug** — `LoadDictionary`'s
longest-`Raw`-first sort is correct, it just had no more-specific entry to prefer over the generic
single-character fallbacks for these particular compounds.

## Fix: repeatable, config-driven extraction instead of manual dictionary curation

`Tests/GameFileHandling.cs`'s `DynamicStringColumnSources` declares `(CsvFileName, int[] Columns)`
pairs for CSV columns known to hold whole-phrase display strings read raw by some IL2CPP code
path (currently `ForceData.csv` column 1 = force/sect name, `SpeHeroData.csv` column 5 = rank/tier
tag). `ExtractDynamicStringCandidatesFromColumns` reads each configured raw CSV under
`Files/Raw/Dumped/GameData/`, pulls every distinct non-empty value from the specified columns, and
appends any not already present in the master `dynamicStrings.txt` (or a previous run of this same
method) to a **separate** dump file,
`Files/Raw/Dumped/DynamicStrings/dynamicStringsFromColumns.txt` — kept distinct from
`dynamicStrings.txt` (itself populated by reviewing/merging
`Converter/output/_dynamicStrings_candidates.txt`, not hand-authored) purely for traceability
(obvious at a glance which entries were auto-pulled from CSV columns vs. manually found in
decompiled code). Registered as its own `TextFileToSplit` entry (same
`TextFileType.DynamicStringsIL2CPP`), so it flows through the *existing*
`DynamicStringWorkflow`/`"1c." export`/merge/package pipeline unchanged — no new Workflow class or
TextFileType enum value needed. Run via `FileInputWorkflowTests`'s
`"1c-pre. ExtractDynamicStringCandidatesFromColumns"` fact, which must run before `"1c."`
(idempotent, safe to re-run any time a new `DynamicStringColumnSources` entry is added).

Packaging produces a second `Files/Mod/dynamicStringsFromColumns.txt.yaml` alongside the existing
`dynamicStrings.txt.yaml`. **Plugin-side change required:** `DynamicStringPatches.LoadDictionary`
previously looked up one exact filename (`dynamicStrings.txt.yaml`) via `FindResourceFile` — this
was generalized to `FindResourceFiles` + a glob (`DictionaryFilePattern =
"dynamicStrings*.txt.yaml"`), loading and merging every matching file's entries into one
dictionary before the longest-first sort. Adding further dynamicStrings-family dump files in
future never requires another plugin change — they just need to match the glob and be listed in
`TextFilesToSplit`.

## Second extraction mode: `DynamicStringLabelColumnSources` (2026-08-27)

Several other `SkipColumns` entries (`KungFuData.csv`/`SummonKungFuData.csv` cols 7,8,9,10,13,
`ResourcePointTypeData.csv` cols 2-4, `SkinDataBase.csv` col 2) aren't single discrete values like
a force name — they're compound `Label<sign><number>[;Label<sign><number>...]` stat/resource
modifier cells (e.g. `内功1;经脉1`, `威望+2,药材+1`). Extracting the whole cell/item would be
useless (the number differs every row, e.g. `内功1` vs `内功4`), so
`ExtractDynamicStringCandidatesFromColumns` additionally splits each cell on `;`/`,` and strips
the trailing sign+number via `StatLabelRegex` (`^[^\d+\-]+`) to keep only the repeated Label
vocabulary (e.g. `内功`, `威望`, `技艺经验`) — config lives in the sibling
`DynamicStringLabelColumnSources` array right next to `DynamicStringColumnSources`.
`NameData.csv`'s `SkipColumns=[0]` (`类别`: `姓`/`名`/`男名`/`女名`) was deliberately excluded from
both — it's a pure internal routing key never displayed to the player, so there's nothing to
translate. A real run against this game's data found ~110 distinct labels this way, several
already covered by existing whole-sentence entries in `dynamicStrings.txt` (dedup correctly
skipped `威望`/`学识` etc., already present there).
