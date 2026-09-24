# Plan: name spacing (`<Name1> <Name2>`) and leftover-Chinese hero names (2026-09-24)

**Status: Part 1 (spacing/casing for already-translated names) implemented. Part 2 (old-save
leftover-Chinese hero names) still parked/not started.**

## Goal

1. Player (main character) name should display/store as `<Name1> <Name2>` (currently no space).
2. `<Name2>` should be proper-cased.
3. Generated hero names that still contain raw Chinese (baked in before `NameData.csv` was
   translated) should display correctly, ideally self-healing in the save like
   `PlotSaveResyncPatches` does for plot text.

## Findings

### (a) Player name — root cause

Native game code (IL2CPP decompile), not a plugin bug. Character creation does a bare
`String.Concat`, no separator:

- `StartMenuController.ResetPlayerName()` — `Converter/output/_NoNamespace/StartMenuController.cs:2005-2006`
- `StartMenuController.SetFliteredPlayerName(string)` — same file, `:2112-2113`

No existing DragonHeirPlugin patch touches either method.

**Fix shape**: Harmony patch on these two methods to join with `" "` and proper-case Name2.
Safe — this is user input at creation time, not a save/lookup identity key referenced elsewhere.

### (b) Generated hero names — root cause

`GameDataController.GenerateRandomHeroName` (`GameDataController.cs:7615-7757`) draws from live
`familyNameDataBase`/`givenNameDataBase`/`maleGivenNameDataBase`/`femaleGivenNameDataBase` lists
(populated from `Files/Raw/Dumped/GameData/NameData.csv` → `Files/Converted/NameData.csv.yaml` →
`Files/Mod/NameData.csv`) and concatenates with, again, bare `String.Concat` (line 7715, no
space). The result is written once into `HeroData.heroName` (plain string,
`HeroData.cs:67`) and read back verbatim forever via `HeroData.HeroName(bool useSetName)`
(`HeroData.cs:11100-11130`) — never re-resolved.

This is the same "frozen at snapshot time" bug class as `PlotData.Clone()`
(see [save-embedded-plot-text-investigation.md](save-embedded-plot-text-investigation.md)), just
via a plain-string bake instead of a `Clone()` round-trip:

- Heroes generated **before** `NameData.csv` was translated → `heroName` baked as raw Chinese,
  permanently, in that save.
- Heroes generated **after** → already English at generation time, but still missing the space.

Unlike `PlotData`, there is no ID to resync `heroName` against (it's a free string, not a table
lookup keyed by ID), so the `PlotSaveResyncPatches` "look up live row by ID" approach doesn't
transfer directly. The realistic fix for old saves is a display-time patch that runs any residual
raw-Chinese fragments through the existing `HeroNamePatches._namePartDictionary`
(`heroNameParts.txt.yaml`) fragment translator.

### (c) Blast-radius check: is `HeroData.HeroName()` safe to reformat directly?

Checked all ~90+ call sites of `HeroData.HeroName(`. Two findings:

1. **No identity/save-matching risk.** `HeroName()`'s return value is never compared with `==`/
   `.Equals`, never a dictionary key, never matched against `PlotData.sourceName`/`targetName`/
   `checkName`, never used in a save-state `if`. Essentially all call sites are display
   (UI `Text`/TMP assignment, `String.Format`/`String.Concat` building display strings,
   `GlobalData`'s `#$TargetInteractName#` dialogue-placeholder substitution). So mutating the
   *save's* `heroName` field or its display value does not risk breaking hero lookup by name, mail,
   or quest/plot targeting logic. (This differs from `PlotData.targetName`, which — per the
   existing investigation doc — does store raw Chinese hero names as an identity key; that field
   is separate from `HeroData.heroName` and is not touched by this plan.)

2. **One real dependency to respect.** `GameController.GetHeroName(int sourceID, int targetID)`
   (`GameController.cs:32870-32873`) — the method that builds relationship titles like "Senior
   Sister Jiang" — does:

   ```
   fullName = HeroData.HeroName(targetID,0,0);
   familyName = HeroData.HeroFamilyName(targetID,0);
   givenNameOnly = fullName.Replace(familyName, "");   // strip family-name substring
   ```

   This assumes `HeroName()`'s output literally *contains* `HeroFamilyName()`'s output as a
   contiguous, unmodified substring, family-first. `DragonHeirPlugin/HeroNamePatches.cs`'s
   existing Harmony postfix on `GetHeroName` then does exact/suffix dictionary matching against
   that raw output shape to translate relationship titles. **A Postfix that reformats
   `HeroData.HeroName()`'s return value globally (reordering, inserting a space, re-casing) would
   propagate into this substring logic and likely break `HeroNamePatches`' relationship-title
   translation.**

   Conclusion: don't patch `HeroData.HeroName()` itself. Patch narrower, further downstream —
   either at the specific UI-facing display call sites, or via a new dedicated
   "display name" formatting helper that the plugin calls explicitly only where a hero's own name
   is shown to the player (roster list, hero detail panel, etc.), leaving the raw method/field
   untouched for everything else (title computation, dialogue substitution internals).

### (d) Existing infrastructure to build on

- `DragonHeirPlugin/HeroNamePatches.cs` — already has `_namePartDictionary`
  (`heroNameParts.txt.yaml`, fragment translator), `_fullNameDictionary`/
  `_reverseFullNameDictionary` (`heroFullNames.txt.yaml`, whole-name translator + reverse lookup),
  and `FormatWithPrefix` (`:253-270`) which already does `$"{english} {TranslateNamePart(prefix)}"`
  — i.e. already knows the "space between composed parts" idiom, just not applied to `heroName`/
  player name.
- `DragonHeirPlugin/PlotInteractControllerPatches.cs:22-46` — `WorldData.GetHero` Prefix that
  reverse-translates a display name back to raw Chinese for lookup purposes. Confirms the game's
  own internal logic elsewhere (not `HeroName()`, but hero-by-name lookups generally) can depend on
  raw Chinese identity strings — a reminder to keep any new formatting change display-only and not
  propagate into whatever `WorldData.GetHero` receives.
- No `ProperCase`/`TitleCase`/name-joining helper exists anywhere yet in DragonHeirPlugin — needs
  to be written (trivial: capitalize first letter of Name2, lowercase rest, or title-case if
  Name2 can be multi-word).

## Part 1: implemented (2026-09-24) — `<Name1> <Name2>` spacing/casing for already-translated names

Rather than the two separate source-level patches originally proposed above (`StartMenuController`
and `GenerateRandomHeroName`), this landed as a single display-time `HarmonyPostfix` on
`HeroData.HeroName(bool useSetName)` in `DragonHeirPlugin/HeroNamePatches.cs`
(`HeroNamePostfix`/`InsertFamilyGivenSpace`). Reasoning for the change of approach:

- `HeroData.HeroName()` is the one getter *every* hero's own name reads through, including the
  player's — the player is stored as an ordinary `HeroData` (confirmed via `GlobalData`'s
  `"#$PlayerName#"` placeholder substitution reading the same `heroName` field the player's
  `StartMenuController` name-entry flow writes into). So one patch here covers the player and every
  NPC/hero, instead of needing a separate, much harder to verify patch on
  `StartMenuController.ResetPlayerName`/`SetFliteredPlayerName` (raw IL2CPP-pointer-arithmetic
  decompiled code with platform-SDK/profanity-filter branching — no clean, confidently-identified
  patch point was found there without live testing).
- It does **not** touch `GenerateRandomHeroName`, `HeroData.heroName`, or `HeroData.heroFamilyName`
  at all — per the (c) blast-radius findings above, mutating the *stored* value risks the
  `GameController.GetHeroName` family-name-stripping (`fullName.Replace(familyName, "")`) and
  `PlotInteractControllerPatches`-style identity lookups. Formatting only what `HeroName()` *returns*
  keeps every consumer of the raw stored fields (title computation, save data, `WorldData.GetHero`
  lookups) working exactly as before.
- Guarded to a no-op unless the name is already fully translated (no CJK characters in either the
  family or given part) — an untranslated (still-raw-Chinese) name is left completely unchanged, so
  this only affects already-English player/hero names, not the old-save Chinese case (that's Part 2,
  still not implemented).
- Skips the `useSetName && HaveSetName()` branch (a player-set custom nickname,
  `"<i>Nickname</i>"`) — that's not a family+given generated name and must not be reformatted.
- Because `GameController.GetHeroName`'s relationship-title logic also calls `HeroData.HeroName()`
  internally and does its own `String.Replace(fullName, familyName, "")` to isolate a bare given
  name for a few narrow address cases (the "former lover"/"儿" child-affix fallback in
  `HeroNamePatches.Translate`), the now-inserted space could otherwise leak through as a stray
  leading space on that isolated fragment. Hardened by trimming in `Translate` (new
  `TranslateNamePartTrimmed` helper) wherever it consumes such a fragment.

Build verified (`dotnet build DragonHeirPlugin/GamePlugin.csproj`) — no new warnings. Not yet
verified live in-game (no ability to launch the game from this session).

### Casing rule chosen

Only the given name's first character is upper-cased (`char.ToUpperInvariant`); everything after it
is left exactly as translated. This avoids corrupting an already-correctly-cased compound given name
(e.g. two capitalized dictionary fragments concatenated, such as `"MeiLing"`) that a full
lower-then-capitalize pass would have mangled.

## Part 2: leftover Chinese in old-save hero names — still parked

Not implemented. Would need to detect raw-Chinese fragments still present in an old save's
`heroName`/`heroFamilyName` and run them through `HeroNamePatches`' existing
`_namePartDictionary`/`_fullNameDictionary` translators before applying the same spacing/casing —
same shape as this file's Part 1 postfix, just with an added translation step gated on `ContainsCjk`
instead of skipping when true. Open questions before doing that:

- Whether the existing `heroNameParts.txt.yaml`/`heroFullNames.txt.yaml` fragment coverage
  (currently sourced from `SpeHeroData`/story-hero name extraction) is broad enough to cover
  *generic* random-hero family/given-name fragments too, or whether `NameData.csv`'s own
  raw→translated column mapping needs to be loaded as a second dictionary source.
- Whether to also self-heal the save file (write the improved name back into `HeroData.heroName`),
  or keep this purely cosmetic/display-time like Part 1 and the relationship-title patches already
  are — self-healing reintroduces the stored-field mutation risk from (c) above and would need the
  same kind of identity-guard reasoning `PlotSaveResyncPatches` uses for `plotText`.
