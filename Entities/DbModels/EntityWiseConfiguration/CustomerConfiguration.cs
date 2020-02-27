using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Entities.DbModels.EntityWiseConfiguration
{
    public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
    {
        public void Configure(EntityTypeBuilder<Customer> builder)
        {

                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.Email).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ImageUrl).HasMaxLength(250);

                builder.Property(e => e.Name).HasMaxLength(150);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId).HasMaxLength(50);
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());


        }
        }
    }
