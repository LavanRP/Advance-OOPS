using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public class Menswear : Dress
    {
        public override Dresstype Dresstype { get; set; }
        public override string Dressname { get; set; }
        public override int Price { get; set; }
        public override int Totalprice { get; set; }
        public override void GetDressInfo(Dresstype dresstype, string dressname, int price)
        {
            Dresstype = dresstype;
            Dressname = dressname;
            Price = price;
        }
        public override void DisplayTheBill()
        {
            Console.WriteLine("-----your bill-----");
            int discount = (Price * 30) / 100;
            Totalprice = Price - discount;
            Console.WriteLine($"Your Dress type: {Dresstype}\nYour Dress name: {Dressname}\nYour Dress Price: {Price}\nYour Dress Total price: {Totalprice}");
        }
    }
}