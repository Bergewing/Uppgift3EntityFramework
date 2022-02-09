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
        //Key1
        public string Ingredient { get; set; }

        //key2
        public int ProductsID { get; set; }


        //Navigation Property
        public Products products { get; set; }

    }
}
