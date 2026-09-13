# AddLog narrative translation naturalness

**Status: DONE, confirmed working in play (2026-09-13).** Isolation, naturalization, and the
runtime performance stretch goal are all complete. See
[`herodetailpanel-slow-load-investigation.md`](herodetailpanel-slow-load-investigation.md) for the
runtime routing/perf side of this work (the `RecordLogDisplayPatches.cs` fix and the two further
bugs found while confirming it in play); this doc covers the translation-content side (which
templates, which fixes) in the `Tests/` and `DragonHeirPlugin/` pipelines.

## Background

The finalized narrative lines that flow through `HeroData.AddLog`/`AreaData.AddLog`
(HeroDetailPanel's Log tab, AreaLog, PlotPanel's RecordScrollView) originally read as mechanically
fragment-translated rather than natural English once fully assembled - missing connective words,
awkward capitalized fragments mid-sentence, retained full-width Chinese punctuation, literal
word-for-word joins where a template's placeholders got filled with independently-translated
fragments. This was a translation-quality problem in the `dynamicStrings*.txt.yaml` template
`Result` values, not a runtime-patch bug - `HeroData.recordLog`/`AreaData.recordLog` are persisted
save fields, so translation for this feed stays exactly where it is for everything else:
display-time only, via `DynamicStringPatches`, never baked into the save (see the "rejected
approach" section of the perf investigation doc for why a source-level translate hook was tried and
reverted).

## 1. Isolation

Traced all ~65 `HeroData.AddLog`/`AreaData.AddLog` call sites across `AIController.cs`,
`GameController.cs`, `HeroData.cs`, `AreaData.cs`, `PlotController.cs` (decompiled source) to 69
distinct `String.Format` Raw templates, curated into
`Tests/DynamicStringSources.LogNarrativeTemplates`. Six further AddLog call sites build their line
via `String.Concat`-glued generic fragments (e.g. `"的"`, `"了"`, `"拜入了"`) rather than a
self-contained template and were deliberately excluded - see that field's doc comment for the full
list and rationale (pulling a fragment that generic into its own file would risk breaking unrelated
non-log text that shares it).

Mechanism (`Tests/` pipeline side):
- `Tests/DynamicStringExtraction.ExtractLogNarrativeCandidates` (fact `"4g."` in
  `FileInputWorkflowTests.cs`) pulls matching lines out of the master `dynamicStrings.txt` dump into
  a new dedicated `dynamicStringsLogNarratives.txt` file - the same "carve into a separate file"
  treatment already used for `heroNameParts.txt`/`forceNameParts.txt`, chosen over a tag/category
  field because the underlying dump format is a flat, unstructured line list with no per-entry
  metadata.
- `dynamicStringsLogNarratives.txt` was added to `DynamicStringDedupePriorityOrder` **ahead of**
  `dynamicStrings.txt`, so the cross-file dedup pass (fact `"5."`) is what actually removes the
  now-duplicated lines from the master dump - `ExtractLogNarrativeCandidates` only ever copies, it
  never removes.
- A new `TextFileToSplit` entry in `TextFileConfiguration.cs` packages it through the same
  `DynamicStringsIL2CPP` plumbing as every other dynamic-string file.
- Full mechanism detail: `Tests/docs/dynamicstrings-pipeline-architecture.md`'s "Log-narrative
  isolation" section.

**Re-deriving the list after a future game update**: `Converter/Scripts/ExtractAddLogTemplates.ps1`
re-scans a fresh decompile for `AddLog` call sites and traces each back to its template, producing
a candidate list for review (it independently reproduced 65 of the 69 templates on its own; see the
script's header for its one known gap - a single call site inlining several sibling-branch literals
directly rather than through one variable, needing manual expansion each time).

## 2. Naturalization

Rather than playing a fresh session, pulled every template's actual packaged `Result` straight out
of the existing `Files/Mod/dynamicStrings.txt.yaml` corpus (it already had translations for nearly
all 69 - only the one contentless template, `"{0}{1}{2}，{3}"`, had none and was skipped, since it
has no fixed literal words at all to naturalize). Added natural-English overrides for the rest to
`Tests/TranslationPackaging.DynamicStringResultOverrides` - the same exact-`Raw`-match mechanism
documented in `.github/instructions/tests-translation-workflow.instructions.md`, applied
unconditionally at packaging time so a future re-export/re-translation can never silently regress
the fix. All rewrites use gender-neutral "they/their" (the original mechanical translation
hardcoded "he" in at least one case) and read as single natural sentences rather than
placeholder-boundary fragments.

Verified by running the actual pipeline (facts 3-6, then packaging) and confirming all 68
overridden templates' `Result` values landed correctly in `Files/Mod/dynamicStringsLogNarratives.txt.yaml`
before deploying to the live game.

## 3. Runtime performance stretch goal

Done - see `herodetailpanel-slow-load-investigation.md` for the full story. Summary: the actual
performance win did not come from routing the display-time `Text` component through a smaller
template list (that mattered far less than expected, since by the time text reaches a component
setter the cost had already been paid). The real fix was `RecordLogDisplayPatches.cs`, which
replaces `HeroData.GetRecordLog`/`AreaData.GetRecordLog` entirely - the base game built the
displayed blob via a loop of `String.Concat` calls (one per entry), and `DynamicStringPatches`'
global `String.Concat` postfix re-ran the *full* template corpus on every iteration against the
ever-growing, increasingly-mixed-language blob. The replacement translates each entry individually
(against only the small isolated log-narrative list) before joining with a `StringBuilder`,
eliminating the repeated full-corpus passes entirely.

Confirmed working in play by the user (2026-09-13), after also fixing two unrelated bugs surfaced
during that verification (a missing Harmony patch registration, and a `PerfInstrumentation`
reentrancy crash) - see the perf investigation doc for both.
