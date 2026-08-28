# Converter — decompiler limitation/bug index

> This file is an **index only**. It is not auto-loaded into agent context (unlike
> `.github/instructions/converter.instructions.md`, which has `applyTo: Converter/**`). Detailed
> investigation narratives live in per-topic files under `Converter/docs/` — read only the
> specific doc relevant to your current task, not this whole index. When a new investigation
> narrative is written, add it as a NEW file under `Converter/docs/` (or extend the
> closest-matching existing one) and add a one-line pointer here — never grow this file into a
> monolith again.

- [`docs/nativemethodextractor-shared-generic-mislabeling.md`](docs/nativemethodextractor-shared-generic-mislabeling.md)
  — `NativeMethodExtractor.ExtractMethodLabels` mislabeling shared-generic-code addresses (fixed:
  first-occurrence-wins → ambiguous-address detection), plus a still-open native-trampoline-reuse
  variant affecting some `Resources.Load`-labeled calls.
- [`docs/field-resolution-hoisted-singleton-gap.md`](docs/field-resolution-hoisted-singleton-gap.md)
  — passes 3d/3e miss instance-field offsets when a singleton pointer is hoisted into a separately
  named local before the offset access.
- [`docs/stringmapextractor-metadata-v27-shift-bug.md`](docs/stringmapextractor-metadata-v27-shift-bug.md)
  — `StringMapExtractor`'s `.data`-section scan silently dropped ~half of all string literals on
  IL2CPP metadata v27+ (missing `>>1` shift); includes the pipeline re-run results.
- [`docs/stringmapextractor-csvunescape-corruption.md`](docs/stringmapextractor-csvunescape-corruption.md)
  — `CsvUnescape`'s sequential-`Replace`-based escaping could corrupt strings containing a literal
  backslash followed by `n`/`r`/`t`/`"`.
