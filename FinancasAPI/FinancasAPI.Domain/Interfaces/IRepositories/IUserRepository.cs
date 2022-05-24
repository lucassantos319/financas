using FinancasAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Domain.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        List<UserModel> GetAllAccount();
        UserModel GetAccountById(int usersId);
        void CreateAccount(UserModel newUser);
        void UpdateAccount(UserModel user);
        void DeleteAccount(UserModel user);
        bool ValidateEmail(string email);
    }
}
