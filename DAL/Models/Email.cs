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
        //Key1 Ligger i modelbuilder, nullable=true
        public string? Emails { get; set; }

        
        //Key2 Ligger i modelbuilder
        public int EmployeeID { get; set; }


        //Navigation Property
        public Employee Employee { get; set; }
    }
}
