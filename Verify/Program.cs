// Persistent, repo-scoped verification/reproduction harness project - see
// .github/copilot-instructions.md's "Verification harnesses" rule. Use this project for one-off
// reproductions of logic bugs (regex/string-processing, etc.) outside of the running game and
// outside of Tests/ (the real xunit test suite). Do NOT delete this project after use - just
// add new scenarios (see RunScenarios below) as new bugs come up. KEEP every prior scenario
// passing when adding/changing logic here - this file doubles as a regression suite for
// DynamicStringPatches' short-entry CJK-adjacency boundary check, so a change that fixes one
// scenario but silently breaks an earlier one is caught immediately by re-running this project.
//
// PROTOTYPE (2026-08-30): "学识技能+1" (a stat-name + literal "技能" + delta popup, built via
// HeroData.ChangeLivingSkill/ChangeFightSkill's `String.Concat(statName, "技能")` - confirmed via
// the decompiled Converter/output/_decompiled/_NoNamespace/HeroData/ChangeLivingSkill.c /
// ChangeFightSkill.c, both of which literally do
// `String.Concat(<statName>, DAT_181d99658 /* "技能" */)`) was left completely untranslated
// because BOTH "学识" and "技能" are legitimate <=2-char dictionary entries sitting directly
// adjacent to each other - ShortEntryBoundaryCheckMaxLength's naive "is the neighbor CJK at all"
// check can't tell "two short entries concatenated, fully covering the CJK span" (safe) apart
// from "a short entry embedded inside one longer UNKNOWN compound" (the original bug this check
// existed to prevent, e.g. "武者" inside "一场武者比武大赛"). Prototyped fix: replace the naive
// single-neighbor-char check with a "is the adjacent CJK run FULLY tileable by dictionary
// entries" check (IsFullyCoveredByDictionary) - a short entry is only blocked if its adjacent CJK
// run contains at least one character with NO possible dictionary coverage at all, so two (or
// more) legitimately-adjacent short entries can now combine safely, while a short entry still
// correctly refuses to tear itself out of a longer compound that has genuinely uncovered CJK
// nearby (see Scenario 2/3 below - both still correctly blocked).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Entry
{
    public string Raw = "";
    public string? Result;
    public char? LeadChar;
    public char? TrailChar;
}

class Program
{
    static bool IsCjkChar(char c) =>
        (c >= '\u4E00' && c <= '\u9FFF') || (c >= '\u3400' && c <= '\u4DBF') ||
        (c >= '\u3000' && c <= '\u303F') || (c >= '\uF900' && c <= '\uFAFF');

    static int FindTagStartBackward(string s, int closeIdx)
    {
        var j = closeIdx - 1;
        while (j >= 0 && s[j] != '<' && s[j] != '>') j--;
        if (j < 0 || s[j] != '<') return -1;
        var k = j + 1;
        if (k <= closeIdx - 1 && s[k] == '/') k++;
        return k <= closeIdx - 1 && char.IsLetter(s[k]) ? j : -1;
    }
    static char? EffectiveTrailingCharBefore(string s, int index)
    {
        var i = index - 1;
        while (i >= 0)
        {
            if (s[i] == '>')
            {
                var tagStart = FindTagStartBackward(s, i);
                if (tagStart >= 0) { i = tagStart - 1; continue; }
            }
            return s[i];
        }
        return null;
    }
    static int FindTagEndForward(string s, int openIdx)
    {
        var j = openIdx + 1;
        while (j < s.Length && s[j] != '<' && s[j] != '>') j++;
        if (j >= s.Length || s[j] != '>') return -1;
        var k = openIdx + 1;
        if (k < j && s[k] == '/') k++;
        return k < j && char.IsLetter(s[k]) ? j : -1;
    }
    static char? EffectiveLeadingCharAt(string s, int startIndex)
    {
        var i = startIndex;
        while (i < s.Length)
        {
            if (s[i] == '<')
            {
                var tagEnd = FindTagEndForward(s, i);
                if (tagEnd >= 0) { i = tagEnd + 1; continue; }
            }
            return s[i];
        }
        return null;
    }
    static char? EffectiveTrailingCharInBuilder(StringBuilder sb)
    {
        var i = sb.Length - 1;
        while (i >= 0)
        {
            if (sb[i] == '>')
            {
                var tagStart = FindTagStartBackwardSb(sb, i);
                if (tagStart >= 0) { i = tagStart - 1; continue; }
            }
            return sb[i];
        }
        return null;
    }
    static int FindTagStartBackwardSb(StringBuilder sb, int closeIdx)
    {
        var j = closeIdx - 1;
        while (j >= 0 && sb[j] != '<' && sb[j] != '>') j--;
        if (j < 0 || sb[j] != '<') return -1;
        var k = j + 1;
        if (k <= closeIdx - 1 && sb[k] == '/') k++;
        return k <= closeIdx - 1 && char.IsLetter(sb[k]) ? j : -1;
    }

    // Index-returning counterparts of EffectiveTrailingCharBefore/EffectiveLeadingCharAt, used to
    // walk an entire contiguous (tag-skipping) CJK run one character at a time instead of just
    // peeking a single neighbor - see CollectEffectiveCjkRunBefore/After below.
    static int EffectiveTrailingIndexBefore(string s, int index)
    {
        var i = index - 1;
        while (i >= 0)
        {
            if (s[i] == '>')
            {
                var tagStart = FindTagStartBackward(s, i);
                if (tagStart >= 0) { i = tagStart - 1; continue; }
            }
            return i;
        }
        return -1;
    }
    static int EffectiveLeadingIndexAt(string s, int startIndex)
    {
        var i = startIndex;
        while (i < s.Length)
        {
            if (s[i] == '<')
            {
                var tagEnd = FindTagEndForward(s, i);
                if (tagEnd >= 0) { i = tagEnd + 1; continue; }
            }
            return i;
        }
        return -1;
    }

    // Collects the contiguous run of effective (tag-skipping) CJK characters immediately
    // before/after a candidate match, in original left-to-right order, stopping at the first
    // non-CJK character (or start/end of string). Tags encountered along the way are skipped
    // entirely (never included in the returned run) since dictionary Raw entries are always plain
    // text with no markup of their own.
    static string CollectEffectiveCjkRunBefore(string s, int idx)
    {
        var sb = new StringBuilder();
        var i = idx;
        while (true)
        {
            var effIdx = EffectiveTrailingIndexBefore(s, i);
            if (effIdx < 0) break;
            var c = s[effIdx];
            if (!IsCjkChar(c)) break;
            sb.Insert(0, c);
            i = effIdx;
        }
        return sb.ToString();
    }
    static string CollectEffectiveCjkRunAfter(string s, int idx)
    {
        var sb = new StringBuilder();
        var i = idx;
        while (true)
        {
            var effIdx = EffectiveLeadingIndexAt(s, i);
            if (effIdx < 0) break;
            var c = s[effIdx];
            if (!IsCjkChar(c)) break;
            sb.Append(c);
            i = effIdx + 1;
        }
        return sb.ToString();
    }

    // PROTOTYPE (2026-08-30): replaces the naive "is the single adjacent character CJK" check.
    // Greedily tokenizes `run` left-to-right using the dictionary (already sorted longest-Raw-
    // first, so the most specific entry always wins at each position, same priority order
    // ApplyDictionary itself uses) - returns true only if the ENTIRE run can be tiled by
    // back-to-back dictionary entries with no leftover, uncovered CJK character. An empty run
    // (nothing adjacent, or the neighbor already isn't CJK) is vacuously fully covered.
    static bool IsFullyCoveredByDictionary(string run, List<Entry> dictionaryLongestFirst)
    {
        var pos = 0;
        while (pos < run.Length)
        {
            if (!IsCjkChar(run[pos])) { pos++; continue; }
            var matched = false;
            foreach (var e in dictionaryLongestFirst)
            {
                if (string.IsNullOrEmpty(e.Raw)) continue;
                if (pos + e.Raw.Length <= run.Length
                    && string.CompareOrdinal(run, pos, e.Raw, 0, e.Raw.Length) == 0)
                {
                    pos += e.Raw.Length;
                    matched = true;
                    break;
                }
            }
            if (!matched) return false;
        }
        return true;
    }

    static string ReplaceWithWordBoundarySpacing(string input, Entry entry, List<Entry> dictionaryLongestFirst)
    {
        var raw = entry.Raw;
        var replacement = entry.Result ?? string.Empty;
        var isShortEntry = raw.Length > 0 && raw.Length <= 2;
        var checkBefore = isShortEntry && IsCjkChar(raw[0]);
        var checkAfter = isShortEntry && IsCjkChar(raw[raw.Length - 1]);
        var sb = new StringBuilder();
        var startIndex = 0;
        int idx;
        while ((idx = input.IndexOf(raw, startIndex, StringComparison.Ordinal)) >= 0)
        {
            if (checkBefore || checkAfter)
            {
                var matchEnd = idx + raw.Length;
                var blocked = false;
                if (checkBefore)
                {
                    var beforeRun = CollectEffectiveCjkRunBefore(input, idx);
                    if (beforeRun.Length > 0 && !IsFullyCoveredByDictionary(beforeRun, dictionaryLongestFirst))
                        blocked = true;
                }
                if (!blocked && checkAfter)
                {
                    var afterRun = CollectEffectiveCjkRunAfter(input, matchEnd);
                    if (afterRun.Length > 0 && !IsFullyCoveredByDictionary(afterRun, dictionaryLongestFirst))
                        blocked = true;
                }
                if (blocked)
                {
                    sb.Append(input, startIndex, matchEnd - startIndex);
                    startIndex = matchEnd;
                    continue;
                }
            }

            sb.Append(input, startIndex, idx - startIndex);

            var prevChar = EffectiveTrailingCharInBuilder(sb);
            if (prevChar.HasValue && entry.LeadChar.HasValue
                && char.IsLetterOrDigit(prevChar.Value) && char.IsLetterOrDigit(entry.LeadChar.Value))
                sb.Append(' ');

            sb.Append(replacement);
            startIndex = idx + raw.Length;

            var nextChar = startIndex < input.Length ? EffectiveLeadingCharAt(input, startIndex) : null;
            if (entry.TrailChar.HasValue && nextChar.HasValue
                && char.IsLetterOrDigit(entry.TrailChar.Value) && char.IsLetterOrDigit(nextChar.Value))
                sb.Append(' ');
        }
        sb.Append(input, startIndex, input.Length - startIndex);
        return sb.ToString();
    }

    static string ApplyDictionary(string input, List<Entry> dictionary)
    {
        var result = input;
        foreach (var entry in dictionary)
        {
            if (string.IsNullOrEmpty(entry.Raw)) continue;
            if (result.Contains(entry.Raw))
                result = ReplaceWithWordBoundarySpacing(result, entry, dictionary);
        }
        return result;
    }

    static List<Entry> BuildDictionary(params (string Raw, string Result)[] entries)
    {
        var dict = entries.Select(e => new Entry { Raw = e.Raw, Result = e.Result }).ToList();
        foreach (var e in dict)
        {
            e.LeadChar = e.Result!.Length > 0 ? e.Result[0] : (char?)null;
            e.TrailChar = e.Result!.Length > 0 ? e.Result[e.Result.Length - 1] : (char?)null;
        }
        return dict.OrderByDescending(e => e.Raw.Length).ToList();
    }

    static int _failures;

    static void Check(string scenario, string input, List<Entry> dict, string expected)
    {
        var actual = ApplyDictionary(input, dict);
        var pass = actual == expected;
        if (!pass) _failures++;
        Console.WriteLine($"[{(pass ? "PASS" : "FAIL")}] {scenario}");
        Console.WriteLine($"  input:    {input}");
        Console.WriteLine($"  expected: {expected}");
        Console.WriteLine($"  actual:   {actual}");
    }

    static void Main()
    {
        // Scenario 1 (2026-08-30, THIS session): "学识技能+1" popup - HeroData.ChangeLivingSkill/
        // ChangeFightSkill build it via String.Concat(statName, "技能") (confirmed via decompiled
        // Converter output). Both "学识" and "技能" are legitimate standalone <=2-char entries
        // sitting directly adjacent - should now combine and fully translate.
        Check(
            "1: adjacent short entries fully cover the CJK span -> both apply",
            "HanFang<color=#00B400>学识技能+1</color>",
            BuildDictionary(
                ("技能修炼", "Skill cultivation"),
                ("技能", "Skills"),
                ("学识", "Scholarship"),
                ("技艺", "Skill"),
                ("技", "Skill")),
            "HanFang<color=#00B400> Scholarship Skills+1</color>");

        // Scenario 2 (CONFIRMED BUG #9, tag-hidden neighbor): "武者" must NOT be torn out of the
        // longer, uncovered compound "一场武者比武大赛" just because a <color> tag hides its true
        // CJK neighbor - neither "一场" nor "比武大赛" have any dictionary coverage here.
        Check(
            "2: tag-hidden neighbor, run NOT fully covered -> still blocked",
            "一场<color=#8C8C8C>武者</color>比武大赛",
            BuildDictionary(("武者", "Warrior")),
            "一场<color=#8C8C8C>武者</color>比武大赛");

        // Scenario 3 (the original 获胜/击败 short-entry regression, generalized to <=2 chars):
        // without a "击败" entry, "击" has no coverage at all, so "敌方"/"全体" must stay blocked
        // rather than partially translating and leaving "击败" stranded next to English text.
        Check(
            "3: short entries adjacent to a genuinely-uncovered char -> blocked",
            "击败敌方全体",
            BuildDictionary(("败", "Defeat"), ("敌方", "Enemy"), ("全体", "Everyone")),
            "击败敌方全体");

        // Scenario 4: same input as #3, but now "击败" has its own explicit 2-char entry - the
        // whole run is fully tileable, so every entry should now apply.
        Check(
            "4: same run as #3, once the missing entry exists -> fully applies",
            "击败敌方全体",
            BuildDictionary(("击败", "Defeat"), ("敌方", "Enemy"), ("全体", "Everyone")),
            "Defeat Enemy Everyone");

        Console.WriteLine();
        Console.WriteLine(_failures == 0 ? "ALL SCENARIOS PASSED" : $"{_failures} SCENARIO(S) FAILED");

        VerifyRepro.TemplateBlockingRepro.Run(@"G:\DragonHierOverLlm\Files\Mod");
    }
}

