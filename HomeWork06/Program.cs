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
    internal class Program
    {
        static void AddContact(string key,  int value, Dictionary<string, int> contact)
        {
            contact.Add(key, value);
        }
        static void ContactRemoval(string key, int value, Dictionary<string, int> contact)
        {
            contact.Remove(key);
        }
        static void ContactSearch(string key, int value, Dictionary<string, int> contact)
        {
            string keySearch = Console.ReadLine();
            if (key == keySearch)
            {
                Console.WriteLine($"{contact[keySearch]}");
            }
        }
        static void DisplayAllContacts(Dictionary<string, int> contacts)
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
        static void AddList(string student, List<string> list)
        {
            
           list.Add(student);
        }
        static void RemoveStudent(string student, List<string> list)
        {

            list.Remove(student);
        }
        static void ContainStudent(string student, List<string> list)
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
        static void StudentCount(List<string> list)
        {
            Console.WriteLine($"Student count: {list.Count}");
        }
        static void AddCustomer(string customer, Queue<string> queue)
        {
            queue.Enqueue(customer);
        }
        static void ServeCustomer( Queue<string> queue)
        {
            Console.WriteLine(queue.Dequeue());
        }
        static void CustomerCount(Queue<string> queue)
        {
            Console.WriteLine(queue.Count());
        }
        static void AddBook(Hashtable books)
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
        static void RemoveBook(Hashtable books)
        {
            string code = Console.ReadLine();
            books.Remove(code);
        }
        static void SearchBook(Hashtable books)
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
        static void DisplayAllBooks(Hashtable books)
        {
            Console.WriteLine(books.Count);
        }
            static void Main(string[] args)
        {
            Dictionary<string, int> contact = new Dictionary<string, int>();
            string key = Console.ReadLine();
            int value = Convert.ToInt32(Console.ReadLine());

            
            int task = Convert.ToInt32(Console.ReadLine());
            switch (task)
            {
                case 1:AddContact(key, value, contact);
                break;
                case 2:ContactRemoval(key, value, contact);
                break;
                case 3:ContactSearch(key, value, contact);
                break;
                case 4:DisplayAllContacts( contact);
                break;
                default: Console.WriteLine($"There is no such a task as {task}");
                            break;

            }
            string student = Console.ReadLine();
            List<string> students = new List<string>();

            int task1 = Convert.ToInt32(Console.ReadLine());

            switch (task1)
            {
                case 1: AddList(student, students);
                    break;
                case 2: RemoveStudent(student, students);
                    break;
                case 3: ContainStudent(student, students);
                    break;
                case 4: StudentCount(students);
                    break;
                default:
                    Console.WriteLine($"There is no such a task1 as {task}");
                    break;
            }
            string customer = Console.ReadLine();
            Queue<string> queue = new Queue<string>();
            int task2 = Convert.ToInt32(Console.ReadLine());
            switch (task2)
            {
                case 1: AddCustomer(customer, queue);
                    break;
                case 2: ServeCustomer(queue);
                    break;
                case 3: CustomerCount(queue);
                    break;
                default: Console.WriteLine($"There is no such task2 as {task2}");
                    break;

            
            }
            Hashtable books = new Hashtable();
            int task3 = Convert.ToInt32(Console.ReadLine());
            switch (task3)
            {
                case 1:
                    AddBook(books);
                    break;
                case 2:
                    RemoveBook(books);
                    break;
                case 3:
                    SearchBook(books);
                    break;
                case 4:
                    DisplayAllBooks(books);
                    break;
                default:
                    Console.WriteLine($"There is no such task3 as {task3}");
                    break;
            }
        }
        }
    }
  
    
