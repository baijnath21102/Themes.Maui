using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Text;

namespace Themes.Maui.ViewModels
{

    public partial class HomeViewModel : ObservableObject
    {
        [RelayCommand]
        private async Task NavigateToControls() => await Shell.Current.GoToAsync("//controls");

        [RelayCommand]
        private async Task NavigateToSettings() => await Shell.Current.GoToAsync("//settings");
    }

}
