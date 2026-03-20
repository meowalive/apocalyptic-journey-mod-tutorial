using Witch.Mod;
using UnityEngine;
using Witch.UI.Window;

namespace DllTemplate;

public static class DllTemplate
{
    [ModInitialize]
    public static void Entry(ModConfig modConfig)
    {
        Commands.Log("DllTemplate", "DllTemplate生效");
    }
}

class Patch
{
    [HookBefore(typeof(SettingUI), nameof(SettingUI.OnEnable))]
    public static void OnEnable(SettingUI __instance)
    {
        Commands.Log("DllTemplate", "OnEnable");
    }
}
