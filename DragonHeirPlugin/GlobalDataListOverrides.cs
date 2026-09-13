using System;
using System.Linq;
using System.Reflection;
using HarmonyLib;

namespace EnglishPatch;

// GlobalData owns several static List<string> tier scales that get their entries translated at
// construction time via LTLocalization.GetText (that's why RankLabelDiagnosticPatches - see git
// history - already saw English, not raw Chinese, when it dumped these live: BattleScoreText,
// AttriRatioString, TreasureValueLvName, EquipmentWeightLvName). Because they're built through
// LTLocalization.GetText rather than the Text/TMP_Text setter sink, DynamicStringPatches'
// path-conditional routing (tried first, then reverted - see chat history 2026-09-13) never even
// saw the ambiguous short entries (冠/绝/下/中/精/etc. collide with unrelated whole-word dictionary
// entries like dumpedPrefabText.txt.yaml's 冠 -> "Crown"). Overwriting these lists' entries directly,
// once, right after they're populated, is simpler and exactly targeted - no path/glyph ambiguity
// possible since each list is addressed by its own real property name.
//
// Confirmed live (2026-09-13) auto-translated values before this override:
//   BattleScoreText        (Count=6): Bottom, Middle, Good, You, Crown, Absolute
//   AttriRatioString       (Count=7): Bottom, Middle, Top, Spirit, Extreme, Absolute, God
//   TreasureValueLvName    (Count=6): Remain, Bottom, Middle, Good, Zhen, Extreme
//   EquipmentWeightLvName  (Count=6): None, Simple, Lightly, Middle, Repeat, Over
//
// BattleScoreText/AttriRatioString use a letter-grade scale (matching the "S/SS"-style choice made
// earlier in this same chat for the top two tiers, extended consistently across the whole list).
// TreasureValueLvName/EquipmentWeightLvName are plain literal fixes for an unrelated
// domain (item rarity / equipment burden) - not a stylistic grade scale, so not lettered.
//
// Applied once (see _applied) via Harmony postfixes on the same three trigger points previously
// used to confirm these lists are already populated by the time each fires: PlotController.Awake,
// GlobalData.GetAttriLv, HeroDetailController.ShowHeroDetail. Uses only reflection over
// PropertyInfo ("Item" indexer get/set, "Count" get) - no generic Cast<T>()/TryCast<T>() or other
// confirmed-unsafe interop call per dragonheirplugin.instructions.md.
internal static class GlobalDataListOverrides
{
    private static bool _applied;

    // If any entry's Count doesn't match its expected length here, that list is skipped (logged as
    // a warning) rather than partially overwritten - a game update reordering/resizing the tier
    // scale should never silently mislabel it.
    private static readonly (string PropertyName, string[] Values)[] Overrides =
    {
        ("BattleScoreText", new[] { "D", "C", "B", "A", "S", "SS" }),
        ("AttriRatioString", new[] { "D", "C", "B", "A", "S", "SS", "SSS" }),
        ("TreasureValueLvName", new[] { "Worthless", "Common", "Uncommon", "Fine", "Precious", "Extraordinary" }),
        ("EquipmentWeightLvName", new[] { "None", "Light", "Slightly Light", "Moderate", "Heavy", "Overloaded" }),
    };

    [HarmonyPatch(typeof(PlotController), "Awake")]
    [HarmonyPostfix]
    private static void PlotController_Awake_Postfix() => TryApply("PlotController.Awake");

    [HarmonyPatch(typeof(GlobalData), nameof(GlobalData.GetAttriLv))]
    [HarmonyPostfix]
    private static void GetAttriLv_Postfix() => TryApply("GlobalData.GetAttriLv");

    [HarmonyPatch(typeof(HeroDetailController), nameof(HeroDetailController.ShowHeroDetail))]
    [HarmonyPostfix]
    private static void ShowHeroDetail_Postfix() => TryApply("HeroDetailController.ShowHeroDetail");

    private static void TryApply(string trigger)
    {
        if (_applied) return;
        _applied = true;

        try
        {
            Apply();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[GlobalDataListOverrides] Apply failed (trigger {trigger}): {ex}");
        }
    }

    private static void Apply()
    {
        var type = typeof(GlobalData);
        foreach (var (propertyName, values) in Overrides)
        {
            var prop = type.GetProperty(propertyName, BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
            if (prop == null)
            {
                MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] Property '{propertyName}' not found on GlobalData.");
                continue;
            }

            object list;
            try
            {
                list = prop.GetValue(null);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] Failed reading '{propertyName}': {ex.Message}");
                continue;
            }

            if (list == null)
            {
                MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] '{propertyName}' is null - GlobalData may not be initialized yet.");
                continue;
            }

            var listType = prop.PropertyType;
            var countProp = listType.GetProperty("Count");
            var itemProp = listType.GetProperty("Item");
            if (countProp == null || itemProp == null)
            {
                MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] '{propertyName}' has no Count/Item property.");
                continue;
            }

            int count;
            try
            {
                count = (int)countProp.GetValue(list);
            }
            catch (Exception ex)
            {
                MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] Failed reading Count for '{propertyName}': {ex.Message}");
                continue;
            }

            if (count != values.Length)
            {
                MainPlugin.Logger.LogWarning(
                    $"[GlobalDataListOverrides] '{propertyName}' has Count={count}, expected {values.Length} - skipping to avoid mislabeling a resized list.");
                continue;
            }

            for (var i = 0; i < values.Length; i++)
            {
                try
                {
                    itemProp.SetValue(list, values[i], new object[] { i });
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogWarning($"[GlobalDataListOverrides] Failed setting '{propertyName}'[{i}]: {ex.Message}");
                }
            }

            MainPlugin.Logger.LogInfo($"[GlobalDataListOverrides] Overrode {propertyName} ({string.Join(", ", values)}).");
        }
    }
}
