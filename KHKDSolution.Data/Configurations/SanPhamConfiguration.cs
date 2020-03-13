using KHKDSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.Configurations
{
    public class SanPhamConfiguration : IEntityTypeConfiguration<SanPham>
    {
        public void Configure(EntityTypeBuilder<SanPham> builder)
        {
            builder.ToTable("SanPhams");

            builder.HasKey(x => x.MaSP);
            builder.Property(x => x.MaSP).IsRequired().HasMaxLength(20);
            builder.Property(x => x.MSSP).HasMaxLength(10);
            builder.Property(x => x.MaCLSpPhu).HasMaxLength(10);
            builder.Property(x => x.MaCLSP).HasMaxLength(10);
            builder.Property(x => x.GhiChu).IsUnicode(true).HasMaxLength(400);
            builder.Property(x => x.TenBTP).HasMaxLength(20);
            builder.Property(x => x.MaSAP).HasMaxLength(20);
            builder.Property(x => x.MaKhuon).HasMaxLength(20);

            builder.HasOne(x => x.AppUser).WithMany(x => x.SanPham).HasForeignKey(x => x.UserCreate);

        }
    }
}
