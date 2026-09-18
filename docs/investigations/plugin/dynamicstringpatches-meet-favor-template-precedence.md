# DynamicStringPatches meet-favor template precedence

## Symptom

The runtime displayed the hero-meeting message with only fragment substitutions applied:

```text
You 结识了 Jianghu<color=#9A7CFF>Great Hero </color>ShenNanJuan(Initial's goodwill<color=#00B400>+9</color>)
```

The complete dynamic-string entry was present in extraction, conversion, packaging, and the deployed resource:

```text
你结识了{0}(初始好感{1})
You have met {0} (Initial affinity {1})
```

The game constructs this message dynamically in `HeroData.SetMeetFavor`; it is not a missing prefab-text entry and does not require a `GetHeroForceLvDescribe` hook.

## Investigation

Runtime diagnostics established the sequence:

1. `String.Concat` and the UI text setter both received the complete formatted message.
2. The template compiled successfully and its permissive regex matched the raw message.
3. Before the larger template ran, the generic template `#SourceHeroName#好感` matched the substring `初始好感`.
4. That smaller template translated the substring to `Initial's goodwill`.
5. The original literals `你结识了` and `初始好感` were then gone, so the larger template could no longer match.

The issue was therefore template precedence, not extraction, packaging, runtime hook coverage, or regex construction.

## Fix

`DynamicStringPatches.PatchAll` orders compiled templates by descending literal-segment length before applying them. The complete meet-favor template therefore runs before broad fragment-shaped templates such as `#SourceHeroName#好感`, so its own literals are still present (and its `Pattern`/`PermissivePattern` still has something to match) by the time it gets its turn.

Temporary meet-favor diagnostics were removed after the live fix was confirmed. Diagnostic logging was also guarded during investigation because logging through patched string methods recursively re-entered the translation pipeline and produced misleading chain entries.

An earlier version of this fix also compiled a "translated-literal variant" of each template (a
copy of the template whose literal segments were themselves pre-translated via the fragment
dictionary), intended as a fallback for partially-translated input the ordering fix didn't cover.
That mechanism was reverted - see "Performance and correctness follow-up" below - since it was
never actually exercised by this investigation's own verification trace and caused a real
production regression. The ordering fix alone is the fix; nothing else in this file is required.

## Verification

The successful runtime trace showed:

```text
stage=replace
strictMatch=False
permissiveMatch=True
blocked=False
output='You have met ... (Initial affinity ...)'
```

This confirms the target template matched through the CJK-inclusive fallback and was not rejected by the overlap guard. The later fragment pass translates the captured hero name and preserves rich-text color tags.

## Related code

- `DragonHeirPlugin/DynamicStringPatches.cs`: template compilation, ordering, and runtime application.
- `Converter/output/_NoNamespace/HeroData.cs`: dynamic construction in `HeroData.SetMeetFavor`.
- `Files/Mod/dynamicStrings.txt.yaml`: packaged source template and translation.

## Performance and correctness follow-up

A later revision of this fix added a "translated-literal variant" mechanism: for each template
whose literal segments were themselves covered by the fragment dictionary, `PatchAll` compiled a
second copy of the template with those literal segments pre-translated (e.g. Chinese `帮主`
literal replaced by `Sect Leader`), as a fallback for text that arrived at this template already
partially translated. Two problems surfaced with real usage and were reverted:

1. **Performance regression.** Compiling a variant for every eligible template nearly doubled the
   compiled-template count (confirmed live: 2,789 source templates -> 5,539 compiled), and merging
   them into the same lists `ApplyTemplatesSinglePass` scans meant every dynamic string paid to
   scan roughly twice as many candidates. An attempt to gate the variant pass behind a
   residual-CJK check (only run it when the raw pass left CJK behind) shifted, rather than fixed,
   the cost: whichever pipeline stage ran immediately before the residual-CJK check determined how
   often the variants' English literal segments were already present in the text, which determined
   how often they passed the cheap `LiteralSegments` prefilter and reached actual regex matching.
   Running dictionary substitution before the check made variants' literals spuriously present far
   more often, which showed up as a spike in "Template match timed out" warnings (e.g. for
   `'{0}Sect Leader</color>'`) on combat/battle logs.

2. **Correctness regression (worse).** Unlike a raw (Chinese-literal) template - which is
   naturally idempotent, since a successful match consumes the Chinese literal its own pattern
   depends on, so it can never match its own output again - a translated-literal variant's pattern
   is built from English text that can still resemble or overlap its own replacement output. With
   `MultiPassTemplateApplicationEnabled` re-running the template list up to three times per call,
   and the same cached log text re-entering this pipeline on redisplay, a variant could match its
   own prior output and re-insert replacement fragments. This produced live text corruption on
   combat/battle logs, e.g. `"Rumored ed ed ed ed ed ed ..."` instead of the intended single
   translation.

Given the investigation's own verification trace (see above) confirmed the fix worked through
ordering plus the existing `PermissivePattern` CJK-inclusive fallback alone - never through a
variant match - the translated-literal variant mechanism added no proven value. It has been
removed entirely (`BuildTranslatedLiteralVariant` deleted, `_compiledTemplateVariants`/
`_logNarrativeCompiledTemplateVariants` deleted); `DynamicStringPatches.PatchAll` and
`RunGenericPipeline` are back to compiling and scanning only the raw templates, ordered by
descending literal-segment length as described in "Fix" above.
