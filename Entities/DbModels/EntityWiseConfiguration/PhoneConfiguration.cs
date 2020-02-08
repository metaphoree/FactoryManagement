using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class PhoneConfiguration : IEntityTypeConfiguration<Phone>
    {
        public void Configure(EntityTypeBuilder<Phone> builder)
        {
        
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.RelatedId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Type)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasMaxLength(50);
           
        }
    }
}
