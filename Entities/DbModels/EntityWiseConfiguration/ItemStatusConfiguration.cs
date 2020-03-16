﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Configuration;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class ItemStatusConfiguration : IEntityTypeConfiguration<ItemStatus>
    {
        public void Configure(EntityTypeBuilder<ItemStatus> builder)
        {

            builder.Property(e => e.Id).HasMaxLength(50);

            builder.Property(e => e.FactoryId)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(p => p.UniqueId)
              .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            //builder.Property(e => e.UniqueId)
            //    .IsRequired();
            builder.HasQueryFilter(s => s.RowStatus != DB_ROW_STATUS.DELETED.ToString());

            builder.HasData(
                new ItemStatus
                {
                    CreatedDateTime = DateTime.UtcNow,
                    FactoryId = Config.FactoryId,
                    Id = Guid.NewGuid().ToString(),
                    Name = "GOOD",
                    RowStatus = DB_ROW_STATUS.ADDED.ToString(),
                    UpdatedDateTime = DateTime.UtcNow
                },
                   new ItemStatus
                   {
                       CreatedDateTime = DateTime.UtcNow,
                       FactoryId = Config.FactoryId,
                       Id = Guid.NewGuid().ToString(),
                       Name = "BAD",
                       RowStatus = DB_ROW_STATUS.ADDED.ToString(),
                       UpdatedDateTime = DateTime.UtcNow
                   }
            ); ;
        }
    }
}
