using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class EmployeeInfo : FamilyInfo
    {
        public string EmployeeID { get; set; }
        public DateTime DateOfJoining { get; set; }
        
        public EmployeeInfo(string motherName,int noOfSiblings,string nativePlace,string employeeID,DateTime dateOfJoining):base(motherName,noOfSiblings,nativePlace)
        {
            EmployeeID = employeeID;
            DateOfJoining = dateOfJoining;
        }
        public override void Update(string name, string fatherName, string mobile, string mail, Gender gender )
        {
            base.Update(name, fatherName, mobile, mail, gender);
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Your name "+Name);
            Console.WriteLine("Your EmployeeID "+EmployeeID);
            Console.WriteLine("Your DateOfJoining "+DateOfJoining);
            Console.WriteLine("Your FatherName "+FatherName);
            Console.WriteLine("Your MotherName "+MotherName);
            Console.WriteLine("Your NoOfSiblings "+NoOfSiblings);
            Console.WriteLine("Your FatherName "+FatherName);
            Console.WriteLine("Your NativePlace "+NativePlace);
            Console.WriteLine("Your Mobile "+Mobile);
            Console.WriteLine("Your Gender "+Gender);
        }
        
    }
}