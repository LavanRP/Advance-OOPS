using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public class CSEDepartment : Library
    {
        public override string AuthorName { get; set; }
        public override string BookName { get; set; }
        public override string PublisherName { get; set; }
        public override string Year { get; set; }

        public override void SetBookInfo(string authorName, string bookName, string publisherName, string year)
        {
            SerialNumber = "LIB" + s_number;
            s_number++;
            AuthorName = authorName;
            BookName = bookName;
            PublisherName = publisherName;
            Year = year;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine("-----CSE department------");
            Console.WriteLine($"Book Serial Number: {SerialNumber}\nBook Book Name: {BookName}\nBook Author Name: {AuthorName}\nBook Publisher Name: {PublisherName}\nBook Published Year: {Year}");
        }
    }
}