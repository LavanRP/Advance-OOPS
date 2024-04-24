using System;
namespace Question5;
public class Program
{
    public static void Main(string[] args)
    {
        PersonalInfo personal1 = new EmployeeInfo("Lavan","Ramesh","123456",Gender.male);
        personal1.Display();

        PersonalInfo personal2 = new SalaryInfo("Lavan","Ramesh","12345",Gender.male,10);
        personal2.Display();
    }
}