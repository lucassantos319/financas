using FinancasAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FinancasAPI.Infra.Mapping
{
    public static class AccountMapping
    {
        public static void MappingAccount(this EntityTypeBuilder<AccountModel> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_ACCOUNT");

            entity.ToTable("Account");

            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Name)
                 .IsRequired();

            entity.Property(x => x.IsActive)
                .IsRequired()
                .HasDefaultValue(true);

            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");


            entity.HasOne(x => x.User)
                .WithMany(y => y.Account)
                .HasForeignKey(z => z.UserId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ITENS_ACCOUNT");
        }

    }
}
 