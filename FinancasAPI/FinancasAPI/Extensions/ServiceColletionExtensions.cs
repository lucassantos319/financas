using FinancasAPI.Applications.Services;
using FinancasAPI.Domain.Interfaces.IServices;
using Microsoft.Extensions.DependencyInjection;

namespace FinancasAPI.Extensions
{
    public static class ServiceColletionExtensions
    {
        public static void AddService(this IServiceCollection services)
        {
            services.AddTransient<IAccountService,AccountService>();
            services.AddTransient<IItensService, ItensService>();
            services.AddTransient<IUserService,UserService>();
        }


    }
}
