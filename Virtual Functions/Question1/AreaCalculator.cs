using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public class AreaCalculator
    {
        public int Radius { get; set; }

        public AreaCalculator(int radius)
        {
            Radius = radius;
        }
        public virtual double Calculate()
        {
            return 3.14 * Radius * Radius;
        }
        public virtual void Display()
        {
            Console.WriteLine("Area : " + Calculate());
        }
    }
}