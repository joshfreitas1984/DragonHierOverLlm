# HeroFightScoreListPatches agent reference

Read this before changing `HeroFightScoreListPatches.cs`. Measurements and reasoning are in
`../../investigations/plugin/hall-of-heroes-ranking-slow-refresh.md`.

## What it replaces

A skip-original Harmony prefix on `HeroFightScoreListController.RefreshHeroFightScoreList`. The game
runs that method when the Hall of Heroes ranking opens and at the start of every Battle for Martial
Supremacy single (`StartStudyFightWithGreatHeroSingle`) and multi (`...Multi`) bout. The game
advances a day after each bout, so the result cannot be reused between bouts.

The prefix keeps the original's rules. The list starts with `Heros[0]` (the player), added without
eligibility checks or a recount. Every other hero is skipped if `hide` or `dead` is set, or if it is
白云天 and `WorldData.plotHappened` lacks key 1000. Remaining heroes are recounted through
`HeroData.CheckHeroDetailDirty(false)`. The result is the top 500 by `fightScore`, descending, with
ties in world-list order (the player wins ties). The original produced this with a per-hero
insertion sort; the prefix sorts once.

## Recount budget

The sort is negligible. The cost is `GameController.CountHeroData` (native, roughly 12-17 ms per
dirty hero), which `CheckHeroDetailDirty` runs for every hero whose `heroDetailDirty` flag is set.
Each refresh recounts dirty heroes highest previous `fightScore` first until
`[Performance] HeroFightScoreListRecountBudgetMs` (default 300, `0` = unlimited) is spent. Heroes not
reached keep their last score and their dirty flag, so a later refresh or a hero-detail open
catches them up. The dirty backlog growing between bouts is expected.

Accepted trade-off: low-ranked heroes can have stale scores for many days. A never-counted hero
(score 0) at the bottom of a permanently over-budget backlog may never be counted; set the budget to
0 for one refresh to catch everyone up.

## Config

- `[Performance] FastHeroFightScoreList` (default `true`): `false` runs the original game code.
- `[Performance] HeroFightScoreListRecountBudgetMs` (default `300`): see above. Both are read live.

Each refresh logs `[HeroFightScoreListPatches] N heroes, E eligible, D dirty, R recounted in Xms,
total Yms -> 500 ranked.`

## Game coupling

Tagged `[GameCoupled HeroFightScoreListController.RefreshHeroFightScoreList replaces]`. After a game
update, diff that method and re-check the eligibility rules, the player seeding, the 500 cap and the
tie order. The decompile's field names are unreliable here; the real ones (`hide`, `dead`,
`heroName`, `heroDetailDirty`, `fightScore`, `WorldData.plotHappened`) were confirmed by matching
field offsets (`heroID` +88, `hide` +96, `dead` +97, `heroName` +104, `plotHappened` +216) against
the declaration order. Any failure falls back to the original method.

## Change checklist

1. Keep the fall-back-to-original on any exception.
2. Do not move the recount off the main thread; it touches IL2CPP objects.
3. Keep the per-refresh log line; it is how the dirty backlog is observed.
