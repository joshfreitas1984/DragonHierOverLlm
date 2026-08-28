# DynamicStringsIL2CPP extraction sources — investigation narratives

> Current-state summary of what these sources are and how to run them lives in
> `tests-translation-workflow.instructions.md`. This doc has the fuller investigation reasoning
> behind two of them.

## Third source (`DynamicStringOtherTextFields`) — the `plotText`/`describe`-family correction

An earlier note claimed `plotText`/`tutorialText`/`choiceText`/`startRemindText`/`describe`/
`eventDescribe`/`jobDescribe` fields "are already populated from the existing CSV workflow, no
runtime patch needed" (a comment that used to live in `DragonHeirPlugin/PrefabTextPatches.cs`).
**Verified empirically wrong**: grepped every raw value sampled from these fields against every
file in `Files/Raw/Dumped/GameData/*.csv` — zero matches for any of them. These fields are long
paragraphs/sentences on custom data classes (`SinglePlotData`, `InnData`, `EventData`-like
structures), not baked directly onto a `TMP_Text`/`UI.Text` component, and have no CSV source at
all — they're populated from `Files/Raw/Dumped/PrefabText/dumpedOtherText.txt` (the
diagnostic-only dump `AssetDumperWorkflowTests.cs` writes for every non-primary MonoBehaviour
field). Do not trust that old doc comment for any other field without similarly verifying against
the CSVs.

Despite being long-form rather than short labels, these fields belong in the **DynamicStrings**
(substring-replace) mechanism, not `PrefabText` (whole-string load-time scan) — `PrefabTextPatches.cs`
only inspects a `TMP_Text`/`UI.Text` component's `text` value once, at
`Resources.Load`/`AssetBundle.LoadAsset`/scene-load time, and never re-checks it afterward, so it
would never see a value assigned later at arbitrary runtime (e.g. when a plot dialog or tutorial
popup actually opens) — which is exactly when these fields get copied onto a UI component's
`.text`. `DynamicStringPatches.cs`, by contrast, patches the `TMP_Text.text`/`UI.Text.text`
**setters** themselves (sink-level, field-agnostic), so it catches the value the moment it's
actually displayed regardless of which source field it came from — exactly what these need.
`DynamicStringPatches.LoadDictionary` already sorts entries longest-first specifically so a
full-paragraph entry can never be corrupted by a shorter, unrelated fragment matching part of it
first, and the existing `GamePlaceholderTokenRegex`/`CheckTransalationSuccessful`
placeholder-preservation check already runs unconditionally (not just for CSV columns), so no new
validation was needed for the longer/paragraph case.

Each field was sampled for noise (checked for stray ASCII-letter runs not part of a
`#Placeholder#` token) before being added: `plotText` (415 total, 3 suspicious — all confirmed
legitimate `<color=red>` markup), `choiceText` (160/160 clean), `describe` (247/247 clean),
`startRemindText` (240/240 clean), `eventDescribe` (27/27 clean), `jobDescribe` (12/12 clean),
`tutorialText` (308 total, 7 suspicious — all confirmed legitimate key-name references like
`Shift`/`WSAD`/`Tab` inside `<b>...</b>` tags). `data` and `targetName` were sampled too and found
too noisy to promote wholesale (mix real content with internal asset/UI names or config-string
fragments on the exact same field name) — deliberately left out; add a genuinely missing string
from one of those two fields directly to `dynamicStrings.txt` instead.

## Fourth source (`ExtractDynamicStringCandidatesFromIl2CppStringMap`) — the staleness problem it fixes

Unlike the other three sources (which read a pre-dumped file), this one actively regenerates its
own upstream input: it shells out (`System.Diagnostics.Process`, `dotnet run --no-build --`) to
the sibling `Converter` project to regenerate `Converter/output/_dynamicStrings_candidates.txt`
FRESH from the current `Converter/output/_string_map.csv` every time this fact runs
(`--dynamic-string-candidates --exclude-file <dynamicStrings.txt>`), then appends any
genuinely-new entries to `dynamicStringsFromColumns.txt` using the same seen-set dedup pattern as
the other sources.

**Added specifically because** two real missing phrases (`随机敌人数量`/`非本门弟子经验`) turned
out to be a pure staleness problem — the extraction logic itself was already correct, but nothing
forced re-extraction after a game patch changed `_string_map.csv`, so an old on-disk candidates
file silently hid new strings. Regenerating unconditionally as part of "1c" makes that failure
mode structurally impossible going forward. No-ops gracefully (does not fail the test) if
`Converter/output/_string_map.csv` doesn't exist yet (fresh clone, full decompile pipeline not
run) or the subprocess fails for any reason — the other three sources still work independently.
`Converter/Services/StringMapExtractor.cs`'s `IsExoticScriptNoise` filter (see
`converter.instructions.md`) keeps BCL/ICU internal Unicode-table noise strings out of the
regenerated candidates before they ever reach this source.
