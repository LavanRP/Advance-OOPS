using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class ShiftDezire : Car,IBrand
    {
        //MakingID(Auto), EngineNumber, ChasisNumber
        private static int s_mNumber=200;
        public string MakingID { get; set; }
        public string EngineNumber { get; set; }
        public string ChasisNumber { get; set; }
        public string BrandName{ get; set; }
        public string ModelName{ get; set; }

        public ShiftDezire(FuleType fuleType,int numberOfSeats,string color,int tankCapacity,int numberOfKmDriven,string brandName,string modelName,string engineNumber,string chasisNumber):base(fuleType,numberOfSeats,color,tankCapacity,numberOfKmDriven)
        {
            MakingID = "MID"+s_mNumber;
            s_mNumber++;
            EngineNumber = engineNumber;
            ChasisNumber = chasisNumber;
            BrandName = brandName;
            ModelName = modelName;
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Car Brand Name: {BrandName}\nCar Model Name: {ModelName}\nCar MakingID: {MakingID}\nCar Engine Number: {EngineNumber}\nCar Chasis Number: {ChasisNumber}\nCar Fule Type: {FuleType}\nNumber Of Seats: {NumberOfSeats}\nCar Color: {Color}\nCar Tank Capacity: {TankCapacity}\nNumber Of Km Driven: {NumberOfKmDriven}");
        }
    }
}