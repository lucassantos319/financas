
using Newtonsoft.Json;

namespace FinancasAPI.Domain.Entities.Factory
{
    public class UserFactory
    {
        public UserFactory()
        {
        }

        public UserModel NewUser(object newUserObj)
        {
            var newUser = JsonConvert.DeserializeObject<UserModel>(newUserObj.ToString());
            return new UserModel
            {
                Name = newUser.Name,
                Email = newUser.Email,
            };
        }

    }
}
