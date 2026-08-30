using System;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Ground-truth diagnostic aid for the still-unresolved ResetFaceSetting/ResetPlayerTag crash
/// (see .github/instructions/dragonheirplugin.instructions.md, "Post-resource-load errors"
/// section and its corrections). Static analysis of the decompiled pseudocode
/// (Converter/output/_NoNamespace/StartMenuController.cs) could not pin down which field is
/// being indexed out of range: the loop bound and the indexed list come from two DIFFERENT
/// pointer chains (`DAT_181d81570`'s statics pointer for the bound vs. `GameDataController`'s
/// instance for the actual index), and our decompiler currently can't resolve either chain to a
/// real field name (see Converter instructions for the specific limitation). Rather than keep
/// guessing from pseudocode, this Harmony Prefix logs every public instance field on the live
/// GameDataController singleton (name, declared type, and Count when the value is some kind of
/// collection) immediately BEFORE the original method body runs, so the next crash's log capture
/// gives us real field names/counts instead of another round of offset arithmetic. Remove once
/// the actual out-of-range field is identified and the real fix is in place (this is pure
/// logging - it does not change behavior).
/// </summary>
internal static class DiagnosticPatches
{
    //[HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetFaceSetting))]
    //[HarmonyPrefix]
    //private static void ResetFaceSetting_Prefix()
    //{
    //    DumpGameDataController("ResetFaceSetting");
    //}

    //[HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetPlayerTag))]
    //[HarmonyPrefix]
    //private static void ResetPlayerTag_Prefix()
    //{
    //    DumpGameDataController("ResetPlayerTag");
    //}

    
    /// <summary>
    /// Diagnostic aid for the Horse/Food/Med item-icon investigation (see chat 2026-08-30):
    /// ItemData.GetItemIconName() falls through to `return this.name;` for item types 1 (Food),
    /// 2 (Med), and the type-6/no-saddle default case (Horse), meaning the sprite lookup key used
    /// by TextureController.LoadAtlasSprite("IconAtlas", key) IS the item's raw Chinese display
    /// name for those three types only - every other type builds a purely numeric/id-based key.
    /// Logs the returned icon name plus the source item's type/subType/name so a live capture
    /// shows definitively whether the key is still raw Chinese or has already been corrupted by
    /// DynamicStringPatches' global substring-replace dictionary by the time it reaches here.
    /// Pure logging - does not change behavior. Remove once the root cause is confirmed/fixed.
    /// </summary>
    //[HarmonyPatch(typeof(ItemData), nameof(ItemData.GetItemIconName))]
    //[HarmonyPostfix]
    //private static void GetItemIconName_Postfix(ItemData __instance, ref string __result)
    //{
    //    try
    //    {
    //        MainPlugin.Logger?.LogInfo(
    //            $"DiagnosticPatches[ItemData.GetItemIconName]: type={__instance?.type}, subType={__instance?.subType}, " +
    //            $"name='{__instance?.name}', itemID={__instance?.itemID} -> iconName='{__result}'");
    //    }
    //    catch (Exception ex)
    //    {
    //        MainPlugin.Logger?.LogError($"DiagnosticPatches[ItemData.GetItemIconName]: failed to dump item: {ex}");
    //    }
    //}

    /// <summary>
    /// Bracket patch for the same investigation: logs every "IconAtlas" sprite lookup
    /// (TextureController.LoadAtlasSprite) with the exact spriteName requested and whether it
    /// resolved to a non-null Sprite, so a live capture pinpoints whether a Food/Med/Horse icon
    /// lookup is failing because the key is already-translated English text (no matching sprite
    /// in IconAtlas) rather than the original raw Chinese name. Filters to "IconAtlas" only to
    /// avoid noise from the many other atlases (UIAtlas, etc.) this same method also serves.
    /// Pure logging - does not change behavior. Remove once the root cause is confirmed/fixed.
    /// </summary>
    //[HarmonyPatch(typeof(TextureController), nameof(TextureController.LoadAtlasSprite))]
    //[HarmonyPostfix]
    //private static void LoadAtlasSprite_Postfix(string atlasPath, string spriteName, ref UnityEngine.Sprite __result)
    //{
    //    try
    //    {
    //        if (atlasPath != "IconAtlas")
    //            return;

    //        MainPlugin.Logger?.LogInfo(
    //            $"DiagnosticPatches[TextureController.LoadAtlasSprite]: atlasPath='{atlasPath}', spriteName='{spriteName}' -> resolved={(__result != null)}");
    //    }
    //    catch (Exception ex)
    //    {
    //        MainPlugin.Logger?.LogError($"DiagnosticPatches[TextureController.LoadAtlasSprite]: failed to log lookup: {ex}");
    //    }
    //}

       

    /// <summary>
    /// Reflects over an object's public fields and properties and renders them as a single
    /// "Name=Value, Name2=Value2, ..." line using <see cref="DescribeValue"/> for each value.
    /// Never throws - reused by any diagnostic patch that needs a compact per-item dump.
    /// Internal (not private) so other diagnostic patches can reuse it too.
    /// </summary>
    internal static string DumpMembersOneLine(object obj)
    {
        if (obj == null)
            return "null";

        var parts = new System.Collections.Generic.List<string>();
        foreach (var field in obj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            try
            {
                parts.Add($"{field.Name}={DescribeValue(field.GetValue(obj))}");
            }
            catch (Exception ex)
            {
                parts.Add($"{field.Name}=<error: {ex.Message}>");
            }
        }
        foreach (var prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (prop.GetIndexParameters().Length > 0) continue;
            try
            {
                parts.Add($"{prop.Name}={DescribeValue(prop.GetValue(obj))}");
            }
            catch (Exception ex)
            {
                parts.Add($"{prop.Name}=<error: {ex.Message}>");
            }
        }

        return string.Join(", ", parts);
    }

    private static void DumpGameDataController(string context)
    {
        try
        {
            var gdc = GameDataController.Instance;
            if (gdc == null)
            {
                MainPlugin.Logger?.LogWarning($"DiagnosticPatches[{context}]: GameDataController.Instance is null");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"DiagnosticPatches[{context}]: dumping GameDataController instance fields/properties before original method runs:");

            // Plain reflection over the wrapper instance's public fields AND properties - not a
            // generic Il2Cpp interop call (Cast<T>/TryCast<T>), so this is safe per the interop
            // rules in this file's own instructions doc. NOTE: a first pass here that only
            // checked GetFields() found zero members - this interop build (be.785) exposes
            // GameDataController's members as public PROPERTIES, not fields, unlike what the
            // decompiled pseudocode's `public List<...> fieldName;` declarations suggest. Always
            // check both when reflecting over an interop wrapper type.
            int memberCount = 0;
            foreach (var field in gdc.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                memberCount++;
                try
                {
                    var value = field.GetValue(gdc);
                    sb.AppendLine($"  [field] {field.FieldType.Name} {field.Name} = {DescribeValue(value)}");
                }
                catch (Exception fieldEx)
                {
                    sb.AppendLine($"  [field] {field.FieldType.Name} {field.Name} = <error reading: {fieldEx.Message}>");
                }
            }
            foreach (var prop in gdc.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (prop.GetIndexParameters().Length > 0) continue; // skip indexers
                memberCount++;
                try
                {
                    var value = prop.GetValue(gdc);
                    sb.AppendLine($"  [prop]  {prop.PropertyType.Name} {prop.Name} = {DescribeValue(value)}");
                }
                catch (Exception propEx)
                {
                    sb.AppendLine($"  [prop]  {prop.PropertyType.Name} {prop.Name} = <error reading: {propEx.Message}>");
                }
            }

            if (memberCount == 0)
                sb.AppendLine("  <no public instance fields or properties found via reflection>");

            MainPlugin.Logger?.LogInfo(sb.ToString());
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[{context}]: failed to dump GameDataController: {ex}");
        }
    }

    /// <summary>
    /// Describes a field value concisely: for anything with a public Count property (List, 
    /// Dictionary, Il2Cpp collections, etc.) logs the runtime type + Count; otherwise falls back
    /// to ToString(). Never throws - callers already wrap per-field access in try/catch too.
    /// </summary>
    private static string DescribeValue(object value)
    {
        if (value == null)
            return "null";

        var countProp = value.GetType().GetProperty("Count");
        if (countProp != null)
        {
            try
            {
                var count = countProp.GetValue(value);
                return $"<{value.GetType().Name}> Count={count}";
            }
            catch
            {
                // Fall through to ToString() below.
            }
        }

        return value.ToString();
    }
}
