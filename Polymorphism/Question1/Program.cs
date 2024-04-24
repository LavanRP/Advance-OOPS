using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        Square(2);
        Square(3,4);
        Square(5,6,7);
        Square(5,6.2,7.4f);
        Square(5,6.5);
    }
    public static void Square(int a)
    {
        Console.WriteLine($"Square {a} : {a*a}");
    }
    public static void Square(int a,int b)
    {
        Console.WriteLine($"Square {a} : {a*a}");
        Console.WriteLine($"Square {b} : {b*b}");
    }
    public static void Square(int a,int b,int c)
    {
        Console.WriteLine($"Square {a} : {a*a}");
        Console.WriteLine($"Square {b} : {b*b}");
        Console.WriteLine($"Square {c} : {c*c}");
    }
    public static void Square(int a,double b,float c)
    {
        Console.WriteLine($"Square {a} : {a*a}");
        Console.WriteLine($"Square {b} : {b*b}");
        Console.WriteLine($"Square {c} : {c*c}");
    }
    public static void Square(int a,double b)
    {
        Console.WriteLine($"Square {a} : {a*a}");
        Console.WriteLine($"Square {b} : {b*b}");
    }
}