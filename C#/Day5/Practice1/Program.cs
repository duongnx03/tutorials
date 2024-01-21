using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice1
{
    internal class Program
    {
        static void Noti(string message) 
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            //tao class Student(var: name, mark  -  method: input, ToString)

            //dung event de thong bao khi input thanh cong
            //dung event de thong bao khi nam va mark khong co gia tri de in ra

            //trong main:
            //tao 1 doi tuong Student, nhap lieu, in ra
            //tao 1 doi tuong Student khac, in ra;;

            Student student1 = new Student();
            student1.MyEvent += Noti;
            student1.input();
            Console.WriteLine(student1.ToString());

            Student student2 = new Student();
            student2.MyEvent += Noti;
            Console.WriteLine(student2.ToString());

            Console.ReadLine();
        }
    }
}
