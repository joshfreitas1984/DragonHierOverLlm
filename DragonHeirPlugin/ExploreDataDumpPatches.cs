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
