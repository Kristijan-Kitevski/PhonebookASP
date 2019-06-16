using PhoneBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneBook.Data
{
    public static class ContactsDatabase
    {
        public static List<Contact> MyContacts = new List<Contact>
        {
            new Contact()
            {
                FirstName = "Kristijan",
                LastName = "Kitevski",
                IsCloseFriend = true,
                PhoneNumber = 078282538
            },
            new Contact()
            {
                FirstName = "Pero",
                LastName = "Perov",
                IsCloseFriend = true,
                PhoneNumber = 078282538
            },
            new Contact()
            {
                FirstName = "Trajce",
                LastName = "Teajcev",
                IsCloseFriend = true,
                PhoneNumber = 078282538
            },
            new Contact()
            {
                FirstName = "Zumbula",
                LastName = "Karanfilova",
                IsCloseFriend = false,
                PhoneNumber = 078282538
            },
        };
    }
}
