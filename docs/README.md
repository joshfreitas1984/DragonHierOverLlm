# DragonHierOverLlm documentation hub

# Latest release

## Install with the installer (recommended)

1. Download the installer: [Windows](https://github.com/joshfreitas1984/DragonHierOverLlm/releases/download/installer/Installer-win-x64.exe) or [Linux](https://github.com/joshfreitas1984/DragonHierOverLlm/releases/download/installer/Installer-linux-x64). These links always give you the newest installer.
2. Run it. It finds the game through Steam (use **Browse** if it can't), installs BepInEx, and installs the [latest patch release](https://github.com/joshfreitas1984/DragonHierOverLlm/releases/latest). Press **Install / Update**.
3. Start the game once and let it reach the main menu, so BepInEx can generate its files.

Windows may warn "Windows protected your PC" because the installer isn't code-signed. Choose **More info**, then **Run anyway**.

**Linux (Steam/Proton):** the game and BepInEx are the Windows builds. Paste this into the game's Steam **Properties > Launch Options** (the installer shows it with a Copy button):

```
WINEDLLOVERRIDES="winhttp=n,b" %command%
```

To remove the patch, run the installer and press **Uninstall patch**. It removes the patch files and leaves BepInEx in place.

## Updates

When the game starts it checks for a newer patch. If there is one, an **Update available** window appears about 15 seconds later. **Update now** downloads it, closes the game, applies the update and restarts the game through Steam (on Linux you may need to start the game yourself afterwards). **Later** hides it until the next start. If a check or download fails, nothing changes and the reason is written to the BepInEx log.

Your settings files under `BepInEx/config` are never overwritten by an update. To turn the check off, set `Enabled = false` under `[Updates]` in `BepInEx/config/FanslationStudio.Plugins.UIEditor.cfg`. Updates only work for a patch installed with the installer.

## Manual install

Install [BepinEx Bleeding Edge build for IL2CPP 64bit build 785](https://builds.bepinex.dev/projects/bepinex_be), then extract the [latest release zip](https://github.com/joshfreitas1984/DragonHierOverLlm/releases/latest) into your `<Game Folder>` where the game .exe is. A manual install won't get the in-game update prompt.

# Contacting us
You can join us here: [Discord](https://discord.gg/sqXd5ceBWT)

This is the canonical navigation entry point for the repository. DragonHierOverLlm builds an
English fan-translation patch for *Legend of Dragon Heir* and contains the tooling, runtime plugin,
and working data used to produce it.

## Projects

| Project | Purpose |
| --- | --- |
| [`Translate/`](../Translate/) | Reusable game-specific extraction, translation, packaging, and configuration code. |
| [`Tests/`](../Tests/) | xUnit workflow facts and regression tests that execute the pipeline against `Files/`. |
| [`Converter/`](../Converter/) | IL2CPP decompilation and reverse-engineering support. |
| [`DragonHeirPlugin/`](../DragonHeirPlugin/) | BepInEx runtime plugin with Harmony patches and translation injection. |
| [`Verify/`](../Verify/) | Persistent harness for isolated logic reproduction. |
| [`Files/`](../Files/) | Raw, converted, glossary, and packaged translation data. |

The tooling projects reference the sibling `FanslationStudio.LlmKit` repository by project
reference. Its own `docs/` tree is the source of truth for shared-library mechanics such as the
quality-review workflow, packaging behavior, and translation data model.

## Documentation taxonomy

1. **Scoped instructions** in `.github/instructions/` are auto-loaded for matching project paths.
   Keep them short and operational: current-state rules, safety invariants, and commands.
2. **[`KNOWN_ISSUES.md`](KNOWN_ISSUES.md)** is one repository-wide index only. It links to detailed
   investigations and current-state references but does not contain their narratives.
3. **Root `docs/` topics** are organized by purpose:
   - `features/` for current-state feature and project references.
   - `investigations/` for incidents, bug investigations, and postmortems.
   - `plans/` for design and implementation plans.
   - `architecture/` for durable structural references and decisions.

Project-level `README.md` files remain local how-to-run/build documentation. Do not add additional
project-local `docs/` folders or project-local issue indexes.

## Source of truth

- Scoped instruction files define current rules for their matching project paths.
- The root `docs/` topics preserve detailed rationale and investigation history.
- The root [`KNOWN_ISSUES.md`](KNOWN_ISSUES.md) is an index only.
- Shared-library behavior belongs in the sibling `FanslationStudio.LlmKit/docs/` tree; link to it
  rather than duplicating its implementation details here.
- Repository-scoped Copilot memories are working notes, not canonical documentation.

## Where should I look?

| Task | Start here |
| --- | --- |
| Run the IL2CPP decompiler | [Converter instructions](../.github/instructions/converter.instructions.md), [Converter README](../Converter/README.md) |
| Debug decompiler output | [KNOWN_ISSUES.md](KNOWN_ISSUES.md), then the linked Converter investigation |
| Work on runtime Harmony patches | [Plugin instructions](../.github/instructions/dragonheirplugin.instructions.md), then `features/runtime-plugin/` |
| Investigate a plugin crash | [KNOWN_ISSUES.md](KNOWN_ISSUES.md), then the linked runtime-plugin investigation |
| Work on extraction, translation, or packaging | [Translation instructions](../.github/instructions/tests-translation-workflow.instructions.md), then `features/translation-pipeline/` |
| Debug translation-pipeline data loss or crashes | [KNOWN_ISSUES.md](KNOWN_ISSUES.md), then the linked pipeline investigation |
| Understand the `Files/` layout | [GameFileHandling reference](features/translation-pipeline/gamefilehandling-reference.md) |
| Work on the QC pass | [KNOWN_ISSUES.md](KNOWN_ISSUES.md), then the sibling repo's [quality-review-pass.md](../../FanslationStudio.LlmKit/docs/features/translation-pipeline/quality-review-pass.md) |
| Reproduce isolated logic bugs | [`Verify/`](../Verify/) and the repository instructions |
| Install/play the released patch | [Latest release](#latest-release) at the top of this file |
