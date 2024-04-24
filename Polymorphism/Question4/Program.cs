using System;
namespace Question4;
public class Program
{
    public static void Main(string[] args)
    {
        FreeLancer freeLancer = new FreeLancer("Lavan","Ramesh",Gender.Male,"BE","developer",10);
        freeLancer.Display();
        Syncfusion syncfusion = new Syncfusion(freeLancer.Name,freeLancer.FatherName,freeLancer.Gender,freeLancer.Qualification,freeLancer.Role,freeLancer.NoOfWorkingDays,"Chennai");
        syncfusion.Display();
    }
}