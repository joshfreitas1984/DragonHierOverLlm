# Mission target descriptions and fallback fragment corruption (2026-09-18)

## Symptom

Mission UI text under `Canvas/MissionPanel/MissionUI/MissionScrollView` could remain partly
Chinese or become grammatically corrupted after runtime translation. Two representative cases
were:

- `藏宝地图` was translated in some dialogue and option strings, while a generated mission title
  still contained an untranslated suffix such as `(Kongtong ...室)`.
- `提升Baling Village的民心6点` became approximately `Improve Baling Village Of 民 6 heart Click`.

The second result suggested that a complete mission objective was being passed through generic,
context-free fragment replacement after its placeholders had already been substituted.

## Investigation findings

### The objective text is composed at runtime

`MissionData.GetMissionTargetDescribe(bool)` builds objective descriptions from hard-coded
Chinese format strings and runtime values. The decompiled method contains 24 target-type branches,
including exploration, resource acquisition, public sentiment, relationships, attacks, patrols,
training, and treasure collection.

The public-sentiment branch formats the objective as:

```text
提升{area}的{effect}{amount}点
```

For the affected objective, the runtime values produced:

```text
提升Baling Village的民心6点
```

This explains why translating a static `藏宝地图` or area-name entry alone could not translate the
whole mission title: the final string did not exist as one source CSV/dictionary entry.

### Both CSV-derived and runtime/static values can participate

The runtime values are not all sourced from the same place. Depending on the target branch, names
and labels come from game data and helpers such as `GlobalData`, `WorldData`, `HeroData`, and
`PlotController` lists. Other labels are extracted from CSV-backed sources by
`DynamicStringSources`.

The observed `心6 -> 6 heart` collision is present in
`Files/Mod/dynamicStringsFromColumns.txt.yaml` and comes from the CSV-derived dictionary. The
standalone `民心` entry is also available in the generic dictionary. When those fragments are
applied independently to the already-composed Chinese objective, they can split and reorder the
meaning of the original sentence. The `点` fragment can likewise be translated as `Click` in an
unrelated context.

Therefore, the original hypothesis was partly correct: runtime/static game data and CSV-derived
fragment dictionaries can meet in the same final string. The corruption is not evidence that the
whole objective came from a missing CSV row.

### `室` was not proven to be the corruption source

The converted dictionary contains room-related entries, including compound entries such as
`志室`, while a standalone `室` raw entry is also present. Generic translation uses substring
matching, so a standalone room fragment could theoretically affect a larger runtime-composed
string. However, the investigation did not establish that `室` caused the specific corrupted
public-sentiment sentence, and blindly replacing every `室` would risk damaging names and other
compound terms.

The treasure-map dialogue and the `查看宝图;GetTreasureMapMissionPlot` option are separate
`PlotController`/`ExploreController` strings. They are not produced by
`GetMissionTargetDescribe` and already have dictionary translations. The generated treasure-map
mission's objective/title text can still pass through the mission-description methods because the
map flow clones and generates a mission at runtime.

## Root cause

The root cause of the confirmed malformed objective was applying generic fragment translation while
the mission objective was still being constructed. `DynamicStringPatches.FormatPrefix` can translate
the `String.Format` template before substitution, and `GenericPostfix` can translate intermediate
`String.Format`/`String.Concat` results. Consequently, the mission postfix could receive text such
as `Improve Baling Village Of Public safety 12 Click`, not the original Chinese text required by
the natural-language regex.

The dictionary is intentionally broad and context-free for ordinary UI text, but that makes entries
such as `心6`, `民心`, and `点` unsafe inside a structured mission sentence.

The missing `室` suffix is a separate runtime-composition problem or an incomplete fragment
translation. It was not safe to solve with a global `室` replacement.

## Fix

`DragonHeirPlugin/MissionPatches.cs` now patches:

- `MissionData.GetMissionTargetDescribe(bool)`
- `MissionData.GetTriggerTargetDescribe(int, bool)`

The patches set a thread-local suppression flag for generic `String.Format`/`String.Concat`
translation while each mission method is running. A Harmony finalizer restores the previous flag
even if the game method throws. The mission postfix then receives the unmodified objective and
translates known formats with ordered regular expressions and natural English replacements before
allowing the generic pipeline to process any remaining CJK.
This includes the public-sentiment objective and the treasure-collection objective:

```text
Raise public sentiment in Baling Village by 6 points.
Collect 1 <treasure type> treasures.
```

The patch also translates the direct dead-target result and preserves the existing
`DynamicStringPatches._inFormatConcatPatch` re-entrancy guard while invoking the generic pipeline.
It only changes transient return values; it does not mutate mission data or game state.

### Runtime format corrections

The decompiled templates and live diagnostic logging established the following details that are
important for the regular expressions:

- Resource objectives are amount-first: `为门派获取720银钱`, not resource-first. The natural
  replacement therefore captures `amount` before `resource`.
- Level objectives can contain Unity rich-text markup inside the skill value, for example
  `刀法<color=#8C8C8C>劈柴刀法</color>(9级)提升1级`.
- Level objectives can also contain whitespace inside the level expression, for example
  `轻功<color=#2779FA>上高楼</color>(8 级)提升1级`.
- The level pattern accepts ASCII or full-width parentheses and optional whitespace around the
  number, `级`, and `提升`. The color markup remains part of the captured skill value so the
  ordinary dynamic pipeline can translate the name while preserving the UI color tags.
- Other logged formats, including `学习1门<color=#9A7CFF>Secret</color>武功`, favor increases,
  crafting, recruitment, manual compilation, teaching, and sparring, matched the natural
  objective patterns as expected.

This means a missing natural translation should first be checked against the exact runtime string,
including argument order, rich-text tags, and whitespace, before adding a dictionary fragment.

## Verification

- `dotnet msbuild DragonHeirPlugin\\GamePlugin.csproj /t:CoreCompile /p:SkipCompilerExecution=false
  /p:RestoreIgnoreFailedSources=true /nologo` passed for the source changes; the ordinary project
  build can still fail in the custom post-build `XCOPY` step when a deployment destination is
  unavailable.
- No source diagnostics were reported for `MissionPatches.cs`.
- The separate treasure-map dialogue and option entries were confirmed in
  `Files/Mod/dynamicStrings.txt.yaml`.
- Live logging confirmed the natural pass for resource, favor, crafting, recruitment, learning,
  manual compilation, teaching, and sparring objectives, as well as the corrected level formats.
- The generic pipeline remains intentionally responsible for embedded names and labels left in a
  naturally translated sentence, such as a skill or resource name that still contains CJK.

## Related code and references

- [MissionPatches.cs](../../../DragonHeirPlugin/MissionPatches.cs)
- [DynamicStringPatches.cs](../../../DragonHeirPlugin/DynamicStringPatches.cs)
- [DynamicStringSources.cs](../../../Translate/DynamicStringSources.cs)
- [MissionData decompilation](../../../Converter/output/_NoNamespace/MissionData.cs)
- [DynamicStringPatches template and fallback investigation](dynamicstringpatches-template-regex-bug.md)
- [DynamicStringPatches CJK placeholder fallback](dynamicstringpatches-cjk-placeholder-fallback.md)
