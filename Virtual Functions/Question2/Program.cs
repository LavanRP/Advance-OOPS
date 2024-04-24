using System;
using System.Drawing;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
       Rectangle rectangle = new Rectangle();
       rectangle.Height = 10;
       rectangle.Length = 10;
       rectangle.Calculate();
       rectangle.Display();

       Sphere sphere = new Sphere();
       sphere.Radius = 10;
       sphere.Calculate();
       sphere.Display();
    }
}