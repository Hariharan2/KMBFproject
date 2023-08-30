using KMBFproject.Controllers;
using Microsoft.EntityFrameworkCore;

namespace KMBFproject.Data
{
    public class loginDbContext : DbContext
    {
        public loginDbContext(DbContextOptions<loginDbContext> options) :base(options) { 
        }

        public DbSet<Loginpage> loginpages { get; set; }
        public DbSet<ShareholderController> Shareholder { get; set; }
    }
}
