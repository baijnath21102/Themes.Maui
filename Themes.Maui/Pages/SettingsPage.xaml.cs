using Themes.Maui.ViewModels;

namespace Themes.Maui.Pages;

public partial class SettingsPage : ContentPage
{
	public SettingsPage(SettingsViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
    }
}