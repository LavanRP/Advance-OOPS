using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public enum Gender{Male,Female,Others}
    public enum Maritaldetails{Married,single}
    public class Personalnfo : IShowData
    {
        //Name, Gender,DOB, Phone, Maritaldetails – Married/single
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public DateTime DOB { get; set; }
        public string Phone { get; set; }
        public Maritaldetails Maritaldetails { get; set; }

        public Personalnfo(string name,Gender gender,DateTime dob,string phone, Maritaldetails maritaldetails)
        {
            Name = name;
            Gender = gender;
            DOB = dob;
            Phone = phone;
            Maritaldetails = maritaldetails;
        }
        public void ShowInfo()
        {
            Console.WriteLine("-----Personal Info-----");
            Console.WriteLine($"Your Name: {Name}\nYour Gender: {Gender}\nYour DOB: {DOB}\nYour Phone: {Phone}\nYour Marital details: {Maritaldetails}");
        }
    }
}