
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
            
        }
    }
}
