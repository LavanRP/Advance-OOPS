using System;
namespace Question3;
public class Program
{
    public static void Main(string[] args)
    {
        CSEDepartment cse = new CSEDepartment();
        cse.Setbookinfo("aurthor1","book1","publicher1","2001");
        cse.DisplayInfo();

        EEEDepartment eee = new EEEDepartment();
        eee.Setbookinfo("aurthor1","book1","publicher1","2001");
        eee.DisplayInfo();
    }
}