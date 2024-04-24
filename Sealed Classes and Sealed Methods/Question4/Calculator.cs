using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public abstract class Calculator
    {
        public abstract double Area(int a);
        public  double Volume(int b)
        {
            return 3.14*b;
        }

    }
}