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
    [HarmonyPatch(typeof(StartMenuController), nameof(StartMenuController.ShowStartMenu))]
    [HarmonyPostfix]
    private static void ShowStartMenu_Postfix(StartMenuController __instance)
    {
        try
        {
            if (__instance.heroFamilyName != null)
            {
                __instance.heroFamilyName.characterLimit = 10;
                //__instance.heroFamilyName.text = "Han"; <-- This must need something else
            }

            if (__instance.heroGivenName != null)
            {
                __instance.heroGivenName.characterLimit = 10;
                //__instance.heroGivenName.text = "Li";
            }
        }
        catch (System.Exception ex)
        {
            MainPlugin.Logger?.LogError($"NameLengthPatches: failed to clear name character limits.\n{ex}");
        }
    }
}
