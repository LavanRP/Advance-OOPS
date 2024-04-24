using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public enum FuleType{Petrol,Diesel}
    public class Car
    {
        //FuleType, NumberOfSeats, Color, TankCapacity, NumberOfKmDriven
        public FuleType FuleType{ get; set; }
        public int NumberOfSeats { get; set; }
        public string Color { get; set; }
        public int TankCapacity { get; set; }
        public int NumberOfKmDriven { get; set; }

        public Car(FuleType fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven)
        {
            FuleType = fuleType;
            NumberOfSeats = numberOfSeats;
            Color = color;
            TankCapacity = tankCapacity;
            NumberOfKmDriven = numberOfKmDriven;
        }
        public void CalculateMilage(int fuleAmount)
        {
            int mailage = NumberOfKmDriven/fuleAmount;
            Console.WriteLine($"Your car Mailage {mailage}");
        }
    }
}