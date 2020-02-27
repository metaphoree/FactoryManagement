using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class StockOutConfiguration : IEntityTypeConfiguration<StockOut>
    {
        public void Configure(EntityTypeBuilder<StockOut> builder)
        {
           
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.BatchNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ExecutorId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ItemId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ItemStatusId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
