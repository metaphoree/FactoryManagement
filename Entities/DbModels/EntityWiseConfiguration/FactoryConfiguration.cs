using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class FactoryConfiguration : IEntityTypeConfiguration<Factory>
    {
        public void Configure(EntityTypeBuilder<Factory> builder)
        {
            
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.ImageUrl).HasMaxLength(250);

                builder.Property(e => e.LicenseNo).HasMaxLength(50);

                builder.Property(e => e.Name).HasMaxLength(150);

                builder.Property(e => e.RegNo).HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId).HasMaxLength(50);

                builder.Property(e => e.VatRegNo).HasMaxLength(50);
            
        }
    }
}
