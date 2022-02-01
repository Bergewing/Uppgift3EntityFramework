using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace DAL
{
    public class StoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLEXPRESS;Database=Uppgift3EF;Integrated Security=True;";
            optionsBuilder
                .UseSqlServer(connectionString)
                .LogTo(Console.WriteLine, LogLevel.Information)
                .EnableSensitiveDataLogging();

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ingredients>()
                .HasKey(s => new { s.Ingredient, s.Product });

            modelBuilder.Entity<Email>()
                .HasKey(x => new { x.Emails, x.EmployeeID });

            modelBuilder.Entity<DepPro>()
                .HasKey(dp => new { dp.ProductsID, dp.DepartmentID });

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<DepPro> DepPro { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Email> Emails { get; set; }
        public DbSet<Ingredients > Ingredients { get; set;}
    }

}