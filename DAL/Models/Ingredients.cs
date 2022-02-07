using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Ingredients
    {
        //Key1 Ligger i modelbuilder
        public string Ingredient { get; set; }

        //key2 Ligger i modelbuilder
        public int ProductsID { get; set; }
        //Key 1 och 2 blir composite key


        //En ingredient kan bara kopplas till en produkt därav bara en vanlig "class" navigation property
        public Products products { get; set; }

    }
}
