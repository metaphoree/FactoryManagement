using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
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

            builder.Property(e => e.AlternateNumber_1)
                .HasMaxLength(50);

            builder.Property(e => e.AlternateNumber_2)
              .HasMaxLength(50);

            builder.Property(e => e.AlternateNumber_3)
              .HasMaxLength(50);

            builder.Property(e => e.LandPhone)
              .HasMaxLength(50);

            builder.Property(e => e.RelatedId)
                    .IsRequired()
                    .HasMaxLength(50);

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Type)
                .HasMaxLength(50);

            builder.Property(e => e.UniqueId)
                .IsRequired()
                .HasMaxLength(50);
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
