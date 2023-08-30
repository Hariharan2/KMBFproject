using KMBFproject.Controllers;
using Microsoft.EntityFrameworkCore;

namespace KMBFproject.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> option) : base(option)
        { }
            public DbSet<EmployeeController> Employees { get; set; }
    }
    }

