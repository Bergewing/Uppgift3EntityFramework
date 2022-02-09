using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Products
    {   [Key]
        public int ProductsID { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int Amount { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }

        public double Price { get; set; }
        [Required] //Jag försökte köra barcode som PK men Entity vill inte
        public int Barcode { get; set; }
        [Required]
        public int? CampaignsID { get; set; }
        [Required]
        public int InventoryByID { get; set; }
        [Required]
        public DateTime InventoryDate { get; set; }


        //Navigation Propertys
        public Employee InventoryBy { get; set; }
        public List<DepartmentProducts> Departments { get; set; }
        public List<Ingredients> Ingredients { get; set; }
        public Campaigns Campaigns { get; set; }

    }
}
