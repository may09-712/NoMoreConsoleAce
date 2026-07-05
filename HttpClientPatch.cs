using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace NoMoreConsole
{
    [HarmonyPatch(typeof(HttpClient), "GetByteArrayAsync", new Type[]
    {
        typeof(string)
    })]
    public class HttpClientPatch
    {
        
        [HarmonyPrefix]
        private static bool Prefix(string requestUri, ref Task<byte[]> __result)
        {
            bool flag = Enumerable.Any<string>(Constants.BlockedUrls, (string blocked) => requestUri.StartsWith(blocked));
            bool result;
            if (flag)
            {
                Debug.Log("[NoMoreConsole] Blocked " + requestUri);
                __result = Task.FromResult<byte[]>(new byte[0]);
                result = false;
            }
            else
            {
                result = true;
            }
            return result;
        }
    }
}
