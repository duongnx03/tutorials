using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

namespace Demo3

{

    internal class Program

    {

        static void Main(string[] args)

        {
            Student student = new Student();
            student.setName("Nguyen Van A");
            student.SayHello();

            Console.ReadLine();
        }

    }

}