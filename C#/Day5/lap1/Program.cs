using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap1
{
   
    internal class Program
    {
        static void Noti()
        {
            Console.WriteLine("EmptyList");
        }
        static void Main(string[] args)
        {
            BookManage bookManage = new BookManage();
            bookManage.MyEvent += Noti;
        }
    }
}
