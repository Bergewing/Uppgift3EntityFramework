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
        public string Ingredient { get; set; }
        public string Product { get; set; }

        public Products products { get; set; }

        //Hur funkar Multi value attributes??
        //Hur gör jag primary keys?
    }
}
