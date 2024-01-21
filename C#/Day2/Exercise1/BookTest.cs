using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class BookTest
    {
        static void Main(string[] args)
        {
            BookManage bookManager = new BookManage();

            int choice;
            do
            {
                Console.WriteLine("\nMenu:");
                Console.WriteLine("1. Create new");
                Console.WriteLine("2. Find By isSale");
                Console.WriteLine("3. Find All");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                if (int.TryParse(Console.ReadLine(), out choice))
                {
                    switch (choice)
                    {
                        case 1:
                            bookManager.CreateBook();
                            break;

                        case 2:
                            bookManager.FindByIsSale();
                            break;

                        case 3:
                            Console.WriteLine("All Books:");
                            foreach (var book in bookManager)
                            {
                                book.BookInfo();
                            }
                            break;

                        case 4:
                            Console.WriteLine("Exiting the program.");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please enter a valid option.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            } while (choice != 4);
        }
    }
}

