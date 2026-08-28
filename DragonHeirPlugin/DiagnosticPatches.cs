using System;
using System.Reflection;
using System.Text;
using HarmonyLib;

namespace EnglishPatch;

/// <summary>
/// Ground-truth diagnostic aid for the still-unresolved ResetFaceSetting/ResetPlayerTag crash
/// (see .github/instructions/dragonheirplugin.instructions.md, "Post-resource-load errors"
/// section and its corrections). Static analysis of the decompiled pseudocode
/// (Converter/output/_NoNamespace/StartMenuController.cs) could not pin down which field is
/// being indexed out of range: the loop bound and the indexed list come from two DIFFERENT
/// pointer chains (`DAT_181d81570`'s statics pointer for the bound vs. `GameDataController`'s
/// instance for the actual index), and our decompiler currently can't resolve either chain to a
/// real field name (see Converter instructions for the specific limitation). Rather than keep
/// guessing from pseudocode, this Harmony Prefix logs every public instance field on the live
/// GameDataController singleton (name, declared type, and Count when the value is some kind of
/// collection) immediately BEFORE the original method body runs, so the next crash's log capture
/// gives us real field names/counts instead of another round of offset arithmetic. Remove once
/// the actual out-of-range field is identified and the real fix is in place (this is pure
/// logging - it does not change behavior).
/// </summary>
internal static class DiagnosticPatches
{
    //[HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetFaceSetting))]
    //[HarmonyPrefix]
    //private static void ResetFaceSetting_Prefix()
    //{
    //    DumpGameDataController("ResetFaceSetting");
    //}

    //[HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ResetPlayerTag))]
    //[HarmonyPrefix]
    //private static void ResetPlayerTag_Prefix()
    //{
    //    DumpGameDataController("ResetPlayerTag");
    //}

    /// <summary>
    /// Diagnostic aid for an ArgumentOutOfRangeException seen in Player.log at
    /// GameController.GenerateHero -&gt; StartNewGame -&gt; Start (fully stripped stack trace, no
    /// line numbers). The known label-lookup fixes for HeroData.RandomAttriAndSkill
    /// (SpeHeroData.csv columns 11/12/18, ForceData.csv columns 9/10/11 - see
    /// Tests/GameFileHandling.cs) are already confirmed present in the packaged Files/Mod/*.csv,
    /// so this is a DIFFERENT crash. Static analysis of the decompiled pseudocode
    /// (Converter/output/_NoNamespace/GameController.cs's GenerateHero body) found a hardcoded
    /// ThrowArgumentOutOfRangeException tied to per-force/per-chapter-tier hero-count bookkeeping
    /// built from `this.worldData.Forces`, but the exact field/count involved could not be
    /// resolved with confidence (heavy local-variable reuse across the decompiled body - the same
    /// `lVarN` name gets reassigned dozens of times). Rather than keep guessing from pseudocode,
    /// this Prefix dumps `worldData.Forces.Count` plus every public field/property on each Force
    /// entry (name/count for collection-typed members) immediately BEFORE GenerateHero runs, so
    /// the next crash's log capture gives us real field names/counts instead of another round of
    /// offset arithmetic. Remove once the actual out-of-range field is identified and the real fix
    /// is in place (this is pure logging - it does not change behavior).
    /// </summary>
    [HarmonyPatch(typeof(GameController), nameof(GameController.GenerateHero))]
    [HarmonyPrefix]
    private static void GenerateHero_Prefix(GameController __instance)
    {
        try
        {
            var worldData = __instance?.worldData;
            if (worldData == null)
            {
                MainPlugin.Logger?.LogWarning("DiagnosticPatches[GenerateHero]: worldData is null");
                return;
            }

            var forces = worldData.Forces;
            if (forces == null)
            {
                MainPlugin.Logger?.LogWarning("DiagnosticPatches[GenerateHero]: worldData.Forces is null");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"DiagnosticPatches[GenerateHero]: worldData.Forces.Count = {forces.Count}");

            int index = 0;
            foreach (var force in forces)
            {
                sb.AppendLine($"  Force[{index}]: {DumpMembersOneLine(force)}");
                index++;
            }

            MainPlugin.Logger?.LogInfo(sb.ToString());
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GenerateHero]: failed to dump worldData.Forces: {ex}");
        }
    }

    /// <summary>
    /// Diagnostic aid for the still-unresolved GenerateHero crash now that a captured log
    /// showed the exception is caught at GenerateHero_Finalizer (NOT UpgradeSkill_Finalizer) -
    /// meaning this occurrence takes a code path that never reaches GameController.UpgradeSkill.
    /// Static analysis of the decompiled pseudocode (Converter/output/_NoNamespace/GameController.cs
    /// GenerateHero body, ~line 7100-7150) found a shorter "custom/free game" setup path (gated by
    /// GameDataController.playerPrefData == 1) that calls HeroData.GetSkill(player, new
    /// KungfuSkillLvData(9), ...) and then immediately does a raw, unresolved indexer call
    /// (FUN_180002f80) using `player.kungfuSkills.Count - 1` as the index BEFORE UpgradeSkill is
    /// invoked - that indexer call is the likely real throw site, but the decompiler couldn't
    /// resolve it to a named/patchable method. HeroData.GetSkill is the last real, hookable call
    /// before that point, so this Postfix logs the hero's kungfuSkills.Count immediately after it
    /// runs. If the next crash log capture stops right after one of these lines instead of
    /// showing more of them, that identifies the failing hero/count pair for the real fix.
    /// Extended (per repo-memory plan correction: no Mono.Cecil/static-DLL tooling against
    /// IL2CPP - ground truth must come from runtime reflection) to also dump every public
    /// field/property on the live HeroData instance itself via DumpMembersOneLine, since the
    /// unresolved indexer likely reads a List-typed field ON HeroData (not GameDataController) -
    /// this full dump is the best chance of spotting the real field/count by name in a live
    /// capture. Paired with AICheckSkill_Postfix below to bracket the risky block. Pure logging -
    /// does not change behavior. Remove once the actual out-of-range indexer is identified and
    /// fixed.
    /// </summary>
    [HarmonyPatch(typeof(HeroData), nameof(HeroData.GetSkill))]
    [HarmonyPostfix]
    private static void GetSkill_Postfix(HeroData __instance, KungfuSkillLvData skillLvData)
    {
        try
        {
            var kungfuSkills = __instance?.kungfuSkills;
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[HeroData.GetSkill]: heroID={__instance?.heroID}, heroName={__instance?.heroName}, " +
                $"kungfuSkills.Count={(kungfuSkills == null ? "null" : kungfuSkills.Count.ToString())}, " +
                $"skillLvData={(skillLvData == null ? "null" : DumpMembersOneLine(skillLvData))}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[HeroData.GetSkill]: failed to dump hero: {ex}");
        }
    }

    /// <summary>
    /// Bracket patch for the still-unresolved crash #2 (see GetSkill_Postfix's remarks above and
    /// the repo-memory plan). UPDATED after a real capture showed AICheckSkill IS reached
    /// (heroID=1, "Jiang Yingquan", a speHero) with the crash immediately after - decompiled
    /// analysis (Converter/output/_NoNamespace/GameController.cs) found this call is actually the
    /// LAST statement in GameController.RandomGenerateNPCSkill(HeroData hero), which then
    /// `return`s straight back to its caller, GenerateHeroData - so the crash is NOT here, it's
    /// somewhere in GenerateHeroData's code that runs right after RandomGenerateNPCSkill returns
    /// (CountHeroData -> RandomGenerateNPCItem -> CountHeroData again, per all 3
    /// GenerateHeroData overloads). See the new bracket patches below on those methods. Logs when
    /// this call is actually reached for a given hero. Pure logging - does not change behavior.
    /// Remove once the actual out-of-range indexer is identified and fixed.
    /// </summary>
    [HarmonyPatch(typeof(AIController), nameof(AIController.AICheckSkill))]
    [HarmonyPostfix]
    private static void AICheckSkill_Postfix(HeroData hero)
    {
        try
        {
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[AIController.AICheckSkill]: reached for heroID={hero?.heroID}, heroName={hero?.heroName}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[AIController.AICheckSkill]: failed to dump hero: {ex}");
        }
    }

    /// <summary>
    /// Bracket patch #2 for crash #2: GameController.CountHeroData(HeroData) is called twice
    /// right after RandomGenerateNPCSkill returns (see AICheckSkill_Postfix's remarks). If a
    /// crash capture shows "AICheckSkill" for a hero with NO matching "CountHeroData" line right
    /// after, the throw is confirmed to be inside CountHeroData's own body (a long method with
    /// many ForceSpeAddData.Get(...) indexed accesses - see GameController.cs ~line 13452) rather
    /// than in code between the two calls. Pure logging - does not change behavior. Remove once
    /// the actual out-of-range indexer is identified and fixed.
    /// </summary>
    [HarmonyPatch(typeof(GameController), nameof(GameController.CountHeroData))]
    [HarmonyPostfix]
    private static void CountHeroData_Postfix(HeroData hero)
    {
        try
        {
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[GameController.CountHeroData]: reached for heroID={hero?.heroID}, heroName={hero?.heroName}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.CountHeroData]: failed to dump hero: {ex}");
        }
    }

    /// <summary>
    /// Mitigation for a NullReferenceException inside GameController.CountHeroData (a long
    /// method chasing HeroSpeAddData/ForceSpeAddData/KungfuSkillLvData/equipment-slot pointer
    /// chains) that was observed crashing a plot-triggered fight
    /// (PlotController.FightInteractHeroFuc -&gt; BattleController.PrepareBattleMap -&gt;
    /// BattleTeamPrepare -&gt; HeroData.CheckHeroDetailDirty -&gt; CountHeroData). Same root-cause
    /// class as the previously-fixed GenerateHero/world-gen crash (a translated CSV column being
    /// used as an internal dictionary lookup key - see
    /// DragonHeirPlugin's KNOWN_ISSUES.md and Tests/docs/generatehero-unresolved-crash.md), just
    /// triggered here by a different hero. Logs and swallows the exception (dumping the hero's
    /// fields) rather than crashing the fight - narrow blast radius: only this hero's stat
    /// recompute is skipped for this call, not the whole fight.
    ///
    /// IMPORTANT: per the decompiled body (Converter/output/_decompiled/_NoNamespace/
    /// GameController/CountHeroData.c), hero.heroDetailDirty (offset +0x2d8) is ONLY cleared on
    /// the method's single successful-completion path, right before its one `return;` - every
    /// other path (all the null-guard checks throughout this long method) jumps to a
    /// "does not return" throw helper instead, meaning the flag is NEVER cleared when this method
    /// throws. HeroData.CheckHeroDetailDirty only calls CountHeroData when heroDetailDirty is
    /// true, so if we merely swallow the exception without clearing the flag ourselves, every
    /// subsequent CheckHeroDetailDirty call for this hero re-triggers CountHeroData -&gt; throws
    /// -&gt; gets suppressed again, forever (observed as an infinite loop/hang during the fight
    /// scene). Must clear hero.heroDetailDirty = false here to let the caller make progress.
    /// </summary>
    [HarmonyPatch(typeof(GameController), nameof(GameController.CountHeroData))]
    [HarmonyFinalizer]
    private static Exception CountHeroData_Finalizer(HeroData hero, Exception __exception)
    {
        if (__exception == null)
            return null;

        try
        {
            MainPlugin.Logger?.LogError(
                $"DiagnosticPatches[GameController.CountHeroData]: threw and was suppressed for " +
                $"heroID={hero?.heroID}, heroName={hero?.heroName}.\n" +
                $"  hero dump: {(hero == null ? "null" : DumpMembersOneLine(hero))}\n{__exception}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.CountHeroData]: failed to dump hero on exception: {ex}");
        }

        try
        {
            // Must clear this ourselves - the real method never reaches its own
            // "heroDetailDirty = false" assignment when it throws (see remarks above), so
            // CheckHeroDetailDirty would otherwise keep re-invoking CountHeroData for this hero
            // forever, looking like an infinite loop/hang.
            if (hero != null)
                hero.heroDetailDirty = false;
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.CountHeroData]: failed to clear heroDetailDirty: {ex}");
        }

        return null;
    }

    /// <summary>
    /// Bracket patch #3 for crash #2: GameController.RandomGenerateNPCItem(HeroData) is the next
    /// real call after the first CountHeroData following RandomGenerateNPCSkill (see
    /// CountHeroData_Postfix's remarks). Same reasoning: pinpoints whether the throw is inside
    /// this method's own body vs. elsewhere. Pure logging - does not change behavior. Remove once
    /// the actual out-of-range indexer is identified and fixed.
    /// </summary>
    [HarmonyPatch(typeof(GameController), nameof(GameController.RandomGenerateNPCItem))]
    [HarmonyPostfix]
    private static void RandomGenerateNPCItem_Postfix(HeroData hero)
    {
        try
        {
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[GameController.RandomGenerateNPCItem]: reached for heroID={hero?.heroID}, heroName={hero?.heroName}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.RandomGenerateNPCItem]: failed to dump hero: {ex}");
        }
    }

    

    private static void LogGenerateHeroDataExtra(
        string overloadTag, GameController instance, int belongForceID, float heroForceLv, HeroData heroDataBase)
    {
        try
        {
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[GameController.GenerateHeroData]({overloadTag} extra): " +
                $"Forces.Count={instance?.worldData?.Forces?.Count.ToString() ?? "null"}, " +
                $"belongForceID(param)={belongForceID}, heroForceLv(param)={heroForceLv}\n" +
                $"  heroDataBase dump: {(heroDataBase == null ? "null" : DumpMembersOneLine(heroDataBase))}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.GenerateHeroData]({overloadTag} extra): failed to dump: {ex}");
        }
    }

    private static void LogGenerateHeroDataReturned(HeroData result)
    {
        try
        {
            MainPlugin.Logger?.LogInfo(
                $"DiagnosticPatches[GameController.GenerateHeroData]: returned heroID={result?.heroID}, heroName={result?.heroName}");
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[GameController.GenerateHeroData]: failed to dump result: {ex}");
        }
    }

    /// <summary>
    /// Reflects over an object's public fields and properties and renders them as a single
    /// "Name=Value, Name2=Value2, ..." line using <see cref="DescribeValue"/> for each value.
    /// Never throws - reused by any diagnostic patch that needs a compact per-item dump.
    /// Internal (not private) so other diagnostic patches can reuse it too.
    /// </summary>
    internal static string DumpMembersOneLine(object obj)
    {
        if (obj == null)
            return "null";

        var parts = new System.Collections.Generic.List<string>();
        foreach (var field in obj.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
        {
            try
            {
                parts.Add($"{field.Name}={DescribeValue(field.GetValue(obj))}");
            }
            catch (Exception ex)
            {
                parts.Add($"{field.Name}=<error: {ex.Message}>");
            }
        }
        foreach (var prop in obj.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
        {
            if (prop.GetIndexParameters().Length > 0) continue;
            try
            {
                parts.Add($"{prop.Name}={DescribeValue(prop.GetValue(obj))}");
            }
            catch (Exception ex)
            {
                parts.Add($"{prop.Name}=<error: {ex.Message}>");
            }
        }

        return string.Join(", ", parts);
    }

    private static void DumpGameDataController(string context)
    {
        try
        {
            var gdc = GameDataController.Instance;
            if (gdc == null)
            {
                MainPlugin.Logger?.LogWarning($"DiagnosticPatches[{context}]: GameDataController.Instance is null");
                return;
            }

            var sb = new StringBuilder();
            sb.AppendLine($"DiagnosticPatches[{context}]: dumping GameDataController instance fields/properties before original method runs:");

            // Plain reflection over the wrapper instance's public fields AND properties - not a
            // generic Il2Cpp interop call (Cast<T>/TryCast<T>), so this is safe per the interop
            // rules in this file's own instructions doc. NOTE: a first pass here that only
            // checked GetFields() found zero members - this interop build (be.785) exposes
            // GameDataController's members as public PROPERTIES, not fields, unlike what the
            // decompiled pseudocode's `public List<...> fieldName;` declarations suggest. Always
            // check both when reflecting over an interop wrapper type.
            int memberCount = 0;
            foreach (var field in gdc.GetType().GetFields(BindingFlags.Public | BindingFlags.Instance))
            {
                memberCount++;
                try
                {
                    var value = field.GetValue(gdc);
                    sb.AppendLine($"  [field] {field.FieldType.Name} {field.Name} = {DescribeValue(value)}");
                }
                catch (Exception fieldEx)
                {
                    sb.AppendLine($"  [field] {field.FieldType.Name} {field.Name} = <error reading: {fieldEx.Message}>");
                }
            }
            foreach (var prop in gdc.GetType().GetProperties(BindingFlags.Public | BindingFlags.Instance))
            {
                if (prop.GetIndexParameters().Length > 0) continue; // skip indexers
                memberCount++;
                try
                {
                    var value = prop.GetValue(gdc);
                    sb.AppendLine($"  [prop]  {prop.PropertyType.Name} {prop.Name} = {DescribeValue(value)}");
                }
                catch (Exception propEx)
                {
                    sb.AppendLine($"  [prop]  {prop.PropertyType.Name} {prop.Name} = <error reading: {propEx.Message}>");
                }
            }

            if (memberCount == 0)
                sb.AppendLine("  <no public instance fields or properties found via reflection>");

            MainPlugin.Logger?.LogInfo(sb.ToString());
        }
        catch (Exception ex)
        {
            MainPlugin.Logger?.LogError($"DiagnosticPatches[{context}]: failed to dump GameDataController: {ex}");
        }
    }

    /// <summary>
    /// Describes a field value concisely: for anything with a public Count property (List, 
    /// Dictionary, Il2Cpp collections, etc.) logs the runtime type + Count; otherwise falls back
    /// to ToString(). Never throws - callers already wrap per-field access in try/catch too.
    /// </summary>
    private static string DescribeValue(object value)
    {
        if (value == null)
            return "null";

        var countProp = value.GetType().GetProperty("Count");
        if (countProp != null)
        {
            try
            {
                var count = countProp.GetValue(value);
                return $"<{value.GetType().Name}> Count={count}";
            }
            catch
            {
                // Fall through to ToString() below.
            }
        }

        return value.ToString();
    }
}
