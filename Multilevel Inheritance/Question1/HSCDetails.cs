using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Question1
{
    public class HSCDetails : StudentInfo
    {
        private static int s_sheetNumber=5000;
        public string HSCMarksheetNumber { get; set; }
        public int Physics { get; set; }
        public int Chemistry { get; set; }
        public int Maths { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }

        public HSCDetails(string name, string fatherName, string phone, string mail, DateTime dob, Gender gender,string registerNumber, string standard, string branch, string acadamicYear,int physics,int chemistry,int maths) :base(name,fatherName,phone,mail,dob,gender,registerNumber,standard,branch,acadamicYear)
        {
            HSCMarksheetNumber = "HSC"+ s_sheetNumber;
            s_sheetNumber++;
            GetMarks(physics,chemistry,maths);
        }
        public double CalculateTotal(int Physics,int Chemistry,int Maths)
        {
            return Physics+Chemistry+Maths;
        }

        public double CalculatePercentage(double Total)
        {
            double percentage = (Total/300)*100;
            return percentage;
        }

        public void GetMarks(int physics,int chemistry,int maths)
        {
            Physics = physics;
            Chemistry = chemistry;
            Maths = maths;
            Total = CalculateTotal(Physics,Chemistry,Maths);
            Percentage = CalculatePercentage(Total);
        }

        public void ShowMarksheet()
        {
            Console.WriteLine("------Your Marksheet------");
            Console.WriteLine($"Your HSCMarksheetNumber: {HSCMarksheetNumber}\nYour Physics Marks: {Physics}\nYour Chemistry Marks: {Chemistry}\nYour Maths Marks: {Maths}\nYour Total Marks: {Total}\nYour Percentage: {Percentage}");
        }
    }
}