﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class ProductionConfiguration : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {

            builder.Property(e => e.Id).HasMaxLength(50);

            builder.Property(e => e.FactoryId)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(e => e.ItemCategoryId)
                .IsRequired()
                .HasMaxLength(50);
            builder
                .Property(e => e.EquipmentId)
                .HasMaxLength(50);

            builder.Property(e => e.ItemId)
                .IsRequired()
                .HasMaxLength(50);

            builder
                .Property(e => e.ProductionId)
                .HasMaxLength(50);

            builder.Property(e => e.UnitPrice).HasColumnType("decimal(18, 0)");

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.StaffId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.TotalAmount).HasColumnType("decimal(18, 0)");
            builder.Property(p => p.UniqueId)
              .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.Property(e => e.UniqueId)
            //    .IsRequired();
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
