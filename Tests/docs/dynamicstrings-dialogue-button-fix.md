# DynamicStringsIL2CPP pipeline — dialogue-option button fix

> Read this when investigating why a dictionary entry exists for a string but the in-game text
> still isn't translated, specifically for short button-label text.

**Bug**: NPC dialogue-option buttons (e.g. `"打扰了;HideInteractUI"`, `"打扰了;GovernPlotStart;1"`)
never got translated even though their dictionary entry existed. These raw cells are a game-data
convention - `Label;ActionName[;Param]` - where the game's own data loader splits on `;` and only
ever passes the bare `Label` substring to the TMP_Text/UI.Text component that renders the button;
the `;ActionName;Param` suffix is action metadata consumed elsewhere and never reaches the UI.
`DynamicStringPatches.ApplyDictionary` only fires when `input.Contains(entry.Raw)`, so a dictionary
entry keyed on the FULL compound literal (`"打扰了;GovernPlotStart;1" -> "Excuse me;GovernPlotStart;1"`)
can never match the shorter on-screen text `"打扰了"` - it's backwards (the dictionary key is
longer than what's actually rendered).

**Fix** (in the sibling `FanslationStudio.LlmKit` repo's `Workflow/DynamicStringWorkflow.cs`):
`ReconstructLine`/`PackageDynamicStringsAsync` now also emit a second, bare `DynamicStringResult`
entry (`Raw`/`Result` = just the single fragment's text/translation, deduped via a
`HashSet<string>`) whenever a line's template has exactly ONE translatable split - covers this
whole class of "Label;metadata" cells generically, not just the two reported examples, without
needing per-file/per-column configuration. Multi-fragment templates (e.g. the DateTime-style
`"{0}年{1}月{2}日"` case) are deliberately left alone - their fragments aren't standalone rendered
labels. No `DragonHeirPlugin` changes were needed since `DynamicStringPatches.LoadDictionary`
already merges every entry from every `dynamicStrings*.txt.yaml` file; re-running "6. Package to
Game Files" alone regenerates the fixed `Files/Mod/*.yaml`.
