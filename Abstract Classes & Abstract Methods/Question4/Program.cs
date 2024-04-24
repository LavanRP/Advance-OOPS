using System;
namespace Question4;
public class Program
{
    public static void Main(string[] args)
    {
        Ladieswear ladieswear = new Ladieswear();
        Menswear menswear = new Menswear();

        ladieswear.GetDressInfo(Dresstype.Ladieswear,"dress1",1000);
        ladieswear.DisplayTheBill();

        menswear.GetDressInfo(Dresstype.Menswear,"dress2",1000);
        menswear.DisplayTheBill();
    }
}