
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

        public void CreateAccount(AccountModel newAccount)
        {
            _repository.CreateAccount(newAccount);
        }

        public void UpdateAccount(AccountModel accountUpdate)
        {
            var account = _repository.GetAccountById(accountUpdate.Id);
            if (account == null)
                throw new Exception($"Conta {accountUpdate.Id}-{accountUpdate.Name} inexistente");

            _repository.UpdateAccount(accountUpdate);
        }

        public void DeleteAccount(int accountId)
        {
            var account = _repository.GetAccountById(accountId);
            if (account == null)
                throw new Exception($"Conta {accountId} inexistente");

            _repository.DeleteAccount(account);
        }
    }
}
