using System;
using Question1;
namespace Question;
public class Program
{
    public static void Main(string[] args)
    {
        EmployeeInfo employee = new EmployeeInfo("EID1002","lavan",Gender.male,new DateTime(2002,05,12),"9438882940");
        employee.Display();
        Console.WriteLine();
        employee.Update("9483687592");
        Console.WriteLine();
        employee.Display();
    }
}