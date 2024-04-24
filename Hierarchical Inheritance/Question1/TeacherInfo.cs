using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class TeacherInfo : PersonalInfo
    {
        private static int s_tNumber=100;
        //TeacherID, Department, SubjectTeaching, Qualification, YearOfExperience, DateOfJoining
        public string TeacherID { get; set; }
        public string Department { get; set; }
        public string SubjectTeaching { get; set; }
        public string Qualification { get; set; }
        public int YearOfExperience { get; set; }
        public DateTime DateOfJoining { get; set; }

        public TeacherInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string department,string subjectTeaching,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            TeacherID = "TI"+s_tNumber;
            s_tNumber++;

            Department = department;
            SubjectTeaching = subjectTeaching;
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }

        public void ShowDetails()
        {
            Console.WriteLine("-----Teacher Details-----");
            Console.WriteLine($"Your Name: {Name}\nYour FatherName: {FatherName}\nYour DOB: {DOB}\nYour Phone: {Phone}\nYour Gender: {Gender}\nYour Mail: {Mail}\nYour TeacherID: {TeacherID}\nYour Department: {Department}\nYour Subject Teaching: {SubjectTeaching}\nYour Qualification: {Qualification}\nYour Year Of Experience: {YearOfExperience}\nYour Date Of Joining: {DateOfJoining}");
        }
    }
}