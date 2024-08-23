using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    public class StudentManagement
    {
       private List<string> list = new List<string>();
        public void AddList(string student, List<string> list)
        {

            list.Add(student);
        }
        public void RemoveStudent(string student, List<string> list)
        {

            list.Remove(student);
        }
        public void ContainStudent(string student, List<string> list)
        {
            if (list.Contains(student))
            {
                Console.WriteLine($"There is student named{student}");
            }
            else
            {
                Console.WriteLine("There is no such a student");
            }
        }
        public void StudentCount(List<string> list)
        {
            Console.WriteLine($"Student count: {list.Count}");
        }
    }
    public class QueueManagement
    {
        private Queue<string> queue = new Queue<string>();
        public void AddCustomer(string customer, Queue<string> queue)
        {
            queue.Enqueue(customer);
        }
        public void ServeCustomer(Queue<string> queue)
        {
            Console.WriteLine(queue.Dequeue());
        }
        public void CustomerCount(Queue<string> queue)
        {
            Console.WriteLine(queue.Count());
        }
        
    }
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
    internal class Program
    {



        
        static void Main(string[] args)
        {
            var contactManager = new ContactManagement();
            Dictionary<string, int> contact = new Dictionary<string, int>();
            string key = Console.ReadLine();
            int value = Convert.ToInt32(Console.ReadLine());

            
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:contactManager.AddContact(key, value, contact);
                break;
                case 2:contactManager.ContactRemoval(key, value, contact);
                break;
                case 3:contactManager.ContactSearch(key, value, contact);
                break;
                case 4:contactManager.DisplayAllContacts( contact);
                break;
                default: Console.WriteLine($"There is no such a task as {task}");
                            break;

            }
            var studentManager = new StudentManagement();
            string student = Console.ReadLine();
            List<string> students = new List<string>();

            int task1 = Convert.ToInt32(Console.ReadLine());

            switch (task1)
            {
                case 1: studentManager.AddList(student, students);
                    break;
                case 2: studentManager.RemoveStudent(student, students);
                    break;
                case 3: studentManager.ContainStudent(student, students);
                    break;
                case 4: studentManager.StudentCount(students);
                    break;
                default:
                    Console.WriteLine($"There is no such a task1 as {task}");
                    break;
            }
            var queueManager = new QueueManagement();
            string customer = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int task2 = Convert.ToInt32(Console.ReadLine());
            switch (task2)
            {
                case 1: queueManager.AddCustomer(customer, queue);
                    break;
                case 2: queueManager.ServeCustomer(queue);
                    break;
                case 3: queueManager.CustomerCount(queue);
                    break;
                default: Console.WriteLine($"There is no such task2 as {task2}");
                    break;

            
            }
            var libraryManager = new LibraryManagement();
            Hashtable books = new Hashtable();
            int task3 = Convert.ToInt32(Console.ReadLine());
            switch (task3)
            {
                case 1:
                    libraryManager.AddBook(books);
                    break;
                case 2:
                    libraryManager.RemoveBook(books);
                    break;
                case 3:
                    libraryManager.SearchBook(books);
                    break;
                case 4:
                    libraryManager.DisplayAllBooks(books);
                    break;
                default:
                    Console.WriteLine($"There is no such task3 as {task3}");
                    break;
            }
        }
        }
    }
  
    
