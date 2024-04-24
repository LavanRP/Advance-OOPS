using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Syncfusion : FreeLancer
    {
        //EmployeeID, Worklocation
        private static int s_eNumber = 1001;
        public string EmployeeID { get; set; }
        public string Worklocation { get; set; }

        public Syncfusion(string name, string fatherName, Gender gender, string qualification, string role, int noOfWorkingDays, string worklocation) : base(name, fatherName, gender, qualification, role, noOfWorkingDays)
        {
            EmployeeID = "SF" + s_eNumber;
            s_eNumber++;
            Worklocation = worklocation;
        }
        public override void CalculateSalary()
        {
            SalaryAmount = 500 * NoOfWorkingDays;
        }

        public override void Display()
        {
            CalculateSalary();
            Console.WriteLine("-----Syncfusion-----");
            Console.WriteLine("Your EmployeeID " + EmployeeID);
            Console.WriteLine("Your Worklocation " + Worklocation);
            Console.WriteLine("Your Name " + Name);
            Console.WriteLine("Your Father Name " + FatherName);
            Console.WriteLine("Your Gender " + Gender);
            Console.WriteLine("Your qualification " + Qualification);
            Console.WriteLine("Your Role " + Role);
            Console.WriteLine("Your NoOfWorkingDays " + NoOfWorkingDays);
            Console.WriteLine("Your SalaryAmount " + SalaryAmount);
        }
    }
}