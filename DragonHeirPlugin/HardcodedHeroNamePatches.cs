using System.Collections.Generic;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// A handful of the player's starting-sect NPCs (the mentor and senior disciples) are started via
/// <c>WorldPlotEventStartData</c> instances built directly in <c>GameController.StartNewGameSetting</c>
/// with their Chinese names baked in as raw string literals (not sourced from any CSV at this call
/// site), e.g. <c>WorldPlotEventStartData.ctor(..., "姜映泉", ...)</c>. <c>GameController
/// .ChangePlotTargetNumCount</c> (case 5) then calls <c>WorldData.GetHero(string)</c> with that raw
/// literal to find the matching live <c>HeroData</c> via <c>WorldData.HerosDict</c> (keyed by
/// <c>HeroData.heroName</c>).
///
/// <c>HerosDict</c>'s keys are the ALREADY-TRANSLATED names from <c>SpeHeroData.csv</c> column 1
/// (e.g. raw "姜.映泉" -&gt; translated "Jiang Yingquan" - note SpeHeroData's raw name field has a
/// literal "." separator the game strips, and is NOT the same string as GameController.cs's
/// dotless literal even before translation). So the hardcoded Chinese literal never matches the
/// translated dictionary key, `GetHero` returns null, and the caller immediately null-derefs the
/// result - crashing `GameController.StartNewGame` on every new game.
///
/// This is NOT a PlotData.csv issue - PlotData's own speaker-name columns are a separate, cosmetic
/// display label and are never read by this lookup. Don't add them to SkipColumns for this bug.
///
/// Fix: prefix `WorldData.GetHero(string)` and remap these known raw Chinese literals to the exact
/// English text they were translated to in `Files/Mod/SpeHeroData.csv` (verified there, not
/// guessed), before the real lookup runs.
/// </summary>
internal static class HardcodedHeroNamePatches
{
    // Verified against Files/Mod/SpeHeroData.csv (row -> Name column) - do not guess spellings,
    // re-check that file if a new hardcoded name turns up (WorldPlotEventStartData.ctor call
    // sites in Converter/output/_NoNamespace/GameController.cs, StartNewGameSetting method).
    private static readonly Dictionary<string, string> RawToTranslatedHeroName = new()
    {
        ["姜映泉"] = "Jiang Yingquan", // SpeHeroData row 1 (raw "姜.映泉")
        ["魏胥华"] = "Wei Xuhua",      // SpeHeroData row 3 (raw "魏.胥华")
        ["余采薇"] = "Yu Caiwei",      // SpeHeroData row 4 (raw "余.采薇")
        ["沈退"] = "Shen Tui",         // SpeHeroData row 6 (raw "沈.退")
        ["姜婉"] = "Jiang Wan",        // SpeHeroData row 7 (raw "姜.婉")
    };

    [HarmonyPatch(typeof(WorldData), nameof(WorldData.GetHero), new[] { typeof(string) })]
    [HarmonyPrefix]
    private static void GetHero_Prefix(ref string heroName)
    {
        try
        {
            if (heroName != null && RawToTranslatedHeroName.TryGetValue(heroName, out var translated))
                heroName = translated;
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"HardcodedHeroNamePatches: failed to remap hardcoded hero name.\n{ex}");
        }
    }
}
