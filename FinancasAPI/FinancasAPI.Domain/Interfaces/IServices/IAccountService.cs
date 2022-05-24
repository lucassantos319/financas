
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IAccountService
    {
        List<AccountModel> GetAccountsByUserId(int userId);

    }
}
