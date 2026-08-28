# Gotcha: plain `PackageReference` dependencies are never copied to the plugin output — must embed via Costura.Fody, AND override `CopyLocalLockFileAssemblies`

Adding `System.Text.Encoding.CodePages` as a normal `PackageReference` (for the GBK decode fix in
`resetfacesetting-crash-investigation.md`) compiled fine locally, but crashed the game at plugin
load time: `System.IO.FileNotFoundException: Could not load file or assembly
'System.Text.Encoding.CodePages, ...'`. Confirmed via `dotnet build -v:diag` (search for
`CopyLocalLockFileAssemblies`): BepInEx's SDK/props set `CopyLocalLockFileAssemblies = false`
project-wide, so **no** `PackageReference`-resolved DLL is ever copied into `bin/Debug/<tfm>/`,
even locally — this is intentional BepInEx behavior (avoids duplicating/conflicting with
assemblies already present in `BepInEx\core`/`BepInEx\interop`), but it silently breaks any *new*,
non-BepInEx-provided managed dependency you add.

**First fix attempt (incomplete)**: adding Costura.Fody alone was **not** sufficient — Costura
embeds by scanning the build output folder (`bin/`) for reference assemblies, and since
`CopyLocalLockFileAssemblies=false` meant the CodePages DLL was never copied into `bin/` in the
first place, Costura had nothing to find and embed for that specific package (the build "succeeded"
and the DLL size grew, which *looked* like a successful embed but wasn't for the one assembly that
actually mattered). Don't trust an increased output size alone as proof a specific dependency got
embedded — verify the actual embedded resource name.

**Complete fix**: both required.
1. Override `CopyLocalLockFileAssemblies` back to `true` in `GamePlugin.csproj`'s main
   `PropertyGroup` so package-reference DLLs land in `bin/` again, where Costura can see them.
2. Embed the dependency into the plugin DLL at build time via **Costura.Fody**:
   ```xml
   <PackageReference Include="System.Text.Encoding.CodePages" Version="7.0.0" />
   <PackageReference Include="Costura.Fody" Version="6.0.0">
     <PrivateAssets>all</PrivateAssets>
   </PackageReference>
   <PackageReference Include="Fody" Version="6.8.2">
     <PrivateAssets>all</PrivateAssets>
     <IncludeAssets>runtime; build; native; contentfiles; analyzers; buildtransitive</IncludeAssets>
   </PackageReference>
   ```
   Also requires a `FodyWeavers.xml` at the project root containing just
   `<Weavers><Costura /></Weavers>` — without it, the packages restore but the weaver never
   actually runs and nothing gets embedded.

**How to actually verify a specific dependency got embedded**: spawn a short-lived separate
process to load the built DLL and list `GetManifestResourceNames()`, filtering for the dependency
name — via a disposable `.ps1` run through `powershell -NoProfile -File script.ps1` (a *separate*
process, not inline in the same terminal session — `Assembly.LoadFile` locks the DLL for the
lifetime of the loading process, which then blocks the next `dotnet build`'s copy step with
`MSB3027`/file-in-use errors until that process is killed). Look for
`costura.system.text.encoding.codepages.dll.compressed` in the resource list. Confirmed working
end-to-end: full clean rebuild grew `FanslationStudio.EnglishPatch.dll` to ~10.2 MB (up from
~6.8 MB once `CopyLocalLockFileAssemblies` was also fixed), and the resource list included the
CodePages entry. No changes were needed to the existing `PostBuild` `XCOPY` target since Costura
merges everything into that one already-deployed file.

**Rule of thumb going forward**: any time a *new* external (non-interop, non-BepInEx) NuGet
dependency is needed in this plugin, assume by default it will neither be copied to `bin/` nor
embedded by Costura automatically — set `CopyLocalLockFileAssemblies=true` and add the Costura
pattern together from the start, then verify via `GetManifestResourceNames()` in a throwaway
process before assuming it's fixed.
