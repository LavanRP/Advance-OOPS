using System;
using Question1;
namespace Question;
public class Program
{
    public static void Main(string[] args)
    {
        Marksheet marksheet1 = new Marksheet("Lavan","Ramesh","1234567",new DateTime(2002,05,12),Gender.Male,new int[]{90,90,90,90,90,90},new int[]{90,90,90,90,90,90},new int[]{90,90,90,90,90,90},new int[]{90,90,90,90,90,90},DateTime.Now,90);
        Marksheet marksheet2 = new Marksheet("Kumar","Jhon","76543",new DateTime(2001,09,02),Gender.Male,new int[]{80,80,80,80,80,80},new int[]{90,90,90,90,90,90},new int[]{80,80,80,80,80,80},new int[]{80,80,80,80,80,80},DateTime.Now,80);

        marksheet1.SHowUGMarkSHeet();
        Console.WriteLine();
        marksheet2.SHowUGMarkSHeet();
    }
}