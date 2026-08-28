# `ForceData.csv` columns 9/10/11 — `HandBookMenuController.ShowForceSkill` crash (2026-08-28)

Same bug class as `HeroTagData.csv`/`ResourcePointTypeData.csv`/`KungFuData.csv` (see
`resetfacesetting-crash-investigation.md` and `dynamicstringpatches-template-regex-bug.md`), found
via an uncaught `ArgumentOutOfRangeException` ("Index was out of range...") in
`HandBookMenuController.ShowForceSkill` (reached via the faction handbook screen's
`SkillHandBookForceTab.OnClick`).

`ForceData.csv` had **no `SkipColumns` at all** before this fix. Decompiling
`GameDataController`'s CSV loader for `GameData/ForceData` (`Converter --filter
"GameDataController"`) found three unprotected label-cross-reference columns, all following the
same "split cell, look up label text against a fixed internal dictionary" shape as the
already-documented `HeroTagData`/`KungFuData`/`ResourcePointTypeData` cases:
- column 9 (`武功专长`/"Combat specialty", `;`-separated, e.g. `轻功;刀法;射术`)
- column 10 (`技艺专长`/"Craft specialty", same shape)
- column 11 (`特色物品`/"Signature item", `:`-separated `Label:Number`, e.g. `珍宝:1.5` — same
  lookup helper call site as `ResourcePointTypeData.csv`'s "资源" column)

Translating these labels makes the lookup miss, and the resulting default/invalid index later gets
used to index a small fixed-size collection elsewhere in the HandBook UI, producing the
out-of-range crash.

**Fix**: `SkipColumns = [9, 10, 11]` added to `ForceData.csv`'s `TextFilesToSplit` entry in
`Tests/GameFileHandling.cs`.

**Known follow-on risk, not yet fixed**: `ForceSpeAddDataBase.csv` (column 1, `特效`) is itself the
match *target* for `StringToSpeAddData`-style lookups from other files
(`HeroTagData.csv`/`KungFuData.csv`/etc., whose effect columns are already
`SkipColumns`-protected and stay in Chinese) — translating `ForceSpeAddDataBase.csv`'s own label
column to English means those untouched-Chinese lookups can now never match at all going forward
(a silent, logged-only no-op per `StringToSpeAddData`'s own catch-and-log behavior, not a crash).
Flagged here for awareness if a "translated effect text isn't applying its stat bonus" report ever
surfaces — no action taken yet.
