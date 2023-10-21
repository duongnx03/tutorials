using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    delegate void MyDelegate(string message);
    internal class Program
    {
        static void function1(string s)
        {
            Console.WriteLine(s);
        }

        static void function2(string s)
        {
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = function1;
            myDelegate += function2;

            myDelegate("this is my message");

            Console.ReadLine();
        }
    }
}
