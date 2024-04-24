using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class TemporaryEmployee : SalaryInfo
    {
        private static int s_tNumber=100;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double TotalSalary { get; set; }

        public TemporaryEmployee(int basicSalary,string month,string employeeType):base(basicSalary,month)
        {
            EmployeeID = "TEID"+s_tNumber;
            s_tNumber++;

            EmployeeType = employeeType;
            TotalSalary = CalculateTotalSalary(BasicSalary);
        }

        public static double CalculateTotalSalary(int basic)
        {
            double da = (basic*0.15)/100;
            double har = (basic*0.13)/100;
            double pf = (basic*0.1)/100;
            double total = basic+da+har-pf;
            return total;
        }
        public void ShowSalary()
        {

            Console.WriteLine("EmployeeID: "+EmployeeID);
            Console.WriteLine("Salary: "+TotalSalary);
        }
    }
}