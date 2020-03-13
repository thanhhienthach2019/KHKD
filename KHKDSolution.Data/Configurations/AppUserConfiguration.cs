using KHKDSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Configurations
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.ToTable("AppUsers");
            builder.Property(x => x.FirstName).IsRequired().IsUnicode(true).HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50).IsUnicode(true);
            builder.Property(x => x.Dob).IsRequired().HasMaxLength(20);
        }
    }
}
