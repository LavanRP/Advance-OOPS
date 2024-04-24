using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class StudentInfo : IDisplayInfo
    {
        public string StudentID { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }

        public StudentInfo(string studentID,string name,string fatherName,string mobile)
        {
            StudentID = studentID;
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
        }
        public void Dispay()
        {
            Console.WriteLine($"StudentID : {StudentID}\nName : {Name}\nFather Name : {FatherName}\nMobile : {Mobile}");
        }
    }
}