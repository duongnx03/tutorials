using System;
using System.Reflection.Emit;
using System.Xml.Linq;

namespace Project1
{
	public class Employee
	{
		private string name;
		private int salary;
		private string level;

		public Employee(string name, int salary, string level)
		{
			this.name = name;
			this.salary = salary;
			this.level = level;
		}

		public void input()
		{
            Console.WriteLine("Input Name: ");
            name = Console.ReadLine();
            Console.WriteLine("Input Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Level: ");
            level = Console.ReadLine();
        }
        public override string ToString()
        {
            return $"Name: {name}, Salary: {salary}, Level: {level}";
        }

		public int getSalary()
		{
			return salary;
		}
        public String getName()
        {
            return name;
        }
    }
}

