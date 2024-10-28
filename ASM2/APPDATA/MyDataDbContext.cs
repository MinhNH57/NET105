using Microsoft.EntityFrameworkCore;

namespace APPAPI.Model
{
    public class MyDataDbContext : DbContext
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options) :base(options) { }

        public DbSet<ThucAn> ThucAns { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ThucAn>()
    .Property(t => t.DonGia)
    .HasPrecision(18, 4);
        }
    }
}
