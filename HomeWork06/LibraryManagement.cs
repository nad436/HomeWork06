using System;
using System.Collections;

namespace HomeWork06
{
    public class LibraryManagement
    {
        private Hashtable books = new Hashtable();
         public void AddBook(Hashtable books)
        {
            string code = Console.ReadLine();

            if (books.ContainsKey(code))
            {
                Console.WriteLine("Book with this code is already exists");
                return;
            }

            string title = Console.ReadLine();

            books.Add(code, title);

        }
        public void RemoveBook(Hashtable books)
        {
            string code = Console.ReadLine();
            books.Remove(code);
        }
        public void SearchBook(Hashtable books)
        {
            string code = Console.ReadLine();
            if (books.ContainsKey(code))
            {
                Console.WriteLine($" {books[code]}");
            }
            else
            {
                Console.WriteLine("Book with this code doesn't exist");
            }
        }
        public void DisplayAllBooks(Hashtable books)
        {
            Console.WriteLine(books.Count);
        }
    }
    }
  
    
