using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Employee
    {
        public string Title { get; set; }

        public int SSN { get; set; }

        public string Name  { get; set; }

        public int PhoneNr  { get; set; }

        public int EmployeeID { get; set; }

        public int Mentor { get; set; }

        public int EndDate { get; set; }

        public List<Email> Emails { get; set; }
    }
}
