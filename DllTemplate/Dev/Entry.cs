using Witch.Mod;
using UnityEngine;

namespace DllTemplate;

public static class DllTemplate
{
    [ModInitialize]
    public static void Entry(ModConfig modConfig)
    {
        Debug.Log("DllTemplate生效！！！");
    }
}
