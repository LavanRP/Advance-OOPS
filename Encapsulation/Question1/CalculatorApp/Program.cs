using System;
namespace CalculatorApp;
using MathsLib;
public class Program
{
    public static void Main(string[] args)
    {
        Maths mat = new Maths();
        CircleArea area = new CircleArea();
        CylinderVolume volume = new CylinderVolume();

        Console.WriteLine("Weight : "+mat.CalculateWeight(8));
        Console.WriteLine("Area : "+area.CalculateCircleArea(10));
        Console.WriteLine("Volume : "+volume.CalculateVolume(10,10));
        
    }
}