using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap3
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Account account = new Account("nguyen van a", 1000);
            
            string option = "";
            while (option != "4")
            {
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Input your option: ");
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Console.WriteLine("Input money: ");
                        int money = int.Parse(Console.ReadLine());
                        account.Deposit = money;
                        break;
                    case "2":
                        Console.WriteLine("Input money: ");
                        int money2 = int.Parse(Console.ReadLine());
                        account.Withdraw = money2;
                        break;
                    case "3":
                        account.Display();
                        break;
                    case "4":
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
