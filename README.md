# Themes.Maui — .NET MAUI App with MVVM, Flyout Navigation & Runtime Theme Switching

A modern, cross‑platform **.NET MAUI** application implementing clean MVVM architecture with **CommunityToolkit.Mvvm**, Shell-based **flyout navigation**, **runtime light/dark theme switching** with persisted state, and a **controls demo** page showcasing essential MAUI UI components.

---

## ✨ Features

- **MVVM with CommunityToolkit.Mvvm**
  - Source generators for [ObservableProperty], [RelayCommand], automatic INotifyPropertyChanged.
  - ViewModels created via DI.
- **Shell Flyout Navigation**
  - Home, Controls Demo, Settings pages.
- **Runtime Theme Switching**
  - Toggle Light/Dark; uses Preferences API for persistence.
- **Controls Demo Page**
  - Entry, Picker, Slider, Stepper, Switch, DatePicker, TimePicker, ActivityIndicator, ProgressBar, and more.

---

## 🧱 Project Structure

Themes.Maui/
├── App.xaml
├── App.xaml.cs
├── AppShell.xaml
├── AppShell.xaml.cs
├── Pages/
│   ├── HomePage.xaml
│   ├── ControlsDemoPage.xaml
│   ├── SettingsPage.xaml
├── ViewModels/
│   ├── HomeViewModel.cs
│   ├── ControlsDemoViewModel.cs
│   ├── SettingsViewModel.cs
├── Services/
│   ├── IThemeService.cs
│   ├── ThemeService.cs
└── Resources/
    ├── Styles/
    └── Themes/

---

## 🛠 Technologies

- .NET MAUI
- CommunityToolkit.Mvvm
- Preferences API
- Shell Navigation
- Dependency Injection

---

## 🚀 Running the Project

```bash
dotnet restore
dotnet build
dotnet maui run
```

Or run via Visual Studio using **F5**.

---

## 🧪 Supported Platforms

✔ Android
✔ iOS
✔ Windows
✔ macOS

---

## 📄 License
MIT License

---

