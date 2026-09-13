# PlotTextSizePatches agent reference

Read this before changing `PlotTextSizePatches.cs`. Full investigation narrative (misdiagnoses
included) is in `docs/plottext-width-overflow-investigation.md`; this file keeps only the current
state and why it works.

## Symptom and root cause

`Canvas/PlotPanel/PlotTextBack/PlotText` (the dialogue speech bubble) grew past the edges of the
screen for long (especially translated, since English runs longer than the original Chinese)
dialogue lines. `PlotTextBack` has a `VerticalLayoutGroup` that does not control child width
(`childControlWidth` reads `True` but with `childForceExpandWidth=False`, it sizes the child to the
child's own reported `preferredWidth` with no cap), so `PlotText` (a legacy `UnityEngine.UI.Text`,
confirmed via `PlotTextPatches.cs`) sizes itself wide enough to fit the whole string on ONE line,
uncapped. `PlotTextBack`'s own background/`ContentSizeFitter` never resizes to match (confirmed:
its `sizeDelta` setter is never even called), so it isn't the visible thing growing - `PlotText`
itself is.

## The fix: clamp `Text.preferredWidth`, not `RectTransform.sizeDelta`

An earlier version of this fix patched `RectTransform.sizeDelta`'s setter directly. That clamped
the final *size* correctly, but `VerticalLayoutGroup` had already used the original, uncapped
`preferredWidth` to calculate the child's aligned *position* before that size was ever written -
so position and size disagreed, and the box visibly drifted to the wrong screen position across
consecutive layout passes instead of converging. Patching `Text.preferredWidth`'s getter instead
means the layout group's position AND size math both use the same corrected number from the
start, so they stay consistent. Always clamp inputs the layout system reads, not outputs it
writes.

## Computing the safe max width

`PlotTextBack` anchors at canvas-center `(0.5, 0.5)` with an `anchoredPosition.x` offset (~±600
units for a real speaker line, mirrored via `localScale.x = ±1` for left vs right), or pivots at
`(0.5, 0.5)` itself for a neutral/narrator line (both hero portraits highlighted, or one missing) -
`PlotController.ShowSinglePlot`'s three alignment branches set pivot/`Text.alignment` accordingly
but never touch `PlotText`'s own pivot, which stays a constant `(0.5, 0.5)`.

Confirmed in-game: the box grows TOWARD screen-center and past it, not away from it (a left
speaker's bubble grows rightward toward/past center; a right speaker's grows leftward toward/past
center). So the safe width is the distance from the anchor across to the OPPOSITE screen edge
(`halfCanvasWidth + |anchoredX|`), not the near edge (`halfCanvasWidth - |anchoredX|` - this was
the first, wrong version of the formula and it clamped far too conservatively, wrapping text
that had plenty of real room). `PlotPanel` fills the canvas exactly and `CanvasScaler` keeps the
canvas's own `RectTransform.rect.width` pinned to its reference resolution regardless of actual
screen size, so `canvasRect.rect.width` is a reliable, resolution-independent basis for this math -
no hand-guessed pixel constant needed.

`PlotTextWidthMargin` (config, live-reloaded) is the one value meant to be tuned day to day - it's
a safety buffer between the computed max and the actual screen edge. `PlotTextMaxWidth`/
`PlotTextMaxWidthCentered` are fallbacks only, used if the dynamic calculation can't run (e.g. no
`Canvas` ancestor found).

## Interop notes

- `is ContentSizeFitter` / `is LayoutGroup` pattern-matching against an object obtained from
  `GetComponents<Component>()` silently fails to match here even when the component genuinely IS
  that type - confirmed by reading the real IL2CPP native class name directly, which proved both
  were present while the C# `is` checks against them kept missing. Use a direct, statically-typed
  `GetComponent<T>()` call instead (works reliably here) rather than enumerating
  `GetComponents<Component>()` and pattern-matching each element.
- `RectTransform.GetWorldCorners` does not marshal correctly through this game's IL2CPP interop -
  it always returns 4 identical, effectively-zeroed corners. Use `.position` (a plain property
  read) plus `RectTransformUtility.WorldToScreenPoint` instead if a screen-space projection is
  ever needed again.
- `BasePlugin` (unlike Mono's `BaseUnityPlugin`) never gets a real Unity `Update()` call, and
  `AddComponent<T>`/`ClassInjector.RegisterTypeInIl2Cpp<T>` crash with an
  `AccessViolationException` in this game's IL2CPP build. The `ForceTestPlotTextHotkey` test
  harness instead patches `Time.deltaTime`'s getter (read every frame by ordinary game code) as a
  safe once-per-frame tick, deduped by `Time.frameCount` - the same pattern used by
  `FanslationStudio.Plugins.TextResizerPlugin`.

## The test hotkey

`ForceTestPlotTextHotkey` (config, `KeyboardShortcut`, default empty/disabled) forces a long,
newline-free, no-CJK stress string into the currently cached `PlotText` component, so
wrap/clamp behavior can be verified visually without hunting for a sufficiently long real
dialogue line. It requires a real plot dialogue to have been opened at least once already this
session, since it reuses the `PlotController` instance cached from
`ShowSinglePlot`/`PlotTextShowFinished` rather than doing a fresh (riskier) object lookup.

## Change checklist

1. Keep clamping `Text.preferredWidth` (an input to the layout system), not `RectTransform.
   sizeDelta` (its output) - see "The fix" above for why the latter caused position drift.
2. Preserve the `isCentered` branch (pivot `(0.5, 0.5)`) vs the side-anchored branch (pivot
   `(0, 0.5)`) - they need different formulas, not one flat constant.
3. Don't reintroduce a hand-guessed flat pixel/unit constant as the primary path - derive the
   safe width from the canvas's actual reference-resolution width and `PlotTextBack`'s real
   anchor offset each time, falling back to the flat config values only if that lookup fails.
4. If touching the test hotkey's tick mechanism, keep the `Time.deltaTime`-getter-patch pattern
   (see Interop notes) rather than `AddComponent<T>`/`ClassInjector`.
