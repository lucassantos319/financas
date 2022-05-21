
namespace FinancasAPI.Domain.Entities
{
    public class AccountModel
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreateAt { get; set; }  
        public List<ItensModel> Itens { get; set; }
        public UserModel User { get; set; }
        public int UserId { get; set; }
    
    }
}
