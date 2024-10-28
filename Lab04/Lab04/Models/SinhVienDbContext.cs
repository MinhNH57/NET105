using Microsoft.EntityFrameworkCore;

namespace Lab03_04.Models
{
    public class SinhVienDbContext : DbContext
    {
        public SinhVienDbContext (DbContextOptions<SinhVienDbContext> options ) : base(options) { }

        public DbSet<SinhVienModel> SinhVien { get; set; }
        public DbSet<LopHocModel> LopHoc { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SinhVienModel>(entity =>
            {

                entity.HasKey(sv => sv.Id);


                entity
                    .HasOne(sv => sv.LopHoc)   
                    .WithMany(lh => lh.SinhViens)    
                    .HasForeignKey(sv => sv.ClassId) 
                    .OnDelete(DeleteBehavior.Cascade); 
            });

            modelBuilder.Entity<LopHocModel>().HasData(new LopHocModel { Id = Guid.Parse("3e581809-e2a0-4848-a30a-a9d9d7f2f72a"), Name = "SD18406" });
            modelBuilder.Entity<SinhVienModel>().HasData(new SinhVienModel { Id = Guid.NewGuid(), Name = "Nguyen Hong Minh", Age = 20, ClassId = Guid.Parse("3e581809-e2a0-4848-a30a-a9d9d7f2f72a") , Major = "CNTT" });
        }

    }
}
