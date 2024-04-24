using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal1 = new PersonalInfo("Lavan","Ramesh","23456789","lavan@gmail.com",new DateTime(2002,05,12),Gender.Male);
        PersonalInfo personal2 = new PersonalInfo("Kumar","Kishore","987654","kumar@gmail.com",new DateTime(2002,07,2),Gender.Male);
        
        StudentInfo student1= new StudentInfo(personal1.Name,personal1.FatherName,personal1.Phone,personal1.Mail,personal1.DOB,personal1.Gender,"11","CSE","2020");
        StudentInfo student2= new StudentInfo(personal2.Name,personal2.FatherName,personal2.Phone,personal2.Mail,personal2.DOB,personal2.Gender,"11","BIO","2020");

        student1.ShowStudentInfo();
        Console.WriteLine();
        student2.ShowStudentInfo();
    }
}