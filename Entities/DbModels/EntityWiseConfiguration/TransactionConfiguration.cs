using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class TransactionConfiguration : IEntityTypeConfiguration<Transaction>
    {
        public void Configure(EntityTypeBuilder<Transaction> builder)
        {
          
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.Amount)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ClientId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Description).HasMaxLength(50);

                builder.Property(e => e.ExecutorId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.InvoiceId).HasMaxLength(50);

                builder.Property(e => e.Month)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.PaymentStatusId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Purpose).HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.TransactionId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.TransactionTypeId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
