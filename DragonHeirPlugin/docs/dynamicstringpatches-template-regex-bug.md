# `DynamicStringPatches` composite `String.Format` templates — full investigation (2026-08-27)

> Summarized as "current state" in `.github/instructions/dragonheirplugin.instructions.md` — read
> this file for the full multi-misdiagnosis narrative behind that summary.

Symptom (reported via a save-slot describe screen screenshot): a date rendered as
`1Nian2Yue5日` — `年`→`Nian` and `月`→`Yue` translated, but `日` left untranslated, producing a
mixed-language mess.

## First (incomplete) diagnosis: assumed `String.Format`, was actually `DateTime.ToString()`

Assumed the game builds this date via `String.Format("{0}年{1}月{2}日", y, m, d)`, and that a
literal pre-substitution match on the Format template argument (`FormatPrefix`) would fix it.
**This was wrong** — after deploying that fix and confirming (via `BepInEx/LogOutput.log`) it
loaded and patched correctly, the date still rendered exactly the same broken way. Tracing
`GetRecentSaveSlotDescribe`/`GameDataController` in the decompiled output
(`Converter/output/_NoNamespace/GameDataController.cs` around `GetSaveInfo`) showed the actual call
is `DateTime.get_Now()` → a **parameterless** `DateTime.ToString()` — .NET's own internal
date-formatting machinery under the game's zh-CN culture, which bakes in `"年"`/`"月"`/`"日"` as
the culture's own date separators. This *never* calls `System.String.Format`/`Concat` with the
`"{0}年{1}月{2}日"` template at all — that dumped `dynamicStrings.txt` entry is dead weight for
this bug (it may still be genuinely used by some other, undiscovered call site, decompiled or not
— the pipeline can't attribute a literal back to its call site, see the `DynamicStringsIL2CPP
pipeline` section in `tests-translation-workflow.instructions.md`). The reason `"年"`/`"月"` were
*ever* partially translated (proving *something* was live) is `DynamicStringPatches`' own
sink-level `TMP_Text`/`UI.Text` `.text`-setter postfix (`ApplyToComponentText`) — a blind
bare-fragment substring scan that runs on **any** text that reaches a UI component regardless of
how it was built. `"年"`/`"月"` happen to have their own standalone single-character dictionary
entries (for unrelated call sites elsewhere); `"日"` correctly has none — a bare single-hanzi entry
for `日` would be far too dangerous to substring-replace globally (`生日`/`节日`/`今日`/... would
all get corrupted), so it was never curated as one.

**General lesson reinforced**: don't assume a dumped `"{0}...{1}...{2}"`-shaped literal is
necessarily consumed via `System.String.Format` just because it looks like a format template —
trace the actual call site in the decompiled output before trusting that assumption, especially
when a fix that should be mechanically correct (confirmed via load-time logging) still produces
identical runtime behavior. Identical output after a supposedly-correct fix is itself strong
evidence the fix targeted the wrong code path, not that the fix "didn't take."

**Actual fix**: since the literal `"{0}"`/`"{1}"`/`"{2}"` text never survives into the rendered
string regardless of which BCL mechanism produced it (`String.Format`, `DateTime.ToString()`, or
anything else), a template can only be recognized *structurally* once its placeholders have
already been substituted with real data. `DynamicStringPatches` now compiles each `isTemplate:
true` dictionary entry (see `FanslationStudio.LlmKit`'s `DynamicStringResult.IsTemplate`, computed
once at packaging time rather than re-derived at runtime) into a `CompiledTemplate`: a regex built
from `Raw` (via `Regex.Escape` + replacing escaped `\{n\}` tokens with named capture groups
`(?<pN>.+?)`) paired with a `.NET` regex replacement string built from `Result` (same `{n}` tokens
rewritten as `${pN}` group references). `ApplyTemplates` runs this regex match+reconstruct pass —
with a cheap `LiteralSegments`-`Contains` pre-filter per template to avoid running ~400 regexes on
every call — in both `GenericPostfix` (Concat/Format's *result*) and the sink-level
`ApplyToComponentText`, **before** the existing bare-fragment `ApplyDictionary` pass, so a matched
composite's own literal separators are fully translated first and never left exposed to
accidental partial collisions from unrelated single-character bare entries. `FormatPrefix` (the
literal pre-substitution match on an actual `String.Format` call's template argument) is kept
alongside this as a second, complementary mechanism for the cases where a genuine `String.Format`
call really is involved — the two do not conflict, since `FormatPrefix` only ever sees literal
`"{n}"` text (before substitution) while `ApplyTemplates` only ever sees already-substituted text.

## Follow-up crash found while diagnosing the above: infinite recursion via `MainPlugin.Logger` itself

Added a `LogInfo` call inside `GenericPostfix`/`FormatPrefix` (guarded on a cheap regex pre-check)
to empirically trace which patch entry point observed the date string — this immediately
stack-overflowed. Root cause: BepInEx's `Logger`/`DiskLogListener.LogEvent` internally calls
`System.String.Format` itself to build the log line — which is one of the exact methods
`DynamicStringPatches` patches — so any `MainPlugin.Logger.LogInfo`/`LogError` call made **from
inside** `GenericPostfix`/`FormatPrefix` (including from a `catch` block's error log — not just
deliberate diagnostic logging) re-enters the same patch and recurses forever (confirmed via the
stack trace: `GenericPostfix` → `DynamicClass.DMD<String::Format>` → `DiskLogListener.LogEvent` →
... → `GenericPostfix` → ...).

**Fix (kept permanently, not just for the diagnostic)**: a `[ThreadStatic] _inFormatConcatPatch`
guard now wraps the entire body of both `GenericPostfix` and `FormatPrefix` (checked at entry,
set/reset around the whole `try`/`catch`/`finally`), so *any* nested `String.Format`/`Concat` call
triggered from inside them — whether from our own logging or anything else — is a cheap, silent
no-op instead of recursing. **General lesson**: never log (or call anything that might internally
call `String.Format`/`Concat`) from inside a Harmony patch on `String.Format`/`Concat` itself
without a re-entrancy guard around the whole patch body first — this applies to error-path
logging in `catch` blocks just as much as deliberate diagnostic logging, since both are equally
capable of triggering the recursion.

## ACTUAL ROOT CAUSE FOUND AND FIXED: `BuildCompiledTemplate`'s placeholder-detection regex never matched anything

`ApplyTemplates`/`_compiledTemplates` never fired at all, for the entire lifetime of this feature.
After fixing the recursion bug above, a second, safe diagnostic (`SafeDebugLog`, writing directly
to a plain file via `File.AppendAllText` — deliberately NOT through `MainPlugin.Logger`, to avoid
any repeat of the recursion bug) was added temporarily to
`GenericPostfix`/`FormatPrefix`/`ApplyToComponentText`, gated on a cheap CJK date-separator regex
pre-check. The resulting trace showed the save-slot date's `"1年2月5日"` converting to
`"1Year2Month5日"` — i.e. the `"年"`/`"月"` separators got translated but the trailing
`"{2}日"` → `"Day"` never did, even though there was no competing shorter template. Root-caused by
reproducing `BuildCompiledTemplate`'s old logic in isolation: it called `Regex.Escape(entry.Raw)`
first and then tried to find/replace the escaped `"{n}"` placeholder tokens back into named capture
groups via `Regex.Replace(escapedRaw, @"\\\{(\d+)\\\}", ...)` — but **`Regex.Escape` only escapes
the opening brace** (`Regex.Escape("{0}")` → `"\{0}"`, not `"\{0\}"` — confirmed via direct testing
in isolation), so that placeholder-finder regex (which required a backslash before the *closing*
brace too) never matched anything. Every compiled template's `Pattern` silently degraded into a
regex requiring the literal, pre-substitution text `"{0}年{1}月{2}日"` (with actual braces) to
still be present in the input — which can never happen once real data has replaced the
placeholders — so `ApplyTemplates` has been a complete no-op since this feature was introduced, and
every "fix" that touched `ApplyTemplates`/`_compiledTemplates` this session (including the earlier
"composite template" diagnosis for this same bug) was chasing a dead consumer while the real,
silently-broken code path went unnoticed.

**Fix**: `BuildCompiledTemplate` was rewritten to build the regex pattern by walking `Raw` directly
— finding each `{n}` placeholder token via `PlaceholderRegex.Matches(raw)`, `Regex.Escape`-ing only
the *literal text segments* in between (never touching the placeholder tokens themselves), and
inserting `(?<pN>.+?)` capture groups at the placeholder positions — instead of round-tripping
through `Regex.Escape` on the whole string and trying to reverse-engineer the escaping afterward.
Verified in isolation (outside the game) that the new approach correctly matches `"1年2月5日"` and
replaces it with `"1Year2Month5Day"` in one pass. **General lesson**: never assume
`Regex.Escape`'s output is symmetric/reversible for a specific character — check its actual
behavior for the specific characters you care about (here: `{` vs `}`) rather than assuming both
sides of a delimiter pair are escaped the same way. This is also a broader lesson about this whole
investigation: repeated "the fix made no difference" reports should have been a strong signal much
earlier to empirically verify each individual mechanism in isolation (e.g. a throwaway console/test
snippet exercising just `BuildCompiledTemplate`+`ApplyTemplates`) rather than only tracing the
in-game call path — the bug was entirely inside this plugin's own regex-building code, not in any
uncertainty about which game method/component was involved.

## Same bug class found in a second call path: `KungFuData.csv`/`SummonKungFuData.csv` column 13 via `GameDataController.LoadSkillData`

Found via a real playtest's `Player.log` after the `PlotData.csv`/`ResourcePointTypeData.csv`/
`HeroTagData.csv`/`SkinDataBase.csv` fixes above were already in place: the game progressed all the
way past `PlotData.csv` loading with no crash, but then hit an **uncaught
`ArgumentException: oldValue is the empty string`** thrown from `System.String.Replace` inside
`GameDataController.StringToSpeAddData`, called from `GameDataController.LoadSkillData`, called
from `LoadAllGameData`.

Decompiling `GameDataController` shows `LoadSkillData` feeds THREE columns into
`StringToSpeAddData` unconditionally: columns 7, 8, and 13 — the exact same
`Label<sign><number>;...` compound-cell/cross-reference pattern as `HeroTagData.csv`'s "效果"
column, just reached via a different loader method. Column headers: 7/8 are `修炼效果`/"Training
effect" and `运功效果`/"Skill effect"; column 13 is `使用特效`/"Use special effects".

**Important correction**: an initial fix only added `SkipColumns = [7, 8]`. This did NOT fix the
crash — columns 7/8 are **always empty** in every row of this game's actual data (`LoadSkillData`
checks for empty before calling `StringToSpeAddData`, so an empty cell never reaches it), meaning
the initial fix was harmless but didn't address the real cause. **Column 13** is populated in
nearly every row and is the column that actually triggers the crash. Lesson: when a decompiled
function feeds multiple columns into the same hazardous call, grep the RAW source CSV/TextAsset to
confirm which of those columns are actually populated in this game's real data before assuming the
"obviously similar-looking" one is the culprit.

Unlike the previously-documented cases (which only hit `Single.Parse` after a *successful* label
match), this crash occurs one step earlier, inside `StringToSpeAddData`'s own regex-based
label-stripping: it does `Regex.Replace(fragment, <trailing-signed-number-pattern>, "")` to
recover just the label text, then `String.Replace(fragment, strippedLabel, "")` to strip the label
back out — if the translated label text has been reduced to nothing at all (an empty string),
`String.Replace` throws `ArgumentException: oldValue is the empty string` rather than merely
logging a mismatch and moving on. Different failure signature, same root cause and fix: never let
translation touch these compound label cells at all.

**Fix applied**: `SkipColumns = [7, 8, 13]` on both `KungFuData.csv` and `SummonKungFuData.csv`'s
`TextFilesToSplit` entries (7/8 kept for completeness/future-proofing even though currently
always-empty; 13 is the column that actually mattered).

## Third occurrence: `StringToAttriRatio` (fatal, no try/catch) on the same two files' columns 9/10

See `Tests/docs/kungfudata-stringtoattriratio-fatal.md` for the full writeup — same file/row, but a
*different* decompiled method (`StringToAttriRatio`, not `StringToSpeAddData`) with no try/catch at
all around `Single.Parse`, making it immediately fatal rather than merely logged. Fixed by adding
columns `9, 10` to the same `SkipColumns` lists.
