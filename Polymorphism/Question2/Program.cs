using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        Square(10);
        Square(10.5);
        Square(11.5f);
        Square(911234567876543);

    }
    public static void Square(int a)
    {
        Console.WriteLine($"Square {a} : {a*a}");
    }
    public static void Square(double a)
    {
        Console.WriteLine($"Square {a} : {a*a}");
    }
    public static void Square(float a)
    {
        Console.WriteLine($"Square {a} : {a*a}");
    }
    public static void Square(long a)
    {
        Console.WriteLine($"Square {a} : {a*a}");
    }
}