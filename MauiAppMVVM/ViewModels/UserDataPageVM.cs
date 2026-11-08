using MauiAppMVVM.Models;
using MauiAppMVVM.Services;

namespace MauiAppMVVM.ViewModels
{

    
    public class UserDataPageVM : VmBase, IQueryAttributable
    {
        IDataService data;
        //private string name;
        //private string password;
        //public string UserName
        //{
        //    get { return name; }
        //    set
        //    {
        //        if (name != value)
        //        {
        //            name = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
        //public string Password
        //{
        //    get { return password; }
        //    set
        //    {
        //        if (password != value)
        //        {
        //            password = value;
        //            OnPropertyChanged();
        //        }
        //    }
        //}
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

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
             User=(User)query["user"];
            Console.WriteLine(  "aa");
        }
    }
}
