using EmployeeManagementAPI.Models;   // Make sure namespace matches your Employee.cs
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagementAPI.Data
{
    public class AppDbContext : DbContext
    {
        // Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Table
        public DbSet<Employee> Employees { get; set; }
    }
}
