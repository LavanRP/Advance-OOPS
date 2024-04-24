using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class VolumeCalculator : AreaCalculator
    {
        public int Height { get; set; }

        public VolumeCalculator(int radius,int height):base(radius)
        {
            Radius = radius;
            Height = height;
        }
        public override double Calculate()
        {
            return 3.14*Radius*Radius*Height;
        }
        public override void Display()
        {
            Console.WriteLine("Volume : "+Calculate());
        }
    }
}