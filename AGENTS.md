# AGENTS.md

Universal rules for any AI coding agent working in this repository, regardless of vendor. This
file exists so no repository rule lives in only one vendor-specific format
(`.github/copilot-instructions.md`, `CLAUDE.md`, etc.).

## Start here

- [`docs/README.md`](docs/README.md) is the canonical documentation hub — project overview,
  documentation taxonomy, source-of-truth rules, and a "where should I look?" task table.
- Each sub-project's scoped instructions file (`.github/instructions/*.instructions.md`) is the
  current-state source of truth for that project's rules and safety invariants. Read the one that
  matches the files you're editing before making changes.

## Repository-wide rules

- This repository contains independent sub-projects (`Converter/`, `DragonHeirPlugin/`, `Tests/`,
  `Verify/`, `Files/`). Do not assume conventions from one apply to another without checking its
  own instructions/docs.
- Do not update instructions files, `KNOWN_ISSUES.md`, or `docs/` topic files as a side effect of a
  fix or feature. Only write documentation when explicitly asked to.
- Do not create throwaway verification harness projects. Use the persistent `Verify/` project for
  isolating logic bugs outside the running game or main test suite.
- Keep auto-loaded instructions files short and operational. Long rationale, investigation
  narratives, and bug chronologies belong in a linked `docs/*.md` file, not the instructions file
  itself.
- Follow the IL2CPP interop safety rules in
  [`.github/instructions/dragonheirplugin.instructions.md`](.github/instructions/dragonheirplugin.instructions.md)
  when touching `DragonHeirPlugin/` — unsafe interop patterns there can crash the running game.

## Where to look for more detail

See [`docs/README.md`](docs/README.md)'s "Where should I look?" table for task-specific starting
points (decompiler runs, Harmony patch work, translation pipeline work, bug investigation, etc.).
