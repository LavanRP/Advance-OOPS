using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question4
{
    public enum  Dresstype{Ladieswear,Menswear,Childrenswear}
    public abstract class Dress
    {
        //dresstype->Ladieswear, menswear, childrenswear, dressname, price, totalprice
        public abstract Dresstype Dresstype { get; set; }
        public abstract string Dressname { get; set; }
        public abstract int Price { get; set; }
        public abstract int Totalprice { get; set; }
        
        public abstract void GetDressInfo(Dresstype dresstype, string dressname,int price);
        public abstract void DisplayTheBill();
        
    }
}