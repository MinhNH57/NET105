using Microsoft.EntityFrameworkCore;

namespace Practice_CRUD.Models
{
    public class MyDataDbcontext : DbContext
    {
        public MyDataDbcontext(DbContextOptions<MyDataDbcontext> options ) :base(options)
        {

        }

        public DbSet<SInhVien> SinhViens { get; set; }
        public DbSet<LopHoc> LopHocs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SInhVien>()
                        .HasOne(s => s.lophoc)
                        .WithMany(l => l.sInhviens)
                        .HasForeignKey(s => s.IDLopHoc);
            modelBuilder.Entity<LopHoc>().HasData(new LopHoc { ID = Guid.Parse("dc3a2078-02ae-4002-8116-bd168fa48cbf"), NameClass = "SD18406" });
            modelBuilder.Entity<SInhVien>().HasData(
                    new SInhVien { ID = Guid.NewGuid(), Name = "Nguyen Hong Minh", Address = "Phung Xa", IDLopHoc= Guid.Parse("dc3a2078-02ae-4002-8116-bd168fa48cbf") }
                );
        }
    }
}
