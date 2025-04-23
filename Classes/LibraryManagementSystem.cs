using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    class LibraryManagementSystem
    {
        public List<LibraryItem> LibraryItems { get; private set; } = [];
        public List<Member> Members { get; private set; } = [];
        public List<Transaction> Transactions { get; private set; } = [];

        public void AddLibraryItem(LibraryItem item)
        {
            LibraryItems.Add(item);
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
        }

        public void DeleteLibraryItem(LibraryItem item)
        {
            if (LibraryItems.Count > 0 && LibraryItems.Contains(item))
            {
                LibraryItems.Remove(item);
                return;
            }
            Console.WriteLine("Library item not found!");
        }

        public void DeleteMember(Member member)
        {
            if (Members.Count > 0 && Members.Contains(member))
            {
                Members.Remove(member);
                return;
            }
            Console.WriteLine("Member not found!");
        }
    }
}
