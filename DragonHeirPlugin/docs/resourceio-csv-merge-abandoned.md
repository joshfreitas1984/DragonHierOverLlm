# `ResourceIoPatches` CSV override — why row-level merge was abandoned

`Load_Postfix` used to go through `CsvMerger.MergeByFirstColumn` (still present in `CsvMerger.cs`
but no longer called), which matched base/override rows by each row's first CSV column, on the
assumption that column 0 is a stable per-row ID. **That assumption is false for at least
`NameData.csv`**: column 0 there is a repeated category label (`姓`/"Surname"), not a unique ID,
and the override file's own column 0 gets translated too (`姓` → `"Surname"`). Every base row's
lookup by `"姓"` then missed every override row keyed by `"Surname"`, so **every row silently fell
back to the original untranslated text** — no exception was thrown, the log line even reported a
successful merge with a plausible non-zero output length, but the actual in-game text never
changed. This is a good example of why "no error + plausible-looking log output" isn't sufficient
evidence a transform actually worked — always compare a snippet of the *actual resulting content*,
not just whether an operation completed without throwing.

The real reason a row-level merge isn't needed at all: `Tests/GameFileHandling.cs`'s
`PackageFinalTranslationAsync` already writes a **complete drop-in file** to `Files/Mod/*.csv` —
every row is present, with translated rows using the translated text and untranslated/failed rows
written back as their original raw text. So the file the plugin picks up under
`resources/<path>.csv` is never a partial patch; it's always the full intended replacement, and
`Load_Postfix` should just use it wholesale. If you ever reintroduce any kind of merge logic here,
first re-verify the "column 0 is a stable ID" assumption per-file — it does not hold universally.
