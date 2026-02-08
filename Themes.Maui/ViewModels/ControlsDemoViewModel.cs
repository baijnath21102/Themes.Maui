using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Themes.Maui.ViewModels
{
    public partial class ControlsDemoViewModel : ObservableObject
    {

        public ControlsDemoViewModel()
        {
            Cities = new ObservableCollection<string>(new[] { "Mumbai", "Pune", "Nagpur", "Nashik" });
            Volume = 50;
            Quantity = 1;
            SelectedDate = DateTime.Today;
            SelectedTime = DateTime.Now.TimeOfDay;
        }


        // Collections
        public ObservableCollection<string> Cities { get; }

        // Basic fields
        [ObservableProperty] private string name = string.Empty;
        [ObservableProperty] private string helloText = string.Empty;
        [ObservableProperty] private string? selectedCity;

        // Ranged values
        [ObservableProperty] private double volume;
        [ObservableProperty] private double quantity;

        // Toggles & pickers
        [ObservableProperty] private bool notificationsEnabled;
        [ObservableProperty] private DateTime selectedDate;
        [ObservableProperty] private TimeSpan selectedTime;


        // Work state
        [ObservableProperty] private bool isBusy;
        [ObservableProperty] private double progress;

        // --- Command logic ---

        // Say Hello
        private bool CanSayHello() => !string.IsNullOrWhiteSpace(Name);

        [RelayCommand(CanExecute = nameof(CanSayHello))]
        private void SayHello()
        {
            HelloText = $"Hello, {(!string.IsNullOrWhiteSpace(Name) ? Name.Trim() : "there")}!";
        }

        // Update CanExecute when Name changes
        partial void OnNameChanged(string value) => SayHelloCommand.NotifyCanExecuteChanged();

        // Show Selected City
        private bool CanShowCity() => SelectedCity is not null;


        [RelayCommand(CanExecute = nameof(CanShowCity))]
    private void ShowCity()
        {
            HelloText = SelectedCity is null ? "Please pick a city." : $"Selected city: {SelectedCity}";
        }

        // Update CanExecute when SelectedCity changes
        partial void OnSelectedCityChanged(string? value) => ShowCityCommand.NotifyCanExecuteChanged();

        // Simulate Work
        private bool CanSimulateWork() => !IsBusy;

        [RelayCommand(CanExecute = nameof(CanSimulateWork))]
        private async Task SimulateWorkAsync()
        {
            IsBusy = true;
            Progress = 0;
            for (int i = 1; i <= 10; i++)
            {
                await Task.Delay(150);
                Progress = i / 10.0;
            }
            IsBusy = false;
        }


        // Update CanExecute when IsBusy changes
        partial void OnIsBusyChanged(bool value) => SimulateWorkCommand.NotifyCanExecuteChanged();
    }

}
