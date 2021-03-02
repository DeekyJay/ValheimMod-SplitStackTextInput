namespace SplitStackTextInput.GameClasses
{
    using HarmonyLib;
    using SplitStackTextInput.SliderHelpers;
    using UnityEngine.EventSystems;
    using UnityEngine.UI;


    [HarmonyPatch(typeof(Slider), "OnPointerDown")]
    public static class Slider_OnPointerDown_RightClickSpawnTextInput
    {
        private static void Prefix(ref Slider __instance, PointerEventData eventData)
        {
            if (TextInput.IsVisible())
            {
                TextInput.instance.Hide();
                SliderTextReceiverInstance.Remove();
            }

            if (eventData.button == PointerEventData.InputButton.Right)
            {
                var receiver = SliderTextReceiverInstance.Create(__instance);
                TextInput.instance.RequestText(receiver, "Enter Amount", __instance.maxValue.ToString().Length);
            }    
        }
    }
}
