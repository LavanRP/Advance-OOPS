using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        StudentInfo student = new StudentInfo("SID1001","Lavan","ramesh","9876543");
        student.Dispay();
        Console.WriteLine();

        EmployeeInfo employee = new EmployeeInfo("SF1001","lavan","ramesh");
        employee.Dispay();
    }
}