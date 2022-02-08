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
            modelBuilder.Entity<Department>()
                .HasKey(n => n.Name);

            modelBuilder.Entity<Ingredients>()
                .HasKey(s => new { s.Ingredient, s.ProductsID });

            modelBuilder.Entity<Email>()
                .HasKey(x => new { x.Emails, x.EmployeeID });

            modelBuilder.Entity<DepartmentProducts>()
                .HasKey(dp => new { dp.ProductsID, dp.DepartmentID });

            modelBuilder.Entity<DepartmentProducts>()
                .HasOne(dp => dp.Department)
                .WithMany(d => d.Products)
                .HasForeignKey(dp => dp.DepartmentID)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<DepartmentProducts>()
                .HasOne(dp => dp.Products)
                .WithMany(d => d.Departments)
                .HasForeignKey(dp => dp.ProductsID)
                .OnDelete(DeleteBehavior.Restrict);

            //Lägg in alla employee i extension mappen
            modelBuilder.Entity<Employee>()
                .HasIndex(e => e.SSN)
                .IsUnique();

            modelBuilder.Entity<Employee>()
                .HasOne<Employee>(e => e.Mentor)
                .WithMany(t => t.Trainees)
                .HasForeignKey(e => e.MentorID);

            modelBuilder.Entity<Employee>()
                .Property(d => d.EndDate)
                .HasColumnType("date");

            //Products
            modelBuilder.Entity<Products>()
                .Property(p => p.ExpirationDate)
                .HasColumnType("date");

            modelBuilder.Entity<Products>()
                .Property(p => p.Price)
                .HasColumnType("money");

            modelBuilder.Entity<Products>()
                .Property(p => p.InventoryDate)
                .HasColumnType("date");

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