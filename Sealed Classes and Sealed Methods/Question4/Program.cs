using System;
namespace Question4;
public class Program
{
    public static void Main(string[] args)
    {
        CylinderCalculator cylinderCalculator = new CylinderCalculator();
        Console.WriteLine(cylinderCalculator.Area(10));
        Console.WriteLine( cylinderCalculator.Volume(20));
       

    }
}
