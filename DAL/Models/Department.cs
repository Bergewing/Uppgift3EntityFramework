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
        [MaxLength(50)]
        public string Name { get; set; }
        public int ManagerID { get; set; }


        //Navigation Propertys
        public List<DepartmentProducts> Products { get; set; }

        public Employee Manager { get; set; }
    }
}
