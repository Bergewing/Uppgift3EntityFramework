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
        public string Title { get; set; }
        public int SSN { get; set; } //Ändra denna till string med max amount och kanske en try catch?
        public string Name  { get; set; }
        public int PhoneNr  { get; set; } //Samma med denna!
        public int EmployeeID { get; set; }
        public int Mentor { get; set; } //Döpa om denna till MentorID? ändra till att den kan vara null
        public int EndDate { get; set; } //Ändra till datum


        //Navigation propertys
        public List<Email> Emails { get; set; }
        //Navigation Property med "?" som funkar som nullable = True
        public List<Products>? Products { get; set; }
    }
}
