
namespace FinancasAPI.Domain.Entities
{
    public class UserModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public DateTime CreatedAt { get; set; }
        public List<AccountModel> Account { get; set;  }
    }
}
