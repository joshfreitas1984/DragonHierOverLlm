# Hall of Heroes ranking and Battle for Martial Supremacy slow refresh (2026-10-03)

**Status: fixed in play (2026-10-03).** Current rules are in
`../../features/runtime-plugin/herofightscorelistpatches-reference.md`.

## Symptom

Opening the Hall of Heroes ranking took several seconds, and a long pause came before every
Battle for Martial Supremacy single/multi bout. It was equally slow with the plugin disabled, so the
cost is in the game's own code.

## Root cause

`HeroFightScoreListController.RefreshHeroFightScoreList` runs on ranking open and at the start of
every single/multi bout (`PlotController.StartStudyFightWithGreatHeroSingle`/`Multi`). The final
mode does not call it. It recounts every hero flagged `heroDetailDirty` through
`GameController.CountHeroData` (a large native method), then insertion-sorts into a top-500 list.
The game also advances a day after each bout, and daily AI marks roughly 100-180 more heroes dirty,
so skipping the refresh between bouts is not possible.

## Measurements

First attempt (replace the insertion sort with one sort, recount unchanged): 1243 heroes took
4711 ms. The sort was microseconds; the recount was the whole cost, about 12-17 ms per dirty hero.

Final version (300 ms recount budget, highest previous score first): about 0.3 s per refresh.
Dirty count grew 281, 465, 581, 673, 731 across successive bouts with 22-25 heroes recounted each.

## Decisions

- Rejected throttling the refresh by in-game hour: the clock moves a day per bout.
- Rejected a fairness mechanism for the stale backlog: low-ranked NPCs rarely jump far in a day,
  and the highest-score-first order already refreshes everyone who could matter for the opponent
  range (`(100 - wins) * 5`, clamped 1-500).
- Cause of the dirty-flag churn (daily AI changes) was not investigated further.
