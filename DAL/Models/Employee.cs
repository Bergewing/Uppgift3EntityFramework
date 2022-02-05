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
        public string SSN { get; set; } //Ändra denna till string med max amount och kanske en try catch?
        [Required]
        public string Name  { get; set; }
        [MaxLength(10)]//Inte Requiered
        public string? PhoneNr  { get; set; } //Samma med denna!
        //Nullable=true
        public int? MentorID { get; set; } //Döpa om denna till MentorID? ändra till att den kan vara null
        //Nullable=true
        public DateTime? EndDate { get; set; }

        //Detta är Mentor Relationen som snurrar runt i cirkel runt i Employee, båda är nullable=true
        public virtual Employee? Mentor { get; set; }
        public List<Employee>? Trainees { get; set; }
        //----------------------------------------------------------

        //Navigation propertys
        public List<Email> Emails { get; set; }
        //Navigation Property med "?" som funkar som nullable = True
        public List<Products>? Products { get; set; }
    }
}
