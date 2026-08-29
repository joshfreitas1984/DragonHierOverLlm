# DragonHeirPlugin — crash investigation index

> This file is an **index only**. It is not auto-loaded into agent context (unlike
> `.github/instructions/dragonheirplugin.instructions.md`, which has `applyTo:
> DragonHeirPlugin/**`). Detailed investigation narratives live in per-topic files under
> `DragonHeirPlugin/docs/` — read only the specific doc relevant to your current task, not this
> whole index. When a new investigation narrative is written, add it as a NEW file under
> `DragonHeirPlugin/docs/` (or extend the closest-matching existing one) and add a one-line
> pointer here — never grow this file into a monolith again.

- [`docs/resourceio-csv-merge-abandoned.md`](docs/resourceio-csv-merge-abandoned.md) — why
  `ResourceIoPatches` uses the packaged drop-in `Files/Mod/*.csv` wholesale instead of a
  row-level `CsvMerger.MergeByFirstColumn` merge (column-0-as-stable-ID assumption is false for
  `NameData.csv`).
- [`docs/unitylogcapture-no-logmessagereceived.md`](docs/unitylogcapture-no-logmessagereceived.md)
  — why `UnityLogCapture` Harmony-patches `UnityEngine.Debug`'s log methods directly instead of
  subscribing to `Application.logMessageReceived` (doesn't exist in this game's interop build).
- [`docs/resetfacesetting-crash-investigation.md`](docs/resetfacesetting-crash-investigation.md) —
  full case study of the `ResetFaceSetting`/`ResetPlayerTag` crash: an encoding-mismatch red
  herring, diagnostic patches, and the CONFIRMED root cause (`GameDataController.
  StringToSpeAddData` aborting `LoadAllGameData` on a translated effect-string column).
- [`docs/costura-embedded-dependencies.md`](docs/costura-embedded-dependencies.md) — why any new
  external NuGet dependency needs both `CopyLocalLockFileAssemblies=true` AND Costura.Fody to
  actually load at runtime.
- [`docs/dynamicstringpatches-template-regex-bug.md`](docs/dynamicstringpatches-template-regex-bug.md)
  — full multi-misdiagnosis narrative behind the `DynamicStringPatches` composite `String.Format`
  template fix (summarized as current-state in `dragonheirplugin.instructions.md`): the
  `DateTime.ToString()` red herring, a logger re-entrancy crash, the actual `Regex.Escape`
  asymmetry root cause, and two further occurrences of the same `StringToSpeAddData`/
  `StringToAttriRatio` bug class on `KungFuData.csv`/`SummonKungFuData.csv`.
- [`docs/dynamicstrings-column-source-extraction.md`](docs/dynamicstrings-column-source-extraction.md)
  — bare-fragment dictionary corruption of whole-phrase compounds (save-slot force/sect names,
  etc.); the `DynamicStringColumnSources`/`DynamicStringLabelColumnSources` config-driven
  extraction fix and the `dynamicStrings*.txt.yaml` glob-loading change.
- [`docs/prefabtext-multiline-and-token-placeholder-bugs.md`](docs/prefabtext-multiline-and-token-placeholder-bugs.md)
  — `PrefabTextPatches` multi-line newline-escaping mismatch, and
  `DynamicStringWorkflow.IsFormatTemplate` missing the game's `#Token#`/`#$Token#` markers.
- [`docs/forcedata-showforceskill-crash.md`](docs/forcedata-showforceskill-crash.md) —
  `ForceData.csv` columns 9/10/11 causing an `ArgumentOutOfRangeException` in
  `HandBookMenuController.ShowForceSkill`; same `SkipColumns` bug class as `HeroTagData`/
  `KungFuData`/`ResourcePointTypeData`.
- [`docs/prefabtextpatches-full-investigation.md`](docs/prefabtextpatches-full-investigation.md) —
  full narrative behind `PrefabTextPatches`: a wrong-scope correction for `plotText`/`describe`
  fields, why lifecycle-callback patches were rejected, an `is`/`as` interop-safety finding, and
  the scene-embedded-UI coverage gap fix.
- [`docs/resourceio-generic-bytearray-classpointerstore-crash.md`](docs/resourceio-generic-bytearray-classpointerstore-crash.md)
  — `ta.bytes` (`Il2CppStructArray<byte>`, a generic wrapper) started throwing
  `Il2CppClassPointerStore<byte>` cctor `NullReferenceException` for every TextAsset, isolated to
  `ResourceIoPatches` since it was the only patch touching a generic struct-array type; fixed by
  reading bytes via raw native calls instead (`GetTextAssetBytesRaw`), not by regenerating
  interop/cache (which does not fix this).
