
using Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    public class MydataDbContext : DbContext
    {
        public MydataDbContext(DbContextOptions<MydataDbContext> options):base(options) { }

        public DbSet<KhachHang> KhachHangs { get; set; }
    }
}
