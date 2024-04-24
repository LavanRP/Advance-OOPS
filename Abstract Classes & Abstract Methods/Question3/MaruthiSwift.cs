using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class MaruthiSwift : Car
    {
        public override void GetEngineType(Enginetype enginetype)
        {
            Enginetype = enginetype;
        }
        public override void GetNoOfSeats(int noOfSeats )
        {
            NoOfSeats = noOfSeats;
        }
        public override void GetPrice(int price )
        {
            Price = price;
        }
        public override void GetCarType(CarType carType)
        {
            CarType = carType;
        }
        public override void DisplayCarDetail()
        {
            Console.WriteLine($"Car Enginetype: {Enginetype}\nNo Of Seats: {NoOfSeats}\nCar Price: {Price}\nCar Car Type: {CarType}");
            ShowWheels();
            ShowDoors();
        }
        
    }
}