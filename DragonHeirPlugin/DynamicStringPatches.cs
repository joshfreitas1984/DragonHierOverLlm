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
///   Converter --dynamic-string-candidates → review → merge into
///   Files/Raw/Dumped/DynamicStrings/dynamicStrings.txt → "1c. ExportDynamicStringsIntoTranslated"
///   → "2. MergeFilesIntoTranslated" → translate → "6. Package to Game Files" produces
///   Files/Mod/dynamicStrings.txt.yaml (flat `raw`/`result` list), deployed to
///   BepInEx\plugins\resources\ alongside the CSV overrides.
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

    private static List<DictionaryEntry> _dictionary = new();

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
        var literalSegments = new List<string>();
        var lastIndex = 0;
        var tokenIndex = 0;

        foreach (Match placeholder in PlaceholderOrTokenRegex.Matches(raw))
        {
            var literal = raw.Substring(lastIndex, placeholder.Index - lastIndex);
            if (literal.Length > 0)
            {
                patternBuilder.Append(Regex.Escape(literal));
                literalSegments.Add(literal);
            }

            if (placeholder.Groups[1].Success)
            {
                patternBuilder.Append($"(?<p{placeholder.Groups[1].Value}>{PlaceholderCaptureClass}+?)");
            }
            else
            {
                patternBuilder.Append($"(?<tok{tokenIndex}>{PlaceholderCaptureClass}+?)");
                tokenIndex++;
            }

            lastIndex = placeholder.Index + placeholder.Length;
        }

        var trailingLiteral = raw.Substring(lastIndex);
        if (trailingLiteral.Length > 0)
        {
            patternBuilder.Append(Regex.Escape(trailingLiteral));
            literalSegments.Add(trailingLiteral);
        }

        var replacementTokenIndex = 0;
        var replacementPattern = PlaceholderOrTokenRegex.Replace(entry.Result ?? string.Empty, m =>
        {
            if (m.Groups[1].Success) return $"${{p{m.Groups[1].Value}}}";
            var name = $"tok{replacementTokenIndex}";
            replacementTokenIndex++;
            return $"${{{name}}}";
        });

        return new CompiledTemplate
        {
            Pattern = new Regex(patternBuilder.ToString(), RegexOptions.Compiled),
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

    // Applied to every patched String.Concat/Format overload's result. _dictionary is expected to
    // stay small (low hundreds of entries at most), so an unconditional per-call scan is cheap
    // relative to the sheer call volume of String.Concat/Format in a running Unity game; skip
    // entirely when the dictionary is empty (e.g. before the pipeline has produced one yet).
    private static void GenericPostfix(ref string __result)
    {
        if (__result == null || _inFormatConcatPatch) return;

        _inFormatConcatPatch = true;
        try
        {
            var result = __result;
            if (_compiledTemplates.Count > 0)
                result = ApplyTemplates(result, _compiledTemplates);
            if (_dictionary.Count > 0)
                result = ApplyDictionary(result, _dictionary);
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
        if (format == null || _templateDictionary.Count == 0 || _inFormatConcatPatch) return;

        _inFormatConcatPatch = true;
        try
        {
            format = ApplyDictionary(format, _templateDictionary);
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

        try
        {
            var current = getText();
            if (string.IsNullOrEmpty(current)) return;

            var replaced = current;
            if (_compiledTemplates.Count > 0)
                replaced = ApplyTemplates(replaced, _compiledTemplates);
            if (_dictionary.Count > 0)
                replaced = ApplyDictionary(replaced, _dictionary);
            if (replaced == current) return;

            _inTextSetterPostfix = true;
            try { setText(replaced); }
            finally { _inTextSetterPostfix = false; }
        }
        catch (Exception ex)
        {
            MainPlugin.Logger.LogError($"[DynamicStringPatches] Text setter postfix failed: {ex}");
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

            if (!template.Pattern.IsMatch(result))
                continue;

            // See CompiledTemplate.BlockingRawEntries (CONFIRMED BUG #4) - captures the text at
            // the start of this template's pass so per-match overlap checks are computed against
            // a stable snapshot (Regex.Replace's MatchEvaluator runs against this same original
            // string for every match before any replacement is written back).
            var beforeThisTemplate = result;
            result = template.Pattern.Replace(result, m =>
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

    private static string ApplyDictionary(string input, List<DictionaryEntry> dictionary)
    {
        var result = input;
        foreach (var entry in dictionary)
        {
            if (string.IsNullOrEmpty(entry.Raw)) continue;
            if (result.Contains(entry.Raw))
                result = result.Replace(entry.Raw, entry.Result ?? string.Empty);
        }
        return result;
    }
}


