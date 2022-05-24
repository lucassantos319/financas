
using FinancasAPI.Domain.Entities;
using FinancasAPI.Domain.Interfaces.IServices;

namespace FinancasAPI.Applications.Services
{
    public class DashboardService : IDashboardService
    {
        private readonly IAccountService _accountService;
        private readonly IItensService _itensService;

        public DashboardService(IAccountService accountService, IItensService itensService)
        {
            _accountService = accountService;
            _itensService = itensService;
        }

        public DashboardInfosModel GetInfoDashboard(int userId)
        {
            var dashInfo = new DashboardInfosModel();
            var accountsUser = _accountService.GetAccountsByUserId(userId);
            
            foreach (var account in accountsUser)
            {
                var itens = _itensService.GetItensByAccount(account.Id);
                dashInfo.AccountsInfos.Add(new AccountItensModel { 
                    Account = account,
                    Itens = itens
                });
            }

            return dashInfo;
            
        }
    }
}
