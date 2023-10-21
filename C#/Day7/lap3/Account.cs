using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace lap3
{
    internal class Account
    {
        private string name;
        private int balance;

        public Account(string name, int balance)
        {
            this.name = name;
            this.balance = balance;
        }

        
        public int Deposit
        {
            get { return balance; }
            set
            {
                if(value < 100)
                {
                    Validate validate = new Validate();
                    validate.Print += Noti;
                    validate.check("Invalid amount for deposit");
                }
                else
                {
                    balance += value;
                }
            }
        }

        public int Withdraw
        {
            get { return balance; }
            set
            {
                if(value< 100 || value > balance)
                {
                    Validate validate = new Validate();
                    validate.Print += Noti;
                    validate.check("Invalid amount for withdraw");
                }
                else
                {
                    balance -= value;
                }
            }
        }

        public void Display()
        {
            Console.WriteLine("Name: " + name + ", balance:  " +  balance);
        }

        public void Noti(string s)
        {
            Console.WriteLine(s);
        }
    }
}
