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

        //public void ProductUpdate(int productId, int updateAmount)
        //{
        //    using (var db = new StoreContext())
        //    {
        //        var update = db.Products.First(p => p.ProductsID == productId);
        //        update.Amount = updateAmount;
        //        db.SaveChanges();

        //    }
        //}


        public void ProductUpdate(ProductUpdateDTO updateInfo)
        {
            using (var db = new StoreContext())
            {
                var update = db.Products.First(p => p.ProductsID == updateInfo.ProductsID);
                update.Amount = updateInfo.Amount;
                db.SaveChanges();

            }
        }
        //var product = context.Product.First(p => p.ProductID == newInfo.ProductId);
        //                product.ProductAmount = newInfo.NewAmount;
        //                context.SaveChanges();
    }
}

/*1.Skapa en controller för hantering av produkter. Controller:n ska mappa mot /products. a.Skapa en endpoint som listar alla produkters namn och antal i lager.
 * Listan ska vara sorterad på antal i lager med lägst värde först. Mappa endpoint:en mot /products/count.*/
        //public List<ProductCountDTO> ListCount()
        //{
        //    using (var db = new StoreContext())
        //    {
        //        List<ProductCountDTO> productCounts = new List<ProductCountDTO>();
        //        foreach (var item in db.Products)
        //        {
        //            db.Products.Select(x => new ProductCountDTO
        //             {
        //                 Name = x.ProductName,
        //                 Amount = x.Amount
        //             })
        //            .ToList()
        //            .OrderBy(x => x.Amount);

        //            productCounts.Add(item.ProductName)

        //        }


        //        //return db.Products
        //        //.Select(x => new ProductCountDTO
        //        //{
        //        //    Name = x.ProductName,
        //        //    Amount = x.Amount
        //        //})
        //        //.ToList()
        //        //.OrderBy(x => x.Amount)
        //        //;
        //    }
        //}