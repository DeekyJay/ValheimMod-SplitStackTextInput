namespace SplitStackTextInput.GameClasses
{
    using HarmonyLib;
    using SplitStackTextInput.SliderHelpers;

    [HarmonyPatch(typeof(InventoryGui), "OnSplitOk")]
    public static class InventoryGui_Patch_OnSplitOk_RemoveTextInput
    {
        private static void Prefix(ref InventoryGui __instance)
        {
            if (TextInput.IsVisible())
            {
                TextInput.instance.Hide();
                SliderTextReceiverInstance.Remove();
            }
        }
    }

    [HarmonyPatch(typeof(InventoryGui), "OnSplitCancel")]
    public static class InventoryGui_Patch_OnSplitCancel_RemoveTextInput
    {
        private static void Prefix(ref InventoryGui __instance)
        {
            if (TextInput.IsVisible())
            {
                TextInput.instance.Hide();
                SliderTextReceiverInstance.Remove();
            }
        }
    }
}
