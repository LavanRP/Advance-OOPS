using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        EEEdepartment eEEdepartment = new EEEdepartment();
        eEEdepartment.SetBookInfo("Author1","book1","lavan","2020");
        eEEdepartment.DisplayInfo();
        Console.WriteLine();
        CSEDepartment cSEDepartment = new CSEDepartment();
        cSEDepartment.SetBookInfo("Author1","book2","kumar","2023");
        cSEDepartment.DisplayInfo();
    }
}