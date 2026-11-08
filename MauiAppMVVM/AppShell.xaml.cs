using MauiAppMVVM.Views;

namespace MauiAppMVVM
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            RegisterPages();
        }
        private void RegisterPages()
        {
            Routing.RegisterRoute("UserData", typeof(UserDataPage));
        }
    }
}
