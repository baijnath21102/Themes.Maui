using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Text;
using Themes.Maui.Services;

namespace Themes.Maui.ViewModels;


public partial class SettingsViewModel : ObservableObject
{
    private readonly IThemeService _themeService;

    [ObservableProperty] private bool isDarkMode;
    [ObservableProperty] private string themeStatus = string.Empty;

    public SettingsViewModel(IThemeService themeService)
    {
        _themeService = themeService;

        var current = _themeService.GetTheme(); // "light" | "dark"
        isDarkMode = string.Equals(current, "dark", StringComparison.OrdinalIgnoreCase);
        UpdateStatus(current);
    }

    partial void OnIsDarkModeChanged(bool value)
    {
        var theme = value ? "dark" : "light";
        _themeService.SetTheme(theme);
        UpdateStatus(theme);
    }

    private void UpdateStatus(string theme) => ThemeStatus = $"Current theme: {theme.ToUpperInvariant()}";
}
