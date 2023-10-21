using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day7
{
    internal class Student
    {
        private string studentId;
        private string fullName;
        private int age;

        public string StudentId
        {
            get { return studentId; }
            set
            {
                if(Regex.IsMatch(value, "^s[0-9]{2}$"))
                {
                    studentId = value;
                }
                else
                {
                    throw new Exception("pls input in type sxx(x is number)");
                }
            }
        }

        public string Fullname
        {
            get { return fullName; }
            set 
            {  
                if(Regex.IsMatch(value,"^[0-9]{1,}$") || value.Length == 0)
                {
                    throw new Exception("can not blank or have number");
                }
                else
                {
                    fullName = value;
                }
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if(value >= 18 && value <= 90)
                {
                    age = value;
                }
                else
                {
                    throw new Exception("18 <= age <= 90");
                }
            }
        }

        public void input()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Input id: ");
                    StudentId = Console.ReadLine();
                    break;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Input fullname: ");
                    Fullname = Console.ReadLine();
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Input age: ");
                    Age = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public override string ToString()
        {
            return "id: " + StudentId + ", name: " + Fullname + ", age: " + Age;
        }
    }
}
