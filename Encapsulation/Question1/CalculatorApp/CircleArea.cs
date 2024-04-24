using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MathsLib;

namespace CalculatorApp
{
    public class CircleArea : Maths
    {
        protected int radius;
        public int Radius { get{return radius;} set{radius = value;} }
        internal double Area {get; set;}
        public double CalculateCircleArea(int val)
        {
            radius = val;
            Area = PI*Radius*Radius;
            return Area;
        }
    }
}