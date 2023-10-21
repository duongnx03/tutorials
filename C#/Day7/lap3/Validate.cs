using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap3
{
    public delegate void MyValid(string mes);
    internal class Validate
    {
        public event MyValid Print;
        public void checkValid(string s)
        {
            Console.WriteLine(s);
        }

        public void check(string s)
        {
            MyValid myValid = Print;
            if(myValid != null)
            {
                Print(s);
            }

        }


    }
}
