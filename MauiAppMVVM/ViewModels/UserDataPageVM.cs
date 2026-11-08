using MauiAppMVVM.Models;
using MauiAppMVVM.Services;
using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;

namespace MauiAppMVVM.ViewModels
{

    [QueryProperty(nameof(User), "user")]
    public class UserDataPageVM : VmBase
    {
        IDataService data;
        private string name;
        private string password;
        public string UserName
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
        private User user;
        public User User
        {
            get { return user; }
            set
            {
                if (user != null)
                {
                    user = value;
                    OnPropertyChanged();
                }
               
              
            }
        }
        public UserDataPageVM(IDataService db)
        {
            data = db;
        }
    }
}
