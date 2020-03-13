using KHKDSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Configurations
{
    public class DpLSXHConfiguration : IEntityTypeConfiguration<DpLSXH>
    {
        public void Configure(EntityTypeBuilder<DpLSXH> builder)
        {
            builder.ToTable("DpLSXHs");
            builder.HasKey(x => x.SoLSX);

            builder.Property(x => x.SoLSX).IsRequired().HasMaxLength(15);

            builder.Property(x => x.SoLSX).HasMaxLength(15);

            builder.Property(x => x.MaKH).IsRequired().HasMaxLength(10);

            builder.Property(x => x.SoTN).HasMaxLength(10);

            builder.Property(x => x.SoDDH).HasMaxLength(15);

            builder.Property(x => x.GhiChu).IsUnicode(true).HasMaxLength(400);

            builder.Property(x => x.SoPO).HasMaxLength(20);

            builder.HasOne(x => x.AppUser).WithMany(x => x.DpLSXH).HasForeignKey(x => x.UserCreate);




        }
    }
}
