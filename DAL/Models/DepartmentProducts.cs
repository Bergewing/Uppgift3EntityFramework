using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentProducts
    {
        
        public int ProductsID { get; set; }
        public Products products { get; set; }

        public int DepartmentID { get; set; }
        public Department department { get; set; }

        //Hur funkar primary keys i N:M relationer?
    }
}
