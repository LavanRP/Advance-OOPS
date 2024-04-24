using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        Cylinders cylinders = new Cylinders(2,3,4);
        cylinders.CalculateArea();
        cylinders.CalculateVolume();
        Console.WriteLine();
        Cubes cubes = new Cubes(4);
        cubes.CalculateArea();
        cubes.CalculateVolume();

    }
}