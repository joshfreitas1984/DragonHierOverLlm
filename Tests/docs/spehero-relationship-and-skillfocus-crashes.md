# `SpeHeroData.csv` — relationship routing (col 18) and skill-focus crash (cols 11/12)

> Read this for two related `SpeHeroData.csv` bugs found after `KungFuData.csv`/`SummonKungFuData.csv`
> were fixed (see `kungfudata-stringtoattriratio-fatal.md`).

## Column 18 (`关系设定`) — non-fatal data-loss variant: relationship routing silently fails, no crash

After the `KungFuData.csv`/`SummonKungFuData.csv` `StringToAttriRatio` fix, a full playtest
progressed cleanly through the entire `GameDataController.LoadAllGameData` sequence with **zero**
exceptions in either `BepInEx/LogOutput.log` or `Player.log` (confirmed by grepping the full
`Player.log` for `Exception` — no matches). However, right after `SpeHeroData.csv`'s "applied
whole-file override" log line, a large wave of non-fatal `Debug.Log` messages appeared:

```
角色关系Friend未设置
角色关系Relatives未设置
角色关系Enemy未设置
角色关系Master未设置
角色关系Brotherhood by blood未设置
```

("Character relationship `<label>` not set" — note the label is the *translated* English word.)

**Root cause**: `SpeHeroData.csv` column 18 (header `关系设定`/"Relationship setting") is a
`Label:ID;Label:ID;...` compound cell (e.g. `朋友:2;亲属:7;仇人:65` — "Friend:2;Relatives:7;Enemy:65")
where `Label` is one of a fixed set of Chinese relationship keywords (朋友/Friend, 亲属/Relatives,
仇人/Enemy, 师父/Master, 结拜/Brotherhood by blood) that the game's relationship-setup code compares
verbatim to decide which of `HeroData`'s `Friends`/`Relatives`/`Haters`/`Teacher`/`Brothers` lists
the paired hero ID (`2`, `7`, `65`, ...) gets routed into. Since this column had no `SkipColumns`
entry, the LLM translated the label half of every pair — once translated, the exact-match
comparison against the game's hardcoded Chinese keyword set fails for every row, and the routing
code logs `"角色关系<label>未设置"` and moves on **without crashing** (unlike the
`StringToSpeAddData`/`StringToAttriRatio` cases, this failure path has no numeric parse step to
throw on) — but the practical effect is that **no character relationships ever get set up** at all,
silent data loss rather than a crash.

This is the same underlying bug class as `NameData.csv`'s `SkipColumns=[0]` case (a cell's value is
used as an internal routing/lookup key compared against a **hardcoded, fixed set of literals** in
game code — not cross-referenced against another translated CSV table like the
`StringToSpeAddData` cases). Full decompiled confirmation of the exact parsing method was
inconclusive (the relevant `GameDataController`/`HeroData` decompiled pseudocode around this call
path suffers from the same string-literal-recovery limitations noted in `converter.instructions.md`
— several nearby string literals clearly don't match their real call-site semantics), but the
behavioral evidence (translated labels appearing verbatim inside the game's own untranslated log
message format, immediately after this exact file's override, for exactly this closed set of five
relationship-type words) is solid regardless of the precise call site — same standard already
applied for `ResourcePointTypeData.csv`'s "守城效果" column.

**Fix**: added `SkipColumns = [18]` to `SpeHeroData.csv`'s `TextFilesToSplit` entry in
`Tests/GameFileHandling.cs`.

**General lesson**: not every translation-breaks-a-lookup bug in this game is fatal — some (like
this one) fail silently via a logged, non-crashing fallback path, so **the absence of any exception
in `Player.log`/`BepInEx/LogOutput.log` does not by itself mean the pipeline's `SkipColumns`
coverage is complete**. When a clean-looking log still contains unexpected repeated Debug.Log
spam that includes obviously-translated words mixed into otherwise-Chinese log text, that's a
strong signal of exactly this class of bug — grep the raw CSVs for the same `Label:ID`/
`Label<sign><number>` compound-cell shape used by the confirmed cases so far (`;`- or
`:`-separated Chinese label immediately followed by a number) before assuming a quiet log means
the pipeline is fully correct.

## Columns 11/12 (`擅长武学`/`擅长技艺`) — fatal variant of the `ForceData.csv` 9/10 bug, crashes at new-game hero generation

`Player.log` showed an uncaught `ArgumentOutOfRangeException` ("Index was out of range... Parameter
name: index") with this call stack:

```
HeroData.RandomAttriAndSkill()
GameController.GenerateHeroData(...)
GameController.GenerateHero()
GameController.StartNewGame()
GameController.Start()
```

**Root cause**: `SpeHeroData.csv` column 11 (`擅长武学`/"Proficient martial arts", e.g.
`内功/剑法`) and column 12 (`擅长技艺`/"Proficient craft", e.g. `医术/学识`) are `'/'`-separated
skill-name label lists — the per-hero equivalent of `ForceData.csv`'s columns 9/10
(`武功专长`/`技艺专长`, `;`-separated, already fixed with `SkipColumns=[9,10,11]` — see the
`ForceData.csv` comment in `Tests/GameFileHandling.cs` and its cited `HandBookMenuController.ShowForceSkill`
crash). Both column pairs are looked up by exact string match against the same fixed internal
skill-name list to resolve into a numeric skill-slot index, populating `List<int>` fields
(`HeroData.kungfuSkillFocus`/`livingSkillFocus` for the per-hero columns,
`ForceData.kungfuSkillFocus`/`livingSkillFocus` for the per-force columns — confirmed via decompiling
`HeroData.cs`/`ForceData.cs`, both declare identically-named/typed fields).
`HeroData.RandomAttriAndSkill` (in `Converter/output/_NoNamespace/HeroData.cs`) iterates
`this.kungfuSkillFocus`/`livingSkillFocus` and uses each entry as an index into the hero's
fixed-size `baseFightSkill`/`maxFightSkill`/`baseLivingSkill`/`maxLivingSkill` lists (size 9,
slots 0-8). Translating the `擅长武学`/`擅长技艺` labels breaks the exact-match lookup, so the
resolved slot index is invalid/out of the valid 0-8 range, and indexing the fixed-size skill list
with it throws — unlike the `ForceData.csv` 9/10/11 case (which only crashes when the faction
handbook UI is opened), this one crashes immediately at new-game start because `GameController.
StartNewGame` -> `GenerateHero` -> `GenerateHeroData` -> `RandomAttriAndSkill` runs for every
procedurally-rolled hero right away.

Full decompiled confirmation of the exact HeroData-side call site that resolves the label to an
index was inconclusive (same Ghidra pseudocode string-literal-recovery limitations noted in
`converter.instructions.md` — no direct assignment to `HeroData.kungfuSkillFocus`/`livingSkillFocus`
was found in the decompiled output, likely obscured by inlining/IL2CPP codegen), but the structural
match (identical field names/types on both `HeroData` and `ForceData`, identical `/`- vs
`;`-separated skill-name-label cell shape, identical downstream fixed-size-list-indexing consumer)
is solid enough on its own — same standard already applied for the `SpeHeroData.csv` column 18 case
above.

**Fix**: added columns `11` and `12` to `SpeHeroData.csv`'s existing `SkipColumns` (alongside `18`)
in `Tests/GameFileHandling.cs`.

**General lesson**: when a game reuses the same "Label list resolved by exact-match into a
fixed-size skill/index array" pattern across multiple data tables (here: `ForceData.csv`'s
force-level skill focus columns and `SpeHeroData.csv`'s hero-level skill focus columns), fixing one
table's columns does **not** cover the other — always grep sibling CSVs for the same header
concept (`专长`/"specialty"/"proficient" wording) before assuming a `SkipColumns` fix is complete
for that whole bug class.

## Columns 3/4/5/7/8/10 — remaining `SpeHeroDataBase` load-abort hazards (`GameDataController.LoadAllGameData`)

After fixing columns 11/12/13/14/18, a `NullReferenceException` in `HeroData.RandomFaceData`
(fired both from the character-creation face-randomize button and during `GenerateHero`'s NPC
generation) turned out to be a downstream symptom of the same `LoadAllGameData`
abort-on-first-exception mechanism documented in
`Tests/docs/skipcolumns-stringtospeadddata-family.md`: `SpeHeroDataBase` itself was ending up
`Count=0` (confirmed via `DiagnosticPatches.DumpGameDataController`, see
`DragonHeirPlugin/docs/resetfacesetting-crash-investigation.md`), which meant the load sequence
aborted **during** the `SpeHeroData.csv` row loop itself, before ever reaching `SpeHeroFaceData`'s
`MaleFaceRandomID`/`FemaleFaceRandomID` population later on.

Decompiling the full `SpeHeroData.csv` row-load loop in `GameDataController.cs` (the
`Resources.Load("GameData/SpeHeroData", ...)` block) found several more `FUN_1817ff280`
fixed-vocabulary dictionary lookups beyond the already-fixed 11/12/13/14/18:

- **Column 3** (`门派`/Sect) and **column 4** (`武学流派`/Martial-arts school) — each resolved via
  `GameDataController.GetForceID`; column 4 additionally has a hardcoded literal check against
  `"默认"` ("Default") before falling back to the same lookup.
- **Column 5** (`等级`/Level-title, e.g. `掌门`/"Sect Master") — a `FUN_1817ff280` dictionary
  lookup resolving a job-rank enum value. Its player-facing display text is separately preserved
  via `DynamicStringColumnSources` (`("SpeHeroData.csv", [5])`), so translation isn't lost even
  though the column itself is skipped.
- **Column 7** (`性格`/Personality) and **column 8** (`资质`/Credentials-Talent) — both go through
  the same `FUN_1817ff280` lookup mechanism.
- **Column 10** (`立场`/Stance, e.g. `混乱/善良`) — split on `/` into two halves, each half fed
  through the same `FUN_1817ff280` lookup independently. This was the actual confirmed cause of
  the `SpeHeroDataBase.Count=0` abort: columns 3/4/5/7/8 alone were not sufficient to stop the
  crash, and only after adding column 10 did a repackage-and-relaunch cycle show
  `SpeHeroDataBase` populated with a nonzero count and no further `ResetFaceSetting`/
  `RandomFaceData` exceptions.

**Fix**: `SpeHeroData.csv`'s `SkipColumns` in `Tests/GameFileHandling.cs` is now
`[3, 4, 5, 7, 8, 10, 11, 12, 13, 14, 18]`.

**General lesson**: this file alone has needed **eleven** separate `SkipColumns` additions across
multiple investigation passes — when a load-abort symptom (`Count=0` on a database, or a crash
several methods downstream of that database's load) reappears after an earlier partial fix,
re-decompile the *entire* row-load loop for that `Resources.Load` call rather than assuming the
previously-found columns were the only hazards; `SpeHeroData.csv`'s load loop alone contains at
least 7 independent `FUN_1817ff280` call sites across different columns.
