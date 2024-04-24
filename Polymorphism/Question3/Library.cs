using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question3
{
    public abstract class Library
    {
        //author name, book name, publishername, year
        private static int _serialNumber = 1000;
        public string SerialNumber 
        { 
            get
            {
                _serialNumber++;
                return "LIB"+_serialNumber;
            } 
        }
        public abstract string AuthorName { get; set; }
        public abstract string BookName { get; set; }
        public abstract string PublisherName { get; set; }
        public abstract string Year { get; set; }

        public abstract void Setbookinfo(string authorName,string bookName,string publisherName,string year);
        public abstract void DisplayInfo();
        
    }
}