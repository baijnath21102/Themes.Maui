using System;
using System.Collections.Generic;
using System.Text;

namespace Themes.Maui.Services
{
    public interface IThemeService
    {
        void InitializeTheme();         // Apply saved theme on app launch
        void SetTheme(string theme);    // "light" | "dark" | (optionally "system")
        string GetTheme();
    }

}
