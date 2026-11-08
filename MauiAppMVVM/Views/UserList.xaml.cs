using MauiAppMVVM.ViewModels;

namespace MauiAppMVVM.Views;

public partial class UserList : ContentPage
{
	public UserList(UserListVM vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
}