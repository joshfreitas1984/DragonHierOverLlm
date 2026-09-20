# AGENTS.md

Universal rules for AI coding agents working in this repository. The canonical documentation hub is
[`docs/README.md`](docs/README.md); read the scoped instruction file matching the project being
edited before making changes.

## Repository structure

- `Translate/` contains reusable game-specific extraction, translation, packaging, and configuration code.
- `Tests/` contains numbered workflow facts and regression tests, and references `Translate/`.
- `Converter/` contains optional IL2CPP reverse-engineering tooling.
- `DragonHeirPlugin/` contains the BepInEx runtime plugin.
- `Verify/` is the persistent isolated verification harness.
- `Files/` contains the working translation data.

## Documentation rules

- Keep current rules and safety invariants in the auto-loaded instruction files under `.github/instructions/`.
- Keep one repository-wide issue index at [`docs/KNOWN_ISSUES.md`](docs/KNOWN_ISSUES.md); it must remain an index, not a narrative.
- Put current-state references under `docs/features/`, investigations and postmortems under
  `docs/investigations/`, plans under `docs/plans/`, and architecture references under `docs/architecture/`.
- Do not create project-local `docs/` folders or project-local `KNOWN_ISSUES.md` files.
- Shared-library mechanics belong in the sibling `FanslationStudio.LlmKit/docs/` tree; link to them
  instead of duplicating their implementation details here.
- Do not update documentation as a side effect of a code fix unless the user explicitly asks for it.

## Engineering rules

- Prefer targeted searches (grep/glob) over reading whole files; read only the specific ranges needed.
- Do not create throwaway verification projects; use the persistent `Verify/` project.
- Keep instruction files short and operational. Put detailed rationale in root `docs/` topics.
- Follow the IL2CPP interop safety rules in
  [`.github/instructions/dragonheirplugin.instructions.md`](.github/instructions/dragonheirplugin.instructions.md)
  when editing `DragonHeirPlugin/`.
