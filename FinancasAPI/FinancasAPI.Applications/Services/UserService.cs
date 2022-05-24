using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Domain.Interfaces.IServices;

namespace FinancasAPI.Applications.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repo;

        public UserService(IUserRepository repo)
        {
            _repo = repo;
        }

        public List<UserModel> GetAllUsers()
        {
            try
            {
                return _repo.GetAllAccount();
            }
            catch
            {
                throw;
            }
        }

        public void CreateUser(UserModel newUser)
        {
            try
            {
                var existUser = _repo.ValidateEmail(newUser.Email);
                if (existUser)
                    throw new Exception("Usuário já existente");
                        
                _repo.CreateAccount(newUser);
            }
            catch
            {
                throw;
            }    
        }


    }
}
