using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    delegate void MyDelegate(string message);
    internal class Student
    {
        public event MyDelegate MyEvent;
        public string Name { get; set; }
        public int Mark { get; set; }

        public void input()
        {
            Console.WriteLine("Input name: ");
            Name = Console.ReadLine();
            Console.WriteLine("Input mark: ");
            Mark = int.Parse(Console.ReadLine());
            MyDelegate myDelegate = MyEvent;
            if(myDelegate != null)
            {
                MyEvent("Add Student successfully");
            }
        }

        public  override string ToString()
        {
            if(Name != null &&  Mark > 0)
            {
                return "name: " + Name + "mark: " + Mark;
               
            }
            else
            {
                MyDelegate myDelegate = MyEvent;
                if (myDelegate != null)
                {
                    MyEvent("Name or Mark is empty!");
                }
                return "";
            }
            
        }
    }
}
