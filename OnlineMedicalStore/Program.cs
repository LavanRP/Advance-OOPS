using System;
namespace OnlineMedicalStore;
public class Program
{
    public static void Main(string[] args)
    {
        FileManagement.Create();
        //Operation.AddData();
        FileManagement.ReadFromCSV();
        Operation.MainMenu();
        FileManagement.WriteToCSV();
        
    }
}