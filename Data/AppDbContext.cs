using Microsoft.EntityFrameworkCore;
using SysObiOnline.Models;

namespace SysObiOnline.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Login> Login { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}
