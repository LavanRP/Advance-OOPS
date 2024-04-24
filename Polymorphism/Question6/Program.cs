using System;
using Question6;
namespace Question;
public class Program
{
    public static void Main(string[] args)
    {
        HDFC hdfc = new HDFC();
        ICICI icici = new ICICI();
        IDBI idbi = new IDBI();
        SBI sbi = new SBI();
        Console.WriteLine(hdfc.GetIntresetInfo());
        Console.WriteLine(icici.GetIntresetInfo());
        Console.WriteLine(idbi.GetIntresetInfo());
        Console.WriteLine(sbi.GetIntresetInfo());
    }
}