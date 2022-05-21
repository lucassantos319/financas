
using FinancasAPI.Domain.Entities;
using FinancasAPI.Infra.data.Mapping;
using FinancasAPI.Infra.Mapping;
using Microsoft.EntityFrameworkCore;

namespace FinancasAPI.Infra.data
{
    public static class DbMapping
    {
        public static void SetMapping(this ModelBuilder builder)
        {
            builder.Entity<AccountModel>().MappingAccount();
            builder.Entity<ItensModel>().MappingItem();
            builder.Entity<UserModel>().MappingUser();
        }
    }
}
