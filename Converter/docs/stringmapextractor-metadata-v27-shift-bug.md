# `StringMapExtractor` — metadata v27 `.data`-section scan dropped ~half of all string literals

**Fixed**: the encoded index needs an extra `>>1` shift on IL2CPP metadata version 27+.

Found investigating the in-game "Custom options" difficulty-slider screen (screenshot showed
untranslated/mixed labels like `本门DiscipleExperience`, `随机Enemy人强度`, `AISectSend展Speed`).
Traced the labels to `CustomDifficultyData.customDifficultyName`/`teammateLimitName`/
`teammateLimitDescribe` (three static `List<string>` fields), populated in
`CustomDifficultyData__cctor` (`output/_decompiled/_NoNamespace/CustomDifficultyData/.cctor.c`)
from 21 distinct `DAT_` addresses (e.g. `DAT_181d72c58`, `DAT_181d56200`) — none of which appeared
in `_string_map.csv`.

**Root cause**, confirmed via a one-off inspection script (`Scripts/InspectDatAddresses.ps1`, kept
in the repo for future similar investigations) that manually parses the PE section table and
`global-metadata.dat`'s string-literal table: all 21 addresses decode correctly as
`usageType == 5` (`kIl2CppMetadataUsageStringLiteral`) in the `.data` section — so an initial
"wrong section"/"different encoding" theory was wrong. The real bug is that this game's
`global-metadata.dat` is **metadata version 27** (Unity 2020.3.48f1), and IL2CPP v27 removed the
separate `metadataUsagePairs` indirection table, changing the encoding of the low 29 bits of the
`.data` slot. Cross-checked against LibCpp2IL's own decoder
(`LibCpp2IL/MetadataUsage.cs::DecodeMetadataUsage`):
```csharp
var index = (uint)(encoded & 0x1FFF_FFFF);
if (context.Metadata.MetadataVersion >= 27)
    index >>= 1;   // <-- StringMapExtractor was missing this shift entirely
```
Without the `>>1`, the decoded `srcIdx` comes out roughly double its real value (e.g. raw `35691`
instead of the correct `17845`), which happens to still look like a plausible index but silently
fails the `srcIdx >= strCount` bounds check for the upper half of the string table — so the bug
never threw, it just silently dropped every string literal indexed in the upper half of the table,
with no error or log output. All 21 `CustomDifficultyData` addresses decoded correctly once the
shift was added (verified against the actual in-game Chinese slider labels, e.g. `DAT_181d72c58` →
`经验倍率`, `DAT_181d71e58` → `组队限制`).

**Fix applied** in `StringMapExtractor.ExtractAndSave`'s scan loop: `if (version >= 27) srcIdx
>>= 1;` right after masking, before the `strCount` bounds check. This is metadata-version-gated so
it doesn't affect any pre-27 games this converter might ever be pointed at (LibCpp2IL's own logic
confirms pre-27 metadata uses the raw un-shifted index via the separate `metadataUsagePairs`
table, which is a different code path entirely and not something this extractor implements).

**Pipeline re-run completed**: ran `--skip-decompile` (no need to re-invoke Ghidra, this bug was
purely in the metadata-usage decode step) after deleting the stale `_string_map.csv` to force
regeneration: entry count went from roughly half to **19280 entries** (metadata has 19283 string
literals total — nearly everything now resolves). All 1108 `_NoNamespace` class files were
rewritten with the corrected string values. Then re-ran `--dynamic-string-candidates
--exclude-file ../Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt`, producing 3680 candidates in
`output/_dynamicStrings_candidates.txt` — **still needs user review/merge into
dynamicStrings.txt**, per the established rule against hand-editing dump files (do not do this
step automatically).
