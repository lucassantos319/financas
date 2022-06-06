using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IRepositories
{
    public interface IUserRepository
    {
        List<UserModel> GetAllUser();
        UserModel GetUserById(int usersId);
        void CreateUser(UserModel newUser);
        void UpdateUser(UserModel user);
        void DeleteUser(UserModel user);
        bool ValidateEmail(string email);
        UserModel GetUserByEmail(string email);
    }
}
