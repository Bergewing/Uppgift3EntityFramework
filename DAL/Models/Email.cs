using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Email
    {
        //[Key]
        //public int ID { get; set; }

        //[Column(Order = 1)]
        public string Emails { get; set; }

        
        //[Column(Order = 2)]
        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }


        
        //Denna ska också vara en multi value likt ingredients
    }
}
