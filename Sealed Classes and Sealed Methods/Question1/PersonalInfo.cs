using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender{male,female}
    public class PersonalInfo
    {
        // Name, FatherName, Mobile, Mail, Gender
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Mobile { get; set; }
        public string Mail { get; set; }
        public Gender Gender { get; set; }
        
        public void UpdateInfo(string name,string fatherName,string mobile,string mail,Gender gender)
        {
            Name = name;
            FatherName = fatherName;
            Mobile = mobile;
            Mail = mail;
            Gender = gender;
        }
    }
}