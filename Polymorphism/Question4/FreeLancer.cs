using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class FreeLancer : PersonDetails
    {
        //Role, SalaryAmount, NoOfWorkingDays
        public string Role { get; set; }
        public int NoOfWorkingDays { get; set; }
        public int SalaryAmount { get; set; }
        public FreeLancer(string name,string fatherName,Gender gender,string qualification,string role,int noOfWorkingDays):base(name,fatherName,gender,qualification)
        {
            Role = role;
            NoOfWorkingDays = noOfWorkingDays;
        }
        public virtual void CalculateSalary()
        {
            SalaryAmount = 500*NoOfWorkingDays;
        }

        public virtual void Display()
        {
            CalculateSalary();
            Console.WriteLine("-----FreeLancer-----");
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your Father Name "+FatherName);
            Console.WriteLine("Your Gender "+Gender);
            Console.WriteLine("Your qualification "+Qualification);
            Console.WriteLine("Your Role "+Role);
            Console.WriteLine("Your NoOfWorkingDays "+NoOfWorkingDays);
            Console.WriteLine("Your SalaryAmount "+SalaryAmount);

        }
    }
}