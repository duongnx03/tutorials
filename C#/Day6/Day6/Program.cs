using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{

    internal class Program

    {

        static void Main(string[] args)

        {
            StudentManager manager = new StudentManager();
            manager.StudentAddedEvent += () => Console.WriteLine("New student added!");

            while (true)
            {
                Console.WriteLine("Options:");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Display Students");
                Console.WriteLine("3. Find Student by ID");
                Console.WriteLine("4. Find Students by Name");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Student newStudent = new Student();
                        newStudent.Input();
                        manager.AddStudent(newStudent);
                        break;
                    case 2:
                        manager.DisplayStudents();
                        break;
                    case 3:
                        Console.Write("Enter Student ID to find: ");
                        string studentId = Console.ReadLine();
                        manager.FindStudentById(studentId);
                        break;
                    case 4:
                        Console.Write("Enter part of the Name to find: ");
                        string name = Console.ReadLine();
                        manager.FindStudentsByName(name);
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }
    }
}