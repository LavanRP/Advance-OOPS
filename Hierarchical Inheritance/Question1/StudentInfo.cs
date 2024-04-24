using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class StudentInfo : PersonalInfo
    {
        //StudentID, Degree, Department, semester
        private static int s_sNumber=100;
        public string StudentID { get; set; }
        public string Degree { get; set; }
        public string Department { get; set; }
        public int Semester { get; set; }

        public StudentInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string degree,string department,int semester):base(name,fatherName,dob,phone,gender,mail)
        {
            StudentID = "SDI"+s_sNumber;
            s_sNumber++;

            Degree = degree;
            Department = department;
            Semester = semester;
        }

        public void ShowDetails()
        {
            Console.WriteLine("-----Student Details-----");
            Console.WriteLine($"Your Name: {Name}\nYour FatherName: {FatherName}\nYour DOB: {DOB}\nYour Phone: {Phone}\nYour Gender: {Gender}\nYour Mail: {Mail}\nYour StudentID: {StudentID}\nYour Department: {Department}\nYour Degree: {Degree}\nYour Semester: {Semester}");
        }
    }
}