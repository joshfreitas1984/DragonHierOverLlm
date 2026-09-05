# Documentation Refresh Plan

## Purpose

Make the repository understandable to both humans and coding agents without relying on Copilot-specific memories. The repository documentation becomes the canonical knowledge store; model memories are short-lived indexes and preferences.

## Working Rules

- Preserve existing user changes. Do not reset or discard unrelated worktree changes.
- Do not change runtime behavior during this refresh unless explicitly requested.
- Keep auto-loaded instruction files short and operational.
- Keep source comments only when they explain a current invariant, external contract, safety rule, or non-obvious algorithm.
- Move historical investigations and detailed rationale into `docs/`.
- Treat `KNOWN_ISSUES.md` files as indexes, not essays.
- Mark each document as `Current`, `Historical`, `Open`, `Mitigated`, `Fixed`, or `Superseded` where useful.
- Work in small batches. After each batch, validate links, compile affected projects if source comments changed, and review the diff.

## Target Information Architecture

```text
docs/
  README.md
  documentation-refresh-plan.md
  architecture/
  references/
  operations/
  investigations/
  decisions/
```

The initial migration may leave existing project `docs/` folders in place. Move or consolidate files only when the destination and links are clear.

## Model Roles

One model can complete the whole plan. Sonnet is preferred for technical judgment and restructuring. Luna can optionally perform mechanical follow-up work after Sonnet has approved the target structure, such as formatting, index generation, duplicate detection, and link checks.

Never ask Luna to decide whether a technical behavior is current without giving it an approved source of truth.

## Phases

### Phase 1: Inventory and taxonomy

Create an inventory of:

- `.github/copilot-instructions.md`
- `.github/instructions/*.instructions.md`
- project `README.md` files
- `KNOWN_ISSUES.md` indexes
- project `docs/*.md`
- repository-scoped Copilot memories
- large source comment blocks outside generated output

Classify every item as one of:

- Current rule
- Current reference
- Operational procedure
- Historical investigation
- Decision record
- Duplicate
- Obsolete or superseded

Do not rewrite content during this phase.

### Phase 2: Establish navigation

Create `docs/README.md` with:

- project overview
- links to Converter, DragonHeirPlugin, Tests, Verify, and Files
- documentation taxonomy
- source-of-truth rules
- links to each project's instruction file and issue index
- a short "where should I look?" table for common tasks

Optionally add a root `AGENTS.md` and a thin `CLAUDE.md` later. They should point to the same canonical docs and avoid duplicating technical knowledge.

### Phase 3: Slim agent context

Reduce auto-loaded instruction files to rules needed on every edit:

- repository boundaries
- build/test restrictions
- interop safety invariants
- workflow hazards
- links to detailed references

Move long examples, case studies, and debugging narratives to reference or investigation docs. Keep the current-state rule in the instruction file and add one direct link to the detailed source.

Suggested target: each scoped instruction file should be short enough to read comfortably during every code edit.

### Phase 4: Refactor source comments

Start with these files:

1. `Tests/GameFileHandling.cs`
2. `DragonHeirPlugin/DynamicStringPatches.cs`
3. `Converter/Services/SummaryWriter.cs`
4. `Converter/Services/StringMapExtractor.cs`
5. `Tests/AssetDumperWorkflowTests.cs`

For each file:

1. Identify comments that describe current behavior or invariants.
2. Keep a concise comment beside the code when it prevents an unsafe change.
3. Move long rationale, failed approaches, and debugging chronology into a linked document.
4. Replace the original comment with a short pointer where needed.
5. Do not alter executable code.
6. Run the narrowest available build or test.

### Phase 5: Consolidate references and investigations

Use the existing agent-reference documents as the pattern for current behavior. Separate them from forensic narratives.

For each topic:

- One concise current-state reference
- Zero or more historical investigations
- One index entry from `KNOWN_ISSUES.md` when the topic is a known issue
- Explicit status and affected code paths
- Links to focused verification projects/tests

Prioritize DynamicString, PrefabText, GameFileHandling, ResourceIo, and Converter post-processing because they currently have the most cross-file knowledge.

### Phase 6: Move portable knowledge out of memories

For each repository memory:

- Copy durable technical facts into the appropriate repository document.
- Reduce the memory to a short pointer, status, and next action.
- Keep user preferences in global memory only.
- Do not copy transient conversation history into repository docs.

The result should allow a fresh Claude Code or Copilot session to work effectively with only the repository and its documented instructions.

### Phase 7: Add handoff adapters

After the canonical docs are stable:

- Keep `.github/copilot-instructions.md` as the Copilot-specific entry point.
- Add `AGENTS.md` only for universal repository rules shared by agents.
- Add `CLAUDE.md` only as a short pointer to `AGENTS.md` and `docs/README.md`.
- Ensure no technical rule exists in only one vendor-specific file.

### Phase 8: Final quality pass

Check:

- no broken relative links
- no duplicate source-of-truth statements
- no large historical narrative in auto-loaded files
- every issue index entry points to a real document
- current references identify owning code and verification paths
- build/test instructions match the repository's actual behavior
- generated output is not accidentally promoted into canonical documentation

## First Sonnet Batch

Do only this batch first:

1. Read this plan and the current repository instructions.
2. Inventory the DynamicString and PrefabText documentation, memories, and source comments.
3. Propose a classification table showing what stays, moves, merges, or becomes obsolete.
4. Do not edit executable code.
5. Do not edit instruction files or docs until the classification is reviewed.
6. Report estimated token reduction and any conflicting or stale claims.

## Reusable Sonnet Prompt

```text
You are maintaining the documentation refresh described in
`docs/documentation-refresh-plan.md`.

Work only on the requested batch. Preserve existing user changes and do not modify
runtime behavior. Before editing, inspect the owning code, nearby tests or verification
harnesses, current instruction files, relevant docs, and repository memories.

For this batch, first produce a classification table:
- item/path
- knowledge type
- current status
- canonical destination
- keep/move/merge/delete recommendation
- confidence and unresolved questions

Do not rewrite documentation until the classification is internally consistent.
Keep auto-loaded instructions concise. Keep source comments only for current invariants,
external contracts, safety rules, and non-obvious algorithms. Move historical rationale
into linked investigation docs. Treat the repository as the portable source of truth.

After approval or when explicitly asked to implement:
- make the smallest documentation-only changes needed
- preserve existing style and links
- validate all changed links
- run the narrowest relevant executable check when source or configuration files changed
- report changed files, token/line reduction, validation performed, and remaining uncertainty.

Current batch: <replace with one batch from the plan>
```

## Optional Luna Handoff Prompt

```text
Apply only the approved mechanical documentation batch from
`docs/documentation-refresh-plan.md` and the attached classification.

Do not make technical judgments, change runtime code, invent missing facts, or rewrite
current-state behavior. Preserve code identifiers and links. Perform only the specified
moves, heading normalization, index updates, duplicate removal, and link corrections.
Report every changed file and flag any statement that appears technically inconsistent
instead of silently correcting it.
```

## Completion Criteria

The refresh is complete when a new agent can locate the correct guidance without loading a large instruction file or relying on Copilot memory, and when the same repository knowledge can be used from Sonnet, Luna, Claude Code, and Copilot with no vendor-specific facts missing.
