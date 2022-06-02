
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IAccountService
    {
        List<AccountModel> GetAccountsByUserId(int userId);
        void CreateAccount(AccountModel newAccount);
        void UpdateAccount(AccountModel newAccount); 
        void DeleteAccount(int accountId);
    }
}
