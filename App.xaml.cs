using LoginApp.Maui.Models;

namespace LoginApp.Maui;
public partial class App : Application
{
    public static User user;
    public App()
    {
        InitializeComponent();

        MainPage = new AppShell();
    }
}