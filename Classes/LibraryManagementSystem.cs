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
            try
            {
                LibraryItems.Remove(item);
            } catch
            {
                Console.WriteLine("Item not found!");
            }
        }

        public void DeleteMember(Member member)
        {
            try
            {
                Members.Remove(member);
            } catch
            {
                Console.WriteLine("Member not found!");
            }
        }
    }
}
