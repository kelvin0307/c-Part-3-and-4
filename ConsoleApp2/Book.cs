using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public int PublicationYear { get; set; }

        public Book(string title, int pages, int publicationYear)
        {
            Title = title;
            Pages = pages;
            PublicationYear = publicationYear;
        }
    }
}
