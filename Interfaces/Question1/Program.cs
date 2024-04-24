using System;
namespace Question1;
public class Program
{
    public static void Main(string[] args)
    {
        Dog dog1 = new Dog();
        dog1.DisplayName();
        dog1.DisplayInfo("forests","bones");
        Console.WriteLine();
        Dog dog2 = new Dog();
        dog2.DisplayName();
        dog2.DisplayInfo("brush lands","meat");

        Console.WriteLine();

        Duck duck1 = new Duck();
        duck1.DisplayName();
        duck1.DisplayInfo("rivers","Earthworms");
        Console.WriteLine();
        Duck duck2 = new Duck();
        duck2.DisplayName();
        duck2.DisplayInfo("ponds","slugs");
    }
}