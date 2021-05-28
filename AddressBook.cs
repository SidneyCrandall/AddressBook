using System;

using System.Collections.Generic;

namespace AddressBook
{
    //1. Add the required classes to make the following code compile.
    //HINT: Use a Dictionary in the AddressBook class to store Contacts. The key should be the contact's email address.
    public class AddressBook
    {
        public Dictionary<string, Contact> Contacts = new Dictionary<string, Contact>();

        public void AddContact(Contact contact)
        {
            try
            {
                Contacts.Add(contact.Email, contact);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Contact has already been added.");
            }
        }
        public Contact GetByEmail(string emailIndex)
        {
            try
            {
                return Contacts[emailIndex];
            }
            catch (KeyNotFoundException)
            {
                Console.WriteLine($"That {emailIndex} could not be found.");
                return null;
            }
        }
    }
}

// Exception thrown that should be try/catch
/*Unhandled exception. System.ArgumentException: An item with the same key has already been added. Key: sue.jones@email.com
   at System.Collections.Generic.Dictionary`2.TryInsert(TKey key, TValue value, InsertionBehavior behavior)
   at System.Collections.Generic.Dictionary`2.Add(TKey key, TValue value)
   at AddressBook.AddressBook.AddContact(Contact contactPerson) in C:\Users\sdncr\workspace\csharp\AddressBook\AddressBook.cs:line 15
   at AddressBook.Program.Main(String[] args) in C:\Users\sdncr\workspace\csharp\AddressBook\Program.cs:line 52*/

// New Exception thrown with Email 
/*Unhandled exception. System.Collections.Generic.KeyNotFoundException: The given key 'not.in.addressbook@email.com' was not present in the dictionary.
   at System.Collections.Generic.Dictionary`2.get_Item(TKey key)
   at AddressBook.AddressBook.GetByEmail(String emailIndex) in C:\Users\sdncr\workspace\csharp\AddressBook\AddressBook.cs:line 26
   at AddressBook.Program.Main(String[] args) in C:\Users\sdncr\workspace\csharp\AddressBook\Program.cs:line 69*/