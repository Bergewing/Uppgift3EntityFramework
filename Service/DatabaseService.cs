using DAL;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class DatabaseService
    {
        //SINGLETON--------------------------------------------------------------------------------------------------
        private static DatabaseService _instance;
        public static DatabaseService Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseService();
                }
                return _instance;
            }
        }
        //SINGLETON--------------------------------------------------------------------------------------------------

        private DatabaseService() { }

        public IOrderedEnumerable<ProductCountDTO> ListCount()
        {
            using (var db = new StoreContext())
            {
                return db.Products
                .Select(x => new ProductCountDTO
                {
                    Name = x.ProductName,
                    Amount = x.Amount
                })
                .ToList()
                .OrderBy(x => x.Amount);
            }
        }

        public void ProductUpdate(ProductUpdateDTO updateInfo)
        {
            using (var db = new StoreContext())
            {
                var update = db.Products.First(p => p.ProductsID == updateInfo.ProductsID);
                update.Amount = updateInfo.Amount;
                db.SaveChanges();
            }
        }

        public List<DepartmentManagerDTO> GetEmailToDepartment()
        { 
            using (var db = new StoreContext())
            {
                List<DepartmentManagerDTO> managerEmailList = new List<DepartmentManagerDTO>();
                var department = db.Department.ToList();
                foreach (var name in department)
                {
                    var manager = db.Employee.Include(x => x.Emails).First(x => x.EmployeeID == name.ManagerID);
                    var list = manager.Emails.Select(x => x.Emails).ToList();

                    managerEmailList.Add(new DepartmentManagerDTO
                    {
                        Name = name.Name,
                        Email = list
                    });
                }
                return managerEmailList;

            }
        }
    }
}

