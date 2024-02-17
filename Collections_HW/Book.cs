using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_HW
{
    public class Book
    {
        public string BookTitle { get;set; }

        public string Author { get;set; }

        public int YearOfPublication { get;set; }

        public Book(string bookTitle, string author, int yearOfPublication)
        {
            BookTitle = bookTitle;
            Author = author;
            YearOfPublication = yearOfPublication;
        }
    }
}
