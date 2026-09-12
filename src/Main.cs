using LemonLoader;
using HarmonyLib;
using UnityEngine;

namespace PvZFusionMod
{
    public class PvZFusionUnlimitedMod : LemonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("PvZ Fusion Unlimited Mod loaded!");
            
            // Apply Harmony patches
            var harmony = new Harmony("com.pvzfusion.unlimited");
            harmony.PatchAll();
            
            LoggerInstance.Msg("Patches applied: Unlimited Suns + No Cooldown");
        }

        public override void OnLateInitializeMelon()
        {
            LoggerInstance.Msg("Mod initialization complete!");
        }
    }

    /// <summary>
    /// Patches for unlimited suns
    /// </summary>
    [HarmonyPatch]
    public class SunManagerPatches
    {
        // Patch the sun consumption/generation system
        [HarmonyPatch(typeof(SunManager), nameof(SunManager.ConsumeSun))]
        [HarmonyPrefix]
        public static bool PatchConsumeSun(SunManager __instance, int amount)
        {
            // Block sun consumption - players keep all suns
            return false;
        }

        // Ensure sun cap is removed
        [HarmonyPatch(typeof(SunManager), nameof(SunManager.AddSun))]
        [HarmonyPostfix]
        public static void PatchAddSun(SunManager __instance, int amount)
        {
            // Set suns to maximum (999999 or however high you want)
            if (__instance != null)
            {
                __instance.currentSuns = 999999;
            }
        }
    }

    /// <summary>
    /// Patches for no cooldown on plants
    /// </summary>
    [HarmonyPatch]
    public class PlantCooldownPatches
    {
        // Remove plant cooldown
        [HarmonyPatch(typeof(Plant), nameof(Plant.GetCooldownRemaining))]
        [HarmonyPrefix]
        public static bool PatchGetCooldown(Plant __instance, ref float __result)
        {
            // Always return 0 cooldown
            __result = 0f;
            return false;
        }

        // Patch the cooldown setter
        [HarmonyPatch(typeof(Plant), "SetCooldown")]
        [HarmonyPrefix]
        public static bool PatchSetCooldown(Plant __instance, float cooldownTime)
        {
            // Ignore all cooldown attempts
            return false;
        }

        // Patch plant ready state
        [HarmonyPatch(typeof(Plant), nameof(Plant.IsReady))]
        [HarmonyPostfix]
        public static void PatchIsReady(Plant __instance, ref bool __result)
        {
            // All plants are always ready to use
            __result = true;
        }
    }

    /// <summary>
    /// Patches for card cooldown (if using card system)
    /// </summary>
    [HarmonyPatch]
    public class CardCooldownPatches
    {
        [HarmonyPatch(typeof(Card), "UpdateCooldown")]
        [HarmonyPrefix]
        public static bool PatchCardCooldown(Card __instance)
        {
            // Skip cooldown updates for cards
            if (__instance != null)
            {
                __instance.cooldownRemaining = 0f;
            }
            return false;
        }
    }
}
