using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2

{

    internal class Program

    {

        static void Main(string[] args)

        {
            //create instance object
            Student student = new Student();
            StudentManager sm = new StudentManager();
            string option = "";
            while(option != "3")
            {
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Show");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Input your option: ");
                option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        sm.Add();
                        break;
                    case "2":
                        sm.Show();
                        break;
                    case "3":
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
