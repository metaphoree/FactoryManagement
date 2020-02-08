using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DbModels.EntityWiseConfiguration
{
    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(e => e.Id).HasMaxLength(50);

            builder.Property(e => e.FactoryId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.PermanentAddress).HasMaxLength(100);

            builder.Property(e => e.PresentAddress).HasMaxLength(50);

            builder.Property(e => e.RelatedId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.UniqueId)
                .IsRequired()
                .HasMaxLength(50);
        }
    }
}
