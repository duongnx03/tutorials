using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{
    public delegate void StudentAddedDelegate();
    public class StudentManager
    {
        public static List<string> StudentIds = new List<string>();
        private List<Student> students = new List<Student>();

        public void AddStudent(Student student)
        {
            students.Add(student);
            OnStudentAdded();
        }

        public void DisplayStudents()
        {
            Console.WriteLine("List of Students:");
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }

        private bool IsStudentIdMatch(string studentId, string input)
        {
            // So sánh StudentId với input
            return studentId.Equals(input, StringComparison.OrdinalIgnoreCase) ||
                   studentId.StartsWith(input, StringComparison.OrdinalIgnoreCase) ||
                   studentId.EndsWith(input, StringComparison.OrdinalIgnoreCase);
        }
        public void FindStudentById(string studentId)
        {
            Console.WriteLine("Students Found by ID:");

            foreach (Student student in students)
            {
                if (IsStudentIdMatch(student.StudentId, studentId))
                {
                    Console.WriteLine(student);
                }
            }
        }

        public void FindStudentsByName(string name)
        {
            Console.WriteLine("Students Found by Name:");
            foreach (Student student in students)
            {
                if (student.FullName.Contains(name, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(student);
                }
            }
        }

        protected virtual void OnStudentAdded()
        {
            StudentAddedEvent?.Invoke();
        }

        public delegate void StudentAddedDelegate();
        public event StudentAddedDelegate StudentAddedEvent;
    }

}

