using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    delegate void MyDelegate(string message);  
    internal class Program
    {
        static void ReceiveMes(string message)
        {
            Console.WriteLine("Receive: " + message);
        }

        static void SendMes(string message)
        {
            Console.WriteLine("Send: " + message);
        }
        static void Main(string[] args)
        {
            MyDelegate myDelegate = SendMes;
            myDelegate += ReceiveMes;

            myDelegate("This is my message");

            Console.ReadLine();
        }
    }
}
