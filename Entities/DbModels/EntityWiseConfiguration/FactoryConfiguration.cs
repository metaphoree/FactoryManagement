using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class FactoryConfiguration : IEntityTypeConfiguration<Factory>
    {
        public void Configure(EntityTypeBuilder<Factory> builder)
        {

            builder.Property(e => e.Id).HasMaxLength(50);

            builder.Property(e => e.ImageUrl).HasMaxLength(250);

            builder.Property(e => e.LicenseNo).HasMaxLength(50);

            builder.Property(e => e.Name).HasMaxLength(150);

            builder.Property(e => e.RegNo).HasMaxLength(50);

            builder.Property(e => e.RowStatus)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(e => e.UniqueId).HasMaxLength(50);

            builder.Property(e => e.VatRegNo).HasMaxLength(50);
            builder.HasData(
    new Factory
    {
        Id = Guid.NewGuid().ToString(),
        FactoryId = Guid.NewGuid().ToString(),
        CreatedDateTime = DateTime.Now,
        ImageUrl = "",
        LicenseNo = "",
        Name = "Fazlu Loom Factory",
        RegNo = "",
        RowStatus = DB_ROW_STATUS.ADDED.ToString(),
        SubscriptionStart = DateTime.Now,
        SubscriptionEnd = DateTime.Now.AddDays(1000),
        UniqueId = "FL00001",
        UpdatedDateTime = DateTime.Now,
        VatRegNo = ""

    });
        }
    }
}
