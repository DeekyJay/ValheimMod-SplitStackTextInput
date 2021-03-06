﻿namespace SplitStackTextInput
{
    using BepInEx;
    using HarmonyLib;
    using SplitStackTextInput.Configuration;

    [BepInPlugin("io.deek.plugins.splitstacktextinput", "Split Stack Text Input", "1.0.0.0")]
    [BepInProcess("valheim.exe")]
    public class SplitStactTextInputPlugin : BaseUnityPlugin
    {
        void Awake()
        {
            ConfigurationManager.Load(Config);
            var harmony = new Harmony("io.deek.plugins.splitstacktextinput");
            harmony.PatchAll();
        }
    }
}
