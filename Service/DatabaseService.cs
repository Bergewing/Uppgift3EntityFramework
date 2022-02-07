using DAL;
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

        public IOrderedEnumerable<DepartmentManagerDTO> GetEmail()
        {
            using (var db = new StoreContext())
            {
                db.Department.Join<Department>.

            }

        }

    }
}

