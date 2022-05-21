using FinancasAPI.Domain.Enums;

namespace FinancasAPI.Domain.Entities
{
    public class ItensModel
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int AccountId { get; set; }
        public double Value { get; set; }
        public TypeItemEnum TypeItem { get; set; }
        public TypeSpentEnum TypeSpent { get; set; }
        public DateTime CreateAt { get; set; }
        public AccountModel Account { get; set; }

    }

}
