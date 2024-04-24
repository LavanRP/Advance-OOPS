using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public partial class Studentinfo
    {
        public void CalculateTotal()
        {
            Console.WriteLine($"Your total : {Physics+Chemistry+Maths}");
        }
        public void CalculatePercentage()
        {
            int total = Physics+Chemistry+Maths;
            double percentage = (total*100)/300;
            Console.WriteLine($"Your percentage : {percentage} %");
        }
        public void Display()
        {
            Console.WriteLine("Your name : "+Name);
            Console.WriteLine("Your Student ID : "+StudentID);
            Console.WriteLine("Your Gender : "+Gender);
            Console.WriteLine("Your Mobile : "+Mobile);
            Console.WriteLine("Your Physics marks : "+Physics);
            Console.WriteLine("Your Chemistry marks : "+Chemistry);
            Console.WriteLine("Your Maths marks : "+Maths);
           
        }
    }
}