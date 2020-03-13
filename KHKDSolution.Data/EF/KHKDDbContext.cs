using KHKDSolution.Data.Configurations;
using KHKDSolution.Data.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace KHKDSolution.Data.EF
{
    public class KHKDDbContext : IdentityDbContext<AppUser,AppRole,Guid>
    {
        public KHKDDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new AppRoleConfiguration());
            modelBuilder.ApplyConfiguration(new DpLSXHConfiguration());
            modelBuilder.ApplyConfiguration(new DpLSXLConfiguration());
            modelBuilder.ApplyConfiguration(new SanPhamConfiguration());
            modelBuilder.ApplyConfiguration(new AppConfigConfiguration());

            modelBuilder.Entity<IdentityUserClaim<Guid>>().ToTable("AppUserClaims");
            modelBuilder.Entity<IdentityUserRole<Guid>>().ToTable("AppUserRoles").HasKey(x => new { x.UserId, x.RoleId });
            modelBuilder.Entity<IdentityUserLogin<Guid>>().ToTable("AppUserLogins").HasKey(x => x.UserId);

            modelBuilder.Entity<IdentityRoleClaim<Guid>>().ToTable("AppRoleClaims");
            modelBuilder.Entity<IdentityUserToken<Guid>>().ToTable("AppUserTokens").HasKey(x => x.UserId);
        }
        public DbSet<AppConfig> AppConfigs { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<DpLSXH> DpLSXHs { get; set; }
        public DbSet<DpLSXL> DpLSXLs { get; set; }
        public DbSet<SanPham> SanPhams { get; set; }
    }
}
