using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.RegularExpressions;
using HarmonyLib;
using TMPro;
using UnityEngine.UI;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace EnglishPatch;

/// <summary>
/// Case 4 (see the "dynamic/hardcoded in-code string translation plan" repo memory - hard case) -
/// runtime translation of hardcoded string literals compiled directly into IL2CPP game code that
/// the CSV-driven translation pipeline (Tests/GameFileHandling.cs) and PrefabTextPatches.cs cannot
/// reach because they aren't stored in a TextAsset or baked into a prefab field. Two distinct
/// sub-cases, both handled by the same flat translated dictionary:
///  - Runtime-assembled/concatenated strings, e.g.
///    SaveLoadMenuController.GetRecentSaveSlotDescribe's `lVar2.Tasks + "\n\n架势\n" +
///    lVar2.saveDataPath` (compiles to a String.Concat call).
///  - Plain literal assignment with no concatenation at all, e.g. `field = "架势";` later read and
///    displayed - never calls String.Concat/Format, so a source-level patch on those methods alone
///    would miss it entirely.
///
/// **Two-layer patch strategy, both global/reflection-driven (no per-method YAML configuration,
/// no need to ever launch the game just to discover which method/field to target)**:
///  1. **Source-level**: every public static, non-generic, string-returning overload of
///     `System.String.Concat`/`System.String.Format` is Harmony-postfixed (found via reflection,
///     not one bespoke postfix per overload) and has the flat dictionary applied as an exact
///     substring replace on the call's result. Catches concatenation-built strings as early as
///     possible, including ones that end up somewhere other than on-screen UI (logs, tooltips
///     rendered through a non-TMP_Text/Text component, etc).
///  2. **Sink-level**: `TMP_Text.text`'s and `UnityEngine.UI.Text.text`'s setters are also
///     Harmony-postfixed, re-reading the component's own `.text` after the original setter ran and
///     re-applying it (via the same setter) with the dictionary substring-replaced. This is what
///     catches case (b) above - a field holding nothing but a raw literal, assigned straight to a
///     UI component's text with no concatenation call in between - and is also a safety net that
///     independently catches case (a) too (defense in depth) for any text that does end up
///     displayed. A `[ThreadStatic]` re-entrancy guard prevents the setter-patches-calling-the-
///     setter-again pattern from looping (the second, inner call sees already-translated text with
///     no further dictionary matches and is a no-op, but the guard makes that termination
///     unconditional rather than relying on dictionary data never re-introducing raw text).
///
/// Neither layer needs to know in advance which fragments belong to which method/field/component -
/// entries that don't appear in a given string are harmless no-ops, so the same global dictionary
/// is reused everywhere.
///
/// Pipeline (mirrors CSV/PrefabText - see FanslationStudio.LlmKit.Workflow.DynamicStringWorkflow
/// and Tests/GameFileHandling.cs):
///   Converter --dynamic-string-candidates → auto-appended (no manual review step) into
///   Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt (by
///   GameFileHandling.ExtractDynamicStringCandidatesFromIl2CppStringMap) → "1c.
///   ExportDynamicStringsIntoTranslated" → "2. MergeFilesIntoTranslated" → translate → "6.
///   Package to Game Files" produces Files/Mod/dynamicStrings.txt.yaml (flat `raw`/`result`
///   list), deployed to BepInEx\plugins\resources\ alongside the CSV overrides.
///
/// **Why substring replacement instead of `string.Format`-ing the call's arguments**: confirmed via
/// earlier discovery-log testing that these concatenation call sites are frequently built from
/// fields/locals rather than passed-in parameters (e.g. `GetRecentSaveSlotDescribe()` takes no
/// parameters at all), so there is nothing reliable to substitute into a template's `{0}`/`{1}`
/// placeholders. Only the hardcoded literal fragments (e.g. `"架势"`) need translating; everything
/// else concatenated alongside them is either already-translated data from elsewhere (CSV
/// pipeline) or non-text data (e.g. a date) and is left untouched by a plain substring replace.
///
/// IL2CPP interop safety: `System.String` is an ordinary BCL type (no interop concerns at all).
/// `TMP_Text`/`UnityEngine.UI.Text` ARE IL2CPP-wrapped game types, but ordinary Harmony
/// prefix/postfix patching of their methods (including property setters) is a confirmed-safe
/// pattern (see dragonheirplugin.instructions.md's "Confirmed-safe patterns" and
/// PrefabTextPatches.cs, which already patches these same two types' properties directly via
/// `tmpText.text = replacement;`/`uiText.text = replacement;`). No generic
/// Cast&lt;T&gt;/TryCast&lt;T&gt; calls anywhere.
/// </summary>
internal static class DynamicStringPatches
{
    private static readonly string PluginDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) ?? ".";
    private static readonly string ResourcesDir = Path.Combine(PluginDir, "resources");
    // Glob rather than a single exact filename: DynamicStringWorkflow-packaged dictionary files
    // all share the "...txt.yaml" shape (raw/result/isTemplate flat list) regardless of which
    // TextFileToSplit produced them, e.g. "dynamicStrings.txt.yaml" (literal
    // fragments) and "dynamicStringsFromColumns.txt.yaml" (auto-extracted CSV column values -
    // see Tests/GameFileHandling.cs's DynamicStringColumnSources/ExtractDynamicStringCandidatesFromColumns).
    // Every matching file is loaded and merged into the same in-memory dictionary (see
    // LoadDictionary) so adding a new source file never requires a plugin-side path change.
    private const string DictionaryFilePattern = "dynamicStrings*.txt.yaml";

    // PrefabTextPatches.cs's own dictionary files (same "raw"/"result" flat-list shape, no
    // "isTemplate" key). Merged in at startup (see LoadDictionary) so quest-name/place-name-style
    // whole-phrase strings that PrefabTextPatches only exact-matches (e.g. "初出茅庐") are ALSO
    // available as a substring fragment - or, for entries containing the game's own "#Token#"
    // placeholders (e.g. quest-task descriptions like "前往#TargetPlace#与顾师兄汇合。"), as a
    // compiled template - for ApplyDictionary/ApplyTemplates to catch when the same text is
    // concatenated/substituted with other runtime data at a call site PrefabTextPatches' exact
    // whole-string match can never see (e.g. the quest tracker's "questName(placeName)", or a
    // quest task description with its "#TargetPlace#" token already substituted with real place
    // text - confirmed 2026-08-30 for both cases). Doing this merge here (rather than manually
    // duplicating quest-name-style entries into the dynamicStrings source data) makes it
    // repeatable: PrefabTextWorkflow's dumped/translated entries are already the single source of
    // truth for these phrases, so any future addition/edit there is picked up automatically on
    // next plugin load with no separate copy step.
    private const string PrefabTextFilePattern = "dumpedPrefabText*.txt.yaml";

    private static List<DictionaryEntry> _dictionary = new();

    // Reverse lookup (translated Result -> original raw Chinese), built once in PatchAll. Needed
    // for the rare case where a data field is used as an internal lookup/asset key (not just
    // displayed) AFTER already being run through this dictionary's substring replace somewhere
    // upstream (e.g. via a String.Concat/Format call in the game's own CSV-row-loading code) - see
    // ItemIconPatches.cs's GetItemIconName_Postfix for the confirmed motivating case (Food/Med/
    // Horse item icon names). First-wins on duplicate Result values (exact full-string matches
    // are expected here, not the partial/substring matches ApplyDictionary handles elsewhere).
    private static readonly Dictionary<string, string> _reverseDictionary = new();

    // Entries flagged isTemplate: true in the packaged YAML (FanslationStudio.LlmKit's
    // DynamicStringResult.IsTemplate - set at packaging time, not re-derived here) contain a
    // literal String.Format placeholder in Raw (e.g. "{0}年{1}月{2}日"). Two independent
    // consumers apply these, at two different points:
    //  1. FormatPrefix (literal match) - translates the *template argument itself* before an
    //     actual `System.String.Format` call runs, while it still contains literal
    //     "{0}"/"{1}"/"{2}".
    //  2. _compiledTemplates (structural/regex match, see below) - for cases where the raw
    //     template's placeholders were substituted by something OTHER than a patchable
    //     `System.String.Format` call (confirmed case: `GameDataController.GetSaveInfo`'s
    //     SaveTime field is built via a plain parameterless `DateTime.ToString()`, which bakes
    //     zh-CN's own culture-specific "年"/"月"/"日" date separators directly via .NET's
    //     internal date-formatting machinery - never touching any String.Format/Concat overload
    //     this plugin can patch). By the time such a string reaches a Concat postfix or a
    //     TMP_Text/UI.Text .text setter, the literal "{0}"/"{1}"/"{2}" text is long gone (already
    //     substituted with real data, e.g. "1年2月5日"), so a literal substring match against
    //     Raw can never fire here - only a regex built from the template's shape can recognize
    //     and reconstruct it.
    private static List<DictionaryEntry> _templateDictionary = new();

    // Compiled once per loaded _templateDictionary entry - see CompiledTemplate for what each
    // field means. Applied by ApplyTemplates against Concat/Format results and sink-level
    // component text, in addition to (not instead of) FormatPrefix's literal pre-substitution
    // match, since either mechanism alone misses cases the other catches.
    private static List<CompiledTemplate> _compiledTemplates = new();

    // A game placeholder marker, e.g. "#PlayerName#", "#$PlayerName#", "#PlayerForceDescribe#".
    // These are NOT String.Format-style "{n}" placeholders - they're the game's own localization
    // tokens, substituted with real (already independently-translated, e.g. via PlotData.csv/
    // NameData.csv) text by the game's own systems well before the composite string ever reaches
    // a Concat/Format call or a TMP_Text/UI.Text setter. Combined into PlaceholderOrTokenRegex
    // below so BuildCompiledTemplate can treat both kinds of marker the same way: as wildcard
    // captures, never as literal text to match against (see CONFIRMED BUG #2 below).
    private static readonly Regex PlaceholderOrTokenRegex = new(@"\{(\d+)\}|#\$?[A-Za-z0-9_]+#", RegexOptions.Compiled);

    // CONFIRMED BUG #3 (2026-08-28, "Experience倍率＋0%" screenshot case): a placeholder capture
    // group built as plain ".+?" has no boundary other than "whatever satisfies the next literal
    // segment", so it can lazily span across a COMPLETELY UNRELATED, still-untranslated CJK run
    // that happens to sit between this template's literal text and its next literal/terminator.
    // Confirmed case: template raw "经验{0}%" (meant for e.g. "经验100%") compiles to literal
    // "经验" + capture + literal "%"; against the real runtime string "经验倍率＋0%" (a static
    // "经验倍率" label immediately followed by an unrelated dynamically-computed "＋0%" slider
    // value - two different concerns that happen to land in the same string), the lazy capture
    // matched "倍率＋0" as the "placeholder" (there is no other "%" to stop at sooner), producing
    // "Experience倍率＋0%" - and because ApplyTemplates runs BEFORE the bare-fragment dictionary
    // pass, this consumed "经验" before the correct, more specific whole-phrase entry
    // ("经验倍率" -> "Experience multiplier") ever got a chance to match. Fix: constrain every
    // placeholder capture (both "{n}" and "#Token#" kinds) to exclude CJK ideographs/punctuation,
    // since a "{n}"-placeholder's real runtime value is always a plain number/date component in
    // every confirmed case, and a "#Token#" marker is always substituted with already-translated
    // (English) text by the game's own localization before this postfix ever runs - neither should
    // ever legitimately need to span across untranslated Chinese text. This makes the whole
    // template fail to match (falls through to the bare dictionary pass, which is exactly what we
    // want) instead of over-matching into someone else's text.
    private const string PlaceholderCaptureClass = @"[^\p{IsCJKUnifiedIdeographs}\p{IsCJKSymbolsandPunctuation}\p{IsCJKCompatibilityIdeographs}]";

    // PLAN B (2026-08-29, "{0}向来秉持{1}之道..." template not translating - see repo memory
    // dynamicstring-cjk-placeholder-template-fallback-plan.md): bug #3's CJK-exclusion fix above
    // is correct for placeholders whose real runtime value is always plain numeric/date/ASCII
    // data, but some templates' "{n}" placeholders are legitimately substituted with CJK text
    // (e.g. a sect name or title from HeroData). For those, the strict PlaceholderCaptureClass can
    // never match, so the WHOLE template - including its own translated literal connector text -
    // is skipped, even though the connectors don't depend on the placeholder values at all. This
    // permissive, CJK-inclusive capture class is tried only as a FALLBACK, after the strict
    // pattern has already failed to match (see ApplyTemplates) - so a template whose strict pattern
    // already matches successfully never reaches the fallback.
    // RESIDUAL RISK (confirmed via throwaway harness, not just theoretical): a template whose
    // strict pattern currently fails to match a bug-#3-shaped input (e.g. "经验{0}%" against
    // "经验倍率＋0%") WILL reach this permissive fallback and CAN reproduce the original bug #3
    // over-match, UNLESS CompiledTemplate.BlockingRawEntries already protects that literal segment
    // (i.e. a longer bare dictionary entry like "经验倍率" exists and is auto-populated as a
    // blocking entry - see BlockingRawEntries' own comment). This holds for every bug #3/#4 case
    // confirmed so far, because those over-matches were always into text that also forms a real,
    // curated whole-phrase dictionary entry - but if a NEW bug-#3-shaped over-match is ever
    // reported against a template that also has a legitimately-CJK placeholder (so it can't just
    // rely on the strict pattern), check BlockingRawEntries coverage FIRST before assuming this is
    // a novel failure mode.
    private const string PermissivePlaceholderCaptureClass = @".";

    // A single dictionary template entry, precompiled into a structural matcher: Pattern captures
    // each "{n}" placeholder as a named group ("p0", "p1", ...) around the template's literal
    // (translated) separator text, so it matches the template's *shape* regardless of how the
    // placeholders were actually substituted (String.Format, String.Concat, or - the confirmed
    // motivating case - .NET's own internal DateTime.ToString() culture formatting). Literal
    // Chinese segments in Raw are cheap-pre-filtered via LiteralSegments (plain Contains checks)
    // before running the full regex, since running ~400 template regexes against every
    // Concat/Format result and every UI text assignment in a running Unity game would otherwise be
    // wasteful.
    private sealed class CompiledTemplate
    {
        public Regex Pattern;

        // PLAN B fallback pattern - identical shape/literal segments as Pattern, but placeholder
        // captures use PermissivePlaceholderCaptureClass (CJK-inclusive) instead of the strict
        // non-CJK PlaceholderCaptureClass. Only ever consulted by ApplyTemplates when Pattern
        // fails to match - see PermissivePlaceholderCaptureClass's comment for why this can't
        // regress bug #3/#4.
        public Regex PermissivePattern;
        public string ReplacementPattern;
        public List<string> LiteralSegments;

        // CONFIRMED BUG #4 (2026-08-28, "非This DoorDiscipleExperience+0%" screenshot case,
        // found AFTER bug #3 above): constraining the placeholder capture to non-CJK (bug #3's
        // fix) stopped a template from over-matching into unrelated CJK text, but did nothing
        // to stop it from UNDER-matching - i.e. still successfully matching a SHORT literal
        // fragment that is itself only part of a longer, more specific whole-phrase dictionary
        // entry. Confirmed case: template raw "经验{0}%" (literal "经验" + non-CJK capture +
        // literal "%") legitimately matches the tail of the real runtime string
        // "非本门弟子经验+0%" (literal "经验" at index 5, capture "+0" is plain ASCII/digits so
        // bug #3's CJK exclusion does not block it, literal "%" follows) - producing
        // "非本门弟子Experience+0%". But "非本门弟子经验" (7 chars) is ALSO a complete, more
        // specific whole-phrase entry in the bare dictionary ("Non-disciple experience points") -
        // and because ApplyTemplates runs BEFORE ApplyDictionary (required for the ORIGINAL date-
        // separator bug - see BuildCompiledTemplate's comments - so this order can't just be
        // reversed globally), the template's partial match consumed "经验" first, permanently
        // destroying the substring "非本门弟子经验" that the longer dictionary entry needed to
        // match. ApplyDictionary then fell back to shorter bare fragments ("本门"->"This Sect",
        // "弟子"->"Disciple"), producing the garbled "非This DoorDiscipleExperience+0%".
        // Fix: BlockingRawEntries (populated once in PatchAll, not per-call) lists every bare
        // _dictionary entry that (a) contains one of this template's own LiteralSegments as a
        // substring and (b) is strictly LONGER than that literal segment - i.e. a dictionary
        // entry that is a more specific superstring of what this template's literal alone would
        // match. ApplyTemplates checks, for each individual regex match, whether any
        // BlockingRawEntries occurrence in the input overlaps that match's span; if so, the
        // template leaves that occurrence untouched entirely and lets ApplyDictionary's own
        // longest-first pass translate the whole, more specific phrase instead (the small cost:
        // the numeric suffix that the template would have translated alongside it, e.g. "+0%",
        // stays untranslated in that occurrence - acceptable, since avoiding corruption matters
        // far more than translating every last fragment of a compound label).
        public List<string> BlockingRawEntries = new();
    }

    // Builds a CompiledTemplate from a raw/result pair, e.g. raw "{0}年{1}月{2}日", result
    // "{0}Year{1}Month{2}Day" -> Pattern matches "(?<p0>.+?)年(?<p1>.+?)月(?<p2>.+?)日" anywhere
    // in a larger string (not anchored - the composite date is typically embedded inside a bigger
    // block of concatenated text), and ReplacementPattern is "${p0}Year${p1}Month${p2}Day" - a
    // .NET regex replacement string referencing the same named groups, so translated literal text
    // from Result surrounds the untouched (non-translatable, e.g. numeric) captured fragments.
    //
    // CONFIRMED BUG (2026-08-27, found via the SafeDebugLog trace below): the previous
    // implementation built the pattern by running `Regex.Escape(entry.Raw)` first and then trying
    // to find/replace the now-escaped "{n}" placeholder tokens back into capture groups. This is
    // broken because .NET's `Regex.Escape` only escapes the OPENING brace ("{" -> "\{") and
    // deliberately leaves the closing "}" alone (confirmed empirically: `Regex.Escape("{0}")` ==
    // "\{0}", not "\{0\}"). The old code's placeholder-finder regex `\\\{(\d+)\\\}` required a
    // backslash before the closing brace too, so it never matched anything - every compiled
    // template's Pattern silently degraded into a literal match for the RAW placeholder text
    // itself (e.g. requiring the literal substring "{0}年{1}月{2}日" to still be present,
    // post-substitution), which can never happen once real data has replaced the placeholders. As
    // a result `ApplyTemplates` has never matched a single template since it was introduced -
    // confirmed by reproducing the exact old logic in isolation (IsMatch always false) and by the
    // live SafeDebugLog trace showing the compiled template never converting the "{2}日" -> "Day"
    // tail of the save-slot date. The fresh fix below builds the pattern by walking Raw directly
    // (splitting on placeholder tokens found via PlaceholderOrTokenRegex and Regex.Escape-ing only the
    // literal text segments between them), so it never depends on being able to find escaped
    // brace tokens after the fact.
    //
    // CONFIRMED BUG #2 (2026-08-27, found via the "是{PlayerForceDescribe}{PlayerName}啊，\n此次
    // {0}前来拜访我{1}，不知{3}？" screenshot case): fix #1 above only ever treated the
    // "{n}"-numbered String.Format placeholders as wildcards; every OTHER marker in Raw - in
    // particular the game's own "#Token#"/"#$Token#" localization placeholders (e.g.
    // "#PlayerForceDescribe#", "#$PlayerName#") - was still escaped and baked into the pattern as
    // REQUIRED LITERAL TEXT. But those tokens are always substituted with real,
    // already-independently-translated text (via the normal CSV pipeline) long before the
    // composite string ever reaches a patched Concat/Format call or TMP_Text/UI.Text setter, so
    // the literal "#PlayerForceDescribe##$PlayerName#" text this pattern demanded could never
    // actually appear at runtime - the whole template silently failed IsMatch forever, which
    // meant none of its translated literal segments ("此次" -> "This time", "前来拜访我" -> "Come
    // to visit me", "，不知" -> ",Unknown") were ever applied, even though the slot values
    // themselves (already translated elsewhere) rendered fine. Fix: walk Raw with
    // PlaceholderOrTokenRegex instead of a "{n}"-only regex, so "#Token#" markers become wildcard
    // capture groups too, exactly like "{n}". Numbered "{n}" placeholders keep being named by
    // their own number ("p0", "p1", ...) so they still match Result's own "{n}" occurrences
    // order-independently (unchanged from fix #1); "#Token#" markers have no number to key off,
    // so they're named by strict left-to-right order of appearance instead ("tok0", "tok1", ...)
    // - both Raw's and Result's token occurrences are walked in that same order, which holds
    // because translation is expected to carry each marker through verbatim and in place, only
    // moving the surrounding literal text (the same assumption every other file in this pipeline
    // already relies on for these tokens - see CompoundFieldSplitter in the sibling
    // FanslationStudio.LlmKit repo).
    private static CompiledTemplate BuildCompiledTemplate(DictionaryEntry entry)
    {
        var raw = entry.Raw ?? string.Empty;
        var patternBuilder = new System.Text.StringBuilder();
        var permissivePatternBuilder = new System.Text.StringBuilder();
        var literalSegments = new List<string>();
        var lastIndex = 0;
        var tokenIndex = 0;
        var result = entry.Result ?? string.Empty;

        // CONFIRMED BUG #5 (2026-08-30, "巨 鲸帮.../仙霞.派..." screenshot case - the
        // "在下#TargetForceDescribe##$TargetInteractName#，\n此次特地前来拜访
        // #SourceForceDescribe##$SourceInteractName#" template): when two placeholder/token
        // markers sit DIRECTLY ADJACENT in Raw with ZERO literal text between them (e.g.
        // "#TargetForceDescribe##$TargetInteractName#" - no separator at all), there is NO anchor
        // in the input for a lazy "+?" capture to bound itself against - the regex engine simply
        // grabs the minimum 1 character for the first capture and hands everything else to the
        // second, since IsMatch/Replace only need SOME match, not a maximal one. Confirmed via a
        // throwaway harness reproducing this exact template against the real runtime string
        // ("在下巨鲸帮<color=...>外门弟子</color>YuLingZhu，\n此次特地前来拜访仙霞派<color=...>
        // 掌门</color>姜映泉"): tok0 (#TargetForceDescribe#) captured only "巨", tok1
        // (#$TargetInteractName#) captured the REMAINING "鲸帮<color=...>外门弟子</color>
        // YuLingZhu" - and since the template's Result has a literal space between the two
        // placeholders ("#TargetForceDescribe# #$TargetInteractName#"), this rendered as
        // "巨 鲸帮..." (force name torn in half by a bogus space). Worse, the trailing
        // "#SourceForceDescribe##$SourceInteractName#" pair (also adjacent, AND at the very end of
        // Raw with no trailing literal to anchor it either) similarly captured just "仙"+"霞",
        // leaving "派<color=...>掌门</color>姜映泉" outside the match entirely, and Result's own
        // trailing "." literal got glued onto the truncated capture ("仙霞."), explaining the
        // "仙霞.派" corruption. This can never be fixed by choosing greedy vs. lazy quantifiers -
        // greedy would just tear the boundary the OTHER way (first capture eating everything,
        // second reduced to 1 char) - there is fundamentally no information in the input to know
        // where one adjacent token's substituted value ends and the next begins.
        //
        // FIRST FIX ATTEMPT (rejected, see below): unconditionally skipping ANY template
        // containing an adjacent-placeholder run was too conservative - it also threw away
        // perfectly safe templates like "胜负已分，夺冠者乃是...#SourceForceDescribe#
        // #$SourceInteractName#！..." whose Result ALSO keeps that exact pair glued adjacent
        // (result: "The winner is...#SourceForceDescribe##$SourceInteractName#!..."), losing
        // translation of all of that template's OTHER literal connector text for no reason - the
        // ambiguity that makes bug #5 dangerous only exists when Result actually needs to insert
        // something (e.g. a space) BETWEEN the two adjacent values, which requires knowing where
        // one placeholder's substituted value ends and the next begins - information that simply
        // isn't present when Result keeps them glued too.
        //
        // ACTUAL FIX: for each maximal run of 2+ raw placeholders with zero literal between them,
        // check whether Result's text contains that EXACT SAME concatenated marker sequence
        // verbatim (e.g. "#SourceForceDescribe##$SourceInteractName#"):
        //  - If YES (safe case): Result treats the pair exactly as glued as Raw does, so there is
        //    no need to split them at all - the whole run compiles into ONE combined wildcard
        //    capture group (using the CJK-permissive class, since a merged run's value is very
        //    often a legitimately-CJK force name) that is captured and re-emitted VERBATIM,
        //    unsplit, in place of that exact literal marker-run substring in Result. The run's
        //    combined captured text still passes through the ordinary bare-fragment
        //    ApplyDictionary pass afterward (this template only translates the surrounding literal
        //    connector text), so e.g. "巨鲸帮"/"仙霞派"/"外门弟子"/"掌门" inside the merged span
        //    still get translated correctly on their own, just not by this template.
        //  - If NO (unsafe case, e.g. the Target pair above, where Result wants a space between
        //    them): still fundamentally unbounded - keep the previous conservative behavior of
        //    refusing to compile this template at all (skip it, log a warning, same "return null"
        //    pattern PatchAll already uses for a template that throws while compiling).
        var placeholderMatches = PlaceholderOrTokenRegex.Matches(raw).Cast<Match>().ToList();

        // Identify maximal runs (start/end inclusive indices into placeholderMatches) of 2+
        // consecutive matches separated by zero raw literal text.
        var runs = new List<(int Start, int End)>();
        {
            var i = 0;
            while (i < placeholderMatches.Count)
            {
                var j = i;
                while (j + 1 < placeholderMatches.Count
                       && placeholderMatches[j + 1].Index == placeholderMatches[j].Index + placeholderMatches[j].Length)
                    j++;
                if (j > i) runs.Add((i, j));
                i = j + 1;
            }
        }

        // Validate every run is safe BEFORE building any pattern text - reject the whole template
        // immediately if any run is unsafe.
        //
        // "Safe" now means: Result contains this run's markers, IN ORDER, separated by nothing
        // but WHITESPACE (was previously: separated by nothing at all, i.e. glued verbatim).
        // Widening this to tolerate whitespace-only gaps fixes a large batch of templates that
        // were being needlessly rejected in full just because Result adds a cosmetic space
        // between the two values (e.g. "#TargetForceDescribe# #$TargetInteractName#") - that
        // space carries no information we'd need to reconstruct a split point for, so the whole
        // run can still be merged into one verbatim pass-through capture exactly as the fully-
        // glued case is, just also swallowing that whitespace (the merged capture's own value
        // rarely needs an extra space injected into the middle of a force-name/hero-name pair
        // anyway - e.g. "Giant Whale GangYuLingZhu" reads acceptably, and is vastly preferable to
        // losing the whole template's other literal connector text to a full rejection).
        // A gap containing anything else (real translated words, punctuation reordering, etc. -
        // e.g. "#TargetForceDescribe#. It's nice to meet you, #$TargetInteractName#.") means
        // Result depends on knowing exactly where one value ends and the next begins, which this
        // template's Raw gives us no way to determine - genuinely unsafe, template still rejected.
        var runResultSpan = new Dictionary<int, string>(); // keyed by run Start index
        foreach (var (start, end) in runs)
        {
            var runPattern = string.Join(@"\s*", Enumerable.Range(start, end - start + 1).Select(k => Regex.Escape(placeholderMatches[k].Value)));
            var runMatch = Regex.Match(result, runPattern);
            if (!runMatch.Success)
            {
                MainPlugin.Logger.LogWarning(
                    $"[DynamicStringPatches] Skipping template with adjacent placeholders that Result splits apart (cannot be safely bounded by regex): '{raw}'");
                return null;
            }
            runResultSpan[start] = runMatch.Value;
        }

        // CONFIRMED BUG #6 (2026-08-30, "仙.霞派" screenshot case - the "...此次特地前来拜访
        // #SourceForceDescribe##$SourceInteractName#" template, which has NOTHING after the
        // placeholder pair): the same "no anchor to bound a lazy capture against" root cause as
        // bug #5 also applies when a placeholder/token (or merged run) is the LAST thing in Raw,
        // with zero trailing literal text - there is nothing after it in the pattern to force the
        // lazy "+?" quantifier to expand, so it matches the minimum 1 character and leaves the
        // rest of the actual value untouched by this template (which then gets partially handled,
        // partially not, by the following bare-fragment pass - explaining a force/hero name being
        // torn apart even though it isn't adjacent to another placeholder). Fix: when the FINAL
        // group in the template has no trailing literal to anchor it, make that one group GREEDY
        // ("+" instead of "+?") instead - since there is nothing after it in the pattern, greedy
        // naturally consumes up to the end of the current input text (or up to the next newline
        // for the CJK-permissive "." class, which doesn't match newlines by default), which is
        // the correct behavior for a placeholder that is genuinely the last piece of displayed
        // text. Every OTHER group (with something after it, even just another group) keeps its
        // lazy quantifier unchanged - this is a targeted fix for the specific unanchored-at-the-
        // end case, not a blanket greedy-everywhere change.
        var lastGroupIsUnanchored = placeholderMatches.Count > 0
            && placeholderMatches[^1].Index + placeholderMatches[^1].Length == raw.Length;

        var runStartToEnd = runs.ToDictionary(r => r.Start, r => r.End);
        var runIndex = 0;
        var idx = 0;
        while (idx < placeholderMatches.Count)
        {
            if (runStartToEnd.TryGetValue(idx, out var runEnd))
            {
                // Merged run: one combined pass-through capture spanning the whole run, bounded
                // only by whatever literal precedes/follows the WHOLE run (not between its
                // members) - see the safety analysis above for why this is sound.
                var runStartMatch = placeholderMatches[idx];
                var runEndMatch = placeholderMatches[runEnd];
                var literal = raw.Substring(lastIndex, runStartMatch.Index - lastIndex);
                if (literal.Length > 0)
                {
                    var escapedLiteral = Regex.Escape(literal);
                    patternBuilder.Append(escapedLiteral);
                    permissivePatternBuilder.Append(escapedLiteral);
                    literalSegments.Add(literal);
                }

                var groupName = $"run{runIndex}";
                // CJK-permissive on both patterns (not just the fallback) - a merged run's value
                // is frequently a legitimately-CJK force name, so the strict non-CJK class would
                // never match here at all. See CONFIRMED BUG #6 above for the quantifier choice.
                var runQuantifier = (lastGroupIsUnanchored && runEnd == placeholderMatches.Count - 1) ? "*" : "*?";
                patternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{runQuantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{runQuantifier})");

                // Replace this run's first occurrence of its Result span (markers plus any
                // whitespace-only gap between them - see the safety check above) with a
                // sentinel, so the ordinary per-placeholder walk below (which still handles every
                // OTHER, non-merged placeholder normally) skips straight over it - the sentinel is
                // swapped for a real "${runN}" reference afterward.
                var resultSpan = runResultSpan[idx];
                var sentinelIdx = result.IndexOf(resultSpan, StringComparison.Ordinal);
                if (sentinelIdx >= 0)
                {
                    var sentinel = $"\u0001RUN{runIndex}\u0001";
                    result = result.Substring(0, sentinelIdx) + sentinel + result.Substring(sentinelIdx + resultSpan.Length);
                }

                lastIndex = runEndMatch.Index + runEndMatch.Length;
                idx = runEnd + 1;
                runIndex++;
                continue;
            }

            var placeholder = placeholderMatches[idx];
            var singleLiteral = raw.Substring(lastIndex, placeholder.Index - lastIndex);
            if (singleLiteral.Length > 0)
            {
                var escapedLiteral = Regex.Escape(singleLiteral);
                patternBuilder.Append(escapedLiteral);
                permissivePatternBuilder.Append(escapedLiteral);
                literalSegments.Add(singleLiteral);
            }

            // See CONFIRMED BUG #6 above for the quantifier choice.
            //
            // CONFIRMED BUG #7 (2026-08-30, "获 Victory 条件" screenshot case - the "获胜条件：
            // \n{0}击败敌方{1}" template): a "+"/"+?" (one-or-more) quantifier can never match a
            // placeholder whose real runtime value is the EMPTY STRING (e.g. this template's {0}
            // is blank whenever there's no time-limit prefix condition, leaving the runtime text
            // as plain "获胜条件：\n击败敌方全体"). When that happens, both Pattern and
            // PermissivePattern fail to match, the whole template (including its own translated
            // literal connector text) is skipped, and the bare ApplyDictionary substring pass
            // mangles the untranslated CJK with unrelated short fragment entries instead. Fix:
            // use "*"/"*?" (zero-or-more) so a genuinely-empty substituted value still lets the
            // template match and translate its literal text - this only widens the minimum
            // repeat count, the CJK-exclusion character class (bug #3) and BlockingRawEntries
            // overlap guard (bug #4) are unchanged, so it does not reopen either of those.
            var isLastGroup = idx == placeholderMatches.Count - 1;
            var quantifier = (lastGroupIsUnanchored && isLastGroup) ? "*" : "*?";
            if (placeholder.Groups[1].Success)
            {
                var groupName = $"p{placeholder.Groups[1].Value}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{quantifier})");
            }
            else
            {
                var groupName = $"tok{tokenIndex}";
                patternBuilder.Append($"(?<{groupName}>{PlaceholderCaptureClass}{quantifier})");
                permissivePatternBuilder.Append($"(?<{groupName}>{PermissivePlaceholderCaptureClass}{quantifier})");
                tokenIndex++;
            }

            lastIndex = placeholder.Index + placeholder.Length;
            idx++;
        }

        var trailingLiteral = raw.Substring(lastIndex);
        if (trailingLiteral.Length > 0)
        {
            var escapedTrailingLiteral = Regex.Escape(trailingLiteral);
            patternBuilder.Append(escapedTrailingLiteral);
            permissivePatternBuilder.Append(escapedTrailingLiteral);
            literalSegments.Add(trailingLiteral);
        }

        var replacementTokenIndex = 0;
        var replacementPattern = PlaceholderOrTokenRegex.Replace(result, m =>
        {
            if (m.Groups[1].Success) return $"${{p{m.Groups[1].Value}}}";
            var name = $"tok{replacementTokenIndex}";
            replacementTokenIndex++;
            return $"${{{name}}}";
        });

        // Swap each run's sentinel back to a real "${runN}" backreference now that the ordinary
        // per-placeholder Replace pass above (which never sees the sentinel text, since it
        // contains no "{n}"/"#Token#" markers) has finished.
        for (var r = 0; r < runIndex; r++)
            replacementPattern = replacementPattern.Replace($"\u0001RUN{r}\u0001", $"${{run{r}}}");

        return new CompiledTemplate
        {
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled),
            PermissivePattern = new Regex(permissivePatternBuilder.ToString(), RegexOptions.Compiled),
            ReplacementPattern = replacementPattern,
            LiteralSegments = literalSegments,
        };
    }

    [ThreadStatic]
    private static bool _inTextSetterPostfix;

    // Guards GenericPostfix/FormatPrefix (the String.Concat/Format patches) against re-entrancy.
    // Confirmed necessary the hard way: MainPlugin.Logger.LogInfo/LogError (BepInEx's
    // DiskLogListener.LogEvent) internally calls System.String.Format itself to build the log
    // line - which is one of the very methods this class patches - so logging anything from
    // inside GenericPostfix/FormatPrefix (including from a catch block's error log) re-enters the
    // same patch and recurses infinitely (observed as a StackOverflow via nested
    // "DynamicClass.DMD<System.String::Format> -> DiskLogListener.LogEvent -> ... ->
    // GenericPostfix -> DynamicClass.DMD<System.String::Format> -> ..." frames). Set true before
    // running the patch body (including before any logging in its catch block) and checked at
    // entry so a re-entrant call is always a cheap, immediate no-op instead of running the
    // dictionary/template scan and logging again.
    [ThreadStatic]
    private static bool _inFormatConcatPatch;

    public sealed class DictionaryEntry
    {
        public string Raw { get; set; }
        public string Result { get; set; }

        // Deserialized from the packaged YAML's "isTemplate" key (see FanslationStudio.LlmKit's
        // DynamicStringResult.IsTemplate) - the pipeline computes this once at packaging time so
        // the plugin never has to re-derive "does Raw look like a String.Format template" from
        // the raw text itself at runtime.
        public bool IsTemplate { get; set; }

        // PERF (2026-08-29, framerate regression after word-boundary spacing was added): these two
        // are the visible (tag-stripped) first/last character of Result, needed on every match by
        // ReplaceWithWordBoundarySpacing's boundary check. They never change once the dictionary is
        // loaded, so they're computed exactly once here (see LoadDictionary) instead of being
        // recomputed via a regex scan of Result on every single match of every single dictionary
        // entry, for every String.Concat/Format call and every TMP_Text/UI.Text setter in the
        // running game - that repeated recompute (multiplied by hundreds of entries x every hot-path
        // call) was the actual cause of the regression, not the boundary-check concept itself.
        public char? ReplacementLeadChar { get; set; }
        public char? ReplacementTrailChar { get; set; }
    }

    /// <summary>Loads dynamicStrings.txt.yaml (if present) and patches every public static
    /// string-returning overload of System.String.Concat/Format, plus TMP_Text.text and
    /// UnityEngine.UI.Text.text's setters. Safe to call even if the dictionary file is missing
    /// (patches still apply, just as a no-op) or a given overload/setter fails to patch (that one
    /// is skipped and logged, the rest still patch).</summary>
    public static void PatchAll()
    {
        try
        {
            var loaded = LoadDictionary();
            _templateDictionary = loaded.Where(e => e.IsTemplate).ToList();
            _dictionary = loaded.Where(e => !e.IsTemplate).ToList();

            // See _reverseDictionary's own comment above. Built from _dictionary only (not
            // templates - a template's Result is a structural pattern, not a literal string, so
            // there's no sensible reverse mapping for it). Iterate in the already-established
            // longest-Raw-first order but only keep the FIRST Result seen for a given key (i.e.
            // prefer the entry whose Raw is longest) so an ambiguous short Result never overwrites
            // a more specific one.
            foreach (var entry in _dictionary)
            {
                if (string.IsNullOrEmpty(entry.Result)) continue;
                if (!_reverseDictionary.ContainsKey(entry.Result))
                    _reverseDictionary[entry.Result] = entry.Raw;
            }

            _compiledTemplates = _templateDictionary
                .Select(entry =>
                {
                    try { return BuildCompiledTemplate(entry); }
                    catch (Exception ex)
                    {
                        MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to compile template '{entry.Raw}': {ex}");
                        return null;
                    }
                })
                .Where(t => t != null)
                .ToList();

            // See CompiledTemplate.BlockingRawEntries for why this exists: computed once here
            // (not per-call) since both _dictionary and _compiledTemplates are already loaded and
            // fixed for the lifetime of the process.
            foreach (var template in _compiledTemplates)
            {
                template.BlockingRawEntries = _dictionary
                    .Where(e => !string.IsNullOrEmpty(e.Raw)
                        && template.LiteralSegments.Any(seg => seg.Length > 0 && e.Raw.Contains(seg) && e.Raw.Length > seg.Length))
                    .Select(e => e.Raw)
                    .Distinct()
                    .ToList();
            }

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Loaded {_dictionary.Count} translated fragment(s) and {_templateDictionary.Count} template(s) ({_compiledTemplates.Count} compiled) from '{DictionaryFilePattern}'.");

            var harmony = new Harmony("EnglishPatch.DynamicStringPatches");
            var postfix = new HarmonyMethod(typeof(DynamicStringPatches), nameof(GenericPostfix));
            var formatPrefix = new HarmonyMethod(typeof(DynamicStringPatches), nameof(FormatPrefix));

            var targets = typeof(string)
                .GetMethods(BindingFlags.Public | BindingFlags.Static)
                .Where(m => (m.Name == nameof(string.Concat) || m.Name == nameof(string.Format))
                    && m.ReturnType == typeof(string)
                    && !m.IsGenericMethod);

            var patched = 0;
            var formatPatched = 0;
            foreach (var method in targets)
            {
                try
                {
                    // Format's template argument (still containing literal "{0}"/"{1}"/... at this
                    // point) is translated first via the prefix, then the (now-translated,
                    // already-formatted) result still goes through the same postfix as Concat -
                    // harmless no-op for the template fragments (their literal braces text is gone
                    // by then) but still catches any additional bare-fragment matches elsewhere in
                    // the same result.
                    var isFormat = method.Name == nameof(string.Format);
                    harmony.Patch(method, prefix: isFormat ? formatPrefix : null, postfix: postfix);
                    patched++;
                    if (isFormat) formatPatched++;
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to patch {method}: {ex}");
                }
            }

            MainPlugin.Logger.LogInfo($"[DynamicStringPatches] Patched {patched} String.Concat/Format overload(s) ({formatPatched} with template prefix).");

            // Sink-level patches: attribute-driven ([HarmonyPatch] on TmpTextSetText_Postfix /
            // UiTextSetText_Postfix below), applied via PatchAll(Type) rather than manual
            // reflection since the target methods are known/fixed at compile time.
            harmony.PatchAll(typeof(DynamicStringPatches));
            MainPlugin.Logger.LogInfo("[DynamicStringPatches] Patched TMP_Text.text/UI.Text.text setters.");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] PatchAll failed: {ex}");
        }
    }

    private static List<DictionaryEntry> LoadDictionary()
    {
        try
        {
            var paths = FindResourceFiles(DictionaryFilePattern);
            if (paths.Count == 0) return new List<DictionaryEntry>();

            var deserializer = new DeserializerBuilder()
                .WithNamingConvention(CamelCaseNamingConvention.Instance)
                .IgnoreUnmatchedProperties()
                .Build();

            var entries = new List<DictionaryEntry>();
            foreach (var path in paths)
            {
                try
                {
                    var yaml = File.ReadAllText(path);
                    var fileEntries = deserializer.Deserialize<List<DictionaryEntry>>(yaml);
                    if (fileEntries != null) entries.AddRange(fileEntries);
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load '{path}': {ex}");
                }
            }

            // Merge in PrefabTextPatches' own dictionary files as additional bare fragments/
            // templates (see PrefabTextFilePattern's comment above) - deduped against Raw values
            // already present above, so an explicit dynamicStrings entry (which may be worded/
            // context-tuned differently) always wins over a merged-in prefab-text one for the
            // same raw phrase.
            var existingRaw = new HashSet<string>(entries.Select(e => e.Raw).Where(r => !string.IsNullOrEmpty(r)));
            var mergedFromPrefabText = 0;
            foreach (var path in FindResourceFiles(PrefabTextFilePattern))
            {
                try
                {
                    var yaml = File.ReadAllText(path);
                    var fileEntries = deserializer.Deserialize<List<DictionaryEntry>>(yaml);
                    if (fileEntries == null) continue;

                    foreach (var entry in fileEntries)
                    {
                        if (string.IsNullOrEmpty(entry.Raw) || !existingRaw.Add(entry.Raw))
                            continue;

                        // CONFIRMED BUG (2026-08-30, "此次特地前来拜访" screenshot case,
                        // found right after this merge was added): dumpedPrefabText*.txt.yaml's
                        // Raw/Result values use a DIFFERENT newline-escaping convention than
                        // dynamicStrings.txt.yaml's own native entries. AssetDumperWorkflowTests
                        // pre-escapes a real line break into a literal two-char "\n" (backslash +
                        // n) BEFORE writing the YAML (see PrefabTextPatches.NormalizeForLookup's
                        // comment), so after YamlDotNet parses the double-quoted YAML scalar,
                        // entry.Raw/Result here still contain that literal two-char sequence.
                        // dynamicStrings.txt.yaml's own entries, by contrast, embed a PLAIN YAML
                        // "\n" escape directly (e.g. "，\n此次..."), which YamlDotNet decodes to a
                        // REAL newline CHARACTER - the convention every dynamicStrings
                        // template/fragment (and Concat/Format/TMP_Text runtime string) actually
                        // uses. An earlier attempt fixed this by normalizing the RUNTIME string at
                        // match time (real newline -> literal "\n") - this was WRONG: it broke
                        // every pre-existing dynamicStrings template containing a real newline
                        // (e.g. "在下#TargetForceDescribe##$TargetInteractName#，\n此次特地前来拜访..."
                        // at line ~7383), since the runtime string's real newline no longer
                        // matched their real-newline literal segments once converted away. Correct
                        // fix: convert ONLY the merged-in PrefabText entries here, once, at load
                        // time, into dynamicStrings' own real-newline convention - no runtime
                        // normalization needed anywhere.
                        entry.Raw = entry.Raw.Replace("\\n", "\n");
                        if (entry.Result != null)
                            entry.Result = entry.Result.Replace("\\n", "\n");

                        // PrefabText's own dictionary files never carry an "isTemplate" key
                        // (PrefabTextPatches only ever does exact whole-string matching, it has no
                        // template concept), so it always deserializes as false here regardless of
                        // shape. But some "other field" entries (e.g. quest-task descriptions) DO
                        // contain the game's own "#Token#"-style localization placeholders (e.g.
                        // "前往#TargetPlace#与顾师兄汇合。") which get substituted with real
                        // (already-translated) text by the game BEFORE this string ever reaches a
                        // patched call/setter - so merging such an entry in as a bare fragment
                        // would never match (the literal "#TargetPlace#" text is long gone by
                        // then). Detect this via the same PlaceholderOrTokenRegex
                        // BuildCompiledTemplate already uses, and route these into the template
                        // dictionary instead so they get compiled into a structural/regex matcher
                        // (confirmed 2026-08-30: quest tracker showing "Proceed Xianxia Sect
                        // Training Grounds And 顾 Senior Brother 汇 Merge。" - the whole-phrase
                        // entry never matched at all, so only isolated bare fragments elsewhere in
                        // dynamicStrings.txt.yaml applied, leaving "顾"/"汇"/"。" untranslated).
                        entry.IsTemplate = PlaceholderOrTokenRegex.IsMatch(entry.Raw);
                        entries.Add(entry);
                        mergedFromPrefabText++;
                    }
                }
                catch (Exception ex)
                {
                    MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load '{path}': {ex}");
                }
            }

            if (mergedFromPrefabText > 0)
            {
                MainPlugin.Logger.LogInfo(
                    $"[DynamicStringPatches] Merged {mergedFromPrefabText} additional fragment(s) from '{PrefabTextFilePattern}'.");
            }

            // Precompute each entry's visible replacement edge chars once (see
            // DictionaryEntry.ReplacementLeadChar/ReplacementTrailChar) rather than on every match
            // at call time - see the perf note on those fields for why this matters.
            foreach (var entry in entries)
            {
                entry.ReplacementLeadChar = EffectiveLeadingChar(entry.Result ?? string.Empty);
                entry.ReplacementTrailChar = EffectiveTrailingChar(entry.Result ?? string.Empty);
            }

            // Longest-fragment-first: entries are applied via sequential substring replace
            // (ApplyDictionary), so a shorter fragment that happens to be a substring of a longer
            // one (e.g. "势" vs "架势") must not get a chance to match first - it would corrupt the
            // longer fragment's span before that entry's own (more specific/correct) replacement
            // ever runs. Sorting longest-first guarantees the most specific match always wins,
            // regardless of which source file a given entry came from.
            return entries.OrderByDescending(e => e.Raw?.Length ?? 0).ToList();
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Failed to load dictionaries matching '{DictionaryFilePattern}': {ex}");
            return new List<DictionaryEntry>();
        }
    }

    private static List<string> FindResourceFiles(string filePattern)
    {
        return Directory.Exists(ResourcesDir)
            ? Directory.GetFiles(ResourcesDir, filePattern, SearchOption.AllDirectories).ToList()
            : new List<string>();
    }

    // PERF (2026-08-29, "still a bit slow" follow-up): String.Concat/Format fire an enormous
    // number of times per frame in a running Unity game (number formatting, asset path building,
    // engine-internal string work, etc.), and the overwhelming majority of those calls involve no
    // Chinese text at all. Every _dictionary/_templateDictionary entry's Raw is now guaranteed to
    // contain at least one CJK character (see Tests/GameFileHandling.cs's
    // RemoveNonChineseDynamicStringEntries, which filters the packaged YAML at packaging time), so
    // a call whose result has zero CJK characters can NEVER match anything in either dictionary -
    // skip the whole per-entry Contains()/regex scan for that overwhelmingly common case instead of
    // paying for it on every single call. Plain char-range scan (no regex/allocation) so the gate
    // itself is as cheap as possible.
    private static bool ContainsCjk(string s)
    {
        foreach (var c in s)
        {
            // CJK Unified Ideographs (covers every confirmed Raw fragment seen so far) plus CJK
            // Symbols and Punctuation (the fullwidth colon/comma etc. that can appear in a
            // template's literal separator text, e.g. "：").
            if ((c >= '\u4E00' && c <= '\u9FFF') || (c >= '\u3000' && c <= '\u303F'))
                return true;
        }
        return false;
    }

    private const string ResidualCjkDebugLogFileName = "residualCjkDebug.log";

    // Gated by MainPlugin.ResidualCjkDebugEnabled (off by default - see its own comment). When
    // enabled, logs the before/after text for any call where CJK characters remain after both the
    // template and bare-fragment passes, to help pin down translation gaps (missing dictionary
    // entries, a rejected/mis-firing template, a hero/force name composed by a method this plugin
    // doesn't hook, etc.) without needing to re-add this logging by hand each time. Uses
    // File.AppendAllText directly (never MainPlugin.Logger) - see GenericPostfix's comment on why
    // Logger calls from inside these patched methods can recurse into String.Concat/Format and
    // loop forever; this same reasoning applies to any diagnostic logging added here.
    private static void LogResidualCjkDebug(string stage, string before, string after)
    {
        if (MainPlugin.ResidualCjkDebugEnabled?.Value != true) return;
        if (!ContainsCjk(after)) return;

        try
        {
            var path = Path.Combine(PluginDir, ResidualCjkDebugLogFileName);
            File.AppendAllText(path,
                $"[{DateTime.Now:HH:mm:ss.fff}] {stage}{Environment.NewLine}" +
                $"  before: {before}{Environment.NewLine}" +
                $"  after:  {after}{Environment.NewLine}");
        }
        catch
        {
            // Best-effort diagnostic only - never let a logging failure affect translation.
        }
    }

    // Applied to every patched String.Concat/Format overload's result. _dictionary is expected to
    // stay small (low hundreds of entries at most), so an unconditional per-call scan is cheap
    // relative to the sheer call volume of String.Concat/Format in a running Unity game; skip
    // entirely when the dictionary is empty (e.g. before the pipeline has produced one yet) or when
    // the result contains no Chinese at all (see ContainsCjk).
    private static void GenericPostfix(ref string __result)
    {
        if (string.IsNullOrEmpty(__result) || _inFormatConcatPatch) return;
        if (_compiledTemplates.Count == 0 && _dictionary.Count == 0) return;
        if (!ContainsCjk(__result)) return;

        // Guard MUST be set before any diagnostic logging below - see CONFIRMED BUG (2026-08-29,
        // OutOfMemoryException/infinite-recursion case): DebugEscape's string.Replace chain and
        // the `$"..."` interpolation calls used by SafeDebugLog themselves compile to
        // System.String.Concat calls, which re-enter this very postfix. Setting the guard first
        // makes that re-entry an immediate no-op instead of looping forever (same recursion class
        // as docs/dynamicstringpatches-template-regex-bug.md's original MainPlugin.Logger bug -
        // any code path invoked from inside this method, diagnostic or not, must run only after
        // the guard is set).
        _inFormatConcatPatch = true;
        try
        {
            var original = __result;
            var result = original;
            if (_compiledTemplates.Count > 0)
                result = ApplyTemplates(result, _compiledTemplates);
            if (_dictionary.Count > 0)
                result = ApplyDictionary(result, _dictionary);
            LogResidualCjkDebug("GenericPostfix", original, result);
            __result = result;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Postfix failed: {ex}");
        }
        finally
        {
            _inFormatConcatPatch = false;
        }
    }

    // Runs before every patched String.Format overload. Translates the *template* argument itself
    // (still containing literal "{0}"/"{1}"/... placeholders at this point, e.g.
    // "{0}年{1}月{2}日") against _templateDictionary, so the composite literal's own real
    // fragments ("年"/"月"/"日") get translated as one deliberate, specific whole-template match
    // instead of relying on the generic postfix's substring scan of the *already-formatted*
    // result - which can never see the template's literal braces text at all (by then "{0}" etc.
    // have been substituted with real data), and would otherwise only get accidentally patched by
    // unrelated bare-fragment entries that happen to share a substring with part of the template.
    // Harmony matches this prefix's "format" parameter by name across every String.Format overload
    // (varying position/arg count), so one prefix method covers all of them.
    private static void FormatPrefix(ref string format)
    {
        if (string.IsNullOrEmpty(format) || _templateDictionary.Count == 0 || _inFormatConcatPatch) return;
        if (!ContainsCjk(format)) return;

        // Guard MUST be set before any diagnostic logging below - see the recursion note in
        // GenericPostfix above (same root cause applies here: DebugEscape/SafeDebugLog's own
        // string operations compile to Concat calls that would otherwise re-enter unguarded).
        _inFormatConcatPatch = true;
        try
        {
            var original = format;
            format = ApplyDictionary(format, _templateDictionary);
            LogResidualCjkDebug("FormatPrefix", original, format);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] FormatPrefix failed: {ex}");
        }
        finally
        {
            _inFormatConcatPatch = false;
        }
    }

    // Sink-level patch: catches text that reaches a TMP_Text/UI.Text component regardless of how
    // it was built (concatenation, string.Format, or - the case String.Concat/Format patching
    // alone can't reach - a plain literal field assignment like `field = "架势";` later read
    // straight into .text with no concatenation call at all). Re-reads the component's own .text
    // after the original setter ran, and if the dictionary changes anything, writes it back through
    // the same (patched) setter. The [ThreadStatic] guard makes the resulting re-entrant call
    // unconditionally terminate on its second pass (skips the dictionary scan entirely) rather than
    // relying on the replaced text simply no longer containing any raw fragments.
    [HarmonyPatch(typeof(TMP_Text), nameof(TMP_Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void TmpTextSetText_Postfix(TMP_Text __instance)
    {
        ApplyToComponentText(() => __instance.text, v => __instance.text = v);
    }

    [HarmonyPatch(typeof(Text), nameof(Text.text), MethodType.Setter)]
    [HarmonyPostfix]
    private static void UiTextSetText_Postfix(Text __instance)
    {
        ApplyToComponentText(() => __instance.text, v => __instance.text = v);
    }

    private static void ApplyToComponentText(Func<string> getText, Action<string> setText)
    {
        if (_inTextSetterPostfix) return;

        // Guard set up-front (before diagnostic logging) for the same reason as
        // GenericPostfix/FormatPrefix above: SafeDebugLog/DebugEscape's own string operations
        // could otherwise re-enter this same setter postfix via a nested .text write.
        _inTextSetterPostfix = true;
        try
        {
            var current = getText();
            if (string.IsNullOrEmpty(current)) return;
            if (_compiledTemplates.Count == 0 && _dictionary.Count == 0) return;
            if (!ContainsCjk(current)) return;

            var replaced = current;
            if (_compiledTemplates.Count > 0)
                replaced = ApplyTemplates(replaced, _compiledTemplates);
            if (_dictionary.Count > 0)
                replaced = ApplyDictionary(replaced, _dictionary);
            LogResidualCjkDebug("ApplyToComponentText", current, replaced);
            if (replaced == current) return;

            setText(replaced);
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Text setter postfix failed: {ex}");
        }
        finally
        {
            _inTextSetterPostfix = false;
        }
    }

    // Structural/regex counterpart to ApplyDictionary - matches each compiled template's *shape*
    // (translated literal separators around captured placeholder spans) anywhere in the input,
    // regardless of what actually substituted the original template's placeholders (String.Format,
    // String.Concat, or - the confirmed motivating case - .NET's own internal DateTime.ToString()
    // culture formatting, which bakes zh-CN's "年"/"月"/"日" separators directly with no
    // patchable managed call in between). Cheap LiteralSegments pre-filter avoids running the full
    // regex for templates that obviously can't match. Applied before the bare-fragment dictionary
    // pass so a matched composite's own literal separators are fully translated first, preventing
    // an unrelated bare single-character entry (e.g. a standalone "年"/"月" entry meant for a
    // different call site) from partially corrupting the same span first.
    private static string ApplyTemplates(string input, List<CompiledTemplate> templates)
    {
        var result = input;
        foreach (var template in templates)
        {
            if (template.LiteralSegments.Count > 0 && !template.LiteralSegments.All(result.Contains))
                continue;

            // PLAN B: try the strict (non-CJK-capture) pattern first - unchanged bug #3/#4
            // behavior. Only fall back to the permissive (CJK-inclusive) pattern when the strict
            // one fails to match at all, so templates that already match correctly today never
            // reach the more permissive path (see PermissivePlaceholderCaptureClass's comment).
            var pattern = template.Pattern;
            if (!pattern.IsMatch(result))
            {
                pattern = template.PermissivePattern;
                if (!pattern.IsMatch(result))
                    continue;
            }

            // See CompiledTemplate.BlockingRawEntries (CONFIRMED BUG #4) - captures the text at
            // the start of this template's pass so per-match overlap checks are computed against
            // a stable snapshot (Regex.Replace's MatchEvaluator runs against this same original
            // string for every match before any replacement is written back).
            var beforeThisTemplate = result;
            result = pattern.Replace(result, m =>
                template.BlockingRawEntries.Count > 0 && OverlapsBlockingEntry(beforeThisTemplate, m, template.BlockingRawEntries)
                    ? m.Value
                    : m.Result(template.ReplacementPattern));
        }
        return result;
    }

    // Returns true if any of the template's BlockingRawEntries occurs in `text` at a position
    // overlapping this specific regex match's span - see CompiledTemplate.BlockingRawEntries for
    // the full "经验{0}%" vs "非本门弟子经验" motivating case.
    private static bool OverlapsBlockingEntry(string text, Match match, List<string> blockingRawEntries)
    {
        var matchStart = match.Index;
        var matchEnd = match.Index + match.Length;
        foreach (var raw in blockingRawEntries)
        {
            var idx = text.IndexOf(raw, StringComparison.Ordinal);
            while (idx >= 0)
            {
                var entryEnd = idx + raw.Length;
                if (idx < matchEnd && entryEnd > matchStart)
                    return true;
                idx = text.IndexOf(raw, idx + 1, StringComparison.Ordinal);
            }
        }
        return false;
    }

    // Public entry point for other patch classes (e.g. HeroNamePatches) that need to translate a
    // raw Chinese fragment - such as a family/given name sliced out of a native string
    // concatenation - using this same loaded substring dictionary, outside of the
    // Concat/Format/text-setter hooks this class patches itself.
    public static string TranslateFragment(string input) => ApplyDictionary(input, _dictionary);

    // Public entry point for patch classes that need to undo this dictionary's substring replace -
    // see _reverseDictionary's comment and ItemIconPatches.GetItemIconName_Postfix for the
    // motivating case. Returns the original raw Chinese text for an EXACT translated match, or the
    // input unchanged if it isn't a recognized whole-string translation result.
    public static string ReverseTranslate(string translated)
    {
        if (string.IsNullOrEmpty(translated)) return translated;
        return _reverseDictionary.TryGetValue(translated, out var raw) ? raw : translated;
    }

    private static string ApplyDictionary(string input, List<DictionaryEntry> dictionary)
    {
        var result = input;
        foreach (var entry in dictionary)
        {
            if (string.IsNullOrEmpty(entry.Raw)) continue;


            if (result.Contains(entry.Raw))
                result = ReplaceWithWordBoundarySpacing(result, entry);
        }
        return result;
    }

    // Plain substring replace smashes words together whenever a translated fragment lands
    // directly next to another word with no separator in the original raw text - the source
    // Chinese never needed a space there (CJK doesn't rely on whitespace for word boundaries), but
    // the English replacement does, e.g. "Slot" + "架势" + "Info" -> "Slot" + "Posture" + "Info"
    // becomes "SlotPostureInfo" instead of "Slot Posture Info". Fix: after substituting, look at
    // the character immediately preceding/following the match; if it's alphanumeric (letter or
    // digit - `char.IsLetterOrDigit` also treats CJK ideographs as letters, so an untranslated
    // Chinese neighbor still counts) and the adjoining edge of the replacement text is also
    // alphanumeric, insert a single space between them. Punctuation/symbols (":", "?", "-", CJK
    // punctuation, etc.) and whitespace are never treated as needing a separator, since
    // `char.IsLetterOrDigit` returns false for those - so "Foo:架势" stays "Foo:Posture", not
    // "Foo: Posture".
    //
    // CONFIRMED BUG (2026-08-29, "Xianxia Sect<color=#8C8C8C>Outer Gate Disciple</color>" case):
    // the naive boundary check above looks at the literal preceding/following character in the
    // string, but TMP/UI rich-text tags (`<color=...>`, `</color>`, `<b>`, etc.) render as
    // zero-width markup, not visible text - the *actual* on-screen neighbor of a match sitting
    // right next to a tag is whatever is on the OTHER side of that tag, not the tag's `<`/`>`
    // bracket itself. `<`/`>` are already non-alphanumeric so the old check correctly avoided
    // inserting a space touching the bracket - but that also meant it never looked past the tag to
    // find the real neighboring word, so "Sect" immediately followed by "<color=...>Outer..."
    // rendered as "SectOuter Gate Disciple" with no visible gap. Fix: `EffectiveTrailingChar`/
    // `EffectiveLeadingChar` strip any run of complete tags immediately at the edge being checked
    // before looking at the character, so the visible "t" (end of "Sect") and "O" (start of
    // "Outer") are compared directly, ignoring the tag markup between them.
    private static readonly Regex TrailingTagsRegex = new(@"(<\/?[A-Za-z][^<>]*>)+$", RegexOptions.Compiled);
    private static readonly Regex LeadingTagsRegex = new(@"^(<\/?[A-Za-z][^<>]*>)+", RegexOptions.Compiled);

    // One-time precompute helpers (see DictionaryEntry.ReplacementLeadChar/ReplacementTrailChar) -
    // only ever called once per dictionary entry at load time, so the regex allocation here is a
    // non-issue. Do NOT call these from the hot per-match path (ReplaceWithWordBoundarySpacing) -
    // use EffectiveTrailingCharInBuilder/EffectiveLeadingCharAt instead, which scan in place with
    // no allocation.
    private static char? EffectiveTrailingChar(string s)
    {
        var stripped = TrailingTagsRegex.Replace(s, string.Empty);
        return stripped.Length > 0 ? stripped[stripped.Length - 1] : (char?)null;
    }

    private static char? EffectiveLeadingChar(string s)
    {
        var stripped = LeadingTagsRegex.Replace(s, string.Empty);
        return stripped.Length > 0 ? stripped[0] : (char?)null;
    }

    // Allocation-free hot-path counterpart to EffectiveTrailingChar: walks backward from the end
    // of `sb` directly via its indexer (no ToString() copy of the whole accumulated buffer),
    // skipping over any complete tag(s) ("<...>"/"</...>") immediately at the end.
    private static char? EffectiveTrailingCharInBuilder(System.Text.StringBuilder sb)
    {
        var i = sb.Length - 1;
        while (i >= 0)
        {
            if (sb[i] == '>')
            {
                var tagStart = FindTagStartBackward(sb, i);
                if (tagStart >= 0)
                {
                    i = tagStart - 1;
                    continue;
                }
            }
            return sb[i];
        }
        return null;
    }

    // Finds the '<' that opens a tag closing at sb[closeIdx] ('>'), returning -1 if what precedes
    // closeIdx isn't actually a well-formed tag (mirrors TrailingTagsRegex/LeadingTagsRegex's
    // "<\/?[A-Za-z][^<>]*>" shape without allocating a substring to run a regex against).
    private static int FindTagStartBackward(System.Text.StringBuilder sb, int closeIdx)
    {
        var j = closeIdx - 1;
        while (j >= 0 && sb[j] != '<' && sb[j] != '>')
            j--;
        if (j < 0 || sb[j] != '<')
            return -1;

        var k = j + 1;
        if (k <= closeIdx - 1 && sb[k] == '/')
            k++;
        return k <= closeIdx - 1 && char.IsLetter(sb[k]) ? j : -1;
    }

    // Allocation-free hot-path counterpart to EffectiveLeadingChar: walks forward from `startIndex`
    // directly on `s` (no Substring() copy of the remaining tail), skipping over any complete
    // tag(s) immediately at that position.
    private static char? EffectiveLeadingCharAt(string s, int startIndex)
    {
        var i = startIndex;
        while (i < s.Length)
        {
            if (s[i] == '<')
            {
                var tagEnd = FindTagEndForward(s, i);
                if (tagEnd >= 0)
                {
                    i = tagEnd + 1;
                    continue;
                }
            }
            return s[i];
        }
        return null;
    }

    // Finds the '>' that closes a tag opening at s[openIdx] ('<'), returning -1 if what follows
    // openIdx isn't actually a well-formed tag.
    private static int FindTagEndForward(string s, int openIdx)
    {
        var j = openIdx + 1;
        while (j < s.Length && s[j] != '<' && s[j] != '>')
            j++;
        if (j >= s.Length || s[j] != '>')
            return -1;

        var k = openIdx + 1;
        if (k < j && s[k] == '/')
            k++;
        return k < j && char.IsLetter(s[k]) ? j : -1;
    }

    private static string ReplaceWithWordBoundarySpacing(string input, DictionaryEntry entry)
    {
        var raw = entry.Raw;
        var replacement = entry.Result ?? string.Empty;
        var sb = new System.Text.StringBuilder();
        var startIndex = 0;
        int idx;
        while ((idx = input.IndexOf(raw, startIndex, StringComparison.Ordinal)) >= 0)
        {
            sb.Append(input, startIndex, idx - startIndex);

            var prevChar = EffectiveTrailingCharInBuilder(sb);
            if (prevChar.HasValue && entry.ReplacementLeadChar.HasValue
                && char.IsLetterOrDigit(prevChar.Value) && char.IsLetterOrDigit(entry.ReplacementLeadChar.Value))
            {
                sb.Append(' ');
            }

            sb.Append(replacement);
            startIndex = idx + raw.Length;

            var nextChar = startIndex < input.Length ? EffectiveLeadingCharAt(input, startIndex) : null;
            if (entry.ReplacementTrailChar.HasValue && nextChar.HasValue
                && char.IsLetterOrDigit(entry.ReplacementTrailChar.Value) && char.IsLetterOrDigit(nextChar.Value))
            {
                sb.Append(' ');
            }
        }
        sb.Append(input, startIndex, input.Length - startIndex);
        return sb.ToString();
    }
}


