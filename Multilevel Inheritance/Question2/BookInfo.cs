using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class BookInfo : RackInfo
    {
        private static int s_number=300;
        public string BookID { get; set; }
        public string BookName { get; set; }
        public string AuthorName { get; set; }
        public int Price { get; set; }

        public BookInfo(string departmentName,string degree,int rackNumber,int columnNumber,string bookName,string authorName,int price):base(departmentName,degree,rackNumber,columnNumber)
        {
            BookID = "BID"+s_number;
            s_number++;

            BookName = bookName;
            AuthorName = authorName;
            Price = price;
        }

        public void  DisplayInfo()
        {
            Console.WriteLine($"DepartmentName: {DepartmentName}\nDegree: {Degree}\nRackNumber: {RackNumber}\nColumnNumber: {ColumnNumber}\nBookID {BookID}\nBookName: {BookName}\nAuthorName: {AuthorName}\nPrice: {Price}");
            Console.WriteLine();
        }
    }
}