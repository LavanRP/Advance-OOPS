using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorApp
{
    public class CylinderVolume : CircleArea
    {
        private int height;
        public int Height { get{return height;} set{height = value;} }
        internal double Volume { get; set; }
        
        public double CalculateVolume(int val,int val2)
        {
            height = val;
            radius = val2;
            Volume =CalculateCircleArea(Radius)*Height;
            return Volume;
        }        
    }
}