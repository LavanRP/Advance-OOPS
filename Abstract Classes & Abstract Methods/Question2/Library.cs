using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2
{
    public abstract class Library
    {
        protected static int s_number = 1000;
        public string SerialNumber { get; set; }
        //AuthorName, BookName, PublisherName, Year
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract string Year { get; set; }

        public abstract void SetBookInfo(string authorName,string bookName,string publisherName,string year);
        public abstract void DisplayInfo();
    }
}