// Regression scenario for DynamicStringPatches' "split" adjacent-placeholder runs (templates like
// "我在{0}{1}，若#PlayerName#能在{2}日内赶来助阵..." whose Result separates {0} and {1}, which used
// to reject the whole template). Links the REAL DragonHeirPlugin/AdjacentRunSplitter.cs and runs it
// against the real packaged Files/Mod bare-fragment dictionary, using the exact run text seen
// in-game (pasted ApplyToComponentText log, 2026-10-01).
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace VerifyRepro;

public static class AdjacentRunSplitRepro
{
    public static bool Run(string modDir)
    {
        var raws = new HashSet<string>();
        var rawRx = new Regex(@"^- raw: ""(.*)""\s*$");
        foreach (var file in Directory.GetFiles(modDir, "*.txt.yaml"))
        {
            var lines = File.ReadAllLines(file);
            for (var i = 0; i < lines.Length; i++)
            {
                var m = rawRx.Match(lines[i]);
                if (!m.Success) continue;
                var isTemplate = false;
                for (var j = i + 1; j < lines.Length && !lines[j].StartsWith("- raw:"); j++)
                    if (lines[j].Trim() == "isTemplate: true") isTemplate = true;
                if (!isTemplate) raws.Add(m.Groups[1].Value);
            }
        }

        bool Covered(string run)
        {
            var pos = 0;
            while (pos < run.Length)
            {
                var c = run[pos];
                if (!((c >= '一' && c <= '鿿') || (c >= '　' && c <= '〿'))) { pos++; continue; }
                var hit = raws.Where(r => r.Length > 0 && pos + r.Length <= run.Length
                        && string.CompareOrdinal(run, pos, r, 0, r.Length) == 0)
                    .OrderByDescending(r => r.Length).FirstOrDefault();
                if (hit == null) return false;
                pos += hit.Length;
            }
            return true;
        }

        var ok = true;
        void Check(string run, string? left, string? right)
        {
            var parts = AdjacentRunSplitter.TrySplitInTwo(run, raws.Contains, Covered);
            var pass = left == null ? parts == null : parts != null && parts[0] == left && parts[1] == right;
            ok &= pass;
            Console.WriteLine($"[AdjacentRunSplit] {(pass ? "PASS" : "FAIL")} '{run}' -> "
                + (parts == null ? "null" : $"'{parts[0]}' | '{parts[1]}'"));
        }

        // Exact in-game text: {0} already translated, {1} still the raw dictionary fragment.
        Check("Iron Palm Gang寻得仇家踪迹", "Iron Palm Gang", "寻得仇家踪迹");
        // Same mail before any substitution.
        Check("铁掌帮寻得仇家踪迹", "铁掌帮", "寻得仇家踪迹");
        // {0} = AtAreaName already carries the direction; 北/方 are bare entries, so the seam before
        // 北方 used to tie with the real one (pasted ApplyToComponentText log, 2026-10-01 20:18).
        Check("Yuxi Village北方寻得仇家踪迹", "Yuxi Village北方", "寻得仇家踪迹");
        // No anchor anywhere: must refuse rather than guess.
        Check("甲乙", null, null);

        Console.WriteLine(ok ? "[AdjacentRunSplit] ALL PASS" : "[AdjacentRunSplit] FAILURES");
        return ok;
    }
}
