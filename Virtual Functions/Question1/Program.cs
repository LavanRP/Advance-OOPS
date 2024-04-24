using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        AreaCalculator area = new AreaCalculator(10);
        area.Display();
        Console.WriteLine();
        VolumeCalculator volume = new VolumeCalculator(10,20);
        volume.Display();
    }
}