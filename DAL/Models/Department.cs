using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Department
    {
        //public int DepartmentID { get; set; } 

        [MaxLength(50)]
        public string Name { get; set; }
        public int ManagerID { get; set; }


        //Navigation Property       //En department kan ha många produkter, därav lista
        public List<DepartmentProducts> Products { get; set; }

        public Employee Manager { get; set; }
    }
}
