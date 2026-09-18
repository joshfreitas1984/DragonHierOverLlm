# GlobalData tier-scale overrides (`GlobalDataListOverrides.cs`)

## What this fixes

`Canvas/BattleUIPanel/BattleEndUI/Rate` and `Canvas/HeroDetailPanel/Attri/Attris/*/Lv` display a
short grade label (originally a single Chinese character like 冠/绝/下/中/精) read off a
`GlobalData` static `List<string>` tier scale. Those same characters also appear as ordinary
whole-string entries in `dumpedPrefabText.txt.yaml` for unrelated UI text (e.g. 冠 → "Crown",
绝 → "Absolute"), and the game auto-translates each list entry at construction time via
`LTLocalization.GetText` using whichever generic-dictionary match fires first — so the two grade
scales were showing wrong/nonsensical English ("You", "Zhen", "Repeat") with no way to fix them
through `DynamicStringPatches`'/`PrefabTextPatches`' normal whole-string or substring dictionaries.

## How the right fields were found (three failed approaches first)

1. **IL2CPP decompile pseudocode offsets** — `Converter/output/_NoNamespace/_BattleEnd_d__248.cs`'s
   `MoveNext` and `GlobalData.GetAttriLv` both read a `List<string>` off a raw instance-pointer
   offset (`pPlotController + 0x5b8`, `+0x558`/`+0x560`). This looked like a `PlotController`
   instance field. **It wasn't** — confirmed by loading the real
   `BepInEx\interop\Assembly-CSharp.dll` directly (see below) and finding
   `PlotController.get_Instance()` decompiles to `return PlotController.LeftFaceHideOffset;`, an
   obviously wrong field name. This decompiler's static-field cross-type references are simply
   unreliable in this build — don't trust a field *name* recovered this way, only the *shape*
   (e.g. "there's a `List<string>` + parallel `List<int/float>` threshold pair somewhere").
2. **Reflecting `PlotController` for `FieldInfo`s** — found zero. Confirmed by the same offline
   assembly load: this Il2CppInterop build exposes every field as a C# **property**
   (`get_X`/`set_X`), never a real reflectable `FieldInfo`. Any future reflection-based diagnostic
   in this codebase must use `GetProperties`, not `GetFields`.
3. **Guessing the owning type** — `PlotController` turned out to have no matching instance
   property at all (only one `List<string>` instance property, `FinalGreatHeroNameList`, unrelated).
   The real owner was `GlobalData` (a static constants class), reachable only by widening the
   search to multiple candidate types.

## The working method: search by value, not by name

Rather than keep guessing a field name from decompiled pseudocode, a temporary diagnostic
(`RankLabelDiagnosticPatches.cs`, since deleted) searched every static `List<string>` property on a
handful of candidate types (`BattleController`, `PlotController`, `GlobalData`,
`HeroDetailController`, `Attri*`) for one whose **actual runtime contents** contained a known
confirmed glyph (冠/绝/下/中/精, identified by hand from `dynamicStrings.txt.yaml`/
`dumpedPrefabTextFromOtherFields.txt.yaml`). Triggered from three Harmony postfixes
(`PlotController.Awake`, `GlobalData.GetAttriLv`, `HeroDetailController.ShowHeroDetail`) to make
sure the lists were already populated by the time the scan ran. This found the exact real property
names and full contents (already auto-translated to English by the generic pipeline) in one pass:

```
GlobalData.BattleScoreText       (Count=6): Bottom, Middle, Good, You, Crown, Absolute
GlobalData.AttriRatioString      (Count=7): Bottom, Middle, Top, Spirit, Extreme, Absolute, God
GlobalData.TreasureValueLvName   (Count=6): Remain, Bottom, Middle, Good, Zhen, Extreme
GlobalData.EquipmentWeightLvName (Count=6): None, Simple, Lightly, Middle, Repeat, Over
```

## The fix

`GlobalDataListOverrides.cs` Harmony-postfixes the same three trigger points and, once
(`_applied` guard), directly overwrites each list's entries in place via reflection on the
concrete `List<string>` property's own `Item` indexer setter (`PropertyInfo.SetValue`) — no
`DynamicStringPatches` dictionary, no path/GameObject matching, no ambiguity, since each list is
addressed by its own real property name instead of by the string content it happens to hold.
Guarded per-list by an expected `Count` check: if a future game update resizes a list, that one
entry is skipped (logged as a warning) rather than silently mislabeling the wrong index.

Current overrides:
- `BattleScoreText`/`AttriRatioString` → a letter-grade scale (`D, C, B, A, S, SS[, SSS]`).
- `TreasureValueLvName`/`EquipmentWeightLvName` → plain literal fixes (different domain - item
  rarity / equipment burden - not a stylistic grade scale, so not lettered).

## Known follow-up: GlobalData almost certainly has more of these

The same offline reflection dump that found the four lists above also surfaced a long tail of
other `GlobalData` static `List<string>` properties whose names strongly suggest they're the same
class of auto-translated tier/label scale and haven't been checked for mistranslated short
entries: `HeroForceLvName`, `HeroServantForceLvName`, `HeroGovernLvName`, `HeroHornorLvName`,
`HeroFreeForceLvName`, `HeroBadForceLvName`, `MartialClubLvName`, `EquipLvName`, `SkillLvName`,
`BookRareLvName`, `TreasureRareLvName`, `FavorLvText`, `AreaTypeName`, `AttriName`,
`FightSkillName`, `LivingSkillName`, and others (`GlobalData.cs`'s decompiled source has the full
field list). Each is a candidate for the same investigation: dump its live (already-translated)
values, eyeball them for anything that looks wrong/truncated/pinyin-leaked (like "Zhen"/"You"/
"Repeat" were here), and add an entry to `GlobalDataListOverrides.Overrides` if so. Nothing here
has been checked yet - this is a "look before you need to", not a confirmed bug list.

## Offline assembly inspection technique (reusable)

To inspect the *real* interop assembly's members directly (bypassing the unreliable decompiled
pseudocode) without touching the live game process: build a throwaway console app referencing
nothing but reflection, resolve dependencies from both `BepInEx\interop\` (game assemblies) and
`BepInEx\core\` (Il2CppInterop runtime itself - `Il2CppInterop.Runtime.dll` etc., easy to miss)
via an `AppDomain.CurrentDomain.AssemblyResolve` hook, then `Assembly.LoadFrom` +
`GetTypes()`/`GetProperties()`. This was how `PlotController.LeftFaceHideOffset` and the
field-vs-property discrepancy were confirmed in minutes instead of guessed at for hours.
