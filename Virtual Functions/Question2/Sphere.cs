using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Sphere : Dimention
    {
        public int Radius { get; set; }
        public override void Calculate()
        {
            Area = 4*3.14*Radius*Radius;
        }
        public override void Display()
        {
            Console.WriteLine("Sphere area : " + Area);
        }
    }
}