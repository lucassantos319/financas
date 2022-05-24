
using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Infra.data;

namespace FinancasAPI.Infra.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly Context _context;
        public UserRepository(Context context)
        {
            _context = context;
        }
        public List<UserModel> GetAllAccount()
        {
            return _context.Users.ToList();
        }

        public UserModel GetAccountById(int usersId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == usersId);
        }

        public void CreateAccount(UserModel newUser)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Users.Add(newUser);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void UpdateAccount(UserModel user)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Users.Update(user);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public void DeleteAccount(UserModel user)
        {
            using var transaction = _context.Database.BeginTransaction();
            try
            {
                _context.Users.Add(user);
                _context.SaveChanges();
                transaction.Commit();
            }
            catch (Exception ex)
            {
                transaction.Rollback();
                throw new Exception("Rollback trying create a error message:", ex);
            }
        }

        public bool ValidateEmail(string email)
        {
            return _context.Users.Any(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
