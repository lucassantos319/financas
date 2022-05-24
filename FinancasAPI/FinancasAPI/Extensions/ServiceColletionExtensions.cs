using FinancasAPI.Applications.Services;
using FinancasAPI.Domain.Interfaces.IRepositories;
using FinancasAPI.Domain.Interfaces.IServices;
using FinancasAPI.Infra.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace FinancasAPI.Extensions
{
    public static class ServiceColletionExtensions
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IUserService,UserService>();
            services.AddTransient<IItensService, ItensService>();
            services.AddTransient<IAccountService,AccountService>();
            services.AddTransient<IDashboardService, DashboardService>();
        }

        public static void AddRepositories(this IServiceCollection services)
        {
            services.AddTransient<IUserRepository,UserRepository>();
            services.AddTransient<IItensRepository, ItensRepository>();
            services.AddTransient<IAccountRepository,AccountRepository>();
        }

    }
}
