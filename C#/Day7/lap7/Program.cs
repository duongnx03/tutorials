using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap7
{
    internal class Program
{

    private static void Noti(string message)
    {
        Console.WriteLine(message);
    }

    public delegate void StudentDelegate(string message);
        

    public static List<Student> StudentsList = new List<Student>();

    static void Main(string[] args)

    {
            Student.StudentEvent += Noti;

            while (true)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Create New");
            Console.WriteLine("2. Show All");
            Console.WriteLine("3. Exit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Student.AddStudent();
                        break;

                    case "2":
                        Student.FindAllStudents();
                        break;

                    case "3":
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