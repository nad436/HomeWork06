using Microsoft.SqlServer.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork06
{
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
  
    
