using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class PurchaseConfiguration : IEntityTypeConfiguration<Purchase>
    {
        public void Configure(EntityTypeBuilder<Purchase> builder)
        {
        
                builder.Property(e => e.Id).HasMaxLength(50);

                //builder.Property(e => e.AmountAfterDiscount).HasColumnType("decimal(18, 0)");

                //builder.Property(e => e.AmountBeforeDiscount).HasColumnType("decimal(18, 0)");

                //builder.Property(e => e.AmountDue).HasColumnType("decimal(18, 0)");

                //builder.Property(e => e.AmountPaid).HasColumnType("decimal(18, 0)");

                builder.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(50);

                //builder.Property(e => e.Description).HasMaxLength(50);

                //builder.Property(e => e.Discount).HasColumnType("decimal(18, 0)");

                //builder.Property(e => e.EmployeeId).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.InvoiceId)
                    .IsRequired()
                    .HasMaxLength(50);

                //builder.Property(e => e.Month)
                //    .IsRequired()
                //    .HasMaxLength(50);

                builder.Property(e => e.ProductId)
                    .IsRequired()
                    .HasMaxLength(50);

                //builder.Property(e => e.PurchaseId)
                //    .IsRequired()
                //    .HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

            ////builder.Property(e => e.UniqueId)
            ////    .IsRequired();
            builder.Property(p => p.UniqueId)
          .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            builder.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
