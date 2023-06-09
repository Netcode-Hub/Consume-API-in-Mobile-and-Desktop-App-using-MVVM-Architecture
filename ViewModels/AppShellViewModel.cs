
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace LoginApp.Maui.ViewModels;

public partial class AppShellViewModel : ObservableObject
{
    [RelayCommand]
    async void Logout()
    {
        if (Preferences.ContainsKey(nameof(App.user)))
        {
            Preferences.Remove(nameof(App.user));
        }
        await Shell.Current.GoToAsync("..");
    }
}
