using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lap1
{
    internal class Book : library
    {
        private string title;
        private double price;
        public bool IsSale;

        public string Title
        {
            get { return title; }
            set
            {
                if (Regex.IsMatch(value, "^[a-zA-Z0-9 ]*$"))
                {
                    title = value;
                }
                else
                {
                    throw new Exception("Title only contains letters, digits and white space");
                }
            }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if(value < 0)
                {
                    throw new Exception("Price must be greater than zero");
                }
                else
                {
                    price = value;
                }
            }
        }
        public override void bookInfo()
        {
           Console.WriteLine("title: " + Title + ", price: " + Price 
                +", isSale: " + IsSale);
        }
    }
}
