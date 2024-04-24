using System;
namespace Question7;
public class Program
{
    public static void Main(string[] args)
    {
        Attendance attendance1 = new Attendance(30,12,5);
        Attendance attendance2 = new Attendance(31,11,4);
        Attendance attendance3 = new Attendance(30,10,2);
        Attendance attendance4 = attendance1+attendance2;
        Attendance attendance5 = attendance4+attendance3;
        Console.WriteLine("total salary " + attendance5.Salary );
    }
}