# Translation pipeline — known-issue case studies

> This file holds detailed historical investigation notes for `Tests/`/`GameFileHandling.cs` bugs.
> It is **not** auto-loaded into agent context (unlike
> `.github/instructions/tests-translation-workflow.instructions.md`, which has `applyTo:
> Tests/**`) — read it explicitly when investigating a new "database ends up empty"/crash-on-load
> case, or when you need the exact reasoning behind an existing `SkipColumns`/`CustomColumnRepair`
> rule. Keep the instructions file itself short; put new deep-dive narratives here instead of
> growing that file again.

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
`.github/instructions/dragonheirplugin.instructions.md`'s "CONFIRMED root cause" section) as the
cause of a `LoadAllGameData` abort that cascaded into a `StartMenuController.ResetFaceSetting` /
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

### `SkinDataBase.csv` found to have the identical pattern (third file, same `StringToSpeAddData` lookup)

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

## `PlotData.csv` — a second, more severe hazard class: uncaught crash directly in `LoadAllGameData`, not the recoverable `StringToSpeAddData` miss

After fixing `SkinDataBase.csv`, the load sequence progressed much further — through `ForceData`,
`BuildingData`, `WeaponData`, `ArmorData`, `MedData`, `FoodData`, `HorseData`,
`HeroNatureTalkText`, `HeroSpeTalkText`, and even `PlotData` (a ~1.5MB raw / ~4.5MB translated CSV,
by far the largest file in the pipeline) all applied their whole-file overrides successfully. But
the game then died with **no** `DiagnosticPatches`/`CrashMitigationPatches` output at all —
`BepInEx/LogOutput.log` simply stopped after `PlotData`'s override-applied line, with no scene
load messages and no exception trace. This is a critical methodology note: **when
`BepInEx/LogOutput.log` just stops mid-sequence with no exception logged, that means an
uncaught/unrecoverable exception occurred synchronously inside `GameDataController.LoadAllGameData`
itself (or the Harmony-patched method call chain around it), not the separately-patched
`ResetFaceSetting`/`ResetPlayerTag` crash** — check Unity's own player log next:
`%USERPROFILE%\AppData\LocalLow\TppStudio\LongYinLiZhiZhuan\Player.log` (same machine, written by
the Unity engine itself, NOT by BepInEx) — it captures the actual native/managed stack trace even
for exceptions that kill the process before BepInEx's own logging/patches can react.

That Player.log showed:
```
IndexOutOfRangeException: Index was outside the bounds of the array.
  at SinglePlotChoiceData..ctor (System.String choiceDataText)
  at SinglePlotData.SetChoiceDataTexts (System.Collections.Generic.List`1[T] choiceDataTexts)
  at GameDataController.LoadAllGameData ()
  at GameDataController.Start ()
```

**Root cause**: `PlotData.csv` column index 9 (header `选项`/"Choice") is a compound field with a
*two-level* delimiter structure that `GameDataController.LoadAllGameData` (`Converter/output/_NoNamespace/GameDataController.cs`,
around line 4195) parses with zero fault tolerance:
1. The whole cell is split on `|` (char 124) into one or more choice-option strings (multiple
   selectable dialogue choices in one row).
2. Each choice-option string is passed to `SinglePlotChoiceData..ctor`
   (`SinglePlotChoiceData.cs`), which splits it on `;` (char 59) into positional parts:
   `[0]=choiceText` (the player-visible button label — the ONLY part that should ever be
   translated), `[1]=callFuc`, `[2]=callParam` (optional), then further optional parts for
   requirements (further split on `/`), relations, and cost-resource lists. The ctor explicitly
   guards `parts.Length < 2` with a managed `ArgumentOutOfRangeException`, but `SetChoiceDataTexts`'s
   own indexing loop over the outer `|`-split list has no such guard and throws a raw
   `IndexOutOfRangeException` if the split produces fewer entries than expected elsewhere in the
   loop bounds.

Because `PlotData.csv` had no `SkipColumns` entry at all, this ENTIRE structured cell (all
`|`/`;`-delimited sub-parts together, across potentially hundreds of thousands of rows) was being
sent to the LLM as one blob and translated/reconstructed as free text — any single row where the
LLM's output didn't preserve the exact original count of `;`/`|` delimiters (dropping one, adding
one via natural English punctuation, etc.) is enough to corrupt that row's structure and crash the
ENTIRE game at startup, since `LoadAllGameData` has no per-row exception isolation (this is the
same "one bad row poisons the whole sequential load" mechanism documented for `StringToSpeAddData`
above, but here the failure is NOT caught/logged-and-continued — it's a raw, fatal exception).

**Fix applied (superseded)**: an initial fix added `SkipColumns = [9]` to `PlotData.csv`, leaving
the whole choice-option column byte-identical to the raw dump. This was reverted in favor of a
proper per-column validation/repair approach (next section) since `CompoundFieldSplitter` already
decomposes this column correctly on its own — a blanket skip would have left every in-dialogue
choice button untranslated for no real reason.

**Column 8** (`调用函数`/"call function", same row) also contains `|`/`;`-structured content (e.g.
`FinishEventMission|PlotStartTutorial;Read the library`) but `LoadAllGameData` stores it as an
opaque raw string with no splitting at load time (confirmed via decompile — no `String.Split` call
on that column in the load loop) — so it's not an immediate startup-crash risk, but it may still be
parsed elsewhere at runtime when that specific plot event actually fires (not yet investigated);
worth keeping in mind if a NEW crash appears later tied to a specific in-game plot/dialogue trigger
rather than at startup.

**General lesson for large free-text files with an embedded structured sub-column**: don't assume
a column is safe just because its cell "looks like" narrative text at a glance — `PlotData.csv`'s
column 10 (`内容`/Content) is genuinely free text and safe to translate, but column 9 sitting right
next to it is a hidden compound structure. When a file is large enough that manual row-by-row
inspection isn't practical, decompile the full load loop for that specific `Resources.Load` call
FIRST (as usual) and identify every column that gets passed through `String.Split` (on any
delimiter char) before concluding a column is safe to fully translate.

### Preferred fix for this class of bug: deterministic per-file/per-column repair, not a blanket `SkipColumns`

`SkipColumns` is the right tool when a column's content genuinely should never be translated (an
icon/resource path, an internal category key). It is the WRONG tool when the column contains real
user-facing text that just happens to sit inside a structural delimiter format that
`CompoundFieldSplitter` already understands (`|`, `;`, `-`, `&`, etc. as literal separators around
individual Chinese fragments) — in that case the actual risk is narrow: an LLM occasionally
bleeding a structural delimiter character into a *translated fragment itself*, which desyncs the
game's positional parsing of the reconstructed cell. `PlotData.csv` column 9 is exactly this case:
`|` genuinely separates independent choice-options and must never appear inside a translated
`choiceText`, but the `choiceText` itself absolutely should be translated.

Important structural fact that shapes the fix: `CompoundFieldSplitter.Reconstruct` only ever does
positional `"{n}"` string substitution into a fixed literal template — it never re-parses the
template's own delimiter shape from anything the translated fragments contain. That means the
*template* can never be corrupted no matter what a fragment's translated text looks like; the only
way corruption can actually happen is if a translated fragment's own text contains a character the
template already uses as a real separator elsewhere in that same cell — the game's runtime
CSV/choice parser has no way to tell the difference once both are substituted into one string. For
`PlotData.csv` column 9 specifically, a raw `choiceText` fragment is always a single isolated
Chinese run (`CompoundFieldSplitter.Decompose` only ever extracts CJK/digit runs into a fragment,
never `|`/`;`), so it can NEVER legitimately contain `|` or `;` in the raw source text — which means
any occurrence of either character in the *translated* fragment is unambiguously an LLM artifact,
not a legitimate translation choice. That determinism is what makes an outright, guaranteed
prevention possible here (as opposed to most translation-quality issues, which can only be
detected-and-retried, not deterministically fixed).

The fix is two hooks in `FanslationStudio.LlmKit.LineValidation`, both mirroring the existing
`CustomPostRepair` hook pattern:
- **`CustomColumnRepair`** (`Func<TextFileToSplit?, int?, string, string, string>`) — invoked at the
  end of `PrepareResult`, BEFORE any validation runs. Receives `(textFile, column, raw, result)` and
  returns the (possibly repaired) result. This is the primary fix: it strips the offending
  characters from the translated fragment outright, so corruption is prevented at the source rather
  than merely detected.
- **`CustomColumnValidator`** (`Func<TextFileToSplit, int?, string, string, string?>`) — invoked at
  the very end of `CheckTransalationSuccessful`, after every built-in check has passed. Receives the
  same four arguments; return a non-null reason string to flag the result as invalid and retry, or
  null to accept it. Kept as a defense-in-depth backstop only — with the repair hook in place it
  should never actually trigger for the case it guards, since the repair has already removed the
  only characters it checks for.

Both hooks required threading an optional `int? column` parameter through `TranslateSplitAsync`
(and its internal recursive helpers — `SplitBracketsRegexIfNeededAsync`, `SplitOnCharsIfNeededAsync`,
`TranslatePiecesWithRetryAsync`), `PrepareResult`, and `CheckTransalationSuccessful`, plus all their
call sites in `TranslationService.cs` and the direct calls in `TranslationWorkflow.cs`'s
`ApplyAllRulesToCurrentTranslation`/manual-translation paths — all of which already had
`TranslationSplit.Split` (the zero-based CSV column index) in scope. See the git history on
`FanslationStudio.LlmKit/TranslationService.cs`/`LineValidation.cs` for the exact plumbing if this
needs extending further (e.g. into `CorrectSentenceBySentenceAsync`, which does not currently
receive `column`).

**This game's actual hook implementations live in `Tests/GameFileHandling.cs`**, in
`RepairGameSpecificColumn` (primary fix, wired up via `LineValidation.CustomColumnRepair`) and
`ValidateGameSpecificColumn` (backstop, wired via `LineValidation.CustomColumnValidator`) — both
registered in the static constructor alongside `CustomPostRepair`. This is the file to add to
whenever a new file+column combination turns out to need a rule like this. Keep every rule scoped to
an exact `textFile.Path == "..."` and `column == N` check (never a blanket "this character is
always bad" rule) since the same delimiter character can be perfectly legitimate translated text in
a different column or file. Current rule: for PlotData.csv column 9, any `|`/`;` in the translated
fragment is stripped unconditionally (raw fragments for this column never legitimately contain
either character), with the validator's exact-count comparison kept as a backstop in case a future
change to the repair/decompose logic ever lets a mismatch slip through undetected.

**Why this is the pattern to reach for first when the next "weird DB-style validation" case shows
up** (as it likely will, per the pattern of `StringToSpeAddData`/`SkinDataBase`/`ResourcePointTypeData`
already found in this codebase): `SkipColumns` throws away real translatable content and should be
reserved for columns that are never meant to be translated at all. Any column that's translatable
but has a narrow structural-corruption risk (a specific delimiter character that must never appear
inside a translated fragment) belongs in `RepairGameSpecificColumn`/`ValidateGameSpecificColumn`
instead, scoped to that exact file+column — prefer the deterministic repair whenever the offending
character(s) can never legitimately appear in that column's raw text (as here), and fall back to a
validate-and-retry-only rule when the character genuinely could appear in some fragments but not
others (where stripping unconditionally would risk destroying real translated content).

## `KungFuData.csv`/`SummonKungFuData.csv` columns 9/10 — `StringToAttriRatio`, a FATAL variant of the `StringToSpeAddData` hazard

After the `PlotData.csv` column-9 repair/validator fix let the load sequence progress all the way
past `PlotData`, `SummonData`, and into `KungFuData`/`SummonKungFuData` (confirmed via
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

## `SpeHeroData.csv` column 18 (`关系设定`) — non-fatal data-loss variant: relationship routing silently fails, no crash

After the `KungFuData.csv`/`SummonKungFuData.csv` `StringToAttriRatio` fix above, a full playtest
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

