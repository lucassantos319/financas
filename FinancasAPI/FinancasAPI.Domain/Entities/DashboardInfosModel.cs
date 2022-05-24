
namespace FinancasAPI.Domain.Entities
{
    public class DashboardInfosModel
    {
        public List<AccountItensModel> AccountsInfos;

        public DashboardInfosModel()
        {
            AccountsInfos = new List<AccountItensModel>();  
        }

    }
    
    public class AccountItensModel
    {
        public AccountModel Account;
        public List<ItensModel> Itens;
    }
}

