using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    class Book: LibraryItem
    {
        public string Genre { get; private set; } = string.Empty;
        public string Publisher { get; private set; } = string.Empty;
        public int PageCount { get; private set; } = 0;

        public Book(string title, string author, string isbn, DateTime publicationDate, string genre, string publisher, int pageCount): base(title, author, isbn, publicationDate)
        {
            Genre = genre;
            Publisher = publisher;
            PageCount = pageCount;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Publisher: {Publisher}");
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
