using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Campaigns
    {
        //PK
        public int ID { get; set; }
        [Required]
        public double PriceReduction { get; set; }
        [Required]
        public string Name { get; set; }

        //En Kampanj kan ha många produkter därav lista
        public List<Products> Products { get; set; }
    }
}
