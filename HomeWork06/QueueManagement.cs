using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWork06
{
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
    }
  
    
