using Microsoft.EntityFrameworkCore;

namespace Lab01_Lab02.Models
{
    public class MyDataDbContext : DbContext 
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options) :base(options)
        {

        }

        public DbSet<Event> events { get; set; }
        public DbSet<Ticket> tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>()
            .HasOne(s => s.Event)
            .WithMany(l => l.Tickets)
            .HasForeignKey(s => s.IDEvent);
            modelBuilder.Entity<Event>().HasData(new Event
            {
                Id = Guid.Parse("2aaf31f1-c00d-4085-ab59-df38dfb0a4df"),
                Name = "Nhung thanh pho mi mang",
                Location = "Ha noi",
                Date = DateTime.Now,
            });
            modelBuilder.Entity<Ticket>().HasData(new Ticket { Id = Guid.NewGuid(), SeatNumber = "S16", Price = 200000, IDEvent = Guid.Parse("2aaf31f1-c00d-4085-ab59-df38dfb0a4df") });
        }
    }
}
