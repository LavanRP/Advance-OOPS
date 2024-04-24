using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public enum Gender {male,female,others}
    public class PersonalInfo
    {
        //Name, FatherName, Mobile, Mail, Gender
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        
        public virtual void Update(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Your name "+Name);
            Console.WriteLine("Your FatherName "+FatherName);
            Console.WriteLine("Your Mail "+Mail);
            Console.WriteLine("Your Mobile "+Mobile);
            Console.WriteLine("Your Gender "+Gender);
        }
    }
}