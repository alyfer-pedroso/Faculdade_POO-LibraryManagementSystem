using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    class Magazine: LibraryItem
    {
        public string Genre { get; private set; } = string.Empty;
        public string Publisher { get; private set; } = string.Empty;

        public Magazine(string title, string author, string isbn, DateTime publicationDate, string genre, string publisher) : base(title, author, isbn, publicationDate)
        {
            Genre = genre;
            Publisher = publisher;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Genre: {Genre}");
            Console.WriteLine($"Publisher: {Publisher}");
        }
    }
}
