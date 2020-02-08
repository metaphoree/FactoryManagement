﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Entities.DbModels.EntityWiseConfiguration
{
    public class StaffConfiguration : IEntityTypeConfiguration<Staff>
    {
        public void Configure(EntityTypeBuilder<Staff> builder)
        {
           
                builder.Property(e => e.Id).HasMaxLength(50);

                builder.Property(e => e.BirthRegistrationNo).HasMaxLength(50);

                builder.Property(e => e.Code).HasMaxLength(50);

                builder.Property(e => e.DepartmentId).HasMaxLength(50);

                builder.Property(e => e.Email).HasMaxLength(50);

                builder.Property(e => e.FactoryId)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.ImageUrl).HasMaxLength(250);

                builder.Property(e => e.Name).HasMaxLength(150);

                builder.Property(e => e.NationalIdNo).HasMaxLength(50);

                builder.Property(e => e.RowStatus)
                    .IsRequired()
                    .HasMaxLength(50);

                builder.Property(e => e.UniqueId).HasMaxLength(50);
        
        }
    }
}
