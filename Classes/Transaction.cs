using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    class Transaction
    {
        public int Id { get; private set; }
        public int MemberId { get; private set; }
        public int LibraryItemId { get; private set; }
        public DateTime BorrowDate { get; private set; } = DateTime.Now;
        public DateTime ReturnDate { get; private set; }

        public Transaction(int id, int memberId, int libraryItemId, DateTime returnDate) 
        {
            Id = id;
            MemberId = memberId;
            LibraryItemId = libraryItemId;
            ReturnDate = returnDate;
        }
    }
}
