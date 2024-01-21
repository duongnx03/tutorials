using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Project1

{

    internal class Program

    {

        static void Main(string[] args)

        {
            //tao class Employee voi cac bien name, salary, level
            //viet cac method: public void input, public string toString

            //tao class EmployeeManager voi cac bien size count list
            // viet cac method: Add Show FindMaxSalary, SearchByName

            // trong main viet menu voi 5 chuc nang
            //Add, Show, FindMaxSalary, SearchByName, Exit

            EmployeeManager em = new EmployeeManager();
            string option = "";
            while (option != "3")
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. FindMaxSalary");
                Console.WriteLine("4. SearchByName");
                Console.WriteLine("5. Exit");
                Console.WriteLine("Input your option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        em.Add();
                        break;
                    case "2":
                        em.Show();
                        break;
                    case "3":
                        em.FindMaxSalary();
                        break;
                    case "4":
                        em.SearchByName();
                        break;
                    case "5":
                        Console.WriteLine("Exit program.");
                        break;
                    default:
                        Console.WriteLine("Invalid option.");
                        break;


                }

            }
        }

    }

}