using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    public class Book : Library
    {
        private string title;
        private double price;
        private bool isSale;

        public string Title
        {
            get { return title; }
            set
            {
                // Check if the title contains only letters, digits, and white space
                if (value.All(char.IsLetterOrDigit) || value.All(char.IsWhiteSpace))
                {
                    title = value;
                }
                else
                {
                    throw new ArgumentException("Title can only contain letters, digits, and white space.");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                // Check if the price is greater than zero
                if (value > 0)
                {
                    price = value;
                }
                else
                {
                    throw new ArgumentException("Price must be greater than zero.");
                }
            }
        }

        public bool IsSale
        {
            get { return isSale; }
            set { isSale = value; }
        }

        public override void BookInfo()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Price: $" + Price);
            Console.WriteLine("On Sale: " + (IsSale ? "Yes" : "No"));
        }
    }
}

