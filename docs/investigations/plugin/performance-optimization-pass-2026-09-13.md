# Performance optimization pass (2026-09-13)

Four targeted, low-risk performance changes across the translation pipeline's hottest call sites,
found by reading the current source directly rather than re-deriving from prior investigation
docs. None of these change translation output/behavior when everything is working normally - they
remove redundant work (duplicate scans/dispatches, per-call config lookups) or redundant I/O
(per-line log flushing) around the existing pipeline.

## 1. `UnityLogCapture` no longer flushes on every log line

`UnityLogCapture.Write` used `AutoFlush = true`, so every single `Debug.Log*` call (postfixed
across all 10 overloads) did a synchronous, flushed disk write. That's now buffered: `AutoFlush` is
off, ordinary log lines are flushed at most once per second (`FlushIntervalTicks`), and
`"Exception"`-level lines still flush immediately/unconditionally, since that's the case
crash-safety actually cares about. `MainPlugin.OnDestroy` also calls the new
`UnityLogCapture.FlushLogFile()` so a clean shutdown doesn't leave the tail of the log stuck in the
buffer.

## 2. Merged the duplicate TMP_Text/Text/UILabel setter patches

`DynamicStringPatches.cs` and `PrefabTextPatches.cs` used to each independently Harmony-patch the
same three `.text` setters, each running its own `ContainsCjk` scan and its own lookup before
either did anything. They're now merged into `DynamicStringPatches.HandleTextSetter`, which reads
the current text once, scans it for CJK once, then runs `PrefabTextPatches.TryApplyExactMatch`
(preserving the old `[HarmonyPriority(Priority.First)]` "exact match wins" order) followed by the
existing `ApplyToComponentText` dictionary/template pipeline. `PrefabTextPatches.TryApplyExactMatch`
is now a pure lookup (no `setText` side effect) - the caller owns the single `setText()` call for
whichever pipeline(s) actually changed the text, so a component's setter fires at most once per
real edit instead of once per pipeline.

## 3. Debug-hotkey tick — tried replacing the `Time.deltaTime` getter patch, reverted

`PlotTextSizePatches` Harmony-patches `Time.deltaTime`'s getter as its only way to get a periodic
"once per frame" tick (`BasePlugin` has no real `Update()`, and `AddComponent<T>`/`ClassInjector`
crash on this IL2CPP build). `deltaTime` is read many times per frame by ordinary game systems, so
in principle a genuine once-per-frame event would be cheaper.

**Tried:** subscribing to `Canvas.willRenderCanvases` (a real C# static event) via
`Il2CppInterop.Runtime.DelegateSupport.ConvertDelegate<Canvas.WillRenderCanvases>`, since the
IL2CPP-side delegate type can't take a managed method group directly.

**Result: reverted.** Confirmed live - `DelegateSupport.ConvertDelegate` crashed the entire process
with a native `AccessViolationException` inside Il2CppInterop's `GenericMethod_GetMethod_Hook`,
during plugin load. This is a hard native crash, not a catchable managed exception, so the
try/catch this code had around the subscription (meant as a safety fallback to the old
`Time.deltaTime` patch) never got a chance to run. `PlotTextSizePatches.cs` is back to Harmony-
patching `Time.deltaTime`'s getter directly, unchanged from before this pass. **Do not retry
`DelegateSupport.ConvertDelegate` for this event without confirming it works in this specific game
build first** - see the comment above `OnDeltaTimeRead_Postfix` in `PlotTextSizePatches.cs`.

## 4. Cached hot-path `ConfigEntry<bool>.Value` reads

Several "Performance"/"Debug"/"Game Bugfixes" config flags were read via `ConfigEntry<bool>.Value`
directly inside per-call hot paths (every patched `String.Concat`/`Format` call, every text-setter
call, every `Text.preferredWidth` read). `MainPlugin.BindCachedBool` now binds the `ConfigEntry<bool>`
as before AND keeps a plain cached `bool` field in sync via `ConfigEntry.SettingChanged`, so those
call sites read the cached field instead. Applied to: `ResidualCjkDebugEnabled`,
`MultiPassTemplateApplicationEnabled`, `AppendOnlySuffixTranslationEnabled`,
`SkipKnownNonCjkComponentsEnabled`, `SpeedUpPlotTextTypewriterEnabled`, `PreTranslatePlotTextEnabled`,
`ClampPlotTextWidthEnabled`. `SentenceBoundaryAwareTemplateCaptureEnabled` was deliberately left
alone - it's baked into each compiled template at `PatchAll` time (load-time only, never read on a
per-call path), so caching it would add nothing.

## Verification

Build passes (`dotnet build`, 0 errors, no new warnings). Still needs an in-game smoke test:
translated text should render identically to before (item 2 must not change observable output),
`unity-log.txt` should still capture an exception immediately, and the F8 `ForceTestPlotTextHotkey`
should still work (confirming `Canvas.willRenderCanvases` fires reliably in this build - if not, the
in-code fallback to the `Time.deltaTime` patch should have kicked in automatically; check the log
for the fallback warning).
