# `StringMapExtractor.CsvUnescape` could corrupt `_string_map.csv` values on round-trip

**Fixed.** `CsvEscape`/`CsvUnescape` (used to persist DAT_-address → string-literal mappings) were
implemented as a sequence of global `string.Replace` calls. `CsvUnescape` unescaped `\"`, `\r`,
`\n`, `\t` **before** `\\`, so a source string containing a literal backslash immediately followed
by a literal `n`/`r`/`t`/`"` (e.g. a Windows-style path or a regex-like fragment embedded in game
text) — which `CsvEscape` correctly encodes as an escaped backslash (`\\\\`) followed by the
untouched letter — got mis-parsed: the `\n`-unescape pass matched across the boundary between the
second backslash of the escaped pair and the following literal letter, silently turning a real
`backslash + letter` sequence into a newline and eating one of the two backslashes.

This is exactly the "decompiler is corrupting strings" symptom — a `DAT_` address would resolve
(via pass 5a) to a subtly mangled string instead of the true literal.

**Fix applied**: `CsvUnescape` now does a single left-to-right character scan that consumes each
recognised two-character escape atomically, so there is no cross-boundary ambiguity between the
`\\` escape and the `\r`/`\n`/`\t`/`\"` escapes.

**If revisited**: if a similar "value differs subtly from what's in the binary" report comes up
again for `_string_map.csv`-sourced text, suspect this same class of bug (sequential-`Replace`-based
escaping) before looking at the PE/metadata extraction logic.
