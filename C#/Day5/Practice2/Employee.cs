using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    internal class Employee
    {
        private string name;
        private int workHour;

        public string Name { 
            get { return name; }
            set { 
                if (value.Length == 0) 
                {
                    throw new Exception("Name can not empty");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int WorkHour
        {
            get { return workHour; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("workHour > 0");
                }
                else
                {
                    workHour = value;
                }
            }
        }

        public int getSalary()
        {
            return workHour * 20;
        }
        
        public void input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input name: ");
                    Name = Console.ReadLine();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Input work hour: ");
                    WorkHour = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                }
            }
        }

        public void display()
        {
            Console.WriteLine("name: " + name + ", salary: " + getSalary());
        }
    }
}
