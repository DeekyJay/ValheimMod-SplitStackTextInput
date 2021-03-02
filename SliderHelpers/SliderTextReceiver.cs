namespace SplitStackTextInput.SliderHelpers
{
    using UnityEngine.UI;

    public class SliderTextReceiver : TextReceiver
    {
        private Slider slider;

        public SliderTextReceiver(Slider slider)
        {
            this.slider = slider;
        }

        public string GetText()
        {
            return slider.value.ToString();
        }

        public void SetText(string text)
        {
            if (float.TryParse(text, out float result) && result > 0 && result < this.slider.maxValue)
            {
                this.slider.value = result;
            }
        }
    }
}