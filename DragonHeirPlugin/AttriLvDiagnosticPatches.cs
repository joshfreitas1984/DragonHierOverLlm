using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// One-off diagnostic to identify the real PlotController property backing the attribute-level
/// tier labels/thresholds shown at Canvas/HeroDetailPanel/Attri/Attris/*/Lv (e.g. the "上"/"中"/
/// "下" single-character labels). Decompiled pseudocode
/// (Converter/output/_NoNamespace/HeroDetailController.cs::SetAttriDetail,
/// GlobalData.cs::GetAttriLv) only resolves these as raw instance-field offsets 0x558 (label
/// list)/0x560 (threshold list) on the PlotController singleton, not real property names. Dumps
/// every public List-like property on PlotController.Instance with a small element count,
/// printing its full contents, the first time SetAttriDetail runs. Uses a zero-parameter Prefix
/// (no bound original-method parameters) specifically to sidestep the by-name parameter-binding
/// gotcha documented in dragonheirplugin.instructions.md - we don't need any of the original
/// args, just a hook point to read PlotController.Instance from. Remove once the real property
/// name + values are captured in the log and a permanent translation patch is written against
/// the confirmed name (see that same instructions file for the plan).
/// </summary>
internal static class AttriLvDiagnosticPatches
{
    private static bool _dumped;

    [HarmonyPatch(typeof(HeroDetailController), nameof(HeroDetailController.SetAttriDetail))]
    [HarmonyPrefix]
    private static void SetAttriDetail_Prefix()
    {
        if (_dumped) return;
        _dumped = true;

        try
        {
            var pc = PlotController.Instance;
            if (pc == null)
            {
                MainPlugin.Logger?.LogWarning("AttriLvDiagnostic: PlotController.Instance is null");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine("AttriLvDiagnostic: scanning PlotController.Instance for ALL list-like properties (no count filter):");
            foreach (var prop in pc.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (prop.GetIndexParameters().Length > 0) continue;

                object value;
                try { value = prop.GetValue(pc); }
                catch (Exception ex) { sb.AppendLine($"  {prop.Name}: <error reading: {ex.Message}>"); continue; }
                if (value == null) continue;

                var countProp = value.GetType().GetProperty("Count");
                var itemProp = value.GetType().GetProperty("Item");
                if (countProp == null || itemProp == null) continue;

                int count;
                try { count = (int)countProp.GetValue(value); }
                catch { continue; }

                // Always log Count so we can spot large data tables (e.g. only indices 0-5 ever
                // displayed) that a narrow count filter would have hidden entirely.
                if (count > 30)
                {
                    sb.AppendLine($"  {prop.PropertyType.Name} {prop.Name} (Count={count}) = <too large to dump, showing first 8>");
                    count = 8;
                }

                var items = new List<string>();
                for (int i = 0; i < count; i++)
                {
                    object item;
                    try { item = itemProp.GetValue(value, new object[] { i }); }
                    catch (Exception ex) { items.Add($"<error: {ex.Message}>"); continue; }

                    string text = item?.ToString();
                    // A bare type-name ToString() (no override) means this is a custom
                    // class/struct, not a primitive/string - reflect one level into its own
                    // public properties so nested label/threshold fields aren't hidden.
                    if (item != null && text == item.GetType().ToString())
                        text = $"{{{DiagnosticPatches.DumpMembersOneLine(item)}}}";
                    items.Add(text ?? "null");
                }
                sb.AppendLine($"  {prop.PropertyType.Name} {prop.Name} (Count={countProp.GetValue(value)}) = [{string.Join(", ", items)}]");
            }
            MainPlugin.Logger?.LogInfo(sb.ToString());
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"AttriLvDiagnostic: failed: {ex}");
        }
    }
}
