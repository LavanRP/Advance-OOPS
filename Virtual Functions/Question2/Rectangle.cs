using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Rectangle : Dimention
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public override void Calculate()
        {
            Area = Length + Height;
        }
        public override void Display()
        {
            Console.WriteLine("Rectangle area : " + Area);
        }
    }
}