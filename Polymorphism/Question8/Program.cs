using System;
namespace Question8;
public class Program
{
    public static void Main(string[] args)
    {
        Calculator sem1 = new Calculator(90, 90, 90, 90, 90, 90);
        Calculator sem2 = new Calculator(90, 90, 90, 90, 90, 90);
        Calculator sem3 = new Calculator(90, 90, 90, 90, 90, 90);
        Calculator sem4 = new Calculator(90, 90, 90, 90, 90, 90);
        Calculator calculator1 = sem1 + sem2;
        Calculator calculator2 = sem3 + sem3;
        Calculator calculator3 = calculator1 + calculator2;

        Console.WriteLine("Total marks for 4 sem " + calculator3.Total);
        Console.WriteLine("Total Percentage for 4 sem " + calculator3.Percentage);
    }
}