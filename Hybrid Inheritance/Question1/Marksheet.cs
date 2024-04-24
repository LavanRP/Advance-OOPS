using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Threading.Tasks;

namespace Question1
{
    public class Marksheet :TheoryExamMarks,ICalculate
    {
        //MarksheetNumber, DateOfIssue, Total, Percentage
        private  static int s_mNumber=1000;

        public string MarksheetNumber { get; set; }
        public DateTime DateOfIssue { get; set; }
        public double Total { get; set; }
        public double Percentage { get; set; }
        public double ProjectMark { get; set; }

        public Marksheet(string name,string fatherName,string phone,DateTime dob,Gender gender,int[] sem1,int[] sem2,int[] sem3,int[] sem4,DateTime dateOfIssue,double projectMark): base(name,fatherName,phone,dob,gender,sem1,sem2,sem3,sem4)
        {
            MarksheetNumber = "MID"+s_mNumber;
            s_mNumber++;
             
            DateOfIssue = dateOfIssue;
            ProjectMark = projectMark;
            Total = CalculateUGTotal(sem1,sem2,sem3,sem4,ProjectMark);
            Percentage = CalculateUGPercentage(Total);

        }
        public double CalculateUGTotal(int[] sem1,int[] sem2,int[] sem3,int[] sem4,double projectMark)
        {
            double total = 0.0;
            for (int i=0;i<sem1.Length;i++)
            {
                total = sem1[i]+sem2[i]+sem3[i]+sem4[i]+total;
            }
            total = total + projectMark;
            return total;
        }
        public double CalculateUGPercentage(double total)
        {
            double percentage = (total/2500)*100;
            return percentage;
        }
        public void SHowUGMarkSHeet()
        {
            Console.WriteLine($"Your RegistationNumber: {RegistationNumber}\nYour Name: {Name}\nYour Marksheet Number: {MarksheetNumber}\nYour Mark Sheet Date Of Issue: {DateOfIssue}\nYour Total: {Total}\nYour Percentage: {Percentage}");
        }
    }
}