using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    public abstract class LibraryItem
    {
        public string Title { get; protected set; } = string.Empty;
        public string Author { get; protected set; } = string.Empty;
        public string ISBN { get; protected set; } = string.Empty;
        public DateTime PublicationDate { get; protected set; }

        protected LibraryItem(string title, string author, string isbn, DateTime publicationDate)
        {
            Title = title;
            Author = author;
            ISBN = isbn;
            PublicationDate = publicationDate;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Author: {Author}");
            Console.WriteLine($"ISBN: {ISBN}");
            Console.WriteLine($"Publication Date: {PublicationDate}");
        }
    }
}