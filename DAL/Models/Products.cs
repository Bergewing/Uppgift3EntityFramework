using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Products
    {
        public int ProductsID { get; set; }
        public string ProductName { get; set; }
        public int Amount { get; set; }
        public int ExpirationDate { get; set; }
        public double Price { get; set; }
        public int Barcode { get; set; }
        public int CampaignsID { get; set; }
        public int InventoryByID { get; set; }
        public int InventoryDate { get; set; }


        //Navigation Propertys och mer??
        public Employee InventoryBy { get; set; }

        public List<DepartmentProducts> Departments { get; set; }

        public List<Ingredients> Ingredients { get; set; }

    }
}
