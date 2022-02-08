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
        //Key1
        public string? Emails { get; set; }
        
        //Key2
        public int EmployeeID { get; set; }


        //Navigation Property
        public Employee Employee { get; set; }
    }
}
