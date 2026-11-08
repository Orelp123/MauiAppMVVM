using MauiAppMVVM.ViewModels;

namespace MauiAppMVVM.Views;

public partial class RegisterPage : ContentPage
{
	public RegisterPage(RegisterPageVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}