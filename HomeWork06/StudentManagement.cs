using System;
using System.Collections.Generic;

namespace HomeWork06
{
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
    }
  
    
