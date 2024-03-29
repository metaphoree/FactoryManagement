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
    public class EquipmentConfiguration: IEntityTypeConfiguration<Equipment>
    {
        public void Configure(EntityTypeBuilder<Equipment> builder)
        {
             builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.Description).HasMaxLength(50);

                builder.Property(e => e.EquipmentCategoryId).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Price).HasColumnType("decimal(18, 0)");

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(p => p.UniqueId)
              .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.Property(e => e.UniqueId);
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
