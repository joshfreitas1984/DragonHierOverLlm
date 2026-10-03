using System;
using System.Collections.Generic;
using System.Diagnostics;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Speeds up the vanilla Hall of Heroes ranking rebuild, which runs when the ranking opens and
/// again before every Battle for Martial Supremacy single/multi bout (PlotController.
/// StartStudyFightWithGreatHeroSingle/Multi both call it, and the game advances a day after each
/// bout so the result can't be reused).
///
/// The original HeroFightScoreListController.RefreshHeroFightScoreList builds the top-500 list by
/// insertion sort: every eligible hero is compared from index 0 against the list until a lower
/// score is found, re-fetching GameController/worldData/Heros through several accessor chains per
/// comparison. This replacement keeps the same eligibility rules, the same per-hero
/// CheckHeroDetailDirty recount and the same result order (stable descending by fightScore, ties
/// keep world-list order, player at index 0 wins ties), but sorts once.
///
/// The per-hero CheckHeroDetailDirty recount (GameController.CountHeroData, native) is the real
/// cost - measured at ~4.7s for 1243 heroes, versus microseconds for the sort. It is bounded by a
/// time budget (MainPlugin.FastHeroFightScoreListRecountBudgetMs): dirty heroes are recounted
/// highest previous score first until the budget is spent; any not reached keep their last score
/// and stay dirty, so the next refresh (or any hero-detail open) catches them up.
/// </summary>
internal static class HeroFightScoreListPatches
{
    private const int MaxListSize = 500;

    // Special hero the game only ranks once plot 1000 has happened (WorldData.plotHappened key).
    private const string ConditionalHeroName = "白云天";
    private const int ConditionalHeroPlotId = 1000;

    // [GameCoupled HeroFightScoreListController.RefreshHeroFightScoreList replaces] re-implements the ranking rules: skips hide/dead heroes and 白云天 until plotHappened has 1000, recounts dirty heroes, stable-sorts by fightScore descending, keeps the top 500, player (Heros[0]) seeded first
    [HarmonyPatch(typeof(HeroFightScoreListController), nameof(HeroFightScoreListController.RefreshHeroFightScoreList))]
    [HarmonyPrefix]
    private static bool RefreshHeroFightScoreList_Prefix(HeroFightScoreListController __instance)
    {
        if (!MainPlugin.FastHeroFightScoreListEnabledCached) return true;

        try
        {
            var list = __instance.heroFightScoreList;
            var world = GameController._instance?.worldData;
            var heroes = world?.Heros;
            if (list == null || heroes == null || heroes.Count == 0) return true;

            var stopwatch = Stopwatch.StartNew();
            var plotHappened = world.plotHappened;

            var entries = new List<Entry>(heroes.Count);
            var dirty = new List<Entry>();

            // Index 0 (the player) is seeded without eligibility checks or a recount, as the original does.
            var player = heroes[0];
            entries.Add(new Entry(player, player.fightScore, 0));

            for (var i = 1; i < heroes.Count; i++)
            {
                var hero = heroes[i];
                if (hero == null || hero.hide || hero.dead) continue;

                if (hero.heroName == ConditionalHeroName
                    && (plotHappened == null || !plotHappened.ContainsKey(ConditionalHeroPlotId)))
                    continue;

                var entry = new Entry(hero, hero.fightScore, i);
                entries.Add(entry);
                if (hero.heroDetailDirty) dirty.Add(entry);
            }

            // Recount dirty heroes, highest previous score first, until the budget runs out.
            var budgetMs = MainPlugin.FastHeroFightScoreListRecountBudgetMsCached;
            dirty.Sort(static (a, b) => b.Score.CompareTo(a.Score));
            var recountStart = stopwatch.ElapsedMilliseconds;
            var recounted = 0;
            foreach (var entry in dirty)
            {
                if (budgetMs > 0 && stopwatch.ElapsedMilliseconds - recountStart >= budgetMs) break;
                entry.Hero.CheckHeroDetailDirty(false);
                recounted++;
            }
            var recountMs = stopwatch.ElapsedMilliseconds - recountStart;

            // Re-read scores (recounted heroes changed); player keeps the score read above.
            for (var i = 1; i < entries.Count; i++)
                entries[i] = new Entry(entries[i].Hero, entries[i].Hero.fightScore, entries[i].Index);

            // Descending score; equal scores keep world-list order (what the original's
            // "insert before the first strictly lower score" produces).
            entries.Sort(static (a, b) =>
            {
                var byScore = b.Score.CompareTo(a.Score);
                return byScore != 0 ? byScore : a.Index.CompareTo(b.Index);
            });

            list.Clear();
            var take = Math.Min(entries.Count, MaxListSize);
            for (var i = 0; i < take; i++)
                list.Add(entries[i].Hero);

            MainPlugin.Logger.LogInfo(
                $"[HeroFightScoreListPatches] {heroes.Count} heroes, {entries.Count} eligible, {dirty.Count} dirty, {recounted} recounted in {recountMs}ms, total {stopwatch.ElapsedMilliseconds}ms -> {take} ranked.");

            return false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[HeroFightScoreListPatches] Fast ranking refresh failed, falling back to the original: {ex}");
            return true;
        }
    }

    private readonly struct Entry
    {
        public readonly HeroData Hero;
        public readonly float Score;
        public readonly int Index;

        public Entry(HeroData hero, float score, int index)
        {
            Hero = hero;
            Score = score;
            Index = index;
        }
    }
}
