using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DepartmentProducts
    {
        //Key 1
        public int ProductsID { get; set; }
        //Navigation Property
        public Products Products { get; set; }

        //Key 2
        public string DepartmentID { get; set; }
        //Navigation Property
        public Department Department { get; set; }
    }
}
