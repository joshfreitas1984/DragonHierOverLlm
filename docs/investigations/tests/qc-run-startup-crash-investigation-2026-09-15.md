# "QC run broke game startup" investigation (2026-09-15) — RESOLVED (2026-09-16)

## Report

After the QC pass in commit `551bb94` ("LAst run"), the user reported that something in the
shipped `dumpedPrefabText.txt` had "broken the game loading" / made "the startup process of the
patch wild."

## Root cause (found 2026-09-16)

`PrefabTextWorkflow.ReconstructLine` (FanslationStudio.LlmKit repo) fell all the way back to **raw,
untranslated Chinese text** (`line.Raw`/`split.Text`) whenever a QC-corrected column's score fell
below `qualityReview.minAcceptableScore` (60) and its `QcDefectCategory` wasn't in
`autoAcceptDefectCategories` — discarding the column's already-good, pre-QC `Translated` English
text along with the rejected correction. `DynamicStringWorkflow` had the identical bug pattern.

Confirmed by isolation testing: `qualityReview.enabled: false` + repackage loaded fine;
`enabled: true` + repackage broke startup. Diffing the two `Files/Mod` builds
(`dumpedPrefabText.txt.yaml`) turned up several entries that had reverted to raw Chinese, including
the **age-rating splash notice** (`检测到您为未成年人...`) — shown on the very first boot screen,
matching the reported "wild startup" symptom. Example real cases from this run (score, category):

- `百会` (score 20, `DomainTerm`) → packaged as `百会` instead of "Meeting of the Hundred Sands"
- `行侠四方` (score 35, `LostIdiom`) → packaged as `行侠四方` instead of "Wander as a wanderer..."
- `入群会友` (score 35, `LostIdiom`) → packaged as `入群会友` instead of "Joining friends in the group"
- the full age-rating notice block (score 20, `GarbledNumber`) → packaged as raw Chinese

None of these QC *corrections* were actually bad (some, like "Baihui" for 百会, were arguably
better) — the bug was that a low score discarded the perfectly fine pre-QC translation too, not
just the rejected correction.

## Fix (2026-09-16, FanslationStudio.LlmKit repo)

1. **`qualityReview.enabled` now gates packaging, not just the QC pass.** `QualityReviewHelpers
   .IsQcReviewFresh` takes a `QualityReviewConfig` and returns `false` immediately when `enabled`
   is `false`, for every packaging path (Csv/Json/DynamicString/PrefabText). This is what made the
   isolation test above possible — flip the flag and re-run "6. Package to Game Files" (no LLM
   calls) to compare QC-on vs. QC-off output directly. See `Files/Config.yaml`'s `qualityReview:`
   comment.
2. **`PrefabTextWorkflow`/`DynamicStringWorkflow` no longer fall back to raw Chinese, ever.** A
   QC-rejected column (low score, uncovered DEFECT category) now falls back to the column's
   ordinary pre-QC `Translated` text instead of `line.Raw` — matching what
   `CsvGameDataWorkflow`/`JsonGameDataWorkflow` already did correctly. A genuine `RawFallback` case
   (unsafe/flagged/missing translation, nothing usable at all) now **omits the entry from the
   packaged dictionary entirely** instead of writing raw Chinese into `Files/Mod` — per user
   direction, an explicit raw-Chinese dictionary entry risks the runtime's own "does this still
   contain untranslated Chinese" check re-matching its own packaged output and looping, whereas a
   missing entry just means no substitution happens (same visual effect, no loop risk). Both
   `dumpedPrefabText.txt.yaml`/`dumpedPrefabTextFromOtherFields.txt.yaml` verified to contain zero
   CJK characters in any packaged `result` field after the fix, with the four examples above
   confirmed packaging their correct pre-QC English text again.

## Investigation history (kept for method, not because it's still open)

We never actually captured the real symptom (log excerpt, screen recording, or even "crash vs.
garbled text vs. hang") before starting — this section is what was ruled out along the way.

## Ruled out

1. **YAML structural corruption in `dumpedPrefabText.txt.yaml`.** Parsed cleanly with PyYAML (1019
   entries). No stray lines outside the `- raw: ...` / `  result: ...` pattern. No duplicate `raw`
   keys across `dumpedPrefabText.txt.yaml` + `dumpedPrefabTextFromOtherFields.txt.yaml` combined
   (3214 unique entries, 0 dupes) — rules out a `Dictionary.Add` duplicate-key throw in
   `PrefabTextPatches.Replacements`.

2. **A bad PrefabText entry crashing plugin load.** Read `DragonHeirPlugin/PrefabTextPatches.cs`
   end to end: the `Replacements` dictionary load and every Harmony hook (`Resources.Load`,
   scene-load, `AssetBundle.LoadAsset`, `Instantiate`, `GlobalData.AddChild`, TMP/UI setters) are
   all individually wrapped in try/catch. A malformed entry in `dumpedPrefabText*.txt.yaml`
   architecturally **cannot** throw an exception that crashes `BasePlugin.Load()` — worst case it
   logs an error and prefab-text replacement is silently disabled. This makes `dumpedPrefabText.txt`
   itself an unlikely direct cause of a hard startup crash, as originally suspected.

3. **Missing font glyphs (full-width CJK punctuation, e.g. `：` U+FF1A, in English result text).**
   Initially looked promising — dozens of "English" `result` strings in
   `dumpedPrefabText.txt.yaml`/`dumpedPrefabTextFromOtherFields.txt.yaml` still carry full-width
   Chinese punctuation instead of ASCII (age-rating splash text, the save-backup-folder message,
   several stat tooltips). **Ruled out by the user**: the `raw` (Chinese) text already uses this
   same punctuation and renders fine in the base game, so the font clearly already has these
   glyphs. The stray full-width punctuation is still a real translation-quality defect, just not a
   plausible crash cause — not fixed, not chased further.

4. **Look-alike Unicode dash/hyphen characters replacing ASCII `-` next to numbers.** Chasing the
   user's "emdash" hunch: found QC/LLM output substituting U+2011 (non-breaking hyphen), U+2013 (en
   dash), U+2014 (em dash) etc. for a plain ASCII `-` glued to a digit — e.g. raw
   `其他情侣好感-50` → result `...affection for each other ‑50` (that's U+2011, not `-`), matching
   this pipeline's own `QcDefectCategory.GarbledNumber` class. **Fix applied and verified, but
   confirmed by the user NOT to be the cause**:
   - Added `TranslationPackaging.NormalizeLookalikeDashesNearDigits` (`Tests/TranslationPackaging.cs`),
     run as a final pass at the end of `PackageFinalTranslationAsync` over every file it writes
     (CSV and YAML alike). Regex-replaces `[‐‑‒–—−]` with `-` **only**
     when directly adjacent to a digit, so legitimate em-dash prose punctuation elsewhere is
     untouched.
   - Re-ran `"6. Package to Game Files"` (rebuilds `Files/Mod` and copies it into
     `BepInEx/plugins/resources/GameData` in the live game install). Verified zero remaining
     dash-near-digit instances anywhere under `Files/Mod` afterward.
   - **This code change was left in place** (it's a real, if narrow, quality fix independent of
     this bug) — not reverted, just confirmed not to be the root cause.

## Leads that turned out irrelevant once the real cause was found

These were open questions before the isolation test pinned this to prefab text QC rejections
specifically — kept for reference, not because they still need chasing:

- Whether the same QC run's `PlotData.csv.yaml`/`KungFuData.csv.yaml` changes corrupted column 9's
  `|`/`;` structure (the documented FATAL-crash-class files) — never programmatically verified, but
  the isolation test (QC off → loads fine; QC on → broken; diff pointed at prefab text specifically)
  makes this an unlikely contributor to *this* symptom. Worth revisiting independently if a
  different startup issue shows up later.
- `DynamicStringPatches.PatchAll()` being unwrapped in `MainPlugin.Load()` — still true and still a
  latent risk (see that file), but not what caused this particular symptom.
- What "broke game loading" looked like at the log level was never captured — turned out not to be
  necessary, since the `Files/Mod` diff was conclusive on its own.
