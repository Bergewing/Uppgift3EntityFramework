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
                    new Products { ProductsID = 1, ProductName = "6 pack Eggs", Amount = 10, ExpirationDate = 123, Price = 15, Barcode = 1, CampaignsID = 0, InventoryByID = 1, InventoryDate = 123 },
                    new Products { ProductsID = 2, ProductName = "Onion in Net", Amount = 5, ExpirationDate = 321, Price = 10, Barcode = 2, CampaignsID = 0, InventoryByID = 2, InventoryDate = 321 },
                    new Products { ProductsID = 3, ProductName = "Cornflakes", Amount = 9, ExpirationDate = 555, Price = 25, Barcode = 3, CampaignsID = 0, InventoryByID = 3, InventoryDate = 777 },
                    new Products { ProductsID = 4, ProductName = "Coca-cola", Amount = 25, ExpirationDate = 456, Price = 20, Barcode = 4, CampaignsID = 0, InventoryByID = 4, InventoryDate = 345 },
                    new Products { ProductsID = 5, ProductName = "Toast", Amount = 3, ExpirationDate = 345, Price = 17, Barcode = 5, CampaignsID = 0, InventoryByID = 5, InventoryDate = 234 },
                    new Products { ProductsID = 6, ProductName = "Riby Eye", Amount = 5, ExpirationDate = 999, Price = 80, Barcode = 6, CampaignsID = 0, InventoryByID = 6, InventoryDate = 888 }
                );

            builder.Entity<Employee>().HasData
                (
                    new Employee { Title = "Manager", SSN = 0000000001, Name = "Soja Karlsson", PhoneNr = 0700000001, EmployeeID = 1, Mentor = 1, EndDate = 10 },
                    new Employee { Title = "Manager", SSN = 0000000002, Name = "Simon Bergewing", PhoneNr = 0700000002, EmployeeID = 2, Mentor = 1, EndDate = 10 },
                    new Employee { Title = "Employee", SSN = 0000000003, Name = "Anders Andersson", PhoneNr = 0700000003, EmployeeID = 3, Mentor = 1, EndDate = 10 },
                    new Employee { Title = "Employee", SSN = 0000000004, Name = "Tobias Persson", PhoneNr = 0700000004, EmployeeID = 4, Mentor = 1, EndDate = 10 },
                    new Employee { Title = "Trainee", SSN = 0000000005, Name = "Erika Andersson", PhoneNr = 0700000005, EmployeeID = 5, Mentor = 1, EndDate = 10 },
                    new Employee { Title = "Trainee", SSN = 0000000001, Name = "Thomas Karlsson", PhoneNr = 0700000001, EmployeeID = 6, Mentor = 1, EndDate = 10 }
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
                    new Department { DepartmentID = 1, Name = "Dairy", Manager = 1 },
                    new Department { DepartmentID = 2, Name = "Fruit&Vegetable", Manager = 1 },
                    new Department { DepartmentID = 3, Name = "Pantry", Manager = 2 },
                    new Department { DepartmentID = 4, Name = "Drink", Manager = 2 },
                    new Department { DepartmentID = 5, Name = "Bread", Manager = 3 },
                    new Department { DepartmentID = 6, Name = "Meat", Manager = 4 }
                );

        }
    }
}
