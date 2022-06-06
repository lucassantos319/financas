namespace FinancasUI.ViewModels
{
    public class DashboardViewModel
    {
        public double TotalValue { get; set; }
        public UserViewModel User { get; set; }
        public IEnumerable<ItensViewModel> Itens { get; set; }
        public IEnumerable<AccountViewModel> Accounts { get; set; }
    }
}
