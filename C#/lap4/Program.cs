using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap4
{

    internal class Program

    {
        static void Noti (string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)

        {
            ProductManager productManager = new ProductManager();
            productManager.ProductEvent += Noti;
            string option = "";
            while(option != "5")
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Delete by Id");
                Console.WriteLine("4. Search by name");
                Console.WriteLine("5. Exit");
                Console.WriteLine("");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        productManager.Add();
                        break;
                    case "2":
                        productManager.Show();
                        break;

                    case "3":
                        productManager.DeleteId();
                        break;

                    case "4":
                        productManager.SearchByName();
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

