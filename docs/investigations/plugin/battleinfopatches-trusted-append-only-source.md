# `BattleInfoPatches`/`InfoListPatches` — trusted-append-only-source pattern

Both patch classes are source-level hooks that pre-translate a line of text before it gets
appended to an ever-growing combat/HUD log, instead of letting the sink-level `Text.text` setter
patch (`DynamicStringPatches.ApplyToComponentText`) re-scan the whole accumulated buffer with the
full templates+dictionary pipeline on every single append (O(n) work per line, so per-line lag
compounds as the log grows — confirmed in-game for the battle log: delay grows with fight length).

Pre-translating the incoming fragment alone is not enough. `ApplyToComponentText` still runs a
full `ContainsCjk`/`RunGenericPipeline` pass over the *entire* buffer on every `.text` set unless
the underlying `Text`/`TMP_Text`/`UILabel` component has been marked via
`DynamicStringPatches.MarkTrustedAppendOnlySource` — that's what lets it trust that only the newly
grown suffix needs checking. Both hooks call `LTLocalization.SetText(component, text)` internally
(the game's own static text-setting helper, not a direct `.text =`), which is what ultimately
triggers the `Text.text` setter Harmony patch — see `LTLocalization.SetText` usage in
`Converter/output/_NoNamespace/InfoTextList.cs` (`this.textLabel`, a `Text`) and
`Converter/output/_decompiled/_NoNamespace/BattleController/AddInfoText.c` (`GameObject
.GetComponent(this.infoText, <type token>)`, resolved to `Text` by analogy with the `InfoTextList`
case since both feed the same `LTLocalization.SetText` helper).

**Confirmed bug (fixed 2026-08-31):** `BattleInfoPatches.AddInfoText_Prefix` translated the
incoming line but never called `MarkTrustedAppendOnlySource` on `BattleController.infoText`'s
`Text` component, unlike `InfoListPatches` which does this for `InfoTextList.textLabel`. This
silently defeated the whole point of the source-level hook — the sink patch kept doing full-buffer
scans on every battle-log append regardless.

**Fix:** `AddInfoText_Prefix` now takes `BattleController __instance`, resolves
`__instance.infoText.GetComponent<Text>()` once per `BattleController` instance (cached via a
`ConditionalWeakTable<BattleController, object>`, exactly mirroring `InfoListPatches`'
`_markedInstances` table keyed on `InfoTextList`), and calls `MarkTrustedAppendOnlySource` on it.
Marking is retried on the next call if `infoText` isn't ready yet (component not null-checked
until read), same as `InfoListPatches`.

When adding a new source-level pre-translation hook for another growing log/text component, always
pair the translate-before-append step with a `MarkTrustedAppendOnlySource` call on the real
underlying `Text`/`TMP_Text`/`UILabel` component (not a wrapping `GameObject` or helper class) —
otherwise the sink patch gets no benefit from the source-level work.
