
using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Domain.Interfaces.IServices;

namespace FinancasAPI.Applications.Services
{
    public class AccountService : IAccountService
    {

        private readonly IAccountRepository _repository;
        public AccountService(IAccountRepository repo)
        {
            _repository = repo;
        }

        public List<AccountModel> GetAccountsByUserId(int userId)
        {
            return _repository.GetAllAccount().Where(x => x.UserId == userId).ToList();
        }

    }
}
