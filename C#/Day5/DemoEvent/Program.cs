using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    internal class Program
    {
        static void EventRun(string mes)
        {
            Console.WriteLine(mes);
        }

        static void EventRun2(string mes)
        {
            Console.WriteLine("This is EventRun2");
        }
        static void Main(string[] args)
        {
            CreateEvent createEvent = new CreateEvent();
            //createEvent.MyEvent += EventRun;
            //.MyEvent += EventRun2;

            createEvent.StartEvent();

            Console.ReadLine();
        }
    }
}
