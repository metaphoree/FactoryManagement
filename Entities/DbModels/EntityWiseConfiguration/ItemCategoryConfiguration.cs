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
    public class ItemCategoryConfiguration : IEntityTypeConfiguration<ItemCategory>
    {
        public void Configure(EntityTypeBuilder<ItemCategory> builder)
        {
            
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.Name).HasMaxLength(150);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            builder.Property(p => p.UniqueId)
              .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.Property(e => e.UniqueId)
            //    .IsRequired();
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());
        }
    }
}
