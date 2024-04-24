using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question5
{
    
    public class SalaryInfo : EmployeeInfo
    {
        public int NumberOfDaysWorked { get; set; }
        public SalaryInfo(string name,string fatherName,string mobileNumber,Gender gender,int numberOfDaysWorked):base(name,fatherName,mobileNumber,gender)
        {
            NumberOfDaysWorked = numberOfDaysWorked;
        }

        public override void Display()
        {
            Console.WriteLine();
            base.Display();
            Console.WriteLine($"Your Salary : {NumberOfDaysWorked*500}");
        }
    }
}