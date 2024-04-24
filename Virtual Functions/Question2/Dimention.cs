using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class Dimention
    {
        public int Value1 { get; set; }
        public int Value2 { get; set; }
        public double Area { get; set; }
        public virtual void Calculate()
        {
            Area = Value1+Value2;
        }
        public virtual void Display()
        {
            Console.WriteLine("Dimention area : "+Area);
        }
    }
}