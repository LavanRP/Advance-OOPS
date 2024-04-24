using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question5
{
    public enum Gender { male, female }
    public abstract class PersonalInfo
    {
        //Name, FatherName,MobileNumber,Gender
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string MobileNumber { get; set; }
        public Gender Gender { get; set; }
        public PersonalInfo(string name,string fatherName,string mobileNumber,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            MobileNumber = mobileNumber;
            Gender = gender;
        }
        public abstract void Display();
    }
}