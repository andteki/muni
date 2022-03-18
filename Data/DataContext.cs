// using Microsoft.EntityFrameworkCore;
// using Pomelo.EntityFrameworkCore.MySql;
// using Microsoft.EntityFrameworkCore.Sqlite;


namespace App01.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; } = null!;
        public DataContext(DbContextOptions<DataContext> options) : base(options) {}

        
    }
}