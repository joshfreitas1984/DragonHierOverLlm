# Save files embed already-resolved plot dialogue text (2026-09-24)

## Symptom

A quest dialogue line (`PlotData.csv` row 228, the 王添翼 "Underworld gathering" quest) was
corrected in `Files/Converted/PlotData.csv.yaml` and repackaged, but an existing save kept showing
the old English translation of that same line in the `Canvas/PlotPanel/PlotTextBack/PlotText`
speech bubble. The stale text persisted through:

- Repackaging `Files/Mod/PlotData.csv` (confirmed correct).
- Redeploying to both live BepInEx copies - `.../BepInEx/plugins/resources/GameData/PlotData.csv`
  and `.../ReleaseFolder/Files/BepInEx/plugins/resources/GameData/PlotData.csv` (both confirmed
  correct).
- A full close-and-relaunch of the game process (not just returning to the main menu).
- Fully disabling the plugin DLL.

None of the above should matter if this were a packaging/deployment/caching bug - the fact that
disabling the plugin entirely still showed *translated* (old) English, not raw Chinese, was the key
signal that the text wasn't coming from the CSV/dictionary pipeline at all for this line anymore.

## Where the text actually comes from

`GameSaveData.WorldData` (part of the plain-JSON save file at
`<Game>_Data/Save/SaveSlotN/Save`) embeds the dialogue text **verbatim**, e.g. (from a real save):

```json
"plotData":{"plotName":null,"spePlot":true,"plotID":228,"plotRandomHero":[],"differentForce":false,
  "targetHeroID":0,"plotCallFuc":null,"randomStartPlot":false,
  "plotDatas":[
    {"plotText":"#PlayerName#, come on, let's go see Master together!\r\nSpill everything that happened at that night's mafia meeting!",
     "heroFaceHightLightType":0,"plotSource":3,"sourceName":"0","plotTarget":5,
     "targetName":"王添翼","choices":[], ...},
    {"plotText":"Brother Wang, go to report it yourself. Why drag me along for this?", ...}
  ]}
```

That `plotText` is the *fully resolved, already-translated* string - not a plotID/index reference
that gets re-resolved on load.

### Root cause: `PlotData.Clone()`/`SinglePlotData.Clone()` snapshot at trigger time

- `GameDataController.LoadAllGameData()` calls `Resources.Load("GameData/PlotData", ...)` **once**
  per process launch and parses the whole CSV into `GameDataController.Instance.PlotDataBase`
  (`Dictionary<int, PlotData>`) - this is the "live" table that reflects whatever
  `resources/GameData/PlotData.csv` override currently contains.
- When a "special" world-event plot is triggered (`spePlot == true`, e.g. a quest cutscene),
  `PlotController.AddPlotDataBase(string/int plotID)` / `ChangePlotDataBase(string/int plotID)`
  look the row up in `PlotDataBase` and call `PlotData.Clone()` (decompiled:
  `Converter/output/_NoNamespace/PlotData.cs`, `PlotController.cs:945/959/973/989`). `Clone()` is a
  `BinaryFormatter` serialize/deserialize round-trip - a full deep copy, including `plotText` on
  every nested `SinglePlotData`.
- That cloned `PlotData`/`SinglePlotData` graph becomes part of `WorldData` (referenced via
  `PlotController.nowPlot`/`plotQueue` at runtime, and via `WorldData`'s own plot-tracking fields
  for save purposes) and gets serialized as plain JSON into the save file as shown above.
- `PlotController.ShowSinglePlot(SinglePlotData targetPlot)` (`Converter/output/_NoNamespace/
  PlotController.cs:2247`) reads `plotText` **straight off this object** (via `GlobalData.
  ReplaceSpeString` for placeholder substitution, then `LTLocalization.GetText`, then
  `DOTweenModuleUI.DOText`) - it never goes back to `PlotDataBase`/`Resources.Load` for an
  already-triggered `spePlot` event.

Once a quest event has been triggered under one translation, its `plotText` is frozen at whatever
was resolved into `endValue` at the moment `PlotTextPatches.DOText_Prefix` last translated it
(or, in the disabled-plugin repro, at whatever text was already saved from a prior session where
the plugin *was* active) - a later CSV correction can never reach it through the normal
translate/package/deploy pipeline, because that pipeline only feeds `PlotDataBase`, and this save
data bypasses `PlotDataBase` entirely from the moment of cloning onward.

### Why this is easy to misdiagnose as a packaging/caching bug

- `Files/Mod`/deployed CSVs can be 100% correct and this symptom still occurs.
- A full game relaunch re-runs `Resources.Load`/`ResourceIoPatches` and rebuilds `PlotDataBase`
  correctly, but doesn't touch already-serialized save data - so relaunching doesn't help either.
- Disabling the plugin doesn't help, because the frozen text in the save is plain data, not
  something the plugin recomputes on load.
- The dialogue speech bubble (`PlotTextPatches`) and the hero/area narrative log
  (`RecordLogDisplayPatches`/`recordLog`) look superficially similar (both are "text shown from
  past game state") but behave oppositely: `recordLog` stores the **raw Chinese** entry and
  translates it fresh at *display* time every time (see `docs/investigations/plugin/
  recordlog-translation-naturalness.md`), so it's immune to this bug. `spePlot` dialogue stores the
  **already-translated** string and never re-translates it. Don't assume one mechanism's behavior
  applies to the other when investigating a "still shows old text after a save load" report -
  check which storage/read path is actually involved first.

## Fix: `PlotSaveResyncPatches`

Two earlier approaches were tried and abandoned before landing on the working one - kept here as a
trap for the next person tempted to reach for either:

1. **Patch `ShowSinglePlot`, find the index via `nowPlot.plotDatas.IndexOf(targetPlot)`.** Broken:
   `PlotController.GoNextPlot()` (`Converter/output/_NoNamespace/PlotController.cs:3619`) does
   `nowPlot.plotDatas.RemoveAt(0)` before showing each subsequent line, so the list shrinks by one
   every line and the line currently being shown is *always* at position 0 of what remains -
   `IndexOf` returned 0 for every line, not just the first.
2. **Patch `ShowSinglePlot`, track a per-`nowPlot`-instance "lines shown so far" counter in a
   `ConditionalWeakTable<PlotData, ...>`.** Also broken live, and for a more fundamental reason:
   this relies on the *same* managed `PlotData` wrapper object being handed back across multiple
   separate Harmony invocations, but Il2CppInterop does not guarantee stable managed-wrapper
   identity for the same underlying native object across separate marshalling calls. In practice
   the `ConditionalWeakTable` saw what looked like a "new" key almost every time, so the counter
   never accumulated - every single line logged "index 0" again, indistinguishable from approach 1
   failing (this is why it looked like "the fix didn't work at all" rather than "worked partway").

**What actually works**: patch `PlotController.ShowPlot(PlotData targetPlot)` instead of
`ShowSinglePlot`, and resync the *whole* `plotDatas` list in one pass, in a single Harmony
invocation, before any line has been shown or removed. This needs no cross-call state at all -
everything happens inside one call, using only the `targetPlot` parameter handed to that call:

1. Looks up the *live* `GameDataController.Instance.PlotDataBase[targetPlot.plotID]`.
2. Only proceeds if `livePlot.plotDatas.Count == targetPlot.plotDatas.Count` - a count mismatch
   means the saved/queued list has drifted from the live table's shape (lines added/removed
   upstream since this instance was cloned), so position-based matching can no longer be trusted
   at all and the whole conversation is skipped.
3. Otherwise walks both lists in lockstep by position. For each pair, validates identity first -
   compares `sourceName`/`targetName`/`plotSource`/`plotTarget` between the saved and live
   `SinglePlotData` at that position. If a `plotID` was ever reused/repurposed for a different
   quest upstream, this mismatch is detected per-line and just that line is skipped (leaving its
   saved text as-is) rather than risking a substitution of an unrelated line's text.
4. If validation passes and the live `plotText` differs from the saved one, overwrites the saved
   `SinglePlotData.plotText` in place.
5. Also resyncs each line's `choices` (`SinglePlotChoiceData.choiceText`/`describe` - the dialogue
   choice buttons) the same way, nested one level deeper: same reasoning (frozen into the save by
   the same `PlotData.Clone()` graph, same untouched-list timing since `choices` isn't subject to
   the `GoNextPlot`/`RemoveAt` trap - only `plotDatas` itself gets popped), same
   count-match-then-per-entry-identity-guard shape, but anchored on `callFuc`/`callParam` instead
   of speaker names, since `SinglePlotChoiceData` has no `sourceName`/`targetName` fields -
   `callFuc`/`callParam` are the raw, never-translated CSV-sourced function hookup/parameter
   strings, so they're a stable "is this still the same choice" signal instead.

Because `targetPlot` (and each `SinglePlotData`/`SinglePlotChoiceData` inside it) is the exact
object instance embedded
in the save's `WorldData` graph, these overwrites also get written back into the save file on the
next autosave - so affected saves self-heal permanently the first time the conversation is next
opened, not just for that one session. Config toggle:
`Game Bugfixes.ResyncStalePlotTextFromSave` (on by default).

## Survey: other save-embedded categories with the same pattern (2026-09-24)

Prompted by a report that Inn names and Horse names looked similarly stale. Confirmed both, plus a
wider structural pattern, by grepping `SaveSlot0/Save`'s raw JSON directly.

### Confirmed live evidence

```json
"innName":"A Moment's Inn"   // and 9 other already-baked inn names, all in Files/Converted's style
```

```json
{"itemID":8,"type":6,"subType":0,"name":"大马",
 "describe":"A sturdy horse of great stature, commonly used by Wulin individuals.", ...}
```

The horse entry is actually a worse case than the plot-text bug: its `describe` field got
translated and baked in, but its `name` field ("大马") never did - it's sitting in the save as raw,
untranslated Chinese, permanently, regardless of any later `Files/Converted`/`ItemData.csv` fix.

Scanning all JSON keys in the save file (`grep`-style key extraction) turned up a much longer list
of name/text-shaped fields worth treating as suspect: `areaName`, `checkName`, `describe`,
`eventDescribe`, `eventName`, `forceName`, `inaccuracyPosText`, `infoText`, `innName`, `mailText`,
`mailTitle`, `name`, `plotName`, `plotText`, `resourcePointFullName`, `resourcePointName`,
`speFunctionDescribe`, `spriteName`, `sourceName`, `targetName`.

### Root cause is the same shape, and it's structural, not incidental

`GameDataController` loads a whole family of CSV tables once at boot into `Dictionary<int, X>`
fields - the exact same shape as `PlotDataBase` (see `Converter/output/_NoNamespace/
GameDataController.cs:79-199`):

| Live table (`GameDataController.Instance.<field>`) | Entry type | Likely translated field(s) |
|---|---|---|
| `weaponDataBase`, `armorDataBase`, `helmetDataBase`, `shoesDataBase`, `medDataBase`, `foodDataBase`, `horseDataBase` | `Dictionary<int, ItemData>` | `name`, `checkName`, `describe` |
| `innDataBase` | `Dictionary<int, InnData>` | `innName`, `describe` |
| `areaDataBase` | `Dictionary<int, AreaData>` | `areaName` (and likely more) |
| `forceDataBase` | `Dictionary<int, ForceData>` | `forceName` (and likely more) |
| `kungfuSkillDataBase`, `summonSkillDataBase` | `Dictionary<int, KungfuSkillData>` | skill name/describe fields (not yet enumerated) |
| `resourcePointTypeDataBase`, `resourcePointDataBase` | `Dictionary<int, ResourcePointData>` | `resourcePointName`, `resourcePointFullName` |
| `SpeHeroDataBase` | `Dictionary<int, HeroData>` | hero name/describe fields (not yet enumerated) |
| `SummonDataBase`, `heroTagDataBase`, `buildingDataBase`, `forceTechDataBase` | various | not yet enumerated |
| `PlotDataBase` | `Dictionary<int, PlotData>` | `plotText` (fixed - see above) |

Every entry class checked so far (`ItemData`, `InnData`, `PlotData`, `SinglePlotData`) has the same
`public virtual object Clone()` - a `BinaryFormatter` serialize/deserialize round-trip - and every
one is `grep`-findable with:

```
grep -rln "public virtual object Clone" Converter/output/_NoNamespace/*.cs
```

Any live instance the world actually contains - an inn on the map, a horse in someone's inventory,
a hero's home area, a force a mail references - is cloned from one of these tables at spawn/
acquire/assign time (mirroring `PlotController.AddPlotDataBase`/`ChangePlotDataBase` calling
`PlotData.Clone()`), and whatever translation state existed *at that moment* gets frozen into
`WorldData`/`GameSaveData` and written to the save file. Same bug class, same underlying fix shape
as `PlotSaveResyncPatches`: resync the relevant field(s) from the live `Dictionary<int, X>` by ID
immediately before display/use, with an identity guard against ID reuse.

### Field-level risk table (surveyed 2026-09-24)

Built by reading each class's actual field list in `Converter/output/_NoNamespace/*.cs`, not by
guessing from field names alone - several `*Name` fields turned out to be non-text asset/config
keys, which is exactly the trap a reflection/diff-based "generic" fix would fall into.

| Category (live table) | Field | Risk | Why |
|---|---|---|---|
| `PlotData`/`SinglePlotData` | `plotText` | Safe (fixed) | Static, CSV-sourced. Resynced with an identity guard in `PlotSaveResyncPatches`. |
| `SinglePlotData.choices` (`SinglePlotChoiceData`) | `choiceText`, `describe` | Safe (fixed) | Same clone-into-save pattern, nested one level deeper. Resynced in `PlotSaveResyncPatches.ResyncChoices`, identity-guarded on `callFuc`/`callParam` (never-translated CSV function hookup fields) instead of speaker names. |
| `SinglePlotChoiceData` | `callFuc`, `callParam`, `requirements`, `relations`, `costResource`, `inited`, `inheritMissionRequirement`, `autoChangeCostByDifficulty`, `destroyEvent`, `playerInteractionTimeNeed` | Never touch | Logic/requirement/cost state, not translation output. `callFuc`/`callParam` are deliberately used as the identity anchor precisely because they're never translated. |
| `ItemData` (weapon/armor/helmet/shoes/med/food/horse) | `name`, `checkName`, `describe` | Needs verification | Confirmed baked-stale live, and confirmed inconsistent per-instance (2026-09-24): the SAME horse ID (e.g. `HorseData.csv` id 22 `枣红马`) appears as both raw `"name":"枣红马"` (34 instances) AND already-baked `"name":"Chestnut horse"` (45 instances) across different `ItemData` clones in one save - exactly the `.Clone()`-freeze pattern, just non-deterministic per instance depending on whether that specific clone was ever displayed/translated yet. Unverified whether players can rename items/horses - if so, `name` doubles as a mutable player field and a blind resync would erase it. |
| `ItemData` | `itemID` used as a resync key | Unsafe as-is | Confirmed collision in a real save - two different items both had `"itemID":0`. Identity must come from `type`+`subType`(+more), not `itemID` alone. |
| `ItemData` | `value`, `itemLv`, `rareLv`, `weight`, `poisonNum`, `poisonNumDetected`, `isNew`, `setName` | Never touch | Per-instance rolled/numeric state. |
| `ItemData.horseData` (`HorseData`) | `speed`, `power`, `sprint`, `resist`, `*Add`, `nowPower`, `favorRate`, `sprintTimeLeft/Cd`, `equiped` | Never touch | Per-instance horse stat rolls, all numeric. |
| `InnData` | `innName`, `describe` | Likely safe | Confirmed baked-stale live. Keyed by `id`, a fixed map-location identifier (not known to be player-renameable) - still worth a quick live confirm before touching. |
| `InnData` | `plotNumCount`, `missionNumCount`, `haveSpeEvent`, `bigMapPos`, `nearAreaID` | Never touch | World-simulation/progress state. |
| `AreaData` | `areaName` | Needs verification | Same shape as `innName`/`forceName` - not yet checked whether areas can be renamed after conquest. |
| `AreaData` | `spriteName` | Not a translation target | Asset key despite the name. |
| `AreaData` | `recordLog` | Not affected by this bug | Confirmed elsewhere (`recordlog-translation-naturalness.md`) to store raw Chinese and translate fresh at every display - a different mechanism, no fix needed. |
| `AreaData` | everything else (population, safety, defence, resource lists, tiles, connections) | Never touch | Core world-simulation state. |
| `ForceData` | `forceName` | High risk - do not touch without confirming first | This genre commonly lets the player found/rename their own force/sect. If true here, a blind resync would silently erase that customization on next autosave. |
| `ForceData` | `forceStyle`, `color` | Not a translation target | Style/hex-color config keys. |
| `ForceData` | everything else (population, resources, favor, tech, salary) | Never touch | Simulation/progress state. |
| `KungfuSkillData`/summon skills | `name`, `describe` | Not affected by this bug (confirmed 2026-09-24) | `KungfuSkillData` instances are never cloned into the save at all - confirmed by grepping all four `SaveSlot*/{Save,Hero,TempHero}` files for fields unique to the class (`manaCost`, `baseDamage`, `summonSkill`, `weaponName`, `targetType`, etc.): zero hits anywhere. Skills are referenced only by `skillID` int (e.g. `"bookData":{"skillID":100}`, `HeroData.kungfuSkillFocus:[0,4]`), so `name`/`describe` must already be resolved live from `kungfuSkillDataBase` at display time - the correct, non-frozen pattern. No fix needed; no patch written. |
| `KungfuSkillData` | `weaponName`, `animationName` | Not a translation target | Internal asset/animation identifiers. |
| `KungfuSkillData` | everything else (damage/mana/range) | Never touch | Combat balance stats. |
| `ResourcePointData` | `resourcePointName`, `resourcePointFullName` | Needs verification | Same shape as `areaName`/`innName`, not confirmed live. |
| `ResourcePointData` | `spriteName` | Not a translation target | Asset key. |
| `SpeHeroDataBase` (`HeroData`) | any name/nickname/describe fields | High risk - not yet reviewed | Hero names/nicknames are very likely player-editable (adoption/marriage/custom naming are common in this genre). Class not yet read field-by-field - treat as unsafe until specifically audited. |
| `SummonDataBase`, `heroTagDataBase`, `buildingDataBase`, `forceTechDataBase` | - | Unreviewed | Not yet read at the field level. |

The recurring false-positive trap: several classes have string fields ending in `Name` that are
NOT translation targets (`spriteName`, `weaponName`, `animationName`, `forceStyle`/`color`'s kind
of field) - they're asset/config keys. This is the strongest argument against any reflection-based
"sync all string fields that differ" approach: it would confidently "fix" fields that were never
broken, and risks corrupting asset lookups if one of those keys were ever overwritten.

Rough safety ranking for whoever picks the next category up: `PlotData` (done) →
`InnData`/`ResourcePointData`/`AreaData` name fields (probably safe, cheap to verify) →
`KungfuSkillData` (probably safe) → `ItemData`/horses (needs the `itemID`-collision problem solved
first) → `ForceData`/`HeroData` names (do not touch until player-rename capability is explicitly
confirmed either way).

### Not yet done

This is a survey only - no additional patches have been written yet for these categories. Before
extending `PlotSaveResyncPatches`'s approach to any of them, still need to:

- Find each category's actual display/read call site (the equivalent of
  `PlotController.ShowSinglePlot` for plot text) - not yet identified for any of the tables above.
- Confirm which specific fields are actually re-derivable from the live table alone (some, like a
  horse's individual stat rolls, are per-instance and must NOT be overwritten - only the
  translated-text fields should be resynced, same as `PlotSaveResyncPatches` only touches
  `plotText` and leaves every other `SinglePlotData` field alone).
- Decide whether a single generalized helper (live-table lookup + identity guard, parameterized by
  table/id-getter/field-list) is worth building once several of these are confirmed, versus
  continuing with per-category patches like `PlotSaveResyncPatches`.

### KungfuSkillData investigation (2026-09-24): not every `Clone()`-capable class is actually cloned into the save

Before assuming any `Dictionary<int, X>` live table has the same bug as `PlotData`, confirm the
class's *own* fields actually show up in the save JSON - don't just check that a name/describe
field with the right ID is present nearby, since IDs get referenced (not embedded) constantly
without the containing object ever being cloned. For `KungfuSkillData` specifically:

- `bookData:{"skillID":100}` (an `ItemData.bookData` wrapper) and `HeroData.kungfuSkillFocus:[0,4]`
  are plain int/array *references* to a skill, not embedded `KungfuSkillData` objects - don't
  mistake "a skillID appears near a name/describe string" for the class being cloned; that
  name/describe usually belongs to the wrapping `ItemData` (the book item), not the skill itself.
- The decisive check is grepping for fields that only exist on the suspect class and nowhere else
  (`manaCost`, `baseDamage`, `summonSkill`, `targetType`, `weaponName` for `KungfuSkillData`) across
  every save file (`Save`, `Hero`, `TempHero` - not just `Save`) and every slot. Zero hits across
  four independent slots is strong evidence the class is genuinely never cloned, not just that this
  particular save happened not to trigger it.
- Found in passing, out of this pass's scope: `HeroData.goodKungfuSkillName` is a separate
  `List<string>` field that DOES bake in skill names verbatim and DOES stay raw/untranslated
  (`"goodKungfuSkillName":["无影乱剑"]`) - a real bug, but a different mechanism/field than
  `KungfuSkillData.name`, not yet investigated (call site, whether it's ever re-derived, whether a
  "good skill" designation can change over a hero's life). Worth a dedicated pass with its own
  step-1-style live confirmation before assuming it fits the same resync-from-live-table fix shape.

### Horse/item sprite lookup investigation (2026-09-24): a related but distinct bug class - translated text used as an atlas key, not baked into the save

Prompted by a report that horse and item sprites sometimes go missing. This turned out to be a
*different* mechanism than the `.Clone()`-freeze bug above (though it interacts with it - see the
gap noted at the end), specific to how the game builds `TextureController.LoadAtlasSprite`'s
`spriteName` argument for a handful of UI elements: the atlas is keyed on each row's **original
raw Chinese** name, but the display code hands it whatever's currently in `ItemData.name`, which
`DynamicStringPatches`/the CSV-column translation pipeline has usually already translated to
English by the time it's read - so the atlas lookup fails to resolve.

Two confirmed root causes, both fixed this pass:

1. **`HorseIconController.Update()`** (`Converter/output/_NoNamespace/HorseIconController.cs:
   ~574`) builds the bigmap "currently-ridden horse" icon key as `targetHorseData.name + "大"`
   directly - bypassing `ItemData.GetItemIconName()`/`ItemIconPatches` entirely (confirmed via
   `grep` to be the only non-numeric atlas-key builder in the whole decompiled codebase besides
   `GetItemIconName()`). Fixed in `DragonHeirPlugin/HorseMountedIconPatches.cs`: prefixes
   `LoadAtlasSprite` and reverse-translates the name portion before the "大" suffix, for the
   `"IconAtlas"` atlas specifically. Config toggle: `Game Bugfixes.ResyncMountedHorseIcon` (on by
   default).
2. **A genuine translation-dictionary collision**: `HorseData.csv` rows 22 (`枣红马`) and 27
   (`黄骠马`) - two distinct horses - were both translated to `"Chestnut horse"` in
   `dynamicStringsFromColumns.txt.yaml`. `DynamicStringPatches._reverseDictionary` is a first-wins
   `Result -> Raw` map (`DynamicStringPatches.cs:559-560`), so `ItemIconPatches`' reverse lookup for
   whichever horse lost the race got the *other* horse's raw name back, breaking its icon. Checked
   Food (36 names) and Med (36 names) columns too - zero collisions there, so this was an isolated
   pair, not a systemic gap in `ItemIconPatches`' approach. Fixed by retranslating `黄骠马` to
   `"Palomino horse"` in both `Files/Converted/dynamicStringsFromColumns.txt.yaml` and the deployed
   `Files/Mod/dynamicStringsFromColumns.txt.yaml`.

**Known gap, deliberately not fixed this pass**: both fixes above are correct for translations
computed from now on, but they do NOT retroactively heal an `ItemData` instance whose `name` was
*already* baked into an existing save as the old, colliding `"Chestnut horse"` text - confirmed
live (see the updated `ItemData` risk-table row above) that both horse IDs 22 and 27 already have
baked `"name":"Chestnut horse"` clones sitting in real saves, alongside other still-raw clones of
the same IDs. For those already-baked instances, the dictionary fix makes `ReverseTranslate`
*deterministic* (always resolves to `枣红马`) instead of an arbitrary coin-flip, which does not make
an already-wrong case worse, but doesn't fix an already-wrong `黄骠马` instance either. Retroactively
healing this needs the `ItemData`-name/describe resync patch already flagged as blocked in the risk
table above (on solving the confirmed `itemID` collision/identity problem first) - out of scope for
this pass; left as a pointer for whoever picks up the `ItemData` row next.

## Notes for fixing OTHER save-embedded content

The `spePlot`/`PlotData.Clone()` pattern is specific to world-event-triggered plot dialogue, but
the general shape of this bug class - "some game system clones/snapshots translated text into save
data instead of keeping only IDs and re-resolving on load" - is worth checking for anywhere else a
"still shows old text after a save load, even with the plugin disabled" report comes in:

- Grep the actual save file (`<Game>_Data/Save/SaveSlotN/Save` - plain UTF-8 JSON, no compression)
  for the reported stale string first. If it's found verbatim in the save, the bug is in a
  clone/snapshot path like this one, not in packaging/deployment/caching - stop looking at
  `Files/Mod`/`Files/Converted` and go find the `.Clone()`/serialization call instead.
- `grep -rn "public virtual object Clone" Converter/output/_NoNamespace/*.cs` lists every class
  with this `BinaryFormatter`-round-trip clone pattern - a reasonable starting list of "things that
  might get frozen into a save at snapshot time."
- The general fix shape (resync-from-live-data-with-an-identity-guard, applied at the read/display
  site rather than trying to migrate old saves offline) from `PlotSaveResyncPatches` should
  transfer directly: find the display/read call site, find the live equivalent table it should
  match against, and validate identity fields before overwriting so a since-repurposed ID can't
  substitute the wrong content.
