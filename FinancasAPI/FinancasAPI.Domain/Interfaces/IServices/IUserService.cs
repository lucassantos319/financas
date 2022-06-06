
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IUserService
    {
        List<UserModel> GetAllUsers();
        void CreateUser(UserModel user);
        UserModel GetUserByEmail(string email);
        void UpdateUser(UserModel user);
        void DeleteUser(UserModel user);  
        object Login(string email, string password); 
    }
}
