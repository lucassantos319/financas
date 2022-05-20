using FinancasUI.ViewModels.Enums;

namespace FinancasUI.ViewModels
{
    public class ItensViewModel
    {
        public int Id { get; set; }
        public int AccountId { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public TypeItemEnum TypeItem { get; set; }
        public TypeSpentEnum TypeSpent { get; set; }
    }
}
