namespace SplitStackTextInput.Configuration
{
    using BepInEx.Configuration;

    public static class ConfigurationManager
    {
        public static ConfigEntry<bool> UseSliderRightClick;

        public static void Load(ConfigFile config)
        {
            UseSliderRightClick = config.Bind(
                section: "General",
                key: "TextInputOnSliderRightClick",
                defaultValue: false,
                description: "Like the original behavior, enable this if you want to right click on the slider in order to trigger the text input."
                );
        }
    }
}
