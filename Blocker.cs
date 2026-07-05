using System;
using BepInEx;
using HarmonyLib;
using UnityEngine;

namespace NoMoreConsole
{
    [BepInPlugin("Ace.Console.Blocker.NoMoreConsole", "NoMoreConsole", "1.0.0")]
    public class Blocker : BaseUnityPlugin
    {
        public void Awake()
        {
            Harmony harmony = new Harmony("Ace.NoMoreConsole");
            harmony.PatchAll();
            Debug.Log("[NoMoreConsole] Initialized");
        }
    }
}
