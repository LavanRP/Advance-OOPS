using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        private static int s_number = 3000;

        public string RegisterNumber { get; set; }
        public string Standard { get; set; }
        public string Branch { get; set; }
        public string AcadamicYear { get; set; }

        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender, string standard, string branch, string acadamicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            GetStudentInfo(standard,branch,acadamicYear);
        }

        public StudentInfo(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender,string registerNumber, string standard, string branch, string acadamicYear) : base(name, fatherName, phone, mail, dob, gender)
        {
            RegisterNumber = registerNumber;
            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
        public void GetStudentInfo(string standard, string branch, string acadamicYear)
        {
            RegisterNumber = "SF" + s_number;
            s_number++;

            Standard = standard;
            Branch = branch;
            AcadamicYear = acadamicYear;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Your Name: {Name}\nYour Fathername: {FatherName}\nYour Phone number: {Phone}\nYour Mail ID: {Mail}\nYour DOB: {DOB}\nYour Gender: {Gender}\nYour school register number: {RegisterNumber}\nYour Standard: {Standard}\nYour Branch: {Branch}\nYour AcadamicYear: {AcadamicYear}");
        }
    }
}