using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        Studentinfo studentinfo = new Studentinfo("SF1001","lavan",Gender.male,new DateTime(2002,05,12),"9542113451",90,90,90);
        studentinfo.Display();
        studentinfo.CalculateTotal();
        studentinfo.CalculatePercentage();
    }
}