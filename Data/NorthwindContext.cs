using Microsoft.EntityFrameworkCore;
using SQLViewer.Models;

namespace SQLViewer.Data
{
    public class NorthwindContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=Northwind;Trusted_Connection=True;Trust Server Certificate=True;");
        }
    }
}
