using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class SalaryInfo
    {
        //BasicSalary, Month
        public int BasicSalary { get; set; }
        public string Month { get; set; }

        public SalaryInfo(int basicSalary,string month)
        {
            BasicSalary = basicSalary;
            Month = month;
        }
    }
}