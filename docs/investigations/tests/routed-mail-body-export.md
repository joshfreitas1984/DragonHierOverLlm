# Routed mail body export investigation

## Symptom

A routed mail was still displayed incorrectly at runtime. The raw value was:

```text
姜婉-小师妹突发高烧，卧病在床！#PlayerName#<b>速回门派</b>，和大家一起想想办法！
```

The game routes mail through `PlotGetNewMail;<Sender>-<Body>`, but the runtime mail display path splits the sender prefix before displaying the body. The translation dictionary therefore needs both the full routed value and a body-only alias.

## Findings

- The runtime behavior was not the correct place to add a one-off prefix workaround. The alias belongs in the translation/export lifecycle so it can be translated, quality-controled, and packaged normally.
- The dedicated raw source is `Files/Raw/Dumped/DynamicStrings/dynamicStringsRoutedMailBodies.txt`.
- The structured source `Files/Raw/Dumped/PrefabText/dumpedOtherText.txt` contains 143 `PlotGetNewMail` records.
- The missing `姜婉-小师妹...` value is not present in that structured dump. It is present in the master `Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt` dump.
- The master dump is not a complete mail source. It also contains unrelated hyphenated values such as `姜婉-1`, `姜婉-3`, and `姜婉-负3`, so every bounded-prefix candidate must not be treated as mail.

## Root cause of the 8-line result

`RoutedMailExport.AddBodyAliases` expects values in the form:

```text
<Sender>-<Body>
```

The first implementation passed values that still began with `PlotGetNewMail;`. Because the helper looked for the first hyphen at positions 2 through 4, only a few accidental values passed the check. The dedicated file consequently remained at 8 stale lines even though the extraction fact passed.

The fix strips `PlotGetNewMail;` while preserving the sender prefix before calling the alias helper.

## Current workflow

`Tests/FileInputWorkflowTests.cs` owns the explicit workflow fact:

```text
4h. ExtractMailBodies
```

It calls `RoutedMailExport.AddBodyAliasesToRawDump` before the cross-file deduplication and dynamic-string export steps. Generic export does not invoke this extraction implicitly.

`RoutedMailExport` now:

1. Reads and parses all structured `PlotGetNewMail` records from `dumpedOtherText.txt`.
2. Reads `dynamicStrings.txt` only for mail-shaped master candidates with a sender separator at index 2 through 4 and both `#PlayerName#` and `<b>` markers.
3. Converts each routed value to its body-only alias.
4. Removes an optional trailing `-true` route flag.
5. Rebuilds `dynamicStringsRoutedMailBodies.txt` deterministically rather than preserving stale partial output.

The master `dynamicStrings.txt` file is not modified.

## Verification

The focused `4h. ExtractMailBodies` fact was run after a fresh `Tests` build.

Result:

- 143 structured routed-mail bodies
- 1 additional mail-shaped candidate from `dynamicStrings.txt`
- 144 generated body aliases
- The `小师妹突发高烧...` body is present
- No generated body retains the `-true` suffix
- `dotnet build Tests/Tests.csproj --no-restore --no-incremental` passes

The numbered workflow fact mutates the dedicated raw export file, so it should not be run casually with the rest of the numbered workflow.

## Follow-up (2026-10-01): hard-coded mails without markers

`PlotController.GetTangMenWeddingMail` calls `PlotGetNewMail` with literals (`姜映泉-听闻唐门…`,
`魏胥华-听闻唐门…`). They are not PlotData records, so they only reach the pipeline through the master
`dynamicStrings.txt` candidate path, whose filter required both `#PlayerName#` and `<b>`. Neither mail has
both, so no body-only alias existed and the displayed body fell back to garbled per-fragment substitution.

`IsMasterMailCandidate` now also accepts a sender-prefixed value whose body is at least 12 characters and
contains `。`, `！` or `？`. A scan of the master dump found exactly these two additional matches.
`4h. ExtractMailBodies` now emits both body aliases; they still need the normal translate -> QC -> package run.
