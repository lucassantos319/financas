using FinancasAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasAPI.Infra.data.Mapping
{
    public static class ItemMapping
    {
        public static void MappingItem(this EntityTypeBuilder<ItensModel> entity)
        {
            entity.HasKey(x => x.Id)
                .HasName("PK_ITENS");

            entity.ToTable("Itens");

            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Name)
                 .IsRequired();

            entity.Property(x => x.Value)
                .IsRequired()
                .HasDefaultValue(0.0);

            entity.Property(x => x.CreateAt)
                .IsRequired()
                .HasDefaultValueSql("now()");

            entity.Property(x => x.TypeSpent);

            entity.Property(x => x.TypeItem);

            entity.HasOne(x => x.Account)
                .WithMany(y => y.Itens)
                .HasForeignKey(z => z.AccountId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK_ITENS_ACCOUNT");

        }
    }
}
