using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question8
{
    public class Calculator
    {
        public int Mark1 { get; set; }
        public int Mark2 { get; set; }
        public int Mark3 { get; set; }
        public int Mark4 { get; set; }
        public int Mark5 { get; set; }
        public int Mark6 { get; set; }
        public int Total { get; set; }
        public double Percentage { get; set; }
        
        public Calculator(int mark1,int mark2,int mark3,int mark4,int mark5,int mark6)
        {
            Mark1 = mark1;
            Mark2 = mark2;
            Mark3 = mark3;
            Mark4 = mark4;
            Mark5 = mark5;
            Mark6 = mark6;
            Total = Mark1+Mark2+Mark3+Mark4+Mark5+Mark6;
            Percentage = (Total*100)/600;

        }
        public static Calculator operator+(Calculator calculator1,Calculator calculator2)
        {
            Calculator calculator3 = new Calculator(0,0,0,0,0,0);
            calculator3.Total = calculator2.Total+calculator1.Total;
            calculator3.Percentage = (calculator2.Percentage+calculator1.Percentage)/2;
            return calculator3;
        }
        
    }
}