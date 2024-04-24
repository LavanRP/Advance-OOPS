using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public enum Enginetype{Petrol,diesel,cng}
    public enum CarType{hatchback,sedan,suv}
    public abstract class Car
    {
        private static int NoOfWheels = 4;
        private static int NoOfDoors = 4;

        //Enginetype -Petrol,diesel,cng, NoOfSeats,price , CarType -hatchback,sedan, suv
        public Enginetype Enginetype { get; set; }
        public int NoOfSeats { get; set; }
        public int Price { get; set; }
        public CarType CarType { get; set; }

        public abstract void GetEngineType(Enginetype enginetype);
        public abstract void GetNoOfSeats(int noOfSeats );
        public abstract void GetPrice(int price );
        public abstract void GetCarType(CarType carType);
        public abstract void DisplayCarDetail();

        public void  ShowWheels()
        {
            Console.WriteLine($"Number of Wheels: {NoOfWheels}");
        }
        public void  ShowDoors()
        {
            Console.WriteLine($"Number of Wheels: {NoOfDoors}");
        }
    }
}