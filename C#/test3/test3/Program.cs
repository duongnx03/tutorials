
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            Console.WriteLine("Input age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input isStudent: ");
            bool isStudent = Convert.ToBoolean(Console.ReadLine());
            Console.WriteLine("Input mark:");
            float mark = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Input weight: ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("name: " + name + ", age:" + age + ", isStudent: " + isStudent + ", mark:" + mark + ",weight:" + weight);

            Console.ReadLine();
        }
    }
}