using System;
using System.Collections;
using System.Collections.Generic;

namespace lap4
{
    internal class Product
	{
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public int UnitPrice { get; set; }

        

        public void PrintInfo()
        {
            Console.WriteLine("ProductId: " + ProductId + ", ProductName:  " + ProductName+ ", UnitPrice:" + UnitPrice);
        }

    }
}

