
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
        public List<UserModel> GetAllUser()
        {
            return _context.Users.ToList();
        }

        public UserModel GetUserById(int usersId)
        {
            return _context.Users.FirstOrDefault(x => x.Id == usersId);
        }

        public void CreateUser(UserModel newUser)
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

        public void UpdateUser(UserModel user)
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

        public void DeleteUser(UserModel user)
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

        public UserModel GetUserByEmail(string email)
        {
            return _context.Users.FirstOrDefault(x => x.Email.ToLower() == email.ToLower());
        }
    }
}
