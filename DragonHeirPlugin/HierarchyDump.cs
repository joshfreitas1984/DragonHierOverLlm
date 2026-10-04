using System;
using System.IO;
using System.Reflection;
using System.Text;
using UnityEngine;

namespace EnglishPatch;

// Debug-only (see MainPlugin.DumpHierarchyHotkey): writes the sibling order of every direct child
// of "Canvas" - plus any per-child Canvas override (overrideSorting/sortingOrder) - to
// hierarchy-dump.txt next to the plugin DLL. Used to work out where Canvas/MissionPanel should sit
// relative to Canvas/TradePanel etc. Ticked from PlotTextSizePatches.FrameTickPatch.
internal static class HierarchyDump
{
    private static readonly string DumpFile = Path.Combine(
        Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".", "hierarchy-dump.txt");

    internal static void RunHotkeyCheck()
    {
        if (MainPlugin.DumpHierarchyHotkey == null) return;

        try
        {
            if (!MainPlugin.DumpHierarchyHotkey.Value.IsDown()) return;

            var canvasGo = GameObject.Find("Canvas");
            if (canvasGo == null)
            {
                MainPlugin.Logger?.LogWarning("HierarchyDump: no active GameObject named 'Canvas' found.");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"# Hierarchy dump at frame {Time.frameCount}");
            sb.AppendLine("# Higher index = drawn later = on top (plain sibling-order UGUI stacking).");
            AppendCanvasInfo(sb, canvasGo.transform, "Canvas (root)");
            sb.AppendLine();

            var root = canvasGo.transform;
            for (int i = 0; i < root.childCount; i++)
            {
                var child = root.GetChild(i);
                AppendChild(sb, child, i, 0);

                var name = child.name;
                if (name == "MissionPanel" || name == "TradePanel")
                {
                    for (int j = 0; j < child.childCount; j++)
                        AppendChild(sb, child.GetChild(j), j, 1);
                }
            }

            File.WriteAllText(DumpFile, sb.ToString());
            MainPlugin.Logger?.LogInfo($"HierarchyDump: wrote {root.childCount} Canvas children to {DumpFile}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"HierarchyDump: failed: {ex}");
        }
    }

    private static void AppendChild(StringBuilder sb, Transform t, int index, int depth)
    {
        var go = t.gameObject;
        sb.Append(' ', depth * 4);
        sb.Append($"[{index}] {t.name}  self={(go.activeSelf ? "on" : "off")} inHier={(go.activeInHierarchy ? "on" : "off")} children={t.childCount}");
        var canvas = go.GetComponent<Canvas>();
        if (canvas != null)
            sb.Append($"  OWN-CANVAS overrideSorting={canvas.overrideSorting} sortingOrder={canvas.sortingOrder} sortingLayer={canvas.sortingLayerID}");
        sb.AppendLine();
    }

    private static void AppendCanvasInfo(StringBuilder sb, Transform t, string label)
    {
        var canvas = t.gameObject.GetComponent<Canvas>();
        if (canvas == null)
        {
            sb.AppendLine($"{label}: no Canvas component");
            return;
        }
        sb.AppendLine($"{label}: renderMode={canvas.renderMode} sortingOrder={canvas.sortingOrder} overrideSorting={canvas.overrideSorting}");
    }
}
