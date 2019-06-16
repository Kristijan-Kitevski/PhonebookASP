using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PhoneBook.Data;
using PhoneBook.Models;

namespace PhoneBook.Controllers
{
    [Route("Contacts")]
    public class CoolController : Controller
    {

        [Route("get-all-contacts")]
        public IActionResult GetEveryone()
        {
            var AllContact = new ListOfContacts
            {
                MyContacts = ContactsDatabase.MyContacts
            };

            return View(AllContact);
        }

        [Route("get-closest-contacts")]
        public IActionResult GetFriends()
        {
            var AllContact = new ListOfContacts
            {
                MyContacts = ContactsDatabase.MyContacts
            };

            //var Friend = AllContact.MyContacts.Where(x => x.IsCloseFriend == true).ToList(); //frla eror nema vrednost friend
            return View(AllContact);
        }

        [HttpGet]
        public IActionResult AddContact()
        {
            return View(new Contact());
        }

        [HttpPost]
        public IActionResult AddContact(Contact MyContact)
        {
            ContactsDatabase.MyContacts.Add(MyContact);
            //nekoja logika sto vrakja eden kontakt od listata 
            return View(new Contact());
        }
    }
}