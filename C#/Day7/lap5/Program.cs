using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap5
{

    internal class Program

    {

        private static void Noti(string message)
        {
            Console.WriteLine(message);
        }

        static void Main(string[] args)

        {
            ComputerManager computerManager = new ComputerManager();
            computerManager.ComputerEvent += Noti;

            while (true)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Add New");
                Console.WriteLine("2. Show All");
                Console.WriteLine("3. Delete By Name");
                Console.WriteLine("4. Search By Price");
                Console.WriteLine("5. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Computer computer = new Computer();
                        computer.Input();
                        computerManager.AddNewComputer(computer);
                        break;

                    case "2":
                        computerManager.ShowAll();
                        
                        break;

                    case "3":
                        computerManager.DeleteByName();
                        break;

                    case "4":
                        computerManager.SearchByPrice();
                        break;

                    case "5":
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