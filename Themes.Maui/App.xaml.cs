using Microsoft.Extensions.DependencyInjection;
using Themes.Maui.Services;

namespace Themes.Maui
{
    public partial class App : Application
    {
        private readonly IThemeService _themeService;

        public App(IThemeService themeService)
        {
            InitializeComponent();
            _themeService = themeService;
            _themeService.InitializeTheme();   // Apply saved theme

            MainPage = new AppShell();
        }
    }
}