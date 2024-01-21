using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lap5
{
    public delegate void ComputerDelegate(string message);

    public class ComputerManager
    {
        private SortedList<string, Computer> list = new SortedList<string, Computer>();
        public event ComputerDelegate ComputerEvent;


        public void AddNewComputer(Computer computer)
        {
            if (!list.ContainsKey(computer.Name))
            {
                list.Add(computer.Name, computer);
                ComputerEvent?.Invoke($"Added new successfully!");
            }
            else
            {
                ComputerEvent?.Invoke($"Computer with the same name already exists: {computer.Name}");
            }
        }

        public void ShowAll()
        {
            foreach(Computer computer in list.Values)
            {
                Console.WriteLine(computer.ToString());
            }
        }

        public void DeleteByName()
        {
            Console.WriteLine("Input name to delete: ");
            string dName = Console.ReadLine();
            foreach (Computer computer in list.Values)
            {
                if (computer.Name == dName)
                {
                    list.Remove(computer.Name);
                    ComputerDelegate computerDelegate = ComputerEvent;
                    if (computerDelegate != null)
                    {
                        ComputerEvent("delete computer successfully!");
                    }
                    break;
                }
            }
        }

        public void SearchByPrice()
        {
            //return list.Values.Where(c => c.GetPrice() >= min && c.GetPrice() <= max).ToList();


            Console.Write("Enter Min Price: ");
            float min = float.Parse(Console.ReadLine());

            Console.Write("Enter Max Price: ");
            float max = float.Parse(Console.ReadLine());
            foreach (Computer computer in list.Values)
            {
                if(computer.GetPrice() >= min && computer.GetPrice() <= max)
                {
                    Console.WriteLine(computer.ToString());

                }
            }
        }
    
    }
}

