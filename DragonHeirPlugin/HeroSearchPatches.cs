using HarmonyLib;

namespace EnglishPatch;

// HeroSearchController.RegenerateHeroIcon (see Converter/output/_NoNamespace/HeroSearchController.cs)
// only adds a hero icon when its filter gate passes - with an empty search box and no force/star
// filter active, that gate evaluates to "show nothing" (a type-to-search UI, not a default full
// list - confirmed live: forcing a regenerate on OpenHeroSearch still produced childCount=0 with
// zero AddHeroIcon calls). The list only actually rebuilds once text is entered AND
// FinishEditSearchHeroName fires (bound to the InputField's End Edit event, i.e. Enter/blur, not
// live typing). This diagnostic confirms whether typing+Enter reaches AddHeroIcon at all, and
// what the hero name looks like at each translation stage, before deciding on a real fix.
internal static class HeroSearchPatches
{
    // Temporary diagnostics - confirms whether AddHeroIcon is ever reached at all, and what the
    // real (in-memory) hero name value looks like, before deciding whether the empty list is a
    // filter-logic gap or a name-comparison/translation gap.
    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.AddHeroIcon))]
    [HarmonyPostfix]
    private static void AddHeroIcon_Postfix(HeroData target)
    {
        var raw = target?.heroName;
        var getText = raw != null ? LTLocalization.GetText(raw, false, true) : null;
        var pipeline = raw != null ? DynamicStringPatches.RunGenericPipeline(raw) : null;
        MainPlugin.Logger.LogInfo($"[HeroSearchPatches] AddHeroIcon_Postfix: heroID={target?.heroID}, heroName='{raw}', GetText='{getText}', RunGenericPipeline='{pipeline}'");
    }

    // Confirms the exact search text the game is comparing against, since typing is only applied
    // on End Edit (Enter/blur), not per-keystroke.
    [HarmonyPatch(typeof(HeroSearchController), nameof(HeroSearchController.RegenerateHeroIcon))]
    [HarmonyPrefix]
    private static void RegenerateHeroIcon_Prefix(HeroSearchController __instance)
    {
        var searchText = __instance.heroSearchNameInputField != null ? __instance.heroSearchNameInputField.text : null;
        MainPlugin.Logger.LogInfo($"[HeroSearchPatches] RegenerateHeroIcon_Prefix: searchText='{searchText}', interestingStarFliter={__instance.interestingStarFliter}, forceIDFliter={__instance.forceIDFliter}");
    }
}
