using KHKDSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Configurations
{
    public class DpLSXLConfiguration : IEntityTypeConfiguration<DpLSXL>
    {
        public void Configure(EntityTypeBuilder<DpLSXL> builder)
        {
            builder.ToTable("DpLSXLs");
            builder.HasKey(x => x.SoLSXID);

            builder.Property(x => x.SoLSX).IsRequired().HasMaxLength(15);

            builder.Property(x => x.ChiNhanh).HasMaxLength(20);

            builder.Property(x => x.MaSP).HasMaxLength(20);

            builder.Property(x => x.MaMau).HasMaxLength(15);

            builder.Property(x => x.MSM).HasMaxLength(10);

            builder.Property(x => x.LoaiBTP).HasMaxLength(10);
            builder.Property(x => x.MauBTP).HasMaxLength(5);
            builder.Property(x => x.QuiCachBTL).HasMaxLength(20);
            builder.Property(x => x.CoSoID).IsRequired();
            builder.Property(x => x.SoSOA).HasMaxLength(15);
            builder.Property(x => x.SoDH).HasMaxLength(15);
            builder.Property(x => x.SoDHK).HasMaxLength(15);
            builder.Property(x => x.MauKhach).HasMaxLength(10);
            builder.Property(x => x.CSDanTem).HasMaxLength(10);
            builder.Property(x => x.DVT).HasMaxLength(5);
            builder.Property(x => x.DienGiaiCT).IsUnicode(true).HasMaxLength(400);

            builder.HasOne(x => x.DpLSXH).WithMany(x => x.DpLSXL).HasForeignKey(x => x.SoLSX);
            builder.HasOne(x => x.SanPham).WithMany(x => x.DpLSXL).HasForeignKey(x => x.MaSP);

        }
    }
}
