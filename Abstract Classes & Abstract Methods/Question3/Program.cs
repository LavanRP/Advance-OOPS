using System;
namespace Question3;
public class Program
{
    public static void Main(string[] args)
    {
        MaruthiSwift swift = new MaruthiSwift();
        swift.GetEngineType(Enginetype.Petrol);
        swift.GetCarType(CarType.hatchback);
        swift.GetNoOfSeats(4);
        swift.GetPrice(10000000);
        swift.DisplayCarDetail();
        Console.WriteLine();
        SuzukiCiaz ciaz = new SuzukiCiaz();
        ciaz.GetEngineType(Enginetype.diesel);
        ciaz.GetCarType(CarType.suv);
        ciaz.GetNoOfSeats(6);
        ciaz.GetPrice(10000000);
        ciaz.DisplayCarDetail();
    }
}