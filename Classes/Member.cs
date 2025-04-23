using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystemSpace.Classes
{
    class Member
    {
        public int Id { get; private set; }
        public string Name { get; private set; } = string.Empty;
        public string Email { get; private set; } = string.Empty;
        public int PhoneNumber { get; private set; }

        public Member(int id, string name, string email, int phoneNumber) {
            Id = id;
            Name = name;
            Email = email;
            PhoneNumber = phoneNumber;
        }

    }
}
