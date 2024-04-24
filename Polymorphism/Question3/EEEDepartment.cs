using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public class EEEDepartment : Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override string Year { get; set; }

        public override void Setbookinfo(string authorName,string bookName,string publisherName,string year)
        {
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("-----EEE Department-----");
            Console.WriteLine("Book ID"+SerialNumber);
            Console.WriteLine("Book BookName"+BookName);
            Console.WriteLine("Book AuthorName"+AuthorName);
            Console.WriteLine("Book PublisherName"+PublisherName);
            Console.WriteLine("Book Year"+Year);
        }
    }
}