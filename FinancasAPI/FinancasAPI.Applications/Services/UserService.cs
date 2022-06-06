using FinancasAPI.Applications.Services.Tokens;
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
                var allUsers = _repo.GetAllUser();
                foreach(var x in allUsers)
                    x.Password = "";

                return allUsers;
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
                        
                _repo.CreateUser(newUser);
            }
            catch
            {
                throw;
            }    
        }

        public UserModel GetUserByEmail(string email)
        {
            try
            {
                var user = _repo.GetAllUser().FirstOrDefault(x=>x.Equals(email));
                if (user == null)
                    throw new Exception("Usuário não existe");

                return user;
            }
            catch
            {
                throw;
            }
        }

        public object Login(string email, string password)
        {
            try
            {
                var user = _repo.GetUserByEmail(email);
                if (user == null)
                    throw new Exception($"Usuário com email {email} não existe");

                var passwordUser = GenerateTokenService.HashString(password);
                if (passwordUser.ToLower().Equals(user.Password.ToLower()))
                {
                    user.Password = "";
                    var token = GenerateTokenService.GenerateToken(user);
                    return new
                    {
                        user,
                        token
                    };
                }
                else
                {
                    throw new Exception("Senha incorreta");
                }

                return null;
            }
            catch
            {
                throw;
            }
        }

        public void UpdateUser(UserModel updateUser)
        {

        }

        public void DeleteUser(UserModel updateUser)
        {

        }

    }
}
