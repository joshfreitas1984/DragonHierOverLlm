# `PlotData.csv` column 9 crash and the preferred repair-over-skip pattern

> Read this when: (1) investigating a fatal crash directly inside `GameDataController.LoadAllGameData`
> with no exception logged to `BepInEx/LogOutput.log` (check `Player.log` instead), or (2) deciding
> whether a new hazardous column should get `SkipColumns` vs. a `CustomColumnRepair`/
> `CustomColumnValidator` rule.

## `PlotData.csv` — a second, more severe hazard class: uncaught crash directly in `LoadAllGameData`, not the recoverable `StringToSpeAddData` miss

After fixing `SkinDataBase.csv` (see `skipcolumns-stringtospeadddata-family.md`), the load sequence
progressed much further — through `ForceData`, `BuildingData`, `WeaponData`, `ArmorData`,
`MedData`, `FoodData`, `HorseData`, `HeroNatureTalkText`, `HeroSpeTalkText`, and even `PlotData` (a
~1.5MB raw / ~4.5MB translated CSV, by far the largest file in the pipeline) all applied their
whole-file overrides successfully. But the game then died with **no** `DiagnosticPatches`/
`CrashMitigationPatches` output at all — `BepInEx/LogOutput.log` simply stopped after `PlotData`'s
override-applied line, with no scene load messages and no exception trace. This is a critical
methodology note: **when `BepInEx/LogOutput.log` just stops mid-sequence with no exception logged,
that means an uncaught/unrecoverable exception occurred synchronously inside
`GameDataController.LoadAllGameData` itself (or the Harmony-patched method call chain around it),
not the separately-patched `ResetFaceSetting`/`ResetPlayerTag` crash** — check Unity's own player
log next: `%USERPROFILE%\AppData\LocalLow\TppStudio\LongYinLiZhiZhuan\Player.log` (same machine,
written by the Unity engine itself, NOT by BepInEx) — it captures the actual native/managed stack
trace even for exceptions that kill the process before BepInEx's own logging/patches can react.

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
in `skipcolumns-stringtospeadddata-family.md`, but here the failure is NOT caught/logged-and-continued
— it's a raw, fatal exception).

**Fix applied (superseded)**: an initial fix added `SkipColumns = [9]` to `PlotData.csv`, leaving
the whole choice-option column byte-identical to the raw dump. This was reverted in favor of a
proper per-column validation/repair approach (below) since `CompoundFieldSplitter` already
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

## Preferred fix for this class of bug: deterministic per-file/per-column repair, not a blanket `SkipColumns`

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
