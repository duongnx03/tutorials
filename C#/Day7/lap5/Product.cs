using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lap5
{
	public abstract class Product
	{
		public string Name { get; set;}
        public int Price { get; set; }

        public virtual void Input()
        {

            Console.WriteLine("Input Name: ");
            Name = Console.ReadLine();

            while (true)
            {
                try
                {
                    Console.WriteLine("Input Price: ");
                    Price = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
		

        public abstract override string ToString();
    }
}

