using System;
using System.Collections.Generic;
using System.Net;
namespace Question1;
public class Program
{
    public static List<HSCDetails> hSCList = new List<HSCDetails>();
    public static void Main(string[] args)
    {
        string flag="yes";
        do
        {
            Console.WriteLine("-----welcome-----");
            Console.WriteLine("1.register\n2.login\n3.Exit");
            Console.WriteLine("Select an optiion");
            int mainOption = int.Parse(Console.ReadLine());
            switch(mainOption)
            {
                case 1:
                {
                    Register();
                    break;
                }
                case 2:
                {
                    Login();
                    break;
                }
                case 3:
                {
                    flag="no";
                    break;
                }
                default:
                {
                    Console.WriteLine("enter valid number");
                    break;
                }
            }
        }while(flag == "yes");
    }
    public static void Register()
    {
        Console.WriteLine("Enter your personal detials");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Enter your name");
        string name = Console.ReadLine();
        Console.WriteLine("Enter your fathers name");
        string fatherName = Console.ReadLine();
        Console.WriteLine("Enter your Gender (Male,female,others)");
        Gender gender = Enum.Parse<Gender>(Console.ReadLine(), true);
        Console.WriteLine("Enter your DOB: dd/MM/yyyy");
        DateTime dob = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", null);
        Console.WriteLine("Enter your Mail Id");
        string mailid = Console.ReadLine();
        Console.WriteLine("Enter your Phone number");
        string number = Console.ReadLine();
        PersonalInfo personal = new PersonalInfo(name, fatherName, number, mailid, dob, gender);
        Console.WriteLine();


        Console.WriteLine("Enter your Student detials");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Enter your Standard");
        string standard = Console.ReadLine();
        Console.WriteLine("Enter your Branch");
        string branch = Console.ReadLine();
        Console.WriteLine("Enter your AcadamicYear");
        string acadamicYear = Console.ReadLine();
        StudentInfo student = new StudentInfo(personal.Name, personal.FatherName, personal.Phone, personal.Mail, personal.DOB, personal.Gender, standard, branch, acadamicYear);
        Console.WriteLine("your student id is: " + student.RegisterNumber);
        Console.WriteLine();


        Console.WriteLine("Enter your HSC Details");
        Console.WriteLine("--------------------------------");
        Console.WriteLine("Enter your Physics");
        int physics = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your Chemistry");
        int chemistry = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter your Maths");
        int maths = int.Parse(Console.ReadLine());
        HSCDetails hSCDetails = new HSCDetails(student.Name, student.FatherName, student.Phone, student.Mail, student.DOB, student.Gender, student.RegisterNumber, student.Standard, student.Branch, student.AcadamicYear, physics, chemistry, maths);
        Console.WriteLine("your HSC mark sheet number is: " + hSCDetails.HSCMarksheetNumber);
        hSCList.Add(hSCDetails);
    }
    public static void Login()
    {
        Console.WriteLine("Enter your student registration number");
        string num=Console.ReadLine().ToUpper();
        int count =0;
        foreach(HSCDetails hSC in hSCList)
        {
            if(num.Equals(hSC.RegisterNumber))
            {
                count++;
                string flag1="yes";
                do
                {
                    Console.WriteLine("-----welcome-----");
                    Console.WriteLine("1.ShowInfo\n2.show marksheet\n3.Exit");
                    Console.WriteLine("Select an optiion");
                    int num2 = int.Parse(Console.ReadLine());
                    switch(num2)
                    {
                        case 1:
                        {
                            hSC.ShowInfo();
                            break;
                        }
                        case 2:
                        {
                            hSC.ShowMarksheet();
                            break;
                        }
                        case 3:
                        {
                            flag1="no";
                            break;
                        }
                        default:
                        {
                            Console.WriteLine("enter valid number");
                            break;
                        }
                    }

                }while(flag1 == "yes");
                break;
            }
        }
        if(count == 0)
        {
            Console.WriteLine("enter valid Registration number: ");
        }
    }
}