using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Department
    {
        public int DepartmentID { get; set; } 
        public string Name { get; set; }
        public string Manager { get; set; }

        public List<Products> Products { get; set; }
    }
}
