using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDelegate
{
    //tao 1 delegate co kieu tra ve la void, co 1 tham so la string 
    //tao 2 function co kieu tra ve la void, co 1 tham so la string 
    //gan 2 function vao delegate
    //chay delegate
    delegate void MyDelegate();
    internal class Program
    {
        static void function1()
        {
            Console.WriteLine("This is function 1");
        }
        static void function2()
        {
            Console.WriteLine("This is function 2");
        }
        static void function3()
        {
            Console.WriteLine("This is function 3");
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = function1;
            myDelegate += function2;
            myDelegate += function3;

            //chay delegate
            myDelegate();

            myDelegate -= function2;


            //chay delegate
            Console.WriteLine();
            myDelegate();

            Console.ReadLine();
        }
    }
}
