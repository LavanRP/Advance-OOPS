using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class Cubes : Shape
    {
        public override double Area { get; set; }
        public override double Volume { get; set; }
        public Cubes(int pageA):base(pageA)
        {

        }
        public override void CalculateArea()
        {
            Area = 6*PageA*PageA;
            Console.WriteLine("Area of Cubes: "+Area);
        }
        public override void CalculateVolume()
        {
            Volume = PageA*PageA*PageA;
            Console.WriteLine("Volume of Cubes : "+Volume);
        }
    }
}