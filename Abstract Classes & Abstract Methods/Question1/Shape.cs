using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public abstract class Shape
    {
        //Radius, Height, Width, Page - a
        public abstract double Area { get; set; }
        public abstract double Volume { get; set; }
        public int Radius { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public int PageA { get; set; }
        
        public Shape(int radius,int height,int width)
        {
            Radius = radius;
            Height = height;
            Width = width;
        }
        public Shape(int pageA)
        {
            PageA = pageA;
        }
        public abstract void CalculateArea();
        public abstract void CalculateVolume();
    }
}