using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL               //städa upp denna sida från kommentarer innan inlämning
{
    public class DepartmentProducts
    {
        //Key 1
        public int ProductsID { get; set; }
        //Navigation Property
        public Products products { get; set; }

        //Key 2
        public string DepartmentID { get; set; }
        //Navigation Property       //Många sidan behöver bara ha en vanlig "class" navigation property
        public Department department { get; set; }
    }
}
