using System;

// Pure (no game/Unity dependencies, so Verify/ can link this exact file) helper for
// DynamicStringPatches' "split" adjacent-placeholder runs. A template whose Raw has two
// placeholders glued together ("我在{0}{1}，若...") can't be bounded by regex alone, and when its
// Result separates them ("at {0} and {1}") the merged pass-through capture can't be re-emitted as
// one unit either. Instead the template captures the whole run as one span at match time and this
// helper re-divides it, using the loaded bare-fragment dictionary as the only evidence of where
// one value ends and the next begins. See
// docs/investigations/plugin/dynamicstringpatches-adjacent-placeholder-merge.md.
internal static class AdjacentRunSplitter
{
    // Returns the two halves of `run`, or null when no split point is convincing (caller then
    // leaves the matched text untouched, same outcome as the old "template rejected" behavior).
    //
    // A split point k is a candidate when both halves are non-empty and each is "covered"
    // (every CJK char is tileable by dictionary entries - non-CJK text always passes). A candidate
    // scores 1 for each half that is an exact dictionary entry or contains no CJK at all (an
    // already-translated name, a number). The best candidate wins if it scores at least 1 and is
    // unique at that score; an ambiguous tie is treated as "no convincing split".
    public static string[] TrySplitInTwo(
        string run,
        Func<string, bool> isExactEntry,
        Func<string, bool> isCovered)
    {
        if (string.IsNullOrEmpty(run) || run.Length < 2) return null;

        var bestScore = 0;
        var bestK = -1;
        var tied = false;
        for (var k = 1; k < run.Length; k++)
        {
            var left = run.Substring(0, k);
            var right = run.Substring(k);
            if (!isCovered(left) || !isCovered(right)) continue;

            var score = (IsAnchor(left, isExactEntry) ? 1 : 0) + (IsAnchor(right, isExactEntry) ? 1 : 0);
            if (score > bestScore)
            {
                bestScore = score;
                bestK = k;
                tied = false;
            }
            else if (score == bestScore && score > 0)
            {
                tied = true;
            }
        }

        if (bestK < 0 || tied) return null;
        return new[] { run.Substring(0, bestK), run.Substring(bestK) };
    }

    private static bool IsAnchor(string part, Func<string, bool> isExactEntry)
        => isExactEntry(part) || !ContainsCjk(part);

    private static bool ContainsCjk(string s)
    {
        foreach (var c in s)
            if ((c >= '一' && c <= '鿿') || (c >= '　' && c <= '〿')) return true;
        return false;
    }
}
