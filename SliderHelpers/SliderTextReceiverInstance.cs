namespace SplitStackTextInput.SliderHelpers
{
    using UnityEngine.UI;

    public class SliderTextReceiverInstance
    {
        private static SliderTextReceiver receiver;

        public static SliderTextReceiver Create(Slider slider)
        {
            receiver = new SliderTextReceiver(slider);
            return receiver;
        }

        public static SliderTextReceiver Get()
        {
            return receiver;
        }

        public static void Remove()
        {
            receiver = null;
        }
    }
}