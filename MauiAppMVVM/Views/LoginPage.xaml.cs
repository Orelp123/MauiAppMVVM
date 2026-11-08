

using MauiAppMVVM.Services;
using MauiAppMVVM.ViewModels;

namespace MauiAppMVVM.Views;

public partial class LoginPage : ContentPage
{
    
    public LoginPage(LoginPageVm vm)
    {
        InitializeComponent();
        BindingContext = vm;
    }

}