using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class CylinderCalculator : Calculator
    {
        public double CircleArea { get; set; }
        public double CylinderVolume { get; set; }

        public  override double Area(int a)
        {
            CircleArea = 3.14*a*a;
            return CircleArea;
        }
        public new double Volume(int b)
        {
            CylinderVolume = CircleArea * b;
            return CylinderVolume;
        }
        
    }
}