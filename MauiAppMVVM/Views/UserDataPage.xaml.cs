using MauiAppMVVM.ViewModels;

namespace MauiAppMVVM.Views;

public partial class UserDataPage : ContentPage
{
	public UserDataPage(UserDataPageVM vm)
	{
		InitializeComponent();
        BindingContext = vm;
    }
}