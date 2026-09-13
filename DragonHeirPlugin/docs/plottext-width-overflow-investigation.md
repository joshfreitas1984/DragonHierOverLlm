# PlotText width overflow: investigation narrative

Full case study behind the `PlotTextSizePatches` fix (summarized as current-state in
`docs/plottextsizepatches-agent-reference.md`). Kept for the misdiagnoses along the way, since
each one is a real trap for the next person touching this area.

## The report

`Canvas/PlotPanel/PlotTextBack/PlotText` (the dialogue speech bubble) appeared to grow past the
edges of the screen, worst for long/translated dialogue lines (English runs longer than the
original Chinese). The user's own external TextResizer plugin config for this exact path
(`Files/Resizers/Canvas_PlotPanel.yaml`) had no `adjustWidth`/`adjustX` entry unlike its sibling
entries, and setting one had no effect - ruling the resizer out early, confirmed by disabling it
entirely and reproducing the same overflow.

## Misdiagnosis #1: assuming the game code resizes the box

Static analysis of the decompiled `PlotController.ShowSinglePlot`
(`Converter/output/_NoNamespace/PlotController.cs`) found no `sizeDelta`/`rect` writes - only
`pivot`/`localScale`/`localPosition` changes for left/right speaker mirroring. This was actually
correct as far as it went (that method really doesn't resize anything), but it wrongly implied
there was *no* runtime resize happening anywhere, when the real resize was happening via Unity's
own layout system (`VerticalLayoutGroup`/`ContentSizeFitter`), invisible to a decompiled-pseudocode
read since it's driven by native Unity engine code, not a traceable managed call site.

## Misdiagnosis #2: assuming `PlotTextBack` is the visible border

A custom diagnostic (`DiagnosticPatches`, since removed) dumped `PlotTextBack`'s RectTransform and
found it frozen at `(80.0, 62.5)` in every single capture, with its `ContentSizeFitter` reporting
`enabled=true, horizontalFit=PreferredSize, verticalFit=PreferredSize` and never actually firing
(its `sizeDelta` setter was never even called, confirmed via a Harmony hook on the setter itself).
This looked like a contradiction (an enabled, correctly-configured `ContentSizeFitter` that
somehow never fires) until a full recursive dump of the `PlotPanel` hierarchy revealed
`PlotBackBlack`/`PlotBack` - a completely separate, fixed `2000x290` backdrop panel
(`sprite="Through 用白色纸块"`, roughly "translucent paper panel") sitting right alongside the tiny
`PlotTextBack` bubble. `PlotTextBack` (`sprite="For 话框"`, "speech bubble") really is just a small,
mostly-static bubble/tail graphic; the big static backdrop everyone was looking at in screenshots
is a different, unrelated, non-reactive GameObject. The thing actually growing/shrinking the whole
time was `PlotText` itself.

## Misdiagnosis #3: clamping `RectTransform.sizeDelta` directly

The first working version of the fix patched `RectTransform.sizeDelta`'s setter and clamped
`PlotText`'s width there. This worked in that the final applied size was correct - but
`VerticalLayoutGroup` had already used the ORIGINAL, uncapped `preferredWidth` to calculate the
child's aligned *position* before that clamped size was ever written. Position and size then
disagreed: logging `PlotText`'s own screen-space position across consecutive layout passes (same
session, same clamp value) showed it drifting nearly 1300px across the screen between passes
instead of converging to a stable spot. The fix was to clamp `Text.preferredWidth` itself (an
*input* the layout group reads) instead of `RectTransform.sizeDelta` (its *output*), so position
and size math both use the same corrected number from the start.

## Misdiagnosis #4: guessing the safe max width, twice, in the wrong direction

With position now stable, the remaining question was what "safe" width to clamp to. Three
consecutive wrong guesses:

1. A flat constant (`700`, then `600`) - overflowed, since it ignored `PlotTextBack`'s actual
   anchor offset from screen-center entirely.
2. A dynamic formula, `halfCanvasWidth - |anchoredX|` (the distance from the anchor to the
   *near* screen edge) - mathematically self-consistent (verified against a ground-truth
   `RectTransformUtility.WorldToScreenPoint` projection, which matched the formula's inputs
   exactly), but the box doesn't grow toward the near edge at all. This produced a needlessly tiny
   clamp (~300 units) that wrapped short lines far too aggressively while `f8`-forced long test
   strings still overflowed - the two symptoms looked contradictory until connecting them: a
   tighter width clamp forces more wrapped lines (a taller box), so a persistent report of
   overflow *after* narrowing the horizontal clamp raised (and briefly seemed to confirm) a
   vertical-overflow theory, but that trail turned out to be a dead end - vertical ground-truth
   logging showed the box comfortably within screen bounds the whole time.
3. Asking directly: does the bubble visually grow left or right? Answer - a left speaker's bubble
   grows rightward (toward/past center), a right speaker's grows leftward (toward/past center).
   Growth is toward center and past it, not away from the anchor toward the near edge. The correct
   formula is `halfCanvasWidth + |anchoredX|` (distance to the OPPOSITE edge) - the near-edge
   formula had measured room in a direction the box never actually grows into.

With the direction fixed, the very first real test (an intentionally extreme `f8` stress string)
still nearly touched the far edge, because the formula's default safety margin (`40` units) was
too thin for real-world font-rendering variance at a nearly-edge-to-edge width. Bumping
`PlotTextWidthMargin` to `150` (live-tunable, no rebuild needed) resolved it.

## Interop findings worth keeping

- `is ContentSizeFitter` / `is LayoutGroup` pattern-matching against an object obtained from
  `GetComponents<Component>()` silently fails to match here even when the component genuinely IS
  that type. Reading the real IL2CPP native class name directly (`il2cpp_object_get_class` +
  `il2cpp_class_get_name` via `Il2CppInterop.Runtime.IL2CPP`) proved both components were present
  while the `is` checks kept missing them. A direct, statically-typed `GetComponent<T>()` call
  works reliably; enumerating `GetComponents<Component>()` and pattern-matching each element does
  not.
- `RectTransform.GetWorldCorners` does not marshal correctly through this game's IL2CPP interop -
  it always returns 4 identical, effectively-zeroed corners regardless of the RectTransform's real
  bounds. A plain `.position` property read plus `RectTransformUtility.WorldToScreenPoint` works
  fine as a substitute for a screen-space ground-truth check.
- `BasePlugin` (unlike Mono's `BaseUnityPlugin`) never gets a real Unity `Update()` call, and
  `AddComponent<T>`/`ClassInjector.RegisterTypeInIl2Cpp<T>` crash with an
  `AccessViolationException` in this game's IL2CPP build (confirmed previously in
  `FanslationStudio.Plugins.TextResizerPlugin`, reused here). Patching `Time.deltaTime`'s getter
  (read every frame by ordinary game code, deduped by `Time.frameCount`) gives a safe once-per-
  frame tick without any generic interop call.

## Current state

See `docs/plottextsizepatches-agent-reference.md` for the shipped fix, its formulas, and the
change checklist.
