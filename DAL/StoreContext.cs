using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DAL.Extensions;

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
                .HasKey(s => new { s.Ingredient, s.ProductID });

            modelBuilder.Entity<Email>()
                .HasKey(x => new { x.Emails, x.EmployeeID });

            modelBuilder.Entity<DepartmentProducts>()
                .HasKey(dp => new { dp.ProductsID, dp.DepartmentID });

            modelBuilder.Seed();
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<DepartmentProducts> DepartmentProducts { get; set; }
        public DbSet<Department> Department { get; set; }
        public DbSet<Campaigns> Campaigns { get; set; }
        public DbSet<Email> Email { get; set; }
        public DbSet<Ingredients > Ingredients { get; set;}
    }

}