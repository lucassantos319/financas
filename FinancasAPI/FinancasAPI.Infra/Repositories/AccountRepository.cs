using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Infra.data;

namespace FinancasAPI.Infra.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        private readonly Context _context;

        public AccountRepository(Context context)
        {
            _context = context;
        }

        public List<AccountModel> GetAllAccount()
        {
            return _context.Accounts.ToList();
        }

        public AccountModel GetAccountById(int accountId)
        {
            return _context.Accounts.FirstOrDefault(x=>x.Id == accountId );
        }

        public void CreateAccount(AccountModel newAccount)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Accounts.Add(newAccount);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void UpdateAccount(AccountModel newAccount)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Accounts.Update(newAccount);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void DeleteAccount(AccountModel newAccount)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Accounts.Remove(newAccount);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }


    }
}
