using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public  class CircleCalculator : Calculator
    {
        public double CircleArea { get; set; }
        
        
        public sealed override double Area(int a)
        {
            CircleArea = 3.14*a*a;
            return CircleArea;
        }
    }
}