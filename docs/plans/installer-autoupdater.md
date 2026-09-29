# Installer and auto-updater plan

Status (2026-09-29): steps 1-3 are implemented (release library, `Installer.Core`, `Installer.App` GUI and the `Installer/` host). Step 4 (in-game prompt) and the other two games are not started.

## Goals

- **Install:** a GUI installer sets up BepInEx (Bleeding Edge IL2CPP x64 build 785) and the latest patch release on Windows and Linux (via Wine/Proton).
- **Update:** the game itself detects a newer release, downloads it, closes, applies it, and relaunches.
- **Release:** the existing manual release workflow (renamed "7. Package Release") builds everything locally, including the installer, into a ready-to-upload folder. Publishing to GitHub is a separate manual step. The implementation is reusable by every LlmKit project.

## Constraints and findings

- The game is a Windows IL2CPP build. Linux users run it under Wine/Proton with the **Windows** BepInEx build and the Steam launch option `WINEDLLOVERRIDES="winhttp=n,b" %command%`. There is no native mac build, so macOS is out of scope.
- Steam app ID: `3202030` (`steam://rungameid/3202030`). The Steam install folder is `LongYinLiZhiZhuan`.
- The current `ZipRelease()` (to be renamed `PackageRelease()`) (`Tests/FileOutputWorkflowTests.cs`) copies Resizers, Layouts, Sprites and `Files/Mod` into `<GameFolder>/ReleaseFolder/Files` and zips it as `EnglishPatch-yyyy.MM.dd.HH.mm.zip`. The plugin DLL, FanslationStudio.Plugins DLLs and BepInEx configs are already sitting in that ReleaseFolder (copied by the plugin PostBuild steps).
- The release must be built locally: `GamePlugin.csproj` references the game's copyrighted interop assemblies by absolute `HintPath`, and `Files/Mod` is gitignored and different per project. CI cannot compile the plugin or produce the mod data, so **there is no GitHub Actions build**. `PackageRelease()` is the release pipeline. It produces the release folder from the local, tested files and stops there; it never talks to GitHub, because the machine has two GitHub accounts (personal and work) and any ambient auth (`gh`, git credential helper) could pick the wrong one.
- Packaging differs per project, so the *host* (what goes in the payload) stays in each translation project. The *implementation* is reusable and lives in LlmKit.

## Architecture: implementation in LlmKit, host in each project

### LlmKit libraries (reusable)

| Library | Responsibility |
| --- | --- |
| `FanslationStudio.LlmKit.Release` | Release packager: stages a payload from a project-supplied list of source-to-destination mappings, applies delete globs, generates `release-manifest.json`, zips, and writes a release folder (patch zip, installer binaries, manifest, release notes stub) plus a prefilled "new release" URL. |
| `FanslationStudio.Installer.Core` | Install/update logic with no UI: locate the game (Steam `libraryfolders.vdf`), download and verify BepInEx from pinned URLs, fetch and apply a release zip honouring `seedOnly`, uninstall via manifest, Wine launch-option helper, headless `--apply-update` (wait for PID, apply, relaunch). |
| `FanslationStudio.Installer.App` | Avalonia GUI over `Installer.Core`. Exposes `InstallerHost.Run(config)`. Kept as its own project so the translation library does not pick up UI dependencies. |

### Per-project host (this repo)

- `Installer/`: a thin project (`Program.cs` plus `installer.json`) that references `Installer.App` and runs it. `installer.json` holds the game name, Steam app ID, Steam folder name, exe name, GitHub repo, BepInEx flavour (IL2CPP or Mono), pinned BepInEx URLs and SHA256 per platform, and the Wine launch-option flag.
- The project's `PackageRelease()` test (renamed from `ZipRelease`, display name "7. Package Release"): describes its payload (this repo's mappings and static files) and calls the LlmKit packager. It stays a test workflow because it needs the local game folder and mod data.
- Static payload that should be source-controlled (BepInEx config files with the game's settings, list of `seedOnly` files) goes in a committed folder in the repo: `Files/Packaging/` (not `Release/`, which `.gitignore` ignores). DLLs keep coming from the existing PostBuild copies into the ReleaseFolder.

### Installer config and packaging

- The installer binaries are **outside** the patch zip. They live on one rolling GitHub **pre-release tagged `installer`** (`Installer-win-x64.exe`, `Installer-linux-x64`), so the download URL never changes (`InstallerAssets.DownloadUrl`) and a pre-release never counts as the "latest" patch release. The in-game update downloads the win-x64 build from that URL on demand (Wine users need the Windows build), so patch releases neither rebuild nor re-upload it. Published trimmed and compressed the binaries are about 20 MB (untrimmed they are about 90 MB, which is why they are not bundled in the zip).
- "7b. Package Installer" builds both binaries into `ReleaseFolder` and opens the prefilled new-release page for `installer`; run it only when the installer code or `installer.json` (for example a new BepInEx pin) changes.
- `installer.json` is included in the host project as an `EmbeddedResource`, so each published single-file binary carries its own config and users download one file. The standalone installer and the in-zip updater are two publishes of the same host, so both carry the same config.
- If an `installer.json` sits next to the exe it overrides the embedded one, which allows testing against a different repo or game folder without rebuilding.
- Config is data, not code: changing the pinned BepInEx version or repo means rebuilding the installer, which `PackageRelease()` does on every release anyway.

### In-game update check (FanslationStudio.Plugins)

The update prompt is a shared runtime plugin in the FanslationStudio.Plugins repo, configured through its BepInEx `.cfg` (GitHub repo, updater path, Steam app ID). Both it and `Installer.Core` read the same `release-manifest.json` schema, so keep that schema in a tiny shared contracts project (or duplicate the minimal reader) and version it.

## Other projects using this design

The same LlmKit libraries and installer host pattern apply to the sibling projects. Each keeps its own `installer.json`, `PackageRelease()` payload and `Installer/` host.

| | DragonHierOverLlm | LegendOfMortalOverLlm | WanXiangOverLlm |
| --- | --- | --- | --- |
| Steam app ID | 3202030 | 1859910 | 3039500 |
| Steam folder | `LongYinLiZhiZhuan` | `LegendOfMortal` | `wanxiang` (exe lives in a nested `wanxiang` folder) |
| Runtime | Unity IL2CPP | Unity Mono | Unity Mono |
| BepInEx (installed locally) | Bleeding Edge 6.0.0-be.785 (IL2CPP x64) | 5.4.23.3, win **x86** | 5.4.23.5, win x64 |
| Game exe | 64-bit | `Mortal.exe` (32-bit PE) | `WXQXZ.exe` (64-bit PE) |
| Plugin target | net6.0 | netstandard2.1 | netstandard2.1 |
| GitHub repo | joshfreitas1984/DragonHierOverLlm | joshfreitas1984/LegendOfMortalOverLlm | joshfreitas1984/WanXiangOverLlm |

Pinned BepInEx 5 builds (read from the local game installs on 2026-09-29; hashes for the installer manifest):

| Game | Asset | SHA256 |
| --- | --- | --- |
| LegendOfMortal | `BepInEx_win_x86_5.4.23.3.zip` from `github.com/BepInEx/BepInEx/releases/download/v5.4.23.3/` | `275bc94fa582ba0ddeb5dca1241fd657d5f101563c3a8dd3a4a6c27ca28e2376` (computed locally; GitHub has no digest for this release) |
| WanXiang | `BepInEx_win_x64_5.4.23.5.zip` from `github.com/BepInEx/BepInEx/releases/download/v5.4.23.5/` | `82f9878551030f54657792c0740d9d51a09500eeae1fba21106b0c441e6732c4` (GitHub digest) |

Notes:
- LegendOfMortal is a **32-bit** game, so it needs the x86 BepInEx build (and the x86 `winhttp.dll` it contains); installing x64 would silently fail to load. The installer config must carry the architecture explicitly.
- LegendOfMortal is one patch behind the newest 5.4.23.5 (5.4.23.4 came out 2025-09-25). Decide whether to pin what is tested (5.4.23.3) or upgrade and retest.
- WanXiang's `BepInEx/core` folder still contains stale BepInEx 6 bleeding edge Mono files (`BepInEx.Core.dll` 6.0.0-be.692, `BepInEx.Unity.Mono*.dll`) left over from an earlier install. The running loader is 5.4.23.5 (`LogOutput.log`, `doorstop_config.ini` targets `BepInEx.Preloader.dll`). The installer must install the clean 5.4.23.5 build and must never copy that `core` folder into a release.

Consequences for the generic design:

- `installer.json` must express the BepInEx flavour and version: IL2CPP BE builds from builds.bepinex.dev versus BepInEx 5 zips from the BepInEx GitHub releases, and x64 versus x86 per game. The pinned URL and SHA256 stay per-game data.
- Wine/Proton still needs the Windows BepInEx build and the `WINEDLLOVERRIDES="winhttp=n,b"` launch option for the Mono games, since they are Windows builds too.
- Game folder detection cannot assume the exe sits directly in the Steam folder (WanXiang nests it). Config gives the exe name and the installer searches for it a couple of levels down.
- Payloads differ, which is why the host stays per-project:
  - LegendOfMortal's `ZipRelease()` copies `Mod` into `Mods/English`, plus resizers into `BepInEx/resizers`. The plugin DLL arrives through its PostBuild copy into `ReleaseFolder`.
  - WanXiang's `ZipRelease()` copies `Mod/English` into `BepInEx/english`, resizers, and then the entire local `BepInEx/config` and `BepInEx/plugins` folders. It has no PostBuild copy to `ReleaseFolder`. Copying whole local folders risks shipping stray or dev-only plugins, so explicit mappings are preferable when it moves to `PackageRelease()`.
- The in-game update plugin must build for both runtimes: net6.0 IL2CPP and netstandard2.1 Mono. Old Unity Mono can have TLS or HTTP limitations, so the update check may need `UnityWebRequest` rather than `HttpClient`. This is the main technical risk for the Mono games; check it early.
- Each repo has a `SharedAssembly` project with its own copy of the resizer and dynamic-string code, so the in-game update component should live in FanslationStudio.Plugins (or a shared library), not be copied per repo.
- The exe name is still needed for each of the three games.

## Release flow ("7. Package Release")

1. (Separate, only when the installer changes: "7b. Package Installer" publishes the host for win-x64 and linux-x64 to the rolling `installer` pre-release.)
2. Stage the payload:
   - Resizers, Layouts, Sprites and `Files/Mod` (the mappings `ZipRelease()` uses today).
   - The plugin DLL, FanslationStudio.Plugins DLLs and configs from the ReleaseFolder.
   - The static folder.
3. Remove the auto-added `zzAddedResizers.yaml`, `zzAddedLayouts.yaml` and `zzAddedSprites.yaml`.
4. Generate `release-manifest.json`: version (`yyyy.MM.dd.HH.mm`), per-file hashes and a `seedOnly` list (config files written only if missing, so user tweaks survive updates).
5. Zip as `EnglishPatch-<version>.zip`.
6. Publish a GitHub Release tagged with the version, attaching the patch zip and `release-manifest.json`. New users get the installer from the rolling `installer` pre-release.

Publishing is manual and needs no credentials from the tool. When packaging finishes, `PackageRelease()`:

- writes outputs next to the existing staging folder (see layout below);
- opens that folder and the browser at `https://github.com/<owner>/<repo>/releases/new?tag=<version>&title=<version>`, taking `<owner>/<repo>` from `installer.json`.

You sign in as the correct account in the browser, drag the files in and click Publish. Assets to attach: `EnglishPatch-<version>.zip` and `release-manifest.json`. The release notes start with the game version (`Files/Packaging/GameVersion.txt`) followed by the git commits since the newest tag. Nothing is built in GitHub Actions: the zip is built from the local tested files.

An optional automated publish can be added later using a fine-grained token scoped to this one repo, read from an explicit environment variable, so the account is never guessed.

### ReleaseFolder layout

The staging folder stays `<GameFolder>/ReleaseFolder/Files` (the plugin PostBuild steps already copy DLLs into it). No per-version subfolder; the version is in the filenames as today.

```
ReleaseFolder/
  Files/                        staging payload (includes PostBuild DLLs)
  EnglishPatch-<version>.zip    as today
  release-manifest.json         copy of the manifest (also inside the zip)
  Installer-win-x64.exe
  Installer-linux-x64
```

Before copying, `PackageRelease()` clears only the folders it fully owns (`BepInEx/resizers`, `layouts`, `sprites2`, `plugins/resources/GameData`) so deleted files do not linger in a release. It leaves `plugins/*.dll` and `config` alone since they come from elsewhere.

## Installer behaviour

1. Locate the game via Steam library folders (`steamapps/common/<folder>`), with a Browse fallback. Confirm the game exe exists.
2. Download the pinned Windows BepInEx build, verify SHA256, and extract it. Skip if the installed BepInEx already matches. Artifact filenames carry a commit hash, so pin them rather than scraping builds.bepinex.dev.
3. Fetch `releases/latest` from the configured repo, extract the patch zip, honouring `seedOnly`.
4. On Linux, offer to write the Wine launch option into Steam's launch options, or show it for copying.
5. Tell the user to launch the game once so BepInEx generates the IL2CPP interop assemblies.
6. Uninstall removes the files listed in the installed manifest.

## In-game update behaviour

- On startup the plugin checks the latest release and compares it with the `version` in the installed manifest. The assembly version (1.0.0) is not used.
- If newer, show an in-game prompt. On accept: download the patch zip and `Installer-win-x64.exe` (from the rolling `installer` release) to a folder under the system temp path (not the game folder, so the updater never sits inside the folder it overwrites), launch `Installer-win-x64.exe --apply-update <zip> --pid <gamePid> --game-dir <dir> --steam-app-id <id>` (detached), and quit the game.
- The updater waits for the PID to exit (no locked DLLs), verifies every hash before writing anything, applies the zip with a small progress window, and relaunches via `steam://rungameid/<appId>`. (If run from inside the game folder it first copies itself to temp.)
- The plugin needs no per-game config: `PackageRelease()` stamps `gitHubRepo`, `steamAppId` and `patchZipPrefix` (from `installer.json`) into `release-manifest.json`, and the installer records that manifest at `BepInEx/release-manifest.json`. The plugin reads its repo and app ID from there; `[Updates] Enabled` in the UI Editor `.cfg` only toggles it.
- The plugin runs inside Wine on Linux, so the spawned updater is the win-x64 build. Relaunch from inside the Wine prefix may not work; the fallback there is "Update complete, please start the game."
- If the download or hash check fails, keep the current install and log rather than quitting the game.

## Order of work

1. **Done.** `Release` library in LlmKit and rename `ZipRelease()` to `PackageRelease()` and rewrite it to use it (manifest, release folder, prefilled release URL). Releases work end to end at this point.
2. **Done.** `Installer.Core`, then headless `--apply-update`.
3. **Done.** `Installer.App` GUI and this repo's `Installer/` host (trimmed single-file publish, shared icon).
4. **Done for the BepInEx 6 IL2CPP host (untested in-game).** In-game prompt in FanslationStudio.Plugins (`UpdateHost`/`UpdatePrompt` in UnityShared, `UpdateService` in Shared). Mono hosts still need wiring, and old Unity Mono may need `UnityWebRequest` instead of `HttpClient` (TLS).
5. Update the `new-translation-project` skill to scaffold `installer.json`, the `Installer/` host and the packager call for new games, and update the install steps in `docs/README.md`.

## Open items

- Whether to add optional automated publish later (repo-scoped token in an environment variable). Not needed for the first cut.
- The static config folder in the repo (`Files/Packaging/`) needs a rule for how the FanslationStudio.Plugins build and this repo's plugin build populate the DLLs.
