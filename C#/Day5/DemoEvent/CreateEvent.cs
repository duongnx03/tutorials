using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    delegate void MyDelegate(string mes);
    internal class CreateEvent
    {
        //khai bao event kieu MyDelegate
        public event MyDelegate MyEvent;

        public void StartEvent()
        {
            Console.WriteLine("This start Event function");
            MyDelegate myDelegate = MyEvent;
            if (myDelegate != null)
            {
                MyEvent("This is my event");
            }
        }
    }
}
