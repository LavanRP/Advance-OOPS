using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender {Male,Female,Others}
    public class PersonalInfo
    {
        //RegistationNumber, Name, FatherName, Phone, DOB, Gender
        private static int s_number=1000;

        public string RegistationNumber { get; set; }
        public string Name { get; set; }
        public string FatherName { get; set; }
        public string Phone { get; set; }
        public DateTime DOB { get; set; }
        public Gender Gender { get; set; }

        public PersonalInfo(string name,string fatherName,string phone,DateTime dob,Gender gender)
        {
            RegistationNumber = "SID"+s_number;
            s_number++;

            Name = name;
            FatherName = fatherName;
            Phone = phone;
            DOB = dob;
            Gender = gender;
        }

    }
}