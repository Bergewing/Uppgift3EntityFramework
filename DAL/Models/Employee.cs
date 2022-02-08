using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DAL
{
    public class Employee
    {
        //PK
        public int EmployeeID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required] [MaxLength(10)]
        public string SSN { get; set; }
        [Required]
        public string Name  { get; set; }
        [MaxLength(10)]
        public string? PhoneNr  { get; set; }
        public int? MentorID { get; set; }
        public DateTime? EndDate { get; set; }

        //Mentor relationen
        public virtual Employee? Mentor { get; set; }
        public List<Employee>? Trainees { get; set; }
        //------------------

        //Navigation propertys
        public List<Email> Emails { get; set; }
        public List<Products>? Products { get; set; }
    }
}
