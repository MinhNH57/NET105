
using Db_Watch_and_Ring.Configurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using MyAPI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Db_Watch_and_Ring.Models
{
    public class WatchDbContext : IdentityDbContext<ApplicationUser>
    {
        public WatchDbContext()
        {

        }
        public WatchDbContext(DbContextOptions<WatchDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-RTLBH4I\SQLEXPRESS;Database=API_2;Trusted_Connection=True;TrustServerCertificate=True");
        }

        public DbSet<ThuongHieu> ThuongHieus { get; set; }
        public DbSet<DongHo> DongHos { get; set; }
        public DbSet<DongHoCT> DongHoCTs { get; set; }
        public DbSet<MatKinh> MatKinhs { get; set; }
        public DbSet<DayDeo> DayDeos { get; set; }
        public DbSet<LoaiMay> LoaiMays { get; set; }
        public DbSet<MauSac> MauSacs { get; set; }
        public DbSet<ChatLieu> chatLieus { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityUserLogin<string>>(entity =>
            {
                entity.HasKey(l => new { l.LoginProvider, l.ProviderKey });
            });

            modelBuilder.Entity<IdentityUserRole<string>>(entity =>
            {
                entity.HasKey(r => new { r.UserId, r.RoleId });
            });

            modelBuilder.Entity<IdentityUserToken<string>>(entity =>
            {
                entity.HasKey(t => new { t.UserId, t.LoginProvider, t.Name });
            });
            modelBuilder.ApplyConfiguration(new DongHoConfig());
            modelBuilder.ApplyConfiguration(new DongHoCTConfig());
            modelBuilder.ApplyConfiguration(new ChatLieuConfig());
            modelBuilder.ApplyConfiguration(new MauSacConfig());
            modelBuilder.ApplyConfiguration(new SizeConfig());
            modelBuilder.ApplyConfiguration(new DayDeoConfig());
            modelBuilder.ApplyConfiguration(new DongHoCT_ChatLieuConfig());
            modelBuilder.ApplyConfiguration(new DongHoCT_MauSacConfig());
        }
    }
}
