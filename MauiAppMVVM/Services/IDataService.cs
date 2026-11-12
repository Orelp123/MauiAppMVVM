using MauiAppMVVM.Models;

namespace MauiAppMVVM.Services
{
    public interface IDataService
    {
        public bool IsRegister(string username, string password);

        public bool IsExist(string username);


        public void Register(string username, string password);

        public string GetAllUsers();

        public List<User> GetUsers();

    }
}
