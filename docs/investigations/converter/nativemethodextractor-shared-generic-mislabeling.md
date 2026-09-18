# `NativeMethodExtractor.ExtractMethodLabels` — shared-generic-code address mislabeling

## Fixed: first-occurrence-wins label assignment mislabeled shared-generic addresses

IL2CPP "generic sharing" compiles many distinct managed methods (e.g. `Dictionary<string, T>`
members instantiated over different reference-type `T`s) down to the **same native code
address**. The extractor used to do `result.TryAdd(rvaHex, label)` — "keep whichever method
happens to be first in the metadata table" — which silently mislabels every other method at that
shared address with a plausible-looking but WRONG name. Confirmed in the wild: several calls in
`GameDataController.cs` with args like `"[DOTween]"`, `"[BoundingBox]"`, `"[CDATA["` were labeled
`Resources.Load(...)` even though those are obviously not resource paths — some unrelated
shared-generic method (not `Resources.Load`) happened to occupy that address and win the
first-occurrence race.

**Fix applied**: collect ALL candidate labels per native address first; only emit a label when an
address has exactly one candidate. Ambiguous addresses are left unlabeled (Ghidra's default
`FUN_xxxxxxxx`) rather than guessing — a missing label is far less harmful than a confidently
wrong one, since a wrong label actively misleads investigation. Console output now reports both
counts, e.g. `Extracted N unambiguous method labels ... (M addresses skipped as
ambiguous/shared-generic)`. Verified by re-running `--filter "GameDataController"` before/after:
the bogus `Resources.Load("[DOTween]", ...)`-style calls are gone post-fix (now render as
unresolved `FUN_...` calls instead).

## Still open: some `Resources.Load`-labeled calls are wrong for a DIFFERENT reason

After the fix above, `GameDataController.cs` still contains calls like
`Resources.Load("[CDATA[", ...)`, `Resources.Load("[NGUI] ", ...)`, `Resources.Load("[/sub]",
...)` — clearly log/XML-tag-parsing strings, not resource paths. Checked `_labels.csv`: the real
`Resources.Load` managed method genuinely maps to exactly 3 distinct, unambiguous native
addresses (one per overload) — so this is NOT the same "shared managed-metadata address" bug
fixed above. This looks like IL2CPP/the game binary reusing the *same native trampoline/icall
stub code* for `Resources.Load` and some unrelated string-processing routine at the **native**
level — something our metadata-only (`LibCpp2IL`/managed methodDefs) extraction approach can't
see or disambiguate, since it only knows about managed method → address mappings, not
native-code-level code reuse.

**Not yet fixed.** If this needs solving, it would require actually inspecting/disassembling the
native function bodies at those addresses (e.g. via Ghidra's own analysis) to tell whether they're
truly identical code or just coincidentally-adjacent, rather than anything achievable in
`NativeMethodExtractor` alone.
