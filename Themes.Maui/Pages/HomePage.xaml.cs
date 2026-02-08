using Themes.Maui.ViewModels;

namespace Themes.Maui.Pages;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
        BindingContext = new HomeViewModel();
    }
}