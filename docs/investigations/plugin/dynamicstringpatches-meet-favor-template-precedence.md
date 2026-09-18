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

`DynamicStringPatches.PatchAll` now compiles a translated-literal variant for templates whose literal portions are themselves covered by the fragment dictionary. It also orders compiled templates by descending literal-segment length before applying them. The complete meet-favor template therefore runs before broad fragment-shaped templates such as `#SourceHeroName#好感`.

The translated-literal variant is a fallback for partially translated input; ordering remains important because it preserves the larger template's natural translation whenever the raw literals are still present.

Temporary meet-favor diagnostics were removed after the live fix was confirmed. Diagnostic logging was also guarded during investigation because logging through patched string methods recursively re-entered the translation pipeline and produced misleading chain entries.

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
