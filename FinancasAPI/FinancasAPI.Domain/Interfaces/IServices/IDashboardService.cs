
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Domain.Interfaces.IServices
{
    public interface IDashboardService
    {
        DashboardInfosModel GetInfoDashboard(int userId);
    }
}
