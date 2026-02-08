using System;
using System.Collections.Generic;
using System.Text;

namespace Themes.Maui.Services
{
    public sealed class ThemeService : IThemeService
    {
        private const string ThemeKey = "theme";
        private const string DefaultTheme = "light";

        public void InitializeTheme()
        {
            var theme = Preferences.Get(ThemeKey, DefaultTheme);
            ApplyTheme(theme);
        }

        public void SetTheme(string theme)
        {
            ApplyTheme(theme);
            Preferences.Set(ThemeKey, theme);
        }

        public string GetTheme() => Preferences.Get(ThemeKey, DefaultTheme);

        private static void ApplyTheme(string theme)
        {
            if (Application.Current is null) return;
            Application.Current.UserAppTheme = theme?.ToLowerInvariant() switch
            {
                "dark" => AppTheme.Dark,
                "light" => AppTheme.Light,
                // "system" => AppTheme.Unspecified,
                _ => AppTheme.Light
            };
        }
    }

}
