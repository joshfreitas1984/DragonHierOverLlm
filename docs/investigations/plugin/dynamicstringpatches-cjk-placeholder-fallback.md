# `DynamicStringPatches` CJK-inclusive placeholder fallback (2026-08-29)

> Summarized as "current state" in `.github/instructions/dragonheirplugin.instructions.md` — read
> this file for the full investigation/verification narrative behind that summary.

## Motivating symptom

Template `raw: "{0}向来秉持{1}之道，{4}。\n我身为{2}，自是应当{3}。"` (`isTemplate: true`) never
had its own translated literal connector text ("向来秉持"/"之道"/"我身为"/"，自是应当") applied,
even though `{3}`/`{4}` (hardcoded phrase-list literals baked into the same call site) translated
fine via the ordinary bare dictionary.

## Two independent investigations run in parallel

**Plan A** (why does the managed `String.Format` Harmony prefix never fire for the real call at
this site) and **Plan B** (why does the sink-level `ApplyTemplates` pass, which reliably sees the
fully-formatted string, still produce byte-for-byte identical output) — see repo memory files
`dynamicstring-format-native-hook-investigation-plan.md` / `dynamicstring-cjk-placeholder-template-
fallback-plan.md` for the full session-by-session record. Summary of conclusions:

- **Plan A**: `BepInEx/LogOutput.log` confirmed all 8 `String.Format` overloads patched correctly
  (rules out a Harmony overload-binding bug). The actual call site in
  `Converter/output/_NoNamespace/PlotController.cs` decompiles as a bare, direct `String.Format`
  symbol call — unlike every sibling BCL/game API call in the same method, which decompiles as
  `il2cpp_internal(...)`-style icall/vtable dispatches. This is consistent with the AOT compiler
  resolving/inlining this specific call natively, bypassing the interop method-table entry Harmony
  patches — i.e. likely unhookable via ordinary Harmony for this call. Not pursued further (native
  inline hooking is out of scope / no precedent in this codebase); not 100% proven (would need a
  fresh live cross-check against a different `isTemplate` template).
- **Plan B (implemented)**: root cause was in `ApplyTemplates`'s placeholder capture. Bug #3/#4's
  fix (`PlaceholderCaptureClass` excludes CJK ideographs/punctuation from placeholder captures, to
  stop over-matching into unrelated untranslated CJK text) has a side effect: **any template whose
  `{n}` placeholder's real runtime value is itself CJK text (e.g. a sect name, title) can never
  match at all**, since the capture group can never span CJK. The whole template — including its
  own literal connector text, which doesn't depend on the placeholder values — was silently
  skipped.

## Fix

`CompiledTemplate` gained a second field, `PermissivePattern`, built alongside the existing strict
`Pattern` in `BuildCompiledTemplate` (same literal segments/escaping, same named capture groups),
but using a new `PermissivePlaceholderCaptureClass = "."` (CJK-inclusive, matches any single
character except newline) instead of the strict non-CJK class. `ApplyTemplates` tries
`template.Pattern.IsMatch(result)` first (unchanged bug #3/#4 behavior); only if that fails does it
fall back to `template.PermissivePattern` before giving up on the template entirely.

## Verification methodology

No existing unit-test harness covers `DynamicStringPatches.cs` directly (BepInEx/Harmony-patch
file, not easily unit-testable in isolation). Verified via a throwaway console project
(`TempVerify/`, deleted immediately after use — this is an established repo convention for
one-off regex/logic verification outside the BepInEx host) that copy-pasted
`BuildCompiledTemplate`/`ApplyTemplates`/`OverlapsBlockingEntry` verbatim and exercised four cases:

1. The motivating "向来秉持" template against a simulated fully-formatted runtime string (real CJK
   sect/title data substituted in) — strict pattern correctly fails, permissive fallback matches
   and correctly translates only the literal connector text, leaving the CJK placeholder values
   untouched.
2. The original bug #3 case ("经验{0}%" vs "经验倍率＋0%") — passes, but **only because the real
   dictionary already has a standalone "经验倍率" entry**, which `PatchAll`'s `BlockingRawEntries`
   population loop auto-adds as a blocking entry for this template (any dictionary entry that
   contains one of the template's literal segments as a substring and is strictly longer).
3. The original bug #4 case (`BlockingRawEntries` overlap suppression) — passes unchanged.
4. Two back-to-back occurrences of a short-literal-separator CJK-placeholder template in the same
   string, to check the lazy `.+?` permissive capture doesn't span past its own template's next
   literal segment into a second occurrence — passes.

## Confirmed residual risk (not just theoretical — actually reproduced when blocking entries were omitted)

The original plan's safety analysis assumed "the permissive fallback is never reached for
bug-#3-shaped templates, since the strict pattern already matches those correctly today." That
assumption does **not** hold for the population this fix specifically targets: a template with a
legitimately-CJK placeholder has a strict pattern that **always** fails to match, by construction —
so it always reaches the permissive fallback, and if `BlockingRawEntries` doesn't happen to cover
the relevant literal segment (i.e. no existing longer dictionary phrase happens to contain it),
the permissive fallback can reproduce the exact bug #3 style over-match into unrelated adjacent
CJK text. Removing the `BlockingRawEntries` entry from the harness's case 2 setup reproduced the
original corruption (`"Experience倍率＋0%"`) immediately, confirming this is a real, not
hypothetical, gap. Current safety in practice relies entirely on `BlockingRawEntries` coverage —
**if a new bug-#3-style over-match is ever reported for a CJK-placeholder template, check
`BlockingRawEntries` coverage for that template's literal segments before assuming a novel bug.**

## Cleanup done

The temporary `SafeDebugLog`/`DebugEscape`/`isDiagTarget` diagnostic blocks (added while running
Plan A/B, gated on `Contains("向来秉持")`) were removed from `FormatPrefix`/`GenericPostfix`/
`ApplyToComponentText` once this fix was implemented and verified. Build confirmed clean via
`dotnet build DragonHeirPlugin/GamePlugin.csproj -c Release`.

## Still open

A live playtest deploy (or a real dictionary-load run, not just the isolated harness) has not yet
confirmed the "向来秉持" template's connector text renders translated in-game with the actual
packaged `Result` translation (the harness used a plausible made-up translation for verification
purposes only).
