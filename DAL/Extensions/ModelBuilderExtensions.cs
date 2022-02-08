using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DAL.Extensions
{
    internal static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Products>().HasData
                (
                    new Products { ProductsID = 1, ProductName = "6 pack Eggs", Amount = 10, ExpirationDate = DateTime.ParseExact("2023-08-15", "yyyy-MM-dd", null), Price = 15, Barcode = 1, CampaignsID = 1, InventoryByID = 1, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) },
                    new Products { ProductsID = 2, ProductName = "Onion in Net", Amount = 5, ExpirationDate = DateTime.ParseExact("2022-08-15", "yyyy-MM-dd", null), Price = 10, Barcode = 2, CampaignsID = 1, InventoryByID = 2, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) },
                    new Products { ProductsID = 3, ProductName = "Cornflakes", Amount = 9, ExpirationDate = DateTime.ParseExact("2022-12-15", "yyyy-MM-dd", null), Price = 25, Barcode = 3, CampaignsID = 1, InventoryByID = 3, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) },
                    new Products { ProductsID = 4, ProductName = "Coca-cola", Amount = 25, ExpirationDate = DateTime.ParseExact("2023-12-15", "yyyy-MM-dd", null), Price = 20, Barcode = 4, CampaignsID = 1, InventoryByID = 4, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) },
                    new Products { ProductsID = 5, ProductName = "Toast", Amount = 3, ExpirationDate = DateTime.ParseExact("2022-08-15", "yyyy-MM-dd", null), Price = 17, Barcode = 5, CampaignsID = 1, InventoryByID = 5, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) },
                    new Products { ProductsID = 6, ProductName = "Rib Eye", Amount = 5, ExpirationDate = DateTime.ParseExact("2023-08-15", "yyyy-MM-dd", null), Price = 80, Barcode = 6, CampaignsID = 2, InventoryByID = 6, InventoryDate = DateTime.ParseExact("2022-01-01", "yyyy-MM-dd", null) }
                );

            builder.Entity<Employee>().HasData
                (
                    new Employee { Title = "Manager", SSN = "0000000001", Name = "Soja Karlsson", PhoneNr = "0700000001", EmployeeID = 1, MentorID = null, EndDate = null },
                    new Employee { Title = "Manager", SSN = "0000000002", Name = "Simon Bergewing", PhoneNr = "0700000002", EmployeeID = 2, MentorID = null, EndDate = null },
                    new Employee { Title = "Employee", SSN = "0000000003", Name = "Anders Andersson", PhoneNr = "0700000003", EmployeeID = 3, MentorID = null, EndDate = null },
                    new Employee { Title = "Employee", SSN = "0000000004", Name = "Tobias Persson", PhoneNr = "0700000004", EmployeeID = 4, MentorID = null, EndDate = null },
                    new Employee { Title = "Trainee", SSN = "0000000005", Name = "Erika Andersson", PhoneNr = "0700000005", EmployeeID = 5, MentorID = 1, EndDate = DateTime.ParseExact("2022-08-15", "yyyy-MM-dd", null) },
                    new Employee { Title = "Trainee", SSN = "0000000006", Name = "Thomas Karlsson", PhoneNr = "0700000006", EmployeeID = 6, MentorID = 2, EndDate = DateTime.ParseExact("2022-10-15", "yyyy-MM-dd", null) }
                );

            builder.Entity<Email>().HasData
                (
                    new Email { Emails = "soja@sojashandel.se", EmployeeID = 1 },
                    new Email { Emails = "sojakarlsson123@msn.se", EmployeeID = 6 },
                    new Email { Emails = "simon@Sojashandel.se", EmployeeID = 2 },
                    new Email { Emails = "simon123@hotmail.com", EmployeeID = 2 },
                    new Email { Emails = "ander321@msn.se", EmployeeID = 3 },
                    new Email { Emails = "tobias567@hotmail.com", EmployeeID = 3 },
                    new Email { Emails = "e.andersson@gmail.com", EmployeeID = 4 },
                    new Email { Emails = "thomaserik@gmail.se", EmployeeID = 5 }
                );

            builder.Entity<Department>().HasData
                (
                    new Department { Name = "Dairy", ManagerID = 1 },
                    new Department { Name = "Fruit&Vegetable", ManagerID = 1 },
                    new Department { Name = "Pantry", ManagerID = 2 },
                    new Department { Name = "Drink", ManagerID = 2 },
                    new Department { Name = "Bread", ManagerID = 3 },
                    new Department { Name = "Meat", ManagerID = 4 }
                );
             
            builder.Entity<Campaigns>().HasData 
                (   
                    new Campaigns { ID = 1, Name = "RegularPrice", PriceReduction = 0 },
                    new Campaigns { ID = 2, Name = "Test", PriceReduction = 1}
                );

            builder.Entity<DepartmentProducts>().HasData
                (
                    new DepartmentProducts { ProductsID = 1, DepartmentID = "Dairy" },
                    new DepartmentProducts { ProductsID = 2, DepartmentID = "Fruit&Vegetable" },
                    new DepartmentProducts { ProductsID = 3, DepartmentID = "Pantry" },
                    new DepartmentProducts { ProductsID = 4, DepartmentID = "Drink" },
                    new DepartmentProducts { ProductsID = 5, DepartmentID = "Bread" },
                    new DepartmentProducts { ProductsID = 6, DepartmentID = "Meat" },
                    new DepartmentProducts { ProductsID = 5, DepartmentID = "Meat" }
                );

        }
    }
}
