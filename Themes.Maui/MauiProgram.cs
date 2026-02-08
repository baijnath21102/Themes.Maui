using Microsoft.Extensions.Logging;
using Themes.Maui.Pages;
using Themes.Maui.Services;
using Themes.Maui.ViewModels;

namespace Themes.Maui
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            // Services
            builder.Services.AddSingleton<IThemeService, ThemeService>();

            // ViewModels
            builder.Services.AddTransient<HomeViewModel>();
            builder.Services.AddTransient<ControlsDemoViewModel>();
            builder.Services.AddTransient<SettingsViewModel>();

            // Pages
            builder.Services.AddTransient<HomePage>();
            builder.Services.AddTransient<ControlsDemoPage>();
            builder.Services.AddTransient<SettingsPage>();


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
