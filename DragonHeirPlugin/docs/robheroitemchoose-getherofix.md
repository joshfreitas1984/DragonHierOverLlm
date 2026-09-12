# RobHeroItemChoose / GetHero dead-button fix (2026-09-12)

## Symptom
The "夺取物件"/`RobHeroItemChoose` choice button (and other choices whose `callFuc` ultimately
looks a hero up by name, e.g. `RobHeroItemChoosen`) silently no-op'd for some heroes.

## Root cause
`PlotController.RobHeroItemChoose(string param)` / `RobHeroItemChoosen(string param)` call
`WorldData.GetHero(worldData, param)` directly (confirmed in
`Converter/output/_NoNamespace/PlotController.cs`). `param` is `choiceData.callParam`, sourced from
PlotData.csv column 9's `"{0};RobHeroItemChoose;{1}"` template. Depending on the specific choice,
`{1}` can reach `GetHero` as:
- the raw `"Family.Given"` CSV value **with the `.` still in it** (e.g. `"姜.映泉"`), while
  `HeroData.heroName` has the `.` stripped at load time (see `HeroNamePatches.cs`'s own doc
  comment) - so the native lookup never matches purely because of the leftover separator, and
- (in principle) an already-translated display name that needs reversing back to the raw Chinese
  name before `GetHero` can match it.

## Fix
`PlotInteractControllerPatches.GetHero_Prefix` (Harmony prefix on `WorldData.GetHero(string)`)
tries, in order: (1) the name as-is, (2) `HeroNamePatches.ReverseTranslateFullName` (the
`heroFullNames.txt.yaml` Result -> Raw dictionary), (3) the same name with `.` stripped. Patching
`GetHero` itself (rather than pre-translating `callParam` in an `OnClick` prefix) fixes every call
site that resolves a hero by name in one place, since they all funnel through `GetHero`.

### Recursion guard
Because the fix needs to retry via `__instance.GetHero(...)` from inside a prefix patching that
same method, the retry call re-enters this same prefix. A `[ThreadStatic] _inGetHeroPrefix` guard
makes the nested/re-entrant invocation just `return true` (let the original method run untouched)
instead of looping forever - an earlier version without the guard produced endless
`GetHero_Prefix ENTERED` log spam for a single click.

## Misdiagnosis worth remembering: translated-looking debug log text
While diagnosing this, a log line printed `ReverseTranslateFullName MISS input='Jiang Yingquan'`
even though the *actual* string (confirmed via a hex char-code dump of the same variable in the
same log statement) was raw Chinese `"姜.映泉"` (codes `59DC,002E,6620,6CC9`). `DynamicStringPatches`
patches `String.Format`/string-interpolation broadly enough that it intercepted and substring-
translated our own diagnostic log arguments for display, even though the underlying variable was
never actually translated. Lesson: when a diagnostic log's *text* and a raw hex/length dump of the
*same value* disagree, trust the hex dump - the display text may have been translated by an
unrelated broad patch after the fact.

## Removed: PlotInteractController.OnClick_Prefix
An earlier fix pre-translated `choiceData.callParam` in an `OnClick` prefix via
`DynamicStringPatches.ReverseTranslate` (exact-match) before *any* `callFuc` handler ran. This was
removed (2026-09-12) because:
- It was redundant for the hero-lookup case once `GetHero_Prefix` fixed `GetHero` itself at the
  source (`RobHeroItemChoose`/`RobHeroItemChoosen` call `GetHero` directly).
- `choiceData.callFuc`/`callParam` is a generic `SendMessage`-based dispatch used by ~500 other
  `PlotController` methods, most of which treat `param` as an internal ID (parsed as an int, an
  area/force/team ID, a boolean-ish flag, etc.), not translatable display text. Unconditionally
  running an exact-match reverse-translate over every one of those params for zero remaining
  benefit was an unnecessary (if narrow) risk of corrupting an unrelated internal ID that happened
  to exactly match some translated Result string elsewhere in the global dictionary.
