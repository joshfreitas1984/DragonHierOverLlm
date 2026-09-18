# `KungFuData.csv`/`SummonKungFuData.csv` columns 9/10 — `StringToAttriRatio`, a FATAL variant of `StringToSpeAddData`

> Read this when a "silent stop, nothing in `BepInEx/LogOutput.log`" crash recurs after the
> `StringToSpeAddData` family (see `skipcolumns-stringtospeadddata-family.md`) has already been
> fixed for the file in question.

After the `PlotData.csv` column-9 repair/validator fix (see
`plotdata-column9-crash-and-repair-pattern.md`) let the load sequence progress all the way past
`PlotData`, `SummonData`, and into `KungFuData`/`SummonKungFuData` (confirmed via
`BepInEx/LogOutput.log` showing `StringToSpeAddData Error: ...` lines for columns 7/8/13, which are
already `SkipColumns`-protected and log-and-continue harmlessly), the game still died silently
right after `KungFuData.csv`'s "applied whole-file override" log line, with `BepInEx/LogOutput.log`
stopping mid-sequence again (no exception logged) — same silent-stop symptom as the original
`PlotData.csv` crash. `Player.log` showed the real cause:

```
FormatException: Input string was not in a correct format.
  at System.Number.ParseSingle (...)
  at GameDataController.StringToAttriRatio (System.String resource) [...]
  at GameDataController.LoadSkillData (LTCSVLoader loader, System.Int32 i, System.Boolean _summonSkill) [...]
  at GameDataController.LoadAllGameData () [...]
  at GameDataController.Start () [...]
```

**Root cause**: `KungFuData.csv`/`SummonKungFuData.csv` column 9 (`威力系数`/"Power ratio") and
column 10 (`修炼需求`/"Cultivation requirement") are `Label<number>[;Label<number>...]` cells (e.g.
`内功10`, `轻功5`, `生命上限20;内力上限20`) — same shape as the columns already protected via
`StringToSpeAddData`, but fed through a **different** decompiled method,
`GameDataController.StringToAttriRatio` (`Converter/output/_NoNamespace/GameDataController.cs`,
~line 7086): it splits the cell on `;`, regex-strips the label text from each piece, then calls
`Single.Parse` on whatever remains. Critically, **`StringToSpeAddData` catches its lookup failure
and only logs `"StringToSpeAddData Error: ..."` (non-fatal, load continues)**, but
`StringToAttriRatio` has **no try/catch around `Single.Parse`** — once the label has been
translated to English, the regex (targeting the original Chinese label text) leaves non-numeric
characters behind, and `Single.Parse`/`ParseSingle` throws an uncaught `FormatException` that kills
`LoadAllGameData` outright, with nothing written to `BepInEx/LogOutput.log` (only visible via
`Player.log`, same as the original `PlotData.csv` crash's `IndexOutOfRangeException`).

**Fix**: added columns `9` and `10` to `SkipColumns` for both `KungFuData.csv` and
`SummonKungFuData.csv` in `Tests/GameFileHandling.cs` (alongside the existing `7, 8, 13`), so these
cells pass through byte-identical from raw and are never sent to the LLM.

**General lesson reinforced**: `GameDataController.StringToSpeAddData`'s error being merely *logged*
(not fatal) had made it easy to assume every `Label<number>` cell in this game behaves the same way
— it doesn't. Before declaring a `Label<number>`/`Label<sign><number>` column "safe because
StringToSpeAddData just logs an error", decompile which specific parsing method actually consumes
that column (`StringToSpeAddData` vs. `StringToAttriRatio` vs. others) and check whether that
method's call site is wrapped in a try/catch — `LoadSkillData`'s column 7/8 calls are
`StringToSpeAddData` (non-fatal) while its column 9/10 calls are `StringToAttriRatio` (fatal), in
the exact same row/method. When investigating a new "silent stop, nothing in
`BepInEx/LogOutput.log`" case, always check `Player.log` for the actual stack trace before assuming
the fix for a previous crash didn't work — the log simply stopping is a generic symptom shared by
*any* uncaught exception inside `LoadAllGameData`, not evidence that a specific prior fix regressed.
