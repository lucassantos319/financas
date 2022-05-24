using Microsoft.EntityFrameworkCore;
using FinancasAPI.Domain.Entities;

namespace FinancasAPI.Infra.data
{
    public class Context : DbContext
    {
        public Context()
        {
        }

        public Context(DbContextOptions<Context> builderOptions) : base(builderOptions)
        {
        }

        public DbSet<AccountModel> Accounts { get; set; } 
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ItensModel> Itens { get; set; }    

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.SetMapping();
            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Username=postgres;Password=root;Database=financas");
            base.OnConfiguring(optionsBuilder);
        }

    }

}
