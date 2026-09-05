# Documentation refresh — classification: DynamicString / PrefabText (First Sonnet Batch)

Review artifact produced per `docs/documentation-refresh-plan.md`'s "First Sonnet Batch". This is
a classification/inventory only — **no executable code, instruction files, or existing
documentation were modified** to produce this artifact. Intended for human review before any
implementation batch runs, and as the input handoff for a later Luna mechanical-edit pass.

## Scope

Inventoried DynamicString and PrefabText documentation, repository memories, and source comments
across `DragonHeirPlugin/`, `Tests/`, `Converter/`, `.github/instructions/`, and `/memories/repo/`.

## Classification table

| Path | Knowledge type | Current status | Proposed canonical destination | Recommendation | Confidence | Unresolved questions |
|---|---|---|---|---|---|---|
| [.github/instructions/dragonheirplugin.instructions.md](../.github/instructions/dragonheirplugin.instructions.md) (DynamicStringPatches/PrefabTextPatches sections) | Current rule + embedded historical narrative | Current, but oversized (multi-paragraph bug chronologies embedded inline, e.g. bugs #5–#9, short-entry boundary fix) | Keep short current-state summary here; move per-bug chronologies to the matching `DragonHeirPlugin/docs/*.md` (several already exist and are referenced) | Move (narrative portions only) | High | Some "Update (date) — CONFIRMED BUG #N" blocks may already be fully duplicated in the linked docs — needs a paragraph-by-paragraph diff before trimming, not assumed here |
| [.github/instructions/tests-translation-workflow.instructions.md](../.github/instructions/tests-translation-workflow.instructions.md) (PrefabText/DynamicStrings sections) | Current reference (already partially slimmed with doc pointers) | **Contains a stale/conflicting claim**: states PrefabText runtime lookup is "**not yet implemented** in `DragonHeirPlugin/`" — false; `PrefabTextPatches.cs` fully implements it (confirmed by reading the source and its agent-reference doc) | Same file, correct the claim | Keep, but flag for correction (not this batch) | High | None — verified directly against `PrefabTextPatches.cs` |
| [DragonHeirPlugin/KNOWN_ISSUES.md](../DragonHeirPlugin/KNOWN_ISSUES.md) | Index | Current, well-maintained index-only file | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/dynamicstringpatches-agent-reference.md](../DragonHeirPlugin/docs/dynamicstringpatches-agent-reference.md) | Current reference | Current, concise, matches source | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/prefabtextpatches-agent-reference.md](../DragonHeirPlugin/docs/prefabtextpatches-agent-reference.md) | Current reference | Current, concise, matches source | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/dynamicstringpatches-template-regex-bug.md](../DragonHeirPlugin/docs/dynamicstringpatches-template-regex-bug.md) | Historical investigation | Fixed/current | Stays (already correctly separated per plan) | Keep | High | — |
| [DragonHeirPlugin/docs/dynamicstringpatches-cjk-placeholder-fallback.md](../DragonHeirPlugin/docs/dynamicstringpatches-cjk-placeholder-fallback.md) | Historical investigation | Fixed; **already explicitly summarizes and supersedes** the two repo memories below | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/dynamicstringpatches-adjacent-placeholder-merge.md](../DragonHeirPlugin/docs/dynamicstringpatches-adjacent-placeholder-merge.md) | Historical investigation | Mixed: bugs #5–#7 fixed, one item (`"在下#$PlayerName#"` false-positive) explicitly flagged Open/unfixed | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/dynamicstrings-column-source-extraction.md](../DragonHeirPlugin/docs/dynamicstrings-column-source-extraction.md) | Historical investigation | Fixed/current | Stays | Keep | Medium | Partial topical overlap with `Tests/docs/dynamicstrings-extraction-sources.md` (different angle: plugin-side glob mechanism vs. pipeline-side sampling rationale) — not a true duplicate, but worth a cross-link |
| [DragonHeirPlugin/docs/prefabtextpatches-full-investigation.md](../DragonHeirPlugin/docs/prefabtextpatches-full-investigation.md) | Historical investigation | Fixed/current | Stays | Keep | High | — |
| [DragonHeirPlugin/docs/prefabtext-multiline-and-token-placeholder-bugs.md](../DragonHeirPlugin/docs/prefabtext-multiline-and-token-placeholder-bugs.md) | Historical investigation | Fixed/current | Stays | Keep | High | — |
| [Tests/KNOWN_ISSUES.md](../Tests/KNOWN_ISSUES.md) | Index | Current, well-maintained | Stays | Keep | High | — |
| [Tests/docs/dynamicstrings-pipeline-architecture.md](../Tests/docs/dynamicstrings-pipeline-architecture.md) | Current reference | **Stale**: describes the old bundled single `"1c."` fact; the pipeline was restructured 2026-09-01 into Facts `1c`–`1j` (per repo memory) but this doc was never updated | Same location, needs a rewrite | Move/Merge (content update, not relocation) | High | Confirm restructuring actually landed in `Tests/FileInputWorkflowTests.cs`/`GameFileHandling.cs` before rewriting the doc |
| [Tests/docs/dynamicstrings-extraction-sources.md](../Tests/docs/dynamicstrings-extraction-sources.md) | Historical investigation | Fixed/current, but references the same stale fact-numbering as above | Stays | Keep (minor date/reference touch-up later) | Medium | — |
| [Tests/docs/dynamicstrings-dialogue-button-fix.md](../Tests/docs/dynamicstrings-dialogue-button-fix.md) | Historical investigation | Fixed/current | Stays | Keep | High | — |
| [Tests/docs/prefabtext-pipeline-architecture.md](../Tests/docs/prefabtext-pipeline-architecture.md) | Current reference | **Stale/conflicting**: ends with "Still not implemented: the runtime BepInEx plugin patch" — false, contradicts `PrefabTextPatches.cs` and its own agent-reference doc | Same location, needs correction | Move/Merge (content update) | High | None — verified against source |
| `/memories/repo/dynamicstring-cjk-placeholder-template-fallback-plan.md` | Session-plan / historical (Plan B) | Done; conclusions **already fully absorbed** into `dynamicstringpatches-cjk-placeholder-fallback.md`, which cites this memory by name | Superseded by the doc | Delete (or reduce to a one-line pointer) | High | — |
| `/memories/repo/dynamicstring-format-native-hook-investigation-plan.md` | Session-plan / historical (Plan A) | Done; conclusion (AOT-inlined `String.Format` call likely unhookable via Harmony) is **summarized** in `dynamicstringpatches-cjk-placeholder-fallback.md` but the full "how we verified metadata dispatch shape" methodology is **not** in any project doc | Merge distilled conclusion into `DragonHeirPlugin/docs/dynamicstringpatches-cjk-placeholder-fallback.md` (already has a stub) or a new small doc; then delete memory | Merge, then delete | Medium | Is the deeper investigation methodology (decompiled-call-shape diffing) worth preserving as a reusable technique, or just the conclusion? |
| `/memories/repo/dynamicstrings-poetry-extraction-and-dedup-plan.md` | Session-plan, durable architecture change | Implemented 2026-09-01; **not reflected in any doc/instructions file** — the only record of the current Fact 1c–1j structure | `Tests/docs/dynamicstrings-pipeline-architecture.md` + `tests-translation-workflow.instructions.md` pointer update | Move (this is the highest-value un-migrated item found) | High | Confirm live code still matches this plan (memory says implemented, but verify current `FileInputWorkflowTests.cs` Fact names before writing the doc) |
| `/memories/repo/prefabtext-generic-field-walk-plan.md` | Decision record (deferred alternative design) | Not implemented; still a live "come back to this" plan | New `docs/decisions/` or `Tests/docs/` entry, referenced from `DynamicStringOtherTextFields` comment | Move | Medium | Still wanted, or has the "quick fix" become permanent enough to drop the alternative-plan idea entirely? |
| `/memories/repo/plottext-pretranslate-endvalue-plan.md` | Adjacent (PlotText, not DynamicString/PrefabText core) | Implemented; touches `DynamicStringPatches.RunGenericPipeline`/`SeedComponentTranslatedSnapshot` | Out of scope for this batch — belongs with a future PlotText/PlotTextPatches batch | Keep as-is for now | Medium | — |
| `/memories/repo/robheroitemchoose-callparam-reverse-translate-fix.md` | Adjacent (PlotInteractController, uses `DynamicStringPatches.ReverseTranslate`) | Implemented | Out of scope for this batch | Keep as-is for now | Medium | — |
| `DynamicStringPatches.cs` / `PrefabTextPatches.cs` source comments | Current invariant pointers | **Already slimmed** — comments are one-line `// Detailed rationale and invariants: docs/...md` pointers, not narrative | N/A | Keep (Phase 4 goal already met for these two files) | High | — |
| `Converter/docs/stringmapextractor-metadata-v27-shift-bug.md` | Historical investigation + open operational item | Fixed extraction bug; 3680 new dynamic-string candidates still awaiting manual review/merge into `dynamicStrings.txt` | Stays; the "still needs review" line could also be surfaced in `Tests/KNOWN_ISSUES.md`'s DynamicStrings section | Keep | Medium | Is this pending review item still outstanding, or was it completed in a later session not reflected here? |
| `Files/Converted/dynamicStrings*.yaml`, `Files/Raw/**/dynamicStrings*`, `dumpedPrefabText*` | Generated data, not documentation | Working-directory artifacts | N/A — not part of the doc taxonomy | Exclude from refresh entirely | High | — |

## Estimated token reduction

- Largest lever: trimming the embedded historical "Update (date) — ..." narrative blocks out of
  `dragonheirplugin.instructions.md`'s DynamicStringPatches section — that section alone is
  roughly 900–1000 words of auto-loaded, per-edit context that largely restates content already
  living in the four linked `docs/*.md` files. Reducing to pointers could cut this file's
  DynamicString/PrefabText portion by ~60–70%.
- Second lever: deleting/pointer-reducing the two superseded repo memories
  (`dynamicstring-cjk-placeholder-template-fallback-plan.md`,
  `dynamicstring-format-native-hook-investigation-plan.md`) — together ~260 lines of memory that
  duplicate `dynamicstringpatches-cjk-placeholder-fallback.md`. Since repo memory isn't
  auto-loaded in full, this is a lower context-cost win but a real duplication/staleness-risk win.
- Net: no line count changes were made in this batch (inventory only); the above are the two
  highest-confidence candidates for the next batch's actual edits.

## Conflicting or stale claims found

1. **Stale, contradicts working code**: `tests-translation-workflow.instructions.md` and
   `Tests/docs/prefabtext-pipeline-architecture.md` both still say the PrefabText runtime lookup
   is "not yet implemented in `DragonHeirPlugin/`." `PrefabTextPatches.cs` and its own
   agent-reference doc show it is fully implemented (`ResourcesLoad_Postfix`,
   `AssetBundleLoadAssetPatch`, `SceneLoaded_Postfix`, exact-match dictionary, priority-first
   setter patches).
2. **Stale/un-migrated**: `Tests/docs/dynamicstrings-pipeline-architecture.md` and the
   instructions pointer to it describe a single bundled `"1c. ExportDynamicStringsIntoTranslated"`
   fact, but repo memory (`dynamicstrings-poetry-extraction-and-dedup-plan.md`) records this was
   restructured 2026-09-01 into Facts `1c`–`1j` with a new `PoetryDataWorkflow` source and a
   dedicated dedup pass. This needs verifying against current `Tests/FileInputWorkflowTests.cs`
   before either doc is trusted or rewritten.
3. **Minor internal inconsistency**: `dynamicstringpatches-cjk-placeholder-fallback.md` states
   Plan A's native-hook conclusion is "not 100% proven," which is consistent with the memory's own
   wording — not a conflict, just worth keeping the hedge when merging.

## Unresolved questions (carried forward from classification)

- Do the "Update (date) — CONFIRMED BUG #N" blocks in `dragonheirplugin.instructions.md`
  duplicate their linked `docs/*.md` files paragraph-for-paragraph, or do they contain details not
  yet captured there? Needs a diff pass before trimming.
- Is the deeper investigation methodology from the native-hook Plan A (decompiled-call-shape
  diffing to distinguish AOT-inlined calls from interop vtable dispatches) worth preserving as a
  reusable technique doc, or just the conclusion?
- Does the live code in `Tests/FileInputWorkflowTests.cs`/`GameFileHandling.cs` actually match the
  Fact `1c`–`1j` restructuring described in `dynamicstrings-poetry-extraction-and-dedup-plan.md`,
  or did it drift further since 2026-09-01?
- Is `prefabtext-generic-field-walk-plan.md`'s deferred alternative design still wanted, or has
  the existing "quick fix" (`DynamicStringOtherTextFields`) become the permanent approach?
- Is the Converter-side "3680 new dynamic-string candidates need review" item
  (`stringmapextractor-metadata-v27-shift-bug.md`) still outstanding?

## Recommended next batch

Do not start until this classification has been reviewed/approved. Suggested order for the next
Sonnet batch (small, verifiable, documentation-only):

1. Correct the two stale "not yet implemented" claims (`tests-translation-workflow.instructions.md`
   and `Tests/docs/prefabtext-pipeline-architecture.md`) against the verified current behavior of
   `PrefabTextPatches.cs` — highest confidence, no open questions blocking it.
2. Verify current Fact numbering/content in `Tests/FileInputWorkflowTests.cs` and
   `Tests/GameFileHandling.cs` against `dynamicstrings-poetry-extraction-and-dedup-plan.md`, then
   rewrite `Tests/docs/dynamicstrings-pipeline-architecture.md` (and the short instructions
   pointer) to match reality.
3. Diff `dragonheirplugin.instructions.md`'s embedded bug-chronology blocks against their linked
   `docs/*.md` files; trim any fully-duplicated narrative down to a one-line pointer.
4. Reduce `/memories/repo/dynamicstring-cjk-placeholder-template-fallback-plan.md` and
   `/memories/repo/dynamicstring-format-native-hook-investigation-plan.md` to short pointers (or
   delete), after confirming no unique detail is lost per the unresolved question above.
5. Move `/memories/repo/prefabtext-generic-field-walk-plan.md`'s durable decision record into a
   proper doc location once its "still wanted?" question is answered by the user.

Batches 1 and 2 are safe for a Luna mechanical handoff once approved (correcting a known-false
claim, and a content sync against already-verified live code). Batch 3 requires Sonnet-level
judgment (duplicate-detection across narrative prose). Batches 4–5 require a user decision before
any edit.
