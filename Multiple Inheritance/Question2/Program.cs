using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        ShiftDezire shift1 = new ShiftDezire(FuleType.Petrol, 4, "blue", 40, 50, "Maruti Suzuki", "2017", "4321", "65432");
        ShiftDezire shift2 = new ShiftDezire(FuleType.Petrol, 4, "green", 40, 50, "Maruti Suzuki", "2018", "12334", "54345");
        shift1.ShowDetails();
        shift1.CalculateMilage(10);
        Console.WriteLine();
        shift2.ShowDetails();
        shift2.CalculateMilage(14);
        Console.WriteLine();

        Eco eco1 = new Eco(FuleType.Diesel, 7, "blue", 40, 25, "Maruti Suzuki", "2019", "1234", "4321");
        Eco eco2 = new Eco(FuleType.Diesel, 7, "red", 40, 20, "Maruti Suzuki", "2017", "9765", "9876");
        eco1.ShowDetails();
        eco1.CalculateMilage(20);
        Console.WriteLine();
        eco2.ShowDetails();
        eco2.CalculateMilage(10);
    }
}