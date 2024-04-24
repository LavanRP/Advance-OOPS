using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class EmployeeInfo : IDisplayInfo
    {
        
        public string EmployeeID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }


        public EmployeeInfo(string employeeID,string name,string fatherName)
        {
            EmployeeID = employeeID;
            Name = name;
            FatherName = fatherName;
        }
        public void Dispay()
        {
            Console.WriteLine($"StudentID : {EmployeeID}\nName : {Name}\nFather Name : {FatherName}");
        }
    }
}