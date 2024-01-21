using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    internal class Student
    {
        //auto property
        public int Id { get; set; }
        private int age;

        public int Age
        {
            get { return age; }
            set {
                if(value < 18)
                {
                    throw new Exception("age > 18");
                }
                else
                {
                    age = value;
                }              
            }
        }
    }
}
