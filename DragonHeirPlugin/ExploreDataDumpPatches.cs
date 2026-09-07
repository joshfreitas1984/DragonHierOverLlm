using System.IO;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace EnglishPatch;

// ExploreController.ExploreTileGroundDataBase (name/costStep per ExploreTileGroundType enum
// value - Road/Plane/Forest/Mountain/River) is baked directly onto the ExploreController
// component (not loaded from any GameData CSV, and not reachable by the offline AssetsTools.NET
// scan in Tests/AssetDumperWorkflowTests.cs - that instance failed to deserialize there). Dumping
// it live here, mirroring ResourceIoPatches' raw/ dump pattern, is the only reliable way to
// capture every entry without hand-guessing values. Writes to the same PluginDir/raw folder
// ResourceIoPatches uses (BepInEx/plugins/raw, not a per-plugin subfolder).
//
// ExploreTileGroundDataBase only has 5 entries (one per ExploreTileGroundType enum value) - the
// much larger variety of names players actually see in Explore mode lives on two sibling lists
// also embedded on ExploreController: ExploreTileTypeDataBase (per-tile event/content type, e.g.
// ruins/ambush camps/resource spots) and ExploreMapTypeDataBase (per-map "biome" flavor name).
// Dumped alongside for the same reason - neither has a CSV/asset source either.
//
// BattleController.obstacleDataBase/explodeObstacleDataBase (obstacleName, e.g. "雕像"/statue,
// "城墙"/wall - the combat-screen equivalent) have the exact same problem, dumped below too.
//
// BattleController.speGridObjDataBase (name+describe per SpeGridObjType enum value - Grass,
// WaterPool, MudLake, MedGrass, StrangeFruit ("异果"), WiredFlower, OddVine, PoisonInsect,
// PoisonLake, ArrowTrap, Spike, StoneTrap, HotCarbon, TreasureChest, Defence) is the same
// embedded-list problem again, one level further down the same class - confirmed missing from
// every dump/CSV/prefab-text source (see DragonHeirPlugin/docs, "StrangeFruit missing
// translation" investigation). Dumped below alongside the obstacle lists.
//
// Same audit turned up four more controllers with the identical shape (a public list field never
// assigned in any decompiled method body - i.e. populated by Unity's own scene/prefab
// deserialization, not code or a CSV asset, so it can only ever be captured live off the running
// instance): BattlePrepareSpellController.BattlePrepareSpellDataBase (spellName/
// spellEffectString - pre-battle tactic picker), WeatherController.WeatherDataBase (name -
// weather-effect label), WorldEventController.worldEventDataBase (name - world-event log/notice),
// ReadBookController.readBookTextTypeDataBase (showName/fullName/describe - book-reading type
// tooltip). All four dumped below the same way.
internal static class ExploreDataDumpPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string RawDir = Path.Combine(PluginDir, "raw");

    [HarmonyPatch(typeof(ExploreController), "Awake")]
    [HarmonyPostfix]
    private static void Awake_Postfix(ExploreController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            DumpGroundTypes(__instance);
            DumpNameList("ExploreTileTypeDataBase", __instance.ExploreTileTypeDataBase?.Count ?? 0,
                i => __instance.ExploreTileTypeDataBase[i].name);
            DumpNameList("ExploreMapTypeDataBase", __instance.ExploreMapTypeDataBase?.Count ?? 0,
                i => __instance.ExploreMapTypeDataBase[i].name);
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: Awake_Postfix failed: {ex}");
        }
    }

    // BattleController's own obstacle name lists (e.g. "雕像"/statue, "城墙"/wall) - same
    // embedded-MonoBehaviour-list problem as ExploreController's lists above, just on the combat
    // screen instead of the explore map.
    [HarmonyPatch(typeof(BattleController), "Awake")]
    [HarmonyPostfix]
    private static void BattleAwake_Postfix(BattleController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            DumpNameList("ObstacleDataBase", __instance.obstacleDataBase?.Count ?? 0,
                i => __instance.obstacleDataBase[i].obstacleName);
            DumpNameList("ExplodeObstacleDataBase", __instance.explodeObstacleDataBase?.Count ?? 0,
                i => __instance.explodeObstacleDataBase[i].obstacleName);
            DumpSpeGridObjDataBase(__instance);
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: BattleAwake_Postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(BattlePrepareSpellController), "Awake")]
    [HarmonyPostfix]
    private static void BattlePrepareSpellAwake_Postfix(BattlePrepareSpellController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            var list = __instance.BattlePrepareSpellDataBase;
            DumpCsv("BattlePrepareSpellDataBase", "name,effect", list?.Count ?? 0,
                i => new[] { list[i].spellName, list[i].spellEffectString });
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: BattlePrepareSpellAwake_Postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(WeatherController), "Awake")]
    [HarmonyPostfix]
    private static void WeatherAwake_Postfix(WeatherController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            DumpNameList("WeatherDataBase", __instance.WeatherDataBase?.Count ?? 0,
                i => __instance.WeatherDataBase[i].name);
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: WeatherAwake_Postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(WorldEventController), "Awake")]
    [HarmonyPostfix]
    private static void WorldEventAwake_Postfix(WorldEventController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            DumpNameList("WorldEventDataBase", __instance.worldEventDataBase?.Count ?? 0,
                i => __instance.worldEventDataBase[i].name);
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: WorldEventAwake_Postfix failed: {ex}");
        }
    }

    [HarmonyPatch(typeof(ReadBookController), "Awake")]
    [HarmonyPostfix]
    private static void ReadBookAwake_Postfix(ReadBookController __instance)
    {
        try
        {
            Directory.CreateDirectory(RawDir);
            var list = __instance.readBookTextTypeDataBase;
            DumpCsv("ReadBookTextTypeDataBase", "showName,fullName,describe", list?.Count ?? 0,
                i => new[] { list[i].showName, list[i].fullName, list[i].describe });
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"ExploreDataDumpPatches: ReadBookAwake_Postfix failed: {ex}");
        }
    }

    // speGridObjDataBase entries carry both a name AND a multi-line describe (e.g. "异果" /
    // "体力+30%\n内力+10%") - unlike the single-column obstacle lists above, so this (and the other
    // multi-column dumps above) goes through DumpCsv for proper CSV quoting instead of DumpNameList.
    private static void DumpSpeGridObjDataBase(BattleController instance)
    {
        var list = instance.speGridObjDataBase;
        DumpCsv("SpeGridObjDataBase", "name,describe", list?.Count ?? 0,
            i => new[] { list[i].name, list[i].describe });
    }

    // Shared multi-column writer with CSV quoting (comma/quote/newline) - single-column name-only
    // lists still go through the simpler, unquoted DumpNameList below since none of those values
    // have ever contained a comma/newline in practice.
    private static void DumpCsv(string fileBaseName, string header, int count, System.Func<int, string[]> getRow)
    {
        MainPlugin.Logger?.LogDebug($"ExploreDataDumpPatches: {fileBaseName}={count} entries");
        if (count == 0)
            return;

        var sb = new StringBuilder(header).Append('\n');
        for (var i = 0; i < count; i++)
        {
            var row = getRow(i);
            for (var c = 0; c < row.Length; c++)
            {
                if (c > 0) sb.Append(',');
                sb.Append(CsvField(row[c]));
            }
            sb.Append('\n');
        }

        File.WriteAllText(Path.Combine(RawDir, fileBaseName + ".csv"), sb.ToString(), new UTF8Encoding(false));
        MainPlugin.Logger?.LogDebug($"ExploreDataDumpPatches: dumped {count} {fileBaseName} entries.");
    }

    private static string CsvField(string value)
    {
        if (string.IsNullOrEmpty(value)) return "";
        if (value.IndexOfAny(new[] { ',', '"', '\n', '\r' }) < 0) return value;
        return "\"" + value.Replace("\"", "\"\"") + "\"";
    }

    private static void DumpGroundTypes(ExploreController instance)
    {
        var list = instance.ExploreTileGroundDataBase;
        MainPlugin.Logger?.LogDebug(
            $"ExploreDataDumpPatches: ExploreTileGroundDataBase={(list == null ? "null" : $"{list.Count} entries")}");

        if (list == null || list.Count == 0)
            return;

        var sb = new StringBuilder("name,costStep\n");
        foreach (var entry in list)
            sb.Append(entry.name).Append(',').Append(entry.costStep).Append('\n');

        File.WriteAllText(Path.Combine(RawDir, "ExploreTileGroundDataBase.csv"), sb.ToString(), new UTF8Encoding(false));
        MainPlugin.Logger?.LogDebug($"ExploreDataDumpPatches: dumped {list.Count} ExploreTileGroundDataBase entries.");
    }

    private static void DumpNameList(string fileBaseName, int count, System.Func<int, string> getName)
    {
        MainPlugin.Logger?.LogDebug($"ExploreDataDumpPatches: {fileBaseName}={count} entries");
        if (count == 0)
            return;

        var sb = new StringBuilder("name\n");
        for (var i = 0; i < count; i++)
            sb.Append(getName(i)).Append('\n');

        File.WriteAllText(Path.Combine(RawDir, fileBaseName + ".csv"), sb.ToString(), new UTF8Encoding(false));
        MainPlugin.Logger?.LogDebug($"ExploreDataDumpPatches: dumped {count} {fileBaseName} entries.");
    }
}
