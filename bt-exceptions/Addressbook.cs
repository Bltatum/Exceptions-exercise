using System.Collections.Generic;

namespace AddressBook
{
    class Addressbook
    {
        public Dictionary<string, Contact> addressbook = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            addressbook.Add(contact.Email, contact);
        }

         public Contact GetByEmail(string email)
        {
            return addressbook[email];
        }
    }

}