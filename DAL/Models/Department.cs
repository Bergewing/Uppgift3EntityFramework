using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        //public int DepartmentID { get; set; } 
        public string Name { get; set; }
        public int Manager { get; set; }


        //Navigation Property       //En department kan ha många produkter, därav lista
        public List<DepartmentProducts> Products { get; set; }
    }
}
