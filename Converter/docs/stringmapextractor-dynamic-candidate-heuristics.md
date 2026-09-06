# `StringMapExtractor` — dynamic-string candidate extraction heuristics

**Current**: describes the design rationale behind `ExtractDynamicStringCandidates`,
`IsExoticScriptNoise`, and `FindLogOnlyStringValues` in `Converter/Services/StringMapExtractor.cs`.

## Multi-line candidates kept as one entry (`ExtractDynamicStringCandidates`)

A value with an embedded real newline (`\r\n`/`\n`/`\r`) is kept as a single candidate rather than
split into separate lines - the newline is escaped to a literal two-character `\n` sequence so the
"one candidate per line" flat-file format can still represent it without corruption.

`FanslationStudio.LlmKit.Utility.CompoundFieldSplitter` (used by the Export step, see
`DynamicStringWorkflow.ExportDynamicStringsToCustomFormat`) already treats a real `\n` as a natural
fragment boundary on its own - each line still gets translated as its own unit via `Decompose`'s
per-fragment splits/template, so splitting here first would only throw away the surrounding
structure for no translation-quality benefit. Keeping the whole multi-line literal as one
candidate/dictionary entry also means the runtime substring-match (see
`DragonHeirPlugin/DynamicStringPatches.cs`) matches against the entire multi-line literal exactly
as it's compiled into the game - a longer, more specific match with much lower false-positive/
collision risk than N independent single-line fragments would have.

## Exotic-script / noncharacter noise filter (`IsExoticScriptNoise`)

Confirmed 2026-08-27, via `_string_map.csv` cross-reference on `DAT_181d62558`/`DAT_181d95d80`/
`DAT_181d95e88`: a false-positive class exists where .NET/ICU internal Unicode-category/culture
boundary data tables happen to get compiled as string literals into the game assembly (likely via
some BCL API touching `CharUnicodeInfo`/`RegexCharClass`/globalization tables) and happen to
contain a CJK codepoint or two among thousands of others, so they pass the CJK regex despite being
pure noise - never real user-facing dialogue/UI text. These are not corrupted/garbled extraction
(verified byte-for-byte identical against `_string_map.csv` - the extraction itself is correct),
just genuine but useless BCL data.

Real Chinese game text never legitimately mixes in Hebrew/Arabic/Thai/Lao/Tibetan/Ethiopic/Khmer/
Mongolian/Hangul-Jamo/Coptic/halfwidth-fullwidth-form/control-picture codepoints alongside CJK
ideographs, so a candidate touching 3+ of these unrelated scripts at once is a reliable signal for
this noise class. The confirmed noise instances touch 8+ distinct scripts; requiring 3 keeps a wide
margin against false positives on legitimate text.

Separately, Unicode reserves certain codepoints as permanent "noncharacters" (`U+FFFE`, `U+FFFF`,
`U+FDD0`-`U+FDEF`) that are guaranteed to never appear in any real, valid text - they exist purely
as internal sentinels/boundary markers. A string literal containing one is an unambiguous signal of
raw BCL/ICU table data (confirmed via short `␀ﾻ꿿￿蟿￾߿`-style candidates that don't touch enough
distinct scripts to trip the >=3 threshold but do contain `U+FFFE`/`U+FFFF`).

## Log/exception-message exclusion (`FindLogOnlyStringValues`)

Scans every decompiled `.c` file for non-user-facing diagnostic sink calls - Debug.Log-family calls
and exception constructor message arguments - and returns the string values passed to them, either
directly as a `DAT_xxx` literal argument or via a multi-hop backward trace through local
variables/parameters within the same function body (e.g. `uVar4 = uVar9; ... uVar9 =
String__Format(DAT_xxx,...); ... Debug__Log(uVar4,0);`).

- Exception messages are included on the same reasoning as `Debug.Log` calls: a thrown exception's
  message string is developer/diagnostic text (surfaced in a crash log/stack trace, e.g.
  `LTCSVLoader`'s out-of-range messages or `ConvertNumToChinese`'s overflow message), never
  end-user-facing text.
- IL2CPP compiles exception constructors as `<Type>Exception__ctor(this, message, methodInfo)` -
  message is the second argument (unlike `Debug.Log`, where it's first), so `ExceptionCtorRegex` is
  a separate pattern/argument index from `LogCallRegex`.
- Each backward-trace hop only follows the last assignment to a variable that appears strictly
  before the point being traced from (preserves genuine backward-data-flow order), a
  visited-variable set prevents revisiting a variable in one trace (guards against assignment
  cycles, e.g. `a = b; b = a;`), and a hop-count cap (`maxHops`) bounds the work per sink call.
- This is a best-effort heuristic, not real control-flow/data-flow analysis - a variable fed
  through a helper method call, a conditional with multiple candidate assignments, or a
  loop-carried value won't be traced correctly.
- A string value found here is excluded from candidates game-wide (by value, not by DAT_
  address/call-site), so a literal that happens to also be used as genuine user-facing text
  elsewhere (same value, different/reused DAT_ slot) is excluded too - worth spot-checking the
  resulting candidate list if this is suspected for a particular case.
- Widening the scan (more sink patterns/hops) only ever adds strings to the exclude set, so it
  can't cause a genuine user-facing string to start being included when it shouldn't be; the only
  risk is the reverse (a genuinely user-facing string excluded because it shares a
  variable-assignment chain with a sink call).
