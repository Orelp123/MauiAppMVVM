using MauiAppMVVM.Models;
using MauiAppMVVM.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace MauiAppMVVM.ViewModels
{
    public class UserListVM : VmBase
    {
        IDataService data;
        private string name;
        private string password;
        List<User> userslist;
        ObservableCollection<User> users;

        private User user;
        private string displayUser;

        public User User
        {
            get { return user; }
            set
            {
                user = value;
                OnPropertyChanged();
                //ShowUserData();
            }
        }
        public ICommand ShowUserDataCommand
        {
            get;
        }
        //public ICommand ShowListCommand
        //{
        //    get;
        //}
        //public ICommand Delete

        //private void ShowUserData()
        //{
        //    DisplayUser = User.Name + " - " + User.Password;
        //}
        public ObservableCollection<User> Users
        {
            get; set;
        }
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
        public string DisplayUser
        {
            get { return displayUser; }
            set
            {
                if (displayUser != value)
                {
                    displayUser = value;
                    OnPropertyChanged();
                }
            }

        }
       

        

        public UserListVM(IDataService db)
        {
            
            data = db;
            userslist = data.GetUsers();
            Users = new ObservableCollection<User>(userslist);
            User = userslist[1];
            ShowUserDataCommand = new Command<User>(async p => ShowUser(p));
            
            
        }
        private async Task ShowUser(User p)
        {
            Dictionary<string, object> data2 = new Dictionary<string, object>();
            data2.Add("user", p);
            await Shell.Current.GoToAsync("UserData", data2);
            // displayUser = p.Name + " - " + p.Password;

        }
    }
}
