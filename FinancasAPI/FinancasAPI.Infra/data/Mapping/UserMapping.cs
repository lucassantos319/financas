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
    public static class UserMapping
    {
        public static void MappingUser(this EntityTypeBuilder<UserModel> entity)
        {
            entity.HasKey(x => x.Id)
               .HasName("PK_USER");
            
            entity.ToTable("Users");

            entity.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            entity.Property(x => x.Name)
                .IsRequired();

            entity.Property(x => x.Email)
                .IsRequired();

            entity.Property(x => x.Password)
                .IsRequired();

            entity.Property(x => x.CreatedAt)
                .IsRequired()
                .HasDefaultValueSql("now()");

        }
    }
}
