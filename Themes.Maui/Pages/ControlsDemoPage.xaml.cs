using Themes.Maui.ViewModels;

namespace Themes.Maui.Pages;

public partial class ControlsDemoPage : ContentPage
{
	public ControlsDemoPage()
	{
		InitializeComponent();
        BindingContext = new ControlsDemoViewModel();
    }
}