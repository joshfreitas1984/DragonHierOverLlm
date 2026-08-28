# `GameController.GenerateHero` — separate `ArgumentOutOfRangeException`, NOT a translated-column bug

> Read this if a new-game start crash recurs after `SpeHeroData.csv`/`ForceData.csv` skill-focus
> columns (see `spehero-relationship-and-skillfocus-crashes.md`) are already fixed.

After the `SpeHeroData.csv`/`ForceData.csv` skill-focus fix was packaged and verified present in
`Files/Mod/*.csv`, a fresh new-game start still threw an uncaught `ArgumentOutOfRangeException`,
but with a **different** stack trace — it stops directly at `GameController.GenerateHero()` itself,
not at `GenerateHeroData`/`RandomAttriAndSkill` (the already-fixed bug's call path). This is a
distinct crash.

**Investigation**: added a temporary Harmony Prefix (`DiagnosticPatches.GenerateHero_Prefix` in
`DragonHeirPlugin/DiagnosticPatches.cs`) that dumps `worldData.Forces.Count` plus every
field/property of each `ForceData` entry to `BepInEx/LogOutput.log` immediately before
`GenerateHero` runs. Confirmed via a real crash capture: all 30 forces' `kungfuSkillFocus`/
`livingSkillFocus` counts are small (0–4 out of 9 possible skill types each), which rules out the
"random-candidate-list empty because every skill slot is already taken" scenario the
`RandomAttriAndSkill` bug pattern would predict — so this is not the same bug recurring for a
missed column.

Since the Prefix only runs **once** before the whole method body (not per-force), the dump shows
the full pre-state of all forces but does **not** by itself identify which force/iteration the
real crash happens on. Static analysis of the decompiled pseudocode
(`Converter/output/_NoNamespace/GameController.cs`'s `GenerateHero` body) found the exception is
somewhere inside a long per-force, per-chapter-tier hero-count bookkeeping block built from
`this.worldData.Forces` (list-of-lists indexed by force index, then by a 0-5 "level tier", then by
a skill-slot index) — but heavy Ghidra local-variable reuse (the same `lVarN` name reassigned
dozens of times across the method, a limitation `converter.instructions.md` already documents for
deeply-obfuscated methods) made it impossible to pin down the exact list/index with confidence
from pseudocode alone.

**Why this looks unrelated to translation**: every field involved in the suspect block (`forceLv`,
`worldData.gameMode`, `force.chapter`, area/resource-point list counts) is a **numeric** value —
our translation pipeline only ever touches display-text CSV columns, never numeric ones. Ten of
the thirty forces (`id` 20-29, all `大帮派`/"Big Gang" = 0, i.e. minor/regional sects) share
`forceLv` values as low as 0, which could plausibly be an edge case the per-tier bookkeeping logic
doesn't handle cleanly, but nothing here correlates with anything our pipeline changes.

**Mitigation applied, then refined (not a real fix)**: initially added
`CrashMitigationPatches.GenerateHero_Finalizer` in `DragonHeirPlugin/CrashMitigationPatches.cs`
(same established pattern as the `ResetFaceSetting`/`ResetPlayerTag` mitigations documented in
`DragonHeirPlugin/KNOWN_ISSUES.md`) — logged the full exception plus
`worldData.Forces.Count`/`worldData.Heros.Count` and swallowed it so a new game could still start
instead of hard-crashing at `GameController.Start`.

A subsequent crash capture with this Finalizer active surfaced the FULL call chain for the first
time (Il2CppInterop only reports managed-method-boundary frames, and the intermediate frames were
being swallowed before reaching `GenerateHero`, hiding them from earlier captures):
`GenerateHero` → `GenerateHeroData` → `RandomGenerateNPCSkill` → `UpgradeSkill`. Crucially, the log
also showed `worldData.Heros.Count=1` after the swallow — i.e. **only the player character was
ever created**; the entire game world was otherwise empty of NPCs, because catching at the
`GenerateHero` level aborts the ENTIRE hero-generation loop for all 30 forces the instant the
FIRST NPC's random skill generation hits this bug.

`RandomGenerateNPCSkill` (see `Converter/output/_NoNamespace/GameController.cs`) calls
`UpgradeSkill` repeatedly in a loop while randomly rolling an NPC's starting kung-fu/living skills.
The exact out-of-range list access inside `UpgradeSkill` itself could not be pinned down with
confidence from decompiled pseudocode (same heavy Ghidra local-variable-reuse limitation as
above), but none of the values involved (skill level, skill type ID, force level) are translated
CSV text — still looks like a pre-existing numeric edge case, not a translation regression.

**Fix refinement**: added a second, much narrower Finalizer,
`CrashMitigationPatches.UpgradeSkill_Finalizer`, patching `GameController.UpgradeSkill` directly.
This means only the ONE failed skill-upgrade attempt for ONE NPC is skipped (that NPC just doesn't
get that particular skill level bump) instead of aborting hero generation for every remaining
force. The original `GenerateHero_Finalizer` is kept as a defense-in-depth safety net only — with
`UpgradeSkill_Finalizer` catching the exception first, `GenerateHero_Finalizer` should rarely if
ever fire now. The `DiagnosticPatches.GenerateHero_Prefix` dump is left in place (harmless,
logging-only) for the next investigation pass.

**Next steps if revisited**: capture a fresh `BepInEx/LogOutput.log` after this fix and grep for
`CrashMitigationPatches: GameController.UpgradeSkill threw` — it now logs `targetHero.heroID`,
whether `skillLvData` was null, and the `lv` argument, which should narrow down whether the bug
correlates with a specific hero/skill/level combination (e.g. `lv` unusually high from
`useMaxNum`-driven calls) rather than needing to bisect force data as originally planned.
