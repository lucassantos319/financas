
namespace FinancasAPI.Domain.Entities
{
    public class DashboardInfosModel
    {
        public List<AccountItensModel> DashboardInfo;

    }
    
    public class AccountItensModel
    {
        public AccountModel Account;
        public List<ItensModel> Itens;
    }
}

