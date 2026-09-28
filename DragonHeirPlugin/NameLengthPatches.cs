using HarmonyLib;
using UnityEngine.UI;

namespace EnglishPatch;

/// <summary>
/// Removes the character-limit cap on the character-creation name fields
/// (StartMenuController.heroFamilyName/heroGivenName). The limit is a serialized
/// InputField.characterLimit value baked into the prefab/scene, not something set in code
/// (Converter/output/_NoNamespace/StartMenuController.cs has no character-limit logic at all),
/// so it can't be "patched out" of the decompiled source - it has to be overridden at runtime
/// instead. Postfixing ShowStartMenu (which runs every time the naming panel is shown) sets
/// both InputFields' characterLimit to 10.
/// </summary>
internal static class NameLengthPatches
{
    // [GameCoupled StartMenuController.ShowStartMenu logic] assumes it runs every time the naming panel opens
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ShowStartMenu))]
    [HarmonyPostfix]
    private static void ShowStartMenu_Postfix(StartMenuController __instance)
    {
        try
        {
            if (__instance.heroFamilyName != null)
                __instance.heroFamilyName.characterLimit = 10;

            if (__instance.heroGivenName != null)
                __instance.heroGivenName.characterLimit = 10;
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"NameLengthPatches: failed to clear name character limits.\n{ex}");
        }
    }

    // Force rename ("自立门户", ManageReplaceForceController): the name is two InputFields - base
    // name + force type, e.g. "仙霞" + "派" - with the same kind of prefab-baked characterLimit. The
    // panel prefills them by cutting the current force name after its 2nd character, and
    // SureReplaceForce saves forceSetName as a bare base + type concatenation. Both are fine for
    // Chinese but mangle English ("Ir" / "on Fist Sect" in, "Iron FistSect" out), so: raise both
    // limits, re-split a CJK-free prefill at its last space, and join CJK-free parts with a space.
    // The short battle-UI force tag that re-truncates forceSetName is handled in
    // HeroNamePatches.GetHeroForceLvDescribePostfix.
    private const int ForceBaseNameLimit = 20;
    private const int ForceTypeNameLimit = 12;

    // [GameCoupled ManageReplaceForceController.ShowManageReplaceForceUI logic] prefills base/type by cutting the name after 2 chars
    [HarmonyPatch(typeof(ManageReplaceForceController), nameof(ManageReplaceForceController.ShowManageReplaceForceUI))]
    [HarmonyPostfix]
    private static void ShowManageReplaceForceUI_Postfix(ManageReplaceForceController __instance)
    {
        try
        {
            var baseField = __instance.forceBaseName;
            var typeField = __instance.forceTypeName;
            if (baseField == null || typeField == null) return;

            baseField.characterLimit = ForceBaseNameLimit;
            typeField.characterLimit = ForceTypeNameLimit;

            // CJK checked first: the concatenation below goes through the global String.Concat
            // translation postfix, which is only a no-op for CJK-free text.
            var baseText = baseField.text ?? string.Empty;
            var typeText = typeField.text ?? string.Empty;
            if (DynamicStringPatches.ContainsCjk(baseText) || DynamicStringPatches.ContainsCjk(typeText)) return;

            var fullName = (baseText + typeText).Trim();
            var lastSpace = fullName.LastIndexOf(' ');
            if (lastSpace <= 0) return;

            baseField.text = fullName.Substring(0, lastSpace).TrimEnd();
            typeField.text = fullName.Substring(lastSpace + 1);
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"NameLengthPatches: failed to prepare force rename fields.\n{ex}");
        }
    }

    // [GameCoupled ManageReplaceForceController.SureReplaceForce logic] saves forceSetName as base.text + type.text with no separator
    [HarmonyPatch(typeof(ManageReplaceForceController), nameof(ManageReplaceForceController.SureReplaceForce))]
    [HarmonyPrefix]
    private static void SureReplaceForce_Prefix(ManageReplaceForceController __instance)
    {
        try
        {
            var baseField = __instance.forceBaseName;
            var typeField = __instance.forceTypeName;
            if (baseField == null || typeField == null) return;

            var baseText = baseField.text;
            var typeText = typeField.text;
            if (string.IsNullOrEmpty(baseText) || string.IsNullOrEmpty(typeText)) return;
            if (DynamicStringPatches.ContainsCjk(baseText) || DynamicStringPatches.ContainsCjk(typeText)) return;
            if (baseText.EndsWith(' ') || typeText.StartsWith(' ')) return;

            // InputField.text truncates to characterLimit, so make room for the added space.
            if (typeField.characterLimit > 0 && typeText.Length + 1 > typeField.characterLimit)
                typeField.characterLimit = typeText.Length + 1;
            typeField.text = " " + typeText;
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"NameLengthPatches: failed to space the force name.\n{ex}");
        }
    }
}
