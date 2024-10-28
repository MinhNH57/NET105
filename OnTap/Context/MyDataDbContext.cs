using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
    public class MyDataDbContext : DbContext
    {
        public MyDataDbContext(DbContextOptions<MyDataDbContext> options) : base(options) { }

        public DbSet<NhanVien> KhachHangs { get; set; }
    }
}
