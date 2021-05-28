using System; 

using System.Collections.Generic;

namespace AddressBook
{
        //1. Add the required classes to make the following code compile.
        //HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
    public class AddressBook 
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contactPerson) 
        {
            Contacts.Add(contactPerson.Email, contactPerson); 
        }
        public Contact GetByEmail(string emailIndex)
        {
            return Contacts[emailIndex];  
                }
            }
        }