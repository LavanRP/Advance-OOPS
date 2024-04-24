using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class PermanentEmployee : SalaryInfo
    {
        //EmployeeID, EmployeeType, DA=0.2% of basic, HRA= 0.18% of basic, PF – 0.1 % basic, TotalSalary
        private static int s_pNumber=100;
        public string EmployeeID { get; set; }
        public string EmployeeType { get; set; }
        public double TotalSalary { get; set; }

        public PermanentEmployee(int basicSalary,string month,string employeeType):base(basicSalary,month)
        {
            EmployeeID = "PEID"+s_pNumber;
            s_pNumber++;

            EmployeeType = employeeType;
            TotalSalary = CalculateTotalSalary(BasicSalary);
        }

        public static double CalculateTotalSalary(int basic)
        {
            double da = (basic*0.2)/100;
            double har = (basic*0.18)/100;
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