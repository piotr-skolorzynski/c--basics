using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookConsoleApp
{
    internal class PhoneBook
    {
        public List<Contact> Contacts { get; set; }

        private void DisplayContactDetails(Contact contact)
        {
            Console.WriteLine($"Contact: {contact.Name}, {contact.Number}");
        }

        private void DisplayContactsDetails(List<Contact> contacts)
        {
            foreach (var contact in contacts)
            {
                DisplayContactDetails(contact);
            }
        }

        //functionlity to add every single contact for now without validation of created contact
        public void AddContact(Contact contact)
        {
            Contacts.Add(contact);
        }

        //functionality to show contact using given phone number
        public void DisplayContact(string number)
        {
            var selectedContact = Contacts.FirstOrDefault(c => c.Number == number);
            if(selectedContact != null)
            {
                DisplayContactDetails(selectedContact);
            }
            else
            {
                Console.WriteLine("Contact not found");
            }
        }

        //functionality to show all contacts
        public void DisplayAllContacts()
        {
            DisplayContactsDetails(Contacts);
        }

        //functionality to display contacts based on passed searchPhrase
        public void DisplayMatchingContacts(string searchPhrase)
        {
            var matchingContacts = Contacts.Where(c => c.Name.Contains(searchPhrase)).ToList();
            DisplayContactsDetails(matchingContacts);
        }
    }
}
