using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo();
        employee.UserID = "SF1001";
         employee.Password = "123456";
        employee.Name = "Lavan";
        employee.FatherName = "Ramesh";
        employee.Gender = Gender.male;
        employee.Mail = "lavan@gmail.com";
        employee.Mobile = "9984772647";
       
       Hack hack = new Hack();
       hack.GetUserInfo();
       hack.ShowKeyInfo();
       hack.ShowUserInfo();

    }
}