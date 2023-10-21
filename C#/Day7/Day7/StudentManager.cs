using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    delegate void StudentAddedDelegate();
    internal class StudentManager
    {
        public event StudentAddedDelegate StudentAddedEvent;
        ArrayList students = new ArrayList();

        public void Add()
        {
            Student student = new Student();
            student.input();
            students.Add(student);
            StudentAddedDelegate studentAddedDelegate = StudentAddedEvent;
            if(studentAddedDelegate != null)
            {
                StudentAddedEvent();
            }
        }

        public void Show()
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student.ToString());
            }
        }

        public void SearchById()
        {
            Console.WriteLine("Input id to search: ");
            string id = Console.ReadLine();
            foreach (Student student in students)
            {
                if(student.StudentId == id)
                {
                    Console.WriteLine(student.ToString());
                }                
            }
        }

        public void SearchByName()
        {
            Console.WriteLine("Input name to search: ");
            string name = Console.ReadLine();
            foreach (Student student in students)
            {
                if (student.Fullname.Contains(name))
                {
                    Console.WriteLine(student.ToString());
                }
            }
        }
    }
}
