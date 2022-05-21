using FinancasAPI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Domain.Interfaces.IRepositories
{
    public interface IAccountRepository
    {
        List<AccountModel> GetAllAccount();
        AccountModel GetAccountById(int accountId);
        void CreateAccount(AccountModel newAccount);
        void UpdateAccount(AccountModel newAccount);
        void DeleteAccount(AccountModel newAccount);
    }
}
