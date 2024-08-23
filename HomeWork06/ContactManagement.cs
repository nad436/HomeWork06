using System;
using System.Collections.Generic;

namespace HomeWork06
{
    public class ContactManagement
    {
        private Dictionary<string, int> contact = new Dictionary<string, int>();
        public void AddContact(string key, int value, Dictionary<string, int> contact)
        {
            contact.Add(key, value);
        }
        public void ContactRemoval(string key, int value, Dictionary<string, int> contact)
        {
            contact.Remove(key);
        }
        public void ContactSearch(string key, int value, Dictionary<string, int> contact)
        {
            string keySearch = Console.ReadLine();
            if (key == keySearch)
            {
                Console.WriteLine($"{contact[keySearch]}");
            }
        }
        public void DisplayAllContacts(Dictionary<string, int> contacts)
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("Contacts are empty");
            }
            else
            {
                Console.WriteLine("Список контактів:");
                foreach (KeyValuePair<string, int> con in contacts)
                {
                    {
                        Console.WriteLine($"{con.Key}: {con.Value}");
                    }
                }
            }
        }
    }
    }
  
    
