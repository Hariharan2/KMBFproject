using KMBFproject.Controllers;
using Microsoft.EntityFrameworkCore;
using KMBFproject.Models;


namespace KMBFproject.Data
{
    public class EmployeeDbContext : DbContext
    {
        public EmployeeDbContext(DbContextOptions<EmployeeDbContext> option) : base(option)
        { }
            public DbSet<Employee>Employees{ get; set; }

    }
    }

