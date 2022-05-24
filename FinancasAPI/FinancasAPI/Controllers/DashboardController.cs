using FinancasAPI.Domain.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;

namespace FinancasAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DashboardController : ControllerBase
    {
        private readonly IDashboardService _dashboardService;

        public DashboardController(IDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public IActionResult GetDashboardInfos(int userId)
        {
            try
            {
                return Ok(_dashboardService.GetInfoDashboard(userId));
            }
            catch (Exception ex)
            {
                return Problem($"Message: {ex.Message}\nInnerException: {ex.InnerException}\nStack: {ex.StackTrace}");
            }

        }

    }
}
