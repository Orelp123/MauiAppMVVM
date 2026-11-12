using MauiAppMVVM.Services;
using System.Windows.Input;

namespace MauiAppMVVM.ViewModels
{
    public class LoginPageVm : VmBase
    {
        IDataService db;
        private Task loadUserName;
        private string name;
        private string password;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    name = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return password; }
            set
            {
                if (password != value)
                {
                    password = value;
                    OnPropertyChanged();
                }
            }
        }

        private bool messangevisible;

        public bool MessagesVisible
        {
            get { return messangevisible; }
            set
            {
                if (messangevisible != value)
                {
                    messangevisible = value;
                    OnPropertyChanged();
                }
            }
        }

        private string messageError;

        public string MessageError
        {
            get { return messageError; }
            set
            {
                if (messageError != value)
                {
                    messageError = value;
                    OnPropertyChanged();
                }
            }

        }

        private Color messagesColor;

        public Color MessagesColor
        {
            get { return messagesColor; }
            set
            {
                if (messagesColor != value)
                {
                    messagesColor = value;
                    OnPropertyChanged();
                }
            }
        }
        public ICommand LoginCommand
        {
            get;
        }
        public LoginPageVm(IDataService data)
        {
            db = data;
            LoginCommand = new Command(async () => await Login());
            loadUserName = LoadUserasync();




        }
        private async Task? LoadUserasync()
        {
            Name = await SecureStorage.Default.GetAsync("userName");
            Password = await SecureStorage.Default.GetAsync("password");
        }
     

        private async Task Login()
        {
            MessagesVisible = true;
           await Task.Delay(1000);
            if (db.IsRegister(Name, Password) == true)
            {

                await SecureStorage.Default.SetAsync("userName", Name);
                await SecureStorage.Default.SetAsync("password", Password);
                MessageError = "you are in";
                MessagesColor = Colors.Green;
                
            }
            else
            {
                MessageError = "login fail";
                MessagesColor = Colors.Red;
            }
           
        }
    }
}
