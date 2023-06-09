using LoginApp.Maui.ViewModels;

namespace LoginApp.Maui;

public partial class LoginPage : ContentPage
{
	public LoginPage(LoginPageViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}