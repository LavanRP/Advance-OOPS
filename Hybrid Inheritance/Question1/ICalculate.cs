using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question1
{
    public interface ICalculate
    {
        double ProjectMark{get;set;}
        double CalculateUGTotal(int[] sem1,int[] sem2,int[] sem3,int[] sem4,double projectMark);
        double CalculateUGPercentage(double total);
    }
}