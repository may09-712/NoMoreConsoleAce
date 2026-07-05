using System;
using System.Linq;
using HarmonyLib;
using UnityEngine;
using UnityEngine.Networking;

namespace NoMoreConsole
{
    [HarmonyPatch(typeof(UnityWebRequest), "SendWebRequest")]
    public class UnityWebRequestPatch
    {
        [HarmonyPrefix]
        private static bool Prefix(UnityWebRequest __instance)
        {
            bool flag = Enumerable.Any<string>(Constants.BlockedUrls, (string blocked) => __instance.url.StartsWith(blocked));
            if (flag)
            {
                Debug.Log("[NoMoreConsole] Blocked " + __instance.url);
                __instance.url = null;
            }
            return true;
        }
    }
}
