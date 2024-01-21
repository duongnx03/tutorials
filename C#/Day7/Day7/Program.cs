using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7
{
    internal class Program
    {
        static void Noti()
        {
            Console.WriteLine("Student Added");
        }
        static void Main(string[] args)
        {
            StudentManager studentManager = new StudentManager();
            studentManager.StudentAddedEvent += Noti;

            string option = "";
            while(option != "5")
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Search by id");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Input your option: ");
                option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        studentManager.Add();
                        break;
                    case "2":
                        studentManager.Show();
                        break;
                    case "3":
                        studentManager.SearchById();
                        break;
                    case "4":
                        studentManager.SearchByName();
                        break;
                    case "5":
                        Console.WriteLine("Exit program!");
                        break;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;

                }
            }
        }
    }
}
