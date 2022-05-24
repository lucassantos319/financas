
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IUserService
    {
        List<UserModel> GetAllUsers();
        void CreateUser(UserModel user); 
    }
}
