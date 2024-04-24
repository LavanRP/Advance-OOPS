using System;
namespace GroceryStore;
public class Program
{
    public static void Main(string[] args)
    {
        FileHandling.Create();
        FileHandling.ReadFromCSV();
        // Operation.AddDetails();
        Operation.MainMenu();
        FileHandling.WriteToCSV();
    }
}