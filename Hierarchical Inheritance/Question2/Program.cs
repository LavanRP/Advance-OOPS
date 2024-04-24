using System;
namespace Question2;
public class Program
{
    public static void Main(string[] args)
    {
        PermanentEmployee permanent1 = new PermanentEmployee(1000,"Jan","permanent");
        PermanentEmployee permanent2 = new PermanentEmployee(1200,"May","permanent");
        permanent1.ShowSalary();
        Console.WriteLine();
        permanent2.ShowSalary();

        Console.WriteLine();
        TemporaryEmployee temporary1 = new TemporaryEmployee (1000,"jan","temporary");
        TemporaryEmployee temporary2 = new TemporaryEmployee (1200,"May","temporary");
        temporary1.ShowSalary();
        Console.WriteLine();
        temporary2.ShowSalary();
    }
}