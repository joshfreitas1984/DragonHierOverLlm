using AssetsTools.NET;
using AssetsTools.NET.Cpp2IL;
using AssetsTools.NET.Extra;
using FanslationStudio.LlmKit;
using FanslationStudio.LlmKit.Utility;
using System.Text.RegularExpressions;

namespace Tests;

/// <summary>
/// A single distinct Chinese string found while scanning assets, tagged with the leaf field name
/// it was found on and the full ancestor path (rooted at the owning script class name where
/// resolvable, e.g. "SomeClass.innSearchNames.Array.data") so array/list elements - which
/// AssetsTools.NET always names "data" at the leaf - can be traced back to the real field that
/// holds them. Written as the full contents of dumpedOtherText.txt (every distinct string,
/// including the primary m_Text/text ones) purely as a diagnostic/reference dump - not a
/// translation input.
/// </summary>
public record DumpedTextEntry(string Raw, string Field, string Path);

/// <summary>
/// Offline equivalent of FanslationStudio.Plugins.PrefabText.PrefabTextDumperService (see
/// G:\FanslationStudio.Plugins\FanslationStudio.Plugins.Shared\PrefabText\PrefabTextDumperService.cs).
/// That service walks *loaded* GameObjects/components at runtime via Harmony + UnityEngine
/// reflection (ExtractTextFromGameObject / GetValidTextProperty, looking for "m_text"/"m_Text"
/// fields on UI.Text/TMP_Text components). This test instead statically parses the serialized
/// .assets/.bundle files under &lt;GameDirectory&gt;\LongYinLiZhiZhuan_Data with AssetsTools.NET -
/// IL2CPP only affects how the game's *code* is compiled, not the Unity SerializedFile format
/// these asset containers use, so no game process/Harmony/reflection is needed to find Chinese
/// text baked into prefabs/MonoBehaviours/TextAssets.
///
/// This is a one-off discovery tool, not part of the numbered translation workflow in
/// FileInputWorkflowTests.cs/FileOutputWorkflowTests.cs - run it manually to see what prefab text
/// exists before deciding how (or whether) to patch it at runtime via a plugin.
/// </summary>
public class AssetDumperWorkflowTests
{
    // Same Chinese-detection pattern as DragonHeirPlugin/MainPlugin.cs's ChineseCharPattern, kept
    // consistent between the runtime plugin and this offline scan.
    private static readonly Regex ChineseCharPattern = new(@"\p{IsCJKUnifiedIdeographs}", RegexOptions.Compiled);

    // Optional: download from https://github.com/nesrak1/AssetsTools.NET/releases and place next
    // to the test assembly. Covers built-in engine types (Texture2D, GameObject, etc.) whose type
    // tree was stripped. It does NOT cover MonoBehaviour script fields (e.g. TextMeshProUGUI's
    // "m_text", or any custom UI script) - those need the Cpp2IL-based generator below instead,
    // since a MonoBehaviour's field layout is defined by game script code, not engine classes.
    private const string ClassDataTpkPath = "classdata.tpk";

    // MonoBehaviour's IL2CPP class ID - used only for diagnostics below (to explain *why* a
    // particular asset was unreadable rather than just silently dropping it).
    private const int MonoBehaviourClassId = (int)AssetClassID.MonoBehaviour;

    // TextAsset's "m_Script" field holds the *entire* file content (sometimes megabytes) - that's
    // already dumped/handled by the existing TextAsset/ CSV workflow (see GameFileHandling.cs), so
    // walking it here just duplicates huge blobs into this UI-text-focused output and blows up the
    // file size (one TextAsset field alone produced a 1.5 million character "line"). Skip
    // TextAsset assets entirely - this dumper only cares about prefab/MonoBehaviour UI text.
    private const int TextAssetClassId = (int)AssetClassID.TextAsset;

    // Safety net for any other field that might legitimately be a huge blob (not just TextAsset) -
    // real hardcoded UI text is never anywhere close to this long.
    private const int MaxStringLength = 2000;

    [Fact(DisplayName = "0. Copy raws to Working Directory")]
    public void CopyRaws()
    {
        var dumpedDirectory = $"{GameFileHandling.GameFolder}/BepinEx/plugins/raw";
        var rawDirectory = $"{GameFileHandling.WorkingDirectory}/Raw/Dumped";

        if (Directory.Exists(rawDirectory))
            Directory.Delete(rawDirectory, true);

        GameFileHandlingBase.CopyDirectory(dumpedDirectory, rawDirectory);
    }

    [Fact(DisplayName = "0b. Dump Chinese text from prefab/asset files")]
    public void DumpChineseTextFromAssets()
    {
        var dataDirectory = $"{GameFileHandling.GameFolder}\\LongYinLiZhiZhuan_Data";
        Assert.True(Directory.Exists(dataDirectory), $"Game data directory not found: {dataDirectory}");

        var manager = new AssetsManager();

        if (File.Exists(ClassDataTpkPath))
            manager.LoadClassPackage(ClassDataTpkPath);

        // Most hardcoded UI text (TextMeshProUGUI/UI.Text/custom scripts) lives on MonoBehaviour
        // components, whose field layout is defined by the game's own script code - not something
        // classdata.tpk (engine-only types) can ever describe. Without this generator,
        // GetBaseField either throws or returns only the generic Object/MonoBehaviour header
        // fields (m_Script/m_Name), silently missing every custom field including the text itself.
        // This mirrors what Converter/Program.cs auto-discovers for the same game (see
        // converter.instructions.md's "--game-dir auto-discovers" table).
        var gameAssemblyPath = $"{GameFileHandling.GameFolder}\\GameAssembly.dll";
        var metadataPath = $"{dataDirectory}\\il2cpp_data\\Metadata\\global-metadata.dat";
        var monoGeneratorAvailable = File.Exists(gameAssemblyPath) && File.Exists(metadataPath);
        if (monoGeneratorAvailable)
            manager.MonoTempGenerator = new Cpp2IlTempGenerator(metadataPath, gameAssemblyPath);

        // Maps each distinct Chinese string to the leaf field name it was first found on (e.g.
        // "m_Text") plus the full ancestor path, purely for informational purposes when reviewing
        // the output - the string itself is still deduplicated (dictionary keys are unique) even
        // though it may appear on multiple fields/assets.
        var exportedStrings = new Dictionary<string, (string LeafField, string Path)>();

        var assetFiles = Directory.GetFiles(dataDirectory, "*", SearchOption.AllDirectories)
            .Where(IsCandidateAssetFile)
            .ToList();

        var skippedFiles = 0;
        var scannedAssets = 0;
        var monoBehavioursSkipped = 0;
        var otherAssetsSkipped = 0;
        var typeTreeAssetFiles = 0;
        var noTypeTreeAssetFiles = 0;
        // Groups both per-file and per-asset failure messages so we can tell *why* things were
        // skipped instead of just a bare count - e.g. "no ClassDatabase/MonoTemplateGenerator
        // available" vs. a genuinely malformed file.
        var errorCounts = new Dictionary<string, int>();

        // TEMP diagnostic (2026-09-03): confirms whether ExploreController (owner of the
        // ExploreTileGroundDataBase list holding the missing 平原/etc. ground-type names) is
        // ever successfully deserialized at all, vs. silently one of the handful of
        // MonoBehaviours the scan can't resolve. Remove once the root cause is confirmed.
        var exploreRootLabelsSeen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var path in assetFiles)
        {
            try
            {
                ScanFile(
                    manager, path, exportedStrings, errorCounts,
                    ref scannedAssets, ref monoBehavioursSkipped, ref otherAssetsSkipped,
                    ref typeTreeAssetFiles, ref noTypeTreeAssetFiles, exploreRootLabelsSeen);
            }
            catch (Exception ex)
            {
                // Mirrors PrefabTextDumperService's per-bundle try/catch - a single malformed or
                // unsupported file shouldn't abort the whole scan.
                skippedFiles++;
                RecordError(errorCounts, ex.Message);
            }
        }

        var outputDirectory = $"{GameFileHandling.WorkingDirectory}/Raw/Dumped/PrefabText";
        Directory.CreateDirectory(outputDirectory);
        var outputPath = $"{outputDirectory}/dumpedPrefabText.txt";
        var otherOutputPath = $"{outputDirectory}/dumpedOtherText.txt";

        // dumpedPrefabText.txt is the actual translation input consumed by
        // FanslationStudio.LlmKit.Workflow.PrefabTextWorkflow (via
        // GameFileHandling.ExportPrefabTextAssetToCustomFormat) - it must be JUST the plain string
        // per line, since each line becomes a whole TranslationLine/TranslationSplit with nothing
        // else to strip out first.
        //
        // dumpedOtherText.txt is a diagnostic/reference dump of EVERY distinct string found
        // (including the primary m_Text/text ones), tagged with the field it was found on, in YAML
        // form:
        //   - raw: 地图一览
        //     field: m_Text
        // This is not a translation input - it exists purely so the field name is easy to cross
        // reference when wiring up the runtime plugin's text-replacement matching later.
        var primaryStrings = exportedStrings
            .Where(kv => IsPrimaryTextField(kv.Value.LeafField))
            .Select(kv => kv.Key)
            .OrderBy(text => text)
            .ToList();
        var allEntries = exportedStrings
            .OrderBy(kv => kv.Key)
            .Select(kv => new DumpedTextEntry(kv.Key, kv.Value.LeafField, kv.Value.Path))
            .ToList();

        File.WriteAllLines(outputPath, primaryStrings);
        var serializer = YamlHelper.CreateSerializer();
        File.WriteAllText(otherOutputPath, serializer.Serialize(allEntries));

        // These counts matter more than the string count itself: if monoBehavioursSkipped or
        // otherAssetsSkipped is high, an empty/small result means "couldn't inspect these assets",
        // not "no Chinese text exists". noTypeTreeAssetFiles being high with no classdata.tpk
        // loaded means built-in engine types (GameObject/Texture2D/etc, not just MonoBehaviour)
        // couldn't be described at all - that's usually the dominant failure mode on a release
        // build, not the MonoBehaviour/Cpp2IL path.
        Console.WriteLine(
            $"Found {exportedStrings.Count} distinct Chinese strings across {assetFiles.Count} asset files " +
            $"({skippedFiles} files skipped). Inspected {scannedAssets} assets; " +
            $"{monoBehavioursSkipped} MonoBehaviours and {otherAssetsSkipped} other assets could not " +
            $"be deserialized. {primaryStrings.Count} m_Text/text strings written to {outputPath}, " +
            $"{allEntries.Count} total strings written to {otherOutputPath}");
        Console.WriteLine(
            $"classdata.tpk loaded: {manager.ClassPackage != null}. Cpp2IL MonoBehaviour generator " +
            $"loaded: {monoGeneratorAvailable} (GameAssembly.dll+global-metadata.dat found: " +
            $"{monoGeneratorAvailable}). Asset files WITH an embedded type tree: {typeTreeAssetFiles}, " +
            $"WITHOUT one (need classdata.tpk to describe engine types): {noTypeTreeAssetFiles}.");

        if (errorCounts.Count > 0)
        {
            Console.WriteLine("Top failure reasons:");
            foreach (var (message, count) in errorCounts.OrderByDescending(kv => kv.Value).Take(5))
                Console.WriteLine($"  [{count}x] {message}");
        }
    }

    private static void RecordError(Dictionary<string, int> errorCounts, string message)
    {
        errorCounts[message] = errorCounts.GetValueOrDefault(message) + 1;
    }

    // Unlike PrefabTextDumperService (which only scans standalone external bundles reachable via
    // AssetBundle.LoadFromFile, since Unity's monolithic internal files aren't loadable that way
    // at runtime), this offline scan can open globalgamemanagers/level*/sharedassets* directly as
    // serialized assets files - they use the same SerializedFile format as a standalone .assets
    // file, just without a distinct extension. Only genuinely unparseable companion payloads are
    // excluded: ".resS"/".resource" streams are raw data blobs (audio/texture bytes) referenced by
    // a StreamingInfo elsewhere and have no SerializedFile header of their own, and ".manifest" is
    // plain-text bundle metadata - AssetsTools correctly rejects all three with "signature not
    // supported" since they were never meant to be opened as a top-level asset container.
    private static bool IsCandidateAssetFile(string path)
    {
        var ext = Path.GetExtension(path).ToLowerInvariant();
        return ext != ".resource" && ext != ".ress" && ext != ".manifest";
    }

    private static void ScanFile(
        AssetsManager manager, string path, Dictionary<string, (string LeafField, string Path)> exportedStrings, Dictionary<string, int> errorCounts,
        ref int scannedAssets, ref int monoBehavioursSkipped, ref int otherAssetsSkipped,
        ref int typeTreeAssetFiles, ref int noTypeTreeAssetFiles, HashSet<string> exploreRootLabelsSeen)
    {
        var ext = Path.GetExtension(path).ToLowerInvariant();

        // Only genuine AssetBundle containers go through the bundle path - everything else
        // (".assets", or no extension at all, e.g. "globalgamemanagers"/"level0") is opened
        // directly as a serialized assets file.
        if (ext is not (".unity3d" or ".assetbundle" or ".bundle"))
        {
            var instance = manager.LoadAssetsFile(path, false);
            LoadClassDatabaseIfNeeded(manager, instance);
            CountTypeTree(instance, ref typeTreeAssetFiles, ref noTypeTreeAssetFiles);
            ScanAssetsFile(manager, instance, exportedStrings, errorCounts, ref scannedAssets, ref monoBehavioursSkipped, ref otherAssetsSkipped, exploreRootLabelsSeen);
            return;
        }

        // .unity3d / .assetbundle / .bundle - an AssetBundle container wrapping one or more
        // serialized assets files.
        var bundle = manager.LoadBundleFile(path, true);
        for (var i = 0; i < bundle.file.BlockAndDirInfo.DirectoryInfos.Count; i++)
        {
            if (!bundle.file.IsAssetsFile(i))
                continue;

            var instance = manager.LoadAssetsFileFromBundle(bundle, i, false);
            LoadClassDatabaseIfNeeded(manager, instance);
            CountTypeTree(instance, ref typeTreeAssetFiles, ref noTypeTreeAssetFiles);
            ScanAssetsFile(manager, instance, exportedStrings, errorCounts, ref scannedAssets, ref monoBehavioursSkipped, ref otherAssetsSkipped, exploreRootLabelsSeen);
        }
    }

    private static void CountTypeTree(AssetsFileInstance instance, ref int typeTreeAssetFiles, ref int noTypeTreeAssetFiles)
    {
        if (instance.file.Metadata.TypeTreeEnabled)
            typeTreeAssetFiles++;
        else
            noTypeTreeAssetFiles++;
    }

    private static void LoadClassDatabaseIfNeeded(AssetsManager manager, AssetsFileInstance instance)
    {
        if (manager.ClassDatabase != null || manager.ClassPackage == null)
            return;

        manager.LoadClassDatabaseFromPackage(instance.file.Metadata.UnityVersion);
    }

    private static void ScanAssetsFile(
        AssetsManager manager, AssetsFileInstance instance, Dictionary<string, (string LeafField, string Path)> exportedStrings, Dictionary<string, int> errorCounts,
        ref int scannedAssets, ref int monoBehavioursSkipped, ref int otherAssetsSkipped, HashSet<string> exploreRootLabelsSeen)
    {
        foreach (var info in instance.file.Metadata.AssetInfos)
        {
            scannedAssets++;

            if (info.TypeId == TextAssetClassId)
                continue;

            AssetTypeValueField? baseField;
            try
            {
                baseField = manager.GetBaseField(instance, info);
            }
            catch (Exception ex)
            {
                // No type tree and no template generator able to describe this asset's layout
                // (e.g. a MonoBehaviour with a stripped type tree and no Cpp2IlTempGenerator wired
                // up) - skip it rather than aborting the whole file, same as
                // PrefabTextDumperService's per-object try/catch around ExtractTextFromGameObject.
                // Counted separately from other failures since MonoBehaviour is where most
                // hardcoded UI text (TextMeshProUGUI/custom scripts) actually lives.
                if (info.TypeId == MonoBehaviourClassId)
                    monoBehavioursSkipped++;
                else
                    otherAssetsSkipped++;
                RecordError(errorCounts, ex.Message);
                continue;
            }

            if (baseField == null)
            {
                if (info.TypeId == MonoBehaviourClassId)
                    monoBehavioursSkipped++;
                else
                    otherAssetsSkipped++;
                RecordError(errorCounts, "GetBaseField returned null");
                continue;
            }

            // For MonoBehaviours, resolve the owning script's actual class name (e.g. "InnData")
            // via the m_Script PPtr so the recorded path reads like "ClassName.fieldName..."
            // instead of the generic "MonoBehaviour" type name. Falls back to the asset's own
            // TypeName (e.g. "GameObject", "Transform") for everything else.
            var rootLabel = info.TypeId == MonoBehaviourClassId
                ? ResolveMonoScriptClassName(manager, instance, baseField) ?? baseField.TypeName
                : baseField.TypeName;

            // TEMP diagnostic (2026-09-03): see declaration in DumpChineseTextFromAssets.
            if (rootLabel.IndexOf("explore", StringComparison.OrdinalIgnoreCase) >= 0)
                exploreRootLabelsSeen.Add(rootLabel);

            ExtractChineseText(baseField, exportedStrings, rootLabel);
        }
    }

    // Resolves a MonoBehaviour asset's "m_Script" PPtr to the actual game script class name (e.g.
    // "InnData", "InnIconController") via MonoScript.m_ClassName. Best-effort: any failure (script
    // asset missing, PPtr unresolved, etc.) falls back to null so the caller uses the generic
    // asset TypeName instead.
    private static string? ResolveMonoScriptClassName(AssetsManager manager, AssetsFileInstance instance, AssetTypeValueField baseField)
    {
        try
        {
            var scriptField = baseField["m_Script"];
            if (scriptField == null || scriptField.IsDummy)
                return null;

            var external = manager.GetExtAsset(instance, scriptField, false, AssetReadFlags.None);
            var classNameField = external.baseField?["m_ClassName"];
            return classNameField != null && !classNameField.IsDummy ? classNameField.AsString : null;
        }
        catch
        {
            return null;
        }
    }

    // Walks every field on the deserialized asset looking for a string value containing Chinese -
    // covers UI.Text/TMP_Text's "m_Text"/"m_text" and any other stray string field on a
    // MonoBehaviour/prefab component. Unlike the runtime dumper there's no live Component/
    // GameObject tree to walk here, only the serialized field tree, so we don't hardcode a fixed
    // set of field names. TextAsset content is skipped upstream in ScanAssetsFile (see
    // TextAssetClassId), and MaxStringLength guards against any other field that happens to hold a
    // large blob rather than genuine short UI text.
    //
    // "path" tracks the dotted ancestor chain down to (but not including) the current field, so
    // array/list elements - which AssetsTools.NET always names "data" at the leaf regardless of
    // the real field name - can still be traced back to the owning class/field (e.g.
    // "InnData.innSearchNames.Array.data") instead of a bare, unhelpful "data".
    private static void ExtractChineseText(AssetTypeValueField field, Dictionary<string, (string LeafField, string Path)> exportedStrings, string path)
    {
        var currentPath = string.IsNullOrEmpty(path) ? field.FieldName : $"{path}.{field.FieldName}";

        if (field.Value != null && field.Value.ValueType == AssetValueType.String)
        {
            var text = field.AsString;
            if (!string.IsNullOrEmpty(text)
                && text.Length <= MaxStringLength
                && ChineseCharPattern.IsMatch(text)
                && !IgnoredFieldNames.Contains(field.FieldName))
            {
                var normalized = text.Replace("\n", "\\n").Replace("\r", "");
                exportedStrings.TryAdd(normalized, (field.FieldName, currentPath));
            }
        }

        foreach (var child in field.Children)
            ExtractChineseText(child, exportedStrings, currentPath);
    }

    // "m_Name" is the GameObject/Asset's own name in the editor hierarchy (often set to a Chinese
    // label by the dev) rather than player-facing UI text, and "first" shows up on
    // dictionary/pair-like fields (e.g. Spine skin/animation name lookups) for the same reason -
    // both are identifiers, not text a player would ever see rendered. A path-based filter was
    // tried first but didn't reliably catch these (asset path shape varies too much), so this
    // filters by the field name that actually holds the value instead.
    private static readonly string[] IgnoredFieldNames = ["m_Name", "first"];

    // The two field names UI.Text/TMP_Text components actually use for their rendered text
    // ("m_Text" on UI.Text, "m_text"/serialized as "text" on TMP_Text - see the class-level doc
    // comment). Everything else found by the generic field walk (plotText, tutorialText,
    // choiceText, eventDescribe, startRemindText, etc.) is real dialogue/plot text living on
    // custom MonoBehaviour fields, not the component's own displayed-text field, so it's routed to
    // dumpedOtherText.txt instead - see DumpChineseTextFromAssets above.
    private static bool IsPrimaryTextField(string fieldName) =>
        string.Equals(fieldName, "m_Text", StringComparison.OrdinalIgnoreCase)
        || string.Equals(fieldName, "text", StringComparison.OrdinalIgnoreCase);
}
