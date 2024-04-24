using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question5
{
    public class EmployeeInfo : PersonalInfo
    {
        private static int s_eNumber = 1000;
        public string EmployeeID { get; set; }
        public EmployeeInfo(string name,string fatherName,string mobileNumber,Gender gender):base(name,fatherName,mobileNumber,gender)
        {
            EmployeeID = "EID"+s_eNumber;
            s_eNumber++;
        }
        public override void Display()
        {
            Console.WriteLine("Your EmployeeID "+EmployeeID);
            Console.WriteLine("Your Name "+Name);
            Console.WriteLine("Your Father Name "+FatherName);
            Console.WriteLine("Your Mobile number "+MobileNumber);
            Console.WriteLine("Your Gender "+Gender);
            
        }
    }
}