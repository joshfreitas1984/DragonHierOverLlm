# UpgradePriorityText and HeroSearch diagnostics — removed as resolved

Two temporary, undocumented diagnostics were left in the plugin from investigations that were
later confirmed resolved in play. Neither investigation ever got its own topic doc while open, so
this entry exists purely to close them out and explain the removal.

## `PrefabTextPatches` — UpgradePriorityText / "优先" diagnostic

`IsDiagTarget`/`DiagLog` (per-call substring scan of `text.Contains("优先")` plus a
`prefabTextDiag.log` file write) instrumented every text-setter/prefab-scan hook to trace whether
and how the "UpgradePriorityText" label was being translated. Confirmed resolved — removed along
with its call sites in `ApplyExactMatchToComponentText` and `ReplaceIfKnown`. Removing it also let
those two methods gain a `DynamicStringPatches.ContainsCjk` short-circuit before the normalize +
dictionary-lookup work, since the diagnostic scan was the only reason non-CJK text still reached
`NormalizeForLookup`.

## `HeroSearchPatches` — AddHeroIcon / RegenerateHeroIcon diagnostic

The whole `HeroSearchPatches.cs` file was a temporary diagnostic confirming whether
`HeroSearchController.AddHeroIcon`/`RegenerateHeroIcon` were reached at all when typing in the hero
search box, and what the hero name looked like at each translation stage. It ran the full
`LTLocalization.GetText`/`DynamicStringPatches.RunGenericPipeline` translation pipeline a second
time purely to build a log line, on every hero icon add. Confirmed resolved — file removed along
with its Harmony registration in `MainPlugin.Load`.
