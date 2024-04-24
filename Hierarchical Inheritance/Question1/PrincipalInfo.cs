using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class PrincipalInfo : PersonalInfo
    {
        //PrincipalID, Qualification, YearOfExperience, DateOfJoining
        private static int s_pNumber=100;
        public string PrincipalID { get; set; } 
        public string Qualification { get; set; } 
        public int YearOfExperience { get; set; } 
        public DateTime DateOfJoining { get; set; }

        public  PrincipalInfo(string name,string fatherName,DateTime dob,string phone,Gender gender,string mail,string qualification,int yearOfExperience,DateTime dateOfJoining):base(name,fatherName,dob,phone,gender,mail)
        {
            PrincipalID = "PID"+s_pNumber;
            s_pNumber++;
            
            Qualification = qualification;
            YearOfExperience = yearOfExperience;
            DateOfJoining = dateOfJoining;
        }
        public void ShowDetails()
        {
            Console.WriteLine("-----Principal Details-----");
            Console.WriteLine($"Your Name: {Name}\nYour FatherName: {FatherName}\nYour DOB: {DOB}\nYour Phone: {Phone}\nYour Gender: {Gender}\nYour Mail: {Mail}\nYour PrincipalID: {PrincipalID}\nYour Qualification: {Qualification}\nYour Year Of Experience: {YearOfExperience}\nYour Date Of Joining: {DateOfJoining}");
        }
    }
}