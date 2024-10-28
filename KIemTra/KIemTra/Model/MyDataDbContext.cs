using Microsoft.EntityFrameworkCore;

namespace KIemTra.Model
{
    public class MyDataDbContext :DbContext
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options) :base(options)
        {

        }

        public DbSet<Sach> Sach { get; set; }   
        public DbSet<DonHang> DonHang { get; set; }
        public DbSet<KhachHang> KhachHang { get;set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<HoaDonSach>()
                 .HasKey(hd => new { hd.HoaDonId, hd.SachId });

            modelBuilder.Entity<HoaDonSach>()
                .HasOne(hd => hd.HoaDon)
                .WithMany(h => h.HoaDonSachs)
                .HasForeignKey(hd => hd.HoaDonId);

            modelBuilder.Entity<HoaDonSach>()
                .HasOne(hd => hd.Sach)
                .WithMany(s => s.HoaDonSachs)
                .HasForeignKey(hd => hd.SachId);
        }
    }
}
