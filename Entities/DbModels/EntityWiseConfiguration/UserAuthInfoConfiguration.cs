using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class UserAuthInfoConfiguration : IEntityTypeConfiguration<UserAuthInfo>
    {
        public void Configure(EntityTypeBuilder<UserAuthInfo> builder)
        {
           
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            
        }
    }
}
